using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;



public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayConsoles();
        }

        void DisplayConsoles()
        {
            MyClassLibrary.clsConsoleCollection Console = new MyClassLibrary.clsConsoleCollection();
            lstConsoles.DataSource = Console.ConsoleList;
            lstConsoles.DataValueField = "ConsoleNo";
            lstConsoles.DataTextField = "ConsoleName";
            lstConsoles.DataBind();
        }
    }

    protected void btnAddConsoles_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is new recrd
        Session["ConsoleNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AConsole.aspx");
    }

    protected void btnDeleteConsole_Click(object sender, EventArgs e)
    {
        Int32 ConsoleNo;
        if (lstConsoles.SelectedIndex != -1)
        {
            ConsoleNo = Convert.ToInt32(lstConsoles.SelectedValue);
            //store the data in session objct
            Session["ConsoleNo"] = ConsoleNo;
            //redirct to delete page
            Response.Redirect("Delete.aspx");

        }
        else  //if no record has been selectd
        {
            //display an error
            lblError.Text = "Please select a record to delete from list";

        }
    }

    protected void btnEditConsole_Click(object sender, EventArgs e)
    {
        //var to store primary key
        Int32 ConsoleNo;
        //if a record has been selected from list
        if (lstConsoles.SelectedIndex != -1)
        {
            //get primary key value of record to edit
            ConsoleNo = Convert.ToInt32(lstConsoles.SelectedValue);
            //store the data in session object
            Session["ConsoleNo"] = ConsoleNo;
            //redirect to edit page
            Response.Redirect("AConsole.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from list";
        }
    }
}