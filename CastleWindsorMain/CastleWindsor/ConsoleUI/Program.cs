using CastleWindsorConsoleUI;
using CastleWindsorDemoLibrary;
using CastleWindsorDemoLibrary.Utilities;
using System;

namespace CastleWindsorDemoLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var businessLogic = WinsorCastleContainerConfig.Register();

            var app = businessLogic.Resolve<IBusinessLogicWrapper>();
            app.ProcessData();
            
            Console.ReadLine();
        }
    }
}
