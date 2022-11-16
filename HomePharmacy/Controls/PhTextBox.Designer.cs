namespace HomePharmacy.Controls
{
    partial class PhTextBox
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb1.Location = new System.Drawing.Point(14, 4);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(246, 16);
            this.tb1.TabIndex = 0;
            // 
            // PhTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb1);
            this.MinimumSize = new System.Drawing.Size(100, 30);
            this.Name = "PhTextBox";
            this.Size = new System.Drawing.Size(274, 30);
            this.FillColorChanged += new HomePharmacy.Controls.RoundedBox.RoundedBoxColorEvent(this.PhTextBox_FillColorChanged);
            this.BorderColorChanged += new HomePharmacy.Controls.RoundedBox.RoundedBoxColorEvent(this.PhTextBox_BorderColorChanged);
            this.Resize += new System.EventHandler(this.PhTextBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb1;
    }
}
