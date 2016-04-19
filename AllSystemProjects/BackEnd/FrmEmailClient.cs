using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace BackEnd
{
    public partial class FrmEmailClient : Form
    {
        //this is a high level variable IsGroup that checks whether the user is composing a group email
        bool IsGroup;

        public FrmEmailClient()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            //this checks to see if the user has selected an item from the listbox, as the default value is -1
            if (LstBxSavedSearch.SelectedIndex > -1)
            {
                string ListResult = LstBxSavedSearch.SelectedItem.ToString();

                Int32 AgeFrom = Convert.ToInt32(ListResult.Substring(7, 2));

                Int32 AgeTo = Convert.ToInt32(ListResult.Substring(10, 2));

                string Location = ListResult.Substring(22);

                clsCustomerSavedSearch NewSearch = new clsCustomerSavedSearch();
                string EmailAddress = NewSearch.SavedSearch(AgeFrom, AgeTo, Location);

                //this runs if the email address is initalised but never appended.
                if (EmailAddress == "")
                {
                    MessageBox.Show("No results found!");
                }
                else
                {
                    //this sends us to the showemail function with the IsGroup Bool value being set to true
                    IsGroup = true;
                    FrmComposeEmail newEmail = new FrmComposeEmail();
                    newEmail.GroupEmail(EmailAddress);

                    newEmail.Show();

                    //this closes the current form
                    this.Close();
                }



            }
            else
            {
                //this gives us an error message as nothing as been selected
                lblError.Text = "Please Select an item from the listbox";
            }
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            //this runs if someone selects "compose individual Email"
            //set the IsGroup to false
            IsGroup = false;
            //send us to the showemail function
            showEmail();


            //this closes the current form
            this.Close();
        }

        /// <summary>
        /// This is a private function
        /// that sorts out whether the user would like to compose a group email or an individual email
        /// </summary>
        private void showEmail()
        {
            //this runs of the user has selected group email
            if (IsGroup == true)
            {
            }
            else
            {
                //create a new instance of the frmComposeEmail form
                FrmComposeEmail NewIndividualEmail = new FrmComposeEmail();

                //this sends us to the NewEmail function in the NewIndividualEmail class
                NewIndividualEmail.NewEmail();

                //this shows the new form
                NewIndividualEmail.Show();
            }
        }

        private void buttonViewInbox_Click(object sender, EventArgs e)
        {
            //this shows the frmViewInbox form

            frmViewInbox NewViewInbox = new frmViewInbox();
            NewViewInbox.Show();

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this closes the form
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this shows the Saved search form and closes the current form 
            //(as the listbox doesn't properly refresh otherwise, due to persistent data)

            FrmSavedSearch NewSavedSearch = new FrmSavedSearch();
            NewSavedSearch.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //this checks to see if the listbox has a selected value
            if (LstBxSavedSearch.SelectedIndex > -1)
            {
                //this retrieves the Selected Item from the listBox on the EmailClient form
                string SavedSearchtext = LstBxSavedSearch.GetItemText(LstBxSavedSearch.SelectedItem);

                //this retrieves the Minimum age, the maximum age and the location via the Substring option available on the EmailClient form
                Int32 MinAge = Convert.ToInt32(SavedSearchtext.Substring(7, 2));
                Int32 MaxAge = Convert.ToInt32(SavedSearchtext.Substring(10, 2));
                string Location = SavedSearchtext.Substring(22);

                //this gets the selected index number from the listbox
                Int32 SelectedIndex = LstBxSavedSearch.SelectedIndex;

                //this gets the new instance of the form Saved Search and it sends the Parameters to the Editsearch function
                //on the saved search form, displays the saved search form
                //then closes the current form (this is due to issues regarding showing the new listbox items on the listbox)
                
                FrmSavedSearch SavedSearch = new FrmSavedSearch();
                SavedSearch.EditSearch(MinAge, MaxAge, Location, SelectedIndex);
                SavedSearch.Show();
                this.Close();
            }

            else
            {
                //this runs if user does not run selected item
                lblError.Text = "Please Select an item";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //this checks to see if the user has selected an item from the listbox, as the default value is -1
            if (LstBxSavedSearch.SelectedIndex > -1)
            {
                if (MessageBox.Show("Are you sure you want to delete this saved search?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //this removes item at the selected index
                    Int32 SelectedIndex = LstBxSavedSearch.SelectedIndex;
                    LstBxSavedSearch.Items.RemoveAt(SelectedIndex);
                }
 
            }
            else
            {
                //this gives us an error message as nothing as been selected
                lblError.Text = "Please Select an item to delete from the listbox";
            }

        }

        public void AddNewSavedSearch(Int32 AgeMin, Int32 AgeMax, string Location)
        {
            //this adds the new list box item from the Saved Search form
            //to the listbox
            string NewListBoxItem = "Age(s) " + AgeMin + "-" + AgeMax + " Location " + Location;
            LstBxSavedSearch.Items.Add(NewListBoxItem);
        }




        public void FinishEdit(Int32 AgeMin, Int32 AgeMax, string Location, Int32 SelectedIndex)
        {
            /// this Is the function for the Finish edit, it starts by removing 
            /// the item according to the SelectedIndex parameter
            /// then adds the edited listbox item at the bottom of the list
            LstBxSavedSearch.Items.RemoveAt(SelectedIndex);
            string EditedListBoxItem = "Age(s) " + AgeMin + "-" + AgeMax + " Location " + Location;
            LstBxSavedSearch.Items.Add(EditedListBoxItem);
        }

        private void btnViewArchive_Click(object sender, EventArgs e)
        {
            frmViewArchive newArchive = new frmViewArchive();
            newArchive.Show();
        }

        private void FrmEmailClient_Load(object sender, EventArgs e)
        {
            try
            {
                clsDataConnection NewConnection = new clsDataConnection();
                NewConnection.Execute("sproc_tblGroupList_GetAllGroupList");
                Int32 RecordCount = NewConnection.Count;
                Int32 Index = 0;
                while (Index < RecordCount)
                {
                    string dd = "Age(s) ";
                    dd += NewConnection.DataTable.Rows[Index]["AgeFrom"].ToString();
                    dd += NewConnection.DataTable.Rows[Index]["AgeTo"].ToString();
                    dd += NewConnection.DataTable.Rows[Index]["Location"].ToString();
                    LstBxSavedSearch.DataSource = dd;
                }
            }
            catch
            {
                MessageBox.Show("Group List Retreival failed, please try again");
            }
        }
    }
}
