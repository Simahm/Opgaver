using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Fornavn = "Simon", Efternavn = "Ahm Madsen" };
            UdskrivPerson(p);

            Elev e = new Elev() { Fornavn = "Hugo", Efternavn = "Ahm Bjerre", Klasselokale = "Brumbasserne" };
            UdskrivPerson(e, "", $" - {e.Klasselokale}");

            Instruktør i = new Instruktør() { Fornavn = "Doctor", Efternavn = "Strange", NøgleId = 1000 };
            UdskrivPerson(i, "Instruktør: ", $" - NøgleId: {i.NøgleId}");

            Console.ReadKey();
        }

        static void UdskrivPerson(Person x, string prefix = "", string suffix = "")
        {
            Console.WriteLine(prefix + x.FuldtNavn() + suffix);
        }
    }
}
