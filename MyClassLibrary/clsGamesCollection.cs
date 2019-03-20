using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsGamesCollection
    {

        List<clsGames> mGamesList = new List<clsGames>();
        //private data member thisgame
        clsGames mThisgame = new clsGames();
        //public property or ThisAdress
       

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
                AGame.Game_Name = Convert.ToString(DB.DataTable.Rows[Index]["Game_Name"]);
                AGame.Game_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Game_ID"]);
                AGame.Game_Description = Convert.ToString(DB.DataTable.Rows[Index]["Game_Description"]);
                AGame.Game_Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Game_Quantity"]);
                AGame.Platform = Convert.ToString(DB.DataTable.Rows[Index]["Platform"]);
                AGame.Supplier_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Supplier_ID"]);



            }
        }
        public clsGames ThisGame
        {
            get
            {
                //return the private data
                return mThisgame;
            }
            set
            {
                //set the private data 
                mThisgame = value;
            }
        }
        public int Add()
        {
            //ads a new record to the database based on the values of ThisGame
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("Game_Name", mThisgame.Game_Name);
            DB.AddParameter("@Game_Description", mThisgame.Game_Description);
            DB.AddParameter("@Game_Quantity", mThisgame.Game_Quantity);
            DB.AddParameter("@Game_Name", mThisgame.Platform);
            DB.AddParameter("@Game_Name", mThisgame.Supplier_ID);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblGames_Insert");
            




        }








        
    }
}