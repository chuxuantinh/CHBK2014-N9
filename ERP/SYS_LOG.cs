using CHBK2014_N9.Common.Enviroment;
using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;

namespace CHBK2014_N9.ERP
{
  public  class SYS_LOG
    {

        private long m_SYS_ID;

        private string m_MChine;

        private string m_AccountWin;

        private string m_UserID;

        private string m_UserName;

        private DateTime m_Created;

        private string m_Module;

        private int m_Action;

        private string m_Action_Name;

        private string m_Reference;

        private string m_IPLan;

        private string m_IPWan;

        private string m_Mac;

        private string m_DeviceName;

        private string m_Description;

        private bool m_Active;

        [Category("Column")]
        [DisplayName("AccountWin")]
        public string AccountWin
        {
            get
            {
                return this.m_AccountWin;
            }
            set
            {
                this.m_AccountWin = value;
            }
        }

        [Category("Column")]
        [DisplayName("Action")]
        public int Action
        {
            get
            {
                return this.m_Action;
            }
            set
            {
                this.m_Action = value;
            }
        }

        [Category("Column")]
        [DisplayName("Action_Name")]
        public string Action_Name
        {
            get
            {
                return this.m_Action_Name;
            }
            set
            {
                this.m_Action_Name = value;
            }
        }

