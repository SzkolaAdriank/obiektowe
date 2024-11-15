using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieabstrakcja
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Autor autor1 = new Autor("Adam", "Mickiewicz", "Polska");
            Autor autor2 = new Autor("Juliusz", "Słowacki", "Polska");
            Ksiazka ksiazka = new Ksiazka("Dziady", 1, "PIW", 1832, 300);
            ksiazka.DodajAutora(autor1);


            Czasopismo czasopismo = new Czasopismo("Wiedza i Życie", 2, "Wiedza", 2023, 5);

 
            Katalog katalogLiteratura = new Katalog("Literatura");
            katalogLiteratura.DodajPozycje(ksiazka);
            katalogLiteratura.DodajPozycje(czasopismo);

  
            Bibliotekarz bibliotekarz = new Bibliotekarz("Jan", "Kowalski", "2020-01-01", 3500);

            Biblioteka biblioteka = new Biblioteka("Warszawa, ul. Książkowa 1");
            biblioteka.DodajBibliotekarza(bibliotekarz);
            biblioteka.DodajKatalog(katalogLiteratura);

            Console.WriteLine("Informacje o wszystkich pozycjach:");
            biblioteka.WypiszWszystkiePozycje();

            Console.WriteLine("\nWyszukiwanie pozycji po tytule:");
            var pozycjaPoTytule = biblioteka.ZnajdzPozycjePoTytule("Dziady");
            pozycjaPoTytule.WypiszInfo();

            Console.WriteLine("\nWyszukiwanie pozycji po ID:");
            var pozycjaPoId = biblioteka.ZnajdzPozycjePoId(2);
            pozycjaPoId.WypiszInfo();

            Console.WriteLine("\nLista bibliotekarzy:");
            biblioteka.WypiszBibliotekarzy();
        }
    }

}
