namespace HomePharmacy.Forms
{
    partial class LogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_email = new HomePharmacy.Controls.PhTextBox();
            this.tb_password = new HomePharmacy.Controls.PhTextBox();
            this.btn_log = new HomePharmacy.Controls.PhButton();
            this.btn_reg = new HomePharmacy.Controls.PhButton();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_email_check = new System.Windows.Forms.Label();
            this.lb_password_check = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Transparent;
            this.tb_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.tb_email.BorderRadius = 10;
            this.tb_email.FillColor = System.Drawing.Color.White;
            this.tb_email.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_email.HoverFillColor = System.Drawing.Color.White;
            this.tb_email.Location = new System.Drawing.Point(447, 122);
            this.tb_email.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordMode = false;
            this.tb_email.PhText = "";
            this.tb_email.Placeholder = "Email";
            this.tb_email.ShowBorder = true;
            this.tb_email.Size = new System.Drawing.Size(274, 30);
            this.tb_email.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Transparent;
            this.tb_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.tb_password.BorderRadius = 10;
            this.tb_password.FillColor = System.Drawing.Color.White;
            this.tb_password.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_password.HoverFillColor = System.Drawing.Color.White;
            this.tb_password.Location = new System.Drawing.Point(447, 197);
            this.tb_password.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordMode = true;
            this.tb_password.PhText = "";
            this.tb_password.Placeholder = "Password";
            this.tb_password.ShowBorder = true;
            this.tb_password.Size = new System.Drawing.Size(274, 30);
            this.tb_password.TabIndex = 1;
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.Color.Transparent;
            this.btn_log.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_log.BorderRadius = 10;
            this.btn_log.Caption = "Login";
            this.btn_log.FillColor = System.Drawing.Color.White;
            this.btn_log.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_log.HoverFillColor = System.Drawing.Color.White;
            this.btn_log.Location = new System.Drawing.Point(447, 321);
            this.btn_log.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_log.Name = "btn_log";
            this.btn_log.ShowBorder = true;
            this.btn_log.Size = new System.Drawing.Size(274, 30);
            this.btn_log.TabIndex = 2;
            this.btn_log.PhClick += new System.EventHandler(this.btn_log_PhClick);
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.Transparent;
            this.btn_reg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_reg.BorderRadius = 10;
            this.btn_reg.Caption = "Registration";
            this.btn_reg.FillColor = System.Drawing.Color.White;
            this.btn_reg.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_reg.HoverFillColor = System.Drawing.Color.White;
            this.btn_reg.Location = new System.Drawing.Point(447, 357);
            this.btn_reg.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.ShowBorder = true;
            this.btn_reg.Size = new System.Drawing.Size(274, 30);
            this.btn_reg.TabIndex = 3;
            this.btn_reg.PhClick += new System.EventHandler(this.btn_reg_PhClick);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_title.Location = new System.Drawing.Point(437, 40);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(300, 36);
            this.lb_title.TabIndex = 4;
            this.lb_title.Text = "HOME PHARMACY";
            // 
            // lb_email_check
            // 
            this.lb_email_check.AutoSize = true;
            this.lb_email_check.BackColor = System.Drawing.Color.Transparent;
            this.lb_email_check.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_email_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_email_check.Location = new System.Drawing.Point(447, 164);
            this.lb_email_check.Name = "lb_email_check";
            this.lb_email_check.Size = new System.Drawing.Size(0, 15);
            this.lb_email_check.TabIndex = 5;
            // 
            // lb_password_check
            // 
            this.lb_password_check.AutoSize = true;
            this.lb_password_check.BackColor = System.Drawing.Color.Transparent;
            this.lb_password_check.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_password_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_password_check.Location = new System.Drawing.Point(447, 239);
            this.lb_password_check.Name = "lb_password_check";
            this.lb_password_check.Size = new System.Drawing.Size(0, 15);
            this.lb_password_check.TabIndex = 6;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::HomePharmacy.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_password_check);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.lb_email_check);
            this.Controls.Add(this.btn_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Pharmacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PhTextBox tb_email;
        private Controls.PhTextBox tb_password;
        private Controls.PhButton btn_log;
        private Controls.PhButton btn_reg;
        private Label lb_title;
        private Label lb_email_check;
        private Label lb_password_check;
    }
}