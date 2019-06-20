using DevExpress.XtraEditors;
using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CHBK2014_N9.ERP
{
  public  class HRM_SALARY_ALLOWANCE
    {

        private Guid m_SalaryTableListID;

        private string m_EmployeeCode;

        private string m_AllowanceCode;

        private decimal m_Money;

        private double m_IncomeTaxValue;

        [Category("Primary Key")]
        [DisplayName("AllowanceCode")]
        public string AllowanceCode
        {
            get
            {
                return this.m_AllowanceCode;
            }
            set
            {
                this.m_AllowanceCode = value;
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
        [DisplayName("IncomeTaxValue")]
        public double IncomeTaxValue
        {
            get
            {
                return this.m_IncomeTaxValue;
            }
            set
            {
                this.m_IncomeTaxValue = value;
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

        public HRM_SALARY_ALLOWANCE()
        {
            this.m_SalaryTableListID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_AllowanceCode = "";
            this.m_Money = new decimal(0);
            this.m_IncomeTaxValue = 0;
        }

        public HRM_SALARY_ALLOWANCE(Guid SalaryTableListID, string EmployeeCode, string AllowanceCode, decimal Money, double IncomeTaxValue)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_AllowanceCode = AllowanceCode;
            this.m_Money = Money;
            this.m_IncomeTaxValue = IncomeTaxValue;
        }

        public static string Create(string SalaryTableListID, bool IsUpdate)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IsUpdate" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IsUpdate };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_ALLOWANCE_Create", strArrays, salaryTableListID);
        }

        public static string Create(string SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_ALLOWANCE_Create", strArrays, salaryTableListID);
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_AllowanceCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_ALLOWANCE_Delete", strArrays, mSalaryTableListID);
        }

        public string Delete(Guid SalaryTableListID, string EmployeeCode, string AllowanceCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_ALLOWANCE_Delete", strArrays, salaryTableListID);
        }

        public string DeleteAll()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_ALLOWANCE_DeleteAll", strArrays, mSalaryTableListID);
        }

        public string DeleteAll(Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_ALLOWANCE_DeleteAll", strArrays, salaryTableListID);
        }

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool Exist(Guid SalaryTableListID, string EmployeeCode, string AllowanceCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_ALLOWANCE_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid SalaryTableListID, string EmployeeCode, string AllowanceCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_ALLOWANCE_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_AllowanceCode = Convert.ToString(sqlDataReader["AllowanceCode"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_IncomeTaxValue = Convert.ToDouble(sqlDataReader["IncomeTaxValue"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, string AllowanceCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_SALARY_ALLOWANCE_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_AllowanceCode = Convert.ToString(sqlDataReader["AllowanceCode"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_IncomeTaxValue = Convert.ToDouble(sqlDataReader["IncomeTaxValue"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, string AllowanceCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_SALARY_ALLOWANCE_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_AllowanceCode = Convert.ToString(sqlDataReader["AllowanceCode"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_IncomeTaxValue = Convert.ToDouble(sqlDataReader["IncomeTaxValue"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_ALLOWANCE_GetList", strArrays, level);
        }

        public DataTable GetListByEmployee(Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_ALLOWANCE_GetListByEmployee", strArrays, salaryTableListID);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@Money", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_AllowanceCode, this.m_Money, this.m_IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_ALLOWANCE_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@Money", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_AllowanceCode, this.m_Money, this.m_IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_ALLOWANCE_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(Guid SalaryTableListID, string EmployeeCode, string AllowanceCode, decimal Money, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@Money", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode, Money, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_ALLOWANCE_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, string AllowanceCode, decimal Money, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@Money", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode, Money, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_ALLOWANCE_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, string AllowanceCode, decimal Money, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@Money", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode, Money, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_ALLOWANCE_Insert", strArrays1, salaryTableListID);
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@Money", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_AllowanceCode, this.m_Money, this.m_IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_ALLOWANCE_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@Money", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_AllowanceCode, this.m_Money, this.m_IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_ALLOWANCE_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(Guid SalaryTableListID, string EmployeeCode, string AllowanceCode, decimal Money, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@Money", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode, Money, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_ALLOWANCE_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, string AllowanceCode, decimal Money, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@Money", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode, Money, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_ALLOWANCE_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, string AllowanceCode, decimal Money, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@Money", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode, Money, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_ALLOWANCE_Update", strArrays1, salaryTableListID);
        }
    }
}
