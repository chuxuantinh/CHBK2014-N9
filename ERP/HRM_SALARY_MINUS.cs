using DevExpress.XtraEditors;
using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
 public   class HRM_SALARY_MINUS
    {

        private Guid m_SalaryTableListID;

        private string m_EmployeeCode;

        private Guid m_SalaryMinusID;

        private string m_DeductionCode;

        private string m_SalaryMinusName;

        private decimal m_Money;

        private string m_Description;

        [Category("Column")]
        [DisplayName("DeductionCode")]
        public string DeductionCode
        {
            get
            {
                return this.m_DeductionCode;
            }
            set
            {
                this.m_DeductionCode = value;
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

        [Category("Primary Key")]
        [DisplayName("SalaryMinusID")]
        public Guid SalaryMinusID
        {
            get
            {
                return this.m_SalaryMinusID;
            }
            set
            {
                this.m_SalaryMinusID = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryMinusName")]
        public string SalaryMinusName
        {
            get
            {
                return this.m_SalaryMinusName;
            }
            set
            {
                this.m_SalaryMinusName = value;
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

        public HRM_SALARY_MINUS()
        {
            this.m_SalaryTableListID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_SalaryMinusID = Guid.Empty;
            this.m_DeductionCode = "";
            this.m_SalaryMinusName = "";
            this.m_Money = new decimal(0);
            this.m_Description = "";
        }

        public HRM_SALARY_MINUS(Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID, string SalaryMinusName, decimal Money, string Description)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_SalaryMinusID = SalaryMinusID;
            this.m_DeductionCode = "";
            this.m_SalaryMinusName = SalaryMinusName;
            this.m_Money = Money;
            this.m_Description = Description;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryMinusID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_MINUS_Delete", strArrays, mSalaryTableListID);
        }

        public string Delete(Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_MINUS_Delete", strArrays, salaryTableListID);
        }

        public string DeleteAll()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_MINUS_Delete", strArrays, mSalaryTableListID);
        }

        public string DeleteAll(Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_MINUS_DeleteAll", strArrays, salaryTableListID);
        }

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool Exist(Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_MINUS_Get", strArrays, objArray);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_MINUS_Get", strArrays, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryMinusID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryMinusID"));
                    this.m_DeductionCode = Convert.ToString(sqlDataReader["DeductionCode"]);
                    this.m_SalaryMinusName = Convert.ToString(sqlDataReader["SalaryMinusName"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(Guid SalaryTableListID, string EmployeeCode, string DeductionCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@DeductionCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, DeductionCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("Select * From [HRM_SALARY_MINUS]\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [EmployeeCode] = @EmployeeCode\r\n AND \r\n    [DeductionCode] = @DeductionCode", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryMinusID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryMinusID"));
                    this.m_DeductionCode = Convert.ToString(sqlDataReader["DeductionCode"]);
                    this.m_SalaryMinusName = Convert.ToString(sqlDataReader["SalaryMinusName"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_SALARY_MINUS_Get", strArrays, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryMinusID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryMinusID"));
                    this.m_DeductionCode = Convert.ToString(sqlDataReader["DeductionCode"]);
                    this.m_SalaryMinusName = Convert.ToString(sqlDataReader["SalaryMinusName"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_SALARY_MINUS_Get", strArrays, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryMinusID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryMinusID"));
                    this.m_DeductionCode = Convert.ToString(sqlDataReader["DeductionCode"]);
                    this.m_SalaryMinusName = Convert.ToString(sqlDataReader["SalaryMinusName"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_MINUS_GetList", strArrays, level);
        }

        public DataTable GetListByEmployee(Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_MINUS_GetListByEmployee", strArrays, salaryTableListID);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID", "@DeductionCode", "@SalaryMinusName", "@Money", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryMinusID, this.m_DeductionCode, this.m_SalaryMinusName, this.m_Money, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_MINUS_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID", "@DeductionCode", "@SalaryMinusName", "@Money", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryMinusID, this.m_DeductionCode, this.m_SalaryMinusName, this.m_Money, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_MINUS_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID, string DeductionCode, string SalaryMinusName, decimal Money, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID", "@DeductionCode", "@SalaryMinusName", "@Money", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID, DeductionCode, SalaryMinusName, Money, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_MINUS_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID, string DeductionCode, string SalaryMinusName, decimal Money, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID", "@DeductionCode", "@SalaryMinusName", "@Money", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID, DeductionCode, SalaryMinusName, Money, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_MINUS_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID, string DeductionCode, string SalaryMinusName, decimal Money, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID", "@DeductionCode", "@SalaryMinusName", "@Money", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID, DeductionCode, SalaryMinusName, Money, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_MINUS_Insert", strArrays1, salaryTableListID);
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID", "@DeductionCode", "@SalaryMinusName", "@Money", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryMinusID, this.m_DeductionCode, this.m_SalaryMinusName, this.m_Money, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_MINUS_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID", "@DeductionCode", "@SalaryMinusName", "@Money", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryMinusID, this.m_DeductionCode, this.m_SalaryMinusName, this.m_Money, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_MINUS_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID, string DeductionCode, string SalaryMinusName, decimal Money, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID", "@DeductionCode", "@SalaryMinusName", "@Money", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID, DeductionCode, SalaryMinusName, Money, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_MINUS_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID, string DeductionCode, string SalaryMinusName, decimal Money, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID", "@DeductionCode", "@SalaryMinusName", "@Money", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID, DeductionCode, SalaryMinusName, Money, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_MINUS_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, Guid SalaryMinusID, string DeductionCode, string SalaryMinusName, decimal Money, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryMinusID", "@DeductionCode", "@SalaryMinusName", "@Money", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryMinusID, DeductionCode, SalaryMinusName, Money, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_MINUS_Update", strArrays1, salaryTableListID);
        }
    }
}
