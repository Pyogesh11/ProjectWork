using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsSupplierCollection
    {
        //private data member for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

        //public propert for the Supplier list
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
            set
            {
                //set the private data
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mSupplierList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsSupplierCollection()
        {
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.Active = true;
            TestItem.Supplier_Address = "Some Supplier Address";
            TestItem.CountyNo = 001;
            TestItem.Supplier_Email = "abcd.e@gmail.com";
            TestItem.Supplier_Id = 1;
            TestItem.Supplier_Name = "Game.net";
            TestItem.Supplier_Phone_No = "07331415589";
            //add the item to the test list
            mSupplierList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsSupplier();
            //set its properties
            TestItem.Active = true;
            TestItem.Supplier_Address = "another Supplier Address";
            TestItem.CountyNo = 2;
            TestItem.Supplier_Email = "abcd.e7@gmail.com";
            TestItem.Supplier_Id = 005;
            TestItem.Supplier_Name = "another Game.net";
            TestItem.Supplier_Phone_No = "07331415599";
            //add the item to the test list
            mSupplierList.Add(TestItem);
        }


        public clsSupplier ThisSupplier { get; set; }
    }
}