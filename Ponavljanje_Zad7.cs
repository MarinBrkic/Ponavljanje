using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_Zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int number = 2; number < 100; number++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    count++;
                }
            }

            Console.WriteLine("Prim brojeva manjih od 100: " + count);

            Console.ReadKey();
        }
    }
}
