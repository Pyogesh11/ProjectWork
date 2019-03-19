using System;
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
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stroe procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank supplier
                clsSupplier ASupplier = new clsSupplier();
                //read in the fields from the current record
                ASupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ASupplier.Supplier_Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Supplier_Id"]);
                ASupplier.Supplier_Address = Convert.ToString(DB.DataTable.Rows[Index]["Supplier_Address"]);
                ASupplier.CountyNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CountyNo"]);
                ASupplier.Supplier_Email = Convert.ToString(DB.DataTable.Rows[Index]["Supplier_Email"]);
                ASupplier.Supplier_Phone_No = Convert.ToString(DB.DataTable.Rows[Index]["Supplier_Phone_No"]);               
                //add the record to the private data member
                mSupplierList.Add(ASupplier);
                //point at the next record
                Index++;

            }
        }


        public clsSupplier ThisSupplier { get; set; }
    }
}