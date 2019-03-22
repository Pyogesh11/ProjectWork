using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 CustomerID;

    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object 
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    //event handler for the yes button 
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delte the record 
        DeleteCustomer();
        //redirect back to the main page 
        Response.Redirect("Default.aspx");
    }

    void DeleteCustomer()
    {
        //function to delete the selected record 

        //create a new instance of the customer store 
        clsCustomerCollection CustomerStore = new clsCustomerCollection();
        //find the record to delete 
        CustomerStore.ThisCustomer.Find(CustomerID);
        //delete the record
        CustomerStore.Delete();
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }
}