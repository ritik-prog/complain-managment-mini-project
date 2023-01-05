using System.Diagnostics;

namespace helphub
{
    public partial class STATUS : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STATUS));
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.requestdataview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request_dataview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.complaindataview = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aadharno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofcomplain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutcomplain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestdataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaindataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(299, 102);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(334, 36);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "COMPLAINS STATUS";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.button3);
            this.GroupBox1.Controls.Add(this.button2);
            this.GroupBox1.Controls.Add(this.requestdataview);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.complaindataview);
            this.GroupBox1.Controls.Add(this.pictureBox3);
            this.GroupBox1.Controls.Add(this.pictureBox2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Location = new System.Drawing.Point(1, -11);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GroupBox1.MaximumSize = new System.Drawing.Size(909, 528);
            this.GroupBox1.MinimumSize = new System.Drawing.Size(909, 528);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GroupBox1.Size = new System.Drawing.Size(909, 528);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(639, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 25);
            this.button3.TabIndex = 33;
            this.button3.Text = "DOWNLOAD REQUESTS REPORT\r\n\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 25);
            this.button2.TabIndex = 32;
            this.button2.Text = "DOWNLOAD COMPLAINS REPORT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Request_dataview,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.requestdataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.requestdataview.GridColor = System.Drawing.Color.Black;
            this.requestdataview.Location = new System.Drawing.Point(51, 353);
            this.requestdataview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.requestdataview.Name = "requestdataview";
            this.requestdataview.RowHeadersWidth = 82;
            this.requestdataview.RowTemplate.Height = 41;
            this.requestdataview.Size = new System.Drawing.Size(800, 151);
            this.requestdataview.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "aadharno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Aadhar Number";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Request_dataview
            // 
            this.Request_dataview.DataPropertyName = "typeofrequest";
            this.Request_dataview.HeaderText = "Request";
            this.Request_dataview.MinimumWidth = 10;
            this.Request_dataview.Name = "Request_dataview";
            this.Request_dataview.ReadOnly = true;
            this.Request_dataview.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mobilenumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mobile Number";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "aboutrequest";
            this.dataGridViewTextBoxColumn5.HeaderText = "Request Details";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(317, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "REQUEST STATUS";
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
            this.ID,
            this.aadharno,
            this.typeofcomplain,
            this.mobilenumber,
            this.aboutcomplain,
            this.address,
            this.status_table});
            this.complaindataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.complaindataview.GridColor = System.Drawing.Color.Black;
            this.complaindataview.Location = new System.Drawing.Point(51, 155);
            this.complaindataview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.complaindataview.Name = "complaindataview";
            this.complaindataview.RowHeadersWidth = 82;
            this.complaindataview.RowTemplate.Height = 41;
            this.complaindataview.Size = new System.Drawing.Size(800, 151);
            this.complaindataview.TabIndex = 29;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 200;
            // 
            // aadharno
            // 
            this.aadharno.DataPropertyName = "aadharno";
            this.aadharno.HeaderText = "Aadhar Number";
            this.aadharno.MinimumWidth = 10;
            this.aadharno.Name = "aadharno";
            this.aadharno.ReadOnly = true;
            this.aadharno.Width = 200;
            // 
            // typeofcomplain
            // 
            this.typeofcomplain.DataPropertyName = "typeofcomplain";
            this.typeofcomplain.HeaderText = "Complain";
            this.typeofcomplain.MinimumWidth = 10;
            this.typeofcomplain.Name = "typeofcomplain";
            this.typeofcomplain.ReadOnly = true;
            this.typeofcomplain.Width = 200;
            // 
            // mobilenumber
            // 
            this.mobilenumber.DataPropertyName = "mobilenumber";
            this.mobilenumber.HeaderText = "Mobile Number";
            this.mobilenumber.MinimumWidth = 10;
            this.mobilenumber.Name = "mobilenumber";
            this.mobilenumber.ReadOnly = true;
            this.mobilenumber.Width = 200;
            // 
            // aboutcomplain
            // 
            this.aboutcomplain.DataPropertyName = "aboutcomplain";
            this.aboutcomplain.HeaderText = "Complain Details";
            this.aboutcomplain.MinimumWidth = 10;
            this.aboutcomplain.Name = "aboutcomplain";
            this.aboutcomplain.ReadOnly = true;
            this.aboutcomplain.Width = 200;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 10;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 200;
            // 
            // status_table
            // 
            this.status_table.DataPropertyName = "status";
            this.status_table.HeaderText = "Status";
            this.status_table.MinimumWidth = 10;
            this.status_table.Name = "status_table";
            this.status_table.ReadOnly = true;
            this.status_table.Width = 200;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::helphub.Properties.Resources.DASHBOARD;
            this.pictureBox3.Location = new System.Drawing.Point(693, 18);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(227, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::helphub.Properties.Resources.LOGOUT;
            this.pictureBox2.Location = new System.Drawing.Point(745, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::helphub.Properties.Resources.Support_service_with_headphones__Customer_Support_service_logo_template__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-67, -32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // STATUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(896, 519);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(912, 558);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(912, 558);
            this.Name = "STATUS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STATUS - HELPHUB";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestdataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaindataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        public Button Button1;
        public Label Label1;
        public GroupBox GroupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DataGridView complaindataview;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn aadharno;
        private DataGridViewTextBoxColumn typeofcomplain;
        private DataGridViewTextBoxColumn REQUEST;
        private DataGridViewTextBoxColumn mobilenumber;
        private DataGridViewTextBoxColumn aboutcomplain;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn status_table;
        public Label label2;
        private DataGridView requestdataview;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Request_dataview;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Button button3;
        private Button button2;
    }
}