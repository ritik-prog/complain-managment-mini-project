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
    public partial class SUPERADMIN : Form
    {
        public SUPERADMIN()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DISPLAYLOGS displaylogs= new DISPLAYLOGS("USER LOGS");
            displaylogs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DISPLAYLOGS displaylogs = new DISPLAYLOGS("ADMIN LOGS");
            displaylogs.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DISPLAYLOGS displaylogs = new DISPLAYLOGS("BAN LOGS");
            displaylogs.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DISPLAYLOGS displaylogs = new DISPLAYLOGS("UNBAN LOGS");
            displaylogs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DISPLAYDATABASE displaydatabase = new DISPLAYDATABASE(button3.Text);
            displaydatabase.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DISPLAYDATABASE displaydatabase = new DISPLAYDATABASE(button5.Text);
            displaydatabase.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DISPLAYDATABASE displaydatabase = new DISPLAYDATABASE(button4.Text);
            displaydatabase.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DISPLAYDATABASE displaydatabase = new DISPLAYDATABASE(button5.Text);
            displaydatabase.Show();
        }
    }
}
