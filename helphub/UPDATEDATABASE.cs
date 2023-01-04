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

        public UPDATEDATABASE(string title)
        {
            InitializeComponent();
            this.Text = "UPDATE " + title;
            this.title = title;
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
        }

        private void updatedetails_Click(object sender, EventArgs e)
        {
            control.UpdateUserDetails(this);
        }

        private void search_Click(object sender, EventArgs e)
        {
            searchbox.Enabled = false;
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
    }
}
