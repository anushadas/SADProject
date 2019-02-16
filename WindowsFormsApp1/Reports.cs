using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Reports : Form
    {
        Form1 f1 = new Form1();
        public Reports()
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
            Inventory in1= new Inventory();
            in1.ShowDialog();
        }

        private void custButton_Click(object sender, EventArgs e)
        {
            Customers cs = new Customers();
            cs.ShowDialog();
        }

        private void ordButton_Click(object sender, EventArgs e)
        {
            Orders od = new Orders();
            od.ShowDialog();
        }

        private void supbutton4_Click(object sender, EventArgs e)
        {
            Suppliers s1 = new Suppliers();
            s1.ShowDialog();
        }

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem.Equals("Inventory Report"))
			{
				InvtRep invt1 = new InvtRep();
				invt1.ShowDialog();
			}
			else if (listBox1.SelectedItem.Equals("Sales Report"))
			{
				SalesRep s1 = new SalesRep();
				s1.ShowDialog();
			}
			else if (listBox1.SelectedItem.Equals("Expense Report"))
			{
				ExpRep ex1 = new ExpRep();
				ex1.ShowDialog();
			}
			else if (listBox1.SelectedItem.Equals("Invoice"))
			{
				Invoice in1 = new Invoice();
				in1.ShowDialog();
			}
			else if (listBox1.SelectedItem.Equals("Packing Slips"))
			{
				PackingSlip ps = new PackingSlip();
				ps.ShowDialog();
			}
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			groupBox1.Visible = true;
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
