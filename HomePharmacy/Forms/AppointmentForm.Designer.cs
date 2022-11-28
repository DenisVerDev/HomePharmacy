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
            this.rb_volume = new HomePharmacy.Controls.RoundedBox();
            this.rb_recommendator = new HomePharmacy.Controls.RoundedBox();
            this.btn_action = new HomePharmacy.Controls.PhButton();
            this.tb_medicines = new System.Windows.Forms.TextBox();
            this.tb_recommendator = new System.Windows.Forms.TextBox();
            this.tb_volume = new System.Windows.Forms.TextBox();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.rb_comments = new HomePharmacy.Controls.RoundedBox();
            this.lb_addinfo_title = new System.Windows.Forms.Label();
            this.lb_med_title = new System.Windows.Forms.Label();
            this.lb_volume_title = new System.Windows.Forms.Label();
            this.lb_recommendator_title = new System.Windows.Forms.Label();
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
            // rb_volume
            // 
            this.rb_volume.BackColor = System.Drawing.Color.Transparent;
            this.rb_volume.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_volume.BorderRadius = 10;
            this.rb_volume.FillColor = System.Drawing.Color.White;
            this.rb_volume.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_volume.HoverFillColor = System.Drawing.Color.White;
            this.rb_volume.IsSelected = false;
            this.rb_volume.Location = new System.Drawing.Point(262, 135);
            this.rb_volume.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_volume.Name = "rb_volume";
            this.rb_volume.ShowBorder = true;
            this.rb_volume.Size = new System.Drawing.Size(244, 200);
            this.rb_volume.TabIndex = 1;
            this.rb_volume.TabStop = false;
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
            // tb_volume
            // 
            this.tb_volume.BackColor = System.Drawing.Color.White;
            this.tb_volume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_volume.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_volume.Location = new System.Drawing.Point(273, 174);
            this.tb_volume.MaxLength = 1000;
            this.tb_volume.Multiline = true;
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(222, 152);
            this.tb_volume.TabIndex = 7;
            // 
            // tb_comment
            // 
            this.tb_comment.BackColor = System.Drawing.Color.White;
            this.tb_comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_comment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_comment.Location = new System.Drawing.Point(23, 376);
            this.tb_comment.MaxLength = 400;
            this.tb_comment.Multiline = true;
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(472, 100);
            this.tb_comment.TabIndex = 8;
            // 
            // rb_comments
            // 
            this.rb_comments.BackColor = System.Drawing.Color.Transparent;
            this.rb_comments.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_comments.BorderRadius = 10;
            this.rb_comments.FillColor = System.Drawing.Color.White;
            this.rb_comments.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_comments.HoverFillColor = System.Drawing.Color.White;
            this.rb_comments.IsSelected = false;
            this.rb_comments.Location = new System.Drawing.Point(12, 343);
            this.rb_comments.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_comments.Name = "rb_comments";
            this.rb_comments.ShowBorder = true;
            this.rb_comments.Size = new System.Drawing.Size(494, 146);
            this.rb_comments.TabIndex = 3;
            this.rb_comments.TabStop = false;
            // 
            // lb_addinfo_title
            // 
            this.lb_addinfo_title.AutoSize = true;
            this.lb_addinfo_title.BackColor = System.Drawing.Color.White;
            this.lb_addinfo_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_addinfo_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_addinfo_title.Location = new System.Drawing.Point(23, 354);
            this.lb_addinfo_title.Name = "lb_addinfo_title";
            this.lb_addinfo_title.Size = new System.Drawing.Size(153, 16);
            this.lb_addinfo_title.TabIndex = 9;
            this.lb_addinfo_title.Text = "Additional information:";
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
            // lb_volume_title
            // 
            this.lb_volume_title.AutoSize = true;
            this.lb_volume_title.BackColor = System.Drawing.Color.White;
            this.lb_volume_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_volume_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_volume_title.Location = new System.Drawing.Point(273, 147);
            this.lb_volume_title.Name = "lb_volume_title";
            this.lb_volume_title.Size = new System.Drawing.Size(152, 16);
            this.lb_volume_title.TabIndex = 11;
            this.lb_volume_title.Text = "Appointment\'s volume:";
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
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomePharmacy.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 551);
            this.Controls.Add(this.lb_recommendator_title);
            this.Controls.Add(this.lb_volume_title);
            this.Controls.Add(this.lb_med_title);
            this.Controls.Add(this.lb_addinfo_title);
            this.Controls.Add(this.tb_comment);
            this.Controls.Add(this.tb_volume);
            this.Controls.Add(this.tb_recommendator);
            this.Controls.Add(this.tb_medicines);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.rb_comments);
            this.Controls.Add(this.rb_recommendator);
            this.Controls.Add(this.rb_volume);
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
        private Controls.RoundedBox rb_volume;
        private Controls.RoundedBox rb_recommendator;
        private Controls.PhButton btn_action;
        private TextBox tb_medicines;
        private TextBox tb_recommendator;
        private TextBox tb_volume;
        private TextBox tb_comment;
        private Controls.RoundedBox rb_comments;
        private Label lb_addinfo_title;
        private Label lb_med_title;
        private Label lb_volume_title;
        private Label lb_recommendator_title;
    }
}