using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;    
            string database = "systemmanagecar";
            string username = "root";
          
                MySqlConnection conn;
            string password = "";
            try
            {

                password = "161200";

                conn = DBMySQLUtils.GetDBConnection(host, port, database, username, password);
                conn.Open();
            }
            catch
           /* if (conn.State == System.Data.ConnectionState.Open)*/
            {

                password = "0974706833vu";

                conn = DBMySQLUtils.GetDBConnection(host, port, database, username, password);
                conn.Open();

            }
                
                return conn;
            
        }

    }
}