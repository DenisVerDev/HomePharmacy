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
    public partial class MainPage : PhPage
    {
        public event ChangePageEvent? ChangePage;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
