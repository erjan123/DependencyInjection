﻿using System;

namespace StructureMapDemoLibrary.Utilities
{
    public class DataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Data");
        }

        public void SaveData(string name)
        {
            Console.WriteLine($"Saving { name }");
        }
    }
}
