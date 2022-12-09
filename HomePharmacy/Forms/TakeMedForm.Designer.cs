namespace HomePharmacy.Forms
{
    partial class TakeMedForm
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
            this.dgv_illnesses = new System.Windows.Forms.DataGridView();
            this.rb_illnesses = new HomePharmacy.Controls.RoundedBox();
            this.rb_medicines = new HomePharmacy.Controls.RoundedBox();
            this.dgv_medicines = new System.Windows.Forms.DataGridView();
            this.cb_result = new HomePharmacy.Controls.PhComboBox();
            this.nm_count = new System.Windows.Forms.NumericUpDown();
            this.lb_count_title = new System.Windows.Forms.Label();
            this.rb_count = new HomePharmacy.Controls.RoundedBox();
            this.lb_av_count = new System.Windows.Forms.Label();
            this.dateUseCalendar = new System.Windows.Forms.MonthCalendar();
            this.lb_usedate_title = new System.Windows.Forms.Label();
            this.rb_usedate = new HomePharmacy.Controls.RoundedBox();
            this.lb_comment_title = new System.Windows.Forms.Label();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.rb_comment = new HomePharmacy.Controls.RoundedBox();
            this.btn_action = new HomePharmacy.Controls.PhButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_illnesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_count)).BeginInit();
            this.SuspendLayout();
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
            this.dgv_illnesses.GridColor = System.Drawing.Color.Firebrick;
            this.dgv_illnesses.Location = new System.Drawing.Point(26, 20);
            this.dgv_illnesses.MultiSelect = false;
            this.dgv_illnesses.Name = "dgv_illnesses";
            this.dgv_illnesses.ReadOnly = true;
            this.dgv_illnesses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_illnesses.RowTemplate.Height = 25;
            this.dgv_illnesses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_illnesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_illnesses.Size = new System.Drawing.Size(509, 144);
            this.dgv_illnesses.TabIndex = 41;
            this.dgv_illnesses.TabStop = false;
            this.dgv_illnesses.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_illnesses_DataBindingComplete);
            this.dgv_illnesses.SelectionChanged += new System.EventHandler(this.dgv_illnesses_SelectionChanged);
            // 
            // rb_illnesses
            // 
            this.rb_illnesses.BackColor = System.Drawing.Color.Transparent;
            this.rb_illnesses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_illnesses.BorderRadius = 10;
            this.rb_illnesses.FillColor = System.Drawing.Color.White;
            this.rb_illnesses.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_illnesses.HoverFillColor = System.Drawing.Color.White;
            this.rb_illnesses.IsSelected = false;
            this.rb_illnesses.Location = new System.Drawing.Point(12, 12);
            this.rb_illnesses.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_illnesses.Name = "rb_illnesses";
            this.rb_illnesses.ShowBorder = true;
            this.rb_illnesses.Size = new System.Drawing.Size(541, 166);
            this.rb_illnesses.TabIndex = 42;
            this.rb_illnesses.TabStop = false;
            // 
            // rb_medicines
            // 
            this.rb_medicines.BackColor = System.Drawing.Color.Transparent;
            this.rb_medicines.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_medicines.BorderRadius = 10;
            this.rb_medicines.FillColor = System.Drawing.Color.White;
            this.rb_medicines.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_medicines.HoverFillColor = System.Drawing.Color.White;
            this.rb_medicines.IsSelected = false;
            this.rb_medicines.Location = new System.Drawing.Point(12, 184);
            this.rb_medicines.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_medicines.Name = "rb_medicines";
            this.rb_medicines.ShowBorder = true;
            this.rb_medicines.Size = new System.Drawing.Size(541, 154);
            this.rb_medicines.TabIndex = 43;
            this.rb_medicines.TabStop = false;
            // 
            // dgv_medicines
            // 
            this.dgv_medicines.AllowUserToAddRows = false;
            this.dgv_medicines.AllowUserToDeleteRows = false;
            this.dgv_medicines.AllowUserToResizeColumns = false;
            this.dgv_medicines.AllowUserToResizeRows = false;
            this.dgv_medicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_medicines.BackgroundColor = System.Drawing.Color.White;
            this.dgv_medicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_medicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medicines.GridColor = System.Drawing.Color.ForestGreen;
            this.dgv_medicines.Location = new System.Drawing.Point(26, 200);
            this.dgv_medicines.MultiSelect = false;
            this.dgv_medicines.Name = "dgv_medicines";
            this.dgv_medicines.ReadOnly = true;
            this.dgv_medicines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_medicines.RowTemplate.Height = 25;
            this.dgv_medicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_medicines.Size = new System.Drawing.Size(509, 125);
            this.dgv_medicines.TabIndex = 51;
            this.dgv_medicines.TabStop = false;
            this.dgv_medicines.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_medicines_DataBindingComplete);
            this.dgv_medicines.SelectionChanged += new System.EventHandler(this.dgv_medicines_SelectionChanged);
            // 
            // cb_result
            // 
            this.cb_result.BackColor = System.Drawing.Color.Transparent;
            this.cb_result.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.cb_result.BorderRadius = 10;
            this.cb_result.FillColor = System.Drawing.Color.White;
            this.cb_result.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.cb_result.HoverFillColor = System.Drawing.Color.White;
            this.cb_result.IsSelected = false;
            this.cb_result.Location = new System.Drawing.Point(12, 344);
            this.cb_result.MinimumSize = new System.Drawing.Size(30, 30);
            this.cb_result.Name = "cb_result";
            this.cb_result.PhText = "Usage result";
            this.cb_result.Placeholder = "Usage result";
            this.cb_result.ShowBorder = true;
            this.cb_result.Size = new System.Drawing.Size(255, 31);
            this.cb_result.TabIndex = 52;
            this.cb_result.TabStop = false;
            // 
            // nm_count
            // 
            this.nm_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nm_count.Location = new System.Drawing.Point(111, 388);
            this.nm_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_count.Name = "nm_count";
            this.nm_count.Size = new System.Drawing.Size(145, 23);
            this.nm_count.TabIndex = 55;
            this.nm_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_count_title
            // 
            this.lb_count_title.AutoSize = true;
            this.lb_count_title.BackColor = System.Drawing.Color.White;
            this.lb_count_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_count_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_count_title.Location = new System.Drawing.Point(26, 390);
            this.lb_count_title.Name = "lb_count_title";
            this.lb_count_title.Size = new System.Drawing.Size(48, 16);
            this.lb_count_title.TabIndex = 54;
            this.lb_count_title.Text = "Count:";
            // 
            // rb_count
            // 
            this.rb_count.BackColor = System.Drawing.Color.Transparent;
            this.rb_count.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_count.BorderRadius = 10;
            this.rb_count.FillColor = System.Drawing.Color.White;
            this.rb_count.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_count.HoverFillColor = System.Drawing.Color.White;
            this.rb_count.IsSelected = false;
            this.rb_count.Location = new System.Drawing.Point(12, 381);
            this.rb_count.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_count.Name = "rb_count";
            this.rb_count.ShowBorder = true;
            this.rb_count.Size = new System.Drawing.Size(255, 37);
            this.rb_count.TabIndex = 53;
            this.rb_count.TabStop = false;
            // 
            // lb_av_count
            // 
            this.lb_av_count.AutoEllipsis = true;
            this.lb_av_count.BackColor = System.Drawing.Color.White;
            this.lb_av_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_av_count.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_av_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_av_count.Location = new System.Drawing.Point(12, 421);
            this.lb_av_count.Name = "lb_av_count";
            this.lb_av_count.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lb_av_count.Size = new System.Drawing.Size(255, 16);
            this.lb_av_count.TabIndex = 56;
            this.lb_av_count.Text = "Avaiable count:";
            // 
            // dateUseCalendar
            // 
            this.dateUseCalendar.Location = new System.Drawing.Point(387, 352);
            this.dateUseCalendar.MaxSelectionCount = 1;
            this.dateUseCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateUseCalendar.Name = "dateUseCalendar";
            this.dateUseCalendar.TabIndex = 59;
            // 
            // lb_usedate_title
            // 
            this.lb_usedate_title.AutoSize = true;
            this.lb_usedate_title.BackColor = System.Drawing.Color.White;
            this.lb_usedate_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_usedate_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_usedate_title.Location = new System.Drawing.Point(284, 352);
            this.lb_usedate_title.Name = "lb_usedate_title";
            this.lb_usedate_title.Size = new System.Drawing.Size(82, 16);
            this.lb_usedate_title.TabIndex = 57;
            this.lb_usedate_title.Text = "Usage date:";
            // 
            // rb_usedate
            // 
            this.rb_usedate.BackColor = System.Drawing.Color.Transparent;
            this.rb_usedate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_usedate.BorderRadius = 10;
            this.rb_usedate.FillColor = System.Drawing.Color.White;
            this.rb_usedate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_usedate.HoverFillColor = System.Drawing.Color.White;
            this.rb_usedate.IsSelected = false;
            this.rb_usedate.Location = new System.Drawing.Point(273, 344);
            this.rb_usedate.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_usedate.Name = "rb_usedate";
            this.rb_usedate.ShowBorder = true;
            this.rb_usedate.Size = new System.Drawing.Size(280, 203);
            this.rb_usedate.TabIndex = 58;
            this.rb_usedate.TabStop = false;
            // 
            // lb_comment_title
            // 
            this.lb_comment_title.AutoSize = true;
            this.lb_comment_title.BackColor = System.Drawing.Color.White;
            this.lb_comment_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_comment_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_comment_title.Location = new System.Drawing.Point(19, 450);
            this.lb_comment_title.Name = "lb_comment_title";
            this.lb_comment_title.Size = new System.Drawing.Size(72, 16);
            this.lb_comment_title.TabIndex = 62;
            this.lb_comment_title.Text = "Comment:";
            // 
            // tb_comment
            // 
            this.tb_comment.BackColor = System.Drawing.Color.White;
            this.tb_comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_comment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_comment.Location = new System.Drawing.Point(23, 478);
            this.tb_comment.MaxLength = 200;
            this.tb_comment.Multiline = true;
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(224, 59);
            this.tb_comment.TabIndex = 61;
            // 
            // rb_comment
            // 
            this.rb_comment.BackColor = System.Drawing.Color.Transparent;
            this.rb_comment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_comment.BorderRadius = 10;
            this.rb_comment.FillColor = System.Drawing.Color.White;
            this.rb_comment.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_comment.HoverFillColor = System.Drawing.Color.White;
            this.rb_comment.IsSelected = false;
            this.rb_comment.Location = new System.Drawing.Point(12, 440);
            this.rb_comment.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_comment.Name = "rb_comment";
            this.rb_comment.ShowBorder = true;
            this.rb_comment.Size = new System.Drawing.Size(255, 107);
            this.rb_comment.TabIndex = 60;
            this.rb_comment.TabStop = false;
            // 
            // btn_action
            // 
            this.btn_action.BackColor = System.Drawing.Color.Transparent;
            this.btn_action.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_action.BorderRadius = 10;
            this.btn_action.Caption = "Action";
            this.btn_action.FillColor = System.Drawing.Color.White;
            this.btn_action.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_action.HoverFillColor = System.Drawing.Color.White;
            this.btn_action.IsSelected = false;
            this.btn_action.Location = new System.Drawing.Point(12, 573);
            this.btn_action.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_action.Name = "btn_action";
            this.btn_action.ShowBorder = true;
            this.btn_action.Size = new System.Drawing.Size(539, 30);
            this.btn_action.TabIndex = 63;
            this.btn_action.TabStop = false;
            this.btn_action.PhClick += new System.EventHandler(this.btn_action_PhClick);
            // 
            // TakeMedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomePharmacy.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 615);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.lb_comment_title);
            this.Controls.Add(this.tb_comment);
            this.Controls.Add(this.rb_comment);
            this.Controls.Add(this.dateUseCalendar);
            this.Controls.Add(this.lb_usedate_title);
            this.Controls.Add(this.rb_usedate);
            this.Controls.Add(this.lb_av_count);
            this.Controls.Add(this.nm_count);
            this.Controls.Add(this.lb_count_title);
            this.Controls.Add(this.rb_count);
            this.Controls.Add(this.cb_result);
            this.Controls.Add(this.dgv_medicines);
            this.Controls.Add(this.rb_medicines);
            this.Controls.Add(this.dgv_illnesses);
            this.Controls.Add(this.rb_illnesses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TakeMedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Pharmacy";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_illnesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_illnesses;
        private Controls.RoundedBox rb_illnesses;
        private Controls.RoundedBox rb_medicines;
        private DataGridView dgv_medicines;
        private Controls.PhComboBox cb_result;
        private NumericUpDown nm_count;
        private Label lb_count_title;
        private Controls.RoundedBox rb_count;
        private Label lb_av_count;
        private MonthCalendar dateUseCalendar;
        private Label lb_usedate_title;
        private Controls.RoundedBox rb_usedate;
        private Label lb_comment_title;
        private TextBox tb_comment;
        private Controls.RoundedBox rb_comment;
        private Controls.PhButton btn_action;
    }
}