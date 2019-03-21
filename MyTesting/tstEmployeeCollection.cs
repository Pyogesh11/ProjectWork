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
            Int32 SomeCount = 6;
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

        //creating the add method
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance pf yje c;ass we wamt to create
            clsEmployeeCollection allEmployee = new clsEmployeeCollection();
            clsEmployee TestItem = new clsEmployee();
            //create an item of test data
            Int32 PrimaryKey = 0;
            //set the paramters
            TestItem.EmployeeNo = 1;
            TestItem.EmployeeFirstName = "Test";
            TestItem.EmployeeSurName = "Data";
            TestItem.EmployeeContactNo = "07152637171";
            TestItem.EmployeeEmail = "Test@gamail.com";
            //SET This EMPLOYEE TO THE TEST DATA
            allEmployee.ThisEmployee = TestItem;
            //add the record
            PrimaryKey = allEmployee.Add();
            //set the primary key of the test data
            TestItem.EmployeeNo = PrimaryKey;
            //find the record 
            allEmployee.ThisEmployee.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allEmployee.ThisEmployee, TestItem);

        }
       [TestMethod]
       public void DeleteMethodOK()
        {
            //CREATE AN INSTANCE 
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            clsEmployee TestItem = new clsEmployee();
            //var to store pk
            Int32 PK = 0;
            //set the props
            TestItem.EmployeeNo = 1;
            TestItem.EmployeeFirstName = "Crack";
            TestItem.EmployeeSurName = "Head";
            TestItem.EmployeeContactNo = "07163829181";
            TestItem.EmployeeEmail = "CrackBox@gmail.com";

            AllEmployees.ThisEmployee = TestItem;
            //set the pk of the test data
            //set thisEmployee to the test data
            PK = AllEmployees.Add();
            //set the pk of the test data
            TestItem.EmployeeNo = PK;
            
            
            //find the record
            AllEmployees.ThisEmployee.Find(PK);
            //deleate record
            AllEmployees.Delete();
            //now find the record
            Boolean Found = AllEmployees.ThisEmployee.Find(PK);
            //TEST TO SEE THAT THE RECORD WAS NOT OUND
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS 
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //craete the ite test data
            clsEmployee TestItem = new clsEmployee();
            //var to store pk
            Int32 PK = 0;
            //SET PROPS
            TestItem.EmployeeNo = 1;
            TestItem.EmployeeFirstName = "Maru";
            TestItem.EmployeeSurName = "Wana";
            TestItem.EmployeeContactNo = "07163829253";
            TestItem.EmployeeEmail = "Maru@gmail.com";
            //set the emplyee to the test data
            AllEmployees.ThisEmployee = TestItem;
            //add the record
            PK = AllEmployees.Add();
            //SET THE PK OF THE TEST DATA
            TestItem.EmployeeNo = PK;
            //MOD THE TEST CODE
            TestItem.EmployeeNo = 1;
            TestItem.EmployeeFirstName = "Wak";
            TestItem.EmployeeSurName = "Anda";
            TestItem.EmployeeContactNo = "07163829253";
            TestItem.EmployeeEmail = "Maru@gmail.com";
            //set the record based on the new test data
            AllEmployees.ThisEmployee = TestItem;
            //update the record
            AllEmployees.Update();
            AllEmployees.ThisEmployee.Find(PK);
            //TEST TO SEE THIS EMPLOYEE MATCHES THE TEST DATA
            Assert.AreEqual(AllEmployees.ThisEmployee, TestItem);

            
        }




    }

}
