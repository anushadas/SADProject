namespace WindowsFormsApp1
{
    partial class Orders
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
			this.supButton = new System.Windows.Forms.Button();
			this.repButton = new System.Windows.Forms.Button();
			this.sobutton = new System.Windows.Forms.Button();
			this.shpMthdlistBox = new System.Windows.Forms.ListBox();
			this.itDesclistBox = new System.Windows.Forms.ListBox();
			this.QtylistBox = new System.Windows.Forms.ListBox();
			this.addlistBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// invButton
			// 
			this.invButton.Location = new System.Drawing.Point(22, 13);
			this.invButton.Name = "invButton";
			this.invButton.Size = new System.Drawing.Size(75, 23);
			this.invButton.TabIndex = 0;
			this.invButton.Text = "Inventory";
			this.invButton.UseVisualStyleBackColor = true;
			this.invButton.Click += new System.EventHandler(this.invButton_Click);
			// 
			// ordButton
			// 
			this.ordButton.Location = new System.Drawing.Point(103, 13);
			this.ordButton.Name = "ordButton";
			this.ordButton.Size = new System.Drawing.Size(75, 23);
			this.ordButton.TabIndex = 1;
			this.ordButton.Text = "Orders";
			this.ordButton.UseVisualStyleBackColor = true;
			// 
			// custButton
			// 
			this.custButton.Location = new System.Drawing.Point(184, 12);
			this.custButton.Name = "custButton";
			this.custButton.Size = new System.Drawing.Size(75, 23);
			this.custButton.TabIndex = 2;
			this.custButton.Text = "Customers";
			this.custButton.UseVisualStyleBackColor = true;
			this.custButton.Click += new System.EventHandler(this.custButton_Click);
			// 
			// supButton
			// 
			this.supButton.Location = new System.Drawing.Point(265, 12);
			this.supButton.Name = "supButton";
			this.supButton.Size = new System.Drawing.Size(75, 23);
			this.supButton.TabIndex = 3;
			this.supButton.Text = "Suppliers";
			this.supButton.UseVisualStyleBackColor = true;
			this.supButton.Click += new System.EventHandler(this.supButton_Click);
			// 
			// repButton
			// 
			this.repButton.Location = new System.Drawing.Point(346, 13);
			this.repButton.Name = "repButton";
			this.repButton.Size = new System.Drawing.Size(75, 23);
			this.repButton.TabIndex = 4;
			this.repButton.Text = "Reports";
			this.repButton.UseVisualStyleBackColor = true;
			this.repButton.Click += new System.EventHandler(this.repButton_Click);
			// 
			// sobutton
			// 
			this.sobutton.Location = new System.Drawing.Point(458, 398);
			this.sobutton.Name = "sobutton";
			this.sobutton.Size = new System.Drawing.Size(75, 23);
			this.sobutton.TabIndex = 5;
			this.sobutton.Text = "Sign Out";
			this.sobutton.UseVisualStyleBackColor = true;
			this.sobutton.Click += new System.EventHandler(this.sobutton_Click);
			// 
			// shpMthdlistBox
			// 
			this.shpMthdlistBox.FormattingEnabled = true;
			this.shpMthdlistBox.Items.AddRange(new object[] {
            "UPS Standard Shipping",
            "Driver Drop Off",
            "UPS Standard Shipping",
            "UPS Standard Shipping",
            "UPS Standard Shipping",
            "UPS Standard Shipping",
            "Driver Drop Off",
            "UPS Standard Shipping",
            "Driver Drop Off"});
			this.shpMthdlistBox.Location = new System.Drawing.Point(22, 96);
			this.shpMthdlistBox.Name = "shpMthdlistBox";
			this.shpMthdlistBox.Size = new System.Drawing.Size(120, 277);
			this.shpMthdlistBox.TabIndex = 6;
			// 
			// itDesclistBox
			// 
			this.itDesclistBox.FormattingEnabled = true;
			this.itDesclistBox.Items.AddRange(new object[] {
            "Microsoft Laptop\t ITEM # 300434 ",
            "Apple Mac Air   \t ITEM # 453233",
            "Dell Laptop  \t ITEM # 584036",
            "Apple Mac Pro\t ITEM # 300456",
            "Microsoft Laptop\t ITEM # 300567",
            "Microsoft Keyboard\t ITEM # 300876",
            "Acer Laptop\t ITEM # 400897",
            "Dell Keyboard\t ITEM # 300987",
            "Apple iPad\t ITEM # 300234"});
			this.itDesclistBox.Location = new System.Drawing.Point(148, 96);
			this.itDesclistBox.Name = "itDesclistBox";
			this.itDesclistBox.Size = new System.Drawing.Size(186, 277);
			this.itDesclistBox.TabIndex = 7;
			// 
			// QtylistBox
			// 
			this.QtylistBox.FormattingEnabled = true;
			this.QtylistBox.Items.AddRange(new object[] {
            "5",
            "3",
            "1",
            "19",
            "8",
            "13",
            "10",
            "5",
            "6"});
			this.QtylistBox.Location = new System.Drawing.Point(340, 96);
			this.QtylistBox.Name = "QtylistBox";
			this.QtylistBox.Size = new System.Drawing.Size(51, 277);
			this.QtylistBox.TabIndex = 8;
			// 
			// addlistBox
			// 
			this.addlistBox.FormattingEnabled = true;
			this.addlistBox.Items.AddRange(new object[] {
            "1347 Burrard Ave.",
            "5672 Austin Ave.",
            "2314 College Access Rd.",
            "2453 Kingston St.",
            "5642 Royal Ave.",
            "3456 Johnson St.",
            "5638 Robin St.",
            "2345 Kingston St.",
            "5463 Austin Ave."});
			this.addlistBox.Location = new System.Drawing.Point(397, 96);
			this.addlistBox.Name = "addlistBox";
			this.addlistBox.Size = new System.Drawing.Size(136, 277);
			this.addlistBox.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Orders";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Shipping Method";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(148, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Item Description";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(343, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Quantity";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(400, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Address";
			// 
			// Orders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 433);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addlistBox);
			this.Controls.Add(this.QtylistBox);
			this.Controls.Add(this.itDesclistBox);
			this.Controls.Add(this.shpMthdlistBox);
			this.Controls.Add(this.sobutton);
			this.Controls.Add(this.repButton);
			this.Controls.Add(this.supButton);
			this.Controls.Add(this.custButton);
			this.Controls.Add(this.ordButton);
			this.Controls.Add(this.invButton);
			this.Name = "Orders";
			this.Text = "Orders";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.Button ordButton;
        private System.Windows.Forms.Button custButton;
        private System.Windows.Forms.Button supButton;
        private System.Windows.Forms.Button repButton;
        private System.Windows.Forms.Button sobutton;
        private System.Windows.Forms.ListBox shpMthdlistBox;
        private System.Windows.Forms.ListBox itDesclistBox;
        private System.Windows.Forms.ListBox QtylistBox;
        private System.Windows.Forms.ListBox addlistBox;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}