using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
namespace CHBK2014_N9.ERP
{
 public   class DIC_MINIMUMSALARY
    {

        private Guid m_MinimumSalaryID;

        private decimal m_Money;

        private DateTime m_Date;

        private string m_DecideNumber;

        private string m_Person;

        private string m_FilePath;

        private bool m_IsCurrent;

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
        [DisplayName("DecideNumber")]
        public string DecideNumber
        {
            get
            {
                return this.m_DecideNumber;
            }
            set
            {
                this.m_DecideNumber = value;
            }
        }

        [Category("Column")]
        [DisplayName("FilePath")]
        public string FilePath
        {
            get
            {
                return this.m_FilePath;
            }
            set
            {
                this.m_FilePath = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsCurrent")]
        public bool IsCurrent
        {
            get
            {
                return this.m_IsCurrent;
            }
            set
            {
                this.m_IsCurrent = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("MinimumSalaryID")]
        public Guid MinimumSalaryID
        {
            get
            {
                return this.m_MinimumSalaryID;
            }
            set
            {
                this.m_MinimumSalaryID = value;
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

        public string ProductName
        {
            get
            {
                return "Class DIC_MINIMUMSALARY";
            }
        }

        public string ProductVersion
        {
            get
            {
                return "1.0.0.0";
            }
        }

        public DIC_MINIMUMSALARY()
        {
            this.m_MinimumSalaryID = Guid.Empty;
            this.m_Money = new decimal(0);
            this.m_Date = DateTime.Now;
            this.m_DecideNumber = "";
            this.m_Person = "";
            this.m_FilePath = "";
            this.m_IsCurrent = true;
        }

        public DIC_MINIMUMSALARY(Guid MinimumSalaryID, decimal Money, DateTime Date, string DecideNumber, string Person, string FilePath, bool IsCurrent)
        {
            this.m_MinimumSalaryID = MinimumSalaryID;
            this.m_Money = Money;
            this.m_Date = Date;
            this.m_DecideNumber = DecideNumber;
            this.m_Person = Person;
            this.m_FilePath = FilePath;
            this.m_IsCurrent = IsCurrent;
        }

        public string Get()
        {
            string str = "";
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_MINIMUMSALARY_Get");
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_MinimumSalaryID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("MinimumSalaryID"));
                    this.m_Money = Convert.ToDecimal(sqlDataReader["Money"]);
                    this.m_Date = Convert.ToDateTime(sqlDataReader["Date"]);
                    this.m_DecideNumber = Convert.ToString(sqlDataReader["DecideNumber"]);
                    this.m_Person = Convert.ToString(sqlDataReader["Person"]);
                    this.m_FilePath = Convert.ToString(sqlDataReader["FilePath"]);
                    this.m_IsCurrent = Convert.ToBoolean(sqlDataReader["IsCurrent"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_MINIMUMSALARY_GetList");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@MinimumSalaryID", "@Money", "@Date", "@DecideNumber", "@Person", "@FilePath", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] mMinimumSalaryID = new object[] { this.m_MinimumSalaryID, this.m_Money, this.m_Date, this.m_DecideNumber, this.m_Person, this.m_FilePath, this.m_IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery("DIC_MINIMUMSALARY_Update", strArrays1, mMinimumSalaryID);
        }

        public string Update(Guid MinimumSalaryID, decimal Money, DateTime Date, string DecideNumber, string Person, string FilePath, bool IsCurrent)
        {
            string[] strArrays = new string[] { "@MinimumSalaryID", "@Money", "@Date", "@DecideNumber", "@Person", "@FilePath", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] minimumSalaryID = new object[] { MinimumSalaryID, Money, Date, DecideNumber, Person, FilePath, IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery("DIC_MINIMUMSALARY_Update", strArrays1, minimumSalaryID);
        }

        public string Update(SqlConnection myConnection, Guid MinimumSalaryID, decimal Money, DateTime Date, string DecideNumber, string Person, string FilePath, bool IsCurrent)
        {
            string[] strArrays = new string[] { "@MinimumSalaryID", "@Money", "@Date", "@DecideNumber", "@Person", "@FilePath", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] minimumSalaryID = new object[] { MinimumSalaryID, Money, Date, DecideNumber, Person, FilePath, IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_MINIMUMSALARY_Update", strArrays1, minimumSalaryID);
        }

        public string Update(SqlTransaction myTransaction, Guid MinimumSalaryID, decimal Money, DateTime Date, string DecideNumber, string Person, string FilePath, bool IsCurrent)
        {
            string[] strArrays = new string[] { "@MinimumSalaryID", "@Money", "@Date", "@DecideNumber", "@Person", "@FilePath", "@IsCurrent" };
            string[] strArrays1 = strArrays;
            object[] minimumSalaryID = new object[] { MinimumSalaryID, Money, Date, DecideNumber, Person, FilePath, IsCurrent };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_MINIMUMSALARY_Update", strArrays1, minimumSalaryID);
        }

    }
}
