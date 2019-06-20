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
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
  public  class HRM_PRODUCT
    {


        private string m_ProductCode;

        private string m_ProductGroupCode;

        private string m_NameProduct;

        private string m_Unit;

        private Image m_Photo;

        private string m_Barcode;

        private decimal m_Price;

        private string m_Description;

        [Category("Column")]
        [DisplayName("Barcode")]
        public string Barcode
        {
            get
            {
                return this.m_Barcode;
            }
            set
            {
                this.m_Barcode = value;
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
        [DisplayName("NameProduct")]
        public string NameProduct
        {
            get
            {
                return this.m_NameProduct;
            }
            set
            {
                this.m_NameProduct = value;
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

        [Category("Column")]
        [DisplayName("Price")]
        public decimal Price
        {
            get
            {
                return this.m_Price;
            }
            set
            {
                this.m_Price = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("ProductCode")]
        public string ProductCode
        {
            get
            {
                return this.m_ProductCode;
            }
            set
            {
                this.m_ProductCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("ProductGroupCode")]
        public string ProductGroupCode
        {
            get
            {
                return this.m_ProductGroupCode;
            }
            set
            {
                this.m_ProductGroupCode = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_PRODUCT";
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
        [DisplayName("Unit")]
        public string Unit
        {
            get
            {
                return this.m_Unit;
            }
            set
            {
                this.m_Unit = value;
            }
        }

        public HRM_PRODUCT()
        {
            this.m_ProductCode = "";
            this.m_ProductGroupCode = "";
            this.m_NameProduct = "";
            this.m_Unit = "";
            this.m_Photo = null;
            this.m_Barcode = "";
            this.m_Price = new decimal(0);
            this.m_Description = "";
        }

        public HRM_PRODUCT(string ProductCode, string ProductGroupCode, string NameProduct, string Unit, string Barcode, decimal Price, string Description)
        {
            this.m_ProductCode = ProductCode;
            this.m_ProductGroupCode = ProductGroupCode;
            this.m_NameProduct = NameProduct;
            this.m_Unit = Unit;
            this.m_Barcode = Barcode;
            this.m_Price = Price;
            this.m_Description = Description;
        }

        //public void AddCombo(ComboBox combo)
        //{
        //    MyLib.TableToComboBox(combo, this.GetList(), "NameProduct", "ProductCode");
        //}

        //public void AddComboAll(ComboBox combo)
        //{
        //    DataTable dataTable = new DataTable();
        //    dataTable = this.GetList();
        //    DataRow dataRow = dataTable.NewRow();
        //    dataRow["ProductCode"] = "All";
        //    dataRow["NameProduct"] = "Tất cả";
        //    dataTable.Rows.InsertAt(dataRow, 0);
        //    MyLib.TableToComboBox(combo, dataTable, "NameProduct", "ProductCode");
        //}

        public void AddComboEdit(ComboBoxEdit combo)
        {
            DataTable dataTable = new DataTable();
            foreach (DataRow row in this.GetList().Rows)
            {
                combo.Properties.Items.Add(row["NameProduct"]);
            }
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@ProductCode" };
            object[] mProductCode = new object[] { this.m_ProductCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_Delete", strArrays, mProductCode);
        }

        public string Delete(string ProductCode)
        {
            string[] strArrays = new string[] { "@ProductCode" };
            object[] productCode = new object[] { ProductCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_Delete", strArrays, productCode);
        }

        public string Delete(SqlConnection myConnection, string ProductCode)
        {
            string[] strArrays = new string[] { "@ProductCode" };
            object[] productCode = new object[] { ProductCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PRODUCT_Delete", strArrays, productCode);
        }

        public string Delete(SqlTransaction myTransaction, string ProductCode)
        {
            string[] strArrays = new string[] { "@ProductCode" };
            object[] productCode = new object[] { ProductCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PRODUCT_Delete", strArrays, productCode);
        }

        public bool Exist(string ProductCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@ProductCode" };
            object[] productCode = new object[] { ProductCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PRODUCT_Get", strArrays, productCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string ProductCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProductCode" };
            object[] productCode = new object[] { ProductCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_PRODUCT_Get", strArrays, productCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProductCode = Convert.ToString(sqlDataReader["ProductCode"]);
                    this.m_ProductGroupCode = Convert.ToString(sqlDataReader["ProductGroupCode"]);
                    this.m_NameProduct = Convert.ToString(sqlDataReader["NameProduct"]);
                    this.m_Unit = Convert.ToString(sqlDataReader["Unit"]);
                    this.m_Barcode = Convert.ToString(sqlDataReader["Barcode"]);
                    this.m_Price = Convert.ToDecimal(sqlDataReader["Price"]);
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

        public string Get(SqlConnection myConnection, string ProductCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProductCode" };
            object[] productCode = new object[] { ProductCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_PRODUCT_Get", strArrays, productCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProductCode = Convert.ToString(sqlDataReader["ProductCode"]);
                    this.m_ProductGroupCode = Convert.ToString(sqlDataReader["ProductGroupCode"]);
                    this.m_NameProduct = Convert.ToString(sqlDataReader["NameProduct"]);
                    this.m_Unit = Convert.ToString(sqlDataReader["Unit"]);
                    this.m_Barcode = Convert.ToString(sqlDataReader["Barcode"]);
                    this.m_Price = Convert.ToDecimal(sqlDataReader["Price"]);
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

        public string Get(SqlTransaction myTransaction, string ProductCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@ProductCode" };
            object[] productCode = new object[] { ProductCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_PRODUCT_Get", strArrays, productCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_ProductCode = Convert.ToString(sqlDataReader["ProductCode"]);
                    this.m_ProductGroupCode = Convert.ToString(sqlDataReader["ProductGroupCode"]);
                    this.m_NameProduct = Convert.ToString(sqlDataReader["NameProduct"]);
                    this.m_Unit = Convert.ToString(sqlDataReader["Unit"]);
                    this.m_Barcode = Convert.ToString(sqlDataReader["Barcode"]);
                    this.m_Price = Convert.ToDecimal(sqlDataReader["Price"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_PRODUCT_GetList");
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@ProductCode", "@ProductGroupCode", "@NameProduct", "@Unit", "@Barcode", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mProductCode = new object[] { this.m_ProductCode, this.m_ProductGroupCode, this.m_NameProduct, this.m_Unit, this.m_Barcode, this.m_Price, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_Insert", strArrays1, mProductCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@ProductCode", "@ProductGroupCode", "@NameProduct", "@Unit", "@Barcode", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mProductCode = new object[] { this.m_ProductCode, this.m_ProductGroupCode, this.m_NameProduct, this.m_Unit, this.m_Barcode, this.m_Price, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PRODUCT_Insert", strArrays1, mProductCode);
        }

        public string Insert(string ProductCode, string ProductGroupCode, string NameProduct, string Unit, string Barcode, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@ProductCode", "@ProductGroupCode", "@NameProduct", "@Unit", "@Barcode", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] productCode = new object[] { ProductCode, ProductGroupCode, NameProduct, Unit, Barcode, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_Insert", strArrays1, productCode);
        }

        public string Insert(SqlConnection myConnection, string ProductCode, string ProductGroupCode, string NameProduct, string Unit, string Barcode, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@ProductCode", "@ProductGroupCode", "@NameProduct", "@Unit", "@Barcode", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] productCode = new object[] { ProductCode, ProductGroupCode, NameProduct, Unit, Barcode, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PRODUCT_Insert", strArrays1, productCode);
        }

        public string Insert(SqlTransaction myTransaction, string ProductCode, string ProductGroupCode, string NameProduct, string Unit, string Barcode, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@ProductCode", "@ProductGroupCode", "@NameProduct", "@Unit", "@Barcode", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] productCode = new object[] { ProductCode, ProductGroupCode, NameProduct, Unit, Barcode, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PRODUCT_Insert", strArrays1, productCode);
        }

        public string NewID()
        {
            return SqlHelper.GenCode("HRM_PRODUCT", "ProductCode", "HH");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@ProductCode", "@ProductGroupCode", "@NameProduct", "@Unit", "@Barcode", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mProductCode = new object[] { this.m_ProductCode, this.m_ProductGroupCode, this.m_NameProduct, this.m_Unit, this.m_Barcode, this.m_Price, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_Update", strArrays1, mProductCode);
        }

        public string Update(string ProductCode, string ProductGroupCode, string NameProduct, string Unit, string Barcode, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@ProductCode", "@ProductGroupCode", "@NameProduct", "@Unit", "@Barcode", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] productCode = new object[] { ProductCode, ProductGroupCode, NameProduct, Unit, Barcode, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_PRODUCT_Update", strArrays1, productCode);
        }

        public string Update(SqlConnection myConnection, string ProductCode, string ProductGroupCode, string NameProduct, string Unit, string Barcode, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@ProductCode", "@ProductGroupCode", "@NameProduct", "@Unit", "@Barcode", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] productCode = new object[] { ProductCode, ProductGroupCode, NameProduct, Unit, Barcode, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_PRODUCT_Update", strArrays1, productCode);
        }

        public string Update(SqlTransaction myTransaction, string ProductCode, string ProductGroupCode, string NameProduct, string Unit, string Barcode, decimal Price, string Description)
        {
            string[] strArrays = new string[] { "@ProductCode", "@ProductGroupCode", "@NameProduct", "@Unit", "@Barcode", "@Price", "@Description" };
            string[] strArrays1 = strArrays;
            object[] productCode = new object[] { ProductCode, ProductGroupCode, NameProduct, Unit, Barcode, Price, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_PRODUCT_Update", strArrays1, productCode);
        }

        public string Update(string ProductCode, Image photo)
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
                MemoryStream memoryStream = new MemoryStream();
                photo.Save(memoryStream, photo.RawFormat);
                buffer = memoryStream.GetBuffer();
                memoryStream.Close();
            }
            string[] strArrays = new string[] { "@ProductCode", "@Photo" };
            object[] productCode = new object[] { ProductCode, buffer };
            return sqlHelper.ExecuteNonQuery("Update HRM_PRODUCT set Photo=@Photo WHERE ProductCode=@ProductCode", strArrays, productCode);
        }
    }
}
