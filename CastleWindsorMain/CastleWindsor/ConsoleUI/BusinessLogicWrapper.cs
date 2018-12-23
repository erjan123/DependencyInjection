using CastleWindsorDemoLibrary;

namespace CastleWindsorConsoleUI
{
    public class BusinessLogicWrapper : IBusinessLogicWrapper
    {
        private IBusinessLogic _businessLogic;

        public BusinessLogicWrapper(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public void ProcessData()
        {
            _businessLogic.ProcessData();
        }
    }
}