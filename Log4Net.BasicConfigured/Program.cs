using System;

namespace Log4NetQuickStartDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();

            var log = log4net.LogManager.GetLogger(typeof (Program));

            log.Info("Debug");
            log.Info("Info");
            log.Info("Warn");
            log.Info("Error");
            log.Info("Fatal");

            Console.ReadLine();
        }
    }
}
