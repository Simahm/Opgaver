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

            List<Person> list = new List<Person>();
            list.Add(p);
            list.Add(e);
            list.Add(i);

            //Gør det samme som nedenfor...
            foreach (var item in list)
            {
                Console.WriteLine(item.Skriv());
            }

            /*Console.WriteLine(p.Skriv());
            Console.WriteLine(e.Skriv());
            Console.WriteLine(i.Skriv());*/

            Console.ReadKey();
        }
    }
}
