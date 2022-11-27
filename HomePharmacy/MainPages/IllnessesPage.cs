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
using HomePharmacy.Forms;

namespace HomePharmacy.MainPages
{
    public partial class IllnessesPage : PhPage
    {
        private Person user;
        private Family? family;
        private List<Illness> illnesses;

        private IllnessForm form;

        private DataTable table;

        public IllnessesPage()
        {
            InitializeComponent();
            this.InitDataTable();

            this.form = new IllnessForm();
        }

        private void InitDataTable()
        {
            table = new DataTable();

            table.Columns.Add(new DataColumn("Id Illness", typeof(int)));
            table.Columns.Add(new DataColumn("Illed person", typeof(string)));
            table.Columns.Add(new DataColumn("Diagnose", typeof(string)));
            table.Columns.Add(new DataColumn("Start date", typeof(string)));
            table.Columns.Add(new DataColumn("End date", typeof(string)));

            this.dgv_illnesses.DataSource = table;
        }

        public override void ClearDataUI()
        {
            this.cb_email.PhText = this.cb_email.Placeholder;
            this.cb_email.Items.Clear();
            this.table.Rows.Clear();
        }

        public override void LoadDataUI()
        {
            this.cb_email.Items.Add("All");
            this.cb_email.Items.AddRange(this.illnesses.Select(x => x.IlledPerson).ToArray());

            this.LoadSpecificDataUI(this.illnesses);
        }

        private void LoadSpecificDataUI(List<Illness> illnesses)
        {
            foreach (Illness illness in illnesses)
            {
                var row = table.NewRow();
                row["Id Illness"] = illness.IdIllness;
                row["Illed person"] = illness.IlledPerson;
                row["Diagnose"] = illness.Diagnoses;
                row["Start date"] = illness.StartDate.ToShortDateString();
                row["End date"] = illness.EndDate?.ToShortDateString();
                table.Rows.Add(row);
            }
        }

        private void btn_apply_PhClick(object sender, EventArgs e)
        {
            List<Illness> filter_illnesses = null;
            if (DBValidation.PersonValidation.EmailValidation(this.cb_email.PhText))
            {
                filter_illnesses = this.illnesses.Where(x => x.IlledPerson == this.cb_email.PhText).ToList();
            }
            else filter_illnesses = this.illnesses;

            this.table.Rows.Clear();
            this.LoadSpecificDataUI(filter_illnesses);
        }

        private void btn_add_PhClick(object sender, EventArgs e)
        {
            string[] people = null;

            if (this.family != null) people = this.family.People.Select(x => x.Email).ToArray();
            else people = new string[1] { this.user.Email }; // personal cabinet mode

            this.form.InitAdd(people);
            if(this.form.ShowDialog() == DialogResult.OK)
            {
                this.illnesses.Add(this.form.Illness);
                this.ClearDataUI();
                this.LoadDataUI();
            }
        }

        private void btn_update_PhClick(object sender, EventArgs e)
        {
            var selected_row = this.dgv_illnesses.SelectedRows[0];
            int id_illness = (int)selected_row.Cells["Id Illness"].Value;

            Illness illness = this.illnesses.Where(x => x.IdIllness == id_illness).First();

            this.form.InitUpdate(illness);
            if (this.form.ShowDialog() == DialogResult.OK)
            {
                this.ClearDataUI();
                this.LoadDataUI();
            }
        }

        private void btn_info_PhClick(object sender, EventArgs e)
        {
            var selected_row = this.dgv_illnesses.SelectedRows[0];
            int id_illness = (int)selected_row.Cells["Id Illness"].Value;

            Illness illness = this.illnesses.Where(x => x.IdIllness == id_illness).First();

            this.form.InitInformation(illness);
            this.form.ShowDialog();
        }

        private async void btn_delete_PhClick(object sender, EventArgs e)
        {
            var selected_row = this.dgv_illnesses.SelectedRows[0];
            int id_illness = (int)selected_row.Cells["Id Illness"].Value;
            this.dgv_illnesses.Rows.Remove(selected_row);

            Illness illness = this.illnesses.Where(x => x.IdIllness == id_illness).First();
            this.illnesses.Remove(illness);

            await Task.Run(() => 
            {
                try
                {
                    using(HomePharmacyContext context = new HomePharmacyContext())
                    {
                        context.Illnesses.Remove(illness);
                        context.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                    if (this.InvokeRequired)
                        this.Invoke(new MethodInvoker(delegate
                        {
                            MessageBox.Show(ex.ToString(), "Database exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                }
            });

            this.ClearDataUI();
            this.LoadDataUI();
        }

        private void IllnessesPage_DataReceived()
        {
            if(Data != null && Data.Length == 3)
            {
                this.user = (Person)this.Data[0];
                this.family = (Family?)this.Data[1];
                this.illnesses = (List<Illness>)Data[2];

                this.ClearDataUI();
                this.LoadDataUI();
            }
        }
    }
}
