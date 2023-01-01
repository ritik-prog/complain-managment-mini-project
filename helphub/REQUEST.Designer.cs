using System.Diagnostics;

namespace helphub
{
    public partial class REQUEST : System.Windows.Forms.Form
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REQUEST));
            this.Aadhar = new System.Windows.Forms.TextBox();
            this.DREQUEST = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aadhar
            // 
            this.Aadhar.BackColor = System.Drawing.Color.White;
            this.Aadhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Aadhar.Enabled = false;
            this.Aadhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aadhar.Location = new System.Drawing.Point(81, 185);
            this.Aadhar.Multiline = true;
            this.Aadhar.Name = "Aadhar";
            this.Aadhar.Size = new System.Drawing.Size(320, 31);
            this.Aadhar.TabIndex = 23;
            // 
            // DREQUEST
            // 
            this.DREQUEST.BackColor = System.Drawing.Color.White;
            this.DREQUEST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DREQUEST.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DREQUEST.Location = new System.Drawing.Point(81, 329);
            this.DREQUEST.Multiline = true;
            this.DREQUEST.Name = "DREQUEST";
            this.DREQUEST.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DREQUEST.Size = new System.Drawing.Size(320, 136);
            this.DREQUEST.TabIndex = 22;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Address.Location = new System.Drawing.Point(508, 329);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Address.Size = new System.Drawing.Size(360, 53);
            this.Address.TabIndex = 21;
            // 
            // Contact
            // 
            this.Contact.BackColor = System.Drawing.Color.White;
            this.Contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contact.Location = new System.Drawing.Point(508, 185);
            this.Contact.Multiline = true;
            this.Contact.Name = "Contact";
            this.Contact.PlaceholderText = "+91826959xxxx";
            this.Contact.Size = new System.Drawing.Size(360, 33);
            this.Contact.TabIndex = 20;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(590, 665);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(337, 88);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "SUBMIT COMPLAIN";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label6.Location = new System.Drawing.Point(81, 156);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(220, 26);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "AADHAR NUMBER";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(508, 300);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(191, 26);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "FULL ADDRESS";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(81, 300);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(230, 26);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "REQUEST DETAILS";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(508, 156);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(232, 26);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "CONTACT NUMBER";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(343, 75);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(225, 26);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "TYPE OF SERVICE";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Label1.Location = new System.Drawing.Point(272, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(359, 39);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "REQUEST SERVICE";
            // 
            // ComboBox1
            // 
            this.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox1.BackColor = System.Drawing.Color.White;
            this.ComboBox1.DropDownWidth = 579;
            this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "MEDICAL EMERGENCY",
            "ELECTRICITY CONNECTION",
            "NEW ROAD ",
            "WATER SUPPLY",
            "OTHER ISSUES"});
            this.ComboBox1.Location = new System.Drawing.Point(312, 103);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(279, 30);
            this.ComboBox1.TabIndex = 24;
            this.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(508, 387);
            this.Button2.Margin = new System.Windows.Forms.Padding(2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(360, 78);
            this.Button2.TabIndex = 25;
            this.Button2.Text = "SUBMIT REQUEST";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.city);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.comboBox2);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.pictureBox3);
            this.GroupBox1.Controls.Add(this.pictureBox2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.DREQUEST);
            this.GroupBox1.Controls.Add(this.ComboBox1);
            this.GroupBox1.Controls.Add(this.Address);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Aadhar);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Contact);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Location = new System.Drawing.Point(1, -10);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GroupBox1.MaximumSize = new System.Drawing.Size(909, 528);
            this.GroupBox1.MinimumSize = new System.Drawing.Size(909, 528);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GroupBox1.Size = new System.Drawing.Size(909, 528);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.White;
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.city.Location = new System.Drawing.Point(508, 256);
            this.city.Multiline = true;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(360, 33);
            this.city.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(508, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "CITY";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownWidth = 579;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(81, 256);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(320, 33);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(81, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "STATE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::helphub.Properties.Resources.DASHBOARD;
            this.pictureBox3.Location = new System.Drawing.Point(698, 18);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(744, 72);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-64, -32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // REQUEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 479);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(916, 518);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(916, 518);
            this.Name = "REQUEST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REQUEST - HELPHUB";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public TextBox Aadhar;
        public TextBox DREQUEST;
        public TextBox Address;
        public TextBox Contact;
        public Button Button1;
        public Label Label5;
        public Label Label4;
        public Label Label3;
        public Label Label2;
        public Label Label1;
        public ComboBox ComboBox1;
        public Label Label6;
        public Button Button2;
        public GroupBox GroupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        public Label label7;
        public ComboBox comboBox2;
        public Label label8;
        public TextBox city;
    }
}