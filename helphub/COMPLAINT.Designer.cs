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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(COMPLAINT));
            Aadhar = new System.Windows.Forms.TextBox();
            Dcomplaint = new System.Windows.Forms.TextBox();
            Address = new System.Windows.Forms.TextBox();
            Contact = new System.Windows.Forms.TextBox();
            Button1 = new System.Windows.Forms.Button();
            Label6 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            ComboBox1 = new System.Windows.Forms.ComboBox();
            Button2 = new System.Windows.Forms.Button();
            Button3 = new System.Windows.Forms.Button();
            GroupBox1 = new System.Windows.Forms.GroupBox();
            GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aadhar
            // 
            Aadhar.BackColor = System.Drawing.Color.Gainsboro;
            Aadhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Aadhar.Location = new System.Drawing.Point(64, 223);
            Aadhar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Aadhar.Multiline = true;
            Aadhar.Name = "Aadhar";
            Aadhar.Size = new System.Drawing.Size(592, 64);
            Aadhar.TabIndex = 23;
            // 
            // Dcomplaint
            // 
            Dcomplaint.BackColor = System.Drawing.Color.Gainsboro;
            Dcomplaint.Font = new System.Drawing.Font("Segoe UI", 10.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Dcomplaint.Location = new System.Drawing.Point(64, 406);
            Dcomplaint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Dcomplaint.Multiline = true;
            Dcomplaint.Name = "Dcomplaint";
            Dcomplaint.Size = new System.Drawing.Size(846, 178);
            Dcomplaint.TabIndex = 22;
            // 
            // Address
            // 
            Address.BackColor = System.Drawing.Color.Gainsboro;
            Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Address.Location = new System.Drawing.Point(965, 406);
            Address.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Address.Multiline = true;
            Address.Name = "Address";
            Address.Size = new System.Drawing.Size(653, 178);
            Address.TabIndex = 21;
            // 
            // Contact
            // 
            Contact.BackColor = System.Drawing.Color.Gainsboro;
            Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Contact.Location = new System.Drawing.Point(945, 219);
            Contact.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Contact.Multiline = true;
            Contact.Name = "Contact";
            Contact.Size = new System.Drawing.Size(592, 68);
            Contact.TabIndex = 20;
            // 
            // Button1
            // 
            Button1.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 24.0f, (System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point);
            Button1.Location = new System.Drawing.Point(1096, 1418);
            Button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Button1.Name = "Button1";
            Button1.Size = new System.Drawing.Size(625, 188);
            Button1.TabIndex = 18;
            Button1.Text = "SUBMIT COMPLAIN";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Label6.Location = new System.Drawing.Point(64, 166);
            Label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size(413, 51);
            Label6.TabIndex = 17;
            Label6.Text = "AADHAR NUMBER";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Label5.Location = new System.Drawing.Point(965, 341);
            Label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(359, 51);
            Label5.TabIndex = 16;
            Label5.Text = "FULL ADDRESS";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new System.Drawing.Font("Segoe UI", 16.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Label4.Location = new System.Drawing.Point(64, 341);
            Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(871, 59);
            Label4.TabIndex = 15;
            Label4.Text = "BRIEF DETAILS ABOUT YOUR COMPLAINT";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Label3.Location = new System.Drawing.Point(945, 166);
            Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(441, 51);
            Label3.TabIndex = 14;
            Label3.Text = "CONTACT NUMBER";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Label2.Location = new System.Drawing.Point(64, 620);
            Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(457, 51);
            Label2.TabIndex = 13;
            Label2.Text = "TYPE OF COMPLAIN";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Label1.ForeColor = System.Drawing.Color.DarkOrange;
            Label1.Location = new System.Drawing.Point(472, 53);
            Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(679, 79);
            Label1.TabIndex = 12;
            Label1.Text = "FILE A COMPLAINT";
            // 
            // ComboBox1
            // 
            ComboBox1.BackColor = System.Drawing.Color.Gainsboro;
            ComboBox1.DropDownWidth = 579;
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Items.AddRange(new object[] { "WATER / SEWAGE", "DOMESTIC VOILENCE", "ELECTRICITY", "STREET DOGS", "ROAD", "OTHER ISSUES" });
            ComboBox1.Location = new System.Drawing.Point(64, 684);
            ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new System.Drawing.Size(515, 40);
            ComboBox1.TabIndex = 24;
            // 
            // Button2
            // 
            Button2.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            Button2.Font = new System.Drawing.Font("Segoe UI", 20.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Button2.Location = new System.Drawing.Point(64, 753);
            Button2.Margin = new System.Windows.Forms.Padding(4);
            Button2.Name = "Button2";
            Button2.Size = new System.Drawing.Size(515, 166);
            Button2.TabIndex = 25;
            Button2.Text = "SUBMIT COMPLAINT";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            Button3.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            Button3.Font = new System.Drawing.Font("Segoe UI", 18.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Button3.Location = new System.Drawing.Point(660, 684);
            Button3.Margin = new System.Windows.Forms.Padding(4);
            Button3.Name = "Button3";
            Button3.Size = new System.Drawing.Size(958, 235);
            Button3.TabIndex = 26;
            Button3.Text = "CLEAR";
            Button3.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Button3);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(Button2);
            GroupBox1.Controls.Add(Label6);
            GroupBox1.Controls.Add(Dcomplaint);
            GroupBox1.Controls.Add(ComboBox1);
            GroupBox1.Controls.Add(Address);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(Aadhar);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(Contact);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Location = new System.Drawing.Point(1, 3);
            GroupBox1.MaximumSize = new System.Drawing.Size(1688, 1127);
            GroupBox1.MinimumSize = new System.Drawing.Size(1688, 1127);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new System.Drawing.Size(1688, 1127);
            GroupBox1.TabIndex = 28;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "complaint";
            // 
            // COMPLAINT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13.0f, 32.0f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1662, 1056);
            this.Controls.Add(Button1);
            this.Controls.Add(GroupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1688, 1127);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1688, 1127);
            this.Name = "COMPLAINT";
            this.Text = "COMPLAINT";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
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
        public Button Button3;
        public GroupBox GroupBox1;
    }
}