﻿<%@ Page Title="Login" Language="C#" MasterPageFile="~/ServiceOrderMaster.master" AutoEventWireup="true" CodeFile="Login_CreateOrder.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
    Login to your DMUITech account</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    Enter your username and password to login to your account:</p>
    <p>
        <asp:Label ID="lblUsername" runat="server" Text="*Username:"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblPassword" runat="server" Text="*Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnViewSummary" runat="server" BackColor="#657198" Font-Names="Microsoft Sans Serif" Font-Size="16pt" ForeColor="White" Height="35px" OnClick="btnViewSummary_Click" Text="View Order Summary" Width="219px" />
    </p>
    <p>
        <asp:Label ID="lblMessage" runat="server" BackColor="White" ForeColor="Red"></asp:Label>
    </p>
</asp:Content>

