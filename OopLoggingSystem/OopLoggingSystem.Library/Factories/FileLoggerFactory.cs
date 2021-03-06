using OopLoggingSystem.Library.Loggers;
using System;

namespace OopLoggingSystem.Library.Factories
{
    public class FileLoggerFactory : LoggerFactory
    {
        public FileLoggerFactory(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get; }

        internal override Logger Create()
        {
            return new FileLogger(FilePath);
        }
    }
}
