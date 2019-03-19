using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {
        //private data member for the HouseNo property  
        //public property for gender
        private Boolean mGender;
        private string mHouseNo;
        private Int32 mCustomerID;
        private int mCountyNo;
        private string mStreet;
        private string mFirstName;
        private string mSurName;
        private string mEmail;
        private string mPostCode;
        private int mPhoneNo;

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for 
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the store procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCountyNo = Convert.ToInt32(DB.DataTable.Rows[0]["CountyNo"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mSurName = Convert.ToString(DB.DataTable.Rows[0]["SurName"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNo"]);
                mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
                //return that everything worked OK 
                return true;
            }
            //if no records was found 
            else
            {
                //return false indicating a problem 
                return false;
            }
        }

        //public property for the house number 
        public int CustomerID
        {
            get
            {
                //return the private data 
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member 
                mCustomerID = value;
            }
        }

        //public property for house no 
        public string HouseNo
        {
            get
            {
                //return the private data
                return mHouseNo;
            }
            set
            {
                //set the value of the private data
                mHouseNo = value;
            }
        }

        //public property for Gender 
        public bool Gender
        {
            get
            {
                //return the private data
                return mGender;
            }
            set
            {
                //set the value of the private data
                mGender = value;
            }
        }

        //public property for county no 
        public int CountyNo
        {
            get
            {
                //return the private data 
                return mCountyNo;
            }
            set
            {
                //set thr private data 
                mCountyNo = value;
            }
        }
        //public property for street
        public string Street
        {
            get
            {
                //return the private data 
                return mStreet;
            }
            set
            {
                //set thr private data 
                mStreet = value;
            }
        }
        //public property for street
        public string FirstName
        {
            get
            {
                //return the private data 
                return mFirstName;
            }
            set
            {
                //set thr private data 
                mFirstName = value;
            }
        }
        //public property for street
        public string SurName
        {
            get
            {
                //return the private data 
                return mSurName;
            }
            set
            {
                //set thr private data 
                mSurName = value;
            }
        }
        //public property for street
        public string Email
        {
            get
            {
                //return the private data 
                return mEmail;
            }
            set
            {
                //set thr private data 
                mEmail = value;
            }
        }
        //public property for street
        public string PostCode
        {
            get
            {
                //return the private data 
                return mPostCode;
            }
            set
            {
                //set thr private data 
                mPostCode = value;
            }
        }
        //public property for street
        public int PhoneNo
        {
            get
            {
                //return the private data 
                return mPhoneNo;
            }
            set
            {
                //set thr private data 
                mPhoneNo = value;
            }
        }

        public string Valid(string firstName, string street, string houseNo, string surName, string postCode, string email)
        {

            //create a string varible to store the error 
            string Error = "";
            //if the HouseNo is blank 
            if (houseNo.Length == 0)
            {
                //record the error 
                Error = Error + "the house no may not be blank : ";
            }
            //if the house no is greater than 6 characters 
            if (houseNo.Length > 6)
            {
                //record the error 
                Error = Error + "The house no must be less than 6 characters : ";
            }
            //is the post code blank
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be black : ";
            }
            //if the post code is too long 
            if (postCode.Length > 9)
            {
                //record the error
                Error = Error + "The poste code must be less than 9 characters :";
            }
            //is the street blank 
            if (street.Length == 0)
            {
                //record the error
                Error = Error + "The street may not be blank : ";
            }
            //if the street is too long 
            if (street.Length > 50)
            {
                //record the error 
                Error = Error + "The street must be less than 50 characters :";
            }
            //is the Email blank
            if (email.Length == 0)
            {
                //record the error 
                Error = Error + "The email may not be blank :";
            }
            //if the email is too long 
            if (email.Length > 30)
            {
                //record  the error 
                Error = Error + "The email must be less than 30 characters :";
            }
            //return any error message 
            return Error;
        }
    }
}
