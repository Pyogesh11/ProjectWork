using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace MyTesting
{
    [TestClass]
    public class tstGamesCollection
    {
        
        
        [TestMethod]
        public void InstanceOK()

        {
            //create an instance of the class we want to create
            clsGamesCollection AllGames = new clsGamesCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllGames);
        }
        [TestMethod]
        public void GamesListOK()
        {
            //create an instance of the class we want to create 
            clsGamesCollection AllGames = new clsGamesCollection();
            //create some test data to assign to the property 
            //crete some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsGames> TestList = new List<clsGames>();
            //add an item t the list 
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
            TestList.Add(TestItem);
            //assign the data to the property
            AllGames.Gameslist = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllGames.Gameslist, TestList);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsGamesCollection AllGames = new clsGamesCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be list of objects. 
            List<clsGames> TestList = new List<clsGames>();
            //add an item to the list 
            //create the item of test data
            clsGames TestItem = new clsGames();
            //set its properties
            TestItem.Game_ID = 1;
            TestItem.Game_Name = "Areeb";
            TestItem.Game_Description = "This is my test description";
            TestItem.Game_Quantity = 25;
            TestItem.Platform = "Xbox";
            TestItem.Supplier_ID = 21;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllGames.Gameslist = TestList;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllGames.Count, TestList.Count);


        }

        [TestMethod]
        public void ThisGamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsGamesCollection AllGames = new clsGamesCollection();
            //create some test data to assign to the property 
            clsGames TestGame = new clsGames();
            //set the properties of the test object 
            TestGame.Game_ID = 1;
            TestGame.Game_Name = "Areeb";
            TestGame.Game_Description = "This is my test data";
            TestGame.Game_Quantity = 25;
            TestGame.Platform = "Xbox";
            TestGame.Supplier_ID = 21;
            //assign the data to the property 
            AllGames.ThisGame = TestGame;
            //test to see that the values are equal 
            Assert.AreEqual(AllGames.ThisGame, TestGame);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsGamesCollection AllGames = new clsGamesCollection();
            //create th eitme of test data 
            clsGames TestItem = new clsGames();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Game_ID = 1;
            TestItem.Game_Name = "Areeb";
            TestItem.Game_Description = "This is my test data";
            TestItem.Game_Quantity = 31;
            TestItem.Platform = "Nintendo switch";
            TestItem.Supplier_ID = 11;
            //set this game to the test data 
            AllGames.ThisGame = TestItem;
            //add the record
            PrimaryKey  = AllGames.Add();
            //set the primary key of the tst data 
            TestItem.Game_ID = PrimaryKey;
            //find the rocrd 
            AllGames.ThisGame.Find(PrimaryKey);
            //test to see that the 2 values are the same 
            Assert.AreEqual(AllGames.ThisGame, TestItem);



        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //crate an instance of the class we want to create
            clsGamesCollection AllGames = new clsGamesCollection();
            //crate the item of test data 
            clsGames TestItem = new clsGames();

            //var to store the primry key 
            Int32 Primarykey = 0;
            //set its properties 
            TestItem.Game_ID = 1;
            TestItem.Game_Name = "Areeb";
            TestItem.Game_Description = "This is my tes data";
            TestItem.Game_Quantity = 25;
            TestItem.Platform = "PlayStation";
            TestItem.Supplier_ID = 21;
            //set this game to the test data 
            AllGames.ThisGame = TestItem;
            //add the record 
            Primarykey = AllGames.Add();
            // set the primary key of the test data 
            TestItem.Game_ID = Primarykey;
            //find the record 
            AllGames.ThisGame.Find(Primarykey);
            //delete the record 
            AllGames.Delete();
            //now find the record 
            Boolean Found = AllGames.ThisGame.Find(Primarykey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsGamesCollection AllGames = new clsGamesCollection();
            //create the item of test data 
            clsGames TestItem = new clsGames();
            //var to store the primry key 
            Int32 Primarykey = 0;
            //set its properties 
            TestItem.Game_ID = 1;
            TestItem.Game_Name = "Areeb";
            TestItem.Game_Description = "This is my tes data";
            TestItem.Game_Quantity = 25;
            TestItem.Platform = "PlayStation";
            TestItem.Supplier_ID = 21;
            //set this game to the test data 
            AllGames.ThisGame = TestItem;
            //add the record 
            Primarykey = AllGames.Add();
            // set the primary key of the test data 
            TestItem.Game_ID = Primarykey;
            //modify the test data
            TestItem.Game_ID = 2;
            TestItem.Game_Name = "Beera";
            TestItem.Game_Description = "This is'nt my test data";
            TestItem.Game_Quantity = 26;
            TestItem.Platform = "PlayStation4";
            TestItem.Supplier_ID = 22;
            //set the record based on the neew test data 
            AllGames.ThisGame = TestItem;
            //update the record 
            AllGames.Update();
            //find the record 
            AllGames.ThisGame.Find(Primarykey);
            // test to see this game matches the test data
            Assert.AreEqual(AllGames.ThisGame, TestItem);
        }





        



    }
}
