using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public partial class frmAddOrder : Form
    {
        //These lines of code create single dimensional arrays, and then initialize each array element with a name.
        //This makes the arrays store the data that can be used later
        private string[] CB1 = new[] { "Hardware", "Software" };
        private string[] CB2 = new[] { "Broken Fan", "Monitor Problems" };
        private string[] CB3 = new[] { "Virus Removal", "Corrupt Files" };

        public frmAddOrder()
        {
            InitializeComponent();
            ddlServiceType.SelectedIndexChanged += ddlServiceType_SelectedIndexChanged;
            //Add the range of items that are held in the array
            ddlServiceType.Items.AddRange(CB1);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void frmAddOrder_Load(object sender, EventArgs e)
        {
            //on fornm load, there is no service selected intitially
            ddlService.SelectedIndex = -1;
            //on fornm load, there is no service type selected intitially
            ddlServiceType.SelectedIndex = -1;

            //on form load, there is no date selected ie. just blank. Only when user picks it, does it change
            ddlDatePicker.CustomFormat = " ";
            ddlDatePicker.Format = DateTimePickerFormat.Custom;

            
        }

    

       

        private void ddlServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ddlServiceType.SelectedItem as string;
            //switch statement enables the second combobox to be populated depending on what item is selected from the first combo box
            switch (selectedValue)
            {
             //case 1
                    //when case 'Hardware' is executed...
                case "Hardware":
                    //clear the combo box...
                    ddlService.Items.Clear();
                    //..and add the items which are stored in array 'CB2'
                    ddlService.Items.AddRange(CB2);
                    //break statement ends case
                    break;
                    //case 2
                //when case 'Software' is executed...
              case "Software":
                    //clear the combo box...
                    ddlService.Items.Clear();
                    //..and add the items which are stored in array 'CB3'
                    ddlService.Items.AddRange(CB3);
                    //break statement ends case
                    break;
            }
        }

        private void ddlService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //button event for 'New' button
        private void btnNew_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmNewCustomer New = new frmNewCustomer();
            //display form
            New.Show();
        }
        //button event for 'Exisiting' button
        private void btnExisting_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmExistingCustomer Existing = new frmExistingCustomer();
            //display form
            Existing.Show();
        }

        private void ddlDatePicker_ValueChanged(object sender, EventArgs e)
        {
            //once user clicks on datetimepicker, then format the date to the standard format ie. date, month, year
            ddlDatePicker.Format = DateTimePickerFormat.Short;
        }

        private void ctrlTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

        
        
          
        
        
        
