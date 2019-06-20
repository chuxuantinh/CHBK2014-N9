using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using CHBK2014_N9.Data.Helper;
//using CHBK2014_N9.Security;
using CHBK2014_N9.Utils.Lib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
  public static  class MyRule
    {

        private static string m_Goup_ID;

        private static string m_Object_ID;

        private static string m_Rule_ID;

        private static bool m_AllowAdd;

        private static bool m_AllowDelete;

        private static bool m_AllowEdit;

        private static bool m_AllowAccess;

        private static bool m_AllowPrint;

        private static bool m_AllowExport;

        private static bool m_AllowImport;

        private static bool m_Active;
        public static BarItemVisibility Accessed
        {
            get
            {
                return (!MyRule.m_AllowAccess ? BarItemVisibility.Never : BarItemVisibility.Always);
            }
        }

        public static bool Active
        {
            get
            {
                return MyRule.m_Active;
            }
            set
            {
                MyRule.m_Active = value;
            }
        }

        public static BarItemVisibility Added
        {
            get
            {
                return (!MyRule.m_AllowAdd ? BarItemVisibility.Never : BarItemVisibility.Always);
            }
        }

        public static bool AllowAccess
        {
            get
            {
                return MyRule.m_AllowAccess;
            }
            set
            {
                MyRule.m_AllowAccess = value;
            }
        }

        public static bool AllowAdd
        {
            get
            {
                return MyRule.m_AllowAdd;
            }
            set
            {
                MyRule.m_AllowAdd = value;
            }
        }

        public static bool AllowDelete
        {
            get
            {
                return MyRule.m_AllowDelete;
            }
            set
            {
                MyRule.m_AllowDelete = value;
            }
        }

        public static bool AllowEdit
        {
            get
            {
                return MyRule.m_AllowEdit;
            }
            set
            {
                MyRule.m_AllowEdit = value;
            }
        }

        public static bool AllowExport
        {
            get
            {
                return MyRule.m_AllowExport;
            }
            set
            {
                MyRule.m_AllowExport = value;
            }
        }

        public static bool AllowImport
        {
            get
            {
                return MyRule.m_AllowImport;
            }
            set
            {
                MyRule.m_AllowImport = value;
            }
        }

        public static bool AllowPrint
        {
            get
            {
                return MyRule.m_AllowPrint;
            }
            set
            {
                MyRule.m_AllowPrint = value;
            }
        }

        public static string Copyright
        {
            get
            {
                return "Công ty Phần mềm CT";
            }
        }

        public static BarItemVisibility Deleted
        {
            get
            {
                return (!MyRule.m_AllowDelete ? BarItemVisibility.Never : BarItemVisibility.Always);
            }
        }

        public static BarItemVisibility Edited
        {
            get
            {
                return (!MyRule.m_AllowEdit ? BarItemVisibility.Never : BarItemVisibility.Always);
            }
        }

        public static BarItemVisibility Exported
        {
            get
            {
                return (!MyRule.m_AllowExport ? BarItemVisibility.Never : BarItemVisibility.Always);
            }
        }

        public static string Goup_ID
        {
            get
            {
                return MyRule.m_Goup_ID;
            }
            set
            {
                MyRule.m_Goup_ID = value;
            }
        }

        public static BarItemVisibility Imported
        {
            get
            {
                return (!MyRule.m_AllowImport ? BarItemVisibility.Never : BarItemVisibility.Always);
            }
        }

        public static string Object_ID
        {
            get
            {
                return MyRule.m_Object_ID;
            }
            set
            {
                MyRule.m_Object_ID = value;
            }
        }

        public static BarItemVisibility Printed
        {
            get
            {
                return (!MyRule.m_AllowPrint ? BarItemVisibility.Never : BarItemVisibility.Always);
            }
        }

        public static string ProductName
        {
            get
            {
                return "Class SYS_USER_RULE";
            }
        }

        public static string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public static string Rule_ID
        {
            get
            {
                return MyRule.m_Rule_ID;
            }
            set
            {
                MyRule.m_Rule_ID = value;
            }
        }

        public static object MsgResc { get; private set; }

        //public static void AddCombo(System.Windows.Forms.ComboBox combo)
        //{
        //    MyLib.TableToComboBoxcombo, MyRule.GetList(), "SYS_USER_RULEName", "SYS_USER_RULEID");
        //}

        //public static void AddComboAll(System.Windows.Forms.ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = MyRule.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["SYS_USER_RULEID"] = "All";
        //    dataRow["SYS_USER_RULEName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "SYS_USER_RULEName", "SYS_USER_RULEID");
        //}

        public static bool Check(MyRule.EnumRule rule, string myObject)
        {
            bool allowAccess;
            if (!(MyRule.Get(MyLogin.RoleId, myObject) != "OK"))
            {
                switch (rule)
                {
                    case MyRule.EnumRule.AllowAccess:
                        {
                            allowAccess = MyRule.AllowAccess;
                            break;
                        }
                    case MyRule.EnumRule.AllowAdd:
                        {
                            allowAccess = MyRule.AllowAdd;
                            break;
                        }
                    case MyRule.EnumRule.AllowDelete:
                        {
                            allowAccess = MyRule.AllowDelete;
                            break;
                        }
                    case MyRule.EnumRule.AllowEdit:
                        {
                            allowAccess = MyRule.AllowEdit;
                            break;
                        }
                    case MyRule.EnumRule.AllowPrint:
                        {
                            allowAccess = MyRule.AllowPrint;
                            break;
                        }
                    case MyRule.EnumRule.AllowExport:
                        {
                            allowAccess = MyRule.AllowExport;
                            break;
                        }
                    case MyRule.EnumRule.AllowImport:
                        {
                            allowAccess = MyRule.AllowImport;
                            break;
                        }
                    default:
                        {
                            allowAccess = true;
                            break;
                        }
                }
            }
            else
            {
                allowAccess = false;
            }
            return allowAccess;
        }

        public static bool Check(string myObject)
        {
            return MyRule.Check(MyRule.EnumRule.All, myObject);
        }

        public static string CreateKey()
        {
            return MyRule.CreateKey("");
        }

        public static string CreateKey(string key)
        {
            return SqlHelper.GenCode(key);
        }

        public static string CreateKey(SqlTransaction myTransaction, string key)
        {
            return SqlHelper.GenCode(myTransaction, key);
        }

        public static string CreateKey(SqlTransaction myTransaction)
        {
            return SqlHelper.GenCode(myTransaction, "");
        }

        public static string Delete()
        {
            return MyRule.Delete(MyRule.m_Goup_ID, MyRule.m_Object_ID);
        }

        public static string Delete(SqlConnection myConnection)
        {
            return MyRule.Delete(myConnection, MyRule.m_Goup_ID, MyRule.m_Object_ID);
        }

        public static string Delete(SqlTransaction myTransaction)
        {
            return MyRule.Delete(MyRule.m_Goup_ID, MyRule.m_Object_ID);
        }

        public static string Delete(string Goup_ID, string Object_ID)
        {
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID" };
            object[] goupID = new object[] { Goup_ID, Object_ID };
            return (new SqlHelper()).ExecuteNonQuery("SYS_USER_RULE_Delete", strArrays, goupID);
        }

        public static string Delete(SqlConnection myConnection, string Goup_ID, string Object_ID)
        {
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID" };
            object[] goupID = new object[] { Goup_ID, Object_ID };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "SYS_USER_RULE_Delete", strArrays, goupID);
        }

        public static string Delete(SqlTransaction myTransaction, string Goup_ID, string Object_ID)
        {
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID" };
            object[] goupID = new object[] { Goup_ID, Object_ID };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_USER_RULE_Delete", strArrays, goupID);
        }

        public static bool Exist()
        {
            return MyRule.Exist(MyRule.m_Goup_ID, MyRule.m_Object_ID);
        }

        public static bool Exist(SqlTransaction myTransaction)
        {
            return MyRule.Exist(myTransaction, MyRule.m_Goup_ID, MyRule.m_Object_ID);
        }

        public static bool Exist(string Goup_ID, string Object_ID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID" };
            object[] goupID = new object[] { Goup_ID, Object_ID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_USER_RULE_Get", strArrays, goupID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public static bool Exist(SqlTransaction myTransaction, string Goup_ID, string Object_ID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID" };
            object[] goupID = new object[] { Goup_ID, Object_ID };
            SqlDataReader sqlDataReader = (new SqlHelper()).ExecuteReader(myTransaction, "SYS_USER_RULE_Get", strArrays, goupID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public static string Get()
        {
            return MyRule.Get(MyRule.Goup_ID, MyRule.Object_ID);
        }

        public static string Get(SqlConnection myConnection)
        {
            return MyRule.Get(myConnection, MyRule.Goup_ID, MyRule.Object_ID);
        }

        public static string Get(SqlTransaction myTransaction)
        {
            return MyRule.Get(myTransaction, MyRule.Goup_ID, MyRule.Object_ID);
        }

        public static string Get(string Goup_ID, string Object_ID)
        {
            string str = "";
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID" };
            object[] goupID = new object[] { Goup_ID, Object_ID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("SYS_USER_RULE_Get", strArrays, goupID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    MyRule.m_Goup_ID = Convert.ToString(sqlDataReader["Goup_ID"]);
                    MyRule.m_Object_ID = Convert.ToString(sqlDataReader["Object_ID"]);
                    MyRule.m_Rule_ID = Convert.ToString(sqlDataReader["Rule_ID"]);
                    MyRule.m_AllowAdd = Convert.ToBoolean(sqlDataReader["AllowAdd"]);
                    MyRule.m_AllowDelete = Convert.ToBoolean(sqlDataReader["AllowDelete"]);
                    MyRule.m_AllowEdit = Convert.ToBoolean(sqlDataReader["AllowEdit"]);
                    MyRule.m_AllowAccess = Convert.ToBoolean(sqlDataReader["AllowAccess"]);
                    MyRule.m_AllowPrint = Convert.ToBoolean(sqlDataReader["AllowPrint"]);
                    MyRule.m_AllowExport = Convert.ToBoolean(sqlDataReader["AllowExport"]);
                    MyRule.m_AllowImport = Convert.ToBoolean(sqlDataReader["AllowImport"]);
                    MyRule.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlDataReader = null;
            }
            sqlHelper.Close();
            return str;
        }

        public static string Get(SqlConnection myConnection, string Goup_ID, string Object_ID)
        {
            string str = "";
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID" };
            object[] goupID = new object[] { Goup_ID, Object_ID };
            SqlDataReader sqlDataReader = (new SqlHelper()).ExecuteReader(myConnection, "SYS_USER_RULE_Get", strArrays, goupID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    MyRule.m_Goup_ID = Convert.ToString(sqlDataReader["Goup_ID"]);
                    MyRule.m_Object_ID = Convert.ToString(sqlDataReader["Object_ID"]);
                    MyRule.m_Rule_ID = Convert.ToString(sqlDataReader["Rule_ID"]);
                    MyRule.m_AllowAdd = Convert.ToBoolean(sqlDataReader["AllowAdd"]);
                    MyRule.m_AllowDelete = Convert.ToBoolean(sqlDataReader["AllowDelete"]);
                    MyRule.m_AllowEdit = Convert.ToBoolean(sqlDataReader["AllowEdit"]);
                    MyRule.m_AllowAccess = Convert.ToBoolean(sqlDataReader["AllowAccess"]);
                    MyRule.m_AllowPrint = Convert.ToBoolean(sqlDataReader["AllowPrint"]);
                    MyRule.m_AllowExport = Convert.ToBoolean(sqlDataReader["AllowExport"]);
                    MyRule.m_AllowImport = Convert.ToBoolean(sqlDataReader["AllowImport"]);
                    MyRule.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public static string Get(SqlTransaction myTransaction, string Goup_ID, string Object_ID)
        {
            string str = "";
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID" };
            object[] goupID = new object[] { Goup_ID, Object_ID };
            SqlDataReader sqlDataReader = (new SqlHelper()).ExecuteReader(myTransaction, "SYS_USER_RULE_Get", strArrays, goupID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    MyRule.m_Goup_ID = Convert.ToString(sqlDataReader["Goup_ID"]);
                    MyRule.m_Object_ID = Convert.ToString(sqlDataReader["Object_ID"]);
                    MyRule.m_Rule_ID = Convert.ToString(sqlDataReader["Rule_ID"]);
                    MyRule.m_AllowAdd = Convert.ToBoolean(sqlDataReader["AllowAdd"]);
                    MyRule.m_AllowDelete = Convert.ToBoolean(sqlDataReader["AllowDelete"]);
                    MyRule.m_AllowEdit = Convert.ToBoolean(sqlDataReader["AllowEdit"]);
                    MyRule.m_AllowAccess = Convert.ToBoolean(sqlDataReader["AllowAccess"]);
                    MyRule.m_AllowPrint = Convert.ToBoolean(sqlDataReader["AllowPrint"]);
                    MyRule.m_AllowExport = Convert.ToBoolean(sqlDataReader["AllowExport"]);
                    MyRule.m_AllowImport = Convert.ToBoolean(sqlDataReader["AllowImport"]);
                    MyRule.m_Active = Convert.ToBoolean(sqlDataReader["Active"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public static DataTable GetList()
        {
            return (new SqlHelper()).ExecuteDataTable("SYS_USER_RULE_GetList");
        }

        public static DataTable GetList(string Goup_ID, string Language_Id, string Owner)
        {
            string[] strArrays = new string[] { "@Goup_ID", "@Language_Id", "@Owner" };
            object[] goupID = new object[] { Goup_ID, Language_Id, Owner };
            return (new SqlHelper()).ExecuteDataTable("Permision", strArrays, goupID);
        }

        public static string Insert()
        {
            string str = MyRule.Insert(MyRule.m_Goup_ID, MyRule.m_Object_ID, MyRule.m_Rule_ID, MyRule.m_AllowAdd, MyRule.m_AllowDelete, MyRule.m_AllowEdit, MyRule.m_AllowAccess, MyRule.m_AllowPrint, MyRule.m_AllowExport, MyRule.m_AllowImport, MyRule.m_Active);
            return str;
        }

        public static string Insert(SqlTransaction myTransaction)
        {
            string str = MyRule.Insert(myTransaction, MyRule.m_Goup_ID, MyRule.m_Object_ID, MyRule.m_Rule_ID, MyRule.m_AllowAdd, MyRule.m_AllowDelete, MyRule.m_AllowEdit, MyRule.m_AllowAccess, MyRule.m_AllowPrint, MyRule.m_AllowExport, MyRule.m_AllowImport, MyRule.m_Active);
            return str;
        }

        public static string Insert(SqlConnection myConnection)
        {
            string str = MyRule.Insert(myConnection, MyRule.m_Goup_ID, MyRule.m_Object_ID, MyRule.m_Rule_ID, MyRule.m_AllowAdd, MyRule.m_AllowDelete, MyRule.m_AllowEdit, MyRule.m_AllowAccess, MyRule.m_AllowPrint, MyRule.m_AllowExport, MyRule.m_AllowImport, MyRule.m_Active);
            return str;
        }

        public static string Insert(string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
        {
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID", "@Rule_ID", "@AllowAdd", "@AllowDelete", "@AllowEdit", "@AllowAccess", "@AllowPrint", "@AllowExport", "@AllowImport", "@Active" };
            string[] strArrays1 = strArrays;
            object[] goupID = new object[] { Goup_ID, Object_ID, Rule_ID, AllowAdd, AllowDelete, AllowEdit, AllowAccess, AllowPrint, AllowExport, AllowImport, Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_USER_RULE_Insert", strArrays1, goupID);
        }

        public static string Insert(SqlConnection myConnection, string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
        {
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID", "@Rule_ID", "@AllowAdd", "@AllowDelete", "@AllowEdit", "@AllowAccess", "@AllowPrint", "@AllowExport", "@AllowImport", "@Active" };
            string[] strArrays1 = strArrays;
            object[] goupID = new object[] { Goup_ID, Object_ID, Rule_ID, AllowAdd, AllowDelete, AllowEdit, AllowAccess, AllowPrint, AllowExport, AllowImport, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "SYS_USER_RULE_Insert", strArrays1, goupID);
        }

        public static string Insert(SqlTransaction myTransaction, string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
        {
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID", "@Rule_ID", "@AllowAdd", "@AllowDelete", "@AllowEdit", "@AllowAccess", "@AllowPrint", "@AllowExport", "@AllowImport", "@Active" };
            string[] strArrays1 = strArrays;
            object[] goupID = new object[] { Goup_ID, Object_ID, Rule_ID, AllowAdd, AllowDelete, AllowEdit, AllowAccess, AllowPrint, AllowExport, AllowImport, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_USER_RULE_Insert", strArrays1, goupID);
        }

        public static bool IsAccess(string myObject)
        {
            return MyRule.Check(MyRule.EnumRule.AllowAccess, myObject);
        }

        public static bool IsAdd(string myObject)
        {
            return MyRule.Check(MyRule.EnumRule.AllowAdd, myObject);
        }

        public static bool IsDelete(string myObject)
        {
            return MyRule.Check(MyRule.EnumRule.AllowDelete, myObject);
        }

        public static bool IsEdit(string myObject)
        {
            return MyRule.Check(MyRule.EnumRule.AllowEdit, myObject);
        }

        public static bool IsExport(string myObject)
        {
            return MyRule.Check(MyRule.EnumRule.AllowExport, myObject);
        }

        public static bool IsImport(string myObject)
        {
            return MyRule.Check(MyRule.EnumRule.AllowImport, myObject);
        }

        public static bool IsPrint(string myObject)
        {
            return MyRule.Check(MyRule.EnumRule.AllowPrint, myObject);
        }

        public static string NewID()
        {
            return SqlHelper.GenCode("SYS_USER_RULE", "SYS_USER_RULEID", "");
        }

        //public static void Notify()
        //{
        //    XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //}

        //public static void Notify(IWin32Window sender)
        //{
        //    XtraMessageBox.Show(sender, MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //}

        public static string Update()
        {
            string str = MyRule.Update(MyRule.m_Goup_ID, MyRule.m_Object_ID, MyRule.m_Rule_ID, MyRule.m_AllowAdd, MyRule.m_AllowDelete, MyRule.m_AllowEdit, MyRule.m_AllowAccess, MyRule.m_AllowPrint, MyRule.m_AllowExport, MyRule.m_AllowImport, MyRule.m_Active);
            return str;
        }

        public static string Update(SqlConnection myConnection)
        {
            string str = MyRule.Update(myConnection, MyRule.m_Goup_ID, MyRule.m_Object_ID, MyRule.m_Rule_ID, MyRule.m_AllowAdd, MyRule.m_AllowDelete, MyRule.m_AllowEdit, MyRule.m_AllowAccess, MyRule.m_AllowPrint, MyRule.m_AllowExport, MyRule.m_AllowImport, MyRule.m_Active);
            return str;
        }

        public static string Update(SqlTransaction myTransaction)
        {
            string str = MyRule.Update(myTransaction, MyRule.m_Goup_ID, MyRule.m_Object_ID, MyRule.m_Rule_ID, MyRule.m_AllowAdd, MyRule.m_AllowDelete, MyRule.m_AllowEdit, MyRule.m_AllowAccess, MyRule.m_AllowPrint, MyRule.m_AllowExport, MyRule.m_AllowImport, MyRule.m_Active);
            return str;
        }

        public static string Update(string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
        {
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID", "@Rule_ID", "@AllowAdd", "@AllowDelete", "@AllowEdit", "@AllowAccess", "@AllowPrint", "@AllowExport", "@AllowImport", "@Active" };
            string[] strArrays1 = strArrays;
            object[] goupID = new object[] { Goup_ID, Object_ID, Rule_ID, AllowAdd, AllowDelete, AllowEdit, AllowAccess, AllowPrint, AllowExport, AllowImport, Active };
            return (new SqlHelper()).ExecuteNonQuery("SYS_USER_RULE_Update", strArrays1, goupID);
        }

        public static string Update(SqlConnection myConnection, string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
        {
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID", "@Rule_ID", "@AllowAdd", "@AllowDelete", "@AllowEdit", "@AllowAccess", "@AllowPrint", "@AllowExport", "@AllowImport", "@Active" };
            string[] strArrays1 = strArrays;
            object[] goupID = new object[] { Goup_ID, Object_ID, Rule_ID, AllowAdd, AllowDelete, AllowEdit, AllowAccess, AllowPrint, AllowExport, AllowImport, Active };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "SYS_USER_RULE_Update", strArrays1, goupID);
        }

        public static string Update(SqlTransaction myTransaction, string Goup_ID, string Object_ID, string Rule_ID, bool AllowAdd, bool AllowDelete, bool AllowEdit, bool AllowAccess, bool AllowPrint, bool AllowExport, bool AllowImport, bool Active)
        {
            string[] strArrays = new string[] { "@Goup_ID", "@Object_ID", "@Rule_ID", "@AllowAdd", "@AllowDelete", "@AllowEdit", "@AllowAccess", "@AllowPrint", "@AllowExport", "@AllowImport", "@Active" };
            string[] strArrays1 = strArrays;
            object[] goupID = new object[] { Goup_ID, Object_ID, Rule_ID, AllowAdd, AllowDelete, AllowEdit, AllowAccess, AllowPrint, AllowExport, AllowImport, Active };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "SYS_USER_RULE_Update", strArrays1, goupID);
        }

        public enum EnumRule
        {
            All,
            AllowAccess,
            AllowAdd,
            AllowDelete,
            AllowEdit,
            AllowPrint,
            AllowExport,
            AllowImport
        }


        public static void Notify()
        {
          //  XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Notify(IWin32Window sender)
        {
          //  XtraMessageBox.Show(sender, MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
