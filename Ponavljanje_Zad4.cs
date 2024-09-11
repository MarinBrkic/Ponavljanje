using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Sve vrijednosti moraju biti vece od 0.");
            }

            else if (c*c == (a * a) + (b * b))
            {
                Console.WriteLine("Trokut je pravokutan.");
            }
            else if (b*b == (a * a) + (c * c))
            {
                Console.WriteLine("Trokut je pravokutan.");
            }
            else if (a*a == (c * c) + (b * b)) {
                Console.WriteLine("Trokut je pravokutan.");
            }
            else { Console.WriteLine("Trokut nije pravokutan."); }

            Console.ReadKey();
        }
    }
}
