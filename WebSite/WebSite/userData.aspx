<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="userData.aspx.cs" Inherits="WebSite.userData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grdUserData" runat="server" HeaderStyle-BackColor="#e9e9f9" AlternatingRowStyle-BackColor="#e9e9f9" GridLines="None" Width="576px" style="text-align:left; margin-left:auto; margin-right:auto; margin-top:32px; font-size:12px">
    </asp:GridView>
</asp:Content>
