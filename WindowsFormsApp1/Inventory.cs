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
    public partial class Inventory : Form
    {
        Form1 f1 = new Form1();
        public Inventory()
        {
            InitializeComponent();
        }

        private void soButton_Click(object sender, EventArgs e)
        {
            f1.unTextBox.Text = "";
            f1.pwTextBox.Text = "";
            f1.ShowDialog();
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

        private void invButton_Click(object sender, EventArgs e)
        {
           
        }

        private void supButton_Click(object sender, EventArgs e)
        {
            Suppliers s1 = new Suppliers();
            s1.ShowDialog();
        }

        private void repButton_Click(object sender, EventArgs e)
        {
            Reports r1 = new Reports();
            r1.ShowDialog();
        }

		private void addInvbutton1_Click(object sender, EventArgs e)
		{
			try
			{
				StreamWriter opFile = new StreamWriter("Inventory.txt",true);
				opFile.WriteLine(itntextBox.Text + "," + addtextBox3.Text + "," + holdtextBox4.Text + "," + pricetextBox2.Text);
				opFile.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			MessageBox.Show("Inventory was added");
		}

		private void addtextBox3_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(addtextBox3.Text, out int qty))
			{
				pricetextBox2.Text = (qty * 100).ToString();
			}

		}
	}
}
