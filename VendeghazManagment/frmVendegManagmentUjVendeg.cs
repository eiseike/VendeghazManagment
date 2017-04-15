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
    public partial class FrmVendegManagmentUjVendeg : Form
    {

        // a formban tarolt peldanya a letrehozando/modositando osztaly(ok)nak
        private Vendeg _tarolt;

        //kozos initializacio
        private void initCtor()
        {
            InitializeComponent();
            cboVendegOkmanyTipus.DataSource = Enum.GetValues(typeof(VendegOkmanyTipus));
            cboVendegNem.DataSource = Enum.GetValues(typeof(VendegNem));
            this.CancelButton = btnCancel;
        }

        public FrmVendegManagmentUjVendeg()
        {
            initCtor();
        }

        public FrmVendegManagmentUjVendeg(int vendegId)
        {
            initCtor();
            //dtpVendegSzuletesiDatum.Enabled = false;
            //cboVendegNem.Enabled = false;
            _tarolt = DBFeladatok.SelectVendeg(vendegId);
            txtVendegNev.Text = _tarolt.Nev;
            txtVendegOkmanyAzonosito.Text = _tarolt.OkmanyAzonosito;
            cboVendegNem.SelectedIndex =(int) _tarolt.VendegNem;
            cboVendegOkmanyTipus.SelectedIndex = (int) _tarolt.VendegOkmanyTipus;
            dtpVendegSzuletesiDatum.Value= _tarolt.SzuletesiDatum;
        }


        internal Vendeg Tarolt
        {
            get { return _tarolt; }
        }



        private void buttonOK_Click(object sender, EventArgs e)
        {
            var error = "";
            if (txtVendegNev.Text.Trim() == "")
            {
                DBFeladatok.AddError(ref error, "Nem adott meg nevet!");
            }
            if (txtVendegOkmanyAzonosito.Text.Trim() == "")
            {
                DBFeladatok.AddError(ref error, "Nem adott meg okmányszámot!");
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
                    _tarolt = new Vendeg(txtVendegNev.Text.Trim(), (VendegNem) cboVendegNem.SelectedItem,
                        (VendegOkmanyTipus) cboVendegOkmanyTipus.SelectedItem, txtVendegOkmanyAzonosito.Text.Trim(),
                        dtpVendegSzuletesiDatum.Value);

                    EasyLog.LogMessageToFile("New vendeg ="+_tarolt);
                }
                else
                {
                    _tarolt.Nev = txtVendegNev.Text.Trim();
                    _tarolt.VendegNem = (VendegNem) cboVendegNem.SelectedItem;
                    _tarolt.VendegOkmanyTipus = (VendegOkmanyTipus) cboVendegOkmanyTipus.SelectedItem;
                    _tarolt.OkmanyAzonosito = txtVendegOkmanyAzonosito.Text.Trim();
                    _tarolt.SzuletesiDatum = dtpVendegSzuletesiDatum.Value;
                    EasyLog.LogMessageToFile("Mod vendeg = "+_tarolt);
                }
            }
        }
    }
}