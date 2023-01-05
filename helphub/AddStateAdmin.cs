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
    public partial class AddStateAdmin : Form
    {
        public AddStateAdmin()
        {
            InitializeComponent();
            state.SelectedItem = "AP|Andhra Pradesh";
        }

        private Boolean check_username_exist(string username)
        {
            string SQLitecnStr = @"Data Source=./helphub.db";
            SQLiteConnection SQLiteConn = new SQLiteConnection();
            SQLiteCommand SQLitecmd = new SQLiteCommand();
            SQLiteConn.ConnectionString = SQLitecnStr;
            SQLiteConn.Open();
            SQLitecmd.Connection = SQLiteConn;
            SQLitecmd.CommandText = "SELECT * FROM user WHERE username='" + username + "'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check_username_exist(username.Text))
            {
                    try
                    {
                        string SQLitecnStr = @"Data Source=./helphub.db";
                        SQLiteConnection SQLiteConn = new SQLiteConnection();
                        SQLiteCommand SQLitecmd = new SQLiteCommand();
                        SQLiteConn.ConnectionString = SQLitecnStr;
                        SQLiteConn.Open();
                        SQLitecmd.Connection = SQLiteConn;
                        SQLitecmd.CommandText = "UPDATE user SET role = '" + state.Text + "' WHERE username = '" + username.Text + "';";
                        try
                        {
                            SQLitecmd.ExecuteNonQuery();

                        CreateLogs.createlogobj.adminlog(UserData.username, "New state admin added :- " + username + " by  " + UserData.username + " state:- "+state.Text+"", this.Name, UserData.role);
                        MessageBox.Show("New admin added Succesfully");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Can't Add New Admin", ex.Message);
                            this.Close();
                        }
                        SQLiteConn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't Add New Admin", ex.Message);
                        this.Close();
                    }
            }
            else
            {
                MessageBox.Show("Username Doesn't Exists");
            }
        }
    }
}
