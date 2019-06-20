using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ATT.DAL.Common
{
   internal class DBHelper
    {

        private static SqlConnection conn = null;
        private bool connectStatus = true;
        private string strConn;
        private string strDatabaseName = "";
        private string strPass = "";
        private string strServerName = "";
        private string strUserName = "";

        public DBHelper()
        {
            try
            {
                if ((conn == null) || (conn.State == ConnectionState.Closed))
                {
                    this.initConnection();
                }
            }
            catch (SqlException exception)
            {
                this.ConnectStatus = false;
                Console.WriteLine("Can not open Connection" + exception.Message);
            }
        }

        public void Dispose()
        {
            if ((conn != null) || (conn.State != ConnectionState.Closed))
            {
                conn.Close();
                this.ConnectStatus = false;
            }
        }

        public DataSet ExecuteDSQuery(string sql, List<SqlParameter> paramlist)
        {
            SqlCommand cmd = new SqlCommand();
            this.prepareCommand(cmd, sql, paramlist);
            SqlDataAdapter adapter = new SqlDataAdapter
            {
                SelectCommand = cmd
            };
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }

        public int ExecuteNonQuery(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conn);
            return command.ExecuteNonQuery();
        }

        public int ExecuteNonQuery(string sql, List<SqlParameter> paramlist)
        {
            SqlCommand cmd = new SqlCommand();
            this.prepareCommand(cmd, sql, paramlist);
            return cmd.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteQuery(string sql)
        {
          // conn.Open();
          
            SqlDataReader reader = null;
            try
            {
             conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                return (reader = command.ExecuteReader());
            }
            catch (SqlException exception)
            {
                Console.WriteLine("Can not create Command" + exception.Message);
            }
          //  conn.Close();
           
            return reader;
           
        }

        public SqlDataReader ExecuteQuery(string sql, List<SqlParameter> paramlist)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                this.prepareCommand(cmd, sql, paramlist);
                reader = cmd.ExecuteReader();
            }
            catch (SqlException exception)
            {
                Console.WriteLine("Can not create Command" + exception.Message);
            }
            return reader;
        }

        public int ExecuteScalar(string query)
        {
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = query,
                Connection = conn
            };
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public int ExecuteScalar(string sql, List<SqlParameter> paramlist)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                this.prepareCommand(cmd, sql, paramlist);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException exception)
            {
                Console.WriteLine("Can not create Command" + exception.Message);
                return 0;
            }
            catch (InvalidCastException exception2)
            {
                Console.WriteLine("Can not get Data" + exception2.Message);
                return 0;
            }
        }

        public int FillDataTable(DataTable dt, string sql)
        {
            SqlCommand selectCommand = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = sql,
                Connection = conn
            };
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            return adapter.Fill(dt);
        }

        private void initConnection()
        {
            this.ReadXML();
            if ((this.strUserName != "") && (this.strPass != ""))
            {
                this.strConn = "Server ='" + this.strServerName + "';Initial Catalog ='" + this.strDatabaseName + "';User Id='" + this.strUserName + "';pwd='" + this.strPass + "';";
            }
            else
            {
                this.strConn = "Server ='" + this.strServerName + "';Initial Catalog ='" + this.strDatabaseName + "';Integrated Security=true;";
            }
            conn = new SqlConnection(this.strConn);
            conn.Open();
            Console.WriteLine("Connection is opening");
        }

        protected void prepareCommand(SqlCommand cmd, string sql, List<SqlParameter> paramlist)
        {
            if ((conn == null) || (conn.State == ConnectionState.Closed))
            {
                this.initConnection();
            }
            cmd.CommandTimeout = 0x3e8;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sql;
            if (paramlist != null)
            {
                foreach (SqlParameter parameter in paramlist)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
        }

        private void ReadXML()
        {
            string fileName = "Config.xml";
            DataSet set = new DataSet();
            try
            {
                set.ReadXml(fileName);
                if ((set != null) && (set.Tables[0].Rows.Count > 0))
                {
                    this.strServerName = set.Tables[0].Rows[0]["ServerName"].ToString().Trim();
                    this.strDatabaseName = set.Tables[0].Rows[0]["Database"].ToString().Trim();
                    this.strUserName = set.Tables[0].Rows[0]["UserName"].ToString().Trim();
                    this.strPass = set.Tables[0].Rows[0]["PassWord"].ToString().Trim();
                }
            }
            catch (Exception exception)
            {
                this.ConnectStatus = false;
                Console.WriteLine(exception.Message);
            }
        }

        public bool ConnectStatus
        {
            get
            {
                return this.connectStatus;
            }
            set
            {
                this.connectStatus = value;
            }
        }
    }
}
