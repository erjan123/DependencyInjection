using UnityDemoLibrary;
using System;
using UnityConsoleUI;
using Unity;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = UnityContainerConfig.RegisterComponents();

            IBusinessLogicWrapper businessLogic = container.Resolve<IBusinessLogicWrapper>();
            businessLogic.ProcessData();

            Console.ReadLine();
        }
    }
}
