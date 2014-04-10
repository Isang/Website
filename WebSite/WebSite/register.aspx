<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebSite.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelRegisterBox" runat="server" CssClass="panel_RegisterBoxContainer">
        Enter your information below:
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="txtRegEmail" runat="server" CssClass="txt_RegBox" TabIndex="1" placeholder="E-Mail" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="txtRegPassword" runat="server" CssClass="txt_RegBox" TabIndex="2" placeholder="Password" TextMode="Password" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="txtRegFirstName" runat="server" CssClass="txt_RegBox" TabIndex="3" placeholder="First name" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="txtRegLastName" runat="server" CssClass="txt_RegBox" TabIndex="4" placeholder="Last name" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="txtRegPhoneNumber" runat="server" CssClass="txt_RegBox" TabIndex="5" placeholder="Phone number" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:Button ID="btnRegister" runat="server" CssClass="btn_RegButton" TabIndex="6" Text="Register" OnClick="btnRegister_Click" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:Label ID="lblRegBoxMessage" runat="server" CssClass="lbl_RegisterBoxMessage" />
    </asp:Panel>
</asp:Content>
