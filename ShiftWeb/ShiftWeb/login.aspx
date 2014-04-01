<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ShiftWeb.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="div_LoginForm">
            <form id="login">
                Log in
                <div style="position:relative; top:16px">
                    <input id="username" type="text" placeholder="Username" autofocus="autofocus" required="required" class="input_TextField" />
                    <div style="position:relative; top:16px">
                        <input id="password" type="password" placeholder="Password" required="required" class="input_TextField" />
                        <div style="position:relative; top:16px">
                            <input type="submit" id="submit" class="input_SubmitButton" />
                            <div style="position:relative; top:16px">
                                Not registered? <a href="register.aspx">Register now!</a>
                            </div>
                        </div>
                    </div>
                </div>
            </form>
        </div>
</asp:Content>
