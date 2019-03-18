

using MyClassLibrary;
using System.Collections.Generic;

namespace MyTesting
{
    public class clsConsoleCollection
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

        public clsConsoleCollection()
        {
            clsConsole TestItem = new clsConsole();
            TestItem.ConsoleNo = 1;
            TestItem.Name = "Xbox";
            TestItem.Manufacturer = "Microsoft";
            TestItem.Price = 250;
            TestItem.Stock = 10000;
            mConsoleList.Add(TestItem);
            TestItem = new clsConsole();
            TestItem.ConsoleNo = 2;
            TestItem.Name = "PS4";
            TestItem.Manufacturer = "Sony";
            TestItem.Price = 200;
            TestItem.Stock = 25000;
            mConsoleList.Add(TestItem);
        }

        
        
    }
}