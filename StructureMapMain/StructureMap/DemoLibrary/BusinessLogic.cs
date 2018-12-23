using StructureMapDemoLibrary.Utilities;
using System;

namespace StructureMapDemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        public void ProcessData()
        {
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            logger.Log("StructureMap - Starting the processing of data.");
            Console.WriteLine("StructureMap - Processing the data");
            dataAccess.LoadData();
            dataAccess.SaveData("StructureMap - ProcessedInfo");
            logger.Log("StructureMap - Finished processing of the data.");
        }
    }
}
