using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Osoba
    {
        private int id;
        private string name;

        public static int licznik = 0;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }

        public Osoba()
        {
            Id = 0;
            Name = "";
            licznik++;
        }
        public Osoba(int i, string n)
        {
            Name = n;
            Id = i;
            licznik++;
        }
        public Osoba(Osoba osoba)
        {
            Id = osoba.Id;
            Name = osoba.Name;
            licznik++;
        }

        public void Powitaj(string n)
        {
            if(Name != "")
            {
                Console.WriteLine($"Cześć {n}, mam na imię {Name}.");
                return;
            }
            Console.WriteLine("Brak danych.");
        }
    }
}
