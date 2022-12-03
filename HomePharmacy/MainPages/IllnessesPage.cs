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
    public partial class IllnessesPage : PhPage
    {
        public ChangeMainPageEvent? ChangeMainPageEvent;

        private Person user;
        private Family? family;
        private List<Illness> illnesses;

        private DataTable table;

        private IllnessForm form;

        public IllnessesPage()
        {
            InitializeComponent();
            this.InitDataTable();

            this.form = new IllnessForm();
        }

        private void InitDataTable()
        {
            table = new DataTable();

            table.Columns.Add(new DataColumn("Id", typeof(int)));
            table.Columns.Add(new DataColumn("Illed person", typeof(string)));
            table.Columns.Add(new DataColumn("Diagnose", typeof(string)));
            table.Columns.Add(new DataColumn("Start date", typeof(string)));
            table.Columns.Add(new DataColumn("End date", typeof(string)));

            this.dgv_illnesses.DataSource = table;
        }

        private void UpdateDataGridView(List<Illness> illnesses)
        {
            this.table.Rows.Clear();

            foreach (Illness illness in illnesses)
            {
                var row = table.NewRow();

                row["Id"] = illness.IdIllness;
                row["Illed person"] = illness.IlledPerson;
                row["Diagnose"] = illness.Diagnoses;
                row["Start date"] = illness.StartDate.ToShortDateString();
                row["End date"] = illness.EndDate?.ToShortDateString();

                table.Rows.Add(row);
            }
        }

        public override void ClearInput()
        {
            this.cb_email.PhText = this.cb_email.Placeholder;
        }

        public override void ClearDataUI()
        {
            this.table.Rows.Clear();
            this.cb_email.Items.Clear();

            this.ClearInput();
        }

        public override void LoadDataUI()
        {
            this.cb_email.Items.Add("All");
            if(this.family != null) this.cb_email.Items.AddRange(this.family.People.Select(x=>x.Email).ToArray());

            this.UpdateDataGridView(this.illnesses);
        }

        private Illness? GetSelectedIllness()
        {
            if (this.dgv_illnesses.SelectedRows.Count == 1)
            {
                var selected_row = this.dgv_illnesses.SelectedRows[0];
                int id_illness = (int)selected_row.Cells["Id"].Value;

                return this.illnesses.Where(x => x.IdIllness == id_illness).First();
            }

            MessageBox.Show("There are no selected rows", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return null;
        }

        private void btn_add_PhClick(object sender, EventArgs e)
        {
            this.form.InitAction(ActionType.ADD, user, family, null);
            if(this.form.ShowDialog() == DialogResult.OK)
            {
                this.illnesses.Add(this.form.Illness);

                this.ClearInput();
                this.UpdateDataGridView(this.illnesses);
            }
        }

        private void btn_update_PhClick(object sender, EventArgs e)
        {
            Illness? selected = this.GetSelectedIllness();

            if (selected != null)
            {
                this.form.InitAction(ActionType.UPDATE, user, family, selected);
                if (this.form.ShowDialog() == DialogResult.OK)
                {
                    selected.TransferDataFrom(this.form.Illness);

                    this.ClearInput();
                    this.UpdateDataGridView(this.illnesses);
                }
            }
        }

        private void btn_info_PhClick(object sender, EventArgs e)
        {
            Illness? selected = this.GetSelectedIllness();

            if (selected != null)
            {
                this.form.InitAction(ActionType.INFORMATION, user, family, selected);
                this.form.ShowDialog();
            }
        }

        private async void btn_delete_PhClick(object sender, EventArgs e)
        {
            Illness? selected = this.GetSelectedIllness();

            if (!this.DbOperation && selected != null)
            {
                this.DbOperation = true;

                this.illnesses.Remove(selected);

                await Task.Run(() =>
                {
                    try
                    {
                        using (HomePharmacyContext context = new HomePharmacyContext())
                        {
                            var usages = context.MedicinesUsages.Where(x => x.IdIllness == selected.IdIllness).ToList();
                            context.MedicinesUsages.RemoveRange(usages);
                            context.SaveChanges();

                            context.Illnesses.Remove(selected);

                            context.SaveChanges();
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
                this.UpdateDataGridView(this.illnesses);

                this.DbOperation = false;
            }
        }

        private void btn_apply_PhClick(object sender, EventArgs e)
        {
            List<Illness>? filter_illnesses;

            if (DBValidation.PersonValidation.EmailValidation(this.cb_email.PhText))
                filter_illnesses = this.illnesses.Where(x => x.IlledPerson == this.cb_email.PhText).ToList();
            else filter_illnesses = this.illnesses;

            this.UpdateDataGridView(filter_illnesses);
        }

        private void btn_appointments_PhClick(object sender, EventArgs e)
        {
            Illness? selected = this.GetSelectedIllness();

            if (this.ChangeMainPageEvent != null && selected != null) this.ChangeMainPageEvent(MainTabs.Appointments, selected);
        }

        private void IllnessesPage_DataReceived()
        {
            if(Data != null && Data.Length == 3)
            {
                this.user = (Person)this.Data[0];
                this.family = (Family?)this.Data[1];
                this.illnesses = (List<Illness>)Data[2];

                this.ClearDataUI();
                this.LoadDataUI();
            }
        }
    }
}
