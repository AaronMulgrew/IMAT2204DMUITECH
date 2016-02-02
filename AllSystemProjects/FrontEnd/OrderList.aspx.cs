using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    //this is the form load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //on page load, add the order data to the text boxe
        txtAllOrders.Text = "120020002" + Environment.NewLine + "1255441112" + Environment.NewLine + "1255456712";
    }

    //filter button function
    protected void btnFilter_Click(object sender, EventArgs e)
    {

        //if there is no date entered in field...
        if(txtDate.Text == "")
        {
            //print error message
            lblMessage.Text = "Please enter a valid date";
        }
            //otherwise
        else
        {
            //if something has been entered, firstly empty the text box...
            txtAllOrders.Text = string.Empty;
            //..then keep one item in, so it gives the illusion of data having been filtered
            txtAllOrders.Text = "120020002";

        }
    }
    protected void txtAllOrders_TextChanged(object sender, EventArgs e)
    {

    }
}