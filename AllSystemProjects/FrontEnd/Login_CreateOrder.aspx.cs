using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
       
        }
    protected void btnViewSummary_Click(object sender, EventArgs e)
{
    //if there is no username entered in field...
    if (txtUsername.Text == "")
    {
        //print error message
        lblMessage.Text = "Please enter a valid username";
    }
    //if there is no password entered in field...
    if (txtPassword.Text == "")
    {
        //print error message
        lblMessage.Text = "Please enter a valid password";
    }
    //otherwise
    else
    {
        //if everything is fine, navigate to the 'Account Management' page
        Response.Redirect("Summary.aspx");
}
}
}