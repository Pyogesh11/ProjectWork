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

        // creating the employee list which will provide us an index ed list of employee frim the database tabel
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
            TestItem.EmployeeFirstName = "Max";
            TestItem.EmployeeSurName = "Tokigawa";
            TestItem.EmployeeContactNo = "07392738291";
            TestItem.EmployeeEmail = "dingas@gmail.com.";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data ti the proepity
            AllEmployees.EmployeeList = TestList;
            //test ti see that the tw calues are the same
            Assert.AreEqual(AllEmployees.EmployeeList, TestList);



        }

        // the following code is for the creation of the count propeity in the class clsEmployeeCollection
        //this will alwasy tell us how many address there are in the list
        [TestMethod]
        public void CountEmployeeOK()
        {
            // creating an instance of the class clsEmployeeCollection
            clsEmployeeCollection AllEmployee = new clsEmployeeCollection();
            // creating some test data yo assign a propeity
            Int32 SomeCount = 0;
            //assign the data to the proepity
            AllEmployee.Count = SomeCount;
            Assert.AreEqual(AllEmployee.Count, SomeCount);

        }


        [TestMethod]
        public void ThisEmployeeOK()
        {
            //creating an instance of the class clsEmployeeCollection
            clsEmployeeCollection AllEmployee = new clsEmployeeCollection();
            clsEmployee TestEmployee = new clsEmployee();
            //Set the propeities of the test object
            TestEmployee.EmployeeNo = 1;
            TestEmployee.EmployeeFirstName = "Max";
            TestEmployee.EmployeeSurName = "Tokigawa";
            TestEmployee.EmployeeContactNo = "07392738291";
            TestEmployee.EmployeeEmail = "dingas@gmail.com";
            AllEmployee.ThisEmployee = TestEmployee;
            Assert.AreEqual(AllEmployee.ThisEmployee, TestEmployee);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //CREATING AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsEmployeeCollection AllEmployee = new clsEmployeeCollection();
            List<clsEmployee> TestList = new List<clsEmployee>();
            //add an item to the list
            //create the item of test data
            clsEmployee TestItem = new clsEmployee();
            //aet its propeities
            TestItem.EmployeeNo = 1;
            TestItem.EmployeeFirstName = "Max";
            TestItem.EmployeeSurName = "Tokigawa";
            TestItem.EmployeeContactNo = "07392738291";
            TestItem.EmployeeEmail = "dingas@gmail.com";
            //add the item  to the test list
            TestList.Add(TestItem);
            AllEmployee.EmployeeList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllEmployee.Count, TestList.Count); 

        }
        

    }

}
