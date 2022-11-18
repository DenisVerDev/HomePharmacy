using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePharmacy.Controls
{
    public partial class PhTextBox : RoundedBox
    {

        public string PhText
        {
            get { return this.tb1.Text; }
            set { this.tb1.Text = value; }
        }

        public string Placeholder
        {
            get { return this.tb1.PlaceholderText; }
            set { this.tb1.PlaceholderText = value; }
        }

        public bool PasswordMode
        {
            get { return this.tb1.UseSystemPasswordChar; }
            set{ this.tb1.UseSystemPasswordChar = value;}
        }

        public PhTextBox()
        {
            InitializeComponent();
            this.tb1.MouseEnter += this.RoundedBox_MouseEnter;
            this.tb1.MouseLeave += this.RoundedBox_MouseLeave;
            this.tb1.Click += this.RoundedBox_Click;

            this.PasswordMode = false;
        }

        private void PhTextBox_Resize(object sender, EventArgs e)
        {
            // y location
            int x = this.tb1.Location.X;
            int y = this.Height / 2 - this.tb1.Height / 2;
            this.tb1.Location = new Point(x, y);
        }

        private void PhTextBox_FillColorChanged(object sender, Color color)
        {
            this.tb1.BackColor = color;
        }

        private void PhTextBox_BorderColorChanged(object sender, Color color)
        {
            this.tb1.ForeColor = color;
        }
    }
}
