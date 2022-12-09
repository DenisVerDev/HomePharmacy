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

        private Appointment initial_ap; // to track original input values
        private Illness illness;

        private ActionType current_action;

        private bool DbOperation;

        public AppointmentForm()
        {
            InitializeComponent();
            this.InitMaxValues();

            this.DbOperation = false;
        }

        #region GUI Initialization

        private void InitMaxValues()
        {
            this.tb_recommendator.MaxLength = DBValidation.AppointmentValidation.recommendator_maxsize;
            this.tb_medicines.MaxLength = DBValidation.AppointmentValidation.info_maxsize;
            this.tb_usagesch.MaxLength = DBValidation.AppointmentValidation.info_maxsize;
        }

        private void InitTextBoxes(bool read_only)
        {
            if (this.current_action == ActionType.ADD)
            {
                this.Controls.OfType<TextBox>().ToList().ForEach((x) =>
                {
                    x.Text = String.Empty;
                    x.ReadOnly = false;
                });
            }
            else
            {
                this.tb_medicines.Text = this.initial_ap.Medicines;
                this.tb_recommendator.Text = this.initial_ap.Recommendator;
                this.tb_usagesch.Text = this.initial_ap.MedicinesUsageSchedule;

                this.Controls.OfType<TextBox>().ToList().ForEach(x=>x.ReadOnly = read_only);
            }
        }

        private void InitDate(bool action_enable)
        {
            this.dateAppCalendar.Enabled = action_enable;

            this.dateAppCalendar.MinDate = this.illness.StartDate;
            if (this.illness.EndDate != null) this.dateAppCalendar.MaxDate = this.illness.EndDate.Value;
            else this.dateAppCalendar.MaxDate = DateTime.Today;

            if (this.current_action == ActionType.ADD) this.dateAppCalendar.SetDate(this.dateAppCalendar.MaxDate);
            else this.dateAppCalendar.SetDate(this.initial_ap.AppointmentDate);
        }

        private void InitButton(bool action_enable)
        {
            if (this.current_action == ActionType.ADD) this.btn_action.Caption = "Add appointment";
            else if (this.current_action == ActionType.UPDATE) this.btn_action.Caption = "Update appointment";
            else this.btn_action.Caption = "Information";

            this.btn_action.Enabled = action_enable;
        }

        #endregion

        private void InitParams(ActionType action, Illness illness, Appointment? appointment)
        {
            DialogResult = DialogResult.None;
            this.current_action = action;

            this.illness = illness;

            this.Appointment = new Appointment();

            if(appointment != null)
            {
                this.Appointment.TransferDataFrom(appointment);

                this.initial_ap = new Appointment();
                this.initial_ap.TransferDataFrom(appointment);
            }
        }

        public void InitAction(ActionType action, Illness illness, Appointment? appointment)
        {
            if (illness != null)
            {
                this.InitParams(action, illness, appointment);

                // gui init
                bool action_enable = true;
                if (this.current_action == ActionType.INFORMATION) action_enable = false;

                this.InitTextBoxes(!action_enable);
                this.InitDate(action_enable);
                this.InitButton(action_enable);
            }
            else this.btn_action.Enabled = false;
        }

        private void InputToAppointment()
        {
            this.Appointment.IdIllness = this.illness.IdIllness;
            this.Appointment.Medicines = this.tb_medicines.Text;
            this.Appointment.Recommendator = this.tb_recommendator.Text;
            this.Appointment.AppointmentDate = this.dateAppCalendar.SelectionRange.Start;
            this.Appointment.MedicinesUsageSchedule = this.tb_usagesch.Text;
        }

        private bool Validation()
        {
            if(!DBValidation.AppointmentValidation.Validate(this.Appointment))
            {
                MessageBox.Show(DBValidation.ValidationErrorMsg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void AddAppointment()
        {
            this.DbOperation = true;

            DialogResult result = DialogResult.None;

            await Task.Run(() => 
            { 
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        if(!context.Appointments.Any(x=>x.IdIllness == this.Appointment.IdIllness && x.AppointmentDate == this.Appointment.AppointmentDate
                        && x.Recommendator == this.Appointment.Recommendator))
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

        private async void UpdateAppointment()
        {
            this.DbOperation = true;

            DialogResult result = DialogResult.None;

            await Task.Run(() => 
            {
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        bool update_exists = context.Appointments.Any(x => x.IdIllness == this.Appointment.IdIllness 
                        && x.AppointmentDate == this.Appointment.AppointmentDate && x.Recommendator == this.Appointment.Recommendator); // check if updated version alread exists
                       
                        if (!update_exists) result = DialogResult.OK; // we dont have updated appointment
                        else // we have the same appointment but we dont know if its the old one(the new values are the same as the old ones)
                        {
                            if (this.Appointment.AppointmentDate == this.initial_ap.AppointmentDate && this.Appointment.Recommendator == this.initial_ap.Recommendator) result = DialogResult.OK;
                            else result = DialogResult.TryAgain;
                        }

                        // processing and analyzing result
                        if(result == DialogResult.OK)
                        {
                            int rows = context.Database.ExecuteSql($"update Appointments set Medicines={this.Appointment.Medicines},Recommendator={this.Appointment.Recommendator},AppointmentDate={this.Appointment.AppointmentDate},MedicinesUsageSchedule={this.Appointment.MedicinesUsageSchedule} where IdIllness={this.initial_ap.IdIllness} and AppointmentDate={this.initial_ap.AppointmentDate} and Recommendator={this.initial_ap.Recommendator}");
                            if (rows != 1) throw new Exception("Exception with the update function!");
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
            this.InputToAppointment();

            if (!this.DbOperation && this.Validation())
            {
                if (this.current_action == ActionType.ADD) this.AddAppointment();
                else if (this.current_action == ActionType.UPDATE) this.UpdateAppointment();
            }
        }
    }
}
