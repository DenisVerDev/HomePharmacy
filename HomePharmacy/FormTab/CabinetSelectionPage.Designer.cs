namespace HomePharmacy.FormTab
{
    partial class CabinetSelectionPage
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
            this.btn_personalcab = new HomePharmacy.Controls.PhButton();
            this.btn_createfam = new HomePharmacy.Controls.PhButton();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_back = new HomePharmacy.Controls.PhButton();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_personalcab
            // 
            this.btn_personalcab.BackColor = System.Drawing.Color.Transparent;
            this.btn_personalcab.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_personalcab.BorderRadius = 30;
            this.btn_personalcab.Caption = "PERSONAL CABINET";
            this.btn_personalcab.FillColor = System.Drawing.Color.White;
            this.btn_personalcab.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_personalcab.HoverFillColor = System.Drawing.Color.White;
            this.btn_personalcab.Location = new System.Drawing.Point(3, 3);
            this.btn_personalcab.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_personalcab.Name = "btn_personalcab";
            this.btn_personalcab.ShowBorder = true;
            this.btn_personalcab.Size = new System.Drawing.Size(136, 150);
            this.btn_personalcab.TabIndex = 0;
            this.btn_personalcab.PhClick += new System.EventHandler(this.btn_personalcab_PhClick);
            // 
            // btn_createfam
            // 
            this.btn_createfam.BackColor = System.Drawing.Color.Transparent;
            this.btn_createfam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_createfam.BorderRadius = 30;
            this.btn_createfam.Caption = "CREATE FAMILY";
            this.btn_createfam.FillColor = System.Drawing.Color.White;
            this.btn_createfam.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_createfam.HoverFillColor = System.Drawing.Color.White;
            this.btn_createfam.Location = new System.Drawing.Point(145, 3);
            this.btn_createfam.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_createfam.Name = "btn_createfam";
            this.btn_createfam.ShowBorder = true;
            this.btn_createfam.Size = new System.Drawing.Size(136, 150);
            this.btn_createfam.TabIndex = 1;
            this.btn_createfam.PhClick += new System.EventHandler(this.btn_createfam_PhClick);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.flowPanel.Controls.Add(this.btn_personalcab);
            this.flowPanel.Controls.Add(this.btn_createfam);
            this.flowPanel.Location = new System.Drawing.Point(262, 126);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(409, 180);
            this.flowPanel.TabIndex = 2;
            this.flowPanel.WrapContents = false;
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
            this.btn_back.Location = new System.Drawing.Point(671, 411);
            this.btn_back.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShowBorder = true;
            this.btn_back.Size = new System.Drawing.Size(120, 30);
            this.btn_back.TabIndex = 30;
            this.btn_back.PhClick += new System.EventHandler(this.btn_back_PhClick);
            // 
            // CabinetSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomePharmacy.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.flowPanel);
            this.Name = "CabinetSelectionPage";
            this.Size = new System.Drawing.Size(792, 422);
            this.DataReceived += new HomePharmacy.Controls.PhPage.GetData(this.CabinetSelectionPage_DataReceived);
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PhButton btn_personalcab;
        private Controls.PhButton btn_createfam;
        private FlowLayoutPanel flowPanel;
        private Controls.PhButton btn_back;
    }
}
