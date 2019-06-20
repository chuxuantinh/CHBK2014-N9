using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Data.Helper;
//using CHBK2014_N9.Utils.Lib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
   public class HRM_DEPARTMENT
    {

        private string m_DepartmentCode;

        private string m_SubsidiaryCode;

        private string m_SubsidiaryName;

        private string m_BranchCode;

        private string m_BranchName;

        private string m_DepartmentName;

        private string m_Phone;

        private int m_Quantity;

        private int m_FactQuantity;

        private string m_Description;

        [Category("Foreign Key")]
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

        [Category("Primary Key")]
        [DisplayName("DepartmentCode")]
        public string DepartmentCode
        {
            get
            {
                return this.m_DepartmentCode;
            }
            set
            {
                this.m_DepartmentCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("DepartmentName")]
        public string DepartmentName
        {
            get
            {
                return this.m_DepartmentName;
            }
            set
            {
                this.m_DepartmentName = value;
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
                return "Class HRM_DEPARTMENT";
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

        [Category("Foreign Key")]
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

        public HRM_DEPARTMENT()
        {
            this.m_DepartmentCode = "";
            this.m_SubsidiaryCode = "";
            this.m_SubsidiaryName = "";
            this.m_BranchCode = "";
            this.m_BranchName = "";
            this.m_DepartmentName = "";
            this.m_Phone = "";
            this.m_Quantity = 0;
            this.m_FactQuantity = 0;
            this.m_Description = "";
        }

        public HRM_DEPARTMENT(string DepartmentCode, string SubsidiaryCode, string BranchCode, string DepartmentName, string Phone, int Quantity, int FactQuantity, string Description)
        {
            this.m_DepartmentCode = DepartmentCode;
            this.m_SubsidiaryCode = SubsidiaryCode;
            this.m_BranchCode = BranchCode;
            this.m_DepartmentName = DepartmentName;
            this.m_Phone = Phone;
            this.m_Quantity = Quantity;
            this.m_FactQuantity = FactQuantity;
            this.m_Description = Description;
        }

        public void AddAllGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "DepartmentName";
            gridlookup.Properties.ValueMember = "DepartmentCode";
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "DepartmentName", "DepartmentCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["DepartmentCode"] = "All";
        //    dataRow["DepartmentName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "DepartmentName", "DepartmentCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["DepartmentName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup, string BranchCode)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetListByBranch(BranchCode);
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "DepartmentName";
            gridlookup.Properties.ValueMember = "DepartmentCode";
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup, string BranchCode, string ValueMember)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetListByBranch(BranchCode);
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "DepartmentName";
            gridlookup.Properties.ValueMember = ValueMember;
        }

        public void AddImageComboBoxEdit(ImageComboBoxEdit imgCombo, string BranchCode)
        {
            imgCombo.Properties.Items.Clear();
            DataTable dataTable = new DataTable();
            dataTable = this.GetListByBranch(BranchCode);
            ImageComboBoxItem imageComboBoxItem = new ImageComboBoxItem()
            {
                Description = "<Tất cả phòng ban>",
                Value = ""
            };
            imgCombo.Properties.Items.Add(imageComboBoxItem);
            foreach (DataRow row in dataTable.Rows)
            {
                ImageComboBoxItem imageComboBoxItem1 = new ImageComboBoxItem()
                {
                    Description = row["DepartmentName"].ToString(),
                    Value = row["DepartmentCode"].ToString()
                };
                imgCombo.Properties.Items.Add(imageComboBoxItem1);
            }
            imgCombo.SelectedIndex = 0;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@DepartmentCode" };
            object[] mDepartmentCode = new object[] { this.m_DepartmentCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_DEPARTMENT_Delete", strArrays, mDepartmentCode);
        }

        public string Delete(string DepartmentCode)
        {
            string[] strArrays = new string[] { "@DepartmentCode" };
            object[] departmentCode = new object[] { DepartmentCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_DEPARTMENT_Delete", strArrays, departmentCode);
        }

        public string Delete(SqlConnection myConnection, string DepartmentCode)
        {
            string[] strArrays = new string[] { "@DepartmentCode" };
            object[] departmentCode = new object[] { DepartmentCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_DEPARTMENT_Delete", strArrays, departmentCode);
        }

        public string Delete(SqlTransaction myTransaction, string DepartmentCode)
        {
            string[] strArrays = new string[] { "@DepartmentCode" };
            object[] departmentCode = new object[] { DepartmentCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_DEPARTMENT_Delete", strArrays, departmentCode);
        }

        public bool Exist(string DepartmentCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@DepartmentCode" };
            object[] departmentCode = new object[] { DepartmentCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_DEPARTMENT_Get", strArrays, departmentCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string DepartmentCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@DepartmentCode" };
            object[] departmentCode = new object[] { DepartmentCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_DEPARTMENT_Get", strArrays, departmentCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = (sqlDataReader["BranchCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchCode"]));
                    this.m_BranchName = (sqlDataReader["BranchName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchName"]));
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
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

        public string Get(SqlConnection myConnection, string DepartmentCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@DepartmentCode" };
            object[] departmentCode = new object[] { DepartmentCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_DEPARTMENT_Get", strArrays, departmentCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = (sqlDataReader["BranchCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchCode"]));
                    this.m_BranchName = (sqlDataReader["BranchName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchName"]));
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
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

        public string Get(SqlTransaction myTransaction, string DepartmentCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@DepartmentCode" };
            object[] departmentCode = new object[] { DepartmentCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_DEPARTMENT_Get", strArrays, departmentCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = (sqlDataReader["BranchCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchCode"]));
                    this.m_BranchName = (sqlDataReader["BranchName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchName"]));
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_DEPARTMENT_GetList");
        }

        public DataTable GetListByBranch(string BranchCode)
        {
            string[] strArrays = new string[] { "@BranchCode" };
            object[] branchCode = new object[] { BranchCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_DEPARTMENT_GetListByBranch", strArrays, branchCode);
        }

        public DataTable GetListByBranchNotNull(string BranchCode)
        {
            string[] strArrays = new string[] { "@BranchCode" };
            object[] branchCode = new object[] { BranchCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable("Select de.*,su.SubsidiaryName, br.BranchName \r\nFrom [HRM_DEPARTMENT] de \r\nleft join [HRM_BRANCH] br on de.BranchCode=br.BranchCode\r\nleft join [HRM_SUBSIDIARY] su on (CASE de.SubsidiaryCode\r\n\t\t\twhen null then br.SubsidiaryCode\r\n\t\t\twhen '' then br.SubsidiaryCode\r\n\t\t\telse de.SubsidiaryCode\r\n\t\t\tEND)=su.SubsidiaryCode\r\nwhere (su.SubsidiaryCode is null or su.SubsidiaryCode = '')\r\nand br.BranchCode = @BranchCode", strArrays, branchCode);
        }

        public DataTable GetListBySubsidiaryBranchNull()
        {
            return (new SqlHelper()
            {
                CommandType = CommandType.Text
            }).ExecuteDataTable("Select de.*,su.SubsidiaryName, br.BranchName \r\nFrom [HRM_DEPARTMENT] de \r\nleft join [HRM_BRANCH] br on de.BranchCode=br.BranchCode\r\nleft join [HRM_SUBSIDIARY] su on (CASE de.SubsidiaryCode\r\n\t\t\twhen null then br.SubsidiaryCode\r\n\t\t\twhen '' then br.SubsidiaryCode\r\n\t\t\telse de.SubsidiaryCode\r\n\t\t\tEND)=su.SubsidiaryCode\r\nwhere (su.SubsidiaryCode is null or su.SubsidiaryCode = '')\r\nand (br.BranchCode is null or br.BranchCode='')");
        }

        public DataTable GetListBySubsidiaryNotNull(string SubsidiaryCode)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode" };
            object[] subsidiaryCode = new object[] { SubsidiaryCode };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            return sqlHelper.ExecuteDataTable("Select de.*,su.SubsidiaryName, br.BranchName \r\nFrom [HRM_DEPARTMENT] de \r\nleft join [HRM_BRANCH] br on de.BranchCode=br.BranchCode\r\nleft join [HRM_SUBSIDIARY] su on (CASE de.SubsidiaryCode\r\n\t\t\twhen null then br.SubsidiaryCode\r\n\t\t\twhen '' then br.SubsidiaryCode\r\n\t\t\telse de.SubsidiaryCode\r\n\t\t\tEND)=su.SubsidiaryCode\r\nwhere su.SubsidiaryCode =@SubsidiaryCode\r\nand (br.BranchCode is null or br.BranchCode='')", strArrays, subsidiaryCode);
        }

        public string GetName(string DepartmentName)
        {
            string str = "";
            string[] strArrays = new string[] { "@DepartmentName" };
            object[] departmentName = new object[] { DepartmentName };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("Select de.DepartmentCode, de.BranchCode, de.DepartmentName,\r\n       de.Phone, de.Quantity, de.FactQuantity, de.[Description],\r\n       su.SubsidiaryCode,su.SubsidiaryName, br.BranchName \r\nFrom [HRM_DEPARTMENT] de \r\nleft join [HRM_BRANCH] br on de.BranchCode=br.BranchCode\r\nleft join [HRM_SUBSIDIARY] su on (CASE de.SubsidiaryCode\r\n\t\t\twhen null then br.SubsidiaryCode\r\n\t\t\twhen '' then br.SubsidiaryCode\r\n\t\t\telse de.SubsidiaryCode\r\n\t\t\tEND)=su.SubsidiaryCode\r\n Where \r\n    [DepartmentName] = @DepartmentName", strArrays, departmentName);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = (sqlDataReader["BranchCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchCode"]));
                    this.m_BranchName = (sqlDataReader["BranchName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchName"]));
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
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

        public string GetName(string BranchCode, string DepartmentName)
        {
            string str = "";
            string[] strArrays = new string[] { "@BranchCode", "@DepartmentName" };
            object[] branchCode = new object[] { BranchCode, DepartmentName };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("Select de.DepartmentCode, de.BranchCode, de.DepartmentName,\r\n       de.Phone, de.Quantity, de.FactQuantity, de.[Description],\r\n       su.SubsidiaryCode,su.SubsidiaryName, br.BranchName \r\nFrom [HRM_DEPARTMENT] de \r\nleft join [HRM_BRANCH] br on de.BranchCode=br.BranchCode\r\nleft join [HRM_SUBSIDIARY] su on (CASE de.SubsidiaryCode\r\n\t\t\twhen null then br.SubsidiaryCode\r\n\t\t\twhen '' then br.SubsidiaryCode\r\n\t\t\telse de.SubsidiaryCode\r\n\t\t\tEND)=su.SubsidiaryCode\r\n Where de.BranchCode = @BranchCode\r\n and DepartmentName = @DepartmentName", strArrays, branchCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = (sqlDataReader["BranchCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchCode"]));
                    this.m_BranchName = (sqlDataReader["BranchName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchName"]));
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
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
            string[] strArrays = new string[] { "@DepartmentCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentName", "@Phone", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mDepartmentCode = new object[] { this.m_DepartmentCode, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentName, this.m_Phone, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_DEPARTMENT_Insert", strArrays1, mDepartmentCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@DepartmentCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentName", "@Phone", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mDepartmentCode = new object[] { this.m_DepartmentCode, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentName, this.m_Phone, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_DEPARTMENT_Insert", strArrays1, mDepartmentCode);
        }

        public string Insert(string DepartmentCode, string DepartmentName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@DepartmentCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentName", "@Phone", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] departmentCode = new object[] { DepartmentCode, this.SubsidiaryCode, this.BranchCode, DepartmentName, this.Phone, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_DEPARTMENT_Insert", strArrays1, departmentCode);
        }

        public string Insert(SqlConnection myConnection, string DepartmentCode, string SubsidiaryCode, string BranchCode, string DepartmentName, string Phone, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@DepartmentCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentName", "@Phone", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] departmentCode = new object[] { DepartmentCode, SubsidiaryCode, BranchCode, DepartmentName, Phone, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_DEPARTMENT_Insert", strArrays1, departmentCode);
        }

        public string Insert(SqlTransaction myTransaction, string DepartmentCode, string SubsidiaryCode, string BranchCode, string DepartmentName, string Phone, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@DepartmentCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentName", "@Phone", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] departmentCode = new object[] { DepartmentCode, SubsidiaryCode, BranchCode, DepartmentName, Phone, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_DEPARTMENT_Insert", strArrays1, departmentCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_DEPARTMENT", "DepartmentCode", "PB");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@DepartmentCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentName", "@Phone", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mDepartmentCode = new object[] { this.m_DepartmentCode, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentName, this.m_Phone, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_DEPARTMENT_Update", strArrays1, mDepartmentCode);
        }

        public string Update(string DepartmentCode, string SubsidiaryCode, string BranchCode, string DepartmentName, string Phone, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@DepartmentCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentName", "@Phone", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] departmentCode = new object[] { DepartmentCode, SubsidiaryCode, BranchCode, DepartmentName, Phone, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_DEPARTMENT_Update", strArrays1, departmentCode);
        }

        public string Update(SqlConnection myConnection, string DepartmentCode, string SubsidiaryCode, string BranchCode, string DepartmentName, string Phone, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@DepartmentCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentName", "@Phone", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] departmentCode = new object[] { DepartmentCode, SubsidiaryCode, BranchCode, DepartmentName, Phone, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_DEPARTMENT_Update", strArrays1, departmentCode);
        }

        public string Update(SqlTransaction myTransaction, string DepartmentCode, string SubsidiaryCode, string BranchCode, string DepartmentName, string Phone, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@DepartmentCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentName", "@Phone", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] departmentCode = new object[] { DepartmentCode, SubsidiaryCode, BranchCode, DepartmentName, Phone, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_DEPARTMENT_Update", strArrays1, departmentCode);
        }
    }
}
