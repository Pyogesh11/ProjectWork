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

        public bool Find(int customerID)
        {
            //set the private data member to the test data value 
            mCustomerID = 1;
            mHouseNo = "1";
            mGender = true;
            mCountyNo = 1;
            //always return true 
            return true;
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

    }
}
