﻿namespace NUnitFramework.Logging.Imlementations
{
    using System.IO;
    using System.Reflection;
    using log4net;
    using log4net.Config;
    using log4net.Repository;
    using NUnitFramework.Logging.Interfaces;

    public class Log4NetInstance : ILoggerInstance
    {
        public ILog Logger { get; set; }

        public ILoggerInstance SetUpLogger()
        {
            ILoggerRepository loggerRepository = LogManager.GetRepository(Assembly.GetExecutingAssembly());
            XmlConfigurator.Configure(loggerRepository, new FileInfo(@"AppSettings\Files\log4net.config"));

            Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            Logger.Info("Log4Net instance created");

            return this;
        }

        public void Info(string message)
        {
            Logger.Info(message);
        }

        public void Info(string message, params object[] args)
        {
            Logger.Info(string.Format(message, args));
        }

        public void Warn(string message)
        {
            Logger.Warn(message);
        }

        public void Warn(string message, params object[] args)
        {
            Logger.Warn(string.Format(message, args));
        }

        public void Error(string message)
        {
            Logger.Error(message);
        }

        public void Error(string message, params object[] args)
        {
            Logger.Error(string.Format(message, args));
        }
    }
}
