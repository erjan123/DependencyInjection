using Castle.MicroKernel.Registration;
using Castle.Windsor;
using CastleWindsorDemoLibrary;
using CastleWindsorDemoLibrary.Utilities;

namespace CastleWindsorConsoleUI
{
    public static class WinsorCastleContainerConfig
    {
        public static IWindsorContainer Register()
        {
            IWindsorContainer container = new WindsorContainer();
            container.Register(Component.For<IBusinessLogicWrapper>().ImplementedBy<BusinessLogicWrapper>());
            container.Register(Component.For<IBusinessLogic>().ImplementedBy<BusinessLogic>());
            container.Register(Component.For<ILogger>().ImplementedBy<Logger>());
            container.Register(Component.For<IDataAccess>().ImplementedBy<DataAccess>());

            return container;
        }
    }
}