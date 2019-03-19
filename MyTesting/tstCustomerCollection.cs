using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();
            //set its properties 
            TestItem.Active = true;
            TestItem.CustomerID = 4;
            TestItem.CountyNo = 4;
            TestItem.PhoneNo = 122222784;
            TestItem.FirstName = "Mila";
            TestItem.SurName = "Nod";
            TestItem.HouseNo = "4";
            TestItem.PostCode = "LE3 72C";
            TestItem.Street = "Charles Street";
            TestItem.Email = "Mila76e3897@outlook.com";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }
        [TestMethod]
         public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property 
            Int32 SomeCount = 11;
            //assign the data to the property 
            AllCustomer.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property 
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object 
            TestCustomer.Active = true;
            TestCustomer.CustomerID = 4;
            TestCustomer.CountyNo = 4;
            TestCustomer.FirstName = "Mila";
            TestCustomer.SurName = "Nod";
            TestCustomer.HouseNo = "4";
            TestCustomer.PostCode = "LE3 72C";
            TestCustomer.Street = "Charles Street";
            TestCustomer.Email = "Mila76e3897@outlook.com";
            TestCustomer.PhoneNo = 122222784;
            //assign the data to the property 
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, 11);
        }
    }
}