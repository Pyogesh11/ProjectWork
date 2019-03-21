using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event of the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box 
            DisplayGames();
        }
    }
    void DisplayGames()
    {
        //create an instance of the county collection 
        MyClassLibrary.clsGamesCollection Games = new MyClassLibrary.clsGamesCollection();
        //set the data source to the list of counties in the collection 
        lstGames.DataSource = Games.Gameslist;
        //set the name of the primary key 
        lstGames.DataValueField = "Game_ID";
        //set the data field to display 
        lstGames.DataTextField = " ";
        //bind the data for the list
        lstGames.DataBind();

    }

    protected void lstGames_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["Game_ID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("AddGame.aspx");

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 Game_ID;
        //if a record hs been selected from the list
        if (lstGames.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            Game_ID = Convert.ToInt32(lstGames.SelectedValue);
            //store the data in the session object 
            Session["Game_ID"] = Game_ID;
            //redirect to the delete page
            Response.Redirect("DeleteGame.aspx");
        }
        else
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the rpimary key vallue of the record to be edited 
        Int32 Game_ID;
        //if a record has ben selected from the list 
        if (lstGames.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            Game_ID = Convert.ToInt32(lstGames.SelectedValue);
            //store the data in the session object 
            Session["Game_ID"] = Game_ID;
            //redirct to the edit page
            Response.Redirect("AddGame.aspx");
        }
        else //f no record has been selected 
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}