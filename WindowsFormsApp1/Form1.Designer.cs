namespace WindowsFormsApp1
{
    partial class Form1
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
			this.unLabel = new System.Windows.Forms.Label();
			this.pwLabel = new System.Windows.Forms.Label();
			this.unTextBox = new System.Windows.Forms.TextBox();
			this.pwTextBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// unLabel
			// 
			this.unLabel.AutoSize = true;
			this.unLabel.Location = new System.Drawing.Point(63, 73);
			this.unLabel.Name = "unLabel";
			this.unLabel.Size = new System.Drawing.Size(61, 13);
			this.unLabel.TabIndex = 0;
			this.unLabel.Text = "Username :";
			// 
			// pwLabel
			// 
			this.pwLabel.AutoSize = true;
			this.pwLabel.Location = new System.Drawing.Point(65, 97);
			this.pwLabel.Name = "pwLabel";
			this.pwLabel.Size = new System.Drawing.Size(59, 13);
			this.pwLabel.TabIndex = 1;
			this.pwLabel.Text = "Password :";
			// 
			// unTextBox
			// 
			this.unTextBox.Location = new System.Drawing.Point(148, 73);
			this.unTextBox.Name = "unTextBox";
			this.unTextBox.Size = new System.Drawing.Size(100, 20);
			this.unTextBox.TabIndex = 2;
			// 
			// pwTextBox
			// 
			this.pwTextBox.Location = new System.Drawing.Point(148, 99);
			this.pwTextBox.Name = "pwTextBox";
			this.pwTextBox.Size = new System.Drawing.Size(100, 20);
			this.pwTextBox.TabIndex = 3;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(109, 139);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(109, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.pwTextBox);
			this.Controls.Add(this.unTextBox);
			this.Controls.Add(this.pwLabel);
			this.Controls.Add(this.unLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.TextBox unTextBox;
        public System.Windows.Forms.TextBox pwTextBox;
		private System.Windows.Forms.Button button1;
	}
}

