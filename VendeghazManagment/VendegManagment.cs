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
 
            if (vendegManagmentUjVendeg.ShowDialog() == DialogResult.OK)
            {

               //hozzadni az adatbazishoz

              
              MessageBox.Show(vendegManagmentUjVendeg.Tarolt.ToString(), "hi :)");

               //refresh ha kinn vannak valahol az adatok

            }
        }
    }
}
