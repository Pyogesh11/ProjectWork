using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace Mytesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

     // [TestMethod]
      //public void ActivePropertyOK()
      //{
            //create an instance of the class we want to create 
      //    clsCustomer ACustomer = new clsCustomer();
      //    //create some test data to assign to the property 
       //   Boolean TestData = true; 
            //assign the data to the property 
       //   ACustomer.Active = TestData;
       //   //test to see that the two values are the same 
       //   Assert.AreEqual(ACustomer.Active, TestData);
      //}
        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property 
            ACustomer.CountyNo = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.CountyNo, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "21b";
            //assign the data to the property 
            ACustomer.HouseNo = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.HouseNo, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            Int32 TestData = 122222784;
            //assign the data to the property 
            ACustomer.PhoneNo = TestData;
            //test to see that two values are the same 
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }
        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "LE5 75L";
            //assign the data to the property 
            ACustomer.PostCode = TestData;
            //test to see that the twoe values are the same 
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }
        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the clss we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Prince Street";
            //assign the data to the property 
            ACustomer.Street = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Street, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Simon";
            //assign the data to the property 
            ACustomer.FirstName = TestData;
            //test to see that two values are the same 
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }
        [TestMethod]
        public void SurNamePropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Bread";
            //assign the data to the property 
            ACustomer.SurName = TestData;
            //test to see that two values are the same 
            Assert.AreEqual(ACustomer.SurName, TestData);
        }
        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Male";
            //assign the data to the property 
            ACustomer.Gender = TestData;
            //test to see that two values are the same 
            Assert.AreEqual(ACustomer.Gender, TestData);
        }
        [TestMethod]
        public void EmailPropertyOk()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            string TestData = "Simon15@gmail.com";
            //assign the data to the property 
            ACustomer.Email = TestData;
            //test to see that two values are the same 
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 CustomerID = 1;
            //invoke the method 
            Found = ACustomer.Find( CustomerID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //bbolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some tesr data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //check the house no 
            if (ACustomer.HouseNo != "1")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestHouseNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some testdata to use with the method 
            Int32 CustomerNo = 1;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //check the house no 
            if (ACustomer.HouseNo != "1")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
    }
}

