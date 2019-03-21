<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EDelCheck.aspx.cs" Inherits="EDelCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        
             <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 554px; width: 882px"> 

            <asp:Label ID="lblDelEmployee" runat="server" style="z-index: 1; left: 5px; top: 530px; position: absolute; width: 111px" Text="Employee Page"></asp:Label>
            <asp:Label ID="lblDelError" runat="server" ForeColor="Red" style="z-index: 1; left: 395px; top: 228px; position: absolute"></asp:Label>
                 <br />

                     <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 292px; top: 168px; position: absolute; width: 94px; margin-bottom: 7px; height: 26px;" Text="Yes" OnClick="btnYes_Click" />
                     <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 457px; top: 168px; position: absolute; width: 91px" Text="No" OnClick="btnNo_Click" />
                 
                 <h1 runat="server" style=" position: absolute; top: 74px; left: 128px;">Are you sure you want to delete this Employee? </h1>
                 
        </asp:Panel>
        
    </form>
</body>
</html>

