using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class EDefault : System.Web.UI.Page
{
    protected ListBox lstEmp;
    protected Label lblError;
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

        //lstEmployees.DataSource = Employees.EmployeeList;
        //set the name of the primary filed
        lstEmp.DataValueField = "EmployeeNo";
        lstEmp.DataValueField = "EmployeeFirstName";
        //bind the data yo the list
        lstEmp.DataBind();

    }




    
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEDAddEmployee_Click(object sender, EventArgs e)
        {
            //var to store varible
            Int32 EmployeeNo;
            //if a record has been selected from the list
            if (   lstEmp.SelectedIndex != -1)
            {
                //get the PK valeu of the record to deleate
                EmployeeNo = Convert.ToInt32(lstEmp.SelectedValue);
                //store -1 into the session object to indicate this is a new record
                Session["EmployeeNo"] = -1;
                //redirect to he data entery page
                Response.Redirect("EmployeesAdd.aspx");
                //get the primary key
            }
            else
            {
                //if no record
                //display error
                lblError.Text = "Please select a record to be deleated from the list";
            }

        }

        protected void btnEDDeleteEmployee_Click1(object sender, EventArgs e)
        {

        }

        protected void btnEDEditEmployee_Click2(Object sender, EventArgs e)
    {
        //var to store the pk value of the record to be edited
        Int32 PK;
        //IF THE RECORD HAS BEEN SELECYED FROM THE LIST
        if (lstEmp.SelectedIndex != -1)
        {
            //get the primary key vaklye if the record to be edited
            PK = Convert.ToInt32(lstEmp.SelectedValue);
            //store the data in the ession object
            Session["EmployeeNo"] = PK;
            Response.Redirect("EmployeesAdd.aspx");

        }
        else //if no record has been selsected
        {
            //display an error
            lblError.Text = "Please Select a record to deleate from the list";
        }
    }

    }
