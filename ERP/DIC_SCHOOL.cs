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
  public  class DIC_SCHOOL
    {
        private string m_SchoolCode;

        private string m_SchoolName;

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
                return "Class DIC_SCHOOL";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string SchoolCode
        {
            get
            {
                return this.m_SchoolCode;
            }
            set
            {
                this.m_SchoolCode = value;
            }
        }

        public string SchoolName
        {
            get
            {
                return this.m_SchoolName;
            }
            set
            {
                this.m_SchoolName = value;
            }
        }

        public DIC_SCHOOL()
        {
            this.m_SchoolCode = "";
            this.m_SchoolName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_SCHOOL(string SchoolCode, string SchoolName, string Description, bool Active)
        {
            this.m_SchoolCode = SchoolCode;
            this.m_SchoolName = SchoolName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "SchoolName", "SchoolCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["SchoolCode"] = "All";
        //    dataRow["SchoolName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "SchoolName", "SchoolCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            combo.Properties.Items.Clear();
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["SchoolName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SchoolCode" };
            object[] mSchoolCode = new object[] { this.m_SchoolCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SCHOOL_Delete", strArrays, mSchoolCode);
        }

        public string Delete(string SchoolCode)
        {
            string[] strArrays = new string[] { "@SchoolCode" };
            object[] schoolCode = new object[] { SchoolCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SCHOOL_Delete", strArrays, schoolCode);
        }

        public string Delete(SqlConnection myConnection, string SchoolCode)
        {
            string[] strArrays = new string[] { "@SchoolCode" };
            object[] schoolCode = new object[] { SchoolCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SCHOOL_Delete", strArrays, schoolCode);
        }

        public string Delete(SqlTransaction myTransaction, string SchoolCode)
        {
            string[] strArrays = new string[] { "@SchoolCode" };
            object[] schoolCode = new object[] { SchoolCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SCHOOL_Delete", strArrays, schoolCode);
        }

        public bool Exist(string SchoolCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SchoolCode" };
            object[] schoolCode = new object[] { SchoolCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SCHOOL_Get", strArrays, schoolCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string SchoolCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SchoolCode" };
            object[] schoolCode = new object[] { SchoolCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SCHOOL_Get", strArrays, schoolCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SchoolCode = Convert.ToString(sqlDataReader["SchoolCode"]);
                    this.m_SchoolName = Convert.ToString(sqlDataReader["SchoolName"]);
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

        public string Get(SqlConnection myConnection, string SchoolCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SchoolCode" };
            object[] schoolCode = new object[] { SchoolCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_SCHOOL_Get", strArrays, schoolCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SchoolCode = Convert.ToString(sqlDataReader["SchoolCode"]);
                    this.m_SchoolName = Convert.ToString(sqlDataReader["SchoolName"]);
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

        public string Get(SqlTransaction myTransaction, string SchoolCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SchoolCode" };
            object[] schoolCode = new object[] { SchoolCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_SCHOOL_Get", strArrays, schoolCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SchoolCode = Convert.ToString(sqlDataReader["SchoolCode"]);
                    this.m_SchoolName = Convert.ToString(sqlDataReader["SchoolName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_SCHOOL_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SchoolCode", "@SchoolName", "@Description", "@Active" };
            object[] mSchoolCode = new object[] { this.m_SchoolCode, this.m_SchoolName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SCHOOL_Insert", strArrays, mSchoolCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SchoolCode", "@SchoolName", "@Description", "@Active" };
            object[] mSchoolCode = new object[] { this.m_SchoolCode, this.m_SchoolName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SCHOOL_Insert", strArrays, mSchoolCode);
        }

        public string Insert(string SchoolCode, string SchoolName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SchoolCode", "@SchoolName", "@Description", "@Active" };
            object[] schoolCode = new object[] { SchoolCode, SchoolName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SCHOOL_Insert", strArrays, schoolCode);
        }

        public string Insert(SqlConnection myConnection, string SchoolCode, string SchoolName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SchoolCode", "@SchoolName", "@Description", "@Active" };
            object[] schoolCode = new object[] { SchoolCode, SchoolName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SCHOOL_Insert", strArrays, schoolCode);
        }

        public string Insert(SqlTransaction myTransaction, string SchoolCode, string SchoolName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SchoolCode", "@SchoolName", "@Description", "@Active" };
            object[] schoolCode = new object[] { SchoolCode, SchoolName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SCHOOL_Insert", strArrays, schoolCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_SCHOOL", "SchoolCode", "TH");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SchoolCode", "@SchoolName", "@Description", "@Active" };
            object[] mSchoolCode = new object[] { this.m_SchoolCode, this.m_SchoolName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SCHOOL_Update", strArrays, mSchoolCode);
        }

        public string Update(string SchoolCode, string SchoolName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SchoolCode", "@SchoolName", "@Description", "@Active" };
            object[] schoolCode = new object[] { SchoolCode, SchoolName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SCHOOL_Update", strArrays, schoolCode);
        }

        public string Update(SqlConnection myConnection, string SchoolCode, string SchoolName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SchoolCode", "@SchoolName", "@Description", "@Active" };
            object[] schoolCode = new object[] { SchoolCode, SchoolName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SCHOOL_Update", strArrays, schoolCode);
        }

        public string Update(SqlTransaction myTransaction, string SchoolCode, string SchoolName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@SchoolCode", "@SchoolName", "@Description", "@Active" };
            object[] schoolCode = new object[] { SchoolCode, SchoolName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SCHOOL_Update", strArrays, schoolCode);
        }



    }
}
