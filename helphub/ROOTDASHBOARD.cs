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
    public partial class ROOTDASHBOARD : Form
    {
        public ROOTDASHBOARD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMIN admin = new ADMIN();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SUPERADMIN superadmin = new SUPERADMIN();
            superadmin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DISPLAYLOGS logs = new DISPLAYLOGS("SUPERADMIN LOGS");
            logs.Show();
        }
    }
}
