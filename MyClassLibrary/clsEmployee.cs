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
        private string mEmployeeContactNo;
        

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

        public string EmployeeContactNo
        { get
            {
                return mEmployeeContactNo;
            }
            set
            {
                mEmployeeContactNo = value;
            }
            

            
        }

        public bool Find(int employeeNo)
        {
            //set the private data meber to test the data value
            mEmployeeNo = 21;
            mEmployeeFirstName = "Max"; 
            mEmployeeSurName = "Tokigawa";
            mEmployeeContactNo = "07392738291";
            mEmployeeEmail = "Dingas@gmail.com";
            //always return true
            return true;

        }

    

       


    }
    
}