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

namespace HomePharmacy.FormTab
{
    public partial class CabinetSelectionPage : PhPage
    {
        public event ChangePageEvent? ChangePage;

        private Person user;
        private Family[] families;

        private Tabs previous;

        public CabinetSelectionPage()
        {
            InitializeComponent();
        }

        public override void ClearDataUI()
        {
            int index = 2; // skip personal cabinet and create family
            int count = this.flowPanel.Controls.Count - index;
            for (int i = 0; i < count; i++)
            {
                this.flowPanel.Controls.RemoveAt(index);
            }
        }

        public override void LoadDataUI()
        {
            try
            {
                // load families ui
                for (int i = 0; i < this.families.Length; i++)
                {
                    var people = this.families[i].People.ToArray();

                    var btn_family = new PhButton();
                    btn_family.Size = new Size(136, 150);
                    btn_family.BorderRadius = 30;
                    btn_family.BorderColor = btn_createfam.BorderColor;
                    btn_family.HoverBorderColor = btn_createfam.HoverBorderColor;
                    btn_family.Caption = $"Family ID: {this.families[i].IdFamily}\n{people[0].Name}\n{people[1].Name}";
                    btn_family.Tag = i;
                    btn_family.Name = $"btn_{this.families[i].IdFamily}";
                    btn_family.PhClick += Btn_family_PhClick;

                    this.flowPanel.Controls.Add(btn_family);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Families UI exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadFamilies()
        {
            this.DbOperation = true;

            await Task.Run(() => 
            {
                try
                {
                    using (HomePharmacyContext context = new HomePharmacyContext())
                    {
                        this.families = context.Persons.Where(x => x.Email == this.user.Email).SelectMany(s => s.Families).Include(c => c.People).ToArray();
                    }
                }
                catch (Exception ex)
                {
                    this.families = null;

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            MessageBox.Show(ex.ToString(), "Loading families exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                    }
                }
            });

            if(this.families != null && this.families.Length > 0) this.LoadDataUI();

            this.DbOperation = false;
        }

        private void Btn_family_PhClick(object sender, EventArgs e)
        {
            var button = (PhButton)sender;
            int index = (int)button.Tag;

            Family selected = this.families[index];

            if (!this.DbOperation && ChangePage != null) ChangePage(Tabs.Main, user, selected);
        }

        private void btn_personalcab_PhClick(object sender, EventArgs e)
        {
            if (!this.DbOperation && ChangePage != null) ChangePage(Tabs.Main, user,null);
        }

        private void btn_createfam_PhClick(object sender, EventArgs e)
        {
            if (!this.DbOperation && ChangePage != null) ChangePage(Tabs.CreateFamily, user);
        }

        private void btn_back_PhClick(object sender, EventArgs e)
        {
            if (!this.DbOperation && ChangePage != null) ChangePage(this.previous);
        }

        private void CabinetSelectionPage_DataReceived()
        {
            try
            {
                if (this.Data != null && this.Data.Length == 2)
                {
                    this.user = (Person)this.Data[0];
                    this.previous = (Tabs)this.Data[1];

                    this.Enabled = true;

                    this.ClearDataUI();
                    this.LoadFamilies();
                }
                else throw new Exception();
            }
            catch(Exception ex)
            {
                this.Enabled = false;
            }
        }
    }
}
