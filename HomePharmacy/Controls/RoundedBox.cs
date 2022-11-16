using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePharmacy.Controls
{
    public partial class RoundedBox : UserControl
    {

        public delegate void RoundedBoxColorEvent(object sender, Color color);

        public event RoundedBoxColorEvent FillColorChanged;
        public event RoundedBoxColorEvent BorderColorChanged;

        public Color FillColor 
        {
            get { return this.fillColor; }
            set
            {
                this.fillColor = value;
                this.Invalidate();

                if (this.FillColorChanged != null)
                    this.FillColorChanged(this, this.fillColor);
            }
        }

        public Color BorderColor 
        {
            get { return this.borderColor; }
            set
            {
                this.borderColor = value;
                this.Invalidate();

                if (this.BorderColorChanged != null)
                    this.BorderColorChanged(this, this.borderColor);
            }
        }

        public int BorderRadius
        {
            get { return this.radius; }
            set
            {
                if (value >= 0 && value <= maxRadius) this.radius = value;
                else this.radius = 0;

                this.Invalidate();
            }
        }

        public bool ShowBorder 
        {
            get { return this.showBorder; } 
            set
            {
                this.showBorder = value;
                this.Invalidate();
            }
        }

        private const int maxRadius = 30;
        private const int thickness = 1;
        private const int offset = 1;

        private Color fillColor;
        private Color borderColor;

        private int radius;

        private bool showBorder;

        public RoundedBox()
        {
            InitializeComponent();

            this.fillColor = Color.White;
            this.borderColor = Color.Black;

            this.radius = 0;

            this.showBorder = true;
        }

        private void RoundedBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (this.radius > 0)
            {
                using(GraphicsPath gp =new GraphicsPath()) // ellipse arcs should be in specific order
                {
                    gp.AddArc(0,0,this.radius,this.radius,180,90);     // top left
                    gp.AddArc(this.Width - this.radius - offset, 0, this.radius,this.radius, 270, 90); //top right
                    gp.AddArc(this.Width - this.radius - offset, this.Height - this.radius - offset, this.radius, this.radius, 0, 90); // bottom right
                    gp.AddArc(0, this.Height - this.radius - offset, this.radius, this.radius, 90, 90); // bottom left
                    gp.CloseFigure();

                    e.Graphics.FillPath(new SolidBrush(this.fillColor), gp);
                    if (this.showBorder) e.Graphics.DrawPath(new Pen(this.borderColor, thickness), gp);
                }
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(this.fillColor), 0, 0, this.Width, this.Height);
                if (this.showBorder) e.Graphics.DrawRectangle(new Pen(this.borderColor, thickness), 0, 0, this.Width - offset, this.Height - offset);
            }
        }
    }
}
