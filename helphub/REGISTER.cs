using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FluentValidation;



namespace helphub
{
    public partial class REGISTER : Form
    {
        public class RegisterUser
        {
            public string Address { get; set; }
            public string Contact { get; set; }
            public string username { get; set; }
            public string Password { get; set; }
            public string Aadhar { get; set; }
            public string Email { get; set; }
        }

        public class RegisterValidator : AbstractValidator<RegisterUser>
        {
            public RegisterValidator()
            {
                RuleFor(RegisterUser => RegisterUser.Email).EmailAddress().NotNull();
                RuleFor(RegisterUser => RegisterUser.Contact).Matches("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$").NotNull();
                RuleFor(RegisterUser => RegisterUser.username).NotNull();
                RuleFor(RegisterUser => RegisterUser.Address).NotNull();
                RuleFor(RegisterUser => RegisterUser.Password).NotNull();
                RuleFor(RegisterUser => RegisterUser.Aadhar).Matches("^[2-9]{1}[0-9]{3}\\s[0-9]{4}\\s[0-9]{4}$").NotNull();
            }
        }

        public REGISTER()
        {
            InitializeComponent();
            username.Select();
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            RegisterUser ruser = new RegisterUser();
            RegisterValidator validator = new RegisterValidator();

            ruser.Aadhar = Aadhar.Text;
            ruser.Contact = Contact.Text;
            ruser.Email = Email.Text;
            ruser.Password = Password.Text;
            ruser.username = username.Text;
            ruser.Address = Address.Text;


            var result = validator.Validate(ruser);

            if (!result.IsValid)
            {
                String errors ="Kindly Solve Below Errors\n";
                int i = 1;
                foreach (var failure in result.Errors)
                {
                    errors = ""+ errors + " "+i+") " + failure.ErrorMessage + "\n";
                    i++;
                }
                MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Text.Trim() == "" && Password.Text.Trim() == "" && Aadhar.Text.Trim() == "" && Contact.Text.Trim() == "" && Email.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Database.databaseobj.register(this);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Close(); //Close Form1,the current open form.
        }

        // change focus
        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Aadhar.Focus();
            }
        }
        private void aadhar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Email.Focus();
            }
        }
        private void email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Contact.Focus();
            }
        }
        private void contact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Address.Focus();
            }
        }
        private void address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button2_Click(null, EventArgs.Empty);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
