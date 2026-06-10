using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.Logger
{
    public class LoggerService: ILoggerService
    {
        private readonly ILog _log;

        public LoggerService(Type callerType)
        {
            _log = LogManager.GetLogger(callerType);
        }

        public void Debug(string message) => _log.Debug(message);
        public void Info(string message) => _log.Info(message);
        public void Warn(string message) => _log.Warn(message);
        public void Error(string message, Exception ex = null)
        {
            if (ex != null) _log.Error(message, ex);
            else _log.Error(message);
        }
        public void Fatal(string message, Exception ex = null)
        {
            if (ex != null) _log.Fatal(message, ex);
            else _log.Fatal(message);
        }

    }
}
