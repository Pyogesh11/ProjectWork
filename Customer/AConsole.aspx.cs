using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class AConsole : System.Web.UI.Page
{
    Int32 ConsoleNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //gets the number of consoles to process
        ConsoleNo = Convert.ToInt32(Session["ConsoleNo"]);
        if (IsPostBack == false){
            //populate consoles
            DisplayConsole();
            //if this is not a new record
            if(ConsoleNo != -1)
            {
                DisplayConsole();
            }
        }
    }
    //function for adding new records
    void Add()
    {
        MyClassLibrary.clsConsoleCollection Consoles = new MyClassLibrary.clsConsoleCollection();

        //validate the data on the web form
        String Error = Consoles.ThisConsole.Valid(TextBoxConsoleName.Text, TextBoxConsolePrice.Text, TextBoxConsoleManufacturer.Text, TextBoxConsoleStock.Text);
        //if data is OK then add it to object
        if (Error == "")
        {
            //gets data entered by user
            Consoles.ThisConsole.Name = TextBoxConsoleName.Text;
            Consoles.ThisConsole.Manufacturer = TextBoxConsoleManufacturer.Text;
            Consoles.ThisConsole.Price = Convert.ToInt32(TextBoxConsolePrice.Text);
            Consoles.ThisConsole.Stock = Convert.ToInt32(TextBoxConsoleStock.Text);
            //add records
            Consoles.Add();

        }
        else
        {
            //report error
            lblError.Text = "There was problms with the data entered " + Error;

        }
    }
    void Update()
    {
        MyClassLibrary.clsConsoleCollection Consoles = new MyClassLibrary.clsConsoleCollection();

        //validate the data on the web form
        String Error = Consoles.ThisConsole.Valid(TextBoxConsoleName.Text, TextBoxConsolePrice.Text, TextBoxConsoleManufacturer.Text, TextBoxConsoleStock.Text);
        //if data is OK then add it to object
        if (Error == "")
        {
            //finds data to update
            Consoles.ThisConsole.Find(ConsoleNo);
            //gets data entered by user
            Consoles.ThisConsole.Name = TextBoxConsoleName.Text;
            Consoles.ThisConsole.Manufacturer = TextBoxConsoleManufacturer.Text;
            Consoles.ThisConsole.Price = Convert.ToInt32(TextBoxConsolePrice.Text);
            Consoles.ThisConsole.Stock = Convert.ToInt32(TextBoxConsoleStock.Text);
            //Update records
            Consoles.Update();
            Response.Redirect("Default.aspx");

        }
        else
        {
            //report error
            lblError.Text = "There was problms with the data entered " + Error;

        }
    }
    void DisplayConsole()
    {
        clsConsoleCollection Consoles = new clsConsoleCollection();
        //find record to update
        Consoles.ThisConsole.Find(ConsoleNo);
        //display data for this record
        TextBoxConsoleName.Text = Consoles.ThisConsole.Name;
        TextBoxConsolePrice.Text = Consoles.ThisConsole.Price.ToString();
        TextBoxConsoleManufacturer.Text = Consoles.ThisConsole.Manufacturer;
        TextBoxConsoleStock.Text = Consoles.ThisConsole.Stock.ToString();


    }

    
    //event handler for OK
    protected void ButtonOKAConsole_Click(object sender, EventArgs e)
    {
        if (ConsoleNo == -1)
        {
            //add new record
            Add();
        }
        else
        {
            //updates record
            Update();
        }
        

    }

    protected void ButtonCancelAConsole_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}