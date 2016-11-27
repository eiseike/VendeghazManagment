using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendeghazManagment
{
    public partial class FrmSzobaManagment : Form
    {
        public FrmSzobaManagment()
        {
            InitializeComponent();
            refreshLstSzoba();
        }

        private void refreshLstSzoba()
        {
            lstSzoba.DataSource = null;
            DataTable dt = DBFeladatok.SzobaDataTable();
            var dict = new Dictionary<int, string>();
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    if (row["nev"].ToString().Trim() != "" &&
                        !Regex.IsMatch(Regex.Escape(row["nev"].ToString()), txtSzobaLstSzobaQuickFind.Text.Trim(),
                            RegexOptions.IgnoreCase))
                    {
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                dict.Add((int) row["id"],
                    row["nev"] + " (" + (SzobaEmelet) Int16.Parse(row["emelet"].ToString()) + ")");
            }
            if (dict.Count > 0)
            {
                lstSzoba.DataSource = new BindingSource(dict, null);
                lstSzoba.DisplayMember = "Value";
                lstSzoba.ValueMember = "Key";
            }
        }

        private void btnUjSzoba_Click(object sender, EventArgs e)
        {
            FrmSzobaManagmentUjSzoba frmSzobaManagmentUjSzoba = new FrmSzobaManagmentUjSzoba();

            if (frmSzobaManagmentUjSzoba.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DBFeladatok.SaveSzoba(frmSzobaManagmentUjSzoba.Tarolt);
                    refreshLstSzoba();
                }
                catch (Exception ex)
                {
                    EasyLog.LogMessageToFile(ex.Message);
                    throw ex;
                }
            }
        }

        private void txtSzobaLstSzobaQuickFind_TextChanged(object sender, EventArgs e)
        {
            refreshLstSzoba();
        }

        private void btnModSzoba_Click(object sender, EventArgs e)
        {
            if (lstSzoba.SelectedValue != null)
            {
                var frmSzobaManagmentUjSzoba = new FrmSzobaManagmentUjSzoba((int) lstSzoba.SelectedValue);

                if (frmSzobaManagmentUjSzoba.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DBFeladatok.UpdateSzoba((int) lstSzoba.SelectedValue, frmSzobaManagmentUjSzoba.Tarolt);
                        refreshLstSzoba();
                    }
                    catch (Exception ex)
                    {
                        EasyLog.LogMessageToFile(ex.Message);
                        throw ex;
                    }
                }
            }
        }

        private void lstSzoba_DoubleClick(object sender, EventArgs e)
        {
            btnModSzoba_Click(sender, e);
        }

        private void btnTorSzoba_Click(object sender, EventArgs e)
        {
            if (lstSzoba.SelectedValue != null)
            {
                if (
                    MessageBox.Show("Biztos benne?", "Figyelmeztetés", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    try
                    {
                        DBFeladatok.DeleteSzoba((int) lstSzoba.SelectedValue);
                        refreshLstSzoba();
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