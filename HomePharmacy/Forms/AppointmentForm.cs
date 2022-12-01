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
            this.DbOperation = false;
        }

        #region GUI Initialization

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
                this.tb_medicines.Text = this.initial_ap.MedicineList;
                this.tb_recommendator.Text = this.initial_ap.Recommendator;
                this.tb_volume.Text = this.initial_ap.AppointmentVolume;
                this.tb_comment.Text = this.initial_ap.AdditionalInfo;

                this.Controls.OfType<TextBox>().ToList().ForEach(x=>x.ReadOnly = read_only);
            }
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
                this.InitButton(action_enable);
            }
            else this.btn_action.Enabled = false;
        }

        private void InputToAppointment()
        {
            this.Appointment.IdIllness = this.illness.IdIllness;
            this.Appointment.MedicineList = this.tb_medicines.Text;
            this.Appointment.Recommendator = this.tb_recommendator.Text;
            this.Appointment.AppointmentVolume = this.tb_volume.Text != String.Empty ? this.tb_volume.Text : null;
            this.Appointment.AdditionalInfo = this.tb_comment.Text != String.Empty ? this.tb_comment.Text : null;
        }

        private bool Validation()
        {
            if(!DBValidation.AppointmentValidation.MedicineListValidation(this.Appointment.MedicineList) 
                || !DBValidation.AppointmentValidation.RecommendatorValidation(this.Appointment.Recommendator))
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
                        if(!context.Appointments.Any(x=>x.IdIllness == this.Appointment.IdIllness && x.MedicineList == this.Appointment.MedicineList
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
                        && x.MedicineList == this.Appointment.MedicineList && x.Recommendator == this.Appointment.Recommendator); // check if updated version alread exists
                       
                        if (!update_exists) result = DialogResult.OK; // we dont have updated appointment
                        else // we have the same appointment but we dont know if its the old one(the new values are the same as the old ones)
                        {
                            if (this.Appointment.MedicineList == this.initial_ap.MedicineList && this.Appointment.Recommendator == this.initial_ap.Recommendator) result = DialogResult.OK;
                            else result = DialogResult.TryAgain;
                        }

                        // processing and analyzing result
                        if(result == DialogResult.OK)
                        {
                            int rows = context.Database.ExecuteSql($"update Appointments set MedicineList={this.Appointment.MedicineList},Recommendator={this.Appointment.Recommendator},AppointmentVolume={this.Appointment.AppointmentVolume},AdditionalInfo={this.Appointment.AdditionalInfo} where IdIllness={this.initial_ap.IdIllness} and MedicineList={this.initial_ap.MedicineList} and Recommendator={this.initial_ap.Recommendator}");
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
