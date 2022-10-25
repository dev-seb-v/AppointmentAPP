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
using System.Threading;

namespace DB_Project_C969.Forms
{
	public partial class UserScheduleForm : Form
	{
		public UserScheduleForm()
		{
			InitializeComponent();
		}

		private void Reports_Load(object sender, EventArgs e)
		{
			userIdComboBox.DisplayMember = "userId";
			userIdComboBox.DataSource = ComboHelper();
		}

		private string textFromList(List<string> list)
		{
			return String.Join(Environment.NewLine, list);
		}

		private List<string> UserSchedule(string userId)
		{

			string select = "SELECT start, end FROM appointment WHERE userId = @userId";
			MySqlConnection connect = new MySqlConnection(SQL.C_String);

			MySqlCommand cmd = new MySqlCommand(select, connect);
			connect.Open();
			cmd.Parameters.AddWithValue("@userId", userId);
			DataTable table = new DataTable();
			MySqlDataReader reader = cmd.ExecuteReader();
			List<string> schedule = new List<string>();
			while (reader.Read())
			{
				schedule.Add(reader[0].ToString());
				String.Join(" ", schedule.ToArray());
			}
			;
			return schedule;
		}

	

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d = new Dashboard();
			d.Show();
		}

		private void Reports_FormClosed(object sender, FormClosedEventArgs e)
		{
			cancelButton_Click(sender, new EventArgs());
		}

		private DataTable ComboHelper()
		{
			string select = "SELECT userId FROM user";

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

		private void userIdComboBox_SelectedValueChanged(object sender, EventArgs e)
		{

			reportText.Text = textFromList(UserSchedule(userIdComboBox.Text));
		}
	}

}
