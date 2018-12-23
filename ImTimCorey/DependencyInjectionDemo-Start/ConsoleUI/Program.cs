using NinjectDemoLibrary;
using System;

namespace NinjectConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic();

            businessLogic.ProcessData();

            Console.ReadLine();
        }
    }
}
