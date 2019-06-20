using DevExpress.XtraEditors;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Data.Helper;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
   public class HRM_SALARY_PAY
    {

        private Guid m_SalaryTableListID;

        private string m_EmployeeCode;

        private Guid m_SalaryPayID;

        private int m_Order;

        private string m_Reason;

        private DateTime m_Date;

        private decimal m_Money;

        private decimal m_PayMoney;

        private decimal m_RealMoney;

        private string m_Person;

        private string m_Description;

        [Category("Column")]
        [DisplayName("Date")]
        public DateTime Date
        {
            get
            {
                return this.m_Date;
            }
            set
            {
                this.m_Date = value;
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

        [Category("Primary Key")]
        [DisplayName("EmployeeCode")]
        public string EmployeeCode
        {
            get
            {
                return this.m_EmployeeCode;
            }
            set
            {
                this.m_EmployeeCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("Money")]
        public decimal Money
        {
            get
            {
                return this.m_Money;
            }
            set
            {
                this.m_Money = value;
            }
        }

        [Category("Column")]
        [DisplayName("Order")]
        public int Order
        {
            get
            {
                return this.m_Order;
            }
            set
            {
                this.m_Order = value;
            }
        }

        [Category("Column")]
        [DisplayName("PayMoney")]
        public decimal PayMoney
        {
            get
            {
                return this.m_PayMoney;
            }
            set
            {
                this.m_PayMoney = value;
            }
        }

        [Category("Column")]
        [DisplayName("Person")]
        public string Person
        {
            get
            {
                return this.m_Person;
            }
            set
            {
                this.m_Person = value;
            }
        }

        [Category("Column")]
        [DisplayName("RealMoney")]
        public decimal RealMoney
        {
            get
            {
                return this.m_RealMoney;
            }
            set
            {
                this.m_RealMoney = value;
            }
        }

        [Category("Column")]
        [DisplayName("Reason")]
        public string Reason
        {
            get
            {
                return this.m_Reason;
            }
            set
            {
                this.m_Reason = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("SalaryPayID")]
        public Guid SalaryPayID
        {
            get
            {
                return this.m_SalaryPayID;
            }
            set
            {
                this.m_SalaryPayID = value;
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

        public HRM_SALARY_PAY()
        {
            this.m_SalaryTableListID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_SalaryPayID = Guid.Empty;
            this.m_Order = 0;
            this.m_Reason = "";
            this.m_Date = DateTime.Now;
            this.m_Money = new decimal(0);
            this.m_PayMoney = new decimal(0);
            this.m_RealMoney = new decimal(0);
            this.m_Person = "";
            this.m_Description = "";
        }

        public HRM_SALARY_PAY(Guid SalaryTableListID, string EmployeeCode, Guid SalaryPayID, int Order, string Reason, DateTime Date, decimal Money, decimal PayMoney, decimal RealMoney, string Person, string Description)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_SalaryPayID = SalaryPayID;
            this.m_Order = Order;
            this.m_Reason = Reason;
            this.m_Date = Date;
            this.m_Money = Money;
            this.m_PayMoney = PayMoney;
            this.m_RealMoney = RealMoney;
            this.m_Person = Person;
            this.m_Description = Description;
        }

        public static string Create(int Level, string Code, string SalaryTableListID, int Order, DateTime Date, int PayType, double Value, string Person, string Description, bool IsSkip)
        {
            HRM_SALARY_TABLELIST hRMSALARYTABLELIST = new HRM_SALARY_TABLELIST();
            hRMSALARYTABLELIST.GetByID(new Guid(SalaryTableListID));
            int year = hRMSALARYTABLELIST.Year;
            int month = hRMSALARYTABLELIST.Month;
            DateTime dateTime = new DateTime(year, month, 1);
            DateTime dateTime1 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            foreach (DataRow row in hRMEMPLOYEE.GetCompactList(Level, Code, 1, dateTime, dateTime1).Rows)
            {
                string[] str = new string[] { "Đang cập nhật...", row["FirstName"].ToString(), " ", row["LastName"].ToString(), " (", row["EmployeeCode"].ToString(), ")" };
                Options.SetWaitDialogCaption(string.Concat(str));
                Thread thread = new Thread(() => HRM_SALARY_PAY.Create(SalaryTableListID, row["EmployeeCode"].ToString(), Order, Date, PayType, Value, Person, Description, IsSkip));
                thread.Start();
                thread.Join();
            }
            Options.HideDialog();
            return "OK";
        }

        public static string Create(string SalaryTableListID, string EmployeeCode, int Order, DateTime Date, int PayType, double Value, string Person, string Description, bool IsSkip)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@Order", "@Date", "@PayType", "@Value", "@Person", "@Description", "@IsSkip" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, Order, Date, PayType, Value, Person, Description, IsSkip };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PAY_Create", strArrays1, salaryTableListID);
        }

        public string Delete(Guid SalaryTableListID, string EmployeeCode, Guid SalaryPayID)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PAY_Delete", strArrays, salaryTableListID);
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PAY_DeleteBy", strArrays, mSalaryTableListID);
        }

        public string Delete(Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PAY_DeleteBy", strArrays, salaryTableListID);
        }

        public string Delete(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_PAY_DeleteBy", strArrays, salaryTableListID);
        }

        public string Delete(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_PAY_DeleteBy", strArrays, salaryTableListID);
        }

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool Exist(Guid SalaryTableListID, string EmployeeCode, string SalaryPayID)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_PAY_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(Guid SalaryTableListID, string EmployeeCode, string SalaryPayID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_PAY_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryPayID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryPayID"));
                    this.m_Order = Convert.ToInt32(sqlDataReader["Order"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_PayMoney = Convert.ToDecimal(sqlDataReader["PayMoney"]);
                    this.m_RealMoney = Convert.ToDecimal(sqlDataReader["RealMoney"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, string SalaryPayID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_SALARY_PAY_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryPayID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryPayID"));
                    this.m_Order = Convert.ToInt32(sqlDataReader["Order"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_PayMoney = Convert.ToDecimal(sqlDataReader["PayMoney"]);
                    this.m_RealMoney = Convert.ToDecimal(sqlDataReader["RealMoney"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public string Get(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, string SalaryPayID)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_SALARY_PAY_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SalaryPayID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryPayID"));
                    this.m_Order = Convert.ToInt32(sqlDataReader["Order"]);
                    this.m_Reason = Convert.ToString(sqlDataReader["Reason"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_PayMoney = Convert.ToDecimal(sqlDataReader["PayMoney"]);
                    this.m_RealMoney = Convert.ToDecimal(sqlDataReader["RealMoney"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    this.m_Description = Convert.ToString(sqlDataReader["Description"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetList(int Level, string Code, Guid SalaryTableListID)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@SalaryTableListID" };
            object[] level = new object[] { Level, Code, SalaryTableListID };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_PAY_GetList", strArrays, level);
        }

        public DataTable GetList(Guid SalaryTableListID, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_PAY_GetList1", strArrays, salaryTableListID);
        }

        public DataTable GetListByOrder(int Level, string Code, Guid SalaryTableListID, int Order)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@SalaryTableListID", "@Order" };
            object[] level = new object[] { Level, Code, SalaryTableListID, Order };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_PAY_GetListByOrder", strArrays, level);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID", "@Order", "@Reason", "@Date", "@Money", "@PayMoney", "@RealMoney", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryPayID, this.m_Order, this.m_Reason, this.m_Date, this.m_Money, this.m_PayMoney, this.m_RealMoney, this.m_Person, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PAY_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID", "@Order", "@Reason", "@Date", "@Money", "@PayMoney", "@RealMoney", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryPayID, this.m_Order, this.m_Reason, this.m_Date, this.m_Money, this.m_PayMoney, this.m_RealMoney, this.m_Person, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_PAY_Insert", strArrays1, mSalaryTableListID);
        }

        public string Insert(Guid SalaryTableListID, string EmployeeCode, Guid SalaryPayID, int Order, string Reason, DateTime Date, decimal Money, decimal PayMoney, decimal RealMoney, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID", "@Order", "@Reason", "@Date", "@Money", "@PayMoney", "@RealMoney", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID, Order, Reason, Date, Money, PayMoney, RealMoney, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PAY_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, Guid SalaryPayID, int Order, string Reason, DateTime Date, decimal Money, decimal PayMoney, decimal RealMoney, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID", "@Order", "@Reason", "@Date", "@Money", "@PayMoney", "@RealMoney", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID, Order, Reason, Date, Money, PayMoney, RealMoney, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_PAY_Insert", strArrays1, salaryTableListID);
        }

        public string Insert(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, Guid SalaryPayID, int Order, string Reason, DateTime Date, decimal Money, decimal PayMoney, decimal RealMoney, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID", "@Order", "@Reason", "@Date", "@Money", "@PayMoney", "@RealMoney", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID, Order, Reason, Date, Money, PayMoney, RealMoney, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_PAY_Insert", strArrays1, salaryTableListID);
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID", "@Order", "@Reason", "@Date", "@Money", "@PayMoney", "@RealMoney", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryPayID, this.m_Order, this.m_Reason, this.m_Date, this.m_Money, this.m_PayMoney, this.m_RealMoney, this.m_Person, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PAY_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID", "@Order", "@Reason", "@Date", "@Money", "@PayMoney", "@RealMoney", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mSalaryTableListID = new object[] { this.m_SalaryTableListID, this.m_EmployeeCode, this.m_SalaryPayID, this.m_Order, this.m_Reason, this.m_Date, this.m_Money, this.m_PayMoney, this.m_RealMoney, this.m_Person, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_PAY_Update", strArrays1, mSalaryTableListID);
        }

        public string Update(Guid SalaryTableListID, string EmployeeCode, Guid SalaryPayID, int Order, string Reason, DateTime Date, decimal Money, decimal PayMoney, decimal RealMoney, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID", "@Order", "@Reason", "@Date", "@Money", "@PayMoney", "@RealMoney", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID, Order, Reason, Date, Money, PayMoney, RealMoney, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_PAY_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlConnection myConnection, Guid SalaryTableListID, string EmployeeCode, Guid SalaryPayID, int Order, string Reason, DateTime Date, decimal Money, decimal PayMoney, decimal RealMoney, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID", "@Order", "@Reason", "@Date", "@Money", "@PayMoney", "@RealMoney", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID, Order, Reason, Date, Money, PayMoney, RealMoney, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_SALARY_PAY_Update", strArrays1, salaryTableListID);
        }

        public string Update(SqlTransaction myTransaction, Guid SalaryTableListID, string EmployeeCode, Guid SalaryPayID, int Order, string Reason, DateTime Date, decimal Money, decimal PayMoney, decimal RealMoney, string Person, string Description)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@SalaryPayID", "@Order", "@Reason", "@Date", "@Money", "@PayMoney", "@RealMoney", "@Person", "@Description" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, SalaryPayID, Order, Reason, Date, Money, PayMoney, RealMoney, Person, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_SALARY_PAY_Update", strArrays1, salaryTableListID);
        }

    }
}
