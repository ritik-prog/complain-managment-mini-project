using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
