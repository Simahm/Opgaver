using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Comparing
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[4];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder"};
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady"};
            hunde[2] = new Hund() { Alder = 7, Navn = "Bølle"};
            hunde[3] = new Hund() { Alder = 4, Navn = "Fido"};
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn + " " + item.Alder);
            }
            Console.ReadKey();
        }
    }
}
