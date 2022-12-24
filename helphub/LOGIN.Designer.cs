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
            this.Password = new System.Windows.Forms.TextBox();
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
            this.REGISTRATION.Controls.Add(this.Password);
            this.REGISTRATION.Controls.Add(this.Username);
            this.REGISTRATION.Controls.Add(this.Label5);
            this.REGISTRATION.Controls.Add(this.Label2);
            this.REGISTRATION.Controls.Add(this.Label1);
            this.REGISTRATION.Controls.Add(this.Button2);
            this.REGISTRATION.Controls.Add(this.pictureBox1);
            this.REGISTRATION.Location = new System.Drawing.Point(0, 0);
            this.REGISTRATION.Margin = new System.Windows.Forms.Padding(0);
            this.REGISTRATION.MaximumSize = new System.Drawing.Size(1488, 1127);
            this.REGISTRATION.MinimumSize = new System.Drawing.Size(1488, 1127);
            this.REGISTRATION.Name = "REGISTRATION";
            this.REGISTRATION.Padding = new System.Windows.Forms.Padding(0);
            this.REGISTRATION.Size = new System.Drawing.Size(1488, 1127);
            this.REGISTRATION.TabIndex = 0;
            this.REGISTRATION.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(618, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "DON\'T HAVE ACCOUNT? REGISTER HERE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(576, 291);
            this.Password.Margin = new System.Windows.Forms.Padding(6);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(459, 52);
            this.Password.TabIndex = 11;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(576, 163);
            this.Username.Margin = new System.Windows.Forms.Padding(6);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(459, 50);
            this.Username.TabIndex = 8;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label5.Font = new System.Drawing.Font("Bauhaus 93", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(576, 243);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(206, 42);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "PASSWORD";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label2.Font = new System.Drawing.Font("Bauhaus 93", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(576, 115);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(195, 42);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "USERNAME";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(618, 19);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 128);
            this.Label1.TabIndex = 1;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button2.Font = new System.Drawing.Font("Bauhaus 93", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(576, 386);
            this.Button2.Margin = new System.Windows.Forms.Padding(6);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(459, 96);
            this.Button2.TabIndex = 0;
            this.Button2.Text = "LOGIN";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 926);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 779);
            this.Controls.Add(this.REGISTRATION);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1158, 850);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1158, 850);
            this.Name = "LOGIN";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN - HELPHUB";
            this.REGISTRATION.ResumeLayout(false);
            this.REGISTRATION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        public Label Label2;
        public Label Label1;
        public GroupBox REGISTRATION;
        public Button Button2;
        public TextBox Password;
        public Label Label5;
        private Label label3;
        private PictureBox pictureBox1;
        public TextBox Username;
    }
}