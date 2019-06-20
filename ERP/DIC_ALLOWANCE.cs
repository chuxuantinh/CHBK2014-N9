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
   public class DIC_ALLOWANCE
    {

        private string m_AllowanceCode;

        private string m_AllowanceName;

        private decimal m_MaximumMoney;

        private bool m_IsByWorkDay;

        private double m_IncomeTaxValue;

        private bool m_IsShowInSalaryTableList;

        private string m_Description;

        [Category("Primary Key")]
        [DisplayName("AllowanceCode")]
        public string AllowanceCode
        {
            get
            {
                return this.m_AllowanceCode;
            }
            set
            {
                this.m_AllowanceCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("AllowanceName")]
        public string AllowanceName
        {
            get
            {
                return this.m_AllowanceName;
            }
            set
            {
                this.m_AllowanceName = value;
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

        [Category("Column")]
        [DisplayName("IncomeTaxValue")]
        public double IncomeTaxValue
        {
            get
            {
                return this.m_IncomeTaxValue;
            }
            set
            {
                this.m_IncomeTaxValue = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsByWorkDay")]
        public bool IsByWorkDay
        {
            get
            {
                return this.m_IsByWorkDay;
            }
            set
            {
                this.m_IsByWorkDay = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsShowInSalaryTableList")]
        public bool IsShowInSalaryTableList
        {
            get
            {
                return this.m_IsShowInSalaryTableList;
            }
            set
            {
                this.m_IsShowInSalaryTableList = value;
            }
        }

        [Category("Column")]
        [DisplayName("MaximumMoney")]
        public decimal MaximumMoney
        {
            get
            {
                return this.m_MaximumMoney;
            }
            set
            {
                this.m_MaximumMoney = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_ALLOWANCE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_ALLOWANCE()
        {
            this.m_AllowanceCode = "";
            this.m_AllowanceName = "";
            this.m_MaximumMoney = new decimal(0);
            this.m_IsByWorkDay = false;
            this.m_IncomeTaxValue = 0;
            this.m_IsShowInSalaryTableList = false;
            this.m_Description = "";
        }

        public DIC_ALLOWANCE(string AllowanceCode, string AllowanceName, decimal MaximumMoney, bool IsByWorkDay, double IncomeTaxValue, bool IsShowInSalaryTableList, string Description)
        {
            this.m_AllowanceCode = AllowanceCode;
            this.m_AllowanceName = AllowanceName;
            this.m_MaximumMoney = MaximumMoney;
            this.m_IsByWorkDay = IsByWorkDay;
            this.m_IncomeTaxValue = IncomeTaxValue;
            this.m_IsShowInSalaryTableList = IsShowInSalaryTableList;
            this.m_Description = Description;
        }

        //public void AddCombo(System.Windows.Forms.ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "AllowanceName", "AllowanceCode");
        //}

        //public void AddComboAll(System.Windows.Forms.ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["AllowanceCode"] = "All";
        //    dataRow["AllowanceName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "AllowanceName", "AllowanceCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["AllowanceName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "AllowanceName";
            gridlookup.Properties.ValueMember = "AllowanceCode";
        }

        public void AddRepositoryGridLookupEdit(RepositoryItemGridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            gridlookup.DataSource = this.GetList();
            gridlookup.DisplayMember = "AllowanceCode";
            gridlookup.ValueMember = "AllowanceCode";
        }

        public void AddRepositoryGridLookupEdit1(RepositoryItemGridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            gridlookup.DataSource = this.GetList();
            gridlookup.DisplayMember = "AllowanceName";
            gridlookup.ValueMember = "AllowanceCode";
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@AllowanceCode" };
            object[] mAllowanceCode = new object[] { this.m_AllowanceCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ALLOWANCE_Delete", strArrays, mAllowanceCode);
        }

        public string Delete(string AllowanceCode)
        {
            string[] strArrays = new string[] { "@AllowanceCode" };
            object[] allowanceCode = new object[] { AllowanceCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ALLOWANCE_Delete", strArrays, allowanceCode);
        }

        public string Delete(SqlConnection myConnection, string AllowanceCode)
        {
            string[] strArrays = new string[] { "@AllowanceCode" };
            object[] allowanceCode = new object[] { AllowanceCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_ALLOWANCE_Delete", strArrays, allowanceCode);
        }

        public string Delete(SqlTransaction myTransaction, string AllowanceCode)
        {
            string[] strArrays = new string[] { "@AllowanceCode" };
            object[] allowanceCode = new object[] { AllowanceCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_ALLOWANCE_Delete", strArrays, allowanceCode);
        }

        public bool Exist(string AllowanceCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@AllowanceCode" };
            object[] allowanceCode = new object[] { AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_ALLOWANCE_Get", strArrays, allowanceCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string AllowanceCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            object item2;
            string str = "";
            string[] strArrays = new string[] { "@AllowanceCode" };
            object[] allowanceCode = new object[] { AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_ALLOWANCE_Get", strArrays, allowanceCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader["AllowanceCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["AllowanceCode"];
                    }
                    this.m_AllowanceCode = Convert.ToString(item);
                    if (sqlDataReader["AllowanceName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["AllowanceName"];
                    }
                    this.m_AllowanceName = Convert.ToString(obj);
                    this.m_MaximumMoney = Convert.ToDecimal((sqlDataReader["MaximumMoney"] == DBNull.Value ? 0 : sqlDataReader["MaximumMoney"]));
                    if (sqlDataReader["IsByWorkDay"] == DBNull.Value)
                    {
                        item1 = true;
                    }
                    else
                    {
                        item1 = sqlDataReader["IsByWorkDay"];
                    }
                    this.m_IsByWorkDay = Convert.ToBoolean(item1);
                    this.m_IncomeTaxValue = Convert.ToDouble((sqlDataReader["IncomeTaxValue"] == DBNull.Value ? 0 : sqlDataReader["IncomeTaxValue"]));
                    if (sqlDataReader["IsShowInSalaryTableList"] == DBNull.Value)
                    {
                        obj1 = true;
                    }
                    else
                    {
                        obj1 = sqlDataReader["IsShowInSalaryTableList"];
                    }
                    this.m_IsShowInSalaryTableList = Convert.ToBoolean(obj1);
                    if (sqlDataReader["Description"] == DBNull.Value)
                    {
                        item2 = "";
                    }
                    else
                    {
                        item2 = sqlDataReader["Description"];
                    }
                    this.m_Description = Convert.ToString(item2);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string AllowanceCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            object item2;
            string str = "";
            string[] strArrays = new string[] { "@AllowanceCode" };
            object[] allowanceCode = new object[] { AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_ALLOWANCE_Get", strArrays, allowanceCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader["AllowanceCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["AllowanceCode"];
                    }
                    this.m_AllowanceCode = Convert.ToString(item);
                    if (sqlDataReader["AllowanceName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["AllowanceName"];
                    }
                    this.m_AllowanceName = Convert.ToString(obj);
                    this.m_MaximumMoney = Convert.ToDecimal((sqlDataReader["MaximumMoney"] == DBNull.Value ? 0 : sqlDataReader["MaximumMoney"]));
                    if (sqlDataReader["IsByWorkDay"] == DBNull.Value)
                    {
                        item1 = true;
                    }
                    else
                    {
                        item1 = sqlDataReader["IsByWorkDay"];
                    }
                    this.m_IsByWorkDay = Convert.ToBoolean(item1);
                    this.m_IncomeTaxValue = Convert.ToDouble((sqlDataReader["IncomeTaxValue"] == DBNull.Value ? 0 : sqlDataReader["IncomeTaxValue"]));
                    if (sqlDataReader["IsShowInSalaryTableList"] == DBNull.Value)
                    {
                        obj1 = true;
                    }
                    else
                    {
                        obj1 = sqlDataReader["IsShowInSalaryTableList"];
                    }
                    this.m_IsShowInSalaryTableList = Convert.ToBoolean(obj1);
                    if (sqlDataReader["Description"] == DBNull.Value)
                    {
                        item2 = "";
                    }
                    else
                    {
                        item2 = sqlDataReader["Description"];
                    }
                    this.m_Description = Convert.ToString(item2);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string AllowanceCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            object item2;
            string str = "";
            string[] strArrays = new string[] { "@AllowanceCode" };
            object[] allowanceCode = new object[] { AllowanceCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_ALLOWANCE_Get", strArrays, allowanceCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader["AllowanceCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["AllowanceCode"];
                    }
                    this.m_AllowanceCode = Convert.ToString(item);
                    if (sqlDataReader["AllowanceName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["AllowanceName"];
                    }
                    this.m_AllowanceName = Convert.ToString(obj);
                    this.m_MaximumMoney = Convert.ToDecimal((sqlDataReader["MaximumMoney"] == DBNull.Value ? 0 : sqlDataReader["MaximumMoney"]));
                    if (sqlDataReader["IsByWorkDay"] == DBNull.Value)
                    {
                        item1 = true;
                    }
                    else
                    {
                        item1 = sqlDataReader["IsByWorkDay"];
                    }
                    this.m_IsByWorkDay = Convert.ToBoolean(item1);
                    this.m_IncomeTaxValue = Convert.ToDouble((sqlDataReader["IncomeTaxValue"] == DBNull.Value ? 0 : sqlDataReader["IncomeTaxValue"]));
                    if (sqlDataReader["IsShowInSalaryTableList"] == DBNull.Value)
                    {
                        obj1 = true;
                    }
                    else
                    {
                        obj1 = sqlDataReader["IsShowInSalaryTableList"];
                    }
                    this.m_IsShowInSalaryTableList = Convert.ToBoolean(obj1);
                    if (sqlDataReader["Description"] == DBNull.Value)
                    {
                        item2 = "";
                    }
                    else
                    {
                        item2 = sqlDataReader["Description"];
                    }
                    this.m_Description = Convert.ToString(item2);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_ALLOWANCE_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@AllowanceCode", "@AllowanceName", "@MaximumMoney", "@IsByWorkDay", "@IncomeTaxValue", "@IsShowInSalaryTableList", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mAllowanceCode = new object[] { this.m_AllowanceCode, this.m_AllowanceName, this.m_MaximumMoney, this.m_IsByWorkDay, this.m_IncomeTaxValue, this.m_IsShowInSalaryTableList, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ALLOWANCE_Insert", strArrays1, mAllowanceCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@AllowanceCode", "@AllowanceName", "@MaximumMoney", "@IsByWorkDay", "@IncomeTaxValue", "@IsShowInSalaryTableList", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mAllowanceCode = new object[] { this.m_AllowanceCode, this.m_AllowanceName, this.m_MaximumMoney, this.m_IsByWorkDay, this.m_IncomeTaxValue, this.m_IsShowInSalaryTableList, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_ALLOWANCE_Insert", strArrays1, mAllowanceCode);
        }

        public string Insert(string AllowanceCode, string AllowanceName, decimal MaximumMoney, bool IsByWorkDay, double IncomeTaxValue, bool IsShowInSalaryTableList, string Description)
        {
            string[] strArrays = new string[] { "@AllowanceCode", "@AllowanceName", "@MaximumMoney", "@IsByWorkDay", "@IncomeTaxValue", "@IsShowInSalaryTableList", "@Description" };
            string[] strArrays1 = strArrays;
            object[] allowanceCode = new object[] { AllowanceCode, AllowanceName, MaximumMoney, IsByWorkDay, IncomeTaxValue, IsShowInSalaryTableList, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ALLOWANCE_Insert", strArrays1, allowanceCode);
        }

        public string Insert(SqlConnection myConnection, string AllowanceCode, string AllowanceName, decimal MaximumMoney, bool IsByWorkDay, double IncomeTaxValue, bool IsShowInSalaryTableList, string Description)
        {
            string[] strArrays = new string[] { "@AllowanceCode", "@AllowanceName", "@MaximumMoney", "@IsByWorkDay", "@IncomeTaxValue", "@IsShowInSalaryTableList", "@Description" };
            string[] strArrays1 = strArrays;
            object[] allowanceCode = new object[] { AllowanceCode, AllowanceName, MaximumMoney, IsByWorkDay, IncomeTaxValue, IsShowInSalaryTableList, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_ALLOWANCE_Insert", strArrays1, allowanceCode);
        }

        public string Insert(SqlTransaction myTransaction, string AllowanceCode, string AllowanceName, decimal MaximumMoney, bool IsByWorkDay, double IncomeTaxValue, bool IsShowInSalaryTableList, string Description)
        {
            string[] strArrays = new string[] { "@AllowanceCode", "@AllowanceName", "@MaximumMoney", "@IsByWorkDay", "@IncomeTaxValue", "@IsShowInSalaryTableList", "@Description" };
            string[] strArrays1 = strArrays;
            object[] allowanceCode = new object[] { AllowanceCode, AllowanceName, MaximumMoney, IsByWorkDay, IncomeTaxValue, IsShowInSalaryTableList, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_ALLOWANCE_Insert", strArrays1, allowanceCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_ALLOWANCE", "AllowanceCode", "PC");
        }

        public void SetData(string AllowanceCode, string AllowanceName, decimal MaximumMoney, bool IsByWorkDay, double IncomeTaxValue, bool IsShowInSalaryTableList, string Description)
        {
            this.m_AllowanceCode = AllowanceCode;
            this.m_AllowanceName = AllowanceName;
            this.m_MaximumMoney = MaximumMoney;
            this.m_IsByWorkDay = IsByWorkDay;
            this.m_IncomeTaxValue = IncomeTaxValue;
            this.m_IsShowInSalaryTableList = IsShowInSalaryTableList;
            this.m_Description = Description;
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@AllowanceCode", "@AllowanceName", "@MaximumMoney", "@IsByWorkDay", "@IncomeTaxValue", "@IsShowInSalaryTableList", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mAllowanceCode = new object[] { this.m_AllowanceCode, this.m_AllowanceName, this.m_MaximumMoney, this.m_IsByWorkDay, this.m_IncomeTaxValue, this.m_IsShowInSalaryTableList, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ALLOWANCE_Update", strArrays1, mAllowanceCode);
        }

        public string Update(string AllowanceCode, string AllowanceName, decimal MaximumMoney, bool IsByWorkDay, double IncomeTaxValue, bool IsShowInSalaryTableList, string Description)
        {
            string[] strArrays = new string[] { "@AllowanceCode", "@AllowanceName", "@MaximumMoney", "@IsByWorkDay", "@IncomeTaxValue", "@IsShowInSalaryTableList", "@Description" };
            string[] strArrays1 = strArrays;
            object[] allowanceCode = new object[] { AllowanceCode, AllowanceName, MaximumMoney, IsByWorkDay, IncomeTaxValue, IsShowInSalaryTableList, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_ALLOWANCE_Update", strArrays1, allowanceCode);
        }

        public string Update(SqlConnection myConnection, string AllowanceCode, string AllowanceName, decimal MaximumMoney, bool IsByWorkDay, double IncomeTaxValue, bool IsShowInSalaryTableList, string Description)
        {
            string[] strArrays = new string[] { "@AllowanceCode", "@AllowanceName", "@MaximumMoney", "@IsByWorkDay", "@IncomeTaxValue", "@IsShowInSalaryTableList", "@Description" };
            string[] strArrays1 = strArrays;
            object[] allowanceCode = new object[] { AllowanceCode, AllowanceName, MaximumMoney, IsByWorkDay, IncomeTaxValue, IsShowInSalaryTableList, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_ALLOWANCE_Update", strArrays1, allowanceCode);
        }

        public string Update(SqlTransaction myTransaction, string AllowanceCode, string AllowanceName, decimal MaximumMoney, bool IsByWorkDay, double IncomeTaxValue, bool IsShowInSalaryTableList, string Description)
        {
            string[] strArrays = new string[] { "@AllowanceCode", "@AllowanceName", "@MaximumMoney", "@IsByWorkDay", "@IncomeTaxValue", "@IsShowInSalaryTableList", "@Description" };
            string[] strArrays1 = strArrays;
            object[] allowanceCode = new object[] { AllowanceCode, AllowanceName, MaximumMoney, IsByWorkDay, IncomeTaxValue, IsShowInSalaryTableList, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_ALLOWANCE_Update", strArrays1, allowanceCode);
        }

        public string UpdateEmployeeAllowance(string AllowanceCode, bool IsByWorkDay, double IncomeTaxValue)
        {
            string[] strArrays = new string[] { "@AllowanceCode", "@IsByWorkDay", "@IncomeTaxValue" };
            object[] allowanceCode = new object[] { AllowanceCode, IsByWorkDay, IncomeTaxValue };
            object[] objArray = allowanceCode;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery("Update HRM_EMPLOYEE_ALLOWANCE\r\nset IsByWorkDay=@IsByWorkDay,\r\nIncomeTaxValue=@IncomeTaxValue\r\nwhere AllowanceCode=@AllowanceCode", strArrays, objArray);
        }

    }
}
