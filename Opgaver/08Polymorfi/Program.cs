using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() {Fornavn = "Simon", Efternavn = "Ahm Madsen" };
            Elev e = new Elev() { Fornavn = "Hugo", Efternavn = "Ahm Bjerre", Klasselokale = "Brumbasserne" };
            Instruktør i = new Instruktør() { Fornavn = "Doctor", Efternavn = "Strange", NøgleId = 100 };

            Console.WriteLine(p.Skriv());
            Console.WriteLine(e.Skriv());
            Console.WriteLine(i.Skriv());

            Console.ReadKey();
        }
    }
}
