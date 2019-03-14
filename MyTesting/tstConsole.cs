using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstConsole
    {
        string ConsoleName = "Xbox";
        string ConsoleManufacturer = "Microsoft";
        string ConsolePrice = "250";
        string ConsoleStock = "10000";

        [TestMethod]
        public void TestMethod1()
        {
            clsConsole AConsole = new clsConsole();
            Assert.IsNotNull(AConsole);
        }

        
      
        [TestMethod]
        public void ConsolePropertyOK()
        {   //instance of class
            clsConsole AConsole = new clsConsole();
            //Console data to assign to property
            string TestData = "Xbox";
            //assigns data to the property
            AConsole.Console = TestData;
            //test to see if they ae the same
            Assert.AreEqual(AConsole.Console, TestData);
        }
        [TestMethod]
        public void ManufacturerPopertyOK()
        {   //instance of class
            clsConsole AConsole = new clsConsole();
            //Console data to assign to property
            string TestData = "Microsoft";
            //assigns data to the property
            AConsole.Manufacturer = TestData;
            //test to see if they ae the same
            Assert.AreEqual(AConsole.Manufacturer, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {   //instance of class
            clsConsole AConsole = new clsConsole();
            //Console data to assign to property
            Int32 TestData = 500;
            //assigns data to the property
            AConsole.Price = TestData;
            //test to see if they ae the same
            Assert.AreEqual(AConsole.Price, TestData);
        }
        [TestMethod]
        public void StockQuantityPropertyOK()
        {   //instance of class
            clsConsole AConsole = new clsConsole();
            //Console data to assign to property
            Int32 TestData = 25000;
            //assigns data to the property
            AConsole.Stock = TestData;
            //test to see if they ae the same
            Assert.AreEqual(AConsole.Stock, TestData);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsConsole AConsole = new clsConsole();
            String Error = "";
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsConsole AConsole = new clsConsole();
            //boolean to store result of search
            Boolean Found = false;
            Int32 ConsoleNo = 2;
            Found = AConsole.Find(ConsoleNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestConsoleNo()
        {
            clsConsole AConsole = new clsConsole();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ConsoleNo = 2;
            Found = AConsole.Find(ConsoleNo);
            if (AConsole.ConsoleNo != 2)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
       

    }
}
