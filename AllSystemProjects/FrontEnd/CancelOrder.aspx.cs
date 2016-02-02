using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CancelOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //if there is no Order Number entered in field...
        if (txtCancel.Text == "")
        {
            //print error message
            lblMessage.Text = "Please enter a valid order number";
        }
            //otherwise
        else
        {
            //print confirmation message
            lblMessage.Text = "Your service order has been cancelled";
        }
    }
}