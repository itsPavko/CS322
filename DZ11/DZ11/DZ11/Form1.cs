using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ11
{

	public class Kurs : IComparable<Kurs>
	{
		public string imeKursa {get; set;}
		public int fondCasova {get; set;}
		public int maksimalnoPrijava {get; set;}

		public Kurs (string imeKursa, int fondCasova, int maksimalnoPrijava)
		{
			this.imeKursa = imeKursa;
			this.fondCasova = fondCasova;
			this.maksimalnoPrijava = maksimalnoPrijava;
		}

		public int CompareTo(Kurs otherKurs)
		{
			int returnVal;

			if (this.maksimalnoPrijava > otherKurs.maksimalnoPrijava)
				returnVal = 1;
			else
				if (this.maksimalnoPrijava < otherKurs.maksimalnoPrijava)
				returnVal = -1;
			else
				returnVal = 0;

			return returnVal;
		}
	}

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<Kurs> kursevi = new List<Kurs>();

			Kurs k3 = new Kurs("PhotoShop", 10, 50);
			Kurs k1 = new Kurs("Programiranje", 10, 3);
			Kurs k2 = new Kurs("Excel", 5, 10);
			

			kursevi.Add(k1);
			kursevi.Add(k2);
			kursevi.Add(k3);

			kursevi.Sort();

			listBox1.Items.Add(kursevi[0].imeKursa + ". Broj prijava: " + kursevi[0].maksimalnoPrijava);
			listBox1.Items.Add(kursevi[1].imeKursa + ". Broj prijava: " + kursevi[1].maksimalnoPrijava);
			listBox1.Items.Add(kursevi[2].imeKursa + ". Broj prijava: " + kursevi[2].maksimalnoPrijava);

		}
	}
}
