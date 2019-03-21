using MyClassLibrary;
using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsConsoleCollection
    {   //private data member for the list
        List<clsConsole> mConsoleList = new List<clsConsole>();
        public clsConsoleCollection()
        {
            //data connection
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("Sproc_tblConsole_SelectAll");
            //populate array list with data table
            PopulateArray(DB);


        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates array list depending on datatable in DB
            //var for index
            Int32 Index = 0;
            //var to store Record Count
            Int32 RecordCount;
            //get count of records
            RecordCount = DB.Count;
            //clears private array list
            mConsoleList = new List<clsConsole>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsConsole AConsole = new clsConsole();
                AConsole.ConsoleNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ConsoleNo"]);
                AConsole.Name = Convert.ToString(DB.DataTable.Rows[Index]["ConsoleName"]);
                AConsole.Manufacturer = Convert.ToString(DB.DataTable.Rows[Index]["ConsoleManufacturer"]);
                AConsole.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["ConsolePrice"]);
                AConsole.Stock = Convert.ToInt32(DB.DataTable.Rows[Index]["ConsoleStock"]);
                mConsoleList.Add(AConsole);
                Index++;
            }
        }
        clsConsole mThisConsole = new clsConsole();
        public List<clsConsole> ConsoleList
        {
            get
            {
                return mConsoleList;
            }
            set
            {
                mConsoleList = value;
            }
        }
        public clsConsole ThisConsole
        {
            get
            {
                //returns private data
                return mThisConsole;
            }
            set
            {
                //set th private data
                mThisConsole = value;
            }
        }
        public int Count { get; set; }
        public List<clsConsole> AllConsoles { get; set; }

        public int Add()
        {
            //adds new record to the databased based on values of thisconsole
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameteres for the stored procedure
            DB.AddParameter("@ConsoleNo", mThisConsole.ConsoleNo);
            DB.AddParameter("@ConsolePrice", mThisConsole.Price);
            DB.AddParameter("@ConsoleStock", mThisConsole.Stock);
            DB.AddParameter("@ConsoleManufacturer", mThisConsole.Manufacturer);
            return DB.Execute("sproc_tblConsole_Insert");
        }
        public void Delete()
        {
            //delete record to pointed to thisConsole
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ConsoleNo", mThisConsole.ConsoleNo);
            DB.Execute("sproc_tblConsole_Delete");
        }
        public void Update()
        {
            //updates existing records
            clsDataConnection DB = new clsDataConnection();
            //set parameters
            DB.AddParameter("@ConsoleNo", mThisConsole.ConsoleNo);
            DB.AddParameter("@ConsolePrice", mThisConsole.Price);
            DB.AddParameter("@ConsoleStock", mThisConsole.Stock);
            DB.AddParameter("@ConsoleManufacturer", mThisConsole.Manufacturer);
            //execute procedure
            DB.Execute("sproc_tblConsole_Update");
        }
        public void ReportByConsoleName(string ConsoleName)
        {
            //DB Connection
            clsDataConnection DB = new clsDataConnection();
            //sends Console parameter to Database
            DB.AddParameter("@ConsoleName", ConsoleName);
            //Execute stored procedure
            DB.Execute("sproc_tblConsole_FilterByConsoleName");
            //populate array with data table
            PopulateArray(DB);

        }


    }
}
