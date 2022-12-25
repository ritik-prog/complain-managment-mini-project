using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace helphub
{
    public partial class REGISTER : Form
    {
        public REGISTER()
        {
            InitializeComponent();
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim() == "" && Password.Text.Trim() == "" && Aadhar.Text.Trim() == "" && Contact.Text.Trim() == "" && Email.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
            string SQLitecnStr = @"Data Source=.\helphub.db";
            SQLiteConnection SQLiteConn = new SQLiteConnection();
            SQLiteCommand SQLitecmd = new SQLiteCommand();

            SQLiteConn.ConnectionString = SQLitecnStr;
            SQLiteConn.Open();

            SQLitecmd.Connection = SQLiteConn;

            SQLitecmd.CommandText = "insert into user(aadharno,username,mobilenumber,password,email) VALUES("+Aadhar.Text+",'"+ username.Text +"',"+ Contact.Text +",'"+ Password.Text +"','"+ Email.Text +"')";

            try {
                SQLitecmd.ExecuteNonQuery();
                MessageBox.Show("Registered Succesfully", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LOGIN login = new LOGIN();

                login.Show();

                this.Hide(); //Close Form1,the current open form.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration Failed: "+ ex.Message +"", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            SQLiteConn.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }
    }
}
