using CastleWindsorConsoleUI;
using System;

namespace CastleWindsorDemoLibrary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var businessLogic = WinsorCastleContainerConfig.Register();

            var app = businessLogic.Resolve<IBusinessLogicWrapper>();
            app.ProcessData();

            Console.ReadLine();
        }
    }
}