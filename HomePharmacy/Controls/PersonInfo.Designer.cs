namespace HomePharmacy.Controls
{
    partial class PersonInfo
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
            this.phPhoto = new HomePharmacy.Controls.PhIcon();
            this.lb_sex = new System.Windows.Forms.Label();
            this.lb_sex_title = new System.Windows.Forms.Label();
            this.rb_sex = new HomePharmacy.Controls.RoundedBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_name_title = new System.Windows.Forms.Label();
            this.rb_name = new HomePharmacy.Controls.RoundedBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_email_title = new System.Windows.Forms.Label();
            this.rb_email = new HomePharmacy.Controls.RoundedBox();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.lb_birthdate_title = new System.Windows.Forms.Label();
            this.rb_birthdate = new HomePharmacy.Controls.RoundedBox();
            this.SuspendLayout();
            // 
            // phPhoto
            // 
            this.phPhoto.BackColor = System.Drawing.Color.Transparent;
            this.phPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.phPhoto.BorderRadius = 0;
            this.phPhoto.FillColor = System.Drawing.Color.White;
            this.phPhoto.FillPercent = 0.7F;
            this.phPhoto.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.phPhoto.HoverFillColor = System.Drawing.Color.White;
            this.phPhoto.IconImage = global::HomePharmacy.Properties.Resources.profile_photo;
            this.phPhoto.IsSelected = false;
            this.phPhoto.Location = new System.Drawing.Point(17, 16);
            this.phPhoto.MinimumSize = new System.Drawing.Size(30, 30);
            this.phPhoto.Name = "phPhoto";
            this.phPhoto.ShowBorder = true;
            this.phPhoto.Size = new System.Drawing.Size(160, 160);
            this.phPhoto.TabIndex = 1;
            this.phPhoto.TabStop = false;
            // 
            // lb_sex
            // 
            this.lb_sex.AutoEllipsis = true;
            this.lb_sex.AutoSize = true;
            this.lb_sex.BackColor = System.Drawing.Color.White;
            this.lb_sex.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_sex.Location = new System.Drawing.Point(251, 107);
            this.lb_sex.MaximumSize = new System.Drawing.Size(200, 16);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(40, 16);
            this.lb_sex.TabIndex = 17;
            this.lb_sex.Text = "other";
            // 
            // lb_sex_title
            // 
            this.lb_sex_title.AutoSize = true;
            this.lb_sex_title.BackColor = System.Drawing.Color.White;
            this.lb_sex_title.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sex_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_sex_title.Location = new System.Drawing.Point(196, 107);
            this.lb_sex_title.Name = "lb_sex_title";
            this.lb_sex_title.Size = new System.Drawing.Size(34, 16);
            this.lb_sex_title.TabIndex = 16;
            this.lb_sex_title.Text = "Sex:";
            // 
            // rb_sex
            // 
            this.rb_sex.BackColor = System.Drawing.Color.Transparent;
            this.rb_sex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_sex.BorderRadius = 10;
            this.rb_sex.FillColor = System.Drawing.Color.White;
            this.rb_sex.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_sex.HoverFillColor = System.Drawing.Color.White;
            this.rb_sex.IsSelected = false;
            this.rb_sex.Location = new System.Drawing.Point(183, 98);
            this.rb_sex.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_sex.Name = "rb_sex";
            this.rb_sex.ShowBorder = true;
            this.rb_sex.Size = new System.Drawing.Size(280, 35);
            this.rb_sex.TabIndex = 18;
            this.rb_sex.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoEllipsis = true;
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.White;
            this.lb_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_name.Location = new System.Drawing.Point(251, 66);
            this.lb_name.MaximumSize = new System.Drawing.Size(200, 16);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(63, 16);
            this.lb_name.TabIndex = 14;
            this.lb_name.Text = "Test Test";
            // 
            // lb_name_title
            // 
            this.lb_name_title.AutoSize = true;
            this.lb_name_title.BackColor = System.Drawing.Color.White;
            this.lb_name_title.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_name_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_name_title.Location = new System.Drawing.Point(196, 66);
            this.lb_name_title.Name = "lb_name_title";
            this.lb_name_title.Size = new System.Drawing.Size(47, 16);
            this.lb_name_title.TabIndex = 13;
            this.lb_name_title.Text = "Name:";
            // 
            // rb_name
            // 
            this.rb_name.BackColor = System.Drawing.Color.Transparent;
            this.rb_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_name.BorderRadius = 10;
            this.rb_name.FillColor = System.Drawing.Color.White;
            this.rb_name.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_name.HoverFillColor = System.Drawing.Color.White;
            this.rb_name.IsSelected = false;
            this.rb_name.Location = new System.Drawing.Point(183, 57);
            this.rb_name.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_name.Name = "rb_name";
            this.rb_name.ShowBorder = true;
            this.rb_name.Size = new System.Drawing.Size(280, 35);
            this.rb_name.TabIndex = 15;
            this.rb_name.TabStop = false;
            // 
            // lb_email
            // 
            this.lb_email.AutoEllipsis = true;
            this.lb_email.AutoSize = true;
            this.lb_email.BackColor = System.Drawing.Color.White;
            this.lb_email.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_email.Location = new System.Drawing.Point(251, 25);
            this.lb_email.MaximumSize = new System.Drawing.Size(200, 16);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(107, 16);
            this.lb_email.TabIndex = 11;
            this.lb_email.Text = "test@gmail.com";
            // 
            // lb_email_title
            // 
            this.lb_email_title.AutoSize = true;
            this.lb_email_title.BackColor = System.Drawing.Color.White;
            this.lb_email_title.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_email_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_email_title.Location = new System.Drawing.Point(196, 25);
            this.lb_email_title.Name = "lb_email_title";
            this.lb_email_title.Size = new System.Drawing.Size(45, 16);
            this.lb_email_title.TabIndex = 10;
            this.lb_email_title.Text = "Email:";
            // 
            // rb_email
            // 
            this.rb_email.BackColor = System.Drawing.Color.Transparent;
            this.rb_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_email.BorderRadius = 10;
            this.rb_email.FillColor = System.Drawing.Color.White;
            this.rb_email.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_email.HoverFillColor = System.Drawing.Color.White;
            this.rb_email.IsSelected = false;
            this.rb_email.Location = new System.Drawing.Point(183, 16);
            this.rb_email.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_email.Name = "rb_email";
            this.rb_email.ShowBorder = true;
            this.rb_email.Size = new System.Drawing.Size(280, 35);
            this.rb_email.TabIndex = 12;
            this.rb_email.TabStop = false;
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoEllipsis = true;
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.BackColor = System.Drawing.Color.White;
            this.lb_birthdate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_birthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_birthdate.Location = new System.Drawing.Point(267, 148);
            this.lb_birthdate.MaximumSize = new System.Drawing.Size(200, 16);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(79, 16);
            this.lb_birthdate.TabIndex = 20;
            this.lb_birthdate.Text = "01.01.2022";
            // 
            // lb_birthdate_title
            // 
            this.lb_birthdate_title.AutoSize = true;
            this.lb_birthdate_title.BackColor = System.Drawing.Color.White;
            this.lb_birthdate_title.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_birthdate_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_birthdate_title.Location = new System.Drawing.Point(196, 148);
            this.lb_birthdate_title.Name = "lb_birthdate_title";
            this.lb_birthdate_title.Size = new System.Drawing.Size(68, 16);
            this.lb_birthdate_title.TabIndex = 19;
            this.lb_birthdate_title.Text = "Birthdate:";
            // 
            // rb_birthdate
            // 
            this.rb_birthdate.BackColor = System.Drawing.Color.Transparent;
            this.rb_birthdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_birthdate.BorderRadius = 10;
            this.rb_birthdate.FillColor = System.Drawing.Color.White;
            this.rb_birthdate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_birthdate.HoverFillColor = System.Drawing.Color.White;
            this.rb_birthdate.IsSelected = false;
            this.rb_birthdate.Location = new System.Drawing.Point(183, 139);
            this.rb_birthdate.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_birthdate.Name = "rb_birthdate";
            this.rb_birthdate.ShowBorder = true;
            this.rb_birthdate.Size = new System.Drawing.Size(280, 35);
            this.rb_birthdate.TabIndex = 21;
            this.rb_birthdate.TabStop = false;
            // 
            // PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.Controls.Add(this.lb_birthdate);
            this.Controls.Add(this.lb_birthdate_title);
            this.Controls.Add(this.rb_birthdate);
            this.Controls.Add(this.lb_sex);
            this.Controls.Add(this.lb_sex_title);
            this.Controls.Add(this.rb_sex);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_name_title);
            this.Controls.Add(this.rb_name);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_email_title);
            this.Controls.Add(this.rb_email);
            this.Controls.Add(this.phPhoto);
            this.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.Name = "PersonInfo";
            this.Size = new System.Drawing.Size(484, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PhIcon phPhoto;
        private Label lb_sex;
        private Label lb_sex_title;
        private RoundedBox rb_sex;
        private Label lb_name;
        private Label lb_name_title;
        private RoundedBox rb_name;
        private Label lb_email;
        private Label lb_email_title;
        private RoundedBox rb_email;
        private Label lb_birthdate;
        private Label lb_birthdate_title;
        private RoundedBox roundedBox1;
        private RoundedBox rb_birthdate;
    }
}
