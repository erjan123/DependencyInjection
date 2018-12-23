using CastleWindsorDemoLibrary.Utilities;
using System;

namespace CastleWindsorDemoLibrary
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
            _logger.Log("CastleWindsor - Starting the processing of data.");
            Console.WriteLine("CastleWindsor - Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("CastleWindsor - ProcessedInfo");
            _logger.Log("CastleWindsor - Finished processing of the data.");
        }
    }
}
