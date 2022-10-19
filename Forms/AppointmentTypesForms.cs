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


		private string joinList(List<string> list)
		{
			return String.Join(" ", list);
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
			List<string> s = AppointmentsByType("test", 10);
			reportText.Text = String.Join(Environment.NewLine, s);
			int counter;
			counter = typeCounter(s, "test");
			reportText.Text = counter.ToString();
			
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

		private void AppointmentTypesForms_Load(object sender, EventArgs e)
		{
			appointmentBox.DisplayMember = "type";
			appointmentBox.DataSource = TypeHelper();
		}
	}
}
