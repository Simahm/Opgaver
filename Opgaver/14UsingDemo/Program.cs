using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14UsingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = File.OpenText("X:/Michell/dyrenavne.txt");
            while (stream.Peek() != -1)
            {
                string navn = stream.ReadLine();
                Console.WriteLine(navn);
            }

            stream.Close();
            stream = null;

            Console.WriteLine("----------------------Ny listning---------------------");

            stream = File.OpenText("X:/Michell/dyrenavne.txt");
            using (stream)
            {
                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn);
                }
            }


            Console.ReadKey();
        }


    }
}
