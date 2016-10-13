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

            listBox1.DisplayMember = "nev";
            listBox1.ValueMember = "id";
            listBox1.DataSource = DBFeladatok.SelectVendeg();

        }

        private void buttonVendegek_Click(object sender, EventArgs e)
        {

            
            frmVendegManagment vendegManagment = new frmVendegManagment();
            vendegManagment.Show();
        }
 
    }
}
