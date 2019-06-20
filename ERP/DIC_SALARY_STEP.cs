using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Microsoft.VisualBasic;
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
  public  class DIC_SALARY_STEP
    {
        private int m_StepCode;

        private string m_RankCode;

        private string m_StepName;

        private double m_Coefficient;

        private string m_Description;

        [Category("Column")]
        [DisplayName("Coefficient")]
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

        public string ProductName
        {
            get
            {
                return "Class DIC_SALARY_STEP";
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
        [DisplayName("RankCode")]
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

        [Category("Primary Key")]
        [DisplayName("StepCode")]
        public int StepCode
        {
            get
            {
                return this.m_StepCode;
            }
            set
            {
                this.m_StepCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("StepName")]
        public string StepName
        {
            get
            {
                return this.m_StepName;
            }
            set
            {
                this.m_StepName = value;
            }
        }

        public DIC_SALARY_STEP()
        {
            this.m_StepCode = 0;
            this.m_RankCode = "";
            this.m_StepName = "";
            this.m_Coefficient = 0;
            this.m_Description = "";
        }

        public DIC_SALARY_STEP(int StepCode, string RankCode, string StepName, double Coefficient, string Description)
        {
            this.m_StepCode = StepCode;
            this.m_RankCode = RankCode;
            this.m_StepName = StepName;
            this.m_Coefficient = Coefficient;
            this.m_Description = Description;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "StepName", "StepCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["StepCode"] = "All";
        //    dataRow["StepName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "StepName", "StepCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["StepName"]);
            }
        }

        public void AddComboEditByRank(ComboBoxEdit combo, string RankCode)
        {
            combo.Properties.Items.Clear();
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetListByRank(RankCode).Rows)
            {
                combo.Properties.Items.Add(row["StepCode"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@StepCode" };
            object[] mStepCode = new object[] { this.m_StepCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_STEP_Delete", strArrays, mStepCode);
        }

        public string Delete(string StepCode)
        {
            string[] strArrays = new string[] { "@StepCode" };
            object[] stepCode = new object[] { StepCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_STEP_Delete", strArrays, stepCode);
        }

        public string Delete(SqlConnection myConnection, string StepCode)
        {
            string[] strArrays = new string[] { "@StepCode" };
            object[] stepCode = new object[] { StepCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SALARY_STEP_Delete", strArrays, stepCode);
        }

        public string Delete(SqlTransaction myTransaction, string StepCode)
        {
            string[] strArrays = new string[] { "@StepCode" };
            object[] stepCode = new object[] { StepCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SALARY_STEP_Delete", strArrays, stepCode);
        }

        public bool Exist(string StepCode, string RankCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@StepCode", "@RankCode" };
            object[] stepCode = new object[] { StepCode, RankCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SALARY_STEP_Get", strArrays, stepCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string StepCode, string RankCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@StepCode", "@RankCode" };
            object[] stepCode = new object[] { StepCode, RankCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SALARY_STEP_Get", strArrays, stepCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_StepCode = Convert.ToInt32(sqlDataReader["StepCode"]);
                    this.m_RankCode = Convert.ToString(sqlDataReader["RankCode"]);
                    this.m_StepName = Convert.ToString(sqlDataReader["StepName"]);
                    this.m_Coefficient = Convert.ToDouble(sqlDataReader["Coefficient"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string StepCode, string RankCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@StepCode", "@RankCode" };
            object[] stepCode = new object[] { StepCode, RankCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_SALARY_STEP_Get", strArrays, stepCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_StepCode = Convert.ToInt32(sqlDataReader["StepCode"]);
                    this.m_RankCode = Convert.ToString(sqlDataReader["RankCode"]);
                    this.m_StepName = Convert.ToString(sqlDataReader["StepName"]);
                    this.m_Coefficient = Convert.ToDouble(sqlDataReader["Coefficient"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string StepCode, string RankCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@StepCode", "@RankCode" };
            object[] stepCode = new object[] { StepCode, RankCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_SALARY_STEP_Get", strArrays, stepCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_StepCode = Convert.ToInt32(sqlDataReader["StepCode"]);
                    this.m_RankCode = Convert.ToString(sqlDataReader["RankCode"]);
                    this.m_StepName = Convert.ToString(sqlDataReader["StepName"]);
                    this.m_Coefficient = Convert.ToDouble(sqlDataReader["Coefficient"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_SALARY_STEP_GetList");
        }

        public DataTable GetListByRank(string RankCode)
        {
            string[] strArrays = new string[] { "@RankCode" };
            object[] rankCode = new object[] { RankCode };
            return (new SqlHelper()).ExecuteDataTable("DIC_SALARY_STEP_GetListByRank", strArrays, rankCode);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@StepCode", "@RankCode", "@StepName", "@Coefficient", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mStepCode = new object[] { this.m_StepCode, this.m_RankCode, this.m_StepName, this.m_Coefficient, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_STEP_Insert", strArrays1, mStepCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@StepCode", "@RankCode", "@StepName", "@Coefficient", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mStepCode = new object[] { this.m_StepCode, this.m_RankCode, this.m_StepName, this.m_Coefficient, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SALARY_STEP_Insert", strArrays1, mStepCode);
        }

        public string Insert(string StepCode, string StepName, string Description)
        {
            string[] strArrays = new string[] { "@StepCode", "@RankCode", "@StepName", "@Coefficient", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stepCode = new object[] { StepCode, this.RankCode, StepName, this.Coefficient, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_STEP_Insert", strArrays1, stepCode);
        }

        public string Insert(SqlConnection myConnection, string StepCode, string StepName, string Description)
        {
            string[] strArrays = new string[] { "@StepCode", "@RankCode", "@StepName", "@Coefficient", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stepCode = new object[] { StepCode, this.RankCode, StepName, this.Coefficient, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SALARY_STEP_Insert", strArrays1, stepCode);
        }

        public string Insert(SqlTransaction myTransaction, string StepCode, string StepName, string Description)
        {
            string[] strArrays = new string[] { "@StepCode", "@RankCode", "@StepName", "@Coefficient", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stepCode = new object[] { StepCode, this.RankCode, StepName, this.Coefficient, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SALARY_STEP_Insert", strArrays1, stepCode);
        }

        public string NewID()
        {
            return this.NewID("DIC_SALARY_STEP", "StepCode", "RankCode", this.m_RankCode);
        }

        public string NewID(string RankCode)
        {
            return this.NewID("DIC_SALARY_STEP", "StepCode", "RankCode", RankCode);
        }

        public string NewID(string tableName, string primaryColumn, string foreignColumn, string fKey)
        {
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            string str = "";
            string[] strArrays = new string[] { "select max([", primaryColumn, "]) from [", tableName, "] where [", foreignColumn, "] = N'", fKey, "'" };
            object obj = sqlHelper.ExecuteScalar(string.Concat(strArrays));
            str = (obj == null ? "0" : obj.ToString());
            if (fKey.Length != 0)
            {
                str = str.Replace(fKey, "").Trim();
            }
            int num = 0;
            if (SqlHelper.IsNumeric(str))
            {
                num = (int)Conversion.Val(str);
            }
            num++;
            string str1 = num.ToString();
            while (str1.Length < 6)
            {
                str1 = string.Concat("0", str1);
            }
            return str1;
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@StepCode", "@RankCode", "@StepName", "@Coefficient", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mStepCode = new object[] { this.m_StepCode, this.m_RankCode, this.m_StepName, this.m_Coefficient, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_STEP_Update", strArrays1, mStepCode);
        }

        public string Update(string StepCode, string StepName, string Description)
        {
            string[] strArrays = new string[] { "@StepCode", "@RankCode", "@StepName", "@Coefficient", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stepCode = new object[] { StepCode, this.RankCode, StepName, this.Coefficient, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_STEP_Update", strArrays1, stepCode);
        }

        public string Update(SqlConnection myConnection, string StepCode, string StepName, string Description)
        {
            string[] strArrays = new string[] { "@StepCode", "@RankCode", "@StepName", "@Coefficient", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stepCode = new object[] { StepCode, this.RankCode, StepName, this.Coefficient, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SALARY_STEP_Update", strArrays1, stepCode);
        }

        public string Update(SqlTransaction myTransaction, string StepCode, string StepName, string Description)
        {
            string[] strArrays = new string[] { "@StepCode", "@RankCode", "@StepName", "@Coefficient", "@Description" };
            string[] strArrays1 = strArrays;
            object[] stepCode = new object[] { StepCode, this.RankCode, StepName, this.Coefficient, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SALARY_STEP_Update", strArrays1, stepCode);
        }
    }
}
