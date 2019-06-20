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
  public  class DIC_HOSPITAL
    {


        private string m_HospitalCode;

        private string m_ProvinceCode;

        private string m_HospitalName;

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

        public string HospitalCode
        {
            get
            {
                return this.m_HospitalCode;
            }
            set
            {
                this.m_HospitalCode = value;
            }
        }

        public string HospitalName
        {
            get
            {
                return this.m_HospitalName;
            }
            set
            {
                this.m_HospitalName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_HOSPITAL";
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

        public DIC_HOSPITAL()
        {
            this.m_HospitalCode = "";
            this.m_ProvinceCode = "";
            this.m_HospitalName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_HOSPITAL(string HospitalCode, string ProvinceCode, string HospitalName, string Description, bool Active)
        {
            this.m_HospitalCode = HospitalCode;
            this.m_ProvinceCode = ProvinceCode;
            this.m_HospitalName = HospitalName;
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
                    Description = row["HospitalName"].ToString(),
                    CheckState = CheckState.Unchecked,
                    Value = row["HospitalCode"].ToString()
                };
                checkedCombo.Properties.Items.Add(checkedListBoxItem);
            }
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "HospitalName", "HospitalCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["HospitalCode"] = "All";
        //    dataRow["HospitalName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "HospitalName", "HospitalCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            combo.Properties.Items.Clear();
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["HospitalName"]);
            }
        }

        public void AddComboEdit(string ProvinceCode, ComboBoxEdit combo)
        {
            combo.Properties.Items.Clear();
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList(ProvinceCode).Rows)
            {
                combo.Properties.Items.Add(row["HospitalName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@HospitalCode" };
            object[] mHospitalCode = new object[] { this.m_HospitalCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOSPITAL_Delete", strArrays, mHospitalCode);
        }

        public string Delete(string HospitalCode)
        {
            string[] strArrays = new string[] { "@HospitalCode" };
            object[] hospitalCode = new object[] { HospitalCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOSPITAL_Delete", strArrays, hospitalCode);
        }

        public string Delete(SqlConnection myConnection, string HospitalCode)
        {
            string[] strArrays = new string[] { "@HospitalCode" };
            object[] hospitalCode = new object[] { HospitalCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_HOSPITAL_Delete", strArrays, hospitalCode);
        }

        public string Delete(SqlTransaction myTransaction, string HospitalCode)
        {
            string[] strArrays = new string[] { "@HospitalCode" };
            object[] hospitalCode = new object[] { HospitalCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_HOSPITAL_Delete", strArrays, hospitalCode);
        }

        public bool Exist(string HospitalCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@HospitalCode" };
            object[] hospitalCode = new object[] { HospitalCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_HOSPITAL_Get", strArrays, hospitalCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string HospitalCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@HospitalCode" };
            object[] hospitalCode = new object[] { HospitalCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_HOSPITAL_Get", strArrays, hospitalCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_HospitalCode = Convert.ToString(sqlDataReader["HospitalCode"]);
                    this.m_ProvinceCode = Convert.ToString(sqlDataReader["ProvinceCode"]);
                    this.m_HospitalName = Convert.ToString(sqlDataReader["HospitalName"]);
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

        public string Get(SqlConnection myConnection, string HospitalCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@HospitalCode" };
            object[] hospitalCode = new object[] { HospitalCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_HOSPITAL_Get", strArrays, hospitalCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_HospitalCode = Convert.ToString(sqlDataReader["HospitalCode"]);
                    this.m_ProvinceCode = Convert.ToString(sqlDataReader["ProvinceCode"]);
                    this.m_HospitalName = Convert.ToString(sqlDataReader["HospitalName"]);
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

        public string Get(SqlTransaction myTransaction, string HospitalCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@HospitalCode" };
            object[] hospitalCode = new object[] { HospitalCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_HOSPITAL_Get", strArrays, hospitalCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_HospitalCode = Convert.ToString(sqlDataReader["HospitalCode"]);
                    this.m_ProvinceCode = Convert.ToString(sqlDataReader["ProvinceCode"]);
                    this.m_HospitalName = Convert.ToString(sqlDataReader["HospitalName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_HOSPITAL_GetList");
        }

        public DataTable GetList(string ProvinceCode)
        {
            string[] strArrays = new string[] { "@ProvinceCode" };
            object[] provinceCode = new object[] { ProvinceCode };
            return (new SqlHelper()).ExecuteDataTable("DIC_HOSPITAL_GetList", strArrays, provinceCode);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@HospitalCode", "@ProvinceCode", "@HospitalName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mHospitalCode = new object[] { this.m_HospitalCode, this.m_ProvinceCode, this.m_HospitalName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOSPITAL_Insert", strArrays1, mHospitalCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@HospitalCode", "@ProvinceCode", "@HospitalName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mHospitalCode = new object[] { this.m_HospitalCode, this.m_ProvinceCode, this.m_HospitalName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_HOSPITAL_Insert", strArrays1, mHospitalCode);
        }

        public string Insert(string HospitalCode, string ProvinceCode, string HospitalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@HospitalCode", "@ProvinceCode", "@HospitalName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] hospitalCode = new object[] { HospitalCode, ProvinceCode, HospitalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOSPITAL_Insert", strArrays1, hospitalCode);
        }

        public string Insert(SqlConnection myConnection, string HospitalCode, string ProvinceCode, string HospitalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@HospitalCode", "@ProvinceCode", "@HospitalName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] hospitalCode = new object[] { HospitalCode, ProvinceCode, HospitalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_HOSPITAL_Insert", strArrays1, hospitalCode);
        }

        public string Insert(SqlTransaction myTransaction, string HospitalCode, string ProvinceCode, string HospitalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@HospitalCode", "@ProvinceCode", "@HospitalName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] hospitalCode = new object[] { HospitalCode, ProvinceCode, HospitalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_HOSPITAL_Insert", strArrays1, hospitalCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_HOSPITAL", "HospitalCode", "BV");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@HospitalCode", "@ProvinceCode", "@HospitalName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mHospitalCode = new object[] { this.m_HospitalCode, this.m_ProvinceCode, this.m_HospitalName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOSPITAL_Update", strArrays1, mHospitalCode);
        }

        public string Update(string HospitalCode, string ProvinceCode, string HospitalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@HospitalCode", "@ProvinceCode", "@HospitalName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] hospitalCode = new object[] { HospitalCode, ProvinceCode, HospitalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_HOSPITAL_Update", strArrays1, hospitalCode);
        }

        public string Update(SqlConnection myConnection, string HospitalCode, string ProvinceCode, string HospitalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@HospitalCode", "@ProvinceCode", "@HospitalName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] hospitalCode = new object[] { HospitalCode, ProvinceCode, HospitalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_HOSPITAL_Update", strArrays1, hospitalCode);
        }

        public string Update(SqlTransaction myTransaction, string HospitalCode, string ProvinceCode, string HospitalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@HospitalCode", "@ProvinceCode", "@HospitalName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] hospitalCode = new object[] { HospitalCode, ProvinceCode, HospitalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_HOSPITAL_Update", strArrays1, hospitalCode);
        }
    }
}
