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
    public partial class frmUpdateEmailTest : Form
    {
        public frmUpdateEmailTest()
        {
            InitializeComponent();
        }

        private void frmUpdateEmailTest_Load(object sender, EventArgs e)
        {
            clsEmailCollection EmailCollection = new clsEmailCollection();
            //string Emails = EmailCollection.UpdateEmails.ToString();

        }
    }
}
