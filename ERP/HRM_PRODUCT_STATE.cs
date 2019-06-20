using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data.SqlClient;


namespace CHBK2014_N9.ERP
{
  public  class HRM_PRODUCT_STATE
    {

        private string m_ProductCode;

        private string m_StateCode;

        [Category("Column")]
        [DisplayName("ProductCode")]
        public string ProductCode
        {
            get
            {
                return this.m_ProductCode;
            }
            set
            {
                this.m_ProductCode = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_PRODUCT_STATE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        [Category("Column")]
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

        public HRM_PRODUCT_STATE()
        {
            this.m_ProductCode = "";
            this.m_StateCode = "";
        }

        public HRM_PRODUCT_STATE(string ProductCode, string StateCode)
        {
            this.m_ProductCode = ProductCode;
            this.m_StateCode = StateCode;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@ProductCode", "@StateCode" };
            object[] mProductCode = new object[] { this.m_ProductCode, this.m_StateCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_STATE_Delete", strArrays, mProductCode);
        }

        public string Delete(string ProductCode, string StateCode)
        {
            string[] strArrays = new string[] { "@ProductCode", "@StateCode" };
            object[] productCode = new object[] { ProductCode, StateCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_STATE_Delete", strArrays, productCode);
        }

        public bool Exist(string ProductCode, string StateCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ProductCode", "@StateCode" };
            object[] productCode = new object[] { ProductCode, StateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PRODUCT_STATE_Get", strArrays, productCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string ProductCode, string StateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProductCode", "@StateCode" };
            object[] productCode = new object[] { ProductCode, StateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PRODUCT_STATE_Get", strArrays, productCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProductCode = Convert.ToString(sqlDataReader["ProductCode"]);
                    this.m_StateCode = Convert.ToString(sqlDataReader["StateCode"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@ProductCode", "@StateCode" };
            object[] mProductCode = new object[] { this.m_ProductCode, this.m_StateCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_STATE_Insert", strArrays, mProductCode);
        }

        public string Insert(string ProductCode, string StateCode)
        {
            string[] strArrays = new string[] { "@ProductCode", "@StateCode" };
            object[] productCode = new object[] { ProductCode, StateCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_STATE_Insert", strArrays, productCode);
        }
    }
}
