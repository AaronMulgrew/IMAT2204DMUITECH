using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class frmInvoiceList : Form
    {
        public string[] UpdateValue = new string[7];

        public frmInvoiceList()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listView1.Columns.Add("InvoiceNo", 70);
            listView1.Columns.Add("FirstName", 90);
            listView1.Columns.Add("LastName", 90);
            listView1.Columns.Add("Address", 120);
            listView1.Columns.Add("Amount", 70);
            listView1.Columns.Add("InvoiceName", 80);
            listView1.Columns.Add("InvoiceDate", 135);

            listView1.View = View.Details;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceListSubmit add = new frmInvoiceListSubmit();
            add.ShowDialog();
            this.Close();
        }

        SqlConnection conn =
            new SqlConnection(
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Invoice.mdf;Integrated Security=True;Connect Timeout=30");

        SqlCommand command;
        SqlDataReader reader;

        public void ShowList()
        {
            conn.Open();
            command = new SqlCommand("SELECT * FROM tblInvoice", conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string[] Row =
                {
                    reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                    reader[6].ToString()
                };
                ListViewItem item = new ListViewItem(Row);
                listView1.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }

        public void ShowList(string Query)
        {
            listView1.Items.Clear();
            try
            {
                conn.Open();
                command = new SqlCommand(Query, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string[] Row =
                    {
                        reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                        reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                        reader[6].ToString()
                    };
                    ListViewItem item = new ListViewItem(Row);
                    listView1.Items.Add(item);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Please Check your search inputs");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (UpdateValue[0] != null)
            {
                this.Hide();
                frmUpdateWindow up = new frmUpdateWindow();
                up.UpdateList(UpdateValue);
                up.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Select A record");
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                UpdateValue[0] = listView1.SelectedItems[0].SubItems[0].Text;
                UpdateValue[1] = listView1.SelectedItems[0].SubItems[1].Text;
                UpdateValue[2] = listView1.SelectedItems[0].SubItems[2].Text;
                UpdateValue[3] = listView1.SelectedItems[0].SubItems[3].Text;
                UpdateValue[4] = listView1.SelectedItems[0].SubItems[4].Text;
                UpdateValue[5] = listView1.SelectedItems[0].SubItems[5].Text;
                UpdateValue[6] = listView1.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (UpdateValue[0] != null)
            {
                if (MessageBox.Show("Confirm DELETE This Record ? ", "DELETE", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    int DeleteID = Convert.ToInt32(UpdateValue[0]);
                    clsInvoiceCollection Delete = new clsInvoiceCollection();
                    Delete.DeleteInvoice(DeleteID);
                    this.Hide();
                    frmInvoiceList In = new frmInvoiceList();
                    In.ShowList();
                    In.ShowDialog();
                    this.Close();

                }

            }
            else
            {
                MessageBox.Show("Select A record");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string Search = "";
            if (SearchBy.Text != "")
            {
                SearchBy.BackColor = Color.White;
                if (SearchText.Text != "")
                {
                    SearchText.BackColor = Color.White;
                    if (SearchBy.Text == "Name")
                    {
                        Search = "SELECT * FROM tblInvoice WHERE FirstName='" + SearchText.Text + "'";
                    }
                    else if (SearchBy.Text == "Date")
                    {
                        Search = "SELECT * FROM tblInvoice WHERE InvoiceDate='" + SearchText.Text + "'";
                    }
                    clsInvoiceCollection Searchobj = new clsInvoiceCollection();
                    ShowList(Search);
                }
                else
                {
                    SearchText.BackColor = Color.Yellow;
                }
            }
            else
            {
                SearchBy.BackColor = Color.Yellow;
            }
        }

        private void SortByDate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            command = new SqlCommand("SELECT * FROM tblInvoice ORDER BY InvoiceDate", conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string[] Row =
                {
                    reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                    reader[6].ToString()
                };
                ListViewItem item = new ListViewItem(Row);
                listView1.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            string PrintFile = "PrintFile.txt";
            if (!File.Exists(PrintFile))
            {
                File.Create(PrintFile).Close();
            }

            int Rows, index = 0, Subindex = 0;
            string Text = "";
            StreamWriter file = new StreamWriter(PrintFile);

            if (listView1.SelectedItems.Count > 0)
            {
                Rows = listView1.SelectedItems.Count;

                while (Rows != 0)
                {
                    Text = listView1.SelectedItems[index].SubItems[Subindex].Text;
                    Subindex++;
                    Text += " " + listView1.SelectedItems[index].SubItems[Subindex].Text;
                    Subindex++;
                    Text += " " + listView1.SelectedItems[index].SubItems[Subindex].Text;
                    Subindex++;
                    Text += " " + listView1.SelectedItems[index].SubItems[Subindex].Text;
                    Subindex++;
                    Text += " " + listView1.SelectedItems[index].SubItems[Subindex].Text;
                    Subindex++;
                    Text += " " + listView1.SelectedItems[index].SubItems[Subindex].Text;
                    Subindex++;
                    Text += " " + listView1.SelectedItems[index].SubItems[Subindex].Text;
                    Rows--;
                    Subindex = 0;
                    index++;
                    file.WriteLine(Text);
                }
                file.Close();
                clsInvoiceCollection print = new clsInvoiceCollection();
                print.Print();
            }
            else
            {
                MessageBox.Show("Please Select Rows to Print");
            }
        }
    }
}
