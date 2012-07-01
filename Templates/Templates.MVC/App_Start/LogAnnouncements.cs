using System;
using System.Linq;
using System.Collections.Generic;
using Castle.Core.Logging;
using System.Data.Entity;
using Templates.Models;

[assembly: WebActivator.PostApplicationStartMethod(typeof(Templates.App_Start.LogAnnouncements), "PostStartup")]
[assembly: WebActivator.ApplicationShutdownMethod(typeof(Templates.App_Start.LogAnnouncements), "Shutdown")]
namespace Templates.App_Start
{
    public static class LogAnnouncements
    {
        private static ILogger logger = NullLogger.Instance;
        public static void PostStartup()
        {
            logger = IoC.Container.Resolve<ILogger>();
            logger.Info("Application Startup Completed");
        }

        public static void Shutdown()
        {
            logger.Info("Application Shutdown");
        }
    }
}