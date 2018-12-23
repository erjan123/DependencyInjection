using System;
using Unity;

namespace UnityConsoleUI
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
