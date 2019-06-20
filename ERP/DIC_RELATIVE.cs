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
  public  class DIC_RELATIVE
    {
        private string m_RelativeCode;

        private string m_RelativeName;

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
                return "Class DIC_RELATIVE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string RelativeCode
        {
            get
            {
                return this.m_RelativeCode;
            }
            set
            {
                this.m_RelativeCode = value;
            }
        }

        public string RelativeName
        {
            get
            {
                return this.m_RelativeName;
            }
            set
            {
                this.m_RelativeName = value;
            }
        }

        public DIC_RELATIVE()
        {
            this.m_RelativeCode = "";
            this.m_RelativeName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_RELATIVE(string RelativeCode, string RelativeName, string Description, bool Active)
        {
            this.m_RelativeCode = RelativeCode;
            this.m_RelativeName = RelativeName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "RelativeName", "RelativeCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["RelativeCode"] = "All";
        //    dataRow["RelativeName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "RelativeName", "RelativeCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["RelativeName"]);
            }
        }

        public void AddRepositoryGridLookup(RepositoryItemGridLookUpEdit grlookup)
        {
            DataTable dataTable = new DataTable();
            grlookup.DataSource = this.GetList();
            grlookup.DisplayMember = "RelativeName";
            grlookup.ValueMember = "RelativeName";
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@RelativeCode" };
            object[] mRelativeCode = new object[] { this.m_RelativeCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELATIVE_Delete", strArrays, mRelativeCode);
        }

        public string Delete(string RelativeCode)
        {
            string[] strArrays = new string[] { "@RelativeCode" };
            object[] relativeCode = new object[] { RelativeCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELATIVE_Delete", strArrays, relativeCode);
        }

        public string Delete(SqlConnection myConnection, string RelativeCode)
        {
            string[] strArrays = new string[] { "@RelativeCode" };
            object[] relativeCode = new object[] { RelativeCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_RELATIVE_Delete", strArrays, relativeCode);
        }

        public string Delete(SqlTransaction myTransaction, string RelativeCode)
        {
            string[] strArrays = new string[] { "@RelativeCode" };
            object[] relativeCode = new object[] { RelativeCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RELATIVE_Delete", strArrays, relativeCode);
        }

        public bool Exist(string RelativeCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@RelativeCode" };
            object[] relativeCode = new object[] { RelativeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_RELATIVE_Get", strArrays, relativeCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string RelativeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@RelativeCode" };
            object[] relativeCode = new object[] { RelativeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_RELATIVE_Get", strArrays, relativeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_RelativeCode = Convert.ToString(sqlDataReader["RelativeCode"]);
                    this.m_RelativeName = Convert.ToString(sqlDataReader["RelativeName"]);
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

        public string Get(SqlConnection myConnection, string RelativeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@RelativeCode" };
            object[] relativeCode = new object[] { RelativeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_RELATIVE_Get", strArrays, relativeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_RelativeCode = Convert.ToString(sqlDataReader["RelativeCode"]);
                    this.m_RelativeName = Convert.ToString(sqlDataReader["RelativeName"]);
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

        public string Get(SqlTransaction myTransaction, string RelativeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@RelativeCode" };
            object[] relativeCode = new object[] { RelativeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_RELATIVE_Get", strArrays, relativeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_RelativeCode = Convert.ToString(sqlDataReader["RelativeCode"]);
                    this.m_RelativeName = Convert.ToString(sqlDataReader["RelativeName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_RELATIVE_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@RelativeCode", "@RelativeName", "@Description", "@Active" };
            object[] mRelativeCode = new object[] { this.m_RelativeCode, this.m_RelativeName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELATIVE_Insert", strArrays, mRelativeCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@RelativeCode", "@RelativeName", "@Description", "@Active" };
            object[] mRelativeCode = new object[] { this.m_RelativeCode, this.m_RelativeName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RELATIVE_Insert", strArrays, mRelativeCode);
        }

        public string Insert(string RelativeCode, string RelativeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RelativeCode", "@RelativeName", "@Description", "@Active" };
            object[] relativeCode = new object[] { RelativeCode, RelativeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELATIVE_Insert", strArrays, relativeCode);
        }

        public string Insert(SqlConnection myConnection, string RelativeCode, string RelativeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RelativeCode", "@RelativeName", "@Description", "@Active" };
            object[] relativeCode = new object[] { RelativeCode, RelativeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_RELATIVE_Insert", strArrays, relativeCode);
        }

        public string Insert(SqlTransaction myTransaction, string RelativeCode, string RelativeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RelativeCode", "@RelativeName", "@Description", "@Active" };
            object[] relativeCode = new object[] { RelativeCode, RelativeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RELATIVE_Insert", strArrays, relativeCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_RELATIVE", "RelativeCode", "QHGD");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@RelativeCode", "@RelativeName", "@Description", "@Active" };
            object[] mRelativeCode = new object[] { this.m_RelativeCode, this.m_RelativeName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELATIVE_Update", strArrays, mRelativeCode);
        }

        public string Update(string RelativeCode, string RelativeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RelativeCode", "@RelativeName", "@Description", "@Active" };
            object[] relativeCode = new object[] { RelativeCode, RelativeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RELATIVE_Update", strArrays, relativeCode);
        }

        public string Update(SqlConnection myConnection, string RelativeCode, string RelativeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RelativeCode", "@RelativeName", "@Description", "@Active" };
            object[] relativeCode = new object[] { RelativeCode, RelativeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_RELATIVE_Update", strArrays, relativeCode);
        }

        public string Update(SqlTransaction myTransaction, string RelativeCode, string RelativeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RelativeCode", "@RelativeName", "@Description", "@Active" };
            object[] relativeCode = new object[] { RelativeCode, RelativeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RELATIVE_Update", strArrays, relativeCode);
        }

    }
}
