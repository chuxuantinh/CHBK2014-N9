using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.Utils.Lib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
  public class DIC_SYMBOL
    {
        private string m_SymbolCode;

        private string m_SymbolName;

        private double m_PercentSalary;

        private bool m_IsEdit;

        private bool m_IsShow;

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

        [Category("Column")]
        [DisplayName("IsEdit")]
        public bool IsEdit
        {
            get
            {
                return this.m_IsEdit;
            }
            set
            {
                this.m_IsEdit = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsShow")]
        public bool IsShow
        {
            get
            {
                return this.m_IsShow;
            }
            set
            {
                this.m_IsShow = value;
            }
        }

        [Category("Column")]
        [DisplayName("PercentSalary")]
        public double PercentSalary
        {
            get
            {
                return this.m_PercentSalary;
            }
            set
            {
                this.m_PercentSalary = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_SYMBOL";
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
        [DisplayName("SymbolCode")]
        public string SymbolCode
        {
            get
            {
                return this.m_SymbolCode;
            }
            set
            {
                this.m_SymbolCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("SymbolName")]
        public string SymbolName
        {
            get
            {
                return this.m_SymbolName;
            }
            set
            {
                this.m_SymbolName = value;
            }
        }

        public DIC_SYMBOL()
        {
            this.m_SymbolCode = "";
            this.m_SymbolName = "";
            this.m_PercentSalary = 0;
            this.m_IsEdit = true;
            this.m_IsShow = true;
            this.m_Description = "";
        }

        public DIC_SYMBOL(string SymbolCode, string SymbolName, double PercentSalary, bool IsEdit, bool IsShow, string Description)
        {
            this.m_SymbolCode = SymbolCode;
            this.m_SymbolName = SymbolName;
            this.m_PercentSalary = PercentSalary;
            this.m_IsEdit = IsEdit;
            this.m_IsShow = IsShow;
            this.m_Description = Description;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "SymbolName", "SymbolCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["SymbolCode"] = "All";
        //    dataRow["SymbolName"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "SymbolName", "SymbolCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["SymbolName"]);
            }
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "SymbolName";
            gridlookup.Properties.ValueMember = "SymbolCode";
        }

        public void AddOTRepositoryGridLookupEdit(RepositoryItemGridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetList();
            DataRowCollection rows = dataTable.Rows;
            object[] objArray = new object[] { "TCT", "Tăng Ca Trước Giờ Làm Việc", 0, false, true, "" };
            rows.Add(objArray);
            DataRowCollection dataRowCollection = dataTable.Rows;
            objArray = new object[] { "TCS", "Tăng Ca Sau Giờ Làm Việc", 0, false, true, "" };
            dataRowCollection.Add(objArray);
            gridlookup.DataSource = dataTable;
            gridlookup.DisplayMember = "SymbolCode";
            gridlookup.ValueMember = "SymbolCode";
        }

        public void AddRepositoryGridLookupEdit(RepositoryItemGridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            gridlookup.DataSource = this.GetList();
            gridlookup.DisplayMember = "SymbolCode";
            gridlookup.ValueMember = "SymbolCode";
        }

        public DataTable CreateNullDataTable()
        {
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("SymbolCode", typeof(string));
            DataColumn dataColumn1 = new DataColumn("SymbolName", typeof(string));
            DataColumn dataColumn2 = new DataColumn("PercentSalary", typeof(int));
            DataColumn dataColumn3 = new DataColumn("IsEdit", typeof(bool));
            DataColumn dataColumn4 = new DataColumn("Description", typeof(string));
            dataTable.Columns.Add(dataColumn);
            dataTable.Columns.Add(dataColumn1);
            dataTable.Columns.Add(dataColumn2);
            dataTable.Columns.Add(dataColumn3);
            dataTable.Columns.Add(dataColumn4);
            dataTable.Clear();
            return dataTable;
        }
        DataRow row = null; //tinh
        public static void CreateReport(XtraReport Report, XRControl Band, bool IsShowLateEarly, bool IsShowShift)
        {
            
            string str;
            XRTable xRTable;
            XRTableRow xRTableRow;
            XRTableCell xRTableCell;
            XRTableCell font;
            XRLabel xRLabel = new XRLabel()
            {
                Text = "Bảng ký hiệu chấm công",
                Font = new Font("Times New Roman", 9.25f, FontStyle.Bold | FontStyle.Italic),
                TopF = Band.TopF + 12f,
                WidthF = 200f,
                TextAlignment = TextAlignment.MiddleLeft
            };
            Band.Controls.Add(xRLabel);
            float single = 0f;
            float topF = xRLabel.TopF + xRLabel.HeightF + 6f;

           
            foreach (DataRow row in (new DIC_SYMBOL()).GetList().Rows)
            {
                if (bool.Parse(row["IsShow"].ToString()))
                {
                    str = "";
                    str = (!(row["SymbolCode"].ToString() == "") ? row["SymbolCode"].ToString() : "(trống)");
                    xRTable = new XRTable();
                    xRTableRow = new XRTableRow();
                    xRTableCell = new XRTableCell();
                    font = new XRTableCell();
                    xRTableCell.WidthF = 102f;
                    xRTableCell.Text = row["SymbolName"].ToString();
                    xRTableCell.WordWrap = false;
                    xRTableCell.Font = new Font("Times New Roman", 8.75f);
                    xRTableCell.TextAlignment = TextAlignment.MiddleLeft;
                    font.WidthF = 62f;
                    font.Text = string.Concat(": ", str);
                    font.WordWrap = false;
                    font.Font = new Font("Times New Roman", 8.75f);
                    font.TextAlignment = TextAlignment.MiddleLeft;
                    xRTableRow.Cells.Add(xRTableCell);
                    xRTableRow.Cells.Add(font);
                    xRTable.Rows.Add(xRTableRow);
                    xRTable.HeightF = 15f;
                    xRTable.WidthF = 164f;
                    xRTable.TopF = topF;
                    xRTable.LeftF = single;
                    Band.Controls.Add(xRTable);
                    if ((float)(Report.PageWidth - (Report.Margins.Left + Report.Margins.Right)) - single < 328f)
                    {
                        single = 0f;
                        topF += 18f;
                    }
                    else
                    {
                        single += 164f;
                    }
                }
            }
            if (IsShowLateEarly)
            {
                for (int i = 0; i < 4; i++)
                {
                    string str1 = "";
                    str = "";
                    if (i == 0)
                    {
                        str1 = "Số phút đi trễ: ";
                        str = ": +(số phút)";
                    }
                    else if (i == 1)
                    {
                        str1 = "Số phút về sớm: ";
                        str = ": -(số phút)";
                    }
                    else if (i == 2)
                    {
                        str1 = "Đi trễ, về sớm: ";
                        str = ": +(sp):-(sp)";
                    }
                    else if (i == 3)
                    {
                        str1 = "Tách đôi ca: ";
                        str = ": +;V +;P ...";
                    }
                    xRTable = new XRTable();
                    xRTableRow = new XRTableRow();
                    xRTableCell = new XRTableCell();
                    font = new XRTableCell();
                    xRTableCell.WidthF = 102f;
                    xRTableCell.Text = str1;
                    xRTableCell.WordWrap = false;
                    xRTableCell.Font = new Font("Times New Roman", 8.75f);
                    xRTableCell.TextAlignment = TextAlignment.MiddleLeft;
                    font.WidthF = 62f;
                    font.Text = str;
                    font.WordWrap = false;
                    font.Font = new Font("Times New Roman", 8.75f);
                    font.TextAlignment = TextAlignment.MiddleLeft;
                    xRTableRow.Cells.Add(xRTableCell);
                    xRTableRow.Cells.Add(font);
                    xRTable.Rows.Add(xRTableRow);
                    xRTable.HeightF = 15f;
                    xRTable.WidthF = 164f;
                    xRTable.TopF = topF;
                    xRTable.LeftF = single;
                    Band.Controls.Add(xRTable);
                    if ((float)(Report.PageWidth - (Report.Margins.Left + Report.Margins.Right)) - single < 328f)
                    {
                        single = 0f;
                        topF += 18f;
                    }
                    else
                    {
                        single += 164f;
                    }
                }
            }
            if (IsShowShift)
            {
                XRLabel xRLabel1 = new XRLabel()
                {
                    Text = "Ký hiệu chấm công theo ca",
                    Font = new Font("Times New Roman", 9.25f, FontStyle.Bold | FontStyle.Italic)
                };
                float single1 = topF + 20f;
                topF = single1;
                xRLabel1.TopF = single1;
                xRLabel1.WidthF = 200f;
                xRLabel1.TextAlignment = TextAlignment.MiddleLeft;
                Band.Controls.Add(xRLabel1);
                single = 0f;
                topF += 30f;
                foreach (DataRow dataRow in (new DIC_SHIFT()).GetList().Rows)
                {
                    str = "";
                    str = (!(dataRow["ShiftCode"].ToString() == "") ? dataRow["ShiftCode"].ToString() : "(trống)");
                    xRTable = new XRTable();
                    xRTableRow = new XRTableRow();
                    xRTableCell = new XRTableCell();
                    font = new XRTableCell();
                    xRTableCell.WidthF = 136f;
                    string[] shortTimeString = new string[] { dataRow["ShiftName"].ToString(), " (", null, null, null, null };
                    DateTime dateTime = Convert.ToDateTime(dataRow["BeginTime"].ToString());
                    shortTimeString[2] = dateTime.ToShortTimeString();
                    shortTimeString[3] = " - ";
                    dateTime = Convert.ToDateTime(dataRow["EndTime"].ToString());
                    shortTimeString[4] = dateTime.ToShortTimeString();
                    shortTimeString[5] = ")";
                    xRTableCell.Text = string.Concat(shortTimeString);
                    xRTableCell.WordWrap = false;
                    xRTableCell.Font = new Font("Times New Roman", 8.75f);
                    xRTableCell.TextAlignment = TextAlignment.MiddleLeft;
                    font.WidthF = 62f;
                    font.Text = string.Concat(": ", str);
                    font.WordWrap = false;
                    font.Font = new Font("Times New Roman", 8.75f);
                    font.TextAlignment = TextAlignment.MiddleLeft;
                    xRTableRow.Cells.Add(xRTableCell);
                    xRTableRow.Cells.Add(font);
                    xRTable.Rows.Add(xRTableRow);
                    xRTable.HeightF = 15f;
                    xRTable.WidthF = 198f;
                    xRTable.TopF = topF;
                    xRTable.LeftF = single;
                    Band.Controls.Add(xRTable);
                    if ((float)(Report.PageWidth - (Report.Margins.Left + Report.Margins.Right)) - single < 396f)
                    {
                        single = 0f;
                        topF += 18f;
                    }
                    else
                    {
                        single += 198f;
                    }
                }
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SymbolCode" };
            object[] mSymbolCode = new object[] { this.m_SymbolCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SYMBOL_Delete", strArrays, mSymbolCode);
        }

        public string Delete(string SymbolCode)
        {
            string[] strArrays = new string[] { "@SymbolCode" };
            object[] symbolCode = new object[] { SymbolCode };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SYMBOL_Delete", strArrays, symbolCode);
        }

        public string Delete(SqlConnection myConnection, string SymbolCode)
        {
            string[] strArrays = new string[] { "@SymbolCode" };
            object[] symbolCode = new object[] { SymbolCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SYMBOL_Delete", strArrays, symbolCode);
        }

        public string Delete(SqlTransaction myTransaction, string SymbolCode)
        {
            string[] strArrays = new string[] { "@SymbolCode" };
            object[] symbolCode = new object[] { SymbolCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SYMBOL_Delete", strArrays, symbolCode);
        }

        public bool Exist(string SymbolCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SymbolCode" };
            object[] symbolCode = new object[] { SymbolCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SYMBOL_Get", strArrays, symbolCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string SymbolCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SymbolCode" };
            object[] symbolCode = new object[] { SymbolCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SYMBOL_Get", strArrays, symbolCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SymbolCode = Convert.ToString(sqlDataReader["SymbolCode"]);
                    this.m_SymbolName = Convert.ToString(sqlDataReader["SymbolName"]);
                    this.m_PercentSalary = Convert.ToDouble(sqlDataReader["PercentSalary"]);
                    this.m_IsEdit = Convert.ToBoolean(sqlDataReader["IsEdit"]);
                    this.m_IsShow = Convert.ToBoolean(sqlDataReader["IsShow"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, string SymbolCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SymbolCode" };
            object[] symbolCode = new object[] { SymbolCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "DIC_SYMBOL_Get", strArrays, symbolCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SymbolCode = Convert.ToString(sqlDataReader["SymbolCode"]);
                    this.m_SymbolName = Convert.ToString(sqlDataReader["SymbolName"]);
                    this.m_PercentSalary = Convert.ToDouble(sqlDataReader["PercentSalary"]);
                    this.m_IsEdit = Convert.ToBoolean(sqlDataReader["IsEdit"]);
                    this.m_IsShow = Convert.ToBoolean(sqlDataReader["IsShow"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, string SymbolCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SymbolCode" };
            object[] symbolCode = new object[] { SymbolCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "DIC_SYMBOL_Get", strArrays, symbolCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SymbolCode = Convert.ToString(sqlDataReader["SymbolCode"]);
                    this.m_SymbolName = Convert.ToString(sqlDataReader["SymbolName"]);
                    this.m_PercentSalary = Convert.ToDouble(sqlDataReader["PercentSalary"]);
                    this.m_IsEdit = Convert.ToBoolean(sqlDataReader["IsEdit"]);
                    this.m_IsShow = Convert.ToBoolean(sqlDataReader["IsShow"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_SYMBOL_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SymbolCode", "@SymbolName", "@PercentSalary", "@IsEdit", "@IsShow", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSymbolCode = new object[] { this.m_SymbolCode, this.m_SymbolName, this.m_PercentSalary, this.m_IsEdit, this.m_IsShow, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SYMBOL_Insert", strArrays1, mSymbolCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SymbolCode", "@SymbolName", "@PercentSalary", "@IsEdit", "@IsShow", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSymbolCode = new object[] { this.m_SymbolCode, this.m_SymbolName, this.m_PercentSalary, this.m_IsEdit, this.m_IsShow, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SYMBOL_Insert", strArrays1, mSymbolCode);
        }

        public string Insert(string SymbolCode, string SymbolName, double PercentSalary, bool IsEdit, bool IsShow, string Description)
        {
            string[] strArrays = new string[] { "@SymbolCode", "@SymbolName", "@PercentSalary", "@IsEdit", "@IsShow", "@Description" };
            string[] strArrays1 = strArrays;
            object[] symbolCode = new object[] { SymbolCode, SymbolName, PercentSalary, IsEdit, IsShow, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SYMBOL_Insert", strArrays1, symbolCode);
        }

        public string Insert(SqlConnection myConnection, string SymbolCode, string SymbolName, double PercentSalary, bool IsEdit, bool IsShow, string Description)
        {
            string[] strArrays = new string[] { "@SymbolCode", "@SymbolName", "@PercentSalary", "@IsEdit", "@IsShow", "@Description" };
            string[] strArrays1 = strArrays;
            object[] symbolCode = new object[] { SymbolCode, SymbolName, PercentSalary, IsEdit, IsShow, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SYMBOL_Insert", strArrays1, symbolCode);
        }

        public string Insert(SqlTransaction myTransaction, string SymbolCode, string SymbolName, double PercentSalary, bool IsEdit, bool IsShow, string Description)
        {
            string[] strArrays = new string[] { "@SymbolCode", "@SymbolName", "@PercentSalary", "@IsEdit", "@IsShow", "@Description" };
            string[] strArrays1 = strArrays;
            object[] symbolCode = new object[] { SymbolCode, SymbolName, PercentSalary, IsEdit, IsShow, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SYMBOL_Insert", strArrays1, symbolCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("DIC_SYMBOL", "SymbolCode", "KH");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SymbolCode", "@SymbolName", "@PercentSalary", "@IsEdit", "@IsShow", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSymbolCode = new object[] { this.m_SymbolCode, this.m_SymbolName, this.m_PercentSalary, this.m_IsEdit, this.m_IsShow, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SYMBOL_Update", strArrays1, mSymbolCode);
        }

        public string Update(string SymbolCode, string SymbolName, double PercentSalary, bool IsEdit, bool IsShow, string Description)
        {
            string[] strArrays = new string[] { "@SymbolCode", "@SymbolName", "@PercentSalary", "@IsEdit", "@IsShow", "@Description" };
            string[] strArrays1 = strArrays;
            object[] symbolCode = new object[] { SymbolCode, SymbolName, PercentSalary, IsEdit, IsShow, Description };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SYMBOL_Update", strArrays1, symbolCode);
        }

        public string Update(SqlConnection myConnection, string SymbolCode, string SymbolName, double PercentSalary, bool IsEdit, bool IsShow, string Description)
        {
            string[] strArrays = new string[] { "@SymbolCode", "@SymbolName", "@PercentSalary", "@IsEdit", "@IsShow", "@Description" };
            string[] strArrays1 = strArrays;
            object[] symbolCode = new object[] { SymbolCode, SymbolName, PercentSalary, IsEdit, IsShow, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SYMBOL_Update", strArrays1, symbolCode);
        }

        public string Update(SqlTransaction myTransaction, string SymbolCode, string SymbolName, double PercentSalary, bool IsEdit, bool IsShow, string Description)
        {
            string[] strArrays = new string[] { "@SymbolCode", "@SymbolName", "@PercentSalary", "@IsEdit", "@IsShow", "@Description" };
            string[] strArrays1 = strArrays;
            object[] symbolCode = new object[] { SymbolCode, SymbolName, PercentSalary, IsEdit, IsShow, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SYMBOL_Update", strArrays1, symbolCode);
        }

    }
}
