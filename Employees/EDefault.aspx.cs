using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EDefault : System.Web.UI.Page
{
    //this function handles he load eveny fpr the page
    protected void page_Load(object sender, EventArgs e)
    {
        //if thid id the first tme the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayEmployees();

        }
    }

    void DisplayEmployees()
    {
        //THE REDLINE UNDER MYCLASSLIBARY, APPRENLTY THAT IS OK TILL PAGE 38 AND IT SHOULD RIGHT NOW WORK  BUT DONT KNOW
        //creating an instance of the class employee collection
        MyClassLibrary.clsEmployeeCollection Employees = new MyClassLibrary.clsEmployeeCollection();
        //set the data source to the list of the counties in the collectiom
        lstEDEmployees.DataSource = Employees.EmployeeList;
        //set the name of the primary filed
        lstEDEmployees.DataValueField = "EmployeeNo";
        lstEDEmployees.DataValueField = "EmployeeFirstName";
        //bind the data yo the list
        lstEDEmployees.DataBind();
        
    }





    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEDAddEmployee_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["EmployeeNo"] = -1;
        //redirect to he data entery page
        Response.Redirect("EmployeesAdd.aspx");
    }

    protected void btnEDDeleteEmployee_Click1(object sender, EventArgs e)
    {

    }
}