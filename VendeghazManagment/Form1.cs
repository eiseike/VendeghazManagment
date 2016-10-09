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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVendegek_Click(object sender, EventArgs e)
        {
            VendegManagment vm = new VendegManagment();
            vm.Show();
        }

        // atmenetileg felugro ablak
        //#TODO:vedd le
        private void Form1_Load(object sender, EventArgs e)
        {
            VendegManagmentUjVendeg vendegManagmentUjVendeg = new VendegManagmentUjVendeg();
            vendegManagmentUjVendeg.ShowDialog();
        }
    }
}
