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
using HomePharmacy.MainPages;
using HomePharmacy.Models;

namespace HomePharmacy.FormTab
{ 

    public partial class MainPage : PhPage
    {
        public event ChangePageEvent? ChangePage;

        private Person user;
        private Family? family;

        public MainPage()
        {
            InitializeComponent();
           
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
        }

        private void ChangeMainTabs(MainTabs next, params object[]? data)
        {
            try
            {
                // clear errors, input and other info
                //var current = this.tab_main.SelectedTab.Controls[0] as PhPage;
                //current.HideErrors();
                //current.ClearInput();

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

            this.ChangeMainTabs((MainTabs)button.Tag,this.user,this.family);
        }

        private void profilePage_LogoutEvent(object sender, EventArgs e)
        {
            if (this.ChangePage != null) this.ChangePage(Tabs.Login);
        }

        private void MainPage_DataReceived()
        {
            if (this.Data != null && this.Data.Length > 0)
            {
                this.user = (Person)this.Data[0];
                if (this.Data.Length > 1) this.family = (Family)this.Data[1];
                else this.family = null;

                this.Page_Select(this.btn_profile, null);
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
