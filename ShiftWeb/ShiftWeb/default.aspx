<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebSite._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="panel_SubContentTab">
        Select an existing village or add a new one:
    </asp:Panel>
    <asp:Panel runat="server" CssClass="panel_SubContentSpacing" />
    <asp:Panel runat="server" CssClass="panel_SubContentTab">
        Select an existing cabin or add a new one:
    </asp:Panel>
    <asp:Panel runat="server" CssClass="panel_SubContentSpacing" />
</asp:Content>
