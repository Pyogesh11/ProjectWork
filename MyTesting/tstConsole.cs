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
        public void ConsoleNameMinMinusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleName = ""; //this should be ok
                                    
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleNameMin()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsoleName = "X"; 
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleNameMinPlusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsoleName = "XS"; 
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleNameMaxMinusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsoleName = "abcabcabcabcabc"; 
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleNameMax()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsoleName = "abcabcabcabcabca"; 
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleNameMid()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsoleName = "abcabcabcab"; 
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void ConsoleNameMaxPlusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleName = "abcabcabcabcabca";
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ConsolePriceMinMinusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleName = ""; //this should be ok

            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ConsolePriceMin()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsolePrice = "0"; 
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsolePriceMinPlusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole(); 
            String Error = "";
            //create some test data to pass to the method
            string ConsolePrice = "1p"; 
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
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
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
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
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
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
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ConsoleManufacturerMinMinusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleManufacturer = ""; //this should be ok

            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleManufacturerMin()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleManufacturer = "X";
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleManufacturerMinPlusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleManufacturer = "XS";
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleManufacturerMaxMinusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleManufacturer = "abcabcabcabcabc";
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleManufacturerMax()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleManufacturer = "abcabcabcabcabca";
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleManufacturerMid()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleManufacturer = "abcabcabca";
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        public void ConsoleManufacturerMaxPlusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleManufacturer = "abcabcabcabcabca";
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ConsoleStockMinMinusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleStock = ""; //this should be ok

            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ConsoleStockMin()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleStock = "0";
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleStockMinPlusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleStock = "1";
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleStockMaxMinusOne()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleStock = "999999"; //this should be ok
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleStockMax()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleStock = "1000000"; //this should be ok
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ConsoleStockMid()
        {
            //create an instance 
            clsConsole AConsole = new clsConsole();
            String Error = "";
            //create some test data to pass to the method
            string ConsoleStock = "500000"; //this should be ok
                                                                                                                                                                                                                                                                                                //invoke the method
            Error = AConsole.Valid(ConsoleManufacturer, ConsoleName, ConsolePrice, ConsoleStock); //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



    }
}
