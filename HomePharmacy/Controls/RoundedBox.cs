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

        public event EventHandler PhClick; // custom click event, because WinForms doesn't consider user control as one element

        public Color FillColor 
        {
            get { return this.fillColor; }
            set
            {
                this.fillColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor 
        {
            get { return this.borderColor; }
            set
            {
                this.borderColor = value;
                this.Invalidate();
            }
        }

        public Color HoverBorderColor { get; set; }
        public Color HoverFillColor { get; set; }

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

        private Color actualFillColor;
        private Color actualBorderColor;

        private Color fillColor;
        private Color borderColor;

        private int radius;

        private bool showBorder;
        private bool mouseHover; // if mouse cursor is over control

        public RoundedBox()
        {
            InitializeComponent();
            this.Click += RoundedBox_Click;

            this.fillColor = Color.White;
            this.borderColor = Color.Black;
            this.HoverFillColor = this.fillColor;
            this.HoverBorderColor = this.borderColor;

            this.actualFillColor = this.fillColor;
            this.actualBorderColor = this.borderColor;

            this.radius = 0;

            this.showBorder = true;
            this.mouseHover = false;
        }

        private void Notify()
        {
            if (this.FillColorChanged != null)
                this.FillColorChanged(this, this.actualFillColor);

            if (this.BorderColorChanged != null)
                this.BorderColorChanged(this, this.actualBorderColor);
        }

        private void RoundedBox_Paint(object sender, PaintEventArgs e)
        {

            if (!this.mouseHover)
            {
                this.actualFillColor = this.fillColor;
                this.actualBorderColor = this.borderColor;
            }
            else
            {
                this.actualFillColor = this.HoverFillColor;
                this.actualBorderColor = this.HoverBorderColor;
            }

            this.Notify();

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

                    e.Graphics.FillPath(new SolidBrush(this.actualFillColor), gp);
                    if (this.showBorder) e.Graphics.DrawPath(new Pen(this.actualBorderColor, thickness), gp);
                }
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(this.actualFillColor), 0, 0, this.Width, this.Height);
                if (this.showBorder) e.Graphics.DrawRectangle(new Pen(this.actualBorderColor, thickness), 0, 0, this.Width - offset, this.Height - offset);
            }
        }

        protected void RoundedBox_MouseEnter(object sender, EventArgs e)
        {
            this.mouseHover = true;
            this.Invalidate();
        }

        protected void RoundedBox_MouseLeave(object sender, EventArgs e)
        {
            this.mouseHover = false;
            this.Invalidate();
        }

        protected void RoundedBox_Click(object? sender, EventArgs e)
        {
            if (PhClick != null) PhClick(sender, e);
        }
    }
}
