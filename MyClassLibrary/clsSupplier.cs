using System;

namespace MyClassLibrary
{
    public class clsSupplier
    {
        //private data member for the Supplier_Id property
        private Int32 mSupplier_Id;
        
        public string Supplier_Address { get; set; }
        public string Supplier_County { get; set; }
        public string Supplier_Email { get; set; }
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
        public string Supplier_Name { get; set; }
        public long Supplier_Phone_No { get; set; }

        public bool Find(int supplier_Id)
        {
            //set the private data member to the test data value
            mSupplier_Id = 002;
            //always return true
            return true;
        }
    }
}