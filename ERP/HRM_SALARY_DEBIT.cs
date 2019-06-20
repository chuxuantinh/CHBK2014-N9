using DevExpress.XtraEditors;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Data.Helper;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
 public   class HRM_SALARY_DEBIT
    {

        private Guid m_SalaryTableListID;

        private string m_EmployeeCode;

        private Guid m_SalaryDebitID;

        private string m_Reason;

        private DateTime m_Date;

        private decimal m_Money;

        private string m_Person;

        private string m_Description;

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
        [DisplayName("Description")]
        public string Description
        {
            get
            {
                return this.m_Description;
            }
            set
            {
                this.m_Description = value;
            }
        }

        [Category("Primary Key")]
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

        [Category("Primary Key")]
        [DisplayName("SalaryDebitID")]
        public Guid SalaryDebitID
        {
            get
            {
                return this.m_SalaryDebitID;
            }
            set
            {
                this.m_SalaryDebitID = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("SalaryTableListID")]
        public Guid SalaryTableListID
        {
            get
            {
                return this.m_SalaryTableListID;
            }
            set
            {
                this.m_SalaryTableListID = value;
            }
        }

        public HRM_SALARY_DEBIT()
        {
            this.m_SalaryTableListID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_SalaryDebitID = Guid.Empty;
            this.m_Reason = "";
            this.m_Date = DateTime.Now;
            this.m_Money = new decimal(0);
            this.m_Person = "";
            this.m_Description = "";
        }

        public HRM_SALARY_DEBIT(Guid SalaryTableListID, string EmployeeCode, Guid SalaryDebitID, string Reason, DateTime Date, decimal Money, string Person, string Description)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_SalaryDebitID = SalaryDebitID;
            this.m_Reason = Reason;
            this.m_Date = Date;
            this.m_Money = Money;
            this.m_Person = Person;
            this.m_Description = Description;
        }

        public static string Create(int Level, string Code, string SalaryTableListID, DateTime Date, int PayType, double Value, string Person, string Description, bool IsSkip)
        {
            HRM_SALARY_TABLELIST hRMSALARYTABLELIST = new HRM_SALARY_TABLELIST();
            hRMSALARYTABLELIST.GetByID(new Guid(SalaryTableListID));
            int year = hRMSALARYTABLELIST.Year;
            int month = hRMSALARYTABLELIST.Month;
            DateTime dateTime = new DateTime(year, month, 1);
            DateTime dateTime1 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            foreach (DataRow row in hRMEMPLOYEE.GetCompactList(Level, Code, 1, dateTime, dateTime1).Rows)
            {
                string[] str = new string[] { "Đang cập nhật...", row["FirstName"].ToString(), " ", row["LastName"].ToString(), " (", row["EmployeeCode"].ToString(), ")" };
                Options.SetWaitDialogCaption(string.Concat(str));
                Thread thread = new Thread(() => HRM_SALARY_DEBIT.Create(SalaryTableListID, row["EmployeeCode"].ToString(), Date, PayType, Value, Person, Description, IsSkip));
                thread.Start();
                thread.Join();
            }
            Options.HideDialog();
            return "OK";
        }

        public static string Create(string SalaryTableListID, string EmployeeCode, DateTime Date, int PayType, double Value, string Person, string Description, bool IsSkip)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@Date", "@PayType", "@Value", "@Person", "@Description", "@IsSkip" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, Date, PayType, Value, Person, Description, IsSkip };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_DEBIT_Create", strArrays1, salaryTableListID);
        }

        public string Delete(Guid SalaryTableListID, string EmployeeCode, Guid SalaryDebitID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_DEBIT_Delete", strArrays, salaryTableListID);
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_DEBIT_DeleteBy", strArrays, mSalaryTableListID);
        }

        public string Delete(Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_DEBIT_DeleteBy", strArrays, salaryTableListID);
        }

        public string Delete(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_DEBIT_DeleteBy", strArrays, salaryTableListID);
        }

        public string Delete(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_DEBIT_DeleteBy", strArrays, salaryTableListID);
        }

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool Exist(Guid SalaryTableListID, string EmployeeCode, string SalaryDebitID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_DEBIT_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid SalaryTableListID, string EmployeeCode, string SalaryDebitID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_DEBIT_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryDebitID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryDebitID"));
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, string SalaryDebitID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_SALARY_DEBIT_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryDebitID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryDebitID"));
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, string SalaryDebitID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_SALARY_DEBIT_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryDebitID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryDebitID"));
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetList(int Level, string Code, Guid SalaryTableListID)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@SalaryTableListID" };
            object[] level = new object[] { Level, Code, SalaryTableListID };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_DEBIT_GetList", strArrays, level);
        }

        public DataTable GetList(Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_DEBIT_GetListByEmployee", strArrays, salaryTableListID);
        }

        public DataTable GetListByOrder(int Level, string Code, Guid SalaryTableListID, int Order)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@SalaryTableListID", "@Order" };
            object[] level = new object[] { Level, Code, SalaryTableListID, Order };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_DEBIT_GetListByOrder", strArrays, level);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID", "@Reason", "@Date", "@Money", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryDebitID, this.m_Reason, this.m_Date, this.m_Money, this.m_Person, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_DEBIT_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID", "@Reason", "@Date", "@Money", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryDebitID, this.m_Reason, this.m_Date, this.m_Money, this.m_Person, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_DEBIT_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(Guid SalaryTableListID, string EmployeeCode, Guid SalaryDebitID, string Reason, DateTime Date, decimal Money, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID", "@Reason", "@Date", "@Money", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID, Reason, Date, Money, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_DEBIT_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, Guid SalaryDebitID, string Reason, DateTime Date, decimal Money, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID", "@Reason", "@Date", "@Money", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID, Reason, Date, Money, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_DEBIT_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, Guid SalaryDebitID, string Reason, DateTime Date, decimal Money, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID", "@Reason", "@Date", "@Money", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID, Reason, Date, Money, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_DEBIT_Insert", strArrays1, salaryTableListID);
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID", "@Reason", "@Date", "@Money", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryDebitID, this.m_Reason, this.m_Date, this.m_Money, this.m_Person, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_DEBIT_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID", "@Reason", "@Date", "@Money", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryDebitID, this.m_Reason, this.m_Date, this.m_Money, this.m_Person, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_DEBIT_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(Guid SalaryTableListID, string EmployeeCode, Guid SalaryDebitID, string Reason, DateTime Date, decimal Money, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID", "@Reason", "@Date", "@Money", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID, Reason, Date, Money, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_DEBIT_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, Guid SalaryDebitID, string Reason, DateTime Date, decimal Money, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID", "@Reason", "@Date", "@Money", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID, Reason, Date, Money, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_DEBIT_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, Guid SalaryDebitID, string Reason, DateTime Date, decimal Money, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryDebitID", "@Reason", "@Date", "@Money", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryDebitID, Reason, Date, Money, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_DEBIT_Update", strArrays1, salaryTableListID);
        }
    }
}
