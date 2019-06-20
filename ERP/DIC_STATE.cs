using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.Utils.Lib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
  public  class DIC_STATE
    {
        private string m_StateCode;

        private string m_StateName;

        private string m_Unit;

        private decimal m_Price;

        private string m_Description;

        [Category("Column")]
        [DisplayName("Description")]
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

        [Category("Column")]
        [DisplayName("Price")]
        public decimal Price
        {
            get
            {
                return this.m_Price;
            }
            set
            {
                this.m_Price = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_STATE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        [Category("Primary Key")]
        [DisplayName("StateCode")]
        public string StateCode
        {
            get
            {
                return this.m_StateCode;
            }
            set
            {
                this.m_StateCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("StateName")]
        public string StateName
        {
            get
            {
                return this.m_StateName;
            }
            set
            {
                this.m_StateName = value;
            }
        }

        [Category("Column")]
        [DisplayName("Unit")]
        public string Unit
        {
            get
            {
                return this.m_Unit;
            }
            set
            {
                this.m_Unit = value;
            }
        }

        public DIC_STATE()
        {
            this.m_StateCode = "";
            this.m_StateName = "";
            this.m_Unit = "";
            this.m_Price = new decimal(0);
            this.m_Description = "";
        }

        public DIC_STATE(string StateCode, string StateName, string Unit, decimal Price, string Description)
        {
            this.m_StateCode = StateCode;
            this.m_StateName = StateName;
            this.m_Unit = Unit;
            this.m_Price = Price;
            this.m_Description = Description;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "StateName", "StateCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["StateCode"] = "All";
        //    dataRow["StateName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "StateName", "StateCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["StateName"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@StateCode" };
            object[] mStateCode = new object[] { this.m_StateCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_STATE_Delete", strArrays, mStateCode);
        }

        public string Delete(string StateCode)
        {
            string[] strArrays = new string[] { "@StateCode" };
            object[] stateCode = new object[] { StateCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_STATE_Delete", strArrays, stateCode);
        }

        public string Delete(SqlConnection myConnection, string StateCode)
        {
            string[] strArrays = new string[] { "@StateCode" };
            object[] stateCode = new object[] { StateCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_STATE_Delete", strArrays, stateCode);
        }

        public string Delete(SqlTransaction myTransaction, string StateCode)
        {
            string[] strArrays = new string[] { "@StateCode" };
            object[] stateCode = new object[] { StateCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_STATE_Delete", strArrays, stateCode);
        }

        public bool Exist(string StateCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@StateCode" };
            object[] stateCode = new object[] { StateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_STATE_Get", strArrays, stateCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string StateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@StateCode" };
            object[] stateCode = new object[] { StateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_STATE_Get", strArrays, stateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_StateCode = Convert.ToString(sqlDataReader["StateCode"]);
                    this.m_StateName = Convert.ToString(sqlDataReader["StateName"]);
                    this.m_Unit = Convert.ToString(sqlDataReader["Unit"]);
                    this.m_Price = Convert.ToDecimal(sqlDataReader["Price"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string StateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@StateCode" };
            object[] stateCode = new object[] { StateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_STATE_Get", strArrays, stateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_StateCode = Convert.ToString(sqlDataReader["StateCode"]);
                    this.m_StateName = Convert.ToString(sqlDataReader["StateName"]);
                    this.m_Unit = Convert.ToString(sqlDataReader["Unit"]);
                    this.m_Price = Convert.ToDecimal(sqlDataReader["Price"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string StateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@StateCode" };
            object[] stateCode = new object[] { StateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_STATE_Get", strArrays, stateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_StateCode = Convert.ToString(sqlDataReader["StateCode"]);
                    this.m_StateName = Convert.ToString(sqlDataReader["StateName"]);
                    this.m_Unit = Convert.ToString(sqlDataReader["Unit"]);
                    this.m_Price = Convert.ToDecimal(sqlDataReader["Price"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_STATE_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@StateCode", "@StateName", "@Unit", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mStateCode = new object[] { this.m_StateCode, this.m_StateName, this.m_Unit, this.m_Price, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_STATE_Insert", strArrays1, mStateCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@StateCode", "@StateName", "@Unit", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mStateCode = new object[] { this.m_StateCode, this.m_StateName, this.m_Unit, this.m_Price, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_STATE_Insert", strArrays1, mStateCode);
        }

        public string Insert(string StateCode, string StateName, string Unit, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@StateCode", "@StateName", "@Unit", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stateCode = new object[] { StateCode, StateName, Unit, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_STATE_Insert", strArrays1, stateCode);
        }

        public string Insert(SqlConnection myConnection, string StateCode, string StateName, string Unit, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@StateCode", "@StateName", "@Unit", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stateCode = new object[] { StateCode, StateName, Unit, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_STATE_Insert", strArrays1, stateCode);
        }

        public string Insert(SqlTransaction myTransaction, string StateCode, string StateName, string Unit, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@StateCode", "@StateName", "@Unit", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stateCode = new object[] { StateCode, StateName, Unit, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_STATE_Insert", strArrays1, stateCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_STATE", "StateCode", "CD");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@StateCode", "@StateName", "@Unit", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mStateCode = new object[] { this.m_StateCode, this.m_StateName, this.m_Unit, this.m_Price, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_STATE_Update", strArrays1, mStateCode);
        }

        public string Update(string StateCode, string StateName, string Unit, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@StateCode", "@StateName", "@Unit", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stateCode = new object[] { StateCode, StateName, Unit, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_STATE_Update", strArrays1, stateCode);
        }

        public string Update(SqlConnection myConnection, string StateCode, string StateName, string Unit, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@StateCode", "@StateName", "@Unit", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stateCode = new object[] { StateCode, StateName, Unit, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_STATE_Update", strArrays1, stateCode);
        }

        public string Update(SqlTransaction myTransaction, string StateCode, string StateName, string Unit, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@StateCode", "@StateName", "@Unit", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stateCode = new object[] { StateCode, StateName, Unit, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_STATE_Update", strArrays1, stateCode);
        }

    }
}
