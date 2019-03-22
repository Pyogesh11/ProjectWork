using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class AddSupplier : System.Web.UI.Page
{
    //add a variable 
    Int32 Supplier_Id;

    //evennt handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            DisplayCounties();
        }
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


    void DisplaySupplier()
    {
        //create an instance of supplier book 
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to update 
        SupplierBook.ThisSupplier.Find(Supplier_Id);
        //display the data for this record
        txtSupplier_Address.Text = SupplierBook.ThisSupplier.Supplier_Address;
        txtSupplier_Email.Text = SupplierBook.ThisSupplier.Supplier_Email;
        txtSupplier_Name.Text = SupplierBook.ThisSupplier.Supplier_Name;
        txtSupplier_Phone_No.Text = SupplierBook.ThisSupplier.Supplier_Phone_No;
        ddlCounty.SelectedValue = SupplierBook.ThisSupplier.CountyNo.ToString();
        chkActive.Checked = SupplierBook.ThisSupplier.Active;
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the supplier
        MyClassLibrary.clsSupplierCollection SupplierBook = new MyClassLibrary.clsSupplierCollection();
        //validate the data on the web form
        string Error = SupplierBook.ThisSupplier.Valid(txtSupplier_Address.Text, txtSupplier_Email.Text, txtSupplier_Name.Text, txtSupplier_Phone_No.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            SupplierBook.ThisSupplier.Supplier_Address = txtSupplier_Address.Text;
            SupplierBook.ThisSupplier.Supplier_Email = txtSupplier_Email.Text;
            SupplierBook.ThisSupplier.Supplier_Name = txtSupplier_Name.Text;
            SupplierBook.ThisSupplier.Supplier_Phone_No = txtSupplier_Phone_No.Text;
            SupplierBook.ThisSupplier.Active = chkActive.Checked;
            SupplierBook.ThisSupplier.CountyNo = Convert.ToInt32(ddlCounty.SelectedValue);
            //add the record
            SupplierBook.Add();
            //all done so redirect back to he main page
            Response.Redirect("SDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problem with the data entered" + Error;
        }
    }

    //update functions
    void Update()
    
        {
            //create an instance of the supplier
            MyClassLibrary.clsSupplierCollection SupplierBook = new MyClassLibrary.clsSupplierCollection();
            //validate the data on the web form
            string Error = SupplierBook.ThisSupplier.Valid(txtSupplier_Address.Text, txtSupplier_Email.Text, txtSupplier_Name.Text, txtSupplier_Phone_No.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
            //find the record to update
            SupplierBook.ThisSupplier.Find(Supplier_Id);
            //get the data entered by the user
                SupplierBook.ThisSupplier.Supplier_Address = txtSupplier_Address.Text;
                SupplierBook.ThisSupplier.Supplier_Email = txtSupplier_Email.Text;
                SupplierBook.ThisSupplier.Supplier_Name = txtSupplier_Name.Text;
                SupplierBook.ThisSupplier.Supplier_Phone_No = txtSupplier_Phone_No.Text;
                SupplierBook.ThisSupplier.Active = chkActive.Checked;
                SupplierBook.ThisSupplier.CountyNo = Convert.ToInt32(ddlCounty.SelectedValue);
                //add the record
                SupplierBook.Add();
                //all done so redirect back to he main page
                Response.Redirect("SDefault.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problem with the data entered" + Error;
            }
        }
    

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (Supplier_Id == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
        //all done so redirect back to the main page
        Response.Redirect("SDefault.aspx");
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("SDefault.aspx");
    }

  
}
