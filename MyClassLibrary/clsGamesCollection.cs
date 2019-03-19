using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsGamesCollection
    {
        List<clsGames> mGamesList = new List<clsGames>();

        public List<clsGames> Gameslist
        {
            get

            {
                //return the private data 
                return mGamesList;
            }
            set
            {
                //set the private data 
                mGamesList = value;
            }
                }
        public int Count
        {
            get
            {
                //return the count of the list 
                return mGamesList.Count;
            }
                set
            {
                //we shall worry about this later 
            }
                }



        //contstructor for the class
        //  public clsGamesCollection()

        // {

        //create the item of test data
        //   clsGames TestItem = new clsGames();
        //set its properties 
        //   TestItem.Game_ID = 1;
        //   TestItem.game_Name = "Areeb";
        //   TestItem.Game_Description = "This is my test data";
        //   TestItem.Game_Quantity = 25;
        //   TestItem.Platform = "Xbox";
        //   TestItem.Supplier_ID = 21;
        //add the item to the test list 
        //   mGamesList.Add(TestItem);
        //re initialize the object for some new data
        //    TestItem = new clsGames();
        //set its properties 
        //  TestItem.Game_ID = 2;
        //  TestItem.game_Name = "Panjwani";
        //  TestItem.Game_Description = "Heres another description";
        //  TestItem.Game_Quantity = 15;
        //  TestItem.Platform = "PlayStaion";
        // TestItem.Supplier_ID = 22;
        //add the item to the test list 
        //  mGamesList.Add(TestItem);
        //  }
        //contrsuctor for the class 
       public clsGamesCollection()
        {
            //var for the index 
             Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblGames_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //while they are records to porcess 
            while (Index < RecordCount)
            {
                //create a blank address 
                clsGames AGame = new clsGames();
                //read in the fields from the current record

            }
        }








        public clsGames ThisGame { get; set; }
    }
}