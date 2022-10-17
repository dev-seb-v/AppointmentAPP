using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project_C969
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCust = new AddCustomerForm();
            addCust.ShowDialog();
            this.Hide();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            updateCustomerForm updatecustomer = new updateCustomerForm();
            this.Hide();
            updatecustomer.Show();
        }

        private void customerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteCustomerForm deleteCustomer = new DeleteCustomerForm();
            this.Hide();
            deleteCustomer.Show();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Appointment_Form a = new Add_Appointment_Form();
            this.Hide();
            a.Show();
        }

		private void appointmentToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            Forms.AppointmentUpdate update = new Forms.AppointmentUpdate();
            this.Hide();
            update.Show();
		}

		private void appointmentToolStripMenuItem2_Click(object sender, EventArgs e)
		{
            Forms.DeleteAppointment delete = new Forms.DeleteAppointment();
            this.Hide();
            delete.Show();
		}

		private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Forms.ViewAppointmentForm view = new Forms.ViewAppointmentForm();
            this.Hide();
            view.Show();
		}

		
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
            Application.Exit();
		}

		private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Forms.Reports reports = new Forms.Reports();
            this.Hide();
            reports.Show();
		}
	}
}
