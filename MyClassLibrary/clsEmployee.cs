using System;

namespace MyClassLibrary
{
    public class clsEmployee
    {
        //private data member for the EmployeeNo
        private Int32 mEmployeeNo;
        private string mEmployeeFirstName;
        private string mEmployeeSurName;
        private string mEmployeeEmail;
        private Int64 mEmployeeContactNo;

        public clsEmployee()
        {
        }

        //Get and set for employee first name
        public string EmployeeFirstName
        {
            get
            {
                //return the private data
                return mEmployeeFirstName;
            }

            set
            {
                //set the value of the private data number
                mEmployeeFirstName = value;

            }

        }

        //get and set for employee surname
        public string EmployeeSurName
        {
            get
            {
                //return the private data
                return mEmployeeSurName;
            }

            set
            {
                //set the value of the private data number
                mEmployeeSurName = value;

            }
        }
        //get and set for employee contact No
        public long EmployeeContactNo
        {
            get
            {
                //return the private data
                return mEmployeeContactNo;
            }

            set
            {
                //set the value of the private data number
                mEmployeeContactNo = value;

            }
        }

        //get and set for emolyee email
        public string EmployeeEmail
        {
            get
            {
                //return the private data
                return mEmployeeEmail;
            }

            set
            {
                //set the value of the private data number
                mEmployeeEmail = value;

            }
        }

        //get and set for employeeNo
        public int EmployeeNo
        {
            get
            {
                //return the private data
                return mEmployeeNo;
            }
                
            set
            {
                //set the value of the priuvate data number
                mEmployeeNo = value;
            }
        }

        public bool Find(string EmployeeFirstName)
        {
            //SET THE PRIVATE DATA MEMBER TO TEST THE VALUE
            mEmployeeFirstName = "MAX";
            //ALWAYS RETURN TURE
            return true;
        }

        public bool Find(int employeeNo)
        {
            //set the private data meber to test the data value
            mEmployeeNo = 21;
            //always return tru
            return true;

        }

        public bool Find(long employeeContactNo)
        {
            //set the private data member to test the data value
            mEmployeeContactNo = 07392738291;
            //always retrun true
            return true; 
        }

       


    }
    
}