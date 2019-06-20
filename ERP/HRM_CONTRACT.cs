using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.HumanResource.Core.Class;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;


namespace CHBK2014_N9.ERP
{
   public class HRM_CONTRACT
    {

        private string m_ContractCode;

        private string m_EmployeeCode;

        private int m_ContractType;

        private string m_ContractTime;

        private DateTime m_SignDate;

        private DateTime m_FromDate;

        private DateTime m_ToDate;

        private decimal m_BasicSalary;

        private string m_PayForm;

        private string m_PayDate;

        private string m_Allowance;

        private string m_Insurance;

        private string m_WorkTime;

        private decimal m_Compensation;

        private string m_Signer;

        private string m_SignerPosition;

        private string m_SignerNationality;

        private string m_Company;

        private string m_Address;

        private string m_Tel;

        private string m_CreatePlace;

        private string m_Subject;

        private string m_Description;

        private bool m_IsCurrent;

        [Category("Column")]
        [DisplayName("Address")]
        public string Address
        {
            get
            {
                return this.m_Address;
            }
            set
            {
                this.m_Address = value;
            }
        }

        [Category("Column")]
        [DisplayName("Allowance")]
        public string Allowance
        {
            get
            {
                return this.m_Allowance;
            }
            set
            {
                this.m_Allowance = value;
            }
        }

