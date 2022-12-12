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
    public partial class AppointmentsPage : PhPage
    {
        private Illness illness;

        private DataTable table;

        private AppointmentForm form;

        public AppointmentsPage()
        {
            InitializeComponent();
            this.InitDataTable();

            this.form = new AppointmentForm();
        }

        private void InitDataTable()
        {
            this.table = new DataTable();
            this.table.Columns.Add(new DataColumn("Recommendator", typeof(string)));
            this.table.Columns.Add(new DataColumn("Appointment's date", typeof(string)));
            this.table.Columns.Add(new DataColumn("Medicines list", typeof(string)));
            this.table.Columns.Add(new DataColumn("Meds usage schedule", typeof(string)));

            this.dgv_appointments.DataSource = this.table;
        }

        public override void ClearDataUI()
        {
            this.table.Rows.Clear();
        }

        public override void LoadDataUI()
        {
            foreach(var appointment in this.illness.Appointments)
            {
                var row = this.table.NewRow();
                row["Recommendator"] = appointment.Recommendator;
                row["Appointment's date"] = appointment.AppointmentDate.ToShortDateString();
                row["Medicines list"] = appointment.Medicines;
                row["Meds usage schedule"] = appointment.MedicinesUsageSchedule;
                
                this.table.Rows.Add(row);
            }
        }

        private Appointment? GetSelectedAppointment()
        {
            if (this.dgv_appointments.SelectedRows.Count == 1)
            {
                var selected_row = this.dgv_appointments.SelectedRows[0];

                string recom = (string)selected_row.Cells["Recommendator"].Value;
                DateTime app_date = DateTime.Parse((string)selected_row.Cells["Appointment's date"].Value);

                return this.illness.Appointments.Where(x => x.Recommendator == recom && x.AppointmentDate == app_date).First();
            }

            MessageBox.Show("There are no selected rows", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return null;
        }

        private void btn_add_PhClick(object sender, EventArgs e)
        {
            this.form.InitAction(ActionType.ADD, this.illness, null);
            if(this.form.ShowDialog() == DialogResult.OK)
            {
                this.illness.Appointments.Add(this.form.Appointment);
                this.ClearDataUI();
                this.LoadDataUI();
            }
        }

        private void btn_update_PhClick(object sender, EventArgs e)
        {
            Appointment? selected = this.GetSelectedAppointment();

            if (selected != null)
            {
                this.form.InitAction(ActionType.UPDATE, this.illness, selected);
                if (this.form.ShowDialog() == DialogResult.OK)
                {
                    selected.TransferDataFrom(this.form.Appointment);
                    this.ClearDataUI();
                    this.LoadDataUI();
                }
            }
        }

        private void btn_info_PhClick(object sender, EventArgs e)
        {
            Appointment? selected = this.GetSelectedAppointment();

            if (selected != null)
            {
                this.form.InitAction(ActionType.INFORMATION, this.illness, selected);
                this.form.ShowDialog();
            }
        }

        private async void btn_delete_PhClick(object sender, EventArgs e)
        {
            Appointment? selected = this.GetSelectedAppointment();

            if (!this.DbOperation && selected != null)
            {
                this.DbOperation = true;

                this.illness.Appointments.Remove(selected);

                await Task.Run(() =>
                {
                    try
                    {
                        using (HomePharmacyContext context = new HomePharmacyContext())
                        {
                            context.Appointments.Remove(selected);
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

                this.ClearDataUI();
                this.LoadDataUI();

                this.DbOperation = false;
            }
        }

        private void AppointmentsPage_DataReceived()
        {
            try
            {
                if (this.Data != null && this.Data.Length == 1)
                {
                    this.illness = (Illness)this.Data[0];

                    this.ClearDataUI();
                    this.LoadDataUI();
                }
            }
            catch(Exception ex)
            {
                this.Enabled = false;
            }
        }
    }
}
