using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstCountyCollection
    {
        [TestMethod]
        public void IntanceOK()
        {
            //create an instance of the class we want to create 
            clsCountyCollection AllCounties = new clsCountyCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllCounties);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCountyCollection AllCounties = new clsCountyCollection();
            //create some test data to assign to the property 
            Int32 SomeCount = 1;
            //assign the data to the property 
            AllCounties.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCounties.Count, SomeCount);
        }

        [TestMethod]
        public void AllCountiesOK()
        {
            //create an instance of the class we want to create 
            clsCountyCollection Counties = new clsCountyCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsCounty> TestList = new List<clsCounty>();
            //add an item to the list 
            //create the item of test data 
            clsCounty TestItem = new clsCounty();
            //set its properties 
            TestItem.CountyNo = 2;
            TestItem.County = "Leicestershire";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            Counties.AllCounties = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(Counties.AllCounties, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance f the class we want to create 
            clsCountyCollection Counties = new clsCountyCollection();
            //create some test data to assign to the property 
            //in this case the data needs t be a list of objects
            List<clsCounty> TestList = new List<clsCounty>();
            //add an item to the list
            //create the item of test data
            clsCounty TestItem = new clsCounty();
            //set is properties
            TestItem.CountyNo = 1;
            TestItem.County = "Leicesteshire";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Counties.AllCounties = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Counties.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoCountiesPresent()
        {
            //create an instance of the class we want to create 
            clsCountyCollection Counties = new clsCountyCollection();
            //test to see tht the two values are the same 
            Assert.AreEqual(Counties.Count, 2);
        }
    } 
}
