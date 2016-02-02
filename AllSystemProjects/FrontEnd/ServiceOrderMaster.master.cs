using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServiceOrderMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void btnServices_Click(object sender, EventArgs e)
    {
        Response.Redirect("Services.aspx");
    }
    protected void btnAddOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddOrder.aspx");
    }
    protected void btnHelp_Click(object sender, EventArgs e)
    {
        Response.Redirect("Help.aspx");
    }
    protected void btnAbout_Click(object sender, EventArgs e)
    {
        Response.Redirect("About.aspx");
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}
