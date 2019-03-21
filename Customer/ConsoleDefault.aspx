<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConsoleDefault.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consoles Default Home</title>
     <link rel = "stylesheet" type = "text/css" href = "StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Consoles</h1>
            <h3>Welcome to consoles!</h3>
            <asp:ListBox ID="lstConsoles" runat="server" Height="252px" Width="304px"></asp:ListBox>
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
        </div>
        <asp:Button ID="btnddConsole" runat="server" Text="Add" />
        <asp:Button ID="btnEditConsole" runat="server" Text="Edit" OnClick="ButtonEditConsole_Click" />
        <asp:Button ID="btnDeleteConsole" runat="server" Text="Delete" OnClick="ButtonDeleteConsole_Click" />
    </form>
</body>
</html>
