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
    public partial class PhComboBox : RoundedBox
    {

        public string Caption
        {
            get { return this.caption; }
            set
            {
                this.caption = value;
                this.cb1.Text = value;
            }
        }

        public ComboBox.ObjectCollection Items
        {
            get { return this.cb1.Items; }
        }

        private string caption;

        public PhComboBox()
        {
            InitializeComponent();

            this.cb1.MouseEnter += this.RoundedBox_MouseEnter;
            this.cb1.LostFocus += this.RoundedBox_MouseLeave;

            this.FillColorChanged += this.PhComboBox_FillColorChanged;
            this.BorderColorChanged += this.PhComboBox_BorderColorChanged;
        }

        private void PhComboBox_Resize(object sender, EventArgs e)
        {
            // y location
            int x = this.cb1.Location.X;
            int y = this.Height / 2 - this.cb1.Height / 2;
            this.cb1.Location = new Point(x, y);
        }

        private void PhComboBox_BorderColorChanged(object sender, Color color)
        {
            this.cb1.ForeColor = color;
        }

        private void PhComboBox_FillColorChanged(object sender, Color color)
        {
            this.cb1.BackColor = color;
        }

        private void cb1_TextChanged(object sender, EventArgs e)
        {
            if (this.cb1.Text == String.Empty) this.cb1.Text = this.caption;
        }
    }
}
