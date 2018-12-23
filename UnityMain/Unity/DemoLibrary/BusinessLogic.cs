using UnityDemoLibrary.Utilities;
using System;

namespace UnityDemoLibrary
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
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            logger.Log("Unity - Starting the processing of data.");
            Console.WriteLine("Unity - Processing the data");
            dataAccess.LoadData();
            dataAccess.SaveData("Unity - ProcessedInfo");
            logger.Log("Unity - Finished processing of the data.");
        }
    }
}
