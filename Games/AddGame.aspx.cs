using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class AddGame : System.Web.UI.Page
{
    Int32 Game_ID;
    
    protected void Page_Load(object sender, EventArgs e)
    {
         Game_ID = Convert.ToInt32(Session["Game_ID"]);
        if (IsPostBack == false)
        {
            DisplayGames();
        }
    }
    void Add()
    {
        //create an instance of the games store
        MyClassLibrary.clsGamesCollection GamesStore = new MyClassLibrary.clsGamesCollection();
        //validate the data on the web form 
        String Error = GamesStore.ThisGame.Valid(txtGame_Name.Text, txtGame_Description.Text, txtGame_Quantity.Text, txtPlatform.Text, txtSupplier_ID.Text);
        //if the ata is ok then add it to the object 
        if (Error == "")
        {
            //get the data entered by the user 
            GamesStore.ThisGame.Game_Name = txtGame_Name.Text;
            GamesStore.ThisGame.Game_Description = txtGame_Description.Text;
            GamesStore.ThisGame.Game_Quantity = Convert.ToInt32(txtGame_Quantity.Text);
            GamesStore.ThisGame.Platform = txtPlatform.Text;
            GamesStore.ThisGame.Supplier_ID = Convert.ToInt32(txtSupplier_ID.Text);
            //add the record 
            GamesStore.Add();
        }

        else
        {
            //report an error 
            lblError.Text = "There was a problem" + Error;
        }

    }

    protected void btnGame_Name_Click(object sender, EventArgs e)
    {

    }

    
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (Game_ID == -1)
        {
            Add();
        }
        else
        {
            Update();
        }
        //add the new record 
        
        //Redirect back to main page
        Response.Redirect("Default.aspx");
    }

    protected void btnGame_ID_Click(object sender, EventArgs e)
    {

    }
    void Update()
    {
        //create an instance of the gamesstore
        clsGamesCollection GamesStore = new clsGamesCollection();
        //validate the data on the web form 
        String Error = GamesStore.ThisGame.Valid(txtGame_Name.Text, txtGame_Description.Text, txtGame_Quantity.Text, txtPlatform.Text, txtSupplier_ID.Text);
        //if the ata is ok then add it to the object 
        if (Error == "")
        {
            GamesStore.ThisGame.Find(Game_ID);
            //get the data entered by the user 
            GamesStore.ThisGame.Game_Name = txtGame_Name.Text;
            GamesStore.ThisGame.Game_Description = txtGame_Description.Text;
            GamesStore.ThisGame.Game_Quantity = Convert.ToInt32(txtGame_Quantity.Text);
            GamesStore.ThisGame.Platform = txtPlatform.Text;
            GamesStore.ThisGame.Supplier_ID = Convert.ToInt32(txtSupplier_ID.Text);
            //update the record 
            GamesStore.Update();
            Response.Redirect("Default.aspx");
        }

        else
        {
            //report an error 
            lblError.Text = "There was a problem" + Error;
        }

    }
    void DisplayGames()
    {
        //crete an instanc eof the games store
        clsGamesCollection GamesStore = new clsGamesCollection();
        //find the record to update 
        GamesStore.ThisGame.Find(Game_ID);
        //display the data for this record 
        txtGame_Name.Text = GamesStore.ThisGame.Game_Name;
        txtGame_Description.Text = GamesStore.ThisGame.Game_Description;
        txtGame_Quantity.Text = GamesStore.ThisGame.Game_Quantity.ToString();
        txtPlatform.Text = GamesStore.ThisGame.Platform;
        txtSupplier_ID.Text = GamesStore.ThisGame.Supplier_ID.ToString();
    }





    


    protected void txtGame_ID_TextChanged(object sender, EventArgs e)
    {

    }
}
    
