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
  public  class DIC_RELIGION
    {

        private string m_ReligionCode;

        private string m_ReligionName;

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
                return "Class DIC_RELIGION";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string ReligionCode
        {
            get
            {
                return this.m_ReligionCode;
            }
            set
            {
                this.m_ReligionCode = value;
            }
        }

        public string ReligionName
        {
            get
            {
                return this.m_ReligionName;
            }
            set
            {
                this.m_ReligionName = value;
            }
        }

        public DIC_RELIGION()
        {
            this.m_ReligionCode = "";
            this.m_ReligionName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_RELIGION(string ReligionCode, string ReligionName, string Description, bool Active)
        {
            this.m_ReligionCode = ReligionCode;
            this.m_ReligionName = ReligionName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "ReligionName", "ReligionCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["ReligionCode"] = "All";
        //    dataRow["ReligionName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "ReligionName", "ReligionCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["ReligionName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@ReligionCode" };
            object[] mReligionCode = new object[] { this.m_ReligionCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELIGION_Delete", strArrays, mReligionCode);
        }

        public string Delete(string ReligionCode)
        {
            string[] strArrays = new string[] { "@ReligionCode" };
            object[] religionCode = new object[] { ReligionCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELIGION_Delete", strArrays, religionCode);
        }

        public string Delete(SqlConnection myConnection, string ReligionCode)
        {
            string[] strArrays = new string[] { "@ReligionCode" };
            object[] religionCode = new object[] { ReligionCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_RELIGION_Delete", strArrays, religionCode);
        }

        public string Delete(SqlTransaction myTransaction, string ReligionCode)
        {
            string[] strArrays = new string[] { "@ReligionCode" };
            object[] religionCode = new object[] { ReligionCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RELIGION_Delete", strArrays, religionCode);
        }

        public bool Exist(string ReligionCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ReligionCode" };
            object[] religionCode = new object[] { ReligionCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_RELIGION_Get", strArrays, religionCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string ReligionCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ReligionCode" };
            object[] religionCode = new object[] { ReligionCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_RELIGION_Get", strArrays, religionCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ReligionCode = Convert.ToString(sqlDataReader["ReligionCode"]);
                    this.m_ReligionName = Convert.ToString(sqlDataReader["ReligionName"]);
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

        public string Get(SqlConnection myConnection, string ReligionCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ReligionCode" };
            object[] religionCode = new object[] { ReligionCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_RELIGION_Get", strArrays, religionCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ReligionCode = Convert.ToString(sqlDataReader["ReligionCode"]);
                    this.m_ReligionName = Convert.ToString(sqlDataReader["ReligionName"]);
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

        public string Get(SqlTransaction myTransaction, string ReligionCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ReligionCode" };
            object[] religionCode = new object[] { ReligionCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_RELIGION_Get", strArrays, religionCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ReligionCode = Convert.ToString(sqlDataReader["ReligionCode"]);
                    this.m_ReligionName = Convert.ToString(sqlDataReader["ReligionName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_RELIGION_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@ReligionCode", "@ReligionName", "@Description", "@Active" };
            object[] mReligionCode = new object[] { this.m_ReligionCode, this.m_ReligionName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELIGION_Insert", strArrays, mReligionCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@ReligionCode", "@ReligionName", "@Description", "@Active" };
            object[] mReligionCode = new object[] { this.m_ReligionCode, this.m_ReligionName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RELIGION_Insert", strArrays, mReligionCode);
        }

        public string Insert(string ReligionCode, string ReligionName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ReligionCode", "@ReligionName", "@Description", "@Active" };
            object[] religionCode = new object[] { ReligionCode, ReligionName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELIGION_Insert", strArrays, religionCode);
        }

        public string Insert(SqlConnection myConnection, string ReligionCode, string ReligionName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ReligionCode", "@ReligionName", "@Description", "@Active" };
            object[] religionCode = new object[] { ReligionCode, ReligionName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_RELIGION_Insert", strArrays, religionCode);
        }

        public string Insert(SqlTransaction myTransaction, string ReligionCode, string ReligionName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ReligionCode", "@ReligionName", "@Description", "@Active" };
            object[] religionCode = new object[] { ReligionCode, ReligionName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RELIGION_Insert", strArrays, religionCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_RELIGION", "ReligionCode", "TG");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@ReligionCode", "@ReligionName", "@Description", "@Active" };
            object[] mReligionCode = new object[] { this.m_ReligionCode, this.m_ReligionName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELIGION_Update", strArrays, mReligionCode);
        }

        public string Update(string ReligionCode, string ReligionName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ReligionCode", "@ReligionName", "@Description", "@Active" };
            object[] religionCode = new object[] { ReligionCode, ReligionName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELIGION_Update", strArrays, religionCode);
        }

        public string Update(SqlConnection myConnection, string ReligionCode, string ReligionName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ReligionCode", "@ReligionName", "@Description", "@Active" };
            object[] religionCode = new object[] { ReligionCode, ReligionName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_RELIGION_Update", strArrays, religionCode);
        }

        public string Update(SqlTransaction myTransaction, string ReligionCode, string ReligionName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ReligionCode", "@ReligionName", "@Description", "@Active" };
            object[] religionCode = new object[] { ReligionCode, ReligionName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RELIGION_Update", strArrays, religionCode);
        }
    }
}
