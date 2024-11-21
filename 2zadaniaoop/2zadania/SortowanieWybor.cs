using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zadania
{
    internal class SortowanieWybor
    {

        public int[] arr;

        private int ZnajdzMax(int start)
        {
            double temp = arr[start];
            int index = start;
            for(int i = start + 1; i< arr.Length; i++)
            {
                if (arr[i] > temp) { temp = arr[i]; index = i; }
            }
            return index;
        }

        public SortowanieWybor(int[] array)
        {
            arr = array;
        }

        public int[] Sortowanie() 
        { 
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int max = ZnajdzMax(i);

                int temp = arr[i];
                arr[i] = arr[max];
                arr[max] = temp;
                

            }

            return arr;
        }


    }
}
