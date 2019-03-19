using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsEmployeeCollection
    {
        List<clsEmployee> mEmployeeList = new List<clsEmployee>();

        public List<clsEmployee> EmployeeList
        {
            get
            {
                //return the private data 
                return mEmployeeList;
            }
            set
            {
                //SET THE PRIVATE DATA
            }




        }




        public int Count { get; set; }
        public clsEmployee ThisEmployee { get; set; }
    }
}