using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using HomePharmacy.Models;

namespace HomePharmacy.Forms
{
    public partial class IllnessForm : Form
    {
        public Illness Illness { get; private set; }
        private Illness init_ill;

        private Person user;
        private Family? family;

        private ActionType current_action;

        private bool DbOperation;

        public IllnessForm()
        {
            InitializeComponent();
            this.InitMaxValues();

            this.DbOperation = false;
        }

        #region GUI Initialization

        private void InitMaxValues()
        {
            this.dateStartCalendar.MaxDate = DateTime.Today;
            this.dateEndCalendar.MaxDate = DateTime.Today;
            this.tb_diagnose.MaxLength = DBValidation.IllnessValidation.diagnosis_maxsize;
        }

        private void InitEmail(bool action_enable)
        {
            this.cb_email.Items.Clear();

            if(this.family != null)
            {
                this.cb_email.Items.AddRange(this.family.People.Select(x => x.Email).ToArray());

                if (this.init_ill.IlledPerson != null) this.cb_email.PhText = this.init_ill.IlledPerson;
                else this.cb_email.PhText = this.cb_email.Placeholder;

                this.cb_email.Enabled = action_enable;
            }
            else
            {
                this.cb_email.PhText = this.user.Email;
                this.cb_email.Enabled = false;
            }
        }

        private void InitTextBox(bool read_only)
        {
            if(this.current_action == ActionType.ADD)
            {
                this.tb_diagnose.Text = String.Empty;
                this.tb_diagnose.ReadOnly = false;
            }
            else
            {
                this.tb_diagnose.Text = this.init_ill.Diagnosis;
                this.tb_diagnose.ReadOnly = read_only;
            }
        }

        private void InitDates(bool action_enable)
        {
            this.dateStartCalendar.Enabled = action_enable;
            this.dateEndCalendar.Enabled = action_enable;
            this.chb_enddate.Enabled = action_enable;

            if(this.current_action == ActionType.ADD)
            {
                this.dateStartCalendar.SetDate(DateTime.Today);
                this.dateEndCalendar.SetDate(DateTime.Today);

                this.chb_enddate.Checked = false;
            }
            else
            {
                this.dateStartCalendar.SetDate(this.init_ill.StartDate);

                this.chb_enddate.Checked = (this.init_ill.EndDate != null);
                if (this.chb_enddate.Checked) this.dateEndCalendar.SetDate((DateTime)this.init_ill.EndDate);
                else this.dateEndCalendar.SetDate(DateTime.Today);
            }
        }

        private void InitButton(bool action_enable)
        {
            if (this.current_action == ActionType.ADD) this.btn_action.Caption = "Add illness";
            else if (this.current_action == ActionType.UPDATE) this.btn_action.Caption = "Update illness";
            else this.btn_action.Caption = "Information";

            this.btn_action.Enabled = action_enable;
        }

        #endregion

        private void InitParams(ActionType action, Person user, Family? family, Illness? illness)
        {
            DialogResult = DialogResult.None;
            this.current_action = action;

            this.user = user;
            this.family = family;

            this.Illness = new Illness();

            if (illness != null)
            {
                this.Illness.TransferDataFrom(illness);

                this.init_ill = new Illness();
                this.init_ill.TransferDataFrom(illness);
            }
        }

        public void InitAction(ActionType action, Person user, Family? family, Illness? illness)
        {
            if (user != null)
            {
                this.InitParams(action, user, family, illness);

                // gui init
                bool action_enable = true;
                if (this.current_action == ActionType.INFORMATION) action_enable = false;

                this.InitEmail(action_enable);
                this.InitTextBox(!action_enable);
                this.InitDates(action_enable);
                this.InitButton(action_enable);
            }
            else this.btn_action.Enabled = false;
        }

