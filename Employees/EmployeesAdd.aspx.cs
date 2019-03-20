using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary; 
public partial class EmployeesAdd : System.Web.UI.Page
{
    


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void Add()
    {
        //create an instance of the employee
        clsEmployeeCollection EmployeeGroup = new clsEmployeeCollection();
        //validate the data on the web form
        string Error = EmployeeGroup.ThisEmployee.Valid(txtEAFA.Text, txtEAEmployeeSurName.Text, txtEAEmployeeContactNo.Text, txtEAEmployeeEmail.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            EmployeeGroup.ThisEmployee.EmployeeFirstName = txtEAFA.Text;
            EmployeeGroup.ThisEmployee.EmployeeSurName = txtEAEmployeeSurName.Text;
            EmployeeGroup.ThisEmployee.EmployeeContactNo = txtEAEmployeeContactNo.Text;
            EmployeeGroup.ThisEmployee.EmployeeEmail = txtEAEmployeeEmail.Text;

            EmployeeGroup.Add();
        }
        else
        {
            //REPOR AN ERROR
            lblEAError.Text = "There wwhere problems with the data entered" + Error;
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Add();
        //all done so redirect back to main page
        Response.Redirect("EDefult.aspx");
    }
}

//txtEAEmployeeFirstName
//txtEAEmployeeSurName
//txtEAEmployeeContactNo
//txtEAEmplloyeeEmail