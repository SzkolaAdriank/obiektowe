using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieabstrakcja
{
    internal class Ksiazka : Pozycja
    {
        private int liczbaStron;
        public List<Autor> Autorzy = new List<Autor>();

        public int LiczbaStron
        {
            get { return liczbaStron; }
            set { liczbaStron = value; }
        }

        public Ksiazka()
        {

        }
        public Ksiazka(string tytul_, int id_, string wydawnictwo_, int rokWydania_, int liczbaStron_) : base(tytul_, id_, wydawnictwo_, rokWydania_)
        {
            this.LiczbaStron = liczbaStron_;
        }
        public void DodajAutora(Autor autor)
        {
            Autorzy.Add(autor);
        }
        public override void WypiszInfo()
        {
            Console.WriteLine($"{tytul}, ID: {id}, Wydawnictwo: {wydawnictwo}, Rok wydania: {rokWydania}, Liczba stron: {liczbaStron}, ");
            Console.Write("Autorzy: ");
            if (Autorzy.Count > 0)
            {
                foreach (var autor in Autorzy)
                {
                    Console.Write($"{autor.Imie} {autor.Nazwisko}, ");
                }
            }
            else
            {
                Console.WriteLine("Brak autorów.");
            }
        }
    }
}
