using System;

namespace MyClassLibrary
{
    public class clsConsole
    {
        private string mConsole;
        private string mManufacturer;
        private Int32 mStock;
        private DateTime mDateAdded;
        private Int32 mPrice;
        private Boolean mActive;
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public DateTime DateAdded {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
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
        public string Manufacturer
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
        public int Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public int Stock
        {
            get
            {
                //return the private data
                return mStock;
            }
            set
            {
                mStock = value;
            }
        }

        public bool Find(int Console)
        {
            mManufacturer = "Microsoft";
            mConsole = "Xbox One";
            mPrice = 250;
            mStock = 25000;
            mDateAdded = Convert.ToDateTime("01/01/2017");
            mActive = true;
            //always returns true
            return true;
        }

        public string Valid(string manufacturer)
        {
            if (Manufacturer != "")
            {
                return "";
            }
            else
            {
                return "This must not be blank";
            }
        }
    }
}