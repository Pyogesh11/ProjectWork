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
        {
            get
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
                mGame_Name = value;
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
            //reate an instace of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the game id to serach for 
            DB.AddParameter("@Game_ID", game_ID);
            //execture the stored procedure 
            DB.Execute("sproc_tblGames_FilterByGame_ID");
            //if one record is found (there shuld be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the data members to the private data memebrs 
                mGame_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Game_ID"]);
                mSupplier_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Supplier_ID"]);
                mGame_Name = Convert.ToString(DB.DataTable.Rows[0]["Game_Name"]);
                mGame_description = Convert.ToString(DB.DataTable.Rows[0]["Game_Description"]);
                mGame_Quantity = Convert.ToInt32(DB.DataTable.Rows[0]["Game_Quantity"]);
                mPlatform = Convert.ToString(DB.DataTable.Rows[0]["Platform"]);

                //always return true 
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating an error
                return false;
            }


        }

        
        public string Valid(string game_Name, string game_Description, String game_Quantity, string platform, String supplier_ID)
        {
            //create a string varibale to store the error
            String Error = "";
            //if  the game_name is blank
            if (game_Name.Length == 0)
            {
                //record the error
                Error = Error + "This field cannot be left blank";
            }
            if (game_Name.Length < 2)
            {
                //record the error 
                Error = Error + "This field can not have less than 2 characters";
            }
            //if the gane_Name is greater than 50 characters 
            if (game_Name.Length > 50)
            {
                //record the error
                Error = Error + "This field can not have more than 50 characters";
            }
            if (game_Description.Length == 0)
            {
                //record the rror 
                Error = Error + "This field cannot be blank";
            }
            if (game_Description.Length >100)
            {
                //record the error
                Error = Error + "This field can not have more than 100 characters";
            }
            if (game_Description.Length < 5 )
            {
                //Reocord the error 
                Error = Error + "This field can not have less than 5 characters";
            }
            if (game_Quantity.Length >1000)
            {
                //record the eror 
                Error = Error + "This field has too many characters";
            }
            if (platform.Length == 0 )
            {
                //record the rror 
                Error = Error + "This field cannot be blank";
            }
            if (platform.Length > 100)
            {
                //record the error
                Error = Error + "This field can not have more than 100 characters ";
            }
            if (supplier_ID.Length == 0) 
            {
                //record the error 
                Error = Error + "This field can not be blank";
            }
            if (supplier_ID.Length > 200)
            {
                //record the error 
                Error = Error + "This field can not have more than 200 characters";
            }


            //return any error message 
            return Error;
        }
    }
}