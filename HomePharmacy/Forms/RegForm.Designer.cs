namespace HomePharmacy.Forms
{
    partial class RegForm
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
            this.lb_password_check = new System.Windows.Forms.Label();
            this.tb_password = new HomePharmacy.Controls.PhTextBox();
            this.lb_email_check = new System.Windows.Forms.Label();
            this.tb_name = new HomePharmacy.Controls.PhTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reg = new HomePharmacy.Controls.PhButton();
            this.btn_back = new HomePharmacy.Controls.PhButton();
            this.tb_birthdate = new HomePharmacy.Controls.PhTextBox();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.tb_sex = new HomePharmacy.Controls.PhTextBox();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Transparent;
            this.tb_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.tb_email.BorderRadius = 10;
            this.tb_email.FillColor = System.Drawing.Color.White;
            this.tb_email.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_email.Location = new System.Drawing.Point(447, 81);
            this.tb_email.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordMode = false;
            this.tb_email.PhText = "";
            this.tb_email.Placeholder = "Email";
            this.tb_email.ShowBorder = true;
            this.tb_email.Size = new System.Drawing.Size(274, 30);
            this.tb_email.TabIndex = 7;
            // 
            // lb_password_check
            // 
            this.lb_password_check.AutoSize = true;
            this.lb_password_check.BackColor = System.Drawing.Color.Transparent;
            this.lb_password_check.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_password_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_password_check.Location = new System.Drawing.Point(447, 165);
            this.lb_password_check.Name = "lb_password_check";
            this.lb_password_check.Size = new System.Drawing.Size(149, 15);
            this.lb_password_check.TabIndex = 10;
            this.lb_password_check.Text = "You password is too short";
            this.lb_password_check.Visible = false;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Transparent;
            this.tb_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.tb_password.BorderRadius = 10;
            this.tb_password.FillColor = System.Drawing.Color.White;
            this.tb_password.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_password.Location = new System.Drawing.Point(447, 132);
            this.tb_password.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordMode = true;
            this.tb_password.PhText = "";
            this.tb_password.Placeholder = "Password";
            this.tb_password.ShowBorder = true;
            this.tb_password.Size = new System.Drawing.Size(274, 30);
            this.tb_password.TabIndex = 8;
            // 
            // lb_email_check
            // 
            this.lb_email_check.AutoSize = true;
            this.lb_email_check.BackColor = System.Drawing.Color.Transparent;
            this.lb_email_check.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_email_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_email_check.Location = new System.Drawing.Point(447, 114);
            this.lb_email_check.Name = "lb_email_check";
            this.lb_email_check.Size = new System.Drawing.Size(174, 15);
            this.lb_email_check.TabIndex = 9;
            this.lb_email_check.Text = "You email address is too short";
            this.lb_email_check.Visible = false;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.Transparent;
            this.tb_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.tb_name.BorderRadius = 10;
            this.tb_name.FillColor = System.Drawing.Color.White;
            this.tb_name.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_name.Location = new System.Drawing.Point(447, 183);
            this.tb_name.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordMode = false;
            this.tb_name.PhText = "";
            this.tb_name.Placeholder = "Name";
            this.tb_name.ShowBorder = true;
            this.tb_name.Size = new System.Drawing.Size(274, 30);
            this.tb_name.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(447, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Your name is too short";
            this.label1.Visible = false;
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
            this.btn_reg.Location = new System.Drawing.Point(447, 355);
            this.btn_reg.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.ShowBorder = true;
            this.btn_reg.Size = new System.Drawing.Size(274, 30);
            this.btn_reg.TabIndex = 15;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_back.BorderRadius = 10;
            this.btn_back.Caption = "Back";
            this.btn_back.FillColor = System.Drawing.Color.White;
            this.btn_back.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_back.HoverFillColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(447, 391);
            this.btn_back.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShowBorder = true;
            this.btn_back.Size = new System.Drawing.Size(274, 30);
            this.btn_back.TabIndex = 16;
            // 
            // tb_birthdate
            // 
            this.tb_birthdate.BackColor = System.Drawing.Color.Transparent;
            this.tb_birthdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.tb_birthdate.BorderRadius = 10;
            this.tb_birthdate.FillColor = System.Drawing.Color.White;
            this.tb_birthdate.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_birthdate.Location = new System.Drawing.Point(447, 285);
            this.tb_birthdate.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_birthdate.Name = "tb_birthdate";
            this.tb_birthdate.PasswordMode = false;
            this.tb_birthdate.PhText = "";
            this.tb_birthdate.Placeholder = "BirthDate";
            this.tb_birthdate.ShowBorder = true;
            this.tb_birthdate.Size = new System.Drawing.Size(274, 30);
            this.tb_birthdate.TabIndex = 17;
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.BackColor = System.Drawing.Color.Transparent;
            this.lb_birthdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_birthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_birthdate.Location = new System.Drawing.Point(447, 318);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(146, 15);
            this.lb_birthdate.TabIndex = 18;
            this.lb_birthdate.Text = "Your birthdate is too short";
            this.lb_birthdate.Visible = false;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_title.Location = new System.Drawing.Point(437, 24);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(300, 36);
            this.lb_title.TabIndex = 19;
            this.lb_title.Text = "HOME PHARMACY";
            // 
            // tb_sex
            // 
            this.tb_sex.BackColor = System.Drawing.Color.Transparent;
            this.tb_sex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.tb_sex.BorderRadius = 10;
            this.tb_sex.FillColor = System.Drawing.Color.White;
            this.tb_sex.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_sex.Location = new System.Drawing.Point(447, 234);
            this.tb_sex.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_sex.Name = "tb_sex";
            this.tb_sex.PasswordMode = false;
            this.tb_sex.PhText = "";
            this.tb_sex.Placeholder = "Sex";
            this.tb_sex.ShowBorder = true;
            this.tb_sex.Size = new System.Drawing.Size(274, 30);
            this.tb_sex.TabIndex = 20;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomePharmacy.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_sex);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.tb_birthdate);
            this.Controls.Add(this.lb_birthdate);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_password_check);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_email_check);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Pharmacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PhTextBox tb_email;
        private Label lb_password_check;
        private Controls.PhTextBox tb_password;
        private Label lb_email_check;
        private Controls.PhTextBox tb_name;
        private Label label1;
        private Controls.PhButton btn_reg;
        private Controls.PhButton btn_back;
        private Controls.PhTextBox tb_birthdate;
        private Label lb_birthdate;
        private Label lb_title;
        private Controls.PhTextBox tb_sex;
    }
}