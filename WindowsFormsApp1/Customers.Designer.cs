namespace WindowsFormsApp1
{
    partial class Customers
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.addCustbutton1 = new System.Windows.Forms.Button();
			this.cmpnytextBox1 = new System.Windows.Forms.TextBox();
			this.ad2textBox1 = new System.Windows.Forms.TextBox();
			this.ad1textBox = new System.Windows.Forms.TextBox();
			this.ordNonotextBox1 = new System.Windows.Forms.TextBox();
			this.phnotextBox1 = new System.Windows.Forms.TextBox();
			this.emtextBox1 = new System.Windows.Forms.TextBox();
			this.lntextBox1 = new System.Windows.Forms.TextBox();
			this.fntextBox = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.label12 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.label11 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.custNamelistBox = new System.Windows.Forms.ListBox();
			this.ordNolistBox2 = new System.Windows.Forms.ListBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.ordInfobutton = new System.Windows.Forms.Button();
			this.Invoicebutton2 = new System.Windows.Forms.Button();
			this.custInfobutton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.ordButton.Location = new System.Drawing.Point(103, 12);
			this.ordButton.Name = "ordButton";
			this.ordButton.Size = new System.Drawing.Size(75, 23);
			this.ordButton.TabIndex = 1;
			this.ordButton.Text = "Orders";
			this.ordButton.UseVisualStyleBackColor = true;
			this.ordButton.Click += new System.EventHandler(this.ordButton_Click);
			// 
			// custButton
			// 
			this.custButton.Location = new System.Drawing.Point(184, 12);
			this.custButton.Name = "custButton";
			this.custButton.Size = new System.Drawing.Size(75, 23);
			this.custButton.TabIndex = 2;
			this.custButton.Text = "Customers";
			this.custButton.UseVisualStyleBackColor = true;
			// 
			// supbutton4
			// 
			this.supbutton4.Location = new System.Drawing.Point(265, 12);
			this.supbutton4.Name = "supbutton4";
			this.supbutton4.Size = new System.Drawing.Size(75, 23);
			this.supbutton4.TabIndex = 3;
			this.supbutton4.Text = "Suppliers";
			this.supbutton4.UseVisualStyleBackColor = true;
			this.supbutton4.Click += new System.EventHandler(this.supbutton4_Click);
			// 
			// repButton
			// 
			this.repButton.Location = new System.Drawing.Point(346, 12);
			this.repButton.Name = "repButton";
			this.repButton.Size = new System.Drawing.Size(75, 23);
			this.repButton.TabIndex = 4;
			this.repButton.Text = "Reports";
			this.repButton.UseVisualStyleBackColor = true;
			this.repButton.Click += new System.EventHandler(this.repButton_Click);
			// 
			// soButton
			// 
			this.soButton.Location = new System.Drawing.Point(449, 571);
			this.soButton.Name = "soButton";
			this.soButton.Size = new System.Drawing.Size(75, 23);
			this.soButton.TabIndex = 5;
			this.soButton.Text = "Sign Out";
			this.soButton.UseVisualStyleBackColor = true;
			this.soButton.Click += new System.EventHandler(this.soButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.addCustbutton1);
			this.groupBox1.Controls.Add(this.cmpnytextBox1);
			this.groupBox1.Controls.Add(this.ad2textBox1);
			this.groupBox1.Controls.Add(this.ad1textBox);
			this.groupBox1.Controls.Add(this.ordNonotextBox1);
			this.groupBox1.Controls.Add(this.phnotextBox1);
			this.groupBox1.Controls.Add(this.emtextBox1);
			this.groupBox1.Controls.Add(this.lntextBox1);
			this.groupBox1.Controls.Add(this.fntextBox);
			this.groupBox1.Controls.Add(this.panel4);
			this.groupBox1.Controls.Add(this.panel3);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(53, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(406, 299);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Customer";
			// 
			// addCustbutton1
			// 
			this.addCustbutton1.Location = new System.Drawing.Point(293, 270);
			this.addCustbutton1.Name = "addCustbutton1";
			this.addCustbutton1.Size = new System.Drawing.Size(89, 23);
			this.addCustbutton1.TabIndex = 31;
			this.addCustbutton1.Text = "Add Customer";
			this.addCustbutton1.UseVisualStyleBackColor = true;
			this.addCustbutton1.Click += new System.EventHandler(this.addCustbutton1_Click);
			// 
			// cmpnytextBox1
			// 
			this.cmpnytextBox1.Location = new System.Drawing.Point(284, 237);
			this.cmpnytextBox1.Name = "cmpnytextBox1";
			this.cmpnytextBox1.Size = new System.Drawing.Size(98, 20);
			this.cmpnytextBox1.TabIndex = 30;
			// 
			// ad2textBox1
			// 
			this.ad2textBox1.Location = new System.Drawing.Point(116, 130);
			this.ad2textBox1.Name = "ad2textBox1";
			this.ad2textBox1.Size = new System.Drawing.Size(139, 20);
			this.ad2textBox1.TabIndex = 29;
			this.ad2textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// ad1textBox
			// 
			this.ad1textBox.Location = new System.Drawing.Point(116, 108);
			this.ad1textBox.Name = "ad1textBox";
			this.ad1textBox.Size = new System.Drawing.Size(139, 20);
			this.ad1textBox.TabIndex = 28;
			// 
			// ordNonotextBox1
			// 
			this.ordNonotextBox1.Location = new System.Drawing.Point(279, 90);
			this.ordNonotextBox1.Name = "ordNonotextBox1";
			this.ordNonotextBox1.Size = new System.Drawing.Size(77, 20);
			this.ordNonotextBox1.TabIndex = 27;
			// 
			// phnotextBox1
			// 
			this.phnotextBox1.Location = new System.Drawing.Point(279, 64);
			this.phnotextBox1.Name = "phnotextBox1";
			this.phnotextBox1.Size = new System.Drawing.Size(77, 20);
			this.phnotextBox1.TabIndex = 26;
			// 
			// emtextBox1
			// 
			this.emtextBox1.Location = new System.Drawing.Point(116, 64);
			this.emtextBox1.Name = "emtextBox1";
			this.emtextBox1.Size = new System.Drawing.Size(77, 20);
			this.emtextBox1.TabIndex = 25;
			// 
			// lntextBox1
			// 
			this.lntextBox1.Location = new System.Drawing.Point(279, 36);
			this.lntextBox1.Name = "lntextBox1";
			this.lntextBox1.Size = new System.Drawing.Size(77, 20);
			this.lntextBox1.TabIndex = 24;
			// 
			// fntextBox
			// 
			this.fntextBox.Location = new System.Drawing.Point(116, 33);
			this.fntextBox.Name = "fntextBox";
			this.fntextBox.Size = new System.Drawing.Size(77, 20);
			this.fntextBox.TabIndex = 23;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.radioButton2);
			this.panel4.Controls.Add(this.radioButton1);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Location = new System.Drawing.Point(217, 156);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(176, 37);
			this.panel4.TabIndex = 22;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(132, 5);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(33, 17);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "N";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(93, 5);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(32, 17);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Y";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 5);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "New Member :";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.radioButton8);
			this.panel3.Controls.Add(this.radioButton5);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Location = new System.Drawing.Point(27, 231);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(156, 36);
			this.panel3.TabIndex = 21;
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Location = new System.Drawing.Point(111, 8);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(33, 17);
			this.radioButton8.TabIndex = 18;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "N";
			this.radioButton8.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(73, 6);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(32, 17);
			this.radioButton5.TabIndex = 15;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Y";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(10, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(57, 13);
			this.label12.TabIndex = 12;
			this.label12.Text = "Customer :";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.radioButton7);
			this.panel2.Controls.Add(this.radioButton4);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Location = new System.Drawing.Point(35, 205);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(164, 26);
			this.panel2.TabIndex = 20;
			// 
			// radioButton7
			// 
			this.radioButton7.AutoSize = true;
			this.radioButton7.Location = new System.Drawing.Point(103, 4);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(33, 17);
			this.radioButton7.TabIndex = 17;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "N";
			this.radioButton7.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(65, 4);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(32, 17);
			this.radioButton4.TabIndex = 14;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Y";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(4, 4);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(55, 13);
			this.label11.TabIndex = 11;
			this.label11.Text = "Business :";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton6);
			this.panel1.Controls.Add(this.radioButton3);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Location = new System.Drawing.Point(30, 176);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(170, 27);
			this.panel1.TabIndex = 19;
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(108, 3);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(33, 17);
			this.radioButton6.TabIndex = 16;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "N";
			this.radioButton6.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(70, 3);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(32, 17);
			this.radioButton3.TabIndex = 13;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Y";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(2, 5);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "Corporation :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(254, 221);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 13);
			this.label9.TabIndex = 7;
			this.label9.Text = "Company Name :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(27, 136);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Address Line 2 :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 108);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Address Line 1 :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(217, 93);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Order No :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(230, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ph No :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(72, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(209, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name :";
			// 
			// custNamelistBox
			// 
			this.custNamelistBox.FormattingEnabled = true;
			this.custNamelistBox.Location = new System.Drawing.Point(95, 391);
			this.custNamelistBox.Name = "custNamelistBox";
			this.custNamelistBox.Size = new System.Drawing.Size(120, 173);
			this.custNamelistBox.TabIndex = 7;
			// 
			// ordNolistBox2
			// 
			this.ordNolistBox2.FormattingEnabled = true;
			this.ordNolistBox2.Location = new System.Drawing.Point(221, 391);
			this.ordNolistBox2.Name = "ordNolistBox2";
			this.ordNolistBox2.Size = new System.Drawing.Size(120, 173);
			this.ordNolistBox2.TabIndex = 8;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(121, 372);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(51, 13);
			this.label13.TabIndex = 9;
			this.label13.Text = "Customer";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(257, 372);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(50, 13);
			this.label14.TabIndex = 10;
			this.label14.Text = "Order No";
			// 
			// ordInfobutton
			// 
			this.ordInfobutton.Location = new System.Drawing.Point(384, 411);
			this.ordInfobutton.Name = "ordInfobutton";
			this.ordInfobutton.Size = new System.Drawing.Size(75, 23);
			this.ordInfobutton.TabIndex = 11;
			this.ordInfobutton.Text = "Order Info";
			this.ordInfobutton.UseVisualStyleBackColor = true;
			// 
			// Invoicebutton2
			// 
			this.Invoicebutton2.Location = new System.Drawing.Point(384, 440);
			this.Invoicebutton2.Name = "Invoicebutton2";
			this.Invoicebutton2.Size = new System.Drawing.Size(75, 23);
			this.Invoicebutton2.TabIndex = 12;
			this.Invoicebutton2.Text = "Invoice";
			this.Invoicebutton2.UseVisualStyleBackColor = true;
			this.Invoicebutton2.Click += new System.EventHandler(this.Invoicebutton2_Click);
			// 
			// custInfobutton
			// 
			this.custInfobutton.Location = new System.Drawing.Point(384, 469);
			this.custInfobutton.Name = "custInfobutton";
			this.custInfobutton.Size = new System.Drawing.Size(75, 36);
			this.custInfobutton.TabIndex = 13;
			this.custInfobutton.Text = "Customer Info";
			this.custInfobutton.UseVisualStyleBackColor = true;
			// 
			// Customers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 606);
			this.Controls.Add(this.custInfobutton);
			this.Controls.Add(this.Invoicebutton2);
			this.Controls.Add(this.ordInfobutton);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.ordNolistBox2);
			this.Controls.Add(this.custNamelistBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.soButton);
			this.Controls.Add(this.repButton);
			this.Controls.Add(this.supbutton4);
			this.Controls.Add(this.custButton);
			this.Controls.Add(this.ordButton);
			this.Controls.Add(this.invButton);
			this.Name = "Customers";
			this.Text = "Customers";
			this.Load += new System.EventHandler(this.Customers_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ad2textBox1;
        private System.Windows.Forms.TextBox ad1textBox;
        private System.Windows.Forms.TextBox ordNonotextBox1;
        private System.Windows.Forms.TextBox phnotextBox1;
        private System.Windows.Forms.TextBox emtextBox1;
        private System.Windows.Forms.TextBox lntextBox1;
        private System.Windows.Forms.TextBox fntextBox;
        private System.Windows.Forms.TextBox cmpnytextBox1;
        private System.Windows.Forms.ListBox custNamelistBox;
        private System.Windows.Forms.ListBox ordNolistBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ordInfobutton;
        private System.Windows.Forms.Button Invoicebutton2;
        private System.Windows.Forms.Button custInfobutton;
        private System.Windows.Forms.Button addCustbutton1;
    }
}