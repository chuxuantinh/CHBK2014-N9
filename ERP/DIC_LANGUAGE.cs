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
 public   class DIC_LANGUAGE
    {

        private string m_LanguageCode;

        private string m_LanguageName;

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

        public string LanguageCode
        {
            get
            {
                return this.m_LanguageCode;
            }
            set
            {
                this.m_LanguageCode = value;
            }
        }

        public string LanguageName
        {
            get
            {
                return this.m_LanguageName;
            }
            set
            {
                this.m_LanguageName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_LANGUAGE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_LANGUAGE()
        {
            this.m_LanguageCode = "";
            this.m_LanguageName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_LANGUAGE(string LanguageCode, string LanguageName, string Description, bool Active)
        {
            this.m_LanguageCode = LanguageCode;
            this.m_LanguageName = LanguageName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "LanguageName", "LanguageCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["LanguageCode"] = "All";
        //    dataRow["LanguageName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "LanguageName", "LanguageCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["LanguageName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@LanguageCode" };
            object[] mLanguageCode = new object[] { this.m_LanguageCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_LANGUAGE_Delete", strArrays, mLanguageCode);
        }

        public string Delete(string LanguageCode)
        {
            string[] strArrays = new string[] { "@LanguageCode" };
            object[] languageCode = new object[] { LanguageCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_LANGUAGE_Delete", strArrays, languageCode);
        }

        public string Delete(SqlConnection myConnection, string LanguageCode)
        {
            string[] strArrays = new string[] { "@LanguageCode" };
            object[] languageCode = new object[] { LanguageCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_LANGUAGE_Delete", strArrays, languageCode);
        }

        public string Delete(SqlTransaction myTransaction, string LanguageCode)
        {
            string[] strArrays = new string[] { "@LanguageCode" };
            object[] languageCode = new object[] { LanguageCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_LANGUAGE_Delete", strArrays, languageCode);
        }

        public bool Exist(string LanguageCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@LanguageCode" };
            object[] languageCode = new object[] { LanguageCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_LANGUAGE_Get", strArrays, languageCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string LanguageCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@LanguageCode" };
            object[] languageCode = new object[] { LanguageCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_LANGUAGE_Get", strArrays, languageCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_LanguageCode = Convert.ToString(sqlDataReader["LanguageCode"]);
                    this.m_LanguageName = Convert.ToString(sqlDataReader["LanguageName"]);
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

        public string Get(SqlConnection myConnection, string LanguageCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@LanguageCode" };
            object[] languageCode = new object[] { LanguageCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_LANGUAGE_Get", strArrays, languageCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_LanguageCode = Convert.ToString(sqlDataReader["LanguageCode"]);
                    this.m_LanguageName = Convert.ToString(sqlDataReader["LanguageName"]);
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

        public string Get(SqlTransaction myTransaction, string LanguageCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@LanguageCode" };
            object[] languageCode = new object[] { LanguageCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_LANGUAGE_Get", strArrays, languageCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_LanguageCode = Convert.ToString(sqlDataReader["LanguageCode"]);
                    this.m_LanguageName = Convert.ToString(sqlDataReader["LanguageName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_LANGUAGE_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@LanguageCode", "@LanguageName", "@Description", "@Active" };
            object[] mLanguageCode = new object[] { this.m_LanguageCode, this.m_LanguageName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_LANGUAGE_Insert", strArrays, mLanguageCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@LanguageCode", "@LanguageName", "@Description", "@Active" };
            object[] mLanguageCode = new object[] { this.m_LanguageCode, this.m_LanguageName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_LANGUAGE_Insert", strArrays, mLanguageCode);
        }

        public string Insert(string LanguageCode, string LanguageName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@LanguageCode", "@LanguageName", "@Description", "@Active" };
            object[] languageCode = new object[] { LanguageCode, LanguageName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_LANGUAGE_Insert", strArrays, languageCode);
        }

        public string Insert(SqlConnection myConnection, string LanguageCode, string LanguageName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@LanguageCode", "@LanguageName", "@Description", "@Active" };
            object[] languageCode = new object[] { LanguageCode, LanguageName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_LANGUAGE_Insert", strArrays, languageCode);
        }

        public string Insert(SqlTransaction myTransaction, string LanguageCode, string LanguageName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@LanguageCode", "@LanguageName", "@Description", "@Active" };
            object[] languageCode = new object[] { LanguageCode, LanguageName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_LANGUAGE_Insert", strArrays, languageCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_LANGUAGE", "LanguageCode", "NN");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@LanguageCode", "@LanguageName", "@Description", "@Active" };
            object[] mLanguageCode = new object[] { this.m_LanguageCode, this.m_LanguageName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_LANGUAGE_Update", strArrays, mLanguageCode);
        }

        public string Update(string LanguageCode, string LanguageName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@LanguageCode", "@LanguageName", "@Description", "@Active" };
            object[] languageCode = new object[] { LanguageCode, LanguageName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_LANGUAGE_Update", strArrays, languageCode);
        }

        public string Update(SqlConnection myConnection, string LanguageCode, string LanguageName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@LanguageCode", "@LanguageName", "@Description", "@Active" };
            object[] languageCode = new object[] { LanguageCode, LanguageName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_LANGUAGE_Update", strArrays, languageCode);
        }

        public string Update(SqlTransaction myTransaction, string LanguageCode, string LanguageName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@LanguageCode", "@LanguageName", "@Description", "@Active" };
            object[] languageCode = new object[] { LanguageCode, LanguageName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_LANGUAGE_Update", strArrays, languageCode);
        }

    }
}
