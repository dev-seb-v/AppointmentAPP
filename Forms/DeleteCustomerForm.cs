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
    public partial class DeleteCustomerForm : Form
    {
        public DeleteCustomerForm()
        {
            InitializeComponent();
        }

        private void DataGridViewHelper()
        {
            custDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            custDGV.ClearSelection();
            custDGV.ReadOnly = true;
            custDGV.MultiSelect = false;
            custDGV.RowHeadersVisible = false;
            custDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            custDGV.AllowUserToResizeRows = false;
            string select = "select * from customer";
            using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
            {
                using (MySqlCommand cmd = new MySqlCommand(select, connect))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            custDGV.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void DeleteCustomerForm_Load(object sender, EventArgs e)
        {
            DataGridViewHelper();
        }

        private void deleteCustomer() 
        {
            // grab values from db using custom functions
            int customerId = Customer.customerId;
            string customerID = customerId.ToString();
            int addressID = Customer.getIntFromDB($"select addressId from address where addressId = {customerId}");
            int cityId = Customer.getIntFromDB("select cityId from address where addressId = '"+addressID+"' ");
            string cID = cityId.ToString();
            int countryId = Customer.getIntFromDB($"select countryId from city where cityId = {cID}");
            string countryID = countryId.ToString();

            // delete customer and associated records on other tables

            SQL.deleteCustomer($"delete from customer where customerId = {Customer.customerId}");
            SQL.deleteCustomer($"delete from address where addressId = {Customer.customerId}");
            SQL.deleteCustomer($"delete from city where cityId = {cityId}");
            SQL.deleteCustomer($"delete from country where countryId = {countryId}");

            MessageBox.Show("customer was deleted.");
            this.Close();
            Dashboard d = new Dashboard();
            d.ShowDialog();
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            // call delete customer method
            deleteCustomer();
        }

        private void custDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Customer.customerId = (int)custDGV.Rows[e.RowIndex].Cells[0].Value;
            if (Customer.customerId < 1)
            {
                deleteCustomerBtn.Enabled = false;
            }
            else
            {
                deleteCustomerBtn.Enabled = true;

            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.ShowDialog();

        }

		private void DeleteCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
		{

            CancelBtn_Click(sender, e);
        }
	}
}
