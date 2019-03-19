using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstCustomer
    {
        //good test data 
        //create some test data to pass to the method
        string HouseNo = "21b";
        string FirstName = "Simon";
        string SurName = "Bread";
        string Street = "Prince Street";
        string PostCode = "LE5 75L";
        string Email = "Simon15@gmail.com";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want
            clsCustomer ACustomer = new clsCustomer();
            //test to see if its exist
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            ACustomer.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ACustomer.Active, TestData);
        }
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
            //create an instance of the class we want
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 CustomerId = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void CustomerIDPropperty()
        {
            //create an instance of the class we want 
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property 
            Int32 TestData = 001;
            //assign the data to the property 
            ACustomer.CustomerID = TestData;
            //test to see if its exist 
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.CustomerID != 5)
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
            Int32 CustomerID = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.HouseNo != "4")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some testdata to use with the method 
            Int32 CustomerID = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.Street != "Priti Street")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCountyNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some testdata to use with the method 
            Int32 CustomerID = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.CountyNo != 5)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some testdata to use with the method 
            Int32 CustomerID = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer id  
            if (ACustomer.Email != "Tilagskjhd@outlook.com")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some testdata to use with the method 
            Int32 CustomerID = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer id  
            if (ACustomer.FirstName != "Tila")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSurNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some testdata to use with the method 
            Int32 CustomerID = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.SurName != "Pat")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some testdata to use with the method 
            Int32 CustomerID = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.PostCode != "LE4 71D")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some testdata to use with the method 
            Int32 CustomerID = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.PhoneNo != 100485785)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some testdata to use with the method 
            Int32 CustomerID = 5;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //check the customer id 
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            string Error = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void HouseNoMinLessone()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string HouseNo = "";
            //this should trigger an error 
            //invoke method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string HouseNo = "1b"; //this should be ok
                                   //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string HouseNo = "2b"; 
            //tis should be ok
             //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the any error message
            String Error = "";
            //create some test data to pass to the method 
            string HouseNo = "4b"; 
            //tis should be ok
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string HouseNo = "6b"; //tis should be ok
                                   //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email); ;
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string HouseNo = "3b"; //tis should be ok
                                   //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string varible to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(501, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(500, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
              //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string HouseNo = "";
            //this should trigger an error 
            //invoke method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string varible to store any error message 
            String Error = "";
            //this should pass
            string PostCode = "a";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "aaaaaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "a");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should fail 
            string Street = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Street = "a";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Street = "aa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(49, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(50, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(25, 'a');
            //invoke the method 
            Error = ACustomer.Valid(FirstName,Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shouldpass
            string Email = "a";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this shouldpass
            string Email = "aa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aaaaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aaaaaaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aaaaaaaaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "a");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aaaa";
            //invoke the method 
            Error = ACustomer.Valid(FirstName, Street, HouseNo, SurName, PostCode, Email);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
    }
}

