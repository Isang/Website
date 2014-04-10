<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="registerCabin.aspx.cs" Inherits="WebSite.registercabin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelRegisterBox" runat="server" CssClass="panel_RegisterBoxContainer">
        Register new cabin:
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:DropDownList ID="ddlVillage" runat="server" CssClass="dropdown_Register" OnSelectedIndexChanged="ddlVillage_SelectedIndexChanged" DataTextField ="Name" AutoPostBack="true"></asp:DropDownList>
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:DropDownList ID="ddlRooms" runat="server" CssClass="dropdown_Register" OnSelectedIndexChanged="ddlRooms_SelectedIndexChanged" ></asp:DropDownList>
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:DropDownList ID="ddlBeds" runat="server" CssClass="dropdown_Register" OnSelectedIndexChanged="ddlBeds_SelectedIndexChanged" ></asp:DropDownList>
        <asp:Panel runat="server" CssClass="panel_RegisterBoxSpacing" />
        <asp:TextBox ID="txtCabinSize" runat="server" CssClass="txt_RegBox" placeholder="Cabin Size in square meters"  ></asp:TextBox>

        </asp:Panel>
</asp:Content>
