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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace helphub
{
    public partial class COMPLAINT : Form
    {
        public COMPLAINT()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Dcomplaint.Text.Trim() == "" && Address.Text.Trim() == "" && Aadhar.Text.Trim() == "" && Contact.Text.Trim() == "" && ComboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string SQLitecnStr = @"Data Source=./helphub.db";
                    SQLiteConnection SQLiteConn = new SQLiteConnection();
                    SQLiteCommand SQLitecmd = new SQLiteCommand();

                    SQLiteConn.ConnectionString = SQLitecnStr;
                    SQLiteConn.Open();
                    SQLitecmd.Connection = SQLiteConn;
                    String typeofcomplain = ComboBox1.SelectedItem.ToString();

                    SQLitecmd.CommandText = "insert into complaint(aadharno,typeofcomplain,mobilenumber,aboutcomplain,address) VALUES(" + Aadhar.Text + ",'" + typeofcomplain + "'," + Contact.Text + ",'" + Dcomplaint.Text + "','" + Address.Text + "')";

                    try
                    {
                        SQLitecmd.ExecuteNonQuery();
                        MessageBox.Show("complain Filled, Checkout in status section", "Complain", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Registration Failed: " + ex.Message + "", "Complain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    SQLiteConn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to File Complain", ex.Message);
                    Console.WriteLine(ex);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DASHBOARD dashboard = new DASHBOARD();

            dashboard.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
