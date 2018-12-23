using Ninject.Modules;
using NinjectDemoLibrary;
using NinjectDemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectConsoleUI
{
    public class NinjectContainerConfig : NinjectModule
    {
        public override void Load()
        {
            Bind<IBusinessLogicWrapper>().To<BusinessLogicWrapper>();
            Bind<IBusinessLogic>().To<BusinessLogic>();
            Bind<ILogger>().To<Logger>();
            Bind<IDataAccess>().To<DataAccess>();
        }
    }
}
