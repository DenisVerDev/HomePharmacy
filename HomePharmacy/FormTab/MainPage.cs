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
using HomePharmacy.MainPages;
using HomePharmacy.Models;

namespace HomePharmacy.FormTab
{ 

    public partial class MainPage : PhPage
    {
        public event ChangePageEvent? ChangePage;

        private Person user;
        private Family? family;
        private List<Illness> illnesses;
        private List<Medicine> medicines;

        public MainPage()
        {
            InitializeComponent();
            this.illnesses = new List<Illness>();
            this.medicines = new List<Medicine>();
           
            // buttons Tag
            this.btn_profile.Tag = MainTabs.Profile;
            this.btn_family.Tag = MainTabs.Family;
            this.btn_illneses.Tag = MainTabs.Illnesses;
            this.btn_medicines.Tag = MainTabs.Medicines;
            this.btn_medusage.Tag = MainTabs.TakeMedicines;
            this.btn_statistics.Tag = MainTabs.Statisctics;
            // tpages Tag
            this.tpage_profile.Tag = MainTabs.Profile;
            this.tpage_family.Tag = MainTabs.Family;
            this.tpage_ilnesses.Tag = MainTabs.Illnesses;
            this.tpage_appoint.Tag = MainTabs.Appointments;
            this.tpage_medicines.Tag = MainTabs.Medicines;
            this.tpage_takemed.Tag = MainTabs.TakeMedicines;
            this.tpage_statistics.Tag = MainTabs.Statisctics;

            this.illnessesPage.ChangeMainPageEvent += this.ChangeMainTabs;
        }

        private void ChangeMainTabs(MainTabs next, params object[]? data)
        {
            try
            {
                // change tab
                var tab_pages = this.tab_main.TabPages.Cast<TabPage>().ToArray();
                var next_page = tab_pages.Where(x => (MainTabs)x.Tag == next).FirstOrDefault();

                if (next_page != null)
                {
                    if (data != null)
                    {
                        var current = next_page.Controls[0] as PhPage;
                        current.Data = data;
                    }

                    this.tab_main.SelectTab(next_page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MainTab change exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Page_Select(object sender, EventArgs e)
        {
            this.flowPanelTabs.Controls.Cast<PhIcon>().ToList().ForEach(x => x.IsSelected = false);

            var button = (PhIcon)sender;
            button.IsSelected = true;

            MainTabs next = (MainTabs)button.Tag;
            switch (next)
            {

                case MainTabs.TakeMedicines:
                    this.ChangeMainTabs((MainTabs)button.Tag, this.medicines);
                    break;

                default: this.ChangeMainTabs((MainTabs)button.Tag); break;
            }
        }

        private void profilePage_ChangeCabinetEvent(object sender, EventArgs e)
        {
            if (this.ChangePage != null) this.ChangePage(Tabs.CabinetSelection,this.user,Tabs.Main);
        }

        private void profilePage_LogoutEvent(object sender, EventArgs e)
        {
            if (this.ChangePage != null) this.ChangePage(Tabs.Login);
        }

        private void MainPage_DataReceived()
        {
            if (this.Data != null && this.Data.Length == 2)
            {
                // gettind new data
                this.user = (Person)this.Data[0];
                this.family = (Family?)this.Data[1];

                // analyzing data
                if (this.family != null) this.btn_family.Enabled = true;
                else this.btn_family.Enabled = false;

                this.LoadData();
                this.Page_Select(this.btn_profile, null);
            }
        }

        private void LoadData()
        {
            try
            {
                using (HomePharmacyContext context = new HomePharmacyContext())
                {
                    // clear all previous data
                    this.illnesses.Clear();
                    this.medicines.Clear();

                    // load medicines types
                    DBValidation.MedicineValidation.types = context.MedicinesTypes.ToArray();

                    // load new data
                    if (this.family != null)
                    {
                        // load illnesses and appointments
                        var people = this.family.People.ToArray();
                        for (int i = 0; i < people.Length; i++)
                        {
                            var illnesses = context.Persons.Where(x => x.Email == people[i].Email).SelectMany(s => s.Illnesses).Include(c => c.Appointments).ToList();
                            if(illnesses.Count > 0) this.illnesses.AddRange(illnesses);
                        }

                        // load medicines
                        this.medicines = context.Families.Where(x => x.IdFamily == this.family.IdFamily).SelectMany(s => s.Medicines).ToList();
                    }
                    else
                    {
                        // load illnesses and appointments
                        this.illnesses = context.Persons.Where(x => x.Email == this.user.Email).SelectMany(s => s.Illnesses).Include(c => c.Appointments).ToList();

                        // load medicines
                        this.medicines = context.Medicines.Where(x => x.BelongsToFamily == null && x.ForWhom == this.user.Email).ToList();
                    }
                }

                // give data to the pages
                this.profilePage.Data = new object[1] { this.user }; // profile page
                this.familyPage.Data = new object[2] { this.user, this.family }; // family page
                this.illnessesPage.Data = new object[3] { this.user,this.family,this.illnesses }; // illnesses page
                this.medicinesPage.Data = new object[3] { this.user, this.family, this.medicines }; // medicines page
            }
            catch(Exception ex)
            {
                this.flowPanelTabs.Controls.Cast<PhIcon>().ToList().ForEach(x => x.Enabled = false);
                MessageBox.Show(ex.ToString(), "Loading data exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

namespace HomePharmacy.MainPages
{
    public delegate void ChangeMainPageEvent(MainTabs next, params object[]? data);

    public enum MainTabs
    {
        Profile,
        Family,
        Illnesses,
        Appointments,
        Medicines,
        TakeMedicines,
        Statisctics
    }
}
