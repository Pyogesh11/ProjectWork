using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstGame
    { 
    
        //good test data 
        //create some test data to pass to the method
        String Game_Description = "My descrption";
        String Game_Name = "This Game";
        string Game_Quantity = "26";
        String Platform = "xbox";
        string Supplier_ID = "25";

            
    
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
            Int32 TestData = 21;
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
            Int32 Game_ID = 1;
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
            Int32 Game_ID = 1;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Game_ID != 1)
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
            Int32 Game_ID = 1;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Supplier_ID != 21)
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
            Int32 Game_ID = 1;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Game_Name != "Areeb")
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
            Int32 Game_ID = 1;
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
            Int32 Game_ID = 1;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Game_Quantity != 25)
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
            Int32 Game_ID = 1;
            //invoke the method 
            Found = AGame.Find(Game_ID);
            //check the game ID        
            if (AGame.Platform != "Xbox")
            {
                OK = false;
            }
            //test to see that the results is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instanc eof the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_NameMinLessOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Name = "a";//this should trigger an error 
            
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void Game_NameMin()
        {
            //cretae an instnac eof the class we want to create 
            clsGames AGame = new clsGames();
            //boolean variable to store the result 
            String Error = "";
            //create some test data to pass to the method
            String Game_Name = "aa";//this should pass
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void Game_NameMinPlusOne()
        {
            //cretae an instnac eof the class we want to create 
            clsGames AGame = new clsGames();
            //boolean variable to store the result 
            String Error = "";
            //create some test data to pass to the method
            string Game_Name = "aaa";//this should pass
            Error = AGame.Valid(this.Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void Game_NameMaxLessOne()
        {
            //create an instance of the class you want to create 
            clsGames AGame = new clsGames();
            //boolean variable to store the result of the validaiton 
            String Error = "";
            //create some test data to pass to the method 
            String Game_Name = "";
            Game_Name = Game_Name.PadRight(49, 'a');//this test should pass 
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //tets to see the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Game_NameMax()
        {
            //create an instance of the class you want to create 
            clsGames AGame = new clsGames();
            //boolean variable to store the result of the validaiton 
            String Error = "";
            //create some test data to pass to the method 
            String Game_Name = "";
            Game_Name = Game_Name.PadRight(50, 'a');//this test should pass 
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //tets to see the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Game_NameMid()
        {
            //create an instance of the class you want to create 
            clsGames AGame = new clsGames();
            //boolean variable to store the result of the validaiton 
            String Error = "";
            //create some test data to pass to the method 
            String Game_Name = "";
            Game_Name = Game_Name.PadRight(25, 'a');//this test should pass 
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //tets to see the result is correct 
            Assert.AreEqual(Error, "");
        }
      
        [TestMethod]
        public void Game_NameMaxPlusOne()
        {
            //create an instance of the class you want to create 
            clsGames AGame = new clsGames();
            //boolean variable to store the result of the validaiton
            String Error = "";
          //create some test data to pass to the method 
            String Game_Name = "";
            Game_Name = Game_Name.PadRight(51, 'a');//this test should pass 
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //tets to see the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Game_NameExtremeMax()
        {
            //create an instance of the class we want to ceate 
            clsGames AGame = new clsGames();
            //string variabe to tore any error message 
            string Error = "";
            //create some test method to pass to the method
            string Game_Name = "";
            Game_Name = Game_Name.PadRight(500,'a');
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test t see that the result is ok
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Game_DescriptionMinLessOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Description = "aaaa";//this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Game_DescriptionMin()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Description = "aaaaa";//this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_DescriptionMinplusOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Description = "aaaaaa";//this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_DescriptionMaxLessOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Description = "";
            Game_Description = Game_Description.PadRight(99, 'a');   //this should be ok 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_DescriptionMax()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Description = "";
            Game_Description = Game_Description.PadRight(100, 'a'); //this should be okay
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_DescriptionMaxPlusOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Description = "";
            Game_Description = Game_Description.PadRight(101, 'a'); //this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Game_DescriptionMid()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Description = "";
            Game_Description = Game_Description.PadRight(50, 'a'); //this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_QuantityMinLessOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some test data to pass to the method 
            String Game_Quantity = "";//this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_QuantityMin()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Quantity = "a";//this should work
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_QuantityMinplusOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Quantity = "aa";//this should work
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_QuantityMaxLessOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Quantity = "";
            Game_Quantity = Game_Quantity.PadRight(999, 'a');   //this should work 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_QuantityMax()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Quantity = "";
            Game_Quantity = Game_Quantity.PadRight(1000, 'a');    //this should work
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Game_QuantityMaxPlusOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Quantity = "";
            Game_Quantity = Game_Quantity.PadRight(1001, 'a');   //this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Game_QuantityMid()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Game_Quantity = "";
            Game_Quantity = Game_Quantity.PadRight(500, 'a');    //this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PlatformMinLessOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some test data to pass to the method 
            String Platform = ""; //this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PlatformMin()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Platform = "aa";//this should work
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PlatformMinplusOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Platform = "aaa";//this should work
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PlatformMaxLessOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Platform = "";
            Platform = Platform.PadRight(99, 'a');   //this should work 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PlatformMax()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Platform = "";
            Platform = Platform.PadRight(100, 'a');    //this should work
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PlatformMaxPlusOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Platform = "";
            Platform = Platform.PadRight(101, 'a');   //this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PlatformMid()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Platform = "";
            Platform = Platform.PadRight(50, 'a');    //this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Supplier_IDMinLessOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some test data to pass to the method 
            String Supplier_ID = ""; //this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Supplier_IDMin()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Supplier_ID = "a";//this should work
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Supplier_IDMinplusOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Supplier_ID = "aa";//this should work
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see hat the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Supplier_IDMaxLessOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Supplier_ID = "";
            Supplier_ID = Supplier_ID.PadRight(199, 'a');   //this should work 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Supplier_IDMax()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Supplier_ID = "";
            Supplier_ID = Supplier_ID.PadRight(200, 'a');    //this should work
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void Supplier_IDMaxPlusOne()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Supplier_ID = "";
            Supplier_ID = Supplier_ID.PadRight(201, 'a');   //this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void Supplier_IDMid()
        {
            //create an insatnce of the class we want to create 
            clsGames AGame = new clsGames();
            //string variable to storee any error message 
            String Error = "";
            //create some tst data to pass to the method 
            String Supplier_ID = "";
            Supplier_ID = Supplier_ID.PadRight(100, 'a');    //this should trigger an error 
            //invoke the method
            Error = AGame.Valid(Game_Name, Game_Description, Game_Quantity, Platform, Supplier_ID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");

        }

















    }
}

