using MyDemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDemoLibrary
{
    public class BetterBusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            Console.WriteLine();
            _logger.Log("BetterBusinessLogic ProcessData() - Starting the processing of data.");
            Console.WriteLine();
            Console.WriteLine("Processing the data");
            Console.WriteLine();
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            Console.WriteLine();
            _logger.Log("Finished processing of the data.");
        }

    }
}
