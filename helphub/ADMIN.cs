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
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace helphub
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
            if (UserData.role != "SUPERADMIN" && UserData.role != "root")
            {
                superadmin.Hide();
                pictureBox4.Hide();
            }
            if (UserData.role != "ADMIN" && UserData.role != "SUPERADMIN" && UserData.role != "root")
            {
                pictureBox5.Hide();
                pictureBox6.Hide();
                pictureBox7.Hide();
                button3.Hide();
                button4.Hide();
                pictureBox1.Width = 682;
                pictureBox1.Height = 736;
                pictureBox1.Location = new Point(-168, -139);
            }
            if (UserData.role != "ADMIN" && UserData.role != "SUPERVISOR" && UserData.role != "SUPERADMIN" && UserData.role != "root")
            {
                label5.Hide();
                comboBox3.Hide();
                label6.Hide();
                comboBox4.Hide();
            }
            ComboBox1.SelectedItem = "ALL REQUEST";
            comboBox2.SelectedItem = "ALL COMPLAINS";
            comboBox3.SelectedItem = "ALL STATE";
            comboBox4.SelectedItem = "ALL STATE";
            fetchData();
            CreateLogs.createlogobj.adminlog(UserData.username, "Checking Admin Panel", this.Name, UserData.role);
        }

        public void fetchData()
        {
            try
            {
                string SQLitecnStr = @"Data Source=./helphub.db";
                SQLiteConnection SQLiteConn = new SQLiteConnection();
                SQLiteCommand SQLitecmd = new SQLiteCommand();
                SQLiteCommand SQLitecmd1 = new SQLiteCommand();
                SQLiteConn.ConnectionString = SQLitecnStr;
                SQLiteConn.Open();
                SQLitecmd.Connection = SQLiteConn;
                SQLitecmd1.Connection = SQLiteConn;
                SQLitecmd.CommandText = "";
                SQLitecmd1.CommandText = "";
                CreateLogs.createlogobj.adminlog(UserData.username, "Fetching Data of complain and request", this.Name, UserData.role);
                if (UserData.role == "ADMIN" || UserData.role == "SUPERVISOR" || UserData.role == "SUPERADMIN" || UserData.role == "root")
                {
                    if (comboBox2.SelectedItem == "ALL COMPLAINS" && comboBox3.SelectedItem == "ALL STATE")
                    {
                        SQLitecmd.CommandText = "SELECT * FROM complaint";
                    }
                    else if (comboBox2.SelectedItem == "ALL COMPLAINS" && comboBox3.SelectedItem != "ALL STATE")
                    {
                        SQLitecmd.CommandText = "SELECT * FROM complaint WHERE state = '" + comboBox3.SelectedItem + "'";
                    }
                    else if (comboBox2.SelectedItem != "ALL COMPLAINS" && comboBox3.SelectedItem == "ALL STATE")
                    {
                        SQLitecmd.CommandText = "SELECT * FROM complaint WHERE typeofcomplain = '" + comboBox2.SelectedItem + "'";
                    }
                    else
                    {
                        SQLitecmd.CommandText = "SELECT * FROM complaint WHERE typeofcomplain = '" + comboBox2.SelectedItem + "' AND state = '" + comboBox3.SelectedItem + "'";
                    }
                    if (ComboBox1.SelectedItem == "ALL REQUEST" && comboBox4.SelectedItem == "ALL STATE")
                    {
                        SQLitecmd1.CommandText = "SELECT * FROM request";
                    }
                    else if (ComboBox1.SelectedItem == "ALL REQUEST" && comboBox4.SelectedItem != "ALL STATE")
                    {
                        SQLitecmd1.CommandText = "SELECT * FROM request WHERE state = '" + comboBox4.SelectedItem + "'";
                    }
                    else if (ComboBox1.SelectedItem != "ALL REQUEST" && comboBox4.SelectedItem == "ALL STATE")
                    {
                        SQLitecmd1.CommandText = "SELECT * FROM request WHERE typeofrequest = '" + ComboBox1.SelectedItem + "'";
                    }
                    else
                    {
                        SQLitecmd1.CommandText = "SELECT * FROM request WHERE typeofrequest = '" + ComboBox1.SelectedItem + "' AND state = '" + comboBox4.SelectedItem + "'";
                    }
                }
                else
                {
                    if (comboBox2.SelectedItem == "ALL COMPLAINS")
                    {
                        SQLitecmd.CommandText = "SELECT * FROM complaint WHERE state = '" + UserData.role + "'";
                    }
                    else
                    {
                        SQLitecmd.CommandText = "SELECT * FROM complaint WHERE state = '" + UserData.role + "' AND typeofcomplain = '" + comboBox2.SelectedItem + "'";
                    }
                    if (ComboBox1.SelectedItem == "ALL REQUEST")
                    {
                        SQLitecmd1.CommandText = "SELECT * FROM request WHERE state = '" + UserData.role + "'";
                    }
                    else
                    {
                        SQLitecmd1.CommandText = "SELECT * FROM request WHERE state = '" + UserData.role + "' AND typeofrequest = '" + ComboBox1.SelectedItem + "'";
                    }
                }

                // data adapter
                SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
                // data table
                DataTable dt = new DataTable();
                // filling data in datatable with adapter
                da.Fill(dt);
                complaindataview.DataSource = dt;

                SQLiteDataAdapter da1 = new SQLiteDataAdapter(SQLitecmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                requestdataview.DataSource = dt1;

                SQLiteConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Load Data", ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            DASHBOARD dashboard = new DASHBOARD();

            dashboard.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private Boolean check_complaint_exist(string ID)
        {
            string SQLitecnStr = @"Data Source=./helphub.db";
            SQLiteConnection SQLiteConn = new SQLiteConnection();
            SQLiteCommand SQLitecmd = new SQLiteCommand();
            SQLiteConn.ConnectionString = SQLitecnStr;
            SQLiteConn.Open();
            SQLitecmd.Connection = SQLiteConn;
            SQLitecmd.CommandText = "SELECT * FROM complaint WHERE ID=" + ID + "";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string ID = "";
            ID = Microsoft.VisualBasic.Interaction.InputBox("Enter ID of Complaint", "Update Complaint status", "", x, y);
            if (ID == "")
            {
                MessageBox.Show("ID field is empty/Updating status aborted");
                return;
            }
            if (check_complaint_exist(ID))
            {

                string Status = Microsoft.VisualBasic.Interaction.InputBox("Enter status of Complaint", "Update Complaint status", "", x, y);
                if (Status == "")
                {
                    MessageBox.Show("Status field is empty/Updating status aborted");
                    return;
                }
                try
                {
                    string SQLitecnStr = @"Data Source=./helphub.db";
                    SQLiteConnection SQLiteConn = new SQLiteConnection();
                    SQLiteCommand SQLitecmd = new SQLiteCommand();
                    SQLiteConn.ConnectionString = SQLitecnStr;
                    SQLiteConn.Open();
                    SQLitecmd.Connection = SQLiteConn;
                    int tempid = int.Parse(ID);
                    SQLitecmd.CommandText = "UPDATE complaint SET status = '" + Status + "' WHERE ID = " + tempid + ";";
                    try
                    {
                        SQLitecmd.ExecuteNonQuery();
                        MessageBox.Show("Status Updated Succesfully");
                        CreateLogs.createlogobj.adminlog(UserData.username, "Complain Id:- " + ID + " Status updated to " + Status + "", this.Name, UserData.role);
                        fetchData();
                        this.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update Failed", ex.Message);
                        CreateLogs.createlogobj.adminlog(UserData.username, "Complain Id:- " + ID + " Status update failed (updated status:- " + Status + ") - " + ex.Message + "", this.Name, UserData.role);
                    }
                    SQLiteConn.Close();

                }
                catch (Exception ex)
                {
                    CreateLogs.createlogobj.adminlog(UserData.username, "Complain Id:- " + ID + " Status update failed (updated status:- " + Status + ") - " + ex.Message + "", this.Name, UserData.role);
                    MessageBox.Show("Update Failed", ex.Message);
                    Console.WriteLine(ex);
                }
            }
            else
            {
                CreateLogs.createlogobj.adminlog(UserData.username, "Id doesn't exists - failed attempt to update complain status", this.Name, UserData.role);
                MessageBox.Show("ID doesn't Exists");
            }
        }

        private Boolean check_request_exist(string ID)
        {
            string SQLitecnStr = @"Data Source=./helphub.db";
            SQLiteConnection SQLiteConn = new SQLiteConnection();
            SQLiteCommand SQLitecmd = new SQLiteCommand();
            SQLiteConn.ConnectionString = SQLitecnStr;
            SQLiteConn.Open();
            SQLitecmd.Connection = SQLiteConn;
            SQLitecmd.CommandText = "SELECT * FROM request WHERE ID=" + ID + "";
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
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string ID = Microsoft.VisualBasic.Interaction.InputBox("Enter Id of Request", "Update Request Status", "", x, y);
            if (ID == "")
            {
                MessageBox.Show("ID field is empty/Updating status aborted");
                return;
            }
            if (check_request_exist(ID))
            {

                string Status = Microsoft.VisualBasic.Interaction.InputBox("Enter status of Complaint", "Update Complaint status", "", x, y);
                if (Status == "")
                {
                    MessageBox.Show("Status field is empty/Updating status aborted");
                    return;
                }
                try
                {
                    string SQLitecnStr = @"Data Source=./helphub.db";
                    SQLiteConnection SQLiteConn = new SQLiteConnection();
                    SQLiteCommand SQLitecmd = new SQLiteCommand();
                    SQLiteConn.ConnectionString = SQLitecnStr;
                    SQLiteConn.Open();
                    SQLitecmd.Connection = SQLiteConn;
                    int tempid = int.Parse(ID);
                    SQLitecmd.CommandText = "UPDATE request SET status = '" + Status + "' WHERE ID = " + tempid + ";";
                    try
                    {
                        SQLitecmd.ExecuteNonQuery();
                        MessageBox.Show("Status Updated Succesfully");
                        CreateLogs.createlogobj.adminlog(UserData.username, "Request Id:- " + ID + " Status updated to " + Status + "", this.Name, UserData.role);
                        fetchData();
                        this.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update Failed", ex.Message);
                        CreateLogs.createlogobj.adminlog(UserData.username, "Request Id:- " + ID + " Status update failed (updated status:- " + Status + ") - " + ex.Message + "", this.Name, UserData.role);
                    }
                    SQLiteConn.Close();
                }
                catch (Exception ex)
                {
                    CreateLogs.createlogobj.adminlog(UserData.username, "Request Id:- " + ID + " Status update failed (updated status:- " + Status + ") - " + ex.Message + "", this.Name, UserData.role);
                    MessageBox.Show("Update Failed", ex.Message);
                    Console.WriteLine(ex);
                }
            }
            else
            {
                CreateLogs.createlogobj.adminlog(UserData.username, "Id doesn't exists - failed attempt to update request status", this.Name, UserData.role);
                MessageBox.Show("ID doesn't Exists");

            }
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
                if ((dt.Rows[0]["role"].ToString() == "SUPERADMIN" || dt.Rows[0]["role"].ToString() == "SUPERVISOR" || dt.Rows[0]["role"].ToString() == "root" || dt.Rows[0]["role"].ToString() == "ADMIN" || Database.databaseobj.StateList.Contains(dt.Rows[0]["role"].ToString())) && UserData.role == "ADMIN")
                {
                    MessageBox.Show("You can't change details of a " + dt.Rows[0]["role"].ToString() + "");
                    CreateLogs.createlogobj.adminlog(UserData.username, "You can't change details of a " + dt.Rows[0]["role"].ToString() + "", this.Name, UserData.role);
                    throw new Exception("You can't change details of a " + dt.Rows[0]["role"].ToString() + "");
                }
                else
                {
                    return true;
                }
            }
            return false;
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string username = Microsoft.VisualBasic.Interaction.InputBox("Enter username of user to make admin", "Update user role", "", x, y);
            if (username != "")
            {
                try
                {
                    if (check_username_exist(username))
                    {
                        string SQLitecnStr = @"Data Source=./helphub.db";
                        SQLiteConnection SQLiteConn = new SQLiteConnection();
                        SQLiteCommand SQLitecmd = new SQLiteCommand();
                        SQLiteConn.ConnectionString = SQLitecnStr;
                        SQLiteConn.Open();
                        SQLitecmd.Connection = SQLiteConn;
                        SQLitecmd.CommandText = "UPDATE user SET role = 'ADMIN' WHERE username = '" + username + "';";
                        try
                        {
                            SQLitecmd.ExecuteNonQuery();
                            CreateLogs.createlogobj.adminlog(UserData.username, "New admin added :- " + username + " by  " + UserData.username + "", this.Name, UserData.role);
                            MessageBox.Show("New admin added Succesfully");
                            fetchData();
                            this.Refresh();
                        }
                        catch (Exception ex)
                        {

                            CreateLogs.createlogobj.adminlog(UserData.username, "Can't Add New Admin " + ex.Message, this.Name, UserData.role);
                            MessageBox.Show("Can't Add New Admin", ex.Message);
                        }
                        SQLiteConn.Close();


                    }
                    else
                    {
                        CreateLogs.createlogobj.adminlog(UserData.username, "Username Doesnt Exists - adding new admin", this.Name, UserData.role);
                        MessageBox.Show("Username Doesn't Exists");
                    }
                }
                catch (Exception ex)
                {
                    CreateLogs.createlogobj.adminlog(UserData.username, "Can't Add New Admin " + ex.Message, this.Name, UserData.role);
                    MessageBox.Show("Can't Add New Admin", ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Username field is empty");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string username = Microsoft.VisualBasic.Interaction.InputBox("Enter username of user to make supervisor", "Update user role", "", x, y);
            if (username != "")
            {
                try
                {
                    if (check_username_exist(username))
                    {
                        string SQLitecnStr = @"Data Source=./helphub.db";
                        SQLiteConnection SQLiteConn = new SQLiteConnection();
                        SQLiteCommand SQLitecmd = new SQLiteCommand();
                        SQLiteConn.ConnectionString = SQLitecnStr;
                        SQLiteConn.Open();
                        SQLitecmd.Connection = SQLiteConn;
                        SQLitecmd.CommandText = "UPDATE user SET role = 'SUPERVISOR' WHERE username = '" + username + "';";
                        try
                        {
                            SQLitecmd.ExecuteNonQuery();
                            MessageBox.Show("New Supervisor added Succesfully");
                            CreateLogs.createlogobj.adminlog(UserData.username, "New supervisor added :- " + username + " by  " + UserData.username + "", this.Name, UserData.role);
                            fetchData();
                            this.Refresh();
                        }
                        catch (Exception ex)
                        {
                            CreateLogs.createlogobj.adminlog(UserData.username, "Can't Add New Supervisor " + ex.Message, this.Name, UserData.role);
                            MessageBox.Show("Can't Add New Supervisor", ex.Message);
                        }
                        SQLiteConn.Close();
                    }
                    else
                    {
                        CreateLogs.createlogobj.adminlog(UserData.username, "Username Doesnt Exists - adding new supervisor", this.Name, UserData.role);
                        MessageBox.Show("Username Doesn't Exists");
                    }
                }
                catch (Exception ex)
                {
                    CreateLogs.createlogobj.adminlog(UserData.username, "Can't Add New Supervisor " + ex.Message, this.Name, UserData.role);
                    MessageBox.Show("Can't Add New Supervisor", ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Username field is empty");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string ID = Microsoft.VisualBasic.Interaction.InputBox("Enter Id of Complain", "Delete Complain", "", x, y);
            if (ID == "")
            {
                MessageBox.Show("ID field is empty/Deleting complain aborted");
                return;
            }
            if (check_complaint_exist(ID))
            {
                try
                {
                    string SQLitecnStr = @"Data Source=./helphub.db";
                    SQLiteConnection SQLiteConn = new SQLiteConnection();
                    SQLiteCommand SQLitecmd = new SQLiteCommand();
                    SQLiteConn.ConnectionString = SQLitecnStr;
                    SQLiteConn.Open();
                    SQLitecmd.Connection = SQLiteConn;
                    int tempid = int.Parse(ID);
                    SQLitecmd.CommandText = "DELETE FROM complaint WHERE ID = " + tempid + ";";
                    try
                    {
                        SQLitecmd.ExecuteNonQuery();
                        MessageBox.Show("Complaint Deleted");
                        CreateLogs.createlogobj.adminlog(UserData.username, "Complain Id:- " + ID + " Deleted", this.Name, UserData.role);
                        fetchData();
                        this.Refresh();
                    }
                    catch (Exception ex)
                    {
                        CreateLogs.createlogobj.adminlog(UserData.username, "Complain Id:- " + ID + " Process failed " + ex.Message, this.Name, UserData.role);
                        MessageBox.Show("Process Failed", ex.Message);
                    }
                    SQLiteConn.Close();

                }
                catch (Exception ex)
                {
                    CreateLogs.createlogobj.adminlog(UserData.username, "Complain Id:- " + ID + " Process Failed " + ex.Message, this.Name, UserData.role);
                    MessageBox.Show("Process Failed", ex.Message);
                }
            }
            else
            {
                CreateLogs.createlogobj.adminlog(UserData.username, "Complain Id:- " + ID + " Doesnt Exists", this.Name, UserData.role);
                MessageBox.Show("ID doesn't Exists");

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AddStateAdmin admin = new AddStateAdmin();
            admin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string ID = Microsoft.VisualBasic.Interaction.InputBox("Enter Id of Request", "Delete Request", "", x, y);
            if (ID == "")
            {
                MessageBox.Show("ID field is empty/Deleting request aborted");
                return;
            }
            if (check_complaint_exist(ID))
            {
                try
                {
                    string SQLitecnStr = @"Data Source=./helphub.db";
                    SQLiteConnection SQLiteConn = new SQLiteConnection();
                    SQLiteCommand SQLitecmd = new SQLiteCommand();
                    SQLiteConn.ConnectionString = SQLitecnStr;
                    SQLiteConn.Open();
                    SQLitecmd.Connection = SQLiteConn;
                    int tempid = int.Parse(ID);
                    SQLitecmd.CommandText = "DELETE FROM request WHERE ID = " + tempid + ";";
                    try
                    {
                        SQLitecmd.ExecuteNonQuery();
                        MessageBox.Show("Request Deleted");
                        CreateLogs.createlogobj.adminlog(UserData.username, "Request Id:- " + ID + " Deleted", this.Name, UserData.role);
                        fetchData();
                        this.Refresh();
                    }
                    catch (Exception ex)
                    {
                        CreateLogs.createlogobj.adminlog(UserData.username, "Request Id:- " + ID + " Deleteion failed " + ex.Message, this.Name, UserData.role);
                        MessageBox.Show("Process Failed", ex.Message);
                    }
                    SQLiteConn.Close();

                }
                catch (Exception ex)
                {
                    CreateLogs.createlogobj.adminlog(UserData.username, "Request Id:- " + ID + " Deleteion failed " + ex.Message, this.Name, UserData.role);
                    MessageBox.Show("Process Failed", ex.Message);
                }
            }
            else
            {
                CreateLogs.createlogobj.adminlog(UserData.username, "Request Id:- " + ID + "Doesnt Exists", this.Name, UserData.role);
                MessageBox.Show("ID doesn't Exists");

            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchData();
            this.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchData();
            this.Refresh();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchData();
            this.Refresh();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchData();
            this.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string username = Microsoft.VisualBasic.Interaction.InputBox("Enter username of user to BAN/UNBAN", "BAN/UNBAN USER", "", x, y);
            if (username != "")
            {
                try
                {
                    if (check_username_exist(username))
                    {
                        string option = Microsoft.VisualBasic.Interaction.InputBox("Want to ban user or unban?\nType 'ban' to Ban a user\nType 'unban' to UnBan a user\nNote:- Type in lowercase only(only users can be banned from admin panel)", "BAN/UNBAN USER", "", x, y);
                        if (option != "")
                        {
                            string banorunban = option == "ban" ? "YES" : "NO";
                            if (username != "")
                            {
                                string SQLitecnStr = @"Data Source=./helphub.db";
                                SQLiteConnection SQLiteConn = new SQLiteConnection();
                                SQLiteCommand SQLitecmd = new SQLiteCommand();
                                SQLiteConn.ConnectionString = SQLitecnStr;
                                SQLiteConn.Open();
                                SQLitecmd.Connection = SQLiteConn;
                                SQLitecmd.CommandText = "UPDATE user SET banned = '" + banorunban + "' WHERE username = '" + username + "' AND role='USER';";
                                try
                                {
                                    SQLitecmd.ExecuteNonQuery();
                                    MessageBox.Show("User succesfully " + option + "ned");
                                    CreateLogs.createlogobj.banunbanlog(username, UserData.username, option);
                                    CreateLogs.createlogobj.adminlog(UserData.username, "" + username + " " + option + "ned", this.Name, UserData.role);
                                }
                                catch (Exception ex)
                                {
                                    CreateLogs.createlogobj.adminlog(UserData.username, "Can't " + option + " user " + ex.Message, this.Name, UserData.role);
                                    MessageBox.Show("Can't " + option + " user", ex.Message);
                                }
                                SQLiteConn.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Option field is empty");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Doesn't Exists");
                    }
                }
                catch (Exception ex)
                {
                    CreateLogs.createlogobj.adminlog(UserData.username, "Can't  ban/unban  user " + ex.Message, this.Name, UserData.role);
                }
            }
            else
            {
                MessageBox.Show("Username field is empty");
            }
        }

        private void superadmin_Click(object sender, EventArgs e)
        {
            SUPERADMIN superadmin = new SUPERADMIN();
            superadmin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DownloadPdf.downloadpdf("REQUESTS REPORT", complaindataview);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DownloadPdf.downloadpdf("COMPLAINS REPORT", complaindataview);
        }
    }
}
