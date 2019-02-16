namespace WindowsFormsApp1
{
    partial class Suppliers
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.selectSuptextBox1 = new System.Windows.Forms.TextBox();
			this.producttextBox2 = new System.Windows.Forms.TextBox();
			this.partdesctextBox3 = new System.Windows.Forms.TextBox();
			this.internalPtextBox4 = new System.Windows.Forms.TextBox();
			this.catcomboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.detsrichTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.ordResptextBox1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ordQtytextBox1 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.dateReqtextBox1 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.custInfobutton = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.subCattextBox1 = new System.Windows.Forms.TextBox();
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
			this.ordButton.Location = new System.Drawing.Point(93, 12);
			this.ordButton.Name = "ordButton";
			this.ordButton.Size = new System.Drawing.Size(75, 23);
			this.ordButton.TabIndex = 2;
			this.ordButton.Text = "Orders";
			this.ordButton.UseVisualStyleBackColor = true;
			this.ordButton.Click += new System.EventHandler(this.ordButton_Click);
			// 
			// custButton
			// 
			this.custButton.Location = new System.Drawing.Point(174, 12);
			this.custButton.Name = "custButton";
			this.custButton.Size = new System.Drawing.Size(75, 23);
			this.custButton.TabIndex = 3;
			this.custButton.Text = "Customers";
			this.custButton.UseVisualStyleBackColor = true;
			this.custButton.Click += new System.EventHandler(this.custButton_Click);
			// 
			// supbutton4
			// 
			this.supbutton4.Location = new System.Drawing.Point(255, 12);
			this.supbutton4.Name = "supbutton4";
			this.supbutton4.Size = new System.Drawing.Size(75, 23);
			this.supbutton4.TabIndex = 4;
			this.supbutton4.Text = "Suppliers";
			this.supbutton4.UseVisualStyleBackColor = true;
			// 
			// repButton
			// 
			this.repButton.Location = new System.Drawing.Point(336, 12);
			this.repButton.Name = "repButton";
			this.repButton.Size = new System.Drawing.Size(75, 23);
			this.repButton.TabIndex = 5;
			this.repButton.Text = "Reports";
			this.repButton.UseVisualStyleBackColor = true;
			this.repButton.Click += new System.EventHandler(this.repButton_Click);
			// 
			// soButton
			// 
			this.soButton.Location = new System.Drawing.Point(426, 410);
			this.soButton.Name = "soButton";
			this.soButton.Size = new System.Drawing.Size(75, 23);
			this.soButton.TabIndex = 6;
			this.soButton.Text = "Sign Out";
			this.soButton.UseVisualStyleBackColor = true;
			this.soButton.Click += new System.EventHandler(this.soButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Select Supplier :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(68, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Item/Product :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Part Description :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(62, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Internal Part # :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(84, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Category :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(62, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Sub Category :";
			// 
			// selectSuptextBox1
			// 
			this.selectSuptextBox1.Location = new System.Drawing.Point(149, 66);
			this.selectSuptextBox1.Name = "selectSuptextBox1";
			this.selectSuptextBox1.Size = new System.Drawing.Size(100, 20);
			this.selectSuptextBox1.TabIndex = 13;
			// 
			// producttextBox2
			// 
			this.producttextBox2.Location = new System.Drawing.Point(149, 89);
			this.producttextBox2.Name = "producttextBox2";
			this.producttextBox2.Size = new System.Drawing.Size(100, 20);
			this.producttextBox2.TabIndex = 14;
			// 
			// partdesctextBox3
			// 
			this.partdesctextBox3.Location = new System.Drawing.Point(149, 111);
			this.partdesctextBox3.Name = "partdesctextBox3";
			this.partdesctextBox3.Size = new System.Drawing.Size(100, 20);
			this.partdesctextBox3.TabIndex = 15;
			// 
			// internalPtextBox4
			// 
			this.internalPtextBox4.Location = new System.Drawing.Point(149, 134);
			this.internalPtextBox4.Name = "internalPtextBox4";
			this.internalPtextBox4.Size = new System.Drawing.Size(100, 20);
			this.internalPtextBox4.TabIndex = 16;
			// 
			// catcomboBox1
			// 
			this.catcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.catcomboBox1.FormattingEnabled = true;
			this.catcomboBox1.Items.AddRange(new object[] {
            "Computer",
            "Phone",
            "Hardware",
            "Software",
            "Storage Devices",
            "RAM"});
			this.catcomboBox1.Location = new System.Drawing.Point(149, 163);
			this.catcomboBox1.Name = "catcomboBox1";
			this.catcomboBox1.Size = new System.Drawing.Size(121, 21);
			this.catcomboBox1.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(94, 242);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Details :";
			// 
			// detsrichTextBox1
			// 
			this.detsrichTextBox1.Location = new System.Drawing.Point(145, 239);
			this.detsrichTextBox1.Name = "detsrichTextBox1";
			this.detsrichTextBox1.Size = new System.Drawing.Size(152, 96);
			this.detsrichTextBox1.TabIndex = 20;
			this.detsrichTextBox1.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(33, 349);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(106, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "Order Responsibility :";
			// 
			// ordResptextBox1
			// 
			this.ordResptextBox1.Location = new System.Drawing.Point(149, 349);
			this.ordResptextBox1.Name = "ordResptextBox1";
			this.ordResptextBox1.Size = new System.Drawing.Size(100, 20);
			this.ordResptextBox1.TabIndex = 22;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(58, 387);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Order Quantity :";
			// 
			// ordQtytextBox1
			// 
			this.ordQtytextBox1.Location = new System.Drawing.Point(149, 380);
			this.ordQtytextBox1.Name = "ordQtytextBox1";
			this.ordQtytextBox1.Size = new System.Drawing.Size(100, 20);
			this.ordQtytextBox1.TabIndex = 24;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(269, 352);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 13);
			this.label10.TabIndex = 25;
			this.label10.Text = "Date Required :";
			// 
			// dateReqtextBox1
			// 
			this.dateReqtextBox1.Location = new System.Drawing.Point(357, 346);
			this.dateReqtextBox1.Name = "dateReqtextBox1";
			this.dateReqtextBox1.Size = new System.Drawing.Size(100, 20);
			this.dateReqtextBox1.TabIndex = 26;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(188, 415);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(98, 13);
			this.label11.TabIndex = 27;
			this.label11.Text = "Get Customer Info :";
			// 
			// custInfobutton
			// 
			this.custInfobutton.Location = new System.Drawing.Point(292, 410);
			this.custInfobutton.Name = "custInfobutton";
			this.custInfobutton.Size = new System.Drawing.Size(75, 23);
			this.custInfobutton.TabIndex = 28;
			this.custInfobutton.Text = "Info";
			this.custInfobutton.UseVisualStyleBackColor = true;
			this.custInfobutton.Click += new System.EventHandler(this.custInfobutton_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(33, 53);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 13);
			this.label12.TabIndex = 29;
			this.label12.Text = "Suppliers";
			// 
			// subCattextBox1
			// 
			this.subCattextBox1.Location = new System.Drawing.Point(149, 190);
			this.subCattextBox1.Name = "subCattextBox1";
			this.subCattextBox1.Size = new System.Drawing.Size(100, 20);
			this.subCattextBox1.TabIndex = 30;
			// 
			// Suppliers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 445);
			this.Controls.Add(this.subCattextBox1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.custInfobutton);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.dateReqtextBox1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.ordQtytextBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.ordResptextBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.detsrichTextBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.catcomboBox1);
			this.Controls.Add(this.internalPtextBox4);
			this.Controls.Add(this.partdesctextBox3);
			this.Controls.Add(this.producttextBox2);
			this.Controls.Add(this.selectSuptextBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.soButton);
			this.Controls.Add(this.repButton);
			this.Controls.Add(this.supbutton4);
			this.Controls.Add(this.custButton);
			this.Controls.Add(this.ordButton);
			this.Controls.Add(this.invButton);
			this.Name = "Suppliers";
			this.Text = " ";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox selectSuptextBox1;
        private System.Windows.Forms.TextBox producttextBox2;
        private System.Windows.Forms.TextBox partdesctextBox3;
        private System.Windows.Forms.TextBox internalPtextBox4;
        private System.Windows.Forms.ComboBox catcomboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox detsrichTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ordResptextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ordQtytextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dateReqtextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button custInfobutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox subCattextBox1;
    }
}