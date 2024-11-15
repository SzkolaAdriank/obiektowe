using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieabstrakcja
{
    internal class Czasopismo : Pozycja
    {
        private int numer;

        public int Numer
        {
            get { return numer; }
            set { numer = value; }
        }

        public Czasopismo()
        {

        }
        public Czasopismo(string tytul_, int id_, string wydawnictwo_, int rokWydania_, int numer_) : base(tytul_, id_, wydawnictwo_, rokWydania_)
        {
            this.Numer = numer_;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine($"Tytuł: {tytul}, ID: {id}, Wydawnictwo: {wydawnictwo}, Rok wydania: {rokWydania}, Numer czasopisma: {numer}");
        }
    }
}
