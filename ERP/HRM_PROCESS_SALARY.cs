using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ERP
{
   public class HRM_PROCESS_SALARY
    {


        private Guid m_SalaryID;

        private string m_EmployeeCode;

        private int m_OldPayForm;

        private decimal m_OldPayMoney;

        private string m_OldRankSalary;

        private int m_OldStepSalary;

        private double m_OldCoefficientSalary;

        private decimal m_OldMinimumSalary;

        private decimal m_OldBasicSalary;

        private decimal m_OldInsuranceSalary;

        private int m_NewPayForm;

        private decimal m_NewPayMoney;

        private string m_NewRankSalary;

        private int m_NewStepSalary;

        private double m_NewCoefficientSalary;

        private decimal m_NewMinimumSalary;

        private decimal m_NewBasicSalary;

        private decimal m_NewInsuranceSalary;

        private DateTime m_Date;

        private string m_Reason;

        private string m_DecideNumber;

        private string m_Person;

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
        [DisplayName("NewBasicSalary")]
        public decimal NewBasicSalary
        {
            get
            {
                return this.m_NewBasicSalary;
            }
            set
            {
                this.m_NewBasicSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewCoefficientSalary")]
        public double NewCoefficientSalary
        {
            get
            {
                return this.m_NewCoefficientSalary;
            }
            set
            {
                this.m_NewCoefficientSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewInsuranceSalary")]
        public decimal NewInsuranceSalary
        {
            get
            {
                return this.m_NewInsuranceSalary;
            }
            set
            {
                this.m_NewInsuranceSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewMinimumSalary")]
        public decimal NewMinimumSalary
        {
            get
            {
                return this.m_NewMinimumSalary;
            }
            set
            {
                this.m_NewMinimumSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewPayForm")]
        public int NewPayForm
        {
            get
            {
                return this.m_NewPayForm;
            }
            set
            {
                this.m_NewPayForm = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewPayMoney")]
        public decimal NewPayMoney
        {
            get
            {
                return this.m_NewPayMoney;
            }
            set
            {
                this.m_NewPayMoney = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewRankSalary")]
        public string NewRankSalary
        {
            get
            {
                return this.m_NewRankSalary;
            }
            set
            {
                this.m_NewRankSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewStepSalary")]
        public int NewStepSalary
        {
            get
            {
                return this.m_NewStepSalary;
            }
            set
            {
                this.m_NewStepSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldBasicSalary")]
        public decimal OldBasicSalary
        {
            get
            {
                return this.m_OldBasicSalary;
            }
            set
            {
                this.m_OldBasicSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldCoefficientSalary")]
        public double OldCoefficientSalary
        {
            get
            {
                return this.m_OldCoefficientSalary;
            }
            set
            {
                this.m_OldCoefficientSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldInsuranceSalary")]
        public decimal OldInsuranceSalary
        {
            get
            {
                return this.m_OldInsuranceSalary;
            }
            set
            {
                this.m_OldInsuranceSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldMinimumSalary")]
        public decimal OldMinimumSalary
        {
            get
            {
                return this.m_OldMinimumSalary;
            }
            set
            {
                this.m_OldMinimumSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldPayForm")]
        public int OldPayForm
        {
            get
            {
                return this.m_OldPayForm;
            }
            set
            {
                this.m_OldPayForm = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldPayMoney")]
        public decimal OldPayMoney
        {
            get
            {
                return this.m_OldPayMoney;
            }
            set
            {
                this.m_OldPayMoney = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldRankSalary")]
        public string OldRankSalary
        {
            get
            {
                return this.m_OldRankSalary;
            }
            set
            {
                this.m_OldRankSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldStepSalary")]
        public int OldStepSalary
        {
            get
            {
                return this.m_OldStepSalary;
            }
            set
            {
                this.m_OldStepSalary = value;
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
                return "Class HRM_PROCESS_SALARY";
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

        [Category("Primary Key")]
        [DisplayName("SalaryID")]
        public Guid SalaryID
        {
            get
            {
                return this.m_SalaryID;
            }
            set
            {
                this.m_SalaryID = value;
            }
        }

        public HRM_PROCESS_SALARY()
        {
            this.m_SalaryID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_OldPayForm = 0;
            this.m_OldPayMoney = new decimal(0);
            this.m_OldRankSalary = "";
            this.m_OldStepSalary = 0;
            this.m_OldCoefficientSalary = 0;
            this.m_OldMinimumSalary = new decimal(0);
            this.m_OldBasicSalary = new decimal(0);
            this.m_OldInsuranceSalary = new decimal(0);
            this.m_NewPayForm = 0;
            this.m_NewPayMoney = new decimal(0);
            this.m_NewRankSalary = "";
            this.m_NewStepSalary = 0;
            this.m_NewCoefficientSalary = 0;
            this.m_NewMinimumSalary = new decimal(0);
            this.m_NewBasicSalary = new decimal(0);
            this.m_NewInsuranceSalary = new decimal(0);
            this.m_Date = DateTime.Now;
            this.m_Reason = "";
            this.m_DecideNumber = "";
            this.m_Person = "";
        }

        public HRM_PROCESS_SALARY(Guid SalaryID, string EmployeeCode, int OldPayForm, decimal OldPayMoney, string OldRankSalary, int OldStepSalary, double OldCoefficientSalary, decimal OldMinimumSalary, decimal OldBasicSalary, decimal OldInsuranceSalary, int NewPayForm, decimal NewPayMoney, string NewRankSalary, int NewStepSalary, double NewCoefficientSalary, decimal NewMinimumSalary, decimal NewBasicSalary, decimal NewInsuranceSalary, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            this.m_SalaryID = SalaryID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_OldPayForm = OldPayForm;
            this.m_OldPayMoney = OldPayMoney;
            this.m_OldRankSalary = OldRankSalary;
            this.m_OldStepSalary = OldStepSalary;
            this.m_OldCoefficientSalary = OldCoefficientSalary;
            this.m_OldMinimumSalary = OldMinimumSalary;
            this.m_OldBasicSalary = OldBasicSalary;
            this.m_OldInsuranceSalary = OldInsuranceSalary;
            this.m_NewPayForm = NewPayForm;
            this.m_NewPayMoney = NewPayMoney;
            this.m_NewRankSalary = NewRankSalary;
            this.m_NewStepSalary = NewStepSalary;
            this.m_NewCoefficientSalary = NewCoefficientSalary;
            this.m_NewMinimumSalary = NewMinimumSalary;
            this.m_NewBasicSalary = NewBasicSalary;
            this.m_NewInsuranceSalary = NewInsuranceSalary;
            this.m_Date = Date;
            this.m_Reason = Reason;
            this.m_DecideNumber = DecideNumber;
            this.m_Person = Person;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SalaryID" };
            object[] mSalaryID = new object[] { this.m_SalaryID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_SALARY_Delete", strArrays, mSalaryID);
        }

        public string Delete(Guid SalaryID)
        {
            string[] strArrays = new string[] { "@SalaryID" };
            object[] salaryID = new object[] { SalaryID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_SALARY_Delete", strArrays, salaryID);
        }

        public string Delete(SqlConnection myConnection, Guid SalaryID)
        {
            string[] strArrays = new string[] { "@SalaryID" };
            object[] salaryID = new object[] { SalaryID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_SALARY_Delete", strArrays, salaryID);
        }

        public string Delete(SqlTransaction myTransaction, Guid SalaryID)
        {
            string[] strArrays = new string[] { "@SalaryID" };
            object[] salaryID = new object[] { SalaryID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_SALARY_Delete", strArrays, salaryID);
        }

        public bool Exist(Guid SalaryID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryID" };
            object[] salaryID = new object[] { SalaryID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PROCESS_SALARY_Get", strArrays, salaryID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid SalaryID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryID" };
            object[] salaryID = new object[] { SalaryID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PROCESS_SALARY_Get", strArrays, salaryID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_OldPayForm = Convert.ToInt32(sqlDataReader["OldPayForm"]);
                    this.m_OldPayMoney = Convert.ToDecimal(sqlDataReader["OldPayMoney"]);
                    this.m_OldRankSalary = Convert.ToString(sqlDataReader["OldRankSalary"]);
                    this.m_OldStepSalary = Convert.ToInt32(sqlDataReader["OldStepSalary"]);
                    this.m_OldCoefficientSalary = Convert.ToDouble(sqlDataReader["OldCoefficientSalary"]);
                    this.m_OldMinimumSalary = Convert.ToDecimal(sqlDataReader["OldMinimumSalary"]);
                    this.m_OldBasicSalary = Convert.ToDecimal(sqlDataReader["OldBasicSalary"]);
                    this.m_OldInsuranceSalary = Convert.ToDecimal(sqlDataReader["OldInsuranceSalary"]);
                    this.m_NewPayForm = Convert.ToInt32(sqlDataReader["NewPayForm"]);
                    this.m_NewPayMoney = Convert.ToDecimal(sqlDataReader["NewPayMoney"]);
                    this.m_NewRankSalary = Convert.ToString(sqlDataReader["NewRankSalary"]);
                    this.m_NewStepSalary = Convert.ToInt32(sqlDataReader["NewStepSalary"]);
                    this.m_NewCoefficientSalary = Convert.ToDouble(sqlDataReader["NewCoefficientSalary"]);
                    this.m_NewMinimumSalary = Convert.ToDecimal(sqlDataReader["NewMinimumSalary"]);
                    this.m_NewBasicSalary = Convert.ToDecimal(sqlDataReader["NewBasicSalary"]);
                    this.m_NewInsuranceSalary = Convert.ToDecimal(sqlDataReader["NewInsuranceSalary"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_DecideNumber = Convert.ToString(sqlDataReader["DecideNumber"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid SalaryID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryID" };
            object[] salaryID = new object[] { SalaryID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_PROCESS_SALARY_Get", strArrays, salaryID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_OldPayForm = Convert.ToInt32(sqlDataReader["OldPayForm"]);
                    this.m_OldPayMoney = Convert.ToDecimal(sqlDataReader["OldPayMoney"]);
                    this.m_OldRankSalary = Convert.ToString(sqlDataReader["OldRankSalary"]);
                    this.m_OldStepSalary = Convert.ToInt32(sqlDataReader["OldStepSalary"]);
                    this.m_OldCoefficientSalary = Convert.ToDouble(sqlDataReader["OldCoefficientSalary"]);
                    this.m_OldMinimumSalary = Convert.ToDecimal(sqlDataReader["OldMinimumSalary"]);
                    this.m_OldBasicSalary = Convert.ToDecimal(sqlDataReader["OldBasicSalary"]);
                    this.m_OldInsuranceSalary = Convert.ToDecimal(sqlDataReader["OldInsuranceSalary"]);
                    this.m_NewPayForm = Convert.ToInt32(sqlDataReader["NewPayForm"]);
                    this.m_NewPayMoney = Convert.ToDecimal(sqlDataReader["NewPayMoney"]);
                    this.m_NewRankSalary = Convert.ToString(sqlDataReader["NewRankSalary"]);
                    this.m_NewStepSalary = Convert.ToInt32(sqlDataReader["NewStepSalary"]);
                    this.m_NewCoefficientSalary = Convert.ToDouble(sqlDataReader["NewCoefficientSalary"]);
                    this.m_NewMinimumSalary = Convert.ToDecimal(sqlDataReader["NewMinimumSalary"]);
                    this.m_NewBasicSalary = Convert.ToDecimal(sqlDataReader["NewBasicSalary"]);
                    this.m_NewInsuranceSalary = Convert.ToDecimal(sqlDataReader["NewInsuranceSalary"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_DecideNumber = Convert.ToString(sqlDataReader["DecideNumber"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid SalaryID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryID" };
            object[] salaryID = new object[] { SalaryID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_PROCESS_SALARY_Get", strArrays, salaryID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_OldPayForm = Convert.ToInt32(sqlDataReader["OldPayForm"]);
                    this.m_OldPayMoney = Convert.ToDecimal(sqlDataReader["OldPayMoney"]);
                    this.m_OldRankSalary = Convert.ToString(sqlDataReader["OldRankSalary"]);
                    this.m_OldStepSalary = Convert.ToInt32(sqlDataReader["OldStepSalary"]);
                    this.m_OldCoefficientSalary = Convert.ToDouble(sqlDataReader["OldCoefficientSalary"]);
                    this.m_OldMinimumSalary = Convert.ToDecimal(sqlDataReader["OldMinimumSalary"]);
                    this.m_OldBasicSalary = Convert.ToDecimal(sqlDataReader["OldBasicSalary"]);
                    this.m_OldInsuranceSalary = Convert.ToDecimal(sqlDataReader["OldInsuranceSalary"]);
                    this.m_NewPayForm = Convert.ToInt32(sqlDataReader["NewPayForm"]);
                    this.m_NewPayMoney = Convert.ToDecimal(sqlDataReader["NewPayMoney"]);
                    this.m_NewRankSalary = Convert.ToString(sqlDataReader["NewRankSalary"]);
                    this.m_NewStepSalary = Convert.ToInt32(sqlDataReader["NewStepSalary"]);
                    this.m_NewCoefficientSalary = Convert.ToDouble(sqlDataReader["NewCoefficientSalary"]);
                    this.m_NewMinimumSalary = Convert.ToDecimal(sqlDataReader["NewMinimumSalary"]);
                    this.m_NewBasicSalary = Convert.ToDecimal(sqlDataReader["NewBasicSalary"]);
                    this.m_NewInsuranceSalary = Convert.ToDecimal(sqlDataReader["NewInsuranceSalary"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_DecideNumber = Convert.ToString(sqlDataReader["DecideNumber"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_SALARY_GetAllList", strArrays, objArray);
        }

        public DataTable GetAllListByDays(DateTime BeginDate, DateTime EndDate)
        {
            int level = MyLogin.Level;
            string code = MyLogin.Code;
            string[] strArrays = new string[] { "@Level", "@Code", "@BeginDate", "@EndDate" };
            object[] beginDate = new object[] { level, code, BeginDate, EndDate };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_SALARY_GetAllListByDays", strArrays, beginDate);
        }

        public DataTable GetList()
        {
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_SALARY_GetList");
        }

        public DataTable GetListByDays(string EmployeeCode, DateTime BeginDate, DateTime EndDate)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@BeginDate", "@EndDate" };
            object[] employeeCode = new object[] { EmployeeCode, BeginDate, EndDate };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_SALARY_GetListByDays", strArrays, employeeCode);
        }

        public DataTable GetListByEmployee(string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_SALARY_GetListByEmployee", strArrays, employeeCode);
        }

        public DataTable GetListByMonth(string EmployeeCode, int Month, int Year)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Month", "@Year" };
            object[] employeeCode = new object[] { EmployeeCode, Month, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_SALARY_GetListByMonth", strArrays, employeeCode);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SalaryID", "@EmployeeCode", "@OldPayForm", "@OldPayMoney", "@OldRankSalary", "@OldStepSalary", "@OldCoefficientSalary", "@OldMinimumSalary", "@OldBasicSalary", "@OldInsuranceSalary", "@NewPayForm", "@NewPayMoney", "@NewRankSalary", "@NewStepSalary", "@NewCoefficientSalary", "@NewMinimumSalary", "@NewBasicSalary", "@NewInsuranceSalary", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] mSalaryID = new object[] { this.m_SalaryID, this.m_EmployeeCode, this.m_OldPayForm, this.m_OldPayMoney, this.m_OldRankSalary, this.m_OldStepSalary, this.m_OldCoefficientSalary, this.m_OldMinimumSalary, this.m_OldBasicSalary, this.m_OldInsuranceSalary, this.m_NewPayForm, this.m_NewPayMoney, this.m_NewRankSalary, this.m_NewStepSalary, this.m_NewCoefficientSalary, this.m_NewMinimumSalary, this.m_NewBasicSalary, this.m_NewInsuranceSalary, this.m_Date, this.m_Reason, this.m_DecideNumber, this.m_Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_SALARY_Insert", strArrays1, mSalaryID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryID", "@EmployeeCode", "@OldPayForm", "@OldPayMoney", "@OldRankSalary", "@OldStepSalary", "@OldCoefficientSalary", "@OldMinimumSalary", "@OldBasicSalary", "@OldInsuranceSalary", "@NewPayForm", "@NewPayMoney", "@NewRankSalary", "@NewStepSalary", "@NewCoefficientSalary", "@NewMinimumSalary", "@NewBasicSalary", "@NewInsuranceSalary", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] mSalaryID = new object[] { this.m_SalaryID, this.m_EmployeeCode, this.m_OldPayForm, this.m_OldPayMoney, this.m_OldRankSalary, this.m_OldStepSalary, this.m_OldCoefficientSalary, this.m_OldMinimumSalary, this.m_OldBasicSalary, this.m_OldInsuranceSalary, this.m_NewPayForm, this.m_NewPayMoney, this.m_NewRankSalary, this.m_NewStepSalary, this.m_NewCoefficientSalary, this.m_NewMinimumSalary, this.m_NewBasicSalary, this.m_NewInsuranceSalary, this.m_Date, this.m_Reason, this.m_DecideNumber, this.m_Person };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_SALARY_Insert", strArrays1, mSalaryID);
        }

        public string Insert(Guid SalaryID, string EmployeeCode, int OldPayForm, decimal OldPayMoney, string OldRankSalary, int OldStepSalary, double OldCoefficientSalary, decimal OldMinimumSalary, decimal OldBasicSalary, decimal OldInsuranceSalary, int NewPayForm, decimal NewPayMoney, string NewRankSalary, int NewStepSalary, double NewCoefficientSalary, decimal NewMinimumSalary, decimal NewBasicSalary, decimal NewInsuranceSalary, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@SalaryID", "@EmployeeCode", "@OldPayForm", "@OldPayMoney", "@OldRankSalary", "@OldStepSalary", "@OldCoefficientSalary", "@OldMinimumSalary", "@OldBasicSalary", "@OldInsuranceSalary", "@NewPayForm", "@NewPayMoney", "@NewRankSalary", "@NewStepSalary", "@NewCoefficientSalary", "@NewMinimumSalary", "@NewBasicSalary", "@NewInsuranceSalary", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] salaryID = new object[] { SalaryID, EmployeeCode, OldPayForm, OldPayMoney, OldRankSalary, OldStepSalary, OldCoefficientSalary, OldMinimumSalary, OldBasicSalary, OldInsuranceSalary, NewPayForm, NewPayMoney, NewRankSalary, NewStepSalary, NewCoefficientSalary, NewMinimumSalary, NewBasicSalary, NewInsuranceSalary, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_SALARY_Insert", strArrays1, salaryID);
        }

        public string Insert(SqlConnection myConnection, Guid SalaryID, string EmployeeCode, int OldPayForm, decimal OldPayMoney, string OldRankSalary, int OldStepSalary, double OldCoefficientSalary, decimal OldMinimumSalary, decimal OldBasicSalary, decimal OldInsuranceSalary, int NewPayForm, decimal NewPayMoney, string NewRankSalary, int NewStepSalary, double NewCoefficientSalary, decimal NewMinimumSalary, decimal NewBasicSalary, decimal NewInsuranceSalary, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@SalaryID", "@EmployeeCode", "@OldPayForm", "@OldPayMoney", "@OldRankSalary", "@OldStepSalary", "@OldCoefficientSalary", "@OldMinimumSalary", "@OldBasicSalary", "@OldInsuranceSalary", "@NewPayForm", "@NewPayMoney", "@NewRankSalary", "@NewStepSalary", "@NewCoefficientSalary", "@NewMinimumSalary", "@NewBasicSalary", "@NewInsuranceSalary", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] salaryID = new object[] { SalaryID, EmployeeCode, OldPayForm, OldPayMoney, OldRankSalary, OldStepSalary, OldCoefficientSalary, OldMinimumSalary, OldBasicSalary, OldInsuranceSalary, NewPayForm, NewPayMoney, NewRankSalary, NewStepSalary, NewCoefficientSalary, NewMinimumSalary, NewBasicSalary, NewInsuranceSalary, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_SALARY_Insert", strArrays1, salaryID);
        }

        public string Insert(SqlTransaction myTransaction, Guid SalaryID, string EmployeeCode, int OldPayForm, decimal OldPayMoney, string OldRankSalary, int OldStepSalary, double OldCoefficientSalary, decimal OldMinimumSalary, decimal OldBasicSalary, decimal OldInsuranceSalary, int NewPayForm, decimal NewPayMoney, string NewRankSalary, int NewStepSalary, double NewCoefficientSalary, decimal NewMinimumSalary, decimal NewBasicSalary, decimal NewInsuranceSalary, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@SalaryID", "@EmployeeCode", "@OldPayForm", "@OldPayMoney", "@OldRankSalary", "@OldStepSalary", "@OldCoefficientSalary", "@OldMinimumSalary", "@OldBasicSalary", "@OldInsuranceSalary", "@NewPayForm", "@NewPayMoney", "@NewRankSalary", "@NewStepSalary", "@NewCoefficientSalary", "@NewMinimumSalary", "@NewBasicSalary", "@NewInsuranceSalary", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] salaryID = new object[] { SalaryID, EmployeeCode, OldPayForm, OldPayMoney, OldRankSalary, OldStepSalary, OldCoefficientSalary, OldMinimumSalary, OldBasicSalary, OldInsuranceSalary, NewPayForm, NewPayMoney, NewRankSalary, NewStepSalary, NewCoefficientSalary, NewMinimumSalary, NewBasicSalary, NewInsuranceSalary, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_SALARY_Insert", strArrays1, salaryID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_PROCESS_SALARY", "JobCode", "CV");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SalaryID", "@EmployeeCode", "@OldPayForm", "@OldPayMoney", "@OldRankSalary", "@OldStepSalary", "@OldCoefficientSalary", "@OldMinimumSalary", "@OldBasicSalary", "@OldInsuranceSalary", "@NewPayForm", "@NewPayMoney", "@NewRankSalary", "@NewStepSalary", "@NewCoefficientSalary", "@NewMinimumSalary", "@NewBasicSalary", "@NewInsuranceSalary", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] mSalaryID = new object[] { this.m_SalaryID, this.m_EmployeeCode, this.m_OldPayForm, this.m_OldPayMoney, this.m_OldRankSalary, this.m_OldStepSalary, this.m_OldCoefficientSalary, this.m_OldMinimumSalary, this.m_OldBasicSalary, this.m_OldInsuranceSalary, this.m_NewPayForm, this.m_NewPayMoney, this.m_NewRankSalary, this.m_NewStepSalary, this.m_NewCoefficientSalary, this.m_NewMinimumSalary, this.m_NewBasicSalary, this.m_NewInsuranceSalary, this.m_Date, this.m_Reason, this.m_DecideNumber, this.m_Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_SALARY_Update", strArrays1, mSalaryID);
        }

        public string Update(Guid SalaryID, string EmployeeCode, int OldPayForm, decimal OldPayMoney, string OldRankSalary, int OldStepSalary, double OldCoefficientSalary, decimal OldMinimumSalary, decimal OldBasicSalary, decimal OldInsuranceSalary, int NewPayForm, decimal NewPayMoney, string NewRankSalary, int NewStepSalary, double NewCoefficientSalary, decimal NewMinimumSalary, decimal NewBasicSalary, decimal NewInsuranceSalary, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@SalaryID", "@EmployeeCode", "@OldPayForm", "@OldPayMoney", "@OldRankSalary", "@OldStepSalary", "@OldCoefficientSalary", "@OldMinimumSalary", "@OldBasicSalary", "@OldInsuranceSalary", "@NewPayForm", "@NewPayMoney", "@NewRankSalary", "@NewStepSalary", "@NewCoefficientSalary", "@NewMinimumSalary", "@NewBasicSalary", "@NewInsuranceSalary", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] salaryID = new object[] { SalaryID, EmployeeCode, OldPayForm, OldPayMoney, OldRankSalary, OldStepSalary, OldCoefficientSalary, OldMinimumSalary, OldBasicSalary, OldInsuranceSalary, NewPayForm, NewPayMoney, NewRankSalary, NewStepSalary, NewCoefficientSalary, NewMinimumSalary, NewBasicSalary, NewInsuranceSalary, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_SALARY_Update", strArrays1, salaryID);
        }

        public string Update(SqlConnection myConnection, Guid SalaryID, string EmployeeCode, int OldPayForm, decimal OldPayMoney, string OldRankSalary, int OldStepSalary, double OldCoefficientSalary, decimal OldMinimumSalary, decimal OldBasicSalary, decimal OldInsuranceSalary, int NewPayForm, decimal NewPayMoney, string NewRankSalary, int NewStepSalary, double NewCoefficientSalary, decimal NewMinimumSalary, decimal NewBasicSalary, decimal NewInsuranceSalary, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@SalaryID", "@EmployeeCode", "@OldPayForm", "@OldPayMoney", "@OldRankSalary", "@OldStepSalary", "@OldCoefficientSalary", "@OldMinimumSalary", "@OldBasicSalary", "@OldInsuranceSalary", "@NewPayForm", "@NewPayMoney", "@NewRankSalary", "@NewStepSalary", "@NewCoefficientSalary", "@NewMinimumSalary", "@NewBasicSalary", "@NewInsuranceSalary", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] salaryID = new object[] { SalaryID, EmployeeCode, OldPayForm, OldPayMoney, OldRankSalary, OldStepSalary, OldCoefficientSalary, OldMinimumSalary, OldBasicSalary, OldInsuranceSalary, NewPayForm, NewPayMoney, NewRankSalary, NewStepSalary, NewCoefficientSalary, NewMinimumSalary, NewBasicSalary, NewInsuranceSalary, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_SALARY_Update", strArrays1, salaryID);
        }

        public string Update(SqlTransaction myTransaction, Guid SalaryID, string EmployeeCode, int OldPayForm, decimal OldPayMoney, string OldRankSalary, int OldStepSalary, double OldCoefficientSalary, decimal OldMinimumSalary, decimal OldBasicSalary, decimal OldInsuranceSalary, int NewPayForm, decimal NewPayMoney, string NewRankSalary, int NewStepSalary, double NewCoefficientSalary, decimal NewMinimumSalary, decimal NewBasicSalary, decimal NewInsuranceSalary, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@SalaryID", "@EmployeeCode", "@OldPayForm", "@OldPayMoney", "@OldRankSalary", "@OldStepSalary", "@OldCoefficientSalary", "@OldMinimumSalary", "@OldBasicSalary", "@OldInsuranceSalary", "@NewPayForm", "@NewPayMoney", "@NewRankSalary", "@NewStepSalary", "@NewCoefficientSalary", "@NewMinimumSalary", "@NewBasicSalary", "@NewInsuranceSalary", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] salaryID = new object[] { SalaryID, EmployeeCode, OldPayForm, OldPayMoney, OldRankSalary, OldStepSalary, OldCoefficientSalary, OldMinimumSalary, OldBasicSalary, OldInsuranceSalary, NewPayForm, NewPayMoney, NewRankSalary, NewStepSalary, NewCoefficientSalary, NewMinimumSalary, NewBasicSalary, NewInsuranceSalary, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_SALARY_Update", strArrays1, salaryID);
        }
    }
}
