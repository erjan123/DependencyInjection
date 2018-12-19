using System;
using System.Collections.Generic;
using System.Text;

namespace MyDemoLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        ILogger _logger;
        public DataAccess(ILogger logger)
        {
            _logger = logger;
        }
        public void LoadData()
        {
            Console.WriteLine("Loading Data");
            _logger.Log("Logging from Data Access LoadData().");
        }

        public void SaveData(string name)
        {
            Console.WriteLine($"Saving { name }");
            _logger.Log("Logging from Data Access SaveData().");
        }
    }
}
