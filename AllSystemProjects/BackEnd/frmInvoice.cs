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
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        int noOfInvoices;
        decimal totalOfInvoices;
        decimal invoiceAvg;

 

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
            decimal Subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
            decimal discountPercent = .25m; //25%
            decimal discountAmount = Subtotal * discountPercent;
            decimal total = Subtotal - discountAmount;

            noOfInvoices++;
            totalOfInvoices += total;
            invoiceAvg = totalOfInvoices / noOfInvoices;

            txtSubtotal.Text = txtEnterSubtotal.Text;
            txtDiscount.Text = discountPercent.ToString();
            txtDiscountAmount.Text = discountAmount.ToString();
            txtTotal.Text = total.ToString();

            txtInvoiceNumber.Text = noOfInvoices.ToString();
            txtServiceOrder.Text = noOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString();
            txtInvoiceAverage.Text = invoiceAvg.ToString();

            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();
        }

        private void buttonCancelInvoice_Click(object sender, EventArgs e)
        {
            noOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAvg = 0m;

            txtDiscountAmount.Text = "";
            txtDiscount.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInvoiceList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceList view = new frmInvoiceList();
            view.ShowList();
            view.ShowDialog();
            this.Close();
        }    
    }
}
