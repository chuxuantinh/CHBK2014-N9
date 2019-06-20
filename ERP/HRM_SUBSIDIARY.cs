using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.Utils;
using CHBK2014_N9.Utils.Lib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
 public   class HRM_SUBSIDIARY
    {

        private string m_SubsidiaryCode;

        private string m_SubsidiaryName;

        private string m_Address;

        private string m_Phone;

        private string m_Fax;

        private string m_WebSite;

        private string m_Email;

        private string m_Tax;

        private string m_BankAccount;

        private string m_OpenedAt;

        private string m_BankAbbreviationName;

        private string m_BankBranch;

        private Image m_Photo;

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

        [Category("Column")]
        [DisplayName("BankAbbreviationName")]
        public string BankAbbreviationName
        {
            get
            {
                return this.m_BankAbbreviationName;
            }
            set
            {
                this.m_BankAbbreviationName = value;
            }
        }

        [Category("Column")]
        [DisplayName("BankAccount")]
        public string BankAccount
        {
            get
            {
                return this.m_BankAccount;
            }
            set
            {
                this.m_BankAccount = value;
            }
        }

        [Category("Column")]
        [DisplayName("BankBranch")]
        public string BankBranch
        {
            get
            {
                return this.m_BankBranch;
            }
            set
            {
                this.m_BankBranch = value;
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
        [DisplayName("Email")]
        public string Email
        {
            get
            {
                return this.m_Email;
            }
            set
            {
                this.m_Email = value;
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
        [DisplayName("OpenedAt")]
        public string OpenedAt
        {
            get
            {
                return this.m_OpenedAt;
            }
            set
            {
                this.m_OpenedAt = value;
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

        [Category("Column")]
        [DisplayName("Photo")]
        public Image Photo
        {
            get
            {
                return this.m_Photo;
            }
            set
            {
                this.m_Photo = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_SUBSIDIARY";
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

        [Category("Column")]
        [DisplayName("Tax")]
        public string Tax
        {
            get
            {
                return this.m_Tax;
            }
            set
            {
                this.m_Tax = value;
            }
        }

        [Category("Column")]
        [DisplayName("WebSite")]
        public string WebSite
        {
            get
            {
                return this.m_WebSite;
            }
            set
            {
                this.m_WebSite = value;
            }
        }

        public HRM_SUBSIDIARY()
        {
            this.m_SubsidiaryCode = "";
            this.m_SubsidiaryName = "";
            this.m_Address = "";
            this.m_Phone = "";
            this.m_Fax = "";
            this.m_WebSite = "";
            this.m_Email = "";
            this.m_Tax = "";
            this.m_BankAccount = "";
            this.m_OpenedAt = "";
            this.m_BankAbbreviationName = "";
            this.m_BankBranch = "";
            this.m_MinimumSalary = new decimal(0);
            this.m_PersonName = "";
            this.m_Quantity = 0;
            this.m_FactQuantity = 0;
            this.m_Description = "";
        }

        public HRM_SUBSIDIARY(string SubsidiaryCode, string SubsidiaryName, string Address, string Phone, string Fax, string WebSite, string Email, string Tax, string BankAccount, string OpenedAt, string BankAbbreviationName, string BankBranch, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            this.m_SubsidiaryCode = SubsidiaryCode;
            this.m_SubsidiaryName = SubsidiaryName;
            this.m_Address = Address;
            this.m_Phone = Phone;
            this.m_Fax = Fax;
            this.m_WebSite = WebSite;
            this.m_Email = Email;
            this.m_Tax = Tax;
            this.m_BankAccount = BankAccount;
            this.m_OpenedAt = OpenedAt;
            this.m_BankAbbreviationName = BankAbbreviationName;
            this.m_BankBranch = BankBranch;
            this.m_MinimumSalary = MinimumSalary;
            this.m_PersonName = PersonName;
            this.m_Quantity = Quantity;
            this.m_FactQuantity = FactQuantity;
            this.m_Description = Description;
        }

    //    public void AddCombo(ComboBox combo)
    //    {
    //        MyLib.TableToComboBox(combo, this.GetList(), "SubsidiaryName", "SubsidiaryCode");
    //    }

    //public void AddComboAll(ComboBox combo)
    //{
    //    DataTable dataTable = new DataTable();
    //    dataTable = this.GetList();
    //    DataRow dataRow = dataTable.NewRow();
    //    dataRow["SubsidiaryCode"] = "All";
    //    dataRow["SubsidiaryName"] = "Tất cả";
    //    dataTable.Rows.InsertAt(dataRow, 0);
    //    MyLib.TableToComboBox(combo, dataTable, "SubsidiaryName", "SubsidiaryCode");
    //}

    public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["SubsidiaryName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "SubsidiaryName";
            gridlookup.Properties.ValueMember = "SubsidiaryCode";
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup, string ValueMember)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "SubsidiaryName";
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
                    Description = row["SubsidiaryName"].ToString(),
                    Value = row["SubsidiaryCode"].ToString()
                };
                imgCombo.Properties.Items.Add(imageComboBoxItem1);
            }
            imgCombo.SelectedIndex = 0;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SubsidiaryCode" };
            object[] mSubsidiaryCode = new object[] { this.m_SubsidiaryCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SUBSIDIARY_Delete", strArrays, mSubsidiaryCode);
        }

        public string Delete(string SubsidiaryCode)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode" };
            object[] subsidiaryCode = new object[] { SubsidiaryCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SUBSIDIARY_Delete", strArrays, subsidiaryCode);
        }

        public string Delete(SqlConnection myConnection, string SubsidiaryCode)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode" };
            object[] subsidiaryCode = new object[] { SubsidiaryCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SUBSIDIARY_Delete", strArrays, subsidiaryCode);
        }

        public string Delete(SqlTransaction myTransaction, string SubsidiaryCode)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode" };
            object[] subsidiaryCode = new object[] { SubsidiaryCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SUBSIDIARY_Delete", strArrays, subsidiaryCode);
        }

        public bool Exist(string SubsidiaryCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SubsidiaryCode" };
            object[] subsidiaryCode = new object[] { SubsidiaryCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SUBSIDIARY_Get", strArrays, subsidiaryCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string SubsidiaryCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SubsidiaryCode" };
            object[] subsidiaryCode = new object[] { SubsidiaryCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SUBSIDIARY_Get", strArrays, subsidiaryCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SubsidiaryCode = Convert.ToString(sqlDataReader["SubsidiaryCode"]);
                    this.m_SubsidiaryName = Convert.ToString(sqlDataReader["SubsidiaryName"]);
                    this.m_Address = Convert.ToString(sqlDataReader["Address"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
                    this.m_Fax = Convert.ToString(sqlDataReader["Fax"]);
                    this.m_WebSite = Convert.ToString(sqlDataReader["WebSite"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Tax = Convert.ToString(sqlDataReader["Tax"]);
                    this.m_BankAccount = Convert.ToString(sqlDataReader["BankAccount"]);
                    this.m_OpenedAt = Convert.ToString(sqlDataReader["OpenedAt"]);
                    this.m_BankAbbreviationName = (sqlDataReader["BankAbbreviationName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankAbbreviationName"]));
                    this.m_BankBranch = (sqlDataReader["BankBranch"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankBranch"]));
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_PersonName = Convert.ToString(sqlDataReader["PersonName"]);
                    this.m_Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    this.m_FactQuantity = Convert.ToInt32(sqlDataReader["FactQuantity"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    if (!sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("Photo")))
                    {
                        if (sqlDataReader["Photo"] != Convert.DBNull)
                        {
                            byte[] item = (byte[])sqlDataReader["Photo"];
                            if ((int)item.Length != 2)
                            {
                                this.m_Photo = Image.FromStream(new MemoryStream(item));
                            }
                            if ((int)item.Length == 2)
                            {
                                this.m_Photo = null;
                            }
                        }
                    }
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
            string[] strArrays = new string[] { "@SubsidiaryCode" };
            object[] subsidiaryCode = new object[] { this.SubsidiaryCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_SUBSIDIARY_Get", strArrays, subsidiaryCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SubsidiaryCode = Convert.ToString(sqlDataReader["SubsidiaryCode"]);
                    this.m_SubsidiaryName = Convert.ToString(sqlDataReader["SubsidiaryName"]);
                    this.m_Address = Convert.ToString(sqlDataReader["Address"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
                    this.m_Fax = Convert.ToString(sqlDataReader["Fax"]);
                    this.m_WebSite = Convert.ToString(sqlDataReader["WebSite"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Tax = Convert.ToString(sqlDataReader["Tax"]);
                    this.m_BankAccount = Convert.ToString(sqlDataReader["BankAccount"]);
                    this.m_OpenedAt = Convert.ToString(sqlDataReader["OpenedAt"]);
                    this.m_BankAbbreviationName = (sqlDataReader["BankAbbreviationName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankAbbreviationName"]));
                    this.m_BankBranch = (sqlDataReader["BankBranch"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankBranch"]));
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_PersonName = Convert.ToString(sqlDataReader["PersonName"]);
                    this.m_Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    this.m_FactQuantity = Convert.ToInt32(sqlDataReader["FactQuantity"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    if (!sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("Photo")))
                    {
                        if (sqlDataReader["Photo"] != Convert.DBNull)
                        {
                            byte[] item = (byte[])sqlDataReader["Photo"];
                            if ((int)item.Length != 2)
                            {
                                this.m_Photo = Image.FromStream(new MemoryStream(item));
                            }
                            if ((int)item.Length == 2)
                            {
                                this.m_Photo = null;
                            }
                        }
                    }
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string SubsidiaryCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SubsidiaryCode" };
            object[] subsidiaryCode = new object[] { SubsidiaryCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_SUBSIDIARY_Get", strArrays, subsidiaryCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SubsidiaryCode = Convert.ToString(sqlDataReader["SubsidiaryCode"]);
                    this.m_SubsidiaryName = Convert.ToString(sqlDataReader["SubsidiaryName"]);
                    this.m_Address = Convert.ToString(sqlDataReader["Address"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
                    this.m_Fax = Convert.ToString(sqlDataReader["Fax"]);
                    this.m_WebSite = Convert.ToString(sqlDataReader["WebSite"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Tax = Convert.ToString(sqlDataReader["Tax"]);
                    this.m_BankAccount = Convert.ToString(sqlDataReader["BankAccount"]);
                    this.m_OpenedAt = Convert.ToString(sqlDataReader["OpenedAt"]);
                    this.m_BankAbbreviationName = (sqlDataReader["BankAbbreviationName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankAbbreviationName"]));
                    this.m_BankBranch = (sqlDataReader["BankBranch"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankBranch"]));
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_PersonName = Convert.ToString(sqlDataReader["PersonName"]);
                    this.m_Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    this.m_FactQuantity = Convert.ToInt32(sqlDataReader["FactQuantity"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    if (!sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("Photo")))
                    {
                        if (sqlDataReader["Photo"] != Convert.DBNull)
                        {
                            byte[] item = (byte[])sqlDataReader["Photo"];
                            if ((int)item.Length != 2)
                            {
                                this.m_Photo = Image.FromStream(new MemoryStream(item));
                            }
                            if ((int)item.Length == 2)
                            {
                                this.m_Photo = null;
                            }
                        }
                    }
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
            return (new SqlHelper()).ExecuteDataTable("HRM_SUBSIDIARY_GetList");
        }

        public string GetName(string SubsidiaryName)
        {
            string str = "";
            string[] strArrays = new string[] { "@SubsidiaryName" };
            object[] subsidiaryName = new object[] { SubsidiaryName };
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("select * from HRM_SUBSIDIARY where SubsidiaryName=@SubsidiaryName", strArrays, subsidiaryName);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SubsidiaryCode = Convert.ToString(sqlDataReader["SubsidiaryCode"]);
                    this.m_SubsidiaryName = Convert.ToString(sqlDataReader["SubsidiaryName"]);
                    this.m_Address = Convert.ToString(sqlDataReader["Address"]);
                    this.m_Phone = Convert.ToString(sqlDataReader["Phone"]);
                    this.m_Fax = Convert.ToString(sqlDataReader["Fax"]);
                    this.m_WebSite = Convert.ToString(sqlDataReader["WebSite"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Tax = Convert.ToString(sqlDataReader["Tax"]);
                    this.m_BankAccount = Convert.ToString(sqlDataReader["BankAccount"]);
                    this.m_OpenedAt = Convert.ToString(sqlDataReader["OpenedAt"]);
                    this.m_BankAbbreviationName = (sqlDataReader["BankAbbreviationName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankAbbreviationName"]));
                    this.m_BankBranch = (sqlDataReader["BankBranch"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankBranch"]));
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_PersonName = Convert.ToString(sqlDataReader["PersonName"]);
                    this.m_Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                    this.m_FactQuantity = Convert.ToInt32(sqlDataReader["FactQuantity"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    if (!sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("Photo")))
                    {
                        if (sqlDataReader["Photo"] != Convert.DBNull)
                        {
                            byte[] item = (byte[])sqlDataReader["Photo"];
                            if ((int)item.Length != 2)
                            {
                                this.m_Photo = Image.FromStream(new MemoryStream(item));
                            }
                            if ((int)item.Length == 2)
                            {
                                this.m_Photo = null;
                            }
                        }
                    }
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
            string[] strArrays = new string[] { "@SubsidiaryCode", "@SubsidiaryName", "@Address", "@Phone", "@Fax", "@WebSite", "@Email", "@Tax", "@BankAccount", "@OpenedAt", "@BankAbbreviationName", "@BankBranch", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSubsidiaryCode = new object[] { this.m_SubsidiaryCode, this.m_SubsidiaryName, this.m_Address, this.m_Phone, this.m_Fax, this.m_WebSite, this.m_Email, this.m_Tax, this.m_BankAccount, this.m_OpenedAt, this.m_BankAbbreviationName, this.m_BankBranch, this.m_MinimumSalary, this.m_PersonName, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SUBSIDIARY_Insert", strArrays1, mSubsidiaryCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode", "@SubsidiaryName", "@Address", "@Phone", "@Fax", "@WebSite", "@Email", "@Tax", "@BankAccount", "@OpenedAt", "@BankAbbreviationName", "@BankBranch", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSubsidiaryCode = new object[] { this.m_SubsidiaryCode, this.m_SubsidiaryName, this.m_Address, this.m_Phone, this.m_Fax, this.m_WebSite, this.m_Email, this.m_Tax, this.m_BankAccount, this.m_OpenedAt, this.m_BankAbbreviationName, this.m_BankBranch, this.m_MinimumSalary, this.m_PersonName, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SUBSIDIARY_Insert", strArrays1, mSubsidiaryCode);
        }

        public string Insert(string SubsidiaryCode, string SubsidiaryName, string Address, string Phone, string Fax, string WebSite, string Email, string Tax, string BankAccount, string OpenedAt, string BankAbbreviationName, string BankBranch, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode", "@SubsidiaryName", "@Address", "@Phone", "@Fax", "@WebSite", "@Email", "@Tax", "@BankAccount", "@OpenedAt", "@BankAbbreviationName", "@BankBranch", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] subsidiaryCode = new object[] { SubsidiaryCode, SubsidiaryName, Address, Phone, Fax, WebSite, Email, Tax, BankAccount, OpenedAt, BankAbbreviationName, BankBranch, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SUBSIDIARY_Insert", strArrays1, subsidiaryCode);
        }

        public string Insert(SqlConnection myConnection, string SubsidiaryCode, string SubsidiaryName, string Address, string Phone, string Fax, string WebSite, string Email, string Tax, string BankAccount, string OpenedAt, string BankAbbreviationName, string BankBranch, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode", "@SubsidiaryName", "@Address", "@Phone", "@Fax", "@WebSite", "@Email", "@Tax", "@BankAccount", "@OpenedAt", "@BankAbbreviationName", "@BankBranch", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] subsidiaryCode = new object[] { SubsidiaryCode, SubsidiaryName, Address, Phone, Fax, WebSite, Email, Tax, BankAccount, OpenedAt, BankAbbreviationName, BankBranch, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SUBSIDIARY_Insert", strArrays1, subsidiaryCode);
        }

        public string Insert(SqlTransaction myTransaction, string SubsidiaryCode, string SubsidiaryName, string Address, string Phone, string Fax, string WebSite, string Email, string Tax, string BankAccount, string OpenedAt, string BankAbbreviationName, string BankBranch, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode", "@SubsidiaryName", "@Address", "@Phone", "@Fax", "@WebSite", "@Email", "@Tax", "@BankAccount", "@OpenedAt", "@BankAbbreviationName", "@BankBranch", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] subsidiaryCode = new object[] { SubsidiaryCode, SubsidiaryName, Address, Phone, Fax, WebSite, Email, Tax, BankAccount, OpenedAt, BankAbbreviationName, BankBranch, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SUBSIDIARY_Insert", strArrays1, subsidiaryCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_SUBSIDIARY", "SubsidiaryCode", "Thêm công ty con");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SubsidiaryCode", "@SubsidiaryName", "@Address", "@Phone", "@Fax", "@WebSite", "@Email", "@Tax", "@BankAccount", "@OpenedAt", "@BankAbbreviationName", "@BankBranch", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSubsidiaryCode = new object[] { this.m_SubsidiaryCode, this.m_SubsidiaryName, this.m_Address, this.m_Phone, this.m_Fax, this.m_WebSite, this.m_Email, this.m_Tax, this.m_BankAccount, this.m_OpenedAt, this.m_BankAbbreviationName, this.m_BankBranch, this.m_MinimumSalary, this.m_PersonName, this.m_Quantity, this.m_FactQuantity, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SUBSIDIARY_Update", strArrays1, mSubsidiaryCode);
        }

        public string Update(string SubsidiaryCode, string SubsidiaryName, string Address, string Phone, string Fax, string WebSite, string Email, string Tax, string BankAccount, string OpenedAt, string BankAbbreviationName, string BankBranch, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode", "@SubsidiaryName", "@Address", "@Phone", "@Fax", "@WebSite", "@Email", "@Tax", "@BankAccount", "@OpenedAt", "@BankAbbreviationName", "@BankBranch", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] subsidiaryCode = new object[] { SubsidiaryCode, SubsidiaryName, Address, Phone, Fax, WebSite, Email, Tax, BankAccount, OpenedAt, BankAbbreviationName, BankBranch, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SUBSIDIARY_Update", strArrays1, subsidiaryCode);
        }

        public string Update(SqlConnection myConnection, string SubsidiaryCode, string SubsidiaryName, string Address, string Phone, string Fax, string WebSite, string Email, string Tax, string BankAccount, string OpenedAt, string BankAbbreviationName, string BankBranch, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode", "@SubsidiaryName", "@Address", "@Phone", "@Fax", "@WebSite", "@Email", "@Tax", "@BankAccount", "@OpenedAt", "@BankAbbreviationName", "@BankBranch", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] subsidiaryCode = new object[] { SubsidiaryCode, SubsidiaryName, Address, Phone, Fax, WebSite, Email, Tax, BankAccount, OpenedAt, BankAbbreviationName, BankBranch, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SUBSIDIARY_Update", strArrays1, subsidiaryCode);
        }

        public string Update(SqlTransaction myTransaction, string SubsidiaryCode, string SubsidiaryName, string Address, string Phone, string Fax, string WebSite, string Email, string Tax, string BankAccount, string OpenedAt, string BankAbbreviationName, string BankBranch, decimal MinimumSalary, string PersonName, int Quantity, int FactQuantity, string Description)
        {
            string[] strArrays = new string[] { "@SubsidiaryCode", "@SubsidiaryName", "@Address", "@Phone", "@Fax", "@WebSite", "@Email", "@Tax", "@BankAccount", "@OpenedAt", "@BankAbbreviationName", "@BankBranch", "@MinimumSalary", "@PersonName", "@Quantity", "@FactQuantity", "@Description" };
            string[] strArrays1 = strArrays;
            object[] subsidiaryCode = new object[] { SubsidiaryCode, SubsidiaryName, Address, Phone, Fax, WebSite, Email, Tax, BankAccount, OpenedAt, BankAbbreviationName, BankBranch, MinimumSalary, PersonName, Quantity, FactQuantity, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SUBSIDIARY_Update", strArrays1, subsidiaryCode);
        }

        public string Update(string EmployeeCode, Image photo)
        {
            byte[] buffer;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            if (photo == null)
            {
                buffer = new byte[2];
            }
            else
            {
                photo.Save(string.Concat(Path.GetTempPath(), "\\temp_image_perfect_software.JPG"));
             //   MyImage.CompressJpeg(string.Concat(Path.GetTempPath(), "\\temp_image_perfect_software.JPG"), 20);
                photo = Image.FromFile(string.Concat(Path.GetTempPath(), "\\temp_image_perfect_software.JPG"));
                MemoryStream memoryStream = new MemoryStream();
                photo.Save(memoryStream, photo.RawFormat);
                buffer = memoryStream.GetBuffer();
                memoryStream.Close();
            }
            string[] strArrays = new string[] { "@SubsidiaryCode", "@Photo" };
            object[] subsidiaryCode = new object[] { this.SubsidiaryCode, buffer };
            return sqlHelper.ExecuteNonQuery("Update HRM_SUBSIDIARY set Photo=@Photo WHERE SubsidiaryCode=@SubsidiaryCode", strArrays, subsidiaryCode);
        }

    }
}
