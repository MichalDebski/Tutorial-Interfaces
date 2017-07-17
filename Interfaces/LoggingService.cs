using System;

namespace Interfaces
{
    public class LoggingService
    {
        public static void WriteToLog(ILoggable item)
        {
            Console.WriteLine(item.Log());
        }
    }
}
