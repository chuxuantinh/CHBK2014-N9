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
   public class DIC_SALARY_RANK
    {

        private string m_RankCode;

        private string m_RankName;

        private string m_Description;

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
                return "Class DIC_SALARY_RANK";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string RankCode
        {
            get
            {
                return this.m_RankCode;
            }
            set
            {
                this.m_RankCode = value;
            }
        }

        public string RankName
        {
            get
            {
                return this.m_RankName;
            }
            set
            {
                this.m_RankName = value;
            }
        }

        public DIC_SALARY_RANK()
        {
            this.m_RankCode = "";
            this.m_RankName = "";
            this.m_Description = "";
        }

        public DIC_SALARY_RANK(string RankCode, string RankName, string Description)
        {
            this.m_RankCode = RankCode;
            this.m_RankName = RankName;
            this.m_Description = Description;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "RankName", "RankCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["RankCode"] = "All";
        //    dataRow["RankName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "RankName", "RankCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["RankName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "RankName";
            gridlookup.Properties.ValueMember = "RankCode";
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@RankCode" };
            object[] mRankCode = new object[] { this.m_RankCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_RANK_Delete", strArrays, mRankCode);
        }

        public string Delete(string RankCode)
        {
            string[] strArrays = new string[] { "@RankCode" };
            object[] rankCode = new object[] { RankCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_RANK_Delete", strArrays, rankCode);
        }

        public string Delete(SqlConnection myConnection, string RankCode)
        {
            string[] strArrays = new string[] { "@RankCode" };
            object[] rankCode = new object[] { RankCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SALARY_RANK_Delete", strArrays, rankCode);
        }

        public string Delete(SqlTransaction myTransaction, string RankCode)
        {
            string[] strArrays = new string[] { "@RankCode" };
            object[] rankCode = new object[] { RankCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SALARY_RANK_Delete", strArrays, rankCode);
        }

        public bool Exist(string RankCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@RankCode" };
            object[] rankCode = new object[] { RankCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SALARY_RANK_Get", strArrays, rankCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string RankCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@RankCode" };
            object[] rankCode = new object[] { RankCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SALARY_RANK_Get", strArrays, rankCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_RankCode = Convert.ToString(sqlDataReader["RankCode"]);
                    this.m_RankName = Convert.ToString(sqlDataReader["RankName"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string RankCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@RankCode" };
            object[] rankCode = new object[] { RankCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_SALARY_RANK_Get", strArrays, rankCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_RankCode = Convert.ToString(sqlDataReader["RankCode"]);
                    this.m_RankName = Convert.ToString(sqlDataReader["RankName"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string RankCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@RankCode" };
            object[] rankCode = new object[] { RankCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_SALARY_RANK_Get", strArrays, rankCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_RankCode = Convert.ToString(sqlDataReader["RankCode"]);
                    this.m_RankName = Convert.ToString(sqlDataReader["RankName"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_SALARY_RANK_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@RankCode", "@RankName", "@Description" };
            object[] mRankCode = new object[] { this.m_RankCode, this.m_RankName, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_RANK_Insert", strArrays, mRankCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@RankCode", "@RankName", "@Description" };
            object[] mRankCode = new object[] { this.m_RankCode, this.m_RankName, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SALARY_RANK_Insert", strArrays, mRankCode);
        }

        public string Insert(string RankCode, string RankName, string Description)
        {
            string[] strArrays = new string[] { "@RankCode", "@RankName", "@Description" };
            object[] rankCode = new object[] { RankCode, RankName, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_RANK_Insert", strArrays, rankCode);
        }

        public string Insert(SqlConnection myConnection, string RankCode, string RankName, string Description)
        {
            string[] strArrays = new string[] { "@RankCode", "@RankName", "@Description" };
            object[] rankCode = new object[] { RankCode, RankName, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SALARY_RANK_Insert", strArrays, rankCode);
        }

        public string Insert(SqlTransaction myTransaction, string RankCode, string RankName, string Description)
        {
            string[] strArrays = new string[] { "@RankCode", "@RankName", "@Description" };
            object[] rankCode = new object[] { RankCode, RankName, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SALARY_RANK_Insert", strArrays, rankCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_SALARY_RANK", "RankCode", "NL");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@RankCode", "@RankName", "@Description" };
            object[] mRankCode = new object[] { this.m_RankCode, this.m_RankName, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_RANK_Update", strArrays, mRankCode);
        }

        public string Update(string RankCode, string RankName, string Description)
        {
            string[] strArrays = new string[] { "@RankCode", "@RankName", "@Description" };
            object[] rankCode = new object[] { RankCode, RankName, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_RANK_Update", strArrays, rankCode);
        }

        public string Update(SqlConnection myConnection, string RankCode, string RankName, string Description)
        {
            string[] strArrays = new string[] { "@RankCode", "@RankName", "@Description" };
            object[] rankCode = new object[] { RankCode, RankName, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SALARY_RANK_Update", strArrays, rankCode);
        }

        public string Update(SqlTransaction myTransaction, string RankCode, string RankName, string Description)
        {
            string[] strArrays = new string[] { "@RankCode", "@RankName", "@Description" };
            object[] rankCode = new object[] { RankCode, RankName, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SALARY_RANK_Update", strArrays, rankCode);
        }
    }
}
