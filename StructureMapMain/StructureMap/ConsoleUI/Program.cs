using StructureMapConsoleUI;
using StructureMapDemoLibrary;
using System;

namespace StructureMapDemoLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var businessLogic = StructureMapContainerConfig.InitIoC();
            var app = businessLogic.GetInstance<IBusinessLogicWrapper>();
            app.ProcessData();
            
            Console.ReadLine();
        }
    }
}
