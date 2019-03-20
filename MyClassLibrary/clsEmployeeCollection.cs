using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsEmployeeCollection
    {


        List<clsEmployee> mEmployeeList = new List<clsEmployee>();
        //private data member thisEmployee
        clsEmployee mThisEmployee = new clsEmployee();


        //PUBLIC PROP FOR ThisEmployee
        public clsEmployee ThisEmployee
        {
            get
            {
                //return the privae data
                return mThisEmployee;
            }
            set
            {
                //set the private data
                mThisEmployee = value;
            }
        }



        public List<clsEmployee> EmployeeList
        {
            get
            {
                //return the private data 
                return mEmployeeList;
            }
            set
            {
                //SET THE PRIVATE DATA
                mEmployeeList = value; 
            }




        }


        public int Count
        {
            get
            {
                //RETURN THE COUNT F THE LIST
                return mEmployeeList.Count;
            }
            set
            {
                //we shall wor bout this later
            }
        }
       
        



        //constuctuer fr the class
        public clsEmployeeCollection()
        {

            //var to store the index
            Int32  Index = 0;
            // var tp stor ethe record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //exercute the stored proceduer
            DB.Execute("sproc_tblEmployees_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to be processed
            while (Index < RecordCount)
            {
                clsEmployee TestItem = new clsEmployee();
                //seting the prameters
                TestItem.EmployeeNo = 6;
                TestItem.EmployeeFirstName = "Crona";
                TestItem.EmployeeSurName = "Maximus;";
                TestItem.EmployeeContactNo = "07364736261";
                TestItem.EmployeeEmail = "Crona@gmail.com";
                //  add the item to the test list
                mEmployeeList.Add(TestItem);
                // seting the prameters
                TestItem.EmployeeNo = 7;
                TestItem.EmployeeFirstName = "Prita";
                TestItem.EmployeeSurName = "Sokanji;";
                TestItem.EmployeeContactNo = "07726389431";
                TestItem.EmployeeEmail = "Crona@gmail.com";
                //add the item to the test list
                mEmployeeList.Add(TestItem);
                //point at the next record
                Index++;


            }





           
        }

        public int Add()
        {
            //connect to the dataase
            clsDataConnection DB = new clsDataConnection();
            //set the paramters fpr the stored proceduer
            DB.AddParameter("@EmployeeFirstName", mThisEmployee.EmployeeFirstName);
            DB.AddParameter("@EmployeeSurNmae", mThisEmployee.EmployeeSurName);
            DB.AddParameter("@EmployeeContactNo", mThisEmployee.EmployeeContactNo);
            DB.AddParameter("EmployeeEmail", mThisEmployee.EmployeeEmail);
            //exercute the querry retruning the primary key value
            return DB.Execute("sproc_tblEmployees_Insert");
        }

        public void Delete()
        {
            //deleates the record ponted to by ThisEmployee
            //commect to the database
            clsDataConnection DB = new clsDataConnection();
            //setting the param for the stored proceder
            DB.AddParameter("@EmployeeNo", mThisEmployee.EmployeeNo);
            //EXERCUTE THE STORED PROCEDUER
            DB.Execute("sproc_tblEmployess_Delete");
        }
    }
}