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
                mEmployeeList = value; 
            }




        }


        public int Count
        {
            get
            {
                //RETURN THE COUNT F THE LIST
                return mEmployeeList.Count;
            }
            set
            {
                //we shall wor bout this later
            }
        }
       
        public clsEmployee ThisEmployee { get; set; }



        //constuctuer fr the class
        public clsEmployeeCollection()
        {
            clsEmployee TestItem = new clsEmployee();
            //seting the prameters
            TestItem.EmployeeNo = 6;
            TestItem.EmployeeFirstName = "Crona";
            TestItem.EmployeeSurName = "Maximus;";
            TestItem.EmployeeContactNo = "07364736261";
            TestItem.EmployeeEmail = "Crona@gmail.com";
            //add the item to the test list
            mEmployeeList.Add(TestItem);
            //seting the prameters
            TestItem.EmployeeNo = 7;
            TestItem.EmployeeFirstName = "Prita";
            TestItem.EmployeeSurName = "Sokanji;";
            TestItem.EmployeeContactNo = "07726389431";
            TestItem.EmployeeEmail = "Crona@gmail.com";
            //add the item to the test list
            mEmployeeList.Add(TestItem);

        }

        



    }
}