using StructureMapDemoLibrary;
using System;

namespace StructureMapDemoLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic businessLogic = new BusinessLogic();

            businessLogic.ProcessData();

            Console.ReadLine();
        }
    }
}
