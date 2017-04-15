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

        private bool EllenorzesFelnottek()
        {
            return (nudFoglalasFelnottek.Value < 1);
        }
        private bool EllenorzesDatumok()
        {
            return (dtpElsoNap.Value > dtpUtolsoNap.Value);

        }


        private void dtpElsoNap_ValueChanged(object sender, EventArgs e)
        {
            groupBoxUtolsoNap.BackColor = EllenorzesDatumok()
               ? Color.PaleVioletRed
               : Control.DefaultBackColor;
        }

        private void dtpUtolsoNap_ValueChanged(object sender, EventArgs e)
        {
            groupBoxUtolsoNap.BackColor = EllenorzesDatumok()
                ? Color.PaleVioletRed
                : Control.DefaultBackColor;
        }

        private void nudFoglalasFelnottek_ValueChanged(object sender, EventArgs e)
        {
            EllenorzesFelnottek();
        }

        private void btnSzobaKereses_Click(object sender, EventArgs e)
        {
            EllenorzesFelnottek();


            var error = "";


            if (nudFoglalasFelnottek.Value + nudFoglalasGyermekek.Value > this.maxEnnyiSzemely)
            {
                DBFeladatok.AddError(ref error, "A legnagyobb szobába maximum " + this.maxEnnyiSzemely.ToString() + " személy fér csak el.");
            }
            if (error != "")
            {
                MessageBox.Show(error, "Figyelmeztetés...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }



    }
}
