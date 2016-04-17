<%@ Page Title="Register" Language="C#" MasterPageFile="~/Customer.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <asp:Panel ID="pnlMain" runat="server" BorderColor="White" BorderStyle="Solid" Height="700px"  Width=60% style="margin-right:auto;margin-left:auto;" >
<p>
    Fill the boxes below to create a new account:

        </p> 
     <p>
         <asp:Label ID="lblFirstName" runat="server" Text="*First Name:"></asp:Label>
         <br />
         <asp:TextBox ID="txtFirstName" runat="server" Width="171px"></asp:TextBox>
     </p>
<p>
        <asp:Label ID="lblLastName" runat="server" Text="*Last Name:"></asp:Label>
<br />
        <asp:TextBox ID="txtLastName" runat="server" Width="171px"></asp:TextBox> 
</p>
<p>
        <asp:Label ID="lblEmailAddress" runat="server" Text="*Email Address"></asp:Label>
<br />
        <asp:TextBox ID="txtEmailAddress" runat="server" Width="171px"></asp:TextBox>
</p>
<p>
        <asp:Label ID="lblPassword" runat="server" Text="*Password "></asp:Label>
<br />
        <asp:TextBox ID="txtPassword" runat="server" Width="171px"></asp:TextBox>
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
        <asp:DropDownList ID="ddlGender" runat="server" Height="25px" Width="171px">
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
        <asp:Button ID="btnRegister" runat="server" Text="Register" Font-Names="Microsoft Sans Serif" Font-Size="X-Large" Height="35px"  Width="200px" BackColor="#657198" ForeColor="WhiteSmoke" OnClick="btnRegister_Click" />
</p>

<p>
        <asp:Label ID="lblMessage" runat="server" BackColor="White" ForeColor="Red"></asp:Label>
</p>

 </asp:Panel>
</asp:Content>

