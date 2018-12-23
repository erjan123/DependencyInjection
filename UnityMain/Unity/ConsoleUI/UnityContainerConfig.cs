using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnityDemoLibrary;
using UnityDemoLibrary.Utilities;

namespace UnityConsoleUI
{
    public static class UnityContainerConfig
    {
       public static IUnityContainer RegisterComponents()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IBusinessLogicWrapper, BusinessLogicWrapper>();
            container.RegisterType<IBusinessLogic,BusinessLogic>();
            container.RegisterType<ILogger, Logger>();
            container.RegisterType<IDataAccess, DataAccess>();

            return container;
        }

    }
}
