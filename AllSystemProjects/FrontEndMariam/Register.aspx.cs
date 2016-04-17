using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
using ClassLibrary;

public partial class Register : System.Web.UI.Page
{

    //function for adding new records
    void Add()
    {
        //create an instance of the customer 
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the webform 
        Boolean OK = CustomerBook.ThisCustomer.Valid(txtFirstName, txtLastName, txtEmailAddress, txtPassword, 
        txtPhoneNumber, txtDateOfBirth, ddlGender, txtAddress, txtCity, txtPostcode);
        //if the data is OK then add it to the object 
        if(OK == true)
        {
            //get the data entered by the user 
            CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
            CustomerBook.ThisCustomer.LastName =  txtLastName.Text;
            CustomerBook.ThisCustomer.EmailAddress = txtEmailAddress.Text;
            CustomerBook.ThisCustomer.Password = txtPassword.Text;
            CustomerBook.ThisCustomer.PhoneNumber = txtPhoneNumber.Text;
            CustomerBook.ThisCustomer.DateOfBirth = txtDateOfBirth.Text;
            CustomerBook.ThisCustomer.Gender = ddlGender.Text;
            CustomerBook.ThisCustomer.Address = txtAddress.Text;
            CustomerBook.ThisCustomer.City = txtCity.Text;
            CustomerBook.ThisCustomer.Postcode = txtPostcode.Text;
            //add the record
            CustomerBook.Add();
        }
        else
        {
            //report an error
            lblMessage.Text = "There was a Problem";
        }
    }



    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //Add the new record
        Add();
        //send to page confermation 
        Response.Redirect("Confirmation.aspx");



    }
}