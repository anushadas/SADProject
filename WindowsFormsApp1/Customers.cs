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
    public partial class Customers : Form
    {
        Form1 f1 = new Form1();
        public Customers()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

		private void addCustbutton1_Click(object sender, EventArgs e)
		{
			try
			{
				StreamWriter opFile = new StreamWriter("Customers.txt",true);
				opFile.WriteLine(fntextBox.Text + " " + lntextBox1.Text + "," + ordNonotextBox1.Text);
				opFile.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			loadCust();
		}

		private void Customers_Load(object sender, EventArgs e)
		{
			loadCust();
		}
		public void loadCust() 
		{
			custNamelistBox.Items.Clear();
			ordNolistBox2.Items.Clear();
			try
			{
				StreamReader ipFile = new StreamReader("Customers.txt");
				String[] col=new String[2]; String eachLine = "";
				while (((eachLine = ipFile.ReadLine()) != null)&&col.Length!=0)
				{
					col = eachLine.Split(',');
					custNamelistBox.Items.Add(col[0]);
					ordNolistBox2.Items.Add(col[1]);
				}
				ipFile.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Invoicebutton2_Click(object sender, EventArgs e)
		{
			Invoice in1 = new Invoice();
			in1.ShowDialog();
		}
	}
}
