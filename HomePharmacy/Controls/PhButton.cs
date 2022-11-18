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
    public partial class PhButton : RoundedBox
    {

        public string Caption
        {
            get { return this.lb_caption.Text; }
            set { this.lb_caption.Text = value; }
        }

        public PhButton()
        {
            InitializeComponent();
            this.lb_caption.MouseEnter += this.RoundedBox_MouseEnter;
            this.lb_caption.MouseLeave += this.RoundedBox_MouseLeave;
            this.lb_caption.Click += this.RoundedBox_Click;
        }

        private void PhButton_FillColorChanged(object sender, Color color)
        {
            this.lb_caption.BackColor = color;
        }

        private void PhButton_BorderColorChanged(object sender, Color color)
        {
            this.lb_caption.ForeColor = color;
        }

        private void PhButton_Resize(object sender, EventArgs e)
        {
            int x = this.Width / 2 - this.lb_caption.Width / 2;
            int y = this.Height / 2 - this.lb_caption.Height / 2;
            this.lb_caption.Location = new Point(x, y);
        }
    }
}
