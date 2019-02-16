namespace WindowsFormsApp1
{
	partial class SalesRep
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRep));
			this.invButton = new System.Windows.Forms.Button();
			this.ordButton = new System.Windows.Forms.Button();
			this.custButton = new System.Windows.Forms.Button();
			this.supbutton4 = new System.Windows.Forms.Button();
			this.repButton = new System.Windows.Forms.Button();
			this.soButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// invButton
			// 
			this.invButton.Location = new System.Drawing.Point(19, 12);
			this.invButton.Name = "invButton";
			this.invButton.Size = new System.Drawing.Size(75, 23);
			this.invButton.TabIndex = 3;
			this.invButton.Text = "Inventory";
			this.invButton.UseVisualStyleBackColor = true;
			this.invButton.Click += new System.EventHandler(this.invButton_Click);
			// 
			// ordButton
			// 
			this.ordButton.Location = new System.Drawing.Point(100, 12);
			this.ordButton.Name = "ordButton";
			this.ordButton.Size = new System.Drawing.Size(75, 23);
			this.ordButton.TabIndex = 4;
			this.ordButton.Text = "Orders";
			this.ordButton.UseVisualStyleBackColor = true;
			this.ordButton.Click += new System.EventHandler(this.ordButton_Click);
			// 
			// custButton
			// 
			this.custButton.Location = new System.Drawing.Point(181, 12);
			this.custButton.Name = "custButton";
			this.custButton.Size = new System.Drawing.Size(75, 23);
			this.custButton.TabIndex = 5;
			this.custButton.Text = "Customers";
			this.custButton.UseVisualStyleBackColor = true;
			this.custButton.Click += new System.EventHandler(this.custButton_Click);
			// 
			// supbutton4
			// 
			this.supbutton4.Location = new System.Drawing.Point(262, 12);
			this.supbutton4.Name = "supbutton4";
			this.supbutton4.Size = new System.Drawing.Size(75, 23);
			this.supbutton4.TabIndex = 6;
			this.supbutton4.Text = "Suppliers";
			this.supbutton4.UseVisualStyleBackColor = true;
			this.supbutton4.Click += new System.EventHandler(this.supbutton4_Click);
			// 
			// repButton
			// 
			this.repButton.Location = new System.Drawing.Point(343, 12);
			this.repButton.Name = "repButton";
			this.repButton.Size = new System.Drawing.Size(75, 23);
			this.repButton.TabIndex = 7;
			this.repButton.Text = "Reports";
			this.repButton.UseVisualStyleBackColor = true;
			this.repButton.Click += new System.EventHandler(this.repButton_Click);
			// 
			// soButton
			// 
			this.soButton.Location = new System.Drawing.Point(529, 539);
			this.soButton.Name = "soButton";
			this.soButton.Size = new System.Drawing.Size(75, 23);
			this.soButton.TabIndex = 8;
			this.soButton.Text = "Sign Out";
			this.soButton.UseVisualStyleBackColor = true;
			this.soButton.Click += new System.EventHandler(this.soButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(45, 79);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(292, 77);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Sales Report";
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(33, 166);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(490, 396);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// SalesRep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 574);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.soButton);
			this.Controls.Add(this.repButton);
			this.Controls.Add(this.supbutton4);
			this.Controls.Add(this.custButton);
			this.Controls.Add(this.ordButton);
			this.Controls.Add(this.invButton);
			this.Name = "SalesRep";
			this.Text = "SalesRep";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}