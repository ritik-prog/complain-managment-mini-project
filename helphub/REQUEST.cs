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

namespace helphub
{
    public partial class REQUEST : Form
    {
        public REQUEST()
        {
            InitializeComponent();
            Aadhar.Text = UserData.aadharno;
            Contact.Text = UserData.mobilenumber;
            ComboBox1.SelectedItem = "MEDICAL EMERGENCY";
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (DREQUEST.Text.Trim() == "" && Address.Text.Trim() == "" && Aadhar.Text.Trim() == "" && Contact.Text.Trim() == "" && ComboBox1.SelectedItem.ToString() == "")
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

                    SQLitecmd.CommandText = "insert into request(aadharno,typeofrequest,mobilenumber,aboutrequest,address) VALUES(" + Aadhar.Text + ",'" + typeofcomplain + "'," + Contact.Text + ",'" + DREQUEST.Text + "','" + Address.Text + "')";

                    try
                    {
                        SQLitecmd.ExecuteNonQuery();
                        MessageBox.Show("Request received, Checkout in status section", "Complain", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        STATUS status = new STATUS();

                        status.Show();

                        this.Hide(); //Close Form1,the current open form.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't Register Your Request: " + ex.Message + "", "Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    SQLiteConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Record your Request: "+ ex.Message +"", "Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
