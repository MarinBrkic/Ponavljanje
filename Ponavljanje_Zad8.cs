using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_Zad8
{
    internal class Program
    {
             static void Main()
            {
                Console.Write("Unesite broj n: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"Fibonaccijev član za n={n} je: {Fibonacci(n)}");

                Console.ReadKey();
            }

            static int Fibonacci(int n)
            {
                if (n <= 0) return 0;
                if (n == 1) return 1;
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
