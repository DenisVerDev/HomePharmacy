﻿namespace HomePharmacy.Controls
{
    partial class RoundedBox
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
            this.SuspendLayout();
            // 
            // RoundedBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.MinimumSize = new System.Drawing.Size(30, 30);
            this.Name = "RoundedBox";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RoundedBox_Paint);
            this.MouseEnter += new System.EventHandler(this.RoundedBox_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.RoundedBox_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
