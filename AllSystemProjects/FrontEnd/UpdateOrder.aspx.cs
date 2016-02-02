using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //update button event
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //if there is no order number entered in field...
        if (txtUpdate.Text == "")
        {
            //print error message
            lblMessage.Text = "Please enter a valid order number";
        }
            //otherwise
        else
        {
            //if everything is fine, navigate to the 'Edit Update' page
            Response.Redirect("EditUpdate.aspx");
        }
    }
}