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

        public bool Find(int EmployeeNo)
        {
            //creating an instance of the data class connection
            clsDataConnection DB = new clsDataConnection();
            //adding a paramter for the employee number to be serched for
            DB.AddParameter("@EmployeeNo", EmployeeNo);
            //exercute the stored proceduer
            DB.Execute("sproc_tblEmployees_FilterByEmployeeNo");
            // if one record is dound (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data numbers
                mEmployeeNo = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeNo" ]);
                mEmployeeFirstName = Convert.ToString(DB.DataTable.Rows[0]["EmployeeFirstName"]);
                mEmployeeSurName = Convert.ToString(DB.DataTable.Rows[0]["EmployeeSurName"]);
                mEmployeeEmail = Convert.ToString(DB.DataTable.Rows[0]["EmployeeEmail"]);
                mEmployeeContactNo = Convert.ToString(DB.DataTable.Rows[0]["EmployeeContactNo"]);
                // return that everything worked ok
                return true;


            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;

            }



          
        }

        public string Valid(string EmployeeFirstName, string EmployeeSurName, string EmployeeContactNo, string EmployeeEmail)
        {
            //craeting a string varible to store the error
            string Error = "";
            if (EmployeeFirstName.Length == 0)
            {
                //RECORD THE ERROR
                Error = Error + " The Employee's First Name, can not be blank.";
            }
            if (EmployeeFirstName.Length > 50)
            {
                //record the error msg
                Error = Error + " The charector total for the first name can not exeed 50 letters, please shorten";
            }
            if (EmployeeSurName.Length == 0)
            {
                //RECORD THE ERROR
                Error = Error + " The Employee's Sur Name, can not be blank.";
            }
            if (EmployeeSurName.Length > 50)
            {
                //record the error msg
                Error = Error + " The charector total for the Sur name can not exeed 50 letters, please shorten";
            }
           
            

            // IF statments for EmployeeContactNo

            if (EmployeeContactNo.Length == 0)

            {
                // the error msg
                Error = Error + " The Employee Contact No can not be blank";
            }
            if (EmployeeContactNo.Length > 13)

            {
                // the error msg
                Error = Error + " The Employee Contact No can not be exceed 13 charecters";
            }



            if (EmployeeEmail.Length == 0)

            {
                // the error msg
                Error = Error + " The Employee Email can not be blank";
            }
            if (EmployeeEmail.Length > 50)

            {
                // the error msg
                Error = Error + " The Employee Contact No can not be exceed 13 charecters";
            }


            //return any error messges
            return "";
        }
    }
    
}