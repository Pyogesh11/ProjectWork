using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public int CountyNo { get; set; }
        public string HouseNo { get; set; }
        public int PhoneNo { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }

        public bool Find(int customerID)
        {
            //always return true 
            return true;
        }
    }
}
