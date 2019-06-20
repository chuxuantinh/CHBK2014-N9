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
   public class DIC_INFORMATIC
    {

        private string m_InformaticCode;

        private string m_InformaticName;

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

        public string InformaticCode
        {
            get
            {
                return this.m_InformaticCode;
            }
            set
            {
                this.m_InformaticCode = value;
            }
        }

        public string InformaticName
        {
            get
            {
                return this.m_InformaticName;
            }
            set
            {
                this.m_InformaticName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_INFORMATIC";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_INFORMATIC()
        {
            this.m_InformaticCode = "";
            this.m_InformaticName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_INFORMATIC(string InformaticCode, string InformaticName, string Description, bool Active)
        {
            this.m_InformaticCode = InformaticCode;
            this.m_InformaticName = InformaticName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "InformaticName", "InformaticCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["InformaticCode"] = "All";
        //    dataRow["InformaticName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "InformaticName", "InformaticCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["InformaticName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@InformaticCode" };
            object[] mInformaticCode = new object[] { this.m_InformaticCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_INFORMATIC_Delete", strArrays, mInformaticCode);
        }

        public string Delete(string InformaticCode)
        {
            string[] strArrays = new string[] { "@InformaticCode" };
            object[] informaticCode = new object[] { InformaticCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_INFORMATIC_Delete", strArrays, informaticCode);
        }

        public string Delete(SqlConnection myConnection, string InformaticCode)
        {
            string[] strArrays = new string[] { "@InformaticCode" };
            object[] informaticCode = new object[] { InformaticCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_INFORMATIC_Delete", strArrays, informaticCode);
        }

        public string Delete(SqlTransaction myTransaction, string InformaticCode)
        {
            string[] strArrays = new string[] { "@InformaticCode" };
            object[] informaticCode = new object[] { InformaticCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_INFORMATIC_Delete", strArrays, informaticCode);
        }

        public bool Exist(string InformaticCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@InformaticCode" };
            object[] informaticCode = new object[] { InformaticCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_INFORMATIC_Get", strArrays, informaticCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string InformaticCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@InformaticCode" };
            object[] informaticCode = new object[] { InformaticCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_INFORMATIC_Get", strArrays, informaticCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_InformaticCode = Convert.ToString(sqlDataReader["InformaticCode"]);
                    this.m_InformaticName = Convert.ToString(sqlDataReader["InformaticName"]);
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

        public string Get(SqlConnection myConnection, string InformaticCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@InformaticCode" };
            object[] informaticCode = new object[] { InformaticCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_INFORMATIC_Get", strArrays, informaticCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_InformaticCode = Convert.ToString(sqlDataReader["InformaticCode"]);
                    this.m_InformaticName = Convert.ToString(sqlDataReader["InformaticName"]);
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

        public string Get(SqlTransaction myTransaction, string InformaticCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@InformaticCode" };
            object[] informaticCode = new object[] { InformaticCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_INFORMATIC_Get", strArrays, informaticCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_InformaticCode = Convert.ToString(sqlDataReader["InformaticCode"]);
                    this.m_InformaticName = Convert.ToString(sqlDataReader["InformaticName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_INFORMATIC_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@InformaticCode", "@InformaticName", "@Description", "@Active" };
            object[] mInformaticCode = new object[] { this.m_InformaticCode, this.m_InformaticName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_INFORMATIC_Insert", strArrays, mInformaticCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@InformaticCode", "@InformaticName", "@Description", "@Active" };
            object[] mInformaticCode = new object[] { this.m_InformaticCode, this.m_InformaticName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_INFORMATIC_Insert", strArrays, mInformaticCode);
        }

        public string Insert(string InformaticCode, string InformaticName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@InformaticCode", "@InformaticName", "@Description", "@Active" };
            object[] informaticCode = new object[] { InformaticCode, InformaticName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_INFORMATIC_Insert", strArrays, informaticCode);
        }

        public string Insert(SqlConnection myConnection, string InformaticCode, string InformaticName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@InformaticCode", "@InformaticName", "@Description", "@Active" };
            object[] informaticCode = new object[] { InformaticCode, InformaticName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_INFORMATIC_Insert", strArrays, informaticCode);
        }

        public string Insert(SqlTransaction myTransaction, string InformaticCode, string InformaticName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@InformaticCode", "@InformaticName", "@Description", "@Active" };
            object[] informaticCode = new object[] { InformaticCode, InformaticName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_INFORMATIC_Insert", strArrays, informaticCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_INFORMATIC", "InformaticCode", "TH");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@InformaticCode", "@InformaticName", "@Description", "@Active" };
            object[] mInformaticCode = new object[] { this.m_InformaticCode, this.m_InformaticName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_INFORMATIC_Update", strArrays, mInformaticCode);
        }

        public string Update(string InformaticCode, string InformaticName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@InformaticCode", "@InformaticName", "@Description", "@Active" };
            object[] informaticCode = new object[] { InformaticCode, InformaticName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_INFORMATIC_Update", strArrays, informaticCode);
        }

        public string Update(SqlConnection myConnection, string InformaticCode, string InformaticName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@InformaticCode", "@InformaticName", "@Description", "@Active" };
            object[] informaticCode = new object[] { InformaticCode, InformaticName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_INFORMATIC_Update", strArrays, informaticCode);
        }

        public string Update(SqlTransaction myTransaction, string InformaticCode, string InformaticName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@InformaticCode", "@InformaticName", "@Description", "@Active" };
            object[] informaticCode = new object[] { InformaticCode, InformaticName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_INFORMATIC_Update", strArrays, informaticCode);
        }
    }
}
