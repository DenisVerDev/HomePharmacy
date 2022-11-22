using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePharmacy.Controls
{
    public partial class PhIcon : RoundedBox
    {

        public Image? IconImage 
        {
            get { return this.iconImage; } 
            set
            {
                this.iconImage = value;
                this.Invalidate();
            }
        }

        public float FillPercent
        {
            get { return this.fillPercent; }
            set
            {
                if (value >= 0 & value <= 1) this.fillPercent = value;
                else this.fillPercent = 0.5f;

                this.Invalidate();
            }
        }

        private Image? iconImage;

        private float fillPercent;

        private Color previousBorderColor;

        public PhIcon()
        {
            InitializeComponent();
        }

        private void PhIcon_Paint(object sender, PaintEventArgs e)
        {
            if(this.iconImage != null)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

                SizeF image_size = new SizeF(this.Width * this.FillPercent, this.Height * this.fillPercent);

                PointF image_loc = new PointF(this.Width/2 - image_size.Width / 2, this.Height/2 - image_size.Height / 2);

                e.Graphics.DrawImage(this.iconImage, new RectangleF(image_loc, image_size));
            }
        }

        private void PhIcon_BorderColorChanged(object sender, Color color)
        {

            if(this.iconImage != null && this.previousBorderColor != color)
            {
                try
                {
                    using (Graphics g = Graphics.FromImage(this.iconImage))
                    {
                        // Set the image attribute's color mappings
                        ColorMap[] colorMap = new ColorMap[1];
                        colorMap[0] = new ColorMap();
                        colorMap[0].OldColor = this.previousBorderColor;
                        colorMap[0].NewColor = color;

                        ImageAttributes attr = new ImageAttributes();
                        attr.SetRemapTable(colorMap);

                        // Draw using the color map
                        Rectangle rect = new Rectangle(0, 0, this.iconImage.Width, this.iconImage.Height);
                        g.DrawImage(this.iconImage, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
                    }

                    this.previousBorderColor = color;
                }
                catch(Exception ex)
                {

                }
            }
        }

        private void PhIcon_Load(object sender, EventArgs e)
        {
            this.previousBorderColor = this.BorderColor;
        }
    }
}
