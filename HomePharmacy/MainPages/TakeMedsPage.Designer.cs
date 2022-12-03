namespace HomePharmacy.MainPages
{
    partial class TakeMedsPage
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
            this.dgv_takemed = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_takemed)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_top
            // 
            this.rb_top.BackColor = System.Drawing.Color.Transparent;
            this.rb_top.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.rb_top.BorderRadius = 0;
            this.rb_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_top.FillColor = System.Drawing.Color.White;
            this.rb_top.HoverBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.rb_top.HoverFillColor = System.Drawing.Color.White;
            this.rb_top.IsSelected = false;
            this.rb_top.Location = new System.Drawing.Point(0, 0);
            this.rb_top.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_top.Name = "rb_top";
            this.rb_top.ShowBorder = true;
            this.rb_top.Size = new System.Drawing.Size(840, 56);
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
            this.btn_delete.Location = new System.Drawing.Point(702, 12);
            this.btn_delete.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShowBorder = true;
            this.btn_delete.Size = new System.Drawing.Size(126, 31);
            this.btn_delete.TabIndex = 53;
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
            this.btn_info.Location = new System.Drawing.Point(279, 12);
            this.btn_info.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_info.Name = "btn_info";
            this.btn_info.ShowBorder = true;
            this.btn_info.Size = new System.Drawing.Size(126, 31);
            this.btn_info.TabIndex = 52;
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
            this.btn_update.Location = new System.Drawing.Point(147, 12);
            this.btn_update.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_update.Name = "btn_update";
            this.btn_update.ShowBorder = true;
            this.btn_update.Size = new System.Drawing.Size(126, 31);
            this.btn_update.TabIndex = 51;
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
            this.btn_add.Location = new System.Drawing.Point(15, 12);
            this.btn_add.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShowBorder = true;
            this.btn_add.Size = new System.Drawing.Size(126, 31);
            this.btn_add.TabIndex = 50;
            this.btn_add.TabStop = false;
            this.btn_add.PhClick += new System.EventHandler(this.btn_add_PhClick);
            // 
            // dgv_takemed
            // 
            this.dgv_takemed.AllowUserToAddRows = false;
            this.dgv_takemed.AllowUserToDeleteRows = false;
            this.dgv_takemed.AllowUserToResizeColumns = false;
            this.dgv_takemed.AllowUserToResizeRows = false;
            this.dgv_takemed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_takemed.BackgroundColor = System.Drawing.Color.White;
            this.dgv_takemed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_takemed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_takemed.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dgv_takemed.Location = new System.Drawing.Point(0, 56);
            this.dgv_takemed.MultiSelect = false;
            this.dgv_takemed.Name = "dgv_takemed";
            this.dgv_takemed.ReadOnly = true;
            this.dgv_takemed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_takemed.RowTemplate.Height = 25;
            this.dgv_takemed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_takemed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_takemed.Size = new System.Drawing.Size(840, 526);
            this.dgv_takemed.TabIndex = 54;
            // 
            // TakeMedsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_takemed);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rb_top);
            this.Name = "TakeMedsPage";
            this.Size = new System.Drawing.Size(840, 582);
            this.DataReceived += new HomePharmacy.Controls.PhPage.GetData(this.TakeMedsPage_DataReceived);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_takemed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedBox rb_top;
        private Controls.PhButton btn_delete;
        private Controls.PhButton btn_info;
        private Controls.PhButton btn_update;
        private Controls.PhButton btn_add;
        private DataGridView dgv_takemed;
    }
}
