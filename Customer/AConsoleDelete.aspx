<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AConsoleDelete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consoles Delete</title>
     <link rel = "stylesheet" type = "text/css" href = "StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Delete</h1>
            <h3>Are you sure??</h3>
            <asp:Button ID="ButtonConsoleDeleteYes" runat="server" Text="YES" OnClick="ButtonConsoleDeleteYes_Click" />
            <asp:Button ID="ButtonConsoleDeleteNo" runat="server" Text="NO" />
            <br />
            
        </div>
    </form>
</body>
</html>
