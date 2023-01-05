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
        public List<string> StateList = new List<string> {
            "AP|Andhra Pradesh",
            "AR|Arunachal Pradesh",
            "AS|Assam",
            "BR|Bihar",
            "CT|Chhattisgarh",
            "GA|Goa",
            "GJ|Gujarat",
            "HR|Haryana",
            "HP|Himachal Pradesh",
            "JK|Jammu and Kashmir",
            "JH|Jharkhand",
            "KA|Karnataka",
            "KL|Kerala",
            "MP|Madhya Pradesh",
            "MH|Maharashtra",
            "MN|Manipur",
            "ML|Meghalaya",
            "MZ|Mizoram",
            "NL|Nagaland",
            "OR|Odisha",
            "PB|Punjab",
            "RJ|Rajasthan",
            "SK|Sikkim",
            "TN|Tamil Nadu",
            "TG|Telangana",
            "TR|Tripura",
            "UT|Uttarakhand",
            "UP|Uttar Pradesh",
            "WB|West Bengal",
            "AN|Andaman and Nicobar Islands",
            "CH|Chandigarh",
            "DN|Dadra and Nagar Haveli",
            "DD|Daman and Diu",
            "DL|Delhi",
            "LD|Lakshadweep",
            "PY|Puducherry"
        };

        public DASHBOARD()
        {
            InitializeComponent();
            if (UserData.role == "ADMIN" || UserData.role == "SUPERVISOR" || StateList.Contains(UserData.role) || UserData.role == "SUPERADMIN" || UserData.role == "root")
            {
                this.pictureBox3.Visible = true;
            }
            else
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
            if(UserData.role == "ADMIN" || UserData.role == "SUPERVISOR" || StateList.Contains(UserData.role) || UserData.role == "SUPERADMIN" || UserData.role == "root")
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PROFILE profile = new PROFILE();
            profile.Show();
            this.Hide();
        }
    }
}
