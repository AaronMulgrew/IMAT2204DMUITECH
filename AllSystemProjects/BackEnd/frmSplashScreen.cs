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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

        }
        //Here we are using the the timer class, from which we can genererate an event after a specific amount of time
        Timer tmr;
        private void frmSplashScreen_Shown(object sender, EventArgs e)
        {
            //cretae instance of timer class
             tmr = new Timer();
     //set time interval 2 sec- the splash screen should siplay for 2 seconds
     tmr.Interval = 2000;
     //starts the timer
     tmr.Start();
     tmr.Tick += tmr_Tick;
 }
 void tmr_Tick(object sender, EventArgs e)
 {
     //after 2 sec stop the timer - the splash screen should disappear
     tmr.Stop();
     //display mthe main menu form
     frmMainMenu mf = new frmMainMenu();
     //show the form
     mf.Show();
 
        }
    }
}
