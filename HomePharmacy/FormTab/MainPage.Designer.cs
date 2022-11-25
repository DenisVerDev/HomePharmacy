namespace HomePharmacy.FormTab;

partial class MainPage
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
            this.btn_family = new HomePharmacy.Controls.PhIcon();
            this.btn_medicines = new HomePharmacy.Controls.PhIcon();
            this.btn_illneses = new HomePharmacy.Controls.PhIcon();
            this.btn_medusage = new HomePharmacy.Controls.PhIcon();
            this.btn_statistics = new HomePharmacy.Controls.PhIcon();
            this.flowPanelTabs = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_profile = new HomePharmacy.Controls.PhIcon();
            this.panel = new System.Windows.Forms.Panel();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tpage_profile = new System.Windows.Forms.TabPage();
            this.profilePage = new HomePharmacy.MainPages.ProfilePage();
            this.tpage_family = new System.Windows.Forms.TabPage();
            this.familyPage = new HomePharmacy.MainPages.FamilyPage();
            this.tpage_ilnesses = new System.Windows.Forms.TabPage();
            this.tpage_medicines = new System.Windows.Forms.TabPage();
            this.tpage_takemed = new System.Windows.Forms.TabPage();
            this.tpage_statistics = new System.Windows.Forms.TabPage();
            this.tpage_appoint = new System.Windows.Forms.TabPage();
            this.flowPanelTabs.SuspendLayout();
            this.panel.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tpage_profile.SuspendLayout();
            this.tpage_family.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_family
            // 
            this.btn_family.BackColor = System.Drawing.Color.Transparent;
            this.btn_family.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_family.BorderRadius = 0;
            this.btn_family.FillColor = System.Drawing.Color.White;
            this.btn_family.FillPercent = 0.7F;
            this.btn_family.HoverBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_family.HoverFillColor = System.Drawing.Color.White;
            this.btn_family.IconImage = global::HomePharmacy.Properties.Resources.family;
            this.btn_family.IsSelected = false;
            this.btn_family.Location = new System.Drawing.Point(3, 74);
            this.btn_family.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_family.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_family.Name = "btn_family";
            this.btn_family.ShowBorder = true;
            this.btn_family.Size = new System.Drawing.Size(76, 70);
            this.btn_family.TabIndex = 1;
            this.btn_family.TabStop = false;
            this.btn_family.PhClick += new System.EventHandler(this.Page_Select);
            // 
            // btn_medicines
            // 
            this.btn_medicines.BackColor = System.Drawing.Color.Transparent;
            this.btn_medicines.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_medicines.BorderRadius = 0;
            this.btn_medicines.FillColor = System.Drawing.Color.White;
            this.btn_medicines.FillPercent = 0.7F;
            this.btn_medicines.HoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btn_medicines.HoverFillColor = System.Drawing.Color.White;
            this.btn_medicines.IconImage = global::HomePharmacy.Properties.Resources.medicine;
            this.btn_medicines.IsSelected = false;
            this.btn_medicines.Location = new System.Drawing.Point(3, 214);
            this.btn_medicines.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_medicines.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_medicines.Name = "btn_medicines";
            this.btn_medicines.ShowBorder = true;
            this.btn_medicines.Size = new System.Drawing.Size(76, 70);
            this.btn_medicines.TabIndex = 2;
            this.btn_medicines.TabStop = false;
            this.btn_medicines.PhClick += new System.EventHandler(this.Page_Select);
            // 
            // btn_illneses
            // 
            this.btn_illneses.BackColor = System.Drawing.Color.Transparent;
            this.btn_illneses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_illneses.BorderRadius = 0;
            this.btn_illneses.FillColor = System.Drawing.Color.White;
            this.btn_illneses.FillPercent = 0.7F;
            this.btn_illneses.HoverBorderColor = System.Drawing.Color.Firebrick;
            this.btn_illneses.HoverFillColor = System.Drawing.Color.White;
            this.btn_illneses.IconImage = global::HomePharmacy.Properties.Resources.virus;
            this.btn_illneses.IsSelected = false;
            this.btn_illneses.Location = new System.Drawing.Point(3, 144);
            this.btn_illneses.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_illneses.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_illneses.Name = "btn_illneses";
            this.btn_illneses.ShowBorder = true;
            this.btn_illneses.Size = new System.Drawing.Size(76, 70);
            this.btn_illneses.TabIndex = 3;
            this.btn_illneses.TabStop = false;
            this.btn_illneses.PhClick += new System.EventHandler(this.Page_Select);
            // 
            // btn_medusage
            // 
            this.btn_medusage.BackColor = System.Drawing.Color.Transparent;
            this.btn_medusage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_medusage.BorderRadius = 0;
            this.btn_medusage.FillColor = System.Drawing.Color.White;
            this.btn_medusage.FillPercent = 0.7F;
            this.btn_medusage.HoverBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_medusage.HoverFillColor = System.Drawing.Color.White;
            this.btn_medusage.IconImage = global::HomePharmacy.Properties.Resources.take_medicines;
            this.btn_medusage.IsSelected = false;
            this.btn_medusage.Location = new System.Drawing.Point(3, 284);
            this.btn_medusage.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_medusage.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_medusage.Name = "btn_medusage";
            this.btn_medusage.ShowBorder = true;
            this.btn_medusage.Size = new System.Drawing.Size(76, 70);
            this.btn_medusage.TabIndex = 4;
            this.btn_medusage.TabStop = false;
            this.btn_medusage.PhClick += new System.EventHandler(this.Page_Select);
            // 
            // btn_statistics
            // 
            this.btn_statistics.BackColor = System.Drawing.Color.Transparent;
            this.btn_statistics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_statistics.BorderRadius = 0;
            this.btn_statistics.FillColor = System.Drawing.Color.White;
            this.btn_statistics.FillPercent = 0.7F;
            this.btn_statistics.HoverBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_statistics.HoverFillColor = System.Drawing.Color.White;
            this.btn_statistics.IconImage = global::HomePharmacy.Properties.Resources.bar_chart;
            this.btn_statistics.IsSelected = false;
            this.btn_statistics.Location = new System.Drawing.Point(3, 354);
            this.btn_statistics.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_statistics.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.ShowBorder = true;
            this.btn_statistics.Size = new System.Drawing.Size(76, 70);
            this.btn_statistics.TabIndex = 5;
            this.btn_statistics.TabStop = false;
            this.btn_statistics.PhClick += new System.EventHandler(this.Page_Select);
            // 
            // flowPanelTabs
            // 
            this.flowPanelTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.flowPanelTabs.Controls.Add(this.btn_profile);
            this.flowPanelTabs.Controls.Add(this.btn_family);
            this.flowPanelTabs.Controls.Add(this.btn_illneses);
            this.flowPanelTabs.Controls.Add(this.btn_medicines);
            this.flowPanelTabs.Controls.Add(this.btn_medusage);
            this.flowPanelTabs.Controls.Add(this.btn_statistics);
            this.flowPanelTabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowPanelTabs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelTabs.Location = new System.Drawing.Point(0, 0);
            this.flowPanelTabs.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.flowPanelTabs.Name = "flowPanelTabs";
            this.flowPanelTabs.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowPanelTabs.Size = new System.Drawing.Size(79, 466);
            this.flowPanelTabs.TabIndex = 8;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_profile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_profile.BorderRadius = 0;
            this.btn_profile.FillColor = System.Drawing.Color.White;
            this.btn_profile.FillPercent = 0.56F;
            this.btn_profile.HoverBorderColor = System.Drawing.Color.DimGray;
            this.btn_profile.HoverFillColor = System.Drawing.Color.White;
            this.btn_profile.IconImage = global::HomePharmacy.Properties.Resources.account_info;
            this.btn_profile.IsSelected = false;
            this.btn_profile.Location = new System.Drawing.Point(3, 4);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_profile.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.ShowBorder = true;
            this.btn_profile.Size = new System.Drawing.Size(76, 70);
            this.btn_profile.TabIndex = 6;
            this.btn_profile.TabStop = false;
            this.btn_profile.PhClick += new System.EventHandler(this.Page_Select);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tab_main);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(79, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(727, 466);
            this.panel.TabIndex = 10;
            // 
            // tab_main
            // 
            this.tab_main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tab_main.Controls.Add(this.tpage_profile);
            this.tab_main.Controls.Add(this.tpage_family);
            this.tab_main.Controls.Add(this.tpage_ilnesses);
            this.tab_main.Controls.Add(this.tpage_medicines);
            this.tab_main.Controls.Add(this.tpage_takemed);
            this.tab_main.Controls.Add(this.tpage_statistics);
            this.tab_main.Controls.Add(this.tpage_appoint);
            this.tab_main.ItemSize = new System.Drawing.Size(0, 1);
            this.tab_main.Location = new System.Drawing.Point(-9, -4);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(743, 478);
            this.tab_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_main.TabIndex = 0;
            // 
            // tpage_profile
            // 
            this.tpage_profile.AutoScroll = true;
            this.tpage_profile.BackColor = System.Drawing.SystemColors.Control;
            this.tpage_profile.Controls.Add(this.profilePage);
            this.tpage_profile.Location = new System.Drawing.Point(4, 5);
            this.tpage_profile.Name = "tpage_profile";
            this.tpage_profile.Padding = new System.Windows.Forms.Padding(3);
            this.tpage_profile.Size = new System.Drawing.Size(735, 469);
            this.tpage_profile.TabIndex = 0;
            this.tpage_profile.Text = "Profile";
            // 
            // profilePage
            // 
            this.profilePage.Data = null;
            this.profilePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePage.Location = new System.Drawing.Point(3, 3);
            this.profilePage.Name = "profilePage";
            this.profilePage.Size = new System.Drawing.Size(729, 463);
            this.profilePage.TabIndex = 0;
            this.profilePage.LogoutEvent += new System.EventHandler(this.profilePage_LogoutEvent);
            this.profilePage.ChangeCabinetEvent += new System.EventHandler(this.profilePage_ChangeCabinetEvent);
            // 
            // tpage_family
            // 
            this.tpage_family.BackColor = System.Drawing.SystemColors.Control;
            this.tpage_family.Controls.Add(this.familyPage);
            this.tpage_family.Location = new System.Drawing.Point(4, 5);
            this.tpage_family.Name = "tpage_family";
            this.tpage_family.Padding = new System.Windows.Forms.Padding(3);
            this.tpage_family.Size = new System.Drawing.Size(735, 469);
            this.tpage_family.TabIndex = 1;
            this.tpage_family.Text = "Family";
            // 
            // familyPage
            // 
            this.familyPage.Data = null;
            this.familyPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.familyPage.Location = new System.Drawing.Point(3, 3);
            this.familyPage.Name = "familyPage";
            this.familyPage.Size = new System.Drawing.Size(729, 463);
            this.familyPage.TabIndex = 0;
            this.familyPage.LeaveFamily += new System.EventHandler(this.profilePage_ChangeCabinetEvent);
            // 
            // tpage_ilnesses
            // 
            this.tpage_ilnesses.Location = new System.Drawing.Point(4, 5);
            this.tpage_ilnesses.Name = "tpage_ilnesses";
            this.tpage_ilnesses.Size = new System.Drawing.Size(735, 469);
            this.tpage_ilnesses.TabIndex = 2;
            this.tpage_ilnesses.Text = "Ilnesses";
            this.tpage_ilnesses.UseVisualStyleBackColor = true;
            // 
            // tpage_medicines
            // 
            this.tpage_medicines.Location = new System.Drawing.Point(4, 5);
            this.tpage_medicines.Name = "tpage_medicines";
            this.tpage_medicines.Size = new System.Drawing.Size(735, 469);
            this.tpage_medicines.TabIndex = 3;
            this.tpage_medicines.Text = "Medicines";
            this.tpage_medicines.UseVisualStyleBackColor = true;
            // 
            // tpage_takemed
            // 
            this.tpage_takemed.Location = new System.Drawing.Point(4, 5);
            this.tpage_takemed.Name = "tpage_takemed";
            this.tpage_takemed.Size = new System.Drawing.Size(735, 469);
            this.tpage_takemed.TabIndex = 4;
            this.tpage_takemed.Text = "Taking medicines";
            this.tpage_takemed.UseVisualStyleBackColor = true;
            // 
            // tpage_statistics
            // 
            this.tpage_statistics.Location = new System.Drawing.Point(4, 5);
            this.tpage_statistics.Name = "tpage_statistics";
            this.tpage_statistics.Size = new System.Drawing.Size(735, 469);
            this.tpage_statistics.TabIndex = 5;
            this.tpage_statistics.Text = "Statisctics";
            this.tpage_statistics.UseVisualStyleBackColor = true;
            // 
            // tpage_appoint
            // 
            this.tpage_appoint.Location = new System.Drawing.Point(4, 5);
            this.tpage_appoint.Name = "tpage_appoint";
            this.tpage_appoint.Size = new System.Drawing.Size(735, 469);
            this.tpage_appoint.TabIndex = 6;
            this.tpage_appoint.Text = "Appointments";
            this.tpage_appoint.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.flowPanelTabs);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(806, 466);
            this.DataReceived += new HomePharmacy.Controls.PhPage.GetData(this.MainPage_DataReceived);
            this.flowPanelTabs.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.tpage_profile.ResumeLayout(false);
            this.tpage_family.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private Controls.PhIcon btn_family;
    private Controls.PhIcon btn_medicines;
    private Controls.PhIcon btn_illneses;
    private Controls.PhIcon btn_medusage;
    private Controls.PhIcon btn_statistics;
    private FlowLayoutPanel flowPanelTabs;
    private Controls.PhIcon btn_profile;
    private Panel panel;
    private TabControl tab_main;
    private TabPage tpage_profile;
    private TabPage tpage_family;
    private TabPage tpage_ilnesses;
    private TabPage tpage_medicines;
    private TabPage tpage_takemed;
    private TabPage tpage_statistics;
    private TabPage tpage_appoint;
    private MainPages.ProfilePage profilePage;
    private MainPages.FamilyPage familyPage;
}
