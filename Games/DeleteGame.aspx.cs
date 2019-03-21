using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class DeleteGame : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted 
    Int32 Game_ID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object 
        Game_ID = Convert.ToInt32(Session["Game_ID"]);

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record 
        Delete();
        //redirect back to the main page 

    }
    void Delete()
    {
        //function to delete selected record 
        //create a new instance of the address book 
        clsGamesCollection GamesStore = new clsGamesCollection();
        //find the record to delete 
        GamesStore.ThisGame.Find(Game_ID);
        //delete the record 
        GamesStore.Delete();
    }

        
    
}