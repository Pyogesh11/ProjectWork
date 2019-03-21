using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class EDelCheck : System.Web.UI.Page

{
    // var to store the pk which should be deleated
    Int32 EmployeeNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the employee to be deleated from this session
        EmployeeNo = Convert.ToInt32(Session["EmployeeNo"]);
    }
    void DeleteEmployee()
    {
        //function to deleate selected record
        //create an  new instance of employee
        clsEmployeeCollection EmployeeList = new clsEmployeeCollection();
        //find the recor to deleate
        EmployeeList.ThisEmployee.Find(EmployeeNo);
        //DELEATE YJE RECORD
        EmployeeList.Delete();
    }
    //EVENT HANDLER FPR YJE  BUTTN
    protected void btnYes_Click (object sender, EventArgs e)
    {
        //deleat  the record 
        DeleteEmployee();
        //redirect back to the main page
        Response.Redirect("EDefault.aspx");
    }
}