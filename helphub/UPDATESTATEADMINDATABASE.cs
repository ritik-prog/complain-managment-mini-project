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
    public partial class UPDATESTATEADMINDATABASE : Form
    {
        Action fetchdata;
        public UPDATESTATEADMINDATABASE(Action fetchdata)
        {
            InitializeComponent();
            this.fetchdata = fetchdata;
        }

        SuperAdminDatabaseOperation control = new SuperAdminDatabaseOperation();

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

        private void search_Click(object sender, EventArgs e)
        {
            searchbox.Enabled = false;
            control.FetchStateAdminDetails(searchbox.Text,searchstateadminrole.SelectedItem.ToString(),this);
        }

        private void updatedetails_Click(object sender, EventArgs e)
        {
            control.UpdateStateAdminDetails(this, fetchdata);
        }

        private void deleteaccount_Click(object sender, EventArgs e)
        {
            control.DeleteStateAdmin(this, fetchdata);
            RefreshData();
            this.Refresh();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            searchbox.Enabled = true;
            RefreshData();
            this.Refresh();
        }
    }
}
