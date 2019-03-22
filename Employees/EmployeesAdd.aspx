<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeesAdd.aspx.cs" Inherits="EmployeesAdd" %>

<!DOCTYPE html>
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtEAEmplloyeeEmail_TextChanged(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Alpha Game</title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 554px; width: 882px">
            
            <asp:Button ID="btnEAHome" runat="server" style="z-index: 1; left: 99px; top: 90px; position: absolute; width: 110px" Text="Home" />
           
            <asp:Label ID="lblSupplier" runat="server" style="z-index: 1; left: 5px; top: 530px; position: absolute; width: 111px" Text="Supplier Page"></asp:Label>
        

            <!-- Employee FirstName Boxes and lables --> 
            <asp:TextBox ID="txtEAFA" runat="server" style="z-index: 1; left: 267px; top: 233px; position: absolute; width: 155px;"></asp:TextBox>
            <asp:Label ID="lblEAEmployeeFirstName" runat="server" style="z-index: 1; left: 128px; top: 234px; position: absolute" Text="Employee First Name"></asp:Label>
               
                 <!-- Employee SurName Boxes and lables --> 
            <asp:Label ID="lblEAEmployeeSurName" runat="server" style="z-index: 1; left: 127px; top: 283px; position: absolute" Text="Employee Sur Name"></asp:Label>
             <asp:TextBox ID="txtEAEmployeeSurName" runat="server" style="z-index: 1; left: 266px; top: 281px; position: absolute; width: 161px; margin-top: 0px;"></asp:TextBox>   
                 
            <!-- Employee Contact Number Boxes and lables --> 
            <asp:TextBox ID="txtEAEmployeeContactNo" runat="server" style="z-index: 1; left: 610px; top: 280px; position: absolute; width: 175px;"></asp:TextBox>
            <asp:Label ID="lblPhone_No" runat="server" style="z-index: 1; left: 506px; top: 280px; position: absolute; width: 79px;" Text="Phone No"></asp:Label>
                 
            <!--Employee email text box and lable -->
                 <asp:TextBox ID="txtEAEmployeeEmail" runat="server" style="z-index: 1; left: 609px; top: 236px; position: absolute; width: 168px;" OnTextChanged="txtEAEmployeeEmail_TextChanged"></asp:TextBox>
                 <asp:Label ID="lblEAEmployeeEmail" runat="server" style="z-index: 1; left: 504px; top: 234px; position: absolute" Text="Employee Email"></asp:Label>
                
                
                 <!-- Lable Error --> 
               <asp:Label ID="lblEAError" runat="server" ForeColor="Red" style="z-index: 1; left: 388px; top: 394px; position: absolute"></asp:Label>
                 
                 
                 <!-- The buttons on this page --> 
                 <asp:Button ID="btnAdd" runat="server" OnClick="btnUpdate_Click" style="z-index: 1; left: 305px; top: 347px; position: absolute; width: 90px; height: 32px;" Text="Add" />
                 <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 438px; top: 348px; position: absolute; width: 90px; height: 32px;" Text="Cancel" />

             </asp:Panel>

        </div>
    </form>
</body>
</html>