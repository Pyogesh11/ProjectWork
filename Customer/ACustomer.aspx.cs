using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class ACustomer : System.Web.UI.Page
{
    //declare to store the primary key with the page levle scope 
    Int32 CustomerID;

    //event handler for the page load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the  customer to be processed 
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        //if this is the first time the page is load
        if (IsPostBack == false)
        {
            //populate the list of counties
            DisplayCounties();
            //if we are not adding a new record
            if (CustomerID != -1)
            {
                //display the current data for the record 
                DisplayCustomer();
            }
        }
    }
    //function for adding new records
    void Add()
    {
        //create an instance of the customer store
        MyClassLibrary.clsCustomerCollection CustomerStore = new MyClassLibrary.clsCustomerCollection();
        //validate the data on the web form 
        string Error = CustomerStore.ThisCustomer.Valid(txtFirstName.Text, txtSurName.Text, txtStreet.Text, txtHouseNo.Text, txtPostCode.Text, txtPhoneNo.Text);
        //if the data is OK then add it to the object 
        if (Error == "")
        {
            //get the data entered by the user 
            CustomerStore.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerStore.ThisCustomer.SurName = txtSurName.Text;
            CustomerStore.ThisCustomer.Street = txtStreet.Text;
            CustomerStore.ThisCustomer.HouseNo = txtHouseNo.Text;
            CustomerStore.ThisCustomer.PostCode = txtPostCode.Text;
            CustomerStore.ThisCustomer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
            CustomerStore.ThisCustomer.Active = chkActive.Checked;
            CustomerStore.ThisCustomer.CountyNo = Convert.ToInt32(ddlCounty.SelectedValue);
            //add the record
            CustomerStore.Add();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problem with the data entered" + Error;
        }
    }

    //function for updating records 
    void Update()
    {
        //create an instance of the customer store
        MyClassLibrary.clsCustomerCollection CustomerStore = new clsCustomerCollection();
        //validate the data on the web form 
        string Error = CustomerStore.ThisCustomer.Valid(txtFirstName.Text, txtSurName.Text, txtStreet.Text, txtHouseNo.Text, txtPostCode.Text, txtPhoneNo.Text);
        //if the data is OK then add it to the object 
        if (Error == "")
        {
            //find the record to update 
            CustomerStore.ThisCustomer.Find(CustomerID);
            //get the data entered by the user 
            CustomerStore.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerStore.ThisCustomer.SurName = txtSurName.Text;
            CustomerStore.ThisCustomer.Street = txtStreet.Text;
            CustomerStore.ThisCustomer.HouseNo = txtHouseNo.Text;
            CustomerStore.ThisCustomer.PostCode = txtPostCode.Text;
            CustomerStore.ThisCustomer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
            CustomerStore.ThisCustomer.Active = chkActive.Checked;
            CustomerStore.ThisCustomer.CountyNo = Convert.ToInt32(ddlCounty.SelectedValue);
            //update the record 
            CustomerStore.Update();
            //all done so redirect back to the main page 
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problem with the data entered" + Error;
        }
    }

    //event handler for the ok button 
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //var to store any error messages
        string ErrorMsg;
        //create an instance of the customer class
        clsCustomerCollection CustomerStore = new clsCustomerCollection();
        //use the objects validation method to test the data
        ErrorMsg = CustomerStore.ThisCustomer.Valid(txtFirstName.Text, txtSurName.Text, txtStreet.Text, txtHouseNo.Text, txtPostCode.Text, txtPhoneNo.Text);
        //if there is no error message
        if (ErrorMsg == "")
        {
            //if we are adding a new record
            if (CustomerID == -1)
            {
                //set the first name property 
                CustomerStore.ThisCustomer.FirstName = txtFirstName.Text;
                //set the surname property 
                CustomerStore.ThisCustomer.SurName = txtSurName.Text;
                //set the street property
                CustomerStore.ThisCustomer.Street = txtStreet.Text;
                //set the house number property of the object
                CustomerStore.ThisCustomer.HouseNo = txtHouseNo.Text;
                //set the house no property 
                CustomerStore.ThisCustomer.HouseNo = txtHouseNo.Text;
                //set the post code property
                CustomerStore.ThisCustomer.PostCode = txtPostCode.Text;
                //set the county no
                CustomerStore.ThisCustomer.CountyNo = Convert.ToInt32(ddlCounty.SelectedValue);
                //set the active property
                CustomerStore.ThisCustomer.Active = chkActive.Checked;
                //invoke the add method
                CustomerStore.Add();
            }
            else//this is an existing record to update
            {
                //find the record to be updated
                //set the first name property 
                CustomerStore.ThisCustomer.FirstName = txtFirstName.Text;
                //set the surname property 
                CustomerStore.ThisCustomer.SurName = txtSurName.Text;
                //set the street property
                CustomerStore.ThisCustomer.Street = txtStreet.Text;
                //set the house number property of the object
                CustomerStore.ThisCustomer.HouseNo = txtHouseNo.Text;
                //set the house no property 
                CustomerStore.ThisCustomer.HouseNo = txtHouseNo.Text;
                //set the post code property
                CustomerStore.ThisCustomer.PostCode = txtPostCode.Text;
                //set the county no
                CustomerStore.ThisCustomer.CountyNo = Convert.ToInt32(ddlCounty.SelectedValue);
                //set the active property
                CustomerStore.ThisCustomer.Active = chkActive.Checked;
                //update the record with the new data
                CustomerStore.Update();
            }
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else//there are errors
        {
            //display the error message
            lblError.Text = ErrorMsg;
        }
    }
    void DisplayCustomer()
    {
        //create an instaance of th customer store
        clsCustomerCollection CustomerStore = new clsCustomerCollection();
        //find the record to update 
        CustomerStore.ThisCustomer.Find(CustomerID);
        //display the data for this record 
        txtFirstName.Text = CustomerStore.ThisCustomer.FirstName;
        txtSurName.Text = CustomerStore.ThisCustomer.SurName;
        txtHouseNo.Text = CustomerStore.ThisCustomer.HouseNo;
        txtPostCode.Text = CustomerStore.ThisCustomer.PostCode;
        txtPhoneNo.Text = CustomerStore.ThisCustomer.PhoneNo.ToString();
        chkActive.Checked = CustomerStore.ThisCustomer.Active;
        ddlCounty.SelectedValue = CustomerStore.ThisCustomer.CountyNo.ToString();
    }

    //function for populating the county drop down list 
    void DisplayCounties()
    {
        //create an instance of the Customer Collection
        MyClassLibrary.clsCountyCollection Counties = new MyClassLibrary.clsCountyCollection();
        //set the data source to the list of Customers in the collection
        ddlCounty.DataSource = Counties.AllCounties;
        //set the name of the primary key
        ddlCounty.DataValueField = "CountyNo";
        //set the data field to display
        ddlCounty.DataTextField = "County";
        //bind the data to the list
        ddlCounty.DataBind();
    }
    protected void ddlCounty_SelectedIndexChanged(object sender, EventArgs e)
    {
     
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("Default.aspx");
    }
}