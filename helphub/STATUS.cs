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
    public partial class STATUS : Form
    {
        public STATUS()
        {
            InitializeComponent();
            fetchData();
        }
        public void fetchData()
        {
            try
            {
                string SQLitecnStr = @"Data Source=./helphub.db";
                SQLiteConnection SQLiteConn = new SQLiteConnection();
                SQLiteCommand SQLitecmd = new SQLiteCommand();
                SQLiteConn.ConnectionString = SQLitecnStr;
                SQLiteConn.Open();
                SQLitecmd.Connection = SQLiteConn;
                SQLitecmd.CommandText = "SELECT * FROM complaint WHERE aadharno='56436546453654'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    statusdataview.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Wrong Credentials", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
}
