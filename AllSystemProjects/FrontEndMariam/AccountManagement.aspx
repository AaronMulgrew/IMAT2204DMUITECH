<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="AccountManagement.aspx.cs" Inherits="AccountManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlMain" runat="server" BorderColor="White" BorderStyle="Solid" Height="485px"  Width="58%" style="margin-right:auto;margin-left:auto;" >
       <h1>Manage your account</h1> 

 <br />
<p>
   <br />
    Click on one of the buttons below:</p>
    <p>
        <asp:Button ID="btnAdd" runat="server" Text="Create Service Order" Font-Names="Microsoft Sans Serif" Font-Size="Large" Height="35px" Width="208px" BackColor="#657198" ForeColor="WhiteSmoke" />
    </p>
    <p>
        <asp:Button ID="btnUpdate" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Height="35px"  Text="Update Service Order" Width="208px" BackColor="#657198" ForeColor="WhiteSmoke" />
    </p>
    <p>
        <asp:Button ID="btnCancel" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Height="35px"  Text="Cancel Service Order" Width="208px" BackColor="#657198" ForeColor="WhiteSmoke" />
    </p>
    <p>
        <asp:Button ID="btnPassword" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Height="35px" Text="Password Management" Width="208px" BackColor="#657198" ForeColor="WhiteSmoke" OnClick="btnPassword_Click" />
    </p>
    <p>
        <asp:Button ID="btnDisplay" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Text="Display Service Orders"  BackColor="#657198" ForeColor="WhiteSmoke" Width="208px" />
    </p>
    <p>
       <asp:Button ID="btnUpdatePersonalDetails" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Text="Update Personal Details"  BackColor="#657198" ForeColor="WhiteSmoke" Width="208px" Height="34px" OnClick="btnUpdatePersonalDetails_Click" />
   </p>

</asp:Panel>
</asp:Content>

