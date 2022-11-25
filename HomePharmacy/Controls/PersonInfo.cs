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

namespace HomePharmacy.Controls
{
    public partial class PersonInfo : RoundedBox
    {
        public Person? Person
        {
            get { return this.person; }
            set
            {
                this.person = value;
                if (value != null) this.LoadDataUI();
            }
        }

        private Person? person;

        public PersonInfo()
        {
            InitializeComponent();
        }

        private void LoadDataUI()
        {
            this.lb_email.Text = this.person.Email;
            this.lb_name.Text = this.person.Name;
            this.lb_sex.Text = this.person.Sex;

            if (this.person.BirthDate != null) this.lb_birthdate.Text = this.person.BirthDate.Value.ToShortDateString();
            else this.lb_birthdate.Text = String.Empty;

            // load photo
            if (this.person.Photo != null) this.LoadImage();
            else this.ResetImage();
        }

        private void ResetImage()
        {
            this.phPhoto.HoverBorderColor = this.phPhoto.BorderColor;
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
                this.phPhoto.IconImage = (Image)converter.ConvertFrom(this.person.Photo);
            }
            catch (Exception ex)
            {
                this.ResetImage();
            }
        }
    }
}
