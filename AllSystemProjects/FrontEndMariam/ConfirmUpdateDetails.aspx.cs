using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConfirmUpdateDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAccountManagement_Click(object sender, EventArgs e)
    {
        //this page will be directed to Account Management page 
        Response.Redirect("AccountManagement.aspx");
    }
}