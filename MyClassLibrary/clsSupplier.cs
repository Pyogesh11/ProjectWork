using System;

namespace MyClassLibrary
{
    public class clsSupplier
    {
        //private data member for the Supplier_Id property
        private Int32 mSupplier_Id;
        //private data member for the Supplier_Id property
        private string mSupplier_Address;
        //private data member for the Supplier_Id property
        private Int32 mCountyNo;
        //private data member for the Supplier_Id property
        private string mSupplier_Email;
        //private data member for the Supplier_Id property
        private string mSupplier_Name;
        //private data member for the Supplier_Id property
        private String mSupplier_Phone_No;
        //private data member for the Supplier_Id property
        private Boolean mActive;

        public string Supplier_Address
        {
            get
            {
                //return the private data
                return mSupplier_Address;
            }
            set
            {
                //set the value of the private data member
                mSupplier_Address = value;
            }
        }

        //public property for the Supplier_County
        public Int32 CountyNo
        {
            get
            {
                //return the private data
                return mCountyNo;
            }
            set
            {
                //set the value of the private data member
                mCountyNo = value;
            }
        }

        //public property for the Supplier_Email
        public string Supplier_Email
        {
            get
            {
                //return the private data
                return mSupplier_Email;
            }
            set
            {
                //set the value of the private data member
                mSupplier_Email = value;
            }
        }


        //public property for the supplier_Id 
        public int Supplier_Id
        {
            get
            {
                //return the private data
                return mSupplier_Id;
            }
            set
            {
                //set the value of the priuvate data member
                mSupplier_Id = value;

            }
        }

        //Public property for Supplier_Name
        public string Supplier_Name
        {
            get
            {
                //return the private data
                return mSupplier_Name;
            }
            set
            {
                //set the value of the private data member
                mSupplier_Name = value;
            }
        }

        //Public property for Supplier_Phone_No
        public string Supplier_Phone_No
        {
            get
            {
                //return the private data
                return mSupplier_Phone_No;
            }
            set
            {
                //set the value of the private data member
                mSupplier_Phone_No = value;
            }
        }

        //Public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }

            set
            {
                //set the private data
                mActive = value;
            }
        }

        public bool Find(int Supplier_Id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Supplier_Id to search for
            DB.AddParameter("@Supplier_Id", Supplier_Id);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplier_Id");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mSupplier_Id = Convert.ToInt32(DB.DataTable.Rows[0]["Supplier_Id"]);
                mSupplier_Address = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Address"]);
                mCountyNo = Convert.ToInt32(DB.DataTable.Rows[0]["CountyNo"]);
                mSupplier_Email = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Email"]);
                mSupplier_Name = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Name"]);
                mSupplier_Phone_No = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Phone_No"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return indicating a problem
                return false;
            }     

        }

        //validation part
        public string Valid(string Supplier_Address, string Supplier_Email, string Supplier_Name, string Supplier_Phone_No)
        {
            //create a string variable to stroe the error
            string Error = "";
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //is the supplier address blank
            if (Supplier_Address.Length == 0)
            {
                //record the error
                Error = Error + "the supplier_Address may not be blank : ";
            }
            //if the town is too long
            if (Supplier_Address.Length > 50)
            {
                //record the error
                Error = Error + "The supplier address must be less than 50 characters : ";
            }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //is the Supplier_Email blank
            if (Supplier_Email.Length == 0)
            {
                //record the error
                Error = Error + "the Supplier_Email may not be blank : ";
            }
            //if the town is too long
            if (Supplier_Email.Length > 50)
            {
                //record the error
                Error = Error + "The Supplier_Email must be less than 50 characters : ";
            }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //is the Supplier_Name blank
            if (Supplier_Name.Length == 0)
            {
                //record the error
                Error = Error + "the Supplier_Name may not be blank : ";
            }
            //if the town is too long
            if (Supplier_Name.Length > 20)
            {
                //record the error
                Error = Error + "The Supplier_Name must be less than 20 characters : ";
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //is the Supplier_Phone_No blank
            if (Supplier_Phone_No.Length == 0)
            {
                //record the error
                Error = Error + "the Supplier_Phone_No may not be blank : ";
            }
            //if the town is too long
            if (Supplier_Phone_No.Length > 15)
            {
                //record the error
                Error = Error + "The Supplier_Phone_No must be less than 15 characters : ";
            }

            // return any error messages
            return "";
        }   
    }
}