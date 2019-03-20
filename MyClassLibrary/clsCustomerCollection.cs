using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data 
                return mCustomerList;
            }
            set
            {
                //set the private data 
                mCustomerList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list 
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later 
            }
        }

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }
        public int Add()
        {
            //add a new record to the databased based on the values of mThisCustomer
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@SurName", mThisCustomer.SurName);
            DB.AddParameter("@CountyNo", mThisCustomer.CountyNo);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("@Active", mThisCustomer.Active);
            DB.AddParameter("@Email", mThisCustomer.Email);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@SurName", mThisCustomer.SurName);
            DB.AddParameter("@CountyNo", mThisCustomer.CountyNo);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("@Active", mThisCustomer.Active);
            DB.AddParameter("@Email", mThisCustomer.Email);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        //constructor for the class
        public clsCustomerCollection()
           
            {
                //var for the index 
                Int32 Index = 0;
                //var to store the record count
                Int32 RecordCount = 0;
                //object for data connection
                clsDataConnection DB = new clsDataConnection();
                //execute the stored procedure 
                DB.Execute("sproc_tblCustomer_SelectAll");
                //get the count of records
                RecordCount = DB.Count;
                //while there are records to process 
                while (Index < RecordCount)
                {
                    //create a blank customer
                    clsCustomer ACustomer = new clsCustomer();
                    //read in the fields from the current record
                    ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                    ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                    ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                    ACustomer.SurName = Convert.ToString(DB.DataTable.Rows[Index]["SurName"]);
                    ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                    ACustomer.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                    ACustomer.PhoneNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneNo"]);
                    ACustomer.CountyNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CountyNo"]);
                    ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                    ACustomer.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                    //add the record to the private data member
                    mCustomerList.Add(ACustomer);
                    //point at the next record
                    Index++;
                }
            }
    }
}