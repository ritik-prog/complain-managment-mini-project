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
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestdataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaindataview)).BeginInit();
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
            this.Label1.Location = new System.Drawing.Point(409, 140);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(200, 36);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "COMPLAINS";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.pictureBox5);
            this.GroupBox1.Controls.Add(this.pictureBox4);
            this.GroupBox1.Controls.Add(this.button2);
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Controls.Add(this.requestdataview);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.complaindataview);
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
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::helphub.Properties.Resources.addnewsupervisor;
            this.pictureBox5.Location = new System.Drawing.Point(0, 684);
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
            this.pictureBox4.Location = new System.Drawing.Point(736, 684);
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
            this.button2.Location = new System.Drawing.Point(736, 142);
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
            this.button1.Location = new System.Drawing.Point(736, 410);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Request_dataview,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.requestdataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.requestdataview.GridColor = System.Drawing.Color.Black;
            this.requestdataview.Location = new System.Drawing.Point(46, 454);
            this.requestdataview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.requestdataview.Name = "requestdataview";
            this.requestdataview.RowHeadersWidth = 82;
            this.requestdataview.RowTemplate.Height = 41;
            this.requestdataview.Size = new System.Drawing.Size(909, 224);
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
            this.dataGridViewTextBoxColumn7.HeaderText = "STATUS";
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
            this.label2.Location = new System.Drawing.Point(422, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "REQUESTS";
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
            this.STATUS});
            this.complaindataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.complaindataview.GridColor = System.Drawing.Color.Black;
            this.complaindataview.Location = new System.Drawing.Point(46, 184);
            this.complaindataview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.complaindataview.Name = "complaindataview";
            this.complaindataview.RowHeadersWidth = 82;
            this.complaindataview.RowTemplate.Height = 41;
            this.complaindataview.Size = new System.Drawing.Size(909, 212);
            this.complaindataview.TabIndex = 29;
            this.complaindataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.complaindataview_CellContentClick);
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
            // STATUS
            // 
            this.STATUS.DataPropertyName = "status";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.MinimumWidth = 10;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 200;
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
            this.pictureBox1.Location = new System.Drawing.Point(-95, -32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 279);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 762);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1017, 761);
            this.Name = "ADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN - HELPHUB";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestdataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaindataview)).EndInit();
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
        private DataGridView complaindataview;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn aadharno;
        private DataGridViewTextBoxColumn typeofcomplain;
        private DataGridViewTextBoxColumn mobilenumber;
        private DataGridViewTextBoxColumn aboutcomplain;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn STATUS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}