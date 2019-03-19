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
            ClsConsoleCollection AllConsoles = new ClsConsoleCollection();
            Assert.IsNotNull(AllConsoles);
        }
        [TestMethod]
        public void ConsoleListOK()
        {
            //creates instance of class we want to create
            ClsConsoleCollection AllConsoles = new ClsConsoleCollection();
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
        

    }
}
