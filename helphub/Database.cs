using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace helphub
{
    public class Database
    {
        // staic obj variable of class so it can be accessed without create object 
        public static Database databaseobj = new Database();

        public DataTable dt = new DataTable();
        public DataTable dt1 = new DataTable();

        string SQLitecnStr = @"Data Source=.\helphub.db";
        SQLiteConnection SQLiteConn = new SQLiteConnection();

        SQLiteCommand SQLitecmd = new SQLiteCommand();
        SQLiteCommand SQLitecmd1 = new SQLiteCommand();

        public Database()
        {
            SQLiteConn.ConnectionString = SQLitecnStr;
            SQLiteConn.Open();
            SQLitecmd.Connection = SQLiteConn;
        }

        void checkconn()
        {
            if(SQLiteConn.State == ConnectionState.Closed)
            {
                SQLiteConn.Open();
            }
        } 

        // state list
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

        // clear function
        public void clear()
        {
            dt.Clear();
            dt.Columns.Clear();
            dt1.Clear();
            dt1.Columns.Clear();
        }

        // common functions
        public Boolean check_username_exist(string username)
        {
            clear();
            checkconn();
            SQLitecmd.CommandText = "SELECT * FROM user WHERE username='" + username + "'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        public int deleteaccount(string username,string formname)
        {
            try
            {
                clear();
                checkconn();
                SQLitecmd.CommandText = "DELETE FROM user WHERE ID=" + UserData.ID + "";

                int status = SQLitecmd.ExecuteNonQuery();

                if (status == 0)
                {
                    CreateLogs.createlogobj.userlog(username, "Unable to delete account", formname);
                    MessageBox.Show("Unable to Delete Account");
                    return 0;
                }
                else
                {
                    CreateLogs.createlogobj.userlog(username, "Account Deleted", formname);
                    MessageBox.Show("Account Successfully Deleted", "Account Deleted");
                    LOGIN login = new LOGIN();
                    login.Show();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                CreateLogs.createlogobj.userlog(username, "Unable to delete account " + ex.Message, formname);
                MessageBox.Show("Unable to Delete Account", ex.Message);
            }
            return 0;
        }

        public void FetchData(DataGridView complaindataview, DataGridView requestdataview)
        {
            clear();
            checkconn();
            try
            {
                // connection + query
                SQLitecmd.Connection = SQLiteConn;
                SQLitecmd.CommandText = "SELECT * FROM complaint WHERE aadharno='" + UserData.aadharno + "'";
                // connection + query
                SQLitecmd1.Connection = SQLiteConn;
                SQLitecmd1.CommandText = "SELECT * FROM request WHERE aadharno='" + UserData.aadharno + "'";
                // data adapter
                SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
                SQLiteDataAdapter da1 = new SQLiteDataAdapter(SQLitecmd1);

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


        // specific function
        public void register(REGISTER passedFunction)
        {
            clear();
            checkconn();
            SQLitecmd.CommandText = "insert into user(aadharno,username,mobilenumber,password,email,address) VALUES('" + passedFunction.Aadhar.Text + "','" + passedFunction.username.Text + "','" + passedFunction.Contact.Text + "','" + passedFunction.Password.Text + "','" + passedFunction.Email.Text + "','" + passedFunction.Address.Text + "')";
            try
            {

                CreateLogs.createlogobj.userlog(passedFunction.username.Text, "User Registered", passedFunction.Name);
                SQLitecmd.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LOGIN login = new LOGIN();

                login.Show();

                passedFunction.Close(); //Close Form1,the current open form.
            }
            catch (SQLiteException ex)
            {
                int code = ex.ErrorCode;
                if (code == 19)
                {

                    CreateLogs.createlogobj.userlog(passedFunction.username.Text, "Already Registered Username/Aadhar Number", passedFunction.Name);
                    MessageBox.Show("Already Registered Username/Aadhar Number", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    CreateLogs.createlogobj.userlog(passedFunction.username.Text, "Database Error " + ex.Message, passedFunction.Name);
                    MessageBox.Show("Database Error: Error code:- " + code + ",Error message:- " + ex.Message + "", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                CreateLogs.createlogobj.userlog(passedFunction.username.Text, "Registration Failed " + ex.Message, passedFunction.Name);
                MessageBox.Show("Registration Failed: " + ex.Message + "", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void login(LOGIN passedFunction)
        {
            clear();
            checkconn();
            try
            {
                SQLitecmd.CommandText = "SELECT * FROM user WHERE username='" + passedFunction.Username.Text + "' AND password='" + passedFunction.Password.Text + "'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0]["banned"].ToString() == "YES")
                    {
                        CreateLogs.createlogobj.userlog(passedFunction.Username.Text, "Banned user tried login", passedFunction.Name);
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

                    if (UserData.role == "root")
                    {
                        ROOTDASHBOARD rootadmin = new ROOTDASHBOARD();
                        rootadmin.Show();
                        passedFunction.Close();
                        return;
                    }

                    if (UserData.role == "SUPERADMIN")
                    {
                        SUPERADMIN superadmin = new SUPERADMIN();
                        superadmin.Show();
                        passedFunction.Close();
                        return;
                    }

                    if (UserData.role == "ADMIN" || UserData.role == "SUPERVISOR" || StateList.Contains(UserData.role))
                    {
                        CreateLogs.createlogobj.userlog(passedFunction.Username.Text, UserData.role + " Logged in", passedFunction.Name);
                        CreateLogs.createlogobj.adminlog(passedFunction.Text, "Logged in", passedFunction.Name, UserData.role);
                        ADMIN admin = new ADMIN();

                        admin.Show();

                        passedFunction.Close(); //Close Form1,the current open form.
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Logged in Successfully", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CreateLogs.createlogobj.userlog(passedFunction.Username.Text, UserData.role + " Logged in", passedFunction.Name);
                        DASHBOARD dashboard = new DASHBOARD();

                        dashboard.Show();

                        passedFunction.Close(); //Close Form1,the current open form.
                    }
                }
                else if (dt.Rows.Count >= 2)
                {
                    CreateLogs.createlogobj.userlog(passedFunction.Username.Text, "Multiple accounts error", passedFunction.Name);
                    MessageBox.Show("Multiple Username Error, Kindly Contact Admin....", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!check_username_exist(passedFunction.Username.Text))
                    {
                        CreateLogs.createlogobj.userlog(passedFunction.Username.Text, "Username Doesnt Exists", passedFunction.Name);
                        MessageBox.Show("Username Doesn't Exists, Kindly Register now", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        REGISTER register = new REGISTER();

                        register.Show();

                        passedFunction.Close(); //Close Form1,the current open form.
                    }
                    else
                    {
                        CreateLogs.createlogobj.userlog(passedFunction.Username.Text, UserData.role + " Wrong Credentials", passedFunction.Name);
                        MessageBox.Show("Wrong Credentials", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                CreateLogs.createlogobj.userlog(passedFunction.Username.Text, UserData.role + " login failed", passedFunction.Name);
                MessageBox.Show("Login Failed", ex.Message);
            }
        }

        public void complaint(COMPLAINT passedFunction)
        {
            clear();
            checkconn();
            try
            {
                String typeofcomplain = passedFunction.ComboBox1.SelectedItem.ToString();
                String state = passedFunction.comboBox2.SelectedItem.ToString();

                SQLitecmd.CommandText = "insert into complaint(aadharno,typeofcomplain,mobilenumber,aboutcomplain,address,state,city,username) VALUES('" + passedFunction.Aadhar.Text + "','" + typeofcomplain + "','" + passedFunction.Contact.Text + "','" + passedFunction.Dcomplaint.Text + "','" + passedFunction.Address.Text + "','" + state + "','" + passedFunction.city.Text + "','" + UserData.username + "')";

                try
                {

                    CreateLogs.createlogobj.userlog(UserData.username, "Complain filled", passedFunction.Name);
                    SQLitecmd.ExecuteNonQuery();
                    MessageBox.Show("complain Filled, Checkout in status section", "Complain", MessageBoxButtons.OK);
                    STATUS status = new STATUS();

                    status.Show();

                    passedFunction.Close(); //Close Form1,the current open form.
                }
                catch (Exception ex)
                {

                    CreateLogs.createlogobj.userlog(UserData.username, "Unable to file complain: " + ex.Message, passedFunction.Name);
                    MessageBox.Show("Unable to file complain: " + ex.Message + "", "Complain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                CreateLogs.createlogobj.userlog(UserData.username, "Unable to file complain: " + ex.Message, passedFunction.Name);
                MessageBox.Show("Unable to File Complain", ex.Message);
                Console.WriteLine(ex);
            }
        }

        public void request(REQUEST passedFunction)
        {
            clear();
            checkconn();
            try
            {
                String typeofcomplain = passedFunction.ComboBox1.SelectedItem.ToString();
                String state = passedFunction.comboBox2.SelectedItem.ToString();

                SQLitecmd.CommandText = "insert into request(aadharno,typeofrequest,mobilenumber,aboutrequest,address,state,city,username) VALUES('" + passedFunction.Aadhar.Text + "','" + typeofcomplain + "','" + passedFunction.Contact.Text + "','" + passedFunction.DREQUEST.Text + "','" + passedFunction.Address.Text + "','" + state + "','" + passedFunction.city.Text + "','" + UserData.username + "')";

                try
                {

                    SQLitecmd.ExecuteNonQuery();
                    MessageBox.Show("Request received, Checkout in status section", "Request", MessageBoxButtons.OK);
                    CreateLogs.createlogobj.userlog(UserData.username, "User sent a request", passedFunction.Name);
                    STATUS status = new STATUS();

                    status.Show();

                    passedFunction.Close(); //Close Form1,the current open form.
                }
                catch (Exception ex)
                {
                    CreateLogs.createlogobj.userlog(UserData.username, "Can't Register Your Request: " + ex.Message, passedFunction.Name);
                    MessageBox.Show("Can't Register Your Request: " + ex.Message + "", "Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SQLiteConn.Close();
            }
            catch (Exception ex)
            {
                CreateLogs.createlogobj.userlog(UserData.username, "Can't Register Your Request: " + ex.Message, passedFunction.Name);
                MessageBox.Show("Unable to Record your Request: " + ex.Message + "", "Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }

        
    }
}
