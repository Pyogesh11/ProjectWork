using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{


    [TestClass]
    public class tstSupplier
    {
        //good test data 
        //create some test data to pass to the method
        string Supplier_Address = "Some Supplier Address ";
        string Supplier_Email = "abcd.e@gmail.com";
        string Supplier_Name = "Game.net";
        string Supplier_Phone_No = "07331415589";

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

        //CountyNo
        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ASupplier.CountyNo = TestData;
            //test to see if its exist
            Assert.AreEqual(ASupplier.CountyNo, TestData);
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
            string TestData = "07331415589";
            //assign the data to the property
            ASupplier.Supplier_Phone_No = TestData;
            //test to see if its exist
            Assert.AreEqual(ASupplier.Supplier_Phone_No, TestData);
        }

        //Active
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ASupplier.Active = TestData;
            //test to see if its exist
            Assert.AreEqual(ASupplier.Active, TestData);
        }

        /// <summary>
        /// ///////////////////////////////////////////////////Creating method////////////////////////////////////////////////////////////////////
        /// </summary>
        //creating method 
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 Supplier_Id = 4;
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
            Int32 Supplier_Id = 004;
            //invoke the method 
            Found = ASupplier.Find(Supplier_Id);
            //check the supplier id 
            if (ASupplier.Supplier_Id != 004)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        //Supplier_Address method
        [TestMethod]
        public void TestSupplier_AddressFound()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 Supplier_Id = 004;
            //invoke the method 
            Found = ASupplier.Find(Supplier_Id);
            //check the supplier id 
            if (ASupplier.Supplier_Address != "Test Supplier_Address")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //Supplier_County method
        [TestMethod]
        public void TestCountyNoFound()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 Supplier_Id = 004;
            //invoke the method 
            Found = ASupplier.Find(Supplier_Id);
            //check the supplier id 
            if (ASupplier.CountyNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //Supplier_Email
        [TestMethod]
        public void TestSupplier_EmailFound()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 Supplier_Id = 004;
            //invoke the method 
            Found = ASupplier.Find(Supplier_Id);
            //check the supplier id 
            if (ASupplier.Supplier_Email != "Supplier_Email@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //Supplier_Name
        [TestMethod]
        public void TestSupplier_NameFound()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 Supplier_Id = 004;
            //invoke the method 
            Found = ASupplier.Find(Supplier_Id);
            //check the supplier id 
            if (ASupplier.Supplier_Name != "Test Supplier Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //Supplier_Phone_No
        [TestMethod]
        public void TestSupplier_Phone_NoFound()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 Supplier_Id = 004;
            //invoke the method 
            Found = ASupplier.Find(Supplier_Id);
            //check the supplier id 
            if (ASupplier.Supplier_Phone_No != "07331415589")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //Active
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 Supplier_Id = 004;
            //invoke the method 
            Found = ASupplier.Find(Supplier_Id);
            //check the supplier id //////////
            if (ASupplier.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //validmethod
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want
            clsSupplier ASupplier = new clsSupplier();
            //string variable to stroe any error message
            string Error = "";
            //invoke the method 
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
        }

        
        //Testing min and max for Supplier_Address 
        [TestMethod]
        public void Supplier_AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Supplier_Address = ""; 
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_AddressMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Address = "a";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Address = "aa";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Address = "";
            Supplier_Address = Supplier_Address.PadRight(49, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_AddressMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Address = "";
            Supplier_Address = Supplier_Address.PadRight(50, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Address = "";
            Supplier_Address = Supplier_Address.PadRight(51, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_AddressMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Address = "";
            Supplier_Address = Supplier_Address.PadRight(25, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //
        [TestMethod]
        public void Supplier_AddressExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Address = "";
            Supplier_Address = Supplier_Address.PadRight(51, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Testing min and max for Supplier_Email 
        [TestMethod]
        public void Supplier_EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Supplier_Email = "aaaaaaaaaaaaaaa";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_EmailMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Email = "aaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Email = "aaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Email = "";
            Supplier_Email = Supplier_Email.PadRight(49, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_EmailMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Email = "";
            Supplier_Email = Supplier_Email.PadRight(50, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Email = "";
            Supplier_Email = Supplier_Email.PadRight(51, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_EmailMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Email = "";
            Supplier_Email = Supplier_Email.PadRight(25, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_EmailExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Email = "";
            Supplier_Email = Supplier_Email.PadRight(60, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Testing min and max for Supplier_Name 
        [TestMethod]
        public void Supplier_NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Supplier_Name = "";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_NameMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Email = "a";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Email = "aa";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Name = "";
            Supplier_Name = Supplier_Name.PadRight(19, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_NameMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Name = "";
            Supplier_Name = Supplier_Name.PadRight(20, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }      
        //
        [TestMethod]
        public void Supplier_NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Name = "";
            Supplier_Name = Supplier_Name.PadRight(21, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_NameMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Name = "";
            Supplier_Name = Supplier_Name.PadRight(10, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_NameExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Name = "";
            Supplier_Name = Supplier_Name.PadRight(50, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        //Testing min and max for Supplier_Phone_No 
        [TestMethod]
        public void Supplier_Phone_NoMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Supplier_Phone_No = "aa";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_Phone_NoMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Phone_No = "aaa";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_Phone_NoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Phone_No = "aaaa";
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_Phone_NoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Phone_No = "";
            Supplier_Phone_No = Supplier_Phone_No.PadRight(14, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //
        [TestMethod]
        public void Supplier_Phone_NoMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Phone_No = "";
            Supplier_Phone_No = Supplier_Phone_No.PadRight(15, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NoExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Supplier_Phone_No = "";
            Supplier_Phone_No = Supplier_Phone_No.PadRight(16, 'a');
            //invoke the method
            Error = ASupplier.Valid(Supplier_Address, Supplier_Email, Supplier_Name, Supplier_Phone_No);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
