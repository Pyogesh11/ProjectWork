<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="GameConsolesPic.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="309px"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" />
            <asp:Button ID="btnClear" runat="server" Height="27px" Text="Clear" Width="59px" />
            <br />
        <asp:ListBox ID="lstCustomers" runat="server" Height="267px" Width="323px"></asp:ListBox>
        <asp:Button ID="btnDisplayAll" runat="server" Text="DisplayAll" OnClick="btnDisplayAll_Click" />
        <p>
            <asp:Button ID="btnAdd" runat="server" Height="33px" Text="Add" Width="80px" OnClick="btnAdd_Click" />
            <asp:Button ID="btnDelete" runat="server" Height="33px" Text="Delete" Width="76px" OnClick="btnDelete_Click" />
            <asp:Button ID="btnUpdate" runat="server" Height="33px" Text="Update" Width="78px" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnPlaceOrder" runat="server" Height="34px" Text="PlaceOrder" />
        </p>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style1" style="z-index: 1" Text="lblError"></asp:Label>
        </div>    
    </form>
</body>
</html>
