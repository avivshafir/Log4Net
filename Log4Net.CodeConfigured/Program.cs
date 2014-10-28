using System;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using log4net.Repository.Hierarchy;

namespace Log4Net.CodeConfigured
{
    class Program
    {
        static void Main(string[] args)
        {

            SimpleLayout layout = new SimpleLayout();
            layout.ActivateOptions();

            ConsoleAppender appender = new ConsoleAppender();
            appender.Layout = layout;
            appender.ActivateOptions();

            Hierarchy hierarchy = (Hierarchy) LogManager.GetRepository();
            Logger root = hierarchy.Root;

            root.Level = log4net.Core.Level.All;

            BasicConfigurator.Configure(appender);

            var log = LogManager.GetLogger(typeof(Program));

            log.Debug("Debug");
            log.Info("Info");
            log.Warn("Warn");
            log.Error("Error");
            log.Fatal("Fatal");

            Console.ReadLine();
        }
    }
}
