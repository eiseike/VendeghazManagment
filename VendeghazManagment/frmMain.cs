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
    public partial class frmMain : Form
    {
        private string connectionString;

        public frmMain()
        {
            InitializeComponent();
        }

        private void buttonVendegek_Click(object sender, EventArgs e)
        {

            
            frmVendegManagment vendegManagment = new frmVendegManagment();
            vendegManagment.Show();
        }
    }
}
