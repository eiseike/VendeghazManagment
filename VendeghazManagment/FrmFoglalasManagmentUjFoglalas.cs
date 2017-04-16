using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendeghazManagment
{

    public partial class FrmFoglalasManagmentUjFoglalas : Form
    {
        private int maxEnnyiSzemely;

        public FrmFoglalasManagmentUjFoglalas()
        {
            InitializeComponent();
            this.maxEnnyiSzemely = 5; //TODO: amennyi max a felnött hely initializálásnál ki kell nyerni
            nudFoglalasFelnottek.Maximum = this.maxEnnyiSzemely;
            nudFoglalasGyermekek.Maximum = this.maxEnnyiSzemely;
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
                List<Szoba> szabad_szobak = SzabadSzobaKeresese((int)nudFoglalasFelnottek.Value, (int)nudFoglalasGyermekek.Value,
                    dtpElsoNap.Value, dtpUtolsoNap.Value);
                foreach (Szoba szoba in szabad_szobak)
                {
                    MessageBox.Show("szabad szoba" + szoba.ToString());
                }
            }
        }

       


        private List<Szoba> SzabadSzobaKeresese(int felnott, int gyermek, DateTime tol, DateTime ig)
        {
            List<Szoba> szobak =  new List<Szoba>();
            szobak.Add(new Szoba("teszt nev", SzobaEmelet.Első_emelet, 3, 2, true, "Alles OK!"));
            return szobak;
        }


    }
}
