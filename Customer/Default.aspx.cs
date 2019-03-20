using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //variable to store the primary key with page level scope 
    Int32 CustomerID;
    //event handler for the page load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed 
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //populate the list of customers
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
        lstCustomers.DataTextField = "FirstName";
        //bind the data to the list
        lstCustomers.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1into the session object to indicate this is a new record 
        Session["CustomerID"] = -1;
        //redirect to the data entry page 
        Response.Redirect("ACustomer.aspx");
    }

    //event handler for the delete button
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

    protected void btnUpdate_Click(object sender, EventArgs e)
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
}