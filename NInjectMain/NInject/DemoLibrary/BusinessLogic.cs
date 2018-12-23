using NinjectDemoLibrary.Utilities;
using System;

namespace NinjectDemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            _logger.Log("Ninject - Starting the processing of data.");
            Console.WriteLine("Ninject - Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Ninject - ProcessedInfo");
            _logger.Log("Ninject - Finished processing of the data.");
        }
    }
}
