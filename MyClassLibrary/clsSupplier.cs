using System;

namespace MyClassLibrary
{
    public class clsSupplier
    {
        //private data member for the Supplier_Id property
        private Int32 mSupplier_Id;
        private string mSupplier_Address;
        private string mSupplier_County;
        private string mSupplier_Email;
        private string mSupplier_Name;
        private String mSupplier_Phone_No;

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
        public string Supplier_County
        {
            get
            {
                //return the private data
                return mSupplier_County;
            }
            set
            {
                //set the value of the private data member
                mSupplier_County = value;
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

        public bool Find(int supplier_Id)
        {
            //set the private data member to the test data value
            mSupplier_Id = 002;
            mSupplier_Address = "Test Supplier_Address";
            mSupplier_County = "Test County";
            mSupplier_Email = "Supplier_Email@gmail.com";
            mSupplier_Name = "Test Supplier Name";
            mSupplier_Phone_No = "07331415589";
            //always return true
            return true;
        }
    }
}