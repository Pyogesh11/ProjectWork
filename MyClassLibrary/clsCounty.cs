using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class clsCounty
    {
        //private data member for the property countyno      
        private Int32 mCountyNo;
        //private property for the property county
        private string mCounty;

        public bool Find(int CountyNo)
        {
            //create an instance of the data connections
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for 
            DB.AddParameter("@CountyNo", CountyNo);
            //execute the store procedure 
            DB.Execute("sproc_tblCounty_FilterByCountyNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mCountyNo = Convert.ToInt32(DB.DataTable.Rows[0]["CountyNo"]);
                mCounty = Convert.ToString(DB.DataTable.Rows[0]["County"]);

                //return that everything worked OK 
                return true;
            }
            //if no records was found 
            else
            {
                //return false indicating a problem 
                return false;
            }
        }

        public string County
        {
            get
            {
                //return false indicating a prolem
                return mCounty;
            }
            set
            {
                //set the value of the private data member
                mCounty = value;
            }
        }

        public int CountyNo
        {
            get
            {
                //return false indicating a problem
                return mCountyNo;
            }
            set
            {
                //set the vale of the private data member
                mCountyNo = value;
            }
        }

        public string Valid(string SomeCounty)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the county is more than 50 characters
            if (SomeCounty.Length > 50)
            {
                //return an error message
                Error = "The county name cannot have more than 50 characters";
            }
            if (SomeCounty.Length == 0)
            {
                //return an error message
                Error = "The county name may not be blank!";
            }
            return Error;
        }
    }
}

