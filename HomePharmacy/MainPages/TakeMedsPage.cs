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
    public partial class TakeMedsPage : PhPage
    {
        private List<MedicinesUsage> medicinesUsages;
        private List<Medicine> medicines;
        private List<Illness> illnesses;

        private DataTable table;

        private TakeMedForm form;

        public TakeMedsPage()
        {
            InitializeComponent();
            this.InitDataTable();

            this.form = new TakeMedForm();
        }

        private void InitDataTable()
        {
            this.table = new DataTable();

            this.table.Columns.Add(new DataColumn("Id Medicine",typeof(int)));
            this.table.Columns.Add(new DataColumn("Id Illness", typeof(int)));
            this.table.Columns.Add(new DataColumn("Usage date", typeof(string)));
            this.table.Columns.Add(new DataColumn("Usage result", typeof(string)));
            this.table.Columns.Add(new DataColumn("Count", typeof(int)));
            this.table.Columns.Add(new DataColumn("Comment", typeof(string)));

            this.dgv_takemed.DataSource = this.table;
        }

        private void UpdateDataGridView()
        {
            this.table.Rows.Clear();

            this.medicinesUsages.ForEach((x) => 
            {
                var row = this.table.NewRow();

                row["Id Medicine"] = x.IdMedicine;
                row["Id Illness"] = x.IdIllness;
                row["Usage date"] = x.UsageDate.ToShortDateString();
                row["Usage result"] = x.UsageResult;
                row["Count"] = x.CountOrAmount;
                row["Comment"] = x.Comment;

                this.table.Rows.Add(row);
            });
        }

        private MedicinesUsage? GetSelectedUsage()
        {
            if(this.dgv_takemed.SelectedRows.Count == 1)
            {
                var row = this.dgv_takemed.SelectedRows[0];
                int id_med = (int)row.Cells["Id Medicine"].Value;
                int id_ill = (int)row.Cells["Id Illness"].Value;
                DateTime date = DateTime.Parse((string)row.Cells["Usage date"].Value);

                return this.medicinesUsages.Where(x => x.IdMedicine == id_med && x.IdIllness == id_ill && x.UsageDate == date).First();
            }

            MessageBox.Show("There are no selected rows", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return null;
        }

        private void btn_add_PhClick(object sender, EventArgs e)
        {
            this.form.InitAction(ActionType.ADD, medicines, illnesses, null);
            if(this.form.ShowDialog() == DialogResult.OK)
            {
                this.medicinesUsages.Add(this.form.MedicinesUsage);
                this.UpdateDataGridView();
            }
        }

        private void btn_update_PhClick(object sender, EventArgs e)
        {
            MedicinesUsage? selected = this.GetSelectedUsage();

            if (selected != null)
            {
                this.form.InitAction(ActionType.UPDATE, medicines, illnesses, selected);
                if(this.form.ShowDialog() == DialogResult.OK)
                {
                    selected.TrasnferDataFrom(this.form.MedicinesUsage);
                    this.UpdateDataGridView();
                }
            }
        }

        private void btn_info_PhClick(object sender, EventArgs e)
        {
            MedicinesUsage? selected = this.GetSelectedUsage();

            if(selected != null)
            {
                this.form.InitAction(ActionType.INFORMATION, medicines, illnesses, selected);
                this.form.ShowDialog();
            }
        }

        private async void btn_delete_PhClick(object sender, EventArgs e)
        {
            MedicinesUsage? selected = this.GetSelectedUsage();

            if (!this.DbOperation && selected != null)
            {
                this.DbOperation = true;

                this.medicinesUsages.Remove(selected);

                await Task.Run(() => 
                {
                    try
                    {
                        using(HomePharmacyContext context = new HomePharmacyContext())
                        {
                            context.MedicinesUsages.Remove(selected);

                            Medicine medicine = this.medicines.Where(x => x.IdMedicine == selected.IdMedicine).First();
                            medicine.Remainings += selected.CountOrAmount;

                            context.Update(medicine);
                            context.SaveChanges();
                        }
                    }
                    catch(Exception ex)
                    {
                        if (this.InvokeRequired)
                            this.Invoke(new MethodInvoker(delegate
                            {
                                MessageBox.Show(ex.ToString(), "Database exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                    }
                });

                this.UpdateDataGridView();

                this.DbOperation = false;
            }
        }

        private void TakeMedsPage_DataReceived()
        {
            if(this.Data != null && this.Data.Length == 3)
            {
                this.medicinesUsages = (List<MedicinesUsage>)this.Data[0];
                this.medicines = (List<Medicine>)this.Data[1];
                this.illnesses = (List<Illness>)this.Data[2];

                this.UpdateDataGridView();
            }
        }
    }
}
