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
  public  class DIC_RATE
    {

        private string m_RateCode;

        private string m_GroupRateCode;

        private string m_RateName;

        private double m_Coefficient;

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

        public double Coefficient
        {
            get
            {
                return this.m_Coefficient;
            }
            set
            {
                this.m_Coefficient = value;
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

        public string GroupRateCode
        {
            get
            {
                return this.m_GroupRateCode;
            }
            set
            {
                this.m_GroupRateCode = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_RATE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string RateCode
        {
            get
            {
                return this.m_RateCode;
            }
            set
            {
                this.m_RateCode = value;
            }
        }

        public string RateName
        {
            get
            {
                return this.m_RateName;
            }
            set
            {
                this.m_RateName = value;
            }
        }

        public DIC_RATE()
        {
            this.m_RateCode = "";
            this.m_GroupRateCode = "";
            this.m_RateName = "";
            this.m_Coefficient = 0;
            this.m_Description = "";
            this.m_Active = true;
        }

        public DIC_RATE(string RateCode, string GroupRateCode, string RateName, double Coefficient, string Description, bool Active)
        {
            this.m_RateCode = RateCode;
            this.m_GroupRateCode = GroupRateCode;
            this.m_RateName = RateName;
            this.m_Coefficient = Coefficient;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "RateName", "RateCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["RateCode"] = "All";
        //    dataRow["RateName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "RateName", "RateCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["RateName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@RateCode" };
            object[] mRateCode = new object[] { this.m_RateCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RATE_Delete", strArrays, mRateCode);
        }

        public string Delete(string RateCode)
        {
            string[] strArrays = new string[] { "@RateCode" };
            object[] rateCode = new object[] { RateCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RATE_Delete", strArrays, rateCode);
        }

        public string Delete(SqlConnection myConnection, string RateCode)
        {
            string[] strArrays = new string[] { "@RateCode" };
            object[] rateCode = new object[] { RateCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_RATE_Delete", strArrays, rateCode);
        }

        public string Delete(SqlTransaction myTransaction, string RateCode)
        {
            string[] strArrays = new string[] { "@RateCode" };
            object[] rateCode = new object[] { RateCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RATE_Delete", strArrays, rateCode);
        }

        public bool Exist(string RateCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@RateCode" };
            object[] rateCode = new object[] { RateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_RATE_Get", strArrays, rateCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string RateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@RateCode" };
            object[] rateCode = new object[] { RateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_RATE_Get", strArrays, rateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_RateCode = Convert.ToString(sqlDataReader["RateCode"]);
                    this.m_GroupRateCode = Convert.ToString(sqlDataReader["GroupRateCode"]);
                    this.m_RateName = Convert.ToString(sqlDataReader["RateName"]);
                    this.m_Coefficient = Convert.ToDouble(sqlDataReader["Coefficient"]);
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

        public string Get(SqlConnection myConnection, string RateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@RateCode" };
            object[] rateCode = new object[] { RateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_RATE_Get", strArrays, rateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_RateCode = Convert.ToString(sqlDataReader["RateCode"]);
                    this.m_GroupRateCode = Convert.ToString(sqlDataReader["GroupRateCode"]);
                    this.m_RateName = Convert.ToString(sqlDataReader["RateName"]);
                    this.m_Coefficient = Convert.ToDouble(sqlDataReader["Coefficient"]);
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

        public string Get(SqlTransaction myTransaction, string RateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@RateCode" };
            object[] rateCode = new object[] { RateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_RATE_Get", strArrays, rateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_RateCode = Convert.ToString(sqlDataReader["RateCode"]);
                    this.m_GroupRateCode = Convert.ToString(sqlDataReader["GroupRateCode"]);
                    this.m_RateName = Convert.ToString(sqlDataReader["RateName"]);
                    this.m_Coefficient = Convert.ToDouble(sqlDataReader["Coefficient"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_RATE_GetList");
        }

        public DataTable GetListByCode(string GroupRateCode)
        {
            string[] strArrays = new string[] { "@GroupRateCode" };
            object[] groupRateCode = new object[] { GroupRateCode };
            return (new SqlHelper()).ExecuteDataTable("DIC_RATE_GetListByCode", strArrays, groupRateCode);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@RateCode", "@GroupRateCode", "@RateName", "@Coefficient", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mRateCode = new object[] { this.m_RateCode, this.m_GroupRateCode, this.m_RateName, this.m_Coefficient, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RATE_Insert", strArrays1, mRateCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@RateCode", "@GroupRateCode", "@RateName", "@Coefficient", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mRateCode = new object[] { this.m_RateCode, this.m_GroupRateCode, this.m_RateName, this.m_Coefficient, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RATE_Insert", strArrays1, mRateCode);
        }

        public string Insert(string RateCode, string GroupRateCode, string RateName, double Coefficient, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RateCode", "@GroupRateCode", "@RateName", "@Coefficient", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] rateCode = new object[] { RateCode, GroupRateCode, RateName, Coefficient, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RATE_Insert", strArrays1, rateCode);
        }

        public string Insert(SqlConnection myConnection, string RateCode, string GroupRateCode, string RateName, double Coefficient, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RateCode", "@GroupRateCode", "@RateName", "@Coefficient", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] rateCode = new object[] { RateCode, GroupRateCode, RateName, Coefficient, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_RATE_Insert", strArrays1, rateCode);
        }

        public string Insert(SqlTransaction myTransaction, string RateCode, string GroupRateCode, string RateName, double Coefficient, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RateCode", "@GroupRateCode", "@RateName", "@Coefficient", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] rateCode = new object[] { RateCode, GroupRateCode, RateName, Coefficient, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RATE_Insert", strArrays1, rateCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_RATE", "RateCode", "DG");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@RateCode", "@GroupRateCode", "@RateName", "@Coefficient", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] mRateCode = new object[] { this.m_RateCode, this.m_GroupRateCode, this.m_RateName, this.m_Coefficient, this.m_Description, this.m_Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RATE_Update", strArrays1, mRateCode);
        }

        public string Update(string RateCode, string GroupRateCode, string RateName, double Coefficient, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RateCode", "@GroupRateCode", "@RateName", "@Coefficient", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] rateCode = new object[] { RateCode, GroupRateCode, RateName, Coefficient, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery("DIC_RATE_Update", strArrays1, rateCode);
        }

        public string Update(SqlConnection myConnection, string RateCode, string GroupRateCode, string RateName, double Coefficient, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RateCode", "@GroupRateCode", "@RateName", "@Coefficient", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] rateCode = new object[] { RateCode, GroupRateCode, RateName, Coefficient, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_RATE_Update", strArrays1, rateCode);
        }

        public string Update(SqlTransaction myTransaction, string RateCode, string GroupRateCode, string RateName, double Coefficient, string Description, bool Active)
        {
            string[] strArrays = new string[] { "@RateCode", "@GroupRateCode", "@RateName", "@Coefficient", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            object[] rateCode = new object[] { RateCode, GroupRateCode, RateName, Coefficient, Description, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_RATE_Update", strArrays1, rateCode);
        }
    }
}
