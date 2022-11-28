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
using HomePharmacy.Controls;
using HomePharmacy.Models;

namespace HomePharmacy.MainPages
{
    public partial class FamilyPage : PhPage
    {
        public event EventHandler LeaveFamily;

        private Person user;
        private Family? family;

        public FamilyPage()
        {
            InitializeComponent();
            this.cb_sex.Items.Add(String.Empty);
            this.cb_sex.Items.AddRange(DBValidation.PersonValidation.sexTypes);
        }

        public override void ClearInput()
        {
            this.tb_email.PhText = String.Empty;
            this.cb_sex.PhText = this.cb_sex.Placeholder;
        }

        public override void ClearDataUI()
        {
            this.ClearInput();
            this.flowPanel.Controls.Clear();
        }

        public override void LoadDataUI()
        {
            var persons = this.GetPersonsByFilter();
            if (persons != null)
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    if (persons[i].Email != this.user.Email) this.flowPanel.Controls.Add(new PersonInfo() { Person = persons[i] });
                }
            }
        }

        private Person[]? GetPersonsByFilter()
        {
            Person[]? person = null;

            if (DBValidation.PersonValidation.SexValidation(this.cb_sex.PhText))
                person = this.family?.People.Where(x => x.Sex == cb_sex.PhText).ToArray();
            else person = this.family?.People.ToArray();

            return person;
        }

        private async void AddMember(string email)
        {
            this.DbOperation = true;

            await Task.Run(() => 
            {
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        Person? person = context.Persons.Where(x => x.Email == email).FirstOrDefault();

                        if(person != null)
                        {
                            Family fam = new Family() { IdFamily = this.family.IdFamily }; // to track remote data, it doesn't work with the local one

                            person.IdFamilies.Add(fam);
                            context.Update(person);
                            context.SaveChanges();

                            this.family.People.Add(person);
                        }
                        else
                        {
                            if (this.InvokeRequired)
                                this.Invoke(new MethodInvoker(delegate
                                {
                                    MessageBox.Show("There is no such account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }));
                        }
                    }
                }
                catch(Exception ex)
                {
                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate 
                        {
                            MessageBox.Show(ex.ToString(), "Database exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                }
            });

            this.ClearDataUI();
            this.LoadDataUI();

            this.DbOperation = false;
        }

        private async void LeaveFromFamily()
        {
            this.DbOperation = true;

            await Task.Run(() =>
            {
                try
                {
                    using (HomePharmacyContext context = new HomePharmacyContext())
                    {
                        // working with the remote data
                        Family? family = context.Families.Where(x => x.IdFamily == this.family.IdFamily).Include(s => s.People).FirstOrDefault();
                        if (family != null)
                        {
                            if (family.People.Count == 2)
                            {
                                family.People.Clear();
                                context.Families.Remove(family);
                            }
                            else
                            {
                                Person? user = family.People.Where(x => x.Email == this.user.Email).FirstOrDefault();
                                if (user != null) family.People.Remove(user);
                            }

                            context.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                        {
                            MessageBox.Show(ex.ToString(), "Database exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                }
            });

            // exit to the cabinet selection
            if (this.LeaveFamily != null) this.LeaveFamily(this, null);

            this.DbOperation = false;
        }

        private void btn_apply_PhClick(object sender, EventArgs e)
        {
            this.flowPanel.Controls.Clear();
            this.LoadDataUI();
        }

        private void btn_add_PhClick(object sender, EventArgs e)
        {
            if(!this.DbOperation)
            {
                if (DBValidation.PersonValidation.EmailValidation(tb_email.PhText))
                {
                    if(!this.family.People.Any(x=>x.Email == tb_email.PhText))this.AddMember(tb_email.PhText);
                    else MessageBox.Show("Such account is already part of your family", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show(DBValidation.ValidationErrorMsg, "Email validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_leave_PhClick(object sender, EventArgs e)
        {
            if (!this.DbOperation) this.LeaveFromFamily();
        }

        private void FamilyPage_DataReceived()
        {
            if (this.Data != null && this.Data.Length == 2)
            {
                this.user = (Person)this.Data[0];
                this.family = (Family?)this.Data[1];

                this.ClearDataUI();
                this.LoadDataUI();
            }
        }
    }
}
