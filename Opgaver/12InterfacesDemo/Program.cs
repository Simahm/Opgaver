using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] liste = new IDbFunktioner[5];
            liste[0] = new Hund() { Navn = "Fido" };
            liste[1] = new Hund() { Navn = "King" };
            liste[2] = new Hund() { Navn = "Basse" };
            liste[3] = new Ubåd() { Nummer = 1, Turbine = 2.1 };
            liste[4] = new Ubåd() { Nummer = 2, Turbine = 2.1 };

            foreach (IDbFunktioner item in liste)
            {
                item.Gem();
            }
            Console.ReadKey();
        }
    }
}
