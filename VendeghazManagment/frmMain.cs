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
    public partial class FrmMain : Form
    {
        private string connectionString;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnVendegek_Click(object sender, EventArgs e)
        { 
            FrmVendegManagment vendegManagment = new FrmVendegManagment();
            vendegManagment.Show();
        }

        private void btnSzobak_Click(object sender, EventArgs e)
        {
            FrmSzobaManagment frmSzobaManagment = new FrmSzobaManagment();
            frmSzobaManagment.Show();
        }
    }
}
