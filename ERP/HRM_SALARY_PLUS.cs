using DevExpress.XtraEditors;
using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
  public  class HRM_SALARY_PLUS
    {

        private string s_HRM_SALARY_PLUS_GetListByType = "Select hea.*,hsi.IncomeName,hsi.IsIncomeTax, he.FirstName, he.LastName,hg.GroupName,hd.DepartmentName,hb.BranchName,hs.SubsidiaryName\r\nFrom [HRM_SALARY_PLUS] hea\r\nleft join HRM_SALARY_INCOME hsi on hea.IncomeCode=hsi.IncomeCode and hea.SalaryTableListID=hsi.SalaryTableListID\r\ninner join HRM_EMPLOYEE he on hea.EmployeeCode=he.EmployeeCode\r\nleft join HRM_GROUP hg on he.GroupCode=hg.GroupCode\r\n\tleft join HRM_DEPARTMENT hd on he.DepartmentCode=hd.DepartmentCode\r\n\tleft join HRM_BRANCH hb on he.BranchCode=hb.BranchCode\r\n\tleft join HRM_SUBSIDIARY hs on he.SubsidiaryCode=hs.SubsidiaryCode\r\nwhere hea.SalaryTableListID=@SalaryTableListID\r\n    and hsi.SalaryTableListID=@SalaryTableListID \r\n    and SalaryPlusType=@SalaryPlusType\r\n\tand (CASE @Level\r\n\t\t\twhen 0 then @Code\r\n\t\t\twhen 1 then he.SubsidiaryCode\r\n\t\t\twhen 2 then he.BranchCode\r\n\t\t\twhen 3 then he.DepartmentCode\r\n\t\t\twhen 4 then he.GroupCode\r\n\t\t\tEND=@Code)";

        private string s_HRM_SALARY_PLUS_GetListByEmployeeByType = "Select hea.*,hsi.IncomeName,hsi.IsIncomeTax From [HRM_SALARY_PLUS] hea\r\nleft join [HRM_SALARY_INCOME] hsi on hea.IncomeCode=hsi.IncomeCode\r\nwhere hea.EmployeeCode=@EmployeeCode \r\n    and hea.SalaryPlusType=@SalaryPlusType\r\n\tand hea.SalaryTableListID=@SalaryTableListID\r\n    and hsi.SalaryTableListID=@SalaryTableListID";

        private Guid m_SalaryTableListID;

        private string m_EmployeeCode;

        private Guid m_SalaryPlusID;

        private string m_IncomeCode;

        private string m_SalaryPlusName;

        private int m_SalaryPlusType;

        private decimal m_Money;

        private decimal m_PayMoney;

        private decimal m_DebtMoney;

        private decimal m_IncomeTaxMoney;

        private DateTime m_Date;

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
        [DisplayName("IncomeCode")]
        public string IncomeCode
        {
            get
            {
                return this.m_IncomeCode;
            }
            set
            {
                this.m_IncomeCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("IncomeTaxMoney")]
        public decimal IncomeTaxMoney
        {
            get
            {
                return this.m_IncomeTaxMoney;
            }
            set
            {
                this.m_IncomeTaxMoney = value;
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

        [Category("Primary Key")]
        [DisplayName("SalaryPlusID")]
        public Guid SalaryPlusID
        {
            get
            {
                return this.m_SalaryPlusID;
            }
            set
            {
                this.m_SalaryPlusID = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryPlusName")]
        public string SalaryPlusName
        {
            get
            {
                return this.m_SalaryPlusName;
            }
            set
            {
                this.m_SalaryPlusName = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryPlusType")]
        public int SalaryPlusType
        {
            get
            {
                return this.m_SalaryPlusType;
            }
            set
            {
                this.m_SalaryPlusType = value;
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

        public HRM_SALARY_PLUS()
        {
            this.m_SalaryTableListID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_SalaryPlusID = Guid.Empty;
            this.m_IncomeCode = "";
            this.m_SalaryPlusName = "";
            this.m_SalaryPlusType = 0;
            this.m_Money = new decimal(0);
            this.m_PayMoney = new decimal(0);
            this.m_DebtMoney = new decimal(0);
            this.m_IncomeTaxMoney = new decimal(0);
            this.m_Date = DateTime.Now;
            this.m_Description = "";
        }

        public HRM_SALARY_PLUS(Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID, string IncomeCode, string SalaryPlusName, int SalaryPlusType, decimal Money, decimal PayMoney, decimal DebtMoney, decimal IncomeTaxMoney, DateTime Date, string Description)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_SalaryPlusID = SalaryPlusID;
            this.m_IncomeCode = IncomeCode;
            this.m_SalaryPlusName = SalaryPlusName;
            this.m_SalaryPlusType = SalaryPlusType;
            this.m_Money = Money;
            this.m_PayMoney = PayMoney;
            this.m_DebtMoney = DebtMoney;
            this.m_IncomeTaxMoney = IncomeTaxMoney;
            this.m_Date = Date;
            this.m_Description = Description;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryPlusID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PLUS_Delete", strArrays, mSalaryTableListID);
        }

        public string Delete(Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PLUS_Delete", strArrays, salaryTableListID);
        }

        public string DeleteAll()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PLUS_DeleteAll", strArrays, mSalaryTableListID);
        }

        public string DeleteAll(Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PLUS_DeleteAll", strArrays, salaryTableListID);
        }

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool Exist(Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_PLUS_Get", strArrays, objArray);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid SalaryTableListID, string EmployeeCode, string IncomeCode)
        {
            object item;
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@IncomeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, IncomeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("Select * From [HRM_SALARY_PLUS]\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [EmployeeCode] = @EmployeeCode\r\n AND \r\n    [IncomeCode] = @IncomeCode", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryPlusID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryPlusID"));
                    if (sqlDataReader["IncomeCode"] == DBNull.Value)
                    {
                        item = "Khác";
                    }
                    else
                    {
                        item = sqlDataReader["IncomeCode"];
                    }
                    this.m_IncomeCode = Convert.ToString(item);
                    this.m_SalaryPlusName = Convert.ToString(sqlDataReader["SalaryPlusName"]);
                    this.m_SalaryPlusType = Convert.ToInt32((sqlDataReader["SalaryPlusType"] == DBNull.Value ? 0 : sqlDataReader["SalaryPlusType"]));
                    this.m_Money = Convert.ToDecimal((sqlDataReader["Money"] == DBNull.Value ? 0 : sqlDataReader["Money"]));
                    this.m_PayMoney = Convert.ToDecimal((sqlDataReader["PayMoney"] == DBNull.Value ? 0 : sqlDataReader["PayMoney"]));
                    this.m_DebtMoney = Convert.ToDecimal((sqlDataReader["DebtMoney"] == DBNull.Value ? 0 : sqlDataReader["DebtMoney"]));
                    this.m_IncomeTaxMoney = Convert.ToDecimal((sqlDataReader["IncomeTaxMoney"] == DBNull.Value ? 0 : sqlDataReader["IncomeTaxMoney"]));
                    this.m_Date = Convert.ToDateTime((sqlDataReader["Date"] == DBNull.Value ? DateTime.Now : sqlDataReader["Date"]));
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID)
        {
            object item;
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_PLUS_Get", strArrays, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryPlusID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryPlusID"));
                    if (sqlDataReader["IncomeCode"] == DBNull.Value)
                    {
                        item = "Khác";
                    }
                    else
                    {
                        item = sqlDataReader["IncomeCode"];
                    }
                    this.m_IncomeCode = Convert.ToString(item);
                    this.m_SalaryPlusName = Convert.ToString(sqlDataReader["SalaryPlusName"]);
                    this.m_SalaryPlusType = Convert.ToInt32((sqlDataReader["SalaryPlusType"] == DBNull.Value ? 0 : sqlDataReader["SalaryPlusType"]));
                    this.m_Money = Convert.ToDecimal((sqlDataReader["Money"] == DBNull.Value ? 0 : sqlDataReader["Money"]));
                    this.m_PayMoney = Convert.ToDecimal((sqlDataReader["PayMoney"] == DBNull.Value ? 0 : sqlDataReader["PayMoney"]));
                    this.m_DebtMoney = Convert.ToDecimal((sqlDataReader["DebtMoney"] == DBNull.Value ? 0 : sqlDataReader["DebtMoney"]));
                    this.m_IncomeTaxMoney = Convert.ToDecimal((sqlDataReader["IncomeTaxMoney"] == DBNull.Value ? 0 : sqlDataReader["IncomeTaxMoney"]));
                    this.m_Date = Convert.ToDateTime((sqlDataReader["Date"] == DBNull.Value ? DateTime.Now : sqlDataReader["Date"]));
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID)
        {
            object item;
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_SALARY_PLUS_Get", strArrays, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryPlusID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryPlusID"));
                    if (sqlDataReader["IncomeCode"] == DBNull.Value)
                    {
                        item = "Khác";
                    }
                    else
                    {
                        item = sqlDataReader["IncomeCode"];
                    }
                    this.m_IncomeCode = Convert.ToString(item);
                    this.m_SalaryPlusName = Convert.ToString(sqlDataReader["SalaryPlusName"]);
                    this.m_SalaryPlusType = Convert.ToInt32((sqlDataReader["SalaryPlusType"] == DBNull.Value ? 0 : sqlDataReader["SalaryPlusType"]));
                    this.m_Money = Convert.ToDecimal((sqlDataReader["Money"] == DBNull.Value ? 0 : sqlDataReader["Money"]));
                    this.m_PayMoney = Convert.ToDecimal((sqlDataReader["PayMoney"] == DBNull.Value ? 0 : sqlDataReader["PayMoney"]));
                    this.m_DebtMoney = Convert.ToDecimal((sqlDataReader["DebtMoney"] == DBNull.Value ? 0 : sqlDataReader["DebtMoney"]));
                    this.m_IncomeTaxMoney = Convert.ToDecimal((sqlDataReader["IncomeTaxMoney"] == DBNull.Value ? 0 : sqlDataReader["IncomeTaxMoney"]));
                    this.m_Date = Convert.ToDateTime((sqlDataReader["Date"] == DBNull.Value ? DateTime.Now : sqlDataReader["Date"]));
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID)
        {
            object item;
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_SALARY_PLUS_Get", strArrays, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryPlusID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryPlusID"));
                    if (sqlDataReader["IncomeCode"] == DBNull.Value)
                    {
                        item = "Khác";
                    }
                    else
                    {
                        item = sqlDataReader["IncomeCode"];
                    }
                    this.m_IncomeCode = Convert.ToString(item);
                    this.m_SalaryPlusName = Convert.ToString(sqlDataReader["SalaryPlusName"]);
                    this.m_SalaryPlusType = Convert.ToInt32((sqlDataReader["SalaryPlusType"] == DBNull.Value ? 0 : sqlDataReader["SalaryPlusType"]));
                    this.m_Money = Convert.ToDecimal((sqlDataReader["Money"] == DBNull.Value ? 0 : sqlDataReader["Money"]));
                    this.m_PayMoney = Convert.ToDecimal((sqlDataReader["PayMoney"] == DBNull.Value ? 0 : sqlDataReader["PayMoney"]));
                    this.m_DebtMoney = Convert.ToDecimal((sqlDataReader["DebtMoney"] == DBNull.Value ? 0 : sqlDataReader["DebtMoney"]));
                    this.m_IncomeTaxMoney = Convert.ToDecimal((sqlDataReader["IncomeTaxMoney"] == DBNull.Value ? 0 : sqlDataReader["IncomeTaxMoney"]));
                    this.m_Date = Convert.ToDateTime((sqlDataReader["Date"] == DBNull.Value ? DateTime.Now : sqlDataReader["Date"]));
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetListByEmployeeByType(Guid SalaryTableListID, string EmployeeCode, int SalaryPlusType)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusType" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusType };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable(this.s_HRM_SALARY_PLUS_GetListByEmployeeByType, strArrays, objArray);
        }

        public DataTable GetListByType(int Level, string Code, Guid SalaryTableListID, int SalaryPlusType)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@SalaryTableListID", "@SalaryPlusType" };
            object[] level = new object[] { Level, Code, SalaryTableListID, SalaryPlusType };
            object[] objArray = level;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable(this.s_HRM_SALARY_PLUS_GetListByType, strArrays, objArray);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID", "@IncomeCode", "@SalaryPlusName", "@SalaryPlusType", "@Money", "@PayMoney", "@DebtMoney", "@IncomeTaxMoney", "@Date", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryPlusID, this.m_IncomeCode, this.m_SalaryPlusName, this.m_SalaryPlusType, this.m_Money, this.m_PayMoney, this.m_DebtMoney, this.m_IncomeTaxMoney, this.m_Date, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PLUS_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID", "@IncomeCode", "@SalaryPlusName", "@SalaryPlusType", "@Money", "@PayMoney", "@DebtMoney", "@IncomeTaxMoney", "@Date", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryPlusID, this.m_IncomeCode, this.m_SalaryPlusName, this.m_SalaryPlusType, this.m_Money, this.m_PayMoney, this.m_DebtMoney, this.m_IncomeTaxMoney, this.m_Date, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_PLUS_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID, string IncomeCode, string SalaryPlusName, int SalaryPlusType, decimal Money, decimal PayMoney, decimal DebtMoney, decimal IncomeTaxMoney, DateTime Date, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID", "@IncomeCode", "@SalaryPlusName", "@SalaryPlusType", "@Money", "@PayMoney", "@DebtMoney", "@IncomeTaxMoney", "@Date", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID, IncomeCode, SalaryPlusName, SalaryPlusType, Money, PayMoney, DebtMoney, IncomeTaxMoney, Date, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PLUS_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID, string IncomeCode, string SalaryPlusName, int SalaryPlusType, decimal Money, decimal PayMoney, decimal DebtMoney, decimal IncomeTaxMoney, DateTime Date, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID", "@IncomeCode", "@SalaryPlusName", "@SalaryPlusType", "@Money", "@PayMoney", "@DebtMoney", "@IncomeTaxMoney", "@Date", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID, IncomeCode, SalaryPlusName, SalaryPlusType, Money, PayMoney, DebtMoney, IncomeTaxMoney, Date, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_PLUS_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID, string IncomeCode, string SalaryPlusName, int SalaryPlusType, decimal Money, decimal PayMoney, decimal DebtMoney, decimal IncomeTaxMoney, DateTime Date, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID", "@IncomeCode", "@SalaryPlusName", "@SalaryPlusType", "@Money", "@PayMoney", "@DebtMoney", "@IncomeTaxMoney", "@Date", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID, IncomeCode, SalaryPlusName, SalaryPlusType, Money, PayMoney, DebtMoney, IncomeTaxMoney, Date, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_PLUS_Insert", strArrays1, salaryTableListID);
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID", "@IncomeCode", "@SalaryPlusName", "@SalaryPlusType", "@Money", "@PayMoney", "@DebtMoney", "@IncomeTaxMoney", "@Date", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryPlusID, this.m_IncomeCode, this.m_SalaryPlusName, this.m_SalaryPlusType, this.m_Money, this.m_PayMoney, this.m_DebtMoney, this.m_IncomeTaxMoney, this.m_Date, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PLUS_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID", "@IncomeCode", "@SalaryPlusName", "@SalaryPlusType", "@Money", "@PayMoney", "@DebtMoney", "@IncomeTaxMoney", "@Date", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryPlusID, this.m_IncomeCode, this.m_SalaryPlusName, this.m_SalaryPlusType, this.m_Money, this.m_PayMoney, this.m_DebtMoney, this.m_IncomeTaxMoney, this.m_Date, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_PLUS_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID, string IncomeCode, string SalaryPlusName, int SalaryPlusType, decimal Money, decimal PayMoney, decimal DebtMoney, decimal IncomeTaxMoney, DateTime Date, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID", "@IncomeCode", "@SalaryPlusName", "@SalaryPlusType", "@Money", "@PayMoney", "@DebtMoney", "@IncomeTaxMoney", "@Date", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID, IncomeCode, SalaryPlusName, SalaryPlusType, Money, PayMoney, DebtMoney, IncomeTaxMoney, Date, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PLUS_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID, string IncomeCode, string SalaryPlusName, int SalaryPlusType, decimal Money, decimal PayMoney, decimal DebtMoney, decimal IncomeTaxMoney, DateTime Date, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID", "@IncomeCode", "@SalaryPlusName", "@SalaryPlusType", "@Money", "@PayMoney", "@DebtMoney", "@IncomeTaxMoney", "@Date", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID, IncomeCode, SalaryPlusName, SalaryPlusType, Money, PayMoney, DebtMoney, IncomeTaxMoney, Date, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_PLUS_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, Guid SalaryPlusID, string IncomeCode, string SalaryPlusName, int SalaryPlusType, decimal Money, decimal PayMoney, decimal DebtMoney, decimal IncomeTaxMoney, DateTime Date, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPlusID", "@IncomeCode", "@SalaryPlusName", "@SalaryPlusType", "@Money", "@PayMoney", "@DebtMoney", "@IncomeTaxMoney", "@Date", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPlusID, IncomeCode, SalaryPlusName, SalaryPlusType, Money, PayMoney, DebtMoney, IncomeTaxMoney, Date, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_PLUS_Update", strArrays1, salaryTableListID);
        }

    }
}
