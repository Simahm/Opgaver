using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16GeneriskeMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Simon";
            string efternavn = "Ahm";
            Console.WriteLine(fornavn + " " + efternavn);
            Swap<string>(ref fornavn, ref efternavn);
            Console.WriteLine(fornavn + " " + efternavn);

            int x = 10;
            int y = 25550;
            Console.WriteLine(x + " " + y);
            Swap(ref x, ref y);
            Console.WriteLine(x + " " + y);

            Console.ReadKey();
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
