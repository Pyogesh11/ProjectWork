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
        public void UpdateMethodOK()
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
            TestItem.Supplier_Name = "Game.net";
            TestItem.Supplier_Phone_No = "07331415589";
            //set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data
            TestItem.Supplier_Id = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.Supplier_Address = "another Supplier Address ";
            TestItem.CountyNo = 2;
            TestItem.Supplier_Email = "abcd.e7@gmail.com";
            TestItem.Supplier_Name = "another Game.net";
            TestItem.Supplier_Phone_No = "07331415599";
            //set tje record based on the new test data
            AllSuppliers.ThisSupplier = TestItem;
            //update the record 
            AllSuppliers.Update();
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see ThisSupplier matches the test data
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void ReportBySupplier_NameMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create an instance of the filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //apply a blank string (should return all records);
            FilteredSuppliers.ReportBySupplier_Name("");
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportBySupplier_NameNoneFound()
        {
            //create an instance of the class we want to create
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //apply a supplier name that doesn't exist
            FilteredSuppliers.ReportBySupplier_Name("another Game.net");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportBySupplier_NameTestDataFound()
        {
            //create an instance of the class we want to create
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a supplier name that doesnt exist
            FilteredSuppliers.ReportBySupplier_Name("another Game.net");
            //check that the correct number of recors are found
            if (FilteredSuppliers.Count == 2)
            {
                //check that the first record is ID 05
                if (FilteredSuppliers.SupplierList[0].Supplier_Id != 05)
                    {
                    OK = false;
                }
                //check that the first record is ID 06
                if (FilteredSuppliers.SupplierList[1].Supplier_Id != 06)
                   {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

                //test to see that there are no record
                Assert.IsTrue(OK);
        }
    }
}


