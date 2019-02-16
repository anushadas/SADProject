namespace WindowsFormsApp1
{
    partial class Inventory
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
			this.soButton = new System.Windows.Forms.Button();
			this.addGroupBox = new System.Windows.Forms.GroupBox();
			this.addInvbutton1 = new System.Windows.Forms.Button();
			this.commentstextBox1 = new System.Windows.Forms.TextBox();
			this.itNametextBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.itemnamelabel = new System.Windows.Forms.Label();
			this.holdtextBox4 = new System.Windows.Forms.TextBox();
			this.addtextBox3 = new System.Windows.Forms.TextBox();
			this.pricetextBox2 = new System.Windows.Forms.TextBox();
			this.itntextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.priceLabel = new System.Windows.Forms.Label();
			this.itnLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.psButton = new System.Windows.Forms.Button();
			this.shpButton = new System.Windows.Forms.Button();
			this.stockButton = new System.Windows.Forms.Button();
			this.addGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// invButton
			// 
			this.invButton.Location = new System.Drawing.Point(12, 12);
			this.invButton.Name = "invButton";
			this.invButton.Size = new System.Drawing.Size(75, 23);
			this.invButton.TabIndex = 1;
			this.invButton.Text = "Inventory";
			this.invButton.UseVisualStyleBackColor = true;
			this.invButton.Click += new System.EventHandler(this.invButton_Click);
			// 
			// ordButton
			// 
			this.ordButton.Location = new System.Drawing.Point(102, 12);
			this.ordButton.Name = "ordButton";
			this.ordButton.Size = new System.Drawing.Size(75, 23);
			this.ordButton.TabIndex = 2;
			this.ordButton.Text = "Orders";
			this.ordButton.UseVisualStyleBackColor = true;
			this.ordButton.Click += new System.EventHandler(this.ordButton_Click);
			// 
			// custButton
			// 
			this.custButton.Location = new System.Drawing.Point(197, 12);
			this.custButton.Name = "custButton";
			this.custButton.Size = new System.Drawing.Size(75, 23);
			this.custButton.TabIndex = 3;
			this.custButton.Text = "Customers";
			this.custButton.UseVisualStyleBackColor = true;
			this.custButton.Click += new System.EventHandler(this.custButton_Click);
			// 
			// supButton
			// 
			this.supButton.Location = new System.Drawing.Point(288, 12);
			this.supButton.Name = "supButton";
			this.supButton.Size = new System.Drawing.Size(75, 23);
			this.supButton.TabIndex = 4;
			this.supButton.Text = "Suppliers";
			this.supButton.UseVisualStyleBackColor = true;
			this.supButton.Click += new System.EventHandler(this.supButton_Click);
			// 
			// repButton
			// 
			this.repButton.Location = new System.Drawing.Point(383, 12);
			this.repButton.Name = "repButton";
			this.repButton.Size = new System.Drawing.Size(75, 23);
			this.repButton.TabIndex = 5;
			this.repButton.Text = "Reports";
			this.repButton.UseVisualStyleBackColor = true;
			this.repButton.Click += new System.EventHandler(this.repButton_Click);
			// 
			// soButton
			// 
			this.soButton.Location = new System.Drawing.Point(418, 522);
			this.soButton.Name = "soButton";
			this.soButton.Size = new System.Drawing.Size(75, 23);
			this.soButton.TabIndex = 6;
			this.soButton.Text = "Sign Out";
			this.soButton.UseVisualStyleBackColor = true;
			this.soButton.Click += new System.EventHandler(this.soButton_Click);
			// 
			// addGroupBox
			// 
			this.addGroupBox.BackColor = System.Drawing.SystemColors.Control;
			this.addGroupBox.Controls.Add(this.addInvbutton1);
			this.addGroupBox.Controls.Add(this.commentstextBox1);
			this.addGroupBox.Controls.Add(this.itNametextBox1);
			this.addGroupBox.Controls.Add(this.label1);
			this.addGroupBox.Controls.Add(this.itemnamelabel);
			this.addGroupBox.Controls.Add(this.holdtextBox4);
			this.addGroupBox.Controls.Add(this.addtextBox3);
			this.addGroupBox.Controls.Add(this.pricetextBox2);
			this.addGroupBox.Controls.Add(this.itntextBox);
			this.addGroupBox.Controls.Add(this.label4);
			this.addGroupBox.Controls.Add(this.label3);
			this.addGroupBox.Controls.Add(this.priceLabel);
			this.addGroupBox.Controls.Add(this.itnLabel);
			this.addGroupBox.Location = new System.Drawing.Point(57, 85);
			this.addGroupBox.Name = "addGroupBox";
			this.addGroupBox.Size = new System.Drawing.Size(401, 210);
			this.addGroupBox.TabIndex = 7;
			this.addGroupBox.TabStop = false;
			this.addGroupBox.Text = "Add to Inventory :";
			// 
			// addInvbutton1
			// 
			this.addInvbutton1.Location = new System.Drawing.Point(309, 175);
			this.addInvbutton1.Name = "addInvbutton1";
			this.addInvbutton1.Size = new System.Drawing.Size(75, 23);
			this.addInvbutton1.TabIndex = 12;
			this.addInvbutton1.Text = "Add";
			this.addInvbutton1.UseVisualStyleBackColor = true;
			this.addInvbutton1.Click += new System.EventHandler(this.addInvbutton1_Click);
			// 
			// commentstextBox1
			// 
			this.commentstextBox1.Location = new System.Drawing.Point(109, 130);
			this.commentstextBox1.Name = "commentstextBox1";
			this.commentstextBox1.Size = new System.Drawing.Size(183, 20);
			this.commentstextBox1.TabIndex = 11;
			this.commentstextBox1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
			// 
			// itNametextBox1
			// 
			this.itNametextBox1.Location = new System.Drawing.Point(109, 96);
			this.itNametextBox1.Name = "itNametextBox1";
			this.itNametextBox1.Size = new System.Drawing.Size(100, 20);
			this.itNametextBox1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Comments :";
			// 
			// itemnamelabel
			// 
			this.itemnamelabel.AutoSize = true;
			this.itemnamelabel.Location = new System.Drawing.Point(39, 99);
			this.itemnamelabel.Name = "itemnamelabel";
			this.itemnamelabel.Size = new System.Drawing.Size(64, 13);
			this.itemnamelabel.TabIndex = 8;
			this.itemnamelabel.Text = "Item Name :";
			// 
			// holdtextBox4
			// 
			this.holdtextBox4.Location = new System.Drawing.Point(259, 63);
			this.holdtextBox4.Name = "holdtextBox4";
			this.holdtextBox4.Size = new System.Drawing.Size(100, 20);
			this.holdtextBox4.TabIndex = 7;
			// 
			// addtextBox3
			// 
			this.addtextBox3.Location = new System.Drawing.Point(256, 37);
			this.addtextBox3.Name = "addtextBox3";
			this.addtextBox3.Size = new System.Drawing.Size(100, 20);
			this.addtextBox3.TabIndex = 6;
			this.addtextBox3.TextChanged += new System.EventHandler(this.addtextBox3_TextChanged);
			// 
			// pricetextBox2
			// 
			this.pricetextBox2.Location = new System.Drawing.Point(82, 59);
			this.pricetextBox2.Name = "pricetextBox2";
			this.pricetextBox2.Size = new System.Drawing.Size(100, 20);
			this.pricetextBox2.TabIndex = 5;
			// 
			// itntextBox
			// 
			this.itntextBox.Location = new System.Drawing.Point(82, 37);
			this.itntextBox.Name = "itntextBox";
			this.itntextBox.Size = new System.Drawing.Size(100, 20);
			this.itntextBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(218, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hold :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(218, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Add :";
			// 
			// priceLabel
			// 
			this.priceLabel.AutoSize = true;
			this.priceLabel.Location = new System.Drawing.Point(39, 62);
			this.priceLabel.Name = "priceLabel";
			this.priceLabel.Size = new System.Drawing.Size(37, 13);
			this.priceLabel.TabIndex = 1;
			this.priceLabel.Text = "Price :";
			// 
			// itnLabel
			// 
			this.itnLabel.AutoSize = true;
			this.itnLabel.Location = new System.Drawing.Point(26, 37);
			this.itnLabel.Name = "itnLabel";
			this.itnLabel.Size = new System.Drawing.Size(50, 13);
			this.itnLabel.TabIndex = 0;
			this.itnLabel.Text = "Item No :";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.psButton);
			this.groupBox1.Controls.Add(this.shpButton);
			this.groupBox1.Controls.Add(this.stockButton);
			this.groupBox1.Location = new System.Drawing.Point(57, 340);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 120);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inventory";
			// 
			// psButton
			// 
			this.psButton.Location = new System.Drawing.Point(42, 78);
			this.psButton.Name = "psButton";
			this.psButton.Size = new System.Drawing.Size(75, 23);
			this.psButton.TabIndex = 2;
			this.psButton.Text = "Packing Slips";
			this.psButton.UseVisualStyleBackColor = true;
			// 
			// shpButton
			// 
			this.shpButton.Location = new System.Drawing.Point(42, 49);
			this.shpButton.Name = "shpButton";
			this.shpButton.Size = new System.Drawing.Size(75, 23);
			this.shpButton.TabIndex = 1;
			this.shpButton.Text = "Shipping";
			this.shpButton.UseVisualStyleBackColor = true;
			// 
			// stockButton
			// 
			this.stockButton.Location = new System.Drawing.Point(42, 20);
			this.stockButton.Name = "stockButton";
			this.stockButton.Size = new System.Drawing.Size(75, 23);
			this.stockButton.TabIndex = 0;
			this.stockButton.Text = "In stock";
			this.stockButton.UseVisualStyleBackColor = true;
			// 
			// Inventory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 557);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.addGroupBox);
			this.Controls.Add(this.soButton);
			this.Controls.Add(this.repButton);
			this.Controls.Add(this.supButton);
			this.Controls.Add(this.custButton);
			this.Controls.Add(this.ordButton);
			this.Controls.Add(this.invButton);
			this.Name = "Inventory";
			this.Text = "Inventory";
			this.addGroupBox.ResumeLayout(false);
			this.addGroupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.Button ordButton;
        private System.Windows.Forms.Button custButton;
        private System.Windows.Forms.Button supButton;
        private System.Windows.Forms.Button repButton;
        private System.Windows.Forms.Button soButton;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.TextBox commentstextBox1;
        private System.Windows.Forms.TextBox itNametextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label itemnamelabel;
        private System.Windows.Forms.TextBox holdtextBox4;
        private System.Windows.Forms.TextBox addtextBox3;
        private System.Windows.Forms.TextBox pricetextBox2;
        private System.Windows.Forms.TextBox itntextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label itnLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button psButton;
        private System.Windows.Forms.Button shpButton;
        private System.Windows.Forms.Button stockButton;
		private System.Windows.Forms.Button addInvbutton1;
	}
}