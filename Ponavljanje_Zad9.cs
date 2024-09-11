using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_Zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = { 5, 2, 8, 1, 4 };

            Array.Sort(niz);

            Console.WriteLine("Sortirani niz:");
            foreach (int broj in niz)
            {
                Console.WriteLine(broj);
            }

            Console.ReadKey();
        }
    }
}
