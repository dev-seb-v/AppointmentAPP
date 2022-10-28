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
	public partial class cancelBtn : Form
	{
		public cancelBtn()
		{
			InitializeComponent();
		}

		private void ExtraReport_Load(object sender, EventArgs e)
		{
			customerComboBox.DisplayMember = "customerName";
			customerComboBox.DataSource = CustComboHelper();
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

		private void customerComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
		
			
		}

		private string CustomerInfo(int customerId)
		{

			string select = "SELECT address, phone, postalCode FROM address WHERE addressId = @custId";
			MySqlConnection connect = new MySqlConnection(SQL.C_String);

			MySqlCommand cmd = new MySqlCommand(select, connect);
			connect.Open();
			cmd.Parameters.AddWithValue("@custId", customerId);
			DataTable table = new DataTable();
			MySqlDataReader reader = cmd.ExecuteReader();
			List<string> customerInfo = new List<string>();
			string custInfo_ = "";
			string msg = "The customer's address, phone #, and postal code is ";
			
			while (reader.Read())
			{
				
				customerInfo.Add(reader["address"].ToString());
				customerInfo.Add(reader["phone"].ToString());
				customerInfo.Add(reader["postalCode"].ToString());
				custInfo_ = String.Join(" ", customerInfo.ToArray());
			
				
			}
			
			return msg + Environment.NewLine +  custInfo_;
		}private string CustomerInfo_(int customerId)
		{

			string select = "SELECT address, phone, postalCode FROM address WHERE addressId = @custId";
			MySqlConnection connect = new MySqlConnection(SQL.C_String);

			MySqlCommand cmd = new MySqlCommand(select, connect);
			connect.Open();
			cmd.Parameters.AddWithValue("@custId", customerId);
			DataTable table = new DataTable();
			MySqlDataReader reader = cmd.ExecuteReader();
			List<string> customerInfo = new List<string>();
			string custInfo_ = "";
			string msg = "The customer's address, phone #, and postal code is: ";
			
			while (reader.Read())
			{
				
				customerInfo.Add(reader["address"].ToString());
				customerInfo.Add(reader["phone"].ToString());
				customerInfo.Add(reader["postalCode"].ToString());
				custInfo_ = String.Join(" ", customerInfo.ToArray());
			
				
			}
			
			return msg + Environment.NewLine + custInfo_;
		}


		private void reportBtn_Click(object sender, EventArgs e)
		{
			int id = SQL.getCustomerId(customerComboBox.Text);
			string name = customerComboBox.Text;
			reportTxtBox.Text =  String.Join(" ", CustomerInfo(id));
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard d = new Dashboard();
			d.Show();
		}
	}
}
