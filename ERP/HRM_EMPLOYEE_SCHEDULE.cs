using DevExpress.XtraEditors;
using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
 public   class HRM_EMPLOYEE_SCHEDULE
    {


        private string m_EmployeeCode;

        private string m_T2;

        private string m_T3;

        private string m_T4;

        private string m_T5;

        private string m_T6;

        private string m_T7;

        private string m_CN;

        private bool m_IsAutomatic;

        public string AssemblyVersion
        {
            get
            {
                return "2.5.0.0";
            }
        }

        [Category("Column")]
        [DisplayName("CN")]
        public string CN
        {
            get
            {
                return this.m_CN;
            }
            set
            {
                this.m_CN = value;
            }
        }

        public string Copyright
        {
            get
            {
                return "Công Ty Phần Mềm Hoàn Hảo";
            }
        }

        [Category("Primary Key")]
        [DisplayName("EmployeeCode")]
        public string EmployeeCode
        {
            get
            {
                return this.m_EmployeeCode;
            }
            set
            {
                this.m_EmployeeCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsAutomatic")]
        public bool IsAutomatic
        {
            get
            {
                return this.m_IsAutomatic;
            }
            set
            {
                this.m_IsAutomatic = value;
            }
        }

        public string Product
        {
            get
            {
                return "Class HRM_EMPLOYEE_SCHEDULE";
            }
        }

        [Category("Column")]
        [DisplayName("T2")]
        public string T2
        {
            get
            {
                return this.m_T2;
            }
            set
            {
                this.m_T2 = value;
            }
        }

        [Category("Column")]
        [DisplayName("T3")]
        public string T3
        {
            get
            {
                return this.m_T3;
            }
            set
            {
                this.m_T3 = value;
            }
        }

        [Category("Column")]
        [DisplayName("T4")]
        public string T4
        {
            get
            {
                return this.m_T4;
            }
            set
            {
                this.m_T4 = value;
            }
        }

        [Category("Column")]
        [DisplayName("T5")]
        public string T5
        {
            get
            {
                return this.m_T5;
            }
            set
            {
                this.m_T5 = value;
            }
        }

        [Category("Column")]
        [DisplayName("T6")]
        public string T6
        {
            get
            {
                return this.m_T6;
            }
            set
            {
                this.m_T6 = value;
            }
        }

        [Category("Column")]
        [DisplayName("T7")]
        public string T7
        {
            get
            {
                return this.m_T7;
            }
            set
            {
                this.m_T7 = value;
            }
        }

        public HRM_EMPLOYEE_SCHEDULE()
        {
            this.m_EmployeeCode = "";
            this.m_T2 = "";
            this.m_T3 = "";
            this.m_T4 = "";
            this.m_T5 = "";
            this.m_T6 = "";
            this.m_T7 = "";
            this.m_CN = "";
            this.m_IsAutomatic = false;
        }

        public HRM_EMPLOYEE_SCHEDULE(string EmployeeCode, string T2, string T3, string T4, string T5, string T6, string T7, string CN, bool IsAutomatic)
        {
            this.m_EmployeeCode = EmployeeCode;
            this.m_T2 = T2;
            this.m_T3 = T3;
            this.m_T4 = T4;
            this.m_T5 = T5;
            this.m_T6 = T6;
            this.m_T7 = T7;
            this.m_CN = CN;
            this.m_IsAutomatic = IsAutomatic;
        }

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool Exist(string EmployeeCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_EMPLOYEE_SCHEDULE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string EmployeeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_EMPLOYEE_SCHEDULE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_T2 = Convert.ToString(sqlDataReader["T2"]);
                    this.m_T3 = Convert.ToString(sqlDataReader["T3"]);
                    this.m_T4 = Convert.ToString(sqlDataReader["T4"]);
                    this.m_T5 = Convert.ToString(sqlDataReader["T5"]);
                    this.m_T6 = Convert.ToString(sqlDataReader["T6"]);
                    this.m_T7 = Convert.ToString(sqlDataReader["T7"]);
                    this.m_CN = Convert.ToString(sqlDataReader["CN"]);
                    this.m_IsAutomatic = Convert.ToBoolean(sqlDataReader["IsAutomatic"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string EmployeeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_EMPLOYEE_SCHEDULE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_T2 = Convert.ToString(sqlDataReader["T2"]);
                    this.m_T3 = Convert.ToString(sqlDataReader["T3"]);
                    this.m_T4 = Convert.ToString(sqlDataReader["T4"]);
                    this.m_T5 = Convert.ToString(sqlDataReader["T5"]);
                    this.m_T6 = Convert.ToString(sqlDataReader["T6"]);
                    this.m_T7 = Convert.ToString(sqlDataReader["T7"]);
                    this.m_CN = Convert.ToString(sqlDataReader["CN"]);
                    this.m_IsAutomatic = Convert.ToBoolean(sqlDataReader["IsAutomatic"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string EmployeeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_EMPLOYEE_SCHEDULE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_T2 = Convert.ToString(sqlDataReader["T2"]);
                    this.m_T3 = Convert.ToString(sqlDataReader["T3"]);
                    this.m_T4 = Convert.ToString(sqlDataReader["T4"]);
                    this.m_T5 = Convert.ToString(sqlDataReader["T5"]);
                    this.m_T6 = Convert.ToString(sqlDataReader["T6"]);
                    this.m_T7 = Convert.ToString(sqlDataReader["T7"]);
                    this.m_CN = Convert.ToString(sqlDataReader["CN"]);
                    this.m_IsAutomatic = Convert.ToBoolean(sqlDataReader["IsAutomatic"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public void SetData(string EmployeeCode, string T2, string T3, string T4, string T5, string T6, string T7, string CN, bool IsAutomatic)
        {
            this.m_EmployeeCode = EmployeeCode;
            this.m_T2 = T2;
            this.m_T3 = T3;
            this.m_T4 = T4;
            this.m_T5 = T5;
            this.m_T6 = T6;
            this.m_T7 = T7;
            this.m_CN = CN;
            this.m_IsAutomatic = IsAutomatic;
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@T2", "@T3", "@T4", "@T5", "@T6", "@T7", "@CN", "@IsAutomatic" };
            string[] strArrays1 = strArrays;
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_T2, this.m_T3, this.m_T4, this.m_T5, this.m_T6, this.m_T7, this.m_CN, this.m_IsAutomatic };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_SCHEDULE_Update", strArrays1, mEmployeeCode);
        }

        public string Update(string EmployeeCode, string T2, string T3, string T4, string T5, string T6, string T7, string CN, bool IsAutomatic)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@T2", "@T3", "@T4", "@T5", "@T6", "@T7", "@CN", "@IsAutomatic" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, T2, T3, T4, T5, T6, T7, CN, IsAutomatic };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_SCHEDULE_Update", strArrays1, employeeCode);
        }
    }
}
