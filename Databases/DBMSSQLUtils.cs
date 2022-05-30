using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTMovementToolApplication.Databases
{
    public class DBMSSQLUtils
    {
        public static SqlConnection GetDBConnection(string datasource, string database)
        {
            // Connection String.
            string connection = "Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

            return new SqlConnection(connection);
        }
    }
}
