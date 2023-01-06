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
    public partial class DISPLAYDATABASE : Form
    {
        public DISPLAYDATABASE()
        {
            InitializeComponent();
        }
        string title = string.Empty;
        SuperAdminDatabaseOperation control = new SuperAdminDatabaseOperation();
        void fetchdata()
        {
            try{
                if (title == "USER DATABASE")
                {
                    control.fetchusers();
                    displaydatabasedata.DataSource = control.dt;
                }
                else if (title == "SUPERVISOR DATABASE")
                {
                    control.fetchsupervisor();
                    displaydatabasedata.DataSource = control.dt;
                }
                else if (title == "ADMIN DATABASE")
                {
                    control.fetchadmin();
                    displaydatabasedata.DataSource = control.dt;
                }
                else if (title == "SUPER ADMIN DATABASE")
                {
                    control.fetchsuperadmin();
                    displaydatabasedata.DataSource = control.dt;
                    updatedatabase.Visible = false;
                    adduser.Visible = false;
                    if (UserData.role == "root")
                    {
                        updatedatabase.Visible = true;
                        adduser.Visible = true;
                    }
                }
                else if (title == "STATE ADMIN DATABASE")
                {
                    control.fetchstateadmin();
                    displaydatabasedata.DataSource = control.dt;
                }
            }catch(Exception ex){
                CreateLogs.createlogobj.superadminlog(UserData.username, "SuperAdmin not able to fetch database - error:- " + ex.Message + "", this.Name, UserData.role);
                MessageBox.Show("Not able to fetch data....", ex.Message);
            }
        }
        public DISPLAYDATABASE(string title)
        {
            InitializeComponent();
            label1.Text= title;
            this.title = title;
            this.Text = title;
            fetchdata();
        }
        private void updatedatabase_Click(object sender, EventArgs e)
        {
            if (title == "STATE ADMIN DATABASE")
            {
                UPDATESTATEADMINDATABASE stateadmin = new UPDATESTATEADMINDATABASE(fetchdata);
                stateadmin.Show();
            }
            else
            {
                UPDATEDATABASE update = new UPDATEDATABASE(title, fetchdata);
                update.Show();
            }
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            if(title == "STATE ADMIN DATABASE")
            {
                AddStateAdmin stateadmin = new AddStateAdmin();
                stateadmin.Show();
            }
            else
            {
                ADDUSER adduser = new ADDUSER(title, fetchdata);
                adduser.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fetchdata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DownloadPdf.downloadpdf(""+title+" REPORT",displaydatabasedata);
        }
    }
}
