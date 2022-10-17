using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                if (Alert() && Alert_())
                {
                    MessageBox.Show("Appointment Reminder", "You have an appointment within 15 minutes");
                }
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else
            {
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

        private bool Alert()
        {
            try
            {
                DateTime now = DateTime.Now;
                DateTime FifteenMinBeforeApp = now.AddMinutes(-15.0);
                int uID = SQL.viewUserId;
                string userId = uID.ToString();

                string query = "SELECT start FROM appointment WHERE userId = @userId AND start >= @f ";


                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();

                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@f", FifteenMinBeforeApp);

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

        private bool Alert_()
        {
            try
            {
                DateTime now = DateTime.Now;
                DateTime FifteenMinBeforeApp = now.AddMinutes(-15.0);
                int uID = SQL.viewUserId;
                string userId = uID.ToString();

                string query = "SELECT start FROM appointment WHERE userId = @userId AND @f < start ";


                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();

                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@f", FifteenMinBeforeApp);

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

        private void displayAppointments()
        { 
        
        }
    }
}
