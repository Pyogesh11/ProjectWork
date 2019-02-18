using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //test to see if its exist
            Assert.IsNotNull(ASupplier);
        }

        //Supplier_Address
        [TestMethod]
        public void Supplier_AddressPropertyOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Some Supplier Address ";
            //assign the data to the property
            ASupplier.Supplier_Address = TestData;
            //test to see if its exist
            Assert.AreEqual(ASupplier.Supplier_Address, TestData);
        }

        //Supplier_County
        [TestMethod]
        public void Supplier_CountyPropertyOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Leicester";
            //assign the data to the property
            ASupplier.Supplier_County = TestData;
            //test to see if its exist
            Assert.AreEqual(ASupplier.Supplier_County, TestData);
        }
        
        //Supplier_Email
        [TestMethod]
        public void Supplier_EmailPropertyOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "abcd.e@gmail.com";
            //assign the data to the property
            ASupplier.Supplier_Email = TestData;
            //test to see if its exist
            Assert.AreEqual(ASupplier.Supplier_Email, TestData);
        }

        //Supplier_Id
        [TestMethod]
        public void Supplier_IdPropertyOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 001;
            //assign the data to the property
            ASupplier.Supplier_Id = TestData;
            //test to see if its exist
            Assert.AreEqual(ASupplier.Supplier_Id, TestData);
        }

        //Supplier_Name
        [TestMethod]
        public void Supplier_NamePropertyOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Game.net";
            //assign the data to the property
            ASupplier.Supplier_Name = TestData;
            //test to see if its exist
            Assert.AreEqual(ASupplier.Supplier_Name, TestData);
        }

        //Supplier_Phone_No
        [TestMethod]
        public void Supplier_Phone_NoPropertyOK()
        {
        //create an instance of the class we want
        clsSupplier ASupplier = new clsSupplier();
        //create some test data to assign to the property
        Int64 TestData =  07112123346;
        //assign the data to the property
        ASupplier.Supplier_Phone_No = TestData;
        //test to see if its exist
        Assert.AreEqual(ASupplier.Supplier_Phone_No, TestData);
        }
        
        
        //creating method 
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 Supplier_Id = 001;
            //invoke the method 
            Found = ASupplier.Find(Supplier_Id);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestSupplier_IdFound()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 Supplier_Id = 002;
            //invoke the method 
            Found = ASupplier.Find(Supplier_Id);
            //check the supplier id 
            if (ASupplier.Supplier_Id != 002)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

    }
}
