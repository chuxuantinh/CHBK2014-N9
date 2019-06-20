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
  public  class HRM_TIMEKEEPER_TABLELIST
    {

        private Guid m_TimeKeeperTableListID;

        private string m_TimeKeeperTableListName;

        private int m_Month;

        private int m_Year;

        private bool m_IsLock;

        private bool m_IsFinish;

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

        public string ProductName
        {
            get
            {
                return "Class HRM_TIMEKEEPER_TABLELIST";
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
        [DisplayName("TimeKeeperTableListID")]
        public Guid TimeKeeperTableListID
        {
            get
            {
                return this.m_TimeKeeperTableListID;
            }
            set
            {
                this.m_TimeKeeperTableListID = value;
            }
        }

        [Category("Column")]
        [DisplayName("TimeKeeperTableListName")]
        public string TimeKeeperTableListName
        {
            get
            {
                return this.m_TimeKeeperTableListName;
            }
            set
            {
                this.m_TimeKeeperTableListName = value;
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

        public HRM_TIMEKEEPER_TABLELIST()
        {
            this.m_TimeKeeperTableListID = Guid.NewGuid();
            this.m_TimeKeeperTableListName = "";
            this.m_Month = 0;
            this.m_Year = 0;
            this.m_IsLock = true;
            this.m_IsFinish = true;
        }

        public HRM_TIMEKEEPER_TABLELIST(Guid TimeKeeperTableListID, string TimeKeeperTableListName, int Month, int Year, bool IsLock, bool IsFinish)
        {
            this.m_TimeKeeperTableListID = TimeKeeperTableListID;
            this.m_TimeKeeperTableListName = TimeKeeperTableListName;
            this.m_Month = Month;
            this.m_Year = Year;
            this.m_IsLock = IsLock;
            this.m_IsFinish = IsFinish;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "TimeKeeperTableListName", "TimeKeeperTableListID");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["TimeKeeperTableListID"] = "All";
        //    dataRow["TimeKeeperTableListName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "TimeKeeperTableListName", "TimeKeeperTableListID");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["TimeKeeperTableListName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "TimeKeeperTableListName";
            gridlookup.Properties.ValueMember = "TimeKeeperTableListID";
        }

        public void AddRepositoryGridLookupEdit(RepositoryItemGridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            gridlookup.DataSource = this.GetList();
            gridlookup.DisplayMember = "TimeKeeperTableListName";
            gridlookup.ValueMember = "TimeKeeperTableListID";
        }

        public void AddRepositoryGridLookupEditByYear(RepositoryItemGridLookUpEdit gridlookup, int Year)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetListByYear(Year);
            if (dataTable.Rows.Count < 0)
            {
                gridlookup.DataSource = null;
                gridlookup.NullText = "[Chọn bảng chấm công]";
            }
            else
            {
                gridlookup.DataSource = dataTable;
                gridlookup.DisplayMember = "TimeKeeperTableListName";
                gridlookup.ValueMember = "TimeKeeperTableListID";
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID" };
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_TABLELIST_Delete", strArrays, mTimeKeeperTableListID);
        }

        public string Delete(string TimeKeeperTableListID)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_TABLELIST_Delete", strArrays, timeKeeperTableListID);
        }

        public string Delete(SqlConnection myConnection, string TimeKeeperTableListID)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_TIMEKEEPER_TABLELIST_Delete", strArrays, timeKeeperTableListID);
        }

        public string Delete(SqlTransaction myTransaction, string TimeKeeperTableListID)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_TABLELIST_Delete", strArrays, timeKeeperTableListID);
        }

        public string Delete(int Month, int Year)
        {
            string[] strArrays = new string[] { "@Month", "@Year" };
            object[] month = new object[] { Month, Year };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_TABLELIST_DeleteBy", strArrays, month);
        }

        public bool Exist(int Month, int Year)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@Month", "@Year" };
            object[] month = new object[] { Month, Year };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_TABLELIST_Get", strArrays, month);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Finish(Guid TimeKeeperTableListID)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery("Update HRM_TIMEKEEPER_TABLELIST set IsLock='1',IsFinish='1' Where TimeKeeperTableListID=@TimeKeeperTableListID", strArrays, timeKeeperTableListID);
        }

        public string Get(int Month, int Year)
        {
            string str = "";
            string[] strArrays = new string[] { "@Month", "@Year" };
            object[] month = new object[] { Month, Year };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_TABLELIST_Get", strArrays, month);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_TimeKeeperTableListName = Convert.ToString(sqlDataReader["TimeKeeperTableListName"]);
                    this.m_Month = Convert.ToInt32(sqlDataReader["Month"]);
                    this.m_Year = Convert.ToInt32(sqlDataReader["Year"]);
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
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_TIMEKEEPER_TABLELIST_Get", strArrays, month);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_TimeKeeperTableListName = Convert.ToString(sqlDataReader["TimeKeeperTableListName"]);
                    this.m_Month = Convert.ToInt32(sqlDataReader["Month"]);
                    this.m_Year = Convert.ToInt32(sqlDataReader["Year"]);
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
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_TIMEKEEPER_TABLELIST_Get", strArrays, month);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_TimeKeeperTableListName = Convert.ToString(sqlDataReader["TimeKeeperTableListName"]);
                    this.m_Month = Convert.ToInt32(sqlDataReader["Month"]);
                    this.m_Year = Convert.ToInt32(sqlDataReader["Year"]);
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

        public string GetByID(Guid TimeKeeperTableListID)
        {
            string str = "";
            string[] strArrays = new string[] { "@TimeKeeperTableListID" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_TABLELIST_GetByID", strArrays, timeKeeperTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_TimeKeeperTableListName = Convert.ToString(sqlDataReader["TimeKeeperTableListName"]);
                    this.m_Month = Convert.ToInt32(sqlDataReader["Month"]);
                    this.m_Year = Convert.ToInt32(sqlDataReader["Year"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_TABLELIST_GetList");
        }

        public DataTable GetListByYear(int Year)
        {
            string[] strArrays = new string[] { "@Year" };
            object[] year = new object[] { Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_TABLELIST_GetListByYear", strArrays, year);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@TimeKeeperTableListName", "@Month", "@Year", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_TimeKeeperTableListName, this.m_Month, this.m_Year, this.m_IsLock, this.m_IsFinish };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_TABLELIST_Insert", strArrays1, mTimeKeeperTableListID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@TimeKeeperTableListName", "@Month", "@Year", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_TimeKeeperTableListName, this.m_Month, this.m_Year, this.m_IsLock, this.m_IsFinish };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_TABLELIST_Insert", strArrays1, mTimeKeeperTableListID);
        }

        public string Insert(Guid TimeKeeperTableListID, string TimeKeeperTableListName, int Month, int Year, bool IsLock, bool IsFinish)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@TimeKeeperTableListName", "@Month", "@Year", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, TimeKeeperTableListName, Month, Year, IsLock, IsFinish };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_TABLELIST_Insert", strArrays1, timeKeeperTableListID);
        }

        public string Insert(SqlConnection myConnection, Guid TimeKeeperTableListID, string TimeKeeperTableListName, int Month, int Year, bool IsLock, bool IsFinish)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@TimeKeeperTableListName", "@Month", "@Year", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, TimeKeeperTableListName, Month, Year, IsLock, IsFinish };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_TIMEKEEPER_TABLELIST_Insert", strArrays1, timeKeeperTableListID);
        }

        public string Insert(SqlTransaction myTransaction, Guid TimeKeeperTableListID, string TimeKeeperTableListName, int Month, int Year, bool IsLock, bool IsFinish)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@TimeKeeperTableListName", "@Month", "@Year", "@IsLock", "@IsFinish" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, TimeKeeperTableListName, Month, Year, IsLock, IsFinish };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_TABLELIST_Insert", strArrays1, timeKeeperTableListID);
        }

        public string Lock(Guid TimeKeeperTableListID)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery("Update HRM_TIMEKEEPER_TABLELIST set IsLock='1' Where TimeKeeperTableListID=@TimeKeeperTableListID", strArrays, timeKeeperTableListID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_TIMEKEEPER_TABLELIST", "TimeKeeperTableListID", "CV");
        }

        public string Open(Guid TimeKeeperTableListID)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery("Update HRM_TIMEKEEPER_TABLELIST set IsLock='0'Where TimeKeeperTableListID=@TimeKeeperTableListID", strArrays, timeKeeperTableListID);
        }
    }
}
