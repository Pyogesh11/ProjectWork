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
        [TestMethod]
        public void ConsoleNameMin()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsoleNo = "X"; //this should be ok
                                    //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleNo, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleNameMinPlusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsoleNo = "XS"; //this should be ok
                                     //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleNo, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleNameMaxMinusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsoleNo = "123123123123123"; //this should be ok
                                                  //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleNo, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleNameMax()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsoleNo = "1231231231231231"; //this should be ok
                                                   //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleNo, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleNameMid()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsoleNo = "12312312"; //this should be ok
                                           //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleNo, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsolePriceMin()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsolePrice = "0"; //this should be ok
                                       //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleNo, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsolePriceMinPlusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsolePrice = "1p"; //this should be ok
                                        //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleNo, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsolePriceMaxMinusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsolePrice = "1231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231231"; //this should be ok
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleNo, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsolePriceMax()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsolePrice = "12312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312312"; //this should be ok
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleNo, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsolePriceMid()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsolePrice = "1231231231231231231231231123123123123123123123123112312312312312312312312311231231231231231231231231123123123123123123123123112312312312312312312312311231231231231231231231231123123123123123123123123112312312312312312312312311231231231231231231231231"; //this should be ok
                                                                                                                                                                                                                                                                                                //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleNo, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



    }
}
