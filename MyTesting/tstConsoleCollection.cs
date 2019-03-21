using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class TstConsoleCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsConsoleCollection AllConsoles = new clsConsoleCollection();
            Assert.IsNotNull(AllConsoles);
        }
        [TestMethod]
        public void ConsoleListOK()
        {
            //creates instance of class we want to create
            clsConsoleCollection AllConsoles = new clsConsoleCollection();
            List<clsConsole> TestList = new List<clsConsole>();
            clsConsole TestItem = new clsConsole();
            //sets properties
            TestItem.ConsoleNo = 1;
            TestItem.Name = "Xbox";
            TestItem.Manufacturer = "Microsoft";
            TestItem.Price = 250;
            TestItem.Stock = 10000;
            TestList.Add(TestItem);
            AllConsoles.ConsoleList = TestList;
            Assert.AreEqual(AllConsoles.ConsoleList, TestList);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsConsoleCollection AllConsoles = new clsConsoleCollection();
            clsConsole TestItem = new clsConsole();
            Int32 PrimaryKey = 0;
            //sets properties
            TestItem.ConsoleNo = 1;
            TestItem.Name = "Xbox";
            TestItem.Manufacturer = "Microsoft";
            TestItem.Price = 250;
            TestItem.Stock = 10000;
            AllConsoles.ThisConsole = TestItem;
            PrimaryKey = AllConsoles.Add();
            TestItem.ConsoleNo = PrimaryKey;
            AllConsoles.ThisConsole.Find(PrimaryKey);
            Assert.AreEqual(AllConsoles.ThisConsole, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of the class we want to create
            clsConsoleCollection AllConsoles = new clsConsoleCollection();
            clsConsole TestItem = new clsConsole();
            Int32 PrimaryKey = 0;
            //sets properties
            TestItem.ConsoleNo = 1;
            TestItem.Name = "Xbox";
            TestItem.Manufacturer = "Microsoft";
            TestItem.Price = 250;
            TestItem.Stock = 10000;
            AllConsoles.ThisConsole = TestItem;
            //add record 
            PrimaryKey = AllConsoles.Add();
            TestItem.ConsoleNo = PrimaryKey;
            AllConsoles.ThisConsole.Find(PrimaryKey);
            AllConsoles.Delete();
            //finds record
            Boolean Found = AllConsoles.ThisConsole.Find(PrimaryKey);
            //tests to see that record was not found
            Assert.IsFalse(Found);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of class we want to create
            clsConsoleCollection AllConsoles = new clsConsoleCollection();
            //creates item for test data
            clsConsole TestItem = new clsConsole();
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.ConsoleNo = 1;
            TestItem.Name = "Xbox";
            TestItem.Manufacturer = "Microsoft";
            TestItem.Price = 250;
            TestItem.Stock = 10000;
            AllConsoles.ThisConsole = TestItem;
            PrimaryKey = AllConsoles.Add();
            //modify test data
            TestItem.ConsoleNo = 5;
            TestItem.Name = "PlayStation 4 Pro";
            TestItem.Manufacturer = "Sony";
            TestItem.Price = 400;
            TestItem.Stock = 2000;
            AllConsoles.ThisConsole = TestItem;
            //update record
            AllConsoles.Update();
            //find record
            AllConsoles.ThisConsole.Find(PrimaryKey);
            //test to see ThisConsole matches test data
            Assert.AreEqual(AllConsoles.ThisConsole, TestItem);
        }
        [TestMethod]
        public void ReportByConsoleNameMethodOK()
        {
            //create instance of class we want to create
            clsConsoleCollection AllConsoles = new clsConsoleCollection();
            //create instance of filtered data
            clsConsoleCollection FilteredConsoles = new clsConsoleCollection();
            FilteredConsoles.ReportByConsoleName("Xbox");
            //test to see if both data is the same
            Assert.AreEqual(AllConsoles.Count, FilteredConsoles.Count);
        }
        [TestMethod]
        public void ReportByConsoleNameNoneFound()
        {   //instance of filtered data
            clsConsoleCollection FilteredConsoles = new clsConsoleCollection();
            FilteredConsoles.ReportByConsoleName("xx xxx");
            //tests to see if there are no records
            Assert.AreEqual(0, FilteredConsoles.Count);

        }
        [TestMethod]
        public void ReportByConsoleTestDataFound()
        {
            //instance of filtered data
            clsConsoleCollection FilteredConsoles = new clsConsoleCollection();
            Boolean OK = true;
            //apply Console Name that does not exist
            FilteredConsoles.ReportByConsoleName("Nintendo N64");
            //check that current record of records are found
            if (FilteredConsoles.Count == 2)
            {
                if (FilteredConsoles.ConsoleList[0].ConsoleNo != 3)
                {
                    OK = false;
                }
                if (FilteredConsoles.ConsoleList[0].ConsoleNo != 4)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see if there's no records
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CountProprtyOK()
        {
            clsConsoleCollection AllConsoles = new clsConsoleCollection();
            Int32 SomeCount = 1;
            AllConsoles.Count = SomeCount;
            Assert.AreEqual(AllConsoles.Count, SomeCount);

        }
        [TestMethod]
        public void AllConsolesOK()
        {
            clsConsoleCollection Console = new clsConsoleCollection();
            List<clsConsole> TestList = new List<clsConsole>();
            clsConsole TestItem = new clsConsole();
            TestItem.ConsoleNo = 1;
            TestList.Add(TestItem);
            Console.AllConsoles = TestList;
            Assert.AreEqual(Console.AllConsoles, TestList);
        }
    }

}
