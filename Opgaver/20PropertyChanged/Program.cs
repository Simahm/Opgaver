using System;

namespace _20PropertyChanged
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.PropertyChanged += (object s, EventArgs e) => {
                Console.WriteLine("Egenskab rettet");
            };

            p.Id = 6;

            Console.ReadKey();
        }
    }
}
