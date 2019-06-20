using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Microsoft.VisualBasic;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.Utils;
using CHBK2014_N9.Utils.Lib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Perfect.Utils;

namespace CHBK2014_N9.ERP
{
   public class HRM_TIMEKEEPER
    {


        private Guid m_TimeKeeperTableListID;

        private string m_EmployeeCode;

        private string m_ShiftCode;

        private DateTime m_Date;

        private string m_Symbol;

        private DateTime m_TimeIn;

        private DateTime m_TimeOut;

        private double m_Hour;

        private double m_DayHour;

        private double m_NightHour;

        private double m_PrivateHour;

        private int m_LateMinute;

        private int m_EarlyMinute;

        private bool m_IsOverTime;

        private bool m_IsWork;

        private int m_Sorted;

        private string m_Description;

        [Category("Primary Key")]
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
        [DisplayName("DayHour")]
        public double DayHour
        {
            get
            {
                return this.m_DayHour;
            }
            set
            {
                this.m_DayHour = value;
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

        [Category("Column")]
        [DisplayName("EarlyMinute")]
        public int EarlyMinute
        {
            get
            {
                return this.m_EarlyMinute;
            }
            set
            {
                this.m_EarlyMinute = value;
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
        [DisplayName("Hour")]
        public double Hour
        {
            get
            {
                return this.m_Hour;
            }
            set
            {
                this.m_Hour = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsOverTime")]
        public bool IsOverTime
        {
            get
            {
                return this.m_IsOverTime;
            }
            set
            {
                this.m_IsOverTime = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsWork")]
        public bool IsWork
        {
            get
            {
                return this.m_IsWork;
            }
            set
            {
                this.m_IsWork = value;
            }
        }

        [Category("Column")]
        [DisplayName("LateMinute")]
        public int LateMinute
        {
            get
            {
                return this.m_LateMinute;
            }
            set
            {
                this.m_LateMinute = value;
            }
        }

        [Category("Column")]
        [DisplayName("NightHour")]
        public double NightHour
        {
            get
            {
                return this.m_NightHour;
            }
            set
            {
                this.m_NightHour = value;
            }
        }

        [Category("Column")]
        [DisplayName("PrivateHour")]
        public double PrivateHour
        {
            get
            {
                return this.m_PrivateHour;
            }
            set
            {
                this.m_PrivateHour = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_TIMEKEEPER";
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
        [DisplayName("ShiftCode")]
        public string ShiftCode
        {
            get
            {
                return this.m_ShiftCode;
            }
            set
            {
                this.m_ShiftCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("Sorted")]
        public int Sorted
        {
            get
            {
                return this.m_Sorted;
            }
            set
            {
                this.m_Sorted = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("Symbol")]
        public string Symbol
        {
            get
            {
                return this.m_Symbol;
            }
            set
            {
                this.m_Symbol = value;
            }
        }

        [Category("Column")]
        [DisplayName("TimeIn")]
        public DateTime TimeIn
        {
            get
            {
                return this.m_TimeIn;
            }
            set
            {
                this.m_TimeIn = value;
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
        [DisplayName("TimeOut")]
        public DateTime TimeOut
        {
            get
            {
                return this.m_TimeOut;
            }
            set
            {
                this.m_TimeOut = value;
            }
        }

        public HRM_TIMEKEEPER()
        {
            this.m_TimeKeeperTableListID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_ShiftCode = "";
            this.m_Date = DateTime.Now;
            this.m_Symbol = "";
            this.m_Hour = 0;
            this.m_DayHour = 0;
            this.m_NightHour = 0;
            this.m_PrivateHour = 0;
            this.m_LateMinute = 0;
            this.m_EarlyMinute = 0;
            this.m_IsOverTime = false;
            this.m_IsWork = false;
            this.m_Sorted = 0;
            this.m_Description = "";
        }

        public HRM_TIMEKEEPER(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol, double Hour, double DayHour, double NightHour, double PrivateHour, int LateMinute, int EarlyMinute, bool IsOverTime, bool IsWork, int Sorted, string Description)
        {
            this.m_TimeKeeperTableListID = TimeKeeperTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_ShiftCode = ShiftCode;
            this.m_Date = Date;
            this.m_Symbol = Symbol;
            this.m_Hour = Hour;
            this.m_DayHour = DayHour;
            this.m_NightHour = NightHour;
            this.m_PrivateHour = PrivateHour;
            this.m_LateMinute = LateMinute;
            this.m_EarlyMinute = EarlyMinute;
            this.m_IsOverTime = IsOverTime;
            this.m_IsWork = IsWork;
            this.m_Sorted = Sorted;
            this.m_Description = Description;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "TimeKeeperTableListName", "TimeKeeperID");
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

        public string Create(int Level, string Code, Guid TimeKeeperTableListID)
        {
            HRM_TIMEKEEPER_TABLELIST hRMTIMEKEEPERTABLELIST = new HRM_TIMEKEEPER_TABLELIST();
            hRMTIMEKEEPERTABLELIST.GetByID(TimeKeeperTableListID);
            int year = hRMTIMEKEEPERTABLELIST.Year;
            int month = hRMTIMEKEEPERTABLELIST.Month;
            DateTime dateTime = new DateTime(year, month, 1);
            DateTime dateTime1 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            HRM_TIMEKEEPER_TOTAL hRMTIMEKEEPERTOTAL = new HRM_TIMEKEEPER_TOTAL();
            foreach (DataRow row in hRMEMPLOYEE.GetCompactList(Level, Code, 1, dateTime, dateTime1).Rows)
            {
                if ((new HRM_TIMEKEEPER()).GetListByEmployee(row["EmployeeCode"].ToString(), month, year).Rows.Count <= 0)
                {
                    string[] str = new string[] { "Đang cập nhật...", row["FirstName"].ToString(), " ", row["LastName"].ToString(), " (", row["EmployeeCode"].ToString(), ")" };
                    Options.SetWaitDialogCaption(string.Concat(str));
                    Thread thread = new Thread(() => this.Create(TimeKeeperTableListID, row["EmployeeCode"].ToString()));
                    thread.Start();
                    thread.Join();
                    Thread thread1 = new Thread(() => hRMTIMEKEEPERTOTAL.Create(TimeKeeperTableListID, row["EmployeeCode"].ToString()));
                    thread1.Start();
                    thread1.Join();
                }
            }
            Options.HideDialog();
            return "OK";
        }

        public string Create(Guid TimeKeeperTableListID, DataTable Employeess)
        {
            HRM_TIMEKEEPER_TOTAL hRMTIMEKEEPERTOTAL = new HRM_TIMEKEEPER_TOTAL();
            foreach (DataRow row in Employeess.Rows)
            {
                string[] str = new string[] { "Đang khởi tạo...", row["FirstName"].ToString(), " ", row["LastName"].ToString(), " (", row["EmployeeCode"].ToString(), ")" };
                Options.SetWaitDialogCaption(string.Concat(str));
                Thread thread = new Thread(() => this.Create(TimeKeeperTableListID, row["EmployeeCode"].ToString()));
                thread.Start();
                thread.Join();
                Thread thread1 = new Thread(() => hRMTIMEKEEPERTOTAL.Create(TimeKeeperTableListID, row["EmployeeCode"].ToString()));
                thread1.Start();
                thread1.Join();
            }
            Options.HideDialog();
            return "OK";
        }

        public string Create(Guid TimeKeeperTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_Create", strArrays, timeKeeperTableListID);
        }

        public DataTable CreateNullDataTable()
        {
            SqlHelper sqlHelper = new SqlHelper();
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("TimeKeeperTableListID");
            DataColumn dataColumn1 = new DataColumn("EmployeeCode");
            DataColumn dataColumn2 = new DataColumn("ShiftCode");
            DataColumn dataColumn3 = new DataColumn("Date");
            DataColumn dataColumn4 = new DataColumn("Symbol");
            DataColumn dataColumn5 = new DataColumn("TimeIn");
            DataColumn dataColumn6 = new DataColumn("TimeOut");
            DataColumn dataColumn7 = new DataColumn("Hour");
            DataColumn dataColumn8 = new DataColumn("DayHour");
            DataColumn dataColumn9 = new DataColumn("NightHour");
            DataColumn dataColumn10 = new DataColumn("PrivateHour");
            DataColumn dataColumn11 = new DataColumn("LateMinute");
            DataColumn dataColumn12 = new DataColumn("EarlyMinute");
            DataColumn dataColumn13 = new DataColumn("IsOverTime");
            DataColumn dataColumn14 = new DataColumn("IsWork");
            DataColumn dataColumn15 = new DataColumn("Sorted");
            DataColumn dataColumn16 = new DataColumn("Description");
            dataTable.Columns.Add(dataColumn);
            dataTable.Columns.Add(dataColumn1);
            dataTable.Columns.Add(dataColumn2);
            dataTable.Columns.Add(dataColumn3);
            dataTable.Columns.Add(dataColumn4);
            dataTable.Columns.Add(dataColumn5);
            dataTable.Columns.Add(dataColumn6);
            dataTable.Columns.Add(dataColumn7);
            dataTable.Columns.Add(dataColumn8);
            dataTable.Columns.Add(dataColumn9);
            dataTable.Columns.Add(dataColumn10);
            dataTable.Columns.Add(dataColumn11);
            dataTable.Columns.Add(dataColumn12);
            dataTable.Columns.Add(dataColumn13);
            dataTable.Columns.Add(dataColumn14);
            dataTable.Columns.Add(dataColumn15);
            dataTable.Columns.Add(dataColumn16);
            dataTable.Clear();
            return dataTable;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol" };
            string[] strArrays1 = strArrays;
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_Symbol };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_Delete", strArrays1, mTimeKeeperTableListID);
        }

        public string Delete(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_Delete", strArrays1, timeKeeperTableListID);
        }

        public string Delete(SqlConnection myConnection, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_TIMEKEEPER_Delete", strArrays1, timeKeeperTableListID);
        }

        public string Delete(SqlTransaction myTransaction, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_Delete", strArrays1, timeKeeperTableListID);
        }

        public string DeleteByEmployeeDate(Guid TimeKeeperTableListID, string EmployeeCode, DateTime Date)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@Date" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, Date };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery("Delete From [HRM_TIMEKEEPER]\r\nWhere \r\n   [TimeKeeperTableListID] = @TimeKeeperTableListID\r\nAND \r\n   [EmployeeCode] = @EmployeeCode\r\nAND\r\n   [Date]=@Date\r\nAND [ShiftCode]<>''", strArrays, objArray);
        }

        public string DeleteByEmployeeShift(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_DeleteByEmployeeShift", strArrays, timeKeeperTableListID);
        }

        public bool Exist(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_Get", strArrays1, objArray);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol)
        {
            string str = "";
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_Get", strArrays1, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_ShiftCode = Convert.ToString(sqlDataReader["ShiftCode"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Symbol = Convert.ToString(sqlDataReader["Symbol"]);
                    this.m_TimeIn = Convert.ToDateTime(sqlDataReader["TimeIn"]);
                    this.m_TimeOut = Convert.ToDateTime(sqlDataReader["TimeOut"]);
                    this.m_Hour = Convert.ToDouble(sqlDataReader["Hour"]);
                    this.m_DayHour = Convert.ToDouble(sqlDataReader["DayHour"]);
                    this.m_NightHour = Convert.ToDouble(sqlDataReader["NightHour"]);
                    this.m_PrivateHour = Convert.ToDouble(sqlDataReader["PrivateHour"]);
                    this.m_LateMinute = Convert.ToInt32(sqlDataReader["LateMinute"]);
                    this.m_EarlyMinute = Convert.ToInt32(sqlDataReader["EarlyMinute"]);
                    this.m_IsOverTime = Convert.ToBoolean(sqlDataReader["IsOverTime"]);
                    this.m_IsWork = Convert.ToBoolean(sqlDataReader["IsWork"]);
                    this.m_Sorted = Convert.ToInt32(sqlDataReader["Sorted"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol)
        {
            string str = "";
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_TIMEKEEPER_Get", strArrays1, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_ShiftCode = Convert.ToString(sqlDataReader["ShiftCode"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Symbol = Convert.ToString(sqlDataReader["Symbol"]);
                    this.m_TimeIn = Convert.ToDateTime(sqlDataReader["TimeIn"]);
                    this.m_TimeOut = Convert.ToDateTime(sqlDataReader["TimeOut"]);
                    this.m_Hour = Convert.ToDouble(sqlDataReader["Hour"]);
                    this.m_DayHour = Convert.ToDouble(sqlDataReader["DayHour"]);
                    this.m_NightHour = Convert.ToDouble(sqlDataReader["NightHour"]);
                    this.m_PrivateHour = Convert.ToDouble(sqlDataReader["PrivateHour"]);
                    this.m_LateMinute = Convert.ToInt32(sqlDataReader["LateMinute"]);
                    this.m_EarlyMinute = Convert.ToInt32(sqlDataReader["EarlyMinute"]);
                    this.m_IsOverTime = Convert.ToBoolean(sqlDataReader["IsOverTime"]);
                    this.m_IsWork = Convert.ToBoolean(sqlDataReader["IsWork"]);
                    this.m_Sorted = Convert.ToInt32(sqlDataReader["Sorted"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol)
        {
            string str = "";
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_TIMEKEEPER_Get", strArrays1, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_ShiftCode = Convert.ToString(sqlDataReader["ShiftCode"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Symbol = Convert.ToString(sqlDataReader["Symbol"]);
                    this.m_TimeIn = Convert.ToDateTime(sqlDataReader["TimeIn"]);
                    this.m_TimeOut = Convert.ToDateTime(sqlDataReader["TimeOut"]);
                    this.m_Hour = Convert.ToDouble(sqlDataReader["Hour"]);
                    this.m_DayHour = Convert.ToDouble(sqlDataReader["DayHour"]);
                    this.m_NightHour = Convert.ToDouble(sqlDataReader["NightHour"]);
                    this.m_PrivateHour = Convert.ToDouble(sqlDataReader["PrivateHour"]);
                    this.m_LateMinute = Convert.ToInt32(sqlDataReader["LateMinute"]);
                    this.m_EarlyMinute = Convert.ToInt32(sqlDataReader["EarlyMinute"]);
                    this.m_IsOverTime = Convert.ToBoolean(sqlDataReader["IsOverTime"]);
                    this.m_IsWork = Convert.ToBoolean(sqlDataReader["IsWork"]);
                    this.m_Sorted = Convert.ToInt32(sqlDataReader["Sorted"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public void Get(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, string Symbol, DateTime Date, DateTime TimeIn, DateTime TimeOut)
        {
            int num = 0;
            int num1 = 0;
            DIC_SHIFT dICSHIFT = new DIC_SHIFT();
            dICSHIFT.Get(ShiftCode);
            int year = Date.Year;
            int month = Date.Month;
            int day = Date.Day;
            int hour = dICSHIFT.BeginTime.Hour;
            int minute = dICSHIFT.BeginTime.Minute;
            DateTime beginTime = dICSHIFT.BeginTime;
            DateTime dateTime = new DateTime(year, month, day, hour, minute, beginTime.Second);
            int year1 = Date.Year;
            int month1 = Date.Month;
            int day1 = Date.Day;
            int hour1 = dICSHIFT.EndTime.Hour;
            int minute1 = dICSHIFT.EndTime.Minute;
            beginTime = dICSHIFT.EndTime;
            DateTime dateTime1 = new DateTime(year1, month1, day1, hour1, minute1, beginTime.Second);
            if (dICSHIFT.IsOvernight)
            {
                dateTime1 = DateAndTime.DateAdd(DateInterval.Day, 1, dateTime1);
            }
            if (Symbol == "+")
            {
                if ((TimeOut >= dateTime1 ? true : !(ShiftCode != "")))
                {
                    this.m_EarlyMinute = 0;
                }
                else
                {
                    num1 =Perfect.Utils. MyDateTime.NumberMinute(TimeOut, dateTime1);
                }
                num = ((TimeIn <= dateTime ? true : !(ShiftCode != "")) ? 0 : Perfect.Utils. MyDateTime.NumberMinute(dateTime, TimeIn));
            }
            this.Get(TimeKeeperTableListID, EmployeeCode, ShiftCode, Symbol, Date, TimeIn, TimeOut, dateTime, dateTime1, num, num1);
        }

        public void Get(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, string Symbol, DateTime Date, DateTime TimeIn, DateTime TimeOut, int Sorted, int Length)
        {
            DateTime beginTime;
            int num = 0;
            int num1 = 0;
            DIC_SHIFT dICSHIFT = new DIC_SHIFT();
            dICSHIFT.Get(ShiftCode);
            DateTime date = Date;
            DateTime dateTime = Date;
            if ((Length != 2 ? true : !dICSHIFT.IsBreak))
            {
                int year = Date.Year;
                int month = Date.Month;
                int day = Date.Day;
                int hour = dICSHIFT.BeginTime.Hour;
                int minute = dICSHIFT.BeginTime.Minute;
                beginTime = dICSHIFT.BeginTime;
                date = new DateTime(year, month, day, hour, minute, beginTime.Second);
                int year1 = Date.Year;
                int month1 = Date.Month;
                int day1 = Date.Day;
                int hour1 = dICSHIFT.EndTime.Hour;
                int minute1 = dICSHIFT.EndTime.Minute;
                beginTime = dICSHIFT.EndTime;
                dateTime = new DateTime(year1, month1, day1, hour1, minute1, beginTime.Second);
                if (dICSHIFT.IsOvernight)
                {
                    dateTime = DateAndTime.DateAdd(DateInterval.Day, 1, dateTime);
                }
            }
            else if (Sorted != 0)
            {
                int year2 = Date.Year;
                int month2 = Date.Month;
                int day2 = Date.Day;
                int hour2 = dICSHIFT.BreakEndTime.Hour;
                int minute2 = dICSHIFT.BreakEndTime.Minute;
                beginTime = dICSHIFT.BreakEndTime;
                date = new DateTime(year2, month2, day2, hour2, minute2, beginTime.Second);
                int num2 = Date.Year;
                int month3 = Date.Month;
                int day3 = Date.Day;
                int hour3 = dICSHIFT.EndTime.Hour;
                int minute3 = dICSHIFT.EndTime.Minute;
                beginTime = dICSHIFT.EndTime;
                dateTime = new DateTime(num2, month3, day3, hour3, minute3, beginTime.Second);
                if (dICSHIFT.IsBreakOvernight)
                {
                    date = DateAndTime.DateAdd(DateInterval.Day, 1, date);
                    dateTime = DateAndTime.DateAdd(DateInterval.Day, 1, dateTime);
                }
            }
            else
            {
                int year3 = Date.Year;
                int num3 = Date.Month;
                int day4 = Date.Day;
                int hour4 = dICSHIFT.BeginTime.Hour;
                int minute4 = dICSHIFT.BeginTime.Minute;
                beginTime = dICSHIFT.BeginTime;
                date = new DateTime(year3, num3, day4, hour4, minute4, beginTime.Second);
                int year4 = Date.Year;
                int month4 = Date.Month;
                int num4 = Date.Day;
                int hour5 = dICSHIFT.BreakBeginTime.Hour;
                int minute5 = dICSHIFT.BreakBeginTime.Minute;
                beginTime = dICSHIFT.BreakBeginTime;
                dateTime = new DateTime(year4, month4, num4, hour5, minute5, beginTime.Second);
            }
            if (Symbol == "+")
            {
                if ((TimeOut >= dateTime ? true : !(ShiftCode != "")))
                {
                    this.m_EarlyMinute = 0;
                }
                else
                {
                    num1 =Perfect.Utils. MyDateTime.NumberMinute(dateTime, TimeOut);
                }
                num = ((TimeIn <= date ? true : !(ShiftCode != "")) ? 0 : Perfect.Utils. MyDateTime.NumberMinute(date, TimeIn));
             }
            this.Get(TimeKeeperTableListID, EmployeeCode, ShiftCode, Symbol, Date, TimeIn, TimeOut, date, dateTime, num, num1);
        }

        public void Get(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, string Symbol, DateTime Date, int LateMinute, int EarlyMinute)
        {
            DateTime now = DateTime.Now;
            DateTime dateTime = DateTime.Now;
            DIC_SHIFT dICSHIFT = new DIC_SHIFT();
            dICSHIFT.Get(ShiftCode);
            int year = Date.Year;
            int month = Date.Month;
            int day = Date.Day;
            int hour = dICSHIFT.BeginTime.Hour;
            int minute = dICSHIFT.BeginTime.Minute;
            DateTime beginTime = dICSHIFT.BeginTime;
            DateTime dateTime1 = new DateTime(year, month, day, hour, minute, beginTime.Second);
            int num = Date.Year;
            int month1 = Date.Month;
            int day1 = Date.Day;
            int hour1 = dICSHIFT.EndTime.Hour;
            int minute1 = dICSHIFT.EndTime.Minute;
            beginTime = dICSHIFT.EndTime;
            DateTime dateTime2 = new DateTime(num, month1, day1, hour1, minute1, beginTime.Second);
            if (dICSHIFT.IsOvernight)
            {
                dateTime2 = DateAndTime.DateAdd(DateInterval.Day, 1, dateTime2);
            }
            if (!(Symbol == "+"))
            {
                now = dateTime1;
                dateTime = dateTime2;
            }
            else
            {
                now = Perfect.Utils. MyDateTime.AddMinute(dateTime1, LateMinute);
                dateTime = Perfect.Utils.MyDateTime.MinusMinute(dateTime2, EarlyMinute);
            }
            this.Get(TimeKeeperTableListID, EmployeeCode, ShiftCode, Symbol, Date, now, dateTime, dateTime1, dateTime2, LateMinute, EarlyMinute);
        }

        public void Get(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, string Symbol, DateTime Date, DateTime TimeIn, DateTime TimeOut, DateTime TimeInShift, DateTime TimeOutShift, int LateMinute, int EarlyMinute)
        {
            double num = 0;
            double num1 = 0;
            double num2 = 0;
            double num3 = 0;
            double num4 = 0;
            if (TimeOut > TimeIn)
            {
                if (!(!(TimeIn >= TimeInShift) || !(TimeOut <= TimeOutShift) ? true : !(ShiftCode != "")))
                {
                    num = Perfect.Utils. MyDateTime.NumberHour(TimeIn, TimeOut);
                }
                else if (!(!(TimeIn < TimeInShift) || !(TimeOut > TimeOutShift) ? true : !(ShiftCode != "")))
                {
                    num = Perfect.Utils. MyDateTime.NumberHour(TimeInShift, TimeOutShift);
                }
                else if ((!(TimeIn < TimeInShift) || !(TimeOut <= TimeOutShift) ? true : !(ShiftCode != "")))
                {
                    num = ((!(TimeIn >= TimeInShift) || !(TimeOut > TimeOutShift) ? true : !(ShiftCode != "")) ? Perfect.Utils. MyDateTime.NumberHour(TimeIn, TimeOut) :Perfect.Utils. MyDateTime.NumberHour(TimeIn, TimeOutShift));
                }
                else
                {
                    num = Perfect.Utils. MyDateTime.NumberHour(TimeInShift, TimeOut);
                }
                double num5 = (new HRM_TIMEKEEPER_BREAK()).TotalBreakHour(TimeKeeperTableListID, EmployeeCode, ShiftCode, Date);
                num -= num5;
                DIC_TIMEKEEPER_FORMULA dICTIMEKEEPERFORMULA = new DIC_TIMEKEEPER_FORMULA();
                dICTIMEKEEPERFORMULA.Get();
                DateTime dateTime = new DateTime(TimeIn.Year, TimeIn.Month, TimeIn.Day, 0, 0, 0);
                int year = TimeIn.Year;
                int month = TimeIn.Month;
                int day = TimeIn.Day;
                int hour = dICTIMEKEEPERFORMULA.EndTimeNight.Hour;
                int minute = dICTIMEKEEPERFORMULA.EndTimeNight.Minute;
                DateTime endTimeNight = dICTIMEKEEPERFORMULA.EndTimeNight;
                DateTime dateTime1 = new DateTime(year, month, day, hour, minute, endTimeNight.Second);
                int year1 = TimeIn.Year;
                int month1 = TimeIn.Month;
                int day1 = TimeIn.Day;
                int hour1 = dICTIMEKEEPERFORMULA.BeginTimeNight.Hour;
                int minute1 = dICTIMEKEEPERFORMULA.BeginTimeNight.Minute;
                endTimeNight = dICTIMEKEEPERFORMULA.BeginTimeNight;
                DateTime dateTime2 = new DateTime(year1, month1, day1, hour1, minute1, endTimeNight.Second);
                DateTime dateTime3 = DateAndTime.DateAdd(DateInterval.Day, 1, TimeIn);
                int year2 = dateTime3.Year;
                int month2 = dateTime3.Month;
                int day2 = dateTime3.Day;
                int hour2 = dICTIMEKEEPERFORMULA.EndTimeNight.Hour;
                int minute2 = dICTIMEKEEPERFORMULA.EndTimeNight.Minute;
                endTimeNight = dICTIMEKEEPERFORMULA.EndTimeNight;
                DateTime dateTime4 = new DateTime(year2, month2, day2, hour2, minute2, endTimeNight.Second);
                if (TimeIn >= dateTime1)
                {
                    num3 = 0;
                }
                else if (!(!(TimeIn >= dateTime) || !(TimeOut <= dateTime1) ? true : !(TimeOut >= dateTime)))
                {
                    num3 = Perfect.Utils. MyDateTime.NumberHour(TimeIn, TimeOut);
                }
                else if (!(TimeIn < dateTime ? true : !(TimeOut > dateTime1)))
                {
                    num3 =Perfect.Utils. MyDateTime.NumberHour(TimeIn, dateTime1);
                }
                else if ((TimeIn >= dateTime ? true : !(TimeOut > dateTime1)))
                {
                    num3 = ((!(TimeIn < dateTime) || !(TimeOut <= dateTime1) ? true : !(TimeOut >= dateTime)) ? 0 :Perfect.Utils. MyDateTime.NumberHour(dateTime, TimeOut));
                }
                else
                {
                    num3 =Perfect.Utils. MyDateTime.NumberHour(dateTime, dateTime1);
                }
                if (TimeOut <= dateTime2)
                {
                    num4 = 0;
                }
                else if (!(!(TimeIn >= dateTime2) || !(TimeOut <= dateTime4) ? true : !(TimeOut >= dateTime2)))
                {
                    num4 =Perfect.Utils. MyDateTime.NumberHour(TimeIn, TimeOut);
                }
                else if (!(TimeIn < dateTime2 ? true : !(TimeOut > dateTime4)))
                {
                    num4 =Perfect.Utils. MyDateTime.NumberHour(TimeIn, dateTime4);
                }
                else if ((TimeIn >= dateTime2 ? true : !(TimeOut > dateTime4)))
                {
                    num4 = ((!(TimeIn < dateTime2) || !(TimeOut <= dateTime4) ? true : !(TimeOut >= dateTime2)) ? 0 : Perfect.Utils.MyDateTime.NumberHour(dateTime2, TimeOut));
                }
                else
                {
                    num4 = Perfect.Utils.MyDateTime.NumberHour(dateTime2, dateTime4);
                }
                num2 = num3 + num4;
                if (num2 - num5 > 0)
                {
                    num2 -= num5;
                }
                num1 = num - num2;
                if ((Symbol == "+" ? false : ShiftCode != ""))
                {
                    TimeIn = TimeInShift;
                    TimeOut = TimeOutShift;
                    num = 0;
                    num1 = 0;
                    num2 = 0;
                    LateMinute = 0;
                    EarlyMinute = 0;
                }
                if (num < 0)
                {
                    num = 0;
                }
                if (num1 < 0)
                {
                    num1 = 0;
                }
                if (num2 < 0)
                {
                    num2 = 0;
                }
            }
            this.m_ShiftCode = ShiftCode;
            this.m_Symbol = Symbol;
            this.m_Date = Date;
            this.m_TimeIn = TimeIn;
            this.m_TimeOut = TimeOut;
            this.m_Hour = num;
            this.m_DayHour = num1;
            this.m_NightHour = num2;
            this.m_LateMinute = LateMinute;
            this.m_EarlyMinute = EarlyMinute;
        }

        public string GetByShift(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date)
        {
            string str = "";
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_GetByShift", strArrays, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_ShiftCode = Convert.ToString(sqlDataReader["ShiftCode"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Symbol = Convert.ToString(sqlDataReader["Symbol"]);
                    this.m_TimeIn = Convert.ToDateTime(sqlDataReader["TimeIn"]);
                    this.m_TimeOut = Convert.ToDateTime(sqlDataReader["TimeOut"]);
                    this.m_Hour = Convert.ToDouble(sqlDataReader["Hour"]);
                    this.m_DayHour = Convert.ToDouble(sqlDataReader["DayHour"]);
                    this.m_NightHour = Convert.ToDouble(sqlDataReader["NightHour"]);
                    this.m_PrivateHour = Convert.ToDouble(sqlDataReader["PrivateHour"]);
                    this.m_LateMinute = Convert.ToInt32(sqlDataReader["LateMinute"]);
                    this.m_EarlyMinute = Convert.ToInt32(sqlDataReader["EarlyMinute"]);
                    this.m_IsOverTime = Convert.ToBoolean(sqlDataReader["IsOverTime"]);
                    this.m_IsWork = Convert.ToBoolean(sqlDataReader["IsWork"]);
                    this.m_Sorted = Convert.ToInt32(sqlDataReader["Sorted"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_GetList");
        }

        public DataTable GetListByDate(string EmployeeCode, DateTime Date)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Date" };
            object[] employeeCode = new object[] { EmployeeCode, Date };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_GetListByDate", strArrays, employeeCode);
        }

        public DataTable GetListByDate1(string EmployeeCode, DateTime Date)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Date" };
            object[] employeeCode = new object[] { EmployeeCode, Date };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable("Select ht.*,ds.ShiftName From [HRM_TIMEKEEPER] ht inner join DIC_SHIFT ds\r\n\ton ht.ShiftCode=ds.ShiftCode\r\n\twhere EmployeeCode=@EmployeeCode and day([Date])=day(@Date)\r\n\t\t\t\t\t\t\t\t\tand month([Date])=month(@Date)\r\n\t\t\t\t\t\t\t\t\tand year([Date])=year(@Date)\r\n\t\t\t\t\t\t\tand ds.ShiftCode<>'' and ht.Symbol<>'' and ht.Symbol<>'CN' and ht.Symbol<>'T7' and ht.Symbol<>'L'\r\n--\t\t\t\t\t\t\tand IsWork=1", strArrays, employeeCode);
        }

        public DataTable GetListByDate2(string EmployeeCode, DateTime Date)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Date" };
            object[] employeeCode = new object[] { EmployeeCode, Date };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable("Select ht.*,ds.ShiftName From [HRM_TIMEKEEPER] ht inner join DIC_SHIFT ds\r\n\ton ht.ShiftCode=ds.ShiftCode\r\n\twhere EmployeeCode=@EmployeeCode and day([Date])=day(@Date)\r\n\t\t\t\t\t\t\t\t\tand month([Date])=month(@Date)\r\n\t\t\t\t\t\t\t\t\tand year([Date])=year(@Date)\r\n\t\t\t\t\t\t\tand ds.ShiftCode<>''", strArrays, employeeCode);
        }

        public DataTable GetListByEmployee(string EmployeeCode, int Month, int Year)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Month", "@Year" };
            object[] employeeCode = new object[] { EmployeeCode, Month, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_GetListByEmployee", strArrays, employeeCode);
        }

        public DataTable GetListByShift(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_GetByShift", strArrays, timeKeeperTableListID);
        }

        public DataTable GetListBySymbol(int Level, string Code, int Year, string Symbol)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@Year", "@Symbol" };
            object[] level = new object[] { Level, Code, Year, Symbol };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_GetListBySymbol", strArrays, level);
        }

        public DataTable GetListDate(string EmployeeCode, int Month, int Year)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Month", "@Year" };
            object[] employeeCode = new object[] { EmployeeCode, Month, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_GetListDate", strArrays, employeeCode);
        }

        public DataTable GetListTotalYear(int Level, string Code, int Year, int Filter)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@Year", "@Filter" };
            object[] level = new object[] { Level, Code, Year, Filter };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_GetListTotalYear", strArrays, level);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol", "@TimeIn", "@TimeOut", "@Hour", "@DayHour", "@NightHour", "@PrivateHour", "@LateMinute", "@EarlyMinute", "@IsOverTime", "@IsWork", "@Sorted", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_Symbol, this.m_TimeIn, this.m_TimeOut, this.m_Hour, this.m_DayHour, this.m_NightHour, this.m_PrivateHour, this.m_LateMinute, this.m_EarlyMinute, this.m_IsOverTime, this.m_IsWork, this.m_Sorted, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_Insert", strArrays1, mTimeKeeperTableListID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol", "@TimeIn", "@TimeOut", "@Hour", "@DayHour", "@NightHour", "@PrivateHour", "@LateMinute", "@EarlyMinute", "@IsOverTime", "@IsWork", "@Sorted", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_Symbol, this.m_TimeIn, this.m_TimeOut, this.m_Hour, this.m_DayHour, this.m_NightHour, this.m_PrivateHour, this.m_LateMinute, this.m_EarlyMinute, this.m_IsOverTime, this.m_IsWork, this.m_Sorted, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_Insert", strArrays1, mTimeKeeperTableListID);
        }

        public string Insert(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol, DateTime TimeIn, DateTime TimeOut, double Hour, double DayHour, double NightHour, double PrivateHour, int LateMinute, int EarlyMinute, bool IsOverTime, bool IsWork, int Sorted, string Description)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol", "@TimeIn", "@TimeOut", "@Hour", "@DayHour", "@NightHour", "@PrivateHour", "@LateMinute", "@EarlyMinute", "@IsOverTime", "@IsWork", "@Sorted", "@Description" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol, TimeIn, TimeOut, Hour, DayHour, NightHour, PrivateHour, LateMinute, EarlyMinute, IsOverTime, IsWork, Sorted, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_Insert", strArrays1, timeKeeperTableListID);
        }

        public string Insert(SqlConnection myConnection, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol, DateTime TimeIn, DateTime TimeOut, double Hour, double DayHour, double NightHour, double PrivateHour, int LateMinute, int EarlyMinute, bool IsOverTime, bool IsWork, int Sorted, string Description)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol", "@TimeIn", "@TimeOut", "@Hour", "@DayHour", "@NightHour", "@PrivateHour", "@LateMinute", "@EarlyMinute", "@IsOverTime", "@IsWork", "@Sorted", "@Description" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol, TimeIn, TimeOut, Hour, DayHour, NightHour, PrivateHour, LateMinute, EarlyMinute, IsOverTime, IsWork, Sorted, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_TIMEKEEPER_Insert", strArrays1, timeKeeperTableListID);
        }

        public string Insert(SqlTransaction myTransaction, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol, DateTime TimeIn, DateTime TimeOut, double Hour, double DayHour, double NightHour, double PrivateHour, int LateMinute, int EarlyMinute, bool IsOverTime, bool IsWork, int Sorted, string Description)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol", "@TimeIn", "@TimeOut", "@Hour", "@DayHour", "@NightHour", "@PrivateHour", "@LateMinute", "@EarlyMinute", "@IsOverTime", "@IsWork", "@Sorted", "@Description" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol, TimeIn, TimeOut, Hour, DayHour, NightHour, PrivateHour, LateMinute, EarlyMinute, IsOverTime, IsWork, Sorted, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_Insert", strArrays1, timeKeeperTableListID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_TIMEKEEPER", "TimeKeeperTableListID", "CV");
        }

        public static int ShiftAbsentDay(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode)
        {
            int num = 0;
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_ShiftAbsentDay", strArrays, timeKeeperTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToInt32(sqlDataReader["ShiftAbsentDay"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public static int ShiftEarlyMinute(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode)
        {
            int num = 0;
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_ShiftEarlyMinute", strArrays, timeKeeperTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToInt32(sqlDataReader["ShiftEarlyMinute"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public static int ShiftFurloughDay(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode)
        {
            int num = 0;
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_ShiftFurloughDay", strArrays, timeKeeperTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToInt32(sqlDataReader["ShiftFurloughDay"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public static int ShiftLateMinute(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode)
        {
            int num = 0;
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_ShiftLateMinute", strArrays, timeKeeperTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToInt32(sqlDataReader["ShiftLateMinute"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public static double ShiftTotalHour(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode)
        {
            double num = 0;
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_ShiftTotalHour", strArrays, timeKeeperTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToDouble(sqlDataReader["ShiftTotalHour"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol", "@TimeIn", "@TimeOut", "@Hour", "@DayHour", "@NightHour", "@PrivateHour", "@LateMinute", "@EarlyMinute", "@IsOverTime", "@IsWork", "@Sorted", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_Symbol, this.m_TimeIn, this.m_TimeOut, this.m_Hour, this.m_DayHour, this.m_NightHour, this.m_PrivateHour, this.m_LateMinute, this.m_EarlyMinute, this.m_IsOverTime, this.m_IsWork, this.m_Sorted, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_Update", strArrays1, mTimeKeeperTableListID);
        }

        public string Update(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol, DateTime TimeIn, DateTime TimeOut, double Hour, double DayHour, double NightHour, double PrivateHour, int LateMinute, int EarlyMinute, bool IsOverTime, bool IsWork, int Sorted, string Description)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol", "@TimeIn", "@TimeOut", "@Hour", "@DayHour", "@NightHour", "@PrivateHour", "@LateMinute", "@EarlyMinute", "@IsOverTime", "@IsWork", "@Sorted", "@Description" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol, TimeIn, TimeOut, Hour, DayHour, NightHour, PrivateHour, LateMinute, EarlyMinute, IsOverTime, IsWork, Sorted, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_Update", strArrays1, timeKeeperTableListID);
        }

        public string Update(SqlConnection myConnection, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol, DateTime TimeIn, DateTime TimeOut, double Hour, double DayHour, double NightHour, double PrivateHour, int LateMinute, int EarlyMinute, bool IsOverTime, bool IsWork, int Sorted, string Description)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol", "@TimeIn", "@TimeOut", "@Hour", "@DayHour", "@NightHour", "@PrivateHour", "@LateMinute", "@EarlyMinute", "@IsOverTime", "@IsWork", "@Sorted", "@Description" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol, TimeIn, TimeOut, Hour, DayHour, NightHour, PrivateHour, LateMinute, EarlyMinute, IsOverTime, IsWork, Sorted, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_TIMEKEEPER_Update", strArrays1, timeKeeperTableListID);
        }

        public string Update(SqlTransaction myTransaction, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol, DateTime TimeIn, DateTime TimeOut, double Hour, double DayHour, double NightHour, double PrivateHour, int LateMinute, int EarlyMinute, bool IsOverTime, bool IsWork, int Sorted, string Description)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol", "@TimeIn", "@TimeOut", "@Hour", "@DayHour", "@NightHour", "@PrivateHour", "@LateMinute", "@EarlyMinute", "@IsOverTime", "@IsWork", "@Sorted", "@Description" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol, TimeIn, TimeOut, Hour, DayHour, NightHour, PrivateHour, LateMinute, EarlyMinute, IsOverTime, IsWork, Sorted, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_Update", strArrays1, timeKeeperTableListID);
        }

        public string UpdateSymbol(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, string Symbol, DateTime TimeIn, DateTime TimeOut, double Hour, double DayHour, double NightHour, double PrivateHour, int LateMinute, int EarlyMinute, bool IsOverTime, bool IsWork, int Sorted, string Description)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@Symbol", "@TimeIn", "@TimeOut", "@Hour", "@DayHour", "@NightHour", "@PrivateHour", "@LateMinute", "@EarlyMinute", "@IsOverTime", "@IsWork", "@Sorted", "@Description" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, Symbol, TimeIn, TimeOut, Hour, DayHour, NightHour, PrivateHour, LateMinute, EarlyMinute, IsOverTime, IsWork, Sorted, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_UpdateSymbol", strArrays1, timeKeeperTableListID);
        }

    }
}
