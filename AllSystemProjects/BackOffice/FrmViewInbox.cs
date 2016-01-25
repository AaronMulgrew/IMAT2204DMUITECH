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
    public partial class FrmViewInbox : Form
    {
        public FrmViewInbox()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            ///these if statements check if the user has selected a row and puts in some dummy data for each of these emails

            if (this.dataGridViewInbox.CurrentCell.RowIndex == 0)
            {
                FrmViewEmail ShowEmail = new FrmViewEmail();
                ShowEmail.ShowEmail(1);
                ShowEmail.Show();
            }
            if (this.dataGridViewInbox.CurrentCell.RowIndex == 1)
            {
                FrmViewEmail ShowEmail2 = new FrmViewEmail();
                ShowEmail2.ShowEmail(2);
                ShowEmail2.Show();
            }
            else if (this.dataGridViewInbox.CurrentCell.RowIndex > 1)
            {
                lblError.Text = "Error, Please select Item 1 or 2";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void FrmViewInbox_Load(object sender, EventArgs e)
        {

            //this adds some dummy data to the DataGridView
            //I will remove this and replace with real data from the Database
            this.dataGridViewInbox.Rows.Add();
            this.dataGridViewInbox.Rows[0].Cells[0].Value = "Lara11@hotmail.co.uk";
            this.dataGridViewInbox.Rows[0].Cells[1].Value = "Refunds";
            this.dataGridViewInbox.Rows[0].Cells[2].Value = "9/12/2015";
            this.dataGridViewInbox.Rows[1].Cells[0].Value = "Lara11@hotmail.co.uk";
            this.dataGridViewInbox.Rows[1].Cells[1].Value = "Enquiry";
            this.dataGridViewInbox.Rows[1].Cells[2].Value = "1/12/2015";

            //this calls the timer function
            Timer();
        }

        /// <summary>
        /// this function is simply here to load a splash page as the emails will be loading from the server
        /// and this will take some time
        /// </summary>

        private void Timer()
        {
            timerLoading.Interval = 5000; // it will Tick for 5 seconds
            this.timerLoading.Start(); //this starts the timer
            timerLoading.Tick += (s, e) =>
            {
                //this runs when the timer has reached the interval
                lblLoading.Hide();
                picBxSpinning.Hide();
                timerLoading.Stop();
            };
        }

        private void btnDeleteEmail_Click(object sender, EventArgs e)
        {
            //this runs if there is more than 1 email in the DataGridView
            if (this.dataGridViewInbox.Rows.Count > 1)
            {
                try
                {
                    //this retrieves the current row index from the DataGridView property
                    Int32 CurrentCell = dataGridViewInbox.CurrentCell.RowIndex;
                    //this removes it at the selected index
                    //but will archive in final edition
                    this.dataGridViewInbox.Rows.RemoveAt(CurrentCell);
                }
                catch
                {
                    //this catches any possible errors that may occur
                    lblError.Text = "There has been an error";
                }
            }
            else
            {
                //this is due to DataGridView must have one row at all times
                lblError.Text = "Cannot archive last email";
            }
        }

        private void btnShowMoreEmails_Click(object sender, EventArgs e)
        {
            //these are the strings from the various subjects
            string Email = "SJAS@hotmail.co.uk";
            string Subject = "Hometown";
            string Date = "9/10/2015";
            //this adds the new email to the DataGridView
            dataGridViewInbox.Rows.Insert(dataGridViewInbox.Rows.Count - 1, Email, Subject, Date);
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
        }
    }
}
