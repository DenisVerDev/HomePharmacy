namespace HomePharmacy.MainPages
{
    partial class IllnessesPage
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
            this.cb_email = new HomePharmacy.Controls.PhComboBox();
            this.btn_apply = new HomePharmacy.Controls.PhButton();
            this.btn_appointments = new HomePharmacy.Controls.PhButton();
            this.btn_add = new HomePharmacy.Controls.PhButton();
            this.btn_delete = new HomePharmacy.Controls.PhButton();
            this.btn_update = new HomePharmacy.Controls.PhButton();
            this.dgv_illnesses = new System.Windows.Forms.DataGridView();
            this.btn_info = new HomePharmacy.Controls.PhButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_illnesses)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_top
            // 
            this.rb_top.BackColor = System.Drawing.Color.Transparent;
            this.rb_top.BorderColor = System.Drawing.Color.Firebrick;
            this.rb_top.BorderRadius = 0;
            this.rb_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_top.FillColor = System.Drawing.Color.White;
            this.rb_top.HoverBorderColor = System.Drawing.Color.Firebrick;
            this.rb_top.HoverFillColor = System.Drawing.Color.White;
            this.rb_top.IsSelected = false;
            this.rb_top.Location = new System.Drawing.Point(0, 0);
            this.rb_top.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_top.Name = "rb_top";
            this.rb_top.ShowBorder = true;
            this.rb_top.Size = new System.Drawing.Size(793, 88);
            this.rb_top.TabIndex = 0;
            this.rb_top.TabStop = false;
            // 
            // cb_email
            // 
            this.cb_email.BackColor = System.Drawing.Color.Transparent;
            this.cb_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.cb_email.BorderRadius = 10;
            this.cb_email.FillColor = System.Drawing.Color.White;
            this.cb_email.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.cb_email.HoverFillColor = System.Drawing.Color.White;
            this.cb_email.IsSelected = false;
            this.cb_email.Location = new System.Drawing.Point(18, 50);
            this.cb_email.MinimumSize = new System.Drawing.Size(30, 30);
            this.cb_email.Name = "cb_email";
            this.cb_email.PhText = "All";
            this.cb_email.Placeholder = "All";
            this.cb_email.ShowBorder = true;
            this.cb_email.Size = new System.Drawing.Size(274, 31);
            this.cb_email.TabIndex = 34;
            this.cb_email.TabStop = false;
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
            this.btn_apply.Location = new System.Drawing.Point(313, 50);
            this.btn_apply.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.ShowBorder = true;
            this.btn_apply.Size = new System.Drawing.Size(133, 31);
            this.btn_apply.TabIndex = 35;
            this.btn_apply.TabStop = false;
            this.btn_apply.PhClick += new System.EventHandler(this.btn_apply_PhClick);
            // 
            // btn_appointments
            // 
            this.btn_appointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_appointments.BackColor = System.Drawing.Color.Transparent;
            this.btn_appointments.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_appointments.BorderRadius = 10;
            this.btn_appointments.Caption = "Appointments";
            this.btn_appointments.FillColor = System.Drawing.Color.White;
            this.btn_appointments.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_appointments.HoverFillColor = System.Drawing.Color.White;
            this.btn_appointments.IsSelected = false;
            this.btn_appointments.Location = new System.Drawing.Point(644, 50);
            this.btn_appointments.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_appointments.Name = "btn_appointments";
            this.btn_appointments.ShowBorder = true;
            this.btn_appointments.Size = new System.Drawing.Size(133, 31);
            this.btn_appointments.TabIndex = 36;
            this.btn_appointments.TabStop = false;
            this.btn_appointments.PhClick += new System.EventHandler(this.btn_appointments_PhClick);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_add.BorderRadius = 10;
            this.btn_add.Caption = "Add";
            this.btn_add.FillColor = System.Drawing.Color.White;
            this.btn_add.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_add.HoverFillColor = System.Drawing.Color.White;
            this.btn_add.IsSelected = false;
            this.btn_add.Location = new System.Drawing.Point(18, 13);
            this.btn_add.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShowBorder = true;
            this.btn_add.Size = new System.Drawing.Size(73, 31);
            this.btn_add.TabIndex = 37;
            this.btn_add.TabStop = false;
            this.btn_add.PhClick += new System.EventHandler(this.btn_add_PhClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_delete.BorderRadius = 10;
            this.btn_delete.Caption = "Delete";
            this.btn_delete.FillColor = System.Drawing.Color.White;
            this.btn_delete.HoverBorderColor = System.Drawing.Color.Firebrick;
            this.btn_delete.HoverFillColor = System.Drawing.Color.White;
            this.btn_delete.IsSelected = false;
            this.btn_delete.Location = new System.Drawing.Point(644, 13);
            this.btn_delete.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShowBorder = true;
            this.btn_delete.Size = new System.Drawing.Size(133, 31);
            this.btn_delete.TabIndex = 38;
            this.btn_delete.TabStop = false;
            this.btn_delete.PhClick += new System.EventHandler(this.btn_delete_PhClick);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_update.BorderRadius = 10;
            this.btn_update.Caption = "Update";
            this.btn_update.FillColor = System.Drawing.Color.White;
            this.btn_update.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_update.HoverFillColor = System.Drawing.Color.White;
            this.btn_update.IsSelected = false;
            this.btn_update.Location = new System.Drawing.Point(97, 13);
            this.btn_update.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShowBorder = true;
            this.btn_update.Size = new System.Drawing.Size(87, 31);
            this.btn_update.TabIndex = 39;
            this.btn_update.TabStop = false;
            this.btn_update.PhClick += new System.EventHandler(this.btn_update_PhClick);
            // 
            // dgv_illnesses
            // 
            this.dgv_illnesses.AllowUserToAddRows = false;
            this.dgv_illnesses.AllowUserToDeleteRows = false;
            this.dgv_illnesses.AllowUserToResizeColumns = false;
            this.dgv_illnesses.AllowUserToResizeRows = false;
            this.dgv_illnesses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_illnesses.BackgroundColor = System.Drawing.Color.White;
            this.dgv_illnesses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_illnesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_illnesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_illnesses.GridColor = System.Drawing.Color.Firebrick;
            this.dgv_illnesses.Location = new System.Drawing.Point(0, 88);
            this.dgv_illnesses.MultiSelect = false;
            this.dgv_illnesses.Name = "dgv_illnesses";
            this.dgv_illnesses.ReadOnly = true;
            this.dgv_illnesses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_illnesses.RowTemplate.Height = 25;
            this.dgv_illnesses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_illnesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_illnesses.Size = new System.Drawing.Size(793, 404);
            this.dgv_illnesses.TabIndex = 40;
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.Transparent;
            this.btn_info.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_info.BorderRadius = 10;
            this.btn_info.Caption = "Information";
            this.btn_info.FillColor = System.Drawing.Color.White;
            this.btn_info.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_info.HoverFillColor = System.Drawing.Color.White;
            this.btn_info.IsSelected = false;
            this.btn_info.Location = new System.Drawing.Point(190, 13);
            this.btn_info.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_info.Name = "btn_info";
            this.btn_info.ShowBorder = true;
            this.btn_info.Size = new System.Drawing.Size(102, 31);
            this.btn_info.TabIndex = 41;
            this.btn_info.TabStop = false;
            this.btn_info.PhClick += new System.EventHandler(this.btn_info_PhClick);
            // 
            // IllnessesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.dgv_illnesses);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_appointments);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cb_email);
            this.Controls.Add(this.rb_top);
            this.Name = "IllnessesPage";
            this.Size = new System.Drawing.Size(793, 492);
            this.DataReceived += new HomePharmacy.Controls.PhPage.GetData(this.IllnessesPage_DataReceived);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_illnesses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedBox rb_top;
        private Controls.PhComboBox cb_email;
        private Controls.PhButton btn_apply;
        private Controls.PhButton btn_appointments;
        private Controls.PhButton btn_add;
        private Controls.PhButton btn_delete;
        private Controls.PhButton btn_update;
        private DataGridView dgv_illnesses;
        private Controls.PhButton btn_info;
    }
}
