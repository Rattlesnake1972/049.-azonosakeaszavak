using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049.azonosakeaszavak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy szót! ");
            string szo1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Kérek még egy szót és kiírom, hogy a szavak azonosak-e! ");
            string szo2 = Convert.ToString(Console.ReadLine());

            if (szo1 == szo2)
            {
                Console.WriteLine("A két szó egyforma.");
            }

            /*else if (szo1 != szo2)
            {
                Console.WriteLine("A két szó nem egyforma.");
            }
            */

            else
            {
                Console.WriteLine("A két szó nem egyforma.");
            }

            Console.ReadKey();
        }
    }
}
