using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePharmacy.Controls;
using HomePharmacy.Models;

namespace HomePharmacy.FormTab
{
    public partial class FamCreationPage : PhPage
    {
        public event ChangePageEvent? ChangePage;

        private Person user;

        public FamCreationPage()
        {
            InitializeComponent();
        }

        public override void HideErrors()
        {
            lb_email_check.Text = String.Empty;
        }

        public override void ClearInput()
        {
            tb_email.PhText = String.Empty;
        }

        private bool Validation(string other_email)
        {
            this.HideErrors();

            if(!DBValidation.PersonValidation.Email(other_email))
            {
                lb_email_check.Text = DBValidation.ValidationErrorMsg;
                return false;
            }

            return true;
        }

        private async void btn_create_PhClick(object sender, EventArgs e)
        {
            string other_email = tb_email.PhText;

            if (!this.DbOperation && this.Validation(other_email))
            {
                this.DbOperation = true;

                Family? family = new Family();

                await Task.Run(() =>
                {
                    try
                    {
                        using (HomePharmacyContext context = new HomePharmacyContext())
                        {
                            Person? user = context.Persons.Where(x => x.Email == this.user.Email).FirstOrDefault();
                            Person? other_person = context.Persons.Where(x => x.Email == other_email).FirstOrDefault();

                            if (user != null && other_person != null)
                            {
                                // create new family
                                context.Families.Add(family);
                                context.SaveChanges();

                                // create relation between persons and family
                                user.Families.Add(family);
                                other_person.Families.Add(family);
                                context.SaveChanges();
                            }
                            else
                            {
                                family = null;

                                if (this.lb_email_check.InvokeRequired)
                                    this.lb_email_check.Invoke(new MethodInvoker(delegate
                                    {
                                        this.lb_email_check.Text = "Account with such email does not exist!";
                                    }));
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        family = null;

                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                MessageBox.Show(ex.ToString(), "Database exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                        }
                    }
                });


                // transfer data
                if (family != null && this.ChangePage != null) this.ChangePage(Tabs.Main, user, family);

                this.DbOperation = false;
            }
        }

        private void btn_back_PhClick(object sender, EventArgs e)
        {
            if (!this.DbOperation && this.ChangePage != null) this.ChangePage(Tabs.CabinetSelection);
        }

        private void FamCreationPage_DataReceived()
        {
            try
            {
                if (this.Data != null && this.Data.Length == 1) this.user = (Person)this.Data[0];
            }
            catch(Exception ex)
            {
                this.Enabled = false;
            }
        }
    }
}
