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
    public partial class frmEditUpdate : Form
    {
        //These lines of code create single dimensional arrays, and then initialize each array element with a name.
        //This makes the arrays store the data that can be used later
         private string[] CB1 = new[] { "Hardware", "Software" };
        private string[] CB2 = new[] { "Broken Fan", "Monitor Problems", "Keyboard"};
        private string[] CB3 = new[] { "Virus Removal", "Corrupt Files" };

        private void frmEditUpdate_Load(object sender, EventArgs e)
        {
            //On page load...

            //Fill in the text box with info
            txtInfo.Text = "My fan was broken and there was a lot of noise coming from it.";
            //Preselect specific item in combobox
            ddlService.SelectedItem = "Keyboard";
            //Preselect specific item in combobox
            ddlServiceType.SelectedItem = "Hardware";
            //Display preselected date
            ddlDatePicker.Value = new DateTime(2016, 01, 14);
            ctrlTimePicker.Value = new DateTime();
           
        }

        public frmEditUpdate()
        {
            InitializeComponent();
            ddlServiceType.SelectedIndexChanged += ddlServiceType_SelectedIndexChanged;
            //Add the range of items that are held in the array
            ddlServiceType.Items.AddRange(CB1);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        //button event for 'Continue' button
        private void btnContinue_Click(object sender, EventArgs e)
        {
            //create instance of form
            frmOrderSummary Summary = new frmOrderSummary();
            //display the form
            Summary.Show();
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
                //case 1
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
    }
}
