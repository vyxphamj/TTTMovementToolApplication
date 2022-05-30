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
    public class primarystudentsController
    {
        private MySqlConnection MySQLconn;
        private SqlConnection MSSQLconn;
        public List<primarystudents> MySQLlist;
        public List<primarystudents> MSSQLlist;
        public void SyncDBs()
        {
            MySQLconn = DBUtils.GetDBMySQLConnection();
            MySQLlist = new List<primarystudents>();

            using (MySQLconn)
            {
                MySQLconn.Open();
                MySqlCommand cmd = MySQLconn.CreateCommand();
                cmd.CommandText = "SELECT * FROM primarystudents";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int IdIndex = reader.GetOrdinal("Id");
                        int NameIndex = reader.GetOrdinal("Name");
                        MySQLlist.Add(new primarystudents
                        {
                            Id = Convert.ToInt32(reader.GetValue(0)),
                            Name = reader.GetString(NameIndex)
                        }); 
                    }
                }
                MySQLconn.Close();
            }

            MSSQLconn = DBUtils.GetDBMSSQLConnection();
            MSSQLlist = new List<primarystudents>();
            using (MSSQLconn)
            {
                MSSQLconn.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                string query = "";
                query = "SELECT * FROM primarystudents";
                command = new SqlCommand(query, MSSQLconn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    MSSQLlist.Add(new primarystudents { Id = dataReader.GetInt32(0), Name = dataReader.GetString(1) });
                }
                MSSQLconn.Close();
            }

            

            if ((MSSQLlist.Count != MySQLlist.Count)||(!MSSQLlist.Equals(MySQLlist)))
            {
                MSSQLconn = DBUtils.GetDBMSSQLConnection();
                using (MSSQLconn)
                {
                    MSSQLconn.Open();
                    SqlCommand command;
                    SqlDataReader dataReader;
                    string query = "";
                    query = "DELETE FROM primarystudents";
                    command = new SqlCommand(query, MSSQLconn);
                    dataReader = command.ExecuteReader();
                    MSSQLconn.Close();
                }
                List<primarystudents> exceptlist = MySQLlist.Except(MSSQLlist).ToList();
                foreach (primarystudents student in exceptlist)
                {
                    MSSQLconn = DBUtils.GetDBMSSQLConnection();
                    using (MSSQLconn)
                    {
                        MSSQLconn.Open();
                        SqlCommand command;
                        SqlDataReader dataReader;
                        string query = "";
                        query = "INSERT INTO primarystudents (Id, Name) VALUES (" + student.Id.ToString() + ",'" + student.Name + "')";
                        command = new SqlCommand(query, MSSQLconn);
                        dataReader = command.ExecuteReader();
                        MSSQLconn.Close();
                    }
                }
            }

        }
    }
}
