using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTTMovementToolApplication.Classes;
using TTTMovementToolApplication.Databases;

namespace TTTMovementToolApplication.Controller
{
    public class configurationsController
    {
        private MySqlConnection MySQLconn;
        private SqlConnection MSSQLconn;
        public List<configurations> MySQLlist;
        public List<configurations> MSSQLlist;
        public void SyncDBs()
        {
            MySQLconn = DBUtils.GetDBMySQLConnection();
            MySQLlist = new List<configurations>();

            using (MySQLconn)
            {
                MySQLconn.Open();
                MySqlCommand cmd = MySQLconn.CreateCommand();
                cmd.CommandText = "SELECT * FROM configurations";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var mydata = new configurations
                        {
                            id = Convert.ToInt32(reader.GetValue(0)),
                            configType = reader.GetString(1),
                            param = reader.GetString(3),
                            value = reader.GetString(4),
                            createdAt = reader.GetString(5),
                            updatedAt = reader.GetString(6)        
                        };

                        try
                        {
                            mydata.name = reader.GetString(2);
                        }
                        catch
                        {
                            mydata.name = null;
                        }
                        try
                        {
                            mydata.deletedAt = reader.GetString(7);
                        }
                        catch
                        {
                            mydata.deletedAt = null;
                        }

                        MySQLlist.Add(mydata); 
                    }

                    MySQLconn.Close();
                }

                MSSQLconn = DBUtils.GetDBMSSQLConnection();
                MSSQLlist = new List<configurations>();
                using (MSSQLconn)
                {
                    MSSQLconn.Open();
                    SqlCommand command;
                    SqlDataReader reader;
                    string query = "";
                    query = "SELECT * FROM configurations";
                    command = new SqlCommand(query, MSSQLconn);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        MSSQLlist.Add(new configurations
                        {
                            id = Convert.ToInt32(reader.GetValue(0)),
                            configType = reader.GetString(1),
                            name = reader.GetString(2),
                            param = reader.GetString(3),
                            value = reader.GetString(4),
                            createdAt = reader.GetDateTime(5).ToString(),
                            updatedAt = reader.GetDateTime(6).ToString(),
                            deletedAt = reader.GetDateTime(7).ToString(),
                        });
                    }
                    MSSQLconn.Close();
                }



                if ((MSSQLlist.Count != MySQLlist.Count) || (!MSSQLlist.Equals(MySQLlist)))
                {
                    MSSQLconn = DBUtils.GetDBMSSQLConnection();
                    using (MSSQLconn)
                    {
                        MSSQLconn.Open();
                        SqlCommand command;
                        SqlDataReader dataReader;
                        string query = "";
                        query = "DELETE FROM configurations";
                        command = new SqlCommand(query, MSSQLconn);
                        dataReader = command.ExecuteReader();
                        MSSQLconn.Close();
                    }

                    foreach (configurations student in MySQLlist)
                    {
                        MSSQLconn = DBUtils.GetDBMSSQLConnection();
                        using (MSSQLconn)
                        {
                            MSSQLconn.Open();
                            SqlCommand command;
                            SqlDataReader dataReader;
                            string query;
                            query = "INSERT INTO configurations (id, configType, name, param, value, createdAt, updatedAt, deletedAt) VALUES ("
                                + student.id.ToString() + ",'"
                                + student.configType + "',N'"
                                + student.name + "','"
                                + student.param + "','"
                                + student.value + "','"
                                + student.createdAt + "','"
                                + student.updatedAt + "','"
                                + student.deletedAt + "');";
                            command = new SqlCommand(query, MSSQLconn);
                            dataReader = command.ExecuteReader();
                            MSSQLconn.Close();
                        }
                    }
                }

            }
        }
    }
}
