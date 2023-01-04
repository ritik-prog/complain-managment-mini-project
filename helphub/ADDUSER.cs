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

        public ADDUSER(string title)
        {
            InitializeComponent();
            this.title = title;
            this.Text = title;
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
        }

        private void updatedetails_Click(object sender, EventArgs e)
        {
            SuperAdminDatabaseOperation control = new SuperAdminDatabaseOperation();
            if (title == "USER DATABASE")
            {
                control.AddUser(this,"USER");
            }
            else if (title == "SUPERVISOR DATABASE")
            {
                control.AddUser(this, "SUPERVISOR");
            }
            else if (title == "ADMIN DATABASE")
            {
                control.AddUser(this, "ADMIN");
            }
            else if (title == "SUPER ADMIN DATABASE")
            {
                control.AddUser(this, "SUPERADMIN");
            }
        }
    }
}
