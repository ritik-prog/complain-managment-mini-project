using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Windows.Forms;

namespace helphub
{
    public class SuperAdminDatabaseOperation
    {
        public DataTable dt = new DataTable();

        string SQLitecnStr = @"Data Source=.\helphub.db";
        SQLiteConnection SQLiteConn = new SQLiteConnection();
        SQLiteCommand SQLitecmd = new SQLiteCommand();
        public SuperAdminDatabaseOperation()
        {
            SQLiteConn.ConnectionString = SQLitecnStr;
            SQLiteConn.Open();
            SQLitecmd.Connection = SQLiteConn;
        }
        public void fetchusers()
        {
            SQLitecmd.CommandText = "Select * from user WHERE role='USER'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            dt.Clear();
            dt.Columns.Clear();
            da.Fill(dt);
        }
        public void fetchsupervisor()
        {
            SQLitecmd.CommandText = "Select * from user WHERE role='SUPERVISOR'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            dt.Clear();
            dt.Columns.Clear();
            da.Fill(dt);
        }
        public void fetchadmin()
        {
            SQLitecmd.CommandText = "Select * from user WHERE role='ADMIN'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            dt.Clear();
            dt.Columns.Clear();
            da.Fill(dt);
        }
        public void fetchsuperadmin()
        {
            SQLitecmd.CommandText = "Select * from user WHERE role='SUPERADMIN'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            dt.Clear();
            dt.Columns.Clear();
            da.Fill(dt);
        }

        public void fetchstateadmin()
        {
            SQLitecmd.CommandText = "Select * from user WHERE role!='SUPERADMIN' AND role!='root' AND  role!='ADMIN' AND  role!='SUPERVISOR' AND  role!='USER'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            dt.Clear();
            dt.Columns.Clear();
            da.Fill(dt);
        }

