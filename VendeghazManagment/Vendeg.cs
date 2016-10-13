using System;

namespace VendeghazManagment
{
    /*
    Nem nem;
    Enum.TryParse<Nem>(valamiKivalaszthato.SelectedValue.ToString(), out nem); 
    */
    internal enum Nem
    {
        Férfi = 0,
        Nő
    }

    internal enum OkmanyTipus
    {
        Személyi = 1,
        Útlevél
    }
    class Vendeg
    {
        private string _nev;
        private Nem _nem;
        private OkmanyTipus _okmanyTipus;
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

        public Nem Nem
        {
            get
            {
                return _nem;
            }

            set
            {
                _nem = value;
            }
        }

        public OkmanyTipus OkmanyTipus
        {
            get
            {
                return _okmanyTipus;
            }

            set
            {
                _okmanyTipus = value;
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


        public Vendeg(string nev, Nem nem, OkmanyTipus okmanyTipus, string okmanyAzonosito, DateTime szuletesiDatum)
        {
            Nev = nev;
            Nem = nem;
            OkmanyTipus = okmanyTipus;
            OkmanyAzonosito = okmanyAzonosito;
            SzuletesiDatum = szuletesiDatum;
        }

        public override string ToString()
        {
            return Nev + Environment.NewLine + Nem + "(" + (int)Nem + ")"+ Environment.NewLine + OkmanyTipus + Environment.NewLine +  OkmanyAzonosito + Environment.NewLine 
                + SzuletesiDatum;
        }
    }
}
