using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstConsole
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsConsole AConsole = new clsConsole();
            Assert.IsNotNull(AConsole);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //instance of class we will create
            clsConsole AConsole = new clsConsole();
            //test data to assign to the property
            Boolean TestData = true;
            AConsole.Active = TestData;
            Assert.AreEqual(AConsole.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsConsole AConsole = new clsConsole();
            //test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assigns data to property
            AConsole.DateAdded = TestData;
            Assert.AreEqual(AConsole.DateAdded, TestData);
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
            String Manufacturer = "Xbox";
            Error = AConsole.Valid(Manufacturer);
            Assert.AreEqual(Error, "");
        }
    }
}
