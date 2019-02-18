using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }

        public bool Find(int customerID)
        {
            //always return true 
            return true; 
        }
    }
}