using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace WindowsFormsApp1
{

	public partial class Form1 : Form
	{

		public ListBox mylist = new ListBox();

		public Form1()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(56, 145);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Dodaj";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(43, 37);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(43, 89);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(43, 63);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(229, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "label1";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(43, 117);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(229, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(229, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 16);
			this.label3.TabIndex = 9;
			this.label3.Text = "label3";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(385, 339);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();


			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string num = textBox3.Text;
			if(num.Length == 13)
			{
				if (num[7] == '7' && num[8] == '3')
				{
					label1.Text = "Osoba jeste iz Nisa.";
				}
				else
				{
					label1.Text = "Osoba nije iz Nisa.";
				}
			}
			else
			{
				label1.Text = "Greska pri unosu JMBG";
			}

			string name = textBox1.Text;
			string[] nameArray = name.Split(' ');

			if (nameArray.Length > 1)
			{
				label2.Text = "Ime ima vise reci";
			}
			else
			{
				label2.Text = "Ime ima jednu rec";
			}

			string adresa = textBox4.Text;
			string[] adresaArray = adresa.Split(' ');

			if (adresaArray.Length > 1)
			{
				label3.Text = "Adresa ima vise reci";
			}
			else
			{
				label3.Text = "Adresa ima jednu rec";
			}


			
			mylist.Location = new Point(200, 125);
			mylist.Size = new Size(120, 95);
			mylist.BorderStyle = BorderStyle.Fixed3D;

			mylist.Items.Add(textBox1.Text + textBox2.Text + ", " + num + ", " + textBox4.Text);

			this.Controls.Add(mylist);
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
