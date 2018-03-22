using Rollbar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework452
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            RollbarLocator.RollbarInstance.Configure(new RollbarConfig(ConfigurationManager.AppSettings["Rollbar.AccessToken"])
            {
                Environment = ConfigurationManager.AppSettings["Rollbar.Environment"]
            });

            log4net.Config.XmlConfigurator.Configure();

            log.Debug("DEBUG test via log4net.Rollbar appender");
            log.Info("INFO test via log4net.Rollbar appender");
            log.Warn("WARN test via log4net.Rollbar appender");
            log.Error("ERROR test via log4net.Rollbar appender");
            log.Fatal("FATAL test via log4net.Rollbar appender");

            Console.WriteLine("Press any key to end");
            Console.Read();
        }
    }
}
