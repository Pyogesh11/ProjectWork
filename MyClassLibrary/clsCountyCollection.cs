using System;
using System.Collections.Generic;
namespace MyClassLibrary
{
    public class clsCountyCollection
    {

        //private data member for the allcounties list 
        private List<clsCounty> mAllCounties = new List<clsCounty>();

        //public prperty for count 
        public int Count
        {
            get
            {
                //return the count property of the private list 
                return mAllCounties.Count;
            }
            set
            {
                //we wil look at thi in a moment!
            }
        }

        //public property for allCounties 
        public List<clsCounty> AllCounties
        {
            //geter sends data to requesting code 
            get
            {
                //return the private data member 
                return mAllCounties;
            }
            //setter accepts dat from other objects 
            set
            {
                //assign the incoming vaue to the private data member 
                mAllCounties = value;
            }
        }
        //public constructor for the class
        public clsCountyCollection()
        {
            //create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stroed procedure to get the list of data
            DB.Execute("sproc_tblCounty_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //While there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the county class
                clsCounty ACounty = new clsCounty();
                //get the County name
                ACounty.County = DB.DataTable.Rows[Index]["County"].ToString();
                //get the pimary key
                ACounty.CountyNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CountyNo"]);
                //add the county to the private data member
                mAllCounties.Add(ACounty);
                //increment the index
                Index++;
            }
        }
    }
}
