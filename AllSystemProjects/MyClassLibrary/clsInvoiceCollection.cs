using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using MyClassLibrary;
using System.Windows.Forms;
using Spire.Pdf;
using System.Drawing;
using System.Drawing.Printing;
using Spire.Pdf.Graphics;


namespace MyClassLibrary
{
    public class clsInvoiceCollection
    {
        public int Count { get; set; }

        public DateTime InvoiceDate { get; set; }
        public DateTime InvoiceNo { get; set; }


        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Invoice.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command;
        public void AddInvoice(string[]Values)
        {
            try
            {
                conn.Open();
                command =
                    new SqlCommand(
                        "INSERT INTO tblInvoice(InvoiceNo,FirstName,LastName,Address,Amount,InvoiceName,InvoiceDate)" +
                        "VALUES(@NO,@FN,@LN,@ADD,@AM,@IN,@ID)", conn);
                command.Parameters.AddWithValue("@No", Values[0]);
                command.Parameters.AddWithValue("@FN", Values[1]);
                command.Parameters.AddWithValue("@LN", Values[2]);
                command.Parameters.AddWithValue("@ADD", Values[3]);
                command.Parameters.AddWithValue("@AM", Values[4]);
                command.Parameters.AddWithValue("@IN", Values[5]);
                command.Parameters.AddWithValue("@ID", Values[6]);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void UpdateInvoice(string[]Values)
        {
            try
            {
                conn.Open();
                command =
                    new SqlCommand(
                        "UPDATE tblInvoice SET FirstName=@FN,LastName=@LN," +
                                "Address=@ADD,Amount=@AM,InvoiceName=@IN,InvoiceDate=@ID WHERE InvoiceNo=@NO", conn);
                command.Parameters.AddWithValue("@No", Values[0]);
                command.Parameters.AddWithValue("@FN", Values[1]);
                command.Parameters.AddWithValue("@LN", Values[2]);
                command.Parameters.AddWithValue("@ADD", Values[3]);
                command.Parameters.AddWithValue("@AM", Values[4]);
                command.Parameters.AddWithValue("@IN", Values[5]);
                command.Parameters.AddWithValue("@ID", Values[6]);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void DeleteInvoice(int ID)
        {
            conn.Open();
            command=new SqlCommand("DELETE FROM tblInvoice WHERE InvoiceNo=@ID",conn);
            command.Parameters.AddWithValue("@ID",ID);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void Print()
        {
            string text = File.ReadAllText("PrintFile.txt");
            PdfDocument doc = new PdfDocument();
            PdfSection section = doc.Sections.Add();
            PdfPageBase page = section.Pages.Add();
            PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 11);
            PdfStringFormat format = new PdfStringFormat();
            format.LineSpacing = 20f;
            PdfBrush brush = PdfBrushes.Black;
            PdfTextWidget textWidget = new PdfTextWidget(text, font, brush);
            float y = 0;
            PdfTextLayout textLayout = new PdfTextLayout();
            textLayout.Break = PdfLayoutBreakType.FitPage;
            textLayout.Layout = PdfLayoutType.Paginate;
            RectangleF bounds = new RectangleF(new PointF(0, y), page.Canvas.ClientSize);
            textWidget.StringFormat = format;
            textWidget.Draw(page, bounds, textLayout);
            doc.SaveToFile("ToPrint.pdf", FileFormat.PDF);
            doc.LoadFromFile("ToPrint.pdf");
            PrintDialog dialogPrint = new PrintDialog();      
            dialogPrint.AllowPrintToFile = true;
            dialogPrint.AllowSomePages = true;
            dialogPrint.PrinterSettings.MinimumPage = 1;
            dialogPrint.PrinterSettings.MaximumPage = doc.Pages.Count;
            dialogPrint.PrinterSettings.FromPage = 1;
            dialogPrint.PrinterSettings.ToPage = doc.Pages.Count;

            if (dialogPrint.ShowDialog() == DialogResult.OK)
            {
                doc.PrintFromPage = dialogPrint.PrinterSettings.FromPage;
                doc.PrintToPage = dialogPrint.PrinterSettings.ToPage;
                doc.PrinterName = dialogPrint.PrinterSettings.PrinterName;
                PrintDocument printDoc = doc.PrintDocument;
                dialogPrint.Document = printDoc;
                printDoc.Print();
            }
            File.Delete("PrintFile.txt");
            File.Delete("ToPrint.pdf");
        }
    }

}
