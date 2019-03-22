<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GameConsoles</title>
    <style type="text/css">
        body
        {
            background-image: url("101345-simple_background-gradient-748x421.jpg");
            background-repeat: repeat-x;
        }
        .auto-style1 {
            position: absolute;
            top: 24px;
            left: 10px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 24px;
            left: 112px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 58px;
            left: 8px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 58px;
            left: 114px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 99px;
            left: 16px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 95px;
            left: 114px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 137px;
            left: 14px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 135px;
            left: 115px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 176px;
            left: 15px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 173px;
            left: 111px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 214px;
            left: 11px;
            z-index: 1;
            width: 78px;
            right: 803px;
        }
        .auto-style12 {
            position: absolute;
            top: 213px;
            left: 116px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 253px;
            left: 18px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 249px;
            left: 105px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 289px;
            left: 20px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 289px;
            left: 108px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 323px;
            left: 15px;
            z-index: 1;
            width: 91px;
        }
        .auto-style18 {
            position: absolute;
            top: 395px;
            left: 294px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 369px;
            left: 16px;
            z-index: 1;
            width: 90px;
            height: 31px;
            right: 786px;
        }
        .auto-style20 {
            position: absolute;
            top: 367px;
            left: 122px;
            z-index: 1;
            width: 90px;
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;</div>
        <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style1" Text="FirstName "></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style2" BorderColor="Black"></asp:TextBox>
        <asp:Label ID="lblSurName" runat="server" CssClass="auto-style3" Text="SurName"></asp:Label>
        <asp:TextBox ID="txtSurName" runat="server" CssClass="auto-style4" BorderColor="Black"></asp:TextBox>
        <asp:Label ID="lblStreet" runat="server" CssClass="auto-style5" Text="Street"></asp:Label>
        <asp:TextBox ID="txtStreet" runat="server" CssClass="auto-style6" BorderColor="Black"></asp:TextBox>
        <asp:Label ID="lblHouseNo" runat="server" CssClass="auto-style7" Text="HouseNo"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" CssClass="auto-style8" BorderColor="Black"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" CssClass="auto-style9" Text="PostCode"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" CssClass="auto-style10" BorderColor="Black"></asp:TextBox>
        <asp:Label ID="lblCounty" runat="server" CssClass="auto-style11" Text="County"></asp:Label>
        <asp:DropDownList ID="ddlCounty" runat="server" CssClass="auto-style12" OnSelectedIndexChanged="ddlCounty_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="lblPhoneNo" runat="server" CssClass="auto-style13" Text="PhoneNo"></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="auto-style14" BorderColor="Black"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" CssClass="auto-style15" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style16" BorderColor="Black"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style17" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style18" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style19" OnClick="btnOK_Click" Text="OK" BackColor="#FFFFCC" BorderColor="Black" BorderStyle="Groove" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style20" Text="Cancel" OnClick="btnCancel_Click" BackColor="#FFFFCC" BorderColor="Black" BorderStyle="Groove" />
    </form>
</body>
</html>
