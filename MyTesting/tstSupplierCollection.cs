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
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create th item of the data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Supplier_Address = "Some Supplier Address ";
            TestItem.CountyNo = 1;
            TestItem.Supplier_Email = "abcd.e@gmail.com";
            TestItem.Supplier_Id = 001;
            TestItem.Supplier_Name = "Game.net";
            TestItem.Supplier_Phone_No = "07331415589";
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.Supplier_Id = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create th item of the data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Supplier_Address = "Some Supplier Address ";
            TestItem.CountyNo = 1;
            TestItem.Supplier_Email = "abcd.e@gmail.com";
            TestItem.Supplier_Id = 001;
            TestItem.Supplier_Name = "Game.net";
            TestItem.Supplier_Phone_No = "07331415589";
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.Supplier_Id = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //delete record
            AllSuppliers.Delete();
            //now find the record
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

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


