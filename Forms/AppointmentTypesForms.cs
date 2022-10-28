using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project_C969.Forms
{
	public partial class AppointmentTypesForms : Form
	{
		public AppointmentTypesForms()
		{
			InitializeComponent();

		}
		private void AppointmentTypesForms_Load(object sender, EventArgs e)
		{
			appointmentBox.DisplayMember = "type";
			appointmentBox.DataSource = TypeHelper();
			reportButton.Enabled = false;
			monthTxtBox.Clear();
		}
		// method to return type by month
		private List<string> AppointmentsByType(string type, int month)
		{
			string select = "SELECT type FROM appointment WHERE type = @type AND MONTH(start) = @month";
			MySqlConnection connect = new MySqlConnection(SQL.C_String);

			MySqlCommand cmd = new MySqlCommand(select, connect);

			cmd.Parameters.AddWithValue("@type", type);
			cmd.Parameters.AddWithValue("@month", month);

			MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

			connect.Open();
			MySqlDataReader reader = cmd.ExecuteReader();
			List<string> list = new List<string>();
			while (reader.Read())
			{
				list.Add(reader[0].ToString());
				String.Join(" ", list);
			}

			return list;
		}


		private int typeCounter(List<string> list, string type)
		{
			int j = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Contains(type))
				{

					j++;

				}
			}
			// return the number of instances of the type
			return j;
		}

		private void reportButton_Click(object sender, EventArgs e)
		{
			//List<string> s = AppointmentsByType("test", 10);
			//reportText.Text = String.Join(Environment.NewLine, s);
			//int counter;
			//counter = typeCounter(s, "test");
			//reportText.Text = "Test meetings in October: " + " " + counter.ToString();


			List<string> s = AppointmentsByType(appointmentBox.Text, Int32.Parse(monthTxtBox.Text));
			string t = getType(appointmentBox.Text);
			int counter = typeCounter(s, t);


			reportText.Text = $"{t} meetings for this month: " + " " + counter.ToString();


		}

		private string getType(string type)
		{
			string value;
			MySqlConnection connect = new MySqlConnection(SQL.C_String);
			try
			{

				string select = "SELECT type FROM appointment WHERE type = @type";
				MySqlCommand cmd = new MySqlCommand(select, connect);
				cmd.Parameters.AddWithValue("@type", type);
				connect.Open();
				value = (string)cmd.ExecuteScalar();
			}
			catch (Exception)
			{

				throw;
			}
			return value;
		}

		private DataTable TypeHelper()
		{
			string select = "SELECT DISTINCT type FROM appointment";

			MySqlConnection c = new MySqlConnection(SQL.C_String);

			DataTable dt = new DataTable();

			try
			{
				c.Open();
				MySqlCommand cmd = new MySqlCommand(select, c);
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				da.Fill(dt);

			}
			catch (Exception)
			{

				throw;
			}
			return dt;
		}

		private bool ValidateTxtBox()
		{
			return !String.IsNullOrWhiteSpace(monthTxtBox.Text)
				&&
			Int32.TryParse(monthTxtBox.Text, out int a);
		}

		private void monthTxtBox_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(monthTxtBox.Text) || !Int32.TryParse(monthTxtBox.Text, out int a)
				|| Int32.Parse(monthTxtBox.Text) < 0 || Int32.Parse(monthTxtBox.Text) > 12
				)
			{

				monthTxtBox.Focus();
				monthTxtBox.Clear();
				MessageBox.Show("Please Enter a Number 1-12 (corresponding to the months of the year)");
				
			}
			else
			{
				reportButton.Enabled = ValidateTxtBox();
			}
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d = new Dashboard();
			d.Show();
		}
	}
}
