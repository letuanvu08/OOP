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
            string password = "0974706833vu";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

    }
}