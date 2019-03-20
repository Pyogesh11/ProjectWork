using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddGame : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            lblError.Text = "There were problems" + Error;
        }

        }
    }
