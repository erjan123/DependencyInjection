using StructureMapDemoLibrary.Utilities;
using System;

namespace StructureMapDemoLibrary
{
    public class BusinessLogic
    {
        public void ProcessData()
        {
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");
            dataAccess.LoadData();
            dataAccess.SaveData("ProcessedInfo");
            logger.Log("Finished processing of the data.");
        }
    }
}
