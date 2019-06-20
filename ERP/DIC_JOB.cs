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
public    class DIC_JOB
    {

        private string m_JobCode;

        private string m_JobName;

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

        public string JobCode
        {
            get
            {
                return this.m_JobCode;
            }
            set
            {
                this.m_JobCode = value;
            }
        }

        public string JobName
        {
            get
            {
                return this.m_JobName;
            }
            set
            {
                this.m_JobName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_JOB";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_JOB()
        {
            this.m_JobCode = "";
            this.m_JobName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_JOB(string JobCode, string JobName, string Description, bool Active)
        {
            this.m_JobCode = JobCode;
            this.m_JobName = JobName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "JobName", "JobCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["JobCode"] = "All";
        //    dataRow["JobName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "JobName", "JobCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["JobName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@JobCode" };
            object[] mJobCode = new object[] { this.m_JobCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_JOB_Delete", strArrays, mJobCode);
        }

        public string Delete(string JobCode)
        {
            string[] strArrays = new string[] { "@JobCode" };
            object[] jobCode = new object[] { JobCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_JOB_Delete", strArrays, jobCode);
        }

        public string Delete(SqlConnection myConnection, string JobCode)
        {
            string[] strArrays = new string[] { "@JobCode" };
            object[] jobCode = new object[] { JobCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_JOB_Delete", strArrays, jobCode);
        }

        public string Delete(SqlTransaction myTransaction, string JobCode)
        {
            string[] strArrays = new string[] { "@JobCode" };
            object[] jobCode = new object[] { JobCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_JOB_Delete", strArrays, jobCode);
        }

        public bool Exist(string JobCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@JobCode" };
            object[] jobCode = new object[] { JobCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_JOB_Get", strArrays, jobCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string JobCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@JobCode" };
            object[] jobCode = new object[] { JobCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_JOB_Get", strArrays, jobCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_JobCode = Convert.ToString(sqlDataReader["JobCode"]);
                    this.m_JobName = Convert.ToString(sqlDataReader["JobName"]);
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

        public string Get(SqlConnection myConnection, string JobCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@JobCode" };
            object[] jobCode = new object[] { JobCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_JOB_Get", strArrays, jobCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_JobCode = Convert.ToString(sqlDataReader["JobCode"]);
                    this.m_JobName = Convert.ToString(sqlDataReader["JobName"]);
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

        public string Get(SqlTransaction myTransaction, string JobCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@JobCode" };
            object[] jobCode = new object[] { JobCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_JOB_Get", strArrays, jobCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_JobCode = Convert.ToString(sqlDataReader["JobCode"]);
                    this.m_JobName = Convert.ToString(sqlDataReader["JobName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_JOB_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@JobCode", "@JobName", "@Description", "@Active" };
            object[] mJobCode = new object[] { this.m_JobCode, this.m_JobName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_JOB_Insert", strArrays, mJobCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@JobCode", "@JobName", "@Description", "@Active" };
            object[] mJobCode = new object[] { this.m_JobCode, this.m_JobName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_JOB_Insert", strArrays, mJobCode);
        }

        public string Insert(string JobCode, string JobName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@JobCode", "@JobName", "@Description", "@Active" };
            object[] jobCode = new object[] { JobCode, JobName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_JOB_Insert", strArrays, jobCode);
        }

        public string Insert(SqlConnection myConnection, string JobCode, string JobName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@JobCode", "@JobName", "@Description", "@Active" };
            object[] jobCode = new object[] { JobCode, JobName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_JOB_Insert", strArrays, jobCode);
        }

        public string Insert(SqlTransaction myTransaction, string JobCode, string JobName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@JobCode", "@JobName", "@Description", "@Active" };
            object[] jobCode = new object[] { JobCode, JobName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_JOB_Insert", strArrays, jobCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_JOB", "JobCode", "CV");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@JobCode", "@JobName", "@Description", "@Active" };
            object[] mJobCode = new object[] { this.m_JobCode, this.m_JobName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_JOB_Update", strArrays, mJobCode);
        }

        public string Update(string JobCode, string JobName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@JobCode", "@JobName", "@Description", "@Active" };
            object[] jobCode = new object[] { JobCode, JobName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_JOB_Update", strArrays, jobCode);
        }

        public string Update(SqlConnection myConnection, string JobCode, string JobName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@JobCode", "@JobName", "@Description", "@Active" };
            object[] jobCode = new object[] { JobCode, JobName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_JOB_Update", strArrays, jobCode);
        }

        public string Update(SqlTransaction myTransaction, string JobCode, string JobName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@JobCode", "@JobName", "@Description", "@Active" };
            object[] jobCode = new object[] { JobCode, JobName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_JOB_Update", strArrays, jobCode);
        }
    }
}
