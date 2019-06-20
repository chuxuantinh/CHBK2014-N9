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
   public  class DIC_ETHNIC
    {


        private string m_EthnicCode;

        private string m_EthnicName;

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

        public string EthnicCode
        {
            get
            {
                return this.m_EthnicCode;
            }
            set
            {
                this.m_EthnicCode = value;
            }
        }

        public string EthnicName
        {
            get
            {
                return this.m_EthnicName;
            }
            set
            {
                this.m_EthnicName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_ETHNIC";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_ETHNIC()
        {
            this.m_EthnicCode = "";
            this.m_EthnicName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_ETHNIC(string EthnicCode, string EthnicName, string Description, bool Active)
        {
            this.m_EthnicCode = EthnicCode;
            this.m_EthnicName = EthnicName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "EthnicName", "EthnicCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["EthnicCode"] = "All";
        //    dataRow["EthnicName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "EthnicName", "EthnicCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["EthnicName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@EthnicCode" };
            object[] mEthnicCode = new object[] { this.m_EthnicCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ETHNIC_Delete", strArrays, mEthnicCode);
        }

        public string Delete(string EthnicCode)
        {
            string[] strArrays = new string[] { "@EthnicCode" };
            object[] ethnicCode = new object[] { EthnicCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ETHNIC_Delete", strArrays, ethnicCode);
        }

        public string Delete(SqlConnection myConnection, string EthnicCode)
        {
            string[] strArrays = new string[] { "@EthnicCode" };
            object[] ethnicCode = new object[] { EthnicCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_ETHNIC_Delete", strArrays, ethnicCode);
        }

        public string Delete(SqlTransaction myTransaction, string EthnicCode)
        {
            string[] strArrays = new string[] { "@EthnicCode" };
            object[] ethnicCode = new object[] { EthnicCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_ETHNIC_Delete", strArrays, ethnicCode);
        }

        public bool Exist(string EthnicCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@EthnicCode" };
            object[] ethnicCode = new object[] { EthnicCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_ETHNIC_Get", strArrays, ethnicCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string EthnicCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EthnicCode" };
            object[] ethnicCode = new object[] { EthnicCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_ETHNIC_Get", strArrays, ethnicCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EthnicCode = Convert.ToString(sqlDataReader["EthnicCode"]);
                    this.m_EthnicName = Convert.ToString(sqlDataReader["EthnicName"]);
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

        public string Get(SqlConnection myConnection, string EthnicCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EthnicCode" };
            object[] ethnicCode = new object[] { EthnicCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_ETHNIC_Get", strArrays, ethnicCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EthnicCode = Convert.ToString(sqlDataReader["EthnicCode"]);
                    this.m_EthnicName = Convert.ToString(sqlDataReader["EthnicName"]);
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

        public string Get(SqlTransaction myTransaction, string EthnicCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EthnicCode" };
            object[] ethnicCode = new object[] { EthnicCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_ETHNIC_Get", strArrays, ethnicCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EthnicCode = Convert.ToString(sqlDataReader["EthnicCode"]);
                    this.m_EthnicName = Convert.ToString(sqlDataReader["EthnicName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_ETHNIC_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@EthnicCode", "@EthnicName", "@Description", "@Active" };
            object[] mEthnicCode = new object[] { this.m_EthnicCode, this.m_EthnicName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ETHNIC_Insert", strArrays, mEthnicCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@EthnicCode", "@EthnicName", "@Description", "@Active" };
            object[] mEthnicCode = new object[] { this.m_EthnicCode, this.m_EthnicName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_ETHNIC_Insert", strArrays, mEthnicCode);
        }

        public string Insert(string EthnicCode, string EthnicName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EthnicCode", "@EthnicName", "@Description", "@Active" };
            object[] ethnicCode = new object[] { EthnicCode, EthnicName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ETHNIC_Insert", strArrays, ethnicCode);
        }

        public string Insert(SqlConnection myConnection, string EthnicCode, string EthnicName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EthnicCode", "@EthnicName", "@Description", "@Active" };
            object[] ethnicCode = new object[] { EthnicCode, EthnicName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_ETHNIC_Insert", strArrays, ethnicCode);
        }

        public string Insert(SqlTransaction myTransaction, string EthnicCode, string EthnicName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EthnicCode", "@EthnicName", "@Description", "@Active" };
            object[] ethnicCode = new object[] { EthnicCode, EthnicName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_ETHNIC_Insert", strArrays, ethnicCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_ETHNIC", "EthnicCode", "DT");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@EthnicCode", "@EthnicName", "@Description", "@Active" };
            object[] mEthnicCode = new object[] { this.m_EthnicCode, this.m_EthnicName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ETHNIC_Update", strArrays, mEthnicCode);
        }

        public string Update(string EthnicCode, string EthnicName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EthnicCode", "@EthnicName", "@Description", "@Active" };
            object[] ethnicCode = new object[] { EthnicCode, EthnicName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ETHNIC_Update", strArrays, ethnicCode);
        }

        public string Update(SqlConnection myConnection, string EthnicCode, string EthnicName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EthnicCode", "@EthnicName", "@Description", "@Active" };
            object[] ethnicCode = new object[] { EthnicCode, EthnicName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_ETHNIC_Update", strArrays, ethnicCode);
        }

        public string Update(SqlTransaction myTransaction, string EthnicCode, string EthnicName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EthnicCode", "@EthnicName", "@Description", "@Active" };
            object[] ethnicCode = new object[] { EthnicCode, EthnicName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_ETHNIC_Update", strArrays, ethnicCode);
        }
    }
}
