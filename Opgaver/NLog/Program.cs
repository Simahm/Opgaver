using NLog;
using System;

namespace _11NLog
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Trace("...Enter...");
            logger.Debug("Nu kaldes Test1!");
            Test1(5, 7);
            logger.Debug("Retur fra Test1");
            logger.Debug("Nu kaldes Test2!");
            Test2();
            logger.Debug("Retur fra Test2");
            logger.Trace("...Exit...");
            Console.ReadKey();
        }

        static void Test1(int i, int x)
        {
            logger.Trace("Enter i, x {0}, {1}", i, x);
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(3000);
            logger.Trace("...Exit...");
        }

        static void Test2()
        {
            logger.Trace("...Enter...");
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)            {
                logger.Error(ex);
            }
            logger.Trace("...Exit...");
        }
    }
}
