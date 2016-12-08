using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //PrintListe();
            //PrintDict();

            Bunke bunke = new Bunke();
            bunke.TilføjKort(new Kort() {Kulør = "Spar", Værdi = 2});
            bunke.TilføjKort(new Kort() {Kulør = "Hjerter", Værdi = 14});
            bunke.TilføjKort(new Kort() {Kulør = "Ruder", Værdi = 3});

            bunke.VisKort();

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(bunke.FjernKort());
            Console.WriteLine();
            bunke.VisKort();

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(bunke.FjernKort());
            Console.WriteLine();
            bunke.VisKort();

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(bunke.FjernKort());
            Console.WriteLine();
            bunke.VisKort();

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(bunke.FjernKort());
            Console.WriteLine();
            bunke.VisKort();

            Console.ReadKey();
        }

        static void PrintListe()
        {
            List<Person> liste = new List<Person>
            {
                new Person() {Id = 1, Navn = "Poul" },
                new Person() {Id = 2, Navn = "Svend" },
                new Person() {Id = 3, Navn = "Ulla" },
                new Person() {Id = 4, Navn = "Frode" }
            };

            foreach (var item in liste)
            {
                Console.WriteLine(item.Navn);
            }
        }

        static void PrintDict()
        {
            Dictionary<int, Person> dict = new Dictionary<int, Person>();
            dict.Add(1, new Person() { Navn = "Lilian" });
            dict.Add(2, new Person() { Navn = "John" });
            dict.Add(3, new Person() { Navn = "Orla" });

            for (int i = 1; i <= dict.Values.Count; i++)
            {
                Console.WriteLine(dict[i].Navn);
            }

        }
    }
}
