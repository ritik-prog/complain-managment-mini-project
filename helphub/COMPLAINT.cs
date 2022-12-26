using FluentValidation;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace helphub
{
    public partial class COMPLAINT : Form
    {
        public class Complaint
        {
            public string DCOMPLAIN { get; set; }
            public string Address { get; set; }
            public string Contact { get; set; }
        }

        public class ComplaintValidator : AbstractValidator<Complaint>
        {
            public ComplaintValidator()
            {
                RuleFor(Complaint => Complaint.DCOMPLAIN).NotNull().WithMessage("Kindly Provide Proper Details about Complain");
                RuleFor(RegisterUser => RegisterUser.Contact).NotNull().Matches("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
                RuleFor(Complaint => Complaint.Address).NotNull();
            }
        }
        public COMPLAINT()
        {
            InitializeComponent();
            Aadhar.Text = UserData.aadharno;
            Contact.Text = UserData.mobilenumber;
            ComboBox1.SelectedItem = "DOMESTIC VOILENCE";
            Address.Text = UserData.address;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Complaint complain = new Complaint();
            ComplaintValidator validator = new ComplaintValidator();

            complain.Address = Address.Text;
            complain.Contact = Contact.Text;
            complain.DCOMPLAIN = Dcomplaint.Text;

            var result = validator.Validate(complain);

            if (!result.IsValid)
            {
                String errors = "Kindly Solve Below Errors\n";
                int i = 1;
                foreach (var failure in result.Errors)
                {
                    errors = "" + errors + " " + i + ") " + failure.ErrorMessage + "\n";
                    i++;
                }
                MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Dcomplaint.Text.Trim() == "" && Address.Text.Trim() == "" && Aadhar.Text.Trim() == "" && Contact.Text.Trim() == "" && ComboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string SQLitecnStr = @"Data Source=./helphub.db";
                    SQLiteConnection SQLiteConn = new SQLiteConnection();
                    SQLiteCommand SQLitecmd = new SQLiteCommand();

                    SQLiteConn.ConnectionString = SQLitecnStr;
                    SQLiteConn.Open();
                    SQLitecmd.Connection = SQLiteConn;
                    String typeofcomplain = ComboBox1.SelectedItem.ToString();

                    SQLitecmd.CommandText = "insert into complaint(aadharno,typeofcomplain,mobilenumber,aboutcomplain,address) VALUES('" + Aadhar.Text + "','" + typeofcomplain + "','" + Contact.Text + "','" + Dcomplaint.Text + "','" + Address.Text + "')";

                    try
                    {
                        SQLitecmd.ExecuteNonQuery();
                        MessageBox.Show("complain Filled, Checkout in status section", "Complain", MessageBoxButtons.OK);
                        STATUS status = new STATUS();

                        status.Show();

                        this.Hide(); //Close Form1,the current open form.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Registration Failed: " + ex.Message + "", "Complain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    SQLiteConn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to File Complain", ex.Message);
                    Console.WriteLine(ex);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DASHBOARD dashboard = new DASHBOARD();

            dashboard.Show();

            this.Hide(); //Close Form1,the current open form.
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
