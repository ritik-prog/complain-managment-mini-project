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
    public partial class PROFILE : Form
    {
        public PROFILE()
        {
            InitializeComponent();
            username.Text = UserData.username;
            email.Text = UserData.email;
            mobilenumber.Text = UserData.mobilenumber;
            aadharnumber.Text = UserData.aadharno;
            address.Text = UserData.address;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UPDATEDETAILS updatedetails = new UPDATEDETAILS();
            updatedetails.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string confirm = Microsoft.VisualBasic.Interaction.InputBox("Type 'confirm' to delete account", "DELETE ACCOUNT", "", x, y);
            if (confirm == "" || confirm != "confirm")
            {
                MessageBox.Show("Wrong Input");
                return;
            }
            if (confirm == "confirm")
            {
                try
                {
                    string SQLitecnStr = @"Data Source=./helphub.db";
                    SQLiteConnection SQLiteConn = new SQLiteConnection();
                    SQLiteCommand SQLitecmd = new SQLiteCommand();
                    SQLiteConn.ConnectionString = SQLitecnStr;
                    SQLiteConn.Open();
                    SQLitecmd.Connection = SQLiteConn;
                    SQLitecmd.CommandText = "DELETE FROM user WHERE ID=" + UserData.ID + "";

                    int status = SQLitecmd.ExecuteNonQuery();

                    if(status == 0)
                    {
                        MessageBox.Show("Unable to Delete Account");
                    }
                    else
                    {
                        MessageBox.Show("Account Successfully Deleted","Account Deleted");
                        LOGIN login = new LOGIN();
                        login.Show();
                        this.Hide();
                    }

                    SQLiteConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Delete Account", ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DASHBOARD dashboard = new DASHBOARD();
            dashboard.Show();
            this.Hide();
        }
    }
}

