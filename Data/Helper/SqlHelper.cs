using Microsoft.VisualBasic;
//using Perfect.Utils.Security2;
using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Transactions;


namespace CHBK2014_N9.Data.Helper
{
    public class SqlHelper
    {

        private static bool _HideError;

        private static string _GlobalConnectString ;
  
        private static string _serverConnectionString;

        private static int _count;

        private bool _autoCommand = true;

        private bool _authentication = true;

        private SqlConnection _connection;

        private string _connectionString ;

        private string _database ;

        private string _password ;

        private string _server ;

        private SqlTransaction _transaction;

        private string _userid = "";

        private string _result = "";

        private string _commandText = "";

        private bool _mustCloseConnection;

        private SqlHelperException _sqlHelperException;

        private bool _isFormatMessage = true;

        private CommandType _commandType = CommandType.StoredProcedure;

        private int m_rowaffected;

        private bool m_useTransaction;

        private bool _isextract;

        public bool Authentication
        {
            get
            {
                return this._authentication;
            }
            set
            {
                this._authentication = value;
            }
        }

        public bool AutoCommand
        {
            get
            {
                return this._autoCommand;
            }
            set
            {
                this._autoCommand = value;
            }
        }

        public string CommandText
        {
            get
            {
                return this._commandText;
            }
            set
            {
                this._commandText = value;
            }
        }

        public CommandType CommandType
        {
            get
            {
                return this._commandType;
            }
            set
            {
                this._commandType = value;
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return this._connection;
            }
        }

        public string ConnectionString
        {
            get
            {
                return this._connectionString;
            }
            set
            {



                this._connectionString = value;
            }
        }

        public static string ConnectString
        {
            get
            {
                return SqlHelper._GlobalConnectString;
            }
            set
            {
                SqlHelper._GlobalConnectString = value;
            }
        }

        public static int Count
        {
            get
            {
                return SqlHelper._count;
            }
            set
            {
                SqlHelper._count = value;
            }
        }

        public string Database
        {
            get
            {
                return this._database;
            }
            set
            {
                this._database = value;
            }
        }

        public static bool HideError
        {
            get
            {
                return SqlHelper._HideError;
            }
            set
            {
                SqlHelper._HideError = value;
            }
        }

        public bool IsConnection
        {
            get
            {
                if (this._connection.State != ConnectionState.Open)
                {
                    return false;
                }
                return true;
               
            }
        }

        public bool IsExtract
        {
            get
            {
                return this._isextract;
            }
            set
            {
                this._isextract = value;
                if (this._isextract)
                {
                    this.Extract();
                }
            }
        }

        public bool IsFormatMessage
        {
            get
            {
                return this._isFormatMessage;
            }
            set
            {
                this._isFormatMessage = value;
            }
        }

        public bool MustCloseConnection
        {
            get
            {
                return this._mustCloseConnection;
            }
            set
            {
                this._mustCloseConnection = value;
            }
        }

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }

        public string Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }

        public int Rowaffected
        {
            get
            {
                return this.m_rowaffected;
            }
            set
            {
                this.m_rowaffected = value;
            }
        }

        public string Server
        {
            get
            {
                return this._server;
            }
            set
            {
                this._server = value;
            }
        }

        public static string ServerConnectString
        {
            get
            {
                string item;
                if (SqlHelper._serverConnectionString != "")
                {
                    return SqlHelper._serverConnectionString;
                }
                if (SqlHelper.IsAuthe(SqlHelper._GlobalConnectString))
                {
                    item = SqlHelper.GetItem("data source=", SqlHelper._GlobalConnectString);
                    return string.Concat("Data Source=", item, ";Initial Catalog=master;Integrated Security=True;");
                }
                item = SqlHelper.GetItem("server=", SqlHelper._GlobalConnectString);
                string str = SqlHelper.GetItem("user id=", SqlHelper._GlobalConnectString);
                string item1 = SqlHelper.GetItem("password=", SqlHelper._GlobalConnectString);
                string[] strArrays = new string[] { "server=", item, ";user id= ", str, " ;password=", item1, ";" };
                return string.Concat(strArrays);
            }
            set
            {
                SqlHelper._serverConnectionString = value;
            }
        }

        public SqlHelperException SqlHelperException
        {
            get
            {
                return this._sqlHelperException;
            }
        }

        public SqlTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
        }

        public string UserID
        {
            get
            {
                return this._userid;
            }
            set
            {
                this._userid = value;
            }
        }

        public bool UseTransaction
        {
            get
            {
                return this.m_useTransaction;
            }
            set
            {
                this.m_useTransaction = value;
            }
        }

        static SqlHelper()
        {
            SqlHelper._HideError = false;
            SqlHelper._GlobalConnectString = "server='.\\CT';database='ERP.PMQLNS'; User Id='sa'; Password = 'cutinh'";
            SqlHelper._serverConnectionString = "";
            SqlHelper._count = 0;
        }

        public SqlHelper()
        {
            this._connectionString = SqlHelper._GlobalConnectString;
            this._connection = new SqlConnection();
            SqlHelper.Count = SqlHelper.Count + 1;
        }

        public SqlHelper(string serverName, string dataBaseName, string userName, string passWord)
        {
            this._server = serverName;
            this._database = dataBaseName;
            this._userid = userName;
            this._password = passWord;
            this._authentication = false;
            this._connectionString = this.RebuildConnectionString();
            this._connection = new SqlConnection();
            SqlHelper.Count = SqlHelper.Count + 1;
        }

        public SqlHelper(string serverName, string userName, string passWord) : this(serverName, "", userName, passWord, false)
        {
        }


        public SqlHelper(string serverName, string dataBaseName, string userName, string passWord, bool authen)
        {
            this._server = serverName;
            this._database = dataBaseName;
            this._userid = userName;
            this._password = passWord;
            this._authentication = authen;
            this._connectionString = this.RebuildConnectionString();
            this._connection = new SqlConnection();
            SqlHelper.Count = SqlHelper.Count + 1;
        }

        public SqlHelper(string serverName, string dataBaseName)
        {
            this._server = serverName;
            this._database = dataBaseName;
            this._userid = "";
            this._password = "";
            this._authentication = true;
            this._connectionString = this.RebuildConnectionString(this._server, this._database);
            this._connection = new SqlConnection();
            SqlHelper.Count = SqlHelper.Count + 1;
        }

        public SqlHelper(string serverName, int authencation)
        {
            this._server = serverName;
            this._database = "";
            this._userid = "";
            this._password = "";
            this._authentication = true;
            this._connectionString = this.RebuildConnectionString(this._server);
            this._connection = new SqlConnection();
            SqlHelper.Count = SqlHelper.Count + 1;

            
        }


        

        //public SqlHelper(string connectstring, string password)// ,bool IsCrypt
        //{
        //    //if (IsCrypt)
        //    //{
        //    //    connectstring = MyEncryption.Decrypt(connectstring, password, true);
        //    //}
        //    if (SqlHelper.ConnectString == null)
        //    {
        //        throw new ArgumentNullException("ConnectString không được rỗng.");
        //    }
        //    if (string.IsNullOrEmpty(connectstring))
        //    {
        //        throw new SqlHelperException("connectstring");
        //    }
        //    this._connectionString = connectstring;
        //    this._connection = new SqlConnection();
        //    SqlHelper.Count = SqlHelper.Count + 1;
        //}

        public SqlHelper(string connectString)
        {
            if (string.IsNullOrEmpty(connectString))
            {
                throw new SqlHelperException("connectString");
            }
            this._connectionString = connectString;
            this._connection = new SqlConnection();
            SqlHelper.Count = SqlHelper.Count + 1;
        }

        public SqlHelper(SqlConnection connection)
        {
            if (connection == null)
            {
                throw new SqlHelperException("connection");
            }
            this._connection = connection;
            this._connectionString = this.Connection.ConnectionString;
            SqlHelper.Count = SqlHelper.Count + 1;
        }

        public string AddUser(string userId, string password, string database)
        {
            this.CommandType = CommandType.Text;
            string[] strArrays = new string[] { "EXEC master.dbo.sp_addlogin @loginame = N'", userId, "', @passwd = N'", password, "', @defdb = N'", database, "'" };
            return this.ExecuteNonQuery(string.Concat(strArrays));
        }

        private void AssignParameterValues(SqlParameter[] commandParameters, object[] parameterValues)
        {
            if (commandParameters == null || parameterValues == null)
            {
                return;
            }
            if ((int)commandParameters.Length != (int)parameterValues.Length)
            {
                throw new ArgumentException("Parameter count does not match Parameter Value count.");
            }
            int num = 0;
            int length = (int)commandParameters.Length;
            while (num < length)
            {
                if (parameterValues[num] is IDbDataParameter)
                {
                    IDbDataParameter dbDataParameter = (IDbDataParameter)parameterValues[num];
                    if (dbDataParameter.Value != null)
                    {
                        commandParameters[num].Value = dbDataParameter.Value;
                    }
                    else
                    {
                        commandParameters[num].Value = DBNull.Value;
                    }
                }
                else if (parameterValues[num] != null)
                {
                    commandParameters[num].Value = parameterValues[num];
                }
                else
                {
                    commandParameters[num].Value = DBNull.Value;
                }
                num++;
            }
        }

        public string Attach(string mdfFile, string ldfFile, string database)
        {
            this.Result = this.Exists(database);
            if (this.Result == "OK")
            {
                string[] strArrays = new string[] { "EXEC sp_attach_db @dbname = N'", database, "',@filename1 = N'", mdfFile, "',@filename2 = N'", ldfFile, "'" };
                string str = string.Concat(strArrays);
                this.CommandType = CommandType.Text;
                this.Result = this.ExecuteNonQuery(str);
            }
            return this.Result;
        }

        private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (commandParameters != null)
            {
                SqlParameter[] sqlParameterArray = commandParameters;
                for (int i = 0; i < (int)sqlParameterArray.Length; i++)
                {
                    SqlParameter value = sqlParameterArray[i];
                    if (value != null)
                    {
                        if ((value.Direction == ParameterDirection.InputOutput || value.Direction == ParameterDirection.Input) && value.Value == null)
                        {
                            value.Value = DBNull.Value;
                        }
                        command.Parameters.Add(value);
                    }
                }
            }
        }

        public bool Check()
        {
            return this.Check(false);
        }

        public bool Check(bool isclose)
        {
            if (this.Open() != "OK")
            {
                return false;
            }
            if (isclose)
            {
                this.Close();
            }
            return true;
        }

        public static string CheckId(string tableName, string columnName, string vKey)
        {
            string str = "";
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            string[] strArrays = new string[] { "select count([", columnName, "]) from [", tableName, "] where [", columnName, "] like '", vKey, "'" };
            object obj = sqlHelper.ExecuteScalar(string.Concat(strArrays));
            if (obj != null && Convert.ToInt32(obj) == 0)
            {
                str = "OK";
            }
            return str;
        }

        public void Close()
        {
            this.Close(this._connection);
        }

        public void Close(SqlConnection myConnection)
        {
            if (myConnection == null)
            {
                return;
            }
            if (myConnection.State == ConnectionState.Open)
            {
                try
                {
                    myConnection.Close();
                }
                catch (SqlException sqlException)
                {
                    this.Result = "Có lỗi xảy ra khi mở kết nối đến máy chủ.";
                }
                catch (Exception exception)
                {
                }
            }
            this._connection.Dispose();
            this._connection = null;
        }

        public string Commit()
        {
            return this.Commit(this._transaction);
        }

        public string Commit(SqlTransaction myTransaction)
        {
            if (myTransaction == null)
            {
                throw new SqlHelperException("myTransaction");
            }
            this.Result = "";
            try
            {
                myTransaction.Commit();
                this.RaiseTransactionClosedEventHander();
                this.Close();
                this.Result = "OK";
                return this.Result;
            }
            catch (InvalidOperationException invalidOperationException1)
            {
                InvalidOperationException invalidOperationException = invalidOperationException1;
                if (!SqlHelper._HideError)
                {
                    this.Result = invalidOperationException.Message;
                }
                else
                {
                    this.Result = "Các giao dịch đã được hoàn thành hoặc được khôi phục lại.\nOr kết nối bị huỹ.";
                }
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = string.Concat("Không thể kết thúc giao dịch.\nChi tiết:\n\t", sqlException.Message);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                if (!SqlHelper._HideError)
                {
                    this.Result = exception.Message;
                }
                else
                {
                    this.Result = "Có lỗi xảy ra trong khi cố gắng hoàn thành giao dịch.";
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return this.Result;
        }

        public string Deattach(string database)
        {
            this.Result = this.Open();
            if (this.Result == "OK")
            {
                string[] strArrays = new string[] { "IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'", database, "') BEGIN  EXEC sp_detach_db @dbname = N'", database, "' END " };
                string str = string.Concat(strArrays);
                this.CommandType = CommandType.Text;
                this.Result = this.ExecuteNonQuery(str);
            }
            return this.Result;
        }

        //public string Decrypt()
        //{
        //    return this.Decrypt(this._connectionString, "!@#$%^&*()Pofd154$#@");
        //}

        //public string Decrypt(string connectstring, string password)
        //{
        //  //  connectstring = MyEncryption.Decrypt(connectstring, password, true);
        //    this._connectionString = connectstring;
        //    if (this._connection == null)
        //    {
        //        this._connection = new SqlConnection();
        //    }
        //    return this._connectionString;
        //}

        private string DispError(int number, string message, string function)
        {
            int num = number;
            if (num <= 201)
            {
                if (num > 2)
                {
                    if (num == 58)
                    {
                        return "Không thể kết nối đến máy chủ,\ndo các nguyên nhân(máy chủ không tồn tại,\nphương thức kết nối không đúng,\nmáy chủ không cho phép truy cập từ xa).";
                    }
                    if (num == 201)
                    {
                        return string.Concat("Thủ tục hoặc chức năng ", function.ToUpper(), " đối số sử dụng không đúng.");
                    }
                }
                else
                {
                    if (num == -2)
                    {
                        return "Thời gian giao dịch quá lâu, vì an toàn kết nối đến tự động ngắt.";
                    }
                    if (num == 2)
                    {
                        return "Không thể kết nối với máy chủ Sql Server.";
                    }
                }
            }
            else if (num > 2812)
            {
                if (num == 4060)
                {
                    return "Không thể mở kết nối đến cở sở dữ liệu, Có thể cở sở dữ liệu này không tồn tại.";
                }
                if (num == 8146)
                {
                    return string.Concat("Thủ tục ", function.ToUpper(), " không có đối số.");
                }
                if (num == 18456)
                {
                    return "Không thể đăng nhập vào máy chủ Sql Server với tài khoản này.\nCó thể tài khoản hoặc mật khẩu không đúng.";
                }
            }
            else
            {
                if (num == 233)
                {
                    return "Không thể thực hiện yêu cầu máy chủ mở giao dịch.";
                }
                if (num == 2812)
                {
                    return string.Concat("Không tìm thấy thủ tục ", function.ToUpper(), ".\nCó thể cở sở dữ liệu này đã quá cũ vui lòng cập nhật mới.");
                }
            }
            if (message.Length > 0)
            {
                int num1 = message.IndexOf('\n');
                if (num1 != -1)
                {
                    message = message.Substring(0, num1);
                }
            }
            return message;
        }

        //public string Encrypt()
        //{
        //    return this.Encrypt(this._connectionString, "!@#$%^&*()Pofd154$#@");
        //}

        //public string Encrypt(string connectstring, string password)
        //{
        //    this._connectionString = connectstring;
        //    if (this._connection == null)
        //    {
        //        this._connection = new SqlConnection();
        //    }
        //   // return MyEncryption.Encrypt(connectstring, password, true);
        //}

        public DataSet ExecuteDataSet(string commandText, string[] myParams, object[] myValues)
        {
            DataSet dataSet = null;
            if (!this.m_useTransaction)
            {
                if (this.Open() == "OK")
                {
                    dataSet = this.ExecuteDataSet(this._connection, commandText, myParams, myValues);
                }
                this.Close();
            }
            else
            {
                this.Result = this.Start();
                if (this.Result != "OK")
                {
                    this.RollBack();
                    return dataSet;
                }
                dataSet = this.ExecuteDataSet(this._transaction, commandText, myParams, myValues);
                if (this.Result == "OK")
                {
                    this.Commit();
                }
            }
            return dataSet;
        }

        public DataSet ExecuteDataSet(string commandText)
        {
            return this.ExecuteDataSet(commandText, null, null);
        }

        public DataSet ExecuteDataSet(SqlConnection myConnection, string commandText, string[] myParams, object[] myValues)
        {
            return this.ExecuteDataSet(myConnection, this.CommandType, commandText, myParams, myValues);
        }

        public DataSet ExecuteDataSet(SqlConnection myConnection, CommandType commandType, string commandText, string[] myParams, object[] myValues)
        {
            if (myConnection == null)
            {
                throw new SqlHelperException("myConnection");
            }
            if (myConnection.State != ConnectionState.Open)
            {
                throw new SqlHelperException("Connnection is close");
            }
            if (string.IsNullOrEmpty(commandText))
            {
                throw new SqlHelperException("commandText");
            }
            bool flag = false;
            if (myParams != null & myValues != null)
            {
                flag = true;
                if ((int)myParams.Length != (int)myValues.Length)
                {
                    throw new SqlHelperException("Parameter count does not match Parameter Value count.");
                }
            }
            this.Result = "";
            DataSet dataSet = new DataSet();
            SqlCommand sqlCommand = myConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            sqlCommand.Connection = myConnection;
            sqlCommand.CommandType = commandType;
            if (flag)
            {
                for (int i = 0; i < (int)myParams.Length; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(myParams[i], myValues[i]);
                    sqlCommand.Parameters.Add(sqlParameter);
                }
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                this.Rowaffected = sqlDataAdapter.Fill(dataSet);
                if (this.AutoCommand)
                {
                    this.CommandType = CommandType.StoredProcedure;
                }
                return dataSet;
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                this.Close(myConnection);
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = this.DispError(sqlException.Number, string.Concat("Không thể được lấy dữ liệu.\nChi tiết:\n\t", sqlException.Message), commandText);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.Close(myConnection);
                this.Result = (SqlHelper._HideError ? string.Concat("Không thể được lấy dữ liệu.\nChi tiết:\n\t", exception.Message) : exception.Message);
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return dataSet;
        }

        public DataSet ExecuteDataSet(SqlConnection myConnection, string commandText)
        {
            return this.ExecuteDataSet(myConnection, commandText, null, null);
        }

        public DataSet ExecuteDataSet(SqlTransaction myTransaction, string commandText, string[] myParams, object[] myValues)
        {
            return this.ExecuteDataSet(myTransaction, this.CommandType, commandText, myParams, myValues);
        }

        public DataSet ExecuteDataSet(SqlTransaction myTransaction, CommandType commandType, string commandText, string[] myParams, object[] myValues)
        {
            if (myTransaction == null)
            {
                throw new SqlHelperException("myTransaction");
            }
            if (string.IsNullOrEmpty(commandText))
            {
                throw new SqlHelperException("commandText");
            }
            if (myTransaction.Connection == null)
            {
                throw new SqlHelperException("The transaction was rollbacked or commited, please provide an open transaction.");
            }
            bool flag = false;
            if (myParams != null & myValues != null)
            {
                flag = true;
                if ((int)myParams.Length != (int)myValues.Length)
                {
                    throw new SqlHelperException("Parameter count does not match Parameter Value count.");
                }
            }
            this.Result = "";
            DataSet dataSet = new DataSet();
            SqlCommand connection = myTransaction.Connection.CreateCommand();
            connection.CommandText = commandText;
            connection.Connection = myTransaction.Connection;
            connection.Transaction = myTransaction;
            connection.CommandType = commandType;
            if (flag)
            {
                for (int i = 0; i < (int)myParams.Length; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(myParams[i], myValues[i]);
                    connection.Parameters.Add(sqlParameter);
                }
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(connection);
            try
            {
                this.Rowaffected = sqlDataAdapter.Fill(dataSet);
                if (this.AutoCommand)
                {
                    this.CommandType = CommandType.StoredProcedure;
                }
                return dataSet;
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                this.RollBack(myTransaction);
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = this.DispError(sqlException.Number, string.Concat("Không thể được lấy dữ liệu.\nChi tiết:\n\t", sqlException.Message), commandText);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.RollBack(myTransaction);
                this.Result = (SqlHelper._HideError ? string.Concat("Không thể được lấy dữ liệu.\nChi tiết:\n\t", exception.Message) : exception.Message);
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return dataSet;
        }

        public DataSet ExecuteDataSet(SqlTransaction myTransaction, string commandText)
        {
            return this.ExecuteDataSet(myTransaction, commandText, null, null);
        }

        public DataTable ExecuteDataTable(string commandText, string[] myParams, object[] myValues)
        {
            DataTable dataTable = null;
            if (!this.m_useTransaction)
            {
                if (this.Open() == "OK")
                {
                    dataTable = this.ExecuteDataTable(this._connection, commandText, myParams, myValues);
                }
                this.Close();
            }
            else
            {
                this.Result = this.Start();
                if (this.Result != "OK")
                {
                    this.RollBack();
                    return dataTable;
                }
                dataTable = this.ExecuteDataTable(this._transaction, commandText, myParams, myValues);
                if (this.Result == "OK")
                {
                    this.Commit();
                }
            }
            return dataTable;
        }

        public DataTable ExecuteDataTable(string commandText)
        {
            return this.ExecuteDataTable(commandText, null, null);
        }

        public DataTable ExecuteDataTable(SqlConnection myConnection, string commandText, string[] myParams, object[] myValues)
        {
            return this.ExecuteDataTable(myConnection, this.CommandType, commandText, myParams, myValues);
        }

        public DataTable ExecuteDataTable(SqlConnection myConnection, CommandType commandType, string commandText, string[] myParams, object[] myValues)
        {
            if (myConnection == null)
            {
                throw new SqlHelperException("myConnection");
            }
            if (myConnection.State != ConnectionState.Open)
            {
                throw new SqlHelperException("Connnection is close");
            }
            if (string.IsNullOrEmpty(commandText))
            {
                throw new SqlHelperException("commandText");
            }
            bool flag = false;
            if (myParams != null & myValues != null)
            {
                flag = true;
                if ((int)myParams.Length != (int)myValues.Length)
                {
                    throw new SqlHelperException("Parameter count does not match Parameter Value count.");
                }
            }
            this.Result = "";
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = myConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            sqlCommand.Connection = myConnection;
            sqlCommand.CommandType = commandType;
            sqlCommand.CommandTimeout = 0;
            if (flag)
            {
                for (int i = 0; i < (int)myParams.Length; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(myParams[i], myValues[i]);
                    sqlCommand.Parameters.Add(sqlParameter);
                }
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                this.Rowaffected = sqlDataAdapter.Fill(dataTable);
                if (this.AutoCommand)
                {
                    this.CommandType = CommandType.StoredProcedure;
                }
                return dataTable;
            }
            catch (InvalidOperationException invalidOperationException1)
            {
                InvalidOperationException invalidOperationException = invalidOperationException1;
                this.Close(myConnection);
                this.Result = (SqlHelper._HideError ? string.Concat("Không thể được lấy dữ liệu.\nChi tiết:\n\t", invalidOperationException.Message) : invalidOperationException.Message);
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                this.Close(myConnection);
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = this.DispError(sqlException.Number, string.Concat("Không thể được lấy dữ liệu.\nChi tiết:\n\t", sqlException.Message), commandText);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.Close(myConnection);
                this.Result = (SqlHelper._HideError ? string.Concat("Không thể được lấy dữ liệu.\nChi tiết:\n\t", exception.Message) : exception.Message);
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return dataTable;
        }

        public DataTable ExecuteDataTable(SqlConnection myConnection, string commandText)
        {
            return this.ExecuteDataTable(myConnection, commandText, null, null);
        }

        public DataTable ExecuteDataTable(SqlTransaction myTransaction, string commandText, string[] myParams, object[] myValues)
        {
            return this.ExecuteDataTable(myTransaction, this.CommandType, commandText, myParams, myValues);
        }

        public DataTable ExecuteDataTable(SqlTransaction myTransaction, CommandType commandType, string commandText, string[] myParams, object[] myValues)
        {
            if (myTransaction == null)
            {
                throw new SqlHelperException("myTransaction");
            }
            if (string.IsNullOrEmpty(commandText))
            {
                throw new ArgumentNullException("commandText");
            }
            if (myTransaction != null && myTransaction.Connection == null)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            bool flag = false;
            if (myParams != null & myValues != null)
            {
                flag = true;
                if ((int)myParams.Length != (int)myValues.Length)
                {
                    throw new ArgumentException("Parameter count does not match Parameter Value count.");
                }
            }
            this.Result = "";
            DataTable dataTable = new DataTable();
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = commandText,
                Connection = myTransaction.Connection,
                Transaction = myTransaction,
                CommandType = commandType,
                CommandTimeout = 0
            };
            if (flag)
            {
                for (int i = 0; i < (int)myParams.Length; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(myParams[i], myValues[i]);
                    sqlCommand.Parameters.Add(sqlParameter);
                }
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                this.Rowaffected = sqlDataAdapter.Fill(dataTable);
                if (this.AutoCommand)
                {
                    this.CommandType = CommandType.StoredProcedure;
                }
                return dataTable;
            }
            catch (InvalidOperationException invalidOperationException1)
            {
                InvalidOperationException invalidOperationException = invalidOperationException1;
                this.RollBack(myTransaction);
                this.Result = (SqlHelper._HideError ? string.Concat("Không thể được lấy dữ liệu.\nChi tiết:\n\t", invalidOperationException.Message) : invalidOperationException.Message);
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                this.RollBack(myTransaction);
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = this.DispError(sqlException.Number, string.Concat("Không thể được lấy dữ liệu.\nChi tiết:\n\t", sqlException.Message), commandText);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.RollBack(myTransaction);
                this.Result = (SqlHelper._HideError ? string.Concat("Không thể được lấy dữ liệu.\nChi tiết:\n\t", exception.Message) : exception.Message);
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return dataTable;
        }

        public DataTable ExecuteDataTable(SqlTransaction myTransaction, string commandText)
        {
            return this.ExecuteDataTable(myTransaction, commandText, null, null);
        }

        public string ExecuteNonQuery(string commandText)
        {
            return this.ExecuteNonQuery(commandText, null, null);
        }

        public string ExecuteNonQuery(string commandText, string[] myParams, object[] myValues)
        {
            if (!this.m_useTransaction)
            {
                this.Result = this.Open();
                if (this.Result == "OK")
                {
                    this.Result = this.ExecuteNonQuery(this._connection, commandText, myParams, myValues);
                }
                this.Close();
            }
            else
            {
                this.Result = this.Start();
                if (this.Result != "OK")
                {
                    this.RollBack();
                    return this.Result;
                }
                this.Result = this.ExecuteNonQuery(this._transaction, commandText, myParams, myValues);
                if (this.Result == "OK")
                {
                    this.Result = this.Commit();
                }
            }
            return this.Result;
        }

        public string ExecuteNonQuery(string[] commandTexts)
        {
            this.Result = "Không thực hiện được";
            if (this.Open() == "OK")
            {
                this.Result = this.Start();
                if (this.Result != "OK")
                {
                    this.RollBack();
                    return this.Result;
                }
                for (int i = 0; i < (int)commandTexts.Length; i++)
                {
                    this.Result = this.ExecuteNonQuery(this._transaction, commandTexts[i]);
                    if (this.Result != "OK")
                    {
                        this.RollBack();
                        return this.Result;
                    }
                }
                this.Commit();
            }
            return this.Result;
        }

        public string ExecuteNonQuery(SqlTransaction myTransaction, string[] commandTexts)
        {
            string str = "Không thực hiện được";
            for (int i = 0; i < (int)commandTexts.Length; i++)
            {
                str = this.ExecuteNonQuery(myTransaction, commandTexts[i]);
                if (str != "OK")
                {
                    this.RollBack(myTransaction);
                    return str;
                }
            }
            return str;
        }

        public string ExecuteNonQuery(SqlTransaction myTransaction, CommandType commandType, StringCollection commandTexts)
        {
            string item = "OK";
            for (int i = 0; i < commandTexts.Count; i++)
            {
                this.CommandType = commandType;
                item = commandTexts[i];
                if (item != "")
                {
                    item = this.ExecuteNonQuery(myTransaction, item);
                    if (item != "OK")
                    {
                        this.RollBack(myTransaction);
                        return item;
                    }
                }
            }
            return item;
        }

        public string ExecuteNonQuery(StringCollection commandTexts)
        {
            return this.ExecuteNonQuery(commandTexts, false);
        }

        public string ExecuteNonQuery(StringCollection commandTexts, bool isTransaction)
        {
            this.Result = "Không thực hiện được";
            if (commandTexts == null)
            {
                throw new SqlHelperException("Null object", 0);
            }
            if (commandTexts.Count == 0)
            {
                return "OK";
            }
            if (this.Open() == "OK")
            {
                if (!isTransaction)
                {
                    for (int i = 0; i < commandTexts.Count; i++)
                    {
                        this.Result = this.ExecuteNonQuery(this._connection, commandTexts[i]);
                        if (this.Result != "OK")
                        {
                            return this.Result;
                        }
                    }
                }
                else
                {
                    this.Result = this.Start();
                    if (this.Result != "OK")
                    {
                        this.RollBack();
                        return this.Result;
                    }
                    for (int j = 0; j < commandTexts.Count; j++)
                    {
                        this.Result = this.ExecuteNonQuery(this._transaction, commandTexts[j]);
                        if (this.Result != "OK")
                        {
                            this.RollBack();
                            return this.Result;
                        }
                    }
                    this.Commit();
                }
            }
            return this.Result;
        }

        public string ExecuteNonQuery(SqlConnection myConnection, string commandText, string[] myParams, object[] myValues)
        {
            return this.ExecuteNonQuery(myConnection, this.CommandType, commandText, myParams, myValues);
        }

        public string ExecuteNonQuery(SqlConnection myConnection, CommandType commandType, string commandText, string[] myParams, object[] myValues)
        {
            this.Result = "";
            if (myConnection == null)
            {
                throw new SqlHelperException("Connection is null");
            }
            if (string.IsNullOrEmpty(commandText))
            {
                throw new SqlHelperException("commandText");
            }
            if (myConnection.State != ConnectionState.Open)
            {
                throw new SqlHelperException("Connnection is close");
            }
            bool flag = false;
            if (myParams != null & myValues != null)
            {
                flag = true;
                if ((int)myParams.Length != (int)myValues.Length)
                {
                    throw new SqlHelperException("Parameter count does not match Parameter Value count.");
                }
            }
            SqlCommand sqlCommand = myConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            sqlCommand.Connection = myConnection;
            sqlCommand.CommandType = commandType;
            sqlCommand.CommandTimeout = 0;
            if (flag)
            {
                for (int i = 0; i < (int)myParams.Length; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(myParams[i], myValues[i]);
                    sqlCommand.Parameters.Add(sqlParameter);
                }
            }
            try
            {
                this.Rowaffected = sqlCommand.ExecuteNonQuery();
                this.Result = "OK";
                if (this.AutoCommand)
                {
                    this.CommandType = CommandType.StoredProcedure;
                }
                return this.Result;
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                this.Close(myConnection);
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = this.DispError(sqlException.Number, string.Concat("Không thể thực hiện tác vụ này.\nChi tiết:\n\t", sqlException.Message), commandText);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.Close(myConnection);
                if (!SqlHelper._HideError)
                {
                    this.Result = exception.Message;
                }
                else
                {
                    this.Result = string.Concat("Không thể thực hiện tác vụ này.\nChi tiết:\n\t", exception.Message);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return this.Result;
        }

        public string ExecuteNonQuery(string connectionString, string commandText, string[] myParams, object[] myValues)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException("connectionString");
            }
            this._connectionString = connectionString;
            return this.ExecuteNonQuery(commandText, myParams, myValues);
        }

        public string ExecuteNonQuery(SqlConnection myConnection, string commandText)
        {
            return this.ExecuteNonQuery(myConnection, commandText, null, null);
        }

        public string ExecuteNonQuery(SqlTransaction myTransaction, string commandText, string[] myParams, object[] myValues)
        {
            return this.ExecuteNonQuery(myTransaction, this.CommandType, commandText, myParams, myValues);
        }

        public string ExecuteNonQuery(SqlTransaction myTransaction, CommandType commandType, string commandText, string[] myParams, object[] myValues)
        {
            if (myTransaction == null)
            {
                throw new SqlHelperException("Transaction is null");
            }
            if (commandText == null)
            {
                throw new SqlHelperException("commandText");
            }
            if (myTransaction != null && myTransaction.Connection == null)
            {
                throw new SqlHelperException("The transaction was rollbacked or commited, please provide an open transaction.");
            }
            bool flag = false;
            if (myParams != null & myValues != null)
            {
                flag = true;
                if ((int)myParams.Length != (int)myValues.Length)
                {
                    throw new SqlHelperException("Parameter count does not match Parameter Value count.");
                }
            }
            SqlCommand connection = myTransaction.Connection.CreateCommand();
            connection.CommandText = commandText;
            connection.Connection = myTransaction.Connection;
            connection.Transaction = myTransaction;
            connection.CommandType = commandType;
            connection.CommandTimeout = 0;
            if (flag)
            {
                for (int i = 0; i < (int)myParams.Length; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(myParams[i], myValues[i]);
                    connection.Parameters.Add(sqlParameter);
                }
            }
            try
            {
                this.Rowaffected = connection.ExecuteNonQuery();
                this.Result = "OK";
                if (this.AutoCommand)
                {
                    this.CommandType = CommandType.StoredProcedure;
                }
                return this.Result;
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                this.RollBack(myTransaction);
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = this.DispError(sqlException.Number, string.Concat("Không thể thực hiện tác vụ này.\nChi tiết:\n\t", sqlException.Message), commandText);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.RollBack(myTransaction);
                if (!SqlHelper._HideError)
                {
                    this.Result = exception.Message;
                }
                else
                {
                    this.Result = string.Concat("Không thể thực hiện tác vụ này.\nChi tiết:\n\t", exception.Message);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return this.Result;
        }

        public string ExecuteNonQuery(SqlTransaction myTransaction, string commandText)
        {
            return this.ExecuteNonQuery(myTransaction, commandText, null, null);
        }

        public SqlDataReader ExecuteReader(string commandText)
        {
            return this.ExecuteReader(commandText, null, null);
        }

        public SqlDataReader ExecuteReader(SqlConnection myConnection, string commandText)
        {
            return this.ExecuteReader(myConnection, commandText, null, null);
        }

        public SqlDataReader ExecuteReader(SqlTransaction myTransaction, string commandText)
        {
            return this.ExecuteReader(myTransaction, commandText, null, null);
        }

        public SqlDataReader ExecuteReader(string commandText, string[] myParams, object[] myValues)
        {
            SqlDataReader sqlDataReader = null;
            if (this.m_useTransaction)
            {
                this.Result = this.Start();
                if (this.Result != "OK")
                {
                    this.RollBack();
                    return sqlDataReader;
                }
                sqlDataReader = this.ExecuteReader(this._transaction, commandText, myParams, myValues);
                if (this.Result == "OK")
                {
                    this.Commit();
                }
            }
            else if (this.Open() == "OK")
            {
                sqlDataReader = this.ExecuteReader(this._connection, commandText, myParams, myValues);
            }
            return sqlDataReader;
        }

        public SqlDataReader ExecuteReader(SqlConnection myConnection, string commandText, string[] myParams, object[] myValues)
        {
            return this.ExecuteReader(myConnection, this.CommandType, commandText, myParams, myValues);
        }

        public SqlDataReader ExecuteReader(SqlConnection myConnection, CommandType commandType, string commandText, string[] myParams, object[] myValues)
        {
            if (myConnection == null)
            {
                throw new SqlHelperException("myConnection");
            }
            if (myConnection.State != ConnectionState.Open)
            {
                throw new SqlHelperException("Connnection is close");
            }
            if (string.IsNullOrEmpty(commandText))
            {
                throw new SqlHelperException("commandText");
            }
            bool flag = false;
            if (myParams != null & myValues != null)
            {
                flag = true;
                if ((int)myParams.Length != (int)myValues.Length)
                {
                    throw new SqlHelperException("Parameter count does not match Parameter Value count.");
                }
            }
            SqlCommand sqlCommand = myConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            sqlCommand.Connection = myConnection;
            sqlCommand.CommandType = commandType;
            sqlCommand.CommandTimeout = 0;
            if (flag)
            {
                for (int i = 0; i < (int)myParams.Length; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(myParams[i], myValues[i]);
                    sqlCommand.Parameters.Add(sqlParameter);
                }
            }
            try
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (this.AutoCommand)
                {
                    this.CommandType = CommandType.StoredProcedure;
                }
                return sqlDataReader;
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                this.Close(myConnection);
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = this.DispError(sqlException.Number, string.Concat("Không lấy được dữ liệu.\nChi tiết:\n\t", sqlException.Message), commandText);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.Close(myConnection);
                if (!SqlHelper._HideError)
                {
                    this.Result = exception.Message;
                }
                else
                {
                    this.Result = string.Concat("Không lấy được dữ liệu.\nChi tiết:\n\t", exception.Message);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return null;
        }

        public SqlDataReader ExecuteReader(SqlTransaction myTransaction, string commandText, string[] myParams, object[] myValues)
        {
            return this.ExecuteReader(myTransaction, this.CommandType, commandText, myParams, myValues);
        }

        public SqlDataReader ExecuteReader(SqlTransaction myTransaction, CommandType commandType, string commandText, string[] myParams, object[] myValues)
        {
            if (myTransaction == null)
            {
                throw new SqlHelperException("myTransaction");
            }
            if (commandText == null)
            {
                throw new SqlHelperException("commandText");
            }
            if (myTransaction != null && myTransaction.Connection == null)
            {
                throw new SqlHelperException("The transaction was rollbacked or commited, please provide an open transaction.");
            }
            bool flag = false;
            if (myParams != null & myValues != null)
            {
                flag = true;
                if ((int)myParams.Length != (int)myValues.Length)
                {
                    throw new ArgumentException("Parameter count does not match Parameter Value count.");
                }
            }
            SqlCommand connection = myTransaction.Connection.CreateCommand();
            connection.CommandText = commandText;
            connection.Connection = myTransaction.Connection;
            connection.Transaction = myTransaction;
            connection.CommandType = commandType;
            connection.CommandTimeout = 0;
            if (flag)
            {
                for (int i = 0; i < (int)myParams.Length; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(myParams[i], myValues[i]);
                    connection.Parameters.Add(sqlParameter);
                }
            }
            try
            {
                SqlDataReader sqlDataReader = connection.ExecuteReader();
                if (this.AutoCommand)
                {
                    this.CommandType = CommandType.StoredProcedure;
                }
                return sqlDataReader;
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                this.RollBack(myTransaction);
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = this.DispError(sqlException.Number, string.Concat("Không lấy được dữ liệu.\nChi tiết:\n\t", sqlException.Message), commandText);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.RollBack(myTransaction);
                if (!SqlHelper._HideError)
                {
                    this.Result = exception.Message;
                }
                else
                {
                    this.Result = string.Concat("Không lấy được dữ liệu.\nChi tiết:\n\t", exception.Message);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return null;
        }

        public object ExecuteScalar(string commandText)
        {
            return this.ExecuteScalar(commandText, null, null);
        }

        public int ExecuteScalar(string commandText, int defautValue)
        {
            object obj = this.ExecuteScalar(commandText);
            if (obj == null)
            {
                return defautValue;
            }
            return Convert.ToInt32(obj);
        }

        public double ExecuteScalar(string commandText, double defautValue)
        {
            object obj = this.ExecuteScalar(commandText);
            if (obj == null)
            {
                return defautValue;
            }
            return Convert.ToDouble(obj);
        }

        public decimal ExecuteScalar(string commandText, decimal defautValue)
        {
            object obj = this.ExecuteScalar(commandText);
            if (obj == null)
            {
                return defautValue;
            }
            return Convert.ToDecimal(obj);
        }

        public string ExecuteScalar(string commandText, string defautValue)
        {
            object obj = this.ExecuteScalar(commandText);
            if (obj == null)
            {
                return defautValue;
            }
            return Convert.ToString(obj);
        }

        public object ExecuteScalar(SqlTransaction myTransaction, string commandText)
        {
            return this.ExecuteScalar(myTransaction, commandText, null, null);
        }

        public int ExecuteScalar(SqlTransaction myTransaction, string commandText, int defautValue)
        {
            return this.ExecuteScalar(myTransaction, commandText, null, null, defautValue);
        }

        public double ExecuteScalar(SqlTransaction myTransaction, string commandText, double defautValue)
        {
            return this.ExecuteScalar(myTransaction, commandText, null, null, defautValue);
        }

        public string ExecuteScalar(SqlTransaction myTransaction, string commandText, string defautValue)
        {
            return this.ExecuteScalar(myTransaction, commandText, null, null, defautValue);
        }

        public object ExecuteScalar(SqlConnection myConnection, string commandText)
        {
            return this.ExecuteScalar(myConnection, commandText, null, null);
        }

        public int ExecuteScalar(SqlConnection myConnection, string commandText, int defaultValue)
        {
            object obj = this.ExecuteScalar(myConnection, commandText);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToInt32(obj);
        }

        public double ExecuteScalar(SqlConnection myConnection, string commandText, double defaultValue)
        {
            object obj = this.ExecuteScalar(myConnection, commandText);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToDouble(obj);
        }

        public string ExecuteScalar(SqlConnection myConnection, string commandText, string defaultValue)
        {
            object obj = this.ExecuteScalar(myConnection, commandText);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToString(obj);
        }

        public object ExecuteScalar(string commandText, string[] myParams, object[] myValues)
        {
            object obj = null;
            if (!this.m_useTransaction)
            {
                if (this.Open() == "OK")
                {
                    obj = this.ExecuteScalar(this._connection, commandText, myParams, myValues);
                }
                this.Close();
            }
            else
            {
                this.Result = this.Start();
                if (this.Result != "OK")
                {
                    this.RollBack();
                    return obj;
                }
                obj = this.ExecuteScalar(this._transaction, commandText, myParams, myValues);
                if (this.Result == "OK")
                {
                    this.Commit();
                }
            }
            return obj;
        }

        public int ExecuteScalar(string commandText, string[] myParams, object[] myValues, int defaultValue)
        {
            object obj = this.ExecuteScalar(commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToInt32(obj);
        }

        public double ExecuteScalar(string commandText, string[] myParams, object[] myValues, double defaultValue)
        {
            object obj = this.ExecuteScalar(commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToDouble(obj);
        }

        public decimal ExecuteScalar(string commandText, string[] myParams, object[] myValues, decimal defaultValue)
        {
            object obj = this.ExecuteScalar(commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToDecimal(obj);
        }

        public string ExecuteScalar(string commandText, string[] myParams, object[] myValues, string defaultValue)
        {
            object obj = this.ExecuteScalar(commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToString(obj);
        }

        public object ExecuteScalar(SqlConnection myConnection, string commandText, string[] myParams, object[] myValues)
        {
            return this.ExecuteScalar(myConnection, this.CommandType, commandText, myParams, myValues);
        }

        private object ExecuteScalar(SqlConnection myConnection, CommandType commandType, string commandText, string[] myParams, object[] myValues)
        {
            if (myConnection == null)
            {
                throw new SqlHelperException("myConnection");
            }
            if (string.IsNullOrEmpty(commandText))
            {
                throw new SqlHelperException("commandText");
            }
            if (myConnection.State != ConnectionState.Open)
            {
                throw new SqlHelperException("Connnection is close");
            }
            bool flag = false;
            if (myParams != null & myValues != null)
            {
                flag = true;
                if ((int)myParams.Length != (int)myValues.Length)
                {
                    throw new SqlHelperException("Parameter count does not match Parameter Value count.");
                }
            }
            object obj = null;
            this.Result = "";
            SqlCommand sqlCommand = myConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            sqlCommand.Connection = myConnection;
            sqlCommand.CommandType = commandType;
            if (flag)
            {
                for (int i = 0; i < (int)myParams.Length; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(myParams[i], myValues[i]);
                    sqlCommand.Parameters.Add(sqlParameter);
                }
            }
            try
            {
                obj = sqlCommand.ExecuteScalar();
                if (obj != null && obj == DBNull.Value)
                {
                    obj = null;
                }
                if (this.AutoCommand)
                {
                    this.CommandType = CommandType.StoredProcedure;
                }
                return obj;
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                this.Close(myConnection);
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = string.Concat("Không lấy được dữ liệu.\nChi tiết:\n\t", sqlException.Message);
                    this.Result = this.DispError(sqlException.Number, this.Result, commandText);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.Close(myConnection);
                if (!SqlHelper._HideError)
                {
                    this.Result = exception.Message;
                }
                else
                {
                    this.Result = string.Concat("Không lấy được dữ liệu.\nChi tiết:\n\t", exception.Message);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return obj;
        }

        public int ExecuteScalar(SqlConnection myConnection, string commandText, string[] myParams, object[] myValues, int defaultValue)
        {
            object obj = this.ExecuteScalar(myConnection, commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToInt32(obj);
        }

        public double ExecuteScalar(SqlConnection myConnection, string commandText, string[] myParams, object[] myValues, double defaultValue)
        {
            object obj = this.ExecuteScalar(myConnection, commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToDouble(obj);
        }

        public decimal ExecuteScalar(SqlConnection myConnection, string commandText, string[] myParams, object[] myValues, decimal defaultValue)
        {
            object obj = this.ExecuteScalar(myConnection, commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToDecimal(obj);
        }

        public string ExecuteScalar(SqlConnection myConnection, string commandText, string[] myParams, object[] myValues, string defaultValue)
        {
            object obj = this.ExecuteScalar(myConnection, commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToString(obj);
        }

        public object ExecuteScalar(SqlTransaction myTransaction, string commandText, string[] myParams, object[] myValues)
        {
            return this.ExecuteScalar(myTransaction, this.CommandType, commandText, myParams, myValues);
        }

        public object ExecuteScalar(SqlTransaction myTransaction, CommandType commandType, string commandText, string[] myParams, object[] myValues)
        {
            if (myTransaction == null)
            {
                throw new SqlHelperException("myTransaction");
            }
            if (commandText == null)
            {
                throw new SqlHelperException("commandText");
            }
            if (myTransaction != null && myTransaction.Connection == null)
            {
                throw new SqlHelperException("The transaction was rollbacked or commited, please provide an open transaction.");
            }
            bool flag = false;
            if (myParams != null & myValues != null)
            {
                flag = true;
                if ((int)myParams.Length != (int)myValues.Length)
                {
                    throw new ArgumentException("Parameter count does not match Parameter Value count.");
                }
            }
            this.Result = "";
            object obj = null;
            SqlCommand connection = myTransaction.Connection.CreateCommand();
            connection.CommandText = commandText;
            connection.Connection = myTransaction.Connection;
            connection.Transaction = myTransaction;
            connection.CommandType = commandType;
            if (flag)
            {
                for (int i = 0; i < (int)myParams.Length; i++)
                {
                    SqlParameter sqlParameter = new SqlParameter(myParams[i], myValues[i]);
                    connection.Parameters.Add(sqlParameter);
                }
            }
            try
            {
                obj = connection.ExecuteScalar();
                if (obj != null && obj == DBNull.Value)
                {
                    obj = null;
                }
                if (this.AutoCommand)
                {
                    this.CommandType = CommandType.StoredProcedure;
                }
                return obj;
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                this.RollBack(myTransaction);
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = string.Concat("Không lấy được dữ liệu.\nChi tiết:\n\t", sqlException.Message);
                    this.Result = this.DispError(sqlException.Number, this.Result, commandText);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.RollBack(myTransaction);
                if (!SqlHelper._HideError)
                {
                    this.Result = exception.Message;
                }
                else
                {
                    this.Result = string.Concat("Không lấy được dữ liệu.\nChi tiết:\n\t", exception.Message);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return obj;
        }

        public int ExecuteScalar(SqlTransaction myTraTransaction, string commandText, string[] myParams, object[] myValues, int defaultValue)
        {
            object obj = this.ExecuteScalar(myTraTransaction, commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToInt32(obj);
        }

        public double ExecuteScalar(SqlTransaction myTraTransaction, string commandText, string[] myParams, object[] myValues, double defaultValue)
        {
            object obj = this.ExecuteScalar(myTraTransaction, commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToDouble(obj);
        }

        public decimal ExecuteScalar(SqlTransaction myTraTransaction, string commandText, string[] myParams, object[] myValues, decimal defaultValue)
        {
            object obj = this.ExecuteScalar(myTraTransaction, commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToDecimal(obj);
        }

        public string ExecuteScalar(SqlTransaction myTraTransaction, string commandText, string[] myParams, object[] myValues, string defaultValue)
        {
            object obj = this.ExecuteScalar(myTraTransaction, commandText, myParams, myValues);
            if (obj == null)
            {
                return defaultValue;
            }
            return Convert.ToString(obj);
        }

        public long ExecuteScalar2(SqlTransaction myTransaction, string commandText, int defautValue)
        {
            return this.ExecuteScalar2(myTransaction, commandText, null, null, defautValue);
        }

        public long ExecuteScalar2(string commandText, string[] myParams, object[] myValues, int defaultValue)
        {
            object obj = this.ExecuteScalar(commandText, myParams, myValues);
            if (obj != null)
            {
                return Convert.ToInt64(obj);
            }
            return (long)defaultValue;
        }

        public long ExecuteScalar2(SqlTransaction myTraTransaction, string commandText, string[] myParams, object[] myValues, int defaultValue)
        {
            object obj = this.ExecuteScalar(myTraTransaction, commandText, myParams, myValues);
            if (obj != null)
            {
                return Convert.ToInt64(obj);
            }
            return (long)defaultValue;
        }

        public string Exists(string expression)
        {
            this.Result = "Cơ sở dữ liệu đã tồn tại.";
            string str = string.Concat("DECLARE @return_value int if EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'", expression, "') set @return_value =1 else set @return_value =0 select @return_value");
            this.CommandType = CommandType.Text;
            object obj = this.ExecuteScalar(str);
            if (obj != Convert.DBNull && Convert.ToInt32(obj) == 0)
            {
                this.Result = "OK";
            }
            return this.Result;
        }

        public void Extract()
        {
            this._authentication = SqlHelper.IsAuthe(this._connectionString);
            if (this._authentication)
            {
                this._server = SqlHelper.GetItem("data source=", this._connectionString);
                this._database = SqlHelper.GetItem("initial catalog=", this._connectionString);
                return;
            }
            this._server = SqlHelper.GetItem("server=", this._connectionString);
            this._database = SqlHelper.GetItem("database=", this._connectionString);
            this._userid = SqlHelper.GetItem("user id=", this._connectionString);
            this._password = SqlHelper.GetItem("password=", this._connectionString);
        }

        ~SqlHelper()
        {
            SqlHelper.Count = SqlHelper.Count - 1;
            this.Close();
            if (this._transaction != null && this._transaction.Connection != null)
            {
                try
                {
                    if (this._transaction.Connection.State == ConnectionState.Open)
                    {
                        this._transaction.Connection.Close();
                    }
                    this._transaction.Rollback();
                    this._transaction = null;
                }
                catch (Exception exception)
                {
                }
            }
        }

        public static string GenCode(string tableName, string columnName, string fKey)
        {
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            string str = "";
            string[] strArrays = new string[] { "select max([", columnName, "]) from [", tableName, "] where [", columnName, "] like N'", fKey, "%'" };
            object obj = sqlHelper.ExecuteScalar(string.Concat(strArrays));
            str = (obj == null ? "0" : obj.ToString());
            if (fKey.Length != 0)
            {
                str = str.Replace(fKey, "").Trim();
            }
            int num = 0;
            if (SqlHelper.IsNumeric(str))
            {
                num = (int)Conversion.Val(str);
            }
            num++;
            string str1 = num.ToString();
            while (str1.Length < 6)
            {
                str1 = string.Concat("0", str1);
            }
            return string.Concat(fKey, str1);
        }

        public static string GenCode(string tableName, string columnName, string fKey, int NumberZero)
        {
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            string str = "";
            string[] strArrays = new string[] { "select max([", columnName, "]) from [", tableName, "] where [", columnName, "] like N'", fKey, "%'" };
            object obj = sqlHelper.ExecuteScalar(string.Concat(strArrays));
            str = (obj == null ? "0" : obj.ToString());
            if (fKey.Length != 0)
            {
                str = str.Replace(fKey, "").Trim();
            }
            int num = 0;
            if (SqlHelper.IsNumeric(str))
            {
                num = (int)Conversion.Val(str);
            }
            num++;
            string str1 = num.ToString();
            while (str1.Length < NumberZero)
            {
                str1 = string.Concat("0", str1);
            }
            return string.Concat(fKey, str1);
        }

        public static string GenCode(string fKey)
        {
            return SqlHelper.GenCode("TRANS_REF", "RefID", fKey);
        }

        public static string GenCode(SqlHelper mySql, string fKey)
        {
            return SqlHelper.GenCode(mySql, "TRANS_REF", "RefID", fKey);
        }

        public static string GenCode(SqlHelper mySql, string tableName, string columnName, string fKey)
        {
            return SqlHelper.GenCode(mySql.Transaction, tableName, columnName, fKey);
        }

        public static string GenCode(SqlTransaction myTransaction, string tableName, string columnName, string fKey)
        {
            if (myTransaction == null)
            {
                throw new ArgumentNullException("transaction");
            }
            if (myTransaction != null && myTransaction.Connection == null)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            string[] strArrays = new string[] { "select max(", columnName, ") from [", tableName, "] where [", columnName, "] like N'", fKey, "%'" };
            object obj = sqlHelper.ExecuteScalar(myTransaction, string.Concat(strArrays));
            string str = (obj == null ? "0" : obj.ToString());
            if (fKey.Length != 0)
            {
                str = str.Replace(fKey, "").Trim();
            }
            int num = 0;
            if (Information.IsNumeric(str))
            {
                num = (int)Conversion.Val(str);
            }
            num++;
            string str1 = num.ToString();
            while (str1.Length < 6)
            {
                str1 = string.Concat("0", str1);
            }
            return string.Concat(fKey, str1);
        }

        public static string GenCode(SqlTransaction myTransaction, string fKey)
        {
            return SqlHelper.GenCode(myTransaction, "TRANS_REF", "RefID", fKey);
        }

        private static string GetItem(string getStr, string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new SqlHelperException((SqlHelper._HideError ? "Chưa cấu hình chuỗi kết nối." : "Connecttion String is fail."));
            }
            string lower = data.ToLower();
            int length = lower.IndexOf(getStr);
            if (length == -1)
            {
                return string.Empty;
            }
            length += getStr.Length;
            int num = lower.IndexOf(';', length) - length;
            return data.Substring(length, num).Trim();
        }

        private static bool IsAuthe(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new SqlHelperException((!SqlHelper._HideError ? "Connecttion String is fail." : "Chưa cấu hình chuỗi kết nối."));
            }
            if (data.ToLower().IndexOf("data source=") != -1)
            {
                return true;
            }
            return false;
        }

        public static bool IsNumeric(object expression)
        {
            double num;
            bool flag = double.TryParse(Convert.ToString(expression), NumberStyles.Any, (IFormatProvider)NumberFormatInfo.InvariantInfo, out num);
            return flag;
        }

        public static void LoadConnectString()
        {
            if (System.Configuration.ConfigurationManager.AppSettings != null)
            {
                if (System.Configuration.ConfigurationManager.AppSettings["connectionString"] == null)
                {
                    return;
                }
                SqlHelper._GlobalConnectString = System.Configuration.ConfigurationManager.AppSettings["connectionString"].ToString(); //"server='CHUTINH-ITC\\';database='HRMExample'; User Id='chuttinh'; Password = 'Cutinh'";//
            }
        }

        public string Open()
        {
            this.RaiseConnectEventHander();
            if (string.IsNullOrEmpty(this._connectionString))
            {
                throw new SqlHelperException("connectionString");
            }
            if (this._connection == null)
            {
                this._connection = new SqlConnection(this._connectionString);
            }
            return  this.Open(this._connection);
        }

        public string Open(SqlConnection myConnection)
        {
            if (myConnection == null)
            {
                throw new SqlHelperException("myConnection");
            }
            this.RaiseConnectEventHander();
            if (myConnection.State == ConnectionState.Open)
            {
                return this.Result;
            }
            try
            {
                if (string.IsNullOrEmpty(this._connectionString))
                {
                    throw new SqlHelperException("_connectionString");
                }
                myConnection.ConnectionString = this._connectionString;
                myConnection.Open();
                this.RaiseConnectedEventHander(myConnection);
                this.Result = "OK";
                return this.Result;
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = string.Concat("Không thể kết nối với máy chủ.\nChi tiết:\n\t", sqlException.Message);
                    this.Result = this.DispError(sqlException.Number, this.Result, "");
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                if (!SqlHelper._HideError)
                {
                    this.Result = exception.Message;
                }
                else
                {
                    this.Result = string.Concat("Không thể kết nối với máy chủ.\nChi tiết:\n\t", exception.Message);
                    this.Result = this.DispError(-1, this.Result, "");
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return this.Result;
        }

        private void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, out bool mustCloseConnection)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (commandText == null || commandText.Length == 0)
            {
                throw new ArgumentNullException("commandText");
            }
            if (connection.State == ConnectionState.Open)
            {
                mustCloseConnection = false;
            }
            else
            {
                mustCloseConnection = true;
                connection.Open();
            }
            command.Connection = connection;
            command.CommandText = commandText;
            if (transaction != null)
            {
                if (transaction.Connection == null)
                {
                    throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
                }
                command.Transaction = transaction;
            }
            command.CommandType = commandType;
            if (commandParameters != null)
            {
                SqlHelper.AttachParameters(command, commandParameters);
            }
        }

        private void RaiseConnectedEventHander(SqlConnection e)
        {
            if (this.Connected != null)
            {
                this.Connected(this, e);
            }
        }

        private void RaiseConnectEventHander()
        {
            if (this.Connect != null)
            {
                this.Connect(this);
            }
        }

        private void RaiseErrorEventHander(SqlHelperException e)
        {
            if (this.Error != null)
            {
                this.Error(this, e);
            }
        }

        private void RaiseTransactionClosedEventHander()
        {
            if (this.TransactionClosed != null)
            {
                this.TransactionClosed(this);
            }
        }

        private void RaiseTransactionCompletedEventHander(TransactionEventArgs e)
        {
            if (this.TransactionCompleted != null)
            {
                this.TransactionCompleted(this, e);
            }
        }

        private void RaiseTransactionEventHander()
        {
            if (this.TransactionStart != null)
            {
                this.TransactionStart(this);
            }
        }

        private void RaiseTransactionStartedEventHander(TransactionEventArgs e)
        {
            if (this.TransactionStarted != null)
            {
                this.TransactionStarted(this, e);
            }
        }

        public string RebuildConnectionString()
        {
            return this.RebuildConnectionString(this._server, this._database, this._userid, this._password, this._authentication);
        }

        public string RebuildConnectionString(string server, string database, string user, string password, bool authentication)
        {
            if (authentication)
            {
                if (database == "")
                {
                    return string.Concat("Data Source=", server, ";Initial Catalog=master;Integrated Security=True;");
                }
                string[] strArrays = new string[] { "Data Source=", server, ";Initial Catalog=", database, ";Integrated Security=True;" };
                return string.Concat(strArrays);
            }
            if (database == "")
            {
                string[] strArrays1 = new string[] { "server=", server, ";database=master;user id= ", user, " ;password=", password, ";" };
                return string.Concat(strArrays1);
            }
            string[] strArrays2 = new string[] { "server=", server, ";database=", database, ";user id= ", user, " ;password=", password, ";" };
            return string.Concat(strArrays2);
        }

        public string RebuildConnectionString(string server, string user, string password)
        {
            return this.RebuildConnectionString(server, "", user, password, false);
        }

        public string RebuildConnectionString(string server)
        {
            return this.RebuildConnectionString(server, "", "", "", true);
        }

        public string RebuildConnectionString(string server, string database)
        {
            return this.RebuildConnectionString(server, database, "", "", true);
        }

        public string RollBack()
        {
            return this.RollBack(this._transaction);
        }

        public string RollBack(SqlTransaction myTransaction)
        {
            string result;
            this.Result = "";
            if (this._transaction == null)
            {
                if (!SqlHelper._HideError)
                {
                    this.Result = "Don't has Transaction created.";
                }
                else
                {
                    this.Result = "Giao dịch chưa được khởi tạo.";
                }
                this.Close();
                return this.Result;
            }
            try
            {
                try
                {
                    if (myTransaction.Connection != null)
                    {
                        myTransaction.Rollback();
                    }
                    myTransaction.Dispose();
                    myTransaction = null;
                    this.Result = "OK";
                    result = this.Result;
                    return result;
                }
                catch (SqlException sqlException1)
                {
                    SqlException sqlException = sqlException1;
                    if (!SqlHelper._HideError)
                    {
                        this.Result = sqlException.Message;
                    }
                    else
                    {
                        this.Result = string.Concat("Không thể khôi phục giao dịch.\nChi tiết:\n\t", sqlException.Message);
                    }
                    this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    if (!SqlHelper._HideError)
                    {
                        this.Result = exception.Message;
                    }
                    else
                    {
                        this.Result = string.Concat("Không thể khôi phục giao dịch.\nChi tiết:\n\t", exception.Message);
                    }
                    this.RaiseErrorEventHander(new SqlHelperException(this.Result));
                }
                return this.Result;
            }
            finally
            {
                this.Close();
            }
            return result;
        }

        public void SaveMyConfig()
        {
            MyConfig myConfig = new MyConfig();
            if (this._authentication)
            {
                string[] strArrays = new string[] { "Data Source=", this._server, ";Initial Catalog=", this._database, ";Integrated Security=True;" };
                myConfig.SetValue("//appSettings//add[@key='connectionString']", string.Concat(strArrays));
                string str = string.Concat("Data Source=", this._server, ";Initial Catalog=Master;Integrated Security=True;");
                myConfig.SetValue("//appSettings//add[@key='ConnectionRestore']", str);
                return;
            }
            string[] strArrays1 = new string[] { "server=", this._server, ";database=", this._database, ";user id= ", this._userid, " ;password=", this._password, ";" };
            myConfig.SetValue("//appSettings//add[@key='connectionString']", string.Concat(strArrays1));
            string[] strArrays2 = new string[] { "server=", this._server, ";database=Master;user id= ", this._userid, " ;password=", this._password, ";" };
            myConfig.SetValue("//appSettings//add[@key='ConnectionRestore']", string.Concat(strArrays2));
        }

        public string Start()
        {
            this.Result = this.Open();
            if (this.Result != "OK")
            {
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
                return this.Result;
            }
            try
            {
                this.RaiseTransactionEventHander();
                this._transaction = this._connection.BeginTransaction();
                this.RaiseTransactionStartedEventHander(new TransactionEventArgs());
                this.Result = "OK";
                return this.Result;
            }
            catch (SqlException sqlException1)
            {
                SqlException sqlException = sqlException1;
                if (!SqlHelper._HideError)
                {
                    this.Result = sqlException.Message;
                }
                else
                {
                    this.Result = this.DispError(sqlException.Number, string.Concat("Không thể khởi tạo giao dịch.\nChi tiết:\n\t", sqlException.Message), "");
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result, sqlException.Number));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                if (!SqlHelper._HideError)
                {
                    this.Result = exception.Message;
                }
                else
                {
                    this.Result = string.Concat("Không thể khởi tạo giao dịch.\nChi tiết:\n\t", exception.Message);
                }
                this.RaiseErrorEventHander(new SqlHelperException(this.Result));
            }
            return this.Result;
        }



        public override string ToString()
        {
            return this._connectionString;
        }

        public event SqlHelper.ConnectEventHander Connect;

        public event SqlHelper.ConnectedEventHander Connected;

        public event SqlHelper.ErrorEventHander Error;

        public event SqlHelper.TransactionClosedEventHander TransactionClosed;

        public event TransactionCompletedEventHandler TransactionCompleted;

        public event SqlHelper.TransactionEventHander TransactionStart;

        public event TransactionStartedEventHandler TransactionStarted;

        public delegate void ConnectedEventHander(object sender, SqlConnection e);

        public delegate void ConnectEventHander(object sender);

        public delegate void ErrorEventHander(object sender, SqlHelperException e);

        public delegate void Execute(object sender, int Percent);

        public delegate void Executed(object sender);

        public delegate void ExecuteStart(object sender);

        public delegate void TransactionClosedEventHander(object sender);

        public delegate void TransactionEventHander(object sender);
    }
}
