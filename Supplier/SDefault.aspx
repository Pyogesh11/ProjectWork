<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SDefault.aspx.cs" Inherits="SDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>  
        <form id="form2" runat="server">
        <div> 
         <!--this line of code is for border line.-->
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 554px; width: 882px">

             <!--this line of code is to create List Box.-->
            <asp:ListBox ID="lstSuppliers" runat="server" style="z-index: 1; left: 176px; top: 190px; position: absolute; width: 249px; height: 216px;"></asp:ListBox>
            <!--this line of code is to create text box.-->
            <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 177px; top: 155px; position: absolute; margin-bottom: 0px; width: 376px; height: 24px;" Text="Search"></asp:TextBox>
            <!--this line of code is to create button.-->
            <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 575px; top: 155px; position: absolute; height: 30px;" Text="Search" OnClick="btnSearch_Click" />      
            <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 644px; top: 155px; position: absolute; height: 30px; bottom: 369px; width: 61px;" Text="Clear" />
            <asp:Button ID="btnAddSupplier" runat="server" style="z-index: 1; left: 440px; top: 218px; position: absolute; width: 118px" Text="Add Supplier" OnClick="btnAddSupplier_Click" />
            <asp:Button ID="btnEditSupplier" runat="server" style="z-index: 1; left: 442px; top: 265px; position: absolute; width: 118px" Text="Edit Supplier"  />
            <asp:Button ID="btnDeleteSupplier" runat="server" style="z-index: 1; left: 442px; top: 314px; position: absolute; width: 118px" Text="Delete Supplier" />
            <!--this line of code is to create Lablel.-->
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 178px; top: 422px; position: absolute"></asp:Label>
            <!--this line of code is to create button.-->
             <asp:Button ID="btnDisplay" runat="server" style="z-index: 1; left: 442px; top: 362px; position: absolute; width: 118px; height: 26px" Text="Display All" OnClick="btnDisplay_Click" />
             <!--this line of code is to create label.-->
             <asp:Label ID="lblSupplier" runat="server" style="z-index: 1; left: 5px; top: 530px; position: absolute; width: 111px" Text="Supplier Page"></asp:Label>
             <br />
             <!--this line of code is to create header.-->
             <h1 style=" position: absolute; top: 84px; left: 373px;">Supplier </h1>
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 179px; top: 90px; position: absolute; width: 110px" Text="Home" OnClick="btnHome_Click" />

             
        </asp:Panel>
        </div>
    </form>
</body>
</html>
