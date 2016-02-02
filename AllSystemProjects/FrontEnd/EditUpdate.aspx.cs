using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditUpdate : System.Web.UI.Page
{
    //this is the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //fill in the text boxes right away when the page loads, so user can edit it
        txtDate.Text = "13/01/2016";
        txtTime.Text = "13.00";
        txtInfo.Text = "My monitor has been experiencing colour and compatibility issues with any new hardware that I purchase. It has got a red tint and the connection keeps coming loose.";
    }
    protected void ddlService_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlServiceType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    //this function handles the 'Confirm' button
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //if there is no date entered in field..
        if (txtDate.Text == "")
        {
            //print error message
            lblMessage.Text = "Please enter all compulsory fields";
        }
        if
            //if there is no time entered in field..
            (txtTime.Text == "")
        {
            //print error message
            lblMessage.Text = "Please enter all compulsory fields";
        }
            //otherwise
        else
        {
            //print confirmation message
            lblMessage.Text = "Your service order has been updated";
        }   
    }
    protected void txtDate_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtInfo_TextChanged(object sender, EventArgs e)
    {

    }
}