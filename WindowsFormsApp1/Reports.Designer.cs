namespace WindowsFormsApp1
{
    partial class Reports
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
			this.invButton = new System.Windows.Forms.Button();
			this.ordButton = new System.Windows.Forms.Button();
			this.custButton = new System.Windows.Forms.Button();
			this.supbutton4 = new System.Windows.Forms.Button();
			this.repButton = new System.Windows.Forms.Button();
			this.soButton = new System.Windows.Forms.Button();
			this.unTextBox = new System.Windows.Forms.TextBox();
			this.unLabel = new System.Windows.Forms.Label();
			this.pwLabel = new System.Windows.Forms.Label();
			this.pwTextBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// invButton
			// 
			this.invButton.Location = new System.Drawing.Point(26, 12);
			this.invButton.Name = "invButton";
			this.invButton.Size = new System.Drawing.Size(75, 23);
			this.invButton.TabIndex = 2;
			this.invButton.Text = "Inventory";
			this.invButton.UseVisualStyleBackColor = true;
			this.invButton.Click += new System.EventHandler(this.invButton_Click);
			// 
			// ordButton
			// 
			this.ordButton.Location = new System.Drawing.Point(107, 12);
			this.ordButton.Name = "ordButton";
			this.ordButton.Size = new System.Drawing.Size(75, 23);
			this.ordButton.TabIndex = 3;
			this.ordButton.Text = "Orders";
			this.ordButton.UseVisualStyleBackColor = true;
			this.ordButton.Click += new System.EventHandler(this.ordButton_Click);
			// 
			// custButton
			// 
			this.custButton.Location = new System.Drawing.Point(197, 12);
			this.custButton.Name = "custButton";
			this.custButton.Size = new System.Drawing.Size(75, 23);
			this.custButton.TabIndex = 4;
			this.custButton.Text = "Customers";
			this.custButton.UseVisualStyleBackColor = true;
			this.custButton.Click += new System.EventHandler(this.custButton_Click);
			// 
			// supbutton4
			// 
			this.supbutton4.Location = new System.Drawing.Point(278, 12);
			this.supbutton4.Name = "supbutton4";
			this.supbutton4.Size = new System.Drawing.Size(75, 23);
			this.supbutton4.TabIndex = 5;
			this.supbutton4.Text = "Suppliers";
			this.supbutton4.UseVisualStyleBackColor = true;
			this.supbutton4.Click += new System.EventHandler(this.supbutton4_Click);
			// 
			// repButton
			// 
			this.repButton.Location = new System.Drawing.Point(359, 12);
			this.repButton.Name = "repButton";
			this.repButton.Size = new System.Drawing.Size(75, 23);
			this.repButton.TabIndex = 6;
			this.repButton.Text = "Reports";
			this.repButton.UseVisualStyleBackColor = true;
			// 
			// soButton
			// 
			this.soButton.Location = new System.Drawing.Point(359, 397);
			this.soButton.Name = "soButton";
			this.soButton.Size = new System.Drawing.Size(75, 23);
			this.soButton.TabIndex = 7;
			this.soButton.Text = "Sign Out";
			this.soButton.UseVisualStyleBackColor = true;
			this.soButton.Click += new System.EventHandler(this.soButton_Click);
			// 
			// unTextBox
			// 
			this.unTextBox.Location = new System.Drawing.Point(181, 94);
			this.unTextBox.Name = "unTextBox";
			this.unTextBox.Size = new System.Drawing.Size(100, 20);
			this.unTextBox.TabIndex = 8;
			// 
			// unLabel
			// 
			this.unLabel.AutoSize = true;
			this.unLabel.Location = new System.Drawing.Point(104, 97);
			this.unLabel.Name = "unLabel";
			this.unLabel.Size = new System.Drawing.Size(61, 13);
			this.unLabel.TabIndex = 9;
			this.unLabel.Text = "Username :";
			// 
			// pwLabel
			// 
			this.pwLabel.AutoSize = true;
			this.pwLabel.Location = new System.Drawing.Point(104, 126);
			this.pwLabel.Name = "pwLabel";
			this.pwLabel.Size = new System.Drawing.Size(59, 13);
			this.pwLabel.TabIndex = 10;
			this.pwLabel.Text = "Password :";
			// 
			// pwTextBox
			// 
			this.pwTextBox.Location = new System.Drawing.Point(181, 120);
			this.pwTextBox.Name = "pwTextBox";
			this.pwTextBox.Size = new System.Drawing.Size(100, 20);
			this.pwTextBox.TabIndex = 11;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(153, 146);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 12;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(150, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Manager Only";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Location = new System.Drawing.Point(97, 223);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 122);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Reports";
			this.groupBox1.Visible = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
            "Sales Report",
            "Invoice",
            "Inventory Report",
            "Expense Report",
            "Packing Slips"});
			this.listBox1.Location = new System.Drawing.Point(36, 20);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(116, 82);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 432);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.pwTextBox);
			this.Controls.Add(this.pwLabel);
			this.Controls.Add(this.unLabel);
			this.Controls.Add(this.unTextBox);
			this.Controls.Add(this.soButton);
			this.Controls.Add(this.repButton);
			this.Controls.Add(this.supbutton4);
			this.Controls.Add(this.custButton);
			this.Controls.Add(this.ordButton);
			this.Controls.Add(this.invButton);
			this.Name = "Reports";
			this.Text = "Reports";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.Button ordButton;
        private System.Windows.Forms.Button custButton;
        private System.Windows.Forms.Button supbutton4;
        private System.Windows.Forms.Button repButton;
        private System.Windows.Forms.Button soButton;
        public System.Windows.Forms.TextBox unTextBox;
        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label pwLabel;
        public System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}