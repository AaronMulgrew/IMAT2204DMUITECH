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
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //Navigate to the 'Update Order' page
        Response.Redirect("UpdateOrder.aspx");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //Navigate to the 'Cancel Order' page
        Response.Redirect("CancelOrder.aspx");
    }
    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        //Navigate to the 'Order List' page
        Response.Redirect("OrderList.aspx");

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Navigate to the 'Add Order' page
        Response.Redirect("AddOrder.aspx");
    }
}