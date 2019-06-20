using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Data.Helper;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ERP
{
   public class SYS_USER
    {
        private string m_UserID;

        private string m_UserName;

        private string m_Password;

        private string m_Group_ID;

        private string m_Email;

        private string m_Description;

        private string m_PartID;

        private int m_Management;

        private string m_SubsidiaryCode;

        private string m_BranchCode;

        private string m_DepartmentCode;

        private string m_GroupCode;

        private string m_EmployeeCode;

        private bool m_Active;

        public bool Active
        {
            get
            {
                return this.m_Active;
            }
            set
            {
                this.m_Active = value;
            }
        }

        public string BranchCode
        {
            get
            {
                return this.m_BranchCode;
            }
            set
            {
                this.m_BranchCode = value;
            }
        }

        public string DepartmentCode
        {
            get
            {
                return this.m_DepartmentCode;
            }
            set
            {
                this.m_DepartmentCode = value;
            }
        }

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

        public string Email
        {
            get
            {
                return this.m_Email;
            }
            set
            {
                this.m_Email = value;
            }
        }

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

        public string Group_ID
        {
            get
            {
                return this.m_Group_ID;
            }
            set
            {
                this.m_Group_ID = value;
            }
        }

        public string GroupCode
        {
            get
            {
                return this.m_GroupCode;
            }
            set
            {
                this.m_GroupCode = value;
            }
        }

        public int Management
        {
            get
            {
                return this.m_Management;
            }
            set
            {
                this.m_Management = value;
            }
        }

        public string PartID
        {
            get
            {
                return this.m_PartID;
            }
            set
            {
                this.m_PartID = value;
            }
        }

        public string Password
        {
            get
            {
                return this.m_Password;
            }
            set
            {
                this.m_Password = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class SYS_USER";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string SubsidiaryCode
        {
            get
            {
                return this.m_SubsidiaryCode;
            }
            set
            {
                this.m_SubsidiaryCode = value;
            }
        }

        public string UserID
        {
            get
            {
                return this.m_UserID;
            }
            set
            {
                this.m_UserID = value;
            }
        }

        public string UserName
        {
            get
            {
                return this.m_UserName;
            }
            set
            {
                this.m_UserName = value;
            }
        }

        public SYS_USER()
        {
            this.m_UserID = "";
            this.m_UserName = "";
            this.m_Password = "";
            this.m_Group_ID = "";
            this.m_Email = "";
            this.m_Description = "";
            this.m_PartID = "";
            this.m_Management = 0;
            this.m_SubsidiaryCode = "";
            this.m_BranchCode = "";
            this.m_DepartmentCode = "";
            this.m_GroupCode = "";
            this.m_EmployeeCode = "";
            this.m_Active = true;
        }

        public SYS_USER(string UserID, string UserName, string Password, string Group_ID, string Email, string Description, string PartID, int Management, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string EmployeeCode, bool Active)
        {
            string str = MyLogin.CreatePassword(UserName, Password);
            this.m_UserID = UserID;
            this.m_UserName = UserName;
            this.m_Password = str;
            this.m_Group_ID = Group_ID;
            this.m_Email = Email;
            this.m_Description = Description;
            this.m_PartID = PartID;
            this.m_Management = Management;
            this.m_SubsidiaryCode = SubsidiaryCode;
            this.m_BranchCode = BranchCode;
            this.m_DepartmentCode = DepartmentCode;
            this.m_GroupCode = GroupCode;
            this.m_EmployeeCode = EmployeeCode;
            this.m_Active = Active;
        }

        public void AddEmployeeGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetListEmployee(0, "");
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "EmployeeCode";
            gridlookup.Properties.ValueMember = "EmployeeCode";
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@UserID" };
            object[] mUserID = new object[] { this.m_UserID };
            return (new SqlHelper()).ExecuteNonQuery("SYS_USER_Delete", strArrays, mUserID);
        }

        public string Delete(string UserID)
        {
            string[] strArrays = new string[] { "@UserID" };
            object[] userID = new object[] { UserID };
            return (new SqlHelper()).ExecuteNonQuery("SYS_USER_Delete", strArrays, userID);
        }

        public string Delete(SqlConnection myConnection, string UserID)
        {
            string[] strArrays = new string[] { "@UserID" };
            object[] userID = new object[] { UserID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "SYS_USER_Delete", strArrays, userID);
        }

        public string Delete(SqlTransaction myTransaction, string UserID)
        {
            string[] strArrays = new string[] { "@UserID" };
            object[] userID = new object[] { UserID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_USER_Delete", strArrays, userID);
        }

        public bool Exist(string UserID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@UserID" };
            object[] userID = new object[] { UserID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_USER_Get", strArrays, userID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool ExistEmployeeCode(string EmployeeCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_USER_Get_By_EmployeeCode", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool ExistEmployeeCode(string EmployeeCode, string UserName)
        {
            bool hasRows = false;
            this.Get_UserName(UserName);
            string mEmployeeCode = this.m_EmployeeCode;
            string[] strArrays = new string[] { "@NewEmployeeCode", "@OldEmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode, mEmployeeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("Select * From [SYS_USER]\r\n Where \r\n   [SYS_USER].EmployeeCode  = @NewEmployeeCode\r\nand [SYS_USER].EmployeeCode  <> @OldEmployeeCode", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string UserID)
        {
            string str = "";
            string[] strArrays = new string[] { "@UserID" };
            object[] userID = new object[] { UserID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_USER_Get", strArrays, userID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_UserID = Convert.ToString(sqlDataReader["UserID"]);
                    this.m_UserName = Convert.ToString(sqlDataReader["UserName"]);
                    this.m_Password = Convert.ToString(sqlDataReader["Password"]);
                    this.m_Group_ID = Convert.ToString(sqlDataReader["Group_ID"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    this.m_PartID = Convert.ToString(sqlDataReader["PartID"]);
                    this.m_Management = Convert.ToInt32(sqlDataReader["Management"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string UserID)
        {
            string str = "";
            string[] strArrays = new string[] { "@UserID" };
            object[] userID = new object[] { UserID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "SYS_USER_Get", strArrays, userID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_UserID = Convert.ToString(sqlDataReader["UserID"]);
                    this.m_UserName = Convert.ToString(sqlDataReader["UserName"]);
                    this.m_Password = Convert.ToString(sqlDataReader["Password"]);
                    this.m_Group_ID = Convert.ToString(sqlDataReader["Group_ID"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    this.m_PartID = Convert.ToString(sqlDataReader["PartID"]);
                    this.m_Management = Convert.ToInt32(sqlDataReader["Management"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string UserID)
        {
            string str = "";
            string[] strArrays = new string[] { "@UserID" };
            object[] userID = new object[] { UserID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "SYS_USER_Get", strArrays, userID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_UserID = Convert.ToString(sqlDataReader["UserID"]);
                    this.m_UserName = Convert.ToString(sqlDataReader["UserName"]);
                    this.m_Password = Convert.ToString(sqlDataReader["Password"]);
                    this.m_Group_ID = Convert.ToString(sqlDataReader["Group_ID"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    this.m_PartID = Convert.ToString(sqlDataReader["PartID"]);
                    this.m_Management = Convert.ToInt32(sqlDataReader["Management"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get_UserName(string UserID)
        {
            string str = "";
            string[] strArrays = new string[] { "@UserName" };
            object[] userID = new object[] { UserID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_USER_Get_By_UserName", strArrays, userID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_UserID = Convert.ToString(sqlDataReader["UserID"]);
                    this.m_UserName = Convert.ToString(sqlDataReader["UserName"]);
                    this.m_Password = Convert.ToString(sqlDataReader["Password"]);
                    this.m_Group_ID = Convert.ToString(sqlDataReader["Group_ID"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    this.m_PartID = Convert.ToString(sqlDataReader["PartID"]);
                    this.m_Management = Convert.ToInt32(sqlDataReader["Management"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetEmployee(string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_Get", strArrays, employeeCode);
        }

        public string GetEmployeeCode(string EmployeeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_USER_Get_By_EmployeeCode", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_UserID = Convert.ToString(sqlDataReader["UserID"]);
                    this.m_UserName = Convert.ToString(sqlDataReader["UserName"]);
                    this.m_Password = Convert.ToString(sqlDataReader["Password"]);
                    this.m_Group_ID = Convert.ToString(sqlDataReader["Group_ID"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    this.m_PartID = Convert.ToString(sqlDataReader["PartID"]);
                    this.m_Management = Convert.ToInt32(sqlDataReader["Management"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
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
            return (new SqlHelper()).ExecuteDataTable("SYS_USER_GetList");
        }

        public DataTable GetList(string Group_ID)
        {
            string[] strArrays = new string[] { "@Group_ID" };
            object[] groupID = new object[] { Group_ID };
            return (new SqlHelper()).ExecuteDataTable("SYS_USER_GetList_By_Group", strArrays, groupID);
        }

        public DataTable GetListEmployee(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetAllList", strArrays, level);
        }

        public string GetUserName(string UserName)
        {
            string str = "";
            string[] strArrays = new string[] { "@UserName" };
            object[] userName = new object[] { UserName };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_USER_GetUserName", strArrays, userName);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_UserID = Convert.ToString(sqlDataReader["UserID"]);
                    this.m_UserName = Convert.ToString(sqlDataReader["UserName"]);
                    this.m_Password = Convert.ToString(sqlDataReader["Password"]);
                    this.m_Group_ID = Convert.ToString(sqlDataReader["Group_ID"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    this.m_PartID = Convert.ToString(sqlDataReader["PartID"]);
                    this.m_Management = Convert.ToInt32(sqlDataReader["Management"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@UserID", "@UserName", "@Password", "@Group_ID", "@Email", "@Description", "@PartID", "@Management", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@EmployeeCode", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mUserID = new object[] { this.m_UserID, this.m_UserName, this.m_Password, this.m_Group_ID, this.m_Email, this.m_Description, this.m_PartID, this.m_Management, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentCode, this.m_GroupCode, this.m_EmployeeCode, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_USER_Insert", strArrays1, mUserID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@UserID", "@UserName", "@Password", "@Group_ID", "@Email", "@Description", "@PartID", "@Management", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@EmployeeCode", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mUserID = new object[] { this.m_UserID, this.m_UserName, this.m_Password, this.m_Group_ID, this.m_Email, this.m_Description, this.m_PartID, this.m_Management, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentCode, this.m_GroupCode, this.m_EmployeeCode, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_USER_Insert", strArrays1, mUserID);
        }

        public string Insert(string UserID, string UserName, string Password, string Group_ID, string Email, string Description, string PartID, int Management, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string EmployeeCode, bool Active)
        {
            string[] strArrays = new string[] { "@UserID", "@UserName", "@Password", "@Group_ID", "@Email", "@Description", "@PartID", "@Management", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@EmployeeCode", "@Active" };
            string[] strArrays1 = strArrays;
            object[] userID = new object[] { UserID, UserName, Password, Group_ID, Email, Description, PartID, Management, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, EmployeeCode, Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_USER_Insert", strArrays1, userID);
        }

        public string Insert(SqlConnection myConnection, string UserID, string UserName, string Password, string Group_ID, string Email, string Description, string PartID, int Management, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string EmployeeCode, bool Active)
        {
            string[] strArrays = new string[] { "@UserID", "@UserName", "@Password", "@Group_ID", "@Email", "@Description", "@PartID", "@Management", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@EmployeeCode", "@Active" };
            string[] strArrays1 = strArrays;
            object[] userID = new object[] { UserID, UserName, Password, Group_ID, Email, Description, PartID, Management, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, EmployeeCode, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "SYS_USER_Insert", strArrays1, userID);
        }

        public string Insert(SqlTransaction myTransaction, string UserID, string UserName, string Password, string Group_ID, string Email, string Description, string PartID, int Management, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string EmployeeCode, bool Active)
        {
            string[] strArrays = new string[] { "@UserID", "@UserName", "@Password", "@Group_ID", "@Email", "@Description", "@PartID", "@Management", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@EmployeeCode", "@Active" };
            string[] strArrays1 = strArrays;
            object[] userID = new object[] { UserID, UserName, Password, Group_ID, Email, Description, PartID, Management, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, EmployeeCode, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_USER_Insert", strArrays1, userID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("SYS_USER", "UserID", "US");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@UserID", "@UserName", "@Password", "@Group_ID", "@Email", "@Description", "@PartID", "@Management", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@EmployeeCode", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mUserID = new object[] { this.m_UserID, this.m_UserName, this.m_Password, this.m_Group_ID, this.m_Email, this.m_Description, this.m_PartID, this.m_Management, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentCode, this.m_GroupCode, this.m_EmployeeCode, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_USER_Update", strArrays1, mUserID);
        }

        public string Update(string UserID, string UserName, string Password, string Group_ID, string Email, string Description, string PartID, int Management, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string EmployeeCode, bool Active)
        {
            MyLogin.CreatePassword(UserName, Password);
            string[] strArrays = new string[] { "@UserID", "@UserName", "@Password", "@Group_ID", "@Email", "@Description", "@PartID", "@Management", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@EmployeeCode", "@Active" };
            string[] strArrays1 = strArrays;
            object[] userID = new object[] { UserID, UserName, Password, Group_ID, Email, Description, PartID, Management, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, EmployeeCode, Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_USER_Update", strArrays1, userID);
        }

        public string Update(SqlConnection myConnection, string UserID, string UserName, string Password, string Group_ID, string Email, string Description, string PartID, int Management, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string EmployeeCode, bool Active)
        {
            string[] strArrays = new string[] { "@UserID", "@UserName", "@Password", "@Group_ID", "@Email", "@Description", "@PartID", "@Management", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@EmployeeCode", "@Active" };
            string[] strArrays1 = strArrays;
            object[] userID = new object[] { UserID, UserName, Password, Group_ID, Email, Description, PartID, Management, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, EmployeeCode, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "SYS_USER_Update", strArrays1, userID);
        }

        public string Update(SqlTransaction myTransaction, string UserID, string UserName, string Password, string Group_ID, string Email, string Description, string PartID, int Management, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string EmployeeCode, bool Active)
        {
            string[] strArrays = new string[] { "@UserID", "@UserName", "@Password", "@Group_ID", "@Email", "@Description", "@PartID", "@Management", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@EmployeeCode", "@Active" };
            string[] strArrays1 = strArrays;
            object[] userID = new object[] { UserID, UserName, Password, Group_ID, Email, Description, PartID, Management, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, EmployeeCode, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_USER_Update", strArrays1, userID);
        }

        public string UpdateNopass()
        {
            string[] strArrays = new string[] { "@UserID", "@UserName", "@Group_ID", "@Email", "@Description", "@PartID", "@Management", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@EmployeeCode", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mUserID = new object[] { this.m_UserID, this.m_UserName, this.m_Group_ID, this.m_Email, this.m_Description, this.m_PartID, this.m_Management, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentCode, this.m_GroupCode, this.m_EmployeeCode, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_USER_UpdateNoPass", strArrays1, mUserID);
        }
    }
}
