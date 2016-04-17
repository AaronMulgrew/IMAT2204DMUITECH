using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountManagement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnUpdatePersonalDetails_Click(object sender, EventArgs e)
    {
        //this page will be directed Update Personal Details page
        Response.Redirect("UpdatePersonalDetails.aspx");
    }
    protected void btnPassword_Click(object sender, EventArgs e)
    {
        //this page will be directed Manage Password page
        Response.Redirect("ManagePassword.aspx");
    }
}