        private void InputToIllness()
        {
            this.Illness.IlledPerson = this.cb_email.PhText;
            this.Illness.Diagnosis = this.tb_diagnose.Text;
            this.Illness.StartDate = this.dateStartCalendar.SelectionRange.Start;
            this.Illness.EndDate = this.chb_enddate.Checked ? this.dateEndCalendar.SelectionRange.Start : null;
        }

        private bool Validation()
        {
            if (this.family != null && !this.family.People.Select(x => x.Email).Contains(this.Illness.IlledPerson))
            {
                MessageBox.Show("There is no such person in your family!", "Validation warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!DBValidation.IllnessValidation.Validate(this.Illness))
            {
                MessageBox.Show(DBValidation.ValidationErrorMsg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void AddIllness()
        {
            this.DbOperation = true;

            DialogResult result = DialogResult.None;

            await Task.Run(() => 
            {
                try
                {
                    using (HomePharmacyContext context = new HomePharmacyContext())
                    {
                        if (!context.Illnesses.Any(x => x.IlledPerson == this.Illness.IlledPerson 
                        && x.Diagnosis == this.Illness.Diagnosis && x.StartDate == this.Illness.StartDate))
                        {
                            context.Illnesses.Add(this.Illness);
                            context.SaveChanges();

                            result = DialogResult.OK;
                        }
                        else
                        {
                            result = DialogResult.TryAgain;

                            if (this.InvokeRequired)
                                this.Invoke(new MethodInvoker(delegate
                                {
                                    MessageBox.Show("There is already such illness", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }));
                        }
                    }
                }
                catch(Exception ex)
                {
                    result = DialogResult.Abort;

                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate 
                        {
                            MessageBox.Show(ex.ToString(), "Database exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                }
            });

            // exit if everything was good or exception
            if (result == DialogResult.OK || result == DialogResult.Abort) this.DialogResult = result;

            this.DbOperation = false;
        }

        private async void UpdateIllness()
        {
            this.DbOperation = true;

            DialogResult result = DialogResult.None;

            await Task.Run(() => 
            { 
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        bool update_exists = context.Illnesses.Any(x=>x.IlledPerson == this.Illness.IlledPerson &&
                        x.Diagnosis == this.Illness.Diagnosis && x.StartDate == this.Illness.StartDate);

                        if(!update_exists) result = DialogResult.OK; // we dont have updated illness
                        else // we have the same illness but we dont know if its the old one(the new values are the same as the old ones)
                        {
                            if (this.Illness.IlledPerson == this.init_ill.IlledPerson && this.Illness.Diagnosis == this.init_ill.Diagnosis
                            && this.Illness.StartDate == this.init_ill.StartDate) result = DialogResult.OK;
                            else result = DialogResult.TryAgain;
                        }

                        // processing and analyzing result
                        if (result == DialogResult.OK)
                        {
                            int rows = context.Database.ExecuteSql($"update Illnesses set IlledPerson={this.Illness.IlledPerson}, Diagnosis={this.Illness.Diagnosis},StartDate={this.Illness.StartDate},EndDate={this.Illness.EndDate} where IdIllness = {this.Illness.IdIllness}");
                            if (rows != 1) throw new Exception("Exception with the update function!");
                        }
                        else
                        {
                            if (this.InvokeRequired)
                                this.Invoke(new MethodInvoker(delegate
                                {
                                    MessageBox.Show("There is already such illness", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }));
                        }
                    }
                }
                catch(Exception ex)
                {
                    result = DialogResult.Abort;

                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                        {
                            MessageBox.Show(ex.ToString(), "Database exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                }
            });

            // exit if everything was good or exception
            if (result == DialogResult.OK || result == DialogResult.Abort) this.DialogResult = result;

            this.DbOperation = false;
        }

        private void btn_action_PhClick(object sender, EventArgs e)
        {
            this.InputToIllness();

            if (!this.DbOperation && this.Validation())
            {
                if (this.current_action == ActionType.ADD) this.AddIllness();
                else if(this.current_action == ActionType.UPDATE) this.UpdateIllness();
            }
        }
    }
}
