namespace HomePharmacy.FormTab
{
    partial class FormTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTab));
            this.tab_form = new System.Windows.Forms.TabControl();
            this.tpage_log = new System.Windows.Forms.TabPage();
            this.logPage = new HomePharmacy.FormTab.LogPage();
            this.tpage_reg = new System.Windows.Forms.TabPage();
            this.regPage = new HomePharmacy.FormTab.RegPage();
            this.tpage_cabsel = new System.Windows.Forms.TabPage();
            this.cabSelPage = new HomePharmacy.FormTab.CabinetSelectionPage();
            this.tab_form.SuspendLayout();
            this.tpage_log.SuspendLayout();
            this.tpage_reg.SuspendLayout();
            this.tpage_cabsel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_form
            // 
            this.tab_form.Controls.Add(this.tpage_log);
            this.tab_form.Controls.Add(this.tpage_reg);
            this.tab_form.Controls.Add(this.tpage_cabsel);
            this.tab_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_form.ItemSize = new System.Drawing.Size(0, 1);
            this.tab_form.Location = new System.Drawing.Point(0, 0);
            this.tab_form.Name = "tab_form";
            this.tab_form.SelectedIndex = 0;
            this.tab_form.Size = new System.Drawing.Size(814, 466);
            this.tab_form.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_form.TabIndex = 0;
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
            // 
            // tpage_cabsel
            // 
            this.tpage_cabsel.Controls.Add(this.cabSelPage);
            this.tpage_cabsel.Location = new System.Drawing.Point(4, 5);
            this.tpage_cabsel.Name = "tpage_cabsel";
            this.tpage_cabsel.Size = new System.Drawing.Size(806, 457);
            this.tpage_cabsel.TabIndex = 2;
            this.tpage_cabsel.Text = "Cabinet selection";
            this.tpage_cabsel.UseVisualStyleBackColor = true;
            // 
            // cabSelPage
            // 
            this.cabSelPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cabSelPage.BackgroundImage")));
            this.cabSelPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cabSelPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabSelPage.Location = new System.Drawing.Point(0, 0);
            this.cabSelPage.Name = "cabSelPage";
            this.cabSelPage.Size = new System.Drawing.Size(806, 457);
            this.cabSelPage.TabIndex = 0;
            // 
            // FormTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tab_form);
            this.Name = "FormTab";
            this.Size = new System.Drawing.Size(814, 466);
            this.tab_form.ResumeLayout(false);
            this.tpage_log.ResumeLayout(false);
            this.tpage_reg.ResumeLayout(false);
            this.tpage_cabsel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tab_form;
        private TabPage tpage_log;
        private TabPage tpage_reg;
        private LogPage logPage;
        private RegPage regPage;
        private TabPage tpage_cabsel;
        private CabinetSelectionPage cabSelPage;
    }
}
