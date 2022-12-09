namespace HomePharmacy.Forms
{
    partial class AppointmentForm
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
            this.rb_medicines = new HomePharmacy.Controls.RoundedBox();
            this.rb_recommendator = new HomePharmacy.Controls.RoundedBox();
            this.btn_action = new HomePharmacy.Controls.PhButton();
            this.tb_medicines = new System.Windows.Forms.TextBox();
            this.tb_recommendator = new System.Windows.Forms.TextBox();
            this.tb_usagesch = new System.Windows.Forms.TextBox();
            this.rb_usagesch = new HomePharmacy.Controls.RoundedBox();
            this.lb_usagesch_title = new System.Windows.Forms.Label();
            this.lb_med_title = new System.Windows.Forms.Label();
            this.lb_recommendator_title = new System.Windows.Forms.Label();
            this.dateAppCalendar = new System.Windows.Forms.MonthCalendar();
            this.lb_appdate = new System.Windows.Forms.Label();
            this.rb_appdate = new HomePharmacy.Controls.RoundedBox();
            this.SuspendLayout();
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
            this.rb_medicines.Location = new System.Drawing.Point(12, 12);
            this.rb_medicines.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_medicines.Name = "rb_medicines";
            this.rb_medicines.ShowBorder = true;
            this.rb_medicines.Size = new System.Drawing.Size(244, 325);
            this.rb_medicines.TabIndex = 0;
            this.rb_medicines.TabStop = false;
            // 
            // rb_recommendator
            // 
            this.rb_recommendator.BackColor = System.Drawing.Color.Transparent;
            this.rb_recommendator.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_recommendator.BorderRadius = 10;
            this.rb_recommendator.FillColor = System.Drawing.Color.White;
            this.rb_recommendator.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_recommendator.HoverFillColor = System.Drawing.Color.White;
            this.rb_recommendator.IsSelected = false;
            this.rb_recommendator.Location = new System.Drawing.Point(262, 12);
            this.rb_recommendator.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_recommendator.Name = "rb_recommendator";
            this.rb_recommendator.ShowBorder = true;
            this.rb_recommendator.Size = new System.Drawing.Size(244, 117);
            this.rb_recommendator.TabIndex = 2;
            this.rb_recommendator.TabStop = false;
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
            this.btn_action.Location = new System.Drawing.Point(12, 509);
            this.btn_action.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_action.Name = "btn_action";
            this.btn_action.ShowBorder = true;
            this.btn_action.Size = new System.Drawing.Size(494, 30);
            this.btn_action.TabIndex = 4;
            this.btn_action.TabStop = false;
            this.btn_action.PhClick += new System.EventHandler(this.btn_action_PhClick);
            // 
            // tb_medicines
            // 
            this.tb_medicines.BackColor = System.Drawing.Color.White;
            this.tb_medicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_medicines.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_medicines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_medicines.Location = new System.Drawing.Point(23, 49);
            this.tb_medicines.MaxLength = 320;
            this.tb_medicines.Multiline = true;
            this.tb_medicines.Name = "tb_medicines";
            this.tb_medicines.Size = new System.Drawing.Size(224, 277);
            this.tb_medicines.TabIndex = 5;
            // 
            // tb_recommendator
            // 
            this.tb_recommendator.BackColor = System.Drawing.Color.White;
            this.tb_recommendator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_recommendator.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_recommendator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_recommendator.Location = new System.Drawing.Point(273, 51);
            this.tb_recommendator.MaxLength = 100;
            this.tb_recommendator.Multiline = true;
            this.tb_recommendator.Name = "tb_recommendator";
            this.tb_recommendator.Size = new System.Drawing.Size(222, 65);
            this.tb_recommendator.TabIndex = 6;
            // 
            // tb_usagesch
            // 
            this.tb_usagesch.BackColor = System.Drawing.Color.White;
            this.tb_usagesch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_usagesch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_usagesch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_usagesch.Location = new System.Drawing.Point(23, 376);
            this.tb_usagesch.MaxLength = 400;
            this.tb_usagesch.Multiline = true;
            this.tb_usagesch.Name = "tb_usagesch";
            this.tb_usagesch.Size = new System.Drawing.Size(472, 100);
            this.tb_usagesch.TabIndex = 8;
            // 
            // rb_usagesch
            // 
            this.rb_usagesch.BackColor = System.Drawing.Color.Transparent;
            this.rb_usagesch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_usagesch.BorderRadius = 10;
            this.rb_usagesch.FillColor = System.Drawing.Color.White;
            this.rb_usagesch.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_usagesch.HoverFillColor = System.Drawing.Color.White;
            this.rb_usagesch.IsSelected = false;
            this.rb_usagesch.Location = new System.Drawing.Point(12, 343);
            this.rb_usagesch.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_usagesch.Name = "rb_usagesch";
            this.rb_usagesch.ShowBorder = true;
            this.rb_usagesch.Size = new System.Drawing.Size(494, 146);
            this.rb_usagesch.TabIndex = 3;
            this.rb_usagesch.TabStop = false;
            // 
            // lb_usagesch_title
            // 
            this.lb_usagesch_title.AutoSize = true;
            this.lb_usagesch_title.BackColor = System.Drawing.Color.White;
            this.lb_usagesch_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_usagesch_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_usagesch_title.Location = new System.Drawing.Point(23, 354);
            this.lb_usagesch_title.Name = "lb_usagesch_title";
            this.lb_usagesch_title.Size = new System.Drawing.Size(172, 16);
            this.lb_usagesch_title.TabIndex = 9;
            this.lb_usagesch_title.Text = "Medicine usage schedule:";
            // 
            // lb_med_title
            // 
            this.lb_med_title.AutoSize = true;
            this.lb_med_title.BackColor = System.Drawing.Color.White;
            this.lb_med_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_med_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_med_title.Location = new System.Drawing.Point(23, 23);
            this.lb_med_title.Name = "lb_med_title";
            this.lb_med_title.Size = new System.Drawing.Size(118, 16);
            this.lb_med_title.TabIndex = 10;
            this.lb_med_title.Text = "List of medicines:";
            // 
            // lb_recommendator_title
            // 
            this.lb_recommendator_title.AutoSize = true;
            this.lb_recommendator_title.BackColor = System.Drawing.Color.White;
            this.lb_recommendator_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_recommendator_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_recommendator_title.Location = new System.Drawing.Point(273, 23);
            this.lb_recommendator_title.Name = "lb_recommendator_title";
            this.lb_recommendator_title.Size = new System.Drawing.Size(116, 16);
            this.lb_recommendator_title.TabIndex = 12;
            this.lb_recommendator_title.Text = "Recommendator:";
            // 
            // dateAppCalendar
            // 
            this.dateAppCalendar.Location = new System.Drawing.Point(299, 167);
            this.dateAppCalendar.MaxSelectionCount = 1;
            this.dateAppCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateAppCalendar.Name = "dateAppCalendar";
            this.dateAppCalendar.TabIndex = 42;
            // 
            // lb_appdate
            // 
            this.lb_appdate.AutoSize = true;
            this.lb_appdate.BackColor = System.Drawing.Color.White;
            this.lb_appdate.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_appdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_appdate.Location = new System.Drawing.Point(273, 142);
            this.lb_appdate.Name = "lb_appdate";
            this.lb_appdate.Size = new System.Drawing.Size(124, 16);
            this.lb_appdate.TabIndex = 40;
            this.lb_appdate.Text = "Appointment date:";
            // 
            // rb_appdate
            // 
            this.rb_appdate.BackColor = System.Drawing.Color.Transparent;
            this.rb_appdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_appdate.BorderRadius = 10;
            this.rb_appdate.FillColor = System.Drawing.Color.White;
            this.rb_appdate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_appdate.HoverFillColor = System.Drawing.Color.White;
            this.rb_appdate.IsSelected = false;
            this.rb_appdate.Location = new System.Drawing.Point(262, 135);
            this.rb_appdate.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_appdate.Name = "rb_appdate";
            this.rb_appdate.ShowBorder = true;
            this.rb_appdate.Size = new System.Drawing.Size(244, 202);
            this.rb_appdate.TabIndex = 41;
            this.rb_appdate.TabStop = false;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomePharmacy.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 551);
            this.Controls.Add(this.dateAppCalendar);
            this.Controls.Add(this.lb_appdate);
            this.Controls.Add(this.rb_appdate);
            this.Controls.Add(this.lb_recommendator_title);
            this.Controls.Add(this.lb_med_title);
            this.Controls.Add(this.lb_usagesch_title);
            this.Controls.Add(this.tb_usagesch);
            this.Controls.Add(this.tb_recommendator);
            this.Controls.Add(this.tb_medicines);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.rb_usagesch);
            this.Controls.Add(this.rb_recommendator);
            this.Controls.Add(this.rb_medicines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Pharmacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.RoundedBox rb_medicines;
        private Controls.RoundedBox rb_recommendator;
        private Controls.PhButton btn_action;
        private TextBox tb_medicines;
        private TextBox tb_recommendator;
        private TextBox tb_usagesch;
        private Controls.RoundedBox rb_usagesch;
        private Label lb_usagesch_title;
        private Label lb_med_title;
        private Label lb_recommendator_title;
        private MonthCalendar dateAppCalendar;
        private Label lb_appdate;
        private Controls.RoundedBox rb_appdate;
    }
}