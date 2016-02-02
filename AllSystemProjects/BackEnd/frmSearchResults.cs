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
    public partial class frmSearchResults : Form
    {
        public frmSearchResults()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the form
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //if there is no order date entered in field...
            if (txtFilter.Text == "")
            {
                //print error message
                 lblMessage.Text = "Please enter a Service Order date";
               
            }
           //otherwise
           else
           {
           
               //clear the list of items in the list box
           lstOrders.Items.Clear();
                //add an item to create the illusion of data being filtered
               lstOrders.Items.Add("129998880");
              
           }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void frmSearchResults_Load(object sender, EventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
