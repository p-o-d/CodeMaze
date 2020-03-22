using Contracts;
using NLog;

namespace LoggerService
{
    public class NLogLoggerManager : ILoggerManager
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public void LogInfo(string message)
        {
            Logger.Info(message);
        }

        public void LogDebug(string message)
        {
            Logger.Debug(message);
        }

        public void LogWarning(string message)
        {
            Logger.Warn(message);
        }

        public void LogError(string message)
        {
            Logger.Error(message);
        }
    }
}
