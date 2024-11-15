using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieabstrakcja
{
    internal class Biblioteka : IZarzadzaniePozycjami
    {
        private string adres;
        public List<Bibliotekarz> Bibliotekarze = new List<Bibliotekarz>();
        public List<Katalog> Katalogi = new List<Katalog>();

        public void DodajKatalog(Katalog katalog)
        {
            Katalogi.Add(katalog);
        }


        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public Biblioteka()
        {

        }

        public Biblioteka(string adres_)
        {
            this.Adres = adres_;
        }

        public void DodajBibliotekarza(Bibliotekarz b)
        {
            Bibliotekarze.Add(b);
        }

        public void WypiszBibliotekarzy()
        {
            Console.WriteLine("Bibliotekarze:");
            if (Bibliotekarze.Count > 0)
            {
                foreach (var bibliotekarz in Bibliotekarze)
                {
                    Console.WriteLine($"{bibliotekarz.Imie} {bibliotekarz.Nazwisko}, Data zatrudnienia: {bibliotekarz.DataZatrudnienia}, Wynagrodzenie: {bibliotekarz.Wynagrodzenie}");
                }
            }
            else
            {
                Console.WriteLine("Brak bibliotekarzy.");
            }
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul)
        {
            foreach (var katalog in Katalogi)
            {
                var pozycja = katalog.ZnajdzPozycjePoTytule(tytul);
                if (pozycja != null)
                {
                    return pozycja;
                }
            }
            return null;
        }

        public Pozycja ZnajdzPozycjePoId(int id)
        {
            foreach (var katalog in Katalogi)
            {
                var pozycja = katalog.ZnajdzPozycjePoId(id);
                if (pozycja != null)
                {
                    return pozycja;
                }
            }
            return null;
        }

        public void WypiszWszystkiePozycje()
        {
            foreach (var katalog in Katalogi)
            {
                katalog.WypiszWszystkiePozycje();
            }
        }



    }
}
