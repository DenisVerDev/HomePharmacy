namespace HomePharmacy.Forms
{
    partial class IllnessForm
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
            this.cb_email = new HomePharmacy.Controls.PhComboBox();
            this.tb_diagnose = new System.Windows.Forms.TextBox();
            this.rb_diagnoses = new HomePharmacy.Controls.RoundedBox();
            this.dateStartCalendar = new System.Windows.Forms.MonthCalendar();
            this.lb_startdate = new System.Windows.Forms.Label();
            this.rb_startdate = new HomePharmacy.Controls.RoundedBox();
            this.dateEndCalendar = new System.Windows.Forms.MonthCalendar();
            this.lb_enddate = new System.Windows.Forms.Label();
            this.rb_enddate = new HomePharmacy.Controls.RoundedBox();
            this.btn_action = new HomePharmacy.Controls.PhButton();
            this.chb_enddate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.cb_email.Location = new System.Drawing.Point(12, 43);
            this.cb_email.MinimumSize = new System.Drawing.Size(30, 30);
            this.cb_email.Name = "cb_email";
            this.cb_email.PhText = "Email";
            this.cb_email.Placeholder = "Email";
            this.cb_email.ShowBorder = true;
            this.cb_email.Size = new System.Drawing.Size(274, 31);
            this.cb_email.TabIndex = 33;
            this.cb_email.TabStop = false;
            // 
            // tb_diagnose
            // 
            this.tb_diagnose.BackColor = System.Drawing.Color.White;
            this.tb_diagnose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_diagnose.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_diagnose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_diagnose.Location = new System.Drawing.Point(21, 91);
            this.tb_diagnose.MaxLength = 400;
            this.tb_diagnose.Multiline = true;
            this.tb_diagnose.Name = "tb_diagnose";
            this.tb_diagnose.Size = new System.Drawing.Size(257, 308);
            this.tb_diagnose.TabIndex = 35;
            this.tb_diagnose.Text = "Diagnoses";
            // 
            // rb_diagnoses
            // 
            this.rb_diagnoses.BackColor = System.Drawing.Color.Transparent;
            this.rb_diagnoses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_diagnoses.BorderRadius = 10;
            this.rb_diagnoses.FillColor = System.Drawing.Color.White;
            this.rb_diagnoses.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_diagnoses.HoverFillColor = System.Drawing.Color.White;
            this.rb_diagnoses.IsSelected = false;
            this.rb_diagnoses.Location = new System.Drawing.Point(12, 80);
            this.rb_diagnoses.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_diagnoses.Name = "rb_diagnoses";
            this.rb_diagnoses.ShowBorder = true;
            this.rb_diagnoses.Size = new System.Drawing.Size(274, 329);
            this.rb_diagnoses.TabIndex = 36;
            this.rb_diagnoses.TabStop = false;
            // 
            // dateStartCalendar
            // 
            this.dateStartCalendar.Location = new System.Drawing.Point(417, 51);
            this.dateStartCalendar.MaxSelectionCount = 1;
            this.dateStartCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateStartCalendar.Name = "dateStartCalendar";
            this.dateStartCalendar.TabIndex = 39;
            // 
            // lb_startdate
            // 
            this.lb_startdate.AutoSize = true;
            this.lb_startdate.BackColor = System.Drawing.Color.White;
            this.lb_startdate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_startdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_startdate.Location = new System.Drawing.Point(316, 51);
            this.lb_startdate.Name = "lb_startdate";
            this.lb_startdate.Size = new System.Drawing.Size(73, 16);
            this.lb_startdate.TabIndex = 37;
            this.lb_startdate.Text = "Start date:";
            // 
            // rb_startdate
            // 
            this.rb_startdate.BackColor = System.Drawing.Color.Transparent;
            this.rb_startdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_startdate.BorderRadius = 10;
            this.rb_startdate.FillColor = System.Drawing.Color.White;
            this.rb_startdate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_startdate.HoverFillColor = System.Drawing.Color.White;
            this.rb_startdate.IsSelected = false;
            this.rb_startdate.Location = new System.Drawing.Point(303, 43);
            this.rb_startdate.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_startdate.Name = "rb_startdate";
            this.rb_startdate.ShowBorder = true;
            this.rb_startdate.Size = new System.Drawing.Size(280, 180);
            this.rb_startdate.TabIndex = 38;
            this.rb_startdate.TabStop = false;
            // 
            // dateEndCalendar
            // 
            this.dateEndCalendar.Location = new System.Drawing.Point(417, 237);
            this.dateEndCalendar.MaxSelectionCount = 1;
            this.dateEndCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateEndCalendar.Name = "dateEndCalendar";
            this.dateEndCalendar.TabIndex = 42;
            // 
            // lb_enddate
            // 
            this.lb_enddate.AutoSize = true;
            this.lb_enddate.BackColor = System.Drawing.Color.White;
            this.lb_enddate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_enddate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_enddate.Location = new System.Drawing.Point(316, 237);
            this.lb_enddate.Name = "lb_enddate";
            this.lb_enddate.Size = new System.Drawing.Size(68, 16);
            this.lb_enddate.TabIndex = 40;
            this.lb_enddate.Text = "End date:";
            // 
            // rb_enddate
            // 
            this.rb_enddate.BackColor = System.Drawing.Color.Transparent;
            this.rb_enddate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_enddate.BorderRadius = 10;
            this.rb_enddate.FillColor = System.Drawing.Color.White;
            this.rb_enddate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_enddate.HoverFillColor = System.Drawing.Color.White;
            this.rb_enddate.IsSelected = false;
            this.rb_enddate.Location = new System.Drawing.Point(303, 229);
            this.rb_enddate.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_enddate.Name = "rb_enddate";
            this.rb_enddate.ShowBorder = true;
            this.rb_enddate.Size = new System.Drawing.Size(280, 180);
            this.rb_enddate.TabIndex = 41;
            this.rb_enddate.TabStop = false;
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
            this.btn_action.Location = new System.Drawing.Point(12, 426);
            this.btn_action.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_action.Name = "btn_action";
            this.btn_action.ShowBorder = true;
            this.btn_action.Size = new System.Drawing.Size(571, 30);
            this.btn_action.TabIndex = 43;
            this.btn_action.TabStop = false;
            this.btn_action.PhClick += new System.EventHandler(this.btn_action_PhClick);
            // 
            // chb_enddate
            // 
            this.chb_enddate.AutoSize = true;
            this.chb_enddate.Checked = true;
            this.chb_enddate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_enddate.Location = new System.Drawing.Point(320, 381);
            this.chb_enddate.Name = "chb_enddate";
            this.chb_enddate.Size = new System.Drawing.Size(15, 14);
            this.chb_enddate.TabIndex = 44;
            this.chb_enddate.UseVisualStyleBackColor = true;
            this.chb_enddate.CheckedChanged += new System.EventHandler(this.chb_enddate_CheckedChanged);
            // 
            // IllnessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HomePharmacy.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 476);
            this.Controls.Add(this.chb_enddate);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.dateEndCalendar);
            this.Controls.Add(this.lb_enddate);
            this.Controls.Add(this.rb_enddate);
            this.Controls.Add(this.dateStartCalendar);
            this.Controls.Add(this.lb_startdate);
            this.Controls.Add(this.rb_startdate);
            this.Controls.Add(this.tb_diagnose);
            this.Controls.Add(this.cb_email);
            this.Controls.Add(this.rb_diagnoses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IllnessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Pharmacy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.PhComboBox cb_email;
        private TextBox tb_diagnose;
        private Controls.RoundedBox rb_diagnoses;
        private MonthCalendar dateStartCalendar;
        private Label lb_startdate;
        private Controls.RoundedBox rb_startdate;
        private MonthCalendar dateEndCalendar;
        private Label lb_enddate;
        private Controls.RoundedBox rb_enddate;
        private Controls.PhButton btn_action;
        private CheckBox chb_enddate;
    }
}