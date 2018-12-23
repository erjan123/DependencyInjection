using System;

namespace CastleWindsorDemoLibrary.Utilities
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging { message }");
        }
    }
}
