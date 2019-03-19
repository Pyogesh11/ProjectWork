using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTesting
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see that it exists
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property 
            //in this case data needs to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.Active = true;
            TestItem.Supplier_Address = "Some Supplier Address ";
            TestItem.CountyNo = 1;
            TestItem.Supplier_Email = "abcd.e@gmail.com";
            TestItem.Supplier_Id = 001;
            TestItem.Supplier_Name = "Game.net";
            TestItem.Supplier_Phone_No = "07331415589";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property 
            Int32 SomeCount = 3;
            //assign the data to the property
            AllSuppliers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property 
            clsSupplier TestSupplier = new clsSupplier();
            //set the properties of the test object
            TestSupplier.Active = true;
            TestSupplier.Supplier_Address = "Some Supplier Address ";
            TestSupplier.CountyNo = 1;
            TestSupplier.Supplier_Email = "abcd.e@gmail.com";
            TestSupplier.Supplier_Id = 001;
            TestSupplier.Supplier_Name = "Game.net";
            TestSupplier.Supplier_Phone_No = "07331415589";
            //assign the data to the property
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);

        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, 3);
        }
    }
}

