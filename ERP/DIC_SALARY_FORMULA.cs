using CHBK2014_N9.Data.Helper;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace CHBK2014_N9.ERP
{
  public  class DIC_SALARY_FORMULA
    {

        private Guid m_FormulaID;

        private double m_SocialInsurance;

        private double m_HealthInsurance;

        private double m_UnemploymentInsurance;

        private double m_SocialInsurance1;

        private double m_HealthInsurance1;

        private double m_UnemploymentInsurance1;

        private decimal m_MaximumInsurance;

        private int m_UnionType;

        private decimal m_UnionValue;

        private int m_UnionType1;

        private decimal m_UnionValue1;

        private decimal m_MaximumUnion;

        private decimal m_IncomeTax;

        private decimal m_PersonIncomeTax;

        private double m_CoefficientOvertimeWorkday;

        private double m_CoefficientOvertimeSunday;

        private double m_CoefficientOvertimeHoliday;

        private double m_CoefficientOvertimeNightWorkday;

        private double m_CoefficientOvertimeNightSunday;

        private double m_CoefficientOvertimeNightHoliday;

        private int m_TaxOvertimeWorkdayType;

        private string m_TaxOvertimeWorkdayValue;

        private int m_TaxOvertimeSundayType;

        private string m_TaxOvertimeSundayValue;

        private int m_TaxOvertimeHolidayType;

        private string m_TaxOvertimeHolidayValue;

        private int m_TaxOvertimeNightWorkdayType;

        private string m_TaxOvertimeNightWorkdayValue;

        private int m_TaxOvertimeNightSundayType;

        private string m_TaxOvertimeNightSundayValue;

        private int m_TaxOvertimeNightHolidayType;

        private string m_TaxOvertimeNightHolidayValue;

        private int m_OvertimeSaturdayType;

        private bool m_IsLateEarly;

        private double m_LateEarlyMinute;

        private bool m_IsGroupSalaryOvertime;

        private bool m_IsIncomeReCreate;

        private int m_SalaryHourType;

        private int m_RoundNumberSalary;

        [Category("Column")]
        [DisplayName("CoefficientOvertimeHoliday")]
        public double CoefficientOvertimeHoliday
        {
            get
            {
                return this.m_CoefficientOvertimeHoliday;
            }
            set
            {
                this.m_CoefficientOvertimeHoliday = value;
            }
        }

        [Category("Column")]
        [DisplayName("CoefficientOvertimeNightHoliday")]
        public double CoefficientOvertimeNightHoliday
        {
            get
            {
                return this.m_CoefficientOvertimeNightHoliday;
            }
            set
            {
                this.m_CoefficientOvertimeNightHoliday = value;
            }
        }

        [Category("Column")]
        [DisplayName("CoefficientOvertimeNightSunday")]
        public double CoefficientOvertimeNightSunday
        {
            get
            {
                return this.m_CoefficientOvertimeNightSunday;
            }
            set
            {
                this.m_CoefficientOvertimeNightSunday = value;
            }
        }

        [Category("Column")]
        [DisplayName("CoefficientOvertimeNightWorkday")]
        public double CoefficientOvertimeNightWorkday
        {
            get
            {
                return this.m_CoefficientOvertimeNightWorkday;
            }
            set
            {
                this.m_CoefficientOvertimeNightWorkday = value;
            }
        }

        [Category("Column")]
        [DisplayName("CoefficientOvertimeSunday")]
        public double CoefficientOvertimeSunday
        {
            get
            {
                return this.m_CoefficientOvertimeSunday;
            }
            set
            {
                this.m_CoefficientOvertimeSunday = value;
            }
        }

        [Category("Column")]
        [DisplayName("CoefficientOvertimeWorkday")]
        public double CoefficientOvertimeWorkday
        {
            get
            {
                return this.m_CoefficientOvertimeWorkday;
            }
            set
            {
                this.m_CoefficientOvertimeWorkday = value;
            }
        }

        [Category("Primary Key")]
        [DisplayName("FormulaID")]
        public Guid FormulaID
        {
            get
            {
                return this.m_FormulaID;
            }
            set
            {
                this.m_FormulaID = value;
            }
        }

        [Category("Column")]
        [DisplayName("HealthInsurance")]
        public double HealthInsurance
        {
            get
            {
                return this.m_HealthInsurance;
            }
            set
            {
                this.m_HealthInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("HealthInsurance1")]
        public double HealthInsurance1
        {
            get
            {
                return this.m_HealthInsurance1;
            }
            set
            {
                this.m_HealthInsurance1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("IncomeTax")]
        public decimal IncomeTax
        {
            get
            {
                return this.m_IncomeTax;
            }
            set
            {
                this.m_IncomeTax = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsGroupSalaryOvertime")]
        public bool IsGroupSalaryOvertime
        {
            get
            {
                return this.m_IsGroupSalaryOvertime;
            }
            set
            {
                this.m_IsGroupSalaryOvertime = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsIncomeReCreate")]
        public bool IsIncomeReCreate
        {
            get
            {
                return this.m_IsIncomeReCreate;
            }
            set
            {
                this.m_IsIncomeReCreate = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsLateEarly")]
        public bool IsLateEarly
        {
            get
            {
                return this.m_IsLateEarly;
            }
            set
            {
                this.m_IsLateEarly = value;
            }
        }

        [Category("Column")]
        [DisplayName("LateEarlyMinute")]
        public double LateEarlyMinute
        {
            get
            {
                return this.m_LateEarlyMinute;
            }
            set
            {
                this.m_LateEarlyMinute = value;
            }
        }

        [Category("Column")]
        [DisplayName("MaximumInsurance")]
        public decimal MaximumInsurance
        {
            get
            {
                return this.m_MaximumInsurance;
            }
            set
            {
                this.m_MaximumInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("MaximumUnion")]
        public decimal MaximumUnion
        {
            get
            {
                return this.m_MaximumUnion;
            }
            set
            {
                this.m_MaximumUnion = value;
            }
        }

        [Category("Column")]
        [DisplayName("OvertimeSaturdayType")]
        public int OvertimeSaturdayType
        {
            get
            {
                return this.m_OvertimeSaturdayType;
            }
            set
            {
                this.m_OvertimeSaturdayType = value;
            }
        }

        [Category("Column")]
        [DisplayName("PersonIncomeTax")]
        public decimal PersonIncomeTax
        {
            get
            {
                return this.m_PersonIncomeTax;
            }
            set
            {
                this.m_PersonIncomeTax = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class DIC_SALARY_FORMULA";
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
        [DisplayName("RoundNumberSalary")]
        public int RoundNumberSalary
        {
            get
            {
                return this.m_RoundNumberSalary;
            }
            set
            {
                this.m_RoundNumberSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryHourType")]
        public int SalaryHourType
        {
            get
            {
                return this.m_SalaryHourType;
            }
            set
            {
                this.m_SalaryHourType = value;
            }
        }

        [Category("Column")]
        [DisplayName("SocialInsurance")]
        public double SocialInsurance
        {
            get
            {
                return this.m_SocialInsurance;
            }
            set
            {
                this.m_SocialInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("SocialInsurance1")]
        public double SocialInsurance1
        {
            get
            {
                return this.m_SocialInsurance1;
            }
            set
            {
                this.m_SocialInsurance1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeHolidayType")]
        public int TaxOvertimeHolidayType
        {
            get
            {
                return this.m_TaxOvertimeHolidayType;
            }
            set
            {
                this.m_TaxOvertimeHolidayType = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeHolidayValue")]
        public string TaxOvertimeHolidayValue
        {
            get
            {
                return this.m_TaxOvertimeHolidayValue;
            }
            set
            {
                this.m_TaxOvertimeHolidayValue = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeNightHolidayType")]
        public int TaxOvertimeNightHolidayType
        {
            get
            {
                return this.m_TaxOvertimeNightHolidayType;
            }
            set
            {
                this.m_TaxOvertimeNightHolidayType = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeNightHolidayValue")]
        public string TaxOvertimeNightHolidayValue
        {
            get
            {
                return this.m_TaxOvertimeNightHolidayValue;
            }
            set
            {
                this.m_TaxOvertimeNightHolidayValue = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeNightSundayType")]
        public int TaxOvertimeNightSundayType
        {
            get
            {
                return this.m_TaxOvertimeNightSundayType;
            }
            set
            {
                this.m_TaxOvertimeNightSundayType = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeNightSundayValue")]
        public string TaxOvertimeNightSundayValue
        {
            get
            {
                return this.m_TaxOvertimeNightSundayValue;
            }
            set
            {
                this.m_TaxOvertimeNightSundayValue = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeNightWorkdayType")]
        public int TaxOvertimeNightWorkdayType
        {
            get
            {
                return this.m_TaxOvertimeNightWorkdayType;
            }
            set
            {
                this.m_TaxOvertimeNightWorkdayType = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeNightWorkdayValue")]
        public string TaxOvertimeNightWorkdayValue
        {
            get
            {
                return this.m_TaxOvertimeNightWorkdayValue;
            }
            set
            {
                this.m_TaxOvertimeNightWorkdayValue = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeSundayType")]
        public int TaxOvertimeSundayType
        {
            get
            {
                return this.m_TaxOvertimeSundayType;
            }
            set
            {
                this.m_TaxOvertimeSundayType = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeSundayValue")]
        public string TaxOvertimeSundayValue
        {
            get
            {
                return this.m_TaxOvertimeSundayValue;
            }
            set
            {
                this.m_TaxOvertimeSundayValue = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeWorkdayType")]
        public int TaxOvertimeWorkdayType
        {
            get
            {
                return this.m_TaxOvertimeWorkdayType;
            }
            set
            {
                this.m_TaxOvertimeWorkdayType = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertimeWorkdayValue")]
        public string TaxOvertimeWorkdayValue
        {
            get
            {
                return this.m_TaxOvertimeWorkdayValue;
            }
            set
            {
                this.m_TaxOvertimeWorkdayValue = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnemploymentInsurance")]
        public double UnemploymentInsurance
        {
            get
            {
                return this.m_UnemploymentInsurance;
            }
            set
            {
                this.m_UnemploymentInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnemploymentInsurance1")]
        public double UnemploymentInsurance1
        {
            get
            {
                return this.m_UnemploymentInsurance1;
            }
            set
            {
                this.m_UnemploymentInsurance1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnionType")]
        public int UnionType
        {
            get
            {
                return this.m_UnionType;
            }
            set
            {
                this.m_UnionType = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnionType1")]
        public int UnionType1
        {
            get
            {
                return this.m_UnionType1;
            }
            set
            {
                this.m_UnionType1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnionValue")]
        public decimal UnionValue
        {
            get
            {
                return this.m_UnionValue;
            }
            set
            {
                this.m_UnionValue = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnionValue1")]
        public decimal UnionValue1
        {
            get
            {
                return this.m_UnionValue1;
            }
            set
            {
                this.m_UnionValue1 = value;
            }
        }

        public DIC_SALARY_FORMULA()
        {
            this.m_FormulaID = Guid.Empty;
            this.m_SocialInsurance = 0;
            this.m_HealthInsurance = 0;
            this.m_UnemploymentInsurance = 0;
            this.m_SocialInsurance1 = 0;
            this.m_HealthInsurance1 = 0;
            this.m_UnemploymentInsurance1 = 0;
            this.m_MaximumInsurance = new decimal(0);
            this.m_UnionType = 0;
            this.m_UnionValue = new decimal(0);
            this.m_UnionType1 = 0;
            this.m_UnionValue1 = new decimal(0);
            this.m_MaximumUnion = new decimal(0);
            this.m_IncomeTax = new decimal(0);
            this.m_PersonIncomeTax = new decimal(0);
            this.m_CoefficientOvertimeWorkday = 0;
            this.m_CoefficientOvertimeSunday = 0;
            this.m_CoefficientOvertimeHoliday = 0;
            this.m_CoefficientOvertimeNightWorkday = 0;
            this.m_CoefficientOvertimeNightSunday = 0;
            this.m_CoefficientOvertimeNightHoliday = 0;
            this.m_TaxOvertimeWorkdayType = 0;
            this.m_TaxOvertimeWorkdayValue = "";
            this.m_TaxOvertimeSundayType = 0;
            this.m_TaxOvertimeSundayValue = "";
            this.m_TaxOvertimeHolidayType = 0;
            this.m_TaxOvertimeHolidayValue = "";
            this.m_TaxOvertimeNightWorkdayType = 0;
            this.m_TaxOvertimeNightWorkdayValue = "";
            this.m_TaxOvertimeNightSundayType = 0;
            this.m_TaxOvertimeNightSundayValue = "";
            this.m_TaxOvertimeNightHolidayType = 0;
            this.m_TaxOvertimeNightHolidayValue = "";
            this.m_OvertimeSaturdayType = 0;
            this.m_IsLateEarly = false;
            this.m_LateEarlyMinute = 0;
            this.m_IsGroupSalaryOvertime = true;
            this.m_IsIncomeReCreate = true;
            this.m_SalaryHourType = 0;
            this.m_RoundNumberSalary = 0;
        }

        public DIC_SALARY_FORMULA(Guid FormulaID, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, decimal MaximumInsurance, int UnionType, decimal UnionValue, int UnionType1, decimal UnionValue1, decimal MaximumUnion, decimal IncomeTax, decimal PersonIncomeTax, double CoefficientOvertimeWorkday, double CoefficientOvertimeSunday, double CoefficientOvertimeHoliday, double CoefficientOvertimeNightWorkday, double CoefficientOvertimeNightSunday, double CoefficientOvertimeNightHoliday, int TaxOvertimeWorkdayType, string TaxOvertimeWorkdayValue, int TaxOvertimeSundayType, string TaxOvertimeSundayValue, int TaxOvertimeHolidayType, string TaxOvertimeHolidayValue, int TaxOvertimeNightWorkdayType, string TaxOvertimeNightWorkdayValue, int TaxOvertimeNightSundayType, string TaxOvertimeNightSundayValue, int TaxOvertimeNightHolidayType, string TaxOvertimeNightHolidayValue, int OvertimeSaturdayType, bool IsLateEarly, double LateEarlyMinute, bool IsGroupSalaryOvertime, bool IsIncomeReCreate, int SalaryHourType, int RoundNumberSalary)
        {
            this.m_FormulaID = FormulaID;
            this.m_SocialInsurance = SocialInsurance;
            this.m_HealthInsurance = HealthInsurance;
            this.m_UnemploymentInsurance = UnemploymentInsurance;
            this.m_SocialInsurance1 = SocialInsurance1;
            this.m_HealthInsurance1 = HealthInsurance1;
            this.m_UnemploymentInsurance1 = UnemploymentInsurance1;
            this.m_MaximumInsurance = MaximumInsurance;
            this.m_UnionType = UnionType;
            this.m_UnionValue = UnionValue;
            this.m_UnionType1 = UnionType1;
            this.m_UnionValue1 = UnionValue1;
            this.m_MaximumUnion = MaximumUnion;
            this.m_IncomeTax = IncomeTax;
            this.m_PersonIncomeTax = PersonIncomeTax;
            this.m_CoefficientOvertimeWorkday = CoefficientOvertimeWorkday;
            this.m_CoefficientOvertimeSunday = CoefficientOvertimeSunday;
            this.m_CoefficientOvertimeHoliday = CoefficientOvertimeHoliday;
            this.m_CoefficientOvertimeNightWorkday = CoefficientOvertimeNightWorkday;
            this.m_CoefficientOvertimeNightSunday = CoefficientOvertimeNightSunday;
            this.m_CoefficientOvertimeNightHoliday = CoefficientOvertimeNightHoliday;
            this.m_TaxOvertimeWorkdayType = TaxOvertimeWorkdayType;
            this.m_TaxOvertimeWorkdayValue = TaxOvertimeWorkdayValue;
            this.m_TaxOvertimeSundayType = TaxOvertimeSundayType;
            this.m_TaxOvertimeSundayValue = TaxOvertimeSundayValue;
            this.m_TaxOvertimeHolidayType = TaxOvertimeHolidayType;
            this.m_TaxOvertimeHolidayValue = TaxOvertimeHolidayValue;
            this.m_TaxOvertimeNightWorkdayType = TaxOvertimeNightWorkdayType;
            this.m_TaxOvertimeNightWorkdayValue = TaxOvertimeNightWorkdayValue;
            this.m_TaxOvertimeNightSundayType = TaxOvertimeNightSundayType;
            this.m_TaxOvertimeNightSundayValue = TaxOvertimeNightSundayValue;
            this.m_TaxOvertimeNightHolidayType = TaxOvertimeNightHolidayType;
            this.m_TaxOvertimeNightHolidayValue = TaxOvertimeNightHolidayValue;
            this.m_OvertimeSaturdayType = OvertimeSaturdayType;
            this.m_IsLateEarly = IsLateEarly;
            this.m_LateEarlyMinute = LateEarlyMinute;
            this.m_IsGroupSalaryOvertime = IsGroupSalaryOvertime;
            this.m_IsIncomeReCreate = IsIncomeReCreate;
            this.m_SalaryHourType = SalaryHourType;
            this.m_RoundNumberSalary = RoundNumberSalary;
        }

        public string Get()
        {
            object item;
            object obj;
            object item1;
            object obj1;
            object item2;
            object obj2;
            string str = "";
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("DIC_SALARY_FORMULA_Get");
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_FormulaID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("FormulaID"));
                    this.m_SocialInsurance = Convert.ToDouble(sqlDataReader["SocialInsurance"]);
                    this.m_HealthInsurance = Convert.ToDouble(sqlDataReader["HealthInsurance"]);
                    this.m_UnemploymentInsurance = Convert.ToDouble(sqlDataReader["UnemploymentInsurance"]);
                    this.m_SocialInsurance1 = Convert.ToDouble(sqlDataReader["SocialInsurance1"]);
                    this.m_HealthInsurance1 = Convert.ToDouble(sqlDataReader["HealthInsurance1"]);
                    this.m_UnemploymentInsurance1 = Convert.ToDouble(sqlDataReader["UnemploymentInsurance1"]);
                    this.m_MaximumInsurance = Convert.ToDecimal(sqlDataReader["MaximumInsurance"]);
                    this.m_UnionType = Convert.ToInt32(sqlDataReader["UnionType"]);
                    this.m_UnionValue = Convert.ToDecimal(sqlDataReader["UnionValue"]);
                    this.m_UnionType1 = Convert.ToInt32(sqlDataReader["UnionType1"]);
                    this.m_UnionValue1 = Convert.ToDecimal(sqlDataReader["UnionValue1"]);
                    this.m_MaximumUnion = Convert.ToDecimal(sqlDataReader["MaximumUnion"]);
                    this.m_IncomeTax = Convert.ToDecimal(sqlDataReader["IncomeTax"]);
                    this.m_PersonIncomeTax = Convert.ToDecimal(sqlDataReader["PersonIncomeTax"]);
                    this.m_CoefficientOvertimeWorkday = Convert.ToDouble(sqlDataReader["CoefficientOvertimeWorkday"]);
                    this.m_CoefficientOvertimeSunday = Convert.ToDouble(sqlDataReader["CoefficientOvertimeSunday"]);
                    this.m_CoefficientOvertimeHoliday = Convert.ToDouble(sqlDataReader["CoefficientOvertimeHoliday"]);
                    this.m_CoefficientOvertimeNightWorkday = Convert.ToDouble(sqlDataReader["CoefficientOvertimeNightWorkday"]);
                    this.m_CoefficientOvertimeNightSunday = Convert.ToDouble(sqlDataReader["CoefficientOvertimeNightSunday"]);
                    this.m_CoefficientOvertimeNightHoliday = Convert.ToDouble(sqlDataReader["CoefficientOvertimeNightHoliday"]);
                    this.m_TaxOvertimeWorkdayType = Convert.ToInt32((sqlDataReader["TaxOvertimeWorkdayType"] == DBNull.Value ? 0 : sqlDataReader["TaxOvertimeWorkdayType"]));
                    if (sqlDataReader["TaxOvertimeWorkdayValue"] == DBNull.Value)
                    {
                        item = "";
                    }
                    else
                    {
                        item = sqlDataReader["TaxOvertimeWorkdayValue"];
                    }
                    this.m_TaxOvertimeWorkdayValue = Convert.ToString(item);
                    this.m_TaxOvertimeSundayType = Convert.ToInt32((sqlDataReader["TaxOvertimeSundayType"] == DBNull.Value ? 0 : sqlDataReader["TaxOvertimeSundayType"]));
                    if (sqlDataReader["TaxOvertimeSundayValue"] == DBNull.Value)
                    {
                        obj = "";
                    }
                    else
                    {
                        obj = sqlDataReader["TaxOvertimeSundayValue"];
                    }
                    this.m_TaxOvertimeSundayValue = Convert.ToString(obj);
                    this.m_TaxOvertimeHolidayType = Convert.ToInt32((sqlDataReader["TaxOvertimeHolidayType"] == DBNull.Value ? 0 : sqlDataReader["TaxOvertimeHolidayType"]));
                    if (sqlDataReader["TaxOvertimeHolidayValue"] == DBNull.Value)
                    {
                        item1 = "";
                    }
                    else
                    {
                        item1 = sqlDataReader["TaxOvertimeHolidayValue"];
                    }
                    this.m_TaxOvertimeHolidayValue = Convert.ToString(item1);
                    this.m_TaxOvertimeNightWorkdayType = Convert.ToInt32((sqlDataReader["TaxOvertimeNightWorkdayType"] == DBNull.Value ? 0 : sqlDataReader["TaxOvertimeNightWorkdayType"]));
                    if (sqlDataReader["TaxOvertimeNightWorkdayValue"] == DBNull.Value)
                    {
                        obj1 = "";
                    }
                    else
                    {
                        obj1 = sqlDataReader["TaxOvertimeNightWorkdayValue"];
                    }
                    this.m_TaxOvertimeNightWorkdayValue = Convert.ToString(obj1);
                    this.m_TaxOvertimeNightSundayType = Convert.ToInt32((sqlDataReader["TaxOvertimeNightSundayType"] == DBNull.Value ? 0 : sqlDataReader["TaxOvertimeNightSundayType"]));
                    if (sqlDataReader["TaxOvertimeNightSundayValue"] == DBNull.Value)
                    {
                        item2 = "";
                    }
                    else
                    {
                        item2 = sqlDataReader["TaxOvertimeNightSundayValue"];
                    }
                    this.m_TaxOvertimeNightSundayValue = Convert.ToString(item2);
                    this.m_TaxOvertimeNightHolidayType = Convert.ToInt32((sqlDataReader["TaxOvertimeNightHolidayType"] == DBNull.Value ? 0 : sqlDataReader["TaxOvertimeNightHolidayType"]));
                    if (sqlDataReader["TaxOvertimeNightHolidayValue"] == DBNull.Value)
                    {
                        obj2 = "";
                    }
                    else
                    {
                        obj2 = sqlDataReader["TaxOvertimeNightHolidayValue"];
                    }
                    this.m_TaxOvertimeNightHolidayValue = Convert.ToString(obj2);
                    this.m_OvertimeSaturdayType = Convert.ToInt32(sqlDataReader["OvertimeSaturdayType"]);
                    this.m_IsLateEarly = Convert.ToBoolean(sqlDataReader["IsLateEarly"]);
                    this.m_LateEarlyMinute = Convert.ToDouble(sqlDataReader["LateEarlyMinute"]);
                    this.m_IsGroupSalaryOvertime = Convert.ToBoolean(sqlDataReader["IsGroupSalaryOvertime"]);
                    this.m_IsIncomeReCreate = (sqlDataReader["IsIncomeReCreate"] == DBNull.Value ? true : Convert.ToBoolean(sqlDataReader["IsIncomeReCreate"]));
                    this.m_SalaryHourType = Convert.ToInt32(sqlDataReader["SalaryHourType"]);
                    this.m_RoundNumberSalary = Convert.ToInt32(sqlDataReader["RoundNumberSalary"]);
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
            return (new SqlHelper()).ExecuteDataTable("DIC_SALARY_FORMULA_GetList");
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@FormulaID", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@MaximumInsurance", "@UnionType", "@UnionValue", "@UnionType1", "@UnionValue1", "@MaximumUnion", "@IncomeTax", "@PersonIncomeTax", "@CoefficientOvertimeWorkday", "@CoefficientOvertimeSunday", "@CoefficientOvertimeHoliday", "@CoefficientOvertimeNightWorkday", "@CoefficientOvertimeNightSunday", "@CoefficientOvertimeNightHoliday", "@TaxOvertimeWorkdayType", "@TaxOvertimeWorkdayValue", "@TaxOvertimeSundayType", "@TaxOvertimeSundayValue", "@TaxOvertimeHolidayType", "@TaxOvertimeHolidayValue", "@TaxOvertimeNightWorkdayType", "@TaxOvertimeNightWorkdayValue", "@TaxOvertimeNightSundayType", "@TaxOvertimeNightSundayValue", "@TaxOvertimeNightHolidayType", "@TaxOvertimeNightHolidayValue", "@OvertimeSaturdayType", "@IsLateEarly", "@LateEarlyMinute", "@IsGroupSalaryOvertime", "@IsIncomeReCreate", "@SalaryHourType", "@RoundNumberSalary" };
            string[] strArrays1 = strArrays;
            object[] mFormulaID = new object[] { this.m_FormulaID, this.m_SocialInsurance, this.m_HealthInsurance, this.m_UnemploymentInsurance, this.m_SocialInsurance1, this.m_HealthInsurance1, this.m_UnemploymentInsurance1, this.m_MaximumInsurance, this.m_UnionType, this.m_UnionValue, this.m_UnionType1, this.m_UnionValue1, this.m_MaximumUnion, this.m_IncomeTax, this.m_PersonIncomeTax, this.m_CoefficientOvertimeWorkday, this.m_CoefficientOvertimeSunday, this.m_CoefficientOvertimeHoliday, this.m_CoefficientOvertimeNightWorkday, this.m_CoefficientOvertimeNightSunday, this.m_CoefficientOvertimeNightHoliday, this.m_TaxOvertimeWorkdayType, this.m_TaxOvertimeWorkdayValue, this.m_TaxOvertimeSundayType, this.m_TaxOvertimeSundayValue, this.m_TaxOvertimeHolidayType, this.m_TaxOvertimeHolidayValue, this.m_TaxOvertimeNightWorkdayType, this.m_TaxOvertimeNightWorkdayValue, this.m_TaxOvertimeNightSundayType, this.m_TaxOvertimeNightSundayValue, this.m_TaxOvertimeNightHolidayType, this.m_TaxOvertimeNightHolidayValue, this.m_OvertimeSaturdayType, this.m_IsLateEarly, this.m_LateEarlyMinute, this.m_IsGroupSalaryOvertime, this.m_IsIncomeReCreate, this.m_SalaryHourType, this.m_RoundNumberSalary };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_FORMULA_Update", strArrays1, mFormulaID);
        }

        public string Update(Guid FormulaID, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, decimal MaximumInsurance, int UnionType, decimal UnionValue, int UnionType1, decimal UnionValue1, decimal MaximumUnion, decimal IncomeTax, decimal PersonIncomeTax, double CoefficientOvertimeWorkday, double CoefficientOvertimeSunday, double CoefficientOvertimeHoliday, double CoefficientOvertimeNightWorkday, double CoefficientOvertimeNightSunday, double CoefficientOvertimeNightHoliday, int TaxOvertimeWorkdayType, string TaxOvertimeWorkdayValue, int TaxOvertimeSundayType, string TaxOvertimeSundayValue, int TaxOvertimeHolidayType, string TaxOvertimeHolidayValue, int TaxOvertimeNightWorkdayType, string TaxOvertimeNightWorkdayValue, int TaxOvertimeNightSundayType, string TaxOvertimeNightSundayValue, int TaxOvertimeNightHolidayType, string TaxOvertimeNightHolidayValue, int OvertimeSaturdayType, bool IsLateEarly, double LateEarlyMinute, bool IsGroupSalaryOvertime, bool IsIncomeReCreate, int SalaryHourType, int RoundNumberSalary)
        {
            string[] strArrays = new string[] { "@FormulaID", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@MaximumInsurance", "@UnionType", "@UnionValue", "@UnionType1", "@UnionValue1", "@MaximumUnion", "@IncomeTax", "@PersonIncomeTax", "@CoefficientOvertimeWorkday", "@CoefficientOvertimeSunday", "@CoefficientOvertimeHoliday", "@CoefficientOvertimeNightWorkday", "@CoefficientOvertimeNightSunday", "@CoefficientOvertimeNightHoliday", "@TaxOvertimeWorkdayType", "@TaxOvertimeWorkdayValue", "@TaxOvertimeSundayType", "@TaxOvertimeSundayValue", "@TaxOvertimeHolidayType", "@TaxOvertimeHolidayValue", "@TaxOvertimeNightWorkdayType", "@TaxOvertimeNightWorkdayValue", "@TaxOvertimeNightSundayType", "@TaxOvertimeNightSundayValue", "@TaxOvertimeNightHolidayType", "@TaxOvertimeNightHolidayValue", "@OvertimeSaturdayType", "@IsLateEarly", "@LateEarlyMinute", "@IsGroupSalaryOvertime", "@IsIncomeReCreate", "@SalaryHourType", "@RoundNumberSalary" };
            string[] strArrays1 = strArrays;
            object[] formulaID = new object[] { FormulaID, SocialInsurance, HealthInsurance, UnemploymentInsurance, SocialInsurance1, HealthInsurance1, UnemploymentInsurance1, MaximumInsurance, UnionType, UnionValue, UnionType1, UnionValue1, MaximumUnion, IncomeTax, PersonIncomeTax, CoefficientOvertimeWorkday, CoefficientOvertimeSunday, CoefficientOvertimeHoliday, CoefficientOvertimeNightWorkday, CoefficientOvertimeNightSunday, CoefficientOvertimeNightHoliday, TaxOvertimeWorkdayType, TaxOvertimeWorkdayValue, TaxOvertimeSundayType, TaxOvertimeSundayValue, TaxOvertimeHolidayType, TaxOvertimeHolidayValue, TaxOvertimeNightWorkdayType, TaxOvertimeNightWorkdayValue, TaxOvertimeNightSundayType, TaxOvertimeNightSundayValue, TaxOvertimeNightHolidayType, TaxOvertimeNightHolidayValue, OvertimeSaturdayType, IsLateEarly, LateEarlyMinute, IsGroupSalaryOvertime, IsIncomeReCreate, SalaryHourType, RoundNumberSalary };
            return (new SqlHelper()).ExecuteNonQuery("DIC_SALARY_FORMULA_Update", strArrays1, formulaID);
        }

        public string Update(SqlConnection myConnection, Guid FormulaID, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, decimal MaximumInsurance, int UnionType, decimal UnionValue, int UnionType1, decimal UnionValue1, decimal MaximumUnion, decimal IncomeTax, decimal PersonIncomeTax, double CoefficientOvertimeWorkday, double CoefficientOvertimeSunday, double CoefficientOvertimeHoliday, double CoefficientOvertimeNightWorkday, double CoefficientOvertimeNightSunday, double CoefficientOvertimeNightHoliday, int TaxOvertimeWorkdayType, string TaxOvertimeWorkdayValue, int TaxOvertimeSundayType, string TaxOvertimeSundayValue, int TaxOvertimeHolidayType, string TaxOvertimeHolidayValue, int TaxOvertimeNightWorkdayType, string TaxOvertimeNightWorkdayValue, int TaxOvertimeNightSundayType, string TaxOvertimeNightSundayValue, int TaxOvertimeNightHolidayType, string TaxOvertimeNightHolidayValue, int OvertimeSaturdayType, bool IsLateEarly, double LateEarlyMinute, bool IsGroupSalaryOvertime, bool IsIncomeReCreate, int SalaryHourType, int RoundNumberSalary)
        {
            string[] strArrays = new string[] { "@FormulaID", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@MaximumInsurance", "@UnionType", "@UnionValue", "@UnionType1", "@UnionValue1", "@MaximumUnion", "@IncomeTax", "@PersonIncomeTax", "@CoefficientOvertimeWorkday", "@CoefficientOvertimeSunday", "@CoefficientOvertimeHoliday", "@CoefficientOvertimeNightWorkday", "@CoefficientOvertimeNightSunday", "@CoefficientOvertimeNightHoliday", "@TaxOvertimeWorkdayType", "@TaxOvertimeWorkdayValue", "@TaxOvertimeSundayType", "@TaxOvertimeSundayValue", "@TaxOvertimeHolidayType", "@TaxOvertimeHolidayValue", "@TaxOvertimeNightWorkdayType", "@TaxOvertimeNightWorkdayValue", "@TaxOvertimeNightSundayType", "@TaxOvertimeNightSundayValue", "@TaxOvertimeNightHolidayType", "@TaxOvertimeNightHolidayValue", "@OvertimeSaturdayType", "@IsLateEarly", "@LateEarlyMinute", "@IsGroupSalaryOvertime", "@IsIncomeReCreate", "@SalaryHourType", "@RoundNumberSalary" };
            string[] strArrays1 = strArrays;
            object[] formulaID = new object[] { FormulaID, SocialInsurance, HealthInsurance, UnemploymentInsurance, SocialInsurance1, HealthInsurance1, UnemploymentInsurance1, MaximumInsurance, UnionType, UnionValue, UnionType1, UnionValue1, MaximumUnion, IncomeTax, PersonIncomeTax, CoefficientOvertimeWorkday, CoefficientOvertimeSunday, CoefficientOvertimeHoliday, CoefficientOvertimeNightWorkday, CoefficientOvertimeNightSunday, CoefficientOvertimeNightHoliday, TaxOvertimeWorkdayType, TaxOvertimeWorkdayValue, TaxOvertimeSundayType, TaxOvertimeSundayValue, TaxOvertimeHolidayType, TaxOvertimeHolidayValue, TaxOvertimeNightWorkdayType, TaxOvertimeNightWorkdayValue, TaxOvertimeNightSundayType, TaxOvertimeNightSundayValue, TaxOvertimeNightHolidayType, TaxOvertimeNightHolidayValue, OvertimeSaturdayType, IsLateEarly, LateEarlyMinute, IsGroupSalaryOvertime, IsIncomeReCreate, SalaryHourType, RoundNumberSalary };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "DIC_SALARY_FORMULA_Update", strArrays1, formulaID);
        }

        public string Update(SqlTransaction myTransaction, Guid FormulaID, double SocialInsurance, double HealthInsurance, double UnemploymentInsurance, double SocialInsurance1, double HealthInsurance1, double UnemploymentInsurance1, decimal MaximumInsurance, int UnionType, decimal UnionValue, int UnionType1, decimal UnionValue1, decimal MaximumUnion, decimal IncomeTax, decimal PersonIncomeTax, double CoefficientOvertimeWorkday, double CoefficientOvertimeSunday, double CoefficientOvertimeHoliday, double CoefficientOvertimeNightWorkday, double CoefficientOvertimeNightSunday, double CoefficientOvertimeNightHoliday, int TaxOvertimeWorkdayType, string TaxOvertimeWorkdayValue, int TaxOvertimeSundayType, string TaxOvertimeSundayValue, int TaxOvertimeHolidayType, string TaxOvertimeHolidayValue, int TaxOvertimeNightWorkdayType, string TaxOvertimeNightWorkdayValue, int TaxOvertimeNightSundayType, string TaxOvertimeNightSundayValue, int TaxOvertimeNightHolidayType, string TaxOvertimeNightHolidayValue, int OvertimeSaturdayType, bool IsLateEarly, double LateEarlyMinute, bool IsGroupSalaryOvertime, bool IsIncomeReCreate, int SalaryHourType, int RoundNumberSalary)
        {
            string[] strArrays = new string[] { "@FormulaID", "@SocialInsurance", "@HealthInsurance", "@UnemploymentInsurance", "@SocialInsurance1", "@HealthInsurance1", "@UnemploymentInsurance1", "@MaximumInsurance", "@UnionType", "@UnionValue", "@UnionType1", "@UnionValue1", "@MaximumUnion", "@IncomeTax", "@PersonIncomeTax", "@CoefficientOvertimeWorkday", "@CoefficientOvertimeSunday", "@CoefficientOvertimeHoliday", "@CoefficientOvertimeNightWorkday", "@CoefficientOvertimeNightSunday", "@CoefficientOvertimeNightHoliday", "@TaxOvertimeWorkdayType", "@TaxOvertimeWorkdayValue", "@TaxOvertimeSundayType", "@TaxOvertimeSundayValue", "@TaxOvertimeHolidayType", "@TaxOvertimeHolidayValue", "@TaxOvertimeNightWorkdayType", "@TaxOvertimeNightWorkdayValue", "@TaxOvertimeNightSundayType", "@TaxOvertimeNightSundayValue", "@TaxOvertimeNightHolidayType", "@TaxOvertimeNightHolidayValue", "@OvertimeSaturdayType", "@IsLateEarly", "@LateEarlyMinute", "@IsGroupSalaryOvertime", "@IsIncomeReCreate", "@SalaryHourType", "@RoundNumberSalary" };
            string[] strArrays1 = strArrays;
            object[] formulaID = new object[] { FormulaID, SocialInsurance, HealthInsurance, UnemploymentInsurance, SocialInsurance1, HealthInsurance1, UnemploymentInsurance1, MaximumInsurance, UnionType, UnionValue, UnionType1, UnionValue1, MaximumUnion, IncomeTax, PersonIncomeTax, CoefficientOvertimeWorkday, CoefficientOvertimeSunday, CoefficientOvertimeHoliday, CoefficientOvertimeNightWorkday, CoefficientOvertimeNightSunday, CoefficientOvertimeNightHoliday, TaxOvertimeWorkdayType, TaxOvertimeWorkdayValue, TaxOvertimeSundayType, TaxOvertimeSundayValue, TaxOvertimeHolidayType, TaxOvertimeHolidayValue, TaxOvertimeNightWorkdayType, TaxOvertimeNightWorkdayValue, TaxOvertimeNightSundayType, TaxOvertimeNightSundayValue, TaxOvertimeNightHolidayType, TaxOvertimeNightHolidayValue, OvertimeSaturdayType, IsLateEarly, LateEarlyMinute, IsGroupSalaryOvertime, IsIncomeReCreate, SalaryHourType, RoundNumberSalary };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "DIC_SALARY_FORMULA_Update", strArrays1, formulaID);
        }
    }
}
