using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace DB_Project_C969
{
    public class SQL
    {
        // reusable connection string
        public static string C_String = "server=localhost; database=client_schedule;port=3306;Uid=sqlUser;Pwd=Passw0rd!;";
        public static int userId;
        public static int viewUserId;
        public static int appointmentId;

        public static string selectCustomerForAppointment = "select  customerId, customerName from customer";
        public static string selectUserForAppointment = "select userId, userName from user";

        // methods
        public static bool LoginCheck(string user, string pw)
        {

            using (MySqlConnection connection = new MySqlConnection(C_String))
                try

                {
                    string userName, password;
                    connection.Open();
                    string checkUsers = "select * from user WHERE userName='" + user + "' AND password = '" + pw + "'; ";
                    MySqlDataAdapter msa = new MySqlDataAdapter(checkUsers, connection);

                    DataTable dataTable = new DataTable();
                    msa.Fill(dataTable);

                    // check if any rows are returned when table is queried
                    if (dataTable.Rows.Count > 0)
                    {
                        userName = user;
                        password = pw;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Login Failed");
                    return false;
                    throw;
                }


        }
       
        public static void deleteCustomer(string query)
        {
            MySqlConnection connection = new MySqlConnection(SQL.C_String);
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException x)
            {

                MessageBox.Show(x.Message);
            }
           
        }

        public static void DataGridViewHelper(string query, DataGridView dg)
        {
           
            // use statement in my SQL class to join customer and appointment tables and display in DGV
            string select = query;
            using (MySqlConnection connect = new MySqlConnection(SQL.C_String))
            {
                using (MySqlCommand cmd = new MySqlCommand(select, connect))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            dg.DataSource = dt;
                        }
                    }
                }
            }
        }


        public static void ADDUSER()
        {
            MySqlConnection connect = new MySqlConnection(SQL.C_String);

            string insert = "insert into user (userName, password, active, createDate, createdBy, lastUpdateBy) values ('Galadriel', 'Mithril', 1, curdate(), 'admin', 'admin')";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(insert, connect))
                {
                    connect.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            connect.Close();
        }


        public static DateTime GetDateTime(string query)
        {
           
                DateTime value;
                MySqlConnection connect = new MySqlConnection(SQL.C_String);
                try
                {

                    string select = query;
                    MySqlCommand cmd = new MySqlCommand(select, connect);
                    connect.Open();
                    value = (DateTime)cmd.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw;
                }
                return value;
            }

        public static string getStringFromDB(string query)
        {
            string value;
            MySqlConnection connect = new MySqlConnection(SQL.C_String);
            try
            {

                string select = query;
                MySqlCommand cmd = new MySqlCommand(select, connect);
                connect.Open();
                value = (string)cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            return value;
        }
        public static int getIdFromDB( string input)
        {
            int value;
            MySqlConnection connect = new MySqlConnection(SQL.C_String);
            try
            {

                string select = "SELECT userId FROM user WHERE userName = @input";
                MySqlCommand cmd = new MySqlCommand(select, connect);
                cmd.Parameters.AddWithValue("@input", input);
                connect.Open();
                value = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            return value;
        }

        public static int getIntFromDB(string query)
        {
            int value;
            MySqlConnection connect = new MySqlConnection(SQL.C_String);
            try
            {

                string select = query;
                MySqlCommand cmd = new MySqlCommand(select, connect);
                connect.Open();
                value = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            return value;
        }

        public static int getCustomerId(string customerName)
        {
            int value;
            MySqlConnection connect = new MySqlConnection(SQL.C_String);
            try
            {
                string query = "SELECT customerId FROM customer WHERE customerName = @customerName";
                //string select = query;
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@customerName", customerName);
                connect.Open();
                value = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            return value;
        }
    }



}
