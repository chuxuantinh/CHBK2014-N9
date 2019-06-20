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
  public  class DIC_EDUCATION
    {

        private string m_EducationCode;

        private string m_EducationName;

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

        public string EducationCode
        {
            get
            {
                return this.m_EducationCode;
            }
            set
            {
                this.m_EducationCode = value;
            }
        }

        public string EducationName
        {
            get
            {
                return this.m_EducationName;
            }
            set
            {
                this.m_EducationName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_EDUCATION";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_EDUCATION()
        {
            this.m_EducationCode = "";
            this.m_EducationName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_EDUCATION(string EducationCode, string EducationName, string Description, bool Active)
        {
            this.m_EducationCode = EducationCode;
            this.m_EducationName = EducationName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "EducationName", "EducationCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["EducationCode"] = "All";
        //    dataRow["EducationName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "EducationName", "EducationCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["EducationName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@EducationCode" };
            object[] mEducationCode = new object[] { this.m_EducationCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_EDUCATION_Delete", strArrays, mEducationCode);
        }

        public string Delete(string EducationCode)
        {
            string[] strArrays = new string[] { "@EducationCode" };
            object[] educationCode = new object[] { EducationCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_EDUCATION_Delete", strArrays, educationCode);
        }

        public string Delete(SqlConnection myConnection, string EducationCode)
        {
            string[] strArrays = new string[] { "@EducationCode" };
            object[] educationCode = new object[] { EducationCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_EDUCATION_Delete", strArrays, educationCode);
        }

        public string Delete(SqlTransaction myTransaction, string EducationCode)
        {
            string[] strArrays = new string[] { "@EducationCode" };
            object[] educationCode = new object[] { EducationCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_EDUCATION_Delete", strArrays, educationCode);
        }

        public bool Exist(string EducationCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@EducationCode" };
            object[] educationCode = new object[] { EducationCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_EDUCATION_Get", strArrays, educationCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string EducationCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EducationCode" };
            object[] educationCode = new object[] { EducationCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_EDUCATION_Get", strArrays, educationCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EducationCode = Convert.ToString(sqlDataReader["EducationCode"]);
                    this.m_EducationName = Convert.ToString(sqlDataReader["EducationName"]);
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

        public string Get(SqlConnection myConnection, string EducationCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EducationCode" };
            object[] educationCode = new object[] { EducationCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_EDUCATION_Get", strArrays, educationCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EducationCode = Convert.ToString(sqlDataReader["EducationCode"]);
                    this.m_EducationName = Convert.ToString(sqlDataReader["EducationName"]);
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

        public string Get(SqlTransaction myTransaction, string EducationCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EducationCode" };
            object[] educationCode = new object[] { EducationCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_EDUCATION_Get", strArrays, educationCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EducationCode = Convert.ToString(sqlDataReader["EducationCode"]);
                    this.m_EducationName = Convert.ToString(sqlDataReader["EducationName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_EDUCATION_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@EducationCode", "@EducationName", "@Description", "@Active" };
            object[] mEducationCode = new object[] { this.m_EducationCode, this.m_EducationName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_EDUCATION_Insert", strArrays, mEducationCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@EducationCode", "@EducationName", "@Description", "@Active" };
            object[] mEducationCode = new object[] { this.m_EducationCode, this.m_EducationName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_EDUCATION_Insert", strArrays, mEducationCode);
        }

        public string Insert(string EducationCode, string EducationName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EducationCode", "@EducationName", "@Description", "@Active" };
            object[] educationCode = new object[] { EducationCode, EducationName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_EDUCATION_Insert", strArrays, educationCode);
        }

        public string Insert(SqlConnection myConnection, string EducationCode, string EducationName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EducationCode", "@EducationName", "@Description", "@Active" };
            object[] educationCode = new object[] { EducationCode, EducationName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_EDUCATION_Insert", strArrays, educationCode);
        }

        public string Insert(SqlTransaction myTransaction, string EducationCode, string EducationName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EducationCode", "@EducationName", "@Description", "@Active" };
            object[] educationCode = new object[] { EducationCode, EducationName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_EDUCATION_Insert", strArrays, educationCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_EDUCATION", "EducationCode", "HV");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@EducationCode", "@EducationName", "@Description", "@Active" };
            object[] mEducationCode = new object[] { this.m_EducationCode, this.m_EducationName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_EDUCATION_Update", strArrays, mEducationCode);
        }

        public string Update(string EducationCode, string EducationName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EducationCode", "@EducationName", "@Description", "@Active" };
            object[] educationCode = new object[] { EducationCode, EducationName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_EDUCATION_Update", strArrays, educationCode);
        }

        public string Update(SqlConnection myConnection, string EducationCode, string EducationName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EducationCode", "@EducationName", "@Description", "@Active" };
            object[] educationCode = new object[] { EducationCode, EducationName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_EDUCATION_Update", strArrays, educationCode);
        }

        public string Update(SqlTransaction myTransaction, string EducationCode, string EducationName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@EducationCode", "@EducationName", "@Description", "@Active" };
            object[] educationCode = new object[] { EducationCode, EducationName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_EDUCATION_Update", strArrays, educationCode);
        }
    }
}
