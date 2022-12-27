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
            if (UserData.role != "ADMIN")
            {
                this.pictureBox3.Visible = false;
            }
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

        private void Button3_Click(object sender, EventArgs e)
        {
            STATUS status = new STATUS();

            status.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(UserData.role == "ADMIN")
            {
                ADMIN admin = new ADMIN();

                admin.Show();

                this.Hide(); //Close Form1,the current open form.
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ABOUT about = new ABOUT();

            about.Show();

            this.Hide(); //Close Form1,the current open form.
        }
    }
}
