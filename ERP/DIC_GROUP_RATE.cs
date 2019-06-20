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
  public  class DIC_GROUP_RATE
    {
        private string m_GroupRateCode;

        private string m_GroupRateName;

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

        public string GroupRateCode
        {
            get
            {
                return this.m_GroupRateCode;
            }
            set
            {
                this.m_GroupRateCode = value;
            }
        }

        public string GroupRateName
        {
            get
            {
                return this.m_GroupRateName;
            }
            set
            {
                this.m_GroupRateName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_GROUP_RATE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_GROUP_RATE()
        {
            this.m_GroupRateCode = "";
            this.m_GroupRateName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_GROUP_RATE(string GroupRateCode, string GroupRateName, string Description, bool Active)
        {
            this.m_GroupRateCode = GroupRateCode;
            this.m_GroupRateName = GroupRateName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "GroupRateName", "GroupRateCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["GroupRateCode"] = "All";
        //    dataRow["GroupRateName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "GroupRateName", "GroupRateCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["GroupRateName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "GroupRateName";
            gridlookup.Properties.ValueMember = "GroupRateCode";
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@GroupRateCode" };
            object[] mGroupRateCode = new object[] { this.m_GroupRateCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_GROUP_RATE_Delete", strArrays, mGroupRateCode);
        }

        public string Delete(string GroupRateCode)
        {
            string[] strArrays = new string[] { "@GroupRateCode" };
            object[] groupRateCode = new object[] { GroupRateCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_GROUP_RATE_Delete", strArrays, groupRateCode);
        }

        public string Delete(SqlConnection myConnection, string GroupRateCode)
        {
            string[] strArrays = new string[] { "@GroupRateCode" };
            object[] groupRateCode = new object[] { GroupRateCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_GROUP_RATE_Delete", strArrays, groupRateCode);
        }

        public string Delete(SqlTransaction myTransaction, string GroupRateCode)
        {
            string[] strArrays = new string[] { "@GroupRateCode" };
            object[] groupRateCode = new object[] { GroupRateCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_GROUP_RATE_Delete", strArrays, groupRateCode);
        }

        public bool Exist(string GroupRateCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@GroupRateCode" };
            object[] groupRateCode = new object[] { GroupRateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_GROUP_RATE_Get", strArrays, groupRateCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string GroupRateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@GroupRateCode" };
            object[] groupRateCode = new object[] { GroupRateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_GROUP_RATE_Get", strArrays, groupRateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_GroupRateCode = Convert.ToString(sqlDataReader["GroupRateCode"]);
                    this.m_GroupRateName = Convert.ToString(sqlDataReader["GroupRateName"]);
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

        public string Get(SqlConnection myConnection, string GroupRateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@GroupRateCode" };
            object[] groupRateCode = new object[] { GroupRateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_GROUP_RATE_Get", strArrays, groupRateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_GroupRateCode = Convert.ToString(sqlDataReader["GroupRateCode"]);
                    this.m_GroupRateName = Convert.ToString(sqlDataReader["GroupRateName"]);
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

        public string Get(SqlTransaction myTransaction, string GroupRateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@GroupRateCode" };
            object[] groupRateCode = new object[] { GroupRateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_GROUP_RATE_Get", strArrays, groupRateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_GroupRateCode = Convert.ToString(sqlDataReader["GroupRateCode"]);
                    this.m_GroupRateName = Convert.ToString(sqlDataReader["GroupRateName"]);
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

        public DataTable GetList()
        {
            return (new SqlHelper()).ExecuteDataTable("DIC_GROUP_RATE_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@GroupRateCode", "@GroupRateName", "@Description", "@Active" };
            object[] mGroupRateCode = new object[] { this.m_GroupRateCode, this.m_GroupRateName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_GROUP_RATE_Insert", strArrays, mGroupRateCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@GroupRateCode", "@GroupRateName", "@Description", "@Active" };
            object[] mGroupRateCode = new object[] { this.m_GroupRateCode, this.m_GroupRateName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_GROUP_RATE_Insert", strArrays, mGroupRateCode);
        }

        public string Insert(string GroupRateCode, string GroupRateName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@GroupRateCode", "@GroupRateName", "@Description", "@Active" };
            object[] groupRateCode = new object[] { GroupRateCode, GroupRateName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_GROUP_RATE_Insert", strArrays, groupRateCode);
        }

        public string Insert(SqlConnection myConnection, string GroupRateCode, string GroupRateName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@GroupRateCode", "@GroupRateName", "@Description", "@Active" };
            object[] groupRateCode = new object[] { GroupRateCode, GroupRateName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_GROUP_RATE_Insert", strArrays, groupRateCode);
        }

        public string Insert(SqlTransaction myTransaction, string GroupRateCode, string GroupRateName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@GroupRateCode", "@GroupRateName", "@Description", "@Active" };
            object[] groupRateCode = new object[] { GroupRateCode, GroupRateName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_GROUP_RATE_Insert", strArrays, groupRateCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_GROUP_RATE", "GroupRateCode", "NDG");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@GroupRateCode", "@GroupRateName", "@Description", "@Active" };
            object[] mGroupRateCode = new object[] { this.m_GroupRateCode, this.m_GroupRateName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_GROUP_RATE_Update", strArrays, mGroupRateCode);
        }

        public string Update(string GroupRateCode, string GroupRateName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@GroupRateCode", "@GroupRateName", "@Description", "@Active" };
            object[] groupRateCode = new object[] { GroupRateCode, GroupRateName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_GROUP_RATE_Update", strArrays, groupRateCode);
        }

        public string Update(SqlConnection myConnection, string GroupRateCode, string GroupRateName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@GroupRateCode", "@GroupRateName", "@Description", "@Active" };
            object[] groupRateCode = new object[] { GroupRateCode, GroupRateName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_GROUP_RATE_Update", strArrays, groupRateCode);
        }

        public string Update(SqlTransaction myTransaction, string GroupRateCode, string GroupRateName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@GroupRateCode", "@GroupRateName", "@Description", "@Active" };
            object[] groupRateCode = new object[] { GroupRateCode, GroupRateName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_GROUP_RATE_Update", strArrays, groupRateCode);
        }

    }
}
