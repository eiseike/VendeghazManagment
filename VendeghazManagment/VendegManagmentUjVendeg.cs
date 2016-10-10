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
    public partial class VendegManagmentUjVendeg : Form
    {
        private Vendeg _tarolt;

        public VendegManagmentUjVendeg()
        {
            InitializeComponent();
            comboBoxOkmanyTipus.DataSource = Enum.GetValues(typeof(OkmanyTipus));
            comboBoxNem.DataSource = Enum.GetValues(typeof(Nem));
        }

        //#TODO: Módósítás

        internal Vendeg Tarolt
        {
            get
            {
                return _tarolt;
            }
        }

        //Kisegítő funkció ami a bejövő hibaüzenetet hozzáfúzi a hibákhoz újsorral elválasztva
        private void addError(ref string error, string szoveg)
        {
            if (error != "")
                error += Environment.NewLine;
            error += szoveg;
        }

        
        private void buttonOK_Click(object sender, EventArgs e)
        {

            if (Tarolt == null)
            {
                string error = "";
                if (textBoxNev.Text.Trim() == "")
                {
                    addError(ref error, "Nem adott meg nevet!");
                }
                if (textBoxOkmanySzam.Text.Trim() == "")
                {
                    addError(ref error, "Nem adott meg okmányszámot!");
                }

                if (error!="")
                {
                    MessageBox.Show(error, "Figyelmeztetés...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.None;
                }
                else
                {
                    _tarolt = new Vendeg(textBoxNev.Text.Trim(), (Nem)comboBoxNem.SelectedItem, (OkmanyTipus)comboBoxOkmanyTipus.SelectedItem, textBoxOkmanySzam.Text.Trim(), dateTimePickerSzuletesiDatum.Value );
                }
            }
            else
            {
                throw new NotImplementedException("Vendeg Modositasa hol?");
            }

        }
    }
}
