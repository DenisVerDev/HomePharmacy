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
    public partial class MedicinesPage : PhPage
    {
        private Person user;
        private Family? family;
        private List<Medicine> medicines;

        private MedicineForm form;

        public MedicinesPage()
        {
            InitializeComponent();
            this.form = new MedicineForm();
        }

        public override void LoadDataUI()
        {
            this.dgv_medicines.DataSource = this.medicines; // rework
        }

        private Medicine GetSelectedMedicine()
        {
            var selected_row = this.dgv_medicines.SelectedRows[0];
            int id_medicine = (int)selected_row.Cells["IdMedicine"].Value;

            return this.medicines.Where(x => x.IdMedicine == id_medicine).First();
        }

        private void btn_add_PhClick(object sender, EventArgs e)
        {
            this.form.InitAction(ActionType.ADD, user, family, null);
            if (this.form.ShowDialog() == DialogResult.OK) this.medicines.Add(this.form.Medicine);
        }

        private void btn_update_PhClick(object sender, EventArgs e)
        {
            this.form.InitAction(ActionType.UPDATE, user, family, this.GetSelectedMedicine());
            this.form.ShowDialog();
        }

        private void btn_info_PhClick(object sender, EventArgs e)
        {
            this.form.InitAction(ActionType.INFORMATION, user, family, this.GetSelectedMedicine());
            this.form.ShowDialog();
        }

        private async void btn_delete_PhClick(object sender, EventArgs e)
        {
            if(!this.DbOperation)
            {
                this.DbOperation = true;

                Medicine medicine = this.GetSelectedMedicine();
                this.medicines.Remove(medicine);

                await Task.Run(() =>
                {
                    try
                    {
                        using(HomePharmacyContext context = new HomePharmacyContext())
                        {
                            context.Medicines.Remove(medicine);
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

                this.DbOperation = false;
            }
        }

        private void MedicinesPage_DataReceived()
        {
            if(this.Data != null && this.Data.Length == 3)
            {
                this.user = (Person)this.Data[0];
                this.family = (Family?)this.Data[1];
                this.medicines = (List<Medicine>)this.Data[2];

                this.LoadDataUI();
            }
        }
    }
}
