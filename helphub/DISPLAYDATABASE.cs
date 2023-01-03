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
        public DISPLAYDATABASE(string title)
        {
            InitializeComponent();
            label1.Text= title;
            SuperAdminDatabaseOperation control = new SuperAdminDatabaseOperation();
            if(title == "USER DATABASE")
            {
                control.fetchusers();
                displaydatabasedata.DataSource= control.dt;
            }
            else if(title == "SUPERVISOR DATABASE")
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
            }
        }

        private void displaydatabasedata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
