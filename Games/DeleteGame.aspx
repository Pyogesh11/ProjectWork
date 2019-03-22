<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteGame.aspx.cs" Inherits="DeleteGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h1>  <asp:Label ID="lblDeleteGame" runat="server" style="z-index: 1; left: 413px; top: 19px; position: absolute" Text="Delete Game"></asp:Label></h1>
        </div>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 400px; top: 134px; position: absolute" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 598px; top: 130px; position: absolute" Text="No" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 403px; top: 101px; position: absolute" Text="Are you sure you want to delete this game"></asp:Label>
        <asp:TextBox ID="txtGame_Name" runat="server" style="z-index: 1; left: 436px; top: 75px; position: absolute; height: 22px;"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 481px; top: 203px; position: absolute"></asp:Label>
    </form>
</body>
</html>
