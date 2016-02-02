<%@ Page Title="" Language="C#" MasterPageFile="~/ServiceOrderMaster.master" AutoEventWireup="true" CodeFile="Summary.aspx.cs" Inherits="Summary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <br />
    <h1>Service Order Summary</h1>
    <p>&nbsp;</p>
    <p>
        <asp:ListBox ID="lstSummary" runat="server" BackColor="#657198" Font-Names="Microsoft Sans Serif" ForeColor="White" Height="167px" Width="367px">
            <asp:ListItem>MR MOHAMMED SHEIKH</asp:ListItem>
            <asp:ListItem>p14165162@myemail.dmu.ac.uk</asp:ListItem>
            <asp:ListItem>Service Order Details:</asp:ListItem>
            <asp:ListItem>Hardware, Broken Fan</asp:ListItem>
            <asp:ListItem>Wednesday 29th January, 13:00</asp:ListItem>
        </asp:ListBox>
    </p>
<p>
    &nbsp;</p>
    <p>
        <asp:Button ID="btnContinue" runat="server" BackColor="#657198" Font-Names="Microsoft Sans Serif" Font-Size="14pt" ForeColor="White" Height="35px" Text="Continue to payment" Width="200px" OnClick="btnContinue_Click" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

