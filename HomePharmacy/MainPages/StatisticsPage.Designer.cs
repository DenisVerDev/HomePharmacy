namespace HomePharmacy.MainPages
{
    partial class StatisticsPage
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
            this.rb_top = new HomePharmacy.Controls.RoundedBox();
            this.cb_selectyear = new HomePharmacy.Controls.PhComboBox();
            this.btn_apply = new HomePharmacy.Controls.PhButton();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chartIllnesses = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.chartMoney = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_top
            // 
            this.rb_top.BackColor = System.Drawing.Color.Transparent;
            this.rb_top.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.rb_top.BorderRadius = 0;
            this.rb_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_top.FillColor = System.Drawing.Color.White;
            this.rb_top.HoverBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.rb_top.HoverFillColor = System.Drawing.Color.White;
            this.rb_top.IsSelected = false;
            this.rb_top.Location = new System.Drawing.Point(0, 0);
            this.rb_top.MinimumSize = new System.Drawing.Size(30, 30);
            this.rb_top.Name = "rb_top";
            this.rb_top.ShowBorder = true;
            this.rb_top.Size = new System.Drawing.Size(822, 58);
            this.rb_top.TabIndex = 0;
            this.rb_top.TabStop = false;
            // 
            // cb_selectyear
            // 
            this.cb_selectyear.BackColor = System.Drawing.Color.Transparent;
            this.cb_selectyear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.cb_selectyear.BorderRadius = 10;
            this.cb_selectyear.FillColor = System.Drawing.Color.White;
            this.cb_selectyear.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.cb_selectyear.HoverFillColor = System.Drawing.Color.White;
            this.cb_selectyear.IsSelected = false;
            this.cb_selectyear.Location = new System.Drawing.Point(14, 16);
            this.cb_selectyear.MinimumSize = new System.Drawing.Size(30, 30);
            this.cb_selectyear.Name = "cb_selectyear";
            this.cb_selectyear.PhText = "Select year";
            this.cb_selectyear.Placeholder = "Select year";
            this.cb_selectyear.ShowBorder = true;
            this.cb_selectyear.Size = new System.Drawing.Size(225, 31);
            this.cb_selectyear.TabIndex = 32;
            this.cb_selectyear.TabStop = false;
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.Transparent;
            this.btn_apply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.btn_apply.BorderRadius = 10;
            this.btn_apply.Caption = "Apply filter";
            this.btn_apply.FillColor = System.Drawing.Color.White;
            this.btn_apply.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(127)))), ((int)(((byte)(120)))));
            this.btn_apply.HoverFillColor = System.Drawing.Color.White;
            this.btn_apply.IsSelected = false;
            this.btn_apply.Location = new System.Drawing.Point(696, 16);
            this.btn_apply.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.ShowBorder = true;
            this.btn_apply.Size = new System.Drawing.Size(100, 31);
            this.btn_apply.TabIndex = 59;
            this.btn_apply.TabStop = false;
            this.btn_apply.PhClick += new System.EventHandler(this.btn_apply_PhClick);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.White;
            this.flowPanel.Controls.Add(this.chartIllnesses);
            this.flowPanel.Controls.Add(this.chartMoney);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 58);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.flowPanel.Size = new System.Drawing.Size(822, 470);
            this.flowPanel.TabIndex = 60;
            // 
            // chartIllnesses
            // 
            this.chartIllnesses.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(147)))));
            this.chartIllnesses.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(235)))));
            this.chartIllnesses.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.chartIllnesses.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartIllnesses.ChartArea.CursorReDraw = false;
            this.chartIllnesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartIllnesses.IsWindowLess = false;
            // 
            // 
            // 
            this.chartIllnesses.Legend.Location = new System.Drawing.Point(663, 60);
            this.chartIllnesses.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartIllnesses.Localize = null;
            this.chartIllnesses.Location = new System.Drawing.Point(3, 8);
            this.chartIllnesses.Name = "chartIllnesses";
            this.chartIllnesses.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.chartIllnesses.PrimaryXAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartIllnesses.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartIllnesses.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartIllnesses.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartIllnesses.PrimaryXAxis.Margin = true;
            this.chartIllnesses.PrimaryXAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartIllnesses.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.chartIllnesses.PrimaryXAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartIllnesses.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartIllnesses.PrimaryYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartIllnesses.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartIllnesses.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartIllnesses.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartIllnesses.PrimaryYAxis.Margin = true;
            this.chartIllnesses.PrimaryYAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartIllnesses.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.chartIllnesses.PrimaryYAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartIllnesses.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartIllnesses.Size = new System.Drawing.Size(750, 300);
            this.chartIllnesses.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            this.chartIllnesses.Style3D = true;
            this.chartIllnesses.TabIndex = 0;
            this.chartIllnesses.Text = "Illnesses count";
            // 
            // 
            // 
            this.chartIllnesses.Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartIllnesses.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartIllnesses.Title.Name = "Default";
            this.chartIllnesses.Titles.Add(this.chartIllnesses.Title);
            this.chartIllnesses.VisualTheme = "";
            // 
            // chartMoney
            // 
            this.chartMoney.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(229)))), ((int)(((byte)(147)))));
            this.chartMoney.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(235)))));
            this.chartMoney.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.chartMoney.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartMoney.ChartArea.CursorReDraw = false;
            this.chartMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartMoney.IsWindowLess = false;
            // 
            // 
            // 
            this.chartMoney.Legend.Location = new System.Drawing.Point(663, 60);
            this.chartMoney.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartMoney.Localize = null;
            this.chartMoney.Location = new System.Drawing.Point(3, 314);
            this.chartMoney.Name = "chartMoney";
            this.chartMoney.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.chartMoney.PrimaryXAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartMoney.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartMoney.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartMoney.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartMoney.PrimaryXAxis.Margin = true;
            this.chartMoney.PrimaryXAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartMoney.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.chartMoney.PrimaryXAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartMoney.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartMoney.PrimaryYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartMoney.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chartMoney.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartMoney.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartMoney.PrimaryYAxis.Margin = true;
            this.chartMoney.PrimaryYAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chartMoney.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.chartMoney.PrimaryYAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartMoney.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartMoney.Size = new System.Drawing.Size(750, 300);
            this.chartMoney.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            this.chartMoney.Style3D = true;
            this.chartMoney.TabIndex = 1;
            this.chartMoney.Text = "Money spent on medicines";
            // 
            // 
            // 
            this.chartMoney.Title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chartMoney.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.chartMoney.Title.Name = "Default";
            this.chartMoney.Titles.Add(this.chartMoney.Title);
            this.chartMoney.VisualTheme = "";
            // 
            // StatisticsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cb_selectyear);
            this.Controls.Add(this.rb_top);
            this.Name = "StatisticsPage";
            this.Size = new System.Drawing.Size(822, 528);
            this.DataReceived += new HomePharmacy.Controls.PhPage.GetData(this.StatisticsPage_DataReceived);
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundedBox rb_top;
        private Controls.PhComboBox cb_selectyear;
        private Controls.PhButton btn_apply;
        private FlowLayoutPanel flowPanel;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartIllnesses;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartMoney;
    }
}
