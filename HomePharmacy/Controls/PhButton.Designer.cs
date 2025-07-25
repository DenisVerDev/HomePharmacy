﻿namespace HomePharmacy.Controls
{
    partial class PhButton
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_caption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_caption
            // 
            this.lb_caption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_caption.AutoEllipsis = true;
            this.lb_caption.AutoSize = true;
            this.lb_caption.BackColor = System.Drawing.Color.Transparent;
            this.lb_caption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_caption.Location = new System.Drawing.Point(48, 63);
            this.lb_caption.Name = "lb_caption";
            this.lb_caption.Size = new System.Drawing.Size(45, 16);
            this.lb_caption.TabIndex = 0;
            this.lb_caption.Text = "label1";
            this.lb_caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_caption);
            this.Name = "PhButton";
            this.FillColorChanged += new HomePharmacy.Controls.RoundedBox.RoundedBoxColorEvent(this.PhButton_FillColorChanged);
            this.BorderColorChanged += new HomePharmacy.Controls.RoundedBox.RoundedBoxColorEvent(this.PhButton_BorderColorChanged);
            this.Load += new System.EventHandler(this.PhButton_Resize);
            this.Resize += new System.EventHandler(this.PhButton_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_caption;
    }
}
