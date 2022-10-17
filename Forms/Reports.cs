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
	public partial class Reports : Form
	{
		public Reports()
		{
			InitializeComponent();
		}

		private void Reports_Load(object sender, EventArgs e)
		{
		
		}

		private void selectBox_SelectedValueChanged(object sender, EventArgs e)
		{

			if (selectBox.Text == "Number of Meetings Per Month (By Type)")
			{
				AppointmentsPerMonthByType("Scrum");
			}
			if (selectBox.Text == "User Schedules")
			{
				UserSchedule();
			}
			if (selectBox.Text == "Number of Meetings By Quarter")
			{
				AppointmentsPerQuarter();
			}


		}

		private void AppointmentsPerMonthByType(string type)
		{
			string select = "SELECT type FROM appointment WHERE type = @type";
			using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
			{
				using (MySqlCommand cmd = new MySqlCommand(select, connect))
				{
					cmd.Parameters.AddWithValue("@type", type);
					using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
					{
						using (DataTable table = new DataTable())
						{
							DataTable tableDerived = new DataTable();
							
							adapter.Fill(table);
							for (int i = 0; i < table.Rows.Count; i++)
							{
							    
							    reportText.Text = table.Rows[i]["type"].ToString();

							}
							
						}
					}
				}
			}
		}

		private void UserSchedule()
		{
			MessageBox.Show("per User");
		}

		private void AppointmentsPerQuarter()
		{
			MessageBox.Show("per Quarter");
		}
	}
}
