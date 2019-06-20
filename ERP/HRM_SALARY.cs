using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Data.Helper;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CHBK2014_N9.ERP
{
 public   class HRM_SALARY
    {

        private Guid m_SalaryTableListID;

        private string m_EmployeeCode;

        private decimal m_MinimumSalary;

        private double m_CoefficientSalary;

        private decimal m_BasicSalary;

        private decimal m_InsuranceSalary;

        private double m_StipulatedTime;

        private double m_WorkHour;

        private double m_LateEarlyHour;

        private decimal m_MinusLateEarly;

        private decimal m_MinusMoney;

        private decimal m_AllowanceInsurance;

        private decimal m_Allowance;

        private decimal m_TotalSalary;

        private decimal m_SalaryHour;

        private decimal m_SalaryOvertime;

        private decimal m_SalaryOvertime150;

        private decimal m_SalaryOvertime200;

        private decimal m_SalaryOvertime300;

        private decimal m_SalaryOvertime195;

        private decimal m_SalaryOvertime260;

        private decimal m_SalaryOvertime390;

        private decimal m_Assignment;

        private decimal m_AssignmentPay;

        private decimal m_AssignmentDebt;

        private decimal m_WorkSalary;

        private decimal m_SocialInsurance;

        private decimal m_HealthInsurance;

        private decimal m_UnemploymentInsurance;

        private decimal m_Insurance;

        private decimal m_SalaryPlusBefore;

        private decimal m_SalaryMinusBefore;

        private decimal m_WorkSalary1;

        private decimal m_IncomeTax;

        private int m_NumberDepend;

        private decimal m_DependMoney;

        private decimal m_TaxYourSelfMoney;

        private decimal m_TaxOvertime150Money;

        private decimal m_TaxOvertime200Money;

        private decimal m_TaxOvertime300Money;

        private decimal m_TaxOvertime195Money;

        private decimal m_TaxOvertime260Money;

        private decimal m_TaxOvertime390Money;

        private decimal m_IncomeTaxRemain;

        private decimal m_IncomeTaxMoney;

        private decimal m_RemainSalary;

        private decimal m_Advance;

        private decimal m_Union;

        private decimal m_Union1;

        private decimal m_SalaryPlus;

        private decimal m_SalaryPlusPay;

        private decimal m_SalaryMinus;

        private decimal m_Salary;

        private decimal m_SalaryPay;

        private decimal m_SalaryDebt;

        [Category("Column")]
        [DisplayName("Advance")]
        public decimal Advance
        {
            get
            {
                return this.m_Advance;
            }
            set
            {
                this.m_Advance = value;
            }
        }

        [Category("Column")]
        [DisplayName("Allowance")]
        public decimal Allowance
        {
            get
            {
                return this.m_Allowance;
            }
            set
            {
                this.m_Allowance = value;
            }
        }

        [Category("Column")]
        [DisplayName("AllowanceInsurance")]
        public decimal AllowanceInsurance
        {
            get
            {
                return this.m_AllowanceInsurance;
            }
            set
            {
                this.m_AllowanceInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("Assignment")]
        public decimal Assignment
        {
            get
            {
                return this.m_Assignment;
            }
            set
            {
                this.m_Assignment = value;
            }
        }

        [Category("Column")]
        [DisplayName("AssignmentDebt")]
        public decimal AssignmentDebt
        {
            get
            {
                return this.m_AssignmentDebt;
            }
            set
            {
                this.m_AssignmentDebt = value;
            }
        }

        [Category("Column")]
        [DisplayName("AssignmentPay")]
        public decimal AssignmentPay
        {
            get
            {
                return this.m_AssignmentPay;
            }
            set
            {
                this.m_AssignmentPay = value;
            }
        }

        [Category("Column")]
        [DisplayName("BasicSalary")]
        public decimal BasicSalary
        {
            get
            {
                return this.m_BasicSalary;
            }
            set
            {
                this.m_BasicSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("CoefficientSalary")]
        public double CoefficientSalary
        {
            get
            {
                return this.m_CoefficientSalary;
            }
            set
            {
                this.m_CoefficientSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("DependMoney")]
        public decimal DependMoney
        {
            get
            {
                return this.m_DependMoney;
            }
            set
            {
                this.m_DependMoney = value;
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
        [DisplayName("HealthInsurance")]
        public decimal HealthInsurance
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
        [DisplayName("IncomeTaxMoney")]
        public decimal IncomeTaxMoney
        {
            get
            {
                return this.m_IncomeTaxMoney;
            }
            set
            {
                this.m_IncomeTaxMoney = value;
            }
        }

        [Category("Column")]
        [DisplayName("IncomeTaxRemain")]
        public decimal IncomeTaxRemain
        {
            get
            {
                return this.m_IncomeTaxRemain;
            }
            set
            {
                this.m_IncomeTaxRemain = value;
            }
        }

        [Category("Column")]
        [DisplayName("Insurance")]
        public decimal Insurance
        {
            get
            {
                return this.m_Insurance;
            }
            set
            {
                this.m_Insurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("InsuranceSalary")]
        public decimal InsuranceSalary
        {
            get
            {
                return this.m_InsuranceSalary;
            }
            set
            {
                this.m_InsuranceSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("LateEarlyHour")]
        public double LateEarlyHour
        {
            get
            {
                return this.m_LateEarlyHour;
            }
            set
            {
                this.m_LateEarlyHour = value;
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
        [DisplayName("MinusLateEarly")]
        public decimal MinusLateEarly
        {
            get
            {
                return this.m_MinusLateEarly;
            }
            set
            {
                this.m_MinusLateEarly = value;
            }
        }

        [Category("Column")]
        [DisplayName("MinusMoney")]
        public decimal MinusMoney
        {
            get
            {
                return this.m_MinusMoney;
            }
            set
            {
                this.m_MinusMoney = value;
            }
        }

        [Category("Column")]
        [DisplayName("NumberDepend")]
        public int NumberDepend
        {
            get
            {
                return this.m_NumberDepend;
            }
            set
            {
                this.m_NumberDepend = value;
            }
        }

        public string ProductName
        {
            get
            {
                return "Class HRM_SALARY";
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
        [DisplayName("RemainSalary")]
        public decimal RemainSalary
        {
            get
            {
                return this.m_RemainSalary;
            }
            set
            {
                this.m_RemainSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("Salary")]
        public decimal Salary
        {
            get
            {
                return this.m_Salary;
            }
            set
            {
                this.m_Salary = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryDebt")]
        public decimal SalaryDebt
        {
            get
            {
                return this.m_SalaryDebt;
            }
            set
            {
                this.m_SalaryDebt = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryHour")]
        public decimal SalaryHour
        {
            get
            {
                return this.m_SalaryHour;
            }
            set
            {
                this.m_SalaryHour = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryMinus")]
        public decimal SalaryMinus
        {
            get
            {
                return this.m_SalaryMinus;
            }
            set
            {
                this.m_SalaryMinus = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryMinusBefore")]
        public decimal SalaryMinusBefore
        {
            get
            {
                return this.m_SalaryMinusBefore;
            }
            set
            {
                this.m_SalaryMinusBefore = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryOvertime")]
        public decimal SalaryOvertime
        {
            get
            {
                return this.m_SalaryOvertime;
            }
            set
            {
                this.m_SalaryOvertime = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryOvertime150")]
        public decimal SalaryOvertime150
        {
            get
            {
                return this.m_SalaryOvertime150;
            }
            set
            {
                this.m_SalaryOvertime150 = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryOvertime195")]
        public decimal SalaryOvertime195
        {
            get
            {
                return this.m_SalaryOvertime195;
            }
            set
            {
                this.m_SalaryOvertime195 = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryOvertime150")]
        public decimal SalaryOvertime200
        {
            get
            {
                return this.m_SalaryOvertime200;
            }
            set
            {
                this.m_SalaryOvertime200 = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryOvertime260")]
        public decimal SalaryOvertime260
        {
            get
            {
                return this.m_SalaryOvertime260;
            }
            set
            {
                this.m_SalaryOvertime260 = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryOvertime300")]
        public decimal SalaryOvertime300
        {
            get
            {
                return this.m_SalaryOvertime300;
            }
            set
            {
                this.m_SalaryOvertime300 = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryOvertime390")]
        public decimal SalaryOvertime390
        {
            get
            {
                return this.m_SalaryOvertime390;
            }
            set
            {
                this.m_SalaryOvertime390 = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryPay")]
        public decimal SalaryPay
        {
            get
            {
                return this.m_SalaryPay;
            }
            set
            {
                this.m_SalaryPay = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryPlus")]
        public decimal SalaryPlus
        {
            get
            {
                return this.m_SalaryPlus;
            }
            set
            {
                this.m_SalaryPlus = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryPlusBefore")]
        public decimal SalaryPlusBefore
        {
            get
            {
                return this.m_SalaryPlusBefore;
            }
            set
            {
                this.m_SalaryPlusBefore = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryPlusPay")]
        public decimal SalaryPlusPay
        {
            get
            {
                return this.m_SalaryPlusPay;
            }
            set
            {
                this.m_SalaryPlusPay = value;
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

        [Category("Column")]
        [DisplayName("SocialInsurance")]
        public decimal SocialInsurance
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
        [DisplayName("StipulateTime")]
        public double StipulatedTime
        {
            get
            {
                return this.m_StipulatedTime;
            }
            set
            {
                this.m_StipulatedTime = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertime150Money")]
        public decimal TaxOvertime150Money
        {
            get
            {
                return this.m_TaxOvertime150Money;
            }
            set
            {
                this.m_TaxOvertime150Money = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertime195Money")]
        public decimal TaxOvertime195Money
        {
            get
            {
                return this.m_TaxOvertime195Money;
            }
            set
            {
                this.m_TaxOvertime195Money = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertime200Money")]
        public decimal TaxOvertime200Money
        {
            get
            {
                return this.m_TaxOvertime200Money;
            }
            set
            {
                this.m_TaxOvertime200Money = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertime260Money")]
        public decimal TaxOvertime260Money
        {
            get
            {
                return this.m_TaxOvertime260Money;
            }
            set
            {
                this.m_TaxOvertime260Money = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertime300Money")]
        public decimal TaxOvertime300Money
        {
            get
            {
                return this.m_TaxOvertime300Money;
            }
            set
            {
                this.m_TaxOvertime300Money = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxOvertime390Money")]
        public decimal TaxOvertime390Money
        {
            get
            {
                return this.m_TaxOvertime390Money;
            }
            set
            {
                this.m_TaxOvertime390Money = value;
            }
        }

        [Category("Column")]
        [DisplayName("TaxYourSelfMoney")]
        public decimal TaxYourSelfMoney
        {
            get
            {
                return this.m_TaxYourSelfMoney;
            }
            set
            {
                this.m_TaxYourSelfMoney = value;
            }
        }

        [Category("Column")]
        [DisplayName("TotalSalary")]
        public decimal TotalSalary
        {
            get
            {
                return this.m_TotalSalary;
            }
            set
            {
                this.m_TotalSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnemploymentInsurance")]
        public decimal UnemploymentInsurance
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
        [DisplayName("Union")]
        public decimal Union
        {
            get
            {
                return this.m_Union;
            }
            set
            {
                this.m_Union = value;
            }
        }

        [Category("Column")]
        [DisplayName("Union1")]
        public decimal Union1
        {
            get
            {
                return this.m_Union1;
            }
            set
            {
                this.m_Union1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("WorkHour")]
        public double WorkHour
        {
            get
            {
                return this.m_WorkHour;
            }
            set
            {
                this.m_WorkHour = value;
            }
        }

        [Category("Column")]
        [DisplayName("WorkSalary")]
        public decimal WorkSalary
        {
            get
            {
                return this.m_WorkSalary;
            }
            set
            {
                this.m_WorkSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("WorkSalary1")]
        public decimal WorkSalary1
        {
            get
            {
                return this.m_WorkSalary1;
            }
            set
            {
                this.m_WorkSalary1 = value;
            }
        }

        public HRM_SALARY()
        {
            this.m_SalaryTableListID = Guid.Empty;
            this.m_EmployeeCode = "";
            this.m_MinimumSalary = new decimal(0);
            this.m_CoefficientSalary = 0;
            this.m_BasicSalary = new decimal(0);
            this.m_InsuranceSalary = new decimal(0);
            this.m_StipulatedTime = 0;
            this.m_WorkHour = 0;
            this.m_LateEarlyHour = 0;
            this.m_MinusLateEarly = new decimal(0);
            this.m_MinusMoney = new decimal(0);
            this.m_AllowanceInsurance = new decimal(0);
            this.m_Allowance = new decimal(0);
            this.m_TotalSalary = new decimal(0);
            this.m_SalaryHour = new decimal(0);
            this.m_SalaryOvertime = new decimal(0);
            this.m_SalaryOvertime150 = new decimal(0);
            this.m_SalaryOvertime200 = new decimal(0);
            this.m_SalaryOvertime300 = new decimal(0);
            this.m_SalaryOvertime195 = new decimal(0);
            this.m_SalaryOvertime260 = new decimal(0);
            this.m_SalaryOvertime390 = new decimal(0);
            this.m_Assignment = new decimal(0);
            this.m_AssignmentPay = new decimal(0);
            this.m_AssignmentDebt = new decimal(0);
            this.m_WorkSalary = new decimal(0);
            this.m_SocialInsurance = new decimal(0);
            this.m_HealthInsurance = new decimal(0);
            this.m_UnemploymentInsurance = new decimal(0);
            this.m_Insurance = new decimal(0);
            this.m_SalaryPlusBefore = new decimal(0);
            this.m_SalaryMinusBefore = new decimal(0);
            this.m_WorkSalary1 = new decimal(0);
            this.m_IncomeTax = new decimal(0);
            this.m_NumberDepend = 0;
            this.m_DependMoney = new decimal(0);
            this.m_TaxYourSelfMoney = new decimal(0);
            this.m_TaxOvertime150Money = new decimal(0);
            this.m_TaxOvertime200Money = new decimal(0);
            this.m_TaxOvertime300Money = new decimal(0);
            this.m_TaxOvertime195Money = new decimal(0);
            this.m_TaxOvertime260Money = new decimal(0);
            this.m_TaxOvertime390Money = new decimal(0);
            this.m_IncomeTaxRemain = new decimal(0);
            this.m_IncomeTaxMoney = new decimal(0);
            this.m_RemainSalary = new decimal(0);
            this.m_Advance = new decimal(0);
            this.m_Union = new decimal(0);
            this.m_Union1 = new decimal(0);
            this.m_SalaryPlus = new decimal(0);
            this.m_SalaryPlusPay = new decimal(0);
            this.m_SalaryMinus = new decimal(0);
            this.m_Salary = new decimal(0);
            this.m_SalaryPay = new decimal(0);
            this.m_SalaryDebt = new decimal(0);
        }

        public HRM_SALARY(Guid SalaryTableListID, string EmployeeCode, decimal MinimumSalary, double CoefficientSalary, decimal BasicSalary, decimal InsuranceSalary, double StipulatedTime, double WorkHour, double LateMinusHour, decimal MinusLateMinute, decimal MinusMoney, decimal AllowanceInsurance, decimal Allowance, decimal TotalSalary, decimal SalaryHour, decimal SalaryOvertime, decimal Assignment, decimal AssignmentPay, decimal AssignmentDebt, decimal WorkSalary, decimal SocialInsurance, decimal HealthInsurance, decimal UnemploymentInsurance, decimal Insurance, decimal SalaryPlusBefore, decimal SalaryMinusBefore, decimal WorkSalary1, decimal IncomeTax, int NumberDepend, decimal DependMoney, decimal TaxYourSelfMoney, decimal TaxOvertime150Money, decimal TaxOvertime200Money, decimal TaxOvertime300Money, decimal TaxOvertime195Money, decimal TaxOvertime260Money, decimal TaxOvertime390Money, decimal IncomeTaxRemain, decimal IncomeTaxMoney, decimal RemainSalary, decimal Advance, decimal Union, decimal Union1, decimal SalaryPlus, decimal SalaryPlusPay, decimal SalaryMinus, decimal Salary, decimal SalaryPay, decimal SalaryDebt)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.m_MinimumSalary = MinimumSalary;
            this.m_CoefficientSalary = CoefficientSalary;
            this.m_BasicSalary = BasicSalary;
            this.m_InsuranceSalary = InsuranceSalary;
            this.m_StipulatedTime = StipulatedTime;
            this.m_WorkHour = WorkHour;
            this.m_LateEarlyHour = LateMinusHour;
            this.m_MinusLateEarly = MinusLateMinute;
            this.m_MinusMoney = MinusMoney;
            this.m_AllowanceInsurance = AllowanceInsurance;
            this.m_Allowance = Allowance;
            this.m_TotalSalary = TotalSalary;
            this.m_SalaryHour = SalaryHour;
            this.m_SalaryOvertime = SalaryOvertime;
            this.m_Assignment = Assignment;
            this.m_AssignmentPay = AssignmentPay;
            this.m_AssignmentDebt = AssignmentDebt;
            this.m_WorkSalary = WorkSalary;
            this.m_SocialInsurance = SocialInsurance;
            this.m_HealthInsurance = HealthInsurance;
            this.m_UnemploymentInsurance = UnemploymentInsurance;
            this.m_Insurance = Insurance;
            this.m_SalaryPlusBefore = SalaryPlusBefore;
            this.m_SalaryMinusBefore = SalaryMinusBefore;
            this.m_WorkSalary1 = WorkSalary1;
            this.m_IncomeTax = IncomeTax;
            this.m_NumberDepend = NumberDepend;
            this.m_DependMoney = DependMoney;
            this.m_TaxYourSelfMoney = TaxYourSelfMoney;
            this.m_TaxOvertime150Money = TaxOvertime150Money;
            this.m_TaxOvertime200Money = TaxOvertime200Money;
            this.m_TaxOvertime300Money = TaxOvertime300Money;
            this.m_TaxOvertime195Money = TaxOvertime195Money;
            this.m_TaxOvertime260Money = TaxOvertime260Money;
            this.m_TaxOvertime390Money = TaxOvertime390Money;
            this.m_IncomeTaxRemain = IncomeTaxRemain;
            this.m_IncomeTaxMoney = IncomeTaxMoney;
            this.m_RemainSalary = RemainSalary;
            this.m_Advance = Advance;
            this.m_Union = Union;
            this.m_Union1 = Union1;
            this.m_SalaryPlus = SalaryPlus;
            this.m_SalaryPlusPay = SalaryPlusPay;
            this.m_SalaryMinus = SalaryMinus;
            this.m_Salary = Salary;
            this.m_SalaryPay = SalaryPay;
            this.m_SalaryDebt = SalaryDebt;
        }

        public static string Create(int Level, string Code, string SalaryTableListID, string SalaryTableListName, int Month, int Year)
        {
            DateTime dateTime = new DateTime(Year, Month, 1);
            DateTime dateTime1 = new DateTime(Year, Month, DateTime.DaysInMonth(Year, Month));
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            foreach (DataRow row in hRMEMPLOYEE.GetCompactList(Level, Code, 1, dateTime, dateTime1).Rows)
            {
                string[] str = new string[] { "Đang cập nhật...", row["FirstName"].ToString(), " ", row["LastName"].ToString(), " (", row["EmployeeCode"].ToString(), ")" };
                Options.SetWaitDialogCaption(string.Concat(str));
                Thread thread = new Thread(() => HRM_SALARY.Create(SalaryTableListID, SalaryTableListName, row["EmployeeCode"].ToString(), Month, Year));
                thread.Start();
                thread.Join();
            }
            Options.HideDialog();
            return "OK";
        }

        public static string Create(string SalaryTableListID, string SalaryTableListName, string EmployeeCode, int Month, int Year)
        {
            string[] strArrays = new string[] { "@SalaryTableListID", "@SalaryTableListName", "@EmployeeCode", "@Month", "@Year" };
            string[] strArrays1 = strArrays;
            object[] salaryTableListID = new object[] { SalaryTableListID, SalaryTableListName, EmployeeCode, Month, Year };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_Create", strArrays1, salaryTableListID);
        }

        public DataTable CreateChart(int Level, string Code, int Month, int Year)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@Month", "@Year" };
            object[] level = new object[] { Level, Code, Month, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_CreateChart", strArrays, level);
        }

        public static string EmployeeUpdate(string TimekeeperTableListID, string SalaryTableListID, int Month, int Year, string EmployeeCode)
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.Get(EmployeeCode);
            string[] strArrays = new string[] { "@TimekeeperTableListID", "@SalaryTableListID", "@Month", "@Year", "@EmployeeCode", "@MinimumSalary", "@CoefficientSalary", "@BasicSalary" };
            string[] strArrays1 = strArrays;
            object[] timekeeperTableListID = new object[] { TimekeeperTableListID, SalaryTableListID, Month, Year, EmployeeCode, hRMEMPLOYEE.MinimumSalary, hRMEMPLOYEE.CoefficientSalary, hRMEMPLOYEE.BasicSalary };
            return (new SqlHelper()).ExecuteNonQuery("HRM_SALARY_EmployeeUpdate", strArrays1, timekeeperTableListID);
        }

        public string Get(Guid SalaryTableListID, string EmployeeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_Get", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_SalaryTableListID = sqlDataReader.GetGuid(sqlDataReader.GetOrdinal("SalaryTableListID"));
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_CoefficientSalary = Convert.ToDouble(sqlDataReader["CoefficientSalary"]);
                    this.m_BasicSalary = Convert.ToDecimal(sqlDataReader["BasicSalary"]);
                    this.m_InsuranceSalary = Convert.ToDecimal(sqlDataReader["InsuranceSalary"]);
                    this.m_StipulatedTime = Convert.ToDouble(sqlDataReader["StipulatedTime"]);
                    this.m_WorkHour = Convert.ToDouble(sqlDataReader["WorkHour"]);
                    this.m_LateEarlyHour = Convert.ToDouble(sqlDataReader["LateEarlyHour"]);
                    this.m_MinusLateEarly = Convert.ToDecimal(sqlDataReader["MinusLateEarly"]);
                    this.m_MinusMoney = Convert.ToDecimal(sqlDataReader["MinusMoney"]);
                    this.m_AllowanceInsurance = Convert.ToDecimal(sqlDataReader["AllowanceInsurance"]);
                    this.m_Allowance = Convert.ToDecimal(sqlDataReader["Allowance"]);
                    this.m_TotalSalary = Convert.ToDecimal(sqlDataReader["TotalSalary"]);
                    this.m_SalaryHour = Convert.ToDecimal(sqlDataReader["SalaryHour"]);
                    this.m_SalaryOvertime = Convert.ToDecimal(sqlDataReader["SalaryOvertime"]);
                    this.m_SalaryOvertime = Convert.ToDecimal(sqlDataReader["SalaryOvertime150"]);
                    this.m_SalaryOvertime = Convert.ToDecimal(sqlDataReader["SalaryOvertime200"]);
                    this.m_SalaryOvertime = Convert.ToDecimal(sqlDataReader["SalaryOvertime300"]);
                    this.m_SalaryOvertime = Convert.ToDecimal(sqlDataReader["SalaryOvertime195"]);
                    this.m_SalaryOvertime = Convert.ToDecimal(sqlDataReader["SalaryOvertime260"]);
                    this.m_SalaryOvertime = Convert.ToDecimal(sqlDataReader["SalaryOvertime390"]);
                    this.m_Assignment = Convert.ToDecimal(sqlDataReader["Assignment"]);
                    this.m_AssignmentPay = Convert.ToDecimal(sqlDataReader["AssignmentPay"]);
                    this.m_AssignmentDebt = Convert.ToDecimal(sqlDataReader["AssignmentDebt"]);
                    this.m_WorkSalary = Convert.ToDecimal(sqlDataReader["WorkSalary"]);
                    this.m_SocialInsurance = Convert.ToDecimal(sqlDataReader["SocialInsurance"]);
                    this.m_HealthInsurance = Convert.ToDecimal(sqlDataReader["HealthInsurance"]);
                    this.m_UnemploymentInsurance = Convert.ToDecimal(sqlDataReader["UnemploymentInsurance"]);
                    this.m_Insurance = Convert.ToDecimal(sqlDataReader["Insurance"]);
                    this.m_SalaryPlusBefore = Convert.ToDecimal(sqlDataReader["SalaryPlusBefore"]);
                    this.m_SalaryMinusBefore = Convert.ToDecimal(sqlDataReader["SalaryMinusBefore"]);
                    this.m_WorkSalary1 = Convert.ToDecimal(sqlDataReader["WorkSalary1"]);
                    this.m_IncomeTax = Convert.ToDecimal(sqlDataReader["IncomeTax"]);
                    this.m_NumberDepend = Convert.ToInt32(sqlDataReader["NumberDepend"]);
                    this.m_DependMoney = Convert.ToDecimal(sqlDataReader["DependMoney"]);
                    this.m_TaxYourSelfMoney = Convert.ToDecimal(sqlDataReader["TaxYourSelfMoney"]);
                    this.m_TaxOvertime150Money = Convert.ToDecimal(sqlDataReader["TaxOvertime150Money"]);
                    this.m_TaxOvertime200Money = Convert.ToDecimal(sqlDataReader["TaxOvertime200Money"]);
                    this.m_TaxOvertime300Money = Convert.ToDecimal(sqlDataReader["TaxOvertime300Money"]);
                    this.m_TaxOvertime195Money = Convert.ToDecimal(sqlDataReader["TaxOvertime195Money"]);
                    this.m_TaxOvertime260Money = Convert.ToDecimal(sqlDataReader["TaxOvertime260Money"]);
                    this.m_TaxOvertime390Money = Convert.ToDecimal(sqlDataReader["TaxOvertime390Money"]);
                    this.m_IncomeTaxRemain = Convert.ToDecimal(sqlDataReader["IncomeTaxRemain"]);
                    this.m_IncomeTaxMoney = Convert.ToDecimal(sqlDataReader["IncomeTaxMoney"]);
                    this.m_RemainSalary = Convert.ToDecimal(sqlDataReader["RemainSalary"]);
                    this.m_Advance = Convert.ToDecimal(sqlDataReader["Advance"]);
                    this.m_Union = Convert.ToDecimal(sqlDataReader["Union"]);
                    this.m_Union1 = Convert.ToDecimal(sqlDataReader["Union1"]);
                    this.m_SalaryPlus = Convert.ToDecimal(sqlDataReader["SalaryPlus"]);
                    this.m_SalaryPlusPay = (sqlDataReader["SalaryPlusPay"] == DBNull.Value ? new decimal(0) : Convert.ToDecimal(sqlDataReader["SalaryPlusPay"]));
                    this.m_SalaryMinus = Convert.ToDecimal(sqlDataReader["SalaryMinus"]);
                    this.m_Salary = Convert.ToDecimal(sqlDataReader["Salary"]);
                    this.m_SalaryPay = Convert.ToDecimal(sqlDataReader["SalaryPay"]);
                    this.m_SalaryDebt = Convert.ToDecimal(sqlDataReader["SalaryDebt"]);
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
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_GetList", strArrays, level);
        }

        public DataTable GetListInsurance(int Level, string Code, int Month, int Year)
        {
            string[] strArrays = new string[] { "Level", "Code", "@Month", "@Year" };
            object[] level = new object[] { Level, Code, Month, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_GetListInsurance", strArrays, level);
        }

        public DataTable GetSalaryByYear(string EmployeeCode, int Year)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@Year" };
            object[] employeeCode = new object[] { EmployeeCode, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_SALARY_GetSalaryByYear", strArrays, employeeCode);
        }

        public decimal GetTotalAdvance(Guid SalaryTableListID, string EmployeeCode)
        {
            decimal num = new decimal(0);
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_TotalAdvance", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToDecimal(sqlDataReader["TotalAdvance"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public decimal GetTotalAllowance(Guid SalaryTableListID, string EmployeeCode)
        {
            decimal num = new decimal(0);
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_TotalAllowance", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToDecimal(sqlDataReader["TotalAllowance"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public decimal GetTotalAllowance(Guid SalaryTableListID, string EmployeeCode, string AllowanceCode, bool IsTaxAllowance)
        {
            decimal num = new decimal(0);
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@AllowanceCode", "@IsTaxAllowance" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, AllowanceCode, IsTaxAllowance };
            object[] objArray = salaryTableListID;
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_TotalAllowanceByCode", strArrays, objArray);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToDecimal(sqlDataReader["TotalAllowance"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public decimal GetTotalAssignment(Guid SalaryTableListID, string EmployeeCode)
        {
            decimal num = new decimal(0);
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_TotalAssignment", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToDecimal(sqlDataReader["TotalAssignment"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public decimal GetTotalIncome(Guid SalaryTableListID, string EmployeeCode, string IncomeCode)
        {
            decimal num = new decimal(0);
            string[] strArrays = new string[] { "@SalaryTableListID", "@EmployeeCode", "@IncomeCode" };
            object[] salaryTableListID = new object[] { SalaryTableListID, EmployeeCode, IncomeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_TotalIncomeByCode", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToDecimal(sqlDataReader["TotalIncome"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

        public decimal GetTotalSalary(Guid SalaryTableListID)
        {
            decimal num = new decimal(0);
            string[] strArrays = new string[] { "@SalaryTableListID" };
            object[] salaryTableListID = new object[] { SalaryTableListID };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_SALARY_TotalSalary", strArrays, salaryTableListID);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    num = Convert.ToDecimal(sqlDataReader["TotalSalary"]);
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return num;
        }

    }
}
