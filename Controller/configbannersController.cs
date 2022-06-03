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
    public class configbannersController
    {
        private MySqlConnection MySQLconn;
        private SqlConnection MSSQLconn;
        public List<configbanners> MySQLlist;
        public List<configbanners> MSSQLlist;
        public void SyncDBs()
        {
            MySQLconn = DBUtils.GetDBMySQLConnection();
            MySQLlist = new List<configbanners>();

            using (MySQLconn)
            {
                MySQLconn.Open();
                MySqlCommand cmd = MySQLconn.CreateCommand();
                cmd.CommandText = "SELECT * FROM configbanners";
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetOrdinal("id");
                        int companyTitleVI = reader.GetOrdinal("companyTitleVI");
                        int companyNameVI = reader.GetOrdinal("companyNameVI");
                        int logoImage = reader.GetOrdinal("logoImage");
                        int companyAddressVI = reader.GetOrdinal("companyAddressVI");
                        int companyPhone = reader.GetOrdinal("companyPhone");
                        int companyFax = reader.GetOrdinal("companyFax");
                        int createdAt = reader.GetOrdinal("createdAt");
                        int updatedAt = reader.GetOrdinal("updatedAt");
                        int deletedAt = reader.GetOrdinal("deletedAt");
                        int companyTitleEN = reader.GetOrdinal("companyTitleEN");
                        int companyNameEN = reader.GetOrdinal("companyNameEN");
                        int companyAddressEN = reader.GetOrdinal("companyAddressEN");
                        int companyEmail = reader.GetOrdinal("companyEmail");
                        int companyWebsite = reader.GetOrdinal("companyWebsite");
                        int companyFooterEN = reader.GetOrdinal("companyFooterEN");
                        int companyFooterVI = reader.GetOrdinal("companyFooterVI");
                        int parameterTableOptions = reader.GetOrdinal("parameterTableOptions");
                        int optionDisplayFooter = reader.GetOrdinal("optionDisplayFooter");
                        int logoFooter = reader.GetOrdinal("logoFooter");
                        int titleStationAirVI = reader.GetOrdinal("titleStationAirVI");
                        int titleStationWaterVI = reader.GetOrdinal("titleStationWaterVI");
                        int titleStationAirEN = reader.GetOrdinal("titleStationAirEN");
                        int titleStationWaterEN = reader.GetOrdinal("titleStationWaterEN");
                        int subTitleHeaderVI = reader.GetOrdinal("subTitleHeaderVI");
                        int subTitleHeaderEN = reader.GetOrdinal("subTitleHeaderEN");
                        DateTime _createdAt;
                        DateTime _updatedAt;
                        DateTime _deletedAt;
                        try
                        {
                            _createdAt = Convert.ToDateTime(reader.GetValue(createdAt));
                        }
                        catch 
                        {
                            _createdAt= DateTime.Now;
                        }
                        try
                        {
                            _updatedAt = Convert.ToDateTime(reader.GetValue(updatedAt));
                        }
                        catch
                        {
                            _updatedAt = DateTime.Now;
                        }
                        try
                        {
                            _deletedAt = Convert.ToDateTime(reader.GetValue(deletedAt));
                        }
                        catch
                        {
                            _deletedAt = DateTime.Now;
                        }
                        MySQLlist.Add(new configbanners
                        {
                            id = Convert.ToInt32(reader.GetValue(id)),
                            companyTitleVI = reader.GetString(companyTitleVI),
                            companyNameVI = reader.GetString(companyNameVI),
                            logoImage = reader.GetString(logoImage),
                            companyAddressVI = reader.GetString(companyAddressVI),
                            companyPhone = reader.GetString(companyPhone),
                            companyFax = reader.GetString(companyFax),
                            createdAt = _createdAt,
                            updatedAt = _updatedAt,
                            deletedAt = _deletedAt,
                            companyTitleEN = reader.GetString(companyTitleEN),
                            companyNameEN = reader.GetString(companyNameEN),
                            companyAddressEN = reader.GetString(companyAddressEN),
                            companyEmail = reader.GetString(companyEmail),
                            companyWebsite = reader.GetString(companyWebsite),
                            companyFooterEN = reader.GetString(companyFooterEN),
                            companyFooterVI = reader.GetString(companyFooterVI),
                            parameterTableOptions = reader.GetString(parameterTableOptions),
                            optionDisplayFooter = reader.GetString(optionDisplayFooter),
                            logoFooter = reader.GetString(logoFooter),
                            titleStationAirVI = reader.GetString(titleStationAirVI),
                            titleStationWaterVI = reader.GetString(titleStationWaterVI),
                            titleStationAirEN = reader.GetString(titleStationAirEN),
                            titleStationWaterEN = reader.GetString(titleStationWaterEN),
                            subTitleHeaderVI = reader.GetString(subTitleHeaderVI),
                            subTitleHeaderEN = reader.GetString(subTitleHeaderEN),
                        });
                    }
                    MySQLconn.Close();
                }

                MSSQLconn = DBUtils.GetDBMSSQLConnection();
                MSSQLlist = new List<configbanners>();
                using (MSSQLconn)
                {
                    MSSQLconn.Open();
                    SqlCommand command;
                    SqlDataReader dataReader;
                    string query = "";
                    query = "SELECT * FROM configbanners";
                    command = new SqlCommand(query, MSSQLconn);
                    dataReader = command.ExecuteReader();
                    
                    while (dataReader.Read())
                    {
                        MSSQLlist.Add(new configbanners
                        {
                            id = dataReader.GetInt32(0),
                            companyTitleVI = dataReader.GetString(1),
                            companyNameVI = dataReader.GetString(2),
                            logoImage = dataReader.GetString(3),
                            companyAddressVI = dataReader.GetString(4),
                            companyPhone = dataReader.GetString(5),
                            companyFax = dataReader.GetString(6),
                            createdAt = dataReader.GetDateTime(7),
                            updatedAt = dataReader.GetDateTime(8),
                            deletedAt = dataReader.GetDateTime(9),
                            companyTitleEN = dataReader.GetString(10),
                            companyNameEN = dataReader.GetString(11),
                            companyAddressEN = dataReader.GetString(12),
                            companyEmail = dataReader.GetString(13),
                            companyWebsite = dataReader.GetString(14),
                            companyFooterEN = dataReader.GetString(15),
                            companyFooterVI = dataReader.GetString(16),
                            parameterTableOptions = dataReader.GetString(17),
                            optionDisplayFooter = dataReader.GetString(18),
                            logoFooter = dataReader.GetString(19),
                            titleStationAirVI = dataReader.GetString(20),
                            titleStationWaterVI = dataReader.GetString(21),
                            titleStationAirEN = dataReader.GetString(22),
                            titleStationWaterEN = dataReader.GetString(23),
                            subTitleHeaderVI = dataReader.GetString(24),
                            subTitleHeaderEN = dataReader.GetString(25),
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
                        query = "DELETE FROM configbanners";
                        command = new SqlCommand(query, MSSQLconn);
                        dataReader = command.ExecuteReader();
                        MSSQLconn.Close();
                    }
                    //List<configbanners> exceptlist = MySQLlist.Except(MSSQLlist).ToList();
                    foreach (configbanners student in MySQLlist)
                    {
                        MSSQLconn = DBUtils.GetDBMSSQLConnection();
                        using (MSSQLconn)
                        {
                            MSSQLconn.Open();
                            SqlCommand command;
                            SqlDataReader dataReader;
                            string query;
                            query = "INSERT INTO configbanners (id, companyTitleVI, companyNameVI, logoImage, companyAddressVI, companyPhone, companyFax, createdAt, updatedAt, deletedAt, companyTitleEN, companyNameEN, companyAddressEN, companyEmail, companyWebsite, companyFooterEN, companyFooterVI, parameterTableOptions, optionDisplayFooter,logoFooter,titleStationAirVI,titleStationWaterVI,titleStationAirEN,titleStationWaterEN,subTitleHeaderVI,subTitleHeaderEN) VALUES ("
                                + student.id.ToString() + ",N'" 
                                + student.companyTitleVI + "','"
                                + student.companyNameVI + "','"
                                + student.logoImage + "',N'"
                                + student.companyAddressVI + "','"
                                + student.companyPhone + "','"
                                + student.companyFax + "','"
                                + student.createdAt.ToString("yyyy-MM-dd HH:mm:ss") + "','"
                                + student.updatedAt.ToString("yyyy-MM-dd HH:mm:ss") + "','"
                                + student.deletedAt.ToString("yyyy-MM-dd HH:mm:ss") + "','"
                                + student.companyTitleEN + "','"
                                + student.companyNameEN + "','"
                                + student.companyAddressEN + "','"
                                + student.companyEmail + "','"
                                + student.companyWebsite + "','"
                                + student.companyFooterEN + "',N'"
                                + student.companyFooterVI + "','"
                                + student.parameterTableOptions + "','"
                                + student.optionDisplayFooter + "','"
                                + student.logoFooter + "',N'"
                                + student.titleStationAirVI + "',N'"
                                + student.titleStationWaterVI + "','"
                                + student.titleStationAirEN + "','"
                                + student.titleStationWaterEN + "',N'"
                                + student.subTitleHeaderVI + "','"
                                + student.subTitleHeaderEN + "');";
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
