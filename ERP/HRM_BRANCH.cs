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
public  class HRM_BRANCH
    {

        private string m_BranchCode;

        private string m_SubsidiaryCode;

        private string m_SubsidiaryName;

        private string m_BranchName;

        private string m_Address;

        private string m_Phone;

        private string m_Fax;

        private decimal m_MinimumSalary;

        private string m_PersonName;

        private int m_Quantity;

        private int m_FactQuantity;

        private string m_Description;

        [Category("Column")]
        [DisplayName("Address")]
        public string Address
        {
            get
            {
                return this.m_Address;
            }
            set
            {
                this.m_Address = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("BranchCode")]
        public string BranchCode
        {
            get
            {
                return this.m_BranchCode;
            }
            set
            {
                this.m_BranchCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("BranchName")]
        public string BranchName
        {
            get
            {
                return this.m_BranchName;
            }
            set
            {
                this.m_BranchName = value;
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
        [DisplayName("FactQuantity")]
        public int FactQuantity
        {
            get
            {
                return this.m_FactQuantity;
            }
            set
            {
                this.m_FactQuantity = value;
            }
        }

        [Category("Column")]
        [DisplayName("Fax")]
        public string Fax
        {
            get
            {
                return this.m_Fax;
            }
            set
            {
                this.m_Fax = value;
            }
        }

        [Category("Column")]
        [DisplayName("MinimumSalary")]
        public decimal MinimumSalary
        {
            get
            {
                return this.m_MinimumSalary;
            }
            set
            {
                this.m_MinimumSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("PersonName")]
        public string PersonName
        {
            get
            {
                return this.m_PersonName;
            }
            set
            {
                this.m_PersonName = value;
            }
        }

        [Category("Column")]
        [DisplayName("Phone")]
        public string Phone
        {
            get
            {
                return this.m_Phone;
            }
            set
            {
                this.m_Phone = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_BRANCH";
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
        [DisplayName("Quantity")]
        public int Quantity
        {
            get
            {
                return this.m_Quantity;
            }
            set
            {
                this.m_Quantity = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("SubsidiaryCode")]
        public string SubsidiaryCode
        {
            get
            {
                return this.m_SubsidiaryCode;
            }
            set
            {
                this.m_SubsidiaryCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("SubsidiaryName")]
        public string SubsidiaryName
        {
            get
            {
                return this.m_SubsidiaryName;
            }
            set
            {
                this.m_SubsidiaryName = value;
            }
        }

        public HRM_BRANCH()
        {
            this.m_BranchCode = "";
            this.m_SubsidiaryCode = "";
            this.m_SubsidiaryName = "";
            this.m_BranchName = "";
            this.m_Address = "";
            this.m_Phone = "";
            this.m_Fax = "";
            this.m_MinimumSalary = new decimal(0);
            this.m_PersonName = "";
            this.m_Quantity = 0;
            this.m_FactQuantity = 0;
            this.m_Description = "";
        }

        public HRM_BRANCH(string BranchCode, string SubsidiaryCode, string BranchName, string Address, string Phone, string Fax, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            this.m_BranchCode = BranchCode;
            this.m_SubsidiaryCode = SubsidiaryCode;
            this.m_BranchName = BranchName;
            this.m_Address = Address;
            this.m_Phone = Phone;
            this.m_Fax = Fax;
            this.m_MinimumSalary = MinimumSalary;
            this.m_PersonName = PersonName;
            this.m_Quantity = Quantity;
            this.m_FactQuantity = FactQuantity;
            this.m_Description = Description;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "BranchName", "BranchCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["BranchCode"] = "All";
        //    dataRow["BranchName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "BranchName", "BranchCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["BranchName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "BranchName";
            gridlookup.Properties.ValueMember = "BranchCode";
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup, string ValueMember)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "BranchName";
            gridlookup.Properties.ValueMember = ValueMember;
        }

        public void AddImageComboBoxEdit(ImageComboBoxEdit imgCombo)
        {
            imgCombo.Properties.Items.Clear();
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            ImageComboBoxItem imageComboBoxItem = new ImageComboBoxItem()
            {
                Description = "<Tất cả chi nhánh>",
                Value = ""
            };
            imgCombo.Properties.Items.Add(imageComboBoxItem);
            foreach (DataRow row in dataTable.Rows)
            {
                ImageComboBoxItem imageComboBoxItem1 = new ImageComboBoxItem()
                {
                    Description = row["BranchName"].ToString(),
                    Value = row["BranchCode"].ToString()
                };
                imgCombo.Properties.Items.Add(imageComboBoxItem1);
            }
            imgCombo.SelectedIndex = 0;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@BranchCode" };
            object[] mBranchCode = new object[] { this.m_BranchCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_BRANCH_Delete", strArrays, mBranchCode);
        }

        public string Delete(string BranchCode)
        {
            string[] strArrays = new string[] { "@BranchCode" };
            object[] branchCode = new object[] { BranchCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_BRANCH_Delete", strArrays, branchCode);
        }

        public string Delete(SqlConnection myConnection, string BranchCode)
        {
            string[] strArrays = new string[] { "@BranchCode" };
            object[] branchCode = new object[] { BranchCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_BRANCH_Delete", strArrays, branchCode);
        }

        public string Delete(SqlTransaction myTransaction, string BranchCode)
        {
            string[] strArrays = new string[] { "@BranchCode" };
            object[] branchCode = new object[] { BranchCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_BRANCH_Delete", strArrays, branchCode);
        }

        public bool Exist(string BranchCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@BranchCode" };
            object[] branchCode = new object[] { BranchCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_BRANCH_Get", strArrays, branchCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string BranchCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@BranchCode" };
            object[] branchCode = new object[] { BranchCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_BRANCH_Get", strArrays, branchCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchName = Convert.ToString(sqlDataReader["BranchName"]);
                    this.m_Address = Convert.ToString(sqlDataReader["Address"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
                    this.m_Fax = Convert.ToString(sqlDataReader["Fax"]);
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_PersonName = Convert.ToString(sqlDataReader["PersonName"]);
                    this.m_Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    this.m_FactQuantity = Convert.ToInt32(sqlDataReader["FactQuantity"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string PositionCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@BranchCode" };
            object[] branchCode = new object[] { this.BranchCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_BRANCH_Get", strArrays, branchCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchName = Convert.ToString(sqlDataReader["BranchName"]);
                    this.m_Address = Convert.ToString(sqlDataReader["Address"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
                    this.m_Fax = Convert.ToString(sqlDataReader["Fax"]);
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_PersonName = Convert.ToString(sqlDataReader["PersonName"]);
                    this.m_Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    this.m_FactQuantity = Convert.ToInt32(sqlDataReader["FactQuantity"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string BranchCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@BranchCode" };
            object[] branchCode = new object[] { BranchCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_BRANCH_Get", strArrays, branchCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchName = Convert.ToString(sqlDataReader["BranchName"]);
                    this.m_Address = Convert.ToString(sqlDataReader["Address"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
                    this.m_Fax = Convert.ToString(sqlDataReader["Fax"]);
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_PersonName = Convert.ToString(sqlDataReader["PersonName"]);
                    this.m_Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    this.m_FactQuantity = Convert.ToInt32(sqlDataReader["FactQuantity"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_BRANCH_GetList");
        }

        public DataTable GetListBySubsidiary(string SubsidiaryCode)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode" };
            object[] subsidiaryCode = new object[] { SubsidiaryCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_BRANCH_GetListBySubsidiary", strArrays, subsidiaryCode);
        }

        public DataTable GetListBySubsidiaryNull()
        {
            return (new SqlHelper()
            {
                CommandType = CommandType.Text
            }).ExecuteDataTable("Select br.*,su.SubsidiaryName\r\nFrom [HRM_BRANCH] br\r\nleft join [HRM_SUBSIDIARY] su\r\non br.SubsidiaryCode=su.SubsidiaryCode\r\nwhere br.SubsidiaryCode is null or br.SubsidiaryCode = ''");
        }

        public string GetName(string BranchName)
        {
            string str = "";
            string[] strArrays = new string[] { "@BranchName" };
            object[] branchName = new object[] { BranchName };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("Select br.*,su.SubsidiaryName\r\nFrom [HRM_BRANCH] br\r\nleft join [HRM_SUBSIDIARY] su on br.SubsidiaryCode=su.SubsidiaryCode\r\n Where \r\n    [BranchName] = @BranchName", strArrays, branchName);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchName = Convert.ToString(sqlDataReader["BranchName"]);
                    this.m_Address = Convert.ToString(sqlDataReader["Address"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
                    this.m_Fax = Convert.ToString(sqlDataReader["Fax"]);
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_PersonName = Convert.ToString(sqlDataReader["PersonName"]);
                    this.m_Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    this.m_FactQuantity = Convert.ToInt32(sqlDataReader["FactQuantity"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string GetName(string SubsidiaryCode, string BranchName)
        {
            string str = "";
            string[] strArrays = new string[] { "@SubsidiaryCode", "@BranchName" };
            object[] subsidiaryCode = new object[] { SubsidiaryCode, BranchName };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("Select br.*,su.SubsidiaryName\r\nFrom [HRM_BRANCH] br\r\nleft join [HRM_SUBSIDIARY] su on br.SubsidiaryCode=su.SubsidiaryCode\r\n Where \r\n    [BranchName] = @BranchName and br.SubsidiaryCode=@SubsidiaryCode", strArrays, subsidiaryCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchName = Convert.ToString(sqlDataReader["BranchName"]);
                    this.m_Address = Convert.ToString(sqlDataReader["Address"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
                    this.m_Fax = Convert.ToString(sqlDataReader["Fax"]);
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_PersonName = Convert.ToString(sqlDataReader["PersonName"]);
                    this.m_Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    this.m_FactQuantity = Convert.ToInt32(sqlDataReader["FactQuantity"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
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
            string[] strArrays = new string[] { "@BranchCode", "@SubsidiaryCode", "@BranchName", "@Address", "@Phone", "@Fax", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mBranchCode = new object[] { this.m_BranchCode, this.m_SubsidiaryCode, this.m_BranchName, this.m_Address, this.m_Phone, this.m_Fax, this.m_MinimumSalary, this.m_PersonName, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_BRANCH_Insert", strArrays1, mBranchCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@BranchCode", "@SubsidiaryCode", "@BranchName", "@Address", "@Phone", "@Fax", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mBranchCode = new object[] { this.m_BranchCode, this.m_SubsidiaryCode, this.m_BranchName, this.m_Address, this.m_Phone, this.m_Fax, this.m_MinimumSalary, this.m_PersonName, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_BRANCH_Insert", strArrays1, mBranchCode);
        }

        public string Insert(string BranchCode, string SubsidiaryCode, string BranchName, string Address, string Phone, string Fax, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@BranchCode", "@SubsidiaryCode", "@BranchName", "@Address", "@Phone", "@Fax", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] branchCode = new object[] { BranchCode, SubsidiaryCode, BranchName, Address, Phone, Fax, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_BRANCH_Insert", strArrays1, branchCode);
        }

        public string Insert(SqlConnection myConnection, string BranchCode, string SubsidiaryCode, string BranchName, string Address, string Phone, string Fax, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@BranchCode", "@SubsidiaryCode", "@BranchName", "@Address", "@Phone", "@Fax", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] branchCode = new object[] { BranchCode, SubsidiaryCode, BranchName, Address, Phone, Fax, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_BRANCH_Insert", strArrays1, branchCode);
        }

        public string Insert(SqlTransaction myTransaction, string BranchCode, string SubsidiaryCode, string BranchName, string Address, string Phone, string Fax, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@BranchCode", "@SubsidiaryCode", "@BranchName", "@Address", "@Phone", "@Fax", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] branchCode = new object[] { BranchCode, SubsidiaryCode, BranchName, Address, Phone, Fax, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_BRANCH_Insert", strArrays1, branchCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_BRANCH", "BranchCode", "CN");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@BranchCode", "@SubsidiaryCode", "@BranchName", "@Address", "@Phone", "@Fax", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mBranchCode = new object[] { this.m_BranchCode, this.m_SubsidiaryCode, this.m_BranchName, this.m_Address, this.m_Phone, this.m_Fax, this.m_MinimumSalary, this.m_PersonName, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_BRANCH_Update", strArrays1, mBranchCode);
        }

        public string Update(string BranchCode, string SubsidiaryCode, string BranchName, string Address, string Phone, string Fax, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@BranchCode", "@SubsidiaryCode", "@BranchName", "@Address", "@Phone", "@Fax", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] branchCode = new object[] { BranchCode, SubsidiaryCode, BranchName, Address, Phone, Fax, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_BRANCH_Update", strArrays1, branchCode);
        }

        public string Update(SqlConnection myConnection, string BranchCode, string SubsidiaryCode, string BranchName, string Address, string Phone, string Fax, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@BranchCode", "@SubsidiaryCode", "@BranchName", "@Address", "@Phone", "@Fax", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] branchCode = new object[] { BranchCode, SubsidiaryCode, BranchName, Address, Phone, Fax, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_BRANCH_Update", strArrays1, branchCode);
        }

        public string Update(SqlTransaction myTransaction, string BranchCode, string SubsidiaryCode, string BranchName, string Address, string Phone, string Fax, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@BranchCode", "@SubsidiaryCode", "@BranchName", "@Address", "@Phone", "@Fax", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] branchCode = new object[] { BranchCode, SubsidiaryCode, BranchName, Address, Phone, Fax, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_BRANCH_Update", strArrays1, branchCode);
        }
    }
}
