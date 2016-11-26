using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
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
                dict.Add((int) row["id"],
                    row["nev"] + " (" + ((SzobaEmelet) Int16.Parse(row["emelet"].ToString())) + ")");

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

                //refresh ha kinn vannak valahol az adatok

            }
        
        }
    }
}
