using Ninject;
using NinjectConsoleUI;
using NinjectDemoLibrary;
using System;
using System.Reflection;

namespace NinjectConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();

            kernel.Load(Assembly.GetExecutingAssembly());

            var app = kernel.Get<IBusinessLogicWrapper>();
            app.ProcessData();

            Console.ReadLine();
        }
    }
}
