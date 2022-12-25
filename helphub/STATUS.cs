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
                SQLiteCommand SQLitecmd1 = new SQLiteCommand();
                SQLiteConn.ConnectionString = SQLitecnStr;
                SQLiteConn.Open();
                // connection + query
                SQLitecmd.Connection = SQLiteConn;
                SQLitecmd.CommandText = "SELECT * FROM complaint WHERE aadharno='"+ UserData.aadharno +"'";
                // connection + query
                SQLitecmd1.Connection = SQLiteConn;
                SQLitecmd1.CommandText = "SELECT * FROM request WHERE aadharno='"+ UserData.aadharno +"'";
                // data adapter
                SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
                SQLiteDataAdapter da1 = new SQLiteDataAdapter(SQLitecmd1);
                // data table
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DASHBOARD dashboard = new DASHBOARD();

            dashboard.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }
    }
}
