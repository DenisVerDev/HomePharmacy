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

        public enum ActionType 
        {
            ADD,
            UPDATE,
            INFORMATION
        }

        private ActionType current_action;

        public IllnessForm()
        {
            InitializeComponent();
            this.dateStartCalendar.MaxDate = DateTime.Today;
            this.dateEndCalendar.MaxDate = DateTime.Today;
        }

        #region Interface init
        private void GuiInit(string[] people)
        {
            // cb_email init
            this.cb_email.Items.Clear();

            if (people.Length == 1)
            {
                this.cb_email.PhText = people[0];
                this.cb_email.Enabled = false;
            }
            else
            {
                this.cb_email.PhText = this.cb_email.Placeholder;
                this.cb_email.Enabled = true;
                this.cb_email.Items.AddRange(people);
            }

            // init other things
            switch(this.current_action)
            {
                case ActionType.ADD:
                    // tb_diagnose init
                    this.tb_diagnose.Text = "Diagnoses";
                    this.tb_diagnose.ReadOnly = false;
                    // start date calendar init
                    this.dateStartCalendar.SetDate(DateTime.Today);
                    this.DateStartCalendarEnable(true);
                    // end date calendar init
                    this.dateEndCalendar.SetDate(DateTime.Today);
                    this.chb_enddate.Checked = false;
                    this.chb_enddate.Enabled = true;
                    // action button init
                    this.btn_action.Caption = "Add illness";
                    this.btn_action.Enabled = true;
                    break;

                case ActionType.UPDATE:
                    // tb_diagnose init
                    this.tb_diagnose.Text = this.Illness.Diagnoses;
                    this.tb_diagnose.ReadOnly = false;
                    // start date calendar init
                    this.dateStartCalendar.SetDate(this.Illness.StartDate);
                    this.DateStartCalendarEnable(true);
                    // end date calendar init
                    this.chb_enddate.Checked = (this.Illness.EndDate != null);
                    if (this.chb_enddate.Checked) this.dateEndCalendar.SetDate((DateTime)this.Illness.EndDate);
                    else this.dateEndCalendar.SetDate(DateTime.Today);
                    this.chb_enddate.Enabled = true;
                    // action button init
                    this.btn_action.Caption = "Update illness";
                    this.btn_action.Enabled = true;
                    break;

                case ActionType.INFORMATION:
                    // tb_diagnose init
                    this.tb_diagnose.Text = this.Illness.Diagnoses;
                    this.tb_diagnose.ReadOnly = true;
                    // start date calendar init
                    this.dateStartCalendar.SetDate(this.Illness.StartDate);
                    this.DateStartCalendarEnable(false);
                    // end date calendar init
                    if (this.Illness.EndDate != null) this.dateEndCalendar.SetDate((DateTime)this.Illness.EndDate);
                    else this.dateEndCalendar.SetDate(DateTime.Today);
                    this.chb_enddate.Checked = false;
                    this.chb_enddate.Enabled = false;
                    // action button init
                    this.btn_action.Caption = "Information";
                    this.btn_action.Enabled = false;
                    break;
            }

        }

        private void DateStartCalendarEnable(bool enable)
        {
            this.lb_startdate.Enabled = enable;
            this.rb_startdate.Enabled = enable;
            this.dateStartCalendar.Enabled = enable;
        }

        public void InitAdd(string[] people)
        {
            DialogResult = DialogResult.None;
            this.current_action = ActionType.ADD;

            if (people != null && people.Length > 0) this.GuiInit(people);
            else this.btn_action.Enabled = false;
        }

        public void InitUpdate(Illness illness)
        {
            DialogResult = DialogResult.None;
            this.current_action = ActionType.UPDATE;

            if (illness != null)
            {
                this.Illness = illness;
                this.GuiInit(new string[1] { this.Illness.IlledPerson });
            }
            else this.btn_action.Enabled = false;
        }

        public void InitInformation(Illness illness)
        {
            DialogResult = DialogResult.None;
            this.current_action = ActionType.INFORMATION;

            if (illness != null)
            {
                this.Illness = illness;
                this.GuiInit(new string[1] { this.Illness.IlledPerson });
            }
            else this.btn_action.Enabled = false;
        }
        #endregion

        private bool DataValidation(string email, string diagnose, DateTime start, DateTime? end)
        {
            if(!DBValidation.PersonValidation.EmailValidation(email) || !DBValidation.IllnessValidation.DiagnoseValidation(diagnose) 
                || !DBValidation.IllnessValidation.DateValidation(start, end))
            {
                MessageBox.Show(DBValidation.ValidationErrorMsg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void CreateIllness(string email, string diagnose, DateTime start, DateTime? end)
        {
            DialogResult result = DialogResult.None;

            this.Illness = new Illness()
            {
                IlledPerson = email,
                Diagnoses = diagnose,
                StartDate = start,
                EndDate = end
            };

            await Task.Run(() => 
            {
                try
                {
                    using (HomePharmacyContext context = new HomePharmacyContext())
                    {
                        if (!context.Illnesses.Any(x => x.IlledPerson == Illness.IlledPerson && x.Diagnoses == Illness.Diagnoses && x.StartDate == Illness.StartDate))
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
            else this.Illness = null;
        }

        private async void UpdateIllness(string email, string diagnose, DateTime start, DateTime? end)
        {
            DialogResult result = DialogResult.None;

            await Task.Run(() => 
            { 
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        if (!context.Illnesses.Any(x => x.IlledPerson == email && x.Diagnoses == diagnose && x.StartDate == start)) // check for the updated|same version
                        {
                            // ef core cant update primary keys, so i have to do it in a raw way
                            int rows = context.Database.ExecuteSql($"update Illnesses set Diagnoses={diagnose},StartDate={start},EndDate={end} where IdIllness = {this.Illness.IdIllness}");

                            if (rows == 1)
                            {
                                this.Illness.Diagnoses = diagnose;
                                this.Illness.StartDate = start;
                                this.Illness.EndDate = end;
                                result = DialogResult.OK;
                            }
                            else throw new Exception("Exception with the update function!");
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
            else this.Illness = null;
        }

        private void chb_enddate_CheckedChanged(object sender, EventArgs e)
        {
            // false means EndDate is null or not for changing
            this.lb_enddate.Enabled = this.chb_enddate.Checked;
            this.dateEndCalendar.Enabled = this.chb_enddate.Checked;
            this.rb_enddate.Enabled = this.chb_enddate.Checked;
        }

        private void btn_action_PhClick(object sender, EventArgs e)
        {
            string email = this.cb_email.PhText;
            string diagnose = this.tb_diagnose.Text;
            DateTime start = this.dateStartCalendar.SelectionRange.Start;
            DateTime? end = this.chb_enddate.Checked ? this.dateEndCalendar.SelectionRange.Start : null;

            if (this.DataValidation(email, diagnose, start, end))
            {
                if (this.current_action == ActionType.ADD) this.CreateIllness(email, diagnose, start, end);
                else if(this.current_action == ActionType.UPDATE) this.UpdateIllness(email, diagnose, start, end);
            }
        }
    }
}
