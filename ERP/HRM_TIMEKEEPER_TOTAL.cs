using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Data.Helper;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CHBK2014_N9.ERP
{
  public  class HRM_TIMEKEEPER_TOTAL
    {

        private Guid m_TimeKeeperTableListID;

        private string m_EmployeeCode;

        private double m_StipulatedDay;

        private double m_WorkTotal;

        private double m_RealDay;

        private double m_NotRealDay;

        private double m_RegulationDay;

        private double m_FurloughDay;

        private double m_CompensationDay;

        private double m_Absent;

        private double m_AbsentWOL;

        private double m_AbsentL;

        private double m_ClockingError;

        private double m_ClockingErrorBegin;

        private double m_ClockingErrorEnd;

        private double m_StipulatedTime;

        private double m_TotalHour;

        private int m_LateMinute;

        private int m_EarlyMinute;

        private double m_OvertimeWorkday;

        private double m_OvertimeSaturday;

        private double m_OvertimeSunday;

        private double m_OvertimeHoliday;

        private double m_OvertimeNightWorkday;

        private double m_OvertimeNightSaturday;

        private double m_OvertimeNightSunday;

        private double m_OvertimeNightHoliday;

        private double m_OvertimeTotal;

        private double m_Overtime150;

        private double m_Overtime200;

        private double m_Overtime300;

        private double m_Overtime195;

        private double m_Overtime260;

        private double m_Overtime390;

        private double m_OvertimeTotal1;

        private double m_PrivateHour;

        private double m_NightHour;

        private double m_NightDutyDay;

        private double m_ExtraHour;

        private string m_Description;

        [Category("Column")]
        [DisplayName("Absent")]
        public double Absent
        {
            get
            {
                return this.m_Absent;
            }
            set
            {
                this.m_Absent = value;
            }
        }

        [Category("Column")]
        [DisplayName("AbsentL")]
        public double AbsentL
        {
            get
            {
                return this.m_AbsentL;
            }
            set
            {
                this.m_AbsentL = value;
            }
        }

        [Category("Column")]
        [DisplayName("AbsentWOL")]
        public double AbsentWOL
        {
            get
            {
                return this.m_AbsentWOL;
            }
            set
            {
                this.m_AbsentWOL = value;
            }
        }

        [Category("Column")]
        [DisplayName("ClockingError")]
        public double ClockingError
        {
            get
            {
                return this.m_ClockingError;
            }
            set
            {
                this.m_ClockingError = value;
            }
        }

        [Category("Column")]
        [DisplayName("ClockingErrorBegin")]
        public double ClockingErrorBegin
        {
            get
            {
                return this.m_ClockingErrorBegin;
            }
            set
            {
                this.m_ClockingErrorBegin = value;
            }
        }

        [Category("Column")]
        [DisplayName("ClockingErrorEnd")]
        public double ClockingErrorEnd
        {
            get
            {
                return this.m_ClockingErrorEnd;
            }
            set
            {
                this.m_ClockingErrorEnd = value;
            }
        }

        [Category("Column")]
        [DisplayName("CompensationDay")]
        public double CompensationDay
        {
            get
            {
                return this.m_CompensationDay;
            }
            set
            {
                this.m_CompensationDay = value;
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
        [DisplayName("ExtraHour")]
        public double ExtraHour
        {
            get
            {
                return this.m_ExtraHour;
            }
            set
            {
                this.m_ExtraHour = value;
            }
        }

        [Category("Column")]
        [DisplayName("FurloughDay")]
        public double FurloughDay
        {
            get
            {
                return this.m_FurloughDay;
            }
            set
            {
                this.m_FurloughDay = value;
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
        [DisplayName("NightDutyDay")]
        public double NightDutyDay
        {
            get
            {
                return this.m_NightDutyDay;
            }
            set
            {
                this.m_NightDutyDay = value;
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
        [DisplayName("NotRealDay")]
        public double NotRealDay
        {
            get
            {
                return this.m_NotRealDay;
            }
            set
            {
                this.m_NotRealDay = value;
            }
        }

        [Category("Column")]
        [DisplayName("Overtime150")]
        public double Overtime150
        {
            get
            {
                return this.m_Overtime150;
            }
            set
            {
                this.m_Overtime150 = value;
            }
        }

        [Category("Column")]
        [DisplayName("Overtime195")]
        public double Overtime195
        {
            get
            {
                return this.m_Overtime195;
            }
            set
            {
                this.m_Overtime195 = value;
            }
        }

        [Category("Column")]
        [DisplayName("Overtime200")]
        public double Overtime200
        {
            get
            {
                return this.m_Overtime200;
            }
            set
            {
                this.m_Overtime200 = value;
            }
        }

        [Category("Column")]
        [DisplayName("Overtime260")]
        public double Overtime260
        {
            get
            {
                return this.m_Overtime260;
            }
            set
            {
                this.m_Overtime260 = value;
            }
        }

        [Category("Column")]
        [DisplayName("Overtime300")]
        public double Overtime300
        {
            get
            {
                return this.m_Overtime300;
            }
            set
            {
                this.m_Overtime300 = value;
            }
        }

        [Category("Column")]
        [DisplayName("Overtime390")]
        public double Overtime390
        {
            get
            {
                return this.m_Overtime390;
            }
            set
            {
                this.m_Overtime390 = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeHoliday")]
        public double OvertimeHoliday
        {
            get
            {
                return this.m_OvertimeHoliday;
            }
            set
            {
                this.m_OvertimeHoliday = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeNightHoliday")]
        public double OvertimeNightHoliday
        {
            get
            {
                return this.m_OvertimeNightHoliday;
            }
            set
            {
                this.m_OvertimeNightHoliday = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeNightSaturday")]
        public double OvertimeNightSaturday
        {
            get
            {
                return this.m_OvertimeNightSaturday;
            }
            set
            {
                this.m_OvertimeNightSaturday = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeNightSunday")]
        public double OvertimeNightSunday
        {
            get
            {
                return this.m_OvertimeNightSunday;
            }
            set
            {
                this.m_OvertimeNightSunday = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeNightWorkday")]
        public double OvertimeNightWorkday
        {
            get
            {
                return this.m_OvertimeNightWorkday;
            }
            set
            {
                this.m_OvertimeNightWorkday = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeSaturday")]
        public double OvertimeSaturday
        {
            get
            {
                return this.m_OvertimeSaturday;
            }
            set
            {
                this.m_OvertimeSaturday = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeSunday")]
        public double OvertimeSunday
        {
            get
            {
                return this.m_OvertimeSunday;
            }
            set
            {
                this.m_OvertimeSunday = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeTotal")]
        public double OvertimeTotal
        {
            get
            {
                return this.m_OvertimeTotal;
            }
            set
            {
                this.m_OvertimeTotal = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeTotal1")]
        public double OvertimeTotal1
        {
            get
            {
                return this.m_OvertimeTotal1;
            }
            set
            {
                this.m_OvertimeTotal1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeWorkday")]
        public double OvertimeWorkday
        {
            get
            {
                return this.m_OvertimeWorkday;
            }
            set
            {
                this.m_OvertimeWorkday = value;
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
                return "Class HRM_TIMEKEEPER_TOTAL";
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
        [DisplayName("RealDay")]
        public double RealDay
        {
            get
            {
                return this.m_RealDay;
            }
            set
            {
                this.m_RealDay = value;
            }
        }

        [Category("Column")]
        [DisplayName("RegulationDay")]
        public double RegulationDay
        {
            get
            {
                return this.m_RegulationDay;
            }
            set
            {
                this.m_RegulationDay = value;
            }
        }

        [Category("Column")]
        [DisplayName("StipulatedDay")]
        public double StipulatedDay
        {
            get
            {
                return this.m_StipulatedDay;
            }
            set
            {
                this.m_StipulatedDay = value;
            }
        }

        [Category("Column")]
        [DisplayName("StipulatedTime")]
        public double StipulatedTime
        {
            get
            {
                return this.m_StipulatedTime;
            }
            set
            {
                this.m_StipulatedTime = value;
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
        [DisplayName("WorkTotal")]
        public double WorkTotal
        {
            get
            {
                return this.m_WorkTotal;
            }
            set
            {
                this.m_WorkTotal = value;
            }
        }

        public HRM_TIMEKEEPER_TOTAL()
        {
            this.m_TimeKeeperTableListID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_StipulatedDay = 0;
            this.m_WorkTotal = 0;
            this.m_RealDay = 0;
            this.m_NotRealDay = 0;
            this.m_RegulationDay = 0;
            this.m_FurloughDay = 0;
            this.m_CompensationDay = 0;
            this.m_Absent = 0;
            this.m_AbsentWOL = 0;
            this.m_AbsentL = 0;
            this.m_ClockingError = 0;
            this.m_ClockingErrorBegin = 0;
            this.m_ClockingErrorEnd = 0;
            this.m_StipulatedTime = 0;
            this.m_TotalHour = 0;
            this.m_LateMinute = 0;
            this.m_EarlyMinute = 0;
            this.m_OvertimeWorkday = 0;
            this.m_OvertimeSaturday = 0;
            this.m_OvertimeSunday = 0;
            this.m_OvertimeHoliday = 0;
            this.m_OvertimeNightWorkday = 0;
            this.m_OvertimeNightSaturday = 0;
            this.m_OvertimeNightSunday = 0;
            this.m_OvertimeNightHoliday = 0;
            this.m_OvertimeTotal = 0;
            this.m_Overtime150 = 0;
            this.m_Overtime200 = 0;
            this.m_Overtime300 = 0;
            this.m_Overtime195 = 1.95;
            this.m_Overtime260 = 2.6;
            this.m_Overtime390 = 3.9;
            this.m_OvertimeTotal1 = 0;
            this.m_PrivateHour = 0;
            this.m_NightHour = 0;
            this.m_NightDutyDay = 0;
            this.m_ExtraHour = 0;
            this.m_Description = "";
        }

        public HRM_TIMEKEEPER_TOTAL(Guid TimeKeeperTableListID, string EmployeeCode, double StipulatedDay, double WorkTotal, double RealDay, double NotRealDay, double RegulationDay, double FurloughDay, double CompensationDay, double Absent, double AbsentWOL, double AbsentL, double ClockingError, double ClockingErrorBegin, double ClockingErrorEnd, double StipulatedTime, double TotalHour, int LateMinute, int EarlyMinute, double OvertimeWorkday, double OvertimeSaturday, double OvertimeSunday, double OvertimeHoliday, double OvertimeNightWorkday, double OvertimeNightSaturday, double OvertimeNightSunday, double OvertimeNightHoliday, double OvertimeTotal, double Overtime150, double Overtime200, double Overtime300, double Overtime195, double Overtime260, double OvertimeTotal1, double PrivateHour, double NightHour, double NightDutyDay, double ExtraHour, string Description)
        {
            this.m_TimeKeeperTableListID = TimeKeeperTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_StipulatedDay = StipulatedDay;
            this.m_WorkTotal = WorkTotal;
            this.m_RealDay = RealDay;
            this.m_NotRealDay = NotRealDay;
            this.m_RegulationDay = RegulationDay;
            this.m_FurloughDay = FurloughDay;
            this.m_CompensationDay = CompensationDay;
            this.m_Absent = Absent;
            this.m_AbsentWOL = AbsentWOL;
            this.m_AbsentL = AbsentL;
            this.m_ClockingError = ClockingError;
            this.m_ClockingErrorBegin = ClockingErrorBegin;
            this.m_ClockingErrorEnd = ClockingErrorEnd;
            this.m_StipulatedTime = StipulatedTime;
            this.m_TotalHour = TotalHour;
            this.m_LateMinute = LateMinute;
            this.m_EarlyMinute = EarlyMinute;
            this.m_OvertimeWorkday = OvertimeWorkday;
            this.m_OvertimeSaturday = OvertimeSaturday;
            this.m_OvertimeSunday = OvertimeSunday;
            this.m_OvertimeHoliday = OvertimeSunday;
            this.m_OvertimeNightWorkday = OvertimeNightWorkday;
            this.m_OvertimeNightSaturday = OvertimeNightSaturday;
            this.m_OvertimeNightSunday = OvertimeNightSunday;
            this.m_OvertimeNightHoliday = OvertimeNightHoliday;
            this.m_OvertimeTotal = OvertimeTotal;
            this.m_Overtime150 = Overtime150;
            this.m_Overtime200 = Overtime200;
            this.m_Overtime300 = Overtime300;
            this.m_Overtime195 = Overtime195;
            this.m_Overtime260 = Overtime260;
            this.m_Overtime390 = this.Overtime390;
            this.m_OvertimeTotal1 = OvertimeTotal1;
            this.m_PrivateHour = PrivateHour;
            this.m_NightHour = NightHour;
            this.m_NightDutyDay = NightDutyDay;
            this.m_ExtraHour = ExtraHour;
            this.m_Description = Description;
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
            foreach (DataRow row in hRMEMPLOYEE.GetCompactList(Level, Code, 1, dateTime, dateTime1).Rows)
            {
                string[] str = new string[] { "Đang tổng hợp...", row["FirstName"].ToString(), " ", row["LastName"].ToString(), " (", row["EmployeeCode"].ToString(), ")" };
                Options.SetWaitDialogCaption(string.Concat(str));
                Thread thread = new Thread(() => this.Create(TimeKeeperTableListID, row["EmployeeCode"].ToString()));
                thread.Start();
                thread.Join();
            }
            Options.HideDialog();
            return "OK";
        }

        public string Create(Guid TimeKeeperTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_TOTAL_Create", strArrays, timeKeeperTableListID);
        }

        public string Get(Guid TimeKeeperTableListID, string EmployeeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_TOTAL_Get", strArrays, timeKeeperTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_StipulatedDay = Convert.ToDouble(sqlDataReader["StipulatedDay"]);
                    this.m_WorkTotal = Convert.ToDouble(sqlDataReader["WorkTotal"]);
                    this.m_RealDay = Convert.ToDouble(sqlDataReader["RealDay"]);
                    this.m_NotRealDay = Convert.ToDouble(sqlDataReader["NotRealDay"]);
                    this.m_RegulationDay = Convert.ToDouble(sqlDataReader["RegulationDay"]);
                    this.m_FurloughDay = Convert.ToDouble(sqlDataReader["FurloughDay"]);
                    this.m_CompensationDay = Convert.ToDouble(sqlDataReader["CompensationDay"]);
                    this.m_Absent = Convert.ToDouble(sqlDataReader["Absent"]);
                    this.m_AbsentWOL = Convert.ToDouble(sqlDataReader["AbsentWOL"]);
                    this.m_AbsentL = Convert.ToDouble(sqlDataReader["AbsentL"]);
                    this.m_ClockingError = Convert.ToDouble(sqlDataReader["ClockingError"]);
                    this.m_ClockingErrorBegin = Convert.ToDouble(sqlDataReader["ClockingErrorBegin"]);
                    this.m_ClockingErrorEnd = Convert.ToDouble(sqlDataReader["ClockingErrorEnd"]);
                    this.m_StipulatedTime = Convert.ToDouble(sqlDataReader["StipulatedTime"]);
                    this.m_TotalHour = Convert.ToDouble(sqlDataReader["TotalHour"]);
                    this.m_LateMinute = Convert.ToInt32(sqlDataReader["LateMinute"]);
                    this.m_EarlyMinute = Convert.ToInt32(sqlDataReader["EarlyMinute"]);
                    this.m_OvertimeWorkday = Convert.ToDouble(sqlDataReader["OvertimeWorkday"]);
                    this.m_OvertimeSaturday = Convert.ToDouble(sqlDataReader["OvertimeSaturday"]);
                    this.m_OvertimeSunday = Convert.ToDouble(sqlDataReader["OvertimeSunday"]);
                    this.m_OvertimeHoliday = Convert.ToDouble(sqlDataReader["OvertimeHoliday"]);
                    this.m_OvertimeNightWorkday = Convert.ToDouble(sqlDataReader["OvertimeNightWorkday"]);
                    this.m_OvertimeNightSaturday = Convert.ToDouble(sqlDataReader["OvertimeNightSaturday"]);
                    this.m_OvertimeNightSunday = Convert.ToDouble(sqlDataReader["OvertimeNightSunday"]);
                    this.m_OvertimeNightHoliday = Convert.ToDouble(sqlDataReader["OvertimeNightHoliday"]);
                    this.m_OvertimeTotal = Convert.ToDouble(sqlDataReader["OvertimeTotal"]);
                    this.m_Overtime150 = Convert.ToDouble(sqlDataReader["Overtime150"]);
                    this.m_Overtime200 = Convert.ToDouble(sqlDataReader["Overtime200"]);
                    this.m_Overtime300 = Convert.ToDouble(sqlDataReader["Overtime300"]);
                    this.m_Overtime195 = Convert.ToDouble(sqlDataReader["Overtime195"]);
                    this.m_Overtime260 = Convert.ToDouble(sqlDataReader["Overtime260"]);
                    this.m_Overtime390 = Convert.ToDouble(sqlDataReader["Overtime390"]);
                    this.m_OvertimeTotal1 = Convert.ToDouble(sqlDataReader["OvertimeTotal1"]);
                    this.m_PrivateHour = Convert.ToDouble(sqlDataReader["PrivateHour"]);
                    this.m_NightHour = Convert.ToDouble(sqlDataReader["NightHour"]);
                    this.m_NightDutyDay = Convert.ToDouble(sqlDataReader["NightDutyDay"]);
                    this.m_ExtraHour = Convert.ToDouble(sqlDataReader["ExtraHour"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetList(int Level, string Code, Guid TimeKeeperTableListID)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@TimeKeeperTableListID" };
            object[] level = new object[] { Level, Code, TimeKeeperTableListID };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_TOTAL_GetList", strArrays, level);
        }

        public DataTable GetSalaryByYear(string EmployeeCode, int Year)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Year" };
            object[] employeeCode = new object[] { EmployeeCode, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_TOTAL_GetSalaryByYear", strArrays, employeeCode);
        }
    }
}
