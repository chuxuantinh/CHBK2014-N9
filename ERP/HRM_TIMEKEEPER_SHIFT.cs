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
   public class HRM_TIMEKEEPER_SHIFT
    {
        private Guid m_TimeKeeperTableListID;

        private string m_EmployeeCode;

        private string m_ShiftCode;

        private bool m_AllDay;

        private bool m_D1;

        private bool m_D2;

        private bool m_D3;

        private bool m_D4;

        private bool m_D5;

        private bool m_D6;

        private bool m_D7;

        private bool m_D8;

        private bool m_D9;

        private bool m_D10;

        private bool m_D11;

        private bool m_D12;

        private bool m_D13;

        private bool m_D14;

        private bool m_D15;

        private bool m_D16;

        private bool m_D17;

        private bool m_D18;

        private bool m_D19;

        private bool m_D20;

        private bool m_D21;

        private bool m_D22;

        private bool m_D23;

        private bool m_D24;

        private bool m_D25;

        private bool m_D26;

        private bool m_D27;

        private bool m_D28;

        private bool m_D29;

        private bool m_D30;

        private bool m_D31;

        [Category("Column")]
        [DisplayName("AllDay")]
        public bool AllDay
        {
            get
            {
                return this.m_AllDay;
            }
            set
            {
                this.m_AllDay = value;
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return "2.5.0.0";
            }
        }

        public string Copyright
        {
            get
            {
                return "BK";
            }
        }

        [Category("Column")]
        [DisplayName("D1")]
        public bool D1
        {
            get
            {
                return this.m_D1;
            }
            set
            {
                this.m_D1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D10")]
        public bool D10
        {
            get
            {
                return this.m_D10;
            }
            set
            {
                this.m_D10 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D11")]
        public bool D11
        {
            get
            {
                return this.m_D11;
            }
            set
            {
                this.m_D11 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D12")]
        public bool D12
        {
            get
            {
                return this.m_D12;
            }
            set
            {
                this.m_D12 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D13")]
        public bool D13
        {
            get
            {
                return this.m_D13;
            }
            set
            {
                this.m_D13 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D14")]
        public bool D14
        {
            get
            {
                return this.m_D14;
            }
            set
            {
                this.m_D14 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D15")]
        public bool D15
        {
            get
            {
                return this.m_D15;
            }
            set
            {
                this.m_D15 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D16")]
        public bool D16
        {
            get
            {
                return this.m_D16;
            }
            set
            {
                this.m_D16 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D17")]
        public bool D17
        {
            get
            {
                return this.m_D17;
            }
            set
            {
                this.m_D17 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D18")]
        public bool D18
        {
            get
            {
                return this.m_D18;
            }
            set
            {
                this.m_D18 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D19")]
        public bool D19
        {
            get
            {
                return this.m_D19;
            }
            set
            {
                this.m_D19 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D2")]
        public bool D2
        {
            get
            {
                return this.m_D2;
            }
            set
            {
                this.m_D2 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D20")]
        public bool D20
        {
            get
            {
                return this.m_D20;
            }
            set
            {
                this.m_D20 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D21")]
        public bool D21
        {
            get
            {
                return this.m_D21;
            }
            set
            {
                this.m_D21 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D22")]
        public bool D22
        {
            get
            {
                return this.m_D22;
            }
            set
            {
                this.m_D22 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D23")]
        public bool D23
        {
            get
            {
                return this.m_D23;
            }
            set
            {
                this.m_D23 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D24")]
        public bool D24
        {
            get
            {
                return this.m_D24;
            }
            set
            {
                this.m_D24 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D25")]
        public bool D25
        {
            get
            {
                return this.m_D25;
            }
            set
            {
                this.m_D25 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D26")]
        public bool D26
        {
            get
            {
                return this.m_D26;
            }
            set
            {
                this.m_D26 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D27")]
        public bool D27
        {
            get
            {
                return this.m_D27;
            }
            set
            {
                this.m_D27 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D28")]
        public bool D28
        {
            get
            {
                return this.m_D28;
            }
            set
            {
                this.m_D28 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D29")]
        public bool D29
        {
            get
            {
                return this.m_D29;
            }
            set
            {
                this.m_D29 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D3")]
        public bool D3
        {
            get
            {
                return this.m_D3;
            }
            set
            {
                this.m_D3 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D30")]
        public bool D30
        {
            get
            {
                return this.m_D30;
            }
            set
            {
                this.m_D30 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D31")]
        public bool D31
        {
            get
            {
                return this.m_D31;
            }
            set
            {
                this.m_D31 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D4")]
        public bool D4
        {
            get
            {
                return this.m_D4;
            }
            set
            {
                this.m_D4 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D5")]
        public bool D5
        {
            get
            {
                return this.m_D5;
            }
            set
            {
                this.m_D5 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D6")]
        public bool D6
        {
            get
            {
                return this.m_D6;
            }
            set
            {
                this.m_D6 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D7")]
        public bool D7
        {
            get
            {
                return this.m_D7;
            }
            set
            {
                this.m_D7 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D8")]
        public bool D8
        {
            get
            {
                return this.m_D8;
            }
            set
            {
                this.m_D8 = value;
            }
        }

        [Category("Column")]
        [DisplayName("D9")]
        public bool D9
        {
            get
            {
                return this.m_D9;
            }
            set
            {
                this.m_D9 = value;
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

        public string Product
        {
            get
            {
                return "Class HRM_TIMEKEEPER_SHIFT";
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

        public HRM_TIMEKEEPER_SHIFT()
        {
            this.m_TimeKeeperTableListID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_ShiftCode = "";
            this.m_AllDay = true;
            this.m_D1 = true;
            this.m_D2 = true;
            this.m_D3 = true;
            this.m_D4 = true;
            this.m_D5 = true;
            this.m_D6 = true;
            this.m_D7 = true;
            this.m_D8 = true;
            this.m_D9 = true;
            this.m_D10 = true;
            this.m_D11 = true;
            this.m_D12 = true;
            this.m_D13 = true;
            this.m_D14 = true;
            this.m_D15 = true;
            this.m_D16 = true;
            this.m_D17 = true;
            this.m_D18 = true;
            this.m_D19 = true;
            this.m_D20 = true;
            this.m_D21 = true;
            this.m_D22 = true;
            this.m_D23 = true;
            this.m_D24 = true;
            this.m_D25 = true;
            this.m_D26 = true;
            this.m_D27 = true;
            this.m_D28 = true;
            this.m_D29 = true;
            this.m_D30 = true;
            this.m_D31 = true;
        }

        public HRM_TIMEKEEPER_SHIFT(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, bool AllDay, bool D1, bool D2, bool D3, bool D4, bool D5, bool D6, bool D7, bool D8, bool D9, bool D10, bool D11, bool D12, bool D13, bool D14, bool D15, bool D16, bool D17, bool D18, bool D19, bool D20, bool D21, bool D22, bool D23, bool D24, bool D25, bool D26, bool D27, bool D28, bool D29, bool D30, bool D31)
        {
            this.m_TimeKeeperTableListID = TimeKeeperTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_ShiftCode = ShiftCode;
            this.m_AllDay = AllDay;
            this.m_D1 = D1;
            this.m_D2 = D2;
            this.m_D3 = D3;
            this.m_D4 = D4;
            this.m_D5 = D5;
            this.m_D6 = D6;
            this.m_D7 = D7;
            this.m_D8 = D8;
            this.m_D9 = D9;
            this.m_D10 = D10;
            this.m_D11 = D11;
            this.m_D12 = D12;
            this.m_D13 = D13;
            this.m_D14 = D14;
            this.m_D15 = D15;
            this.m_D16 = D16;
            this.m_D17 = D17;
            this.m_D18 = D18;
            this.m_D19 = D19;
            this.m_D20 = D20;
            this.m_D21 = D21;
            this.m_D22 = D22;
            this.m_D23 = D23;
            this.m_D24 = D24;
            this.m_D25 = D25;
            this.m_D26 = D26;
            this.m_D27 = D27;
            this.m_D28 = D28;
            this.m_D29 = D29;
            this.m_D30 = D30;
            this.m_D31 = D31;
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
                if ((new HRM_TIMEKEEPER_SHIFT()).GetListByEmployee(TimeKeeperTableListID, row["EmployeeCode"].ToString()).Rows.Count <= 0)
                {
                    string[] str = new string[] { "Đang khởi tạo...", row["FirstName"].ToString(), " ", row["LastName"].ToString(), " (", row["EmployeeCode"].ToString(), ")" };
                    Options.SetWaitDialogCaption(string.Concat(str));
                    Thread thread = new Thread(() => this.Create(TimeKeeperTableListID, row["EmployeeCode"].ToString()));
                    thread.Start();
                    thread.Join();
                }
            }
            Options.HideDialog();
            return "OK";
        }

        public string Create(Guid TimeKeeperTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_SHIFT_Create1", strArrays, timeKeeperTableListID);
        }

        public string CreateByShift(Guid TimeKeeperTableListID, int Month, int Year)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@Month", "@Year" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, Month, Year };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_SHIFT_CreateByShift", strArrays, timeKeeperTableListID);
        }

        public DataTable CreateNullDataTable()
        {
            SqlHelper sqlHelper = new SqlHelper();
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("TimeKeeperTableListID");
            DataColumn dataColumn1 = new DataColumn("EmployeeCode");
            DataColumn dataColumn2 = new DataColumn("FirstName");
            DataColumn dataColumn3 = new DataColumn("LastName");
            DataColumn dataColumn4 = new DataColumn("ShiftCode");
            DataColumn dataColumn5 = new DataColumn("AllDay");
            DataColumn dataColumn6 = new DataColumn("D1");
            DataColumn dataColumn7 = new DataColumn("D2");
            DataColumn dataColumn8 = new DataColumn("D3");
            DataColumn dataColumn9 = new DataColumn("D4");
            DataColumn dataColumn10 = new DataColumn("D5");
            DataColumn dataColumn11 = new DataColumn("D6");
            DataColumn dataColumn12 = new DataColumn("D7");
            DataColumn dataColumn13 = new DataColumn("D8");
            DataColumn dataColumn14 = new DataColumn("D9");
            DataColumn dataColumn15 = new DataColumn("D10");
            DataColumn dataColumn16 = new DataColumn("D11");
            DataColumn dataColumn17 = new DataColumn("D12");
            DataColumn dataColumn18 = new DataColumn("D13");
            DataColumn dataColumn19 = new DataColumn("D14");
            DataColumn dataColumn20 = new DataColumn("D15");
            DataColumn dataColumn21 = new DataColumn("D16");
            DataColumn dataColumn22 = new DataColumn("D17");
            DataColumn dataColumn23 = new DataColumn("D18");
            DataColumn dataColumn24 = new DataColumn("D19");
            DataColumn dataColumn25 = new DataColumn("D20");
            DataColumn dataColumn26 = new DataColumn("D21");
            DataColumn dataColumn27 = new DataColumn("D22");
            DataColumn dataColumn28 = new DataColumn("D23");
            DataColumn dataColumn29 = new DataColumn("D24");
            DataColumn dataColumn30 = new DataColumn("D25");
            DataColumn dataColumn31 = new DataColumn("D26");
            DataColumn dataColumn32 = new DataColumn("D27");
            DataColumn dataColumn33 = new DataColumn("D28");
            DataColumn dataColumn34 = new DataColumn("D29");
            DataColumn dataColumn35 = new DataColumn("D30");
            DataColumn dataColumn36 = new DataColumn("D31");
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
            dataTable.Columns.Add(dataColumn17);
            dataTable.Columns.Add(dataColumn18);
            dataTable.Columns.Add(dataColumn19);
            dataTable.Columns.Add(dataColumn20);
            dataTable.Columns.Add(dataColumn21);
            dataTable.Columns.Add(dataColumn22);
            dataTable.Columns.Add(dataColumn23);
            dataTable.Columns.Add(dataColumn24);
            dataTable.Columns.Add(dataColumn25);
            dataTable.Columns.Add(dataColumn26);
            dataTable.Columns.Add(dataColumn27);
            dataTable.Columns.Add(dataColumn28);
            dataTable.Columns.Add(dataColumn29);
            dataTable.Columns.Add(dataColumn30);
            dataTable.Columns.Add(dataColumn31);
            dataTable.Columns.Add(dataColumn32);
            dataTable.Columns.Add(dataColumn33);
            dataTable.Columns.Add(dataColumn34);
            dataTable.Columns.Add(dataColumn35);
            dataTable.Columns.Add(dataColumn36);
            dataTable.Clear();
            return dataTable;
        }

        public DataTable CreateNullEmployeesDataTable()
        {
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("EmployeeCode");
            DataColumn dataColumn1 = new DataColumn("FirstName");
            DataColumn dataColumn2 = new DataColumn("LastName");
            dataTable.Columns.Add(dataColumn);
            dataTable.Columns.Add(dataColumn1);
            dataTable.Columns.Add(dataColumn2);
            dataTable.Clear();
            return dataTable;
        }

        public bool Exist(Guid TimeKeeperTableListID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@TimeKeeperTableListID" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_SHIFT_Get", strArrays, timeKeeperTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public DataTable GetList(int Level, string Code, Guid TimeKeeperTableListID)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@TimeKeeperTableListID" };
            object[] level = new object[] { Level, Code, TimeKeeperTableListID };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_SHIFT_GetList", strArrays, level);
        }

        public DataTable GetList(int Level, string Code, Guid TimeKeeperTableListID, bool IsPrintNotNull, bool IsOnlyNightDay)
        {
            DataTable list = this.GetList(Level, Code, TimeKeeperTableListID);
            for (int i = 0; i < list.Rows.Count; i++)
            {
                if (IsPrintNotNull)
                {
                    if ((bool.Parse(list.Rows[i]["D1"].ToString()) || bool.Parse(list.Rows[i]["D2"].ToString()) || bool.Parse(list.Rows[i]["D3"].ToString()) || bool.Parse(list.Rows[i]["D4"].ToString()) || bool.Parse(list.Rows[i]["D5"].ToString()) || bool.Parse(list.Rows[i]["D6"].ToString()) || bool.Parse(list.Rows[i]["D7"].ToString()) || bool.Parse(list.Rows[i]["D8"].ToString()) || bool.Parse(list.Rows[i]["D9"].ToString()) || bool.Parse(list.Rows[i]["D10"].ToString()) || bool.Parse(list.Rows[i]["D11"].ToString()) || bool.Parse(list.Rows[i]["D12"].ToString()) || bool.Parse(list.Rows[i]["D13"].ToString()) || bool.Parse(list.Rows[i]["D14"].ToString()) || bool.Parse(list.Rows[i]["D15"].ToString()) || bool.Parse(list.Rows[i]["D16"].ToString()) || bool.Parse(list.Rows[i]["D17"].ToString()) || bool.Parse(list.Rows[i]["D18"].ToString()) || bool.Parse(list.Rows[i]["D19"].ToString()) || bool.Parse(list.Rows[i]["D20"].ToString()) || bool.Parse(list.Rows[i]["D21"].ToString()) || bool.Parse(list.Rows[i]["D22"].ToString()) || bool.Parse(list.Rows[i]["D23"].ToString()) || bool.Parse(list.Rows[i]["D24"].ToString()) || bool.Parse(list.Rows[i]["D25"].ToString()) || bool.Parse(list.Rows[i]["D26"].ToString()) || bool.Parse(list.Rows[i]["D27"].ToString()) || bool.Parse(list.Rows[i]["D28"].ToString()) || bool.Parse(list.Rows[i]["D29"].ToString()) || bool.Parse(list.Rows[i]["D30"].ToString()) ? false : !bool.Parse(list.Rows[i]["D31"].ToString())))
                    {
                        list.Rows.RemoveAt(i);
                        i--;
                    }
                }
                if (IsOnlyNightDay)
                {
                    try
                    {
                        string str = list.Rows[i]["ShiftCode"].ToString();
                        DIC_SHIFT dICSHIFT = new DIC_SHIFT();
                        dICSHIFT.Get(str);
                        if (!dICSHIFT.IsNightDutyDay)
                        {
                            list.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            return list;
        }

        public DataTable GetListByEmployee(Guid TimeKeeperTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_TIMEKEEPER_SHIFT_GetListByEmployee", strArrays, timeKeeperTableListID);
        }

        public DataTable GetListByEmployee(Guid TimeKeeperTableListID, string EmployeeCode, bool IsPrintNotNull)
        {
            DataTable listByEmployee = this.GetListByEmployee(TimeKeeperTableListID, EmployeeCode);
            for (int i = 0; i < listByEmployee.Rows.Count; i++)
            {
                if (IsPrintNotNull)
                {
                    if ((bool.Parse(listByEmployee.Rows[i]["D1"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D2"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D3"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D4"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D5"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D6"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D7"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D8"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D9"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D10"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D11"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D12"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D13"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D14"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D15"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D16"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D17"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D18"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D19"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D20"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D21"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D22"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D23"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D24"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D25"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D26"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D27"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D28"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D29"].ToString()) || bool.Parse(listByEmployee.Rows[i]["D30"].ToString()) ? false : !bool.Parse(listByEmployee.Rows[i]["D31"].ToString())))
                    {
                        listByEmployee.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            return listByEmployee;
        }

        public static bool IsWork(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, int Day)
        {
            bool flag = false;
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@Day" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, Day };
            object[] objArray = timeKeeperTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_SHIFT_IsWork", strArrays, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    flag = Convert.ToBoolean(sqlDataReader["IsWork"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return flag;
        }

        public static double TotalHour(Guid TimeKeeperTableListID, string EmployeeCode)
        {
            double num = 0;
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode" };
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_TIMEKEEPER_SHIFT_TotalHour", strArrays, timeKeeperTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToDouble(sqlDataReader["TotalHour"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public string Update(Guid TimeKeeperTableListID, string EmployeeCode, string ShiftCode, bool AllDay, bool D1, bool D2, bool D3, bool D4, bool D5, bool D6, bool D7, bool D8, bool D9, bool D10, bool D11, bool D12, bool D13, bool D14, bool D15, bool D16, bool D17, bool D18, bool D19, bool D20, bool D21, bool D22, bool D23, bool D24, bool D25, bool D26, bool D27, bool D28, bool D29, bool D30, bool D31)
        {
            string[] strArrays = new string[] { "@TimeKeeperTableListID", "@EmployeeCode", "@ShiftCode", "@AllDay", "@D1", "@D2", "@D3", "@D4", "@D5", "@D6", "@D7", "@D8", "@D9", "@D10", "@D11", "@D12", "@D13", "@D14", "@D15", "@D16", "@D17", "@D18", "@D19", "@D20", "@D21", "@D22", "@D23", "@D24", "@D25", "@D26", "@D27", "@D28", "@D29", "@D30", "@D31" };
            string[] strArrays1 = strArrays;
            object[] timeKeeperTableListID = new object[] { TimeKeeperTableListID, EmployeeCode, ShiftCode, AllDay, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, D21, D22, D23, D24, D25, D26, D27, D28, D29, D30, D31 };
            return (new SqlHelper()).ExecuteNonQuery("HRM_TIMEKEEPER_SHIFT_Update", strArrays1, timeKeeperTableListID);
        }
    }



}
