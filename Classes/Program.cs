using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project_C969
{
    static class Program
    {
      
        static void Main()
        {
            // add user for testing purposes
            //SQL.ADDUSER();
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
           
        }
    }
}
