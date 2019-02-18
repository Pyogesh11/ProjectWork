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
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create 
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 CustomerID = 1;
            //invoke the method 
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }


    }
}
