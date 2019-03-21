<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
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
        }
        .auto-style3 {
            position: absolute;
            top: 70px;
            left: 68px;
            z-index: 1;
            width: 40px;
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Areyousureyouwantodeletethiscustomer" runat="server" CssClass="auto-style1" style="z-index: 1" Text="Are you sure you wan to delete this customer?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" Text="No" />
    </form>
</body>
</html>
