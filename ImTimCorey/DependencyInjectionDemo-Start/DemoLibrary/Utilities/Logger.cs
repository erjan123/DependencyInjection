using System;

namespace DemoLibrary.Utilities
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging { message }");
        }
    }
}
