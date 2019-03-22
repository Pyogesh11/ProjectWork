<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GameConsoles</title>
    <link href="GameConsolesPic.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
         body
        {
            background-image: url("101345-simple_background-gradient-748x421.jpg");
            background-repeat: repeat-x;
        }
        .auto-style1 {
            position: absolute;
            top: 336px;
            left: 363px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 305px;
            left: 7px;
            z-index: 1;
            width: 251px;
        }
        .auto-style3 {
            position: absolute;
            top: 325px;
            left: 4px;
            z-index: 1;
            width: 239px;
        }
        .auto-style4 {
            height: 401px;
            width: 704px;
        }
        .auto-style5 {
            position: absolute;
            top: 267px;
            left: 358px;
            z-index: 1;
            width: 91px;
            height: 31px;
        }
        .auto-style6 {
            position: absolute;
            top: 268px;
            left: 458px;
            z-index: 1;
            height: 31px;
            width: 90px;
        }
        .auto-style7 {
            position: absolute;
            top: 371px;
            left: 3px;
            z-index: 1;
            width: 90px;
            height: 31px;
        }
        .auto-style8 {
            position: absolute;
            top: 372px;
            z-index: 1;
            width: 90px;
            height: 31px;
            left: 99px;
            right: 703px;
        }
        .auto-style9 {
            position: absolute;
            top: 371px;
            z-index: 1;
            left: 199px;
            width: 90px;
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style4">
        <div>
            <br />
            <asp:TextBox ID="txtPostCode" runat="server" CssClass="auto-style3" BackColor="White" BorderColor="Black"></asp:TextBox>
        <asp:ListBox ID="lstCustomers" runat="server" Height="267px" Width="323px" BackColor="#FFFFCC"></asp:ListBox>
            <asp:Label ID="lblPostCode" runat="server" CssClass="auto-style2" Text="Please Enter a PostCode"></asp:Label>
        <p>
            <asp:Button ID="btnDisplayAll" runat="server" BackColor="#FFFFCC" BorderStyle="Groove" CssClass="auto-style6" OnClick="btnDisplayAll_Click1" Text="DisplayAll" />
            </p>
        </div>    
        <asp:Label ID="lblError" runat="server" CssClass="auto-style1" Text="lblError"></asp:Label>
        <asp:Button ID="btnApply" runat="server" BackColor="#FFFFCC" BorderStyle="Groove" CssClass="auto-style5" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnAdd" runat="server" BackColor="#FFFFCC" BorderColor="Black" BorderStyle="Groove" CssClass="auto-style7" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" BackColor="#FFFFCC" BorderColor="Black" CssClass="auto-style8" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" BackColor="#FFFFCC" BorderColor="Black" CssClass="auto-style9" OnClick="btnDelete_Click" Text="Delete " />
    </form>
</body>
</html>
