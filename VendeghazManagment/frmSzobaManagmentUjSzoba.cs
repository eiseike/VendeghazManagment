using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendeghazManagment
{
    public partial class FrmSzobaManagmentUjSzoba : Form
    {
        public FrmSzobaManagmentUjSzoba()
        {
            initCtor();
        }

        private void initCtor()
        {
            InitializeComponent();
            string[] emeletek = Enum.GetNames(typeof(SzobaEmelet));

            foreach (string item in emeletek)
            {
                cboSzobaEmelet.Items.Add(item.Replace("_", " "));
            }
            this.CancelButton = btnCancel;
        }
    }
}
