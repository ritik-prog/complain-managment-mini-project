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
            string SQLitecnStr = @"Data Source=C:\Users\ritikmakhija\source\repos\helphub\helphub\helphub.db";
            SQLiteConnection SQLiteConn = new SQLiteConnection();
            SQLiteCommand SQLitecmd = new SQLiteCommand();
            SQLiteDataReader SQLiteReader;

            SQLiteConn.ConnectionString = SQLitecnStr;
            SQLiteConn.Open();

            SQLitecmd.Connection = SQLiteConn;

            SQLitecmd.CommandText = "insert into user(aadharno,username,mobilenumber,password,email) VALUES("+Aadhar.Text+",'"+ username.Text +"',"+ Contact.Text +",'"+ Password.Text +"','"+ Email.Text +"')";

            try {
                SQLitecmd.ExecuteNonQuery();
                MessageBox.Show("Registered Succesfully");

                LOGIN login = new LOGIN();

                login.Show();

                this.Hide(); //Close Form1,the current open form.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration Failed",ex.Message);
            }


            SQLiteConn.Close();
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }
    }
}
