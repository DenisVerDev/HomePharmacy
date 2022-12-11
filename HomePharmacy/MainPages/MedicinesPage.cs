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
using HomePharmacy.Forms;

namespace HomePharmacy.MainPages
{
    public partial class MedicinesPage : PhPage
    {
        private Person user;
        private Family? family;
        private List<Medicine> medicines;
        private List<MedicinesUsage> medicinesUsages;

        private DataTable table;

        private MedicineForm form;

        public MedicinesPage()
        {
            InitializeComponent();
            this.InitDataTable();

            this.form = new MedicineForm();
        }

        private void InitDataTable()
        {
            this.table = new DataTable();
            this.table.Columns.Add(new DataColumn("Id",typeof(int)));
            this.table.Columns.Add(new DataColumn("Name", typeof(string)));
            this.table.Columns.Add(new DataColumn("Type", typeof(string)));
            this.table.Columns.Add(new DataColumn("Expiary date", typeof(string)));
            this.table.Columns.Add(new DataColumn("Buy date", typeof(string)));
            this.table.Columns.Add(new DataColumn("Price", typeof(decimal)));
            this.table.Columns.Add(new DataColumn("Remainings", typeof(int)));
            this.table.Columns.Add(new DataColumn("Count", typeof(int)));
            this.table.Columns.Add(new DataColumn("Exemplears count", typeof(int)));
            this.table.Columns.Add(new DataColumn("ForWhom", typeof(string)));

            this.dgv_medicines.DataSource = this.table;
        }

        private void UpdateDataGridView(List<Medicine> medicines)
        {
            this.table.Rows.Clear();

            foreach (Medicine medicine in medicines)
            {
                var row = this.table.NewRow();

                row["Id"] = medicine.IdMedicine;
                row["Name"] = medicine.Name;
                row["Type"] = medicine.Type;
                row["Expiary date"] = medicine.ExpiryDate.ToShortDateString();
                row["Buy date"] = medicine.PurchaseDate;
                row["Price"] = medicine.Price;
                row["Remainings"] = medicine.Remainings;
                row["Count"] = medicine.CountOrAmount;
                row["Exemplears count"] = medicine.ExemplearsCount;
                row["ForWhom"] = medicine.ForWhom;

                this.table.Rows.Add(row);
            }
        }

        public override void ClearInput()
        {
            this.cb_type.PhText = this.cb_type.Placeholder;

            this.chb_expired.Checked = false;
            this.chb_used.Checked = false;
        }

        public override void ClearDataUI()
        {
            this.table.Rows.Clear();
            this.cb_type.Items.Clear();

            this.ClearInput();
        }

        public override void LoadDataUI()
        {
            this.cb_type.Items.Add("All");
            this.cb_type.Items.AddRange(DBValidation.MedicineValidation.types);

            this.UpdateDataGridView(this.medicines);
        }

        private Medicine? GetSelectedMedicine()
        {
            if (this.dgv_medicines.SelectedRows.Count == 1)
            {
                var selected_row = this.dgv_medicines.SelectedRows[0];
                int id_medicine = (int)selected_row.Cells["Id"].Value;

                return this.medicines.Where(x => x.IdMedicine == id_medicine).FirstOrDefault();
            }

            MessageBox.Show("There are no selected rows", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return null;
        }

        private void btn_add_PhClick(object sender, EventArgs e)
        {
            this.form.InitAction(ActionType.ADD, user, family, null);
            if (this.form.ShowDialog() == DialogResult.OK)
            {
                this.medicines.Add(this.form.Medicine);

                this.ClearInput();
                this.UpdateDataGridView(this.medicines);
            }
        }

        private void btn_update_PhClick(object sender, EventArgs e)
        {
            Medicine? selected = this.GetSelectedMedicine();

            if (selected != null)
            {
                this.form.InitAction(ActionType.UPDATE, user, family, selected);
                if (this.form.ShowDialog() == DialogResult.OK)
                {
                    selected.TransferDataFrom(this.form.Medicine);

                    this.ClearInput();
                    this.UpdateDataGridView(this.medicines);
                }
            }
        }

        private void btn_info_PhClick(object sender, EventArgs e)
        {
            Medicine? selected = this.GetSelectedMedicine();

            if (selected != null)
            {
                this.form.InitAction(ActionType.INFORMATION, user, family, selected);
                this.form.ShowDialog();
            }
        }

        private async void btn_delete_PhClick(object sender, EventArgs e)
        {
            Medicine? selected = this.GetSelectedMedicine();

            if (!this.DbOperation && selected != null)
            {
                this.DbOperation = true;

                this.medicines.Remove(selected);

                await Task.Run(() =>
                {
                    try
                    {
                        using (HomePharmacyContext context = new HomePharmacyContext())
                        {
                            Medicine? medicine = context.Medicines.Where(x => x.IdMedicine == selected.IdMedicine).FirstOrDefault();

                            if (medicine != null)
                            {
                                context.Medicines.Remove(medicine);
                                var usages = context.MedicinesUsages.Where(x => x.IdMedicine == selected.IdMedicine).ToList();
                                context.SaveChanges();

                                usages.ForEach(x =>
                                {
                                    var usage = this.medicinesUsages.Where(c => c.IdIllness == x.IdIllness && c.IdMedicine == x.IdMedicine && x.UsageDate == c.UsageDate).First();
                                    this.medicinesUsages.Remove(usage);
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (this.InvokeRequired)
                            this.Invoke(new MethodInvoker(delegate
                            {
                                MessageBox.Show(ex.ToString(), "Database exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                    }
                });

                this.ClearInput();
                this.UpdateDataGridView(this.medicines);

                this.DbOperation = false;
            }
        }

        private void btn_apply_PhClick(object sender, EventArgs e)
        {
            List<Medicine> medicines;

            string[] types = DBValidation.MedicineValidation.types;

            if (types.Contains(this.cb_type.PhText)) medicines = this.medicines.Where(x => x.Type == this.cb_type.PhText).ToList();
            else medicines = this.medicines;

            if (this.chb_expired.Checked) medicines = medicines.Where(x => x.ExpiryDate < DateTime.Today).ToList();
            if(this.chb_used.Checked) medicines = medicines.Where(x => x.Remainings < x.CountOrAmount*x.ExemplearsCount).ToList();

            this.UpdateDataGridView(medicines);
        }

        private void MedicinesPage_DataReceived()
        {
            try
            {
                if (this.Data != null && this.Data.Length == 4)
                {
                    this.user = (Person)this.Data[0];
                    this.family = (Family?)this.Data[1];
                    this.medicines = (List<Medicine>)this.Data[2];
                    this.medicinesUsages = (List<MedicinesUsage>)this.Data[3];

                    this.Enabled = true;

                    this.ClearDataUI();
                    this.LoadDataUI();
                }
                else throw new Exception();
            }
            catch(Exception ex)
            {
                this.Enabled = false;
            }
        }
    }
}
