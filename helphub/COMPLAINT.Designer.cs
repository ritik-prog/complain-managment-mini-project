using System.Diagnostics;

namespace helphub
{
    public partial class COMPLAINT : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMPLAINT));
            this.Aadhar = new System.Windows.Forms.TextBox();
            this.Dcomplaint = new System.Windows.Forms.TextBox();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aadhar
            // 
            this.Aadhar.BackColor = System.Drawing.Color.White;
            this.Aadhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Aadhar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aadhar.Location = new System.Drawing.Point(147, 379);
            this.Aadhar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Aadhar.Multiline = true;
            this.Aadhar.Name = "Aadhar";
            this.Aadhar.Size = new System.Drawing.Size(592, 64);
            this.Aadhar.TabIndex = 23;
            // 
            // Dcomplaint
            // 
            this.Dcomplaint.BackColor = System.Drawing.Color.White;
            this.Dcomplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dcomplaint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dcomplaint.Location = new System.Drawing.Point(147, 550);
            this.Dcomplaint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Dcomplaint.Multiline = true;
            this.Dcomplaint.Name = "Dcomplaint";
            this.Dcomplaint.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Dcomplaint.Size = new System.Drawing.Size(592, 178);
            this.Dcomplaint.TabIndex = 22;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Address.Location = new System.Drawing.Point(939, 550);
            this.Address.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Address.Size = new System.Drawing.Size(653, 178);
            this.Address.TabIndex = 21;
            // 
            // Contact
            // 
            this.Contact.BackColor = System.Drawing.Color.White;
            this.Contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Contact.Location = new System.Drawing.Point(939, 379);
            this.Contact.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Contact.Multiline = true;
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(592, 68);
            this.Contact.TabIndex = 20;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(1096, 1418);
            this.Button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(625, 188);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "SUBMIT COMPLAIN";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label6.Font = new System.Drawing.Font("Bauhaus 93", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label6.Location = new System.Drawing.Point(147, 324);
            this.Label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(362, 49);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "AADHAR NUMBER";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label5.Font = new System.Drawing.Font("Bauhaus 93", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(939, 495);
            this.Label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(289, 49);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "FULL ADDRESS";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label4.Font = new System.Drawing.Font("Bauhaus 93", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(147, 495);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(564, 49);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "DETAILS ABOUT COMPLAINT";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label3.Font = new System.Drawing.Font("Bauhaus 93", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(939, 324);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(344, 49);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "MOBILE NUMBER";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label2.Font = new System.Drawing.Font("Bauhaus 93", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(641, 174);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(403, 49);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "TYPE OF COMPLAIN";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Bauhaus 93", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Label1.Location = new System.Drawing.Point(547, 54);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(599, 78);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "FILE A COMPLAINT";
            // 
            // ComboBox1
            // 
            this.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox1.BackColor = System.Drawing.Color.White;
            this.ComboBox1.DropDownWidth = 579;
            this.ComboBox1.Font = new System.Drawing.Font("Bauhaus 93", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "DOMESTIC VOILENCE",
            "ELECTRICITY",
            "ROAD",
            "STREET DOGS",
            "WATER / SEWAGE",
            "OTHER ISSUES"});
            this.ComboBox1.Location = new System.Drawing.Point(590, 240);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(515, 50);
            this.ComboBox1.TabIndex = 24;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button2.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(524, 775);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(668, 166);
            this.Button2.TabIndex = 25;
            this.Button2.Text = "SUBMIT COMPLAINT";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.pictureBox2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Dcomplaint);
            this.GroupBox1.Controls.Add(this.ComboBox1);
            this.GroupBox1.Controls.Add(this.Address);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Aadhar);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Contact);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Location = new System.Drawing.Point(1, 3);
            this.GroupBox1.MaximumSize = new System.Drawing.Size(1688, 1127);
            this.GroupBox1.MinimumSize = new System.Drawing.Size(1688, 1127);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1688, 1127);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1479, 38);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(160, 55);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(90, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 55);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-116, -64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(531, 540);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(231, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 540);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // COMPLAINT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1662, 989);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1688, 1060);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1688, 1060);
            this.Name = "COMPLAINT";
            this.Text = "COMPLAINT - HELPHUB";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public TextBox Aadhar;
        public TextBox Dcomplaint;
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
    }
}