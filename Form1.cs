using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using TTTMovementToolApplication.Controller;
using TTTMovementToolApplication.Databases;

namespace TTTMovementToolApplication
{
    public partial class Form1 : Form
    {
        #region Field
        bool _mysqlvalid;
        bool _mssqlvalid; 
        primarystudentsController primarystudentscontroller;
        configbannersController configbannerscontroller;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Disabled Sync Function
            _mssqlvalid = false;
            _mysqlvalid = false;
            btnSync.Enabled = false;

            //Init MySQL DB 
            txtMySQLHost.Text = "localhost";
            txtMySQLPort.Text = "3306";
            txtMySQLDatabase.Text = "thanhthien_prod";
            txtMySQLUserName.Text = "root";
            txtMySQLPassword.Text = "TT12345";

            //Init MSSQL DB
            txtMSSQLDataSource.Text = "GIAVY-LAPTOP";
            txtMSSQLDatabase.Text = "thanhthien_prod";
        }

        private void btnTestMySQL_Click(object sender, EventArgs e)
        {
            DBUtils.host = txtMySQLHost.Text;
            try 
            {
                DBUtils.port = int.Parse(txtMySQLPort.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Port");
                return;
            }
            DBUtils.mysqldatabase = txtMySQLDatabase.Text;
            DBUtils.username = txtMySQLUserName.Text;
            DBUtils.password = txtMySQLPassword.Text;
            var MySQLconn = DBUtils.GetDBMySQLConnection();
            try
            {
                using (MySQLconn)
                {
                    MySQLconn.Open();
                    _mysqlvalid=true;
                    MessageBox.Show("Successful Connection!");
                    if (_mssqlvalid)
                    {
                        btnSync.Enabled = true;
                    }
                    MySQLconn.Close();
                }
            }
            catch
            {
                btnSync.Enabled = false; 
                _mysqlvalid = false;
                MessageBox.Show("Failed Connection!");
            }
            
        }

        private void btnMSSQLTest_Click(object sender, EventArgs e)
        {
            DBUtils.datasource = txtMSSQLDataSource.Text;
            DBUtils.mssqldatabase = txtMSSQLDatabase.Text;
            var MSSQLconn = DBUtils.GetDBMSSQLConnection();
            try
            {
                using (MSSQLconn)
                {
                    MSSQLconn.Open();
                    _mssqlvalid = true;
                    MessageBox.Show("Successful Connection!");
                    if (_mysqlvalid)
                    {
                        btnSync.Enabled = true;
                    }
                    MSSQLconn.Close();
                }
            }
            catch
            {
                _mssqlvalid = false;
                btnSync.Enabled = false ;
                MessageBox.Show("Failed Connection!");
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            if (btnSync.Text == "Sync")
            {
                Synctimer.Enabled = true;
                Synctimer.Interval = 5000;
                Synctimer.Start();
                btnSync.Text = "Stop";
                primarystudentscontroller = new primarystudentsController();
                configbannerscontroller = new configbannersController();
            }
            else if (btnSync.Text == "Stop")
            {
                Synctimer.Enabled=false;
                Synctimer.Stop();
                btnSync.Text = "Sync";
            }
        }

        private void Synctimer_Tick(object sender, EventArgs e)
        {
            //primarystudentscontroller.SyncDBs();
            configbannerscontroller.SyncDBs();
        }
    }
}