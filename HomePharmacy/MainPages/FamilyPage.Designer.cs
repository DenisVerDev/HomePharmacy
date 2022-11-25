namespace HomePharmacy.MainPages
{
    partial class FamilyPage
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
            this.rb_top = new HomePharmacy.Controls.RoundedBox();
            this.cb_sex = new HomePharmacy.Controls.PhComboBox();
            this.btn_apply = new HomePharmacy.Controls.PhButton();
            this.btn_leave = new HomePharmacy.Controls.PhButton();
            this.tb_email = new HomePharmacy.Controls.PhTextBox();
            this.btn_add = new HomePharmacy.Controls.PhButton();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // rb_top
            // 
            this.rb_top.BackColor = System.Drawing.Color.Transparent;
            this.rb_top.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rb_top.BorderRadius = 0;
            this.rb_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_top.FillColor = System.Drawing.Color.White;
            this.rb_top.HoverBorderColor = System.Drawing.Color.DodgerBlue;
            this.rb_top.HoverFillColor = System.Drawing.Color.White;
            this.rb_top.IsSelected = false;
            this.rb_top.Location = new System.Drawing.Point(0, 0);
            this.rb_top.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_top.Name = "rb_top";
            this.rb_top.ShowBorder = true;
            this.rb_top.Size = new System.Drawing.Size(690, 89);
            this.rb_top.TabIndex = 0;
            this.rb_top.TabStop = false;
            // 
            // cb_sex
            // 
            this.cb_sex.BackColor = System.Drawing.Color.Transparent;
            this.cb_sex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.cb_sex.BorderRadius = 10;
            this.cb_sex.FillColor = System.Drawing.Color.White;
            this.cb_sex.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.cb_sex.HoverFillColor = System.Drawing.Color.White;
            this.cb_sex.IsSelected = false;
            this.cb_sex.Location = new System.Drawing.Point(19, 48);
            this.cb_sex.MinimumSize = new System.Drawing.Size(30, 30);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.PhText = "Sex";
            this.cb_sex.Placeholder = "Sex";
            this.cb_sex.ShowBorder = true;
            this.cb_sex.Size = new System.Drawing.Size(274, 31);
            this.cb_sex.TabIndex = 32;
            this.cb_sex.TabStop = false;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.Transparent;
            this.btn_apply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_apply.BorderRadius = 10;
            this.btn_apply.Caption = "Apply filter";
            this.btn_apply.FillColor = System.Drawing.Color.White;
            this.btn_apply.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_apply.HoverFillColor = System.Drawing.Color.White;
            this.btn_apply.IsSelected = false;
            this.btn_apply.Location = new System.Drawing.Point(316, 48);
            this.btn_apply.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.ShowBorder = true;
            this.btn_apply.Size = new System.Drawing.Size(133, 31);
            this.btn_apply.TabIndex = 33;
            this.btn_apply.TabStop = false;
            this.btn_apply.PhClick += new System.EventHandler(this.btn_apply_PhClick);
            // 
            // btn_leave
            // 
            this.btn_leave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_leave.BackColor = System.Drawing.Color.Transparent;
            this.btn_leave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_leave.BorderRadius = 10;
            this.btn_leave.Caption = "Leave family";
            this.btn_leave.FillColor = System.Drawing.Color.White;
            this.btn_leave.HoverBorderColor = System.Drawing.Color.Firebrick;
            this.btn_leave.HoverFillColor = System.Drawing.Color.White;
            this.btn_leave.IsSelected = false;
            this.btn_leave.Location = new System.Drawing.Point(558, 48);
            this.btn_leave.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.ShowBorder = true;
            this.btn_leave.Size = new System.Drawing.Size(119, 31);
            this.btn_leave.TabIndex = 34;
            this.btn_leave.TabStop = false;
            this.btn_leave.PhClick += new System.EventHandler(this.btn_leave_PhClick);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Transparent;
            this.tb_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.tb_email.BorderRadius = 10;
            this.tb_email.FillColor = System.Drawing.Color.White;
            this.tb_email.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_email.HoverFillColor = System.Drawing.Color.White;
            this.tb_email.IsSelected = false;
            this.tb_email.Location = new System.Drawing.Point(19, 12);
            this.tb_email.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordMode = false;
            this.tb_email.PhText = "";
            this.tb_email.Placeholder = "Other person\'s email";
            this.tb_email.ShowBorder = true;
            this.tb_email.Size = new System.Drawing.Size(274, 30);
            this.tb_email.TabIndex = 35;
            this.tb_email.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_add.BorderRadius = 10;
            this.btn_add.Caption = "Add new member";
            this.btn_add.FillColor = System.Drawing.Color.White;
            this.btn_add.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_add.HoverFillColor = System.Drawing.Color.White;
            this.btn_add.IsSelected = false;
            this.btn_add.Location = new System.Drawing.Point(316, 12);
            this.btn_add.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShowBorder = true;
            this.btn_add.Size = new System.Drawing.Size(133, 30);
            this.btn_add.TabIndex = 36;
            this.btn_add.TabStop = false;
            this.btn_add.PhClick += new System.EventHandler(this.btn_add_PhClick);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.White;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(0, 89);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.flowPanel.Size = new System.Drawing.Size(690, 388);
            this.flowPanel.TabIndex = 37;
            this.flowPanel.WrapContents = false;
            // 
            // FamilyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.btn_leave);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.rb_top);
            this.Name = "FamilyPage";
            this.Size = new System.Drawing.Size(690, 477);
            this.DataReceived += new HomePharmacy.Controls.PhPage.GetData(this.FamilyPage_DataReceived);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedBox rb_top;
        private Controls.PhComboBox cb_sex;
        private Controls.PhButton btn_apply;
        private Controls.PhButton btn_leave;
        private Controls.PhTextBox tb_email;
        private Controls.PhButton btn_add;
        private FlowLayoutPanel flowPanel;
    }
}
