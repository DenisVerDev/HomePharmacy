namespace HomePharmacy.Forms
{
    partial class MedicineForm
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
            this.lb_name_title = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.rb_name = new HomePharmacy.Controls.RoundedBox();
            this.cb_type = new HomePharmacy.Controls.PhComboBox();
            this.cb_forwhom = new HomePharmacy.Controls.PhComboBox();
            this.rb_price = new HomePharmacy.Controls.RoundedBox();
            this.lb_price_title = new System.Windows.Forms.Label();
            this.nm_price = new System.Windows.Forms.NumericUpDown();
            this.nm_count = new System.Windows.Forms.NumericUpDown();
            this.lb_count_title = new System.Windows.Forms.Label();
            this.rb_count = new HomePharmacy.Controls.RoundedBox();
            this.nm_excount = new System.Windows.Forms.NumericUpDown();
            this.lb_excount_title = new System.Windows.Forms.Label();
            this.rb_excount = new HomePharmacy.Controls.RoundedBox();
            this.lb_remainings_title = new System.Windows.Forms.Label();
            this.rb_remainings = new HomePharmacy.Controls.RoundedBox();
            this.dateExpCalendar = new System.Windows.Forms.MonthCalendar();
            this.lb_expdate_title = new System.Windows.Forms.Label();
            this.rb_expdate = new HomePharmacy.Controls.RoundedBox();
            this.datePurchaseCalendar = new System.Windows.Forms.MonthCalendar();
            this.lb_purchasedate_title = new System.Windows.Forms.Label();
            this.rb_purchasedate = new HomePharmacy.Controls.RoundedBox();
            this.btn_action = new HomePharmacy.Controls.PhButton();
            this.nm_remainings = new System.Windows.Forms.NumericUpDown();
            this.btn_remcount = new HomePharmacy.Controls.PhButton();
            ((System.ComponentModel.ISupportInitialize)(this.nm_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_excount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_remainings)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name_title
            // 
            this.lb_name_title.AutoSize = true;
            this.lb_name_title.BackColor = System.Drawing.Color.White;
            this.lb_name_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_name_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_name_title.Location = new System.Drawing.Point(19, 22);
            this.lb_name_title.Name = "lb_name_title";
            this.lb_name_title.Size = new System.Drawing.Size(48, 16);
            this.lb_name_title.TabIndex = 13;
            this.lb_name_title.Text = "Name:";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.tb_name.Location = new System.Drawing.Point(23, 50);
            this.tb_name.MaxLength = 200;
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(195, 59);
            this.tb_name.TabIndex = 12;
            // 
            // rb_name
            // 
            this.rb_name.BackColor = System.Drawing.Color.Transparent;
            this.rb_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_name.BorderRadius = 10;
            this.rb_name.FillColor = System.Drawing.Color.White;
            this.rb_name.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_name.HoverFillColor = System.Drawing.Color.White;
            this.rb_name.IsSelected = false;
            this.rb_name.Location = new System.Drawing.Point(12, 12);
            this.rb_name.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_name.Name = "rb_name";
            this.rb_name.ShowBorder = true;
            this.rb_name.Size = new System.Drawing.Size(226, 107);
            this.rb_name.TabIndex = 11;
            this.rb_name.TabStop = false;
            // 
            // cb_type
            // 
            this.cb_type.BackColor = System.Drawing.Color.Transparent;
            this.cb_type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.cb_type.BorderRadius = 10;
            this.cb_type.FillColor = System.Drawing.Color.White;
            this.cb_type.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.cb_type.HoverFillColor = System.Drawing.Color.White;
            this.cb_type.IsSelected = false;
            this.cb_type.Location = new System.Drawing.Point(12, 125);
            this.cb_type.MinimumSize = new System.Drawing.Size(30, 30);
            this.cb_type.Name = "cb_type";
            this.cb_type.PhText = "Type";
            this.cb_type.Placeholder = "Type";
            this.cb_type.ShowBorder = true;
            this.cb_type.Size = new System.Drawing.Size(226, 31);
            this.cb_type.TabIndex = 34;
            this.cb_type.TabStop = false;
            // 
            // cb_forwhom
            // 
            this.cb_forwhom.BackColor = System.Drawing.Color.Transparent;
            this.cb_forwhom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.cb_forwhom.BorderRadius = 10;
            this.cb_forwhom.FillColor = System.Drawing.Color.White;
            this.cb_forwhom.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.cb_forwhom.HoverFillColor = System.Drawing.Color.White;
            this.cb_forwhom.IsSelected = false;
            this.cb_forwhom.Location = new System.Drawing.Point(12, 162);
            this.cb_forwhom.MinimumSize = new System.Drawing.Size(30, 30);
            this.cb_forwhom.Name = "cb_forwhom";
            this.cb_forwhom.PhText = "For whom";
            this.cb_forwhom.Placeholder = "For whom";
            this.cb_forwhom.ShowBorder = true;
            this.cb_forwhom.Size = new System.Drawing.Size(226, 31);
            this.cb_forwhom.TabIndex = 35;
            this.cb_forwhom.TabStop = false;
            // 
            // rb_price
            // 
            this.rb_price.BackColor = System.Drawing.Color.Transparent;
            this.rb_price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_price.BorderRadius = 10;
            this.rb_price.FillColor = System.Drawing.Color.White;
            this.rb_price.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_price.HoverFillColor = System.Drawing.Color.White;
            this.rb_price.IsSelected = false;
            this.rb_price.Location = new System.Drawing.Point(12, 199);
            this.rb_price.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_price.Name = "rb_price";
            this.rb_price.ShowBorder = true;
            this.rb_price.Size = new System.Drawing.Size(226, 37);
            this.rb_price.TabIndex = 36;
            this.rb_price.TabStop = false;
            // 
            // lb_price_title
            // 
            this.lb_price_title.AutoSize = true;
            this.lb_price_title.BackColor = System.Drawing.Color.White;
            this.lb_price_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_price_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_price_title.Location = new System.Drawing.Point(19, 206);
            this.lb_price_title.Name = "lb_price_title";
            this.lb_price_title.Size = new System.Drawing.Size(44, 16);
            this.lb_price_title.TabIndex = 37;
            this.lb_price_title.Text = "Price:";
            // 
            // nm_price
            // 
            this.nm_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nm_price.Location = new System.Drawing.Point(111, 208);
            this.nm_price.Name = "nm_price";
            this.nm_price.Size = new System.Drawing.Size(120, 23);
            this.nm_price.TabIndex = 38;
            // 
            // nm_count
            // 
            this.nm_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nm_count.Location = new System.Drawing.Point(111, 249);
            this.nm_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_count.Name = "nm_count";
            this.nm_count.Size = new System.Drawing.Size(120, 23);
            this.nm_count.TabIndex = 41;
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
            this.lb_count_title.Location = new System.Drawing.Point(19, 249);
            this.lb_count_title.Name = "lb_count_title";
            this.lb_count_title.Size = new System.Drawing.Size(48, 16);
            this.lb_count_title.TabIndex = 40;
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
            this.rb_count.Location = new System.Drawing.Point(12, 242);
            this.rb_count.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_count.Name = "rb_count";
            this.rb_count.ShowBorder = true;
            this.rb_count.Size = new System.Drawing.Size(226, 37);
            this.rb_count.TabIndex = 39;
            this.rb_count.TabStop = false;
            // 
            // nm_excount
            // 
            this.nm_excount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nm_excount.Location = new System.Drawing.Point(111, 301);
            this.nm_excount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_excount.Name = "nm_excount";
            this.nm_excount.Size = new System.Drawing.Size(120, 23);
            this.nm_excount.TabIndex = 44;
            this.nm_excount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_excount_title
            // 
            this.lb_excount_title.AutoSize = true;
            this.lb_excount_title.BackColor = System.Drawing.Color.White;
            this.lb_excount_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_excount_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_excount_title.Location = new System.Drawing.Point(19, 292);
            this.lb_excount_title.MaximumSize = new System.Drawing.Size(100, 0);
            this.lb_excount_title.Name = "lb_excount_title";
            this.lb_excount_title.Size = new System.Drawing.Size(86, 32);
            this.lb_excount_title.TabIndex = 43;
            this.lb_excount_title.Text = "Exemplears count:";
            // 
            // rb_excount
            // 
            this.rb_excount.BackColor = System.Drawing.Color.Transparent;
            this.rb_excount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_excount.BorderRadius = 10;
            this.rb_excount.FillColor = System.Drawing.Color.White;
            this.rb_excount.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_excount.HoverFillColor = System.Drawing.Color.White;
            this.rb_excount.IsSelected = false;
            this.rb_excount.Location = new System.Drawing.Point(12, 285);
            this.rb_excount.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_excount.Name = "rb_excount";
            this.rb_excount.ShowBorder = true;
            this.rb_excount.Size = new System.Drawing.Size(226, 50);
            this.rb_excount.TabIndex = 42;
            this.rb_excount.TabStop = false;
            // 
            // lb_remainings_title
            // 
            this.lb_remainings_title.AutoSize = true;
            this.lb_remainings_title.BackColor = System.Drawing.Color.White;
            this.lb_remainings_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_remainings_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_remainings_title.Location = new System.Drawing.Point(19, 348);
            this.lb_remainings_title.Name = "lb_remainings_title";
            this.lb_remainings_title.Size = new System.Drawing.Size(86, 16);
            this.lb_remainings_title.TabIndex = 46;
            this.lb_remainings_title.Text = "Remainings:";
            // 
            // rb_remainings
            // 
            this.rb_remainings.BackColor = System.Drawing.Color.Transparent;
            this.rb_remainings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_remainings.BorderRadius = 10;
            this.rb_remainings.FillColor = System.Drawing.Color.White;
            this.rb_remainings.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_remainings.HoverFillColor = System.Drawing.Color.White;
            this.rb_remainings.IsSelected = false;
            this.rb_remainings.Location = new System.Drawing.Point(12, 341);
            this.rb_remainings.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_remainings.Name = "rb_remainings";
            this.rb_remainings.ShowBorder = true;
            this.rb_remainings.Size = new System.Drawing.Size(226, 74);
            this.rb_remainings.TabIndex = 45;
            this.rb_remainings.TabStop = false;
            // 
            // dateExpCalendar
            // 
            this.dateExpCalendar.Location = new System.Drawing.Point(358, 20);
            this.dateExpCalendar.MaxSelectionCount = 1;
            this.dateExpCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateExpCalendar.Name = "dateExpCalendar";
            this.dateExpCalendar.TabIndex = 50;
            // 
            // lb_expdate_title
            // 
            this.lb_expdate_title.AutoSize = true;
            this.lb_expdate_title.BackColor = System.Drawing.Color.White;
            this.lb_expdate_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_expdate_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_expdate_title.Location = new System.Drawing.Point(255, 20);
            this.lb_expdate_title.Name = "lb_expdate_title";
            this.lb_expdate_title.Size = new System.Drawing.Size(91, 16);
            this.lb_expdate_title.TabIndex = 48;
            this.lb_expdate_title.Text = "Expiary date:";
            // 
            // rb_expdate
            // 
            this.rb_expdate.BackColor = System.Drawing.Color.Transparent;
            this.rb_expdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_expdate.BorderRadius = 10;
            this.rb_expdate.FillColor = System.Drawing.Color.White;
            this.rb_expdate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_expdate.HoverFillColor = System.Drawing.Color.White;
            this.rb_expdate.IsSelected = false;
            this.rb_expdate.Location = new System.Drawing.Point(244, 12);
            this.rb_expdate.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_expdate.Name = "rb_expdate";
            this.rb_expdate.ShowBorder = true;
            this.rb_expdate.Size = new System.Drawing.Size(280, 197);
            this.rb_expdate.TabIndex = 49;
            this.rb_expdate.TabStop = false;
            // 
            // datePurchaseCalendar
            // 
            this.datePurchaseCalendar.Location = new System.Drawing.Point(358, 223);
            this.datePurchaseCalendar.MaxSelectionCount = 1;
            this.datePurchaseCalendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datePurchaseCalendar.Name = "datePurchaseCalendar";
            this.datePurchaseCalendar.TabIndex = 54;
            // 
            // lb_purchasedate_title
            // 
            this.lb_purchasedate_title.AutoSize = true;
            this.lb_purchasedate_title.BackColor = System.Drawing.Color.White;
            this.lb_purchasedate_title.Font = new System.Drawing.Font("Arial", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_purchasedate_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.lb_purchasedate_title.Location = new System.Drawing.Point(255, 223);
            this.lb_purchasedate_title.Name = "lb_purchasedate_title";
            this.lb_purchasedate_title.Size = new System.Drawing.Size(67, 16);
            this.lb_purchasedate_title.TabIndex = 52;
            this.lb_purchasedate_title.Text = "Buy date:";
            // 
            // rb_purchasedate
            // 
            this.rb_purchasedate.BackColor = System.Drawing.Color.Transparent;
            this.rb_purchasedate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_purchasedate.BorderRadius = 10;
            this.rb_purchasedate.FillColor = System.Drawing.Color.White;
            this.rb_purchasedate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.rb_purchasedate.HoverFillColor = System.Drawing.Color.White;
            this.rb_purchasedate.IsSelected = false;
            this.rb_purchasedate.Location = new System.Drawing.Point(244, 215);
            this.rb_purchasedate.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_purchasedate.Name = "rb_purchasedate";
            this.rb_purchasedate.ShowBorder = true;
            this.rb_purchasedate.Size = new System.Drawing.Size(280, 200);
            this.rb_purchasedate.TabIndex = 53;
            this.rb_purchasedate.TabStop = false;
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
            this.btn_action.Location = new System.Drawing.Point(12, 433);
            this.btn_action.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_action.Name = "btn_action";
            this.btn_action.ShowBorder = true;
            this.btn_action.Size = new System.Drawing.Size(512, 30);
            this.btn_action.TabIndex = 55;
            this.btn_action.TabStop = false;
            this.btn_action.PhClick += new System.EventHandler(this.btn_action_PhClick);
            // 
            // nm_remainings
            // 
            this.nm_remainings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nm_remainings.Location = new System.Drawing.Point(111, 348);
            this.nm_remainings.Name = "nm_remainings";
            this.nm_remainings.Size = new System.Drawing.Size(120, 23);
            this.nm_remainings.TabIndex = 56;
            // 
            // btn_remcount
            // 
            this.btn_remcount.BackColor = System.Drawing.Color.Transparent;
            this.btn_remcount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_remcount.BorderRadius = 10;
            this.btn_remcount.Caption = "Count max";
            this.btn_remcount.FillColor = System.Drawing.Color.White;
            this.btn_remcount.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_remcount.HoverFillColor = System.Drawing.Color.White;
            this.btn_remcount.IsSelected = false;
            this.btn_remcount.Location = new System.Drawing.Point(111, 377);
            this.btn_remcount.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_remcount.Name = "btn_remcount";
            this.btn_remcount.ShowBorder = true;
            this.btn_remcount.Size = new System.Drawing.Size(120, 30);
            this.btn_remcount.TabIndex = 57;
            this.btn_remcount.TabStop = false;
            this.btn_remcount.PhClick += new System.EventHandler(this.btn_remcount_PhClick);
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HomePharmacy.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 477);
            this.Controls.Add(this.btn_remcount);
            this.Controls.Add(this.nm_remainings);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.datePurchaseCalendar);
            this.Controls.Add(this.lb_purchasedate_title);
            this.Controls.Add(this.dateExpCalendar);
            this.Controls.Add(this.lb_expdate_title);
            this.Controls.Add(this.rb_expdate);
            this.Controls.Add(this.lb_remainings_title);
            this.Controls.Add(this.rb_remainings);
            this.Controls.Add(this.nm_excount);
            this.Controls.Add(this.lb_excount_title);
            this.Controls.Add(this.rb_excount);
            this.Controls.Add(this.nm_count);
            this.Controls.Add(this.lb_count_title);
            this.Controls.Add(this.rb_count);
            this.Controls.Add(this.nm_price);
            this.Controls.Add(this.lb_price_title);
            this.Controls.Add(this.rb_price);
            this.Controls.Add(this.cb_forwhom);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.lb_name_title);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.rb_name);
            this.Controls.Add(this.rb_purchasedate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Pharmacy";
            ((System.ComponentModel.ISupportInitialize)(this.nm_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_excount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_remainings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_name_title;
        private TextBox tb_name;
        private Controls.RoundedBox rb_name;
        private Controls.PhComboBox cb_type;
        private Controls.PhComboBox cb_forwhom;
        private Controls.RoundedBox rb_price;
        private Label lb_price_title;
        private NumericUpDown nm_price;
        private NumericUpDown nm_count;
        private Label lb_count_title;
        private Controls.RoundedBox rb_count;
        private NumericUpDown nm_excount;
        private Label lb_excount_title;
        private Controls.RoundedBox rb_excount;
        private Label lb_remainings_title;
        private Controls.RoundedBox rb_remainings;
        private MonthCalendar dateExpCalendar;
        private Label lb_expdate_title;
        private Controls.RoundedBox rb_expdate;
        private MonthCalendar datePurchaseCalendar;
        private Label lb_purchasedate_title;
        private Controls.RoundedBox rb_purchasedate;
        private Controls.PhButton btn_action;
        private NumericUpDown nm_remainings;
        private Controls.PhButton btn_remcount;
    }
}