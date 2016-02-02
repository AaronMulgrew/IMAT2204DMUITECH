<%@ Page Title="" Language="C#" MasterPageFile="~/ServiceOrderMaster.master" AutoEventWireup="true" CodeFile="AccountManagement.aspx.cs" Inherits="AccountManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <br />
   <h1>Manage your account</h1> 

    &nbsp;
<p>
    &nbsp;
    Click on one of the buttons below:</p>
    <p>
        <asp:Button ID="btnAdd" runat="server" Text="Create Service Order" Font-Names="Microsoft Sans Serif" Font-Size="Large" Height="35px" Width="200px" OnClick="btnAdd_Click" BackColor="#657198" ForeColor="WhiteSmoke" />
    </p>
    <p>
        <asp:Button ID="btnUpdate" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Height="35px" OnClick="btnUpdate_Click" Text="Update Service Order" Width="200px" BackColor="#657198" ForeColor="WhiteSmoke" />
    </p>
    <p>
        <asp:Button ID="btnCancel" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Height="35px" OnClick="btnCancel_Click" Text="Cancel Service Order" Width="200px" BackColor="#657198" ForeColor="WhiteSmoke" />
    </p>
    <p>
        <asp:Button ID="btnPassword" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Height="35px" Text="Password Management" Width="200px" BackColor="#657198" ForeColor="WhiteSmoke" />
    </p>
    <p>
        <asp:Button ID="btnDisplay" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Text="Display Service Orders" OnClick="btnDisplay_Click" BackColor="#657198" ForeColor="WhiteSmoke" />
    </p>
    <p>
        </p>
</asp:Content>

