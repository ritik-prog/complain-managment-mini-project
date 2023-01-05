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
    public partial class DISPLAYLOGS : Form
    {
        public DISPLAYLOGS()
        {
            InitializeComponent();
        }
        public DISPLAYLOGS(string title)
        {
            InitializeComponent();
            label1.Text = title;
            if(title == "USER LOGS")
            {
                CreateLogs.createlogobj.fetchuserlog();
                displaylogsdata.DataSource = CreateLogs.createlogobj.dt;
            }else if (title == "ADMIN LOGS")
            {
                CreateLogs.createlogobj.fetchadminlog();
                displaylogsdata.DataSource = CreateLogs.createlogobj.dt;
            }
            else if (title == "BAN LOGS")
            {
                CreateLogs.createlogobj.fetchbanlog();
                displaylogsdata.DataSource = CreateLogs.createlogobj.dt;
            }
            else if (title == "UNBAN LOGS")
            {
                CreateLogs.createlogobj.fetchunbanlog();
                displaylogsdata.DataSource = CreateLogs.createlogobj.dt;
            }
            else if (title == "SUPERADMIN LOGS")
            {
                CreateLogs.createlogobj.fetchsuperadminlog();
                displaylogsdata.DataSource = CreateLogs.createlogobj.dt;
            }
        }

    }
}
