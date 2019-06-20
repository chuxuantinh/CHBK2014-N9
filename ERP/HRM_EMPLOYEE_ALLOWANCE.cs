using DevExpress.XtraEditors;
using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
  public  class HRM_EMPLOYEE_ALLOWANCE
    {

        private string m_EmployeeCode;

        private string m_AllowanceCode;

        private decimal m_Money;

        private bool m_IsByWorkDay;

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
        [DisplayName("IsByWorkDay")]
        public bool IsByWorkDay
        {
            get
            {
                return this.m_IsByWorkDay;
            }
            set
            {
                this.m_IsByWorkDay = value;
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

        public HRM_EMPLOYEE_ALLOWANCE()
        {
            this.m_EmployeeCode = "";
            this.m_AllowanceCode = "";
            this.m_Money = new decimal(0);
            this.m_IsByWorkDay = false;
            this.m_IncomeTaxValue = 0;
        }

        public HRM_EMPLOYEE_ALLOWANCE(string EmployeeCode, string AllowanceCode, decimal Money, bool IsByWorkDay, double IncomeTaxValue)
        {
            this.m_EmployeeCode = EmployeeCode;
            this.m_AllowanceCode = AllowanceCode;
            this.m_Money = Money;
            this.m_IsByWorkDay = IsByWorkDay;
            this.m_IncomeTaxValue = IncomeTaxValue;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { this.EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_ALLOWANCE_Delete", strArrays, employeeCode);
        }

        public string Delete(string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_ALLOWANCE_Delete", strArrays, employeeCode);
        }

        public string Delete(SqlConnection myConnection, string EmployeeCode, string AllowanceCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_EMPLOYEE_ALLOWANCE_Delete", strArrays, employeeCode);
        }

        public string Delete(SqlTransaction myTransaction, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_EMPLOYEE_ALLOWANCE_Delete", strArrays, employeeCode);
        }

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool Exist(string EmployeeCode, string AllowanceCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode" };
            object[] employeeCode = new object[] { EmployeeCode, AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_EMPLOYEE_ALLOWANCE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string EmployeeCode, string AllowanceCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode" };
            object[] employeeCode = new object[] { EmployeeCode, AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_EMPLOYEE_ALLOWANCE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_AllowanceCode = Convert.ToString(sqlDataReader["AllowanceCode"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string EmployeeCode, string AllowanceCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode" };
            object[] employeeCode = new object[] { EmployeeCode, AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_EMPLOYEE_ALLOWANCE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_AllowanceCode = Convert.ToString(sqlDataReader["AllowanceCode"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string EmployeeCode, string AllowanceCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode" };
            object[] employeeCode = new object[] { EmployeeCode, AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_EMPLOYEE_ALLOWANCE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_AllowanceCode = Convert.ToString(sqlDataReader["AllowanceCode"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetList(string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_ALLOWANCE_GetList", strArrays, employeeCode);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode", "@Money", "@IsByWorkDay", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_AllowanceCode, this.m_Money, this.m_IsByWorkDay, this.m_IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_ALLOWANCE_Insert", strArrays1, mEmployeeCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode", "@Money", "@IsByWorkDay", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_AllowanceCode, this.m_Money, this.m_IsByWorkDay, this.m_IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_EMPLOYEE_ALLOWANCE_Insert", strArrays1, mEmployeeCode);
        }

        public string Insert(string EmployeeCode, string AllowanceCode, decimal Money, bool IsByWorkDay, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode", "@Money", "@IsByWorkDay", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, AllowanceCode, Money, IsByWorkDay, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_ALLOWANCE_Insert", strArrays1, employeeCode);
        }

        public string Insert(SqlConnection myConnection, string EmployeeCode, string AllowanceCode, decimal Money, bool IsByWorkDay, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode", "@Money", "@IsByWorkDay", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, AllowanceCode, Money, IsByWorkDay, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_EMPLOYEE_ALLOWANCE_Insert", strArrays1, employeeCode);
        }

        public string Insert(SqlTransaction myTransaction, string EmployeeCode, string AllowanceCode, decimal Money, bool IsByWorkDay, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode", "@Money", "@IsByWorkDay", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, AllowanceCode, Money, IsByWorkDay, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_EMPLOYEE_ALLOWANCE_Insert", strArrays1, employeeCode);
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode", "@Money", "@IsByWorkDay", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_AllowanceCode, this.m_Money, this.m_IsByWorkDay, this.m_IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_ALLOWANCE_Update", strArrays1, mEmployeeCode);
        }

        public string Update(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode", "@Money", "@IsByWorkDay", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_AllowanceCode, this.m_Money, this.m_IsByWorkDay, this.m_IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_EMPLOYEE_ALLOWANCE_Update", strArrays1, mEmployeeCode);
        }

        public string Update(string EmployeeCode, string AllowanceCode, decimal Money, bool IsByWorkDay, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode", "@Money", "@IsByWorkDay", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, AllowanceCode, Money, IsByWorkDay, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_ALLOWANCE_Update", strArrays1, employeeCode);
        }

        public string Update(SqlConnection myConnection, string EmployeeCode, string AllowanceCode, decimal Money, bool IsByWorkDay, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode", "@Money", "@IsByWorkDay", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, AllowanceCode, Money, IsByWorkDay, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_EMPLOYEE_ALLOWANCE_Update", strArrays1, employeeCode);
        }

        public string Update(SqlTransaction myTransaction, string EmployeeCode, string AllowanceCode, decimal Money, bool IsByWorkDay, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@AllowanceCode", "@Money", "@IsByWorkDay", "@IncomeTaxValue" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, AllowanceCode, Money, IsByWorkDay, IncomeTaxValue };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_EMPLOYEE_ALLOWANCE_Update", strArrays1, employeeCode);
        }
    }
}
