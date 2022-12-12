using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePharmacy.Models;
using HomePharmacy.Controls;
using Syncfusion.Windows.Forms.Chart;

namespace HomePharmacy.MainPages
{
    public partial class StatisticsPage : PhPage
    {
        private Person user;
        private Family? family;
        private List<Illness> illnesses;
        private List<Medicine> medicines;

        public StatisticsPage()
        {
            InitializeComponent();
        }

        private void InitCharts(int year)
        {
            this.flowPanel.Controls.OfType<ChartControl>().ToList().ForEach(x =>
            {
                x.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                x.PrimaryXAxis.DateTimeFormat = "MM";
                x.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(new DateTime(year-1, 12, 1), new DateTime(year+1, 1, 1), 1, ChartDateTimeIntervalType.Months);
            });
        }

        public override void ClearDataUI()
        {
            this.cb_selectyear.Items.Clear();
            this.cb_selectyear.PhText = this.cb_selectyear.Placeholder;
        }

        public override void LoadDataUI()
        {
            this.InitCharts(DateTime.Today.Year);

            if (this.illnesses.Count > 0)
            {
                int year = this.illnesses.Select(x => x.StartDate).Min().Year;
                for (int i = year; i <= DateTime.Today.Year; i++)
                {
                    this.cb_selectyear.Items.Add(i);
                }

                this.LoadCharts(DateTime.Today.Year);
            }
            else
            {
                this.chartIllnesses.Series.Clear();
                this.chartMoney.Series.Clear();
            }
        }

        private void LoadIllnessesStatistics(int year, Person person)
        {
            ChartSeries series = new ChartSeries(person.Name, ChartSeriesType.Column);

            for (int month = 1; month <= 12; month++)
            {
                int illnesses_count = 0;
                DateTime between = new DateTime(year, month, 1);

                this.illnesses.Where(x=>x.IlledPerson == person.Email).ToList().ForEach(x => 
                {
                    DateTime start = new DateTime(x.StartDate.Year,x.StartDate.Month,1);
                    DateTime end = x.EndDate != null ? new DateTime(x.EndDate.Value.Year,x.EndDate.Value.Month,1) : DateTime.MaxValue;

                    if (between.Ticks >= start.Ticks && between.Ticks <= end.Ticks) illnesses_count++;

                });

                series.Points.Add(between, illnesses_count);
            }

            this.chartIllnesses.Series.Add(series);
        }

        private void LoadMoneyStatistics(int year, Person person)
        {
            ChartSeries series = new ChartSeries(person.Name, ChartSeriesType.Column);

            for (int month = 1; month <= 12; month++)
            {
                decimal money_count = 0;
                DateTime between = new DateTime(year, month, 1);

                this.medicines.Where(x => x.ForWhom == person.Email).ToList().ForEach(x =>
                {
                    DateTime start = new DateTime(x.PurchaseDate.Year, x.PurchaseDate.Month, 1);

                    if (between.Ticks == start.Ticks) money_count += x.Price;
                });

                series.Points.Add(between, (int)money_count);
            }

            this.chartMoney.Series.Add(series);
        }

        private void LoadCharts(int year)
        {
            this.chartIllnesses.Series.Clear();
            this.chartMoney.Series.Clear();

            if (this.family == null) // personal cabinet
            {
                this.LoadIllnessesStatistics(year, this.user);
                this.LoadMoneyStatistics(year, this.user);
            }
            else // family cabinet
            {
                this.family.People.ToList().ForEach(x => 
                { 
                    this.LoadIllnessesStatistics(year, x);
                    this.LoadMoneyStatistics(year, x);
                });
            }
        }

        private void btn_apply_PhClick(object sender, EventArgs e)
        {
            int year;
            if (Int32.TryParse(this.cb_selectyear.PhText, out year))
            {
                this.InitCharts(year);
                this.LoadCharts(year);
            }
            else MessageBox.Show("Wrong year!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void StatisticsPage_DataReceived()
        {
            try
            {
                if (this.Data != null && this.Data.Length == 4)
                {
                    this.user = (Person)this.Data[0];
                    this.family = (Family?)this.Data[1];
                    this.illnesses = (List<Illness>)this.Data[2];
                    this.medicines = (List<Medicine>)this.Data[3];

                    this.ClearDataUI();
                    this.LoadDataUI();
                }
            }
            catch(Exception ex)
            {
                this.Enabled = false;
            }
        }
    }
}
