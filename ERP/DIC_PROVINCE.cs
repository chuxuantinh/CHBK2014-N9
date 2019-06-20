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
   public class DIC_PROVINCE
    {

        private string m_ProvinceCode;

        private string m_ProvinceName;

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
                return "Class DIC_PROVINCE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string ProvinceCode
        {
            get
            {
                return this.m_ProvinceCode;
            }
            set
            {
                this.m_ProvinceCode = value;
            }
        }

        public string ProvinceName
        {
            get
            {
                return this.m_ProvinceName;
            }
            set
            {
                this.m_ProvinceName = value;
            }
        }

        public DIC_PROVINCE()
        {
            this.m_ProvinceCode = "";
            this.m_ProvinceName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_PROVINCE(string ProvinceCode, string ProvinceName, string Description, bool Active)
        {
            this.m_ProvinceCode = ProvinceCode;
            this.m_ProvinceName = ProvinceName;
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
                    Description = row["ProvinceName"].ToString(),
                    CheckState = CheckState.Unchecked,
                    Value = row["ProvinceCode"].ToString()
                };
                checkedCombo.Properties.Items.Add(checkedListBoxItem);
            }
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "ProvinceName", "ProvinceCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["ProvinceCode"] = "All";
        //    dataRow["ProvinceName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "ProvinceName", "ProvinceCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            combo.Properties.Items.Clear();
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["ProvinceName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@ProvinceCode" };
            object[] mProvinceCode = new object[] { this.m_ProvinceCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROVINCE_Delete", strArrays, mProvinceCode);
        }

        public string Delete(string ProvinceCode)
        {
            string[] strArrays = new string[] { "@ProvinceCode" };
            object[] provinceCode = new object[] { ProvinceCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROVINCE_Delete", strArrays, provinceCode);
        }

        public string Delete(SqlConnection myConnection, string ProvinceCode)
        {
            string[] strArrays = new string[] { "@ProvinceCode" };
            object[] provinceCode = new object[] { ProvinceCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_PROVINCE_Delete", strArrays, provinceCode);
        }

        public string Delete(SqlTransaction myTransaction, string ProvinceCode)
        {
            string[] strArrays = new string[] { "@ProvinceCode" };
            object[] provinceCode = new object[] { ProvinceCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_PROVINCE_Delete", strArrays, provinceCode);
        }

        public bool Exist(string ProvinceCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ProvinceCode" };
            object[] provinceCode = new object[] { ProvinceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_PROVINCE_Get", strArrays, provinceCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string ProvinceCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProvinceCode" };
            object[] provinceCode = new object[] { ProvinceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_PROVINCE_Get", strArrays, provinceCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProvinceCode = Convert.ToString(sqlDataReader["ProvinceCode"]);
                    this.m_ProvinceName = Convert.ToString(sqlDataReader["ProvinceName"]);
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

        public string Get(SqlConnection myConnection, string ProvinceCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProvinceCode" };
            object[] provinceCode = new object[] { ProvinceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_PROVINCE_Get", strArrays, provinceCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProvinceCode = Convert.ToString(sqlDataReader["ProvinceCode"]);
                    this.m_ProvinceName = Convert.ToString(sqlDataReader["ProvinceName"]);
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

        public string Get(SqlTransaction myTransaction, string ProvinceCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProvinceCode" };
            object[] provinceCode = new object[] { ProvinceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_PROVINCE_Get", strArrays, provinceCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProvinceCode = Convert.ToString(sqlDataReader["ProvinceCode"]);
                    this.m_ProvinceName = Convert.ToString(sqlDataReader["ProvinceName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_PROVINCE_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@ProvinceCode", "@ProvinceName", "@Description", "@Active" };
            object[] mProvinceCode = new object[] { this.m_ProvinceCode, this.m_ProvinceName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROVINCE_Insert", strArrays, mProvinceCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@ProvinceCode", "@ProvinceName", "@Description", "@Active" };
            object[] mProvinceCode = new object[] { this.m_ProvinceCode, this.m_ProvinceName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_PROVINCE_Insert", strArrays, mProvinceCode);
        }

        public string Insert(string ProvinceCode, string ProvinceName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProvinceCode", "@ProvinceName", "@Description", "@Active" };
            object[] provinceCode = new object[] { ProvinceCode, ProvinceName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROVINCE_Insert", strArrays, provinceCode);
        }

        public string Insert(SqlConnection myConnection, string ProvinceCode, string ProvinceName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProvinceCode", "@ProvinceName", "@Description", "@Active" };
            object[] provinceCode = new object[] { ProvinceCode, ProvinceName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_PROVINCE_Insert", strArrays, provinceCode);
        }

        public string Insert(SqlTransaction myTransaction, string ProvinceCode, string ProvinceName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProvinceCode", "@ProvinceName", "@Description", "@Active" };
            object[] provinceCode = new object[] { ProvinceCode, ProvinceName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_PROVINCE_Insert", strArrays, provinceCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_PROVINCE", "ProvinceCode", "TI");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@ProvinceCode", "@ProvinceName", "@Description", "@Active" };
            object[] mProvinceCode = new object[] { this.m_ProvinceCode, this.m_ProvinceName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROVINCE_Update", strArrays, mProvinceCode);
        }

        public string Update(string ProvinceCode, string ProvinceName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProvinceCode", "@ProvinceName", "@Description", "@Active" };
            object[] provinceCode = new object[] { ProvinceCode, ProvinceName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROVINCE_Update", strArrays, provinceCode);
        }

        public string Update(SqlConnection myConnection, string ProvinceCode, string ProvinceName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProvinceCode", "@ProvinceName", "@Description", "@Active" };
            object[] provinceCode = new object[] { ProvinceCode, ProvinceName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_PROVINCE_Update", strArrays, provinceCode);
        }

        public string Update(SqlTransaction myTransaction, string ProvinceCode, string ProvinceName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProvinceCode", "@ProvinceName", "@Description", "@Active" };
            object[] provinceCode = new object[] { ProvinceCode, ProvinceName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_PROVINCE_Update", strArrays, provinceCode);
        }

    }
}
