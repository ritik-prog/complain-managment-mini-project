using System.Diagnostics;

namespace helphub { 
internal partial class DASHBOARD : System.Windows.Forms.Form
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(DASHBOARD));
        Label1 = new System.Windows.Forms.Label();
        Label2 = new System.Windows.Forms.Label();
        Button1 = new System.Windows.Forms.Button();
        Button2 = new System.Windows.Forms.Button();
        Button3 = new System.Windows.Forms.Button();
        Button4 = new System.Windows.Forms.Button();
        GroupBox1 = new System.Windows.Forms.GroupBox();
        GroupBox1.SuspendLayout();
        this.SuspendLayout();
        // 
        // Label1
        // 
        Label1.AutoSize = true;
        Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        Label1.Location = new System.Drawing.Point(61, 35);
        Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        Label1.Name = "Label1";
        Label1.Size = new System.Drawing.Size(1523, 147);
        Label1.TabIndex = 0;
        Label1.Text = "HELPHUB DASHBOARD";
        // 
        // Label2
        // 
        Label2.AutoSize = true;
        Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        Label2.Location = new System.Drawing.Point(497, 238);
        Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        Label2.Name = "Label2";
        Label2.Size = new System.Drawing.Size(627, 44);
        Label2.TabIndex = 1;
        Label2.Text = "WHAT ARE YOU LOOKING FOR?";
        // 
        // Button1
        // 
        Button1.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
        Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        Button1.Location = new System.Drawing.Point(61, 385);
        Button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        Button1.Name = "Button1";
        Button1.Size = new System.Drawing.Size(564, 198);
        Button1.TabIndex = 2;
        Button1.Text = "FILE COMPLAINT";
        Button1.UseVisualStyleBackColor = false;
        // 
        // Button2
        // 
        Button2.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
        Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        Button2.Location = new System.Drawing.Point(1026, 385);
        Button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        Button2.Name = "Button2";
        Button2.Size = new System.Drawing.Size(558, 198);
        Button2.TabIndex = 3;
        Button2.Text = "REQUEST SERVICE";
        Button2.UseVisualStyleBackColor = false;
        // 
        // Button3
        // 
        Button3.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
        Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        Button3.Location = new System.Drawing.Point(342, 701);
        Button3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        Button3.Name = "Button3";
        Button3.Size = new System.Drawing.Size(1027, 101);
        Button3.TabIndex = 4;
        Button3.Text = "COMPLAINT / REQUEST STATUS";
        Button3.UseVisualStyleBackColor = false;
        // 
        // Button4
        // 
        Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        Button4.BackgroundImage = (System.Drawing.Image)resources.GetObject("Button4.BackgroundImage");
        Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.0f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        Button4.Location = new System.Drawing.Point(-359, 688);
        Button4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        Button4.Name = "Button4";
        Button4.Size = new System.Drawing.Size(109, 123);
        Button4.TabIndex = 10;
        Button4.UseVisualStyleBackColor = true;
        // 
        // GroupBox1
        // 
        GroupBox1.Controls.Add(Label1);
        GroupBox1.Controls.Add(Button3);
        GroupBox1.Controls.Add(Label2);
        GroupBox1.Controls.Add(Button2);
        GroupBox1.Controls.Add(Button1);
        GroupBox1.Location = new System.Drawing.Point(3, 2);
        GroupBox1.MaximumSize = new System.Drawing.Size(1688, 1127);
        GroupBox1.MinimumSize = new System.Drawing.Size(1688, 1127);
        GroupBox1.Name = "GroupBox1";
        GroupBox1.Size = new System.Drawing.Size(1688, 1127);
        GroupBox1.TabIndex = 11;
        GroupBox1.TabStop = false;
        GroupBox1.Text = "dashboard";
        // 
        // DASHBOARD
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(13.0f, 32.0f);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.BackColor = System.Drawing.Color.White;
        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        this.ClientSize = new System.Drawing.Size(1662, 1056);
        this.Controls.Add(Button4);
        this.Controls.Add(GroupBox1);
        this.DoubleBuffered = true;
        this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
        this.MaximizeBox = false;
        this.MaximumSize = new System.Drawing.Size(1688, 1127);
        this.MinimizeBox = false;
        this.MinimumSize = new System.Drawing.Size(1688, 1127);
        this.Name = "DASHBOARD";
        this.Text = "DASHBOARD";
        GroupBox1.ResumeLayout(false);
        GroupBox1.PerformLayout();
        this.ResumeLayout(false);

    }

    public Label Label1;
    public Label Label2;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public GroupBox GroupBox1;
}
}