﻿using System;
using System.Collections.Generic;
using MyClassLibrary;

namespace MyClassLibrary
{
    public class clsConsole
    {
        private string mConsole;
        private string mConsoleManufacturer;
        private Int32 mConsoleStock;
        private Int32 mConsolePrice;
        private Int32 mConsoleNo;
        private string mConsoleName;




        public string Console
        {
            get
            {
                //return the private data
                return mConsole;
            }
            set
            {
                mConsole = value;
            }
        }
        public int ConsoleNo
        {
            get
            {
                //return the private data
                return mConsoleNo;
            }
            set
            {
                mConsoleNo = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                //return the private data
                return mConsoleManufacturer;
            }
            set
            {
                mConsoleManufacturer = value;
            }
        }
        public int Price
        {
            get
            {
                //return the private data
                return mConsolePrice;
            }
            set
            {
                mConsolePrice = value;
            }
        }
        public int Stock
        {
            get
            {
                //return the private data
                return mConsoleStock;
            }
            set
            {
                mConsoleStock = value;
            }
        }
        public string Name
        {
            get
            {
                //return the private data
                return mConsoleName;
            }
            set
            {
                mConsoleName = value;
            }
        }
        public bool Find(int ConsoleNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ConsoleNo", ConsoleNo);
            DB.Execute("sproc_tblConsole_FilterByConsole_Manufacturer");
            if (DB.Count == 1)
            {
                mConsoleNo = Convert.ToInt32(DB.DataTable.Rows[0]["ConsoleNo"]);
                mConsoleName = Convert.ToString(DB.DataTable.Rows[0]["ConsoleName"]);
                mConsolePrice = Convert.ToInt32(DB.DataTable.Rows[0]["ConsolePrice"]);
                mConsoleStock = Convert.ToInt32(DB.DataTable.Rows[0]["ConsoleStock"]);
                mConsoleManufacturer = Convert.ToString(DB.DataTable.Rows[0]["ConsoleManufacturer"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string ConsoleName, string ConsolePrice, string ConsoleStock, string ConsoleManufacturer)
        {
            String Error = "";

            if (ConsoleName.Length == 0)
            {
                Error = Error + "This must not be blank";
            }
            if (ConsoleManufacturer.Length == 0)
            {
                Error = Error + "This must not be blank";
            }
            if (ConsoleName.Length > 16)
            {
                Error = Error + "The Console Name must be less than 16 characters: ";
            }
            if (ConsoleManufacturer.Length > 19)
            {
                Error = Error + "The Console Manufacturer must be less than 19 characters: ";
            }
            if (ConsolePrice.Length == 0)
            {
                Error = Error + "This must not be blank";
            }
            if (ConsolePrice.Length > 500)
            {
                Error = Error + "The Console Name must be less than 500 characters: ";
            }
            if (ConsoleStock.Length == 0)
            {
                Error = Error + "This must not be blank";
            }
            if (ConsolePrice.Length > 1000000)
            {
                Error = Error + "The Console Name must be less than 1000000 characters: ";
            }
            return Error;
        }


    }
}

