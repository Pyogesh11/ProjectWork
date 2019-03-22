<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditSupplier.aspx.cs" Inherits="EditSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 554px; width: 882px">
            
            <asp:Button ID="btnHome" runat="server" style="z-index: 1; left: 179px; top: 90px; position: absolute; width: 110px" Text="Home" OnClick="btnHome_Click" />
            <h1 style=" position: absolute; top: 84px; left: 373px;">Edit Supplier </h1>
            <asp:Label ID="lblSupplier" runat="server" style="z-index: 1; left: 5px; top: 530px; position: absolute; width: 111px" Text="Supplier Page"></asp:Label>
        

            <asp:TextBox ID="txtSupplier_Id" runat="server" style="z-index: 1; left: 245px; top: 189px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplier_Name" runat="server" style="z-index: 1; left: 244px; top: 233px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplier_Address" runat="server" style="z-index: 1; left: 244px; top: 280px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtSupplier_Email" runat="server" style="z-index: 1; left: 556px; top: 233px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtPhone_No" runat="server" style="z-index: 1; left: 557px; top: 281px; position: absolute"></asp:TextBox> 
            <asp:DropDownList ID="ddlCounty" runat="server" style="z-index: 1; left: 558px; top: 189px; position: absolute; height: 22px; width: 128px; bottom: 343px">
            </asp:DropDownList>

            <asp:Label ID="lblSupplier_Id" runat="server" style="z-index: 1; left: 130px; top: 190px; position: absolute" Text="Supplier ID"></asp:Label>
            <asp:Label ID="lblSupplier_Name" runat="server" style="z-index: 1; left: 128px; top: 234px; position: absolute" Text="Supplier Name"></asp:Label>
            <asp:Label ID="lblSupplier_Address" runat="server" style="z-index: 1; left: 127px; top: 283px; position: absolute" Text="Supplier Address"></asp:Label>
            <asp:Label ID="lblCounty" runat="server" style="z-index: 1; left: 444px; top: 188px; position: absolute" Text="County"></asp:Label>
            <asp:Label ID="lblSupplier_Email" runat="server" style="z-index: 1; left: 444px; top: 234px; position: absolute" Text="Supplier Email"></asp:Label>
            <asp:Label ID="lblPhone_No" runat="server" style="z-index: 1; left: 446px; top: 282px; position: absolute" Text="Phone No"></asp:Label>

 
            <asp:Button ID="btnUpdate" runat="server" style="z-index: 1; left: 305px; top: 357px; position: absolute; width: 90px; height: 32px;" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 438px; top: 357px; position: absolute; width: 90px; height: 32px;" Text="Cancel" />
             
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 388px; top: 402px; position: absolute"></asp:Label>
            
                 <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 387px; top: 320px; position: absolute" Text="Active"/>
            
             </asp:Panel>

        </div>
    </form>
</body>
</html>
