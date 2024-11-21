using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zadania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 32, 51, 24, 8, 19, 63, 45, 90, 19, 84 };
            SortowanieWybor sort = new SortowanieWybor(tablica);

            sort.Sortowanie();
            foreach(int i in sort.arr)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
