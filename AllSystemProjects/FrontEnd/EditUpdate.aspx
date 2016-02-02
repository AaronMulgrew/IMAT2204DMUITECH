<%@ Page Title="" Language="C#" MasterPageFile="~/ServiceOrderMaster.master" AutoEventWireup="true" CodeFile="EditUpdate.aspx.cs" Inherits="EditUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"><br />
   <br />
    <asp:Panel ID="pnlMain" runat="server" BorderColor="White" BorderStyle="Solid" Height="540px"  Width=40% style="margin-right:auto;margin-left:auto;" >
        <br />
        
        <asp:Label ID="lblMessage" runat="server" BackColor="White" ForeColor="Red"></asp:Label><br />
        <br />
       <div id="First"><asp:Label ID="lblServiceType" runat="server" Text="*Service Type:" Font-Names="Microsoft Sans Serif" Font-Size="X-Large" Height="15px"></asp:Label>
           &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:DropDownList ID="ddlServiceType" runat="server" Height="23px" Width="130px" OnSelectedIndexChanged="ddlServiceType_SelectedIndexChanged">
          <asp:ListItem>Hardware</asp:ListItem>
          <asp:ListItem>Software</asp:ListItem>
        </asp:DropDownList> </div> 
        <br />
        <div id="Second">
            <asp:Label ID="lblService" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="X-Large" Height="15px" Text="*Service:"></asp:Label>
            &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlService" runat="server" Height="23px" Width="130px" OnSelectedIndexChanged="ddlService_SelectedIndexChanged">
                <asp:ListItem>Monitor Problem</asp:ListItem>
                <asp:ListItem>Broken Fan</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <div id="Third">
            &nbsp;
            <asp:Label ID="lblInfo" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="X-Large" Height="15px" Text="Additional Info:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <br />
        <asp:TextBox ID="txtInfo" runat="server" Height="115px" Width="479px" Rows="10" TextMode="MultiLine" OnTextChanged="txtInfo_TextChanged"></asp:TextBox>
        <br />
        <br />
        <div id=":Fourth">
            <asp:Label ID="lblDate" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="X-Large" Height="15px" Text="*Date:"></asp:Label>
            (DD/MM/YYYY)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtDate" runat="server" Height="23px" Width="130px" OnTextChanged="txtDate_TextChanged"></asp:TextBox>
        </div>
        <br />
        <br />
        <div id="Fifth">
            <asp:Label ID="lblTime" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="X-Large" Height="15px" Text="*Time:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTime" runat="server" Height="23px" Width="130px"></asp:TextBox>
        </div>
        <br />
        <asp:Label ID="lblAsterisk" runat="server" Font-Names="Microsoft Sans Serif" Text="*Fields marked with asterisks are compulsory"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnConfirm" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Large" Height="49px" OnClick="btnConfirm_Click" Text="Confirm Update" Width="268px" BackColor="#657198" ForeColor="WhiteSmoke" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        
        &nbsp;
    </asp:Panel>
    <br /><br />
    </asp:Content>

