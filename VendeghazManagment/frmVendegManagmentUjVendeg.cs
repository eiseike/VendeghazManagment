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
        private Vendeg _tarolt;

        private void initCtor()
        {
            InitializeComponent();
            cboOkmanyTipus.DataSource = Enum.GetValues(typeof(OkmanyTipus));
            cboNem.DataSource = Enum.GetValues(typeof(Nem));
        }

        public FrmVendegManagmentUjVendeg()
        {
            initCtor();
        }

        public FrmVendegManagmentUjVendeg(int vendegId)
        {
            initCtor();
            dtpSzuletesiDatum.Enabled = false;
            _tarolt = DBFeladatok.SelectVendeg(vendegId);
            txtNev.Text = _tarolt.Nev;
            txtOkmanyAzonosito.Text = _tarolt.OkmanyAzonosito;
            cboNem.SelectedIndex =(int) _tarolt.Nem;
            cboOkmanyTipus.SelectedIndex = (int) _tarolt.OkmanyTipus;
        }


        internal Vendeg Tarolt
        {
            get { return _tarolt; }
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
            var error = "";
            if (txtNev.Text.Trim() == "")
            {
                addError(ref error, "Nem adott meg nevet!");
            }
            if (txtOkmanyAzonosito.Text.Trim() == "")
            {
                addError(ref error, "Nem adott meg okmányszámot!");
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
                    _tarolt = new Vendeg(txtNev.Text.Trim(), (Nem) cboNem.SelectedItem,
                        (OkmanyTipus) cboOkmanyTipus.SelectedItem, txtOkmanyAzonosito.Text.Trim(),
                        dtpSzuletesiDatum.Value);
                }
                else
                {
                    _tarolt.Nev = txtNev.Text.Trim();
                    _tarolt.Nem = (Nem) cboNem.SelectedItem;
                    _tarolt.OkmanyTipus = (OkmanyTipus) cboOkmanyTipus.SelectedItem;
                    _tarolt.OkmanyAzonosito = txtOkmanyAzonosito.Text.Trim();
                }
            }
        }
    }
}