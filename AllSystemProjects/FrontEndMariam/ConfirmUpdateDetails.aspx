<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="ConfirmUpdateDetails.aspx.cs" Inherits="ConfirmUpdateDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="pnlMain" runat="server" BorderColor="White" BorderStyle="Solid" Height="476px"  Width=60% style="margin-right:auto;margin-left:auto;" >
    <br />
    <br />
    <br />
    <br />
    <br />
       <div id="Text">Your details were updated successfully 
       </div>
   <br />
<p>
        <asp:Button ID="btnAccountManagement" runat="server" Text="Account Management Page" Font-Names="Microsoft Sans Serif" Font-Size="X-Large" Height="35px"  Width="312px" BackColor="#657198" ForeColor="WhiteSmoke" OnClick="btnAccountManagement_Click" />
</p>
 
</asp:Panel>
</asp:Content>

