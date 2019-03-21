<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 56px;
            left: 10px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 57px;
            left: 119px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 105px;
            left: 11px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 105px;
            left: 116px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 159px;
            left: 20px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 160px;
            left: 116px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 209px;
            left: 23px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 207px;
            left: 116px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 260px;
            left: 23px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 257px;
            left: 117px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 308px;
            left: 22px;
            z-index: 1;
            width: 78px;
            right: 944px;
        }
        .auto-style12 {
            position: absolute;
            top: 306px;
            left: 118px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 354px;
            left: 22px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 350px;
            left: 110px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 395px;
            left: 28px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 393px;
            left: 111px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 450px;
            left: 32px;
            z-index: 1;
            width: 91px;
        }
        .auto-style18 {
            position: absolute;
            top: 447px;
            left: 166px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 499px;
            left: 18px;
            z-index: 1;
            width: 54px;
            height: 26px;
        }
        .auto-style20 {
            position: absolute;
            top: 498px;
            left: 104px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;</div>
        <asp:Label ID="lblFirstName" runat="server" CssClass="auto-style1" Text="FirstName "></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Label ID="lblSurName" runat="server" CssClass="auto-style3" Text="SurName"></asp:Label>
        <asp:TextBox ID="txtSurName" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Label ID="lblStreet" runat="server" CssClass="auto-style5" Text="Street"></asp:Label>
        <asp:TextBox ID="txtStreet" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Label ID="lblHouseNo" runat="server" CssClass="auto-style7" Text="HouseNo"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" CssClass="auto-style8"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" CssClass="auto-style9" Text="PostCode"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:Label ID="lblCounty" runat="server" CssClass="auto-style11" Text="County"></asp:Label>
        <asp:DropDownList ID="ddlCounty" runat="server" CssClass="auto-style12" OnSelectedIndexChanged="ddlCounty_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="lblPhoneNo" runat="server" CssClass="auto-style13" Text="PhoneNo"></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="auto-style14"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" CssClass="auto-style15" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style16"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style17" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style18" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" CssClass="auto-style19" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style20" Text="Cancel" />
    </form>
</body>
</html>
