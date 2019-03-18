using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTesting
{
    [TestClass]
    public class tstEmployeeCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            {
                //test to see that it exists
                Assert.IsNotNull(AllEmployees);
            }

            
        }


        [TestMethod]
        public void EmployeeListOk()
        {
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //creating some test data to assign to the propeity
            //in the case the data needs to be a list of objects
            List<clsEmployee> TestList = new List<clsEmployee>();
            //add an item to the list
            //create the item of test data
            clsEmployee TestItem = new clsEmployee();
            // set its propities
            TestItem.EmployeeNo = 1;
            TestItem.EmployeeFirstName = "Tokigawa";
            TestItem.EmployeeSurName = "Max";
            TestItem.EmployeeContactNo = "07392738291";
            TestItem.EmployeeEmail = "dingas@gmail.com.com";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data ti the proepity
            AllEmployees.EmployeeList = TestList;
            //test ti see that the tw calues are the same
            Assert.AreEqual(AllEmployees.EmployeeList, TestList); 



        }
    }

}
