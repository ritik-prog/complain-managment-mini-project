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
    public partial class UPDATEDATABASE : Form
    {
        public UPDATEDATABASE()
        {
            InitializeComponent();
        }
        
        string title = string.Empty;
        SuperAdminDatabaseOperation control = new SuperAdminDatabaseOperation();
        Action fetchdata;
        public UPDATEDATABASE(string title, Action fetchdata)
        {
            InitializeComponent();
            this.Text = "UPDATE " + title;
            this.title = title;
            this.fetchdata = fetchdata;

            CreateLogs.createlogobj.superadminlog(UserData.username, "SuperAdmin checking "+title+"", this.Name, UserData.role);
        }

        public void RefreshData()
        {
                username.Text = "";
                aadharnumber.Text = "";
                mobilenumber.Text = "";
                email.Text = "";
                role.SelectedItem = "";
                address.Text = "";
                password.Text = "";
            searchbox.Text = "";
            searchbox.Enabled = true;
        }
 
        private void updatedetails_Click(object sender, EventArgs e)
        {

            CreateLogs.createlogobj.superadminlog(UserData.username, "SuperAdmin updating details of username:- " + searchbox.Text + " on " + title + "", this.Name, UserData.role);
            control.UpdateUserDetails(this, fetchdata);
        }

        private void search_Click(object sender, EventArgs e)
        {
            searchbox.Enabled = false;
            CreateLogs.createlogobj.superadminlog(UserData.username, "SuperAdmin checking details of username:- "+searchbox.Text+ " on "+title+"", this.Name, UserData.role);
            if (title == "USER DATABASE")
            {
                control.FetchUserDetails(searchbox.Text,"USER",this);
            }
            else if (title == "SUPERVISOR DATABASE")
            {
                control.FetchUserDetails(searchbox.Text, "SUPERVISOR",this);
            }
            else if (title == "ADMIN DATABASE")
            {
                control.FetchUserDetails(searchbox.Text, "ADMIN", this);
            }
            else if (title == "SUPER ADMIN DATABASE")
            {
                control.FetchUserDetails(searchbox.Text, "SUPERADMIN", this);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            searchbox.Enabled = true;
            RefreshData();
            this.Refresh();
        }

        private void deleteaccount_Click(object sender, EventArgs e)
        {
            CreateLogs.createlogobj.superadminlog(UserData.username, "SuperAdmin deleting user username:- " + searchbox.Text + " on " + title + "", this.Name, UserData.role);
            control.DeleteUser(this, fetchdata);
            RefreshData();
            this.Refresh();
        }
    }
}
