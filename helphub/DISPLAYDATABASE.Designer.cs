namespace helphub
{
    partial class DISPLAYDATABASE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DISPLAYDATABASE));
            this.displaydatabasedata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.updatedatabase = new System.Windows.Forms.Button();
            this.adduser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displaydatabasedata)).BeginInit();
            this.SuspendLayout();
            // 
            // displaydatabasedata
            // 
            this.displaydatabasedata.AllowUserToAddRows = false;
            this.displaydatabasedata.AllowUserToDeleteRows = false;
            this.displaydatabasedata.BackgroundColor = System.Drawing.Color.White;
            this.displaydatabasedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displaydatabasedata.Location = new System.Drawing.Point(12, 67);
            this.displaydatabasedata.Name = "displaydatabasedata";
            this.displaydatabasedata.ReadOnly = true;
            this.displaydatabasedata.RowTemplate.Height = 25;
            this.displaydatabasedata.Size = new System.Drawing.Size(776, 340);
            this.displaydatabasedata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLACEHOLDER TEXT";
            // 
            // updatedatabase
            // 
            this.updatedatabase.Location = new System.Drawing.Point(595, 21);
            this.updatedatabase.Name = "updatedatabase";
            this.updatedatabase.Size = new System.Drawing.Size(193, 40);
            this.updatedatabase.TabIndex = 2;
            this.updatedatabase.Text = "UPDATE DATABASE";
            this.updatedatabase.UseVisualStyleBackColor = true;
            this.updatedatabase.Click += new System.EventHandler(this.updatedatabase_Click);
            // 
            // adduser
            // 
            this.adduser.Location = new System.Drawing.Point(396, 20);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(193, 40);
            this.adduser.TabIndex = 3;
            this.adduser.Text = "ADD USER";
            this.adduser.UseVisualStyleBackColor = true;
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "REFRESH DATABASE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(396, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "DOWNLOAD DATA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DISPLAYDATABASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.adduser);
            this.Controls.Add(this.updatedatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displaydatabasedata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "DISPLAYDATABASE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            ((System.ComponentModel.ISupportInitialize)(this.displaydatabasedata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView displaydatabasedata;
        private Label label1;
        private Button updatedatabase;
        private Button button1;
        private Button adduser;
        private Button button2;
        private Button button3;
    }
}