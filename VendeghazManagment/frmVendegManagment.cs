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

            lstVendeg.DataSource = DBFeladatok.VendegDataTable();
            lstVendeg.DisplayMember = "Adatok";
            lstVendeg.ValueMember = "id";
        }

        private void btnUjVendeg_Click(object sender, EventArgs e)
        {
            FrmVendegManagmentUjVendeg vendegManagmentUjVendeg = new FrmVendegManagmentUjVendeg();

            if (vendegManagmentUjVendeg.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    DBFeladatok.SaveVendeg(vendegManagmentUjVendeg.Tarolt);
                    lstVendeg.DataSource = DBFeladatok.VendegDataTable();
                }
                catch (Exception ex)
                {
                    EasyLog.LogMessageToFile(ex.Message);
                    throw ex;
                }

                //refresh ha kinn vannak valahol az adatok

            }
        }

        private void btnModVendeg_Click(object sender, EventArgs e)
        {
            if (lstVendeg.SelectedValue != null)
            {

                var vendegManagmentUjVendeg = new FrmVendegManagmentUjVendeg((int)lstVendeg.SelectedValue);

                if (vendegManagmentUjVendeg.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        DBFeladatok.UpdateVendeg((int)lstVendeg.SelectedValue, vendegManagmentUjVendeg.Tarolt);
                        lstVendeg.DataSource = DBFeladatok.VendegDataTable();
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

        private void lstVendeg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnModVendeg_Click(sender, e);
        }

        private void btnTorVendeg_Click(object sender, EventArgs e)
        {
            if (lstVendeg.SelectedValue != null)
            {
                if (
                    MessageBox.Show("Biztos benne?", "Figyelmeztetés", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    try
                    {
                        DBFeladatok.DeleteVendeg((int)lstVendeg.SelectedValue);
                        lstVendeg.DataSource = DBFeladatok.VendegDataTable();
                    }
                    catch (Exception ex)
                    {
                        EasyLog.LogMessageToFile(ex.Message);
                        throw ex;
                    }
                
                    
                }
            }
        }
    }
}
