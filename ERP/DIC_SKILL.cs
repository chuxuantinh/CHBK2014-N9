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
 public   class DIC_SKILL
    {


        private string m_SkillCode;

        private string m_SkillName;

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

        public string ProductName
        {
            get
            {
                return "Class DIC_SKILL";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string SkillCode
        {
            get
            {
                return this.m_SkillCode;
            }
            set
            {
                this.m_SkillCode = value;
            }
        }

        public string SkillName
        {
            get
            {
                return this.m_SkillName;
            }
            set
            {
                this.m_SkillName = value;
            }
        }

        public DIC_SKILL()
        {
            this.m_SkillCode = "";
            this.m_SkillName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_SKILL(string SkillCode, string SkillName, string Description, bool Active)
        {
            this.m_SkillCode = SkillCode;
            this.m_SkillName = SkillName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        public void AddCheckedComboEdit(CheckedComboBoxEdit checkedCombo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                CheckedListBoxItem checkedListBoxItem = new CheckedListBoxItem()
                {
                    Description = row["SkillName"].ToString(),
                    CheckState = CheckState.Unchecked,
                    Value = row["SkillCode"].ToString()
                };
                checkedCombo.Properties.Items.Add(checkedListBoxItem);
            }
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "SkillName", "SkillCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["SkillCode"] = "All";
        //    dataRow["SkillName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "SkillName", "SkillCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["SkillName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SkillCode" };
            object[] mSkillCode = new object[] { this.m_SkillCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SKILL_Delete", strArrays, mSkillCode);
        }

        public string Delete(string SkillCode)
        {
            string[] strArrays = new string[] { "@SkillCode" };
            object[] skillCode = new object[] { SkillCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SKILL_Delete", strArrays, skillCode);
        }

        public string Delete(SqlConnection myConnection, string SkillCode)
        {
            string[] strArrays = new string[] { "@SkillCode" };
            object[] skillCode = new object[] { SkillCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SKILL_Delete", strArrays, skillCode);
        }

        public string Delete(SqlTransaction myTransaction, string SkillCode)
        {
            string[] strArrays = new string[] { "@SkillCode" };
            object[] skillCode = new object[] { SkillCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SKILL_Delete", strArrays, skillCode);
        }

        public bool Exist(string SkillCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SkillCode" };
            object[] skillCode = new object[] { SkillCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SKILL_Get", strArrays, skillCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string SkillCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SkillCode" };
            object[] skillCode = new object[] { SkillCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SKILL_Get", strArrays, skillCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SkillCode = Convert.ToString(sqlDataReader["SkillCode"]);
                    this.m_SkillName = Convert.ToString(sqlDataReader["SkillName"]);
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

        public string Get(SqlConnection myConnection, string SkillCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SkillCode" };
            object[] skillCode = new object[] { SkillCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_SKILL_Get", strArrays, skillCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SkillCode = Convert.ToString(sqlDataReader["SkillCode"]);
                    this.m_SkillName = Convert.ToString(sqlDataReader["SkillName"]);
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

        public string Get(SqlTransaction myTransaction, string SkillCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SkillCode" };
            object[] skillCode = new object[] { SkillCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_SKILL_Get", strArrays, skillCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SkillCode = Convert.ToString(sqlDataReader["SkillCode"]);
                    this.m_SkillName = Convert.ToString(sqlDataReader["SkillName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_SKILL_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SkillCode", "@SkillName", "@Description", "@Active" };
            object[] mSkillCode = new object[] { this.m_SkillCode, this.m_SkillName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SKILL_Insert", strArrays, mSkillCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SkillCode", "@SkillName", "@Description", "@Active" };
            object[] mSkillCode = new object[] { this.m_SkillCode, this.m_SkillName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SKILL_Insert", strArrays, mSkillCode);
        }

        public string Insert(string SkillCode, string SkillName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SkillCode", "@SkillName", "@Description", "@Active" };
            object[] skillCode = new object[] { SkillCode, SkillName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SKILL_Insert", strArrays, skillCode);
        }

        public string Insert(SqlConnection myConnection, string SkillCode, string SkillName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SkillCode", "@SkillName", "@Description", "@Active" };
            object[] skillCode = new object[] { SkillCode, SkillName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SKILL_Insert", strArrays, skillCode);
        }

        public string Insert(SqlTransaction myTransaction, string SkillCode, string SkillName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SkillCode", "@SkillName", "@Description", "@Active" };
            object[] skillCode = new object[] { SkillCode, SkillName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SKILL_Insert", strArrays, skillCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_SKILL", "SkillCode", "KN");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SkillCode", "@SkillName", "@Description", "@Active" };
            object[] mSkillCode = new object[] { this.m_SkillCode, this.m_SkillName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SKILL_Update", strArrays, mSkillCode);
        }

        public string Update(string SkillCode, string SkillName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SkillCode", "@SkillName", "@Description", "@Active" };
            object[] skillCode = new object[] { SkillCode, SkillName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SKILL_Update", strArrays, skillCode);
        }

        public string Update(SqlConnection myConnection, string SkillCode, string SkillName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SkillCode", "@SkillName", "@Description", "@Active" };
            object[] skillCode = new object[] { SkillCode, SkillName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SKILL_Update", strArrays, skillCode);
        }

        public string Update(SqlTransaction myTransaction, string SkillCode, string SkillName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SkillCode", "@SkillName", "@Description", "@Active" };
            object[] skillCode = new object[] { SkillCode, SkillName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SKILL_Update", strArrays, skillCode);
        }
    }
}
