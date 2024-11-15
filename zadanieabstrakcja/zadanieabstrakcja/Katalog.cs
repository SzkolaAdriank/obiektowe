using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieabstrakcja
{
    internal class Katalog : IZarzadzaniePozycjami
    {
        private string dzialTematyczny;
        public List<Pozycja> Pozycje = new List<Pozycja>();

        public string DzialTematyczny
        {
            get { return dzialTematyczny; }
            set { dzialTematyczny = value; }
        }

        public Katalog()
        {

        }

        public Katalog(string dzialTematyczny_)
        {
            this.DzialTematyczny = dzialTematyczny_;
        }

        public void DodajPozycje(Pozycja pozycja)
        {
            Pozycje.Add(pozycja);
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul)
        {
            foreach (Pozycja p in Pozycje)
            {
                if (p.Tytul.Equals(tytul, StringComparison.InvariantCultureIgnoreCase))
                {
                    return p;
                }

            }
            return null;
        }

        public Pozycja ZnajdzPozycjePoId(int id)
        {
            foreach (var p in Pozycje)
            {
                if (p.Id == id)
                {
                    return p;
                }

            }
            return null;
        }

        public void WypiszWszystkiePozycje()
        {
            foreach (var p in Pozycje)
            {
                p.WypiszInfo();
            }
        }
    }
}
