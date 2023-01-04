using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace helphub
{
    public class StatsSuperAdmin
    {
        string SQLitecnStr = @"Data Source=.\helphub.db";
        SQLiteConnection SQLiteConn = new SQLiteConnection();
        SQLiteCommand SQLitecmd = new SQLiteCommand();
        public StatsSuperAdmin()
        {
            SQLiteConn.ConnectionString = SQLitecnStr;
            SQLiteConn.Open();
            SQLitecmd.Connection = SQLiteConn;
        }
        public int totalnumberofusers()
        {
            SQLitecmd.CommandText = "select count(id) from user where role = 'USER';";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }
        public int totalnumberofbannedusers()
        {
            SQLitecmd.CommandText = "select count(id) from user where banned = 'YES';";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }
        public int totalnumberofsupervisors()
        {
            SQLitecmd.CommandText = "select count(id) from user where role = 'SUPERVISOR';";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }
        public int totalnumberofadmins()
        {
            SQLitecmd.CommandText = "select count(id) from user where role = 'ADMIN';";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }
        public int totalnumberofsuperadmins()
        {
            SQLitecmd.CommandText = "select count(id) from user where role = 'SUPERADMIN';";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }

        public int totalnumberofstateadmins()
        {
            SQLitecmd.CommandText = "select count(id) from user WHERE role!='SUPERADMIN' AND role!='root' AND  role!='ADMIN' AND  role!='SUPERVISOR' AND  role!='USER'";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }

        public int totalnumberofcomplains()
        {
            SQLitecmd.CommandText = "select count(id) from complaint;";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }
        public int totalnumberofcomplainspending()
        {
            SQLitecmd.CommandText = "select count(id) from complaint where status='pending';";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }
        public int totalnumberofcomplainsstatusupdated()
        {
            SQLitecmd.CommandText = "select count(id) from complaint where status!='pending';";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }
        public int totalnumberofrequests()
        {
            SQLitecmd.CommandText = "select count(id) from request;";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }
        public int totalnumberofrequestspending()
        {
            SQLitecmd.CommandText = "select count(id) from request where status='pending';";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }
        public int totalnumberofrequestsstatusupdated()
        {
            SQLitecmd.CommandText = "select count(id) from request where status!='pending';";
            SQLitecmd.CommandType = CommandType.Text;
            int RowCount = 0;
            try
            {
                RowCount = Convert.ToInt32(SQLitecmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            return RowCount;
        }
    }
}
