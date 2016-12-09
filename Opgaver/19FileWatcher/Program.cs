using System;
namespace _19FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher fw = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            fw.EnableRaisingEvents = true;
            fw.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;

            // bind en metode til fw.Changed her ------->
            fw.Changed += Fw_Changed;
            fw.Created += Fw_Created;
            fw.Renamed += Fw_Renamed;
            do {} while (true);
        }

        private static void Fw_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            Console.Write(" og er nu navngivet " + e.Name);
        }

        private static void Fw_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Der er oprettet en ny fil " + e.Name);
        }

        private static void Fw_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Det er ændret i filen " + e.Name);
        }
    }
}
