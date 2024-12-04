using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
				conn.Open();
				string checkuser = "select count(*) from RegisterDataBase where StudentName='" + TextBox1.Text + "'";
				SqlCommand cmd = new SqlCommand(checkuser, conn);
				int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

				if (temp == 1)
				{
					Response.Write("Student Already Exist");
				}

				conn.Close();
			}

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			try
			{

				SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
				conn.Open();
				string insertQuery = "insert into Database1(Index,fName,lName)values (@name,@lname,@id)";
				SqlCommand cmd = new SqlCommand(insertQuery, conn);
				cmd.Parameters.AddWithValue("@name", TextBox1.Text);
				cmd.Parameters.AddWithValue("@lname", TextBox2.Text);
				cmd.Parameters.AddWithValue("@id", TextBox3.Text);
				cmd.ExecuteNonQuery();


				conn.Close();

			}
			catch (Exception ex)
			{
				Response.Write("error" + ex.ToString());
			}
		}
	}
}