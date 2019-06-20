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
   public class HRM_GROUP
    {
        private string m_GroupCode;

        private string m_SubsidiaryCode;

        private string m_SubsidiaryName;

        private string m_BranchCode;

        private string m_BranchName;

        private string m_DepartmentCode;

        private string m_DepartmentName;

        private string m_GroupName;

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

        [Category("Primary Key")]
        [DisplayName("GroupCode")]
        public string GroupCode
        {
            get
            {
                return this.m_GroupCode;
            }
            set
            {
                this.m_GroupCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("GroupName")]
        public string GroupName
        {
            get
            {
                return this.m_GroupName;
            }
            set
            {
                this.m_GroupName = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_GROUP";
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

        public HRM_GROUP()
        {
            this.m_GroupCode = "";
            this.m_SubsidiaryCode = "";
            this.m_SubsidiaryName = "";
            this.m_BranchCode = "";
            this.m_BranchName = "";
            this.m_DepartmentCode = "";
            this.m_DepartmentName = "";
            this.m_GroupName = "";
            this.m_Quantity = 0;
            this.m_FactQuantity = 0;
            this.m_Description = "";
        }

        public HRM_GROUP(string GroupCode, string DepartmentCode, string GroupName, int Quantity, int FactQuantity, string Description)
        {
            this.m_GroupCode = GroupCode;
            this.m_DepartmentCode = DepartmentCode;
            this.m_GroupName = GroupName;
            this.m_Quantity = Quantity;
            this.m_FactQuantity = FactQuantity;
            this.m_Description = Description;
        }

        public void AddAllCheckedListBoxEdit(CheckedListBoxControl imgCombo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                CheckedListBoxItem checkedListBoxItem = new CheckedListBoxItem()
                {
                    Description = string.Concat(row["GroupName"].ToString(), " (", row["GroupCode"].ToString(), ")"),
                    CheckState = CheckState.Checked,
                    Value = row["GroupCode"].ToString()
                };
                imgCombo.Items.Add(checkedListBoxItem);
            }
        }

        public void AddCheckedListBoxEdit(CheckedListBoxControl imgCombo, string DepartmentCode)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetListByDepartment(DepartmentCode).Rows)
            {
                CheckedListBoxItem checkedListBoxItem = new CheckedListBoxItem()
                {
                    Description = string.Concat(row["GroupName"].ToString(), " (", row["GroupCode"].ToString(), ")"),
                    CheckState = CheckState.Checked,
                    Value = row["GroupCode"].ToString()
                };
                imgCombo.Items.Add(checkedListBoxItem);
            }
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "GroupName", "GroupCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["GroupCode"] = "All";
        //    dataRow["GroupName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "GroupName", "GroupCode");
        //}

        public void AddGridLookupEdit(GridLookUpEdit gridlookup, string DepartmentCode)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetListByDepartment(DepartmentCode);
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "GroupName";
            gridlookup.Properties.ValueMember = "GroupCode";
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup, string DepartmentCode, string ValueMember)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetListByDepartment(DepartmentCode);
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "GroupName";
            gridlookup.Properties.ValueMember = ValueMember;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@GroupCode" };
            object[] mGroupCode = new object[] { this.m_GroupCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_GROUP_Delete", strArrays, mGroupCode);
        }

        public string Delete(string GroupCode)
        {
            string[] strArrays = new string[] { "@GroupCode" };
            object[] groupCode = new object[] { GroupCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_GROUP_Delete", strArrays, groupCode);
        }

        public string Delete(SqlConnection myConnection, string GroupCode)
        {
            string[] strArrays = new string[] { "@GroupCode" };
            object[] groupCode = new object[] { GroupCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_GROUP_Delete", strArrays, groupCode);
        }

        public string Delete(SqlTransaction myTransaction, string GroupCode)
        {
            string[] strArrays = new string[] { "@GroupCode" };
            object[] groupCode = new object[] { GroupCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_GROUP_Delete", strArrays, groupCode);
        }

        public bool Exist(string GroupCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@GroupCode" };
            object[] groupCode = new object[] { GroupCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_GROUP_Get", strArrays, groupCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string GroupCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@GroupCode" };
            object[] groupCode = new object[] { GroupCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_GROUP_Get", strArrays, groupCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = (sqlDataReader["BranchCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchCode"]));
                    this.m_BranchName = (sqlDataReader["BranchName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchName"]));
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_GroupName = Convert.ToString(sqlDataReader["GroupName"]);
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
            string[] strArrays = new string[] { "@GroupCode" };
            object[] groupCode = new object[] { this.GroupCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_GROUP_Get", strArrays, groupCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = (sqlDataReader["BranchCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchCode"]));
                    this.m_BranchName = (sqlDataReader["BranchName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchName"]));
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_GroupName = Convert.ToString(sqlDataReader["GroupName"]);
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

        public string Get(SqlTransaction myTransaction, string GroupCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@GroupCode" };
            object[] groupCode = new object[] { GroupCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_GROUP_Get", strArrays, groupCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = (sqlDataReader["BranchCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchCode"]));
                    this.m_BranchName = (sqlDataReader["BranchName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchName"]));
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_GroupName = Convert.ToString(sqlDataReader["GroupName"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_GROUP_GetList");
        }

        public DataTable GetListByDepartment(string DepartmentCode)
        {
            string[] strArrays = new string[] { "@DepartmentCode" };
            object[] departmentCode = new object[] { DepartmentCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_GROUP_GetListByDepartment", strArrays, departmentCode);
        }

        public string GetName(string GroupName)
        {
            string str = "";
            string[] strArrays = new string[] { "@GroupName" };
            object[] groupName = new object[] { GroupName };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("Select gr.*, de.DepartmentName,br.BranchCode,br.BranchName,\r\nsu.SubsidiaryCode,su.SubsidiaryName\r\n\tFrom [HRM_GROUP] gr\r\n\tinner join [HRM_DEPARTMENT] de on gr.DepartmentCode=de.DepartmentCode\r\n\tleft join [HRM_BRANCH] br on de.BranchCode=br.BranchCode\r\n\tleft join [HRM_SUBSIDIARY] su on (CASE de.SubsidiaryCode\r\n\t\t\twhen null then br.SubsidiaryCode\r\n\t\t\twhen '' then br.SubsidiaryCode\r\n\t\t\telse de.SubsidiaryCode\r\n\t\t\tEND)=su.SubsidiaryCode\r\n Where \r\n    [GroupName] = @GroupName", strArrays, groupName);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = (sqlDataReader["BranchCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchCode"]));
                    this.m_BranchName = (sqlDataReader["BranchName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchName"]));
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_GroupName = Convert.ToString(sqlDataReader["GroupName"]);
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

        public string GetName(string DepartmentCode, string GroupName)
        {
            string str = "";
            string[] strArrays = new string[] { "@DepartmentCode", "@GroupName" };
            object[] departmentCode = new object[] { DepartmentCode, GroupName };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("Select gr.*, de.DepartmentName,br.BranchCode,br.BranchName,\r\nsu.SubsidiaryCode,su.SubsidiaryName\r\n\tFrom [HRM_GROUP] gr\r\n\tinner join [HRM_DEPARTMENT] de on gr.DepartmentCode=de.DepartmentCode\r\n\tleft join [HRM_BRANCH] br on de.BranchCode=br.BranchCode\r\n\tleft join [HRM_SUBSIDIARY] su on (CASE de.SubsidiaryCode\r\n\t\t\twhen null then br.SubsidiaryCode\r\n\t\t\twhen '' then br.SubsidiaryCode\r\n\t\t\telse de.SubsidiaryCode\r\n\t\t\tEND)=su.SubsidiaryCode\r\n Where \r\n    [GroupName] = @GroupName\r\nand gr.DepartmentCode = @DepartmentCode", strArrays, departmentCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = (sqlDataReader["BranchCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchCode"]));
                    this.m_BranchName = (sqlDataReader["BranchName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BranchName"]));
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_GroupName = Convert.ToString(sqlDataReader["GroupName"]);
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
            string[] strArrays = new string[] { "@GroupCode", "@DepartmentCode", "@GroupName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mGroupCode = new object[] { this.m_GroupCode, this.m_DepartmentCode, this.m_GroupName, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_GROUP_Insert", strArrays1, mGroupCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@GroupCode", "@DepartmentCode", "@GroupName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mGroupCode = new object[] { this.m_GroupCode, this.m_DepartmentCode, this.m_GroupName, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_GROUP_Insert", strArrays1, mGroupCode);
        }

        public string Insert(string GroupCode, string GroupName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@GroupCode", "@DepartmentCode", "@GroupName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] groupCode = new object[] { GroupCode, this.DepartmentCode, GroupName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_GROUP_Insert", strArrays1, groupCode);
        }

        public string Insert(SqlConnection myConnection, string GroupCode, string DepartmentCode, string GroupName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@GroupCode", "@DepartmentCode", "@GroupName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] groupCode = new object[] { GroupCode, DepartmentCode, GroupName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_GROUP_Insert", strArrays1, groupCode);
        }

        public string Insert(SqlTransaction myTransaction, string GroupCode, string DepartmentCode, string GroupName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@GroupCode", "@DepartmentCode", "@GroupName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] groupCode = new object[] { GroupCode, DepartmentCode, GroupName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_GROUP_Insert", strArrays1, groupCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_GROUP", "GroupCode", "TN");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@GroupCode", "@DepartmentCode", "@GroupName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mGroupCode = new object[] { this.m_GroupCode, this.m_DepartmentCode, this.m_GroupName, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_GROUP_Update", strArrays1, mGroupCode);
        }

        public string Update(string GroupCode, string DepartmentCode, string GroupName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@GroupCode", "@DepartmentCode", "@GroupName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] groupCode = new object[] { GroupCode, DepartmentCode, GroupName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_GROUP_Update", strArrays1, groupCode);
        }

        public string Update(SqlConnection myConnection, string GroupCode, string DepartmentCode, string GroupName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@GroupCode", "@DepartmentCode", "@GroupName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] groupCode = new object[] { GroupCode, DepartmentCode, GroupName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_GROUP_Update", strArrays1, groupCode);
        }

        public string Update(SqlTransaction myTransaction, string GroupCode, string DepartmentCode, string GroupName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@GroupCode", "@DepartmentCode", "@GroupName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] groupCode = new object[] { GroupCode, DepartmentCode, GroupName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_GROUP_Update", strArrays1, groupCode);
        }


    }
}
