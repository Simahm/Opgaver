using System;

namespace _09Dyr
{
    public class Dyr
    {
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder ");
        }

        static Dyr TilfældigtDyr()
        {
            //return System.IO.File;
        }
    }
}
