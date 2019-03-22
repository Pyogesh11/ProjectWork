<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GameConsoles</title>
    <style type="text/css">
        body
        {
            background-image: url("101345-simple_background-gradient-748x421.jpg");
            background-repeat: repeat-x;
        }
        .auto-style1 {
            position: absolute;
            top: 34px;
            left: 10px;
        }
        .auto-style2 {
            position: absolute;
            top: 69px;
            left: 13px;
            z-index: 1;
            width: 90px;
            height: 31px;
        }
        .auto-style3 {
            position: absolute;
            top: 70px;
            left: 119px;
            z-index: 1;
            width: 90px;
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Areyousureyouwantodeletethiscustomer" runat="server" CssClass="auto-style1" style="z-index: 1" Text="Are you sure you wan to delete this customer?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" Text="Yes" OnClick="btnYes_Click" BackColor="#FFFFCC" BorderColor="Black" BorderStyle="Groove" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" Text="No" OnClick="btnNo_Click" BackColor="#FFFFCC" BorderColor="Black" BorderStyle="Groove" />
    </form>
</body>
</html>
