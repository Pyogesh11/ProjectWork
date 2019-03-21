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
            TestCustomer.PhoneNo = 122222784;
            TestCustomer.FirstName = "Mila";
            TestCustomer.SurName = "Nod";
            TestCustomer.HouseNo = "4";
            TestCustomer.PostCode = "LE3 72C";
            TestCustomer.Street = "Charles Street";
            TestCustomer.Email = "Mila76e3897@outlook.com";
            //assign the data to the property 
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 4;
            TestItem.CountyNo = 4;
            TestItem.PhoneNo = 122222784;
            TestItem.PostCode = "LE3 72C";
            TestItem.Street = "Charles Street";
            TestItem.FirstName = "Mila";
            TestItem.SurName = "Nod";
            TestItem.HouseNo = "4";
            TestItem.Email = "Mila76e3897@outlook.com";
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 4;
            TestItem.CountyNo = 4;
            TestItem.HouseNo = "4";
            TestItem.PostCode = "LE3 72C";
            TestItem.Street = "charles street";
            TestItem.FirstName = "mila";
            TestItem.SurName = "Nod";
            TestItem.PhoneNo = 122222784;
            TestItem.Email = "Mila76e3897@outlook.com";
            //set ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomer.Delete();
            //now find the record   
            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data 
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary ey 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 4;
            TestItem.CountyNo = 4;
            TestItem.HouseNo = "4";
            TestItem.PostCode = "LE3 72C";
            TestItem.Street = "charles street";
            TestItem.FirstName = "Mila";
            TestItem.SurName = "Nod";
            TestItem.PhoneNo = 122222784;
            TestItem.Email = "Mila76e3897@outlook.com";
            //set ThisCustomer to the test data 
            AllCustomer.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data 
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.CustomerID = 4;
            TestItem.CountyNo = 5;
            TestItem.HouseNo = "4";
            TestItem.PostCode = "LE4 71D";
            TestItem.Street = "Priti Street";
            TestItem.FirstName = "Tila";
            TestItem.SurName = "Pat";
            TestItem.PhoneNo = 100485785;
            TestItem.Email = "Tilagskjhd@outlook.com";
            //set the record based on the new test data 
            AllCustomer.ThisCustomer = TestItem;
            //update the record 
            AllCustomer.Update();
            //find the record 
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer Matches the test data 
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the filtered data
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instace of the filtered data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByPostCode("");
            //test to see that two values are the same 
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }



        public void ReportByPostCode(string PostCode)
        {
            //filters the record based on a full or partial post code 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database 
            DB.AddParameter("@PostCode", PostCode);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByPostCode");
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a post code that doesn't exist
            FilteredCustomers.ReportByPostCode("xxx xxx");
            //test to see that there are no records 
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByMethodTestDataFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome 
            Boolean OK = false;
            //apply a post code that doesn't exist 
            FilteredCustomers.ReportByPostCode("yyy yyy");
            //check that the correct number of records are found 
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 12
                if (FilteredCustomers.CustomerList[0].CustomerID != 12)
                {
                    OK = false;
                }
                //check that the first record is ID 13
                if (FilteredCustomers.CustomerList[1].CustomerID != 13)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                //test to see that there are no records 
                Assert.IsFalse(OK);
            }
        }
    }

}