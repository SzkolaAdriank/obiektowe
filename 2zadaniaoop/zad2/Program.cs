using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj imię:");
            string imie = Console.ReadLine();

            Osoba osoba1 = new Osoba(1, imie);
            Osoba osoba2 = new Osoba(osoba1);

            osoba1.Powitaj("Bolek");
            Osoba osoba3 = new Osoba();
            osoba3.Id = 3;

            Console.WriteLine("Osoba 1: " + osoba1.Id + " | " + osoba1.Name);
            Console.WriteLine("Osoba 2: " + osoba2.Id + " | " + osoba2.Name);
            Console.WriteLine("Osoba 3: " + osoba3.Id + " | " + osoba3.Name);

            Console.ReadLine();
        }
    }
}
