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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}
        private void LoginForm_Load(object sender, EventArgs e)
        {
            submitButton.Enabled = false;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {

			if (SQL.LoginCheck(usernameTextBox.Text, passwordTextBox.Text))
            {
                SQL.viewUserId = SQL.getIdFromDB(usernameTextBox.Text);
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                
                
            }
            else
            {
                MessageBox.Show("Login Failed");
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                usernameTextBox.Focus();
            }
        }

		private void usernameTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(usernameTextBox.Text))
             {
                submitButton.Enabled = false;
            }
            else
            {
                submitButton.Enabled = isValid();
            }
		}

		private void passwordTextBox_TextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrWhiteSpace(passwordTextBox.Text))
             {
                submitButton.Enabled = false;
            }
            else
            {
                submitButton.Enabled = isValid();
            }
        }

        private bool isValid()
        {
            return (!String.IsNullOrWhiteSpace(passwordTextBox.Text)
                &&
                   (!String.IsNullOrWhiteSpace(usernameTextBox.Text)));
        }
	}
}
