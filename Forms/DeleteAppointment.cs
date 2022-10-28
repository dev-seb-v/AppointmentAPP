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
	public partial class DeleteAppointment : Form
	{
		public DeleteAppointment()
		{
			InitializeComponent();
		}

        private void DeleteAppointment_Load(object sender, EventArgs e)
        {
            DataGridViewHelper();
            DeleteBtn.Enabled = false;
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
                MessageBox.Show("Please Choose an Appointment to Delete.");
            }

            else
            {
                SQL.appointmentId = (int)appointmentDGV.Rows[e.RowIndex].Cells[0].Value;
                DeleteBtn.Enabled = true;
            }
        }

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
            Delete_Appointment();
		}

		

        private void Delete_Appointment()
        {

            string DeleteAppointment = "DELETE FROM appointment WHERE appointmentId = '"+SQL.appointmentId.ToString()+"'";

            try
            {
                MySqlConnection con = new MySqlConnection(SQL.C_String);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(DeleteAppointment, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Deleted!");
                DeleteAppointment_Load(this, new EventArgs());

            }
            catch (MySqlException x)
            {

                MessageBox.Show(x.Message);
            }

        }

		private void CancelBtn_Click(object sender, EventArgs e)
		{
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

		private void DeleteAppointment_FormClosed(object sender, FormClosedEventArgs e)
		{
            Dashboard d = new Dashboard();
            d.Show();
        }
	}
}
