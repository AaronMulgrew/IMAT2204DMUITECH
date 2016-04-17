<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="ManagePassword.aspx.cs" Inherits="ManagePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="pnlMain" runat="server" BorderColor="White" BorderStyle="Solid" Height="700px"  Width=60% style="margin-right:auto;margin-left:auto;" >
   <p>Password Management</p>
     <br />
    <br />
    <br />
    <br />
       <div id="Text"> please Enter your email below to process your request  
       </div>
    <br />
    <br />
    <br />
       <asp:TextBox ID="txtEnterEmail" runat="server" Width="248px"></asp:TextBox>      
    <br />
    <br />
    <br />     
       <asp:Button ID="btnSubmit" runat="server" Text="Submit" Font-Names="Microsoft Sans Serif" Font-Size="X-Large" Height="35px" OnClick="btnSubmit_Click" Width="200px" BackColor="#657198" ForeColor="WhiteSmoke" />
    <br />
    <br />
    <br />

    <asp:Label ID="lblMessage" runat="server"> </asp:Label>
      
</asp:Panel>
</asp:Content>

