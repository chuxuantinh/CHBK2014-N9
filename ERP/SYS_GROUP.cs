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
   public class SYS_GROUP
    {
        private string m_Group_ID;

        private string m_Group_Name;

        private string m_Group_NameEn;

        private string m_Description;

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

        public string Group_Name
        {
            get
            {
                return this.m_Group_Name;
            }
            set
            {
                this.m_Group_Name = value;
            }
        }

        public string Group_NameEn
        {
            get
            {
                return this.m_Group_NameEn;
            }
            set
            {
                this.m_Group_NameEn = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class SYS_GROUP";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public SYS_GROUP()
        {
            this.m_Group_ID = "";
            this.m_Group_Name = "";
            this.m_Group_NameEn = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public SYS_GROUP(string Group_ID, string Group_Name, string Group_NameEn, string Description, bool Active)
        {
            this.m_Group_ID = Group_ID;
            this.m_Group_Name = Group_Name;
            this.m_Group_NameEn = Group_NameEn;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo( System.Windows.Forms.  ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "SYS_GROUPName", "SYS_GROUPID");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["SYS_GROUPID"] = "All";
        //    dataRow["SYS_GROUPName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "SYS_GROUPName", "SYS_GROUPID");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["Group_Name"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit glkEdit)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            glkEdit.Properties.DataSource = dataTable;
            glkEdit.Properties.DisplayMember = "Group_Name";
            glkEdit.Properties.ValueMember = "Group_ID";
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@Group_ID" };
            object[] mGroupID = new object[] { this.m_Group_ID };
            return (new SqlHelper()).ExecuteNonQuery("SYS_GROUP_Delete", strArrays, mGroupID);
        }

        public string Delete(string Group_ID)
        {
            string[] strArrays = new string[] { "@Group_ID" };
            object[] groupID = new object[] { Group_ID };
            return (new SqlHelper()).ExecuteNonQuery("SYS_GROUP_Delete", strArrays, groupID);
        }

        public string Delete(SqlConnection myConnection, string Group_ID)
        {
            string[] strArrays = new string[] { "@Group_ID" };
            object[] groupID = new object[] { Group_ID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "SYS_GROUP_Delete", strArrays, groupID);
        }

        public string Delete(SqlTransaction myTransaction, string Group_ID)
        {
            string[] strArrays = new string[] { "@Group_ID" };
            object[] groupID = new object[] { Group_ID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_GROUP_Delete", strArrays, groupID);
        }

        public bool Exist(string Group_ID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@Group_ID" };
            object[] groupID = new object[] { Group_ID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_GROUP_Get", strArrays, groupID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string Group_ID)
        {
            string str = "";
            string[] strArrays = new string[] { "@Group_ID" };
            object[] groupID = new object[] { Group_ID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_GROUP_Get", strArrays, groupID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_Group_ID = Convert.ToString(sqlDataReader["Group_ID"]);
                    this.m_Group_Name = Convert.ToString(sqlDataReader["Group_Name"]);
                    this.m_Group_NameEn = Convert.ToString(sqlDataReader["Group_NameEn"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    this.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string Group_ID)
        {
            string str = "";
            string[] strArrays = new string[] { "@Group_ID" };
            object[] groupID = new object[] { Group_ID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "SYS_GROUP_Get", strArrays, groupID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_Group_ID = Convert.ToString(sqlDataReader["Group_ID"]);
                    this.m_Group_Name = Convert.ToString(sqlDataReader["Group_Name"]);
                    this.m_Group_NameEn = Convert.ToString(sqlDataReader["Group_NameEn"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    this.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string Group_ID)
        {
            string str = "";
            string[] strArrays = new string[] { "@Group_ID" };
            object[] groupID = new object[] { Group_ID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "SYS_GROUP_Get", strArrays, groupID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_Group_ID = Convert.ToString(sqlDataReader["Group_ID"]);
                    this.m_Group_Name = Convert.ToString(sqlDataReader["Group_Name"]);
                    this.m_Group_NameEn = Convert.ToString(sqlDataReader["Group_NameEn"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    this.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable Get_List(string Group_ID)
        {
            string[] strArrays = new string[] { "@Group_ID" };
            object[] groupID = new object[] { Group_ID };
            return (new SqlHelper()).ExecuteDataTable("SYS_GROUP_Get", strArrays, groupID);
        }

        public DataTable GetList()
        {
            return (new SqlHelper()).ExecuteDataTable("SYS_GROUP_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@Group_ID", "@Group_Name", "@Group_NameEn", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mGroupID = new object[] { this.m_Group_ID, this.m_Group_Name, this.m_Group_NameEn, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_GROUP_Insert", strArrays1, mGroupID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@Group_ID", "@Group_Name", "@Group_NameEn", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mGroupID = new object[] { this.m_Group_ID, this.m_Group_Name, this.m_Group_NameEn, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_GROUP_Insert", strArrays1, mGroupID);
        }

        public string Insert(string Group_ID, string Group_Name, string Group_NameEn, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@Group_ID", "@Group_Name", "@Group_NameEn", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] groupID = new object[] { Group_ID, Group_Name, Group_NameEn, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_GROUP_Insert", strArrays1, groupID);
        }

        public string Insert(SqlConnection myConnection, string Group_ID, string Group_Name, string Group_NameEn, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@Group_ID", "@Group_Name", "@Group_NameEn", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] groupID = new object[] { Group_ID, Group_Name, Group_NameEn, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "SYS_GROUP_Insert", strArrays1, groupID);
        }

        public string Insert(SqlTransaction myTransaction, string Group_ID, string Group_Name, string Group_NameEn, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@Group_ID", "@Group_Name", "@Group_NameEn", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] groupID = new object[] { Group_ID, Group_Name, Group_NameEn, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_GROUP_Insert", strArrays1, groupID);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("SYS_GROUP", "Group_ID", "VT");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@Group_ID", "@Group_Name", "@Group_NameEn", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mGroupID = new object[] { this.m_Group_ID, this.m_Group_Name, this.m_Group_NameEn, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_GROUP_Update", strArrays1, mGroupID);
        }

        public string Update(string Group_ID, string Group_Name, string Group_NameEn, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@Group_ID", "@Group_Name", "@Group_NameEn", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] groupID = new object[] { Group_ID, Group_Name, Group_NameEn, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_GROUP_Update", strArrays1, groupID);
        }

        public string Update(SqlConnection myConnection, string Group_ID, string Group_Name, string Group_NameEn, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@Group_ID", "@Group_Name", "@Group_NameEn", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] groupID = new object[] { Group_ID, Group_Name, Group_NameEn, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "SYS_GROUP_Update", strArrays1, groupID);
        }

        public string Update(SqlTransaction myTransaction, string Group_ID, string Group_Name, string Group_NameEn, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@Group_ID", "@Group_Name", "@Group_NameEn", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] groupID = new object[] { Group_ID, Group_Name, Group_NameEn, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_GROUP_Update", strArrays1, groupID);
        }

    }
}
