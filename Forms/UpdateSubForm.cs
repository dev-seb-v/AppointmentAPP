using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_Project_C969
{
    public partial class UpdateSubForm : Form
    {
        public UpdateSubForm()
        {
            InitializeComponent();
            // variables for the textboxes
            // pseudocode => thisvaluefromdb = textbox.text and so on
            
        }

        private void UpdateSubForm_Load(object sender, EventArgs e)
        {
            // call method
            TextBoxPopulate();
       

        }

        // populates the textboxes using the id dervied from cell click event
        private void TextBoxPopulate()
        {
            string name = Customer.getStringFromDB("select customerName from customer where customerId = '" + Customer.customerId + "'");
            nameTextBox.Text = name;
            string address = Customer.getStringFromDB("select address from address where addressId = '" + Customer.customerId + "'");
            addressTextBox.Text = address;
            string phone = Customer.getStringFromDB("select phone from address where addressId = '" + Customer.customerId + "'");
            phoneTextBox.Text = phone;
            int cityId = Customer.getIntFromDB("select cityId from address where addressId = '" + Customer.customerId + "'");
            string city = Customer.getStringFromDB("select city from city where cityId = '" + cityId + "'");
            cityTextBox.Text = city;
            int countryId = Customer.getIntFromDB("select countryId from city where city = '" + city + "'");
            string country = Customer.getStringFromDB("select country from country where countryId = '" + countryId + "'");
            countryTextBox.Text = country;
        }

       private void UpdateCustomerBtn_Click(object sender, EventArgs e)
        {

			try
			{
                UPDATE();
                MessageBox.Show("Customer Updated!");
                this.Hide();
                Dashboard d = new Dashboard();
                d.Show();
			}
			catch (Exception)
			{

				throw;
			}
           

        
        }

        private void UPDATE()
        {
            // update customer name
            using (MySqlConnection con = new MySqlConnection(SQL.C_String))
            {
                try
                {
                    con.Open();

                    string updateCustomer = "update customer set customerName = '" + nameTextBox.Text + "' where customerId = '" + Customer.customerId + "'";


                    using (MySqlCommand cmd = new MySqlCommand(updateCustomer, con))
                    {
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception)
                {

                    throw;
                }
                con.Close();
            }

            // update address
            using (MySqlConnection con = new MySqlConnection(SQL.C_String))
            {
                try
                {
                    con.Open();

                    string updateCustomer = "update address set address = '" + addressTextBox.Text + "' where addressId = '" + Customer.customerId + "'";


                    using (MySqlCommand cmd = new MySqlCommand(updateCustomer, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                con.Close();

                // update phone
                using (MySqlConnection con1 = new MySqlConnection(SQL.C_String))
                {
                    try
                    {
                        con1.Open();

                        string updateCustomer = "update address set phone = '" + phoneTextBox.Text + "' where addressId = '" + Customer.customerId + "'";


                        using (MySqlCommand cmd = new MySqlCommand(updateCustomer, con1))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    con.Close();


                    int city = Customer.getIntFromDB("select cityId from address where addressId = '" + Customer.customerId + "'");
                    string cityId = city.ToString();
                    int countryId = Customer.getIntFromDB("select countryId from city where cityId = '" + cityId + "'");
                    // update city name
                    using (MySqlConnection con2 = new MySqlConnection(SQL.C_String))
                    {
                        try
                        {
                            con2.Open();

                            string updateCustomer = "update city set city = '" + cityTextBox.Text + "' where cityId = '" + cityId + "'";


                            using (MySqlCommand cmd = new MySqlCommand(updateCustomer, con2))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        con2.Close();

                        // update country name
                        using (MySqlConnection con3 = new MySqlConnection(SQL.C_String))
                        {
                            try
                            {
                                con3.Open();

                                string updateCustomer = "update country set country = '" + countryTextBox.Text + "' where countryId = '" + countryId + "'";


                                using (MySqlCommand cmd = new MySqlCommand(updateCustomer, con3))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                            con3.Close();


                        }
                    }
                }
            }
        }
		private void nameTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                UpdateCustomerBtn.Enabled = false;
            }
            else
            {
                UpdateCustomerBtn.Enabled = true;
            }
        }

		private void addressTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                UpdateCustomerBtn.Enabled = false;
            }
            else
            {
                UpdateCustomerBtn.Enabled = true;
            }
        }

		private void phoneTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                UpdateCustomerBtn.Enabled = false;
            }
            else
            {
                UpdateCustomerBtn.Enabled = true;
            }
        }

		private void cityTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                UpdateCustomerBtn.Enabled = false;
            }
            else
            {
                UpdateCustomerBtn.Enabled = true;
            }
        }

		private void countryTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                UpdateCustomerBtn.Enabled = false;
            }
            else
            {
                UpdateCustomerBtn.Enabled = true;
            }
        }

		private void CancelButton_Click(object sender, EventArgs e)
		{
            this.Hide();
            updateCustomerForm ucf = new updateCustomerForm();
            ucf.Show();
        }

		private void UpdateSubForm_FormClosed(object sender, FormClosedEventArgs e)
		{
            updateCustomerForm ucf = new updateCustomerForm();
            ucf.Show();
        }
	}
}
