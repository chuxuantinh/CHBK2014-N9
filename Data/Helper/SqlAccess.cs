using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CHBK2014_N9.Data.Helper
{
  public  class SqlAccess
    {

        private string _strConn;

        private OleDbConnection _myConn;

        private OleDbTransaction _OleDbTrans;

        public OleDbConnection Connection
        {
            get
            {
                return this._myConn;
            }
        }

        public string ConnectString
        {
            get
            {
                return this._strConn;
            }
            set
            {
                this._strConn = value;
            }
        }

        public OleDbTransaction Transaction
        {
            get
            {
                return this._OleDbTrans;
            }
        }

        public SqlAccess()
        {
            if (ConfigurationSettings.AppSettings["connectionString"] == null)
            {
                throw new ArgumentNullException("Không thể đọc được chuỗi \"ConnectString\" trong tập tin .Config.");
            }
            this._strConn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", Application.StartupPath, ConfigurationSettings.AppSettings["ConnectionString"].ToString());
            this._myConn = new OleDbConnection();
        }

        public SqlAccess(string sLocation, string sDBName, string sPassword)
        {
            string[] strArrays = new string[] { "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", sLocation, sDBName, ";Persist Security Info=False;Jet OLEDB:Database Password=", sPassword };
            this._strConn = string.Concat(strArrays);
            this._myConn = new OleDbConnection();
        }

        public SqlAccess(string sDBName, string sPassword)
        {
            this._strConn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", sDBName, ";Persist Security Info=False;Jet OLEDB:Database Password=", sPassword);
            this._myConn = new OleDbConnection();
        }

        public SqlAccess(string sDBName)
        {
            this._strConn = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", sDBName, ";Persist Security Info=False;Jet OLEDB:Database Password=");
            this._myConn = new OleDbConnection();
        }

        public void Close()
        {
            if (this._myConn.State == ConnectionState.Open)
            {
                this._myConn.Close();
                this._myConn.Dispose();
                this._myConn = null;
            }
        }

        public string Commit()
        {
            string str;
            try
            {
                this._OleDbTrans.Commit();
                str = "OK";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return str;
        }

        public DataTable ExecuteDataTable(string commandText, string[] myPara, object[] myValue)
        {
            string str = "";
            DataTable dataTable = new DataTable();
            if (this.Open() != "OK")
            {
                return dataTable;
            }
            try
            {
                try
                {
                    OleDbCommand oleDbCommand = new OleDbCommand()
                    {
                        CommandText = commandText,
                        Connection = this._myConn
                    };
                    if (myPara != null)
                    {
                        oleDbCommand.CommandType = CommandType.StoredProcedure;
                        for (int i = 0; i < (int)myPara.Length; i++)
                        {
                            OleDbParameter oleDbParameter = new OleDbParameter(myPara[i], myValue[i]);
                            oleDbCommand.Parameters.Add(oleDbParameter);
                        }
                    }
                    (new OleDbDataAdapter(oleDbCommand)).Fill(dataTable);
                    str = "OK";
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
            finally
            {
                this.Close();
            }
            return dataTable;
        }

        public DataTable ExecuteDataTable(OleDbTransaction myTransaction, string commandText)
        {
            DataTable dataTable = new DataTable();
            try
            {
                OleDbCommand oleDbCommand = new OleDbCommand(commandText, myTransaction.Connection, myTransaction);
                (new OleDbDataAdapter(oleDbCommand)).Fill(dataTable);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return dataTable;
        }

        public DataTable ExecuteDataTable(string commandText)
        {
            return this.ExecuteDataTable(commandText, null, null);
        }

        public string ExecuteNonQuery(string commandText)
        {
            return this.ExecuteNonQuery(commandText, null, null);
        }

        public string ExecuteNonQuery(string commandText, string[] myPara, object[] myValue)
        {
            string message = "";
            message = this.Open();
            if (message != "OK")
            {
                return message;
            }
            try
            {
                try
                {
                    OleDbCommand oleDbCommand = new OleDbCommand()
                    {
                        CommandText = commandText,
                        Connection = this._myConn
                    };
                    if (myPara != null)
                    {
                        oleDbCommand.CommandType = CommandType.StoredProcedure;
                        for (int i = 0; i < (int)myPara.Length; i++)
                        {
                            OleDbParameter oleDbParameter = new OleDbParameter(myPara[i], myValue[i]);
                            oleDbCommand.Parameters.Add(oleDbParameter);
                        }
                    }
                    oleDbCommand.ExecuteNonQuery();
                    message = "OK";
                }
                catch (Exception exception)
                {
                    message = exception.Message;
                    throw new Exception(message);
                }
            }
            finally
            {
                this.Close();
            }
            return message;
        }

        public string ExecuteNonQuery(OleDbTransaction myTransaction, string commandText, string[] myPara, object[] myValue)
        {
            string message = "";
            try
            {
                OleDbCommand oleDbCommand = new OleDbCommand()
                {
                    CommandText = commandText,
                    Connection = myTransaction.Connection,
                    Transaction = myTransaction
                };
                if (myPara != null)
                {
                    oleDbCommand.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < (int)myPara.Length; i++)
                    {
                        OleDbParameter oleDbParameter = new OleDbParameter(myPara[i], myValue[i]);
                        oleDbCommand.Parameters.Add(oleDbParameter);
                    }
                }
                oleDbCommand.ExecuteNonQuery();
                message = "OK";
            }
            catch (Exception exception)
            {
                message = exception.Message;
                this.Rollback();
                throw new Exception(message);
            }
            return message;
        }

        public string ExecuteNonQuery(OleDbTransaction myTransaction, string commandText)
        {
            return this.ExecuteNonQuery(myTransaction, commandText, null, null);
        }

        public OleDbDataReader ExecuteReader(string commandText)
        {
            OleDbDataReader oleDbDataReader = null;
            if (this.Open() == "OK")
            {
                oleDbDataReader = this.ExecuteReader(this._myConn, commandText);
            }
            return oleDbDataReader;
        }

        public OleDbDataReader ExecuteReader(OleDbConnection myConnection, string commandText)
        {
            OleDbDataReader oleDbDataReader = null;
            try
            {
                oleDbDataReader = (new OleDbCommand(commandText, myConnection)).ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception exception)
            {
                throw new ArgumentException(exception.Message);
            }
            return oleDbDataReader;
        }

        public OleDbDataReader ExecuteReader(OleDbTransaction myTransaction, string commandText)
        {
            OleDbDataReader oleDbDataReader = null;
            try
            {
                OleDbCommand oleDbCommand = new OleDbCommand(commandText, myTransaction.Connection, myTransaction);
                oleDbDataReader = oleDbCommand.ExecuteReader();
            }
            catch (Exception exception)
            {
                throw new ArgumentException(exception.Message);
            }
            return oleDbDataReader;
        }

        public object ExecuteScalar(string commandText, string[] myPara, object[] myValue)
        {
            object obj = null;
            if (this.Open() != "OK")
            {
                return obj;
            }
            try
            {
                try
                {
                    OleDbCommand oleDbCommand = new OleDbCommand()
                    {
                        CommandText = commandText,
                        Connection = this._myConn
                    };
                    if (myPara != null)
                    {
                        oleDbCommand.CommandType = CommandType.StoredProcedure;
                        for (int i = 0; i < (int)myPara.Length; i++)
                        {
                            OleDbParameter oleDbParameter = new OleDbParameter(myPara[i], myValue[i]);
                            oleDbCommand.Parameters.Add(oleDbParameter);
                        }
                    }
                    obj = oleDbCommand.ExecuteScalar();
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    obj = null;
                    throw new Exception(exception.Message);
                }
            }
            finally
            {
                this.Close();
            }
            return obj;
        }

        public object ExecuteScalar(string commandText)
        {
            return this.ExecuteScalar(commandText, null, null);
        }

        ~SqlAccess()
        {
            this._myConn = null;
        }

        public string Open()
        {
            string str;
            if (this._myConn == null)
            {
                throw new Exception("Connect is null");
            }
            try
            {
                this._myConn.ConnectionString = this._strConn;
                if (this._myConn.State == ConnectionState.Closed)
                {
                    this._myConn.Open();
                }
                str = "OK";
            }
            catch (OleDbException oleDbException1)
            {
                OleDbException oleDbException = oleDbException1;
                string message = oleDbException.Message;
                throw new Exception(oleDbException.Message);
            }
            return str;
        }

        public string Rollback()
        {
            string str;
            string message = "";
            try
            {
                this._OleDbTrans.Rollback();
                str = "OK";
            }
            catch (Exception exception)
            {
                message = exception.Message;
                return message;
            }
            return str;
        }

        public string Start()
        {
            string str;
            string str1 = this.Open();
            if (str1 != "OK")
            {
                return str1;
            }
            try
            {
                this._OleDbTrans = this._myConn.BeginTransaction();
                str = "OK";
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return str;
        }
    }
}