        public void FetchUserDetails(string username, string role, UPDATEDATABASE passedFunction)
        {
            try
            {
                SQLitecmd.CommandText = "SELECT * FROM user WHERE username='"+username+ "' AND role='"+role+"'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
                dt.Clear();
                dt.Columns.Clear();
                da.Fill(dt);
                if(dt.Rows.Count==0)
                {
                    MessageBox.Show("Username Doesn't Exists");
                    passedFunction.searchbox.Enabled = true;
                    return;
                }
                else
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        passedFunction.username.Text = row["username"].ToString();
                        passedFunction.aadharnumber.Text = row["aadharno"].ToString();
                        passedFunction.mobilenumber.Text = row["mobilenumber"].ToString();
                        passedFunction.email.Text = row["email"].ToString();
                        passedFunction.role.SelectedItem = row["Role"].ToString();
                        passedFunction.address.Text = row["address"].ToString();
                        passedFunction.password.Text = row["password"].ToString();
                        passedFunction.ban.SelectedItem = row["banned"].ToString() == "YES" ? "ban" : "unban";
                    }
                }
            }
            catch(Exception ex)
            {
                passedFunction.searchbox.Enabled = true;
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateUserDetails(UPDATEDATABASE passedFunction,Action fetchdata)
        {
            string banorunban = passedFunction.ban.SelectedItem == "ban" ? "YES" : "NO";
            SQLitecmd.CommandText = "UPDATE user SET role='"+ passedFunction.role.SelectedItem.ToString() + "',banned = '"+ banorunban + "', aadharno = '" + passedFunction.aadharnumber.Text + "',username = '" + passedFunction.username.Text + "',mobilenumber = '" + passedFunction.mobilenumber.Text + "',password = '" + passedFunction.password.Text + "',email = '" + passedFunction.email.Text + "',address='" + passedFunction.address.Text + "' WHERE username = '" + passedFunction.searchbox.Text + "'";
            try
            {
                int status = SQLitecmd.ExecuteNonQuery();
                if (status == 0)
                {
                    MessageBox.Show("Update Failed", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    fetchdata();
                    MessageBox.Show("Deatils Updated", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SQLiteException ex)
            {
                int code = ex.ErrorCode;

                if (code == 19)
                {
                    MessageBox.Show("Already Registered Username/Aadhar Number", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Database Error: Error code:- " + code + ",Error message:- " + ex.Message + "", "Update Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteUser(UPDATEDATABASE passedFunction,Action fetchdata)
        {
            SQLitecmd.CommandText = "DELETE from user WHERE username='"+passedFunction.username.Text+"'";
            try
            {
                int status = SQLitecmd.ExecuteNonQuery();
                if (status == 0)
                {
                    MessageBox.Show("Unable to Delete Account");
                }
                else
                {
                    fetchdata();
                    MessageBox.Show("Account Successfully Deleted", "Account Deleted");
                }
            }
            catch (SQLiteException ex)
            {
                int code = ex.ErrorCode;

                if (code == 19)
                {
                    MessageBox.Show("Already Registered Username/Aadhar Number", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Database Error: Error code:- " + code + ",Error message:- " + ex.Message + "", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void AddUser(ADDUSER passedFunction,string role,Action fetchdata)
        {
            SQLitecmd.CommandText = "insert into user(aadharno,username,mobilenumber,password,email,address,role) VALUES('" + passedFunction.aadharnumber.Text + "','" + passedFunction.username.Text + "','" + passedFunction.mobilenumber.Text + "','" + passedFunction.password.Text + "','" + passedFunction.email.Text + "','" + passedFunction.address.Text + "','" + role + "')";
            try
            {
                int status = SQLitecmd.ExecuteNonQuery();
                if (status == 0)
                {
                    MessageBox.Show("Unable to Add "+role+"");
                }
                else
                {
                    fetchdata();
                    MessageBox.Show(""+role+" Successfully Added", ""+role+" Added");
                }
            }
            catch (SQLiteException ex)
            {
                int code = ex.ErrorCode;

                if (code == 19)
                {
                    MessageBox.Show("Already Registered Username/Aadhar Number", "Add "+role+"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Database Error: Error code:- " + code + ",Error message:- " + ex.Message + "", "Add "+role+"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void FetchStateAdminDetails(string username, string role, UPDATESTATEADMINDATABASE passedFunction)
        {
            try
            {
                SQLitecmd.CommandText = "SELECT * FROM user WHERE username='" + username + "' AND role='" + role + "'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
                dt.Clear();
                dt.Columns.Clear();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Username Doesn't Exists");
                    passedFunction.searchbox.Enabled = true;
                    return;
                }
                else
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        passedFunction.username.Text = row["username"].ToString();
                        passedFunction.aadharnumber.Text = row["aadharno"].ToString();
                        passedFunction.mobilenumber.Text = row["mobilenumber"].ToString();
                        passedFunction.email.Text = row["email"].ToString();
                        passedFunction.role.SelectedItem = row["Role"].ToString();
                        passedFunction.address.Text = row["address"].ToString();
                        passedFunction.password.Text = row["password"].ToString();
                        passedFunction.ban.SelectedItem = row["banned"].ToString() == "YES" ? "ban" : "unban";
                    }
                }
            }
            catch (Exception ex)
            {
                passedFunction.searchbox.Enabled = true;
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateStateAdminDetails(UPDATESTATEADMINDATABASE passedFunction,Action fetchdata)
        {
            string banorunban = passedFunction.ban.SelectedItem == "ban" ? "YES" : "NO";
            SQLitecmd.CommandText = "UPDATE user SET role='" + passedFunction.role.SelectedItem.ToString() + "', banned = '" + banorunban + "', aadharno = '" + passedFunction.aadharnumber.Text + "',username = '" + passedFunction.username.Text + "',mobilenumber = '" + passedFunction.mobilenumber.Text + "',password = '" + passedFunction.password.Text + "',email = '" + passedFunction.email.Text + "',address='" + passedFunction.address.Text + "' WHERE username = '" + passedFunction.searchbox.Text + "'";
            try
            {
                int status = SQLitecmd.ExecuteNonQuery();
                if (status == 0)
                {
                    MessageBox.Show("Update Failed", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    fetchdata();
                    MessageBox.Show("Deatils Updated", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SQLiteException ex)
            {
                int code = ex.ErrorCode;

                if (code == 19)
                {
                    MessageBox.Show("Already Registered Username/Aadhar Number", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Database Error: Error code:- " + code + ",Error message:- " + ex.Message + "", "Update Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteStateAdmin(UPDATESTATEADMINDATABASE passedFunction,Action fetchdata)
        {
            SQLitecmd.CommandText = "DELETE from user WHERE username='" + passedFunction.username.Text + "'";
            try
            {
                int status = SQLitecmd.ExecuteNonQuery();
                if (status == 0)
                {
                    MessageBox.Show("Unable to Delete Account");
                }
                else
                {
                    fetchdata(); 
                    MessageBox.Show("Account Successfully Deleted", "Account Deleted");
                }
            }
            catch (SQLiteException ex)
            {
                int code = ex.ErrorCode;

                if (code == 19)
                {
                    MessageBox.Show("Already Registered Username/Aadhar Number", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Database Error: Error code:- " + code + ",Error message:- " + ex.Message + "", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
