using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddOrder : System.Web.UI.Page
{
    //this is the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //this line of code inserts an empty item into the dropdown list
        ddlServiceType.Items.Insert(0, new ListItem(String.Empty, String.Empty));
        //On page load, the empty item (which has index=0) gets selected
        ddlServiceType.SelectedIndex = 0;

        //this line of code inserts an empty item into the dropdown list
        ddlService.Items.Insert(0, new ListItem(String.Empty, String.Empty));
        //On page load, the empty item (which has index=0) gets selected
        ddlService.SelectedIndex = 0;
    }
    protected void ddlServiceType_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void ddlService_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    //this function handles the 'New' button
    protected void btnNew_Click(object sender, EventArgs e)
    {     
             
    }
    protected void txtDate_TextChanged(object sender, EventArgs e)
    {
       
        
    }
    protected void btnExisting_Click(object sender, EventArgs e)
    {
        //if there is no date entered in field...
        if (txtDate.Text == "")
        {
            //print error message
            lblMessage.Text = "Please enter all compulsory fields";
        }
        if
            //if there is no time entered in field...
            (txtTime.Text == "")
        {
            //print error message
            lblMessage.Text = "Please enter all compulsory fields";
        }
        //otherwise
        else
        {
            //if everything is fine, navigate to the 'Login' page
            Response.Redirect("Login_CreateOrder.aspx");
        }   
    }
    protected void txtInfo_TextChanged(object sender, EventArgs e)
    {

    }
}