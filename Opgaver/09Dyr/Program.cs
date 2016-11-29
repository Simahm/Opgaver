using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Dyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] dyreListe = new Dyr[20];
            for (int i = 0; i < dyreListe.Length; i++)
            {
                dyreListe[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyreListe)
            {
                item.SigNoget();
            }

            Console.ReadKey();
        }
    }
}
