namespace WindowsFormsApp1
{
	partial class InvtRep
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.totqtytextBox = new System.Windows.Forms.TextBox();
			this.totInvtextBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// invButton
			// 
			this.invButton.Location = new System.Drawing.Point(12, 12);
			this.invButton.Name = "invButton";
			this.invButton.Size = new System.Drawing.Size(75, 23);
			this.invButton.TabIndex = 3;
			this.invButton.Text = "Inventory";
			this.invButton.UseVisualStyleBackColor = true;
			this.invButton.Click += new System.EventHandler(this.invButton_Click);
			// 
			// ordButton
			// 
			this.ordButton.Location = new System.Drawing.Point(93, 12);
			this.ordButton.Name = "ordButton";
			this.ordButton.Size = new System.Drawing.Size(75, 23);
			this.ordButton.TabIndex = 4;
			this.ordButton.Text = "Orders";
			this.ordButton.UseVisualStyleBackColor = true;
			this.ordButton.Click += new System.EventHandler(this.ordButton_Click);
			// 
			// custButton
			// 
			this.custButton.Location = new System.Drawing.Point(174, 12);
			this.custButton.Name = "custButton";
			this.custButton.Size = new System.Drawing.Size(75, 23);
			this.custButton.TabIndex = 5;
			this.custButton.Text = "Customers";
			this.custButton.UseVisualStyleBackColor = true;
			this.custButton.Click += new System.EventHandler(this.custButton_Click);
			// 
			// supbutton4
			// 
			this.supbutton4.Location = new System.Drawing.Point(255, 12);
			this.supbutton4.Name = "supbutton4";
			this.supbutton4.Size = new System.Drawing.Size(75, 23);
			this.supbutton4.TabIndex = 6;
			this.supbutton4.Text = "Suppliers";
			this.supbutton4.UseVisualStyleBackColor = true;
			this.supbutton4.Click += new System.EventHandler(this.supbutton4_Click);
			// 
			// repButton
			// 
			this.repButton.Location = new System.Drawing.Point(336, 12);
			this.repButton.Name = "repButton";
			this.repButton.Size = new System.Drawing.Size(75, 23);
			this.repButton.TabIndex = 7;
			this.repButton.Text = "Reports";
			this.repButton.UseVisualStyleBackColor = true;
			this.repButton.Click += new System.EventHandler(this.repButton_Click);
			// 
			// soButton
			// 
			this.soButton.Location = new System.Drawing.Point(354, 301);
			this.soButton.Name = "soButton";
			this.soButton.Size = new System.Drawing.Size(75, 23);
			this.soButton.TabIndex = 8;
			this.soButton.Text = "Sign Out";
			this.soButton.UseVisualStyleBackColor = true;
			this.soButton.Click += new System.EventHandler(this.soButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Inventory Report";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(15, 73);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(262, 20);
			this.textBox1.TabIndex = 10;
			this.textBox1.Text = "Item Number           Quantity      Hold         Price";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(15, 100);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(262, 160);
			this.richTextBox1.TabIndex = 11;
			this.richTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 272);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Total Inventory Quantity";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(147, 272);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Total Inventory Value";
			// 
			// totqtytextBox
			// 
			this.totqtytextBox.Location = new System.Drawing.Point(15, 289);
			this.totqtytextBox.Name = "totqtytextBox";
			this.totqtytextBox.Size = new System.Drawing.Size(100, 20);
			this.totqtytextBox.TabIndex = 14;
			// 
			// totInvtextBox3
			// 
			this.totInvtextBox3.Location = new System.Drawing.Point(155, 289);
			this.totInvtextBox3.Name = "totInvtextBox3";
			this.totInvtextBox3.Size = new System.Drawing.Size(100, 20);
			this.totInvtextBox3.TabIndex = 15;
			// 
			// InvtRep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 336);
			this.Controls.Add(this.totInvtextBox3);
			this.Controls.Add(this.totqtytextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.soButton);
			this.Controls.Add(this.repButton);
			this.Controls.Add(this.supbutton4);
			this.Controls.Add(this.custButton);
			this.Controls.Add(this.ordButton);
			this.Controls.Add(this.invButton);
			this.Name = "InvtRep";
			this.Text = "InvtRep";
			this.Load += new System.EventHandler(this.InvtRep_Load);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox totqtytextBox;
		private System.Windows.Forms.TextBox totInvtextBox3;
	}
}