using MyClassLibrary;
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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this closes the form
            Close();
        }

        private void btnEmailClient_Click(object sender, EventArgs e)
        {
            //this sends us to the private function showemail
            ShowEmail();
        }

        private void emailClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this Sends us to the private function Showemail
            ShowEmail();
        }

        private void ShowEmail()
        {
            //this shows the new EmailClient Form
            FrmEmailClient EmailClient = new FrmEmailClient();
            EmailClient.Show();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
