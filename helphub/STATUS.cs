using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace helphub
{
    public partial class STATUS : Form
    {
        public STATUS()
        {
            InitializeComponent();
            Database.databaseobj.FetchData(complaindataview,requestdataview);
        }
       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DASHBOARD dashboard = new DASHBOARD();

            dashboard.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DownloadPdf.downloadpdf("COMPLAINS REPORT",complaindataview);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DownloadPdf.downloadpdf("REQUESTS REPORT", requestdataview);
        }
    }
}
