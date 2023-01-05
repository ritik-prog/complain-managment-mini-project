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
    public partial class PROFILE : Form
    {
        public PROFILE()
        {
            InitializeComponent();
            username.Text = UserData.username;
            email.Text = UserData.email;
            mobilenumber.Text = UserData.mobilenumber;
            aadharnumber.Text = UserData.aadharno;
            address.Text = UserData.address;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UPDATEDETAILS updatedetails = new UPDATEDETAILS();
            updatedetails.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = this.Left + (this.Width / 2) - 200;
            int y = this.Top + (this.Height / 2) - 100;
            string confirm = Microsoft.VisualBasic.Interaction.InputBox("Type 'confirm' to delete account", "DELETE ACCOUNT", "", x, y);
            if (confirm == "" || confirm != "confirm")
            {
                CreateLogs.createlogobj.userlog(username.Text, "Wrong Confirm spelling", this.Name);
                MessageBox.Show("Wrong Input");
                return;
            }
            if (confirm == "confirm")
            {
                if (Database.databaseobj.deleteaccount(username.Text, "PROFILE") == 0)
                {
                    return;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DASHBOARD dashboard = new DASHBOARD();
            dashboard.Show();
            this.Close();
        }
    }
}

