using System.Diagnostics;

namespace helphub
{
    partial class REGISTER
    {

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.

        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTER));
            this.REGISTRATION = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.Aadhar = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.REGISTRATION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // REGISTRATION
            // 
            this.REGISTRATION.BackColor = System.Drawing.Color.White;
            this.REGISTRATION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.REGISTRATION.Controls.Add(this.pictureBox2);
            this.REGISTRATION.Controls.Add(this.Password);
            this.REGISTRATION.Controls.Add(this.Contact);
            this.REGISTRATION.Controls.Add(this.Aadhar);
            this.REGISTRATION.Controls.Add(this.Address);
            this.REGISTRATION.Controls.Add(this.Email);
            this.REGISTRATION.Controls.Add(this.username);
            this.REGISTRATION.Controls.Add(this.Label7);
            this.REGISTRATION.Controls.Add(this.Label6);
            this.REGISTRATION.Controls.Add(this.Label5);
            this.REGISTRATION.Controls.Add(this.Label4);
            this.REGISTRATION.Controls.Add(this.Label3);
            this.REGISTRATION.Controls.Add(this.Label2);
            this.REGISTRATION.Controls.Add(this.Button2);
            this.REGISTRATION.Controls.Add(this.pictureBox1);
            this.REGISTRATION.Location = new System.Drawing.Point(-4, -21);
            this.REGISTRATION.Margin = new System.Windows.Forms.Padding(0);
            this.REGISTRATION.MaximumSize = new System.Drawing.Size(1484, 774);
            this.REGISTRATION.MinimumSize = new System.Drawing.Size(1484, 774);
            this.REGISTRATION.Name = "REGISTRATION";
            this.REGISTRATION.Padding = new System.Windows.Forms.Padding(0);
            this.REGISTRATION.Size = new System.Drawing.Size(1484, 774);
            this.REGISTRATION.TabIndex = 0;
            this.REGISTRATION.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::helphub.Properties.Resources.Component_2_FINAL;
            this.pictureBox2.Location = new System.Drawing.Point(7, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(973, 403);
            this.Password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(468, 52);
            this.Password.TabIndex = 13;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // Contact
            // 
            this.Contact.BackColor = System.Drawing.Color.White;
            this.Contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contact.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contact.Location = new System.Drawing.Point(973, 256);
            this.Contact.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Contact.Name = "Contact";
            this.Contact.PlaceholderText = "+91826959xxxx";
            this.Contact.Size = new System.Drawing.Size(459, 52);
            this.Contact.TabIndex = 12;
            this.Contact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contact_KeyDown);
            // 
            // Aadhar
            // 
            this.Aadhar.BackColor = System.Drawing.Color.White;
            this.Aadhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Aadhar.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aadhar.Location = new System.Drawing.Point(973, 98);
            this.Aadhar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Aadhar.Name = "Aadhar";
            this.Aadhar.PlaceholderText = "3675 9834 6012";
            this.Aadhar.Size = new System.Drawing.Size(459, 52);
            this.Aadhar.TabIndex = 11;
            this.Aadhar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aadhar_KeyDown);
            // 
            // Address
            // 
            this.Address.AcceptsReturn = true;
            this.Address.AcceptsTab = true;
            this.Address.AllowDrop = true;
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Address.Location = new System.Drawing.Point(461, 403);
            this.Address.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Address.Size = new System.Drawing.Size(431, 256);
            this.Address.TabIndex = 10;
            this.Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address_KeyDown);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.White;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(461, 256);
            this.Email.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Email.Name = "Email";
            this.Email.PlaceholderText = "helphub@gmail.com";
            this.Email.Size = new System.Drawing.Size(431, 52);
            this.Email.TabIndex = 9;
            this.Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_KeyDown);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(461, 98);
            this.username.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.username.Name = "username";
            this.username.PlaceholderText = "Helphub";
            this.username.Size = new System.Drawing.Size(431, 52);
            this.username.TabIndex = 8;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label7.Location = new System.Drawing.Point(973, 346);
            this.Label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(244, 42);
            this.Label7.TabIndex = 7;
            this.Label7.Text = "PASSWORD";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label6.Location = new System.Drawing.Point(973, 198);
            this.Label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(275, 42);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "CONTACT NO";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(973, 41);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(249, 42);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "AADHAR NO";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(461, 346);
            this.Label4.Margin = new System.Windows.Forms.Padding(0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(206, 42);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "ADDRESS";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(461, 198);
            this.Label3.Margin = new System.Windows.Forms.Padding(0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(134, 42);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "EMAIL";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(461, 41);
            this.Label2.Margin = new System.Windows.Forms.Padding(0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(238, 42);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "USERNAME";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(973, 499);
            this.Button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(470, 162);
            this.Button2.TabIndex = 0;
            this.Button2.Text = "REGISTER";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::helphub.Properties.Resources.REGISTER_BANNER;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 766);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // REGISTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1458, 703);
            this.Controls.Add(this.REGISTRATION);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1484, 774);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1484, 774);
            this.Name = "REGISTER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRATION - HELPHUB";
            this.REGISTRATION.ResumeLayout(false);
            this.REGISTRATION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        public TextBox Contact;
        public TextBox Email;
        public TextBox username;
        public Label Label7;
        public Label Label6;
        public Label Label5;
        public Label Label4;
        public Label Label3;
        public Label Label2;
        public TextBox Aadhar;
        public GroupBox REGISTRATION;
        public TextBox Password;
        public Button Button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public TextBox Address;
    }
}