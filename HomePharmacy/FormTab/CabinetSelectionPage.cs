﻿using System;
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
    public partial class CabinetSelectionPage : PhPage
    {
        public event ChangePageEvent? ChangePage;

        public CabinetSelectionPage()
        {
            InitializeComponent();
        }

        private void btn_personalcab_PhClick(object sender, EventArgs e)
        {

        }

        private void btn_createfam_PhClick(object sender, EventArgs e)
        {

        }

        private void btn_back_PhClick(object sender, EventArgs e)
        {
            if (ChangePage != null) ChangePage(Tabs.Login, null);
        }
    }
}