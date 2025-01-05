using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ10
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Random rnd = new Random();

			for (int j = 0; j < 100; j++)
			{
				int n = rnd.Next(1, 100);
				this.listBox1.Items.Add(n);
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();

			int n = rnd.Next(1, 100);
			this.listBox1.Items.Add(n);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int sel = this.listBox1.SelectedIndex;
			this.listBox1.Items.RemoveAt(sel);

		}
	}
}
