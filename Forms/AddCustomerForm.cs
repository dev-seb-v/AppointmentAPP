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
    
    public partial class AddCustomerForm : Form
    {
        
        
        public AddCustomerForm()
        {

           InitializeComponent();
           addCustomerButton.Enabled = false;

        }
        private bool isValid()
        {
            return (!String.IsNullOrWhiteSpace(nameTextBox.Text)
                    &&
                    (!String.IsNullOrWhiteSpace(addressTextBox.Text)
                    &&
                    (!String.IsNullOrWhiteSpace(phoneTextBox.Text)
                    &&
                    (!String.IsNullOrWhiteSpace(cityTextBox.Text)
                    &&
                     (!String.IsNullOrWhiteSpace(countryTextBox.Text))))));

        }
        public void addCustomer()
        {
            try
            {
                // INSERT INTO COUNTRY
                using (MySqlConnection con = new MySqlConnection(SQL.C_String))
                {
                    try
                    {
                        con.Open();
                        string a = "insert into country (country, createDate, createdBy, lastUpdateBy) values('" +countryTextBox.Text + "', curdate(), 'user', 'user');";
                        using (MySqlCommand cmd = new MySqlCommand(a, con))
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

                // INSERT INTO CITY
                using (MySqlConnection con = new MySqlConnection(SQL.C_String))
                {
                    try
                    {
                        con.Open();

                        string d = "insert into city (city, countryId, createDate, createdBy, lastUpdateBy)"
                            + "values ('" + cityTextBox.Text + "', LAST_INSERT_ID(), curdate(), 'user', 'user')";


                        using (MySqlCommand cmd = new MySqlCommand(d, con))
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
                //create random number for postal code
                Random rnd = new Random();
                int num = rnd.Next(33333, 55555);

                // INSERT INTO ADDRESS
                using (MySqlConnection con = new MySqlConnection(SQL.C_String))
                {
                    con.Open();

                    string f = "insert into address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy)"
                        + "values ('" +addressTextBox.Text + "', ' ', LAST_INSERT_ID(), '" + num + "', '" + phoneTextBox.Text + "', curdate(), 'user', 'user' )";


                    using (MySqlCommand cmd = new MySqlCommand(f, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // INSERT INTO CUSTOMER
                using (MySqlConnection con = new MySqlConnection(SQL.C_String))
                {
                    con.Open();

                    string g = "insert into customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdateBy)"
                        + "values (LAST_INSERT_ID(), '"+nameTextBox.Text+"' , LAST_INSERT_ID(), 1, curdate(), 'user', 'user' )";


                    using (MySqlCommand cmd = new MySqlCommand(g, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }

                MessageBox.Show("Customer Added!");
                this.Close();
                Dashboard db = new Dashboard();
                db.Show();
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void addCustomerButton_Click(object sender, EventArgs e)
        {
           addCustomer();
        }

		private void nameTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                addCustomerButton.Enabled = false;
            }
            else
            {
                addCustomerButton.Enabled = isValid();
            }
		}

		private void addressTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                addCustomerButton.Enabled = false;
            }
            else
            {
                addCustomerButton.Enabled = isValid();
            }
        }

		private void phoneTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                addCustomerButton.Enabled = false;
            }
            else
            {
                addCustomerButton.Enabled = isValid();
            }
        }

		private void cityTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                addCustomerButton.Enabled = false;
            }
            else
            {
                addCustomerButton.Enabled = isValid();
            }
        }

		private void countryTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                addCustomerButton.Enabled = false;
            }
            else
            {
                addCustomerButton.Enabled = isValid();
            }
        }

		private void cancelBtn_Click(object sender, EventArgs e)
		{
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
		}

		private void AddCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
		{
            Dashboard d = new Dashboard();
            d.Show();
        }
	}
}
