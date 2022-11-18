namespace HomePharmacy
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tpage_log = new System.Windows.Forms.TabPage();
            this.logPage = new HomePharmacy.TabPages.LogPage();
            this.tpage_reg = new System.Windows.Forms.TabPage();
            this.regPage = new HomePharmacy.TabPages.RegPage();
            this.tpage_cabsel = new System.Windows.Forms.TabPage();
            this.cabselPage = new HomePharmacy.TabPages.CabinetSelectionPage();
            this.tab_main.SuspendLayout();
            this.tpage_log.SuspendLayout();
            this.tpage_reg.SuspendLayout();
            this.tpage_cabsel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_main
            // 
            this.tab_main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tab_main.Controls.Add(this.tpage_log);
            this.tab_main.Controls.Add(this.tpage_reg);
            this.tab_main.Controls.Add(this.tpage_cabsel);
            this.tab_main.ItemSize = new System.Drawing.Size(0, 1);
            this.tab_main.Location = new System.Drawing.Point(-7, -8);
            this.tab_main.Margin = new System.Windows.Forms.Padding(0);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(814, 466);
            this.tab_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_main.TabIndex = 0;
            // 
            // tpage_log
            // 
            this.tpage_log.Controls.Add(this.logPage);
            this.tpage_log.Location = new System.Drawing.Point(4, 5);
            this.tpage_log.Name = "tpage_log";
            this.tpage_log.Padding = new System.Windows.Forms.Padding(3);
            this.tpage_log.Size = new System.Drawing.Size(806, 457);
            this.tpage_log.TabIndex = 0;
            this.tpage_log.Text = "Login module";
            this.tpage_log.UseVisualStyleBackColor = true;
            // 
            // logPage
            // 
            this.logPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logPage.BackgroundImage")));
            this.logPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPage.Location = new System.Drawing.Point(3, 3);
            this.logPage.Name = "logPage";
            this.logPage.Size = new System.Drawing.Size(800, 451);
            this.logPage.TabIndex = 0;
            this.logPage.PageChange += new HomePharmacy.PageChangeEvent(this.PageChange);
            // 
            // tpage_reg
            // 
            this.tpage_reg.Controls.Add(this.regPage);
            this.tpage_reg.Location = new System.Drawing.Point(4, 5);
            this.tpage_reg.Name = "tpage_reg";
            this.tpage_reg.Padding = new System.Windows.Forms.Padding(3);
            this.tpage_reg.Size = new System.Drawing.Size(806, 457);
            this.tpage_reg.TabIndex = 1;
            this.tpage_reg.Text = "Registration module";
            this.tpage_reg.UseVisualStyleBackColor = true;
            // 
            // regPage
            // 
            this.regPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regPage.BackgroundImage")));
            this.regPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regPage.Location = new System.Drawing.Point(3, 3);
            this.regPage.Name = "regPage";
            this.regPage.Size = new System.Drawing.Size(800, 451);
            this.regPage.TabIndex = 0;
            this.regPage.PageChange += new HomePharmacy.PageChangeEvent(this.PageChange);
            // 
            // tpage_cabsel
            // 
            this.tpage_cabsel.Controls.Add(this.cabselPage);
            this.tpage_cabsel.Location = new System.Drawing.Point(4, 5);
            this.tpage_cabsel.Name = "tpage_cabsel";
            this.tpage_cabsel.Size = new System.Drawing.Size(806, 457);
            this.tpage_cabsel.TabIndex = 2;
            this.tpage_cabsel.Text = "Cabinet selection";
            this.tpage_cabsel.UseVisualStyleBackColor = true;
            // 
            // cabselPage
            // 
            this.cabselPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cabselPage.BackgroundImage")));
            this.cabselPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cabselPage.Location = new System.Drawing.Point(3, 3);
            this.cabselPage.Name = "cabselPage";
            this.cabselPage.Size = new System.Drawing.Size(800, 451);
            this.cabselPage.TabIndex = 0;
            this.cabselPage.PageChange += new HomePharmacy.PageChangeEvent(this.PageChange);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Pharmacy";
            this.tab_main.ResumeLayout(false);
            this.tpage_log.ResumeLayout(false);
            this.tpage_reg.ResumeLayout(false);
            this.tpage_cabsel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tab_main;
        private TabPage tpage_log;
        private TabPage tpage_reg;
        private TabPages.LogPage logPage;
        private TabPages.RegPage regPage;
        private TabPage tpage_cabsel;
        private TabPages.CabinetSelectionPage cabselPage;
    }
}