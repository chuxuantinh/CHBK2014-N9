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
 public   class DIC_UNIT
    {
        private string m_UnitCode;

        private string m_UnitName;

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
                return "Class DIC_UNIT";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string UnitCode
        {
            get
            {
                return this.m_UnitCode;
            }
            set
            {
                this.m_UnitCode = value;
            }
        }

        public string UnitName
        {
            get
            {
                return this.m_UnitName;
            }
            set
            {
                this.m_UnitName = value;
            }
        }

        public DIC_UNIT()
        {
            this.m_UnitCode = "";
            this.m_UnitName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_UNIT(string UnitCode, string UnitName, string Description, bool Active)
        {
            this.m_UnitCode = UnitCode;
            this.m_UnitName = UnitName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "UnitName", "UnitCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["UnitCode"] = "All";
        //    dataRow["UnitName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "UnitName", "UnitCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["UnitName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@UnitCode" };
            object[] mUnitCode = new object[] { this.m_UnitCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_UNIT_Delete", strArrays, mUnitCode);
        }

        public string Delete(string UnitCode)
        {
            string[] strArrays = new string[] { "@UnitCode" };
            object[] unitCode = new object[] { UnitCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_UNIT_Delete", strArrays, unitCode);
        }

        public string Delete(SqlConnection myConnection, string UnitCode)
        {
            string[] strArrays = new string[] { "@UnitCode" };
            object[] unitCode = new object[] { UnitCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_UNIT_Delete", strArrays, unitCode);
        }

        public string Delete(SqlTransaction myTransaction, string UnitCode)
        {
            string[] strArrays = new string[] { "@UnitCode" };
            object[] unitCode = new object[] { UnitCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_UNIT_Delete", strArrays, unitCode);
        }

        public bool Exist(string UnitCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@UnitCode" };
            object[] unitCode = new object[] { UnitCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_UNIT_Get", strArrays, unitCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string UnitCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@UnitCode" };
            object[] unitCode = new object[] { UnitCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_UNIT_Get", strArrays, unitCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_UnitCode = Convert.ToString(sqlDataReader["UnitCode"]);
                    this.m_UnitName = Convert.ToString(sqlDataReader["UnitName"]);
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

        public string Get(SqlConnection myConnection, string UnitCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@UnitCode" };
            object[] unitCode = new object[] { UnitCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_UNIT_Get", strArrays, unitCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_UnitCode = Convert.ToString(sqlDataReader["UnitCode"]);
                    this.m_UnitName = Convert.ToString(sqlDataReader["UnitName"]);
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

        public string Get(SqlTransaction myTransaction, string UnitCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@UnitCode" };
            object[] unitCode = new object[] { UnitCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_UNIT_Get", strArrays, unitCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_UnitCode = Convert.ToString(sqlDataReader["UnitCode"]);
                    this.m_UnitName = Convert.ToString(sqlDataReader["UnitName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_UNIT_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@UnitCode", "@UnitName", "@Description", "@Active" };
            object[] mUnitCode = new object[] { this.m_UnitCode, this.m_UnitName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_UNIT_Insert", strArrays, mUnitCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@UnitCode", "@UnitName", "@Description", "@Active" };
            object[] mUnitCode = new object[] { this.m_UnitCode, this.m_UnitName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_UNIT_Insert", strArrays, mUnitCode);
        }

        public string Insert(string UnitCode, string UnitName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@UnitCode", "@UnitName", "@Description", "@Active" };
            object[] unitCode = new object[] { UnitCode, UnitName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_UNIT_Insert", strArrays, unitCode);
        }

        public string Insert(SqlConnection myConnection, string UnitCode, string UnitName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@UnitCode", "@UnitName", "@Description", "@Active" };
            object[] unitCode = new object[] { UnitCode, UnitName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_UNIT_Insert", strArrays, unitCode);
        }

        public string Insert(SqlTransaction myTransaction, string UnitCode, string UnitName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@UnitCode", "@UnitName", "@Description", "@Active" };
            object[] unitCode = new object[] { UnitCode, UnitName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_UNIT_Insert", strArrays, unitCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_UNIT", "UnitCode", "DVT");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@UnitCode", "@UnitName", "@Description", "@Active" };
            object[] mUnitCode = new object[] { this.m_UnitCode, this.m_UnitName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_UNIT_Update", strArrays, mUnitCode);
        }

        public string Update(string UnitCode, string UnitName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@UnitCode", "@UnitName", "@Description", "@Active" };
            object[] unitCode = new object[] { UnitCode, UnitName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_UNIT_Update", strArrays, unitCode);
        }

        public string Update(SqlConnection myConnection, string UnitCode, string UnitName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@UnitCode", "@UnitName", "@Description", "@Active" };
            object[] unitCode = new object[] { UnitCode, UnitName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_UNIT_Update", strArrays, unitCode);
        }

        public string Update(SqlTransaction myTransaction, string UnitCode, string UnitName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@UnitCode", "@UnitName", "@Description", "@Active" };
            object[] unitCode = new object[] { UnitCode, UnitName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_UNIT_Update", strArrays, unitCode);
        }

    }
}
