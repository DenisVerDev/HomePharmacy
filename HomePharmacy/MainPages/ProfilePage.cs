using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePharmacy.Controls;
using HomePharmacy.Models;

namespace HomePharmacy.MainPages
{
    public partial class ProfilePage : PhPage
    {
        public event EventHandler LogoutEvent;
        public event EventHandler ChangeCabinetEvent;

        private const long max_size = 1000000; // 1mb

        private Person user;

        public ProfilePage()
        {
            InitializeComponent();
            this.datebirthCalendar.MaxDate = DateTime.Today;
        }

        public override void ClearDataUI()
        {
            this.lb_email.Text = String.Empty;
            this.lb_name.Text = String.Empty;
            this.lb_sex.Text = String.Empty;
            this.datebirthCalendar.SetDate(this.datebirthCalendar.MaxDate);
            this.ResetImage();
        }

        public override void LoadDataUI()
        {
            // load base info
            this.lb_email.Text = this.user.Email;
            this.lb_name.Text = this.user.Name;
            this.lb_sex.Text = this.user.Sex;
            if (this.user.BirthDate != null) this.datebirthCalendar.SetDate((DateTime)this.user.BirthDate);

            // load photo
            if (this.user.Photo != null) this.LoadImage();
            else this.ResetImage();
        }

        private void ResetImage()
        {
            this.phPhoto.HoverBorderColor = Color.FromArgb(255, 91, 127, 120);
            this.phPhoto.FillPercent = 0.7f;
            this.phPhoto.IconImage = Properties.Resources.profile_photo;
        }

        private void LoadImage()
        {
            try
            {
                this.phPhoto.HoverBorderColor = this.phPhoto.BorderColor;
                this.phPhoto.FillPercent = 0.99f;

                ImageConverter converter = new ImageConverter();
                this.phPhoto.IconImage = (Image)converter.ConvertFrom(this.user.Photo);
            }
            catch(Exception ex)
            {
                this.ResetImage();
            }
        }

        private void LoadImage(Image img)
        {
            this.phPhoto.HoverBorderColor = this.phPhoto.BorderColor;
            this.phPhoto.FillPercent = 0.99f;
            this.phPhoto.IconImage = img;
        }

        private async void UploadPhoto(byte[]? data)
        {
            this.DbOperation = true;

            await Task.Run(() => 
            {
                try
                {
                    using (HomePharmacyContext context = new HomePharmacyContext())
                    {
                        this.user.Photo = data;
                        context.Update(this.user);
                        context.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            MessageBox.Show(ex.ToString(), "Database exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }));
                    }
                }
            });

            this.DbOperation = false;
        }

        private void phPhoto_PhClick(object sender, EventArgs e)
        {
            if (!this.DbOperation)
            {
                try
                {
                    OpenFileDialog opf = new OpenFileDialog();
                    opf.Title = "Select image to load";
                    opf.Filter = "png|*.png|jpg|*.jpg";

                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        string filename = opf.FileName;
                        long size = new FileInfo(filename).Length;

                        if (size <= max_size)
                        {
                            Image img = Image.FromFile(filename);
                            ImageConverter converter = new ImageConverter();

                            byte[] data = new byte[1];
                            data = (byte[])converter.ConvertTo(img, data.GetType());

                            this.LoadImage(img);
                            this.UploadPhoto(data);
                        }
                        else MessageBox.Show("Size of the uploaded image must be under 1mb", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "File exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_remove_PhClick(object sender, EventArgs e)
        {
            if (!this.DbOperation)
            {
                this.UploadPhoto(null);
                this.ResetImage();
            }
        }

        private async void btn_save_PhClick(object sender, EventArgs e)
        {
            if (!this.DbOperation)
            {
                this.DbOperation = true;

                DateTime selectedDate = this.datebirthCalendar.SelectionRange.Start;

                await Task.Run(() =>
                {
                    try
                    {
                        using (HomePharmacyContext context = new HomePharmacyContext())
                        {
                            this.user.BirthDate = selectedDate;
                            context.Update(this.user);
                            context.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                MessageBox.Show(ex.ToString(), "Database exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                        }
                    }
                });

                this.DbOperation = false;
            }
        }

        private void btn_changecab_PhClick(object sender, EventArgs e)
        {
            if (!this.DbOperation && this.ChangeCabinetEvent != null) this.ChangeCabinetEvent(this, e);
        }

        private void btn_logout_PhClick(object sender, EventArgs e)
        {
            if (!this.DbOperation && this.LogoutEvent != null) this.LogoutEvent(this, e);
        }

        private void ProfilePage_DataReceived()
        {
            try
            {
                if (this.Data != null && this.Data.Length == 1)
                {
                    this.user = (Person)this.Data[0];

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
