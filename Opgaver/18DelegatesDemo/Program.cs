using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18DelegatesDemo
{
    class Program
    {
        public delegate int Beregn(int a, int b); 

        static void Main(string[] args)
        {
            int resultat;
            resultat = Beregner(2, 5, Gange);
            Console.WriteLine(resultat);
            Console.ReadKey();
        }

        public static int Beregner(int a, int b, Beregn f)
        {
            return f(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public  static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}
