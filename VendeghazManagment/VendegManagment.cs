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
    public partial class VendegManagment : Form
    {
        public VendegManagment()
        {
            InitializeComponent();
        }

        private void buttonUjVendegHozzaadasa_Click(object sender, EventArgs e)
        {
            VendegManagmentUjVendeg vendegManagmentUjVendeg = new VendegManagmentUjVendeg();
            vendegManagmentUjVendeg.ShowDialog();
        }
    }
}
