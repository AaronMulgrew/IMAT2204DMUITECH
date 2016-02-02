<%@ Page Title="" Language="C#" MasterPageFile="~/ServiceOrderMaster.master" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <br />
   <h1>Your Service Orders</h1> 

    &nbsp;
<p>
    &nbsp;
    Click on the 'Filter' button to filter your service orders by a specific date:</p>
    <p>
        <asp:TextBox ID="txtAllOrders" runat="server" Height="160px" OnTextChanged="txtAllOrders_TextChanged" Width="643px" Rows="5" TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblMessage" runat="server" BackColor="White" ForeColor="Red"></asp:Label>
    </p>
    <p>
        <asp:Label ID="LabelInstruction" runat="server" Text="Enter an order date to filter your service order"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnFilter" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Text="Filter Service Orders" OnClick="btnFilter_Click" BackColor="#657198" ForeColor="WhiteSmoke" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>


