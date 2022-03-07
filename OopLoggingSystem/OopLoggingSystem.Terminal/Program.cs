using OopLoggingSystem.Library;
using OopLoggingSystem.Library.Factories;
using System;

namespace OopLoggingSystem.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializare logger
            //ApplicationLog.Initialize(new ConsoleLoggerFactory());
            //ApplicationLog.Initialize(new DebugWindowLoggerFactory());
            ApplicationLog.Initialize(new FileLoggerFactory(@"D:\FastTrackIT\errorLog.txt"));

            int[] array = ArrayHelper.ReadFromConsole("Array");
            ArrayHelper.PrintToConsole("Array", array);
        }
    }
}
