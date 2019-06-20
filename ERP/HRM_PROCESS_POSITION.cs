using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ERP
{
  public  class HRM_PROCESS_POSITION
    {
        private Guid m_PositionID;

        private string m_EmployeeCode;

        private string m_OldSubsidiaryCode;

        private string m_OldBranchCode;

        private string m_OldDepartmentCode;

        private string m_OldGroupCode;

        private string m_OldPosition;

        private string m_OldOrganization;

        private string m_NewSubsidiaryCode;

        private string m_NewBranchCode;

        private string m_NewDepartmentCode;

        private string m_NewGroupCode;

        private string m_NewPosition;

        private string m_NewOrganization;

        private DateTime m_Date;

        private string m_Reason;

        private string m_DecideNumber;

        private string m_Person;

        [Category("Column")]
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
        [DisplayName("DecideNumber")]
        public string DecideNumber
        {
            get
            {
                return this.m_DecideNumber;
            }
            set
            {
                this.m_DecideNumber = value;
            }
        }

        [Category("Column")]
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
        [DisplayName("NewBranchCode")]
        public string NewBranchCode
        {
            get
            {
                return this.m_NewBranchCode;
            }
            set
            {
                this.m_NewBranchCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewDepartmentCode")]
        public string NewDepartmentCode
        {
            get
            {
                return this.m_NewDepartmentCode;
            }
            set
            {
                this.m_NewDepartmentCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewGroupCode")]
        public string NewGroupCode
        {
            get
            {
                return this.m_NewGroupCode;
            }
            set
            {
                this.m_NewGroupCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewOrganization")]
        public string NewOrganization
        {
            get
            {
                return this.m_NewOrganization;
            }
            set
            {
                this.m_NewOrganization = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewPosition")]
        public string NewPosition
        {
            get
            {
                return this.m_NewPosition;
            }
            set
            {
                this.m_NewPosition = value;
            }
        }

        [Category("Column")]
        [DisplayName("NewSubsidiaryCode")]
        public string NewSubsidiaryCode
        {
            get
            {
                return this.m_NewSubsidiaryCode;
            }
            set
            {
                this.m_NewSubsidiaryCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldBranchCode")]
        public string OldBranchCode
        {
            get
            {
                return this.m_OldBranchCode;
            }
            set
            {
                this.m_OldBranchCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldDepartmentCode")]
        public string OldDepartmentCode
        {
            get
            {
                return this.m_OldDepartmentCode;
            }
            set
            {
                this.m_OldDepartmentCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldGroupCode")]
        public string OldGroupCode
        {
            get
            {
                return this.m_OldGroupCode;
            }
            set
            {
                this.m_OldGroupCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldOrganization")]
        public string OldOrganization
        {
            get
            {
                return this.m_OldOrganization;
            }
            set
            {
                this.m_OldOrganization = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldPosition")]
        public string OldPosition
        {
            get
            {
                return this.m_OldPosition;
            }
            set
            {
                this.m_OldPosition = value;
            }
        }

        [Category("Column")]
        [DisplayName("OldSubsidiaryCode")]
        public string OldSubsidiaryCode
        {
            get
            {
                return this.m_OldSubsidiaryCode;
            }
            set
            {
                this.m_OldSubsidiaryCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("Person")]
        public string Person
        {
            get
            {
                return this.m_Person;
            }
            set
            {
                this.m_Person = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("PositionID")]
        public Guid PositionID
        {
            get
            {
                return this.m_PositionID;
            }
            set
            {
                this.m_PositionID = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_PROCESS_POSITION";
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
        [DisplayName("Reason")]
        public string Reason
        {
            get
            {
                return this.m_Reason;
            }
            set
            {
                this.m_Reason = value;
            }
        }

        public HRM_PROCESS_POSITION()
        {
            this.m_PositionID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_OldSubsidiaryCode = "";
            this.m_OldBranchCode = "";
            this.m_OldDepartmentCode = "";
            this.m_OldGroupCode = "";
            this.m_OldPosition = "";
            this.m_OldOrganization = "";
            this.m_NewSubsidiaryCode = "";
            this.m_NewBranchCode = "";
            this.m_NewDepartmentCode = "";
            this.m_NewGroupCode = "";
            this.m_NewPosition = "";
            this.m_NewOrganization = "";
            this.m_Date = DateTime.Now;
            this.m_Reason = "";
            this.m_DecideNumber = "";
            this.m_Person = "";
        }

        public HRM_PROCESS_POSITION(Guid PositionID, string EmployeeCode, string OldSubsidiaryCode, string OldBranchCode, string OldDepartmentCode, string OldGroupCode, string OldPosition, string OldOrganization, string NewSubsidiaryCode, string NewBranchCode, string NewDepartmentCode, string NewGroupCode, string NewPosition, string NewOrganization, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            this.m_PositionID = PositionID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_OldSubsidiaryCode = OldSubsidiaryCode;
            this.m_OldBranchCode = OldBranchCode;
            this.m_OldDepartmentCode = OldDepartmentCode;
            this.m_OldGroupCode = OldGroupCode;
            this.m_OldPosition = OldPosition;
            this.m_OldOrganization = OldOrganization;
            this.m_NewSubsidiaryCode = NewSubsidiaryCode;
            this.m_NewBranchCode = NewBranchCode;
            this.m_NewDepartmentCode = NewDepartmentCode;
            this.m_NewGroupCode = NewGroupCode;
            this.m_NewPosition = NewPosition;
            this.m_NewOrganization = NewOrganization;
            this.m_Date = Date;
            this.m_Reason = Reason;
            this.m_DecideNumber = DecideNumber;
            this.m_Person = Person;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@PositionID" };
            object[] mPositionID = new object[] { this.m_PositionID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_POSITION_Delete", strArrays, mPositionID);
        }

        public string Delete(Guid PositionID)
        {
            string[] strArrays = new string[] { "@PositionID" };
            object[] positionID = new object[] { PositionID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_POSITION_Delete", strArrays, positionID);
        }

        public string Delete(SqlConnection myConnection, Guid PositionID)
        {
            string[] strArrays = new string[] { "@PositionID" };
            object[] positionID = new object[] { PositionID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_POSITION_Delete", strArrays, positionID);
        }

        public string Delete(SqlTransaction myTransaction, Guid PositionID)
        {
            string[] strArrays = new string[] { "@PositionID" };
            object[] positionID = new object[] { PositionID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_POSITION_Delete", strArrays, positionID);
        }

        public bool Exist(Guid PositionID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@PositionID" };
            object[] positionID = new object[] { PositionID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PROCESS_POSITION_Get", strArrays, positionID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid PositionID)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            object item2;
            object obj2;
            object item3;
            object obj3;
            object item4;
            object obj4;
            object item5;
            object obj5;
            object item6;
            object obj6;
            object item7;
            object obj7;
            string str = "";
            string[] strArrays = new string[] { "@PositionID" };
            object[] positionID = new object[] { PositionID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PROCESS_POSITION_Get", strArrays, positionID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_PositionID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("PositionID"));
                    if (sqlDataReader["EmployeeCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["EmployeeCode"];
                    }
                    this.m_EmployeeCode = Convert.ToString(item);
                    if (sqlDataReader["OldSubsidiaryCode"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["OldSubsidiaryCode"];
                    }
                    this.m_OldSubsidiaryCode = Convert.ToString(obj);
                    if (sqlDataReader["OldBranchCode"] == DBNull.Value)
                    {
                        item1 = "";
                    }
                    else
                    {
                        item1 = sqlDataReader["OldBranchCode"];
                    }
                    this.m_OldBranchCode = Convert.ToString(item1);
                    if (sqlDataReader["OldDepartmentCode"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["OldDepartmentCode"];
                    }
                    this.m_OldDepartmentCode = Convert.ToString(obj1);
                    if (sqlDataReader["OldGroupCode"] == DBNull.Value)
                    {
                        item2 = "";
                    }
                    else
                    {
                        item2 = sqlDataReader["OldGroupCode"];
                    }
                    this.m_OldGroupCode = Convert.ToString(item2);
                    if (sqlDataReader["OldPosition"] == DBNull.Value)
                    {
                        obj2 = "";
                    }
                    else
                    {
                        obj2 = sqlDataReader["OldPosition"];
                    }
                    this.m_OldPosition = Convert.ToString(obj2);
                    if (sqlDataReader["OldOrganization"] == DBNull.Value)
                    {
                        item3 = "";
                    }
                    else
                    {
                        item3 = sqlDataReader["OldOrganization"];
                    }
                    this.m_OldOrganization = Convert.ToString(item3);
                    if (sqlDataReader["NewSubsidiaryCode"] == DBNull.Value)
                    {
                        obj3 = "";
                    }
                    else
                    {
                        obj3 = sqlDataReader["NewSubsidiaryCode"];
                    }
                    this.m_NewSubsidiaryCode = Convert.ToString(obj3);
                    if (sqlDataReader["NewBranchCode"] == DBNull.Value)
                    {
                        item4 = "";
                    }
                    else
                    {
                        item4 = sqlDataReader["NewBranchCode"];
                    }
                    this.m_NewBranchCode = Convert.ToString(item4);
                    if (sqlDataReader["NewDepartmentCode"] == DBNull.Value)
                    {
                        obj4 = "";
                    }
                    else
                    {
                        obj4 = sqlDataReader["NewDepartmentCode"];
                    }
                    this.m_NewDepartmentCode = Convert.ToString(obj4);
                    if (sqlDataReader["NewGroupCode"] == DBNull.Value)
                    {
                        item5 = "";
                    }
                    else
                    {
                        item5 = sqlDataReader["NewGroupCode"];
                    }
                    this.m_NewGroupCode = Convert.ToString(item5);
                    if (sqlDataReader["NewPosition"] == DBNull.Value)
                    {
                        obj5 = "";
                    }
                    else
                    {
                        obj5 = sqlDataReader["NewPosition"];
                    }
                    this.m_NewPosition = Convert.ToString(obj5);
                    if (sqlDataReader["NewOrganization"] == DBNull.Value)
                    {
                        item6 = "";
                    }
                    else
                    {
                        item6 = sqlDataReader["NewOrganization"];
                    }
                    this.m_NewOrganization = Convert.ToString(item6);
                    this.m_Date = Convert.ToDateTime((sqlDataReader["Date"] == DBNull.Value ? DateTime.Now : sqlDataReader["Date"]));
                    if (sqlDataReader["Reason"] == DBNull.Value)
                    {
                        obj6 = "";
                    }
                    else
                    {
                        obj6 = sqlDataReader["Reason"];
                    }
                    this.m_Reason = Convert.ToString(obj6);
                    if (sqlDataReader["DecideNumber"] == DBNull.Value)
                    {
                        item7 = "";
                    }
                    else
                    {
                        item7 = sqlDataReader["DecideNumber"];
                    }
                    this.m_DecideNumber = Convert.ToString(item7);
                    if (sqlDataReader["Person"] == DBNull.Value)
                    {
                        obj7 = "";
                    }
                    else
                    {
                        obj7 = sqlDataReader["Person"];
                    }
                    this.m_Person = Convert.ToString(obj7);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid PositionID)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            object item2;
            object obj2;
            object item3;
            object obj3;
            object item4;
            object obj4;
            object item5;
            object obj5;
            object item6;
            object obj6;
            object item7;
            object obj7;
            string str = "";
            string[] strArrays = new string[] { "@PositionID" };
            object[] positionID = new object[] { PositionID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_PROCESS_POSITION_Get", strArrays, positionID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_PositionID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("PositionID"));
                    if (sqlDataReader["EmployeeCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["EmployeeCode"];
                    }
                    this.m_EmployeeCode = Convert.ToString(item);
                    if (sqlDataReader["OldSubsidiaryCode"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["OldSubsidiaryCode"];
                    }
                    this.m_OldSubsidiaryCode = Convert.ToString(obj);
                    if (sqlDataReader["OldBranchCode"] == DBNull.Value)
                    {
                        item1 = "";
                    }
                    else
                    {
                        item1 = sqlDataReader["OldBranchCode"];
                    }
                    this.m_OldBranchCode = Convert.ToString(item1);
                    if (sqlDataReader["OldDepartmentCode"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["OldDepartmentCode"];
                    }
                    this.m_OldDepartmentCode = Convert.ToString(obj1);
                    if (sqlDataReader["OldGroupCode"] == DBNull.Value)
                    {
                        item2 = "";
                    }
                    else
                    {
                        item2 = sqlDataReader["OldGroupCode"];
                    }
                    this.m_OldGroupCode = Convert.ToString(item2);
                    if (sqlDataReader["OldPosition"] == DBNull.Value)
                    {
                        obj2 = "";
                    }
                    else
                    {
                        obj2 = sqlDataReader["OldPosition"];
                    }
                    this.m_OldPosition = Convert.ToString(obj2);
                    if (sqlDataReader["OldOrganization"] == DBNull.Value)
                    {
                        item3 = "";
                    }
                    else
                    {
                        item3 = sqlDataReader["OldOrganization"];
                    }
                    this.m_OldOrganization = Convert.ToString(item3);
                    if (sqlDataReader["NewSubsidiaryCode"] == DBNull.Value)
                    {
                        obj3 = "";
                    }
                    else
                    {
                        obj3 = sqlDataReader["NewSubsidiaryCode"];
                    }
                    this.m_NewSubsidiaryCode = Convert.ToString(obj3);
                    if (sqlDataReader["NewBranchCode"] == DBNull.Value)
                    {
                        item4 = "";
                    }
                    else
                    {
                        item4 = sqlDataReader["NewBranchCode"];
                    }
                    this.m_NewBranchCode = Convert.ToString(item4);
                    if (sqlDataReader["NewDepartmentCode"] == DBNull.Value)
                    {
                        obj4 = "";
                    }
                    else
                    {
                        obj4 = sqlDataReader["NewDepartmentCode"];
                    }
                    this.m_NewDepartmentCode = Convert.ToString(obj4);
                    if (sqlDataReader["NewGroupCode"] == DBNull.Value)
                    {
                        item5 = "";
                    }
                    else
                    {
                        item5 = sqlDataReader["NewGroupCode"];
                    }
                    this.m_NewGroupCode = Convert.ToString(item5);
                    if (sqlDataReader["NewPosition"] == DBNull.Value)
                    {
                        obj5 = "";
                    }
                    else
                    {
                        obj5 = sqlDataReader["NewPosition"];
                    }
                    this.m_NewPosition = Convert.ToString(obj5);
                    if (sqlDataReader["NewOrganization"] == DBNull.Value)
                    {
                        item6 = "";
                    }
                    else
                    {
                        item6 = sqlDataReader["NewOrganization"];
                    }
                    this.m_NewOrganization = Convert.ToString(item6);
                    this.m_Date = Convert.ToDateTime((sqlDataReader["Date"] == DBNull.Value ? DateTime.Now : sqlDataReader["Date"]));
                    if (sqlDataReader["Reason"] == DBNull.Value)
                    {
                        obj6 = "";
                    }
                    else
                    {
                        obj6 = sqlDataReader["Reason"];
                    }
                    this.m_Reason = Convert.ToString(obj6);
                    if (sqlDataReader["DecideNumber"] == DBNull.Value)
                    {
                        item7 = "";
                    }
                    else
                    {
                        item7 = sqlDataReader["DecideNumber"];
                    }
                    this.m_DecideNumber = Convert.ToString(item7);
                    if (sqlDataReader["Person"] == DBNull.Value)
                    {
                        obj7 = "";
                    }
                    else
                    {
                        obj7 = sqlDataReader["Person"];
                    }
                    this.m_Person = Convert.ToString(obj7);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid PositionID)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            object item2;
            object obj2;
            object item3;
            object obj3;
            object item4;
            object obj4;
            object item5;
            object obj5;
            object item6;
            object obj6;
            object item7;
            object obj7;
            string str = "";
            string[] strArrays = new string[] { "@PositionID" };
            object[] positionID = new object[] { PositionID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_PROCESS_POSITION_Get", strArrays, positionID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_PositionID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("PositionID"));
                    if (sqlDataReader["EmployeeCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["EmployeeCode"];
                    }
                    this.m_EmployeeCode = Convert.ToString(item);
                    if (sqlDataReader["OldSubsidiaryCode"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["OldSubsidiaryCode"];
                    }
                    this.m_OldSubsidiaryCode = Convert.ToString(obj);
                    if (sqlDataReader["OldBranchCode"] == DBNull.Value)
                    {
                        item1 = "";
                    }
                    else
                    {
                        item1 = sqlDataReader["OldBranchCode"];
                    }
                    this.m_OldBranchCode = Convert.ToString(item1);
                    if (sqlDataReader["OldDepartmentCode"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["OldDepartmentCode"];
                    }
                    this.m_OldDepartmentCode = Convert.ToString(obj1);
                    if (sqlDataReader["OldGroupCode"] == DBNull.Value)
                    {
                        item2 = "";
                    }
                    else
                    {
                        item2 = sqlDataReader["OldGroupCode"];
                    }
                    this.m_OldGroupCode = Convert.ToString(item2);
                    if (sqlDataReader["OldPosition"] == DBNull.Value)
                    {
                        obj2 = "";
                    }
                    else
                    {
                        obj2 = sqlDataReader["OldPosition"];
                    }
                    this.m_OldPosition = Convert.ToString(obj2);
                    if (sqlDataReader["OldOrganization"] == DBNull.Value)
                    {
                        item3 = "";
                    }
                    else
                    {
                        item3 = sqlDataReader["OldOrganization"];
                    }
                    this.m_OldOrganization = Convert.ToString(item3);
                    if (sqlDataReader["NewSubsidiaryCode"] == DBNull.Value)
                    {
                        obj3 = "";
                    }
                    else
                    {
                        obj3 = sqlDataReader["NewSubsidiaryCode"];
                    }
                    this.m_NewSubsidiaryCode = Convert.ToString(obj3);
                    if (sqlDataReader["NewBranchCode"] == DBNull.Value)
                    {
                        item4 = "";
                    }
                    else
                    {
                        item4 = sqlDataReader["NewBranchCode"];
                    }
                    this.m_NewBranchCode = Convert.ToString(item4);
                    if (sqlDataReader["NewDepartmentCode"] == DBNull.Value)
                    {
                        obj4 = "";
                    }
                    else
                    {
                        obj4 = sqlDataReader["NewDepartmentCode"];
                    }
                    this.m_NewDepartmentCode = Convert.ToString(obj4);
                    if (sqlDataReader["NewGroupCode"] == DBNull.Value)
                    {
                        item5 = "";
                    }
                    else
                    {
                        item5 = sqlDataReader["NewGroupCode"];
                    }
                    this.m_NewGroupCode = Convert.ToString(item5);
                    if (sqlDataReader["NewPosition"] == DBNull.Value)
                    {
                        obj5 = "";
                    }
                    else
                    {
                        obj5 = sqlDataReader["NewPosition"];
                    }
                    this.m_NewPosition = Convert.ToString(obj5);
                    if (sqlDataReader["NewOrganization"] == DBNull.Value)
                    {
                        item6 = "";
                    }
                    else
                    {
                        item6 = sqlDataReader["NewOrganization"];
                    }
                    this.m_NewOrganization = Convert.ToString(item6);
                    this.m_Date = Convert.ToDateTime((sqlDataReader["Date"] == DBNull.Value ? DateTime.Now : sqlDataReader["Date"]));
                    if (sqlDataReader["Reason"] == DBNull.Value)
                    {
                        obj6 = "";
                    }
                    else
                    {
                        obj6 = sqlDataReader["Reason"];
                    }
                    this.m_Reason = Convert.ToString(obj6);
                    if (sqlDataReader["DecideNumber"] == DBNull.Value)
                    {
                        item7 = "";
                    }
                    else
                    {
                        item7 = sqlDataReader["DecideNumber"];
                    }
                    this.m_DecideNumber = Convert.ToString(item7);
                    if (sqlDataReader["Person"] == DBNull.Value)
                    {
                        obj7 = "";
                    }
                    else
                    {
                        obj7 = sqlDataReader["Person"];
                    }
                    this.m_Person = Convert.ToString(obj7);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetAllList()
        {
            int level = MyLogin.Level;
            string code = MyLogin.Code;
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] objArray = new object[] { level, code };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_POSITION_GetAllList", strArrays, objArray);
        }

        public DataTable GetAllListByDays(DateTime BeginDate, DateTime EndDate)
        {
            int level = MyLogin.Level;
            string code = MyLogin.Code;
            string[] strArrays = new string[] { "@Level", "@Code", "@BeginDate", "@EndDate" };
            object[] beginDate = new object[] { level, code, BeginDate, EndDate };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_POSITION_GetAllListByDays", strArrays, beginDate);
        }

        public DataTable GetList()
        {
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_POSITION_GetList");
        }

        public DataTable GetListByDays(string EmployeeCode, DateTime BeginDate, DateTime EndDate)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@BeginDate", "@EndDate" };
            object[] employeeCode = new object[] { EmployeeCode, BeginDate, EndDate };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_POSITION_GetListByDays", strArrays, employeeCode);
        }

        public DataTable GetListByEmployee(string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_POSITION_GetListByEmployee", strArrays, employeeCode);
        }

        public DataTable GetListByMonth(string EmployeeCode, int Month, int Year)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Month", "@Year" };
            object[] employeeCode = new object[] { EmployeeCode, Month, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_PROCESS_POSITION_GetListByMonth", strArrays, employeeCode);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@PositionID", "@EmployeeCode", "@OldSubsidiaryCode", "@OldBranchCode", "@OldDepartmentCode", "@OldGroupCode", "@OldPosition", "@OldOrganization", "@NewSubsidiaryCode", "@NewBranchCode", "@NewDepartmentCode", "@NewGroupCode", "@NewPosition", "@NewOrganization", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] mPositionID = new object[] { this.m_PositionID, this.m_EmployeeCode, this.m_OldSubsidiaryCode, this.m_OldBranchCode, this.m_OldDepartmentCode, this.m_OldGroupCode, this.m_OldPosition, this.m_OldOrganization, this.m_NewSubsidiaryCode, this.m_NewBranchCode, this.m_NewDepartmentCode, this.m_NewGroupCode, this.m_NewPosition, this.m_NewOrganization, this.m_Date, this.m_Reason, this.m_DecideNumber, this.m_Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_POSITION_Insert", strArrays1, mPositionID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@PositionID", "@EmployeeCode", "@OldSubsidiaryCode", "@OldBranchCode", "@OldDepartmentCode", "@OldGroupCode", "@OldPosition", "@OldOrganization", "@NewSubsidiaryCode", "@NewBranchCode", "@NewDepartmentCode", "@NewGroupCode", "@NewPosition", "@NewOrganization", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] mPositionID = new object[] { this.m_PositionID, this.m_EmployeeCode, this.m_OldSubsidiaryCode, this.m_OldBranchCode, this.m_OldDepartmentCode, this.m_OldGroupCode, this.m_OldPosition, this.m_OldOrganization, this.m_NewSubsidiaryCode, this.m_NewBranchCode, this.m_NewDepartmentCode, this.m_NewGroupCode, this.m_NewPosition, this.m_NewOrganization, this.m_Date, this.m_Reason, this.m_DecideNumber, this.m_Person };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_POSITION_Insert", strArrays1, mPositionID);
        }

        public string Insert(Guid PositionID, string EmployeeCode, string OldSubsidiaryCode, string OldBranchCode, string OldDepartmentCode, string OldGroupCode, string OldPosition, string OldOrganization, string NewSubsidiaryCode, string NewBranchCode, string NewDepartmentCode, string NewGroupCode, string NewPosition, string NewOrganization, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@PositionID", "@EmployeeCode", "@OldSubsidiaryCode", "@OldBranchCode", "@OldDepartmentCode", "@OldGroupCode", "@OldPosition", "@OldOrganization", "@NewSubsidiaryCode", "@NewBranchCode", "@NewDepartmentCode", "@NewGroupCode", "@NewPosition", "@NewOrganization", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] positionID = new object[] { PositionID, EmployeeCode, OldSubsidiaryCode, OldBranchCode, OldDepartmentCode, OldGroupCode, OldPosition, OldOrganization, NewSubsidiaryCode, NewBranchCode, NewDepartmentCode, NewGroupCode, NewPosition, NewOrganization, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_POSITION_Insert", strArrays1, positionID);
        }

        public string Insert(SqlConnection myConnection, Guid PositionID, string EmployeeCode, string OldSubsidiaryCode, string OldBranchCode, string OldDepartmentCode, string OldGroupCode, string OldPosition, string OldOrganization, string NewSubsidiaryCode, string NewBranchCode, string NewDepartmentCode, string NewGroupCode, string NewPosition, string NewOrganization, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@PositionID", "@EmployeeCode", "@OldSubsidiaryCode", "@OldBranchCode", "@OldDepartmentCode", "@OldGroupCode", "@OldPosition", "@OldOrganization", "@NewSubsidiaryCode", "@NewBranchCode", "@NewDepartmentCode", "@NewGroupCode", "@NewPosition", "@NewOrganization", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] positionID = new object[] { PositionID, EmployeeCode, OldSubsidiaryCode, OldBranchCode, OldDepartmentCode, OldGroupCode, OldPosition, OldOrganization, NewSubsidiaryCode, NewBranchCode, NewDepartmentCode, NewGroupCode, NewPosition, NewOrganization, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_POSITION_Insert", strArrays1, positionID);
        }

        public string Insert(SqlTransaction myTransaction, Guid PositionID, string EmployeeCode, string OldSubsidiaryCode, string OldBranchCode, string OldDepartmentCode, string OldGroupCode, string OldPosition, string OldOrganization, string NewSubsidiaryCode, string NewBranchCode, string NewDepartmentCode, string NewGroupCode, string NewPosition, string NewOrganization, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@PositionID", "@EmployeeCode", "@OldSubsidiaryCode", "@OldBranchCode", "@OldDepartmentCode", "@OldGroupCode", "@OldPosition", "@OldOrganization", "@NewSubsidiaryCode", "@NewBranchCode", "@NewDepartmentCode", "@NewGroupCode", "@NewPosition", "@NewOrganization", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] positionID = new object[] { PositionID, EmployeeCode, OldSubsidiaryCode, OldBranchCode, OldDepartmentCode, OldGroupCode, OldPosition, OldOrganization, NewSubsidiaryCode, NewBranchCode, NewDepartmentCode, NewGroupCode, NewPosition, NewOrganization, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_POSITION_Insert", strArrays1, positionID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_PROCESS_POSITION", "JobCode", "CV");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@PositionID", "@EmployeeCode", "@OldSubsidiaryCode", "@OldBranchCode", "@OldDepartmentCode", "@OldGroupCode", "@OldPosition", "@OldOrganization", "@NewSubsidiaryCode", "@NewBranchCode", "@NewDepartmentCode", "@NewGroupCode", "@NewPosition", "@NewOrganization", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] mPositionID = new object[] { this.m_PositionID, this.m_EmployeeCode, this.m_OldSubsidiaryCode, this.m_OldBranchCode, this.m_OldDepartmentCode, this.m_OldGroupCode, this.m_OldPosition, this.m_OldOrganization, this.m_NewSubsidiaryCode, this.m_NewBranchCode, this.m_NewDepartmentCode, this.m_NewGroupCode, this.m_NewPosition, this.m_NewOrganization, this.m_Date, this.m_Reason, this.m_DecideNumber, this.m_Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_POSITION_Update", strArrays1, mPositionID);
        }

        public string Update(Guid PositionID, string EmployeeCode, string OldSubsidiaryCode, string OldBranchCode, string OldDepartmentCode, string OldGroupCode, string OldPosition, string OldOrganization, string NewSubsidiaryCode, string NewBranchCode, string NewDepartmentCode, string NewGroupCode, string NewPosition, string NewOrganization, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@PositionID", "@EmployeeCode", "@OldSubsidiaryCode", "@OldBranchCode", "@OldDepartmentCode", "@OldGroupCode", "@OldPosition", "@OldOrganization", "@NewSubsidiaryCode", "@NewBranchCode", "@NewDepartmentCode", "@NewGroupCode", "@NewPosition", "@NewOrganization", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] positionID = new object[] { PositionID, EmployeeCode, OldSubsidiaryCode, OldBranchCode, OldDepartmentCode, OldGroupCode, OldPosition, OldOrganization, NewSubsidiaryCode, NewBranchCode, NewDepartmentCode, NewGroupCode, NewPosition, NewOrganization, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PROCESS_POSITION_Update", strArrays1, positionID);
        }

        public string Update(SqlConnection myConnection, Guid PositionID, string EmployeeCode, string OldSubsidiaryCode, string OldBranchCode, string OldDepartmentCode, string OldGroupCode, string OldPosition, string OldOrganization, string NewSubsidiaryCode, string NewBranchCode, string NewDepartmentCode, string NewGroupCode, string NewPosition, string NewOrganization, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@PositionID", "@EmployeeCode", "@OldSubsidiaryCode", "@OldBranchCode", "@OldDepartmentCode", "@OldGroupCode", "@OldPosition", "@OldOrganization", "@NewSubsidiaryCode", "@NewBranchCode", "@NewDepartmentCode", "@NewGroupCode", "@NewPosition", "@NewOrganization", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] positionID = new object[] { PositionID, EmployeeCode, OldSubsidiaryCode, OldBranchCode, OldDepartmentCode, OldGroupCode, OldPosition, OldOrganization, NewSubsidiaryCode, NewBranchCode, NewDepartmentCode, NewGroupCode, NewPosition, NewOrganization, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PROCESS_POSITION_Update", strArrays1, positionID);
        }

        public string Update(SqlTransaction myTransaction, Guid PositionID, string EmployeeCode, string OldSubsidiaryCode, string OldBranchCode, string OldDepartmentCode, string OldGroupCode, string OldPosition, string OldOrganization, string NewSubsidiaryCode, string NewBranchCode, string NewDepartmentCode, string NewGroupCode, string NewPosition, string NewOrganization, DateTime Date, string Reason, string DecideNumber, string Person)
        {
            string[] strArrays = new string[] { "@PositionID", "@EmployeeCode", "@OldSubsidiaryCode", "@OldBranchCode", "@OldDepartmentCode", "@OldGroupCode", "@OldPosition", "@OldOrganization", "@NewSubsidiaryCode", "@NewBranchCode", "@NewDepartmentCode", "@NewGroupCode", "@NewPosition", "@NewOrganization", "@Date", "@Reason", "@DecideNumber", "@Person" };
            string[] strArrays1 = strArrays;
            object[] positionID = new object[] { PositionID, EmployeeCode, OldSubsidiaryCode, OldBranchCode, OldDepartmentCode, OldGroupCode, OldPosition, OldOrganization, NewSubsidiaryCode, NewBranchCode, NewDepartmentCode, NewGroupCode, NewPosition, NewOrganization, Date, Reason, DecideNumber, Person };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PROCESS_POSITION_Update", strArrays1, positionID);
        }

    }
}
