using FluentValidation;
using Microsoft.VisualBasic.ApplicationServices;
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
using static helphub.REGISTER;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace helphub
{
    public partial class UPDATEDETAILS : Form
    {
        public class UpdateUser
        {
            public string Address { get; set; }
            public string Contact { get; set; }
            public string username { get; set; }
            public string oldPassword { get; set; }
            public string newPassword { get; set; }
            public string Aadhar { get; set; }
            public string Email { get; set; }
        }
        public class UpdateValidator : AbstractValidator<UpdateUser>
        {
            public UpdateValidator()
            {
                RuleFor(UpdateUser => UpdateUser.Email).EmailAddress().NotNull();
                RuleFor(UpdateUser => UpdateUser.Contact).Matches("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$").NotNull();
                RuleFor(UpdateUser => UpdateUser.username).NotNull();
                RuleFor(UpdateUser => UpdateUser.Address).NotNull();
                RuleFor(UpdateUser => UpdateUser.newPassword).NotNull();
                RuleFor(UpdateUser => UpdateUser.oldPassword).NotNull();
                RuleFor(UpdateUser => UpdateUser.Aadhar).Matches("^[2-9]{1}[0-9]{3}\\s[0-9]{4}\\s[0-9]{4}$").NotNull();
            }
        }
        public UPDATEDETAILS()
        {
            InitializeComponent();
            Aadhar.Text = UserData.aadharno;
            Contact.Text = UserData.mobilenumber;
            Email.Text = UserData.email;
            username.Text = UserData.username;
            Address.Text = UserData.address;
        }

        PROFILE profile = new PROFILE();

        private void Button2_Click(object sender, EventArgs e)
        {
            UpdateUser ruser = new UpdateUser();
            UpdateValidator validator = new UpdateValidator();

            ruser.Aadhar = Aadhar.Text;
            ruser.Contact = Contact.Text;
            ruser.Email = Email.Text;
            ruser.oldPassword = oldpassword.Text;
            ruser.newPassword = newpassword.Text;
            ruser.username = username.Text;
            ruser.Address = Address.Text;


            var result = validator.Validate(ruser);

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
            else
            {
                string SQLitecnStr = @"Data Source=.\helphub.db";
                SQLiteConnection SQLiteConn = new SQLiteConnection();
                SQLiteCommand SQLitecmd = new SQLiteCommand();

                SQLiteConn.ConnectionString = SQLitecnStr;
                SQLiteConn.Open();

                SQLitecmd.Connection = SQLiteConn;
                SQLitecmd.CommandText = "SELECT * FROM user WHERE username='" + UserData.username + "' AND password='" + oldpassword.Text + "'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(SQLitecmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count != 1)
                {
                    MessageBox.Show("Wrong Old Password", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    SQLitecmd.CommandText = "UPDATE user SET aadharno = '" + Aadhar.Text + "',username = '" + username.Text + "',mobilenumber = '" + Contact.Text + "',password = '" + newpassword.Text + "',email = '" + Email.Text + "',address='" + Address.Text + "' WHERE ID = " + UserData.ID + "";
                    try
                    {
                        int status = SQLitecmd.ExecuteNonQuery();
                        if (status == 0)
                        {
                            MessageBox.Show("Update Failed", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            profile.Show();
                            this.Hide(); //Close Form1,the current open form.
                        }
                        else
                        {
                            MessageBox.Show("Deatils Updated", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SQLitecmd.CommandText = "SELECT * FROM user WHERE username='" + UserData.username + "' AND password='" + oldpassword.Text + "'";
                            da = new SQLiteDataAdapter(SQLitecmd);
                            dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count == 1)
                            {
                                foreach (DataRow row in dt.Rows)
                                {
                                    UserData.ID = row["ID"].ToString();
                                    UserData.username = row["username"].ToString();
                                    UserData.aadharno = row["aadharno"].ToString();
                                    UserData.mobilenumber = row["mobilenumber"].ToString();
                                    UserData.password = row["password"].ToString();
                                    UserData.email = row["email"].ToString();
                                    UserData.role = row["Role"].ToString();
                                    UserData.address = row["address"].ToString();
                                }
                            }
                            profile.Show();
                            this.Hide(); //Close Form1,the current open form.
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        int code = ex.ErrorCode;

                        if (code == 19)
                        {
                            MessageBox.Show("Already Registered Username/Aadhar Number", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Database Error: Error code:- " + code + ",Error message:- " + ex.Message + "", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        profile.Show();
                        this.Hide(); //Close Form1,the current open form.
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Update Failed: " + ex.Message + "", "Update Deatils", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        profile.Show();
                        this.Hide(); //Close Form1,the current open form.
                    }
                }
                SQLiteConn.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            profile.Show();
            this.Hide(); //Close Form1,the current open form.
        }
    }
}
