using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace helphub
{
    public class CreateLogs
    {
        // staic obj variable of class so it can be accessed without create object 
        public static CreateLogs createlogobj = new CreateLogs();
        public DataTable dt = new DataTable();

        string SQLitecnStr = @"Data Source=.\helphub.db";
        SQLiteConnection SQLiteConn = new SQLiteConnection();
        SQLiteCommand SQLitecmd = new SQLiteCommand();
        public CreateLogs()
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
        public void userlog(string username,string action,string formname)
        {
            checkconn();
            SQLitecmd.CommandText = "insert into userlogs(username,action,formname,time) VALUES('" + username + "','" + action + "','" + formname + "','" + DateTime.Now + "')";
            try
            {
                SQLitecmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void adminlog(string username, string action, string formname, string role)
        {
            checkconn();
            SQLitecmd.CommandText = "insert into adminlogs(username,action,formname,time,role) VALUES('" + username + "','" + action + "','" + formname + "','" + DateTime.Now + "','" + role + "')";
            try
            {
                SQLitecmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void banunbanlog(string usernameofuser, string usernameofadmin, string action)
        {
            checkconn();
            SQLitecmd.CommandText = "insert into banunbanlogs(usernameofuser,usernameofadmin,time,action) VALUES('" + usernameofuser + "','" + usernameofadmin + "','" + DateTime.Now + "','" + action + "')";
            try
            {
                SQLitecmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void superadminlog(string username,string action, string formname, string role)
        {
            checkconn();
            SQLitecmd.CommandText = "insert into superadminlogs(username,action,formname,time,role) VALUES('" + username + "','" + action + "','" + formname + "','" + DateTime.Now + "','" + role + "')";
            try
            {
                SQLitecmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void fetchuserlog()
        {
            checkconn();
            SQLitecmd.CommandText = "Select * from userlogs";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            dt.Clear();
            dt.Columns.Clear();
            da.Fill(dt);
        }
        public void fetchadminlog()
        {
            checkconn();
            SQLitecmd.CommandText = "Select * from adminlogs";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            dt.Clear();
            dt.Columns.Clear();
            da.Fill(dt);
        }
        public void fetchbanlog()
        {
            checkconn();
            SQLitecmd.CommandText = "Select * from banunbanlogs WHERE action='ban'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            dt.Clear();
            dt.Columns.Clear();
            da.Fill(dt);
        }
        public void fetchunbanlog()
        {
            checkconn();
            SQLitecmd.CommandText = "Select * from banunbanlogs WHERE action='unban'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            dt.Clear();
            dt.Columns.Clear();
            da.Fill(dt);
        }
        public void fetchsuperadminlog()
        {
            checkconn();
            SQLitecmd.CommandText = "Select * from superadminlogs";
            SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
            dt.Clear();
            dt.Columns.Clear();
            da.Fill(dt);
        }
    }
}
