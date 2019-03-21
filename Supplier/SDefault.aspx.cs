using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class SDefault : System.Web.UI.Page
{
    //varaible to store the primary key with page level scope
    Int32 Supplier_Id;
    protected void Page_Load(object sender, EventArgs e)

    {
        //if this is the first time the page is displayed
        Supplier_Id = Convert.ToInt32(Session["Supplier_Id"]);
        if (IsPostBack == false)
        {
            //populate the list of suppliers
            DisplaySuppliers();

        }
    }
 
        void DisplaySuppliers()
        {
            //create an instance of the County collection
            MyClassLibrary.clsSupplierCollection Suppliers = new MyClassLibrary.clsSupplierCollection();
            //set the data source to the list of counties in collection 
            lstSuppliers.DataSource = Suppliers.SupplierList;
            //set the name of the primary key 
            lstSuppliers.DataValueField = "Supplier_Id";
            //set the data field to display
            lstSuppliers.DataTextField = "Supplier_Name";
            //bind the data to the list
            lstSuppliers.DataBind();
        }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        //display only GymEquipment Matching the text in the Body part text box
       //DisplaySuppliers(txtSearch.Text);
    }


    //event handler for the add button
    protected void btnAddSupplier_click(object sender, EventArgs e)
    {
        //stroe -1 into the session object to indicate this is a new record
        Session["Supplier_Id"] = -1;
        //redirect to the data entry page
        Response.Redirect("AddSupplier.aspx");
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {

    }

    protected void btnDeleteSupplier_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 Supplier_Id;
        //if a record has been selected from the list
        if (lstSuppliers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            Supplier_Id = Convert.ToInt32(lstSuppliers.SelectedValue);
            //store the data in the session object
            Session["Supplier_Id"] = Supplier_Id;
            //redirect to the delete page
            Response.Redirect("SDefault.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";

        }
    }

    protected void btnEditSupplier_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 Supplier_Id;
        //if a record has been selected from the list
        if (lstSuppliers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            Supplier_Id = Convert.ToInt32(lstSuppliers.SelectedValue);
            //store the data in the session object
            Session["Supplier_Id"] = Supplier_Id;
            //redirect to the delete page
            Response.Redirect("AddSupplier.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnAddSupplier_Click(object sender, EventArgs e)
    {
        // this line of code redirects back to the main page
        Response.Redirect("AddSupplier.aspx?ItemNo=-1");
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        //display all Supplier
        //DisplaySuppliers("");
        //string txtSearch;
    }
}
