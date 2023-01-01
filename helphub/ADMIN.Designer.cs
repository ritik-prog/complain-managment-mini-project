using System.Diagnostics;

namespace helphub
{
    public partial class ADMIN : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN));
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.complaindataview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.requestdataview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complaindataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestdataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(46, 101);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(200, 36);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "COMPLAINS";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.comboBox4);
            this.GroupBox1.Controls.Add(this.ComboBox1);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.comboBox3);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.complaindataview);
            this.GroupBox1.Controls.Add(this.comboBox2);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.pictureBox6);
            this.GroupBox1.Controls.Add(this.button4);
            this.GroupBox1.Controls.Add(this.button3);
            this.GroupBox1.Controls.Add(this.pictureBox5);
            this.GroupBox1.Controls.Add(this.pictureBox4);
            this.GroupBox1.Controls.Add(this.button2);
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Controls.Add(this.requestdataview);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.pictureBox3);
            this.GroupBox1.Controls.Add(this.pictureBox2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Location = new System.Drawing.Point(1, -11);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GroupBox1.MaximumSize = new System.Drawing.Size(1017, 731);
            this.GroupBox1.MinimumSize = new System.Drawing.Size(1017, 731);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GroupBox1.Size = new System.Drawing.Size(1017, 731);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteCustomSource.AddRange(new string[] {
            "ALL STATE",
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
            this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox4.BackColor = System.Drawing.Color.White;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.DropDownWidth = 579;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "ALL STATE",
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
            this.comboBox4.Location = new System.Drawing.Point(265, 424);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(204, 33);
            this.comboBox4.TabIndex = 47;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
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
            "ALL REQUEST",
            "MEDICAL EMERGENCY",
            "ELECTRICITY CONNECTION",
            "NEW ROAD ",
            "WATER SUPPLY",
            "OTHER ISSUES"});
            this.ComboBox1.Location = new System.Drawing.Point(728, 424);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(227, 30);
            this.ComboBox1.TabIndex = 39;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(46, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 26);
            this.label6.TabIndex = 46;
            this.label6.Text = "FILTER BY STATE:- ";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "ALL STATE",
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
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.DropDownWidth = 579;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ALL STATE",
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
            this.comboBox3.Location = new System.Drawing.Point(259, 140);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(204, 33);
            this.comboBox3.TabIndex = 45;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 26);
            this.label5.TabIndex = 44;
            this.label5.Text = "FILTER BY STATE:- ";
            // 
            // complaindataview
            // 
            this.complaindataview.AllowUserToAddRows = false;
            this.complaindataview.AllowUserToDeleteRows = false;
            this.complaindataview.AllowUserToResizeColumns = false;
            this.complaindataview.AllowUserToResizeRows = false;
            this.complaindataview.BackgroundColor = System.Drawing.Color.White;
            this.complaindataview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.complaindataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaindataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.complaindataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.complaindataview.GridColor = System.Drawing.Color.Black;
            this.complaindataview.Location = new System.Drawing.Point(46, 176);
            this.complaindataview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.complaindataview.Name = "complaindataview";
            this.complaindataview.RowHeadersWidth = 82;
            this.complaindataview.RowTemplate.Height = 41;
            this.complaindataview.Size = new System.Drawing.Size(909, 212);
            this.complaindataview.TabIndex = 43;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn15.HeaderText = "City";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn16.HeaderText = "State";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownWidth = 579;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ALL COMPLAINS",
            "DOMESTIC VOILENCE",
            "ELECTRICITY",
            "ROAD",
            "STREET DOGS",
            "WATER / SEWAGE",
            "OTHER ISSUES"});
            this.comboBox2.Location = new System.Drawing.Point(728, 140);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 33);
            this.comboBox2.TabIndex = 41;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(468, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "FILTER BY COMPLAIN:- ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(476, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "FILTER BY REQUEST:- ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::helphub.Properties.Resources.stateadmin1;
            this.pictureBox6.Location = new System.Drawing.Point(710, 684);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(334, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(513, 390);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 30);
            this.button4.TabIndex = 37;
            this.button4.Text = "DELETE REQUEST";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(498, 107);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 30);
            this.button3.TabIndex = 36;
            this.button3.Text = "DELETE COMPLAIN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::helphub.Properties.Resources.addnewsupervisor;
            this.pictureBox5.Location = new System.Drawing.Point(320, 684);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(334, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::helphub.Properties.Resources.addnewadmin;
            this.pictureBox4.Location = new System.Drawing.Point(0, 684);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(264, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(736, 107);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 30);
            this.button2.TabIndex = 33;
            this.button2.Text = "UPDATE COMPLAIN STATUS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(736, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 30);
            this.button1.TabIndex = 32;
            this.button1.Text = "UPDATE REQUEST STATUS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // requestdataview
            // 
            this.requestdataview.AllowUserToAddRows = false;
            this.requestdataview.AllowUserToDeleteRows = false;
            this.requestdataview.AllowUserToResizeColumns = false;
            this.requestdataview.AllowUserToResizeRows = false;
            this.requestdataview.BackgroundColor = System.Drawing.Color.White;
            this.requestdataview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.requestdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestdataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7});
            this.requestdataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.requestdataview.GridColor = System.Drawing.Color.Black;
            this.requestdataview.Location = new System.Drawing.Point(46, 464);
            this.requestdataview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.requestdataview.Name = "requestdataview";
            this.requestdataview.RowHeadersWidth = 82;
            this.requestdataview.RowTemplate.Height = 41;
            this.requestdataview.Size = new System.Drawing.Size(909, 214);
            this.requestdataview.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn3.HeaderText = "City";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn7.HeaderText = "State";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "REQUESTS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::helphub.Properties.Resources.DASHBOARD;
            this.pictureBox3.Location = new System.Drawing.Point(783, 9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::helphub.Properties.Resources.LOGOUT;
            this.pictureBox2.Location = new System.Drawing.Point(846, 57);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::helphub.Properties.Resources.Support_service_with_headphones__Customer_Support_service_logo_template__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-48, -22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1001, 722);
            this.Controls.Add(this.GroupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 762);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1017, 761);
            this.Name = "ADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN - HELPHUB";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complaindataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestdataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        public Label Label1;
        public GroupBox GroupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn REQUEST;
        public Label label2;
        private DataGridView requestdataview;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Request_dataview;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button4;
        private Button button3;
        private PictureBox pictureBox6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        public ComboBox ComboBox1;
        public Label label3;
        public ComboBox comboBox2;
        public Label label4;
        private DataGridView complaindataview;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        public Label label5;
        public ComboBox comboBox3;
        public ComboBox comboBox4;
        public Label label6;
    }
}