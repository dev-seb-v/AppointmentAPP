using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_C969
{
    public class Customer
    {
        public static int customerId;
        public static string customerName { get; set; }
        public static int addressId { get; set; }
        public static string address { get; set; }
        public static string city { get; set; }
        public static string country { get; set; }


        // method will return string retrieved from db
         public static string getStringFromDB (string query)
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

       
    }
}
