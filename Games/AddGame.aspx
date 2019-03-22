<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddGame.aspx.cs" Inherits="AddGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnGame_Decription" runat="server" style="z-index: 1; left: 20px; top: 159px; position: absolute" Text="Game_Decription" />
            <asp:Button ID="btnSupplier_ID" runat="server" style="z-index: 1; left: 20px; top: 365px; position: absolute" Text="Supplier_ID" />
            <asp:Button ID="btnPlatfrom" runat="server" style="z-index: 1; left: 27px; top: 299px; position: absolute" Text="Platfrom" />
            <asp:Button ID="btnGame_Name" runat="server" style="z-index: 1; left: 30px; top: 90px; position: absolute" Text="Game_Name" OnClick="btnGame_Name_Click" />
            <asp:Button ID="btnGame_Quantity" runat="server" style="z-index: 1; left: 22px; top: 231px; position: absolute" Text="Game_Quantity" />
            <asp:TextBox ID="txtGame_Name" runat="server" style="z-index: 1; left: 247px; top: 87px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtGame_Quantity" runat="server" style="z-index: 1; left: 247px; top: 227px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplier_ID" runat="server" style="z-index: 1; left: 241px; top: 367px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPlatform" runat="server" style="z-index: 1; left: 243px; top: 297px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblAddGame" runat="server" style="z-index: 1; left: 160px; top: 32px; position: absolute; height: 30px" Text="Add Game"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="txtGame_Description" runat="server" style="z-index: 1; left: 248px; top: 165px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="z-index: 1; left: 332px; top: 469px; position: absolute" Text="Back" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 35px; top: 468px; position: absolute"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnUpdate" runat="server" style="z-index: 1; left: 236px; top: 469px; position: absolute" Text="Update" OnClick="btnUpdate_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
