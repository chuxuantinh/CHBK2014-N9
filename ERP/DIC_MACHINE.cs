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
  public  class DIC_MACHINE
    {

        private string m_MachineCode;

        private string m_MachineName;

        private string m_PortType;

        private string m_PortID;

        private string m_IP;

        private string m_Password;

        private string m_Com;

        [Category("Column")]
        [DisplayName("Com")]
        public string Com
        {
            get
            {
                return this.m_Com;
            }
            set
            {
                this.m_Com = value;
            }
        }

        [Category("Column")]
        [DisplayName("IP")]
        public string IP
        {
            get
            {
                return this.m_IP;
            }
            set
            {
                this.m_IP = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("MachineCode")]
        public string MachineCode
        {
            get
            {
                return this.m_MachineCode;
            }
            set
            {
                this.m_MachineCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("MachineName")]
        public string MachineName
        {
            get
            {
                return this.m_MachineName;
            }
            set
            {
                this.m_MachineName = value;
            }
        }

        [Category("Column")]
        [DisplayName("Password")]
        public string Password
        {
            get
            {
                return this.m_Password;
            }
            set
            {
                this.m_Password = value;
            }
        }

        [Category("Column")]
        [DisplayName("PortID")]
        public string PortID
        {
            get
            {
                return this.m_PortID;
            }
            set
            {
                this.m_PortID = value;
            }
        }

        [Category("Column")]
        [DisplayName("PortType")]
        public string PortType
        {
            get
            {
                return this.m_PortType;
            }
            set
            {
                this.m_PortType = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_MACHINE";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_MACHINE()
        {
            this.m_MachineCode = "";
            this.m_MachineName = "";
            this.m_PortType = "";
            this.m_PortID = "";
            this.m_IP = "";
            this.m_Password = "";
            this.m_Com = "";
        }

        public DIC_MACHINE(string MachineCode, string MachineName, string PortType, string PortID, string IP, string Password, string Com)
        {
            this.m_MachineCode = MachineCode;
            this.m_MachineName = MachineName;
            this.m_PortType = PortType;
            this.m_PortID = PortID;
            this.m_IP = IP;
            this.m_Password = Password;
            this.m_Com = Com;
        }

        public void AddCheckedListBox(CheckedListBoxControl checkList)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                CheckedListBoxItem checkedListBoxItem = new CheckedListBoxItem();
                string[] str = new string[] { row["MachineName"].ToString(), " - ", row["MachineCode"].ToString(), " (", null, null, null, null };
                DateTime dateTime = DateTime.Parse(row["BeginTime"].ToString());
                str[4] = dateTime.ToShortTimeString();
                str[5] = "->";
                dateTime = DateTime.Parse(row["EndTime"].ToString());
                str[6] = dateTime.ToShortTimeString();
                str[7] = ")";
                checkedListBoxItem.Description = string.Concat(str);
                checkedListBoxItem.Value = row["MachineCode"];
                checkList.Items.Add(checkedListBoxItem);
            }
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "MachineName", "MachineCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["MachineCode"] = "All";
        //    dataRow["MachineName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "MachineName", "MachineCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["MachineCode"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "MachineName";
            gridlookup.Properties.ValueMember = "MachineCode";
        }

        public void AddRepositoryGridLookupEdit(RepositoryItemGridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            gridlookup.DataSource = this.GetList();
            gridlookup.DisplayMember = "MachineName";
            gridlookup.ValueMember = "MachineCode";
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@MachineCode" };
            object[] mMachineCode = new object[] { this.m_MachineCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_MACHINE_Delete", strArrays, mMachineCode);
        }

        public string Delete(string MachineCode)
        {
            string[] strArrays = new string[] { "@MachineCode" };
            object[] machineCode = new object[] { MachineCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_MACHINE_Delete", strArrays, machineCode);
        }

        public string Delete(SqlConnection myConnection, string MachineCode)
        {
            string[] strArrays = new string[] { "@MachineCode" };
            object[] machineCode = new object[] { MachineCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_MACHINE_Delete", strArrays, machineCode);
        }

        public string Delete(SqlTransaction myTransaction, string MachineCode)
        {
            string[] strArrays = new string[] { "@MachineCode" };
            object[] machineCode = new object[] { MachineCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_MACHINE_Delete", strArrays, machineCode);
        }

        public bool Exist(string MachineCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@MachineCode" };
            object[] machineCode = new object[] { MachineCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_MACHINE_Get", strArrays, machineCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string MachineCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            object item2;
            object obj2;
            object item3;
            string str = "";
            string[] strArrays = new string[] { "@MachineCode" };
            object[] machineCode = new object[] { MachineCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_MACHINE_Get", strArrays, machineCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader["MachineCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["MachineCode"];
                    }
                    this.m_MachineCode = Convert.ToString(item);
                    if (sqlDataReader["MachineName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["MachineName"];
                    }
                    this.m_MachineName = Convert.ToString(obj);
                    if (sqlDataReader["PortType"] == DBNull.Value)
                    {
                        item1 = "";
                    }
                    else
                    {
                        item1 = sqlDataReader["PortType"];
                    }
                    this.m_PortType = Convert.ToString(item1);
                    if (sqlDataReader["PortID"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["PortID"];
                    }
                    this.m_PortID = Convert.ToString(obj1);
                    if (sqlDataReader["IP"] == DBNull.Value)
                    {
                        item2 = "";
                    }
                    else
                    {
                        item2 = sqlDataReader["IP"];
                    }
                    this.m_IP = Convert.ToString(item2);
                    if (sqlDataReader["Password"] == DBNull.Value)
                    {
                        obj2 = "";
                    }
                    else
                    {
                        obj2 = sqlDataReader["Password"];
                    }
                    this.m_Password = Convert.ToString(obj2);
                    if (sqlDataReader["Com"] == DBNull.Value)
                    {
                        item3 = "";
                    }
                    else
                    {
                        item3 = sqlDataReader["Com"];
                    }
                    this.m_Com = Convert.ToString(item3);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string MachineCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            object item2;
            object obj2;
            object item3;
            string str = "";
            string[] strArrays = new string[] { "@MachineCode" };
            object[] machineCode = new object[] { MachineCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_MACHINE_Get", strArrays, machineCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader["MachineCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["MachineCode"];
                    }
                    this.m_MachineCode = Convert.ToString(item);
                    if (sqlDataReader["MachineName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["MachineName"];
                    }
                    this.m_MachineName = Convert.ToString(obj);
                    if (sqlDataReader["PortType"] == DBNull.Value)
                    {
                        item1 = "";
                    }
                    else
                    {
                        item1 = sqlDataReader["PortType"];
                    }
                    this.m_PortType = Convert.ToString(item1);
                    if (sqlDataReader["PortID"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["PortID"];
                    }
                    this.m_PortID = Convert.ToString(obj1);
                    if (sqlDataReader["IP"] == DBNull.Value)
                    {
                        item2 = "";
                    }
                    else
                    {
                        item2 = sqlDataReader["IP"];
                    }
                    this.m_IP = Convert.ToString(item2);
                    if (sqlDataReader["Password"] == DBNull.Value)
                    {
                        obj2 = "";
                    }
                    else
                    {
                        obj2 = sqlDataReader["Password"];
                    }
                    this.m_Password = Convert.ToString(obj2);
                    if (sqlDataReader["Com"] == DBNull.Value)
                    {
                        item3 = "";
                    }
                    else
                    {
                        item3 = sqlDataReader["Com"];
                    }
                    this.m_Com = Convert.ToString(item3);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string MachineCode)
        {
            object item;
            object obj;
            object item1;
            object obj1;
            object item2;
            object obj2;
            object item3;
            string str = "";
            string[] strArrays = new string[] { "@MachineCode" };
            object[] machineCode = new object[] { MachineCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_MACHINE_Get", strArrays, machineCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader["MachineCode"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["MachineCode"];
                    }
                    this.m_MachineCode = Convert.ToString(item);
                    if (sqlDataReader["MachineName"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["MachineName"];
                    }
                    this.m_MachineName = Convert.ToString(obj);
                    if (sqlDataReader["PortType"] == DBNull.Value)
                    {
                        item1 = "";
                    }
                    else
                    {
                        item1 = sqlDataReader["PortType"];
                    }
                    this.m_PortType = Convert.ToString(item1);
                    if (sqlDataReader["PortID"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["PortID"];
                    }
                    this.m_PortID = Convert.ToString(obj1);
                    if (sqlDataReader["IP"] == DBNull.Value)
                    {
                        item2 = "";
                    }
                    else
                    {
                        item2 = sqlDataReader["IP"];
                    }
                    this.m_IP = Convert.ToString(item2);
                    if (sqlDataReader["Password"] == DBNull.Value)
                    {
                        obj2 = "";
                    }
                    else
                    {
                        obj2 = sqlDataReader["Password"];
                    }
                    this.m_Password = Convert.ToString(obj2);
                    if (sqlDataReader["Com"] == DBNull.Value)
                    {
                        item3 = "";
                    }
                    else
                    {
                        item3 = sqlDataReader["Com"];
                    }
                    this.m_Com = Convert.ToString(item3);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_MACHINE_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@MachineCode", "@MachineName", "@PortType", "@PortID", "@IP", "@Password", "@Com" };
            string[] strArrays1 = strArrays;
            object[] mMachineCode = new object[] { this.m_MachineCode, this.m_MachineName, this.m_PortType, this.m_PortID, this.m_IP, this.m_Password, this.Com };
            return (new SqlHelper()).ExecuteNonQuery("DIC_MACHINE_Insert", strArrays1, mMachineCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@MachineCode", "@MachineName", "@PortType", "@PortID", "@IP", "@Password", "@Com" };
            string[] strArrays1 = strArrays;
            object[] mMachineCode = new object[] { this.m_MachineCode, this.m_MachineName, this.m_PortType, this.m_PortID, this.m_IP, this.m_Password, this.Com };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_MACHINE_Insert", strArrays1, mMachineCode);
        }

        public string Insert(string MachineCode, string MachineName, string PortType, string PortID, string IP, string Password, string Com)
        {
            string[] strArrays = new string[] { "@MachineCode", "@MachineName", "@PortType", "@PortID", "@IP", "@Password", "@Com" };
            string[] strArrays1 = strArrays;
            object[] machineCode = new object[] { MachineCode, MachineName, PortType, PortID, IP, Password, Com };
            return (new SqlHelper()).ExecuteNonQuery("DIC_MACHINE_Insert", strArrays1, machineCode);
        }

        public string Insert(SqlConnection myConnection, string MachineCode, string MachineName, string PortType, string PortID, string IP, string Password, string Com)
        {
            string[] strArrays = new string[] { "@MachineCode", "@MachineName", "@PortType", "@PortID", "@IP", "@Password", "@Com" };
            string[] strArrays1 = strArrays;
            object[] machineCode = new object[] { MachineCode, MachineName, PortType, PortID, IP, Password, Com };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_MACHINE_Insert", strArrays1, machineCode);
        }

        public string Insert(SqlTransaction myTransaction, string MachineCode, string MachineName, string PortType, string PortID, string IP, string Password, string Com)
        {
            string[] strArrays = new string[] { "@MachineCode", "@MachineName", "@PortType", "@PortID", "@IP", "@Password", "@Com" };
            string[] strArrays1 = strArrays;
            object[] machineCode = new object[] { MachineCode, MachineName, PortType, PortID, IP, Password, Com };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_MACHINE_Insert", strArrays1, machineCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_MACHINE", "MachineCode", "");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@MachineCode", "@MachineName", "@PortType", "@PortID", "@IP", "@Password", "@Com" };
            string[] strArrays1 = strArrays;
            object[] mMachineCode = new object[] { this.m_MachineCode, this.MachineName, this.m_PortType, this.m_PortID, this.m_IP, this.m_Password, this.Com };
            return (new SqlHelper()).ExecuteNonQuery("DIC_MACHINE_Update", strArrays1, mMachineCode);
        }

        public string Update(string MachineCode, string MachineName, string PortType, string PortID, string IP, string Password, string Com)
        {
            string[] strArrays = new string[] { "@MachineCode", "@MachineName", "@PortType", "@PortID", "@IP", "@Password", "@Com" };
            string[] strArrays1 = strArrays;
            object[] machineCode = new object[] { MachineCode, MachineName, PortType, PortID, IP, Password, Com };
            return (new SqlHelper()).ExecuteNonQuery("DIC_MACHINE_Update", strArrays1, machineCode);
        }

        public string Update(SqlConnection myConnection, string MachineCode, string MachineName, string PortType, string PortID, string IP, string Password, string Com)
        {
            string[] strArrays = new string[] { "@MachineCode", "@MachineName", "@PortType", "@PortID", "@IP", "@Password", "@Com" };
            string[] strArrays1 = strArrays;
            object[] machineCode = new object[] { MachineCode, MachineName, PortType, PortID, IP, Password, Com };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_MACHINE_Update", strArrays1, machineCode);
        }

        public string Update(SqlTransaction myTransaction, string MachineCode, string MachineName, string PortType, string PortID, string IP, string Password, string Com)
        {
            string[] strArrays = new string[] { "@MachineCode", "@MachineName", "@PortType", "@PortID", "@IP", "@Password", "@Com" };
            string[] strArrays1 = strArrays;
            object[] machineCode = new object[] { MachineCode, MachineName, PortType, PortID, IP, Password, Com };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_MACHINE_Update", strArrays1, machineCode);
        }
    }
}
