using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyClassLibrary;

namespace Invoice
{
    public partial class frmInvoiceListSubmit : Form
    {
        public frmInvoiceListSubmit()
        {
            InitializeComponent();
        }

        private void frmInvoiceListSubmit_Load(object sender, EventArgs e)
        {

        }
       
        private void butttonOK_Click(object sender, EventArgs e)
        {
            
            if (textBoxInvoiceNo.Text != "")
            {
                textBoxInvoiceNo.BackColor = Color.White;
                if (textBoxFirstName.Text != "")
                {
                    textBoxFirstName.BackColor = Color.White;
                    if (textBoxLastName.Text != "")
                    {
                        textBoxLastName.BackColor = Color.White;
                        if (textBoxAddress.Text != "")
                        {
                            textBoxAddress.BackColor = Color.White;

                            if (textBoxAmount.Text != "")
                            {
                                textBoxAmount.BackColor = Color.White;
                                if (comboBoxInvoiceName.Text != "")
                                {
                                    comboBoxInvoiceName.BackColor = Color.White;
                                    if (textBoxInvoiceDate.Text != "")
                                    {
                                        textBoxInvoiceDate.BackColor = Color.White;
                                        string[] Values =
                                        {
                                            textBoxInvoiceNo.Text,
                                            textBoxFirstName.Text,
                                            textBoxLastName.Text,
                                            textBoxAddress.Text,
                                            textBoxAmount.Text,
                                            comboBoxInvoiceName.Text,
                                            textBoxInvoiceDate.Text
                                        };
                                        clsInvoiceCollection addData = new clsInvoiceCollection();

                                        addData.AddInvoice(Values);
                                        this.Hide();
                                        frmInvoiceList In = new frmInvoiceList();
                                        In.ShowList();
                                        In.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                        textBoxInvoiceDate.BackColor=Color.Yellow;

                                }
                                else
                                    comboBoxInvoiceName.BackColor=Color.Yellow;

                            }
                            else
                                textBoxAmount.BackColor = Color.Yellow;
                        }
                        else
                            textBoxAddress.BackColor = Color.Yellow;
                    }
                    else
                        textBoxLastName.BackColor = Color.Yellow;
                }
                else
                    textBoxFirstName.BackColor = Color.Yellow;
            }
            else
                textBoxInvoiceNo.BackColor = Color.Yellow;
        }

       

    }
}
