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
            this.Button3 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aadhar
            // 
            this.Aadhar.BackColor = System.Drawing.Color.Gainsboro;
            this.Aadhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Aadhar.Location = new System.Drawing.Point(64, 223);
            this.Aadhar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Aadhar.Multiline = true;
            this.Aadhar.Name = "Aadhar";
            this.Aadhar.Size = new System.Drawing.Size(592, 64);
            this.Aadhar.TabIndex = 23;
            // 
            // DREQUEST
            // 
            this.DREQUEST.BackColor = System.Drawing.Color.Gainsboro;
            this.DREQUEST.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DREQUEST.Location = new System.Drawing.Point(64, 406);
            this.DREQUEST.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DREQUEST.Multiline = true;
            this.DREQUEST.Name = "DREQUEST";
            this.DREQUEST.Size = new System.Drawing.Size(846, 178);
            this.DREQUEST.TabIndex = 22;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.Gainsboro;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Address.Location = new System.Drawing.Point(965, 406);
            this.Address.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(653, 178);
            this.Address.TabIndex = 21;
            // 
            // Contact
            // 
            this.Contact.BackColor = System.Drawing.Color.Gainsboro;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Contact.Location = new System.Drawing.Point(945, 219);
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
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label6.Location = new System.Drawing.Point(64, 166);
            this.Label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(413, 51);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "AADHAR NUMBER";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(965, 341);
            this.Label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(359, 51);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "FULL ADDRESS";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(64, 341);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(806, 59);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "BRIEF DETAILS ABOUT YOUR REQUEST";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(945, 166);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(441, 51);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "CONTACT NUMBER";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(64, 620);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(439, 51);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "TYPE OF REQUEST";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Label1.Location = new System.Drawing.Point(472, 53);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(609, 79);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "FILE A REQUEST";
            // 
            // ComboBox1
            // 
            this.ComboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.ComboBox1.DropDownWidth = 579;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "WATER / SEWAGE",
            "DOMESTIC VOILENCE",
            "ELECTRICITY",
            "STREET DOGS",
            "ROAD",
            "OTHER ISSUES"});
            this.ComboBox1.Location = new System.Drawing.Point(64, 684);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(515, 40);
            this.ComboBox1.TabIndex = 24;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(64, 753);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(515, 166);
            this.Button2.TabIndex = 25;
            this.Button2.Text = "SUBMIT REQUEST";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button3.Location = new System.Drawing.Point(660, 684);
            this.Button3.Margin = new System.Windows.Forms.Padding(4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(958, 235);
            this.Button3.TabIndex = 26;
            this.Button3.Text = "CLEAR";
            this.Button3.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button3);
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
            this.GroupBox1.Location = new System.Drawing.Point(1, 3);
            this.GroupBox1.MaximumSize = new System.Drawing.Size(1688, 1127);
            this.GroupBox1.MinimumSize = new System.Drawing.Size(1688, 1127);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1688, 1127);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "REQUEST";
            // 
            // REQUEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1662, 1056);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1688, 1127);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1688, 1127);
            this.Name = "REQUEST";
            this.Text = "REQUEST";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
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
        public Button Button3;
        public GroupBox GroupBox1;
    }
}