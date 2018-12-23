using System;
using Autofac;
using AutoFacDemoLibrary;
using AutoFacTestProject;

namespace AutoFacSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoFacContainer = AutoFacContainerConfig.Configure();

            using (var scope = autoFacContainer.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
