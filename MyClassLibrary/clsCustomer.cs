using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {
        //private data member for the HouseNo property  
        //public property for active 
        public bool Active { get; set; }
        public int CountyNo { get; set; }
        public int PhoneNo { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public bool Find(int customerID)
        {
            //set the private data member to the test data value 
            mHouseNo = "1";
            //always return true 
            return true;
        }

        private string mHouseNo;
        //public property for the house number 
        public string HouseNo
        {
            get
            {
                //return the private data 
                return mHouseNo;
            }
            set
            {
                //set the value of the private data member 
                mHouseNo = value;
            }
        }
    }
}
