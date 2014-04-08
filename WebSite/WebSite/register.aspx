<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebSite.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelRegisterBox" runat="server" CssClass="panel_RegisterBoxContainer">
        Enter your information below:
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="textBoxRegisterEMail" runat="server" CssClass="textBox_RegisterBox" placeholder="E-Mail" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="textBoxRegisterPassword" runat="server" CssClass="textBox_RegisterBox" placeholder="Password"  TextMode="Password" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="textBoxRegisterFirstName" runat="server" CssClass="textBox_RegisterBox" placeholder="First name" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="textBoxRegisterLastName" runat="server" CssClass="textBox_RegisterBox" placeholder="Last name" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="textBoxRegisterPhoneNumber" runat="server" CssClass="textBox_RegisterBox" placeholder="Phone number" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:Button ID="buttonRegister" runat="server" CssClass="button_Register" Text="Register" />
    </asp:Panel>
</asp:Content>
