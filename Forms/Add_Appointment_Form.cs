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


namespace DB_Project_C969
{
    public partial class Add_Appointment_Form : Form
    {
        public Add_Appointment_Form()
        {
            InitializeComponent();
        }
        private void Add_Appointment_Form_Load(object sender, EventArgs e)
        {
            start.Format = DateTimePickerFormat.Custom;
            start.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            start.ShowUpDown = true; 
            
            
            end.Format = DateTimePickerFormat.Custom;
            end.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            end.ShowUpDown = true;
            end.Value = start.Value.AddMinutes(30.0);
            
            // formatting for combobox and set data source
            userIdComboBox.DisplayMember = "userId";
            userIdComboBox.DataSource = ComboHelper();
            customerComboBox.DisplayMember = "customerName";
            customerComboBox.DataSource = CustComboHelper();
        }
        
        private void Add_Appointment()
        {

            DateTime startofMeeting = start.Value;
            DateTime endOfMeeting = end.Value;

            // string startInput = startofMeeting.ToString("yyyy-MM-dd hh:mm:ss");
            //string endInput =  endOfMeeting.ToString("yyyy-MM-dd hh:mm:ss");

            DateTime startInput = TimeZoneInfo.ConvertTimeToUtc(start.Value);
            string s = startInput.ToString("yyyy-MM-dd hh:mm:ss");
            DateTime endInput = TimeZoneInfo.ConvertTimeToUtc(end.Value);
            string e = endInput.ToString("yyyy-MM-dd hh:mm:ss");

            string type = typeTextBox.Text;
            string notNeeded = "not needed";
            string userId = userIdComboBox.Text;
            string cur_user = "current_user";

            string name = customerComboBox.Text;
            int customerId = SQL.getCustomerId(name);
            string cusId = customerId.ToString();
            string insertIntoAppointment = "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdateBy) VALUES (@cusId, @userId , @notNeeded, @notNeeded, @notNeeded, @notNeeded, @type, @notNeeded, @start, @end, curdate(), @cur_user, @cur_user )";

                    try
                    {
                        MySqlConnection con = new MySqlConnection(SQL.C_String);
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(insertIntoAppointment, con);
                        
                        cmd.Parameters.AddWithValue("@cusId", cusId);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@notNeeded", notNeeded);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@start", s);
                        cmd.Parameters.AddWithValue("@end", e);
                        cmd.Parameters.AddWithValue("@cur_user", cur_user);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Appointment Added!");
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

        // method to grab userId from user table
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

      


		
        // VALIDATION SECTION
        private bool CheckDate()
        {
            DateTime s = start.Value;
            DateTime today = DateTime.Today;
            int result = DateTime.Compare(s, today);
            if (result < 0)
            {
                return true;
            }
            else if (result == 0)
            {
                return false;
            }
            else
            {
                return false;
            }

		}

        private bool outsideBusinessHrs()
        {
            // checks for start of appointment are
            // can't be before 0800 or after 1700 hours
            DateTime s = start.Value;
            DateTime e = end.Value;

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
       

		private void AddAppBtn_Click(object sender, EventArgs e)
		{
			try
			{
                if (String.IsNullOrWhiteSpace(typeTextBox.Text))
                {
                    MessageBox.Show("Please Enter An Appointment Type/Reason");
                    typeTextBox.Focus();
                    return;
                }
                if (CheckDate() == true)
                {
                    MessageBox.Show("Date Cannot Be in the Past");
                    start.Focus();
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
                    Add_Appointment();
                }
			}
			
            catch (MySqlException x)
			{

                MessageBox.Show(x.Message);
			}
		}
        
        private bool CheckOverlap_0()
        {
			try
			{
                // <---|--->---| overlap condition
                string query = "SELECT start from appointment WHERE userId = @userId AND start BETWEEN @userStart AND  @userEnd";
                string s = start.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string u = userIdComboBox.Text;
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@userId", u);

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
                string query = "SELECT end from appointment WHERE userId = @userId AND end > @userEnd AND start BETWEEN @userStart AND @userEnd";
                string s = start.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string u = userIdComboBox.Text;
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@userId", u);

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
                string query = "SELECT start from appointment WHERE userId = @userId AND start < @userStart AND @userStart BETWEEN start  AND end";
                string s = start.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string u = userIdComboBox.Text;
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@userId", u);

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
                string query = "SELECT end from appointment WHERE userId = @userId AND end > @userStart AND end > @userEnd";
                string s = start.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string u = userIdComboBox.Text;
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@userId", u);

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
                string query = "SELECT start from appointment WHERE userId = @userId AND start < @userStart AND @userStart BETWEEN start AND end ";
                string s = start.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string u = userIdComboBox.Text;
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@userId", u);

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
                string query = "SELECT end from appointment WHERE userId = @userId AND end BETWEEN @userStart AND  @userEnd";
                string s = start.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string u = userIdComboBox.Text;
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@userId", u);

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
                string query = "SELECT start from appointment WHERE userId = @userId AND start BETWEEN @userStart AND end";
                string s = start.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string u = userIdComboBox.Text;
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@userId", u);

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
                string query = "SELECT end from appointment WHERE userId = @userId AND end BETWEEN start AND @userEnd";
                string s = start.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string e = end.Value.ToString("yyyy-MM-dd hh:mm:ss");
                string u = userIdComboBox.Text;
                using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        connect.Open();
                        cmd.Parameters.AddWithValue("@userStart", s);
                        cmd.Parameters.AddWithValue("@userEnd", e);
                        cmd.Parameters.AddWithValue("@userId", u);

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

        private void start_ValueChanged(object sender, EventArgs e)
		{
            // adds 30 minutes to the end as a way to improve usability 
            end.Value = start.Value.AddMinutes(30.0);

		}

		private void button2_Click(object sender, EventArgs e)
		{
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

		private void Add_Appointment_Form_FormClosed(object sender, FormClosedEventArgs e)
		{
            Dashboard d = new Dashboard();
            d.Show();
        }
	}
}
