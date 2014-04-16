<%@ Page Title="Search Cabin" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="searchCabin.aspx.cs" Inherits="WebSite.searchCabin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelRegisterBox" runat="server" CssClass="panel_RegisterBoxContainer">
        Search for a cabin:
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:DropDownList ID="ddlVillage" runat="server" CssClass="dropdown_Register" DataTextField ="Name" DataValueField ="Id" AutoPostBack="true" OnSelectedIndexChanged="ddlVillage_SelectedIndexChanged"></asp:DropDownList>
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:DropDownList ID="ddlRooms" runat="server" CssClass="dropdown_Register" OnSelectedIndexChanged="ddlRooms_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:DropDownList ID="ddlBeds" runat="server" CssClass="dropdown_Register" OnSelectedIndexChanged="ddlBeds_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
    </asp:Panel>
    <asp:GridView ID="grdUserData" runat="server" AutoPostBack="true" HeaderStyle-BackColor="#e9e9f9" AlternatingRowStyle-BackColor="#e9e9f9" GridLines="None" Width="576px" style="text-align:left; margin-left:auto; margin-right:auto; margin-top:32px;">
    </asp:GridView>
</asp:Content>
