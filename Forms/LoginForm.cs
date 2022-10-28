using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace DB_Project_C969
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			submitButton.Enabled = false;

		}

		private void submitButton_Click(object sender, EventArgs e)
		{


			if (SQL.LoginCheck(usernameTextBox.Text, passwordTextBox.Text))
			{

				SQL.viewUserId = SQL.getIdFromDB(usernameTextBox.Text);
				string id = SQL.viewUserId.ToString();
				if (Alert(id))
				{
					MessageBox.Show("Appointment Reminder");
				}

				string u = SQL.getUserName(SQL.viewUserId);
				WriteToTxtFile_Success(u);

				this.Hide();
				Dashboard dashboard = new Dashboard();
				dashboard.ShowDialog();
			}
			else
			{
				SQL.viewUserId = SQL.getIdFromDB(usernameTextBox.Text);
				string u = SQL.getUserName(SQL.viewUserId);

				// LOGIN FAILURE TO TXT FILE
				WriteToTxtFile_Failure(u);

				MessageBox.Show("Login Failed");
				usernameTextBox.Clear();
				passwordTextBox.Clear();
				usernameTextBox.Focus();
			}
		}

		private void usernameTextBox_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				submitButton.Enabled = false;
			}
			else
			{
				submitButton.Enabled = isValid();
			}
		}

		private void passwordTextBox_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				submitButton.Enabled = false;
			}
			else
			{
				submitButton.Enabled = isValid();
			}
		}

		private bool isValid()
		{
			return (!String.IsNullOrWhiteSpace(passwordTextBox.Text)
				&&
				   (!String.IsNullOrWhiteSpace(usernameTextBox.Text)));
		}
		
		private bool Alert(string userId)
		{
			try
			{
				DateTime start = DateTime.Now.ToUniversalTime();
				DateTime end = start.AddMinutes(15.0);
				
				string query = "SELECT start FROM appointment WHERE userId = @userId AND start <= @end  AND start >= @start";

				using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
				{
					using (MySqlCommand cmd = new MySqlCommand(query, connect))
					{
						connect.Open();

						cmd.Parameters.AddWithValue("@userId", userId);
						cmd.Parameters.AddWithValue("@start", start);
						cmd.Parameters.AddWithValue("@end", end);

						MySqlDataReader rdr = cmd.ExecuteReader();

						if (rdr.HasRows == true)
						{

							return true;
						}
						else
						{

							return false;
						}

					}
				}

			}
			catch (MySqlException x)
			{

				MessageBox.Show(x.Message);
				return false;
			}
		}

		Action<string> WriteToTxtFile_Success = userName =>
	   {
		   string filePath = @"C:\Users\LabUser\Desktop\AppointmentAPP\log.txt";
		   StreamWriter writer = new StreamWriter(filePath, true);
		   DateTime now = DateTime.Now;

		   writer.WriteLine(userName + " has logged in at " + now.ToString());

		   writer.Close();

	   };
		
		Action<string> WriteToTxtFile_Failure = userName =>
		{
			string filePath = @"C:\Users\LabUser\Desktop\AppointmentAPP\log.txt";
			StreamWriter writer = new StreamWriter(filePath, true);
			DateTime now = DateTime.Now;

			writer.WriteLine(userName + " Failed login attempt at " + now.ToString());

			writer.Close();
		};

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
