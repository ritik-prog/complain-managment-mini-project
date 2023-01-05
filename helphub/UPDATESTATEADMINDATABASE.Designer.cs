namespace helphub
{
    partial class UPDATESTATEADMINDATABASE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPDATESTATEADMINDATABASE));
            this.deleteaccount = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.updatedetails = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ban = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mobilenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aadharnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.searchstateadminrole = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteaccount
            // 
            this.deleteaccount.BackColor = System.Drawing.Color.Red;
            this.deleteaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteaccount.ForeColor = System.Drawing.Color.White;
            this.deleteaccount.Location = new System.Drawing.Point(13, 452);
            this.deleteaccount.Name = "deleteaccount";
            this.deleteaccount.Size = new System.Drawing.Size(193, 50);
            this.deleteaccount.TabIndex = 43;
            this.deleteaccount.Text = "DELETE ACCOUNT";
            this.deleteaccount.UseVisualStyleBackColor = false;
            this.deleteaccount.Click += new System.EventHandler(this.deleteaccount_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Location = new System.Drawing.Point(249, 387);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(193, 50);
            this.clear.TabIndex = 42;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // updatedetails
            // 
            this.updatedetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updatedetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatedetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatedetails.Location = new System.Drawing.Point(249, 452);
            this.updatedetails.Name = "updatedetails";
            this.updatedetails.Size = new System.Drawing.Size(193, 50);
            this.updatedetails.TabIndex = 41;
            this.updatedetails.Text = "UPDATE DETAILS";
            this.updatedetails.UseVisualStyleBackColor = false;
            this.updatedetails.Click += new System.EventHandler(this.updatedetails_Click);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(13, 408);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(193, 29);
            this.password.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "NEW PASSWORD";
            // 
            // ban
            // 
            this.ban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ban.FormattingEnabled = true;
            this.ban.Items.AddRange(new object[] {
            "ban",
            "unban"});
            this.ban.Location = new System.Drawing.Point(249, 345);
            this.ban.Name = "ban";
            this.ban.Size = new System.Drawing.Size(193, 23);
            this.ban.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(249, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "BAN/UNBAN";
            // 
            // role
            // 
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
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
            "PY|Puducherry"});
            this.role.Location = new System.Drawing.Point(249, 283);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(193, 23);
            this.role.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(249, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "STATE";
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(13, 281);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(193, 87);
            this.address.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "ADDRESS";
            // 
            // mobilenumber
            // 
            this.mobilenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobilenumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mobilenumber.Location = new System.Drawing.Point(249, 209);
            this.mobilenumber.Name = "mobilenumber";
            this.mobilenumber.Size = new System.Drawing.Size(193, 29);
            this.mobilenumber.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(249, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "MOBILE NUMBER";
            // 
            // aadharnumber
            // 
            this.aadharnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aadharnumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aadharnumber.Location = new System.Drawing.Point(13, 209);
            this.aadharnumber.Name = "aadharnumber";
            this.aadharnumber.Size = new System.Drawing.Size(193, 29);
            this.aadharnumber.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "AADHAR NUMBER";
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(13, 140);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(193, 29);
            this.username.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(249, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "EMAIL";
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(249, 140);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(193, 29);
            this.email.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "USERNAME";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Location = new System.Drawing.Point(194, 68);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(68, 29);
            this.search.TabIndex = 24;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchbox
            // 
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchbox.Location = new System.Drawing.Point(15, 32);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(202, 29);
            this.searchbox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "ENTER USERNAME";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(241, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "SELECT STATE";
            // 
            // searchstateadminrole
            // 
            this.searchstateadminrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchstateadminrole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchstateadminrole.FormattingEnabled = true;
            this.searchstateadminrole.Items.AddRange(new object[] {
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
            "PY|Puducherry"});
            this.searchstateadminrole.Location = new System.Drawing.Point(241, 33);
            this.searchstateadminrole.Name = "searchstateadminrole";
            this.searchstateadminrole.Size = new System.Drawing.Size(202, 29);
            this.searchstateadminrole.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.searchstateadminrole);
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 105);
            this.panel1.TabIndex = 46;
            // 
            // UPDATESTATEADMINDATABASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteaccount);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.updatedetails);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ban);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.role);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mobilenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aadharnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UPDATESTATEADMINDATABASE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATE STATE ADMIN DATABASE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button deleteaccount;
        public Button clear;
        public Button updatedetails;
        public TextBox password;
        public Label label9;
        public ComboBox ban;
        public Label label8;
        public ComboBox role;
        public Label label7;
        public TextBox address;
        public Label label6;
        public TextBox mobilenumber;
        public Label label5;
        public TextBox aadharnumber;
        public Label label4;
        public TextBox username;
        public Label label3;
        public TextBox email;
        public Label label2;
        public Button search;
        public TextBox searchbox;
        public Label label1;
        public Label label10;
        public ComboBox searchstateadminrole;
        private Panel panel1;
    }
}