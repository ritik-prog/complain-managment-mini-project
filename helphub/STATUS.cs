using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace helphub
{
    public partial class STATUS : Form
    {
        public STATUS()
        {
            InitializeComponent();
            FetchData();
        }
        public void FetchData()
        {
            try
            {
                string SQLitecnStr = @"Data Source=./helphub.db";
                SQLiteConnection SQLiteConn = new SQLiteConnection();
                SQLiteCommand SQLitecmd = new SQLiteCommand();
                SQLiteCommand SQLitecmd1 = new SQLiteCommand();
                SQLiteConn.ConnectionString = SQLitecnStr;
                SQLiteConn.Open();
                // connection + query
                SQLitecmd.Connection = SQLiteConn;
                SQLitecmd.CommandText = "SELECT * FROM complaint WHERE aadharno='"+ UserData.aadharno +"'";
                // connection + query
                SQLitecmd1.Connection = SQLiteConn;
                SQLitecmd1.CommandText = "SELECT * FROM request WHERE aadharno='"+ UserData.aadharno +"'";
                // data adapter
                SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
                SQLiteDataAdapter da1 = new SQLiteDataAdapter(SQLitecmd1);
                // data table
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                // filling data in datatable with adapter
                da.Fill(dt);
                da1.Fill(dt1);

                if (dt.Rows.Count > 0 || dt1.Rows.Count > 0)
                {
                    complaindataview.DataSource = dt;
                    requestdataview.DataSource = dt1;
                }
                else
                {
                    MessageBox.Show("No records found", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                SQLiteConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Load Data", ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DASHBOARD dashboard = new DASHBOARD();

            dashboard.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (complaindataview.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(complaindataview.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in complaindataview.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in complaindataview.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                Paragraph para = new Paragraph("HELPHUB - COMPLAINS REPORT\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 22));
                                para.Alignment = Element.ALIGN_CENTER;
                                document.Add(para);
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (requestdataview.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(requestdataview.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in requestdataview.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in requestdataview.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                Paragraph para = new Paragraph("HELPHUB - REQUESTS REPORT\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 22));
                                para.Alignment = Element.ALIGN_CENTER;
                                document.Add(para);
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
    }
}
