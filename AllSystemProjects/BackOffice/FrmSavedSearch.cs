using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class FrmSavedSearch : Form
    {
        //this checks if the user is editing an item
        public Int32 EditCounter = 0;

        //this checks if the user has a selected index
        public Int32 selectedIndex = 0;

        public FrmSavedSearch()
        {
            InitializeComponent();
        }

        private void FrmSavedSearch_Load(object sender, EventArgs e)
        {
        }

        public void LoadSavedSearch()
        {
        }

        /// <summary>
        /// this is the public function EditSearch and it gets parameters from the listbox that
        /// is available on the Form SavedSearch
        /// </summary>
        /// <param name="MinAge"></param>
        /// <param name="MaxAge"></param>
        /// <param name="Location"></param>
        /// <param name="SelectedIndex"></param>

        public void EditSearch(Int32 MinAge, Int32 MaxAge, string Location, Int32 SelectedIndex)
        {
            //this sets the editCounter to 1 as the user is editing the item
            EditCounter = 1;

            //this gets the minimum age
            NumUpDwnAgeMin.Value = MinAge;
            //this gets the maximum age
            NumUpDownAgeMax.Value = MaxAge;
            //this gets the location
            txtBxLocation.Text = Location;
            //this gets the selectedIndex of the item selected
            selectedIndex = SelectedIndex;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this closes the current form
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //declares 3 variables
            Int32 AgeMin;
            Int32 AgeMax;
            string Location;

            //this converts the two values to Int32 and gets the location txt box
            AgeMin = Convert.ToInt32(NumUpDwnAgeMin.Value);
            AgeMax = Convert.ToInt32(NumUpDownAgeMax.Value);
            Location = txtBxLocation.Text;

            //these are some simple validation techniques, before the full ones are implemented in the main model
            if (Location == "")
            {
                lblError.Text = "Please enter a location";
            }

            else if (AgeMax < AgeMin)
            {
                lblError.Text = "The minimum age must be less than or equal to the maximum age";
            }

            //this runs if all the validation runs ok
            //this is also runs if the user is editing a current saved search
            else
            {
                //this loads the saved search within the EmailClient page
                if (EditCounter == 1)
                {
                    FrmEmailClient EmailClient = new FrmEmailClient();
                    EmailClient.FinishEdit(AgeMin, AgeMax, Location, selectedIndex);
                    EmailClient.Show();
                    this.Close();
                }
                //this loads the saved search if it is a new addition
                else
                {
                    FrmEmailClient EmailClient = new FrmEmailClient();
                    EmailClient.AddNewSavedSearch(AgeMin, AgeMax, Location);
                    EmailClient.Show();
                    this.Close();
                }
            }
        }
    }
}
