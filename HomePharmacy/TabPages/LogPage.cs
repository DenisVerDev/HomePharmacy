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

namespace HomePharmacy.TabPages
{
    public partial class LogPage : UserControl
    {

        public delegate void PageChangeEvent(object? sender, FormTabs tab);
        public event PageChangeEvent? PageChange;

        public LogPage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void HideErrors()
        {
            this.lb_email_check.Text = String.Empty;
            this.lb_password_check.Text = String.Empty;
        }

        private bool LogValidation()
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

                return validation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Validation exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void btn_log_PhClick(object sender, EventArgs e)
        {
            if (LogValidation())
            {
                string email = this.tb_email.PhText;
                string password = this.tb_password.PhText;

                Person? person = null;

                await Task.Run(() =>
                {
                    try
                    {
                        using (HomePharmacyContext context = new HomePharmacyContext())
                        {
                            person = context.Persons.Where(x => x.Email == email).FirstOrDefault();

                            if (person == null)
                            {
                                if (this.lb_email_check.InvokeRequired)
                                    this.lb_email_check.Invoke(new MethodInvoker(delegate
                                    {
                                        this.lb_email_check.Text = "Account with such email does not exist!";
                                    }));
                            }
                            else
                            {
                                if (person.Password != password)
                                {
                                    if (this.lb_password_check.InvokeRequired)
                                        this.lb_password_check.Invoke(new MethodInvoker(delegate
                                        {
                                            this.lb_password_check.Text = "Incorrect password!";
                                        }));

                                    person = null;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                MessageBox.Show(ex.ToString(), "Database exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                        }
                    }
                });
            }
        }

        private void btn_reg_PhClick(object sender, EventArgs e)
        {
            if (this.PageChange != null) PageChange(this, FormTabs.Registration);
        }
    }
}
