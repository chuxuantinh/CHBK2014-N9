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
 public   class DIC_SHIFT
    {

        private string m_ShiftCode;

        private string m_ShiftName;

        private DateTime m_BeginTime;

        private DateTime m_EndTime;

        private bool m_IsOvernight;

        private DateTime m_BeginTime1;

        private DateTime m_BeginTime2;

        private DateTime m_EndTime1;

        private DateTime m_EndTime2;

        private int m_LateMinute;

        private int m_EarlyMinute;

        private bool m_IsBreak;

        private bool m_IsBreakOvernight;

        private DateTime m_BreakBeginTime;

        private DateTime m_BreakEndTime;

        private int m_TotalMinute;

        private double m_TotalHour;

        private int m_HalfWorkMinute;

        private int m_WorkMinute;

        private double m_WorkDay;

        private int m_MethodCheck;

        private bool m_IsBOT;

        private bool m_IsAOT;

        private int m_MinimumMinuteBOT;

        private int m_MaximumMinuteBOT;

        private int m_DistanceMinuteBOT;

        private int m_MinimumMinuteAOT;

        private int m_MaximumMinuteAOT;

        private int m_DistanceMinuteAOT;

        private bool m_IsNightDutyDay;

        private string m_Description;

        [Category("Column")]
        [DisplayName("BeginTime")]
        public DateTime BeginTime
        {
            get
            {
                return this.m_BeginTime;
            }
            set
            {
                this.m_BeginTime = value;
            }
        }

        [Category("Column")]
        [DisplayName("BeginTime1")]
        public DateTime BeginTime1
        {
            get
            {
                return this.m_BeginTime1;
            }
            set
            {
                this.m_BeginTime1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("BeginTime2")]
        public DateTime BeginTime2
        {
            get
            {
                return this.m_BeginTime2;
            }
            set
            {
                this.m_BeginTime2 = value;
            }
        }

        [Category("Column")]
        [DisplayName("BreakBeginTime")]
        public DateTime BreakBeginTime
        {
            get
            {
                return this.m_BreakBeginTime;
            }
            set
            {
                this.m_BreakBeginTime = value;
            }
        }

        [Category("Column")]
        [DisplayName("BreakEndTime")]
        public DateTime BreakEndTime
        {
            get
            {
                return this.m_BreakEndTime;
            }
            set
            {
                this.m_BreakEndTime = value;
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
        [DisplayName("DistanceMinuteAOT")]
        public int DistanceMinuteAOT
        {
            get
            {
                return this.m_DistanceMinuteAOT;
            }
            set
            {
                this.m_DistanceMinuteAOT = value;
            }
        }

        [Category("Column")]
        [DisplayName("DistanceMinuteBOT")]
        public int DistanceMinuteBOT
        {
            get
            {
                return this.m_DistanceMinuteBOT;
            }
            set
            {
                this.m_DistanceMinuteBOT = value;
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

        [Category("Column")]
        [DisplayName("EndTime")]
        public DateTime EndTime
        {
            get
            {
                return this.m_EndTime;
            }
            set
            {
                this.m_EndTime = value;
            }
        }

        [Category("Column")]
        [DisplayName("EndTime1")]
        public DateTime EndTime1
        {
            get
            {
                return this.m_EndTime1;
            }
            set
            {
                this.m_EndTime1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("EndTime2")]
        public DateTime EndTime2
        {
            get
            {
                return this.m_EndTime2;
            }
            set
            {
                this.m_EndTime2 = value;
            }
        }

        [Category("Column")]
        [DisplayName("HalfWorkMinute")]
        public int HalfWorkMinute
        {
            get
            {
                return this.m_HalfWorkMinute;
            }
            set
            {
                this.m_HalfWorkMinute = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsAOT")]
        public bool IsAOT
        {
            get
            {
                return this.m_IsAOT;
            }
            set
            {
                this.m_IsAOT = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsBOT")]
        public bool IsBOT
        {
            get
            {
                return this.m_IsBOT;
            }
            set
            {
                this.m_IsBOT = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsBreak")]
        public bool IsBreak
        {
            get
            {
                return this.m_IsBreak;
            }
            set
            {
                this.m_IsBreak = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsBreakOvernight")]
        public bool IsBreakOvernight
        {
            get
            {
                return this.m_IsBreakOvernight;
            }
            set
            {
                this.m_IsBreakOvernight = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsNightDutyDay")]
        public bool IsNightDutyDay
        {
            get
            {
                return this.m_IsNightDutyDay;
            }
            set
            {
                this.m_IsNightDutyDay = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsOvernight")]
        public bool IsOvernight
        {
            get
            {
                return this.m_IsOvernight;
            }
            set
            {
                this.m_IsOvernight = value;
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
        [DisplayName("MaximumMinuteAOT")]
        public int MaximumMinuteAOT
        {
            get
            {
                return this.m_MaximumMinuteAOT;
            }
            set
            {
                this.m_MaximumMinuteAOT = value;
            }
        }

        [Category("Column")]
        [DisplayName("MaximumMinuteBOT")]
        public int MaximumMinuteBOT
        {
            get
            {
                return this.m_MaximumMinuteBOT;
            }
            set
            {
                this.m_MaximumMinuteBOT = value;
            }
        }

        [Category("Column")]
        [DisplayName("MethodCheck")]
        public int MethodCheck
        {
            get
            {
                return this.m_MethodCheck;
            }
            set
            {
                this.m_MethodCheck = value;
            }
        }

        [Category("Column")]
        [DisplayName("MinimumMinuteAOT")]
        public int MinimumMinuteAOT
        {
            get
            {
                return this.m_MinimumMinuteAOT;
            }
            set
            {
                this.m_MinimumMinuteAOT = value;
            }
        }

        [Category("Column")]
        [DisplayName("MinimumMinuteBOT")]
        public int MinimumMinuteBOT
        {
            get
            {
                return this.m_MinimumMinuteBOT;
            }
            set
            {
                this.m_MinimumMinuteBOT = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_SHIFT";
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
        [DisplayName("ShiftName")]
        public string ShiftName
        {
            get
            {
                return this.m_ShiftName;
            }
            set
            {
                this.m_ShiftName = value;
            }
        }

        [Category("Column")]
        [DisplayName("TotalHour")]
        public double TotalHour
        {
            get
            {
                return this.m_TotalHour;
            }
            set
            {
                this.m_TotalHour = value;
            }
        }

        [Category("Column")]
        [DisplayName("TotalMinute")]
        public int TotalMinute
        {
            get
            {
                return this.m_TotalMinute;
            }
            set
            {
                this.m_TotalMinute = value;
            }
        }

        [Category("Column")]
        [DisplayName("WorkDay")]
        public double WorkDay
        {
            get
            {
                return this.m_WorkDay;
            }
            set
            {
                this.m_WorkDay = value;
            }
        }

        [Category("Column")]
        [DisplayName("WorkMinute")]
        public int WorkMinute
        {
            get
            {
                return this.m_WorkMinute;
            }
            set
            {
                this.m_WorkMinute = value;
            }
        }

        public DIC_SHIFT()
        {
            this.m_ShiftCode = "";
            this.m_ShiftName = "";
            this.m_BeginTime = DateTime.Now;
            this.m_EndTime = DateTime.Now;
            this.m_IsOvernight = true;
            this.m_BeginTime1 = DateTime.Now;
            this.m_BeginTime2 = DateTime.Now;
            this.m_EndTime1 = DateTime.Now;
            this.m_EndTime2 = DateTime.Now;
            this.m_LateMinute = 0;
            this.m_EarlyMinute = 0;
            this.m_IsBreak = true;
            this.m_IsBreakOvernight = true;
            this.m_BreakBeginTime = DateTime.Now;
            this.m_BreakEndTime = DateTime.Now;
            this.m_TotalMinute = 0;
            this.m_TotalHour = 0;
            this.m_HalfWorkMinute = 0;
            this.m_WorkMinute = 0;
            this.m_WorkDay = 0;
            this.m_MethodCheck = 2;
            this.m_IsBOT = true;
            this.m_IsAOT = true;
            this.m_MinimumMinuteBOT = 0;
            this.m_MaximumMinuteBOT = 0;
            this.m_DistanceMinuteBOT = 0;
            this.m_MinimumMinuteAOT = 0;
            this.m_MaximumMinuteAOT = 0;
            this.m_DistanceMinuteAOT = 0;
            this.m_IsNightDutyDay = true;
            this.m_Description = "";
        }

        public DIC_SHIFT(string ShiftCode, string ShiftName, DateTime BeginTime, DateTime EndTime, bool IsOvernight, DateTime BeginTime1, DateTime BeginTime2, DateTime EndTime1, DateTime EndTime2, int LateMinute, int EarlyMinute, bool IsBreak, bool IsBreakOvernight, DateTime BreakBeginTime, DateTime BreakEndTime, int TotalMinute, double TotalHour, int HalfWorkMinute, int WorkMinute, double WorkDay, int MethodCheck, bool IsBOT, bool IsAOT, int MinimumMinuteBOT, int MaximumMinuteBOT, int DistanceMinuteBOT, int MinimumMinuteAOT, int MaximumMinuteAOT, int DistanceMinuteAOT, bool IsNightDutyDay, string Description)
        {
            this.m_ShiftCode = ShiftCode;
            this.m_ShiftName = ShiftName;
            this.m_BeginTime = BeginTime;
            this.m_EndTime = EndTime;
            this.m_IsOvernight = IsOvernight;
            this.m_BeginTime1 = BeginTime1;
            this.m_BeginTime2 = BeginTime2;
            this.m_EndTime1 = EndTime1;
            this.m_EndTime2 = EndTime2;
            this.m_LateMinute = LateMinute;
            this.m_EarlyMinute = EarlyMinute;
            this.m_IsBreak = IsBreak;
            this.m_IsBreakOvernight = IsBreakOvernight;
            this.m_BreakBeginTime = BreakBeginTime;
            this.m_BreakEndTime = BreakEndTime;
            this.m_TotalMinute = TotalMinute;
            this.m_TotalHour = TotalHour;
            this.m_HalfWorkMinute = HalfWorkMinute;
            this.m_WorkMinute = WorkMinute;
            this.m_WorkDay = WorkDay;
            this.m_MethodCheck = MethodCheck;
            this.m_IsBOT = IsBOT;
            this.m_IsAOT = IsAOT;
            this.m_MinimumMinuteBOT = MinimumMinuteBOT;
            this.m_MaximumMinuteBOT = MaximumMinuteBOT;
            this.m_DistanceMinuteBOT = DistanceMinuteBOT;
            this.m_MinimumMinuteAOT = MinimumMinuteAOT;
            this.m_MaximumMinuteAOT = MaximumMinuteAOT;
            this.m_DistanceMinuteAOT = DistanceMinuteAOT;
            this.m_IsNightDutyDay = IsNightDutyDay;
            this.m_Description = Description;
        }

        public void AddCheckedListBox(CheckedListBoxControl checkList)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                CheckedListBoxItem checkedListBoxItem = new CheckedListBoxItem();
                string[] str = new string[] { row["ShiftName"].ToString(), " - ", row["ShiftCode"].ToString(), " (", null, null, null, null };
                DateTime dateTime = DateTime.Parse(row["BeginTime"].ToString());
                str[4] = dateTime.ToString("HH:mm tt");
                str[5] = "->";
                dateTime = DateTime.Parse(row["EndTime"].ToString());
                str[6] = dateTime.ToString("HH:mm tt");
                str[7] = ")";
                checkedListBoxItem.Description = string.Concat(str);
                checkedListBoxItem.Value = row["ShiftCode"].ToString();
                checkList.Items.Add(checkedListBoxItem);
            }
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "ShiftName", "ShiftCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["ShiftCode"] = "All";
        //    dataRow["ShiftName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "ShiftName", "ShiftCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["ShiftName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "ShiftName";
            gridlookup.Properties.ValueMember = "ShiftCode";
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@ShiftCode" };
            object[] mShiftCode = new object[] { this.m_ShiftCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SHIFT_Delete", strArrays, mShiftCode);
        }

        public string Delete(string ShiftCode)
        {
            string[] strArrays = new string[] { "@ShiftCode" };
            object[] shiftCode = new object[] { ShiftCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SHIFT_Delete", strArrays, shiftCode);
        }

        public string Delete(SqlConnection myConnection, string ShiftCode)
        {
            string[] strArrays = new string[] { "@ShiftCode" };
            object[] shiftCode = new object[] { ShiftCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SHIFT_Delete", strArrays, shiftCode);
        }

        public string Delete(SqlTransaction myTransaction, string ShiftCode)
        {
            string[] strArrays = new string[] { "@ShiftCode" };
            object[] shiftCode = new object[] { ShiftCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SHIFT_Delete", strArrays, shiftCode);
        }

        public bool Exist(string ShiftCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ShiftCode" };
            object[] shiftCode = new object[] { ShiftCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SHIFT_Get", strArrays, shiftCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool ExistNightDay(string ShiftCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ShiftCode" };
            object[] shiftCode = new object[] { ShiftCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("select ShiftCode from DIC_SHIFT\r\n where IsNightDutyDay=1 and ShiftCode<>@ShiftCode", strArrays, shiftCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string ShiftCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ShiftCode" };
            object[] shiftCode = new object[] { ShiftCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SHIFT_Get", strArrays, shiftCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ShiftCode = Convert.ToString(sqlDataReader["ShiftCode"]);
                    this.m_ShiftName = Convert.ToString(sqlDataReader["ShiftName"]);
                    this.m_BeginTime = Convert.ToDateTime(sqlDataReader["BeginTime"]);
                    this.m_EndTime = Convert.ToDateTime(sqlDataReader["EndTime"]);
                    this.m_IsOvernight = Convert.ToBoolean(sqlDataReader["IsOvernight"]);
                    this.m_BeginTime1 = Convert.ToDateTime(sqlDataReader["BeginTime1"]);
                    this.m_BeginTime2 = Convert.ToDateTime(sqlDataReader["BeginTime2"]);
                    this.m_EndTime1 = Convert.ToDateTime(sqlDataReader["EndTime1"]);
                    this.m_EndTime2 = Convert.ToDateTime(sqlDataReader["EndTime2"]);
                    this.m_LateMinute = Convert.ToInt32(sqlDataReader["LateMinute"]);
                    this.m_EarlyMinute = Convert.ToInt32(sqlDataReader["EarlyMinute"]);
                    this.m_IsBreak = Convert.ToBoolean(sqlDataReader["IsBreak"]);
                    this.m_IsBreakOvernight = Convert.ToBoolean(sqlDataReader["IsBreakOvernight"]);
                    this.m_BreakBeginTime = Convert.ToDateTime(sqlDataReader["BreakBeginTime"]);
                    this.m_BreakEndTime = Convert.ToDateTime(sqlDataReader["BreakEndTime"]);
                    this.m_TotalMinute = Convert.ToInt32(sqlDataReader["TotalMinute"]);
                    this.m_TotalHour = Convert.ToDouble(sqlDataReader["TotalHour"]);
                    this.m_HalfWorkMinute = Convert.ToInt32(sqlDataReader["HalfWorkMinute"]);
                    this.m_WorkMinute = Convert.ToInt32(sqlDataReader["WorkMinute"]);
                    this.m_WorkDay = Convert.ToDouble(sqlDataReader["WorkDay"]);
                    this.m_MethodCheck = Convert.ToInt32(sqlDataReader["MethodCheck"]);
                    this.m_IsBOT = Convert.ToBoolean(sqlDataReader["IsBOT"]);
                    this.m_IsAOT = Convert.ToBoolean(sqlDataReader["IsAOT"]);
                    this.m_MinimumMinuteBOT = Convert.ToInt32(sqlDataReader["MinimumMinuteBOT"]);
                    this.m_MaximumMinuteBOT = Convert.ToInt32(sqlDataReader["MaximumMinuteBOT"]);
                    this.m_DistanceMinuteBOT = Convert.ToInt32(sqlDataReader["DistanceMinuteBOT"]);
                    this.m_MinimumMinuteAOT = Convert.ToInt32(sqlDataReader["MinimumMinuteAOT"]);
                    this.m_MaximumMinuteAOT = Convert.ToInt32(sqlDataReader["MaximumMinuteAOT"]);
                    this.m_DistanceMinuteAOT = Convert.ToInt32(sqlDataReader["DistanceMinuteAOT"]);
                    this.m_IsNightDutyDay = Convert.ToBoolean(sqlDataReader["IsNightDutyDay"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string ShiftCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ShiftCode" };
            object[] shiftCode = new object[] { ShiftCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_SHIFT_Get", strArrays, shiftCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ShiftCode = Convert.ToString(sqlDataReader["ShiftCode"]);
                    this.m_ShiftName = Convert.ToString(sqlDataReader["ShiftName"]);
                    this.m_BeginTime = Convert.ToDateTime(sqlDataReader["BeginTime"]);
                    this.m_EndTime = Convert.ToDateTime(sqlDataReader["EndTime"]);
                    this.m_IsOvernight = Convert.ToBoolean(sqlDataReader["IsOvernight"]);
                    this.m_BeginTime1 = Convert.ToDateTime(sqlDataReader["BeginTime1"]);
                    this.m_BeginTime2 = Convert.ToDateTime(sqlDataReader["BeginTime2"]);
                    this.m_EndTime1 = Convert.ToDateTime(sqlDataReader["EndTime1"]);
                    this.m_EndTime2 = Convert.ToDateTime(sqlDataReader["EndTime2"]);
                    this.m_LateMinute = Convert.ToInt32(sqlDataReader["LateMinute"]);
                    this.m_EarlyMinute = Convert.ToInt32(sqlDataReader["EarlyMinute"]);
                    this.m_IsBreak = Convert.ToBoolean(sqlDataReader["IsBreak"]);
                    this.m_IsBreakOvernight = Convert.ToBoolean(sqlDataReader["IsBreakOvernight"]);
                    this.m_BreakBeginTime = Convert.ToDateTime(sqlDataReader["BreakBeginTime"]);
                    this.m_BreakEndTime = Convert.ToDateTime(sqlDataReader["BreakEndTime"]);
                    this.m_TotalMinute = Convert.ToInt32(sqlDataReader["TotalMinute"]);
                    this.m_TotalHour = Convert.ToDouble(sqlDataReader["TotalHour"]);
                    this.m_HalfWorkMinute = Convert.ToInt32(sqlDataReader["HalfWorkMinute"]);
                    this.m_WorkMinute = Convert.ToInt32(sqlDataReader["WorkMinute"]);
                    this.m_WorkDay = Convert.ToDouble(sqlDataReader["WorkDay"]);
                    this.m_MethodCheck = Convert.ToInt32(sqlDataReader["MethodCheck"]);
                    this.m_IsBOT = Convert.ToBoolean(sqlDataReader["IsBOT"]);
                    this.m_IsAOT = Convert.ToBoolean(sqlDataReader["IsAOT"]);
                    this.m_MinimumMinuteBOT = Convert.ToInt32(sqlDataReader["MinimumMinuteBOT"]);
                    this.m_MaximumMinuteBOT = Convert.ToInt32(sqlDataReader["MaximumMinuteBOT"]);
                    this.m_DistanceMinuteBOT = Convert.ToInt32(sqlDataReader["DistanceMinuteBOT"]);
                    this.m_MinimumMinuteAOT = Convert.ToInt32(sqlDataReader["MinimumMinuteAOT"]);
                    this.m_MaximumMinuteAOT = Convert.ToInt32(sqlDataReader["MaximumMinuteAOT"]);
                    this.m_DistanceMinuteAOT = Convert.ToInt32(sqlDataReader["DistanceMinuteAOT"]);
                    this.m_IsNightDutyDay = Convert.ToBoolean(sqlDataReader["IsNightDutyDay"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string ShiftCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ShiftCode" };
            object[] shiftCode = new object[] { ShiftCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_SHIFT_Get", strArrays, shiftCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ShiftCode = Convert.ToString(sqlDataReader["ShiftCode"]);
                    this.m_ShiftName = Convert.ToString(sqlDataReader["ShiftName"]);
                    this.m_BeginTime = Convert.ToDateTime(sqlDataReader["BeginTime"]);
                    this.m_EndTime = Convert.ToDateTime(sqlDataReader["EndTime"]);
                    this.m_IsOvernight = Convert.ToBoolean(sqlDataReader["IsOvernight"]);
                    this.m_BeginTime1 = Convert.ToDateTime(sqlDataReader["BeginTime1"]);
                    this.m_BeginTime2 = Convert.ToDateTime(sqlDataReader["BeginTime2"]);
                    this.m_EndTime1 = Convert.ToDateTime(sqlDataReader["EndTime1"]);
                    this.m_EndTime2 = Convert.ToDateTime(sqlDataReader["EndTime2"]);
                    this.m_LateMinute = Convert.ToInt32(sqlDataReader["LateMinute"]);
                    this.m_EarlyMinute = Convert.ToInt32(sqlDataReader["EarlyMinute"]);
                    this.m_IsBreak = Convert.ToBoolean(sqlDataReader["IsBreak"]);
                    this.m_IsBreakOvernight = Convert.ToBoolean(sqlDataReader["IsBreakOvernight"]);
                    this.m_BreakBeginTime = Convert.ToDateTime(sqlDataReader["BreakBeginTime"]);
                    this.m_BreakEndTime = Convert.ToDateTime(sqlDataReader["BreakEndTime"]);
                    this.m_TotalMinute = Convert.ToInt32(sqlDataReader["TotalMinute"]);
                    this.m_TotalHour = Convert.ToDouble(sqlDataReader["TotalHour"]);
                    this.m_HalfWorkMinute = Convert.ToInt32(sqlDataReader["HalfWorkMinute"]);
                    this.m_WorkMinute = Convert.ToInt32(sqlDataReader["WorkMinute"]);
                    this.m_WorkDay = Convert.ToDouble(sqlDataReader["WorkDay"]);
                    this.m_MethodCheck = Convert.ToInt32(sqlDataReader["MethodCheck"]);
                    this.m_IsBOT = Convert.ToBoolean(sqlDataReader["IsBOT"]);
                    this.m_IsAOT = Convert.ToBoolean(sqlDataReader["IsAOT"]);
                    this.m_MinimumMinuteBOT = Convert.ToInt32(sqlDataReader["MinimumMinuteBOT"]);
                    this.m_MaximumMinuteBOT = Convert.ToInt32(sqlDataReader["MaximumMinuteBOT"]);
                    this.m_DistanceMinuteBOT = Convert.ToInt32(sqlDataReader["DistanceMinuteBOT"]);
                    this.m_MinimumMinuteAOT = Convert.ToInt32(sqlDataReader["MinimumMinuteAOT"]);
                    this.m_MaximumMinuteAOT = Convert.ToInt32(sqlDataReader["MaximumMinuteAOT"]);
                    this.m_DistanceMinuteAOT = Convert.ToInt32(sqlDataReader["DistanceMinuteAOT"]);
                    this.m_IsNightDutyDay = Convert.ToBoolean(sqlDataReader["IsNightDutyDay"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_SHIFT_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@ShiftCode", "@ShiftName", "@BeginTime", "@EndTime", "@IsOvernight", "@BeginTime1", "@BeginTime2", "@EndTime1", "@EndTime2", "@LateMinute", "@EarlyMinute", "@IsBreak", "@IsBreakOvernight", "@BreakBeginTime", "@BreakEndTime", "@TotalMinute", "@TotalHour", "@HalfWorkMinute", "@WorkMinute", "@WorkDay", "@MethodCheck", "@IsBOT", "@IsAOT", "@MinimumMinuteBOT", "@MaximumMinuteBOT", "@DistanceMinuteBOT", "@MinimumMinuteAOT", "@MaximumMinuteAOT", "@DistanceMinuteAOT", "@IsNightDutyDay", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mShiftCode = new object[] { this.m_ShiftCode, this.m_ShiftName, this.m_BeginTime, this.m_EndTime, this.m_IsOvernight, this.m_BeginTime1, this.m_BeginTime2, this.m_EndTime1, this.m_EndTime2, this.m_LateMinute, this.m_EarlyMinute, this.m_IsBreak, this.m_IsBreakOvernight, this.m_BreakBeginTime, this.m_BreakEndTime, this.m_TotalMinute, this.m_TotalHour, this.m_HalfWorkMinute, this.m_WorkMinute, this.m_WorkDay, this.m_MethodCheck, this.m_IsBOT, this.m_IsAOT, this.m_MinimumMinuteBOT, this.m_MaximumMinuteBOT, this.m_DistanceMinuteBOT, this.m_MinimumMinuteAOT, this.m_MaximumMinuteAOT, this.m_DistanceMinuteAOT, this.m_IsNightDutyDay, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SHIFT_Insert", strArrays1, mShiftCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@ShiftCode", "@ShiftName", "@BeginTime", "@EndTime", "@IsOvernight", "@BeginTime1", "@BeginTime2", "@EndTime1", "@EndTime2", "@LateMinute", "@EarlyMinute", "@IsBreak", "@IsBreakOvernight", "@BreakBeginTime", "@BreakEndTime", "@TotalMinute", "@TotalHour", "@HalfWorkMinute", "@WorkMinute", "@WorkDay", "@MethodCheck", "@IsBOT", "@IsAOT", "@MinimumMinuteBOT", "@MaximumMinuteBOT", "@DistanceMinuteBOT", "@MinimumMinuteAOT", "@MaximumMinuteAOT", "@DistanceMinuteAOT", "@IsNightDutyDay", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mShiftCode = new object[] { this.m_ShiftCode, this.m_ShiftName, this.m_BeginTime, this.m_EndTime, this.m_IsOvernight, this.m_BeginTime1, this.m_BeginTime2, this.m_EndTime1, this.m_EndTime2, this.m_LateMinute, this.m_EarlyMinute, this.m_IsBreak, this.m_IsBreakOvernight, this.m_BreakBeginTime, this.m_BreakEndTime, this.m_TotalMinute, this.m_TotalHour, this.m_HalfWorkMinute, this.m_WorkMinute, this.m_WorkDay, this.m_MethodCheck, this.m_IsBOT, this.m_IsAOT, this.m_MinimumMinuteBOT, this.m_MaximumMinuteBOT, this.m_DistanceMinuteBOT, this.m_MinimumMinuteAOT, this.m_MaximumMinuteAOT, this.m_DistanceMinuteAOT, this.m_IsNightDutyDay, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SHIFT_Insert", strArrays1, mShiftCode);
        }

        public string Insert(string ShiftCode, string ShiftName, DateTime BeginTime, DateTime EndTime, bool IsOvernight, DateTime BeginTime1, DateTime BeginTime2, DateTime EndTime1, DateTime EndTime2, int LateMinute, int EarlyMinute, bool IsBreak, bool IsBreakOvernight, DateTime BreakBeginTime, DateTime BreakEndTime, int TotalMinute, double TotalHour, int HalfWorkMinute, int WorkMinute, double WorkDay, int MethodCheck, bool IsBOT, bool IsAOT, int MinimumMinuteBOT, int MaximumMinuteBOT, int DistanceMinuteBOT, int MinimumMinuteAOT, int MaximumMinuteAOT, int DistanceMinuteAOT, bool IsNightDutyDay, string Description)
        {
            string[] strArrays = new string[] { "@ShiftCode", "@ShiftName", "@BeginTime", "@EndTime", "@IsOvernight", "@BeginTime1", "@BeginTime2", "@EndTime1", "@EndTime2", "@LateMinute", "@EarlyMinute", "@IsBreak", "@IsBreakOvernight", "@BreakBeginTime", "@BreakEndTime", "@TotalMinute", "@TotalHour", "@HalfWorkMinute", "@WorkMinute", "@WorkDay", "@MethodCheck", "@IsBOT", "@IsAOT", "@MinimumMinuteBOT", "@MaximumMinuteBOT", "@DistanceMinuteBOT", "@MinimumMinuteAOT", "@MaximumMinuteAOT", "@DistanceMinuteAOT", "@IsNightDutyDay", "@Description" };
            string[] strArrays1 = strArrays;
            object[] shiftCode = new object[] { ShiftCode, ShiftName, BeginTime, EndTime, IsOvernight, BeginTime1, BeginTime2, EndTime1, EndTime2, LateMinute, EarlyMinute, IsBreak, IsBreakOvernight, BreakBeginTime, BreakEndTime, TotalMinute, TotalHour, HalfWorkMinute, WorkMinute, WorkDay, MethodCheck, IsBOT, IsAOT, MinimumMinuteBOT, MaximumMinuteBOT, DistanceMinuteBOT, MinimumMinuteAOT, MaximumMinuteAOT, DistanceMinuteAOT, IsNightDutyDay, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SHIFT_Insert", strArrays1, shiftCode);
        }

        public string Insert(SqlConnection myConnection, string ShiftCode, string ShiftName, DateTime BeginTime, DateTime EndTime, bool IsOvernight, DateTime BeginTime1, DateTime BeginTime2, DateTime EndTime1, DateTime EndTime2, int LateMinute, int EarlyMinute, bool IsBreak, bool IsBreakOvernight, DateTime BreakBeginTime, DateTime BreakEndTime, int TotalMinute, double TotalHour, int HalfWorkMinute, int WorkMinute, double WorkDay, int MethodCheck, bool IsBOT, bool IsAOT, int MinimumMinuteBOT, int MaximumMinuteBOT, int DistanceMinuteBOT, int MinimumMinuteAOT, int MaximumMinuteAOT, int DistanceMinuteAOT, bool IsNightDutyDay, string Description)
        {
            string[] strArrays = new string[] { "@ShiftCode", "@ShiftName", "@BeginTime", "@EndTime", "@IsOvernight", "@BeginTime1", "@BeginTime2", "@EndTime1", "@EndTime2", "@LateMinute", "@EarlyMinute", "@IsBreak", "@IsBreakOvernight", "@BreakBeginTime", "@BreakEndTime", "@TotalMinute", "@TotalHour", "@HalfWorkMinute", "@WorkMinute", "@WorkDay", "@MethodCheck", "@IsBOT", "@IsAOT", "@MinimumMinuteBOT", "@MaximumMinuteBOT", "@DistanceMinuteBOT", "@MinimumMinuteAOT", "@MaximumMinuteAOT", "@DistanceMinuteAOT", "@IsNightDutyDay", "@Description" };
            string[] strArrays1 = strArrays;
            object[] shiftCode = new object[] { ShiftCode, ShiftName, BeginTime, EndTime, IsOvernight, BeginTime1, BeginTime2, EndTime1, EndTime2, LateMinute, EarlyMinute, IsBreak, IsBreakOvernight, BreakBeginTime, BreakEndTime, TotalMinute, TotalHour, HalfWorkMinute, WorkMinute, WorkDay, MethodCheck, IsBOT, IsAOT, MinimumMinuteBOT, MaximumMinuteBOT, DistanceMinuteBOT, MinimumMinuteAOT, MaximumMinuteAOT, DistanceMinuteAOT, IsNightDutyDay, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SHIFT_Insert", strArrays1, shiftCode);
        }

        public string Insert(SqlTransaction myTransaction, string ShiftCode, string ShiftName, DateTime BeginTime, DateTime EndTime, bool IsOvernight, DateTime BeginTime1, DateTime BeginTime2, DateTime EndTime1, DateTime EndTime2, int LateMinute, int EarlyMinute, bool IsBreak, bool IsBreakOvernight, DateTime BreakBeginTime, DateTime BreakEndTime, int TotalMinute, double TotalHour, int HalfWorkMinute, int WorkMinute, double WorkDay, int MethodCheck, bool IsBOT, bool IsAOT, int MinimumMinuteBOT, int MaximumMinuteBOT, int DistanceMinuteBOT, int MinimumMinuteAOT, int MaximumMinuteAOT, int DistanceMinuteAOT, bool IsNightDutyDay, string Description)
        {
            string[] strArrays = new string[] { "@ShiftCode", "@ShiftName", "@BeginTime", "@EndTime", "@IsOvernight", "@BeginTime1", "@BeginTime2", "@EndTime1", "@EndTime2", "@LateMinute", "@EarlyMinute", "@IsBreak", "@IsBreakOvernight", "@BreakBeginTime", "@BreakEndTime", "@TotalMinute", "@TotalHour", "@HalfWorkMinute", "@WorkMinute", "@WorkDay", "@MethodCheck", "@IsBOT", "@IsAOT", "@MinimumMinuteBOT", "@MaximumMinuteBOT", "@DistanceMinuteBOT", "@MinimumMinuteAOT", "@MaximumMinuteAOT", "@DistanceMinuteAOT", "@IsNightDutyDay", "@Description" };
            string[] strArrays1 = strArrays;
            object[] shiftCode = new object[] { ShiftCode, ShiftName, BeginTime, EndTime, IsOvernight, BeginTime1, BeginTime2, EndTime1, EndTime2, LateMinute, EarlyMinute, IsBreak, IsBreakOvernight, BreakBeginTime, BreakEndTime, TotalMinute, TotalHour, HalfWorkMinute, WorkMinute, WorkDay, MethodCheck, IsBOT, IsAOT, MinimumMinuteBOT, MaximumMinuteBOT, DistanceMinuteBOT, MinimumMinuteAOT, MaximumMinuteAOT, DistanceMinuteAOT, IsNightDutyDay, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SHIFT_Insert", strArrays1, shiftCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_SHIFT", "ShiftCode", "C", 1);
        }

        public void SetData(string ShiftCode, string ShiftName, DateTime BeginTime, DateTime EndTime, bool IsOvernight, DateTime BeginTime1, DateTime BeginTime2, DateTime EndTime1, DateTime EndTime2, int LateMinute, int EarlyMinute, bool IsBreak, bool IsBreakOvernight, DateTime BreakBeginTime, DateTime BreakEndTime, int TotalMinute, double TotalHour, int HalfWorkMinute, int WorkMinute, double WorkDay, int MethodCheck, bool IsBOT, bool IsAOT, int MinimumMinuteBOT, int MaximumMinuteBOT, int DistanceMinuteBOT, int MinimumMinuteAOT, int MaximumMinuteAOT, int DistanceMinuteAOT, bool IsNightDutyDay, string Description)
        {
            this.m_ShiftCode = ShiftCode;
            this.m_ShiftName = ShiftName;
            this.m_BeginTime = BeginTime;
            this.m_EndTime = EndTime;
            this.m_IsOvernight = IsOvernight;
            this.m_BeginTime1 = BeginTime1;
            this.m_BeginTime2 = BeginTime2;
            this.m_EndTime1 = EndTime1;
            this.m_EndTime2 = EndTime2;
            this.m_LateMinute = LateMinute;
            this.m_EarlyMinute = EarlyMinute;
            this.m_IsBreak = IsBreak;
            this.m_IsBreakOvernight = IsBreakOvernight;
            this.m_BreakBeginTime = BreakBeginTime;
            this.m_BreakEndTime = BreakEndTime;
            this.m_TotalMinute = TotalMinute;
            this.m_TotalHour = TotalHour;
            this.m_HalfWorkMinute = HalfWorkMinute;
            this.m_WorkMinute = WorkMinute;
            this.m_WorkDay = WorkDay;
            this.m_MethodCheck = MethodCheck;
            this.m_IsBOT = IsBOT;
            this.m_IsAOT = IsAOT;
            this.m_MinimumMinuteBOT = MinimumMinuteBOT;
            this.m_MaximumMinuteBOT = MaximumMinuteBOT;
            this.m_DistanceMinuteBOT = DistanceMinuteBOT;
            this.m_MinimumMinuteAOT = MinimumMinuteAOT;
            this.m_MaximumMinuteAOT = MaximumMinuteAOT;
            this.m_DistanceMinuteAOT = DistanceMinuteAOT;
            this.m_IsNightDutyDay = IsNightDutyDay;
            this.m_Description = Description;
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@ShiftCode", "@ShiftName", "@BeginTime", "@EndTime", "@IsOvernight", "@BeginTime1", "@BeginTime2", "@EndTime1", "@EndTime2", "@LateMinute", "@EarlyMinute", "@IsBreak", "@IsBreakOvernight", "@BreakBeginTime", "@BreakEndTime", "@TotalMinute", "@TotalHour", "@HalfWorkMinute", "@WorkMinute", "@WorkDay", "@MethodCheck", "@IsBOT", "@IsAOT", "@MinimumMinuteBOT", "@MaximumMinuteBOT", "@DistanceMinuteBOT", "@MinimumMinuteAOT", "@MaximumMinuteAOT", "@DistanceMinuteAOT", "@IsNightDutyDay", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mShiftCode = new object[] { this.m_ShiftCode, this.m_ShiftName, this.m_BeginTime, this.m_EndTime, this.m_IsOvernight, this.m_BeginTime1, this.m_BeginTime2, this.m_EndTime1, this.m_EndTime2, this.m_LateMinute, this.m_EarlyMinute, this.m_IsBreak, this.m_IsBreakOvernight, this.m_BreakBeginTime, this.m_BreakEndTime, this.m_TotalMinute, this.m_TotalHour, this.m_HalfWorkMinute, this.m_WorkMinute, this.m_WorkDay, this.m_MethodCheck, this.m_IsBOT, this.m_IsAOT, this.m_MinimumMinuteBOT, this.m_MaximumMinuteBOT, this.m_DistanceMinuteBOT, this.m_MinimumMinuteAOT, this.m_MaximumMinuteAOT, this.m_DistanceMinuteAOT, this.m_IsNightDutyDay, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SHIFT_Update", strArrays1, mShiftCode);
        }

        public string Update(string ShiftCode, string ShiftName, DateTime BeginTime, DateTime EndTime, bool IsOvernight, DateTime BeginTime1, DateTime BeginTime2, DateTime EndTime1, DateTime EndTime2, int LateMinute, int EarlyMinute, bool IsBreak, bool IsBreakOvernight, DateTime BreakBeginTime, DateTime BreakEndTime, int TotalMinute, double TotalHour, int HalfWorkMinute, int WorkMinute, double WorkDay, int MethodCheck, bool IsBOT, bool IsAOT, int MinimumMinuteBOT, int MaximumMinuteBOT, int DistanceMinuteBOT, int MinimumMinuteAOT, int MaximumMinuteAOT, int DistanceMinuteAOT, bool IsNightDutyDay, string Description)
        {
            string[] strArrays = new string[] { "@ShiftCode", "@ShiftName", "@BeginTime", "@EndTime", "@IsOvernight", "@BeginTime1", "@BeginTime2", "@EndTime1", "@EndTime2", "@LateMinute", "@EarlyMinute", "@IsBreak", "@IsBreakOvernight", "@BreakBeginTime", "@BreakEndTime", "@TotalMinute", "@TotalHour", "@HalfWorkMinute", "@WorkMinute", "@WorkDay", "@MethodCheck", "@IsBOT", "@IsAOT", "@MinimumMinuteBOT", "@MaximumMinuteBOT", "@DistanceMinuteBOT", "@MinimumMinuteAOT", "@MaximumMinuteAOT", "@DistanceMinuteAOT", "@IsNightDutyDay", "@Description" };
            string[] strArrays1 = strArrays;
            object[] shiftCode = new object[] { ShiftCode, ShiftName, BeginTime, EndTime, IsOvernight, BeginTime1, BeginTime2, EndTime1, EndTime2, LateMinute, EarlyMinute, IsBreak, IsBreakOvernight, BreakBeginTime, BreakEndTime, TotalMinute, TotalHour, HalfWorkMinute, WorkMinute, WorkDay, MethodCheck, IsBOT, IsAOT, MinimumMinuteBOT, MaximumMinuteBOT, DistanceMinuteBOT, MinimumMinuteAOT, MaximumMinuteAOT, DistanceMinuteAOT, IsNightDutyDay, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SHIFT_Update", strArrays1, shiftCode);
        }

        public string Update(SqlConnection myConnection, string ShiftCode, string ShiftName, DateTime BeginTime, DateTime EndTime, bool IsOvernight, DateTime BeginTime1, DateTime BeginTime2, DateTime EndTime1, DateTime EndTime2, int LateMinute, int EarlyMinute, bool IsBreak, bool IsBreakOvernight, DateTime BreakBeginTime, DateTime BreakEndTime, int TotalMinute, double TotalHour, int HalfWorkMinute, int WorkMinute, double WorkDay, int MethodCheck, bool IsBOT, bool IsAOT, int MinimumMinuteBOT, int MaximumMinuteBOT, int DistanceMinuteBOT, int MinimumMinuteAOT, int MaximumMinuteAOT, int DistanceMinuteAOT, bool IsNightDutyDay, string Description)
        {
            string[] strArrays = new string[] { "@ShiftCode", "@ShiftName", "@BeginTime", "@EndTime", "@IsOvernight", "@BeginTime1", "@BeginTime2", "@EndTime1", "@EndTime2", "@LateMinute", "@EarlyMinute", "@IsBreak", "@IsBreakOvernight", "@BreakBeginTime", "@BreakEndTime", "@TotalMinute", "@TotalHour", "@HalfWorkMinute", "@WorkMinute", "@WorkDay", "@MethodCheck", "@IsBOT", "@IsAOT", "@MinimumMinuteBOT", "@MaximumMinuteBOT", "@DistanceMinuteBOT", "@MinimumMinuteAOT", "@MaximumMinuteAOT", "@DistanceMinuteAOT", "@IsNightDutyDay", "@Description" };
            string[] strArrays1 = strArrays;
            object[] shiftCode = new object[] { ShiftCode, ShiftName, BeginTime, EndTime, IsOvernight, BeginTime1, BeginTime2, EndTime1, EndTime2, LateMinute, EarlyMinute, IsBreak, IsBreakOvernight, BreakBeginTime, BreakEndTime, TotalMinute, TotalHour, HalfWorkMinute, WorkMinute, WorkDay, MethodCheck, IsBOT, IsAOT, MinimumMinuteBOT, MaximumMinuteBOT, DistanceMinuteBOT, MinimumMinuteAOT, MaximumMinuteAOT, DistanceMinuteAOT, IsNightDutyDay, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SHIFT_Update", strArrays1, shiftCode);
        }

        public string Update(SqlTransaction myTransaction, string ShiftCode, string ShiftName, DateTime BeginTime, DateTime EndTime, bool IsOvernight, DateTime BeginTime1, DateTime BeginTime2, DateTime EndTime1, DateTime EndTime2, int LateMinute, int EarlyMinute, bool IsBreak, bool IsBreakOvernight, DateTime BreakBeginTime, DateTime BreakEndTime, int TotalMinute, double TotalHour, int HalfWorkMinute, int WorkMinute, double WorkDay, int MethodCheck, bool IsBOT, bool IsAOT, int MinimumMinuteBOT, int MaximumMinuteBOT, int DistanceMinuteBOT, int MinimumMinuteAOT, int MaximumMinuteAOT, int DistanceMinuteAOT, bool IsNightDutyDay, string Description)
        {
            string[] strArrays = new string[] { "@ShiftCode", "@ShiftName", "@BeginTime", "@EndTime", "@IsOvernight", "@BeginTime1", "@BeginTime2", "@EndTime1", "@EndTime2", "@LateMinute", "@EarlyMinute", "@IsBreak", "@IsBreakOvernight", "@BreakBeginTime", "@BreakEndTime", "@TotalMinute", "@TotalHour", "@HalfWorkMinute", "@WorkMinute", "@WorkDay", "@MethodCheck", "@IsBOT", "@IsAOT", "@MinimumMinuteBOT", "@MaximumMinuteBOT", "@DistanceMinuteBOT", "@MinimumMinuteAOT", "@MaximumMinuteAOT", "@DistanceMinuteAOT", "@IsNightDutyDay", "@Description" };
            string[] strArrays1 = strArrays;
            object[] shiftCode = new object[] { ShiftCode, ShiftName, BeginTime, EndTime, IsOvernight, BeginTime1, BeginTime2, EndTime1, EndTime2, LateMinute, EarlyMinute, IsBreak, IsBreakOvernight, BreakBeginTime, BreakEndTime, TotalMinute, TotalHour, HalfWorkMinute, WorkMinute, WorkDay, MethodCheck, IsBOT, IsAOT, MinimumMinuteBOT, MaximumMinuteBOT, DistanceMinuteBOT, MinimumMinuteAOT, MaximumMinuteAOT, DistanceMinuteAOT, IsNightDutyDay, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SHIFT_Update", strArrays1, shiftCode);
        }
    }
}
