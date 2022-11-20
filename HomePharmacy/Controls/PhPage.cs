using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePharmacy.Controls
{
    public partial class PhPage : UserControl
    {
        
        public delegate void GetData();
        public event GetData? DataReceived;

        public object[]? Data 
        {
            get { return this.data; }
            set
            {
                this.data = value;
                if (DataReceived != null)
                    DataReceived();
            }
        }

        public bool DbOperation { get; protected set; }

        private object[]? data;

        public PhPage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.DbOperation = false;
        }

        public virtual void HideErrors() { }

        public virtual void ClearInput() { }
    }
}
