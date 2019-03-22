using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page 
    protected void Page_Load(object sender, EventArgs e)
    {

        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();

        }
    }

    void DisplayCustomers()
    {
        //create an instance of the Customer Collection
        MyClassLibrary.clsCustomerCollection Customers = new MyClassLibrary.clsCustomerCollection();
        //set the data source to the list of Customers in the collection
        lstCustomers.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomers.DataValueField = "CustomerID";
        //set the data field to display
        lstCustomers.DataTextField = "PostCode";
        //bind the data to the list
        lstCustomers.DataBind();
    }


    protected void btnApply_Click(object sender, EventArgs e)
    {
        //display all Customers
        DisplayCustomers();
    }

    protected void btnDisplayAll_Click1(object sender, EventArgs e)
    {
        //dispplay all customers
        DisplayCustomers();
    }
    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["CustomerID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("ACustomer.aspx?CustomerID=-1");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key values of the record to be edited 
        Int32 CustomerID;
        //if a record has been selected from the list 
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to update page 
            Response.Redirect("ACustomer.aspx");
        }
        else //if no record has been selected 
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list 
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object 
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page 
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "please select a record to delete from the list";
        }
    }
}
