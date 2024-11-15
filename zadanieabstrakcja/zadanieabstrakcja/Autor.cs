using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieabstrakcja
{
    internal class Autor : Osoba
    {

        private string narodowosc;

        public string Narodowosc
        {
            get { return narodowosc; }
            set { narodowosc = value; }
        }

        public Autor()
        {

        }
        public Autor(string imie_, string nazwisko_, string narodowosc_) : base(imie_, nazwisko_)
        {
            this.Narodowosc = narodowosc_;
        }
    }
}

