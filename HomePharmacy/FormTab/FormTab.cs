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

namespace HomePharmacy.FormTab
{

    public delegate void ChangePageEvent(Tabs next, params object[]? data);

    public enum Tabs
    {
        Login,
        Registration,
        CabinetSelection,
        CreateFamily,
        Main
    }

    public partial class FormTab : UserControl
    {

        public FormTab()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            this.logPage.ChangePage += ChangePage;
            this.regPage.ChangePage += ChangePage;
            this.cabSelPage.ChangePage += ChangePage;

            this.tpage_log.Tag = Tabs.Login;
            this.tpage_reg.Tag = Tabs.Registration;
            this.tpage_cabsel.Tag = Tabs.CabinetSelection;
        }

        private void ChangePage(Tabs next, object? data)
        {
            try
            {
                // clear errors and input
                var current = this.tab_form.SelectedTab.Controls[0] as PhPage;
                current.HideErrors();
                current.ClearInput();

                // change tab
                var tab_pages = this.tab_form.TabPages.Cast<TabPage>().ToArray();
                var next_page = tab_pages.Where(x => (Tabs)x.Tag == next).FirstOrDefault();
                if (next_page != null)
                {
                    current = next_page.Controls[0] as PhPage;
                    current.Data = data;

                    this.tab_form.SelectTab(next_page);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Tab change exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
