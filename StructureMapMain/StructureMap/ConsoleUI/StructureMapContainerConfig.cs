using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using StructureMapDemoLibrary;
using StructureMapDemoLibrary.Utilities;

namespace StructureMapConsoleUI
{
    public class StructureMapContainerConfig
    {
        public static IContainer InitIoC()
        {
            var container = new Container(_ =>
            {
                _.For<IBusinessLogicWrapper>().Use<BusinessLogicWrapper>();
                _.For<IBusinessLogic>().Use<BusinessLogic>();
                _.For<ILogger>().Use<Logger>();
                _.For<IDataAccess>().Use<DataAccess>();
            });

            return container;
        }
    }
}
