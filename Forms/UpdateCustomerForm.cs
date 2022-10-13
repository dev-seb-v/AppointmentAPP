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
    
    public partial class updateCustomerForm : Form
    {
        public updateCustomerForm()
        {
            InitializeComponent();
            this.DataGridViewHelper();
        }

        // datagrid view stuff
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

        private void custDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer.customerId = (int)custDGV.Rows[e.RowIndex].Cells[0].Value;
          
    
        }

        private void updateCustButton_Click(object sender, EventArgs e)
        {
            UpdateSubForm usf = new UpdateSubForm();
            usf.ShowDialog();
            this.Hide();


        }

		private void CancelBtn_Click(object sender, EventArgs e)
		{
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

		private void updateCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
		{
            Dashboard d = new Dashboard();
            d.Show();
        }
	}
}
