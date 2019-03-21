<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AConsole.aspx.cs" Inherits="AConsole" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AConsole</title>
    <link rel = "stylesheet" type = "text/css" href = "StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Console</h1>
            <h3>Please enter Console details below:</h3>
            Console Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxConsoleName" runat="server"></asp:TextBox>
            <br />
            Console Manufacturer&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBoxConsoleManufacturer" runat="server"></asp:TextBox>
            <br />
            Console Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBoxConsolePrice" runat="server"></asp:TextBox>
            <br />
            Console StockConsole Stock&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxConsoleStock" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonOKAConsole" runat="server" OnClick="ButtonOKAConsole_Click" Text="OK" />
            <asp:Button ID="ButtonCancelAConsole" runat="server" OnClick="ButtonCancelAConsole_Click" Text="Cancel" />
        </div>
    </form>
</body>
</html>
