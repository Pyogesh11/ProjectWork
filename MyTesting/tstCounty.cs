﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstCounty
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //test to see that it exists
            Assert.IsNotNull(ACounty);
        }

        [TestMethod]
        public void CountyPropertyOK()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create some test data to assign to the property
            string SomeCounty = "Leicestershire";
            //assign the data to the property
            ACounty.County = SomeCounty;
            //test to see that the values are the same
            Assert.AreEqual(ACounty.County, SomeCounty);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create some test data to assign to the property
            Int32 CountyNo = 1;
            //assign the data to the property
            ACounty.CountyNo = CountyNo;
            //test to see that the values are the same
            Assert.AreEqual(ACounty.CountyNo, CountyNo);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "Leicestershire";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //boolean variable to store the result of the validtin
            Boolean Found = false;
            //create Some test data to use with the method
            Int32 CountyNo = 1;
            //invoke the method
            Found = ACounty.Find(CountyNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CountyMinLessOne()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountyMinBoundary()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "a";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "aa";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CountyMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountyMid()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "0123456789012345678901234";
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyEtremeMax()
        {
            //create an instance of the class we want to create
            clsCounty ACounty = new clsCounty();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCounty = "";
            //pad the string with characters
            SomeCounty = SomeCounty.PadRight(500, 'a');
            //invoke the method
            Error = ACounty.Valid(SomeCounty);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

    }
}