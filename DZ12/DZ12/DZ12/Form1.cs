using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DZ12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection(
			"Server=127.0.0.1;Database=test;User Id=myUsername;Password=myPassword;");

			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "INSERT INTO korisnik (ID, Username, Password) VALUES (1, 2, 3);";
			cmd.Connection = conn;
			conn.Open();

			try
			{
				int aff = cmd.ExecuteNonQuery();
				label4.Text = (aff + " rows were affected.");
			}
			catch
			{
				label4.Text = ("Error encountered during INSERT operation.");
			}
			finally
			{
				conn.Close();
			}
		}
	}
}