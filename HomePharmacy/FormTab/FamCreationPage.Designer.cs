namespace HomePharmacy.FormTab
{
    partial class FamCreationPage
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
            this.tb_email = new HomePharmacy.Controls.PhTextBox();
            this.lb_email_check = new System.Windows.Forms.Label();
            this.btn_back = new HomePharmacy.Controls.PhButton();
            this.btn_create = new HomePharmacy.Controls.PhButton();
            this.lb_hint = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Transparent;
            this.tb_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.tb_email.BorderRadius = 10;
            this.tb_email.FillColor = System.Drawing.Color.White;
            this.tb_email.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_email.HoverFillColor = System.Drawing.Color.White;
            this.tb_email.Location = new System.Drawing.Point(447, 142);
            this.tb_email.MinimumSize = new System.Drawing.Size(100, 30);
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordMode = false;
            this.tb_email.PhText = "";
            this.tb_email.Placeholder = "Other person\'s email";
            this.tb_email.ShowBorder = true;
            this.tb_email.Size = new System.Drawing.Size(274, 30);
            this.tb_email.TabIndex = 13;
            // 
            // lb_email_check
            // 
            this.lb_email_check.AutoSize = true;
            this.lb_email_check.BackColor = System.Drawing.Color.Transparent;
            this.lb_email_check.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_email_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_email_check.Location = new System.Drawing.Point(447, 184);
            this.lb_email_check.Name = "lb_email_check";
            this.lb_email_check.Size = new System.Drawing.Size(0, 15);
            this.lb_email_check.TabIndex = 14;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_back.BorderRadius = 10;
            this.btn_back.Caption = "Back";
            this.btn_back.FillColor = System.Drawing.Color.White;
            this.btn_back.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_back.HoverFillColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(447, 357);
            this.btn_back.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShowBorder = true;
            this.btn_back.Size = new System.Drawing.Size(274, 30);
            this.btn_back.TabIndex = 16;
            this.btn_back.PhClick += new System.EventHandler(this.btn_back_PhClick);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Transparent;
            this.btn_create.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_create.BorderRadius = 10;
            this.btn_create.Caption = "Create";
            this.btn_create.FillColor = System.Drawing.Color.White;
            this.btn_create.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_create.HoverFillColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(447, 261);
            this.btn_create.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_create.Name = "btn_create";
            this.btn_create.ShowBorder = true;
            this.btn_create.Size = new System.Drawing.Size(274, 30);
            this.btn_create.TabIndex = 15;
            this.btn_create.PhClick += new System.EventHandler(this.btn_create_PhClick);
            // 
            // lb_hint
            // 
            this.lb_hint.AutoSize = true;
            this.lb_hint.BackColor = System.Drawing.Color.Transparent;
            this.lb_hint.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_hint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_hint.Location = new System.Drawing.Point(447, 294);
            this.lb_hint.MaximumSize = new System.Drawing.Size(274, 50);
            this.lb_hint.Name = "lb_hint";
            this.lb_hint.Size = new System.Drawing.Size(267, 32);
            this.lb_hint.TabIndex = 17;
            this.lb_hint.Text = "In order to create a new family, you need at least two persons in one group";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lb_title.Location = new System.Drawing.Point(437, 40);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(300, 36);
            this.lb_title.TabIndex = 18;
            this.lb_title.Text = "HOME PHARMACY";
            // 
            // FamCreationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomePharmacy.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_hint);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email_check);
            this.Name = "FamCreationPage";
            this.Size = new System.Drawing.Size(792, 422);
            this.DataReceived += new HomePharmacy.Controls.PhPage.GetData(this.FamCreationPage_DataReceived);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PhTextBox tb_email;
        private Label lb_email_check;
        private Controls.PhButton btn_back;
        private Controls.PhButton btn_create;
        private Label lb_hint;
        private Label lb_title;
    }
}
