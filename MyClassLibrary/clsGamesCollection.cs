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
        public clsGamesCollection()
        {

            //create the item of test data
            clsGames TestItem = new clsGames();
            //set its properties 
            TestItem.Game_ID = 1;
            TestItem.Game_Name = "Areeb";
            TestItem.Game_Description = "This is my test data";
            TestItem.Game_Quantity = 25;
            TestItem.Platform = "Xbox";
            TestItem.Supplier_ID = 21;
            //add the item to the test list 
            mGamesList.Add(TestItem);
            //re initialize the object for some new data
            TestItem = new clsGames();
            //set its properties 
            TestItem.Game_ID = 2;
            TestItem.Game_Name = "Panjwani";
            TestItem.Game_Description = "Heres another description";
            TestItem.Game_Quantity = 15;
            TestItem.Platform = "PlayStaion";
            TestItem.Supplier_ID = 22;
            //add the item to the test list 
            mGamesList.Add(TestItem);
        }








        public clsGames ThisGame { get; set; }
    }
}