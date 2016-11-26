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
    public partial class FrmSzobaManagmentUjSzoba : Form
    {
        // a formban tarolt peldanya a letrehozando/modositando osztaly(ok)nak
        private Szoba _tarolt;

        internal Szoba Tarolt
        {
            get
            {
                return _tarolt;
            }

            set
            {
                _tarolt = value;
            }
        }

        public FrmSzobaManagmentUjSzoba()
        {
            initCtor();
        }

        private void initCtor()
        {
            InitializeComponent();
            string[] emeletek = Enum.GetNames(typeof(SzobaEmelet));
            foreach (string item in emeletek)
            {
                cboSzobaEmelet.Items.Add(item.Replace("_", " "));
            }
            cboSzobaEmelet.SelectedIndex = 0;

            cboSzobaKiadhato.DataSource = Enum.GetNames(typeof(IgenNem));

            this.CancelButton = btnCancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var error = "";
            if (txtSzobaNev.Text.Trim() == "")
            {
                DBFeladatok.AddError(ref error, "Nem adott meg nevet!");
            }
           
            if (error != "")
            {
                MessageBox.Show(error, "Figyelmeztetés...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (Tarolt == null)
                {
                    _tarolt = new Szoba(
                        txtSzobaNev.Text.Trim(), (SzobaEmelet)cboSzobaEmelet.SelectedIndex,
                        (int)nudSzobaFelnotthely.Value, (int)nudSzobaGyermekHely.Value, cboSzobaKiadhato.SelectedIndex==1, 
                        txtSzobaMegjegyzes.Text.Trim()
                    );
                    EasyLog.LogMessageToFile("New szoba =" + _tarolt);
                }
                else
                {
                    _tarolt.Nev = txtSzobaNev.Text.Trim();
                    _tarolt.Emelet = (SzobaEmelet)cboSzobaEmelet.SelectedIndex;
                    _tarolt.Felnott_hely = (int)nudSzobaFelnotthely.Value;
                    _tarolt.Gyermek_hely = (int)nudSzobaGyermekHely.Value;
                    _tarolt.Kiadhato = cboSzobaKiadhato.SelectedIndex == 1;
                    _tarolt.Megjegyzes = txtSzobaMegjegyzes.Text.Trim();
                    EasyLog.LogMessageToFile("Mod szoba = " + _tarolt);
                }
            }
        }

    }
}
