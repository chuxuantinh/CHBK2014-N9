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
  public  class HRM_PRODUCT_GROUP
    {


        private string m_ProductGroupCode;

        private string m_ProductGroupName;

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

        public string ProductGroupCode
        {
            get
            {
                return this.m_ProductGroupCode;
            }
            set
            {
                this.m_ProductGroupCode = value;
            }
        }

        public string ProductGroupName
        {
            get
            {
                return this.m_ProductGroupName;
            }
            set
            {
                this.m_ProductGroupName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_PRODUCT_GROUP";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public HRM_PRODUCT_GROUP()
        {
            this.m_ProductGroupCode = "";
            this.m_ProductGroupName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public HRM_PRODUCT_GROUP(string ProductGroupCode, string ProductGroupName, string Description, bool Active)
        {
            this.m_ProductGroupCode = ProductGroupCode;
            this.m_ProductGroupName = ProductGroupName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "ProductGroupName", "ProductGroupCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["ProductGroupCode"] = "All";
        //    dataRow["ProductGroupName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "ProductGroupName", "ProductGroupCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["ProductGroupName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@ProductGroupCode" };
            object[] mProductGroupCode = new object[] { this.m_ProductGroupCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_GROUP_Delete", strArrays, mProductGroupCode);
        }

        public string Delete(string ProductGroupCode)
        {
            string[] strArrays = new string[] { "@ProductGroupCode" };
            object[] productGroupCode = new object[] { ProductGroupCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_GROUP_Delete", strArrays, productGroupCode);
        }

        public string Delete(SqlConnection myConnection, string ProductGroupCode)
        {
            string[] strArrays = new string[] { "@ProductGroupCode" };
            object[] productGroupCode = new object[] { ProductGroupCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PRODUCT_GROUP_Delete", strArrays, productGroupCode);
        }

        public string Delete(SqlTransaction myTransaction, string ProductGroupCode)
        {
            string[] strArrays = new string[] { "@ProductGroupCode" };
            object[] productGroupCode = new object[] { ProductGroupCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PRODUCT_GROUP_Delete", strArrays, productGroupCode);
        }

        public bool Exist(string ProductGroupCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ProductGroupCode" };
            object[] productGroupCode = new object[] { ProductGroupCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PRODUCT_GROUP_Get", strArrays, productGroupCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string ProductGroupCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProductGroupCode" };
            object[] productGroupCode = new object[] { ProductGroupCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PRODUCT_GROUP_Get", strArrays, productGroupCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProductGroupCode = Convert.ToString(sqlDataReader["ProductGroupCode"]);
                    this.m_ProductGroupName = Convert.ToString(sqlDataReader["ProductGroupName"]);
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

        public string Get(SqlConnection myConnection, string ProductGroupCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProductGroupCode" };
            object[] productGroupCode = new object[] { ProductGroupCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_PRODUCT_GROUP_Get", strArrays, productGroupCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProductGroupCode = Convert.ToString(sqlDataReader["ProductGroupCode"]);
                    this.m_ProductGroupName = Convert.ToString(sqlDataReader["ProductGroupName"]);
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

        public string Get(SqlTransaction myTransaction, string ProductGroupCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProductGroupCode" };
            object[] productGroupCode = new object[] { ProductGroupCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_PRODUCT_GROUP_Get", strArrays, productGroupCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProductGroupCode = Convert.ToString(sqlDataReader["ProductGroupCode"]);
                    this.m_ProductGroupName = Convert.ToString(sqlDataReader["ProductGroupName"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_PRODUCT_GROUP_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@ProductGroupCode", "@ProductGroupName", "@Description", "@Active" };
            object[] mProductGroupCode = new object[] { this.m_ProductGroupCode, this.m_ProductGroupName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_GROUP_Insert", strArrays, mProductGroupCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@ProductGroupCode", "@ProductGroupName", "@Description", "@Active" };
            object[] mProductGroupCode = new object[] { this.m_ProductGroupCode, this.m_ProductGroupName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PRODUCT_GROUP_Insert", strArrays, mProductGroupCode);
        }

        public string Insert(string ProductGroupCode, string ProductGroupName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProductGroupCode", "@ProductGroupName", "@Description", "@Active" };
            object[] productGroupCode = new object[] { ProductGroupCode, ProductGroupName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_GROUP_Insert", strArrays, productGroupCode);
        }

        public string Insert(SqlConnection myConnection, string ProductGroupCode, string ProductGroupName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProductGroupCode", "@ProductGroupName", "@Description", "@Active" };
            object[] productGroupCode = new object[] { ProductGroupCode, ProductGroupName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PRODUCT_GROUP_Insert", strArrays, productGroupCode);
        }

        public string Insert(SqlTransaction myTransaction, string ProductGroupCode, string ProductGroupName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProductGroupCode", "@ProductGroupName", "@Description", "@Active" };
            object[] productGroupCode = new object[] { ProductGroupCode, ProductGroupName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PRODUCT_GROUP_Insert", strArrays, productGroupCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_PRODUCT_GROUP", "ProductGroupCode", "NH");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@ProductGroupCode", "@ProductGroupName", "@Description", "@Active" };
            object[] mProductGroupCode = new object[] { this.m_ProductGroupCode, this.m_ProductGroupName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_GROUP_Update", strArrays, mProductGroupCode);
        }

        public string Update(string ProductGroupCode, string ProductGroupName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProductGroupCode", "@ProductGroupName", "@Description", "@Active" };
            object[] productGroupCode = new object[] { ProductGroupCode, ProductGroupName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_GROUP_Update", strArrays, productGroupCode);
        }

        public string Update(SqlConnection myConnection, string ProductGroupCode, string ProductGroupName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProductGroupCode", "@ProductGroupName", "@Description", "@Active" };
            object[] productGroupCode = new object[] { ProductGroupCode, ProductGroupName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PRODUCT_GROUP_Update", strArrays, productGroupCode);
        }

        public string Update(SqlTransaction myTransaction, string ProductGroupCode, string ProductGroupName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProductGroupCode", "@ProductGroupName", "@Description", "@Active" };
            object[] productGroupCode = new object[] { ProductGroupCode, ProductGroupName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PRODUCT_GROUP_Update", strArrays, productGroupCode);
        }
    }
}
