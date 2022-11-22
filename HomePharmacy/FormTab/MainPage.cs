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
using HomePharmacy.MainTab;

namespace HomePharmacy.FormTab
{ 

    public partial class MainPage : PhPage
    {
        public event ChangePageEvent? ChangePage;

        public MainPage()
        {
            InitializeComponent();
           
            this.tpage_profile.Tag = MainTabs.Profile;
            this.tpage_family.Tag = MainTabs.Family;
            this.tpage_ilnesses.Tag = MainTabs.Illnesses;
            this.tpage_appoint.Tag = MainTabs.Appointments;
            this.tpage_medicines.Tag = MainTabs.Medicines;
            this.tpage_takemed.Tag = MainTabs.TakeMedicines;
            this.tpage_statistics.Tag = MainTabs.Statisctics;
        }

        private void ResetSelected()
        {
            int count = this.flowPanelTabs.Controls.Count;

            for (int i = 0; i < count; i++)
            {
                (this.flowPanelTabs.Controls[i] as PhIcon).IsSelected = false;
            }
        }

        private void ChangeMainTabs()
        {
            // do work here
        }

        private void Page_Select(object sender, EventArgs e)
        {
            this.ResetSelected();

            var button = (PhIcon)sender;
            button.IsSelected = true;
        }
    }
}

namespace HomePharmacy.MainTab
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
