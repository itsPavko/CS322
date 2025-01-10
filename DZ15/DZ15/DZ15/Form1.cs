using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ15
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			float iznos;
			float kamata;
			try
			{
				iznos = float.Parse(textBox1.Text);
				
			}
			catch (FormatException)
			{
				MessageBox.Show("Iznos nije broj", "Greska pri unosu iznosa",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				kamata = float.Parse(textBox2.Text);

			}
			catch (FormatException)
			{
				MessageBox.Show("Kamata nije broj", "Greska pri unosu kamate",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			float novIznos = iznos * ((100 + kamata)/100);
			MessageBox.Show(novIznos.ToString(), "Resenje",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
