using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class frmUpdateWindow : Form
    {
        public frmUpdateWindow()
        {
            InitializeComponent();
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
                                        MyClassLibrary.clsInvoiceCollection addData = new MyClassLibrary.clsInvoiceCollection();

                                        addData.UpdateInvoice(Values);
                                        this.Hide();
                                        frmInvoiceList In = new frmInvoiceList();
                                        In.ShowList();
                                        In.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                        textBoxInvoiceDate.BackColor = Color.Yellow;

                                }
                                else
                                    comboBoxInvoiceName.BackColor = Color.Yellow;

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

        public void UpdateList(string[] UpdateValues)
        {
            textBoxInvoiceNo.Text = UpdateValues[0];
            textBoxFirstName.Text = UpdateValues[1];
            textBoxLastName.Text = UpdateValues[2];
            textBoxAddress.Text = UpdateValues[3];
            textBoxAmount.Text = UpdateValues[4];
            comboBoxInvoiceName.Text = UpdateValues[5];
            textBoxInvoiceDate.Text = UpdateValues[6];
        }
    }
}
