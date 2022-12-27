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

namespace helphub
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
            fetchData();
        }

    public static DialogResult InputBox(string title, string promptText, ref string value)
    {
        Form form = new Form();
        Label label = new Label();
        TextBox textBox = new TextBox();
        Button buttonOk = new Button();
        Button buttonCancel = new Button();

        form.Text = title;
        label.Text = promptText;
        textBox.Text = value;

        buttonOk.Text = "OK";
        buttonCancel.Text = "Cancel";
        buttonOk.DialogResult = DialogResult.OK;
        buttonCancel.DialogResult = DialogResult.Cancel;

        label.SetBounds(9, 20, 372, 13);
        textBox.SetBounds(12, 36, 372, 20);
        buttonOk.SetBounds(228, 72, 75, 23);
        buttonCancel.SetBounds(309, 72, 75, 23);

        label.AutoSize = true;
        textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
        buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

        form.ClientSize = new Size(396, 107);
        form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
        form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
        form.FormBorderStyle = FormBorderStyle.FixedDialog;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.MinimizeBox = false;
        form.MaximizeBox = false;
        form.AcceptButton = buttonOk;
        form.CancelButton = buttonCancel;

        DialogResult dialogResult = form.ShowDialog();
        value = textBox.Text;
        return dialogResult;
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
                SQLitecmd.CommandText = "SELECT * FROM complaint";
                // connection + query
                SQLitecmd1.Connection = SQLiteConn;
                SQLitecmd1.CommandText = "SELECT * FROM request";
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

        private void STATUS_Load(object sender, EventArgs e)
        {

        }

        private void complaindataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string ID = Microsoft.VisualBasic.Interaction.InputBox("Enter ID of Complaint", "Update Complaint status", "", x, y);
            string Status = Microsoft.VisualBasic.Interaction.InputBox("Enter status of Complaint", "Update Complaint status", "", x, y);
            try
            {
                string SQLitecnStr = @"Data Source=./helphub.db";
                SQLiteConnection SQLiteConn = new SQLiteConnection();
                SQLiteCommand SQLitecmd = new SQLiteCommand();
                SQLiteConn.ConnectionString = SQLitecnStr;
                SQLiteConn.Open();
                SQLitecmd.Connection = SQLiteConn;
                int tempid = int.Parse(ID);
                SQLitecmd.CommandText = "UPDATE complaint SET status = '"+ Status + "' WHERE ID = "+ tempid + ";";
                try
                {
                    SQLitecmd.ExecuteNonQuery();
                    MessageBox.Show("Status Updated Succesfully");
                    fetchData();
                    this.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Failed", ex.Message);
                }
                SQLiteConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed", ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string ID = Microsoft.VisualBasic.Interaction.InputBox("Enter Id of Request", "Update Request Status", "", x, y);
            string Status = Microsoft.VisualBasic.Interaction.InputBox("Enter status of Request", "Update Request Status", "", x, y);
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
                    fetchData();
                    this.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Failed", ex.Message);
                }
                SQLiteConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed", ex.Message);
                Console.WriteLine(ex);
            }
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
                        MessageBox.Show("New admin added Succesfully");
                        fetchData();
                        this.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't Add New Admin", ex.Message);
                    }
                    SQLiteConn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't Add New Admin", ex.Message);
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
