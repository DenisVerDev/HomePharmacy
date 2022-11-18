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

namespace HomePharmacy.Forms
{
    public partial class RegForm : Form
    {
        private Form previous;

        public RegForm(Form previous)
        {
            InitializeComponent();
            this.cb_sex.Items.AddRange(DBValidation.PersonValidation.sexTypes);

            this.previous = previous;
        }

        private void HideErrors()
        {
            this.lb_email_check.Text = String.Empty;
            this.lb_password_check.Text = String.Empty;
            this.lb_name_check.Text = String.Empty;
            this.lb_sex_check.Text = String.Empty;
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
                    DBValidation.ShowValidationError(lb_email_check);
                }

                // password check block
                if (!DBValidation.PersonValidation.PasswordValidation(tb_password.PhText))
                {
                    validation = false;
                    DBValidation.ShowValidationError(lb_password_check);
                }

                // name check block
                if (!DBValidation.PersonValidation.NameValidation(tb_name.PhText))
                {
                    validation = false;
                    DBValidation.ShowValidationError(lb_name_check);
                }

                // sex check block
                if (!DBValidation.PersonValidation.SexValidation(cb_sex.PhText))
                {
                    validation = false;
                    DBValidation.ShowValidationError(lb_sex_check);
                }

                return validation;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Validation exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void btn_reg_PhClick(object sender, EventArgs e)
        {
            if (RegValidation())
            {

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
                    catch(Exception ex)
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

        private void btn_back_PhClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegForm_Shown(object sender, EventArgs e)
        {
            this.Location = this.previous.Location;
        }
    }
}
