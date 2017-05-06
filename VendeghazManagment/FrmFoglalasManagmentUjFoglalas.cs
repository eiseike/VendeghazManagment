using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendeghazManagment
{

    public partial class FrmFoglalasManagmentUjFoglalas : Form
    {
        private int maxEnnyiSzemely;
        private List<Szoba> szobak_filter_datasource;

        public FrmFoglalasManagmentUjFoglalas()
        {
            InitializeComponent();
            int maxFelnott = DBFeladatok.MaxSzemelyekSzobakban(VendegTipus.Felnőtt);
            int maxGyermek = DBFeladatok.MaxSzemelyekSzobakban(VendegTipus.Gyermek);
            this.maxEnnyiSzemely = maxFelnott + maxGyermek;
            nudFoglalasFelnottek.Maximum = maxFelnott;
            nudFoglalasGyermekek.Maximum = maxGyermek + maxFelnott;
            PanelSwitch(gpbSzoba, false);
            PanelSwitch(gpbVendeg, false);

        }

        private void PanelSwitch(Control control, bool enabled)
        {
            foreach (Control ctrl in control.Controls)
            {
                ctrl.Enabled = enabled;
            } 
        }

        private void dtpElsoNapEllenorzesDatumTol()
        {
            groupBoxElsoNap.BackColor = EllenorzesDatumok_Tol()
                ? Control.DefaultBackColor
                : Color.PaleVioletRed;
        }
        private void dtpElsoNapEllenorzesDatumIg()
        {
            groupBoxUtolsoNap.BackColor = EllenorzesDatumok_Ig()
                ? Control.DefaultBackColor
                : Color.PaleVioletRed;
        }

        private bool EllenorzesBefernekEASzobabaAVendegek()
        {
            return nudFoglalasFelnottek.Value + nudFoglalasGyermekek.Value <= this.maxEnnyiSzemely;
        }
        private bool EllenorzesFelnottek()
        {
            return (nudFoglalasFelnottek.Value > 0);
        }
        private bool EllenorzesDatumok_Ig()
        {
            return (dtpElsoNap.Value.Date <= dtpUtolsoNap.Value.Date);
        }

        private bool EllenorzesDatumok_Tol()
        {
            return (DateTime.Now.Date <= dtpElsoNap.Value.Date);
        }

        private void dtpElsoNap_ValueChanged(object sender, EventArgs e)
        {
            dtpElsoNapEllenorzesDatumTol();
            dtpElsoNapEllenorzesDatumIg();
        }
        private void dtpUtolsoNap_ValueChanged(object sender, EventArgs e)
        {
            dtpElsoNapEllenorzesDatumTol();
            dtpElsoNapEllenorzesDatumIg();
        }

        private void nudFoglalasFelnottek_ValueChanged(object sender, EventArgs e)
        {
            EllenorzesFelnottek();
        }

        private void btnSzobaKereses_Click(object sender, EventArgs e)
        {
            EllenorzesFelnottek();
            dtpElsoNapEllenorzesDatumTol();
            dtpElsoNapEllenorzesDatumIg();


            var error = "";


            if (false == EllenorzesBefernekEASzobabaAVendegek())
            {
                DBFeladatok.AddError(ref error, "A legnagyobb szobába maximum " + this.maxEnnyiSzemely.ToString() + " személy fér csak el.");
            }
            if (false == EllenorzesDatumok_Tol())
            {
                DBFeladatok.AddError(ref error, "Szobát csak a mai naptól lehet foglalni.");
            }
            else if (false == EllenorzesDatumok_Ig())
            {
                DBFeladatok.AddError(ref error, "Hibás foglalási dátum, az utolsó nap az elsö elött van.");
            }
            if (error != "")
            {
                MessageBox.Show(error, "Figyelmeztetés...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
            else
            {
                List<Szoba> szabad_szobak = DBFeladatok.SzabadSzobaKeresese((int)nudFoglalasFelnottek.Value, (int)nudFoglalasGyermekek.Value,
                    dtpElsoNap.Value, dtpUtolsoNap.Value);
                if (szabad_szobak.Count > 0)
                {
                    PanelSwitch(gpbSzoba, true);
                    txtSzobaLstSzobaQuickFind.Text = "";
                    szobak_filter_datasource = szabad_szobak;
                    lstSzoba.DataSource = szobak_filter_datasource;

                } 
            }
        }

        private void txtSzobaLstSzobaQuickFind_TextChanged(object sender, EventArgs e)
        {
            refreshLstSzoba();
        }

        private void refreshLstSzoba()
        {
            lstSzoba.DataSource = null;
            List<Szoba> szurtList = new List<Szoba>();
            foreach (Szoba szoba in szobak_filter_datasource)
            {
                try
                {
                    if (!Regex.IsMatch(Regex.Escape(szoba.ToString()), txtSzobaLstSzobaQuickFind.Text.Trim(),
                        RegexOptions.IgnoreCase))
                    {
                        continue;
                    }
                }
                catch (Exception)
                {
                }
                if (szoba.Id > 0)
                {
                    szurtList.Add(szoba);
                }
            }

            lstSzoba.DataSource = szurtList;
        }
 
        private void lstSzoba_DoubleClick(object sender, EventArgs e)
        {
            if (lstSzoba.SelectedIndex > -1)
            {
                MessageBox.Show((lstSzoba.SelectedItem).ToString());
            }
        }
    }
}
