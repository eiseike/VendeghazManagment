using System;

namespace VendeghazManagment
{
    /*
    VendegNem vendegNem;
    Enum.TryParse<VendegNem>(valamiKivalaszthato.SelectedValue.ToString(), out vendegNem); 
    */
  
    public class Vendeg
    {
        private string _nev;
        private VendegNem _vendegNem;
        private VendegOkmanyTipus _vendegOkmanyTipus;
        private string _okmanyAzonosito;
        private DateTime _szuletesiDatum;

        public string Nev
        {
            get
            {
                return _nev;
            }

            set
            {
                _nev = value;
            }
        }

        public VendegNem VendegNem
        {
            get
            {
                return _vendegNem;
            }

            set
            {
                _vendegNem = value;
            }
        }

        public VendegOkmanyTipus VendegOkmanyTipus
        {
            get
            {
                return _vendegOkmanyTipus;
            }

            set
            {
                _vendegOkmanyTipus = value;
            }
        }

        public string OkmanyAzonosito
        {
            get
            {
                return _okmanyAzonosito;
            }

            set
            {
                _okmanyAzonosito = value;
            }
        }

        public DateTime SzuletesiDatum
        {
            get
            {
                return _szuletesiDatum;
            }

            set
            {
                _szuletesiDatum = value;
            }
        }


        public Vendeg(string nev, VendegNem vendegNem, VendegOkmanyTipus vendegOkmanyTipus, string okmanyAzonosito, DateTime szuletesiDatum)
        {
            Nev = nev;
            VendegNem = vendegNem;
            VendegOkmanyTipus = vendegOkmanyTipus;
            OkmanyAzonosito = okmanyAzonosito;
            SzuletesiDatum = szuletesiDatum;
        }

        public override string ToString()
        {
            return Nev + Environment.NewLine + VendegNem + "(" + (int)VendegNem + ")" + Environment.NewLine + VendegOkmanyTipus + Environment.NewLine + OkmanyAzonosito + Environment.NewLine
                + SzuletesiDatum;
        }
    }
}
