using System;

namespace _09Dyr
{
    public class Dyr
    {
        static System.Random rnd = new Random();
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder ");
        }

        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\michell\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0, navne.Length);
            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }else{
                return new Kat() { Navn = navne[index] };

            }
        }
    }
}
