using helphub;
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
    partial class LOADING : Form
    {
        public LOADING()
        {
            InitializeComponent();
        }

             private void Timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width >=599)
            {
                timer1.Stop();
                LOGIN login = new LOGIN();
                login.Show();
                this.Hide(); 
            }
        }
    }
}
