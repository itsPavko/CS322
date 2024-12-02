using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Automobil auto = new Automobil(120, 2000, "Crna", 2);
			label1.Text = auto.konjaza.ToString() + " " + auto.kubikaza.ToString() + " " + auto.boja + " " + auto.duzina.ToString();
		}

		interface Motor
		{
			int GetKonjaza();
			int GetKubikaza();
		}

		interface Eksterijer
		{
			string GetBoja();
			int GetDuzina();
		}

		public class Automobil : Motor, Eksterijer
		{
			public int konjaza;
			public int kubikaza;
			public string boja;
			public int duzina;

			public Automobil(int konjaza, int kubikaza, string boja, int duzina)
			{
				this.konjaza = konjaza;
				this.kubikaza = kubikaza;
				this.boja = boja;
				this.duzina = duzina;
			}

			public int GetKonjaza()
			{
				return this.konjaza;
			}

			public int GetKubikaza()
			{
				return this.kubikaza;
			}

			public string GetBoja()
			{
				return this.boja;
			}

			public int GetDuzina()
			{
				return this.duzina;
			}
		}
	}
}