        [Category("Column")]
        [DisplayName("Active")]
        public bool Active
        {
            get
            {
                return this.m_Active;
            }
            set
            {
                this.m_Active = value;
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public string Copyright
        {
            get
            {
                return "Công Ty Phần Mềm Hoàn Hảo";
            }
        }

        [Category("Column")]
        [DisplayName("Created")]
        public DateTime Created
        {
            get
            {
                return this.m_Created;
            }
            set
            {
                this.m_Created = value;
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
        [DisplayName("DeviceName")]
        public string DeviceName
        {
            get
            {
                return this.m_DeviceName;
            }
            set
            {
                this.m_DeviceName = value;
            }
        }

        [Category("Column")]
        [DisplayName("IPLan")]
        public string IPLan
        {
            get
            {
                return this.m_IPLan;
            }
            set
            {
                this.m_IPLan = value;
            }
        }

        [Category("Column")]
        [DisplayName("IPWan")]
        public string IPWan
        {
            get
            {
                return this.m_IPWan;
            }
            set
            {
                this.m_IPWan = value;
            }
        }

        [Category("Column")]
        [DisplayName("Mac")]
        public string Mac
        {
            get
            {
                return this.m_Mac;
            }
            set
            {
                this.m_Mac = value;
            }
        }

        [Category("Column")]
        [DisplayName("MChine")]
        public string MChine
        {
            get
            {
                return this.m_MChine;
            }
            set
            {
                this.m_MChine = value;
            }
        }

        [Category("Column")]
        [DisplayName("Module")]
        public string Module
        {
            get
            {
                return this.m_Module;
            }
            set
            {
                this.m_Module = value;
            }
        }

        public string Product
        {
            get
            {
                return "Class SYS_LOG";
            }
        }

        [Category("Column")]
        [DisplayName("Reference")]
        public string Reference
        {
            get
            {
                return this.m_Reference;
            }
            set
            {
                this.m_Reference = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("SYS_ID")]
        public long SYS_ID
        {
            get
            {
                return this.m_SYS_ID;
            }
            set
            {
                this.m_SYS_ID = value;
            }
        }

        [Category("Column")]
        [DisplayName("UserID")]
        public string UserID
        {
            get
            {
                return this.m_UserID;
            }
            set
            {
                this.m_UserID = value;
            }
        }

        [Category("Column")]
        [DisplayName("UserName")]
        public string UserName
        {
            get
            {
                return this.m_UserName;
            }
            set
            {
                this.m_UserName = value;
            }
        }

        public SYS_LOG()
        {
            this.m_SYS_ID = (long)0;
            this.m_MChine = "";
            this.m_AccountWin = "";
            this.m_UserID = "";
            this.m_UserName = "";
            this.m_Created = DateTime.Now;
            this.m_Module = "";
            this.m_Action = 0;
            this.m_Action_Name = "";
            this.m_Reference = "";
            this.m_IPLan = "";
            this.m_IPWan = "";
            this.m_Mac = "";
            this.m_DeviceName = "";
            this.m_Description = "";
            this.m_Active = true;
        }

        public SYS_LOG(long SYS_ID, string MChine, string AccountWin, string UserID, string UserName, DateTime Created, string Module, int Action, string Action_Name, string Reference, string IPLan, string IPWan, string Mac, string DeviceName, string Description, bool Active)
        {
            this.m_SYS_ID = SYS_ID;
            this.m_MChine = MChine;
            this.m_AccountWin = AccountWin;
            this.m_UserID = UserID;
            this.m_UserName = UserName;
            this.m_Created = Created;
            this.m_Module = Module;
            this.m_Action = Action;
            this.m_Action_Name = Action_Name;
            this.m_Reference = Reference;
            this.m_IPLan = IPLan;
            this.m_IPWan = IPWan;
            this.m_Mac = Mac;
            this.m_DeviceName = DeviceName;
            this.m_Description = Description;
            this.m_Active = Active;
        }

        public void Delete(long SYS_ID)
        {
            string[] strArrays = new string[] { "@SYS_ID" };
            object[] sYSID = new object[] { SYS_ID };
            (new SqlHelper()).ExecuteNonQuery("SYS_LOG_Delete", strArrays, sYSID);
        }

        public bool Exist(DateTime from, DateTime to)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@From", "@To" };
            object[] objArray = new object[] { from, to };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_LOG_GetList_ByDate", strArrays, objArray);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public DataTable GetList(DateTime from, DateTime to)
        {
            string[] strArrays = new string[] { "@From", "@To" };
            object[] objArray = new object[] { from, to };
            return (new SqlHelper()).ExecuteDataTable("SYS_LOG_GetList_ByDate", strArrays, objArray);
        }

        public static void Insert(string module, string actionName, string reference)
        {
            string[] strArrays = new string[] { "@MChine", "@AccountWin", "@UserID", "@UserName", "@Created", "@Module", "@Action", "@Action_Name", "@Reference", "@IPLan", "@IPWan", "@Mac", "@DeviceName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            string name = WindowsIdentity.GetCurrent().Name;
            name = name.Substring(name.IndexOf("\\") + 1);
            object[] machineName = new object[] { Environment.MachineName, name, MyLogin.UserId, MyLogin.AccountName, DateTime.Now, module, 0, actionName, reference, NetworkManager.NetworkInfo.Ip, NetworkManager.NetworkInfo.IpWan, NetworkManager.NetworkInfo.MacAddress, NetworkManager.NetworkInfo.DeviceName, null, null };
            strArrays = new string[] { actionName, " ", module, " - ", reference };
            machineName[13] = string.Concat(strArrays);
            machineName[14] = true;
            (new SqlHelper()).ExecuteNonQuery("SYS_LOG_Insert", strArrays1, machineName);
        }

        public static void Insert(string module, string actionName)
        {
            string[] strArrays = new string[] { "@MChine", "@AccountWin", "@UserID", "@UserName", "@Created", "@Module", "@Action", "@Action_Name", "@Reference", "@IPLan", "@IPWan", "@Mac", "@DeviceName", "@Description", "@Active" };
            string[] strArrays1 = strArrays;
            string name = WindowsIdentity.GetCurrent().Name;
            name = name.Substring(name.IndexOf("\\") + 1);
            object[] machineName = new object[] { Environment.MachineName, name, MyLogin.UserId, MyLogin.AccountName, DateTime.Now, module, 0, actionName, "", NetworkManager.NetworkInfo.Ip, NetworkManager.NetworkInfo.IpWan, NetworkManager.NetworkInfo.MacAddress, NetworkManager.NetworkInfo.DeviceName, string.Concat(actionName, " ", module), true };
            (new SqlHelper()).ExecuteNonQuery("SYS_LOG_Insert", strArrays1, machineName);
        }

    }
}
