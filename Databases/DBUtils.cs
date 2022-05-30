using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTMovementToolApplication.Databases
{
    public static class DBUtils
    {
        public static string host;
        public static int port;
        public static string mysqldatabase;
        public static string username;
        public static string password;
        public static MySqlConnection GetDBMySQLConnection()
        {
            return DBMySQLUtils.GetDBConnection(host, port, mysqldatabase, username, password);
        }

        public static string datasource;
        public static string mssqldatabase;
        public static SqlConnection GetDBMSSQLConnection()
        {
            return DBMSSQLUtils.GetDBConnection(datasource, mssqldatabase);
        }

    }
}
