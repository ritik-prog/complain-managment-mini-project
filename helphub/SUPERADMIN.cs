namespace helphub
{
    public partial class SUPERADMIN : Form
    {
        StatsSuperAdmin stats = new StatsSuperAdmin();
        void fetchstats()
        {
            totalnumberofusers.Text = stats.totalnumberofusers().ToString();
            totalnumberofbannedusers.Text = stats.totalnumberofbannedusers().ToString();
            totalnumberofsupervisors.Text = stats.totalnumberofsupervisors().ToString();
            totalnumberofadmins.Text = stats.totalnumberofadmins().ToString();
            totalnumberofsuperadmins.Text = stats.totalnumberofsuperadmins().ToString();
            totalnumberofcomplainspending.Text = stats.totalnumberofcomplainspending().ToString();
            totalnumberofcomplains.Text = stats.totalnumberofcomplains().ToString();
            totalnumberofcomplainsstatusupdated.Text = stats.totalnumberofcomplainsstatusupdated().ToString();
            totalnumberofrequestpending.Text = stats.totalnumberofrequestspending().ToString();
            totalnumberofrequest.Text = stats.totalnumberofrequests().ToString();
            totalnumberofrequeststatusupdated.Text = stats.totalnumberofrequestsstatusupdated().ToString();
            totalnumberofstateadmins.Text = stats.totalnumberofstateadmins().ToString();
        }
        public SUPERADMIN()
        {
            InitializeComponent();
            if (UserData.role != "root")
            {
                button12.Hide();
            }
            fetchstats();
            CreateLogs.createlogobj.superadminlog(UserData.username, "SuperAdmin checking Dashboard", this.Name, UserData.role);
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
            DISPLAYDATABASE displaydatabase = new DISPLAYDATABASE(button6.Text);
            displaydatabase.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ADMIN admin = new ADMIN();
            admin.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DASHBOARD dashboard = new DASHBOARD();
            dashboard.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LOGIN logout = new LOGIN();
            logout.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ROOTDASHBOARD root = new ROOTDASHBOARD();
            root.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DISPLAYDATABASE displaydatabase = new DISPLAYDATABASE(button13.Text);
            displaydatabase.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            fetchstats();
        }
    }
}
