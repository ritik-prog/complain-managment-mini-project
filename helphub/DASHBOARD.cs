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
    partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            COMPLAINT complaint = new COMPLAINT();

            complaint.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            REQUEST request = new REQUEST();

            request.Show();

            this.Hide(); //Close Form1,the current open form.
        }
    }
}
