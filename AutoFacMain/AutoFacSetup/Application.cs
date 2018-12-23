using AutoFacDemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFacTestProject
{
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }
                    
        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
