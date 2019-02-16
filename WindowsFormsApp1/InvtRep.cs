using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
	public partial class InvtRep : Form
	{
		Form1 f1 = new Form1();
		public InvtRep()
		{
			InitializeComponent();
		}

		private void soButton_Click(object sender, EventArgs e)
		{
			f1.unTextBox.Text = "";
			f1.pwTextBox.Text = "";
			f1.ShowDialog();
		}

		private void invButton_Click(object sender, EventArgs e)
		{
			Inventory in1 = new Inventory();
			in1.ShowDialog();
		}

		private void ordButton_Click(object sender, EventArgs e)
		{
			Orders od = new Orders();
			od.ShowDialog();
		}

		private void custButton_Click(object sender, EventArgs e)
		{
			Customers cs = new Customers();
			cs.ShowDialog();
		}

		private void supbutton4_Click(object sender, EventArgs e)
		{
			Suppliers s1 = new Suppliers();
			s1.ShowDialog();
		}

		private void repButton_Click(object sender, EventArgs e)
		{
			Reports r1 = new Reports();
			r1.ShowDialog();
		}

		private void InvtRep_Load(object sender, EventArgs e)
		{
			int qty = 0, price = 0;
			try
			{
				StreamReader ipFile = new StreamReader("Inventory.txt");
				String eachLine = "";
				String[] col = new String[4];
				while ((eachLine = ipFile.ReadLine()) != null&&col.Length!=0)
				{
					col = eachLine.Split(',');
					richTextBox1.Text += "\n"+col[0]+"\t\t"+col[1]+"\t"+col[2]+"\t"+col[3];
					qty += Int32.Parse(col[1]);
					price += Int32.Parse(col[3]);
				}
				ipFile.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			totqtytextBox.Text = qty.ToString();
			totInvtextBox3.Text ="$"+ price.ToString();
		}
	}
}
