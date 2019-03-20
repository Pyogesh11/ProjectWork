<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EDefault.aspx.cs" Inherits="EDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Alpha Game </title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
       <div> 
         <!--this line of code is for border line.-->
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 554px; width: 882px">

             <!--this line of code is to create List Box.-->
            <asp:ListBox ID="lstEDEmployees" runat="server" style="z-index: 1; left: 176px; top: 190px; position: absolute; width: 249px; height: 216px;"></asp:ListBox>
            <!--this line of code is to create text box.-->
            <asp:TextBox ID="txtEDSearch" runat="server" style="z-index: 1; left: 177px; top: 155px; position: absolute; margin-bottom: 0px; width: 376px; height: 24px;" Text="Search Employee"></asp:TextBox>
            <!--this line of code is to create button.-->
            <asp:Button ID="btnEDSearch" runat="server" style="z-index: 1; left: 575px; top: 155px; position: absolute; height: 30px;" Text="Search" />      
           <asp:Button ID="btnEDClear" runat="server" style="z-index: 1; left: 644px; top: 155px; position: absolute; height: 30px; bottom: 369px; width: 61px;" Text="Clear" />
            
            
            
            <asp:Button ID="btnEDAddEmployee" runat="server" style="z-index: 1; left: 440px; top: 218px; position: absolute; width: 118px" Text="Add Employee" OnClick="btnEDAddEmployee_Click" />
            <asp:Button ID="btnEDEditEmployee" runat="server" style="z-index: 1; left: 442px; top: 265px; position: absolute; width: 118px" Text="Edit Employee" OnClick="btnEDEditEmployee_Click1" />
            <asp:Button ID="btnEDDeleteEmployee" runat="server" style="z-index: 1; left: 442px; top: 314px; position: absolute; width: 118px" Text="Delete Employee" OnClick="btnEDDeleteEmployee_Click1" />
            <!--this line of code is to create Lablel.-->
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 178px; top: 422px; position: absolute"></asp:Label>
            <!--this line of code is to create button.-->
            <asp:Button ID="btnEDHome" runat="server" style="z-index: 1; left: 99px; top: 90px; position: absolute; width: 110px" Text="Home" />
           
            <asp:Button ID="btnEDDisplay" runat="server" style="z-index: 1; left: 442px; top: 362px; position: absolute; width: 118px; height: 26px" Text="Display All" />
            <!--this line of code is to create label.-->
            <asp:Label ID="lblEmployee" runat="server" style="z-index: 1; left: 5px; top: 530px; position: absolute; width: 111px" Text="Supplier Page"></asp:Label>

            <br />
            <!--this line of code is to create header.-->
            <h1 style=" position: absolute; top: 34px; left: 377px;"> Employees</h1>

             
        </asp:Panel>
        </div>
    </form>
</body>
</html>
