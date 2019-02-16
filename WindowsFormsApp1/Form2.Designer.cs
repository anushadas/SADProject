namespace WindowsFormsApp1
{
    partial class Form2
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
			this.ivcButton = new System.Windows.Forms.Button();
			this.supButton = new System.Windows.Forms.Button();
			this.repButton = new System.Windows.Forms.Button();
			this.soButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// invButton
			// 
			this.invButton.Location = new System.Drawing.Point(49, 42);
			this.invButton.Name = "invButton";
			this.invButton.Size = new System.Drawing.Size(75, 23);
			this.invButton.TabIndex = 0;
			this.invButton.Text = "Inventory";
			this.invButton.UseVisualStyleBackColor = true;
			this.invButton.Click += new System.EventHandler(this.invButton_Click);
			// 
			// ordButton
			// 
			this.ordButton.Location = new System.Drawing.Point(154, 42);
			this.ordButton.Name = "ordButton";
			this.ordButton.Size = new System.Drawing.Size(75, 23);
			this.ordButton.TabIndex = 1;
			this.ordButton.Text = "Orders";
			this.ordButton.UseVisualStyleBackColor = true;
			this.ordButton.Click += new System.EventHandler(this.ordButton_Click);
			// 
			// custButton
			// 
			this.custButton.Location = new System.Drawing.Point(49, 89);
			this.custButton.Name = "custButton";
			this.custButton.Size = new System.Drawing.Size(75, 23);
			this.custButton.TabIndex = 2;
			this.custButton.Text = "Customers";
			this.custButton.UseVisualStyleBackColor = true;
			this.custButton.Click += new System.EventHandler(this.custButton_Click);
			// 
			// ivcButton
			// 
			this.ivcButton.Location = new System.Drawing.Point(154, 89);
			this.ivcButton.Name = "ivcButton";
			this.ivcButton.Size = new System.Drawing.Size(75, 23);
			this.ivcButton.TabIndex = 3;
			this.ivcButton.Text = "Invoice";
			this.ivcButton.UseVisualStyleBackColor = true;
			this.ivcButton.Click += new System.EventHandler(this.ivcButton_Click);
			// 
			// supButton
			// 
			this.supButton.Location = new System.Drawing.Point(49, 130);
			this.supButton.Name = "supButton";
			this.supButton.Size = new System.Drawing.Size(75, 23);
			this.supButton.TabIndex = 4;
			this.supButton.Text = "Suppliers";
			this.supButton.UseVisualStyleBackColor = true;
			this.supButton.Click += new System.EventHandler(this.supButton_Click);
			// 
			// repButton
			// 
			this.repButton.Location = new System.Drawing.Point(154, 130);
			this.repButton.Name = "repButton";
			this.repButton.Size = new System.Drawing.Size(75, 23);
			this.repButton.TabIndex = 5;
			this.repButton.Text = "Reports";
			this.repButton.UseVisualStyleBackColor = true;
			this.repButton.Click += new System.EventHandler(this.repButton_Click);
			// 
			// soButton
			// 
			this.soButton.Location = new System.Drawing.Point(188, 227);
			this.soButton.Name = "soButton";
			this.soButton.Size = new System.Drawing.Size(75, 23);
			this.soButton.TabIndex = 6;
			this.soButton.Text = "Sign Out";
			this.soButton.UseVisualStyleBackColor = true;
			this.soButton.Click += new System.EventHandler(this.soButton_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.soButton);
			this.Controls.Add(this.repButton);
			this.Controls.Add(this.supButton);
			this.Controls.Add(this.ivcButton);
			this.Controls.Add(this.custButton);
			this.Controls.Add(this.ordButton);
			this.Controls.Add(this.invButton);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.Button ordButton;
        private System.Windows.Forms.Button custButton;
        private System.Windows.Forms.Button ivcButton;
        private System.Windows.Forms.Button supButton;
        private System.Windows.Forms.Button repButton;
        private System.Windows.Forms.Button soButton;
    }
}