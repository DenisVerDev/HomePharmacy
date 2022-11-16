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
        // Border and text color when mouse enters control's area
        public Color HoverColor { get; set; }

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
            get { return this.passwordMode; }
            set
            {
                this.passwordMode = value;
                if (this.passwordMode) this.tb1.UseSystemPasswordChar = true;
                else this.tb1.UseSystemPasswordChar = false;
            }
        }

        private Color prevBorderColor;

        private bool passwordMode;

        public PhTextBox()
        {
            InitializeComponent();

            this.HoverColor = this.BorderColor;
            this.passwordMode = false;
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

        private void PhTextBox_MouseEnter(object sender, EventArgs e)
        {
            this.prevBorderColor = this.BorderColor;
            this.BorderColor = this.HoverColor;
        }

        private void PhTextBox_MouseLeave(object sender, EventArgs e)
        {
            this.BorderColor = this.prevBorderColor;
        }
    }
}
