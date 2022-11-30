namespace HomePharmacy.MainPages
{
    partial class MedicinesPage
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
            this.btn_delete = new HomePharmacy.Controls.PhButton();
            this.btn_info = new HomePharmacy.Controls.PhButton();
            this.btn_update = new HomePharmacy.Controls.PhButton();
            this.btn_add = new HomePharmacy.Controls.PhButton();
            this.cb_type = new HomePharmacy.Controls.PhComboBox();
            this.chb_expired = new System.Windows.Forms.CheckBox();
            this.rb_expired = new HomePharmacy.Controls.RoundedBox();
            this.chb_used = new System.Windows.Forms.CheckBox();
            this.rb_used = new HomePharmacy.Controls.RoundedBox();
            this.btn_apply = new HomePharmacy.Controls.PhButton();
            this.btn_takemed = new HomePharmacy.Controls.PhButton();
            this.dgv_medicines = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicines)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_top
            // 
            this.rb_top.BackColor = System.Drawing.Color.Transparent;
            this.rb_top.BorderColor = System.Drawing.Color.ForestGreen;
            this.rb_top.BorderRadius = 0;
            this.rb_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_top.FillColor = System.Drawing.Color.White;
            this.rb_top.HoverBorderColor = System.Drawing.Color.ForestGreen;
            this.rb_top.HoverFillColor = System.Drawing.Color.White;
            this.rb_top.IsSelected = false;
            this.rb_top.Location = new System.Drawing.Point(0, 0);
            this.rb_top.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_top.Name = "rb_top";
            this.rb_top.ShowBorder = true;
            this.rb_top.Size = new System.Drawing.Size(753, 90);
            this.rb_top.TabIndex = 0;
            this.rb_top.TabStop = false;
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
            this.btn_delete.Location = new System.Drawing.Point(641, 12);
            this.btn_delete.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShowBorder = true;
            this.btn_delete.Size = new System.Drawing.Size(100, 31);
            this.btn_delete.TabIndex = 49;
            this.btn_delete.TabStop = false;
            this.btn_delete.PhClick += new System.EventHandler(this.btn_delete_PhClick);
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
            this.btn_info.Location = new System.Drawing.Point(288, 12);
            this.btn_info.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_info.Name = "btn_info";
            this.btn_info.ShowBorder = true;
            this.btn_info.Size = new System.Drawing.Size(126, 31);
            this.btn_info.TabIndex = 48;
            this.btn_info.TabStop = false;
            this.btn_info.PhClick += new System.EventHandler(this.btn_info_PhClick);
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
            this.btn_update.Location = new System.Drawing.Point(144, 12);
            this.btn_update.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShowBorder = true;
            this.btn_update.Size = new System.Drawing.Size(138, 31);
            this.btn_update.TabIndex = 47;
            this.btn_update.TabStop = false;
            this.btn_update.PhClick += new System.EventHandler(this.btn_update_PhClick);
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
            this.btn_add.Location = new System.Drawing.Point(12, 12);
            this.btn_add.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShowBorder = true;
            this.btn_add.Size = new System.Drawing.Size(126, 31);
            this.btn_add.TabIndex = 46;
            this.btn_add.TabStop = false;
            this.btn_add.PhClick += new System.EventHandler(this.btn_add_PhClick);
            // 
            // cb_type
            // 
            this.cb_type.BackColor = System.Drawing.Color.Transparent;
            this.cb_type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.cb_type.BorderRadius = 10;
            this.cb_type.FillColor = System.Drawing.Color.White;
            this.cb_type.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.cb_type.HoverFillColor = System.Drawing.Color.White;
            this.cb_type.IsSelected = false;
            this.cb_type.Location = new System.Drawing.Point(12, 49);
            this.cb_type.MinimumSize = new System.Drawing.Size(30, 30);
            this.cb_type.Name = "cb_type";
            this.cb_type.PhText = "Type";
            this.cb_type.Placeholder = "Type";
            this.cb_type.ShowBorder = true;
            this.cb_type.Size = new System.Drawing.Size(226, 31);
            this.cb_type.TabIndex = 51;
            this.cb_type.TabStop = false;
            // 
            // chb_expired
            // 
            this.chb_expired.AutoSize = true;
            this.chb_expired.BackColor = System.Drawing.Color.White;
            this.chb_expired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.chb_expired.Location = new System.Drawing.Point(254, 56);
            this.chb_expired.Name = "chb_expired";
            this.chb_expired.Size = new System.Drawing.Size(93, 19);
            this.chb_expired.TabIndex = 54;
            this.chb_expired.Text = "Only Expired";
            this.chb_expired.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_expired.UseVisualStyleBackColor = false;
            // 
            // rb_expired
            // 
            this.rb_expired.BackColor = System.Drawing.Color.Transparent;
            this.rb_expired.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_expired.BorderRadius = 10;
            this.rb_expired.FillColor = System.Drawing.Color.White;
            this.rb_expired.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_expired.HoverFillColor = System.Drawing.Color.White;
            this.rb_expired.IsSelected = false;
            this.rb_expired.Location = new System.Drawing.Point(244, 49);
            this.rb_expired.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_expired.Name = "rb_expired";
            this.rb_expired.ShowBorder = true;
            this.rb_expired.Size = new System.Drawing.Size(110, 31);
            this.rb_expired.TabIndex = 55;
            this.rb_expired.TabStop = false;
            // 
            // chb_used
            // 
            this.chb_used.AutoSize = true;
            this.chb_used.BackColor = System.Drawing.Color.White;
            this.chb_used.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.chb_used.Location = new System.Drawing.Point(371, 56);
            this.chb_used.Name = "chb_used";
            this.chb_used.Size = new System.Drawing.Size(80, 19);
            this.chb_used.TabIndex = 56;
            this.chb_used.Text = "Only Used";
            this.chb_used.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_used.UseVisualStyleBackColor = false;
            // 
            // rb_used
            // 
            this.rb_used.BackColor = System.Drawing.Color.Transparent;
            this.rb_used.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_used.BorderRadius = 10;
            this.rb_used.FillColor = System.Drawing.Color.White;
            this.rb_used.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_used.HoverFillColor = System.Drawing.Color.White;
            this.rb_used.IsSelected = false;
            this.rb_used.Location = new System.Drawing.Point(360, 49);
            this.rb_used.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_used.Name = "rb_used";
            this.rb_used.ShowBorder = true;
            this.rb_used.Size = new System.Drawing.Size(96, 31);
            this.rb_used.TabIndex = 57;
            this.rb_used.TabStop = false;
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.Transparent;
            this.btn_apply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_apply.BorderRadius = 10;
            this.btn_apply.Caption = "Apply filters";
            this.btn_apply.FillColor = System.Drawing.Color.White;
            this.btn_apply.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_apply.HoverFillColor = System.Drawing.Color.White;
            this.btn_apply.IsSelected = false;
            this.btn_apply.Location = new System.Drawing.Point(641, 49);
            this.btn_apply.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.ShowBorder = true;
            this.btn_apply.Size = new System.Drawing.Size(100, 31);
            this.btn_apply.TabIndex = 58;
            this.btn_apply.TabStop = false;
            this.btn_apply.PhClick += new System.EventHandler(this.btn_apply_PhClick);
            // 
            // btn_takemed
            // 
            this.btn_takemed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_takemed.AutoSize = true;
            this.btn_takemed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_takemed.BackColor = System.Drawing.Color.Transparent;
            this.btn_takemed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_takemed.BorderRadius = 10;
            this.btn_takemed.Caption = "Take medicine";
            this.btn_takemed.FillColor = System.Drawing.Color.White;
            this.btn_takemed.HoverBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_takemed.HoverFillColor = System.Drawing.Color.White;
            this.btn_takemed.IsSelected = false;
            this.btn_takemed.Location = new System.Drawing.Point(420, 12);
            this.btn_takemed.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_takemed.Name = "btn_takemed";
            this.btn_takemed.ShowBorder = true;
            this.btn_takemed.Size = new System.Drawing.Size(192, 31);
            this.btn_takemed.TabIndex = 59;
            this.btn_takemed.TabStop = false;
            // 
            // dgv_medicines
            // 
            this.dgv_medicines.AllowUserToAddRows = false;
            this.dgv_medicines.AllowUserToDeleteRows = false;
            this.dgv_medicines.AllowUserToResizeColumns = false;
            this.dgv_medicines.AllowUserToResizeRows = false;
            this.dgv_medicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_medicines.BackgroundColor = System.Drawing.Color.White;
            this.dgv_medicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medicines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_medicines.GridColor = System.Drawing.Color.ForestGreen;
            this.dgv_medicines.Location = new System.Drawing.Point(0, 90);
            this.dgv_medicines.MultiSelect = false;
            this.dgv_medicines.Name = "dgv_medicines";
            this.dgv_medicines.ReadOnly = true;
            this.dgv_medicines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_medicines.RowTemplate.Height = 25;
            this.dgv_medicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_medicines.Size = new System.Drawing.Size(753, 413);
            this.dgv_medicines.TabIndex = 50;
            // 
            // MedicinesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_takemed);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.chb_used);
            this.Controls.Add(this.rb_used);
            this.Controls.Add(this.chb_expired);
            this.Controls.Add(this.rb_expired);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.dgv_medicines);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rb_top);
            this.Name = "MedicinesPage";
            this.Size = new System.Drawing.Size(753, 503);
            this.DataReceived += new HomePharmacy.Controls.PhPage.GetData(this.MedicinesPage_DataReceived);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.RoundedBox rb_top;
        private Controls.PhButton btn_delete;
        private Controls.PhButton btn_info;
        private Controls.PhButton btn_update;
        private Controls.PhButton btn_add;
        private Controls.PhComboBox cb_type;
        private CheckBox chb_expired;
        private Controls.RoundedBox rb_expired;
        private CheckBox chb_used;
        private Controls.RoundedBox rb_used;
        private Controls.PhButton btn_apply;
        private Controls.PhButton btn_takemed;
        private DataGridView dgv_medicines;
    }
}
