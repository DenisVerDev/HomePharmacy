using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePharmacy.TabPages
{
    public partial class CabinetSelectionPage : UserControl
    {
        public event PageChangeEvent? PageChange;

        public CabinetSelectionPage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btn_personalcab_PhClick(object sender, EventArgs e)
        {

        }

        private void btn_createfam_PhClick(object sender, EventArgs e)
        {

        }

        private void btn_back_PhClick(object sender, EventArgs e)
        {
            if (PageChange != null) PageChange(FormTabs.Login, null);
        }
    }
}
