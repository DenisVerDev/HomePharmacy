﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePharmacy.Models;

namespace HomePharmacy.TabPages
{

    public partial class RegPage : UserControl
    { 
        public event PageChangeEvent? PageChange;

        public RegPage()
        {
            InitializeComponent();
            this.cb_sex.Items.AddRange(DBValidation.PersonValidation.sexTypes);
            this.DoubleBuffered = true;
        }

        private void HideErrors()
        {
            this.lb_email_check.Text = String.Empty;
            this.lb_password_check.Text = String.Empty;
            this.lb_name_check.Text = String.Empty;
            this.lb_sex_check.Text = String.Empty;
        }

        private void ClearInput()
        {
            this.tb_email.PhText = String.Empty;
            this.tb_password.PhText = String.Empty;
            this.tb_name.PhText = String.Empty;
            this.cb_sex.PhText = String.Empty;
        }

        private bool RegValidation()
        {
            try
            {
                this.HideErrors();

                bool validation = true;

                // email check block
                if (!DBValidation.PersonValidation.EmailValidation(tb_email.PhText))
                {
                    validation = false;
                    lb_email_check.Text = DBValidation.ValidationErrorMsg;
                }

                // password check block
                if (!DBValidation.PersonValidation.PasswordValidation(tb_password.PhText))
                {
                    validation = false;
                    lb_password_check.Text = DBValidation.ValidationErrorMsg;
                }

                // name check block
                if (!DBValidation.PersonValidation.NameValidation(tb_name.PhText))
                {
                    validation = false;
                    lb_name_check.Text = DBValidation.ValidationErrorMsg;
                }

                // sex check block
                if (!DBValidation.PersonValidation.SexValidation(cb_sex.PhText))
                {
                    validation = false;
                    lb_sex_check.Text = DBValidation.ValidationErrorMsg;
                }

                return validation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Validation exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void btn_reg_PhClick(object sender, EventArgs e)
        {
            if (RegValidation())
            {

                bool status = true;

                Person person = new Person()
                {
                    Email = this.tb_email.PhText,
                    Password = this.tb_password.PhText,
                    Name = this.tb_name.PhText,
                    Sex = this.cb_sex.PhText
                };

                await Task.Run(() =>
                {
                    try
                    {
                        using (HomePharmacyContext context = new HomePharmacyContext())
                        {
                            context.Persons.Add(person);
                            context.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        status = false;

                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                MessageBox.Show(ex.ToString(), "Database exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                        }
                    }
                });

                // clear Registration page and go to the Cabinet Selection page
                if (status && this.PageChange != null)
                {
                    this.ClearInput();
                    PageChange(FormTabs.CabinetSelection, person);
                }
            }
        }

        private void btn_back_PhClick(object sender, EventArgs e)
        {
            if (this.PageChange != null) PageChange(FormTabs.Login,null);
        }
    }
}