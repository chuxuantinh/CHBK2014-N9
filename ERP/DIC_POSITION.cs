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
    public class DIC_POSITION
    {

        private string m_PositionCode;

        private string m_PositionName;

        private bool m_IsManager;

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

        public bool IsManager
        {
            get
            {
                return this.m_IsManager;
            }
            set
            {
                this.m_IsManager = value;
            }
        }

        public string PositionCode
        {
            get
            {
                return this.m_PositionCode;
            }
            set
            {
                this.m_PositionCode = value;
            }
        }

        public string PositionName
        {
            get
            {
                return this.m_PositionName;
            }
            set
            {
                this.m_PositionName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_POSITION";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_POSITION()
        {
            this.m_PositionCode = "";
            this.m_PositionName = "";
            this.m_IsManager = false;
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_POSITION(string PositionCode, string PositionName, bool IsManager, string Description, bool Active)
        {
            this.m_PositionCode = PositionCode;
            this.m_PositionName = PositionName;
            this.m_IsManager = IsManager;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "PositionName", "PositionCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["PositionCode"] = "All";
        //    dataRow["PositionName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "PositionName", "PositionCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["PositionName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "PositionName";
            gridlookup.Properties.ValueMember = "PositionCode";
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@PositionCode" };
            object[] mPositionCode = new object[] { this.m_PositionCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_POSITION_Delete", strArrays, mPositionCode);
        }

        public string Delete(string PositionCode)
        {
            string[] strArrays = new string[] { "@PositionCode" };
            object[] positionCode = new object[] { PositionCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_POSITION_Delete", strArrays, positionCode);
        }

        public string Delete(SqlConnection myConnection, string PositionCode)
        {
            string[] strArrays = new string[] { "@PositionCode" };
            object[] positionCode = new object[] { PositionCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_POSITION_Delete", strArrays, positionCode);
        }

        public string Delete(SqlTransaction myTransaction, string PositionCode)
        {
            string[] strArrays = new string[] { "@PositionCode" };
            object[] positionCode = new object[] { PositionCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_POSITION_Delete", strArrays, positionCode);
        }

        public bool Exist(string PositionCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@PositionCode" };
            object[] positionCode = new object[] { PositionCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_POSITION_Get", strArrays, positionCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string PositionCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@PositionCode" };
            object[] positionCode = new object[] { PositionCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_POSITION_Get", strArrays, positionCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_PositionCode = Convert.ToString(sqlDataReader["PositionCode"]);
                    this.m_PositionName = Convert.ToString(sqlDataReader["PositionName"]);
                    this.m_IsManager = Convert.ToBoolean(sqlDataReader["IsManager"]);
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

        public string Get(SqlConnection myConnection, string PositionCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@PositionCode" };
            object[] positionCode = new object[] { PositionCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_POSITION_Get", strArrays, positionCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_PositionCode = Convert.ToString(sqlDataReader["PositionCode"]);
                    this.m_PositionName = Convert.ToString(sqlDataReader["PositionName"]);
                    this.m_IsManager = Convert.ToBoolean(sqlDataReader["IsManager"]);
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

        public string Get(SqlTransaction myTransaction, string PositionCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@PositionCode" };
            object[] positionCode = new object[] { PositionCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_POSITION_Get", strArrays, positionCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_PositionCode = Convert.ToString(sqlDataReader["PositionCode"]);
                    this.m_PositionName = Convert.ToString(sqlDataReader["PositionName"]);
                    this.m_IsManager = Convert.ToBoolean(sqlDataReader["IsManager"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_POSITION_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@PositionCode", "@PositionName", "@IsManager", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mPositionCode = new object[] { this.m_PositionCode, this.m_PositionName, this.m_IsManager, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_POSITION_Insert", strArrays1, mPositionCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@PositionCode", "@PositionName", "@IsManager", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mPositionCode = new object[] { this.m_PositionCode, this.m_PositionName, this.m_IsManager, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_POSITION_Insert", strArrays1, mPositionCode);
        }

        public string Insert(string PositionCode, string PositionName, bool IsManager, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@PositionCode", "@PositionName", "@IsManager", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] positionCode = new object[] { PositionCode, PositionName, IsManager, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_POSITION_Insert", strArrays1, positionCode);
        }

        public string Insert(SqlConnection myConnection, string PositionCode, string PositionName, bool IsManager, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@PositionCode", "@PositionName", "@IsManager", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] positionCode = new object[] { PositionCode, PositionName, IsManager, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_POSITION_Insert", strArrays1, positionCode);
        }

        public string Insert(SqlTransaction myTransaction, string PositionCode, string PositionName, bool IsManager, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@PositionCode", "@PositionName", "@IsManager", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] positionCode = new object[] { PositionCode, PositionName, IsManager, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_POSITION_Insert", strArrays1, positionCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_POSITION", "PositionCode", "CV");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@PositionCode", "@PositionName", "@IsManager", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mPositionCode = new object[] { this.m_PositionCode, this.m_PositionName, this.m_IsManager, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_POSITION_Update", strArrays1, mPositionCode);
        }

        public string Update(string PositionCode, string PositionName, bool IsManager, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@PositionCode", "@PositionName", "@IsManager", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] positionCode = new object[] { PositionCode, PositionName, IsManager, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_POSITION_Update", strArrays1, positionCode);
        }

        public string Update(SqlConnection myConnection, string PositionCode, string PositionName, bool IsManager, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@PositionCode", "@PositionName", "@IsManager", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] positionCode = new object[] { PositionCode, PositionName, IsManager, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_POSITION_Update", strArrays1, positionCode);
        }

        public string Update(SqlTransaction myTransaction, string PositionCode, string PositionName, bool IsManager, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@PositionCode", "@PositionName", "@IsManager", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] positionCode = new object[] { PositionCode, PositionName, IsManager, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_POSITION_Update", strArrays1, positionCode);
        }
    }
}
