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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace helphub
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            Username.Focus();
            Username.Select();
        }

        public List<string> StateList = new List<string> {
            "AP|Andhra Pradesh",
            "AR|Arunachal Pradesh",
            "AS|Assam",
            "BR|Bihar",
            "CT|Chhattisgarh",
            "GA|Goa",
            "GJ|Gujarat",
            "HR|Haryana",
            "HP|Himachal Pradesh",
            "JK|Jammu and Kashmir",
            "JH|Jharkhand",
            "KA|Karnataka",
            "KL|Kerala",
            "MP|Madhya Pradesh",
            "MH|Maharashtra",
            "MN|Manipur",
            "ML|Meghalaya",
            "MZ|Mizoram",
            "NL|Nagaland",
            "OR|Odisha",
            "PB|Punjab",
            "RJ|Rajasthan",
            "SK|Sikkim",
            "TN|Tamil Nadu",
            "TG|Telangana",
            "TR|Tripura",
            "UT|Uttarakhand",
            "UP|Uttar Pradesh",
            "WB|West Bengal",
            "AN|Andaman and Nicobar Islands",
            "CH|Chandigarh",
            "DN|Dadra and Nagar Haveli",
            "DD|Daman and Diu",
            "DL|Delhi",
            "LD|Lakshadweep",
            "PY|Puducherry"};


        private void Button2_Click(object sender, EventArgs e)
        {
            if (Username.Text.Trim() == "" || Password.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                try
                {
                    string SQLitecnStr = @"Data Source=./helphub.db";
                    SQLiteConnection SQLiteConn = new SQLiteConnection();
                    SQLiteCommand SQLitecmd = new SQLiteCommand();
                    SQLiteConn.ConnectionString = SQLitecnStr;
                    SQLiteConn.Open();
                    SQLitecmd.Connection = SQLiteConn;
                    SQLitecmd.CommandText = "SELECT * FROM user WHERE username='" + Username.Text + "' AND password='" + Password.Text + "'";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if(dt.Rows.Count == 1)
                    {
                        if (dt.Rows[0]["banned"].ToString() == "YES")
                        {
                            MessageBox.Show("Account Banned", "SECURITY SYSTEM HELPHUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        foreach (DataRow row in dt.Rows)
                        {
                            UserData.ID = row["ID"].ToString();
                            UserData.username = row["username"].ToString();
                            UserData.aadharno = row["aadharno"].ToString();
                            UserData.mobilenumber = row["mobilenumber"].ToString();
                            UserData.password = row["password"].ToString();
                            UserData.email = row["email"].ToString();
                            UserData.role = row["Role"].ToString();
                            UserData.address = row["address"].ToString();
                        }

                        if (UserData.role == "ADMIN" || UserData.role == "SUPERVISOR" || StateList.Contains(UserData.role))
                        {
                            ADMIN admin = new ADMIN();

                            admin.Show();

                            this.Hide(); //Close Form1,the current open form.
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Logedin Succesfully", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DASHBOARD dashboard = new DASHBOARD();

                            dashboard.Show();

                            this.Hide(); //Close Form1,the current open form.
                        }
                    }
                    else if (dt.Rows.Count >= 2)
                    {
                        MessageBox.Show("Multiple Username Error, Kindly Contact Admin....", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SQLitecmd.CommandText = "SELECT * FROM user WHERE username='" + Username.Text + "'";
                        da = new SQLiteDataAdapter(SQLitecmd);
                        da.Fill(dt);
                        if (dt.Rows.Count != 1)
                        {
                            MessageBox.Show("Username Doesn't Exists, Kindly Register now", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            REGISTER register = new REGISTER();

                            register.Show();

                            this.Hide(); //Close Form1,the current open form.
                        }
                        else
                        {
                            MessageBox.Show("Wrong Credentials", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    SQLiteConn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login Failed", ex.Message);
                    Console.WriteLine(ex);
                }


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            REGISTER register = new REGISTER();

            register.Show();

            this.Hide(); //Close Form1,the current open form.
        }
        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password.Focus();
            }
        }
        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button2_Click(null, EventArgs.Empty);
            }
        }
    }
}
