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
    public partial class frmVendegManagment : Form
    {
        public frmVendegManagment()
        {
            InitializeComponent();
        }

        private void buttonUjVendegHozzaadasa_Click(object sender, EventArgs e)
        {
            frmVendegManagmentUjVendeg vendegManagmentUjVendeg = new frmVendegManagmentUjVendeg();

            if (vendegManagmentUjVendeg.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    DBFeladatok.SaveVendeg(vendegManagmentUjVendeg.Tarolt);
                }
                catch (Exception ex)
                {
                    EasyLog.LogMessageToFile(ex.Message);
                    throw ex;
                }
                
               //refresh ha kinn vannak valahol az adatok

            }
        }
    }
}
