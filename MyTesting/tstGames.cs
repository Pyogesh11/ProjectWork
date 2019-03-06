using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstGame
    {
        [TestMethod]
        public void InstanceOK()

        {
            //ceate an instanc eof the class we want to create 
            clsGames AGame = new clsGames();
            Assert.IsNotNull(AGame);
        }
        [TestMethod]
        public void Game_NamePropertyOK()
        {
            clsGames AGame = new clsGames();
            //create some test data to assighn to the property
            string TestData = "Areeb";
            //assighn the data to the property
            AGame.Game_Name = TestData;
            Assert.AreEqual(AGame.Game_Name, TestData);

        }
        [TestMethod]
        public void Game_DescriptionPropertyOK()
        {
            clsGames AGame = new clsGames();
            //create some test data to assighn to the property
            string TestData = "This is my Test data";
            //assighn the data to the property
            AGame.Game_Description = TestData;
            Assert.AreEqual(AGame.Game_Description, TestData);
        }

        [TestMethod]
        public void Game_QuantityPropertyOK()
        {
            clsGames AGame = new clsGames();
            //create some test data to assighn to the property
            Int32 TestData = 25;
            //assighn the data to the property
            AGame.Game_Quantity = TestData;
            Assert.AreEqual(AGame.Game_Quantity, TestData);
        }
        [TestMethod]
        public void PlatformPropertyOK()
        {
            clsGames AGame = new clsGames();
            //create some test data to assighn to the property
            string TestData = "Xbox";
            //assighn the data to the property
            AGame.Platform = TestData;
            Assert.AreEqual(AGame.Platform, TestData);
        }
        [TestMethod]
        public void Supplier_IDPropertyOK()
        {
            clsGames AGame = new clsGames();
            //create some test data to assighn to the property
            Int32 TestData = 1;
            //assighn the data to the property
            AGame.Supplier_ID = TestData;
            Assert.AreEqual(AGame.Supplier_ID, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsGames AGame = new clsGames();
            //boolean variable to store the result of the VALIDATING 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Game_ID = 21;
            //invoke the method
            Found = AGame.Find(Game_ID);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }
        public Boolean Find(int Game_ID)
        {
            //always return true
            return true;
        }



        [TestMethod]
        public void TestGame_IDFound()
        {
            //create an instance of the class we want to create
            clsGames AGame = new clsGames();
            //boolean variable to store result of the search 
            Boolean Found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 Game_ID = 21;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Game_ID != 21)
            {
                OK = false;
            }
            //test to see that the results is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestSupplier_IDFound()
        {
            //create an instance of the class we want to create
            clsGames AGame = new clsGames();
            //boolean variable to store result of the search 
            Boolean Found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 Game_ID = 21;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Supplier_ID != 1)
            {
                OK = false;
            }
            //test to see that the results is correct 
            Assert.IsTrue(OK);
        }
        public void TestGame_NameFound()
        {
            //create an instance of the class we want to create
            clsGames AGame = new clsGames();
            //boolean variable to store result of the search 
            Boolean Found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 Game_ID = 21;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Game_Name != "Test Game")
            {
                OK = false;
            }
            //test to see that the results is correct 
            Assert.IsTrue(OK);
        }
        public void TestGame_DecriptionFound()
        {
            //create an instance of the class we want to create
            clsGames AGame = new clsGames();
            //boolean variable to store result of the search 
            Boolean Found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 Game_ID = 21;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Game_Description != "Test description for this property")
            {
                OK = false;
            }
            //test to see that the results is correct 
            Assert.IsTrue(OK);
        }
        public void TestGame_QuantityFound()
        {
            //create an instance of the class we want to create
            clsGames AGame = new clsGames();
            //boolean variable to store result of the search 
            Boolean Found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 Game_ID = 21;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Game_Quantity != 10)
            {
                OK = false;
            }
            //test to see that the results is correct 
            Assert.IsTrue(OK);
        }
        public void TestPlatformFound()
        {
            //create an instance of the class we want to create
            clsGames AGame = new clsGames();
            //boolean variable to store result of the search 
            Boolean Found = false;
            //boolean variable to record if data is okay
            Boolean OK = true;
            // create some test data to use with the method 
            Int32 Game_ID = 21;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Platform != "PlayStation4")
            {
                OK = false;
            }
            //test to see that the results is correct 
            Assert.IsTrue(OK);
        }

    }
}

