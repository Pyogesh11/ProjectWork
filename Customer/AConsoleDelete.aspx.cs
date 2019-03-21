using MyClassLibrary;
using System;

public partial class Delete : System.Web.UI.Page

{   //var to store primary key
    Int32 ConsoleNo;
    //event handler for load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //gets number of consoles to be deleted
        ConsoleNo = Convert.ToInt32(Session["ConsoleNo"]);
    }
    void DeleteAddress()
    {
        //function to delete selected record
        clsConsoleCollection Console = new clsConsoleCollection();
        //find record to delete
        Console.ThisConsole.Find(ConsoleNo);
        //delete record
        Console.Delete();
    }

    protected void ButtonConsoleDeleteYes_Click(object sender, EventArgs e)
    {
        //delete record
        DeleteAddress();
        //redirect back to main page
        Response.Redirect("Default.aspx");
    }
}