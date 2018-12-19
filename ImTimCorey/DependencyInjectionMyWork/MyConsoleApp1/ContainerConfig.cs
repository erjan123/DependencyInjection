using Autofac;
using MyDemoLibrary;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace MyConsoleApp1
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            // Note: Application class depends on IBusinessLogic therefore the second Registered Type overrides the first Registered Type
            // The BusinessLogic.ProcessData() method will be invoked. If we change the order then the BetterVusinessLogic.ProcessData() method will be invoked.
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>(); 
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(MyDemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
