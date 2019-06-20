using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.Utils.Lib;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CHBK2014_N9.ERP
{
  public  class DIC_HOLIDAY
    {

        private Guid m_HolidayID;

        private string m_HolidayName;

        private string m_Description;

        private DateTime m_FromDate;

        private DateTime m_ToDate;

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

        public Guid HolidayID
        {
            get
            {
                return this.m_HolidayID;
            }
            set
            {
                this.m_HolidayID = value;
            }
        }

        public string HolidayName
        {
            get
            {
                return this.m_HolidayName;
            }
            set
            {
                this.m_HolidayName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_HOLIDAY";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

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

        public DIC_HOLIDAY()
        {
            this.m_HolidayID = Guid.Empty;
            this.m_HolidayName = "";
            this.m_Description = "";
            this.m_FromDate = DateTime.Now;
            this.m_ToDate = DateTime.Now;
        }

        public DIC_HOLIDAY(Guid HolidayID, string HolidayName, DateTime FromDate, DateTime ToDate, string Description)
        {
            this.m_HolidayID = HolidayID;
            this.m_HolidayName = HolidayName;
            this.m_Description = Description;
            this.m_FromDate = FromDate;
            this.m_ToDate = ToDate;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "HolidayName", "HolidayID");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["HolidayID"] = "All";
        //    dataRow["HolidayName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "HolidayName", "HolidayID");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["HolidayName"]);
            }
        }

        public DataTable CreateNullDataTable()
        {
            SqlHelper sqlHelper = new SqlHelper();
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("HolidayID");
            DataColumn dataColumn1 = new DataColumn("HolidayName");
            DataColumn dataColumn2 = new DataColumn("Date");
            DataColumn dataColumn3 = new DataColumn("Description");
            dataTable.Columns.Add(dataColumn);
            dataTable.Columns.Add(dataColumn1);
            dataTable.Columns.Add(dataColumn2);
            dataTable.Columns.Add(dataColumn3);
            dataTable.Clear();
            return dataTable;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@HolidayID" };
            object[] mHolidayID = new object[] { this.m_HolidayID };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOLIDAY_Delete", strArrays, mHolidayID);
        }

        public string Delete(Guid HolidayID)
        {
            string[] strArrays = new string[] { "@HolidayID" };
            object[] holidayID = new object[] { HolidayID };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOLIDAY_Delete", strArrays, holidayID);
        }

        public bool Exist(string HolidayID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@HolidayID" };
            object[] holidayID = new object[] { HolidayID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_HOLIDAY_Get", strArrays, holidayID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool Exist(DateTime Date)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@Date" };
            object[] date = new object[] { Date };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("select * from DIC_HOLIDAY where dateadd(day,-1,FromDate)<@Date and ToDate>=@Date", strArrays, date);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string HolidayID)
        {
            string str = "";
            string[] strArrays = new string[] { "@HolidayID" };
            object[] holidayID = new object[] { HolidayID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_HOLIDAY_Get", strArrays, holidayID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_HolidayID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("HolidayID"));
                    this.m_HolidayName = Convert.ToString(sqlDataReader["HolidayName"]);
                    this.m_FromDate = Convert.ToDateTime(sqlDataReader["FromDate"]);
                    this.m_ToDate = Convert.ToDateTime(sqlDataReader["ToDate"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string HolidayID)
        {
            string str = "";
            string[] strArrays = new string[] { "@HolidayID" };
            object[] holidayID = new object[] { HolidayID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_HOLIDAY_Get", strArrays, holidayID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_HolidayID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("HolidayID"));
                    this.m_HolidayName = Convert.ToString(sqlDataReader["HolidayName"]);
                    this.m_FromDate = Convert.ToDateTime(sqlDataReader["FromDate"]);
                    this.m_ToDate = Convert.ToDateTime(sqlDataReader["ToDate"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string HolidayID)
        {
            string str = "";
            string[] strArrays = new string[] { "@HolidayID" };
            object[] holidayID = new object[] { HolidayID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_HOLIDAY_Get", strArrays, holidayID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_HolidayID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("HolidayID"));
                    this.m_HolidayName = Convert.ToString(sqlDataReader["HolidayName"]);
                    this.m_FromDate = Convert.ToDateTime(sqlDataReader["FromDate"]);
                    this.m_ToDate = Convert.ToDateTime(sqlDataReader["ToDate"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetByMonth(int Month, int Year)
        {
            string[] strArrays = new string[] { "@Month", "@Year" };
            object[] month = new object[] { Month, Year };
            return (new SqlHelper()).ExecuteDataTable("DIC_HOLIDAY_GetByMonth", strArrays, month);
        }

        public DataTable GetByYear(int Year)
        {
            string[] strArrays = new string[] { "@Year" };
            object[] year = new object[] { Year };
            return (new SqlHelper()).ExecuteDataTable("DIC_HOLIDAY_GetByYear", strArrays, year);
        }

        public DataTable GetList()
        {
            return (new SqlHelper()).ExecuteDataTable("DIC_HOLIDAY_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@HolidayID", "@HolidayName", "@FromDate", "@ToDate", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mHolidayID = new object[] { this.m_HolidayID, this.m_HolidayName, this.m_FromDate, this.m_ToDate, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOLIDAY_Insert", strArrays1, mHolidayID);
        }

        public string Insert(Guid HolidayID, string HolidayName, DateTime FromDate, DateTime ToDate, string Description)
        {
            string[] strArrays = new string[] { "@HolidayID", "@HolidayName", "@FromDate", "@ToDate", "@Description" };
            string[] strArrays1 = strArrays;
            object[] holidayID = new object[] { HolidayID, HolidayName, FromDate, ToDate, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOLIDAY_Insert", strArrays1, holidayID);
        }

        public string Insert(SqlConnection myConnection, Guid HolidayID, string HolidayName, DateTime FromDate, DateTime ToDate, string Description)
        {
            string[] strArrays = new string[] { "@HolidayID", "@HolidayName", "@FromDate", "@ToDate", "@Description" };
            string[] strArrays1 = strArrays;
            object[] holidayID = new object[] { HolidayID, HolidayName, FromDate, ToDate, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_HOLIDAY_Insert", strArrays1, holidayID);
        }

        public string Insert(SqlTransaction myTransaction, Guid HolidayID, string HolidayName, DateTime FromDate, DateTime ToDate, string Description)
        {
            string[] strArrays = new string[] { "@HolidayID", "@HolidayName", "@FromDate", "@ToDate", "@Description" };
            string[] strArrays1 = strArrays;
            object[] holidayID = new object[] { HolidayID, HolidayName, FromDate, ToDate, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_HOLIDAY_Insert", strArrays1, holidayID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_HOLIDAY", "HolidayID", "TH");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@HolidayID", "@HolidayName", "@FromDate", "@ToDate", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mHolidayID = new object[] { this.m_HolidayID, this.m_HolidayName, this.m_FromDate, this.m_ToDate, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOLIDAY_Update", strArrays1, mHolidayID);
        }

        public string Update(Guid HolidayID, string HolidayName, DateTime FromDate, DateTime ToDate, string Description)
        {
            string[] strArrays = new string[] { "@HolidayID", "@HolidayName", "@FromDate", "@ToDate", "@Description" };
            string[] strArrays1 = strArrays;
            object[] holidayID = new object[] { HolidayID, HolidayName, FromDate, ToDate, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOLIDAY_Update", strArrays1, holidayID);
        }

        public string Update(SqlConnection myConnection, Guid HolidayID, string HolidayName, DateTime FromDate, DateTime ToDate, string Description)
        {
            string[] strArrays = new string[] { "@HolidayID", "@HolidayName", "@FromDate", "@ToDate", "@Description" };
            string[] strArrays1 = strArrays;
            object[] holidayID = new object[] { HolidayID, HolidayName, FromDate, ToDate, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_HOLIDAY_Update", strArrays1, holidayID);
        }

        public string Update(SqlTransaction myTransaction, Guid HolidayID, string HolidayName, DateTime FromDate, DateTime ToDate, string Description)
        {
            string[] strArrays = new string[] { "@HolidayID", "@HolidayName", "@FromDate", "@ToDate", "@Description" };
            string[] strArrays1 = strArrays;
            object[] holidayID = new object[] { HolidayID, HolidayName, FromDate, ToDate, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_HOLIDAY_Update", strArrays1, holidayID);
        }
    }
}
