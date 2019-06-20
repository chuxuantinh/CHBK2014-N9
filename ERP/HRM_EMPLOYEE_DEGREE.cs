using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data.SqlClient;


namespace CHBK2014_N9.ERP
{
  public  class HRM_EMPLOYEE_DEGREE
    {


        private string m_EmployeeCode;

        private string m_DegreeCode;

        [Category("Column")]
        [DisplayName("DegreeCode")]
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

        [Category("Column")]
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

        public string ProductName
        {
            get
            {
                return "Class HRM_EMPLOYEE_DEGREE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public HRM_EMPLOYEE_DEGREE()
        {
            this.m_EmployeeCode = "";
            this.m_DegreeCode = "";
        }

        public HRM_EMPLOYEE_DEGREE(string EmployeeCode, string DegreeCode)
        {
            this.m_EmployeeCode = EmployeeCode;
            this.m_DegreeCode = DegreeCode;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@DegreeCode" };
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_DegreeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_DEGREE_Delete", strArrays, mEmployeeCode);
        }

        public string Delete(string EmployeeCode, string DegreeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@DegreeCode" };
            object[] employeeCode = new object[] { EmployeeCode, DegreeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_DEGREE_Delete", strArrays, employeeCode);
        }

        public bool Exist(string EmployeeCode, string DegreeCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@EmployeeCode", "@DegreeCode" };
            object[] employeeCode = new object[] { EmployeeCode, DegreeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_EMPLOYEE_DEGREE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string EmployeeCode, string DegreeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EmployeeCode", "@DegreeCode" };
            object[] employeeCode = new object[] { EmployeeCode, DegreeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_EMPLOYEE_DEGREE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_DegreeCode = Convert.ToString(sqlDataReader["DegreeCode"]);
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
            string[] strArrays = new string[] { "@EmployeeCode", "@DegreeCode" };
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_DegreeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_DEGREE_Insert", strArrays, mEmployeeCode);
        }

        public string Insert(string EmployeeCode, string DegreeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@DegreeCode" };
            object[] employeeCode = new object[] { EmployeeCode, DegreeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_DEGREE_Insert", strArrays, employeeCode);
        }
    }
}
