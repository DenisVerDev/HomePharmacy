using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePharmacy.Models;
using HomePharmacy.Controls;

namespace HomePharmacy.Forms
{
    public partial class MedicineForm : Form
    {
        public Medicine Medicine { get; private set; }

        private Person user;
        private Family? family;

        private ActionType current_action;

        private bool DbOperation;

        public MedicineForm()
        {
            InitializeComponent();
            this.InitMaxValues();

            this.DbOperation = false;
        }

        #region GUI Initialization
        private void InitMaxValues()
        {
            this.tb_name.MaxLength = DBValidation.MedicineValidation.name_maxsize;

            this.Controls.OfType<NumericUpDown>().ToList().ForEach(x => x.Maximum = Int32.MaxValue);

            this.dateExpCalendar.MaxDate = DateTime.MaxValue;
            this.datePurchaseCalendar.MaxDate = DateTime.Today;
        }

        private void InitName(bool read_only)
        {
            if(this.current_action == ActionType.ADD) this.tb_name.Text = String.Empty;
            else this.tb_name.Text = this.Medicine.Name;

            this.tb_name.ReadOnly = read_only;
        }

        private void InitForWhom(bool action_enable)
        {
            this.cb_forwhom.Items.Clear();

            if (this.family != null)
            {
                this.cb_forwhom.Items.AddRange(this.family.People.Select(x => x.Email).ToArray());

                if (this.Medicine.ForWhom != null) this.cb_forwhom.PhText = this.Medicine.ForWhom;
                else this.cb_forwhom.PhText = this.cb_forwhom.Placeholder;

                this.cb_forwhom.Enabled = action_enable;
            }
            else
            {
                this.cb_forwhom.PhText = this.user.Email;
                this.cb_forwhom.Enabled = false;
            }
        }

        private void InitType(bool action_enable)
        {
            this.cb_type.Items.Clear();
            this.cb_type.Items.AddRange(DBValidation.MedicineValidation.types);

            if (this.Medicine.Type != null) this.cb_type.PhText = this.Medicine.Type;
            else this.cb_type.PhText = this.cb_type.Placeholder;

            this.cb_type.Enabled = action_enable;
        }

        private void InitNumerics(bool action_enable)
        {
            if(this.current_action == ActionType.ADD)
            {
                this.Controls.OfType<NumericUpDown>().ToList().ForEach((x) => 
                {
                    x.Value = x.Minimum;
                    x.Enabled = true;
                });
            }
            else
            {
                this.nm_price.Value = this.Medicine.Price;
                this.nm_price.Enabled = action_enable;

                this.nm_count.Value = this.Medicine.CountOrAmount;
                this.nm_count.Enabled = false;
                this.nm_excount.Value = this.Medicine.ExemplearsCount;
                this.nm_excount.Enabled = false;
                this.nm_remainings.Value = this.Medicine.Remainings;
                this.nm_remainings.Enabled = false;
            }
        }

        private void InitDates(bool action_enable)
        {
            this.dateExpCalendar.Enabled = action_enable;
            this.datePurchaseCalendar.Enabled = action_enable;

            if (this.current_action == ActionType.ADD)
            {
                this.dateExpCalendar.SetDate(DateTime.Today);
                this.datePurchaseCalendar.SetDate(DateTime.Today);
            }
            else
            {
                this.dateExpCalendar.SetDate(this.Medicine.ExpiryDate);
                this.datePurchaseCalendar.SetDate(this.Medicine.PurchaseDate);
            }
        }

        private void InitButtons(bool action_enable)
        {
            this.btn_action.Enabled = action_enable;
            this.btn_remcount.Enabled = false;

            if (this.current_action == ActionType.ADD)
            {
                this.btn_action.Caption = "Add medicine";
                this.btn_remcount.Enabled = true;
            }
            else if (this.current_action == ActionType.UPDATE) this.btn_action.Caption = "Update medicine";
            else this.btn_action.Caption = "Information";
        }

        #endregion

        private void InitParams(ActionType action, Person user, Family? family, Medicine? medicine)
        {
            DialogResult = DialogResult.None;
            this.current_action = action;

            this.user = user;
            this.family = family;

            this.Medicine = new Medicine();
            if (medicine != null) this.Medicine.TransferDataFrom(medicine);
        }

        public void InitAction(ActionType action, Person user, Family? family, Medicine? medicine)
        {
            if (user != null)
            {
                this.InitParams(action, user, family, medicine);

                // gui init
                bool action_enable = true;
                if (this.current_action == ActionType.INFORMATION) action_enable = false;
               
                this.InitName(!action_enable);
                this.InitType(action_enable);
                this.InitForWhom(action_enable);
                this.InitNumerics(action_enable);
                this.InitDates(action_enable);
                this.InitButtons(action_enable);
            }
            else this.btn_action.Enabled = false;
        }

        private void InputToMedicine()
        {
            this.Medicine.Name = this.tb_name.Text;
            this.Medicine.Type = (string)this.cb_type.PhText;
            this.Medicine.ForWhom = this.cb_forwhom.PhText;
            this.Medicine.Price = this.nm_price.Value;
            this.Medicine.CountOrAmount = (int)this.nm_count.Value;
            this.Medicine.ExemplearsCount = (int)this.nm_excount.Value;
            this.Medicine.Remainings = (int)this.nm_remainings.Value;
            this.Medicine.ExpiryDate = this.dateExpCalendar.SelectionRange.Start;
            this.Medicine.PurchaseDate = this.datePurchaseCalendar.SelectionRange.Start;
            this.Medicine.BelongsToFamily = this.family != null ? this.family.IdFamily : null;
        }

        private bool Validation()
        {
            if(this.family != null && !this.family.People.Select(x=>x.Email).Contains(this.Medicine.ForWhom))
            {
                MessageBox.Show("There is no such person in your family!", "Validation warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(!DBValidation.MedicineValidation.Validate(this.Medicine))
            {
                MessageBox.Show(DBValidation.ValidationErrorMsg, "Validation warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void AddMedicine()
        {
            this.DbOperation = true;

            DialogResult result = DialogResult.None;

            await Task.Run(() => 
            {
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        context.Medicines.Add(this.Medicine);
                        context.SaveChanges();

                        result = DialogResult.OK;
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

            this.DialogResult = result;

            this.DbOperation = false;
        }

        private async void UpdateMedicine()
        {
            this.DbOperation = true;

            DialogResult result = DialogResult.None;

            await Task.Run(() => 
            { 
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        Medicine? med = context.Medicines.Where(x => x.IdMedicine == this.Medicine.IdMedicine).FirstOrDefault();

                        if (med != null)
                        {
                            med.TransferDataFrom(this.Medicine);

                            context.Update(med);
                            context.SaveChanges();

                            result = DialogResult.OK;
                        }
                        else
                        {
                            result = DialogResult.TryAgain;

                            if (this.InvokeRequired)
                                this.Invoke(new MethodInvoker(delegate
                                {
                                    MessageBox.Show("There is no such medicine", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.InputToMedicine();

            if (!this.DbOperation && this.Validation())
            {
                if (this.current_action == ActionType.ADD) this.AddMedicine();
                else this.UpdateMedicine();
            }
        }

        private void btn_remcount_PhClick(object sender, EventArgs e)
        {
            this.nm_remainings.Value = this.nm_count.Value * this.nm_excount.Value;
        }
    }
}
