using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsSupplierCollection
    {
        //private data member for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        //private data member thisSupplier
        clsSupplier mThisSupplier = new clsSupplier();

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
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stroed procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //populate the arrary list with the data table
            PopulateArrary(DB);            
        }

        public int Add()
        {
            //add a new record to the database based on the values of mThisSupplier
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Supplier_Address", mThisSupplier.Supplier_Address);
            DB.AddParameter("@CountyNo", mThisSupplier.CountyNo);
            DB.AddParameter("@Supplier_Email", mThisSupplier.Supplier_Email);
            DB.AddParameter("@Supplier_Name", mThisSupplier.Supplier_Name);
            DB.AddParameter("@Supplier_Phone_No", mThisSupplier.Supplier_Phone_No);
            DB.AddParameter("@Active", mThisSupplier.Active);
            //execute the query returing the primary key value
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        //public property for ThisSupplier
        public clsSupplier ThisSupplier
        {
            get
            {
                //Return the private data
                return mThisSupplier;
            }

            set
            {
                //set the private data
                mThisSupplier = value;
            }
        }

        //delete method for supplier table
            public void Delete()
        {
            //delete the record pointed to by ThisSupplier
            //connected to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Supplier_Id", mThisSupplier.Supplier_Id);
            //execute the stored procedure 
            DB.Execute("sproc_tblSupplier_Delete");       
        }

        public void Update()
        {
            //update an existing record based on the values of the thisSupplier
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the store procedure
            DB.AddParameter("@Supplier_Id", mThisSupplier.Supplier_Id);
            DB.AddParameter("@Supplier_Address", mThisSupplier.Supplier_Address);
            DB.AddParameter("@CountyNo", mThisSupplier.CountyNo);
            DB.AddParameter("@Supplier_Email", mThisSupplier.Supplier_Email);
            DB.AddParameter("@Supplier_Name", mThisSupplier.Supplier_Name);
            DB.AddParameter("@Supplier_Phone_No", mThisSupplier.Supplier_Phone_No);
            DB.AddParameter("@Active", mThisSupplier.Active);
            //execute the store procedure
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void ReportBySupplier_Name(string Supplier_Name)
        {
            //filters the records based on a full or partial supplier name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the supplier name parameter to the database
            DB.AddParameter("@Supplier_Name", Supplier_Name);
            //execute the store procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplier_Name");
            //populate the array list with the data table
            PopulateArrary(DB);
        }

        void PopulateArrary(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mSupplierList = new List<clsSupplier>();
            //while there are recordds to process
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
                ASupplier.Supplier_Name = Convert.ToString(DB.DataTable.Rows[Index]["Supplier_Name"]);
                ASupplier.Supplier_Phone_No = Convert.ToString(DB.DataTable.Rows[Index]["Supplier_Phone_No"]);
                //add the record to the private data member
                mSupplierList.Add(ASupplier);
                //point at the next record
                Index++;
            }
        }
    }
}