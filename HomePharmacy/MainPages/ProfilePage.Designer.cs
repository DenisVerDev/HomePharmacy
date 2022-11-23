namespace HomePharmacy.MainPages
{
    partial class ProfilePage
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
            this.lb_email_title = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.rb_email = new HomePharmacy.Controls.RoundedBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_name_title = new System.Windows.Forms.Label();
            this.rb_name = new HomePharmacy.Controls.RoundedBox();
            this.lb_sex = new System.Windows.Forms.Label();
            this.lb_sex_title = new System.Windows.Forms.Label();
            this.rb_sex = new HomePharmacy.Controls.RoundedBox();
            this.rb_background = new HomePharmacy.Controls.RoundedBox();
            this.lb_datebirth = new System.Windows.Forms.Label();
            this.rb_datebirth = new HomePharmacy.Controls.RoundedBox();
            this.datebirthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btn_save = new HomePharmacy.Controls.PhButton();
            this.btn_logout = new HomePharmacy.Controls.PhButton();
            this.btn_remove = new HomePharmacy.Controls.PhButton();
            this.btn_changecab = new HomePharmacy.Controls.PhButton();
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
            this.phPhoto.Location = new System.Drawing.Point(63, 17);
            this.phPhoto.MinimumSize = new System.Drawing.Size(30, 30);
            this.phPhoto.Name = "phPhoto";
            this.phPhoto.ShowBorder = true;
            this.phPhoto.Size = new System.Drawing.Size(150, 150);
            this.phPhoto.TabIndex = 0;
            this.phPhoto.TabStop = false;
            this.phPhoto.PhClick += new System.EventHandler(this.phPhoto_PhClick);
            // 
            // lb_email_title
            // 
            this.lb_email_title.AutoSize = true;
            this.lb_email_title.BackColor = System.Drawing.Color.White;
            this.lb_email_title.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_email_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_email_title.Location = new System.Drawing.Point(76, 198);
            this.lb_email_title.Name = "lb_email_title";
            this.lb_email_title.Size = new System.Drawing.Size(45, 16);
            this.lb_email_title.TabIndex = 1;
            this.lb_email_title.Text = "Email:";
            // 
            // lb_email
            // 
            this.lb_email.AutoEllipsis = true;
            this.lb_email.AutoSize = true;
            this.lb_email.BackColor = System.Drawing.Color.White;
            this.lb_email.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_email.Location = new System.Drawing.Point(131, 198);
            this.lb_email.MaximumSize = new System.Drawing.Size(200, 16);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(107, 16);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "test@gmail.com";
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
            this.rb_email.Location = new System.Drawing.Point(63, 186);
            this.rb_email.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_email.Name = "rb_email";
            this.rb_email.ShowBorder = true;
            this.rb_email.Size = new System.Drawing.Size(280, 40);
            this.rb_email.TabIndex = 3;
            this.rb_email.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoEllipsis = true;
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.White;
            this.lb_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_name.Location = new System.Drawing.Point(131, 268);
            this.lb_name.MaximumSize = new System.Drawing.Size(200, 16);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(63, 16);
            this.lb_name.TabIndex = 5;
            this.lb_name.Text = "Test Test";
            // 
            // lb_name_title
            // 
            this.lb_name_title.AutoSize = true;
            this.lb_name_title.BackColor = System.Drawing.Color.White;
            this.lb_name_title.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_name_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_name_title.Location = new System.Drawing.Point(76, 268);
            this.lb_name_title.Name = "lb_name_title";
            this.lb_name_title.Size = new System.Drawing.Size(47, 16);
            this.lb_name_title.TabIndex = 4;
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
            this.rb_name.Location = new System.Drawing.Point(63, 256);
            this.rb_name.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_name.Name = "rb_name";
            this.rb_name.ShowBorder = true;
            this.rb_name.Size = new System.Drawing.Size(280, 40);
            this.rb_name.TabIndex = 6;
            this.rb_name.TabStop = false;
            // 
            // lb_sex
            // 
            this.lb_sex.AutoEllipsis = true;
            this.lb_sex.AutoSize = true;
            this.lb_sex.BackColor = System.Drawing.Color.White;
            this.lb_sex.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_sex.Location = new System.Drawing.Point(131, 338);
            this.lb_sex.MaximumSize = new System.Drawing.Size(200, 16);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(40, 16);
            this.lb_sex.TabIndex = 8;
            this.lb_sex.Text = "other";
            // 
            // lb_sex_title
            // 
            this.lb_sex_title.AutoSize = true;
            this.lb_sex_title.BackColor = System.Drawing.Color.White;
            this.lb_sex_title.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_sex_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_sex_title.Location = new System.Drawing.Point(76, 338);
            this.lb_sex_title.Name = "lb_sex_title";
            this.lb_sex_title.Size = new System.Drawing.Size(34, 16);
            this.lb_sex_title.TabIndex = 7;
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
            this.rb_sex.Location = new System.Drawing.Point(63, 326);
            this.rb_sex.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_sex.Name = "rb_sex";
            this.rb_sex.ShowBorder = true;
            this.rb_sex.Size = new System.Drawing.Size(280, 40);
            this.rb_sex.TabIndex = 9;
            this.rb_sex.TabStop = false;
            // 
            // rb_background
            // 
            this.rb_background.BackColor = System.Drawing.Color.Transparent;
            this.rb_background.BorderColor = System.Drawing.Color.DimGray;
            this.rb_background.BorderRadius = 0;
            this.rb_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_background.FillColor = System.Drawing.Color.White;
            this.rb_background.HoverBorderColor = System.Drawing.Color.DimGray;
            this.rb_background.HoverFillColor = System.Drawing.Color.White;
            this.rb_background.IsSelected = false;
            this.rb_background.Location = new System.Drawing.Point(0, 0);
            this.rb_background.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_background.Name = "rb_background";
            this.rb_background.ShowBorder = true;
            this.rb_background.Size = new System.Drawing.Size(979, 396);
            this.rb_background.TabIndex = 10;
            this.rb_background.TabStop = false;
            // 
            // lb_datebirth
            // 
            this.lb_datebirth.AutoSize = true;
            this.lb_datebirth.BackColor = System.Drawing.Color.White;
            this.lb_datebirth.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_datebirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_datebirth.Location = new System.Drawing.Point(381, 194);
            this.lb_datebirth.Name = "lb_datebirth";
            this.lb_datebirth.Size = new System.Drawing.Size(89, 16);
            this.lb_datebirth.TabIndex = 11;
            this.lb_datebirth.Text = "Date of birth:";
            // 
            // rb_datebirth
            // 
            this.rb_datebirth.BackColor = System.Drawing.Color.Transparent;
            this.rb_datebirth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_datebirth.BorderRadius = 10;
            this.rb_datebirth.FillColor = System.Drawing.Color.White;
            this.rb_datebirth.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_datebirth.HoverFillColor = System.Drawing.Color.White;
            this.rb_datebirth.IsSelected = false;
            this.rb_datebirth.Location = new System.Drawing.Point(368, 186);
            this.rb_datebirth.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_datebirth.Name = "rb_datebirth";
            this.rb_datebirth.ShowBorder = true;
            this.rb_datebirth.Size = new System.Drawing.Size(280, 180);
            this.rb_datebirth.TabIndex = 13;
            this.rb_datebirth.TabStop = false;
            // 
            // datebirthCalendar
            // 
            this.datebirthCalendar.Location = new System.Drawing.Point(482, 194);
            this.datebirthCalendar.MaxSelectionCount = 1;
            this.datebirthCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datebirthCalendar.Name = "datebirthCalendar";
            this.datebirthCalendar.TabIndex = 14;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_save.BorderRadius = 30;
            this.btn_save.Caption = "Save";
            this.btn_save.FillColor = System.Drawing.Color.White;
            this.btn_save.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_save.HoverFillColor = System.Drawing.Color.White;
            this.btn_save.IsSelected = false;
            this.btn_save.Location = new System.Drawing.Point(381, 326);
            this.btn_save.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowBorder = true;
            this.btn_save.Size = new System.Drawing.Size(89, 30);
            this.btn_save.TabIndex = 15;
            this.btn_save.TabStop = false;
            this.btn_save.PhClick += new System.EventHandler(this.btn_save_PhClick);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.White;
            this.btn_logout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_logout.BorderRadius = 30;
            this.btn_logout.Caption = "Logout";
            this.btn_logout.FillColor = System.Drawing.Color.White;
            this.btn_logout.HoverBorderColor = System.Drawing.Color.Firebrick;
            this.btn_logout.HoverFillColor = System.Drawing.Color.White;
            this.btn_logout.IsSelected = false;
            this.btn_logout.Location = new System.Drawing.Point(221, 137);
            this.btn_logout.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ShowBorder = true;
            this.btn_logout.Size = new System.Drawing.Size(122, 30);
            this.btn_logout.TabIndex = 16;
            this.btn_logout.TabStop = false;
            this.btn_logout.PhClick += new System.EventHandler(this.btn_logout_PhClick);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.White;
            this.btn_remove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_remove.BorderRadius = 30;
            this.btn_remove.Caption = "Remove photo";
            this.btn_remove.FillColor = System.Drawing.Color.White;
            this.btn_remove.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_remove.HoverFillColor = System.Drawing.Color.White;
            this.btn_remove.IsSelected = false;
            this.btn_remove.Location = new System.Drawing.Point(221, 43);
            this.btn_remove.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.ShowBorder = true;
            this.btn_remove.Size = new System.Drawing.Size(122, 30);
            this.btn_remove.TabIndex = 17;
            this.btn_remove.TabStop = false;
            this.btn_remove.PhClick += new System.EventHandler(this.btn_remove_PhClick);
            // 
            // btn_changecab
            // 
            this.btn_changecab.BackColor = System.Drawing.Color.White;
            this.btn_changecab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_changecab.BorderRadius = 30;
            this.btn_changecab.Caption = "Change cabinet";
            this.btn_changecab.FillColor = System.Drawing.Color.White;
            this.btn_changecab.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_changecab.HoverFillColor = System.Drawing.Color.White;
            this.btn_changecab.IsSelected = false;
            this.btn_changecab.Location = new System.Drawing.Point(221, 90);
            this.btn_changecab.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_changecab.Name = "btn_changecab";
            this.btn_changecab.ShowBorder = true;
            this.btn_changecab.Size = new System.Drawing.Size(122, 30);
            this.btn_changecab.TabIndex = 18;
            this.btn_changecab.TabStop = false;
            this.btn_changecab.PhClick += new System.EventHandler(this.btn_changecab_PhClick);
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_changecab);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.datebirthCalendar);
            this.Controls.Add(this.lb_datebirth);
            this.Controls.Add(this.rb_datebirth);
            this.Controls.Add(this.lb_sex);
            this.Controls.Add(this.lb_sex_title);
            this.Controls.Add(this.rb_sex);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_name_title);
            this.Controls.Add(this.rb_name);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_email_title);
            this.Controls.Add(this.phPhoto);
            this.Controls.Add(this.rb_email);
            this.Controls.Add(this.rb_background);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(979, 396);
            this.DataReceived += new HomePharmacy.Controls.PhPage.GetData(this.ProfilePage_DataReceived);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PhIcon phPhoto;
        private Label lb_email_title;
        private Label lb_email;
        private Controls.RoundedBox rb_email;
        private Label lb_name;
        private Label lb_name_title;
        private Controls.RoundedBox rb_name;
        private Label lb_sex;
        private Label lb_sex_title;
        private Controls.RoundedBox rb_sex;
        private Controls.RoundedBox rb_background;
        private Label lb_datebirth;
        private Controls.RoundedBox rb_datebirth;
        private MonthCalendar datebirthCalendar;
        private Controls.PhButton btn_save;
        private Controls.PhButton btn_logout;
        private Controls.PhButton btn_remove;
        private Controls.PhButton btn_changecab;
    }
}
