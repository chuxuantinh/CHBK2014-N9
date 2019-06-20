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
  public  class DIC_DEGREE
    {

        private string m_DegreeCode;

        private string m_DegreeName;

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

        public string DegreeCode
        {
            get
            {
                return this.m_DegreeCode;
            }
            set
            {
                this.m_DegreeCode = value;
            }
        }

        public string DegreeName
        {
            get
            {
                return this.m_DegreeName;
            }
            set
            {
                this.m_DegreeName = value;
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
                return "Class DIC_DEGREE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_DEGREE()
        {
            this.m_DegreeCode = "";
            this.m_DegreeName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_DEGREE(string DegreeCode, string DegreeName, string Description, bool Active)
        {
            this.m_DegreeCode = DegreeCode;
            this.m_DegreeName = DegreeName;
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
                    Description = row["DegreeName"].ToString(),
                    CheckState = CheckState.Unchecked,
                    Value = row["DegreeCode"].ToString()
                };
                checkedCombo.Properties.Items.Add(checkedListBoxItem);
            }
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "DegreeName", "DegreeCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["DegreeCode"] = "All";
        //    dataRow["DegreeName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "DegreeName", "DegreeCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["DegreeName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@DegreeCode" };
            object[] mDegreeCode = new object[] { this.m_DegreeCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_DEGREE_Delete", strArrays, mDegreeCode);
        }

        public string Delete(string DegreeCode)
        {
            string[] strArrays = new string[] { "@DegreeCode" };
            object[] degreeCode = new object[] { DegreeCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_DEGREE_Delete", strArrays, degreeCode);
        }

        public string Delete(SqlConnection myConnection, string DegreeCode)
        {
            string[] strArrays = new string[] { "@DegreeCode" };
            object[] degreeCode = new object[] { DegreeCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_DEGREE_Delete", strArrays, degreeCode);
        }

        public string Delete(SqlTransaction myTransaction, string DegreeCode)
        {
            string[] strArrays = new string[] { "@DegreeCode" };
            object[] degreeCode = new object[] { DegreeCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_DEGREE_Delete", strArrays, degreeCode);
        }

        public bool Exist(string DegreeCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@DegreeCode" };
            object[] degreeCode = new object[] { DegreeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_DEGREE_Get", strArrays, degreeCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string DegreeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@DegreeCode" };
            object[] degreeCode = new object[] { DegreeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_DEGREE_Get", strArrays, degreeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_DegreeCode = Convert.ToString(sqlDataReader["DegreeCode"]);
                    this.m_DegreeName = Convert.ToString(sqlDataReader["DegreeName"]);
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

        public string Get(SqlConnection myConnection, string DegreeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@DegreeCode" };
            object[] degreeCode = new object[] { DegreeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_DEGREE_Get", strArrays, degreeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_DegreeCode = Convert.ToString(sqlDataReader["DegreeCode"]);
                    this.m_DegreeName = Convert.ToString(sqlDataReader["DegreeName"]);
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

        public string Get(SqlTransaction myTransaction, string DegreeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@DegreeCode" };
            object[] degreeCode = new object[] { DegreeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_DEGREE_Get", strArrays, degreeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_DegreeCode = Convert.ToString(sqlDataReader["DegreeCode"]);
                    this.m_DegreeName = Convert.ToString(sqlDataReader["DegreeName"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_DEGREE_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@DegreeCode", "@DegreeName", "@Description", "@Active" };
            object[] mDegreeCode = new object[] { this.m_DegreeCode, this.m_DegreeName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_DEGREE_Insert", strArrays, mDegreeCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@DegreeCode", "@DegreeName", "@Description", "@Active" };
            object[] mDegreeCode = new object[] { this.m_DegreeCode, this.m_DegreeName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_DEGREE_Insert", strArrays, mDegreeCode);
        }

        public string Insert(string DegreeCode, string DegreeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@DegreeCode", "@DegreeName", "@Description", "@Active" };
            object[] degreeCode = new object[] { DegreeCode, DegreeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_DEGREE_Insert", strArrays, degreeCode);
        }

        public string Insert(SqlConnection myConnection, string DegreeCode, string DegreeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@DegreeCode", "@DegreeName", "@Description", "@Active" };
            object[] degreeCode = new object[] { DegreeCode, DegreeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_DEGREE_Insert", strArrays, degreeCode);
        }

        public string Insert(SqlTransaction myTransaction, string DegreeCode, string DegreeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@DegreeCode", "@DegreeName", "@Description", "@Active" };
            object[] degreeCode = new object[] { DegreeCode, DegreeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_DEGREE_Insert", strArrays, degreeCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_DEGREE", "DegreeCode", "BC");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@DegreeCode", "@DegreeName", "@Description", "@Active" };
            object[] mDegreeCode = new object[] { this.m_DegreeCode, this.m_DegreeName, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_DEGREE_Update", strArrays, mDegreeCode);
        }

        public string Update(string DegreeCode, string DegreeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@DegreeCode", "@DegreeName", "@Description", "@Active" };
            object[] degreeCode = new object[] { DegreeCode, DegreeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_DEGREE_Update", strArrays, degreeCode);
        }

        public string Update(SqlConnection myConnection, string DegreeCode, string DegreeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@DegreeCode", "@DegreeName", "@Description", "@Active" };
            object[] degreeCode = new object[] { DegreeCode, DegreeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_DEGREE_Update", strArrays, degreeCode);
        }

        public string Update(SqlTransaction myTransaction, string DegreeCode, string DegreeName, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@DegreeCode", "@DegreeName", "@Description", "@Active" };
            object[] degreeCode = new object[] { DegreeCode, DegreeName, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_DEGREE_Update", strArrays, degreeCode);
        }
    }
}
