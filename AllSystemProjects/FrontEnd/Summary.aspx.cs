using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Summary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnContinue_Click(object sender, EventArgs e)
    {
        //navigate to payment page
        Response.Redirect("Pay.aspx");
    }
}