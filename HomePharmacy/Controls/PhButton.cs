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
        // Fill color when mouse enters contorl's area
        public Color HoverFillColor { get; set; }

        // Border color when mouse enters control's area
        public Color HoverBorderColor { get; set; }

        public string Caption
        {
            get { return this.lb_caption.Text; }
            set { this.lb_caption.Text = value; }
        }

        private Color prevFillColor;
        private Color prevBorderColor;

        public PhButton()
        {
            InitializeComponent();
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

        private void PhButton_MouseEnter(object sender, EventArgs e)
        {
            this.prevFillColor = this.FillColor;
            this.prevBorderColor = this.BorderColor;

            this.FillColor = this.HoverFillColor;
            this.BorderColor = this.HoverBorderColor;
        }

        private void PhButton_MouseLeave(object sender, EventArgs e)
        {
            this.FillColor = this.prevFillColor;
            this.BorderColor = this.prevBorderColor;
        }
    }
}
