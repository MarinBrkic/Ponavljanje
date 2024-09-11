using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite URL adresu:");
            string url = Console.ReadLine();

            if (IsValidUrl(url))
            {
                Console.WriteLine("URL adresa je ispravna.");
            }
            else
            {
                Console.WriteLine("URL adresa nije ispravna.");
            }

            Console.ReadKey();
        }

        static bool IsValidUrl(string url)
        {
            return url.StartsWith("www") && url.EndsWith(".hr") && url.Contains(".");
        }
    }
    }
