using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helphub
{
    public partial class ADDUSER : Form
    {
        public ADDUSER()
        {
            InitializeComponent();
        }

        string title = string.Empty;
        Action fetchdata;

        public ADDUSER(string title,Action fetchdata)
        {
            InitializeComponent();
            this.title = title;
            this.Text = title;
            this.fetchdata= fetchdata;
            if (title == "USER DATABASE")
            {
                label1.Text = "ADD USER";
            }
            else if (title == "SUPERVISOR DATABASE")
            {
                label1.Text = "ADD SUPERVISOR";
            }
            else if (title == "ADMIN DATABASE")
            {
                label1.Text = "ADD ADMIN";
            }
            else if (title == "SUPER ADMIN DATABASE")
            {
                label1.Text = "ADD SUPERADMIN";
            }

            CreateLogs.createlogobj.superadminlog(UserData.username, "SuperAdmin adding new user on form:- " + title + "", this.Name, UserData.role);
        }

        private void updatedetails_Click(object sender, EventArgs e)
        {
            SuperAdminDatabaseOperation control = new SuperAdminDatabaseOperation();

            CreateLogs.createlogobj.superadminlog(UserData.username, "SuperAdmin added new user, username:- " + username.Text + " in " + title + "", this.Name, UserData.role);
            if (title == "USER DATABASE")
            {
                control.AddUser(this,"USER", fetchdata);
            }
            else if (title == "SUPERVISOR DATABASE")
            {
                control.AddUser(this, "SUPERVISOR", fetchdata);
            }
            else if (title == "ADMIN DATABASE")
            {
                control.AddUser(this, "ADMIN", fetchdata);
            }
            else if (title == "SUPER ADMIN DATABASE")
            {
                control.AddUser(this, "SUPERADMIN", fetchdata);
            }
        }
    }
}
