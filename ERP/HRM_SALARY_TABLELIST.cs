using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.Utils.Lib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
   public class HRM_SALARY_TABLELIST
    {


        private Guid m_SalaryTableListID;

        private string m_SalaryTableListName;

        private int m_Month;

        private int m_Year;

        private double m_SocialInsurance;

        private double m_HealthInsurance;

        private double m_UnemploymentInsurance;

        private double m_SocialInsurance1;

        private double m_HealthInsurance1;

        private double m_UnemploymentInsurance1;

        private int m_OvertimeSaturdayType;

        private bool m_IsLock;

        private bool m_IsFinish;

        [Category("Column")]
        [DisplayName("HealthInsurance")]
        public double HealthInsurance
        {
            get
            {
                return this.m_HealthInsurance;
            }
            set
            {
                this.m_HealthInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("HealthInsurance1")]
        public double HealthInsurance1
        {
            get
            {
                return this.m_HealthInsurance1;
            }
            set
            {
                this.m_HealthInsurance1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsFinish")]
        public bool IsFinish
        {
            get
            {
                return this.m_IsFinish;
            }
            set
            {
                this.m_IsFinish = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsLock")]
        public bool IsLock
        {
            get
            {
                return this.m_IsLock;
            }
            set
            {
                this.m_IsLock = value;
            }
        }

        [Category("Column")]
        [DisplayName("Month")]
        public int Month
        {
            get
            {
                return this.m_Month;
            }
            set
            {
                this.m_Month = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeSaturdayType")]
        public int OvertimeSaturdayType
        {
            get
            {
                return this.m_OvertimeSaturdayType;
            }
            set
            {
                this.m_OvertimeSaturdayType = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_SALARY_TABLELIST";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
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

        [Category("Column")]
        [DisplayName("SalaryTableListName")]
        public string SalaryTableListName
        {
            get
            {
                return this.m_SalaryTableListName;
            }
            set
            {
                this.m_SalaryTableListName = value;
            }
        }

        [Category("Column")]
        [DisplayName("SocialInsurance")]
        public double SocialInsurance
        {
            get
            {
                return this.m_SocialInsurance;
            }
            set
            {
                this.m_SocialInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("SocialInsurance1")]
        public double SocialInsurance1
        {
            get
            {
                return this.m_SocialInsurance1;
            }
            set
            {
                this.m_SocialInsurance1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnemploymentInsurance")]
        public double UnemploymentInsurance
        {
            get
            {
                return this.m_UnemploymentInsurance;
            }
            set
            {
                this.m_UnemploymentInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnemploymentInsurance1")]
        public double UnemploymentInsurance1
        {
            get
            {
                return this.m_UnemploymentInsurance1;
            }
            set
            {
                this.m_UnemploymentInsurance1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("Year")]
        public int Year
        {
            get
            {
                return this.m_Year;
            }
            set
            {
                this.m_Year = value;
            }
        }

        public HRM_SALARY_TABLELIST()
        {
            this.m_SalaryTableListID = Guid.NewGuid();
            this.m_SalaryTableListName = "";
            this.m_Month = 0;
            this.m_Year = 0;
            this.m_SocialInsurance = 0;
            this.m_HealthInsurance = 0;
            this.m_UnemploymentInsurance = 0;
            this.m_SocialInsurance1 = 0;
            this.m_HealthInsurance1 = 0;
            this.m_UnemploymentInsurance1 = 0;
            this.m_OvertimeSaturdayType = 0;
            this.m_IsLock = true;
            this.m_IsFinish = true;
        }

        public HRM_SALARY_TABLELIST(Guid SalaryTableListID, string SalaryTableListName, int Month, int Year, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, int OvertimeSaturdayType, bool IsLock, bool IsFinish)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_SalaryTableListName = SalaryTableListName;
            this.m_Month = Month;
            this.m_Year = Year;
            this.m_SocialInsurance = SocialInsurance;
            this.m_HealthInsurance = HealthInsurance;
            this.m_UnemploymentInsurance = UnemploymentInsurance;
            this.m_SocialInsurance1 = SocialInsurance1;
            this.m_HealthInsurance1 = HealthInsurance1;
            this.m_UnemploymentInsurance1 = UnemploymentInsurance1;
            this.m_OvertimeSaturdayType = OvertimeSaturdayType;
            this.m_IsLock = IsLock;
            this.m_IsFinish = IsFinish;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "SalaryTableListName", "SalaryTableListID");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["SalaryTableListID"] = "All";
        //    dataRow["SalaryTableListName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "SalaryTableListName", "SalaryTableListID");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["SalaryTableListName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "SalaryTableListName";
            gridlookup.Properties.ValueMember = "SalaryTableListID";
        }

        public void AddRepositoryGridLookupEdit(RepositoryItemGridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            gridlookup.DataSource = this.GetList();
            gridlookup.DisplayMember = "SalaryTableListName";
            gridlookup.ValueMember = "SalaryTableListID";
        }

        public void AddRepositoryGridLookupEditByYear(RepositoryItemGridLookUpEdit gridlookup, int Year)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetListByYear(Year);
            if (dataTable.Rows.Count < 0)
            {
                gridlookup.DataSource = null;
                gridlookup.NullText = "[Chọn bảng lương]";
            }
            else
            {
                gridlookup.DataSource = dataTable;
                gridlookup.DisplayMember = "SalaryTableListName";
                gridlookup.ValueMember = "SalaryTableListID";
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_TABLELIST_Delete", strArrays, mSalaryTableListID);
        }

        public string Delete(int Month, int Year)
        {
            this.Get(Month, Year);
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_TABLELIST_Delete", strArrays, mSalaryTableListID);
        }

        public string Delete(string SalaryTableListID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_TABLELIST_Delete", strArrays, salaryTableListID);
        }

        public string Delete(SqlConnection myConnection, string SalaryTableListID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_TABLELIST_Delete", strArrays, salaryTableListID);
        }

        public string Delete(SqlTransaction myTransaction, string SalaryTableListID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_TABLELIST_Delete", strArrays, salaryTableListID);
        }

        public bool Exist(Guid SalaryTableListID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("select * from HRM_SALARY_TABLELIST\r\nwhere SalaryTableListID=@SalaryTableListID", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool Exist(int Month, int Year)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@Month", "@Year" };
            object[] month = new object[] { Month, Year };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_TABLELIST_Get", strArrays, month);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Finish(Guid SalaryTableListID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery("Update HRM_SALARY_TABLELIST set IsLock='1',IsFinish='1' Where SalaryTableListID=@SalaryTableListID", strArrays, salaryTableListID);
        }

        public string Get(int Month, int Year)
        {
            string str = "";
            string[] strArrays = new string[] { "@Month", "@Year" };
            object[] month = new object[] { Month, Year };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_TABLELIST_Get", strArrays, month);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_SalaryTableListName = Convert.ToString(sqlDataReader["SalaryTableListName"]);
                    this.m_Month = Convert.ToInt32(sqlDataReader["Month"]);
                    this.m_Year = Convert.ToInt32(sqlDataReader["Year"]);
                    this.m_SocialInsurance = Convert.ToDouble(sqlDataReader["SocialInsurance"]);
                    this.m_HealthInsurance = Convert.ToDouble(sqlDataReader["HealthInsurance"]);
                    this.m_UnemploymentInsurance = Convert.ToDouble(sqlDataReader["UnemploymentInsurance"]);
                    this.m_SocialInsurance1 = Convert.ToDouble(sqlDataReader["SocialInsurance1"]);
                    this.m_HealthInsurance1 = Convert.ToDouble(sqlDataReader["HealthInsurance1"]);
                    this.m_UnemploymentInsurance1 = Convert.ToDouble(sqlDataReader["UnemploymentInsurance1"]);
                    this.m_OvertimeSaturdayType = Convert.ToInt32(sqlDataReader["OvertimeSaturdayType"]);
                    this.m_IsLock = Convert.ToBoolean(sqlDataReader["IsLock"]);
                    this.m_IsFinish = Convert.ToBoolean(sqlDataReader["IsFinish"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, int Month, int Year)
        {
            string str = "";
            string[] strArrays = new string[] { "@Month", "@Year" };
            object[] month = new object[] { Month, Year };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_SALARY_TABLELIST_Get", strArrays, month);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_SalaryTableListName = Convert.ToString(sqlDataReader["SalaryTableListName"]);
                    this.m_Month = Convert.ToInt32(sqlDataReader["Month"]);
                    this.m_Year = Convert.ToInt32(sqlDataReader["Year"]);
                    this.m_SocialInsurance = Convert.ToDouble(sqlDataReader["SocialInsurance"]);
                    this.m_HealthInsurance = Convert.ToDouble(sqlDataReader["HealthInsurance"]);
                    this.m_UnemploymentInsurance = Convert.ToDouble(sqlDataReader["UnemploymentInsurance"]);
                    this.m_SocialInsurance1 = Convert.ToDouble(sqlDataReader["SocialInsurance1"]);
                    this.m_HealthInsurance1 = Convert.ToDouble(sqlDataReader["HealthInsurance1"]);
                    this.m_UnemploymentInsurance1 = Convert.ToDouble(sqlDataReader["UnemploymentInsurance1"]);
                    this.m_OvertimeSaturdayType = Convert.ToInt32(sqlDataReader["OvertimeSaturdayType"]);
                    this.m_IsLock = Convert.ToBoolean(sqlDataReader["IsLock"]);
                    this.m_IsFinish = Convert.ToBoolean(sqlDataReader["IsFinish"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, int Month, int Year)
        {
            string str = "";
            string[] strArrays = new string[] { "@Month", "@Year" };
            object[] month = new object[] { Month, Year };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_SALARY_TABLELIST_Get", strArrays, month);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_SalaryTableListName = Convert.ToString(sqlDataReader["SalaryTableListName"]);
                    this.m_Month = Convert.ToInt32(sqlDataReader["Month"]);
                    this.m_Year = Convert.ToInt32(sqlDataReader["Year"]);
                    this.m_SocialInsurance = Convert.ToDouble(sqlDataReader["SocialInsurance"]);
                    this.m_HealthInsurance = Convert.ToDouble(sqlDataReader["HealthInsurance"]);
                    this.m_UnemploymentInsurance = Convert.ToDouble(sqlDataReader["UnemploymentInsurance"]);
                    this.m_SocialInsurance1 = Convert.ToDouble(sqlDataReader["SocialInsurance1"]);
                    this.m_HealthInsurance1 = Convert.ToDouble(sqlDataReader["HealthInsurance1"]);
                    this.m_UnemploymentInsurance1 = Convert.ToDouble(sqlDataReader["UnemploymentInsurance1"]);
                    this.m_OvertimeSaturdayType = Convert.ToInt32(sqlDataReader["OvertimeSaturdayType"]);
                    this.m_IsLock = Convert.ToBoolean(sqlDataReader["IsLock"]);
                    this.m_IsFinish = Convert.ToBoolean(sqlDataReader["IsFinish"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string GetByID(Guid SalaryTableListID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_TABLELIST_GetByID", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_SalaryTableListName = Convert.ToString(sqlDataReader["SalaryTableListName"]);
                    this.m_Month = Convert.ToInt32(sqlDataReader["Month"]);
                    this.m_Year = Convert.ToInt32(sqlDataReader["Year"]);
                    this.m_SocialInsurance = Convert.ToDouble(sqlDataReader["SocialInsurance"]);
                    this.m_HealthInsurance = Convert.ToDouble(sqlDataReader["HealthInsurance"]);
                    this.m_UnemploymentInsurance = Convert.ToDouble(sqlDataReader["UnemploymentInsurance"]);
                    this.m_SocialInsurance1 = Convert.ToDouble(sqlDataReader["SocialInsurance1"]);
                    this.m_HealthInsurance1 = Convert.ToDouble(sqlDataReader["HealthInsurance1"]);
                    this.m_UnemploymentInsurance1 = Convert.ToDouble(sqlDataReader["UnemploymentInsurance1"]);
                    this.m_OvertimeSaturdayType = Convert.ToInt32(sqlDataReader["OvertimeSaturdayType"]);
                    this.m_IsLock = Convert.ToBoolean(sqlDataReader["IsLock"]);
                    this.m_IsFinish = Convert.ToBoolean(sqlDataReader["IsFinish"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetList()
        {
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_TABLELIST_GetList");
        }

        public DataTable GetListByYear(int Year)
        {
            string[] strArrays = new string[] { "@Year" };
            object[] year = new object[] { Year };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable("select * from HRM_SALARY_TABLELIST\r\nwhere Year=@Year", strArrays, year);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@SalaryTableListName", "@Month", "@Year", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@OvertimeSaturdayType", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_SalaryTableListName, this.m_Month, this.m_Year, this.m_SocialInsurance, this.m_HealthInsurance, this.m_UnemploymentInsurance, this.m_SocialInsurance1, this.m_HealthInsurance1, this.m_UnemploymentInsurance1, this.m_OvertimeSaturdayType, this.m_IsLock, this.m_IsFinish };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_TABLELIST_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@SalaryTableListName", "@Month", "@Year", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@OvertimeSaturdayType", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_SalaryTableListName, this.m_Month, this.m_Year, this.m_SocialInsurance, this.m_HealthInsurance, this.m_UnemploymentInsurance, this.m_SocialInsurance1, this.m_HealthInsurance1, this.m_UnemploymentInsurance1, this.m_OvertimeSaturdayType, this.m_IsLock, this.m_IsFinish };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_TABLELIST_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(string SalaryTableListID, string SalaryTableListName, int Month, int Year, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, int OvertimeSaturdayType, bool IsLock, bool IsFinish)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@SalaryTableListName", "@Month", "@Year", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@OvertimeSaturdayType", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, SalaryTableListName, Month, Year, SocialInsurance, HealthInsurance, UnemploymentInsurance, SocialInsurance1, HealthInsurance1, UnemploymentInsurance1, OvertimeSaturdayType, IsLock, IsFinish };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_TABLELIST_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlConnection myConnection, string SalaryTableListID, string SalaryTableListName, int Month, int Year, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, int OvertimeSaturdayType, bool IsLock, bool IsFinish)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@SalaryTableListName", "@Month", "@Year", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@OvertimeSaturdayType", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, SalaryTableListName, Month, Year, SocialInsurance, HealthInsurance, UnemploymentInsurance, SocialInsurance1, HealthInsurance1, UnemploymentInsurance1, OvertimeSaturdayType, IsLock, IsFinish };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_TABLELIST_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction, string SalaryTableListID, string SalaryTableListName, int Month, int Year, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, int OvertimeSaturdayType, bool IsLock, bool IsFinish)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@SalaryTableListName", "@Month", "@Year", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@OvertimeSaturdayType", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, SalaryTableListName, Month, Year, SocialInsurance, HealthInsurance, UnemploymentInsurance, SocialInsurance1, HealthInsurance1, UnemploymentInsurance1, OvertimeSaturdayType, IsLock, IsFinish };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_TABLELIST_Insert", strArrays1, salaryTableListID);
        }

        public string Lock(Guid SalaryTableListID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery("Update HRM_SALARY_TABLELIST set IsLock='1' Where SalaryTableListID=@SalaryTableListID", strArrays, salaryTableListID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_SALARY_TABLELIST", "SalaryTableListID", "CV");
        }

        public string Open(Guid SalaryTableListID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery("Update HRM_SALARY_TABLELIST set IsLock='0'Where SalaryTableListID=@SalaryTableListID", strArrays, salaryTableListID);
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@SalaryTableListName", "@Month", "@Year", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@OvertimeSaturdayType", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_SalaryTableListName, this.m_Month, this.m_Year, this.m_SocialInsurance, this.m_HealthInsurance, this.m_UnemploymentInsurance, this.m_SocialInsurance1, this.m_HealthInsurance1, this.m_UnemploymentInsurance1, this.m_OvertimeSaturdayType, this.m_IsLock, this.m_IsFinish };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_TABLELIST_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(string SalaryTableListID, string SalaryTableListName, int Month, int Year, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, int OvertimeSaturdayType, bool IsLock, bool IsFinish)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@SalaryTableListName", "@Month", "@Year", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@OvertimeSaturdayType", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, SalaryTableListName, Month, Year, SocialInsurance, HealthInsurance, UnemploymentInsurance, SocialInsurance1, HealthInsurance1, UnemploymentInsurance1, OvertimeSaturdayType, IsLock, IsFinish };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_TABLELIST_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlConnection myConnection, string SalaryTableListID, string SalaryTableListName, int Month, int Year, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, int OvertimeSaturdayType, bool IsLock, bool IsFinish)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@SalaryTableListName", "@Month", "@Year", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@OvertimeSaturdayType", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, SalaryTableListName, Month, Year, SocialInsurance, HealthInsurance, UnemploymentInsurance, SocialInsurance1, HealthInsurance1, UnemploymentInsurance1, OvertimeSaturdayType, IsLock, IsFinish };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_TABLELIST_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlTransaction myTransaction, string SalaryTableListID, string SalaryTableListName, int Month, int Year, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, int OvertimeSaturdayType, bool IsLock, bool IsFinish)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@SalaryTableListName", "@Month", "@Year", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@OvertimeSaturdayType", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, SalaryTableListName, Month, Year, SocialInsurance, HealthInsurance, UnemploymentInsurance, SocialInsurance1, HealthInsurance1, UnemploymentInsurance1, OvertimeSaturdayType, IsLock, IsFinish };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_TABLELIST_Update", strArrays1, salaryTableListID);
        }
    }
}
