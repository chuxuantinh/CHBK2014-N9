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
 public   class DIC_NATIONALITY
    {

        private string m_NationalityCode;

        private string m_NationalityName;

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

        public string NationalityCode
        {
            get
            {
                return this.m_NationalityCode;
            }
            set
            {
                this.m_NationalityCode = value;
            }
        }

        public string NationalityName
        {
            get
            {
                return this.m_NationalityName;
            }
            set
            {
                this.m_NationalityName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_NATIONALITY";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_NATIONALITY()
        {
            this.m_NationalityCode = "";
            this.m_NationalityName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_NATIONALITY(string NationalityCode, string NationalityName, string Description, bool Active)
        {
            this.m_NationalityCode = NationalityCode;
            this.m_NationalityName = NationalityName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "NationalityName", "NationalityCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["NationalityCode"] = "All";
        //    dataRow["NationalityName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "NationalityName", "NationalityCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["NationalityName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@NationalityCode" };
            object[] mNationalityCode = new object[] { this.m_NationalityCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_NATIONALITY_Delete", strArrays, mNationalityCode);
        }

        public string Delete(string NationalityCode)
        {
            string[] strArrays = new string[] { "@NationalityCode" };
            object[] nationalityCode = new object[] { NationalityCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_NATIONALITY_Delete", strArrays, nationalityCode);
        }

        public string Delete(SqlConnection myConnection, string NationalityCode)
        {
            string[] strArrays = new string[] { "@NationalityCode" };
            object[] nationalityCode = new object[] { NationalityCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_NATIONALITY_Delete", strArrays, nationalityCode);
        }

        public string Delete(SqlTransaction myTransaction, string NationalityCode)
        {
            string[] strArrays = new string[] { "@NationalityCode" };
            object[] nationalityCode = new object[] { NationalityCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_NATIONALITY_Delete", strArrays, nationalityCode);
        }

        public bool Exist(string NationalityCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@NationalityCode" };
            object[] nationalityCode = new object[] { NationalityCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_NATIONALITY_Get", strArrays, nationalityCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string NationalityCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@NationalityCode" };
            object[] nationalityCode = new object[] { NationalityCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_NATIONALITY_Get", strArrays, nationalityCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_NationalityCode = Convert.ToString(sqlDataReader["NationalityCode"]);
                    this.m_NationalityName = Convert.ToString(sqlDataReader["NationalityName"]);
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

        public string Get(SqlConnection myConnection, string NationalityCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@NationalityCode" };
            object[] nationalityCode = new object[] { NationalityCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_NATIONALITY_Get", strArrays, nationalityCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_NationalityCode = Convert.ToString(sqlDataReader["NationalityCode"]);
                    this.m_NationalityName = Convert.ToString(sqlDataReader["NationalityName"]);
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

        public string Get(SqlTransaction myTransaction, string NationalityCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@NationalityCode" };
            object[] nationalityCode = new object[] { NationalityCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_NATIONALITY_Get", strArrays, nationalityCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_NationalityCode = Convert.ToString(sqlDataReader["NationalityCode"]);
                    this.m_NationalityName = Convert.ToString(sqlDataReader["NationalityName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_NATIONALITY_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@NationalityCode", "@NationalityName", "@Description", "@Active" };
            object[] mNationalityCode = new object[] { this.m_NationalityCode, this.m_NationalityName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_NATIONALITY_Insert", strArrays, mNationalityCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@NationalityCode", "@NationalityName", "@Description", "@Active" };
            object[] mNationalityCode = new object[] { this.m_NationalityCode, this.m_NationalityName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_NATIONALITY_Insert", strArrays, mNationalityCode);
        }

        public string Insert(string NationalityCode, string NationalityName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@NationalityCode", "@NationalityName", "@Description", "@Active" };
            object[] nationalityCode = new object[] { NationalityCode, NationalityName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_NATIONALITY_Insert", strArrays, nationalityCode);
        }

        public string Insert(SqlConnection myConnection, string NationalityCode, string NationalityName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@NationalityCode", "@NationalityName", "@Description", "@Active" };
            object[] nationalityCode = new object[] { NationalityCode, NationalityName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_NATIONALITY_Insert", strArrays, nationalityCode);
        }

        public string Insert(SqlTransaction myTransaction, string NationalityCode, string NationalityName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@NationalityCode", "@NationalityName", "@Description", "@Active" };
            object[] nationalityCode = new object[] { NationalityCode, NationalityName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_NATIONALITY_Insert", strArrays, nationalityCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_NATIONALITY", "NationalityCode", "QT");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@NationalityCode", "@NationalityName", "@Description", "@Active" };
            object[] mNationalityCode = new object[] { this.m_NationalityCode, this.m_NationalityName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_NATIONALITY_Update", strArrays, mNationalityCode);
        }

        public string Update(string NationalityCode, string NationalityName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@NationalityCode", "@NationalityName", "@Description", "@Active" };
            object[] nationalityCode = new object[] { NationalityCode, NationalityName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_NATIONALITY_Update", strArrays, nationalityCode);
        }

        public string Update(SqlConnection myConnection, string NationalityCode, string NationalityName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@NationalityCode", "@NationalityName", "@Description", "@Active" };
            object[] nationalityCode = new object[] { NationalityCode, NationalityName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_NATIONALITY_Update", strArrays, nationalityCode);
        }

        public string Update(SqlTransaction myTransaction, string NationalityCode, string NationalityName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@NationalityCode", "@NationalityName", "@Description", "@Active" };
            object[] nationalityCode = new object[] { NationalityCode, NationalityName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_NATIONALITY_Update", strArrays, nationalityCode);
        }

    }
}
