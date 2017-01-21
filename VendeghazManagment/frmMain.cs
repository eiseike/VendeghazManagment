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
    public partial class FrmMain : Form
    {
        private string connectionString;

        public FrmMain()
        {
            InitializeComponent();

            try
            {
                DBFeladatok.ConnectSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem sikerült csatlakozni az adatbázishoz." + Environment.NewLine + ex.Message);
            }

            //FrmFoglalasManagmentUjFoglalas frmFoglalasManagmentUjFoglalas = new FrmFoglalasManagmentUjFoglalas();
            //frmFoglalasManagmentUjFoglalas.ShowDialog();
        }

        private void btnVendegek_Click(object sender, EventArgs e)
        {
            FrmVendegManagment vendegManagment = new FrmVendegManagment();
            vendegManagment.Show();
        }

        private void btnFoglalas_Click(object sender, EventArgs e)
        {
            FrmFoglalasManagment frmFoglalasManagment = new FrmFoglalasManagment();
            frmFoglalasManagment.Show();
        }

        private void btnSzobak_Click(object sender, EventArgs e)
        {
            FrmSzobaManagment frmSzobaManagment = new FrmSzobaManagment();
            frmSzobaManagment.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos kilép?", "Biztos benne?", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                DBFeladatok.DisconnectSQL();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }
    }
}