

using MyClassLibrary;
using System;
using System.Collections.Generic;

namespace MyTesting
{
    public class ClsConsoleCollection
    {
        List<clsConsole> mConsoleList = new List<clsConsole>();

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

        public int Count { get; internal set; }

        public ClsConsoleCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("Sproc_tblConsole_SelectAll");
            RecordCount = DB.Count;

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

        
        
    }
}