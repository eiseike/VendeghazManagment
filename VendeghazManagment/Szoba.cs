using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeghazManagment
{
   
    class Szoba
    {
        private string _nev;
        private SzobaEmelet _emelet;
        private int _felnottHely;
        private int _gyermekHely;
        private bool _kiadhato;
        private string _megjegyzes;
        private int _id;

        public override string ToString()
        {
            return Nev + " (" + Enumok.Bovebben(Emelet) + ")";
        }


        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

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

        public SzobaEmelet Emelet
        {
            get
            {
                return _emelet;
            }

            set
            {
                _emelet = value;
            }
        }

        public int Felnott_hely
        {
            get
            {
                return _felnottHely;
            }

            set
            {
                _felnottHely = value;
            }
        }

        public int Gyermek_hely
        {
            get
            {
                return _gyermekHely;
            }

            set
            {
                _gyermekHely = value;
            }
        }

        public bool Kiadhato
        {
            get
            {
                return _kiadhato;
            }

            set
            {
                _kiadhato = value;
            }
        }

        public string Megjegyzes
        {
            get
            {
                return _megjegyzes;
            }

            set
            {
                _megjegyzes = value;
            }
        }

        

        public Szoba(string nev, SzobaEmelet emelet, int felnottHely, int gyermekHely, bool kiadhato, string megjegyzes, int id = 0)
        {
            Nev = nev;
            Emelet = emelet;
            Felnott_hely = felnottHely;
            Gyermek_hely = gyermekHely;
            Kiadhato = kiadhato;
            Megjegyzes = megjegyzes;
            Id = id;
        }
    }
}
