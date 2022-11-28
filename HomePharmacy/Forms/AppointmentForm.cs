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
    public enum ActionType
    {
        ADD,
        UPDATE,
        INFORMATION
    }

    public partial class AppointmentForm : Form
    {
        public Appointment Appointment { get; private set; }

        private ActionType current_action;

        private bool DbOperation;

        public AppointmentForm()
        {
            InitializeComponent();
            this.DbOperation = false;
        }

        public void InitAdd(int id_illness)
        {
            DialogResult = DialogResult.None;
            this.current_action = ActionType.ADD;

            this.Appointment = new Appointment() { IdIllness = id_illness };

            this.Controls.OfType<TextBox>().ToList().ForEach(x => x.ReadOnly = false);

            this.tb_medicines.Text = String.Empty;
            this.tb_recommendator.Text = String.Empty;
            this.tb_volume.Text = String.Empty;
            this.tb_comment.Text = String.Empty;

            this.btn_action.Caption = "Add appointment";
            this.btn_action.Enabled = true;
        }

        public void InitAction(ActionType action, Appointment appointment)
        {
            if (appointment != null)
            {
                if (action != ActionType.ADD)
                {
                    DialogResult = DialogResult.None;
                    this.current_action = action;

                    this.Appointment = appointment;

                    if (this.current_action == ActionType.INFORMATION)
                    {
                        this.Controls.OfType<TextBox>().ToList().ForEach(x => x.ReadOnly = true);

                        this.btn_action.Caption = "Information";
                        this.btn_action.Enabled = false;
                    }
                    else
                    {
                        this.Controls.OfType<TextBox>().ToList().ForEach(x => x.ReadOnly = false);

                        this.btn_action.Caption = "Update appointment";
                        this.btn_action.Enabled = true;
                    }

                    this.tb_medicines.Text = this.Appointment.MedicineList;
                    this.tb_recommendator.Text = this.Appointment.Recommendator;
                    this.tb_volume.Text = this.Appointment.AppointmentVolume;
                    this.tb_comment.Text = this.Appointment.AdditionalInfo;
                }
                else this.InitAdd(appointment.IdIllness);
            }
            else this.btn_action.Enabled = false;
        }

        private bool DataValidation(string meds, string recom)
        {
            if(!DBValidation.AppointmentValidation.MedicineListValidation(meds) || !DBValidation.AppointmentValidation.RecommendatorValidation(recom))
            {
                MessageBox.Show(DBValidation.ValidationErrorMsg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void AddAppointment(string meds, string recom, string? volume, string? addition_info)
        {
            this.DbOperation = true;

            DialogResult result = DialogResult.None;

            this.Appointment.MedicineList = meds;
            this.Appointment.Recommendator = recom;
            this.Appointment.AppointmentVolume = volume;
            this.Appointment.AdditionalInfo = addition_info;

            await Task.Run(() => 
            { 
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        if(!context.Appointments.Any(x=>x.IdIllness == this.Appointment.IdIllness && x.MedicineList == meds && x.Recommendator == recom))
                        {
                            context.Appointments.Add(this.Appointment);
                            context.SaveChanges();

                            result = DialogResult.OK;
                        }
                        else
                        {
                            result = DialogResult.TryAgain;

                            if (this.InvokeRequired)
                                this.Invoke(new MethodInvoker(delegate
                                {
                                    MessageBox.Show("There is already such appointment", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private async void UpdateAppointment(string meds, string recom, string? volume, string? addition_info)
        {
            this.DbOperation = true;

            DialogResult result = DialogResult.None;

            await Task.Run(() => 
            {
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        int count = context.Appointments.Count(x => x.IdIllness == this.Appointment.IdIllness && x.MedicineList == meds && x.Recommendator == recom);
                       
                        if (count == 0) result = DialogResult.OK; // we dont have updated appointment
                        else if (count == 1) // we have the same appointment but we dont know if its the old one(the new values are the same as the old ones)
                        {
                            if (this.Appointment.MedicineList == meds && this.Appointment.Recommendator == recom) result = DialogResult.OK;
                            else result = DialogResult.TryAgain;
                        }

                        // processing and analyzing result
                        if(result == DialogResult.OK)
                        {
                            int rows = context.Database.ExecuteSql($"update Appointments set MedicineList={meds},Recommendator={recom},AppointmentVolume={volume},AdditionalInfo={addition_info} where IdIllness={this.Appointment.IdIllness} and MedicineList={this.Appointment.MedicineList} and Recommendator={this.Appointment.Recommendator}");
                            if (rows == 1)
                            {
                                this.Appointment.MedicineList = meds;
                                this.Appointment.Recommendator = recom;
                                this.Appointment.AppointmentVolume = volume;
                                this.Appointment.AdditionalInfo = addition_info;
                            }
                            else throw new Exception("Exception with the update function!");
                        }
                        else
                        {
                            if (this.InvokeRequired)
                                this.Invoke(new MethodInvoker(delegate
                                {
                                    MessageBox.Show("There is already such appointment", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string meds = this.tb_medicines.Text;
            string recom = this.tb_recommendator.Text;
            string? volume = this.tb_volume.Text != String.Empty ? this.tb_volume.Text : null;
            string? addition_info = this.tb_comment.Text != String.Empty ? this.tb_comment.Text : null;

            if (!this.DbOperation && this.DataValidation(meds, recom))
            {
                if (this.current_action == ActionType.ADD) this.AddAppointment(meds, recom, volume, addition_info);
                else if (this.current_action == ActionType.UPDATE) this.UpdateAppointment(meds, recom, volume, addition_info);
            }
        }
    }
}
