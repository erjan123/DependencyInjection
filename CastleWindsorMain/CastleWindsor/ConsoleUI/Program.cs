using CastleWindsorDemoLibrary;
using System;

namespace CastleWindsorDemoLibrary
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
