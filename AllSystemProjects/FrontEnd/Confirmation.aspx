<%@ Page Title="" Language="C#" MasterPageFile="~/ServiceOrderMaster.master" AutoEventWireup="true" CodeFile="Confirmation.aspx.cs" Inherits="Confirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <asp:Label ID="lblInstruction1" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="16pt" ForeColor="White" Text="Your order has been placed"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblOrderNo" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="16pt" ForeColor="White" Text="Service Order No: 122099201"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblEmailConfirm" runat="server" BorderColor="#657198" Font-Names="Microsoft Sans Serif" Font-Size="16pt" ForeColor="White" Text="An email confirmation has been sent to your email"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnReturn" runat="server" BackColor="#657198" Font-Names="Microsoft Sans Serif" Font-Size="14pt" ForeColor="White" Height="35px" OnClick="btnReturn_Click" Text="Return to homepage" Width="200px" />
    </p>
</asp:Content>

