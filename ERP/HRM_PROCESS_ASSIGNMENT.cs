using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ERP
{
public  class HRM_PROCESS_ASSIGNMENT
    {


        private Guid m_AssignmentID;

        private string m_EmployeeCode;

        private string m_AssignmentName;

        private string m_Reason;

        private string m_Where;

        private DateTime m_FromDate;

        private DateTime m_ToDate;

        private decimal m_Money;

        private decimal m_PayMoney;

        private decimal m_DebtMoney;

        private DateTime m_Date;

        private string m_DecideNumber;

        private string m_Person;

        private string m_FilePath;

        [Category("Primary Key")]
        [DisplayName("AssignmentID")]
        public Guid AssignmentID
        {
            get
            {
                return this.m_AssignmentID;
            }
            set
            {
                this.m_AssignmentID = value;
            }
        }

        [Category("Column")]
        [DisplayName("AssignmentName")]
        public string AssignmentName
        {
            get
            {
                return this.m_AssignmentName;
            }
            set
            {
                this.m_AssignmentName = value;
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
        [DisplayName("DebtMoney")]
        public decimal DebtMoney
        {
            get
            {
                return this.m_DebtMoney;
            }
            set
            {
                this.m_DebtMoney = value;
            }
        }

        [Category("Column")]
        [DisplayName("DecideNumber")]
        public string DecideNumber
        {
            get
            {
                return this.m_DecideNumber;
            }
            set
            {
                this.m_DecideNumber = value;
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
        [DisplayName("FilePath")]
        public string FilePath
        {
            get
            {
                return this.m_FilePath;
            }
            set
            {
                this.m_FilePath = value;
            }
        }

        [Category("Column")]
        [DisplayName("FromDate")]
        public DateTime FromDate
        {
            get
            {
                return this.m_FromDate;
            }
            set
            {
                this.m_FromDate = value;
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
        [DisplayName("PayMoney")]
        public decimal PayMoney
        {
            get
            {
                return this.m_PayMoney;
            }
            set
            {
                this.m_PayMoney = value;
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
                return "Class HRM_PROCESS_ASSIGNMENT";
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

        [Category("Column")]
        [DisplayName("ToDate")]
        public DateTime ToDate
        {
            get
            {
                return this.m_ToDate;
            }
            set
            {
                this.m_ToDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("Where")]
        public string Where
        {
            get
            {
                return this.m_Where;
            }
            set
            {
                this.m_Where = value;
            }
        }

        public HRM_PROCESS_ASSIGNMENT()
        {
            this.m_AssignmentID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_AssignmentName = "";
            this.m_Reason = "";
            this.m_Where = "";
            this.m_FromDate = DateTime.Now;
            this.m_ToDate = DateTime.Now;
            this.m_Money = new decimal(0);
            this.m_PayMoney = new decimal(0);
            this.m_DebtMoney = new decimal(0);
            this.m_Date = DateTime.Now;
            this.m_DecideNumber = "";
            this.m_Person = "";
            this.m_FilePath = "";
        }

        public HRM_PROCESS_ASSIGNMENT(Guid AssignmentID, string EmployeeCode, string AssignmentName, string Reason, string Where, DateTime FromDate, DateTime ToDate, decimal Money, decimal PayMoney, decimal DebtMoney, DateTime Date, string DecideNumber, string Person, string FilePath)
        {
            this.m_AssignmentID = AssignmentID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_AssignmentName = AssignmentName;
            this.m_Reason = Reason;
            this.m_Where = Where;
            this.m_FromDate = FromDate;
            this.m_ToDate = ToDate;
            this.m_Money = Money;
            this.m_PayMoney = PayMoney;
            this.m_DebtMoney = DebtMoney;
            this.m_Date = Date;
            this.m_DecideNumber = DecideNumber;
            this.m_Person = Person;
            this.m_FilePath = FilePath;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@AssignmentID" };
            object[] mAssignmentID = new object[] { this.m_AssignmentID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ASSIGNMENT_Delete", strArrays, mAssignmentID);
        }

        public string Delete(Guid AssignmentID)
        {
            string[] strArrays = new string[] { "@AssignmentID" };
            object[] assignmentID = new object[] { AssignmentID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ASSIGNMENT_Delete", strArrays, assignmentID);
        }

        public string Delete(SqlConnection myConnection, Guid AssignmentID)
        {
            string[] strArrays = new string[] { "@AssignmentID" };
            object[] assignmentID = new object[] { AssignmentID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_ASSIGNMENT_Delete", strArrays, assignmentID);
        }

        public string Delete(SqlTransaction myTransaction, Guid AssignmentID)
        {
            string[] strArrays = new string[] { "@AssignmentID" };
            object[] assignmentID = new object[] { AssignmentID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_ASSIGNMENT_Delete", strArrays, assignmentID);
        }

        public string DeleteByMonth(string EmployeeCode, int Month, int Year)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Month", "@Year" };
            object[] employeeCode = new object[] { EmployeeCode, Month, Year };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ASSIGNMENT_DeleteByMonth", strArrays, employeeCode);
        }

        public bool Exist(Guid AssignmentID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@AssignmentID" };
            object[] assignmentID = new object[] { AssignmentID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PROCESS_ASSIGNMENT_Get", strArrays, assignmentID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid AssignmentID)
        {
            string str = "";
            string[] strArrays = new string[] { "@AssignmentID" };
            object[] assignmentID = new object[] { AssignmentID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PROCESS_ASSIGNMENT_Get", strArrays, assignmentID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_AssignmentID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("AssignmentID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_AssignmentName = Convert.ToString(sqlDataReader["AssignmentName"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Where = Convert.ToString(sqlDataReader["Where"]);
                    this.m_FromDate = Convert.ToDateTime(sqlDataReader["FromDate"]);
                    this.m_ToDate = Convert.ToDateTime(sqlDataReader["ToDate"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_PayMoney = Convert.ToDecimal(sqlDataReader["PayMoney"]);
                    this.m_DebtMoney = Convert.ToDecimal(sqlDataReader["DebtMoney"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_DecideNumber = Convert.ToString(sqlDataReader["DecideNumber"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    this.m_FilePath = Convert.ToString(sqlDataReader["FilePath"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid AssignmentID)
        {
            string str = "";
            string[] strArrays = new string[] { "@AssignmentID" };
            object[] assignmentID = new object[] { AssignmentID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_PROCESS_ASSIGNMENT_Get", strArrays, assignmentID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_AssignmentID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("AssignmentID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_AssignmentName = Convert.ToString(sqlDataReader["AssignmentName"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Where = Convert.ToString(sqlDataReader["Where"]);
                    this.m_FromDate = Convert.ToDateTime(sqlDataReader["FromDate"]);
                    this.m_ToDate = Convert.ToDateTime(sqlDataReader["ToDate"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_PayMoney = Convert.ToDecimal(sqlDataReader["PayMoney"]);
                    this.m_DebtMoney = Convert.ToDecimal(sqlDataReader["DebtMoney"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_DecideNumber = Convert.ToString(sqlDataReader["DecideNumber"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    this.m_FilePath = Convert.ToString(sqlDataReader["FilePath"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid AssignmentID)
        {
            string str = "";
            string[] strArrays = new string[] { "@AssignmentID" };
            object[] assignmentID = new object[] { AssignmentID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_PROCESS_ASSIGNMENT_Get", strArrays, assignmentID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_AssignmentID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("AssignmentID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_AssignmentName = Convert.ToString(sqlDataReader["AssignmentName"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Where = Convert.ToString(sqlDataReader["Where"]);
                    this.m_FromDate = Convert.ToDateTime(sqlDataReader["FromDate"]);
                    this.m_ToDate = Convert.ToDateTime(sqlDataReader["ToDate"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_PayMoney = Convert.ToDecimal(sqlDataReader["PayMoney"]);
                    this.m_DebtMoney = Convert.ToDecimal(sqlDataReader["DebtMoney"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_DecideNumber = Convert.ToString(sqlDataReader["DecideNumber"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    this.m_FilePath = Convert.ToString(sqlDataReader["FilePath"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ASSIGNMENT_GetAllList", strArrays, objArray);
        }

        public DataTable GetAllListByDays(DateTime BeginDate, DateTime EndDate)
        {
            int level = MyLogin.Level;
            string code = MyLogin.Code;
            string[] strArrays = new string[] { "@Level", "@Code", "@BeginDate", "@EndDate" };
            object[] beginDate = new object[] { level, code, BeginDate, EndDate };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ASSIGNMENT_GetAllListByDays", strArrays, beginDate);
        }

        public DataTable GetList()
        {
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ASSIGNMENT_GetList");
        }

        public DataTable GetListByDays(string EmployeeCode, DateTime BeginDate, DateTime EndDate)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@BeginDate", "@EndDate" };
            object[] employeeCode = new object[] { EmployeeCode, BeginDate, EndDate };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ASSIGNMENT_GetListByDays", strArrays, employeeCode);
        }

        public DataTable GetListByEmployee(string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ASSIGNMENT_GetListByEmployee", strArrays, employeeCode);
        }

        public DataTable GetListByMonth(string EmployeeCode, int Month, int Year)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Month", "@Year" };
            object[] employeeCode = new object[] { EmployeeCode, Month, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_ASSIGNMENT_GetListByMonth", strArrays, employeeCode);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@AssignmentID", "@EmployeeCode", "@AssignmentName", "@Reason", "@Where", "@FromDate", "@ToDate", "@Money", "@PayMoney", "@DebtMoney", "@Date", "@DecideNumber", "@Person", "@FilePath" };
            string[] strArrays1 = strArrays;
            object[] mAssignmentID = new object[] { this.m_AssignmentID, this.m_EmployeeCode, this.m_AssignmentName, this.m_Reason, this.m_Where, this.m_FromDate, this.m_ToDate, this.m_Money, this.m_PayMoney, this.m_DebtMoney, this.m_Date, this.m_DecideNumber, this.m_Person, this.m_FilePath };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ASSIGNMENT_Insert", strArrays1, mAssignmentID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@AssignmentID", "@EmployeeCode", "@AssignmentName", "@Reason", "@Where", "@FromDate", "@ToDate", "@Money", "@PayMoney", "@DebtMoney", "@Date", "@DecideNumber", "@Person", "@FilePath" };
            string[] strArrays1 = strArrays;
            object[] mAssignmentID = new object[] { this.m_AssignmentID, this.m_EmployeeCode, this.m_AssignmentName, this.m_Reason, this.m_Where, this.m_FromDate, this.m_ToDate, this.m_Money, this.m_PayMoney, this.m_DebtMoney, this.m_Date, this.m_DecideNumber, this.m_Person, this.m_FilePath };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_ASSIGNMENT_Insert", strArrays1, mAssignmentID);
        }

        public string Insert(Guid AssignmentID, string EmployeeCode, string AssignmentName, string Reason, string Where, DateTime FromDate, DateTime ToDate, decimal Money, decimal PayMoney, decimal DebtMoney, DateTime Date, string DecideNumber, string Person, string FilePath)
        {
            string[] strArrays = new string[] { "@AssignmentID", "@EmployeeCode", "@AssignmentName", "@Reason", "@Where", "@FromDate", "@ToDate", "@Money", "@PayMoney", "@DebtMoney", "@Date", "@DecideNumber", "@Person", "@FilePath" };
            string[] strArrays1 = strArrays;
            object[] assignmentID = new object[] { AssignmentID, EmployeeCode, AssignmentName, Reason, Where, FromDate, ToDate, Money, PayMoney, DebtMoney, Date, DecideNumber, Person, FilePath };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ASSIGNMENT_Insert", strArrays1, assignmentID);
        }

        public string Insert(SqlConnection myConnection, Guid AssignmentID, string EmployeeCode, string AssignmentName, string Reason, string Where, DateTime FromDate, DateTime ToDate, decimal Money, decimal PayMoney, decimal DebtMoney, DateTime Date, string DecideNumber, string Person, string FilePath)
        {
            string[] strArrays = new string[] { "@AssignmentID", "@EmployeeCode", "@AssignmentName", "@Reason", "@Where", "@FromDate", "@ToDate", "@Money", "@PayMoney", "@DebtMoney", "@Date", "@DecideNumber", "@Person", "@FilePath" };
            string[] strArrays1 = strArrays;
            object[] assignmentID = new object[] { AssignmentID, EmployeeCode, AssignmentName, Reason, Where, FromDate, ToDate, Money, PayMoney, DebtMoney, Date, DecideNumber, Person, FilePath };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_ASSIGNMENT_Insert", strArrays1, assignmentID);
        }

        public string Insert(SqlTransaction myTransaction, Guid AssignmentID, string EmployeeCode, string AssignmentName, string Reason, string Where, DateTime FromDate, DateTime ToDate, decimal Money, decimal PayMoney, decimal DebtMoney, DateTime Date, string DecideNumber, string Person, string FilePath)
        {
            string[] strArrays = new string[] { "@AssignmentID", "@EmployeeCode", "@AssignmentName", "@Reason", "@Where", "@FromDate", "@ToDate", "@Money", "@PayMoney", "@DebtMoney", "@Date", "@DecideNumber", "@Person", "@FilePath" };
            string[] strArrays1 = strArrays;
            object[] assignmentID = new object[] { AssignmentID, EmployeeCode, AssignmentName, Reason, Where, FromDate, ToDate, Money, PayMoney, DebtMoney, Date, DecideNumber, Person, FilePath };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_ASSIGNMENT_Insert", strArrays1, assignmentID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_PROCESS_ASSIGNMENT", "JobCode", "CV");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@AssignmentID", "@EmployeeCode", "@AssignmentName", "@Reason", "@Where", "@FromDate", "@ToDate", "@Money", "@PayMoney", "@DebtMoney", "@Date", "@DecideNumber", "@Person", "@FilePath" };
            string[] strArrays1 = strArrays;
            object[] mAssignmentID = new object[] { this.m_AssignmentID, this.m_EmployeeCode, this.m_AssignmentName, this.m_Reason, this.m_Where, this.m_FromDate, this.m_ToDate, this.m_Money, this.m_PayMoney, this.m_DebtMoney, this.m_Date, this.m_DecideNumber, this.m_Person, this.m_FilePath };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ASSIGNMENT_Update", strArrays1, mAssignmentID);
        }

        public string Update(Guid AssignmentID, string EmployeeCode, string AssignmentName, string Reason, string Where, DateTime FromDate, DateTime ToDate, decimal Money, decimal PayMoney, decimal DebtMoney, DateTime Date, string DecideNumber, string Person, string FilePath)
        {
            string[] strArrays = new string[] { "@AssignmentID", "@EmployeeCode", "@AssignmentName", "@Reason", "@Where", "@FromDate", "@ToDate", "@Money", "@PayMoney", "@DebtMoney", "@Date", "@DecideNumber", "@Person", "@FilePath" };
            string[] strArrays1 = strArrays;
            object[] assignmentID = new object[] { AssignmentID, EmployeeCode, AssignmentName, Reason, Where, FromDate, ToDate, Money, PayMoney, DebtMoney, Date, DecideNumber, Person, FilePath };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_ASSIGNMENT_Update", strArrays1, assignmentID);
        }

        public string Update(SqlConnection myConnection, Guid AssignmentID, string EmployeeCode, string AssignmentName, string Reason, string Where, DateTime FromDate, DateTime ToDate, decimal Money, decimal PayMoney, decimal DebtMoney, DateTime Date, string DecideNumber, string Person, string FilePath)
        {
            string[] strArrays = new string[] { "@AssignmentID", "@EmployeeCode", "@AssignmentName", "@Reason", "@Where", "@FromDate", "@ToDate", "@Money", "@PayMoney", "@DebtMoney", "@Date", "@DecideNumber", "@Person", "@FilePath" };
            string[] strArrays1 = strArrays;
            object[] assignmentID = new object[] { AssignmentID, EmployeeCode, AssignmentName, Reason, Where, FromDate, ToDate, Money, PayMoney, DebtMoney, Date, DecideNumber, Person, FilePath };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_ASSIGNMENT_Update", strArrays1, assignmentID);
        }

        public string Update(SqlTransaction myTransaction, Guid AssignmentID, string EmployeeCode, string AssignmentName, string Reason, string Where, DateTime FromDate, DateTime ToDate, decimal Money, decimal PayMoney, decimal DebtMoney, DateTime Date, string DecideNumber, string Person, string FilePath)
        {
            string[] strArrays = new string[] { "@AssignmentID", "@EmployeeCode", "@AssignmentName", "@Reason", "@Where", "@FromDate", "@ToDate", "@Money", "@PayMoney", "@DebtMoney", "@Date", "@DecideNumber", "@Person", "@FilePath" };
            string[] strArrays1 = strArrays;
            object[] assignmentID = new object[] { AssignmentID, EmployeeCode, AssignmentName, Reason, Where, FromDate, ToDate, Money, PayMoney, DebtMoney, Date, DecideNumber, Person, FilePath };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_ASSIGNMENT_Update", strArrays1, assignmentID);
        }



    }
}
