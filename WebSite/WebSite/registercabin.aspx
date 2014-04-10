<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="registerCabin.aspx.cs" Inherits="WebSite.registercabin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelRegisterBox" runat="server" CssClass="panel_RegisterBoxContainer">
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:DropDownList ID="ddlVillage" runat="server" CssClass="dropdown_Register" ></asp:DropDownList>
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:DropDownList ID="ddlRooms" runat="server" CssClass="dropdown_Register" ></asp:DropDownList>
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:DropDownList ID="ddlBeds" runat="server" CssClass="dropdown_Register" ></asp:DropDownList>
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="txtCabinSize" runat="server" CssClass="textBox_RegisterBox" ></asp:TextBox>

        </asp:Panel>
</asp:Content>
