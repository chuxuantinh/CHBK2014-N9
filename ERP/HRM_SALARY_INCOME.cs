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
 public   class HRM_SALARY_INCOME
    {

        private string s_HRM_SALARY_INCOME_Get = "Select * From [HRM_SALARY_INCOME]\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [IncomeCode] = @IncomeCode";

        private string s_HRM_SALARY_INCOME_GetName = "Select * From [HRM_SALARY_INCOME]\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [IncomeName] = @IncomeName";

        private string s_HRM_SALARY_INCOME_GetInSalaryPlus = "Select * From [HRM_SALARY_PLUS]\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [IncomeCode] = @IncomeCode";

        private string s_HRM_SALARY_INCOME_GetList = "Select * From [HRM_SALARY_INCOME]";

        private string s_HRM_SALARY_INCOME_GetListBySalary = "Select * From [HRM_SALARY_INCOME] where SalaryTableListID=@SalaryTableListID";

        private string s_HRM_SALARY_INCOME_GetListByTax = "Select * From [HRM_SALARY_INCOME] where SalaryTableListID=@SalaryTableListID and IsIncomeTax=@IsIncomeTax";

        private string s_HRM_SALARY_INCOME_Delete = "Delete From [HRM_SALARY_INCOME]\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [IncomeCode] = @IncomeCode\r\n";

        private string s_HRM_SALARY_INCOME_Insert = "INSERT INTO [HRM_SALARY_INCOME] (\r\n    SalaryTableListID,\r\n    IncomeCode,\r\n    IncomeName,\r\n    IsIncomeTax,\r\n    Description\r\n)\r\nVALUES (\r\n    @SalaryTableListID,\r\n    @IncomeCode,\r\n    @IncomeName,\r\n    @IsIncomeTax,\r\n    @Description)";

        private string s_HRM_SALARY_INCOME_Update = "UPDATE [HRM_SALARY_INCOME]\r\nSET\r\n    [IncomeName] = @IncomeName,\r\n    [IsIncomeTax] = @IsIncomeTax,\r\n    [Description] = @Description\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [IncomeCode] = @IncomeCode";

        private Guid m_SalaryTableListID;

        private string m_IncomeCode;

        private string m_IncomeName;

        private bool m_IsIncomeTax;

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

        [Category("Primary Key")]
        [DisplayName("IncomeCode")]
        public string IncomeCode
        {
            get
            {
                return this.m_IncomeCode;
            }
            set
            {
                this.m_IncomeCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("IncomeName")]
        public string IncomeName
        {
            get
            {
                return this.m_IncomeName;
            }
            set
            {
                this.m_IncomeName = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsIncomeTax")]
        public bool IsIncomeTax
        {
            get
            {
                return this.m_IsIncomeTax;
            }
            set
            {
                this.m_IsIncomeTax = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_SALARY_INCOME";
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
        [DisplayName("SalaryTableListID")]
        public Guid SalaryTableListID
        {
            get
            {
                return this.m_SalaryTableListID;
            }
            set
            {
                this.m_SalaryTableListID = value;
            }
        }

        public HRM_SALARY_INCOME()
        {
            this.m_SalaryTableListID = Guid.Empty;
            this.m_IncomeCode = "";
            this.m_IncomeName = "";
            this.m_IsIncomeTax = false;
            this.m_Description = "";
        }

        public HRM_SALARY_INCOME(Guid SalaryTableListID, string IncomeCode, string IncomeName, bool IsIncomeTax, string Description)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_IncomeCode = IncomeCode;
            this.m_IncomeName = IncomeName;
            this.m_IsIncomeTax = IsIncomeTax;
            this.m_Description = Description;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "IncomeName", "IncomeCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["IncomeCode"] = "All";
        //    dataRow["IncomeName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "IncomeName", "IncomeCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["IncomeName"]);
            }
        }

        public void AddGridLookupEdit(Guid SalaryTableListID, GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList(SalaryTableListID);
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "IncomeName";
            gridlookup.Properties.ValueMember = "IncomeCode";
        }

        public void AddRepositoryGridLookupEdit(Guid SalaryTableListID, RepositoryItemGridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            gridlookup.DataSource = this.GetList(SalaryTableListID);
            gridlookup.DisplayMember = "IncomeName";
            gridlookup.ValueMember = "IncomeCode";
        }

        public static string Create(string SalaryTableListID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_INCOME_Create", strArrays, salaryTableListID);
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_IncomeCode };
            object[] objArray = mSalaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(this.s_HRM_SALARY_INCOME_Delete, strArrays, objArray);
        }

        public string Delete(Guid SalaryTableListID, string IncomeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(this.s_HRM_SALARY_INCOME_Delete, strArrays, salaryTableListID);
        }

        public string Delete(SqlConnection myConnection, Guid SalaryTableListID, string IncomeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myConnection, this.s_HRM_SALARY_INCOME_Delete, strArrays, salaryTableListID);
        }

        public string Delete(SqlTransaction myTransaction, Guid SalaryTableListID, string IncomeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myTransaction, this.s_HRM_SALARY_INCOME_Delete, strArrays, salaryTableListID);
        }

        public bool Exist(Guid SalaryTableListID, string IncomeCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(this.s_HRM_SALARY_INCOME_Get, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool ExistInSalaryPlus(Guid SalaryTableListID, string IncomeCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(this.s_HRM_SALARY_INCOME_GetInSalaryPlus, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool ExistName(Guid SalaryTableListID, string IncomeName)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeName" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeName };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(this.s_HRM_SALARY_INCOME_GetName, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    if (sqlDataReader["IncomeCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["IncomeCode"];
                    }
                    this.m_IncomeCode = Convert.ToString(item);
                    if (sqlDataReader["IncomeName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["IncomeName"];
                    }
                    this.m_IncomeName = Convert.ToString(obj);
                    if (sqlDataReader["IsIncomeTax"] == DBNull.Value)
                    {
                        item1 = true;
                    }
                    else
                    {
                        item1 = sqlDataReader["IsIncomeTax"];
                    }
                    this.m_IsIncomeTax = Convert.ToBoolean(item1);
                    if (sqlDataReader["Description"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["Description"];
                    }
                    this.m_Description = Convert.ToString(obj1);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid SalaryTableListID, string IncomeCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(this.s_HRM_SALARY_INCOME_Get, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    if (sqlDataReader["IncomeCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["IncomeCode"];
                    }
                    this.m_IncomeCode = Convert.ToString(item);
                    if (sqlDataReader["IncomeName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["IncomeName"];
                    }
                    this.m_IncomeName = Convert.ToString(obj);
                    if (sqlDataReader["IsIncomeTax"] == DBNull.Value)
                    {
                        item1 = true;
                    }
                    else
                    {
                        item1 = sqlDataReader["IsIncomeTax"];
                    }
                    this.m_IsIncomeTax = Convert.ToBoolean(item1);
                    if (sqlDataReader["Description"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["Description"];
                    }
                    this.m_Description = Convert.ToString(obj1);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid SalaryTableListID, string IncomeCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, this.s_HRM_SALARY_INCOME_Get, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    if (sqlDataReader["IncomeCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["IncomeCode"];
                    }
                    this.m_IncomeCode = Convert.ToString(item);
                    if (sqlDataReader["IncomeName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["IncomeName"];
                    }
                    this.m_IncomeName = Convert.ToString(obj);
                    if (sqlDataReader["IsIncomeTax"] == DBNull.Value)
                    {
                        item1 = true;
                    }
                    else
                    {
                        item1 = sqlDataReader["IsIncomeTax"];
                    }
                    this.m_IsIncomeTax = Convert.ToBoolean(item1);
                    if (sqlDataReader["Description"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["Description"];
                    }
                    this.m_Description = Convert.ToString(obj1);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid SalaryTableListID, string IncomeCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, this.s_HRM_SALARY_INCOME_Get, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    if (sqlDataReader["IncomeCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["IncomeCode"];
                    }
                    this.m_IncomeCode = Convert.ToString(item);
                    if (sqlDataReader["IncomeName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["IncomeName"];
                    }
                    this.m_IncomeName = Convert.ToString(obj);
                    if (sqlDataReader["IsIncomeTax"] == DBNull.Value)
                    {
                        item1 = true;
                    }
                    else
                    {
                        item1 = sqlDataReader["IsIncomeTax"];
                    }
                    this.m_IsIncomeTax = Convert.ToBoolean(item1);
                    if (sqlDataReader["Description"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["Description"];
                    }
                    this.m_Description = Convert.ToString(obj1);
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
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable(this.s_HRM_SALARY_INCOME_GetList);
        }

        public DataTable GetList(Guid SalaryTableListID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable(this.s_HRM_SALARY_INCOME_GetListBySalary, strArrays, salaryTableListID);
        }

        public DataTable GetList(Guid SalaryTableListID, bool IsIncomeTax)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IsIncomeTax" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IsIncomeTax };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable(this.s_HRM_SALARY_INCOME_GetListByTax, strArrays, salaryTableListID);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode", "@IncomeName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_IncomeCode, this.m_IncomeName, this.m_IsIncomeTax, this.m_Description };
            object[] objArray = mSalaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(this.s_HRM_SALARY_INCOME_Insert, strArrays1, objArray);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode", "@IncomeName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_IncomeCode, this.m_IncomeName, this.m_IsIncomeTax, this.m_Description };
            object[] objArray = mSalaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myTransaction, this.s_HRM_SALARY_INCOME_Insert, strArrays1, objArray);
        }

        public string Insert(Guid SalaryTableListID, string IncomeCode, string IncomeName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode", "@IncomeName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode, IncomeName, IsIncomeTax, Description };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(this.s_HRM_SALARY_INCOME_Insert, strArrays1, objArray);
        }

        public string Insert(SqlConnection myConnection, Guid SalaryTableListID, string IncomeCode, string IncomeName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode", "@IncomeName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode, IncomeName, IsIncomeTax, Description };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myConnection, this.s_HRM_SALARY_INCOME_Insert, strArrays1, objArray);
        }

        public string Insert(SqlTransaction myTransaction, Guid SalaryTableListID, string IncomeCode, string IncomeName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode", "@IncomeName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode, IncomeName, IsIncomeTax, Description };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myTransaction, this.s_HRM_SALARY_INCOME_Insert, strArrays1, objArray);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_SALARY_INCOME", "IncomeCode", "LTN");
        }

        public void SetData(Guid SalaryTableListID, string IncomeCode, string IncomeName, bool IsIncomeTax, string Description)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_IncomeCode = IncomeCode;
            this.m_IncomeName = IncomeName;
            this.m_IsIncomeTax = IsIncomeTax;
            this.m_Description = Description;
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode", "@IncomeName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_IncomeCode, this.m_IncomeName, this.m_IsIncomeTax, this.m_Description };
            object[] objArray = mSalaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(this.s_HRM_SALARY_INCOME_Update, strArrays1, objArray);
        }

        public string Update(Guid SalaryTableListID, string IncomeCode, string IncomeName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode", "@IncomeName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode, IncomeName, IsIncomeTax, Description };
            return (new SqlHelper()).ExecuteNonQuery(this.s_HRM_SALARY_INCOME_Update, strArrays1, salaryTableListID);
        }

        public string Update(SqlConnection myConnection, Guid SalaryTableListID, string IncomeCode, string IncomeName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode", "@IncomeName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode, IncomeName, IsIncomeTax, Description };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myConnection, this.s_HRM_SALARY_INCOME_Update, strArrays1, objArray);
        }

        public string Update(SqlTransaction myTransaction, Guid SalaryTableListID, string IncomeCode, string IncomeName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IncomeCode", "@IncomeName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, IncomeCode, IncomeName, IsIncomeTax, Description };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myTransaction, this.s_HRM_SALARY_INCOME_Update, strArrays1, objArray);
        }
    }
}
