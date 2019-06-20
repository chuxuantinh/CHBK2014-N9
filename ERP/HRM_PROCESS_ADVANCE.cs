using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ERP
{
  public  class HRM_PROCESS_ADVANCE
    {

        private Guid m_AdvanceID;

        private string m_EmployeeCode;

        private string m_Reason;

        private DateTime m_Date;

        private decimal m_Money;

        private string m_Person;

        [Category("Primary Key")]
        [DisplayName("AdvanceID")]
        public Guid AdvanceID
        {
            get
            {
                return this.m_AdvanceID;
            }
            set
            {
                this.m_AdvanceID = value;
            }
        }

        [Category("Column")]
        [DisplayName("Date")]
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

        [Category("Column")]
        [DisplayName("EmployeeCode")]
        public string EmployeeCode
        {
            get
            {
                return this.m_EmployeeCode;
            }
            set
            {
                this.m_EmployeeCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("Money")]
        public decimal Money
        {
            get
            {
                return this.m_Money;
            }
            set
            {
                this.m_Money = value;
            }
        }

        [Category("Column")]
        [DisplayName("Person")]
        public string Person
        {
            get
            {
                return this.m_Person;
            }
            set
            {
                this.m_Person = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_PROCESS_ADVANCE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        [Category("Column")]
        [DisplayName("Reason")]
        public string Reason
        {
            get
            {
                return this.m_Reason;
            }
            set
            {
                this.m_Reason = value;
            }
        }

        public HRM_PROCESS_ADVANCE()
        {
            this.m_AdvanceID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_Reason = "";
            this.m_Date = DateTime.Now;
            this.m_Money = new decimal(0);
            this.m_Person = "";
        }

        public HRM_PROCESS_ADVANCE(Guid AdvanceID, string EmployeeCode, string Reason, DateTime Date, decimal Money, string Person)
        {
            this.m_AdvanceID = AdvanceID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_Reason = Reason;
            this.m_Date = Date;
            this.m_Money = Money;
            this.m_Person = Person;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@AdvanceID" };
            object[] mAdvanceID = new object[] { this.m_AdvanceID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ADVANCE_Delete", strArrays, mAdvanceID);
        }

        public string Delete(Guid AdvanceID)
        {
            string[] strArrays = new string[] { "@AdvanceID" };
            object[] advanceID = new object[] { AdvanceID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ADVANCE_Delete", strArrays, advanceID);
        }

        public string Delete(SqlConnection myConnection, Guid AdvanceID)
        {
            string[] strArrays = new string[] { "@AdvanceID" };
            object[] advanceID = new object[] { AdvanceID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_ADVANCE_Delete", strArrays, advanceID);
        }

        public string Delete(SqlTransaction myTransaction, Guid AdvanceID)
        {
            string[] strArrays = new string[] { "@AdvanceID" };
            object[] advanceID = new object[] { AdvanceID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_ADVANCE_Delete", strArrays, advanceID);
        }

        public string DeleteByMonth(string EmployeeCode, int Month, int Year)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Month", "@Year" };
            object[] employeeCode = new object[] { EmployeeCode, Month, Year };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ADVANCE_DeleteByMonth", strArrays, employeeCode);
        }

        public bool Exist(Guid AdvanceID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@AdvanceID" };
            object[] advanceID = new object[] { AdvanceID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PROCESS_ADVANCE_Get", strArrays, advanceID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid AdvanceID)
        {
            string str = "";
            string[] strArrays = new string[] { "@AdvanceID" };
            object[] advanceID = new object[] { AdvanceID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PROCESS_ADVANCE_Get", strArrays, advanceID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_AdvanceID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("AdvanceID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid AdvanceID)
        {
            string str = "";
            string[] strArrays = new string[] { "@AdvanceID" };
            object[] advanceID = new object[] { AdvanceID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_PROCESS_ADVANCE_Get", strArrays, advanceID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_AdvanceID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("AdvanceID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid AdvanceID)
        {
            string str = "";
            string[] strArrays = new string[] { "@AdvanceID" };
            object[] advanceID = new object[] { AdvanceID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_PROCESS_ADVANCE_Get", strArrays, advanceID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_AdvanceID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("AdvanceID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetAllList()
        {
            int level = MyLogin.Level;
            string code = MyLogin.Code;
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] objArray = new object[] { level, code };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ADVANCE_GetAllList", strArrays, objArray);
        }

        public DataTable GetAllListByDays(DateTime BeginDate, DateTime EndDate)
        {
            int level = MyLogin.Level;
            string code = MyLogin.Code;
            string[] strArrays = new string[] { "@Level", "@Code", "@BeginDate", "@EndDate" };
            object[] beginDate = new object[] { level, code, BeginDate, EndDate };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ADVANCE_GetAllListByDays", strArrays, beginDate);
        }

        public DataTable GetList()
        {
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ADVANCE_GetList");
        }

        public DataTable GetListByDays(string EmployeeCode, DateTime BeginDate, DateTime EndDate)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@BeginDate", "@EndDate" };
            object[] employeeCode = new object[] { EmployeeCode, BeginDate, EndDate };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ADVANCE_GetListByDays", strArrays, employeeCode);
        }

        public DataTable GetListByEmployee(string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ADVANCE_GetListByEmployee", strArrays, employeeCode);
        }

        public DataTable GetListByMonth(string EmployeeCode, int Month, int Year)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Month", "@Year" };
            object[] employeeCode = new object[] { EmployeeCode, Month, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ADVANCE_GetListByMonth", strArrays, employeeCode);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@AdvanceID", "@EmployeeCode", "@Reason", "@Date", "@Money", "@Person" };
            string[] strArrays1 = strArrays;
            object[] mAdvanceID = new object[] { this.m_AdvanceID, this.m_EmployeeCode, this.m_Reason, this.m_Date, this.m_Money, this.m_Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ADVANCE_Insert", strArrays1, mAdvanceID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@AdvanceID", "@EmployeeCode", "@Reason", "@Date", "@Money", "@Person" };
            string[] strArrays1 = strArrays;
            object[] mAdvanceID = new object[] { this.m_AdvanceID, this.m_EmployeeCode, this.m_Reason, this.m_Date, this.m_Money, this.m_Person };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_ADVANCE_Insert", strArrays1, mAdvanceID);
        }

        public string Insert(Guid AdvanceID, string EmployeeCode, string Reason, DateTime Date, decimal Money, string Person)
        {
            string[] strArrays = new string[] { "@AdvanceID", "@EmployeeCode", "@Reason", "@Date", "@Money", "@Person" };
            string[] strArrays1 = strArrays;
            object[] advanceID = new object[] { AdvanceID, EmployeeCode, Reason, Date, Money, Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ADVANCE_Insert", strArrays1, advanceID);
        }

        public string Insert(SqlConnection myConnection, Guid AdvanceID, string EmployeeCode, string Reason, DateTime Date, decimal Money, string Person)
        {
            string[] strArrays = new string[] { "@AdvanceID", "@EmployeeCode", "@Reason", "@Date", "@Money", "@Person" };
            string[] strArrays1 = strArrays;
            object[] advanceID = new object[] { AdvanceID, EmployeeCode, Reason, Date, Money, Person };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_ADVANCE_Insert", strArrays1, advanceID);
        }

        public string Insert(SqlTransaction myTransaction, Guid AdvanceID, string EmployeeCode, string Reason, DateTime Date, decimal Money, string Person)
        {
            string[] strArrays = new string[] { "@AdvanceID", "@EmployeeCode", "@Reason", "@Date", "@Money", "@Person" };
            string[] strArrays1 = strArrays;
            object[] advanceID = new object[] { AdvanceID, EmployeeCode, Reason, Date, Money, Person };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_ADVANCE_Insert", strArrays1, advanceID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_PROCESS_ADVANCE", "JobCode", "CV");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@AdvanceID", "@EmployeeCode", "@Reason", "@Date", "@Money", "@Person" };
            string[] strArrays1 = strArrays;
            object[] mAdvanceID = new object[] { this.m_AdvanceID, this.m_EmployeeCode, this.m_Reason, this.m_Date, this.m_Money, this.m_Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ADVANCE_Update", strArrays1, mAdvanceID);
        }

        public string Update(Guid AdvanceID, string EmployeeCode, string Reason, DateTime Date, decimal Money, string Person)
        {
            string[] strArrays = new string[] { "@AdvanceID", "@EmployeeCode", "@Reason", "@Date", "@Money", "@Person" };
            string[] strArrays1 = strArrays;
            object[] advanceID = new object[] { AdvanceID, EmployeeCode, Reason, Date, Money, Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ADVANCE_Update", strArrays1, advanceID);
        }

        public string Update(SqlConnection myConnection, Guid AdvanceID, string EmployeeCode, string Reason, DateTime Date, decimal Money, string Person)
        {
            string[] strArrays = new string[] { "@AdvanceID", "@EmployeeCode", "@Reason", "@Date", "@Money", "@Person" };
            string[] strArrays1 = strArrays;
            object[] advanceID = new object[] { AdvanceID, EmployeeCode, Reason, Date, Money, Person };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_ADVANCE_Update", strArrays1, advanceID);
        }

        public string Update(SqlTransaction myTransaction, Guid AdvanceID, string EmployeeCode, string Reason, DateTime Date, decimal Money, string Person)
        {
            string[] strArrays = new string[] { "@AdvanceID", "@EmployeeCode", "@Reason", "@Date", "@Money", "@Person" };
            string[] strArrays1 = strArrays;
            object[] advanceID = new object[] { AdvanceID, EmployeeCode, Reason, Date, Money, Person };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_ADVANCE_Update", strArrays1, advanceID);
        }
    }
}
