using System;
using System.Collections.Generic;
using System.Text;

namespace MyDemoLibrary.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging { message }");
        }
    }
}
 