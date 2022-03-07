using OopLoggingSystem.Library.Factories;
using OopLoggingSystem.Library.Loggers;

namespace OopLoggingSystem.Library
{
    public static class ApplicationLog
    {
        private static Logger logger;

        public static void Initialize(LoggerFactory factory)
        {
            ApplicationLog.logger = factory.Create();
        }

        public static void Write(LogEntry logEntry)
        {
            if(logEntry is not null)
            {
                ApplicationLog.logger.Write(logEntry);
            }
        }
    }
}
