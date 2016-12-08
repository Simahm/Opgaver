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

            Dictionary<int, Person> dict = new Dictionary<int, Person>();
            dict.Add(1, new Person() { Navn = "Lilian" });
            dict.Add(2, new Person() { Navn = "John" });
            dict.Add(3, new Person() { Navn = "Orla" });

            for (int i = 1; i <= dict.Values.Count; i++)
            {
                Console.WriteLine(dict[i].Navn);
            }

            Console.ReadKey();
        }
    }
}
