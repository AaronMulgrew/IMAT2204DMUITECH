<%@ Page Title="" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="UpdatePersonalDetails.aspx.cs" Inherits="UpdatePersonalDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:Panel ID="pnlMain" runat="server" BorderColor="White" BorderStyle="Solid" Height="700px"  Width=60% style="margin-right:auto;margin-left:auto;" >

    <p>
   Update your Personal Details:

</p>
<p>
      <asp:Label ID="lblFirstName" runat="server" Text="*First Name:"></asp:Label>
<br />
        <asp:TextBox ID="txtFirstName" runat="server" Width="171px" OnTextChanged="txtFirstName_TextChanged"></asp:TextBox>
</p> 
<p>
        <asp:Label ID="lblLastName" runat="server" Text="*Last Name:"></asp:Label>
<br />
        <asp:TextBox ID="txtLastName" runat="server" Width="171px"></asp:TextBox> 
</p>
<p>
        <asp:Label ID="lblEmailAddress" runat="server" Text="*Email Address"></asp:Label>
<br />
        <asp:TextBox ID="txtEmailAddress" runat="server" Width="171px" OnTextChanged="txtEmailAddress_TextChanged"></asp:TextBox>
</p>
<p>
        <asp:Label ID="lblPhoneNumber" runat="server" Text="*Phone Number:"></asp:Label>
<br />
        <asp:TextBox ID="txtPhoneNumber" runat="server" Width="171px"></asp:TextBox>
</p> 
<p>
        <asp:Label ID="lblDateOfBirth" runat="server" Text="*Date Of Birth:"></asp:Label>
<br />
        <asp:TextBox ID="txtDateOfBirth" runat="server" Width="171px"></asp:TextBox>
</p> 
<p>
        <asp:Label ID="lblGender" runat="server" Text="*Gender:"></asp:Label>
<br />
        <asp:DropDownList ID="DDLGender" runat="server" Height="25px" Width="171px">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
        </asp:DropDownList>
</p>
<p>
        <asp:Label ID="lblAddress" runat="server" Text="*Address:"></asp:Label>
<br />
        <asp:TextBox ID="txtAddress" runat="server" Width="171px"></asp:TextBox>
</p>
<p>
        <asp:Label ID="lblCity" runat="server" Text="*City:"></asp:Label>
<br />
        <asp:TextBox ID="txtCity" runat="server" Width="171px"></asp:TextBox>
</p> 

<p>
        <asp:Label ID="lblPostcode" runat="server" Text="*Postcode:"></asp:Label>
<br />
        <asp:TextBox ID="txtPostcode" runat="server" Width="171px"></asp:TextBox>
</p> 
<p>
</p>
<p>
        <asp:Button ID="btnConfirm" runat="server" Text="Confirm"  Font-Names="Microsoft Sans Serif" Font-Size="X-Large" Height="35px" OnClick="btnConfirm_Click" Width="200px" BackColor="#657198" ForeColor="WhiteSmoke" />
</p>
<p>
        <asp:Label ID="lblMessage" runat="server" BackColor="White" ForeColor="Red"></asp:Label>
</p>
 </asp:Panel>
</asp:Content>

