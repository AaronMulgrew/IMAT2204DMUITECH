<%@ Page Title="" Language="C#" MasterPageFile="~/ServiceOrderMaster.master" AutoEventWireup="true" CodeFile="CancelOrder.aspx.cs" Inherits="CancelOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <br />
    <h1>Cancel Service Order</h1>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    Please enter your Service Order Number to cancel your service order:</p>
    <p>
        <asp:TextBox ID="txtCancel" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnCancel" runat="server" Text="Cancel Service Order" OnClick="btnCancel_Click" BackColor="#657198" ForeColor="WhiteSmoke" Font-Names="Microsoft Sans Serif" Font-Size="14pt" Height="35px" Width="200px" />
    </p>
    <p>
        <asp:Label ID="lblMessage" runat="server" BackColor="White" ForeColor="Red"></asp:Label>
    </p>
</asp:Content>

