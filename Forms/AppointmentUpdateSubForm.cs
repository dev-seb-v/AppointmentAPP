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
	public partial class AppointmentUpdateSubForm : Form
	{
		public AppointmentUpdateSubForm()
		{
			InitializeComponent();
		}

		private void AppointmentUpdateSubForm_Load(object sender, EventArgs e)
		{
			start.Format = DateTimePickerFormat.Custom;
			start.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
			start.ShowUpDown = true;


			end.Format = DateTimePickerFormat.Custom;
			end.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
			end.ShowUpDown = true;
			end.Value = start.Value.AddMinutes(30.0);


			int appId = SQL.appointmentId;
			string appIdString = appId.ToString();
			string type = Customer.getStringFromDB("SELECT type FROM appointment WHERE appointmentId = '"+appIdString+"'");
			var custId = Customer.getIntFromDB("SELECT customerId FROM appointment WHERE appointmentId = '" + appIdString + "'");
			string custName = Customer.getStringFromDB("SELECT customerName FROM customer WHERE customerId = '" + custId + "'");
			DateTime startTime = SQL.GetDateTime("SELECT start from appointment WHERE appointmentId = '" + appId + "'");
			DateTime endTime = SQL.GetDateTime("SELECT end from appointment WHERE appointmentId = '" + appId + "'");



			userIdComboBox.Text = appIdString;
			typeTextBox.Text = type;
			customerComboBox.Text = custName;
			start.Value = startTime;
			end.Value = endTime;

            userIdComboBox.DisplayMember = "userId";
            userIdComboBox.DataSource = ComboHelper();
            customerComboBox.DisplayMember = "customerName";
            customerComboBox.DataSource = CustComboHelper();

        }

		private void updateBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (String.IsNullOrWhiteSpace(typeTextBox.Text))
				{
					MessageBox.Show("Please Enter An Appointment Type/Reason");
					typeTextBox.Focus();
					return;
				}
				
				if (outsideBusinessHrs() == false)
				{
					MessageBox.Show("Appointments cannot be made outside of business hours");
					start.Focus();
					return;
				}

				if (CheckOverlap_0() && CheckOverlap_00() == true)
				{
					// <---|--->---| overlap condition
					MessageBox.Show("Cannot Create Appointment!", "Overlap_0 error");
					start.Focus();
					return;
				}
				if (CheckOverlap_1() && CheckOverlap_11() == true)
				{
					MessageBox.Show("Cannot Create Appointment!", "Overlap_1 error");
					start.Focus();
					return;
				}
				if (CheckOverlap_2() && CheckOverlap_22() == true)
				{
					MessageBox.Show("Cannot Create Appointment!", "Overlap_2 error");
					start.Focus();
					return;
				}
				if (CheckOverlap_3() && CheckOverlap_33() == true)
				{
					MessageBox.Show("cannot create appointment!", "overlap_3 error");
					start.Focus();
					return;
				}

				else
				{
					Update_Appointment();
				}
			}

			catch (MySqlException x)
			{

				MessageBox.Show(x.Message);
			}
		}

		

		private bool outsideBusinessHrs()
		{
			// checks for start of appointment are
			// can't be before 0800 or after 1700 hours
			DateTime s = start.Value.ToUniversalTime();
			DateTime e = end.Value.ToUniversalTime();

			DateTime startOfBusiness = new DateTime();
			startOfBusiness = start.Value.Date.AddHours(8.0);
			DateTime endOfBusiness = new DateTime();
			endOfBusiness = end.Value.Date.AddHours(17.0);

			if (s < startOfBusiness || s > endOfBusiness)
			{

				return false;
			}

			if (e < startOfBusiness || e > endOfBusiness)
			{

				return false;
			}
			else
			{
				return true;
			}
		}

        private bool CheckOverlap_0()
        {
            try
            {
                // <---|--->---| overlap condition
                string query = "SELECT start from appointment WHERE NOT appointmentId = @apID AND start BETWEEN @userStart AND  @userEnd";
                string s = start.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string a = SQL.appointmentId.ToString();
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@apID", a);

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
        private bool CheckOverlap_00()
        {
            try
            {
                // <---|--->---| overlap condition
                string query = "SELECT end from appointment WHERE NOT appointmentId = @apID AND end > @userEnd AND start BETWEEN @userStart AND @userEnd";
                string s = start.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string a = SQL.appointmentId.ToString();
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@apID", a);

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
        private bool CheckOverlap_1()
        {
            try
            {
                // |--<---->--| overlap condition
                string query = "SELECT start from appointment WHERE NOT appointmentId = @apID AND start < @userStart AND @userStart BETWEEN start  AND @userEnd";
                string s = start.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string a = SQL.appointmentId.ToString();
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@apID", a);

                        MySqlDataReader rdr = cmd.ExecuteReader();

                        if (rdr.HasRows)
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
            catch (Exception)
            {

                throw;
            }

        }
        private bool CheckOverlap_11()
        {
            try
            {
                // |--<---->--| overlap condition
                string query = "SELECT end from appointment WHERE NOT appointmentId = @apID AND end > @userStart AND end > @userEnd";
                string s = start.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string a = SQL.appointmentId.ToString();
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@apID", a);

                        MySqlDataReader rdr = cmd.ExecuteReader();

                        if (rdr.HasRows)
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
            catch (Exception)
            {

                throw;
            }

        }
        private bool CheckOverlap_2()
        {
            try
            {
                //  |--<----|--> overlap condition
                string query = "SELECT start from appointment WHERE NOT appointmentId = @appID AND start < @userStart AND @userStart BETWEEN start AND end ";
                string s = start.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string a = SQL.appointmentId.ToString();
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@appID", a);

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
            catch (Exception)
            {

                throw;
            }

        }
        private bool CheckOverlap_22()
        {
            try
            {
                //  |--<----|--> overlap condition
                string query = "SELECT end from appointment WHERE NOT appointmentId = @apID AND end BETWEEN @userStart AND  @userEnd";
                string s = start.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string a = SQL.appointmentId.ToString();
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@apID", a);

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
            catch (Exception)
            {

                throw;
            }

        }
        private bool CheckOverlap_3()
        {
            try
            {
                // <--|------|--> overlap condition
                string query = "SELECT start from appointment WHERE NOT appointmentId = @apID AND start BETWEEN @userStart and end";
                string s = start.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string a = SQL.appointmentId.ToString();
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@apID", a);

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
            catch (Exception)
            {

                throw;
            }

        }
        private bool CheckOverlap_33()
        {
            try
            {
                // <--|------|--> overlap condition
                string query = "SELECT end from appointment WHERE NOT appointmentId = @apID AND end BETWEEN start AND @userEnd";
                string s = start.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToUniversalTime().ToString("yyyy-MM-dd hh:mm:ss");
                string a = SQL.appointmentId.ToString();
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@apID", a);

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
            catch (Exception)
            {

                throw;
            }

        }
        private void Update_Appointment()
        {

            DateTime startofMeeting = start.Value;
            DateTime endOfMeeting = end.Value;

            // string startInput = startofMeeting.ToString("yyyy-MM-dd hh:mm:ss");
            //string endInput =  endOfMeeting.ToString("yyyy-MM-dd hh:mm:ss");

            DateTime startInput = TimeZoneInfo.ConvertTimeToUtc(start.Value);
            string s = startInput.ToString("yyyy-MM-dd hh:mm:ss");
            DateTime endInput = TimeZoneInfo.ConvertTimeToUtc(end.Value);
            string e = endInput.ToString("yyyy-MM-dd hh:mm:ss");

            //string notNeeded = " not needed ";
            string userId = userIdComboBox.Text;
            int customerId = Customer.getIntFromDB("select customerId from customer where customerName = '" + customerComboBox.Text + "' ");
            string cusId = customerId.ToString();
            string UpdateAppointment = "UPDATE appointment SET UserId = '"+userIdComboBox.Text+"' , type = '" + typeTextBox.Text +"',customerId = '" + cusId + "' , start = '" + s + "',  end = '" + e + "' WHERE appointmentId = '" + SQL.appointmentId + "' ";
                
            try
            {
                MySqlConnection con = new MySqlConnection(SQL.C_String);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(UpdateAppointment, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Updated!");
                this.Hide();
                Dashboard d = new Dashboard();
                d.Show();

            }
            catch (MySqlException x)
            {

                MessageBox.Show(x.Message);
            }

        }
        private DataTable CustComboHelper()
        {
            string select = "select customerName from customer";

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
        private DataTable ComboHelper()
        {
            string select = "select userId from user";

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

		private void start_ValueChanged(object sender, EventArgs e)
		{
            end.Value = start.Value.AddMinutes(30.0);
        }

		private void button2_Click(object sender, EventArgs e)
		{
            this.Hide();
            Forms.AppointmentUpdate update = new AppointmentUpdate();
            update.Show();
		}
	}
}
