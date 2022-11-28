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
            this.table.Columns.Add(new DataColumn("Medicines list", typeof(string)));
            this.table.Columns.Add(new DataColumn("Appointment's volume", typeof(string)));
            this.table.Columns.Add(new DataColumn("Additional information", typeof(string)));

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
                row["Medicines list"] = appointment.MedicineList;
                row["Appointment's volume"] = appointment.AppointmentVolume;
                row["Additional information"] = appointment.AdditionalInfo;
                
                this.table.Rows.Add(row);
            }
        }

        private void btn_add_PhClick(object sender, EventArgs e)
        {
            this.form.InitAdd(this.illness.IdIllness);
            if(this.form.ShowDialog() == DialogResult.OK)
            {
                this.illness.Appointments.Add(this.form.Appointment);
                this.ClearDataUI();
                this.LoadDataUI();
            }
        }

        private void btn_update_info(object sender, EventArgs e)
        {
            var selected_row = this.dgv_appointments.SelectedRows[0];

            string meds = (string)selected_row.Cells["Medicines list"].Value;
            string recom = (string)selected_row.Cells["Recommendator"].Value;

            Appointment appointment = this.illness.Appointments.Where(x => x.MedicineList == meds && x.Recommendator == recom).First();

            ActionType action;
            if (sender == this.btn_update) action = ActionType.UPDATE;
            else action = ActionType.INFORMATION;

            this.form.InitAction(action, appointment);
            if(this.form.ShowDialog() == DialogResult.OK)
            {
                this.ClearDataUI();
                this.LoadDataUI();
            }
        }

        private async void btn_delete_PhClick(object sender, EventArgs e)
        {
            var selected_row = this.dgv_appointments.SelectedRows[0];

            string meds = (string)selected_row.Cells["Medicines list"].Value;
            string recom = (string)selected_row.Cells["Recommendator"].Value;
            this.dgv_appointments.Rows.Remove(selected_row);

            Appointment appointment = this.illness.Appointments.Where(x => x.MedicineList == meds && x.Recommendator == recom).First();
            this.illness.Appointments.Remove(appointment);

            await Task.Run(() =>
            {
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        context.Appointments.Remove(appointment);
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
        }

        private void AppointmentsPage_DataReceived()
        {
            if(this.Data != null && this.Data.Length == 1)
            {
                this.illness = (Illness)this.Data[0];

                this.ClearDataUI();
                this.LoadDataUI();
            }
        }
    }
}
