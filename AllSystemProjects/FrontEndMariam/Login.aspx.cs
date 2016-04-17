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
        //if there is nothing entered.
        if (txtUsername.Text == "")
        {
            //show error message
            lblMessage.Text = "Please enter a valid username";
        }
        //if there is no password entered.
        if (txtPassword.Text == "")
        {
            //show error message
            lblMessage.Text = "Please enter a valid password";
        }
            //otherwise
        else
        
            //if all text boxes are not empty, redirect to the Account Management page
            Response.Redirect("AccountManagement.aspx");
        }
    }
