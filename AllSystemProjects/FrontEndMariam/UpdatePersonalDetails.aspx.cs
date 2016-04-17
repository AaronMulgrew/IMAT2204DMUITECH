using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdatePersonalDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //dummy data inserted 
        txtFirstName.Text = "Jhon";
        txtLastName.Text = "Smith";
        txtEmailAddress.Text = "John.s@hotmail.co.uk";
        txtPhoneNumber.Text = "07568469452";
        txtDateOfBirth.Text = "12/05/1991";
        DDLGender.Text = "Male";
        txtAddress.Text = "54 Rose Road";
        txtCity.Text = "Leicester";
        txtPostcode.Text = "LE4 1FN";
      
    }
    protected void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //if there is no  new email entered in field..
        if (txtEmailAddress.Text == "")
        {
            //show error message
            lblMessage.Text = "Please enter all compulsory fields";
        }
        if (txtAddress.Text == "")
        {
            //show error message
            lblMessage.Text = "Please enter all compulsory fields";
        }
        if
            //if there is no time entered in field.
            (txtPhoneNumber.Text == "")
        {
            //show error message
            lblMessage.Text = "Please enter all compulsory fields";
        }
        //otherwise
        else
        {
            //send to confirmation page
            Response.Redirect("ConfirmUpdateDetails.aspx");
        }   
    }
    protected void txtEmailAddress_TextChanged(object sender, EventArgs e)
    {

    }
}