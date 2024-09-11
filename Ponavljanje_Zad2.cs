using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Unesite neku recenicu:");
                string unos = Console.ReadLine();
                string rezultat = unos.Replace(' ', '_');
                Console.WriteLine("Nova recenica: " + rezultat);

                Console.ReadKey();
            }
        }

    }
