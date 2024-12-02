using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool check = true;

			if (!int.TryParse(textBox1.Text, out int broj))
			{
				label3.Text = "Greska pri unosu broja";
				check = false;
			}

			if (!int.TryParse(textBox2.Text, out int stepen))
			{
				label3.Text = "Greska pri unosu stepena";
				check = false;
			}

			if (broj == 0)
			{
				label3.Text = "Greska pri unosu broja";
				check = false;
			}

			if (stepen < 0)
			{
				label3.Text = "Greska pri unosu stepena";
				check = false;
			}

			if (check)
			{
				double res = Math.Pow(broj, stepen);
				label3.Text = res.ToString();

			}
		}

		public int RandomBroj()
		{
			Random rnd = new Random();
			int n = rnd.Next(1, 201);
			return n;
		}

		public string RandomString()
		{
			Random rnd = new Random();
			int length = 8;
			const string chars = "abcdefghijklmnopqrstuvwxyz";
			string randomWord = new string(Enumerable.Repeat(chars, length).Select(s => s[rnd.Next(s.Length)]).ToArray());
			return char.ToUpper(randomWord[0]) + randomWord.Substring(1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Posetioc posetioc = new Posetioc();
			posetioc.name = RandomString();
			posetioc.surname = RandomString();
			posetioc.number = RandomBroj();

			label6.Text = posetioc.name + " " + posetioc.surname + ", " + posetioc.number;

		}

		public class Posetioc
		{
			public string name;
			public string surname;
			public int number;
		}
	}


}
