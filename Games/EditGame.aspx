<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddGame.aspx.cs" Inherits="AddGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 183px; top: 374px; position: absolute"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnGame_ID" runat="server" Text="Game_ID" Height="36px" OnClick="btnGame_ID_Click" />
        </p>
        <p>
        <asp:Button ID="btnGame_Name" runat="server" Text="Game_Name" />
            <asp:TextBox ID="txtGame_ID" runat="server" style="z-index: 1; left: 292px; top: 95px; position: absolute" OnTextChanged="txtGame_ID_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtGame_Name" runat="server" style="z-index: 1; left: 294px; top: 144px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtGame_Quantity" runat="server" style="z-index: 1; left: 292px; top: 237px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplier_ID" runat="server" style="z-index: 1; left: 296px; top: 329px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPlatform" runat="server" style="z-index: 1; left: 292px; top: 283px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtGame_Description" runat="server" style="z-index: 1; left: 294px; top: 191px; position: absolute; bottom: 435px"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="btnGame_Description" runat="server" Text="Game_Description" />
        </p>
        <p>
        <asp:Button ID="btnGame_Quantity" runat="server" Text="Game_Quantity" />
        </p>
        <p>
        <asp:Button ID="btnPlatform" runat="server" Text="Platform" />
         <h1>   <asp:Label ID="blEditGame" runat="server" style="z-index: 1; left: 123px; top: 19px; position: absolute; width: 195px; height: 48px" Text="Edit Game"></asp:Label>
        <asp:Button ID="btnSupplier_ID" runat="server" Text="Supplier_ID" />
         </h1>
        </p>
    </form>
</body>
</html>