        [Category("Column")]
        [DisplayName("BasicSalary")]
        public decimal BasicSalary
        {
            get
            {
                return this.m_BasicSalary;
            }
            set
            {
                this.m_BasicSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("Company")]
        public string Company
        {
            get
            {
                return this.m_Company;
            }
            set
            {
                this.m_Company = value;
            }
        }

        [Category("Column")]
        [DisplayName("Compensation")]
        public decimal Compensation
        {
            get
            {
                return this.m_Compensation;
            }
            set
            {
                this.m_Compensation = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("ContractCode")]
        public string ContractCode
        {
            get
            {
                return this.m_ContractCode;
            }
            set
            {
                this.m_ContractCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("ContractTime")]
        public string ContractTime
        {
            get
            {
                return this.m_ContractTime;
            }
            set
            {
                this.m_ContractTime = value;
            }
        }

        [Category("Column")]
        [DisplayName("ContractType")]
        public int ContractType
        {
            get
            {
                return this.m_ContractType;
            }
            set
            {
                this.m_ContractType = value;
            }
        }

        [Category("Column")]
        [DisplayName("CreatePlace")]
        public string CreatePlace
        {
            get
            {
                return this.m_CreatePlace;
            }
            set
            {
                this.m_CreatePlace = value;
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
        [DisplayName("Insurance")]
        public string Insurance
        {
            get
            {
                return this.m_Insurance;
            }
            set
            {
                this.m_Insurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsCurrent")]
        public bool IsCurrent
        {
            get
            {
                return this.m_IsCurrent;
            }
            set
            {
                this.m_IsCurrent = value;
            }
        }

        [Category("Column")]
        [DisplayName("PayDate")]
        public string PayDate
        {
            get
            {
                return this.m_PayDate;
            }
            set
            {
                this.m_PayDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("PayForm")]
        public string PayForm
        {
            get
            {
                return this.m_PayForm;
            }
            set
            {
                this.m_PayForm = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_CONTRACT";
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
        [DisplayName("SignDate")]
        public DateTime SignDate
        {
            get
            {
                return this.m_SignDate;
            }
            set
            {
                this.m_SignDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("Signer")]
        public string Signer
        {
            get
            {
                return this.m_Signer;
            }
            set
            {
                this.m_Signer = value;
            }
        }

        [Category("Column")]
        [DisplayName("SignerNationality")]
        public string SignerNationality
        {
            get
            {
                return this.m_SignerNationality;
            }
            set
            {
                this.m_SignerNationality = value;
            }
        }

        [Category("Column")]
        [DisplayName("SignerPosition")]
        public string SignerPosition
        {
            get
            {
                return this.m_SignerPosition;
            }
            set
            {
                this.m_SignerPosition = value;
            }
        }

        [Category("Column")]
        [DisplayName("Subject")]
        public string Subject
        {
            get
            {
                return this.m_Subject;
            }
            set
            {
                this.m_Subject = value;
            }
        }

        [Category("Column")]
        [DisplayName("Tel")]
        public string Tel
        {
            get
            {
                return this.m_Tel;
            }
            set
            {
                this.m_Tel = value;
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
        [DisplayName("WorkTime")]
        public string WorkTime
        {
            get
            {
                return this.m_WorkTime;
            }
            set
            {
                this.m_WorkTime = value;
            }
        }

        public HRM_CONTRACT()
        {
            this.m_ContractCode = "";
            this.m_EmployeeCode = "";
            this.m_ContractType = 0;
            this.m_ContractTime = "";
            this.m_SignDate = DateTime.Now;
            this.m_FromDate = DateTime.Now;
            this.m_ToDate = DateTime.Now;
            this.m_BasicSalary = new decimal(0);
            this.m_PayForm = "";
            this.m_PayDate = "";
            this.m_Allowance = "";
            this.m_Insurance = "";
            this.m_WorkTime = "";
            this.m_Compensation = new decimal(0);
            this.m_Signer = "";
            this.m_SignerPosition = "";
            this.m_SignerNationality = "";
            this.m_Company = "";
            this.m_Address = "";
            this.m_Tel = "";
            this.m_CreatePlace = "";
            this.m_Subject = "";
            this.m_Description = "";
            this.m_IsCurrent = true;
        }

        public HRM_CONTRACT(string ContractCode, string EmployeeCode, int ContractType, string ContractTime, DateTime SignDate, DateTime FromDate, DateTime ToDate, decimal BasicSalary, string PayForm, string PayDate, string Allowance, string Insurance, string WorkTime, decimal Compensation, string Signer, string SignerPosition, string SignerNationality, string Company, string Address, string Tel, string CreatePlace, string Subject, string Description, bool IsCurrent)
        {
            this.m_ContractCode = ContractCode;
            this.m_EmployeeCode = EmployeeCode;
            this.m_ContractType = ContractType;
            this.m_ContractTime = ContractTime;
            this.m_SignDate = SignDate;
            this.m_FromDate = FromDate;
            this.m_ToDate = ToDate;
            this.m_BasicSalary = BasicSalary;
            this.m_PayForm = PayForm;
            this.m_PayDate = PayDate;
            this.m_Allowance = Allowance;
            this.m_Insurance = Insurance;
            this.m_WorkTime = WorkTime;
            this.m_Compensation = Compensation;
            this.m_Signer = Signer;
            this.m_SignerPosition = SignerPosition;
            this.m_SignerNationality = SignerNationality;
            this.m_Company = Company;
            this.m_Address = Address;
            this.m_Tel = Tel;
            this.m_CreatePlace = CreatePlace;
            this.m_Subject = Subject;
            this.m_Description = Description;
            this.m_IsCurrent = IsCurrent;
        }

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList(MyLogin.Level, MyLogin.Code);
            foreach (DataRow row in dataTable.Rows)
            {
                combo.Properties.Items.Add(row["ContractCode"]);
            }
        }

        public void AddComboEdit(ComboBoxEdit combo, string EmployeeCode)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetListByEmployee(EmployeeCode).Rows)
            {
                combo.Properties.Items.Add(row["ContractCode"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@ContractCode" };
            object[] mContractCode = new object[] { this.m_ContractCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_CONTRACT_Delete", strArrays, mContractCode);
        }

        public string Delete(string ContractCode)
        {
            string[] strArrays = new string[] { "@ContractCode" };
            object[] contractCode = new object[] { ContractCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_CONTRACT_Delete", strArrays, contractCode);
        }

        public string Delete(SqlConnection myConnection, string ContractCode)
        {
            string[] strArrays = new string[] { "@ContractCode" };
            object[] contractCode = new object[] { ContractCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_CONTRACT_Delete", strArrays, contractCode);
        }

        public string Delete(SqlTransaction myTransaction, string ContractCode)
        {
            string[] strArrays = new string[] { "@ContractCode" };
            object[] contractCode = new object[] { ContractCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_CONTRACT_Delete", strArrays, contractCode);
        }

        public bool Exist(string ContractCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ContractCode" };
            object[] contractCode = new object[] { ContractCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_CONTRACT_Get", strArrays, contractCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool ExistByEmployee(string EmployeeCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_CONTRACT_GetByEmployee", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string ContractCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ContractCode" };
            object[] contractCode = new object[] { ContractCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_CONTRACT_Get", strArrays, contractCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ContractCode = Convert.ToString(sqlDataReader["ContractCode"]);
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_ContractType = Convert.ToInt32(sqlDataReader["ContractType"]);
                    this.m_ContractTime = Convert.ToString(sqlDataReader["ContractTime"]);
                    this.m_SignDate = Convert.ToDateTime(sqlDataReader["SignDate"]);
                    this.m_FromDate = Convert.ToDateTime(sqlDataReader["FromDate"]);
                    this.m_ToDate = Convert.ToDateTime(sqlDataReader["ToDate"]);
                    this.m_BasicSalary = Convert.ToDecimal(sqlDataReader["BasicSalary"]);
                    this.m_PayForm = Convert.ToString(sqlDataReader["PayForm"]);
                    this.m_PayDate = Convert.ToString(sqlDataReader["PayDate"]);
                    this.m_Allowance = Convert.ToString(sqlDataReader["Allowance"]);
                    this.m_Insurance = Convert.ToString(sqlDataReader["Insurance"]);
                    this.m_WorkTime = Convert.ToString(sqlDataReader["WorkTime"]);
                    this.m_Compensation = Convert.ToDecimal(sqlDataReader["Compensation"]);
                    this.m_Signer = Convert.ToString(sqlDataReader["Signer"]);
                    this.m_SignerPosition = Convert.ToString(sqlDataReader["SignerPosition"]);
                    this.m_SignerNationality = Convert.ToString(sqlDataReader["SignerNationality"]);
                    this.m_Company = Convert.ToString(sqlDataReader["Company"]);
                    this.m_Address = Convert.ToString(sqlDataReader["Address"]);
                    this.m_Tel = Convert.ToString(sqlDataReader["Tel"]);
                    this.m_CreatePlace = Convert.ToString(sqlDataReader["CreatePlace"]);
                    this.m_Subject = Convert.ToString(sqlDataReader["Subject"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    this.m_IsCurrent = Convert.ToBoolean(sqlDataReader["IsCurrent"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetCurrentList(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_CONTRACT_GetCurrentList", strArrays, level);
        }

        public DataTable GetList(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_CONTRACT_GetList", strArrays, level);
        }

        public DataTable GetListByContract(string ContractCode, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@ContractCode", "@EmployeeCode" };
            object[] contractCode = new object[] { ContractCode, EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable("Select hc.*,he.*,hs.SubsidiaryName, hb.BranchName, hd.DepartmentName,\r\n\tcase\r\n\t\twhen hc.ContractType=0 then N'Hợp đồng xác định thời hạn'\r\n\t\twhen hc.ContractType=1 then N'Hợp đồng không xác định thời hạn'\r\n\t\twhen hc.ContractType=2 then N'Hợp đồng thử việc'\r\n\t\telse N'Hợp đồng học việc'\r\n\tend as ContractTypeName\r\n From [HRM_CONTRACT] hc\r\n\tinner join [HRM_EMPLOYEE] he on hc.EmployeeCode=he.EmployeeCode\r\n\tleft join [HRM_SUBSIDIARY] hs on he.SubsidiaryCode=hs.SubsidiaryCode\r\n\tleft join [HRM_BRANCH] hb on he.BranchCode=hb.BranchCode\r\n\tleft join [HRM_DEPARTMENT] hd on he.DepartmentCode=hd.DepartmentCode\r\n\tLEFT JOIN [HRM_GROUP] hg ON he.GroupCode=hg.GroupCode\r\n Where \r\n    hc.[EmployeeCode] = @EmployeeCode\r\n    and hc.[ContractCode]=@ContractCode", strArrays, contractCode);
        }

        public DataTable GetListByEmployee(string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable("Select hc.*, he.FirstName, he.LastName,hs.SubsidiaryCode, hb.BranchName, hd.DepartmentName,hg.GroupName\r\nFrom [HRM_CONTRACT] hc\r\ninner join [HRM_EMPLOYEE] he on hc.EmployeeCode=he.EmployeeCode\r\nleft join [HRM_SUBSIDIARY] hs on he.SubsidiaryCode=hs.SubsidiaryCode\r\nleft join [HRM_BRANCH] hb on he.BranchCode=hb.BranchCode\r\nleft join [HRM_DEPARTMENT] hd on he.DepartmentCode=hd.DepartmentCode\r\nLEFT JOIN [HRM_GROUP] hg ON he.GroupCode=hg.GroupCode\r\n Where \r\n    hc.[EmployeeCode] = @EmployeeCode\r\n--    and IsCurrent=0", strArrays, employeeCode);
        }

        public DataTable GetListExpiration(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_CONTRACT_GetListExpiration", strArrays, level);
        }

        public DataTable GetListJustExpiration(int Level, string Code)
        {
            clsContractOption _clsContractOption = new clsContractOption();
            string[] strArrays = new string[] { "@Level", "@Code", "@NumberDayWarning" };
            object[] level = new object[] { Level, Code, _clsContractOption.NumberDayWarning };
            return (new SqlHelper()).ExecuteDataTable("HRM_CONTRACT_GetListJustExpiration", strArrays, level);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@ContractCode", "@EmployeeCode", "@ContractType", "@ContractTime", "@SignDate", "@FromDate", "@ToDate", "@BasicSalary", "@PayForm", "@PayDate", "@Allowance", "@Insurance", "@WorkTime", "@Compensation", "@Signer", "@SignerPosition", "@SignerNationality", "@Company", "@Address", "@Tel", "@CreatePlace", "@Subject", "@Description", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] mContractCode = new object[] { this.m_ContractCode, this.m_EmployeeCode, this.m_ContractType, this.m_ContractTime, this.m_SignDate, this.m_FromDate, this.m_ToDate, this.m_BasicSalary, this.m_PayForm, this.m_PayDate, this.m_Allowance, this.m_Insurance, this.m_WorkTime, this.m_Compensation, this.m_Signer, this.m_SignerPosition, this.m_SignerNationality, this.m_Company, this.m_Address, this.m_Tel, this.m_CreatePlace, this.m_Subject, this.m_Description, this.m_IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery("HRM_CONTRACT_Insert", strArrays1, mContractCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@ContractCode", "@EmployeeCode", "@ContractType", "@ContractTime", "@SignDate", "@FromDate", "@ToDate", "@BasicSalary", "@PayForm", "@PayDate", "@Allowance", "@Insurance", "@WorkTime", "@Compensation", "@Signer", "@SignerPosition", "@SignerNationality", "@Company", "@Address", "@Tel", "@CreatePlace", "@Subject", "@Description", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] mContractCode = new object[] { this.m_ContractCode, this.m_EmployeeCode, this.m_ContractType, this.m_ContractTime, this.m_SignDate, this.m_FromDate, this.m_ToDate, this.m_BasicSalary, this.m_PayForm, this.m_PayDate, this.m_Allowance, this.m_Insurance, this.m_WorkTime, this.m_Compensation, this.m_Signer, this.m_SignerPosition, this.m_SignerNationality, this.m_Company, this.m_Address, this.m_Tel, this.m_CreatePlace, this.m_Subject, this.m_Description, this.m_IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_CONTRACT_Insert", strArrays1, mContractCode);
        }

        public string Insert(string ContractCode, string EmployeeCode, int ContractType, string ContractTime, DateTime SignDate, DateTime FromDate, DateTime ToDate, decimal BasicSalary, string PayForm, string PayDate, string Allowance, string Insurance, string WorkTime, decimal Compensation, string Signer, string SignerPosition, string SignerNationality, string Company, string Address, string Tel, string CreatePlace, string Subject, string Description, bool IsCurrent)
        {
            string[] strArrays = new string[] { "@ContractCode", "@EmployeeCode", "@ContractType", "@ContractTime", "@SignDate", "@FromDate", "@ToDate", "@BasicSalary", "@PayForm", "@PayDate", "@Allowance", "@Insurance", "@WorkTime", "@Compensation", "@Signer", "@SignerPosition", "@SignerNationality", "@Company", "@Address", "@Tel", "@CreatePlace", "@Subject", "@Description", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] contractCode = new object[] { ContractCode, EmployeeCode, ContractType, ContractTime, SignDate, FromDate, ToDate, BasicSalary, PayForm, PayDate, Allowance, Insurance, WorkTime, Compensation, Signer, SignerPosition, SignerNationality, Company, Address, Tel, CreatePlace, Subject, Description, IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery("HRM_CONTRACT_Insert", strArrays1, contractCode);
        }

        public string Insert(SqlConnection myConnection, string ContractCode, string EmployeeCode, int ContractType, string ContractTime, DateTime SignDate, DateTime FromDate, DateTime ToDate, decimal BasicSalary, string PayForm, string PayDate, string Allowance, string Insurance, string WorkTime, decimal Compensation, string Signer, string SignerPosition, string SignerNationality, string Company, string Address, string Tel, string CreatePlace, string Subject, string Description, bool IsCurrent)
        {
            string[] strArrays = new string[] { "@ContractCode", "@EmployeeCode", "@ContractType", "@ContractTime", "@SignDate", "@FromDate", "@ToDate", "@BasicSalary", "@PayForm", "@PayDate", "@Allowance", "@Insurance", "@WorkTime", "@Compensation", "@Signer", "@SignerPosition", "@SignerNationality", "@Company", "@Address", "@Tel", "@CreatePlace", "@Subject", "@Description", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] contractCode = new object[] { ContractCode, EmployeeCode, ContractType, ContractTime, SignDate, FromDate, ToDate, BasicSalary, PayForm, PayDate, Allowance, Insurance, WorkTime, Compensation, Signer, SignerPosition, SignerNationality, Company, Address, Tel, CreatePlace, Subject, Description, IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_CONTRACT_Insert", strArrays1, contractCode);
        }

        public string Insert(SqlTransaction myTransaction, string ContractCode, string EmployeeCode, int ContractType, string ContractTime, DateTime SignDate, DateTime FromDate, DateTime ToDate, decimal BasicSalary, string PayForm, string PayDate, string Allowance, string Insurance, string WorkTime, decimal Compensation, string Signer, string SignerPosition, string SignerNationality, string Company, string Address, string Tel, string CreatePlace, string Subject, string Description, bool IsCurrent)
        {
            string[] strArrays = new string[] { "@ContractCode", "@EmployeeCode", "@ContractType", "@ContractTime", "@SignDate", "@FromDate", "@ToDate", "@BasicSalary", "@PayForm", "@PayDate", "@Allowance", "@Insurance", "@WorkTime", "@Compensation", "@Signer", "@SignerPosition", "@SignerNationality", "@Company", "@Address", "@Tel", "@CreatePlace", "@Subject", "@Description", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] contractCode = new object[] { ContractCode, EmployeeCode, ContractType, ContractTime, SignDate, FromDate, ToDate, BasicSalary, PayForm, PayDate, Allowance, Insurance, WorkTime, Compensation, Signer, SignerPosition, SignerNationality, Company, Address, Tel, CreatePlace, Subject, Description, IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_CONTRACT_Insert", strArrays1, contractCode);
        }

        private bool IsNumeric(object expression)
        {
            double num;
            bool flag = double.TryParse(Convert.ToString(expression), NumberStyles.Any, (IFormatProvider)NumberFormatInfo.InvariantInfo, out num);
            return flag;
        }

        public string NewID()
        {
            DateTime now = DateTime.Now;
            clsDocumentNumberOption _clsDocumentNumberOption = new clsDocumentNumberOption("ContractCode", "HDLD/", string.Concat("/", now.Year));
            return _clsDocumentNumberOption.GenCode("HRM_CONTRACT", "ContractCode");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@ContractCode", "@EmployeeCode", "@ContractType", "@ContractTime", "@SignDate", "@FromDate", "@ToDate", "@BasicSalary", "@PayForm", "@PayDate", "@Allowance", "@Insurance", "@WorkTime", "@Compensation", "@Signer", "@SignerPosition", "@SignerNationality", "@Company", "@Address", "@Tel", "@CreatePlace", "@Subject", "@Description", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] mContractCode = new object[] { this.m_ContractCode, this.m_EmployeeCode, this.m_ContractType, this.m_ContractTime, this.m_SignDate, this.m_FromDate, this.m_ToDate, this.m_BasicSalary, this.m_PayForm, this.m_PayDate, this.m_Allowance, this.m_Insurance, this.m_WorkTime, this.m_Compensation, this.m_Signer, this.m_SignerPosition, this.m_SignerNationality, this.m_Company, this.m_Address, this.m_Tel, this.m_CreatePlace, this.m_Subject, this.m_Description, this.m_IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery("HRM_CONTRACT_Update", strArrays1, mContractCode);
        }

        public string Update(string ContractCode, string EmployeeCode, int ContractType, string ContractTime, DateTime SignDate, DateTime FromDate, DateTime ToDate, decimal BasicSalary, string PayForm, string PayDate, string Allowance, string Insurance, string WorkTime, decimal Compensation, string Signer, string SignerPosition, string SignerNationality, string Company, string Address, string Tel, string CreatePlace, string Subject, string Description, bool IsCurrent)
        {
            string[] strArrays = new string[] { "@ContractCode", "@EmployeeCode", "@ContractType", "@ContractTime", "@SignDate", "@FromDate", "@ToDate", "@BasicSalary", "@PayForm", "@PayDate", "@Allowance", "@Insurance", "@WorkTime", "@Compensation", "@Signer", "@SignerPosition", "@SignerNationality", "@Company", "@Address", "@Tel", "@CreatePlace", "@Subject", "@Description", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] contractCode = new object[] { ContractCode, EmployeeCode, ContractType, ContractTime, SignDate, FromDate, ToDate, BasicSalary, PayForm, PayDate, Allowance, Insurance, WorkTime, Compensation, Signer, SignerPosition, SignerNationality, Company, Address, Tel, CreatePlace, Subject, Description, IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery("HRM_CONTRACT_Update", strArrays1, contractCode);
        }

        public string Update(SqlConnection myConnection, string ContractCode, string EmployeeCode, int ContractType, string ContractTime, DateTime SignDate, DateTime FromDate, DateTime ToDate, decimal BasicSalary, string PayForm, string PayDate, string Allowance, string Insurance, string WorkTime, decimal Compensation, string Signer, string SignerPosition, string SignerNationality, string Company, string Address, string Tel, string CreatePlace, string Subject, string Description, bool IsCurrent)
        {
            string[] strArrays = new string[] { "@ContractCode", "@EmployeeCode", "@ContractType", "@ContractTime", "@SignDate", "@FromDate", "@ToDate", "@BasicSalary", "@PayForm", "@PayDate", "@Allowance", "@Insurance", "@WorkTime", "@Compensation", "@Signer", "@SignerPosition", "@SignerNationality", "@Company", "@Address", "@Tel", "@CreatePlace", "@Subject", "@Description", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] contractCode = new object[] { ContractCode, EmployeeCode, ContractType, ContractTime, SignDate, FromDate, ToDate, BasicSalary, PayForm, PayDate, Allowance, Insurance, WorkTime, Compensation, Signer, SignerPosition, SignerNationality, Company, Address, Tel, CreatePlace, Subject, Description, IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_CONTRACT_Update", strArrays1, contractCode);
        }

        public string Update(SqlTransaction myTransaction, string ContractCode, string EmployeeCode, int ContractType, string ContractTime, DateTime SignDate, DateTime FromDate, DateTime ToDate, decimal BasicSalary, string PayForm, string PayDate, string Allowance, string Insurance, string WorkTime, decimal Compensation, string Signer, string SignerPosition, string SignerNationality, string Company, string Address, string Tel, string CreatePlace, string Subject, string Description, bool IsCurrent)
        {
            string[] strArrays = new string[] { "@ContractCode", "@EmployeeCode", "@ContractType", "@ContractTime", "@SignDate", "@FromDate", "@ToDate", "@BasicSalary", "@PayForm", "@PayDate", "@Allowance", "@Insurance", "@WorkTime", "@Compensation", "@Signer", "@SignerPosition", "@SignerNationality", "@Company", "@Address", "@Tel", "@CreatePlace", "@Subject", "@Description", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] contractCode = new object[] { ContractCode, EmployeeCode, ContractType, ContractTime, SignDate, FromDate, ToDate, BasicSalary, PayForm, PayDate, Allowance, Insurance, WorkTime, Compensation, Signer, SignerPosition, SignerNationality, Company, Address, Tel, CreatePlace, Subject, Description, IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_CONTRACT_Update", strArrays1, contractCode);
        }
    }
}
