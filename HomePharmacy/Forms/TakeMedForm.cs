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
    public partial class TakeMedForm : Form
    {
        public MedicinesUsage MedicinesUsage { get; private set; }
        private MedicinesUsage init_usage;

        private List<Illness> illnesses;
        private List<Medicine> medicines;

        private DataTable table_illnesses;
        private DataTable table_medicines;

        private ActionType current_action;

        private bool DbOperation;

        public TakeMedForm()
        {
            InitializeComponent();
            this.InitMaxValues();
            this.InitDataTables();

            this.DbOperation = false;
        }

        #region GUI Initialization

        private void InitMaxValues()
        {
            this.nm_count.Maximum = Int32.MaxValue;
            this.dateUseCalendar.MaxDate = DateTime.Today;
        }

        private void InitDataTables()
        {
            // illnesses
            this.table_illnesses = new DataTable();

            this.table_illnesses.Columns.Add(new DataColumn("Id", typeof(int)));
            this.table_illnesses.Columns.Add(new DataColumn("Illed person", typeof(string)));
            this.table_illnesses.Columns.Add(new DataColumn("Diagnose", typeof(string)));
            this.table_illnesses.Columns.Add(new DataColumn("Start date", typeof(string)));
            this.table_illnesses.Columns.Add(new DataColumn("End date", typeof(string)));

            this.dgv_illnesses.DataSource = this.table_illnesses;

            // medicines
            this.table_medicines = new DataTable();
            this.table_medicines.Columns.Add(new DataColumn("Id", typeof(int)));
            this.table_medicines.Columns.Add(new DataColumn("Name", typeof(string)));
            this.table_medicines.Columns.Add(new DataColumn("Type", typeof(string)));
            this.table_medicines.Columns.Add(new DataColumn("Expiary date", typeof(string)));
            this.table_medicines.Columns.Add(new DataColumn("Price", typeof(decimal)));
            this.table_medicines.Columns.Add(new DataColumn("Remainings", typeof(int)));
            this.table_medicines.Columns.Add(new DataColumn("Count", typeof(int)));
            this.table_medicines.Columns.Add(new DataColumn("Exemplears count", typeof(int)));

            this.dgv_medicines.DataSource = this.table_medicines;
        }

        private void InitDataGridViews()
        {
            this.table_illnesses.Rows.Clear();
            this.table_medicines.Rows.Clear();

            this.illnesses.ForEach(x => this.AddIllness(x));
            this.medicines.ForEach(x => this.AddMedicine(x));

            if (this.current_action != ActionType.ADD)
            {
                var ill_row = this.dgv_illnesses.Rows.Cast<DataGridViewRow>().ToList().Where(x => (int)x.Cells["Id"].Value == this.init_usage.IdIllness).First();
                var med_row = this.dgv_medicines.Rows.Cast<DataGridViewRow>().ToList().Where(x => (int)x.Cells["Id"].Value == this.init_usage.IdMedicine).First();

                ill_row.Selected = true;
                med_row.Selected = true;

                this.Controls.OfType<DataGridView>().ToList().ForEach(x => x.Enabled = false);
            }
            else this.Controls.OfType<DataGridView>().ToList().ForEach(x => x.Enabled = true);
        }

        private void InitUsageResults(bool action_enable)
        {
            this.cb_result.Items.Clear();
            this.cb_result.Items.AddRange(DBValidation.MedUsageValidation.results);

            if (this.current_action == ActionType.ADD) this.cb_result.PhText = this.cb_result.Placeholder;
            else this.cb_result.PhText = this.init_usage.UsageResult;

            this.cb_result.Enabled = action_enable;
        }

        private void InitCount(bool action_enable)
        {
            if (this.current_action == ActionType.ADD) this.nm_count.Value = this.nm_count.Minimum;
            else
            {
                this.nm_count.Value = this.init_usage.CountOrAmount;
                this.InitAvaiableCount();
            }

            this.nm_count.Enabled = action_enable;
        }

        private void InitAvaiableCount()
        {
            Medicine? medicine = this.GetSelectedMedicine();
            if (medicine != null) this.lb_av_count.Text = $"Avaiable count: {medicine.Remainings}";
        }

        private void InitComment(bool read_only)
        {
            if (this.current_action == ActionType.ADD) this.tb_comment.Text = String.Empty;
            else this.tb_comment.Text = this.init_usage.Comment;

            this.tb_comment.ReadOnly = read_only;
        }

        private void InitDate(bool action_enable)
        {
            if (this.current_action == ActionType.ADD) this.dateUseCalendar.SetDate(DateTime.Today);
            else this.dateUseCalendar.SetDate(this.init_usage.UsageDate);

            this.dateUseCalendar.Enabled = action_enable;
        }

        private void InitButton(bool action_enable)
        {
            if (this.current_action == ActionType.ADD) this.btn_action.Caption = "Add medicine usage";
            else if (this.current_action == ActionType.UPDATE) this.btn_action.Caption = "Update medicine usage";
            else this.btn_action.Caption = "Information";

            this.btn_action.Enabled = action_enable;
        }

        private void AddIllness(Illness illness)
        {
            var row = this.table_illnesses.NewRow();

            row["Id"] = illness.IdIllness;
            row["Illed person"] = illness.IlledPerson;
            row["Diagnose"] = illness.Diagnoses;
            row["Start date"] = illness.StartDate.ToShortDateString();
            row["End date"] = illness.EndDate?.ToShortDateString();

            this.table_illnesses.Rows.Add(row);
        }

        private void AddMedicine(Medicine medicine)
        {
            var row = this.table_medicines.NewRow();

            row["Id"] = medicine.IdMedicine;
            row["Name"] = medicine.Name;
            row["Type"] = medicine.Type;
            row["Expiary date"] = medicine.ExpiryDate.ToShortDateString();
            row["Price"] = medicine.Price;
            row["Remainings"] = medicine.Remainings;
            row["Count"] = medicine.CountOrAmount;
            row["Exemplears count"] = medicine.ExemplearsCount;

            this.table_medicines.Rows.Add(row);
        }

        #endregion

        private void InitParams(ActionType action, List<Medicine> medicines, List<Illness> illnesses, MedicinesUsage? usage)
        {
            DialogResult = DialogResult.None;
            this.current_action = action;

            this.medicines = medicines;
            this.illnesses = illnesses;

            this.MedicinesUsage = new MedicinesUsage();
            if(usage != null)
            {
                this.MedicinesUsage.TrasnferDataFrom(usage);

                this.init_usage = new MedicinesUsage();
                this.init_usage.TrasnferDataFrom(usage);
            }
        }

        public void InitAction(ActionType action, List<Medicine> medicines, List<Illness> illnesses, MedicinesUsage? usage)
        {
            if (medicines != null && illnesses != null)
            {
                this.InitParams(action, medicines, illnesses, usage);

                // gui init
                bool action_enable = true;
                if (this.current_action == ActionType.INFORMATION) action_enable = false;

                this.InitDataGridViews();
                this.InitUsageResults(action_enable);
                this.InitCount(action_enable);
                this.InitComment(!action_enable);
                this.InitDate(action_enable);
                this.InitButton(action_enable);
            }
            else this.btn_action.Enabled = false;
        }

        private Illness? GetSelectedIllness()
        {
            if(this.dgv_illnesses.SelectedRows.Count == 1)
            {
                var row = this.dgv_illnesses.SelectedRows[0];
                int id = (int)row.Cells["Id"].Value;

                return this.illnesses.Where(x => x.IdIllness == id).First();
            }

            MessageBox.Show("There is no selected illness!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return null;
        }

        private Medicine? GetSelectedMedicine()
        {
            if(this.dgv_medicines.SelectedRows.Count == 1)
            {
                var row = this.dgv_medicines.SelectedRows[0];
                int id = (int)row.Cells["Id"].Value;

                return this.medicines.Where(x => x.IdMedicine == id).First();
            }

            MessageBox.Show("There is no selected medicine!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return null;
        }

        private bool InputToUsage()
        {
            Medicine? selected_medicine = this.GetSelectedMedicine();
            Illness? selected_illness = this.GetSelectedIllness();

            if(selected_medicine != null && selected_illness != null)
            {
                this.MedicinesUsage.IdMedicine = selected_medicine.IdMedicine;
                this.MedicinesUsage.IdIllness = selected_illness.IdIllness;
                this.MedicinesUsage.UsageDate = this.dateUseCalendar.SelectionRange.Start;
                this.MedicinesUsage.UsageResult = this.cb_result.PhText;
                this.MedicinesUsage.CountOrAmount = (int)this.nm_count.Value;
                this.MedicinesUsage.Comment = this.tb_comment.Text != String.Empty ? this.tb_comment.Text : null;

                return true;
            }

            return false;
        }

        private bool Validation()
        {
            Medicine? selected_medicine = this.GetSelectedMedicine();

            if (selected_medicine != null)
            {
                if (DBValidation.MedUsageValidation.Validation(this.current_action,selected_medicine, this.MedicinesUsage)) return true;
                else
                {
                    MessageBox.Show(DBValidation.ValidationErrorMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return false;
        }

        private async void AddUsage()
        {
            DialogResult result = DialogResult.None;

            this.DbOperation = true;

            await Task.Run(() => 
            {
                try
                {
                    using (HomePharmacyContext context = new HomePharmacyContext())
                    {
                        if(!context.MedicinesUsages.Any(x=>x.IdIllness == this.MedicinesUsage.IdIllness &&
                        x.IdMedicine == this.MedicinesUsage.IdMedicine && x.UsageDate == this.MedicinesUsage.UsageDate))
                        {
                            context.MedicinesUsages.Add(this.MedicinesUsage);

                            Medicine med = this.medicines.Where(x => x.IdMedicine == this.MedicinesUsage.IdMedicine).First();
                            med.Remainings -= this.MedicinesUsage.CountOrAmount;

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
                                    MessageBox.Show("There is already such medicine usage", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private async void UpdateUsage()
        {
            DialogResult result = DialogResult.None;

            this.DbOperation = true;

            await Task.Run(() => 
            {
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        bool update_exists = context.MedicinesUsages.Any(x => x.IdIllness == this.MedicinesUsage.IdIllness
                        && x.IdMedicine == this.MedicinesUsage.IdMedicine && x.UsageDate == this.MedicinesUsage.UsageDate); // search for the updated version

                        if (!update_exists) result = DialogResult.OK;
                        else
                        {
                            if (this.MedicinesUsage.IdIllness == this.init_usage.IdIllness && this.MedicinesUsage.IdMedicine == this.init_usage.IdMedicine
                            && this.MedicinesUsage.UsageDate == this.init_usage.UsageDate) result = DialogResult.OK;
                            else result = DialogResult.TryAgain;
                        }

                        // analyzing result

                        if(result == DialogResult.OK)
                        {
                            Medicine current = this.medicines.Where(x => x.IdMedicine == this.MedicinesUsage.IdMedicine).First();
                            current.Remainings += this.init_usage.CountOrAmount;
                            current.Remainings -= this.MedicinesUsage.CountOrAmount;

                            context.Update(current);
                            context.SaveChanges();

                            int rows = context.Database.ExecuteSql($"update MedicinesUsage set IdMedicine={this.MedicinesUsage.IdMedicine}, IdIllness={this.MedicinesUsage.IdIllness},UsageDate={this.MedicinesUsage.UsageDate},UsageResult={this.MedicinesUsage.UsageResult},CountOrAmount={this.MedicinesUsage.CountOrAmount},Comment={this.MedicinesUsage.Comment} where IdMedicine={this.init_usage.IdMedicine} and IdIllness={this.init_usage.IdIllness} and UsageDate={this.init_usage.UsageDate}");
                            if (rows != 1) throw new Exception("Exception with the update function!");
                        }
                        else
                        {
                            if (this.InvokeRequired)
                                this.Invoke(new MethodInvoker(delegate
                                {
                                    MessageBox.Show("There is already such medicine usage", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if(!this.DbOperation && this.InputToUsage() && this.Validation())
            {
                if (this.current_action == ActionType.ADD) this.AddUsage();
                else if (this.current_action == ActionType.UPDATE) this.UpdateUsage();
            }
        }

        private void dgv_medicines_SelectionChanged(object sender, EventArgs e)
        {
            if(this.dgv_medicines.SelectedRows.Count == 1) this.InitAvaiableCount();
        }
    }
}
