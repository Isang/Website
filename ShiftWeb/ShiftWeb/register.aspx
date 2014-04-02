<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebSite.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="panel_Register">
        Enter your information below:
        <asp:Panel runat="server" CssClass="panel_Spacing" />
        <asp:TextBox ID="txtUserFirstName" runat="server" CssClass="textBox_Register" Placeholder="First name" />
        <asp:Panel runat="server" CssClass="panel_Spacing" />
        <asp:TextBox ID="txtUserLastName" runat="server" CssClass="textBox_Register" Placeholder="Last name"/>
        <asp:Panel runat="server" CssClass="panel_Spacing" />
        <asp:TextBox ID="txtUserEMail" runat="server" CssClass="textBox_Register" Placeholder="E-mail" TextMode="Email" />
        <asp:Panel runat="server" CssClass="panel_Spacing" />
        <asp:TextBox ID="txtUserPassword" runat="server" CssClass="textBox_Register" Placeholder="Password" TextMode="Password" />
        <asp:Panel runat="server" CssClass="panel_Spacing" />
        <asp:TextBox ID="txtUserPhoneNumber" runat="server" CssClass="textBox_Register" Placeholder="Phone number"/>
        <asp:Panel runat="server" CssClass="panel_Spacing" />
        <asp:Button ID="btnUserRegister" runat="server" CssClass="button_Submit" OnClick="Page_Load" Text="Register" />
    </asp:Panel>
</asp:Content>
