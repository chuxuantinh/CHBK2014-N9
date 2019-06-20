using CHBK2014_N9.Data.Helper;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.HumanResource.Core.Machine
{
   public class HRM_TIMEKEEPER_MACHINE
    {

        private Guid m_ID;

        private string m_EnrollNumber;

        private DateTime m_Date;

        private DateTime m_Hour;

        private int m_StateInOut;

        private string m_MachineID;

        public string Copyright
        {
            get
            {
                return "BKSOFT";
            }
        }

        public DateTime Date
        {
            get
            {
                return this.m_Date;
            }
            set
            {
                this.m_Date = value;
            }
        }

        public string EnrollNumber
        {
            get
            {
                return this.m_EnrollNumber;
            }
            set
            {
                this.m_EnrollNumber = value;
            }
        }

        public DateTime Hour
        {
            get
            {
                return this.m_Hour;
            }
            set
            {
                this.m_Hour = value;
            }
        }

        public Guid ID
        {
            get
            {
                return this.m_ID;
            }
            set
            {
                this.m_ID = value;
            }
        }

        public string MachineID
        {
            get
            {
                return this.m_MachineID;
            }
            set
            {
                this.m_MachineID = value;
            }
        }

        public string Product
        {
            get
            {
                return "Class HRM_TIMEKEEPER_MACHINE";
            }
        }

        public int StateInOut
        {
            get
            {
                return this.m_StateInOut;
            }
            set
            {
                this.m_StateInOut = value;
            }
        }

        public string Version
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public HRM_TIMEKEEPER_MACHINE()
        {
            this.m_ID = Guid.Empty;
            this.m_EnrollNumber = "";
            this.m_Date = DateTime.Now;
            this.m_Hour = DateTime.Now;
            this.m_StateInOut = 0;
            this.m_MachineID = "";
        }

        public HRM_TIMEKEEPER_MACHINE(Guid ID, string EnrollNumber, DateTime Date, DateTime Hour, int StateInOut, string MachineID)
        {
            this.m_ID = ID;
            this.m_EnrollNumber = EnrollNumber;
            this.m_Date = Date;
            this.m_Hour = Hour;
            this.m_StateInOut = StateInOut;
            this.m_MachineID = MachineID;
        }

        public string CreateKey()
        {
            return this.CreateKey("");
        }

        public string CreateKey(string key)
        {
            return SqlHelper.GenCode(key);
        }

        public string CreateKey(SqlTransaction myTransaction, string key)
        {
            return SqlHelper.GenCode(myTransaction, key);
        }

        public string CreateKey(SqlTransaction myTransaction)
        {
            return SqlHelper.GenCode(myTransaction, "");
        }

        public DataTable CreateNullDataTable()
        {
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("ID");
            DataColumn dataColumn1 = new DataColumn("EnrollNumber");
            DataColumn dataColumn2 = new DataColumn("EmployeeCode");
            DataColumn dataColumn3 = new DataColumn("EmployeeName");
            DataColumn dataColumn4 = new DataColumn("Date", Type.GetType("System.DateTime"));
            DataColumn dataColumn5 = new DataColumn("Hour", Type.GetType("System.DateTime"));
            DataColumn dataColumn6 = new DataColumn("StateInOut");
            DataColumn dataColumn7 = new DataColumn("MachineID");
            dataTable.Columns.Add(dataColumn);
            dataTable.Columns.Add(dataColumn1);
            dataTable.Columns.Add(dataColumn2);
            dataTable.Columns.Add(dataColumn3);
            dataTable.Columns.Add(dataColumn4);
            dataTable.Columns.Add(dataColumn5);
            dataTable.Columns.Add(dataColumn6);
            dataTable.Columns.Add(dataColumn7);
            return dataTable;
        }

        public static DataTable CreateNullEmployeesDataTable()
        {
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("EnrollNumber");
            dataTable.Columns.Add(dataColumn);
            dataTable.Clear();
            return dataTable;
        }

        public string Delete(Guid ID)
        {
            string[] strArrays = new string[] { "@ID" };
            object[] d = new object[] { ID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_MACHINE_Delete", strArrays, d);
        }

        public string Delete(SqlConnection myConnection, string ID)
        {
            string[] strArrays = new string[] { "@ID" };
            object[] d = new object[] { ID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_TIMEKEEPER_MACHINE_Delete", strArrays, d);
        }

        public string Delete(SqlTransaction myTransaction, string ID)
        {
            string[] strArrays = new string[] { "@ID" };
            object[] d = new object[] { ID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_MACHINE_Delete", strArrays, d);
        }

        public string DeleteAll()
        {
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_MACHINE_DeleteAll");
        }

        public bool Exist()
        {
            return this.Exist(this.m_ID);
        }

        public bool Exist(SqlTransaction myTransaction)
        {
            return this.Exist(myTransaction, this.m_ID);
        }

        public bool Exist(Guid ID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ID" };
            object[] d = new object[] { ID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("M_Machine_Get", strArrays, d);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool Exist(SqlTransaction myTransaction, Guid ID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ID" };
            object[] d = new object[] { ID };
            SqlDataReader sqlDataReader = (new SqlHelper()).ExecuteReader(myTransaction, "M_Machine_Get", strArrays, d);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get()
        {
            return this.Get(this.ID);
        }

        public string Get(SqlConnection myConnection)
        {
            return this.Get(myConnection, this.ID);
        }

        public string Get(SqlTransaction myTransaction)
        {
            return this.Get(myTransaction, this.ID);
        }

        public string Get(Guid ID)
        {
            string str = "";
            string[] strArrays = new string[] { "@ID" };
            object[] d = new object[] { ID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("M_Machine_Get", strArrays, d);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID"));
                    this.m_EnrollNumber = Convert.ToString(sqlDataReader["EnrollNumber"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Hour = Convert.ToDateTime(sqlDataReader["Hour"]);
                    this.m_StateInOut = Convert.ToInt32(sqlDataReader["StateInOut"]);
                    this.m_MachineID = Convert.ToString(sqlDataReader["MachineID"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlDataReader = null;
            }
            sqlHelper.Close();
            return str;
        }

        public string Get(SqlConnection myConnection, Guid ID)
        {
            string str = "";
            string[] strArrays = new string[] { "@ID" };
            object[] d = new object[] { ID };
            SqlDataReader sqlDataReader = (new SqlHelper()).ExecuteReader(myConnection, "M_Machine_Get", strArrays, d);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID"));
                    this.m_EnrollNumber = Convert.ToString(sqlDataReader["EnrollNumber"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Hour = Convert.ToDateTime(sqlDataReader["Hour"]);
                    this.m_StateInOut = Convert.ToInt32(sqlDataReader["StateInOut"]);
                    this.m_MachineID = Convert.ToString(sqlDataReader["MachineID"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid ID)
        {
            string str = "";
            string[] strArrays = new string[] { "@ID" };
            object[] d = new object[] { ID };
            SqlDataReader sqlDataReader = (new SqlHelper()).ExecuteReader(myTransaction, "M_Machine_Get", strArrays, d);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("ID"));
                    this.m_EnrollNumber = Convert.ToString(sqlDataReader["EnrollNumber"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Hour = Convert.ToDateTime(sqlDataReader["Hour"]);
                    this.m_StateInOut = Convert.ToInt32(sqlDataReader["StateInOut"]);
                    this.m_MachineID = Convert.ToString(sqlDataReader["MachineID"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetList()
        {
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_MACHINE_GetList");
        }

        public string Insert()
        {
            string str = this.Insert(this.m_ID, this.m_EnrollNumber, this.m_Date, this.m_Hour, this.m_StateInOut, this.m_MachineID);
            return str;
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string str = this.Insert(myTransaction, this.m_ID, this.m_EnrollNumber, this.m_Date, this.m_Hour, this.m_StateInOut, this.m_MachineID);
            return str;
        }

        public string Insert(SqlConnection myConnection)
        {
            string str = this.Insert(myConnection, this.m_ID, this.m_EnrollNumber, this.m_Date, this.m_Hour, this.m_StateInOut, this.m_MachineID);
            return str;
        }

        public string Insert(Guid ID, string EnrollNumber, DateTime Date, DateTime Hour, int StateInOut, string MachineID)
        {
            string[] strArrays = new string[] { "@ID", "@EnrollNumber", "@Date", "@Hour", "@StateInOut", "@MachineID" };
            string[] strArrays1 = strArrays;
            object[] d = new object[] { ID, EnrollNumber, Date, Hour, StateInOut, MachineID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_MACHINE_Insert", strArrays1, d);
        }

        public string Insert(SqlConnection myConnection, Guid ID, string EnrollNumber, DateTime Date, DateTime Hour, int StateInOut, string MachineID)
        {
            string[] strArrays = new string[] { "@ID", "@EnrollNumber", "@Date", "@Hour", "@StateInOut", "@MachineID" };
            string[] strArrays1 = strArrays;
            object[] d = new object[] { ID, EnrollNumber, Date, Hour, StateInOut, MachineID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_TIMEKEEPER_MACHINE_Insert", strArrays1, d);
        }

        public string Insert(SqlTransaction myTransaction, Guid ID, string EnrollNumber, DateTime Date, DateTime Hour, int StateInOut, string MachineID)
        {
            string[] strArrays = new string[] { "@ID", "@EnrollNumber", "@Date", "@Hour", "@StateInOut", "@MachineID" };
            string[] strArrays1 = strArrays;
            object[] d = new object[] { ID, EnrollNumber, Date, Hour, StateInOut, MachineID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_MACHINE_Insert", strArrays1, d);
        }

        public string NewID()
        {
            return this.NewID("");
        }

        public string NewID(string key)
        {
            return SqlHelper.GenCode("HRM_TIMEKEEPER_MACHINE", "HRM_TIMEKEEPER_MACHINEID", key);
        }

        public string SetShift(DateTime BeginDate, DateTime EndDate, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@BeginDate", "@EndDate", "@EmployeeCode" };
            object[] beginDate = new object[] { BeginDate, EndDate, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_MACHINE_SetShift", strArrays, beginDate);
        }

        public string UpdateTimeKeeper(DateTime BeginDate, DateTime EndDate, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@BeginDate", "@EndDate", "@EmployeeCode" };
            object[] beginDate = new object[] { BeginDate, EndDate, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_MACHINE_Update", strArrays, beginDate);
        }
    }
}
