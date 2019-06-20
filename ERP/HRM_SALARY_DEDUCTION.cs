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
  public  class HRM_SALARY_DEDUCTION
    {


        private string s_HRM_SALARY_DEDUCTION_Get = "Select * From [HRM_SALARY_DEDUCTION]\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [DeductionCode] = @DeductionCode";

        private string s_HRM_SALARY_DEDUCTION_GetName = "Select * From [HRM_SALARY_DEDUCTION]\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [DeductionName] = @DeductionName";

        private string s_HRM_SALARY_DEDUCTION_GetInSalaryPlus = "Select * From [HRM_SALARY_MINUS]\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [DeductionCode] = @DeductionCode";

        private string s_HRM_SALARY_DEDUCTION_GetList = "Select * From [HRM_SALARY_DEDUCTION]";

        private string s_HRM_SALARY_DEDUCTION_GetListBySalary = "Select * From [HRM_SALARY_DEDUCTION] where SalaryTableListID=@SalaryTableListID";

        private string s_HRM_SALARY_DEDUCTION_GetListByTax = "Select * From [HRM_SALARY_DEDUCTION] where SalaryTableListID=@SalaryTableListID and IsIncomeTax=@IsIncomeTax";

        private string s_HRM_SALARY_DEDUCTION_Delete = "Delete From [HRM_SALARY_DEDUCTION]\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [DeductionCode] = @DeductionCode\r\n";

        private string s_HRM_SALARY_DEDUCTION_Insert = "INSERT INTO [HRM_SALARY_DEDUCTION] (\r\n    SalaryTableListID,\r\n    DeductionCode,\r\n    DeductionName,\r\n    IsIncomeTax,\r\n    Description\r\n)\r\nVALUES (\r\n    @SalaryTableListID,\r\n    @DeductionCode,\r\n    @DeductionName,\r\n    @IsIncomeTax,\r\n    @Description)";

        private string s_HRM_SALARY_DEDUCTION_Update = "UPDATE [HRM_SALARY_DEDUCTION]\r\nSET\r\n    [DeductionName] = @DeductionName,\r\n    [IsIncomeTax] = @IsIncomeTax,\r\n    [Description] = @Description\r\n Where \r\n    [SalaryTableListID] = @SalaryTableListID\r\n AND \r\n    [DeductionCode] = @DeductionCode";

        private Guid m_SalaryTableListID;

        private string m_DeductionCode;

        private string m_DeductionName;

        private bool m_IsIncomeTax;

        private string m_Description;

        [Category("Primary Key")]
        [DisplayName("DeductionCode")]
        public string DeductionCode
        {
            get
            {
                return this.m_DeductionCode;
            }
            set
            {
                this.m_DeductionCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("DeductionName")]
        public string DeductionName
        {
            get
            {
                return this.m_DeductionName;
            }
            set
            {
                this.m_DeductionName = value;
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
                return "Class HRM_SALARY_DEDUCTION";
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

        public HRM_SALARY_DEDUCTION()
        {
            this.m_SalaryTableListID = Guid.Empty;
            this.m_DeductionCode = "";
            this.m_DeductionName = "";
            this.m_IsIncomeTax = false;
            this.m_Description = "";
        }

        public HRM_SALARY_DEDUCTION(Guid SalaryTableListID, string DeductionCode, string DeductionName, bool IsIncomeTax, string Description)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_DeductionCode = DeductionCode;
            this.m_DeductionName = DeductionName;
            this.m_IsIncomeTax = IsIncomeTax;
            this.m_Description = Description;
        }

     //   public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "DeductionName", "DeductionCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["DeductionCode"] = "All";
        //    dataRow["DeductionName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "DeductionName", "DeductionCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["DeductionName"]);
            }
        }

        public void AddGridLookupEdit(Guid SalaryTableListID, GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList(SalaryTableListID);
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "DeductionName";
            gridlookup.Properties.ValueMember = "DeductionCode";
        }

        public void AddRepositoryGridLookupEdit(Guid SalaryTableListID, RepositoryItemGridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            gridlookup.DataSource = this.GetList(SalaryTableListID);
            gridlookup.DisplayMember = "DeductionName";
            gridlookup.ValueMember = "DeductionCode";
        }

        public static string Create(string SalaryTableListID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_DEDUCTION_Create", strArrays, salaryTableListID);
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_DeductionCode };
            object[] objArray = mSalaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(this.s_HRM_SALARY_DEDUCTION_Delete, strArrays, objArray);
        }

        public string Delete(Guid SalaryTableListID, string DeductionCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(this.s_HRM_SALARY_DEDUCTION_Delete, strArrays, salaryTableListID);
        }

        public string Delete(SqlConnection myConnection, Guid SalaryTableListID, string DeductionCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myConnection, this.s_HRM_SALARY_DEDUCTION_Delete, strArrays, salaryTableListID);
        }

        public string Delete(SqlTransaction myTransaction, Guid SalaryTableListID, string DeductionCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myTransaction, this.s_HRM_SALARY_DEDUCTION_Delete, strArrays, salaryTableListID);
        }

        public bool Exist(Guid SalaryTableListID, string DeductionCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(this.s_HRM_SALARY_DEDUCTION_Get, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool ExistInSalaryMinus(Guid SalaryTableListID, string DeductionCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(this.s_HRM_SALARY_DEDUCTION_GetInSalaryPlus, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public bool ExistName(Guid SalaryTableListID, string DeductionName)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionName" };
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionName };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(this.s_HRM_SALARY_DEDUCTION_GetName, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    if (sqlDataReader["DeductionCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["DeductionCode"];
                    }
                    this.m_DeductionCode = Convert.ToString(item);
                    if (sqlDataReader["DeductionName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["DeductionName"];
                    }
                    this.m_DeductionName = Convert.ToString(obj);
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

        public string Get(Guid SalaryTableListID, string DeductionCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(this.s_HRM_SALARY_DEDUCTION_Get, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    if (sqlDataReader["DeductionCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["DeductionCode"];
                    }
                    this.m_DeductionCode = Convert.ToString(item);
                    if (sqlDataReader["DeductionName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["DeductionName"];
                    }
                    this.m_DeductionName = Convert.ToString(obj);
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

        public string Get(SqlConnection myConnection, Guid SalaryTableListID, string DeductionCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, this.s_HRM_SALARY_DEDUCTION_Get, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    if (sqlDataReader["DeductionCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["DeductionCode"];
                    }
                    this.m_DeductionCode = Convert.ToString(item);
                    if (sqlDataReader["DeductionName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["DeductionName"];
                    }
                    this.m_DeductionName = Convert.ToString(obj);
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

        public string Get(SqlTransaction myTransaction, Guid SalaryTableListID, string DeductionCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, this.s_HRM_SALARY_DEDUCTION_Get, strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    if (sqlDataReader["DeductionCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["DeductionCode"];
                    }
                    this.m_DeductionCode = Convert.ToString(item);
                    if (sqlDataReader["DeductionName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["DeductionName"];
                    }
                    this.m_DeductionName = Convert.ToString(obj);
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
            return sqlHelper.ExecuteDataTable(this.s_HRM_SALARY_DEDUCTION_GetList);
        }

        public DataTable GetList(Guid SalaryTableListID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable(this.s_HRM_SALARY_DEDUCTION_GetListBySalary, strArrays, salaryTableListID);
        }

        public DataTable GetList(Guid SalaryTableListID, bool IsIncomeTax)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@IsIncomeTax" };
            object[] salaryTableListID = new object[] { SalaryTableListID, IsIncomeTax };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable(this.s_HRM_SALARY_DEDUCTION_GetListByTax, strArrays, salaryTableListID);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode", "@DeductionName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_DeductionCode, this.m_DeductionName, this.m_IsIncomeTax, this.m_Description };
            object[] objArray = mSalaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(this.s_HRM_SALARY_DEDUCTION_Insert, strArrays1, objArray);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode", "@DeductionName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_DeductionCode, this.m_DeductionName, this.m_IsIncomeTax, this.m_Description };
            object[] objArray = mSalaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myTransaction, this.s_HRM_SALARY_DEDUCTION_Insert, strArrays1, objArray);
        }

        public string Insert(Guid SalaryTableListID, string DeductionCode, string DeductionName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode", "@DeductionName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode, DeductionName, IsIncomeTax, Description };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(this.s_HRM_SALARY_DEDUCTION_Insert, strArrays1, objArray);
        }

        public string Insert(SqlConnection myConnection, Guid SalaryTableListID, string DeductionCode, string DeductionName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode", "@DeductionName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode, DeductionName, IsIncomeTax, Description };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myConnection, this.s_HRM_SALARY_DEDUCTION_Insert, strArrays1, objArray);
        }

        public string Insert(SqlTransaction myTransaction, Guid SalaryTableListID, string DeductionCode, string DeductionName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode", "@DeductionName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode, DeductionName, IsIncomeTax, Description };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myTransaction, this.s_HRM_SALARY_DEDUCTION_Insert, strArrays1, objArray);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_SALARY_DEDUCTION", "DeductionCode", "LTN");
        }

        public void SetData(Guid SalaryTableListID, string DeductionCode, string DeductionName, bool IsIncomeTax, string Description)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_DeductionCode = DeductionCode;
            this.m_DeductionName = DeductionName;
            this.m_IsIncomeTax = IsIncomeTax;
            this.m_Description = Description;
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode", "@DeductionName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_DeductionCode, this.m_DeductionName, this.m_IsIncomeTax, this.m_Description };
            object[] objArray = mSalaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(this.s_HRM_SALARY_DEDUCTION_Update, strArrays1, objArray);
        }

        public string Update(Guid SalaryTableListID, string DeductionCode, string DeductionName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode", "@DeductionName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode, DeductionName, IsIncomeTax, Description };
            return (new SqlHelper()).ExecuteNonQuery(this.s_HRM_SALARY_DEDUCTION_Update, strArrays1, salaryTableListID);
        }

        public string Update(SqlConnection myConnection, Guid SalaryTableListID, string DeductionCode, string DeductionName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode", "@DeductionName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode, DeductionName, IsIncomeTax, Description };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myConnection, this.s_HRM_SALARY_DEDUCTION_Update, strArrays1, objArray);
        }

        public string Update(SqlTransaction myTransaction, Guid SalaryTableListID, string DeductionCode, string DeductionName, bool IsIncomeTax, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@DeductionCode", "@DeductionName", "@IsIncomeTax", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, DeductionCode, DeductionName, IsIncomeTax, Description };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteNonQuery(myTransaction, this.s_HRM_SALARY_DEDUCTION_Update, strArrays1, objArray);
        }
    }
}
