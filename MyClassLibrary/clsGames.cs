using System;

namespace MyClassLibrary
{
    public class clsGames
    {
        //private data member for the Game_ID property
        private Int32 mGame_ID;
        private Int32 mSupplier_ID;
        private string mGame_Name;
        private string mGame_description;
        private Int32 mGame_Quantity;
        private string mPlatform;


        
        
        public int Supplier_ID
        { get
            {
                //return the private data 
                return mSupplier_ID;

            }

            set
            {
                mSupplier_ID = value;
            }
                
                }
        public int Game_ID
        {
            get
            {
                //return the private data 
                return mGame_ID;
            }
            set
            {
                //set the value of the private dta amember
                mGame_ID = value;
            }
        }
        public string Game_Name
        {
            get
            {
                //return the private data 
                return mGame_Name;
            }
            set
            {
                mGame_Name= value;
            }
        }
        public string Game_Description
        {
            get
            {
                //return the private data 
                return mGame_description;
            }
            set
            {
                //set the private data 
                mGame_description = value;
            }
                }
        public int Game_Quantity
        {
            get
            {
                //return the private data 
                return mGame_Quantity;
            }
                set
            {
                //set the private data 
                mGame_Quantity = value;
            }
                }
        public string Platform
        {
            get
            {
                //return the private data
                return mPlatform;
            }
                 
                set
            {
                //set the private data 
                mPlatform = value;
            }
                }
















        public bool Find(int game_ID)
        {
           
           {
                mGame_ID = 21;
                mSupplier_ID = 1;
                mGame_Name = "Test Game";
                mGame_description = "Test Description for this property";
                mGame_Quantity = 10;
                mPlatform = "PlayStation4";

                //always return true 
            return true;
         }
 
        }
       




    }
}