using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendeghazManagment
{
    public partial class FrmVendegManagment : Form
    {
        private void refreshLstVendeg()
        {
            lstVendeg.DataSource = null;
            DataTable dt = DBFeladatok.VendegDataTable();
            var dict = new Dictionary<int, string>();
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    if (row["nev"].ToString().Trim() != "" &&
                        !Regex.IsMatch(Regex.Escape(row["nev"].ToString()), txtVendegLstVendegQuickFind.Text.Trim(),
                            RegexOptions.IgnoreCase))
                    {
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                dict.Add((int)row["id"],
                    row["Adatok"] + " ("  + ")");
            }
            if (dict.Count > 0)
            {
                lstVendeg.DataSource = new BindingSource(dict, null);
                lstVendeg.DisplayMember = "Value";
                lstVendeg.ValueMember = "Key";
            }
        }

        public FrmVendegManagment()
        {
            InitializeComponent();
            refreshLstVendeg();
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

                refreshLstVendeg();

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

                    refreshLstVendeg();
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

                    refreshLstVendeg();

                }
            }
        }

        private void txtVendegLstVendegQuickFind_TextChanged(object sender, EventArgs e)
        {
            refreshLstVendeg();
        }
    }
}
