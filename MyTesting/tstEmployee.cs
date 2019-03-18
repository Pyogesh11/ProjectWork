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
             //MAKES IT AVALAIBLE TO ALL TEST
             //And if we want to add a new propeity, we can just add it here
             string EmployeeFirstName = "Areeb";
             string EmployeeSurName = "Pajwani";
             string EmployeeEmail = "Areeb@gamil.com";
        string EmployeeContactNo = "07152872622";






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


        //TEST FOR THE PARAMTERS 

        //Testing for EmployeeFirstName Min 1
        [TestMethod]
        public void EmployeeFirstNameMinMinusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            String EmployeeFirstName = "";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");

        }

        //testing for EmployeeFirst Name Min
        [TestMethod]
        public void EmployeeFirstNameMin()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeFirstName = "N";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeFirst Name Min plus one
        [TestMethod]
        public void EmployeeFirstNameMinPlusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeFirstName = "NN";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeFirst Name Max minus one so 49
        [TestMethod]
        public void EmployeeFirstNameMaxLessOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeFirstName = "NnnnnnnnnnNnnnnnnnnnNnnnnnnnnnNnnnnnnnnnNnnnnnnnn"; //49 chars here as max is 50
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeFirst Name Max, so 50
        [TestMethod]
        public void EmployeeFirstNameMax()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeFirstName = "NnnnnnnnnnNnnnnnnnnnNnnnnnnnnnNnnnnnnnnnNnnnnnnnnn"; //50 chars here as max is 50
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeFirst Name Middle, so 25
        [TestMethod]
        public void EmployeeFirstNameMid()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeFirstName = "NnnnnnnnnnNnnnnnnnnnNnnnn"; //25 chars here as max is 50
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }


        //testing for EmployeeFirst Name Max plus one so 59

        [TestMethod]
        public void EmployeeFirstNameMaxPlusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeFirstName = "NnnnnnnnnnNnnnnnnnnnNnnnnnnnnnNnnnnnnnnnNnnnnnnnnnN"; //51 chars here as max is 50
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeFirst Name Max exstream
        [TestMethod]
        public void EmployeeFirstNameMaxExstream()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeFirstName = ""; //this is blank a sthe following line of code will fill it
            EmployeeFirstName = EmployeeFirstName.PadRight(500, 'N'); //essential its saying give it 500chars. This should fail
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }








        //Testing for EmployeeSurName Min MINUS 1
        [TestMethod]
        public void EmployeeSurNameMinMinusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            String EmployeeSurName = "";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");

        }
        //testing for Employee Sur Name Min
        [TestMethod]
        public void EmployeeSurNameMin()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeSurNameName = "C";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        
        //testing for EmployeeSurName Name Min plus one
        [TestMethod]
        public void EmployeeSurNameMinPlusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeSurName = "CC";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeSurName Max minus one so 49
        [TestMethod]
        public void EmployeeSurNameMaxLessOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeSurName = ""; //empty a sthe next line will fill it with 49 chars
            EmployeeSurName = EmployeeSurName.PadRight(49,'c' );
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeSur Name Max, so 50
        [TestMethod]
        public void EmployeeSurNameMax()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeSurName = "";
            EmployeeSurName = EmployeeSurName.PadRight(50, 'C');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        
        //testing for EmployeeSur Name Middle, so 25
        [TestMethod]
        public void EmployeeSurNameMid()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeSurName = "";
            EmployeeSurName = EmployeeSurName.PadRight(25, 'C');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeSurName Max plus one so 59

        [TestMethod]
        public void EmployeeSurNameMaxPlusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeSurName = "";
            EmployeeSurName = EmployeeSurName.PadRight(59, 'C');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeSur Name Max exstream
        [TestMethod]
        public void EmployeeSurNameMaxExstream()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeSurName = ""; //this is blank a sthe following line of code will fill it
            EmployeeFirstName = EmployeeSurName.PadRight(500, 'C'); //essential its saying give it 500chars. This should fail
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }



        //Testing for EmployeeContactNo Min MINUS 1
        [TestMethod]
        public void EmployeeContactNoMinMinusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            String EmployeeContactNo = "";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");

        }


        //testing for Employee Contact Number  Min
        [TestMethod]
        public void EmployeeContactNoMin()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeContactNo = "1";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeContactNo Min plus one
        [TestMethod]
        public void EmployeeContactNoMinPlusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeContactNo = "12";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeContactNo Max minus one so 12 as 13 is max
        [TestMethod]
        public void EmployeeContactNoMaxLessOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeContactNo = ""; //empty a sthe next line will fill it with 12 chars
            EmployeeContactNo = EmployeeContactNo.PadRight(12, '1');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeContactNo Max, so 13
        [TestMethod]
        public void EmployeeContactNoMax()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeContactNo = "";
            EmployeeContactNo = EmployeeContactNo.PadRight(13, '2');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeContactNo MiddlE, so 7
        [TestMethod]
        public void EmployeeContactNoMid()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeContactNo = "";
            EmployeeContactNo = EmployeeContactNo.PadRight(7, '3');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeContactNo Max plus one so 14

        [TestMethod]
        public void EmployeeContactNoMaxPlusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeContactNo = "";
            EmployeeContactNo = EmployeeContactNo.PadRight(14, '4');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeContactNo Max exstream, lets say 100
        [TestMethod]
        public void EmployeeContactNoMaxExstream()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeContactNo = ""; //this is blank a sthe following line of code will fill it
            EmployeeContactNo = EmployeeContactNo.PadRight(100, '5'); //essential its saying give it 500chars. This should fail
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }








        //Testing for EmployeeEmail Min MINUS 1
        [TestMethod]
        public void EmployeeEmailMinMinusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            String EmployeeEmail = "";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");

        }


        //testing for Employeee Email  Min
        [TestMethod]
        public void EmployeeEmailMin()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeEmail = "E";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }


        //testing for EmployeEmail Min plus one, so two chars
        [TestMethod]
        public void EmployeeEmailNoMinPlusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeEmail = "Ea";
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }



        //testing for EmployeeEmail Max minus one so 49 as 50 is max
        [TestMethod]
        public void EmployeeEmailMaxLessOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeEmail = ""; //empty a sthe next line will fill it with 49chars
            EmployeeEmail = EmployeeEmail.PadRight(49, 'E');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeEmail Max, so 50
        [TestMethod]
        public void EmployeeEmailMax()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeEmail = "";
            EmployeeEmail = EmployeeEmail.PadRight(50, 'E');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeEmail MiddlE, so 25
        [TestMethod]
        public void EmployeeEmailNameMid()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeEmail = "";
            EmployeeEmail = EmployeeContactNo.PadRight(25, 'E');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }



        //testing for EmployeeEmail Max plus one so 51

        [TestMethod]
        public void EmployeeEmailMaxPlusOne()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeEmail = "";
            EmployeeEmail = EmployeeEmail.PadRight(51, 'E');
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        //testing for EmployeeEmail Max exstream, lets say 500
        [TestMethod]
        public void EmployeeEmailMaxExstream()
        {
            clsEmployee AnEmployee = new clsEmployee();
            String Error = "";
            //creating some test data
            String EmployeeContactNo = ""; //this is blank a sthe following line of code will fill it
            EmployeeEmail = EmployeeEmail.PadRight(500, 'E'); //essential its saying give it 500chars. This should fail
            //invoking the method
            Error = AnEmployee.Valid(EmployeeFirstName, EmployeeSurName, EmployeeContactNo, EmployeeEmail);
            //checking to see that the results are correct
            Assert.AreEqual(Error, "");
        }






    }
}

