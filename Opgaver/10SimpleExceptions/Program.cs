using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SimpleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Der er sket følgende fejl: " + ex.Message);
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("Reultatet er " + res);

            Console.ReadKey();
        }
    }
}
