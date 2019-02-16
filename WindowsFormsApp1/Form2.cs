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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void soButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.unTextBox.Text= "";
            f1.pwTextBox.Text= "";
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

		private void ivcButton_Click(object sender, EventArgs e)
		{
			Invoice in1 = new Invoice();
			in1.ShowDialog();
		}
	}
}
