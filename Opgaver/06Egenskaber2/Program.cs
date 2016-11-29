using System;

namespace _06Egenskaber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(10, 12);
            Console.WriteLine($"Grunlinjen er: {t.Grundlinje}");
            Console.WriteLine($"Højden er: {t.Højde}");
            Console.WriteLine($"Hvilket giver et areal på: {t.Areal}");

            Kasse k = new Kasse(10, 6, 12);
            Console.WriteLine($"Kassens mål er: {k.Højde} x {k.Bredde} x {k.Dybde}");
            Console.WriteLine($"Hvilket giver et areal på: {k.Areal} samt et rumfang på: {k.Rumfang}");
            Console.ReadKey();
        }
    }
}