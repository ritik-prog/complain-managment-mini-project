using System.Diagnostics;

namespace helphub
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.REGISTRATION = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Aadhar = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.REGISTRATION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // REGISTRATION
            // 
            this.REGISTRATION.BackColor = System.Drawing.Color.White;
            this.REGISTRATION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.REGISTRATION.Controls.Add(this.label3);
            this.REGISTRATION.Controls.Add(this.Aadhar);
            this.REGISTRATION.Controls.Add(this.Username);
            this.REGISTRATION.Controls.Add(this.Label5);
            this.REGISTRATION.Controls.Add(this.Label2);
            this.REGISTRATION.Controls.Add(this.Label1);
            this.REGISTRATION.Controls.Add(this.Button2);
            this.REGISTRATION.Controls.Add(this.pictureBox1);
            this.REGISTRATION.Location = new System.Drawing.Point(-4, -4);
            this.REGISTRATION.Margin = new System.Windows.Forms.Padding(0);
            this.REGISTRATION.MaximumSize = new System.Drawing.Size(1688, 1127);
            this.REGISTRATION.MinimumSize = new System.Drawing.Size(1688, 1127);
            this.REGISTRATION.Name = "REGISTRATION";
            this.REGISTRATION.Padding = new System.Windows.Forms.Padding(0);
            this.REGISTRATION.Size = new System.Drawing.Size(1688, 1127);
            this.REGISTRATION.TabIndex = 0;
            this.REGISTRATION.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(584, 823);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "DON\'T HAVE ACCOUNT? REGISTER HERE";
            // 
            // Aadhar
            // 
            this.Aadhar.BackColor = System.Drawing.Color.Gainsboro;
            this.Aadhar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Aadhar.Location = new System.Drawing.Point(1005, 537);
            this.Aadhar.Margin = new System.Windows.Forms.Padding(6);
            this.Aadhar.Name = "Aadhar";
            this.Aadhar.PasswordChar = '*';
            this.Aadhar.Size = new System.Drawing.Size(459, 57);
            this.Aadhar.TabIndex = 11;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Gainsboro;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(217, 537);
            this.Username.Margin = new System.Windows.Forms.Padding(6);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(431, 57);
            this.Username.TabIndex = 8;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(1005, 481);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(232, 51);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "PASSWORD";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(217, 481);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(228, 51);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "USERNAME";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(633, 23);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(348, 128);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "LOGIN";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(633, 701);
            this.Button2.Margin = new System.Windows.Forms.Padding(6);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(348, 96);
            this.Button2.TabIndex = 0;
            this.Button2.Text = "LOGIN";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 643);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1662, 909);
            this.Controls.Add(this.REGISTRATION);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1688, 980);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1688, 980);
            this.Name = "LOGIN";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN - HELPHUB";
            this.REGISTRATION.ResumeLayout(false);
            this.REGISTRATION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        public TextBox Username;
        public Label Label2;
        public Label Label1;
        public GroupBox REGISTRATION;
        public Button Button2;
        public TextBox Aadhar;
        public Label Label5;
        private Label label3;
        private PictureBox pictureBox1;
    }
}