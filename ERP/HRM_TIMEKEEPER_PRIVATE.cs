﻿using CHBK2014_N9.Data.Helper;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ERP
{
    public class HRM_TIMEKEEPER_PRIVATE
    {


        private Guid m_TimeKeeperTableListID;

        private string m_EmployeeCode;

        private string m_ShiftCode;

        private DateTime m_Date;

        private Guid m_OrderID;

        private DateTime m_PrivateBeginTime;

        private DateTime m_PrivateEndTime;

        private double m_Hour;

        private int m_Minute;

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
        [DisplayName("Minute")]
        public int Minute
        {
            get
            {
                return this.m_Minute;
            }
            set
            {
                this.m_Minute = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("OrderID")]
        public Guid OrderID
        {
            get
            {
                return this.m_OrderID;
            }
            set
            {
                this.m_OrderID = value;
            }
        }

        [Category("Column")]
        [DisplayName("PrivateBeginTime")]
        public DateTime PrivateBeginTime
        {
            get
            {
                return this.m_PrivateBeginTime;
            }
            set
            {
                this.m_PrivateBeginTime = value;
            }
        }

        [Category("Column")]
        [DisplayName("PrivateEndTime")]
        public DateTime PrivateEndTime
        {
            get
            {
                return this.m_PrivateEndTime;
            }
            set
            {
                this.m_PrivateEndTime = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_TIMEKEEPER_PRIVATE";
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

        public HRM_TIMEKEEPER_PRIVATE()
        {
            this.m_TimeKeeperTableListID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_ShiftCode = "";
            this.m_Date = DateTime.Now;
            this.m_OrderID = Guid.Empty;
            this.m_PrivateBeginTime = DateTime.Now;
            this.m_PrivateEndTime = DateTime.Now;
            this.m_Hour = 0;
            this.m_Minute = 0;
        }

        public HRM_TIMEKEEPER_PRIVATE(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID, DateTime PrivateBeginTime, DateTime PrivateEndTime, double Hour, int Minute)
        {
            this.m_TimeKeeperTableListID = TimeKeeperTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_ShiftCode = ShiftCode;
            this.m_Date = Date;
            this.m_OrderID = OrderID;
            this.m_PrivateBeginTime = PrivateBeginTime;
            this.m_PrivateEndTime = PrivateEndTime;
            this.m_Hour = Hour;
            this.m_Minute = Minute;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID" };
            string[] strArrays1 = strArrays;
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_OrderID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_PRIVATE_Delete", strArrays1, mTimeKeeperTableListID);
        }

        public string Delete(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_PRIVATE_Delete", strArrays1, timeKeeperTableListID);
        }

        public string Delete(SqlConnection myConnection, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_TIMEKEEPER_PRIVATE_Delete", strArrays1, timeKeeperTableListID);
        }

        public string Delete(SqlTransaction myTransaction, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_PRIVATE_Delete", strArrays1, timeKeeperTableListID);
        }

        public string Delete(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_PRIVATE_DeleteAllDay", strArrays, timeKeeperTableListID);
        }

        public string DeleteByDate(Guid TimeKeeperTableListID, string EmployeeCode, DateTime Date)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@Date" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, Date };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery("Delete From [HRM_TIMEKEEPER_PRIVATE]\r\nWhere \r\n   [TimeKeeperTableListID] = @TimeKeeperTableListID\r\nAND \r\n   [EmployeeCode] = @EmployeeCode\r\nAND\r\n   [Date]=@Date\r\nAND [ShiftCode]<>''", strArrays, objArray);
        }

        public string DeleteByShift(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery("Delete From [HRM_TIMEKEEPER_PRIVATE]\r\nWhere \r\n   [TimeKeeperTableListID] = @TimeKeeperTableListID\r\nAND \r\n   [EmployeeCode] = @EmployeeCode\r\nAND\r\n   [Date]=@Date\r\nAND [ShiftCode]<>@ShiftCode", strArrays, objArray);
        }

        public bool Exist(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_PRIVATE_Get", strArrays1, objArray);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID)
        {
            string str = "";
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_PRIVATE_Get", strArrays1, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_ShiftCode = Convert.ToString(sqlDataReader["ShiftCode"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_OrderID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("OrderID"));
                    this.m_PrivateBeginTime = Convert.ToDateTime(sqlDataReader["PrivateBeginTime"]);
                    this.m_PrivateEndTime = Convert.ToDateTime(sqlDataReader["PrivateEndTime"]);
                    this.m_Hour = Convert.ToDouble(sqlDataReader["Hour"]);
                    this.m_Minute = Convert.ToInt32(sqlDataReader["Minute"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID)
        {
            string str = "";
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_TIMEKEEPER_PRIVATE_Get", strArrays1, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_ShiftCode = Convert.ToString(sqlDataReader["ShiftCode"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_OrderID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("OrderID"));
                    this.m_PrivateBeginTime = Convert.ToDateTime(sqlDataReader["PrivateBeginTime"]);
                    this.m_PrivateEndTime = Convert.ToDateTime(sqlDataReader["PrivateEndTime"]);
                    this.m_Hour = Convert.ToDouble(sqlDataReader["Hour"]);
                    this.m_Minute = Convert.ToInt32(sqlDataReader["Minute"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID)
        {
            string str = "";
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_TIMEKEEPER_PRIVATE_Get", strArrays1, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_TimeKeeperTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("TimeKeeperTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_ShiftCode = Convert.ToString(sqlDataReader["ShiftCode"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_OrderID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("OrderID"));
                    this.m_PrivateBeginTime = Convert.ToDateTime(sqlDataReader["PrivateBeginTime"]);
                    this.m_PrivateEndTime = Convert.ToDateTime(sqlDataReader["PrivateEndTime"]);
                    this.m_Hour = Convert.ToDouble(sqlDataReader["Hour"]);
                    this.m_Minute = Convert.ToInt32(sqlDataReader["Minute"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetList(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_PRIVATE_GetList", strArrays, timeKeeperTableListID);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID", "@PrivateBeginTime", "@PrivateEndTime", "@Hour", "@Minute" };
            string[] strArrays1 = strArrays;
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_OrderID, this.m_PrivateBeginTime, this.m_PrivateEndTime, this.m_Hour, this.m_Minute };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_PRIVATE_Insert", strArrays1, mTimeKeeperTableListID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID", "@PrivateBeginTime", "@PrivateEndTime", "@Hour", "@Minute" };
            string[] strArrays1 = strArrays;
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_OrderID, this.m_PrivateBeginTime, this.m_PrivateEndTime, this.m_Hour, this.m_Minute };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_PRIVATE_Insert", strArrays1, mTimeKeeperTableListID);
        }

        public string Insert(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID, DateTime PrivateBeginTime, DateTime PrivateEndTime, double Hour, int Minute)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID", "@PrivateBeginTime", "@PrivateEndTime", "@Hour", "@Minute" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID, PrivateBeginTime, PrivateEndTime, Hour, Minute };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_PRIVATE_Insert", strArrays1, timeKeeperTableListID);
        }

        public string Insert(SqlConnection myConnection, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID, DateTime PrivateBeginTime, DateTime PrivateEndTime, double Hour, int Minute)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID", "@PrivateBeginTime", "@PrivateEndTime", "@Hour", "@Minute" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID, PrivateBeginTime, PrivateEndTime, Hour, Minute };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_TIMEKEEPER_PRIVATE_Insert", strArrays1, timeKeeperTableListID);
        }

        public string Insert(SqlTransaction myTransaction, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID, DateTime PrivateBeginTime, DateTime PrivateEndTime, double Hour, int Minute)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID", "@PrivateBeginTime", "@PrivateEndTime", "@Hour", "@Minute" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID, PrivateBeginTime, PrivateEndTime, Hour, Minute };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_PRIVATE_Insert", strArrays1, timeKeeperTableListID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_TIMEKEEPER_PRIVATE", "TimeKeeperTableListID", "CV");
        }

        public double TotalNightPrivateHour(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date)
        {
            return 0;
        }

        public double TotalPrivateHour(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date)
        {
            double num = 0;
            foreach (DataRow row in this.GetList(TimeKeeperTableListID, EmployeeCode, ShiftCode, Date).Rows)
            {
                num += Convert.ToDouble(row["Hour"].ToString());
            }
            return num;
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID", "@PrivateBeginTime", "@PrivateEndTime", "@Hour", "@Minute" };
            string[] strArrays1 = strArrays;
            object[] mTimeKeeperTableListID = new object[] { this.m_TimeKeeperTableListID, this.m_EmployeeCode, this.m_ShiftCode, this.m_Date, this.m_OrderID, this.m_PrivateBeginTime, this.m_PrivateEndTime, this.m_Hour, this.m_Minute };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_PRIVATE_Update", strArrays1, mTimeKeeperTableListID);
        }

        public string Update(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID, DateTime PrivateBeginTime, DateTime PrivateEndTime, double Hour, int Minute)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID", "@PrivateBeginTime", "@PrivateEndTime", "@Hour", "@Minute" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID, PrivateBeginTime, PrivateEndTime, Hour, Minute };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_PRIVATE_Update", strArrays1, timeKeeperTableListID);
        }

        public string Update(SqlConnection myConnection, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID, DateTime PrivateBeginTime, DateTime PrivateEndTime, double Hour, int Minute)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID", "@PrivateBeginTime", "@PrivateEndTime", "@Hour", "@Minute" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID, PrivateBeginTime, PrivateEndTime, Hour, Minute };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_TIMEKEEPER_PRIVATE_Update", strArrays1, timeKeeperTableListID);
        }

        public string Update(SqlTransaction myTransaction, Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, DateTime Date, Guid OrderID, DateTime PrivateBeginTime, DateTime PrivateEndTime, double Hour, int Minute)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Date", "@OrderID", "@PrivateBeginTime", "@PrivateEndTime", "@Hour", "@Minute" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Date, OrderID, PrivateBeginTime, PrivateEndTime, Hour, Minute };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_TIMEKEEPER_PRIVATE_Update", strArrays1, timeKeeperTableListID);
        }
    }
}