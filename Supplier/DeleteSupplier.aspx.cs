using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Delete : System.Web.UI.Page
{
    //var tp store the primary key value of the record to be deleted
    Int32 Supplier_Id;

    //event hamdler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be deleted from the session object
        Supplier_Id = Convert.ToInt32(Session["Supplier_Id"]);
    }

    void DeleteSupplier()
    {
        //function to delete the selected record
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to delete
        SupplierBook.ThisSupplier.Find(Supplier_Id);
        //delete the record
        SupplierBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteSupplier();
        //redirect back to the main page
        Response.Redirect("SDefault.aspx");
    }

}