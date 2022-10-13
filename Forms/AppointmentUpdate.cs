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
	public partial class AppointmentUpdate : Form
	{
		public AppointmentUpdate()
		{
			InitializeComponent();
		}

		private void AppointmentUpdate_Load(object sender, EventArgs e)
		{
            updateBtn.Enabled = false;
            appointmentDGV.ClearSelection();
            // function to populate datagridview with appointments from DB
            DataGridViewHelper();
		}

        private void DataGridViewHelper()
        {
            appointmentDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentDGV.ClearSelection();
            appointmentDGV.ReadOnly = true;
            appointmentDGV.MultiSelect = false;
            appointmentDGV.RowHeadersVisible = false;
            appointmentDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            appointmentDGV.AllowUserToResizeRows = false;
            string select = "select * from appointment";
            using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
            {
                using (MySqlCommand cmd = new MySqlCommand(select, connect))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            appointmentDGV.DataSource = dt;
                        }
                    }
                }
            }
        }

		private void appointmentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            if (appointmentDGV.Rows.Count < 0)
            {
                MessageBox.Show("Please Choose an Appointment to Update.");
            }

            else
            {
            SQL.appointmentId = (int)appointmentDGV.Rows[e.RowIndex].Cells[0].Value;
                updateBtn.Enabled = true;
            }
           
        }

		private void updateBtn_Click(object sender, EventArgs e)
		{

			try
			{

                if (appointmentDGV.SelectedRows.Count < 0)
                {
                    MessageBox.Show("Please Select an Appointment To Update.", "No Appointment Chosen!");
                }
                else
                {
                    AppointmentUpdateSubForm ausf = new AppointmentUpdateSubForm();
                    this.Hide();
                    ausf.Show();
                }
               
            }
			catch (Exception)
			{

				throw;
			}
           
		}

		private void button2_Click(object sender, EventArgs e)
		{
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

		private void AppointmentUpdate_FormClosed(object sender, FormClosedEventArgs e)
		{
            Dashboard d = new Dashboard();
            d.Show();
        }
	}
}
