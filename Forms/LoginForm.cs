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
		public delegate bool funcke(string n);
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			submitButton.Enabled = false;

			CultureInfo ci = CultureInfo.CurrentCulture;
			CultureInfo ci_Spanish;

			if (!ci.Name.Equals("en-US"))
			{
				ci_Spanish = new CultureInfo("es-ES");
				CultureInfo.CurrentCulture = ci_Spanish;
			}
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			if (!UserExists(usernameTextBox.Text))
			{
				MessageBox.Show("User does not exist.", "Invalid User Input");
			}

			else
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
					if (CultureInfo.CurrentCulture.Name != "en-US")
					{
						MessageBox.Show("Error de inicio de sesion");
					}
					else
					{
						MessageBox.Show("Login Failed");
					}
					usernameTextBox.Clear();
					passwordTextBox.Clear();
					usernameTextBox.Focus();
				}
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
		// lambda function for successful login to .txt file
		Action<string> WriteToTxtFile_Success = userName =>
	   {
		   string filePath = @"C:\Users\LabUser\Desktop\AppointmentAPP\log.txt";
		   StreamWriter writer = new StreamWriter(filePath, true);
		   DateTime now = DateTime.Now;

		   writer.WriteLine(userName + " has logged in at " + now.ToString());

		   writer.Close();

	   };
		// lambda function for failed login to .txt file
		Action<string> WriteToTxtFile_Failure = userName =>
		{
			string filePath = @"C:\Users\LabUser\Desktop\AppointmentAPP\log.txt";
			StreamWriter writer = new StreamWriter(filePath, true);
			DateTime now = DateTime.Now;

			writer.WriteLine(userName + " Failed login attempt at " + now.ToString());

			writer.Close();
		};

		// delegate type used to create lambda function to check if User exists
		funcke UserExists = (x) =>
		{
			try
			{
				string select = "SELECT userName from user WHERE userName = @user";
				MySqlConnection connect = new MySqlConnection(SQL.C_String);
				MySqlCommand cmd = new MySqlCommand(select, connect);
				cmd.Parameters.AddWithValue("@user", x);
				MySqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					return true;
				}
				else
				{
					return false;
				}

			}
			catch
			{
				return false;
			}

		};
		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
