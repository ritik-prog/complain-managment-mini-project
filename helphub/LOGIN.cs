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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string SQLitecnStr = @"Data Source=C:\Users\ritikmakhija\source\repos\helphub\helphub\helphub.db";
            SQLiteConnection SQLiteConn = new SQLiteConnection();
            SQLiteCommand SQLitecmd = new SQLiteCommand();
            SQLiteDataReader SQLiteReader;
            SQLiteConn.ConnectionString = SQLitecnStr;
            SQLiteConn.Open();
            SQLitecmd.Connection = SQLiteConn;
            SQLitecmd.CommandText = "SELECT * FROM user WHERE username='"+ Username.Text +"' AND password='"+ Password.Text + "'";
            try
            {
                SQLitecmd.ExecuteNonQuery();
                MessageBox.Show("Logedin Succesfully");

                DASHBOARD dashboard = new DASHBOARD();

                dashboard.Show();

                this.Hide(); //Close Form1,the current open form.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed", ex.Message);
            }


            SQLiteConn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            REGISTER register = new REGISTER();

            register.Show();

            this.Hide(); //Close Form1,the current open form.
        }
    }
}
