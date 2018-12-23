using CastleWindsorDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorConsoleUI
{
    public class BusinessLogicWrapper : IBusinessLogicWrapper
    {
        IBusinessLogic _businessLogic;
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
