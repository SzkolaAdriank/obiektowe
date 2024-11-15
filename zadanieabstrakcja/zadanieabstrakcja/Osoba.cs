using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieabstrakcja
{
    internal class Osoba
    {
        protected string imie;
        protected string nazwisko;
            
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public Osoba()
        {

        }

        public Osoba(string imie_, string nazwisko_)
        {
            this.Imie = imie_;
            this.Nazwisko = nazwisko_;
        }
    }
}
