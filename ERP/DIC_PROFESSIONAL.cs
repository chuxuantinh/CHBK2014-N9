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
  public  class DIC_PROFESSIONAL
    {

        private string m_ProfessionalCode;

        private string m_ProfessionalName;

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
                return "Class DIC_PROFESSIONAL";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string ProfessionalCode
        {
            get
            {
                return this.m_ProfessionalCode;
            }
            set
            {
                this.m_ProfessionalCode = value;
            }
        }

        public string ProfessionalName
        {
            get
            {
                return this.m_ProfessionalName;
            }
            set
            {
                this.m_ProfessionalName = value;
            }
        }

        public DIC_PROFESSIONAL()
        {
            this.m_ProfessionalCode = "";
            this.m_ProfessionalName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_PROFESSIONAL(string ProfessionalCode, string ProfessionalName, string Description, bool Active)
        {
            this.m_ProfessionalCode = ProfessionalCode;
            this.m_ProfessionalName = ProfessionalName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "ProfessionalName", "ProfessionalCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["ProfessionalCode"] = "All";
        //    dataRow["ProfessionalName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "ProfessionalName", "ProfessionalCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["ProfessionalName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@ProfessionalCode" };
            object[] mProfessionalCode = new object[] { this.m_ProfessionalCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROFESSIONAL_Delete", strArrays, mProfessionalCode);
        }

        public string Delete(string ProfessionalCode)
        {
            string[] strArrays = new string[] { "@ProfessionalCode" };
            object[] professionalCode = new object[] { ProfessionalCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROFESSIONAL_Delete", strArrays, professionalCode);
        }

        public string Delete(SqlConnection myConnection, string ProfessionalCode)
        {
            string[] strArrays = new string[] { "@ProfessionalCode" };
            object[] professionalCode = new object[] { ProfessionalCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_PROFESSIONAL_Delete", strArrays, professionalCode);
        }

        public string Delete(SqlTransaction myTransaction, string ProfessionalCode)
        {
            string[] strArrays = new string[] { "@ProfessionalCode" };
            object[] professionalCode = new object[] { ProfessionalCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_PROFESSIONAL_Delete", strArrays, professionalCode);
        }

        public bool Exist(string ProfessionalCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ProfessionalCode" };
            object[] professionalCode = new object[] { ProfessionalCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_PROFESSIONAL_Get", strArrays, professionalCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string ProfessionalCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProfessionalCode" };
            object[] professionalCode = new object[] { ProfessionalCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_PROFESSIONAL_Get", strArrays, professionalCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProfessionalCode = Convert.ToString(sqlDataReader["ProfessionalCode"]);
                    this.m_ProfessionalName = Convert.ToString(sqlDataReader["ProfessionalName"]);
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

        public string Get(SqlConnection myConnection, string ProfessionalCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProfessionalCode" };
            object[] professionalCode = new object[] { ProfessionalCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_PROFESSIONAL_Get", strArrays, professionalCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProfessionalCode = Convert.ToString(sqlDataReader["ProfessionalCode"]);
                    this.m_ProfessionalName = Convert.ToString(sqlDataReader["ProfessionalName"]);
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

        public string Get(SqlTransaction myTransaction, string ProfessionalCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProfessionalCode" };
            object[] professionalCode = new object[] { ProfessionalCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_PROFESSIONAL_Get", strArrays, professionalCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProfessionalCode = Convert.ToString(sqlDataReader["ProfessionalCode"]);
                    this.m_ProfessionalName = Convert.ToString(sqlDataReader["ProfessionalName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_PROFESSIONAL_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@ProfessionalCode", "@ProfessionalName", "@Description", "@Active" };
            object[] mProfessionalCode = new object[] { this.m_ProfessionalCode, this.m_ProfessionalName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROFESSIONAL_Insert", strArrays, mProfessionalCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@ProfessionalCode", "@ProfessionalName", "@Description", "@Active" };
            object[] mProfessionalCode = new object[] { this.m_ProfessionalCode, this.m_ProfessionalName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_PROFESSIONAL_Insert", strArrays, mProfessionalCode);
        }

        public string Insert(string ProfessionalCode, string ProfessionalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProfessionalCode", "@ProfessionalName", "@Description", "@Active" };
            object[] professionalCode = new object[] { ProfessionalCode, ProfessionalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROFESSIONAL_Insert", strArrays, professionalCode);
        }

        public string Insert(SqlConnection myConnection, string ProfessionalCode, string ProfessionalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProfessionalCode", "@ProfessionalName", "@Description", "@Active" };
            object[] professionalCode = new object[] { ProfessionalCode, ProfessionalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_PROFESSIONAL_Insert", strArrays, professionalCode);
        }

        public string Insert(SqlTransaction myTransaction, string ProfessionalCode, string ProfessionalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProfessionalCode", "@ProfessionalName", "@Description", "@Active" };
            object[] professionalCode = new object[] { ProfessionalCode, ProfessionalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_PROFESSIONAL_Insert", strArrays, professionalCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_PROFESSIONAL", "ProfessionalCode", "CM");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@ProfessionalCode", "@ProfessionalName", "@Description", "@Active" };
            object[] mProfessionalCode = new object[] { this.m_ProfessionalCode, this.m_ProfessionalName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROFESSIONAL_Update", strArrays, mProfessionalCode);
        }

        public string Update(string ProfessionalCode, string ProfessionalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProfessionalCode", "@ProfessionalName", "@Description", "@Active" };
            object[] professionalCode = new object[] { ProfessionalCode, ProfessionalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_PROFESSIONAL_Update", strArrays, professionalCode);
        }

        public string Update(SqlConnection myConnection, string ProfessionalCode, string ProfessionalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProfessionalCode", "@ProfessionalName", "@Description", "@Active" };
            object[] professionalCode = new object[] { ProfessionalCode, ProfessionalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_PROFESSIONAL_Update", strArrays, professionalCode);
        }

        public string Update(SqlTransaction myTransaction, string ProfessionalCode, string ProfessionalName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@ProfessionalCode", "@ProfessionalName", "@Description", "@Active" };
            object[] professionalCode = new object[] { ProfessionalCode, ProfessionalName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_PROFESSIONAL_Update", strArrays, professionalCode);
        }
    }
}
