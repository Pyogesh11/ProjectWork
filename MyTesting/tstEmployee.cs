using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
        [TestClass]  
        public class tstEmployee

    {
        //good test data
        //creating some test data to pass to the valid method
        string EmployeeFirstName = "Areeb";
        string EmployeeSurName = "Pajwani";
        string EmployeeEmail = "Areeb@gamil.com";
        string EmployeeContactNo = "07152872622"
        
        
        
        
        
        
        //creating an instances of my class clsEmployee
        [TestMethod]
        public void InsttanceOK()
        {
            clsEmployee AnEmployee = new clsEmployee();
            //testing to see that the object AnEmployee exists
            Assert.IsNotNull(AnEmployee);
        }

        [TestMethod]
        //creaing the porpiety EmployeeFirstName
        public void EmployeeFirstNameExist()
        {
            //making an insstance of the class clsemployee
            clsEmployee AnEmployee = new clsEmployee();
            //creating a carible and assinging it a name 
            String testEmployeeFirstName = "tom";
            //the data type which we want to create is mentioned here when we are assing the valuye in testEmpyye First name to iit 
            AnEmployee.EmployeeFirstName = testEmployeeFirstName;
            //checking shure that the propity contains the same value in the varible testEmployeeFirstName
            Assert.AreEqual(testEmployeeFirstName, AnEmployee.EmployeeFirstName);
        }
        [TestMethod]
        //creating the propeity EmployeeSurName by cheking to see that it exists
        public void EmployeeSurNameExit()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String testEmployeeSurName = "Kehane";
            //we are now assinging the value which we have in the string into the propiety whcih we also create here
            AnEmployee.EmployeeSurName = testEmployeeSurName;
            //testing to see if the data type has the same data as in the string
            Assert.AreEqual(testEmployeeSurName, AnEmployee.EmployeeSurName);

        }
       // [TestMethod]
        //creating the propeity EmployeeContactNoExist by cheking to see that it exists
       // public void EmployeeContactNoExist()
       // {
       //     clsEmployee AnEmployee = new clsEmployee();
       //     string testEmployeeContactNo = "12345678901";
            //the data type which we want to create is mentioned here , also transfer teh data in the varibe into the propeity
        //    AnEmployee.EmployeeContactNo = testEmployeeContactNo;
        //    Assert.AreEqual(testEmployeeContactNo, AnEmployee.EmployeeContactNo);
        //}

        [TestMethod]
        public void EmployeeContactNoExist()
        {
            clsEmployee AnEmployee = new clsEmployee();
            string testEmployeeContactNo = "12345678901";
            AnEmployee.EmployeeContactNo = testEmployeeContactNo;
            Assert.AreEqual(testEmployeeContactNo, AnEmployee.EmployeeContactNo);
        }




        [TestMethod]
        //Creating the propeity EmployeeEmailExist by cheking to see that it exists
        public void EmployeeEmailExist()
        {
            clsEmployee AnEmployee = new clsEmployee();
            string testEmployeeEmail = "NaughtyDogz@gmail.com";
            // the data type whcih we want to create is mentioned her, and we are plcing the data in the string into the propeity
            AnEmployee.EmployeeEmail = testEmployeeEmail;
            Assert.AreEqual(testEmployeeEmail, AnEmployee.EmployeeEmail);

        }
        [TestMethod]
        // creating the propeity EmployeeNoExist by cheking to see that it exists
        public void EmployeeNoExist()
        {
            //creating an instane of the class  Employeee
            clsEmployee AnEmployee = new clsEmployee();
            // creating an varible and assing data to it
            Int32 testEmployeeNo = 123;
            //moving the data in from the varible to the propeity 
            AnEmployee.EmployeeNo = testEmployeeNo;
            //checking to see that the data in the propeity is the sam eas the data in the varible
            Assert.AreEqual(testEmployeeNo, AnEmployee.EmployeeNo);

        }
        [TestMethod]
        //The following contains the methods
        public void FindMethodOK()
        {
            // CREATING THE INSTANCE OF THE CLASS
            clsEmployee AnEmployee = new clsEmployee();
            // creating a boolean varbble to store the results of the validation
            Boolean Found = false;
           
            //craeting test data to test the method
             Int32 EmployeeNo = 1;
            // string EmployeeFirstName = "Nadim";
           
            //invoking the method
            Found = AnEmployee.Find(EmployeeNo);
            Assert.IsTrue(Found);
            // !!!!!!! i have made it so that it always return true, this needs to be fizxed
            
        }
        // fOLLOWING CODE MAKES SURE THAT WE CAN FIND ALL THE ATTRIBUTES
        [TestMethod]

        public void TestEmployeeNoFound()
        {
            clsEmployee anEmployee = new clsEmployee();
            //boolean varible to store the results of theserach
            Boolean Found = false;
            //boolean varible to record if data is ok (assume it is???)
            Boolean OK = true;
            //craeting test data to test all thsi out
            Int32 EmployeeNo = 1;
            //invoking the method
            Found = anEmployee.Find(EmployeeNo);
            //check the employee no
            if (anEmployee.EmployeeNo != 1)
            {
                OK = false;
            }
            //tesst to see if the results are true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testemployeefirstnamefound()
        {
            clsEmployee anemployee = new clsEmployee();
            //boolean varible to store the results of the serach
            Boolean found = false;
            //boolean varible to record if data is ok (assume it is???)
            Boolean ok = true;
            Int32 EmployeeNo = 1;
            //creating test data to test all of it out
            //string employeefirstname = "max";
            //invoke the method
            found = anemployee.Find(EmployeeNo);
            //check emplyeefirst name
            if (anemployee.EmployeeFirstName != "Max")
            {
                ok = false;
            }
            Assert.IsTrue(ok);

        }

        [TestMethod]
        public void TestEmployeeSurNameFound()
        {
            clsEmployee AnEmployee = new clsEmployee();
            //boolean varible to store the results of the serach
            Boolean Found = false;
            //boolean varible to record if data is ok (assume it is???)
            Boolean OK = true;
            Int32 EmployeeNo = 1;
            //creating test data to test all of it out
            //string EmployeeSurName = "Tokigawa";
            //invoke the method
            Found = AnEmployee.Find(EmployeeNo);
            //check emplyeefirst name
            if (AnEmployee.EmployeeSurName != "Tokigawa")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestEmployeeContactNoFound()
        {
            clsEmployee anEmployee = new clsEmployee();
            //boolean varible to store the results of theserach
            Boolean Found = false;
            //boolean varible to record if data is ok (assume it is???)
            Boolean OK = true;
            Int32 EmployeeNo = 1;
            //craeting test data to test all thsi out
            Int64 EmployeeContactNo = 07392738291;
            //invoking the method
            Found = anEmployee.Find(EmployeeNo);
            //check the employee contact no
            if (anEmployee.EmployeeContactNo != "07392738291")
            {
                OK = false;
            }
            //tesst to see if the results are true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmployeeEmailFound()
        {
            clsEmployee AnEmployee = new clsEmployee();
            //boolean varible to store the results of the serach
            Boolean Found = false;
            //boolean varible to record if data is ok (assume it is???)
            Boolean OK = true;
            Int32 EmployeeNo = 1;
            //creating test data to test all of it out
            string EmployeeEmail = "Dingas@gmail.com";
            //invoke the method
            Found = AnEmployee.Find(EmployeeNo);
            //check emplye email
            if (AnEmployee.EmployeeEmail != "Dingas@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        // The following code is for validating data enteryes. 
        [TestMethod]
        public void ValidMethodOK()
        {
            //creating an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string varible  to store any error message
            string Error = "";
            //invoking the valid method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail); 

        }







    }
}

