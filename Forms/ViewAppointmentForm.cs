using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project_C969.Forms
{
	public partial class ViewAppointmentForm : Form
	{
		public ViewAppointmentForm()
		{
			InitializeComponent();
		}

		private void ViewAppointmentForm_Load(object sender, EventArgs e)
		{
			


		}

		private void All_Appointments()
		{
			DataTable table = new DataTable();
			DataTable tableDerived = new DataTable();
			
			
			string query = "SELECT appointmentId, customerId, userId, type, start, end FROM appointment";
			MySqlConnection connect = new MySqlConnection(SQL.C_String);
			MySqlCommand cmd = new MySqlCommand(query, connect);
			connect.Open();
			MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
			adapter.Fill(table);
			adapter.Fill(tableDerived);
			DGV_UTC.DataSource = table;
			DGV_LOCAL.DataSource = tableDerived;


			// DataGridView Formatting
			DGV_UTC.RowHeadersVisible = false;
			DGV_LOCAL.RowHeadersVisible = false;

			for (int i = 0; i < table.Rows.Count; i++)
			{
				tableDerived.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)tableDerived.Rows[i]["start"], TimeZoneInfo.Local).ToString();
				tableDerived.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)tableDerived.Rows[i]["end"], TimeZoneInfo.Local).ToString();
			}
		}

		private void Weekly_Appointments()
		{
			DGV_LOCAL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DGV_LOCAL.ClearSelection();
			DGV_LOCAL.ReadOnly = true;
			DGV_LOCAL.MultiSelect = false;
			DGV_LOCAL.RowHeadersVisible = false;
			DGV_LOCAL.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			DGV_LOCAL.AllowUserToResizeRows = false;
			DateTime now = DateTime.Today;
			CultureInfo ci = new CultureInfo("en-US");
			Calendar myCalendar = ci.Calendar;
			CalendarWeekRule weekRule = ci.DateTimeFormat.CalendarWeekRule;
			DayOfWeek firstDOW = ci.DateTimeFormat.FirstDayOfWeek;
			int week = myCalendar.GetWeekOfYear(now, weekRule, firstDOW) - 1;

			string select = "SELECT appointmentId, customerId, userId, type, start, end  FROM appointment WHERE WEEK(start) = @week";
			using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
			{
				using (MySqlCommand cmd = new MySqlCommand(select, connect))
				{
					cmd.Parameters.AddWithValue("@week", week);
					using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
					{
						using (DataTable table = new DataTable())
						{
							DataTable tableDerived = new DataTable();
							adapter.Fill(tableDerived);
							adapter.Fill(table);
							DGV_UTC.DataSource = table;
							DGV_LOCAL.DataSource = tableDerived;
							for (int i = 0; i < table.Rows.Count; i++)
							{
								tableDerived.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)tableDerived.Rows[i]["start"], TimeZoneInfo.Local).ToString();
								tableDerived.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)tableDerived.Rows[i]["end"], TimeZoneInfo.Local).ToString();
							}
						}
					}
				}
			}
		}
		private void Monthly_Appointment()
		{
			DGV_LOCAL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DGV_LOCAL.ClearSelection();
			DGV_LOCAL.ReadOnly = true;
			DGV_LOCAL.MultiSelect = false;
			DGV_LOCAL.RowHeadersVisible = false;
			DGV_LOCAL.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			DGV_LOCAL.AllowUserToResizeRows = false;
			int thisMonth = DateTime.Now.Month;
			string select = "SELECT appointmentId, customerId, userId, type, start, end  FROM appointment WHERE MONTH(start) = @thisMonth";
			using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
			{
				using (MySqlCommand cmd = new MySqlCommand(select, connect))
				{
					cmd.Parameters.AddWithValue("@thisMonth", thisMonth);
					using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
					{
						using (DataTable table = new DataTable())
						{
							DataTable tableDerived = new DataTable();
							adapter.Fill(tableDerived);
							adapter.Fill(table);
							DGV_UTC.DataSource = table;
							DGV_LOCAL.DataSource = tableDerived;
							for (int i = 0; i < table.Rows.Count; i++)
							{
								tableDerived.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)tableDerived.Rows[i]["start"], TimeZoneInfo.Local).ToString();
								tableDerived.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)tableDerived.Rows[i]["end"], TimeZoneInfo.Local).ToString();
							}

						}
					}
				}
			}
		}

		private void weekRB_CheckedChanged(object sender, EventArgs e)
		{
			Weekly_Appointments();
		}

		private void monthRB_CheckedChanged(object sender, EventArgs e)
		{
			Monthly_Appointment();
		}


		private void allRB_CheckedChanged(object sender, EventArgs e)
		{
			All_Appointments();
		}
	}
}
