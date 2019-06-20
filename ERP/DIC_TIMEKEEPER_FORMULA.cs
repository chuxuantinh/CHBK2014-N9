using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ERP
{
  public  class DIC_TIMEKEEPER_FORMULA
    {

        private Guid m_FormulaID;

        private bool m_IsOvertimeSaturday;

        private int m_OvertimeSaturdayType;

        private DateTime m_BeginTimeSaturday;

        private int m_MinimumMinuteSaturday;

        private int m_MaximumMinuteSaturday;

        private bool m_IsOvertimeSunday;

        private int m_OvertimeSundayType;

        private DateTime m_BeginTimeSunday;

        private int m_MinimumMinuteSunday;

        private int m_MaximumMinuteSunday;

        private bool m_IsOvertimeHoliday;

        private int m_OvertimeHolidayType;

        private DateTime m_BeginTimeHoliday;

        private int m_MinimumMinuteHoliday;

        private int m_MaximumMinuteHoliday;

        private DateTime m_BeginTimeNight;

        private DateTime m_EndTimeNight;

        private double m_NumberDayStandard;

        private double m_NumberHourStandard;

        private double m_NumberHourOnDayStandard;

        private bool m_IsNumberStandardApplyAll;

        private bool m_IsNumberDayByHour;

        [Category("Column")]
        [DisplayName("BeginTimeHoliday")]
        public DateTime BeginTimeHoliday
        {
            get
            {
                return this.m_BeginTimeHoliday;
            }
            set
            {
                this.m_BeginTimeHoliday = value;
            }
        }

        [Category("Column")]
        [DisplayName("BeginTimeNight")]
        public DateTime BeginTimeNight
        {
            get
            {
                return this.m_BeginTimeNight;
            }
            set
            {
                this.m_BeginTimeNight = value;
            }
        }

        [Category("Column")]
        [DisplayName("BeginTimeSaturday")]
        public DateTime BeginTimeSaturday
        {
            get
            {
                return this.m_BeginTimeSaturday;
            }
            set
            {
                this.m_BeginTimeSaturday = value;
            }
        }

        [Category("Column")]
        [DisplayName("BeginTimeSunday")]
        public DateTime BeginTimeSunday
        {
            get
            {
                return this.m_BeginTimeSunday;
            }
            set
            {
                this.m_BeginTimeSunday = value;
            }
        }

        [Category("Column")]
        [DisplayName("EndTimeNight")]
        public DateTime EndTimeNight
        {
            get
            {
                return this.m_EndTimeNight;
            }
            set
            {
                this.m_EndTimeNight = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("FormulaID")]
        public Guid FormulaID
        {
            get
            {
                return this.m_FormulaID;
            }
            set
            {
                this.m_FormulaID = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsNumberDayByHour")]
        public bool IsNumberDayByHour
        {
            get
            {
                return this.m_IsNumberDayByHour;
            }
            set
            {
                this.m_IsNumberDayByHour = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsNumberStandardApplyAll")]
        public bool IsNumberStandardApplyAll
        {
            get
            {
                return this.m_IsNumberStandardApplyAll;
            }
            set
            {
                this.m_IsNumberStandardApplyAll = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsOvertimeHoliday")]
        public bool IsOvertimeHoliday
        {
            get
            {
                return this.m_IsOvertimeHoliday;
            }
            set
            {
                this.m_IsOvertimeHoliday = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsOvertimeSaturday")]
        public bool IsOvertimeSaturday
        {
            get
            {
                return this.m_IsOvertimeSaturday;
            }
            set
            {
                this.m_IsOvertimeSaturday = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsOvertimeSunday")]
        public bool IsOvertimeSunday
        {
            get
            {
                return this.m_IsOvertimeSunday;
            }
            set
            {
                this.m_IsOvertimeSunday = value;
            }
        }

        [Category("Column")]
        [DisplayName("MaximumMinuteHoliday")]
        public int MaximumMinuteHoliday
        {
            get
            {
                return this.m_MaximumMinuteHoliday;
            }
            set
            {
                this.m_MaximumMinuteHoliday = value;
            }
        }

        [Category("Column")]
        [DisplayName("MaximumMinuteSaturday")]
        public int MaximumMinuteSaturday
        {
            get
            {
                return this.m_MaximumMinuteSaturday;
            }
            set
            {
                this.m_MaximumMinuteSaturday = value;
            }
        }

        [Category("Column")]
        [DisplayName("MaximumMinuteSunday")]
        public int MaximumMinuteSunday
        {
            get
            {
                return this.m_MaximumMinuteSunday;
            }
            set
            {
                this.m_MaximumMinuteSunday = value;
            }
        }

        [Category("Column")]
        [DisplayName("MinimumMinuteHoliday")]
        public int MinimumMinuteHoliday
        {
            get
            {
                return this.m_MinimumMinuteHoliday;
            }
            set
            {
                this.m_MinimumMinuteHoliday = value;
            }
        }

        [Category("Column")]
        [DisplayName("MinimumMinuteSaturday")]
        public int MinimumMinuteSaturday
        {
            get
            {
                return this.m_MinimumMinuteSaturday;
            }
            set
            {
                this.m_MinimumMinuteSaturday = value;
            }
        }

        [Category("Column")]
        [DisplayName("MinimumMinuteSunday")]
        public int MinimumMinuteSunday
        {
            get
            {
                return this.m_MinimumMinuteSunday;
            }
            set
            {
                this.m_MinimumMinuteSunday = value;
            }
        }

        [Category("Column")]
        [DisplayName("NumberDayStandard")]
        public double NumberDayStandard
        {
            get
            {
                return this.m_NumberDayStandard;
            }
            set
            {
                this.m_NumberDayStandard = value;
            }
        }

        [Category("Column")]
        [DisplayName("NumberHourOnDayStandard")]
        public double NumberHourOnDayStandard
        {
            get
            {
                return this.m_NumberHourOnDayStandard;
            }
            set
            {
                this.m_NumberHourOnDayStandard = value;
            }
        }

        [Category("Column")]
        [DisplayName("NumberHourStandard")]
        public double NumberHourStandard
        {
            get
            {
                return this.m_NumberHourStandard;
            }
            set
            {
                this.m_NumberHourStandard = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeHolidayType")]
        public int OvertimeHolidayType
        {
            get
            {
                return this.m_OvertimeHolidayType;
            }
            set
            {
                this.m_OvertimeHolidayType = value;
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

        [Category("Column")]
        [DisplayName("OvertimeSundayType")]
        public int OvertimeSundayType
        {
            get
            {
                return this.m_OvertimeSundayType;
            }
            set
            {
                this.m_OvertimeSundayType = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_TIMEKEEPER_FORMULA";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_TIMEKEEPER_FORMULA()
        {
            this.m_FormulaID = Guid.Empty;
            this.m_IsOvertimeSaturday = true;
            this.m_OvertimeSaturdayType = 0;
            this.m_BeginTimeSaturday = DateTime.Now;
            this.m_MinimumMinuteSaturday = 0;
            this.m_MaximumMinuteSaturday = 0;
            this.m_IsOvertimeSunday = true;
            this.m_OvertimeSundayType = 0;
            this.m_BeginTimeSunday = DateTime.Now;
            this.m_MinimumMinuteSunday = 0;
            this.m_MaximumMinuteSunday = 0;
            this.m_IsOvertimeHoliday = true;
            this.m_OvertimeHolidayType = 0;
            this.m_BeginTimeHoliday = DateTime.Now;
            this.m_MinimumMinuteHoliday = 0;
            this.m_MaximumMinuteHoliday = 0;
            this.m_BeginTimeNight = DateTime.Now;
            this.m_EndTimeNight = DateTime.Now;
            this.m_NumberDayStandard = 0;
            this.m_NumberHourStandard = 0;
            this.m_NumberHourOnDayStandard = 0;
            this.m_IsNumberStandardApplyAll = false;
            this.m_IsNumberDayByHour = false;
        }

        public DIC_TIMEKEEPER_FORMULA(Guid FormulaID, bool IsOvertimeSaturday, int OvertimeSaturdayType, DateTime BeginTimeSaturday, int MinimumMinuteSaturday, int MaximumMinuteSaturday, bool IsOvertimeSunday, int OvertimeSundayType, DateTime BeginTimeSunday, int MinimumMinuteSunday, int MaximumMinuteSunday, bool IsOvertimeHoliday, int OvertimeHolidayType, DateTime BeginTimeHoliday, int MinimumMinuteHoliday, int MaximumMinuteHoliday, DateTime BeginTimeNight, DateTime EndTimeNight, double NumberDayStandard, double NumberHourStandard, double NumberHourOnDayStandard, bool IsNumberStandardApplyAll, bool IsNumberDayByHour)
        {
            this.m_FormulaID = FormulaID;
            this.m_IsOvertimeSaturday = IsOvertimeSaturday;
            this.m_OvertimeSaturdayType = OvertimeSaturdayType;
            this.m_BeginTimeSaturday = BeginTimeSaturday;
            this.m_MinimumMinuteSaturday = MinimumMinuteSaturday;
            this.m_MaximumMinuteSaturday = MaximumMinuteSaturday;
            this.m_IsOvertimeSunday = IsOvertimeSunday;
            this.m_OvertimeSundayType = OvertimeSundayType;
            this.m_BeginTimeSunday = BeginTimeSunday;
            this.m_MinimumMinuteSunday = MinimumMinuteSunday;
            this.m_MaximumMinuteSunday = MaximumMinuteSunday;
            this.m_IsOvertimeHoliday = IsOvertimeHoliday;
            this.m_OvertimeHolidayType = OvertimeHolidayType;
            this.m_BeginTimeHoliday = BeginTimeHoliday;
            this.m_MinimumMinuteHoliday = MinimumMinuteHoliday;
            this.m_MaximumMinuteHoliday = MaximumMinuteHoliday;
            this.m_BeginTimeNight = BeginTimeNight;
            this.m_EndTimeNight = EndTimeNight;
            this.m_NumberDayStandard = NumberDayStandard;
            this.m_NumberHourStandard = NumberHourStandard;
            this.m_NumberHourOnDayStandard = NumberHourOnDayStandard;
            this.m_IsNumberStandardApplyAll = IsNumberStandardApplyAll;
            this.m_IsNumberDayByHour = IsNumberDayByHour;
        }

        public string Get()
        {
            string str = "";
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_TIMEKEEPER_FORMULA_Get");
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_FormulaID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("FormulaID"));
                    this.m_IsOvertimeSaturday = Convert.ToBoolean(sqlDataReader["IsOvertimeSaturday"]);
                    this.m_OvertimeSaturdayType = Convert.ToInt32(sqlDataReader["OvertimeSaturdayType"]);
                    this.m_BeginTimeSaturday = Convert.ToDateTime(sqlDataReader["BeginTimeSaturday"]);
                    this.m_MinimumMinuteSaturday = Convert.ToInt32(sqlDataReader["MinimumMinuteSaturday"]);
                    this.m_MaximumMinuteSaturday = Convert.ToInt32(sqlDataReader["MaximumMinuteSaturday"]);
                    this.m_IsOvertimeSunday = Convert.ToBoolean(sqlDataReader["IsOvertimeSunday"]);
                    this.m_OvertimeSundayType = Convert.ToInt32(sqlDataReader["OvertimeSundayType"]);
                    this.m_BeginTimeSunday = Convert.ToDateTime(sqlDataReader["BeginTimeSunday"]);
                    this.m_MinimumMinuteSunday = Convert.ToInt32(sqlDataReader["MinimumMinuteSunday"]);
                    this.m_MaximumMinuteSunday = Convert.ToInt32(sqlDataReader["MaximumMinuteSunday"]);
                    this.m_IsOvertimeHoliday = Convert.ToBoolean(sqlDataReader["IsOvertimeHoliday"]);
                    this.m_OvertimeHolidayType = Convert.ToInt32(sqlDataReader["OvertimeHolidayType"]);
                    this.m_BeginTimeHoliday = Convert.ToDateTime(sqlDataReader["BeginTimeHoliday"]);
                    this.m_MinimumMinuteHoliday = Convert.ToInt32(sqlDataReader["MinimumMinuteHoliday"]);
                    this.m_MaximumMinuteHoliday = Convert.ToInt32(sqlDataReader["MaximumMinuteHoliday"]);
                    this.m_BeginTimeNight = Convert.ToDateTime(sqlDataReader["BeginTimeNight"]);
                    this.m_EndTimeNight = Convert.ToDateTime(sqlDataReader["EndTimeNight"]);
                    this.m_NumberDayStandard = (sqlDataReader["NumberDayStandard"] == DBNull.Value ? 26 : Convert.ToDouble(sqlDataReader["NumberDayStandard"]));
                    this.m_NumberHourStandard = (sqlDataReader["NumberHourStandard"] == DBNull.Value ? 208 : Convert.ToDouble(sqlDataReader["NumberHourStandard"]));
                    this.m_NumberHourOnDayStandard = (sqlDataReader["NumberHourOnDayStandard"] == DBNull.Value ? 8 : Convert.ToDouble(sqlDataReader["NumberHourOnDayStandard"]));
                    this.m_IsNumberStandardApplyAll = (sqlDataReader["IsNumberStandardApplyAll"] == DBNull.Value ? false : Convert.ToBoolean(sqlDataReader["IsNumberStandardApplyAll"]));
                    this.m_IsNumberDayByHour = (sqlDataReader["IsNumberDayByHour"] == DBNull.Value ? false : Convert.ToBoolean(sqlDataReader["IsNumberDayByHour"]));
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
            return (new SqlHelper()).ExecuteDataTable("DIC_TIMEKEEPER_FORMULA_GetList");
        }

        public double NumberNightHour(DateTime dt1, DateTime dt2)
        {
            return Perfect.Utils. MyDateTime.NumberHour(dt1, dt2);
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@FormulaID", "@IsOvertimeSaturday", "@OvertimeSaturdayType", "@BeginTimeSaturday", "@MinimumMinuteSaturday", "@MaximumMinuteSaturday", "@IsOvertimeSunday", "@OvertimeSundayType", "@BeginTimeSunday", "@MinimumMinuteSunday", "@MaximumMinuteSunday", "@IsOvertimeHoliday", "@OvertimeHolidayType", "@BeginTimeHoliday", "@MinimumMinuteHoliday", "@MaximumMinuteHoliday", "@BeginTimeNight", "@EndTimeNight", "@NumberDayStandard", "@NumberHourStandard", "@NumberHourOnDayStandard", "@IsNumberStandardApplyAll", "@IsNumberDayByHour" };
            string[] strArrays1 = strArrays;
            object[] mFormulaID = new object[] { this.m_FormulaID, this.m_IsOvertimeSaturday, this.m_OvertimeSaturdayType, this.m_BeginTimeSaturday, this.m_MinimumMinuteSaturday, this.m_MaximumMinuteSaturday, this.m_IsOvertimeSunday, this.m_OvertimeSundayType, this.m_BeginTimeSunday, this.m_MinimumMinuteSunday, this.m_MaximumMinuteSunday, this.m_IsOvertimeHoliday, this.m_OvertimeHolidayType, this.m_BeginTimeHoliday, this.m_MinimumMinuteHoliday, this.m_MaximumMinuteHoliday, this.m_BeginTimeNight, this.m_EndTimeNight, this.m_NumberDayStandard, this.m_NumberHourStandard, this.m_NumberHourOnDayStandard, this.m_IsNumberStandardApplyAll, this.m_IsNumberDayByHour };
            return (new SqlHelper()).ExecuteNonQuery("DIC_TIMEKEEPER_FORMULA_Update", strArrays1, mFormulaID);
        }

        public string Update(Guid FormulaID, bool IsOvertimeSaturday, int OvertimeSaturdayType, DateTime BeginTimeSaturday, int MinimumMinuteSaturday, int MaximumMinuteSaturday, bool IsOvertimeSunday, int OvertimeSundayType, DateTime BeginTimeSunday, int MinimumMinuteSunday, int MaximumMinuteSunday, bool IsOvertimeHoliday, int OvertimeHolidayType, DateTime BeginTimeHoliday, int MinimumMinuteHoliday, int MaximumMinuteHoliday, DateTime BeginTimeNight, DateTime EndTimeNight, double NumberDayStandard, double NumberHourStandard, double NumberHourOnDayStandard, bool IsNumberStandardApplyAll, bool IsNumberDayByHour)
        {
            string[] strArrays = new string[] { "@FormulaID", "@IsOvertimeSaturday", "@OvertimeSaturdayType", "@BeginTimeSaturday", "@MinimumMinuteSaturday", "@MaximumMinuteSaturday", "@IsOvertimeSunday", "@OvertimeSundayType", "@BeginTimeSunday", "@MinimumMinuteSunday", "@MaximumMinuteSunday", "@IsOvertimeHoliday", "@OvertimeHolidayType", "@BeginTimeHoliday", "@MinimumMinuteHoliday", "@MaximumMinuteHoliday", "@BeginTimeNight", "@EndTimeNight", "@NumberDayStandard", "@NumberHourStandard", "@NumberHourOnDayStandard", "@IsNumberStandardApplyAll", "@IsNumberDayByHour" };
            string[] strArrays1 = strArrays;
            object[] formulaID = new object[] { FormulaID, IsOvertimeSaturday, OvertimeSaturdayType, BeginTimeSaturday, MinimumMinuteSaturday, MaximumMinuteSaturday, IsOvertimeSunday, OvertimeSundayType, BeginTimeSunday, MinimumMinuteSunday, MaximumMinuteSunday, IsOvertimeHoliday, OvertimeHolidayType, BeginTimeHoliday, MinimumMinuteHoliday, MaximumMinuteHoliday, BeginTimeNight, EndTimeNight, NumberDayStandard, NumberHourStandard, NumberHourOnDayStandard, IsNumberStandardApplyAll, IsNumberDayByHour };
            return (new SqlHelper()).ExecuteNonQuery("DIC_TIMEKEEPER_FORMULA_Update", strArrays1, formulaID);
        }

        public string Update(SqlConnection myConnection, Guid FormulaID, bool IsOvertimeSaturday, int OvertimeSaturdayType, DateTime BeginTimeSaturday, int MinimumMinuteSaturday, int MaximumMinuteSaturday, bool IsOvertimeSunday, int OvertimeSundayType, DateTime BeginTimeSunday, int MinimumMinuteSunday, int MaximumMinuteSunday, bool IsOvertimeHoliday, int OvertimeHolidayType, DateTime BeginTimeHoliday, int MinimumMinuteHoliday, int MaximumMinuteHoliday, DateTime BeginTimeNight, DateTime EndTimeNight, double NumberDayStandard, double NumberHourStandard, double NumberHourOnDayStandard, bool IsNumberStandardApplyAll, bool IsNumberDayByHour)
        {
            string[] strArrays = new string[] { "@FormulaID", "@IsOvertimeSaturday", "@OvertimeSaturdayType", "@BeginTimeSaturday", "@MinimumMinuteSaturday", "@MaximumMinuteSaturday", "@IsOvertimeSunday", "@OvertimeSundayType", "@BeginTimeSunday", "@MinimumMinuteSunday", "@MaximumMinuteSunday", "@IsOvertimeHoliday", "@OvertimeHolidayType", "@BeginTimeHoliday", "@MinimumMinuteHoliday", "@MaximumMinuteHoliday", "@BeginTimeNight", "@EndTimeNight", "@NumberDayStandard", "@NumberHourStandard", "@NumberHourOnDayStandard", "@IsNumberStandardApplyAll", "@IsNumberDayByHour" };
            string[] strArrays1 = strArrays;
            object[] formulaID = new object[] { FormulaID, IsOvertimeSaturday, OvertimeSaturdayType, BeginTimeSaturday, MinimumMinuteSaturday, MaximumMinuteSaturday, IsOvertimeSunday, OvertimeSundayType, BeginTimeSunday, MinimumMinuteSunday, MaximumMinuteSunday, IsOvertimeHoliday, OvertimeHolidayType, BeginTimeHoliday, MinimumMinuteHoliday, MaximumMinuteHoliday, BeginTimeNight, EndTimeNight, NumberDayStandard, NumberHourStandard, NumberHourOnDayStandard, IsNumberStandardApplyAll, IsNumberDayByHour };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_TIMEKEEPER_FORMULA_Update", strArrays1, formulaID);
        }

        public string Update(SqlTransaction myTransaction, Guid FormulaID, bool IsOvertimeSaturday, int OvertimeSaturdayType, DateTime BeginTimeSaturday, int MinimumMinuteSaturday, int MaximumMinuteSaturday, bool IsOvertimeSunday, int OvertimeSundayType, DateTime BeginTimeSunday, int MinimumMinuteSunday, int MaximumMinuteSunday, bool IsOvertimeHoliday, int OvertimeHolidayType, DateTime BeginTimeHoliday, int MinimumMinuteHoliday, int MaximumMinuteHoliday, DateTime BeginTimeNight, DateTime EndTimeNight, double NumberDayStandard, double NumberHourStandard, double NumberHourOnDayStandard, bool IsNumberStandardApplyAll, bool IsNumberDayByHour)
        {
            string[] strArrays = new string[] { "@FormulaID", "@IsOvertimeSaturday", "@OvertimeSaturdayType", "@BeginTimeSaturday", "@MinimumMinuteSaturday", "@MaximumMinuteSaturday", "@IsOvertimeSunday", "@OvertimeSundayType", "@BeginTimeSunday", "@MinimumMinuteSunday", "@MaximumMinuteSunday", "@IsOvertimeHoliday", "@OvertimeHolidayType", "@BeginTimeHoliday", "@MinimumMinuteHoliday", "@MaximumMinuteHoliday", "@BeginTimeNight", "@EndTimeNight", "@NumberDayStandard", "@NumberHourStandard", "@NumberHourOnDayStandard", "@IsNumberStandardApplyAll", "@IsNumberDayByHour" };
            string[] strArrays1 = strArrays;
            object[] formulaID = new object[] { FormulaID, IsOvertimeSaturday, OvertimeSaturdayType, BeginTimeSaturday, MinimumMinuteSaturday, MaximumMinuteSaturday, IsOvertimeSunday, OvertimeSundayType, BeginTimeSunday, MinimumMinuteSunday, MaximumMinuteSunday, IsOvertimeHoliday, OvertimeHolidayType, BeginTimeHoliday, MinimumMinuteHoliday, MaximumMinuteHoliday, BeginTimeNight, EndTimeNight, NumberDayStandard, NumberHourStandard, NumberHourOnDayStandard, IsNumberStandardApplyAll, IsNumberDayByHour };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_TIMEKEEPER_FORMULA_Update", strArrays1, formulaID);
        }
    }
}
