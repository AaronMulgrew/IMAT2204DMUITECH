<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="Confirmation.aspx.cs" Inherits="Confirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlMain" runat="server" BorderColor="White" BorderStyle="Solid" Height="476px"  Width=60% style="margin-right:auto;margin-left:auto;" >
    <br />
    <br />
       <div id="Text">Welcom to DMUItech Repairs and Thank you for registering in our website please press the button below to start navigating through our website  
       </div>
   <br />
<p>
        <asp:Button ID="btnHome" runat="server" Text="Back To Home Page" Font-Names="Microsoft Sans Serif" Font-Size="X-Large" Height="35px"  Width="238px" BackColor="#657198" ForeColor="WhiteSmoke" OnClick="btnRegister_Click" />
</p>
 
</asp:Panel>
</asp:Content>

