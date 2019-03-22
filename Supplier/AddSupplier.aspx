<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddSupplier.aspx.cs" Inherits="AddSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <!--this line of code is for border line.-->
            <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 554px; width: 882px"> 
            <!--this line of code is to create button.-->
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 231px; top: 90px; position: absolute; width: 110px" Text="Home" />
            <asp:Label ID="lblSupplier" runat="server" style="z-index: 1; left: 5px; top: 530px; position: absolute; width: 111px" Text="Supplier Page"></asp:Label>
            <!--this line of code is to create text box.-->
            <asp:TextBox ID="txtSupplier_Id" runat="server" style="z-index: 1; left: 245px; top: 189px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplier_Name" runat="server" style="z-index: 1; left: 244px; top: 233px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplier_Address" runat="server" style="z-index: 1; left: 244px; top: 280px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplier_Email" runat="server" style="z-index: 1; left: 556px; top: 233px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplier_Phone_No" runat="server" style="z-index: 1; left: 557px; top: 281px; position: absolute"></asp:TextBox> 
            <!--this line of code is to create DropDown list.-->
            <asp:DropDownList ID="ddlCounty" runat="server" style="z-index: 1; left: 558px; top: 189px; position: absolute; height: 22px; width: 128px; bottom: 343px">
                <asp:ListItem>dsf</asp:ListItem>
                <asp:ListItem>sdf</asp:ListItem>
                <asp:ListItem>fdsf</asp:ListItem>
            </asp:DropDownList>
            <!--this line of code is to create lable.-->
            <asp:Label ID="lblSupplier_Id" runat="server" style="z-index: 1; left: 130px; top: 190px; position: absolute" Text="Supplier ID"></asp:Label>
            <asp:Label ID="lblSupplier_Name" runat="server" style="z-index: 1; left: 128px; top: 234px; position: absolute" Text="Supplier Name"></asp:Label>
            <asp:Label ID="lblSupplier_Address" runat="server" style="z-index: 1; left: 127px; top: 283px; position: absolute" Text="Supplier Address"></asp:Label>
            <asp:Label ID="lblCounty" runat="server" style="z-index: 1; left: 444px; top: 188px; position: absolute" Text="County"></asp:Label>
            <asp:Label ID="lblSupplier_Email" runat="server" style="z-index: 1; left: 444px; top: 234px; position: absolute" Text="Supplier Email"></asp:Label>
            <asp:Label ID="lblSupplier_Phone_No" runat="server" style="z-index: 1; left: 446px; top: 282px; position: absolute" Text="Phone No"></asp:Label>

               <!--this line of code is to create Button.-->
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 305px; top: 358px; position: absolute; width: 90px; height: 32px;" Text="OK"  />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 438px; top: 358px; position: absolute; width: 90px; height: 32px;" Text="Cancel" />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 389px; top: 407px; position: absolute"></asp:Label>
            <br />
            <!--this line of code is to create header.-->
            <h1 style=" position: absolute; top: 83px; left: 363px; right: 334px;"> Add Supplier </h1>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 387px; top: 320px; position: absolute" Text="Active"/>
        </asp:Panel>

        </div>
    </form>
</body>
</html>
