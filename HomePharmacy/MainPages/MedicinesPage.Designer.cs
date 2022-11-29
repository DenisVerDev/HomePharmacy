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
            this.rb_top.Size = new System.Drawing.Size(753, 117);
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
            this.btn_delete.Location = new System.Drawing.Point(628, 76);
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
            this.btn_info.Location = new System.Drawing.Point(225, 76);
            this.btn_info.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_info.Name = "btn_info";
            this.btn_info.ShowBorder = true;
            this.btn_info.Size = new System.Drawing.Size(100, 31);
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
            this.btn_update.Location = new System.Drawing.Point(119, 76);
            this.btn_update.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShowBorder = true;
            this.btn_update.Size = new System.Drawing.Size(100, 31);
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
            this.btn_add.Location = new System.Drawing.Point(13, 76);
            this.btn_add.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShowBorder = true;
            this.btn_add.Size = new System.Drawing.Size(100, 31);
            this.btn_add.TabIndex = 46;
            this.btn_add.TabStop = false;
            this.btn_add.PhClick += new System.EventHandler(this.btn_add_PhClick);
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
            this.dgv_medicines.Location = new System.Drawing.Point(0, 117);
            this.dgv_medicines.MultiSelect = false;
            this.dgv_medicines.Name = "dgv_medicines";
            this.dgv_medicines.ReadOnly = true;
            this.dgv_medicines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_medicines.RowTemplate.Height = 25;
            this.dgv_medicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_medicines.Size = new System.Drawing.Size(753, 386);
            this.dgv_medicines.TabIndex = 50;
            // 
            // MedicinesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

        }

        #endregion

        private Controls.RoundedBox rb_top;
        private Controls.PhButton btn_delete;
        private Controls.PhButton btn_info;
        private Controls.PhButton btn_update;
        private Controls.PhButton btn_add;
        private DataGridView dgv_medicines;
    }
}
