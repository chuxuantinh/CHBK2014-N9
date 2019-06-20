using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Data.Helper;
using CHBK2014_N9.HumanResource.Core.Class;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CHBK2014_N9.ERP
{
  public  class HRM_EMPLOYEE
    {



        private string m_EmployeeCode;

        private string m_SubsidiaryCode;

        private string m_SubsidiaryName;

        private string m_BranchCode;

        private string m_BranchName;

        private string m_DepartmentCode;

        private string m_DepartmentName;

        private string m_GroupCode;

        private string m_GroupName;

        private string m_CandidateCode;

        private string m_EnrollNumber;

        private string m_FirstName;

        private string m_LastName;

        private string m_Alias;

        private bool m_Sex;

        private string m_Marriage;

        private int m_BirthdayDay;

        private int m_BirthdayMonth;

        private int m_BirthdayYear;

        private string m_BirthPlace;

        private string m_MainAddress;

        private string m_ContactAddress;

        private string m_CellPhone;

        private string m_HomePhone;

        private string m_Email;

        private string m_Skype;

        private string m_Yahoo;

        private string m_Facebook;

        private Image m_Photo;

        private string m_Nationality;

        private string m_Ethnic;

        private string m_Religion;

        private string m_Education;

        private string m_Language;

        private string m_Informatic;

        private string m_Professional;

        private string m_Position;

        private string m_GroupRateCode;

        private string m_School;

        private string m_IDCard;

        private DateTime m_IDCardDate;

        private string m_IDCardPlace;

        private bool m_IsTest;

        private string m_TestTime;

        private DateTime m_TestFromDate;

        private DateTime m_TestToDate;

        private decimal m_TestSalary;

        private DateTime m_BeginDate;

        private bool m_IsOffWork;

        private DateTime m_EndDate;

        private string m_Health;

        private double m_Height;

        private double m_Weight;

        private int m_PayForm;

        private decimal m_PayMoney;

        private decimal m_MinimumSalary;

        private string m_RankSalary;

        private int m_StepSalary;

        private double m_CoefficientSalary;

        private DateTime m_DateSalary;

        private decimal m_BasicSalary;

        private decimal m_SalaryPeriod1;

        private decimal m_InsuranceSalary;

        private bool m_IsFixedSalary;

        private decimal m_Allowance1;

        private decimal m_Allowance2;

        private decimal m_Allowance3;

        private decimal m_Allowance4;

        private bool m_IsSocialInsurance;

        private bool m_IsHealthInsurance;

        private bool m_IsUnemploymentInsurance;

        private bool m_IsUnionMoney;

        private string m_IncomeTaxCode;

        private bool m_IsMandateTax;

        private bool m_IsYourSelfTax;

        private bool m_IsSecondIncomeTax;

        private double m_PercentSecondIncomeTax;

        private int m_ResidenceType;

        private string m_BankCode;

        private DateTime m_BankDate;

        private string m_BankName;

        private string m_BankBranch;

        private string m_BankCity;

        private string m_BankAddress;

        private string m_LaborCode;

        private DateTime m_LaborDate;

        private string m_LaborPlace;

        private bool m_IsUnion;

        private string m_UnionCode;

        private DateTime m_UnionDate;

        private string m_UnionPlace;

        private bool m_IsParty;

        private string m_PartyCode;

        private DateTime m_PartyDate;

        private string m_PartyPlace;

        private string m_InsuranceCode;

        private DateTime m_InsuranceDate;

        private string m_InsurancePlace;

        private string m_HealthInsuranceCode;

        private DateTime m_HealthInsuranceFromDate;

        private DateTime m_HealthInsuranceToDate;

        private string m_ContractCode;

        private string m_ContractType;

        private DateTime m_ContractSignDate;

        private DateTime m_ContractFromDate;

        private DateTime m_ContractToDate;

        private string m_Province;

        private string m_Hospital;

        private string m_MilitaryCode;

        private DateTime m_MilitaryFromDate;

        private DateTime m_MilitaryToDate;

        private string m_MilitaryPosition;

        private string m_PassportCode;

        private DateTime m_PassportFromDate;

        private DateTime m_PassportToDate;

        private string m_ReasonLeave;

        private int m_Status;

        private string m_Description;

        [Category("Column")]
        [DisplayName("Alias")]
        public string Alias
        {
            get
            {
                return this.m_Alias;
            }
            set
            {
                this.m_Alias = value;
            }
        }

        [Category("Column")]
        [DisplayName("Allowance1")]
        public decimal Allowance1
        {
            get
            {
                return this.m_Allowance1;
            }
            set
            {
                this.m_Allowance1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("Allowance2")]
        public decimal Allowance2
        {
            get
            {
                return this.m_Allowance2;
            }
            set
            {
                this.m_Allowance2 = value;
            }
        }

        [Category("Column")]
        [DisplayName("Allowance3")]
        public decimal Allowance3
        {
            get
            {
                return this.m_Allowance3;
            }
            set
            {
                this.m_Allowance3 = value;
            }
        }

        [Category("Column")]
        [DisplayName("Allowance4")]
        public decimal Allowance4
        {
            get
            {
                return this.m_Allowance4;
            }
            set
            {
                this.m_Allowance4 = value;
            }
        }

        [Category("Column")]
        [DisplayName("BankAddress")]
        public string BankAddress
        {
            get
            {
                return this.m_BankAddress;
            }
            set
            {
                this.m_BankAddress = value;
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
        [DisplayName("BankCity")]
        public string BankCity
        {
            get
            {
                return this.m_BankCity;
            }
            set
            {
                this.m_BankCity = value;
            }
        }

        [Category("Column")]
        [DisplayName("BankCode")]
        public string BankCode
        {
            get
            {
                return this.m_BankCode;
            }
            set
            {
                this.m_BankCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("BankDate")]
        public DateTime BankDate
        {
            get
            {
                return this.m_BankDate;
            }
            set
            {
                this.m_BankDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("BankName")]
        public string BankName
        {
            get
            {
                return this.m_BankName;
            }
            set
            {
                this.m_BankName = value;
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
        [DisplayName("BeginDate")]
        public DateTime BeginDate
        {
            get
            {
                return this.m_BeginDate;
            }
            set
            {
                this.m_BeginDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("BirthdayDay")]
        public int BirthdayDay
        {
            get
            {
                return this.m_BirthdayDay;
            }
            set
            {
                this.m_BirthdayDay = value;
            }
        }

        [Category("Column")]
        [DisplayName("BirthdayMonth")]
        public int BirthdayMonth
        {
            get
            {
                return this.m_BirthdayMonth;
            }
            set
            {
                this.m_BirthdayMonth = value;
            }
        }

        [Category("Column")]
        [DisplayName("BirthdayYear")]
        public int BirthdayYear
        {
            get
            {
                return this.m_BirthdayYear;
            }
            set
            {
                this.m_BirthdayYear = value;
            }
        }

        [Category("Column")]
        [DisplayName("BirthPlace")]
        public string BirthPlace
        {
            get
            {
                return this.m_BirthPlace;
            }
            set
            {
                this.m_BirthPlace = value;
            }
        }

        [Category("Column")]
        [DisplayName("BranchCode")]
        public string BranchCode
        {
            get
            {
                return this.m_BranchCode;
            }
            set
            {
                this.m_BranchCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("BranchName")]
        public string BranchName
        {
            get
            {
                return this.m_BranchName;
            }
            set
            {
                this.m_BranchName = value;
            }
        }

        [Category("Column")]
        [DisplayName("CandidateCode")]
        public string CandidateCode
        {
            get
            {
                return this.m_CandidateCode;
            }
            set
            {
                this.m_CandidateCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("CellPhone")]
        public string CellPhone
        {
            get
            {
                return this.m_CellPhone;
            }
            set
            {
                this.m_CellPhone = value;
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
        [DisplayName("ContactAddress")]
        public string ContactAddress
        {
            get
            {
                return this.m_ContactAddress;
            }
            set
            {
                this.m_ContactAddress = value;
            }
        }

        [Category("Column")]
        [DisplayName("ContractCode")]
        public string ContractCode
        {
            get
            {
                return this.m_ContractCode;
            }
            set
            {
                this.m_ContractCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("ContractFromDate")]
        public DateTime ContractFromDate
        {
            get
            {
                return this.m_ContractFromDate;
            }
            set
            {
                this.m_ContractFromDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("ContractSignDate")]
        public DateTime ContractSignDate
        {
            get
            {
                return this.m_ContractSignDate;
            }
            set
            {
                this.m_ContractSignDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("ContractToDate")]
        public DateTime ContractToDate
        {
            get
            {
                return this.m_ContractToDate;
            }
            set
            {
                this.m_ContractToDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("ContractType")]
        public string ContractType
        {
            get
            {
                return this.m_ContractType;
            }
            set
            {
                this.m_ContractType = value;
            }
        }

        [Category("Column")]
        [DisplayName("DateSalary")]
        public DateTime DateSalary
        {
            get
            {
                return this.m_DateSalary;
            }
            set
            {
                this.m_DateSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("DepartmentCode")]
        public string DepartmentCode
        {
            get
            {
                return this.m_DepartmentCode;
            }
            set
            {
                this.m_DepartmentCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("DepartmentName")]
        public string DepartmentName
        {
            get
            {
                return this.m_DepartmentName;
            }
            set
            {
                this.m_DepartmentName = value;
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
        [DisplayName("Education")]
        public string Education
        {
            get
            {
                return this.m_Education;
            }
            set
            {
                this.m_Education = value;
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
        [DisplayName("EndDate")]
        public DateTime EndDate
        {
            get
            {
                return this.m_EndDate;
            }
            set
            {
                this.m_EndDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("EnrollNumber")]
        public string EnrollNumber
        {
            get
            {
                return this.m_EnrollNumber;
            }
            set
            {
                this.m_EnrollNumber = value;
            }
        }

        [Category("Column")]
        [DisplayName("Ethnic")]
        public string Ethnic
        {
            get
            {
                return this.m_Ethnic;
            }
            set
            {
                this.m_Ethnic = value;
            }
        }

        [Category("Column")]
        [DisplayName("Facebook")]
        public string Facebook
        {
            get
            {
                return this.m_Facebook;
            }
            set
            {
                this.m_Facebook = value;
            }
        }

        [Category("Column")]
        [DisplayName("FirstName")]
        public string FirstName
        {
            get
            {
                return this.m_FirstName;
            }
            set
            {
                this.m_FirstName = value;
            }
        }

        [Category("Column")]
        [DisplayName("GroupCode")]
        public string GroupCode
        {
            get
            {
                return this.m_GroupCode;
            }
            set
            {
                this.m_GroupCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("GroupName")]
        public string GroupName
        {
            get
            {
                return this.m_GroupName;
            }
            set
            {
                this.m_GroupName = value;
            }
        }

        [Category("Column")]
        [DisplayName("GroupRateCode")]
        public string GroupRateCode
        {
            get
            {
                return this.m_GroupRateCode;
            }
            set
            {
                this.m_GroupRateCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("Health")]
        public string Health
        {
            get
            {
                return this.m_Health;
            }
            set
            {
                this.m_Health = value;
            }
        }

        [Category("Column")]
        [DisplayName("HealthInsuranceCode")]
        public string HealthInsuranceCode
        {
            get
            {
                return this.m_HealthInsuranceCode;
            }
            set
            {
                this.m_HealthInsuranceCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("HealthInsuranceFromDate")]
        public DateTime HealthInsuranceFromDate
        {
            get
            {
                return this.m_HealthInsuranceFromDate;
            }
            set
            {
                this.m_HealthInsuranceFromDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("HealthInsuranceToDate")]
        public DateTime HealthInsuranceToDate
        {
            get
            {
                return this.m_HealthInsuranceToDate;
            }
            set
            {
                this.m_HealthInsuranceToDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("Height")]
        public double Height
        {
            get
            {
                return this.m_Height;
            }
            set
            {
                this.m_Height = value;
            }
        }

        [Category("Column")]
        [DisplayName("HomePhone")]
        public string HomePhone
        {
            get
            {
                return this.m_HomePhone;
            }
            set
            {
                this.m_HomePhone = value;
            }
        }

        [Category("Column")]
        [DisplayName("Hospital")]
        public string Hospital
        {
            get
            {
                return this.m_Hospital;
            }
            set
            {
                this.m_Hospital = value;
            }
        }

        [Category("Column")]
        [DisplayName("IDCard")]
        public string IDCard
        {
            get
            {
                return this.m_IDCard;
            }
            set
            {
                this.m_IDCard = value;
            }
        }

        [Category("Column")]
        [DisplayName("IDCardDate")]
        public DateTime IDCardDate
        {
            get
            {
                return this.m_IDCardDate;
            }
            set
            {
                this.m_IDCardDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("IDCardPlace")]
        public string IDCardPlace
        {
            get
            {
                return this.m_IDCardPlace;
            }
            set
            {
                this.m_IDCardPlace = value;
            }
        }

        [Category("Column")]
        [DisplayName("IncomeTaxCode")]
        public string IncomeTaxCode
        {
            get
            {
                return this.m_IncomeTaxCode;
            }
            set
            {
                this.m_IncomeTaxCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("Informatic")]
        public string Informatic
        {
            get
            {
                return this.m_Informatic;
            }
            set
            {
                this.m_Informatic = value;
            }
        }

        [Category("Column")]
        [DisplayName("InsuranceCode")]
        public string InsuranceCode
        {
            get
            {
                return this.m_InsuranceCode;
            }
            set
            {
                this.m_InsuranceCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("InsuranceDate")]
        public DateTime InsuranceDate
        {
            get
            {
                return this.m_InsuranceDate;
            }
            set
            {
                this.m_InsuranceDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("InsurancePlace")]
        public string InsurancePlace
        {
            get
            {
                return this.m_InsurancePlace;
            }
            set
            {
                this.m_InsurancePlace = value;
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
        [DisplayName("IsFixedSalary")]
        public bool IsFixedSalary
        {
            get
            {
                return this.m_IsFixedSalary;
            }
            set
            {
                this.m_IsFixedSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsHealthInsurance")]
        public bool IsHealthInsurance
        {
            get
            {
                return this.m_IsHealthInsurance;
            }
            set
            {
                this.m_IsHealthInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsMandateTax")]
        public bool IsMandateTax
        {
            get
            {
                return this.m_IsMandateTax;
            }
            set
            {
                this.m_IsMandateTax = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsOffWork")]
        public bool IsOffWork
        {
            get
            {
                return this.m_IsOffWork;
            }
            set
            {
                this.m_IsOffWork = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsParty")]
        public bool IsParty
        {
            get
            {
                return this.m_IsParty;
            }
            set
            {
                this.m_IsParty = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsSecondIncomeTax")]
        public bool IsSecondIncomeTax
        {
            get
            {
                return this.m_IsSecondIncomeTax;
            }
            set
            {
                this.m_IsSecondIncomeTax = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsSocialInsurance")]
        public bool IsSocialInsurance
        {
            get
            {
                return this.m_IsSocialInsurance;
            }
            set
            {
                this.m_IsSocialInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsTest")]
        public bool IsTest
        {
            get
            {
                return this.m_IsTest;
            }
            set
            {
                this.m_IsTest = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsUnemploymentInsurance")]
        public bool IsUnemploymentInsurance
        {
            get
            {
                return this.m_IsUnemploymentInsurance;
            }
            set
            {
                this.m_IsUnemploymentInsurance = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsUnion")]
        public bool IsUnion
        {
            get
            {
                return this.m_IsUnion;
            }
            set
            {
                this.m_IsUnion = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsUnionMoney")]
        public bool IsUnionMoney
        {
            get
            {
                return this.m_IsUnionMoney;
            }
            set
            {
                this.m_IsUnionMoney = value;
            }
        }

        [Category("Column")]
        [DisplayName("IsYourSelfTax")]
        public bool IsYourSelfTax
        {
            get
            {
                return this.m_IsYourSelfTax;
            }
            set
            {
                this.m_IsYourSelfTax = value;
            }
        }

        [Category("Column")]
        [DisplayName("LaborCode")]
        public string LaborCode
        {
            get
            {
                return this.m_LaborCode;
            }
            set
            {
                this.m_LaborCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("LaborDate")]
        public DateTime LaborDate
        {
            get
            {
                return this.m_LaborDate;
            }
            set
            {
                this.m_LaborDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("LaborPlace")]
        public string LaborPlace
        {
            get
            {
                return this.m_LaborPlace;
            }
            set
            {
                this.m_LaborPlace = value;
            }
        }

        [Category("Column")]
        [DisplayName("Language")]
        public string Language
        {
            get
            {
                return this.m_Language;
            }
            set
            {
                this.m_Language = value;
            }
        }

        [Category("Column")]
        [DisplayName("LastName")]
        public string LastName
        {
            get
            {
                return this.m_LastName;
            }
            set
            {
                this.m_LastName = value;
            }
        }

        [Category("Column")]
        [DisplayName("MainAddress")]
        public string MainAddress
        {
            get
            {
                return this.m_MainAddress;
            }
            set
            {
                this.m_MainAddress = value;
            }
        }

        [Category("Column")]
        [DisplayName("Marriage")]
        public string Marriage
        {
            get
            {
                return this.m_Marriage;
            }
            set
            {
                this.m_Marriage = value;
            }
        }

        [Category("Column")]
        [DisplayName("MilitaryCode")]
        public string MilitaryCode
        {
            get
            {
                return this.m_MilitaryCode;
            }
            set
            {
                this.m_MilitaryCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("MilitaryFromDate")]
        public DateTime MilitaryFromDate
        {
            get
            {
                return this.m_MilitaryFromDate;
            }
            set
            {
                this.m_MilitaryFromDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("MilitaryPosition")]
        public string MilitaryPosition
        {
            get
            {
                return this.m_MilitaryPosition;
            }
            set
            {
                this.m_MilitaryPosition = value;
            }
        }

        [Category("Column")]
        [DisplayName("MilitaryToDate")]
        public DateTime MilitaryToDate
        {
            get
            {
                return this.m_MilitaryToDate;
            }
            set
            {
                this.m_MilitaryToDate = value;
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
        [DisplayName("Nationality")]
        public string Nationality
        {
            get
            {
                return this.m_Nationality;
            }
            set
            {
                this.m_Nationality = value;
            }
        }

        [Category("Column")]
        [DisplayName("PartyCode")]
        public string PartyCode
        {
            get
            {
                return this.m_PartyCode;
            }
            set
            {
                this.m_PartyCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("PartyDate")]
        public DateTime PartyDate
        {
            get
            {
                return this.m_PartyDate;
            }
            set
            {
                this.m_PartyDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("PartyPlace")]
        public string PartyPlace
        {
            get
            {
                return this.m_PartyPlace;
            }
            set
            {
                this.m_PartyPlace = value;
            }
        }

        [Category("Column")]
        [DisplayName("PassportCode")]
        public string PassportCode
        {
            get
            {
                return this.m_PassportCode;
            }
            set
            {
                this.m_PassportCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("PassportFromDate")]
        public DateTime PassportFromDate
        {
            get
            {
                return this.m_PassportFromDate;
            }
            set
            {
                this.m_PassportFromDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("PassportToDate")]
        public DateTime PassportToDate
        {
            get
            {
                return this.m_PassportToDate;
            }
            set
            {
                this.m_PassportToDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("PayForm")]
        public int PayForm
        {
            get
            {
                return this.m_PayForm;
            }
            set
            {
                this.m_PayForm = value;
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
        [DisplayName("PercentSecondIncomeTax")]
        public double PercentSecondIncomeTax
        {
            get
            {
                return this.m_PercentSecondIncomeTax;
            }
            set
            {
                this.m_PercentSecondIncomeTax = value;
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
        [DisplayName("Position")]
        public string Position
        {
            get
            {
                return this.m_Position;
            }
            set
            {
                this.m_Position = value;
            }
        }

        [Category("Column")]
        [DisplayName("Professional")]
        public string Professional
        {
            get
            {
                return this.m_Professional;
            }
            set
            {
                this.m_Professional = value;
            }
        }

        [Category("Column")]
        [DisplayName("Province")]
        public string Province
        {
            get
            {
                return this.m_Province;
            }
            set
            {
                this.m_Province = value;
            }
        }

        [Category("Column")]
        [DisplayName("RankSalary")]
        public string RankSalary
        {
            get
            {
                return this.m_RankSalary;
            }
            set
            {
                this.m_RankSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("ReasonLeave")]
        public string ReasonLeave
        {
            get
            {
                return this.m_ReasonLeave;
            }
            set
            {
                this.m_ReasonLeave = value;
            }
        }

        [Category("Column")]
        [DisplayName("Religion")]
        public string Religion
        {
            get
            {
                return this.m_Religion;
            }
            set
            {
                this.m_Religion = value;
            }
        }

        [Category("Column")]
        [DisplayName("ResidenceType")]
        public int ResidenceType
        {
            get
            {
                return this.m_ResidenceType;
            }
            set
            {
                this.m_ResidenceType = value;
            }
        }

        [Category("Column")]
        [DisplayName("SalaryPeriod1")]
        public decimal SalaryPeriod1
        {
            get
            {
                return this.m_SalaryPeriod1;
            }
            set
            {
                this.m_SalaryPeriod1 = value;
            }
        }

        [Category("Column")]
        [DisplayName("School")]
        public string School
        {
            get
            {
                return this.m_School;
            }
            set
            {
                this.m_School = value;
            }
        }

        [Category("Column")]
        [DisplayName("Sex")]
        public bool Sex
        {
            get
            {
                return this.m_Sex;
            }
            set
            {
                this.m_Sex = value;
            }
        }

        [Category("Column")]
        [DisplayName("Skype")]
        public string Skype
        {
            get
            {
                return this.m_Skype;
            }
            set
            {
                this.m_Skype = value;
            }
        }

        [Category("Column")]
        [DisplayName("Status")]
        public int Status
        {
            get
            {
                return this.m_Status;
            }
            set
            {
                this.m_Status = value;
            }
        }

        [Category("Column")]
        [DisplayName("StepSalary")]
        public int StepSalary
        {
            get
            {
                return this.m_StepSalary;
            }
            set
            {
                this.m_StepSalary = value;
            }
        }

        [Category("Column")]
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
        [DisplayName("TestFromDate")]
        public DateTime TestFromDate
        {
            get
            {
                return this.m_TestFromDate;
            }
            set
            {
                this.m_TestFromDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("TestSalary")]
        public decimal TestSalary
        {
            get
            {
                return this.m_TestSalary;
            }
            set
            {
                this.m_TestSalary = value;
            }
        }

        [Category("Column")]
        [DisplayName("TestTime")]
        public string TestTime
        {
            get
            {
                return this.m_TestTime;
            }
            set
            {
                this.m_TestTime = value;
            }
        }

        [Category("Column")]
        [DisplayName("TestToDate")]
        public DateTime TestToDate
        {
            get
            {
                return this.m_TestToDate;
            }
            set
            {
                this.m_TestToDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnionCode")]
        public string UnionCode
        {
            get
            {
                return this.m_UnionCode;
            }
            set
            {
                this.m_UnionCode = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnionDate")]
        public DateTime UnionDate
        {
            get
            {
                return this.m_UnionDate;
            }
            set
            {
                this.m_UnionDate = value;
            }
        }

        [Category("Column")]
        [DisplayName("UnionPlace")]
        public string UnionPlace
        {
            get
            {
                return this.m_UnionPlace;
            }
            set
            {
                this.m_UnionPlace = value;
            }
        }

        [Category("Column")]
        [DisplayName("Weight")]
        public double Weight
        {
            get
            {
                return this.m_Weight;
            }
            set
            {
                this.m_Weight = value;
            }
        }

        [Category("Column")]
        [DisplayName("Yahoo")]
        public string Yahoo
        {
            get
            {
                return this.m_Yahoo;
            }
            set
            {
                this.m_Yahoo = value;
            }
        }

        public HRM_EMPLOYEE()
        {
            this.m_EmployeeCode = "";
            this.m_SubsidiaryCode = "";
            this.m_SubsidiaryName = "";
            this.m_BranchCode = "";
            this.m_BranchName = "";
            this.m_DepartmentCode = "";
            this.m_DepartmentName = "";
            this.m_GroupCode = "";
            this.m_GroupName = "";
            this.m_CandidateCode = "";
            this.m_EnrollNumber = "";
            this.m_FirstName = "";
            this.m_LastName = "";
            this.m_Alias = "";
            this.m_Sex = true;
            this.m_Marriage = "";
            this.m_BirthdayDay = DateTime.Now.Day;
            this.m_BirthdayMonth = DateTime.Now.Month;
            this.m_BirthdayYear = DateTime.Now.Year;
            this.m_BirthPlace = "";
            this.m_MainAddress = "";
            this.m_ContactAddress = "";
            this.m_CellPhone = "";
            this.m_HomePhone = "";
            this.m_Email = "";
            this.m_Skype = "";
            this.m_Yahoo = "";
            this.m_Facebook = "";
            this.m_Nationality = "";
            this.m_Ethnic = "";
            this.m_Religion = "";
            this.m_Education = "";
            this.m_Language = "";
            this.m_Informatic = "";
            this.m_Professional = "";
            this.m_Position = "";
            this.m_GroupRateCode = "";
            this.m_School = "";
            this.m_IDCard = "";
            this.m_IDCardDate = DateTime.Now;
            this.m_IDCardPlace = "";
            this.m_IsTest = true;
            this.m_TestTime = "";
            this.m_TestFromDate = DateTime.Now;
            this.m_TestToDate = DateTime.Now;
            this.m_TestSalary = new decimal(0);
            this.m_BeginDate = DateTime.Now;
            this.m_IsOffWork = true;
            this.m_EndDate = DateTime.Now;
            this.m_Health = "";
            this.m_Height = 0;
            this.m_Weight = 0;
            this.m_PayForm = 0;
            this.m_PayMoney = new decimal(0);
            this.m_MinimumSalary = new decimal(0);
            this.m_RankSalary = "";
            this.m_StepSalary = 0;
            this.m_CoefficientSalary = 0;
            this.m_DateSalary = DateTime.Now;
            this.m_BasicSalary = new decimal(0);
            this.m_SalaryPeriod1 = new decimal(0);
            this.m_InsuranceSalary = new decimal(0);
            this.m_IsFixedSalary = false;
            this.m_Allowance1 = new decimal(0);
            this.m_Allowance2 = new decimal(0);
            this.m_Allowance3 = new decimal(0);
            this.m_Allowance4 = new decimal(0);
            this.m_IsSocialInsurance = true;
            this.m_IsHealthInsurance = true;
            this.m_IsUnemploymentInsurance = true;
            this.m_IsUnionMoney = true;
            this.m_IncomeTaxCode = "";
            this.m_IsMandateTax = true;
            this.m_IsYourSelfTax = true;
            this.m_IsSecondIncomeTax = false;
            this.m_PercentSecondIncomeTax = 0;
            this.m_ResidenceType = 0;
            this.m_BankCode = "";
            this.m_BankDate = DateTime.Now;
            this.m_BankName = "";
            this.m_BankBranch = "";
            this.m_BankCity = "";
            this.m_BankAddress = "";
            this.m_LaborCode = "";
            this.m_LaborDate = DateTime.Now;
            this.m_LaborPlace = "";
            this.m_IsUnion = true;
            this.m_UnionCode = "";
            this.m_UnionDate = DateTime.Now;
            this.m_UnionPlace = "";
            this.m_IsParty = true;
            this.m_PartyCode = "";
            this.m_PartyDate = DateTime.Now;
            this.m_PartyPlace = "";
            this.m_InsuranceCode = "";
            this.m_InsuranceDate = DateTime.Now;
            this.m_InsurancePlace = "";
            this.m_HealthInsuranceCode = "";
            this.m_HealthInsuranceFromDate = DateTime.Now;
            this.m_HealthInsuranceToDate = DateTime.Now;
            this.m_ContractCode = "";
            this.m_ContractType = "";
            this.m_ContractSignDate = DateTime.Now;
            this.m_ContractFromDate = DateTime.Now;
            this.m_ContractToDate = DateTime.Now;
            this.m_Province = "";
            this.m_Hospital = "";
            this.m_MilitaryCode = "";
            this.m_MilitaryFromDate = DateTime.Now;
            this.m_MilitaryToDate = DateTime.Now;
            this.m_MilitaryPosition = "";
            this.m_PassportCode = "";
            this.m_PassportFromDate = DateTime.Now;
            this.m_PassportToDate = DateTime.Now;
            this.m_ReasonLeave = "";
            this.m_Status = 0;
            this.m_Description = "";
        }

        public HRM_EMPLOYEE(string EmployeeCode, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string CandidateCode, string EnrollNumber, string FirstName, string LastName, string Alias, bool Sex, string Marriage, int BirthdayDay, int BirthdayMonth, int BirthdayYear, string BirthPlace, string MainAddress, string ContactAddress, string CellPhone, string HomePhone, string Email, string Skype, string Yahoo, string Facebook, string Nationality, string Ethnic, string Religion, string Education, string Language, string Informatic, string Professional, string Position, string GroupRateCode, string School, string IDCard, DateTime IDCardDate, string IDCardPlace, bool IsTest, string TestTime, DateTime TestFromDate, DateTime TestToDate, decimal TestSalary, DateTime BeginDate, bool IsOffWork, DateTime EndDate, string Health, double Height, double Weight, int PayForm, decimal PayMoney, decimal MinimumSalary, string RankSalary, int StepSalary, double CoefficientSalary, DateTime DateSalary, decimal BasicSalary, decimal SalaryPeriod1, decimal InsuranceSalary, bool IsFixedSalary, decimal Allowance1, decimal Allowance2, decimal Allowance3, decimal Allowance4, bool IsSocialInsurance, bool IsHealthInsurance, bool IsUnemploymentInsurance, bool IsUnionMoney, string IncomeTaxCode, bool IsMandateTax, bool IsYourSelfTax, bool IsSecondIncomeTax, double PercentSecondIncomeTax, int ResidenceType, string BankCode, DateTime BankDate, string BankName, string BankBranch, string BankCity, string BankAddress, string LaborCode, DateTime LaborDate, string LaborPlace, bool IsUnion, string UnionCode, DateTime UnionDate, string UnionPlace, bool IsParty, string PartyCode, DateTime PartyDate, string PartyPlace, string InsuranceCode, DateTime InsuranceDate, string InsurancePlace, string HealthInsuranceCode, DateTime HealthInsuranceFromDate, DateTime HealthInsuranceToDate, string ContractCode, string ContractType, DateTime ContractSignDate, DateTime ContractFromDate, DateTime ContractToDate, string Province, string Hospital, string MilitaryCode, DateTime MilitaryFromDate, DateTime MilitaryToDate, string MilitaryPosition, string PassportCode, DateTime PassportFromDate, DateTime PassportToDate, string ReasonLeave, int Status, string Description)
        {
            this.m_EmployeeCode = EmployeeCode;
            this.m_SubsidiaryCode = SubsidiaryCode;
            this.m_BranchCode = BranchCode;
            this.m_DepartmentCode = DepartmentCode;
            this.m_GroupCode = GroupCode;
            this.m_CandidateCode = CandidateCode;
            this.m_EnrollNumber = EnrollNumber;
            this.m_FirstName = FirstName;
            this.m_LastName = LastName;
            this.m_Alias = Alias;
            this.m_Sex = Sex;
            this.m_Marriage = Marriage;
            this.m_BirthdayDay = BirthdayDay;
            this.m_BirthdayMonth = BirthdayMonth;
            this.m_BirthdayYear = BirthdayYear;
            this.m_BirthPlace = BirthPlace;
            this.m_MainAddress = MainAddress;
            this.m_ContactAddress = ContactAddress;
            this.m_CellPhone = CellPhone;
            this.m_HomePhone = HomePhone;
            this.m_Email = Email;
            this.m_Skype = Skype;
            this.m_Yahoo = Yahoo;
            this.m_Facebook = Facebook;
            this.m_Nationality = Nationality;
            this.m_Ethnic = Ethnic;
            this.m_Religion = Religion;
            this.m_Education = Education;
            this.m_Language = Language;
            this.m_Informatic = Informatic;
            this.m_Professional = Professional;
            this.m_Position = Position;
            this.m_GroupRateCode = GroupRateCode;
            this.m_School = School;
            this.m_IDCard = IDCard;
            this.m_IDCardDate = IDCardDate;
            this.m_IDCardPlace = IDCardPlace;
            this.m_IsTest = IsTest;
            this.m_TestTime = TestTime;
            this.m_TestFromDate = TestFromDate;
            this.m_TestToDate = TestToDate;
            this.m_TestSalary = TestSalary;
            this.m_BeginDate = BeginDate;
            this.m_IsOffWork = IsOffWork;
            this.m_EndDate = EndDate;
            this.m_Health = Health;
            this.m_Height = Height;
            this.m_Weight = Weight;
            this.m_PayForm = PayForm;
            this.m_PayMoney = PayMoney;
            this.m_MinimumSalary = MinimumSalary;
            this.m_RankSalary = RankSalary;
            this.m_StepSalary = StepSalary;
            this.m_CoefficientSalary = CoefficientSalary;
            this.m_DateSalary = DateSalary;
            this.m_BasicSalary = BasicSalary;
            this.m_SalaryPeriod1 = SalaryPeriod1;
            this.m_InsuranceSalary = InsuranceSalary;
            this.m_IsFixedSalary = IsFixedSalary;
            this.m_Allowance1 = Allowance1;
            this.m_Allowance2 = Allowance2;
            this.m_Allowance3 = Allowance3;
            this.m_Allowance4 = Allowance4;
            this.m_IsSocialInsurance = IsSocialInsurance;
            this.m_IsHealthInsurance = IsHealthInsurance;
            this.m_IsUnemploymentInsurance = IsUnemploymentInsurance;
            this.m_IsUnionMoney = IsUnionMoney;
            this.m_IncomeTaxCode = IncomeTaxCode;
            this.m_IsMandateTax = IsMandateTax;
            this.m_IsYourSelfTax = IsYourSelfTax;
            this.m_IsSecondIncomeTax = IsSecondIncomeTax;
            this.m_PercentSecondIncomeTax = PercentSecondIncomeTax;
            this.m_ResidenceType = ResidenceType;
            this.m_BankCode = BankCode;
            this.m_BankDate = BankDate;
            this.m_BankName = BankName;
            this.m_BankBranch = BankBranch;
            this.m_BankCity = BankCity;
            this.m_BankAddress = BankAddress;
            this.m_LaborCode = LaborCode;
            this.m_LaborDate = LaborDate;
            this.m_LaborPlace = LaborPlace;
            this.m_IsUnion = IsUnion;
            this.m_UnionCode = UnionCode;
            this.m_UnionDate = UnionDate;
            this.m_UnionPlace = UnionPlace;
            this.m_IsParty = IsParty;
            this.m_PartyCode = PartyCode;
            this.m_PartyDate = PartyDate;
            this.m_PartyPlace = PartyPlace;
            this.m_InsuranceCode = InsuranceCode;
            this.m_InsuranceDate = InsuranceDate;
            this.m_InsurancePlace = InsurancePlace;
            this.m_HealthInsuranceCode = HealthInsuranceCode;
            this.m_HealthInsuranceFromDate = HealthInsuranceFromDate;
            this.m_HealthInsuranceToDate = HealthInsuranceToDate;
            this.m_ContractCode = ContractCode;
            this.m_ContractType = ContractType;
            this.m_ContractSignDate = ContractSignDate;
            this.m_ContractFromDate = ContractFromDate;
            this.m_ContractToDate = ContractToDate;
            this.m_Province = Province;
            this.m_Hospital = Hospital;
            this.m_MilitaryCode = MilitaryCode;
            this.m_MilitaryFromDate = MilitaryFromDate;
            this.m_MilitaryToDate = MilitaryToDate;
            this.m_MilitaryPosition = MilitaryPosition;
            this.m_PassportCode = PassportCode;
            this.m_PassportFromDate = PassportFromDate;
            this.m_PassportToDate = PassportToDate;
            this.m_ReasonLeave = ReasonLeave;
            this.m_Status = Status;
            this.m_Description = Description;
        }

        public void AddAllGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetListCurrentNow(0, "", -1);
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "EmployeeCode";
            gridlookup.Properties.ValueMember = "EmployeeCode";
        }

        public void AddGridLookupEdit(GridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetListCurrentNow(MyLogin.Level, MyLogin.Code, -1);
            gridlookup.Properties.DataSource = dataTable;
            gridlookup.Properties.DisplayMember = "EmployeeCode";
            gridlookup.Properties.ValueMember = "EmployeeCode";
        }

        public void AddRepositoryGridLookupEdit(RepositoryItemGridLookUpEdit gridlookup)
        {
            DataTable dataTable = new DataTable();
            dataTable = this.GetListCurrentNow(MyLogin.Level, MyLogin.Code, -1);
            gridlookup.DataSource = dataTable;
            gridlookup.DisplayMember = "EmployeeCode";
            gridlookup.ValueMember = "EmployeeCode";
        }

        public static string BirthdayString(int Year, int Month, int Day)
        {
            string str = "";
            string str1 = Year.ToString();
            string str2 = Month.ToString();
            string str3 = Day.ToString();
            if (Day < 10)
            {
                str3 = string.Concat("0", Day.ToString());
            }
            if (Month < 10)
            {
                str2 = string.Concat("0", Month.ToString());
            }
            if (!(Day != 0 ? true : Month != 0))
            {
                str = str1;
            }
            else if (Day != 0)
            {
                string[] strArrays = new string[] { str3, "/", str2, "/", str1 };
                str = string.Concat(strArrays);
            }
            else
            {
                str = string.Concat(str2, "/", str1);
            }
            return str;
        }

        public DataTable CreateNullDataTable()
        {
            DataTable dataTable = new DataTable();
            DataColumn dataColumn = new DataColumn("EmployeeCode");
            DataColumn dataColumn1 = new DataColumn("FirstName");
            DataColumn dataColumn2 = new DataColumn("LastName");
            DataColumn dataColumn3 = new DataColumn("Sex");
            DataColumn dataColumn4 = new DataColumn("Status");
            dataTable.Columns.Add(dataColumn);
            dataTable.Columns.Add(dataColumn1);
            dataTable.Columns.Add(dataColumn2);
            dataTable.Columns.Add(dataColumn3);
            dataTable.Columns.Add(dataColumn4);
            return dataTable;
        }

        public string Delete()
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_Delete", strArrays, mEmployeeCode);
        }

        public string Delete(string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_Delete", strArrays, employeeCode);
        }

        public string Delete(SqlConnection myConnection, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_EMPLOYEE_Delete", strArrays, employeeCode);
        }

        public string Delete(SqlTransaction myTransaction, string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_EMPLOYEE_Delete", strArrays, employeeCode);
        }

        private void DispError(object sender, SqlHelperException e)
        {
            XtraMessageBox.Show(e.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public string EditCode(string OldEmployeeCode, string NewEmployeeCode)
        {
            string[] strArrays = new string[] { "@OldEmployeeCode", "@NewEmployeeCode" };
            object[] oldEmployeeCode = new object[] { OldEmployeeCode, NewEmployeeCode };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_EditCode", strArrays, oldEmployeeCode);
        }

        public bool Exist(string EmployeeCode)
        {
            bool hasRows = false;
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_EMPLOYEE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                hasRows = sqlDataReader.HasRows;
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return hasRows;
        }

        public string Get(string EmployeeCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_EMPLOYEE_Get", strArrays, employeeCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_BranchName = Convert.ToString(sqlDataReader["BranchName"]);
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_GroupName = Convert.ToString(sqlDataReader["GroupName"]);
                    this.m_CandidateCode = Convert.ToString(sqlDataReader["CandidateCode"]);
                    this.m_EnrollNumber = Convert.ToString(sqlDataReader["EnrollNumber"]);
                    this.m_FirstName = Convert.ToString(sqlDataReader["FirstName"]);
                    this.m_LastName = Convert.ToString(sqlDataReader["LastName"]);
                    this.m_Alias = Convert.ToString(sqlDataReader["Alias"]);
                    this.m_Sex = Convert.ToBoolean(sqlDataReader["Sex"]);
                    this.m_Marriage = Convert.ToString(sqlDataReader["Marriage"]);
                    this.m_BirthdayDay = Convert.ToInt32(sqlDataReader["BirthdayDay"]);
                    this.m_BirthdayMonth = Convert.ToInt32(sqlDataReader["BirthdayMonth"]);
                    this.m_BirthdayYear = Convert.ToInt32(sqlDataReader["BirthdayYear"]);
                    this.m_BirthPlace = Convert.ToString(sqlDataReader["BirthPlace"]);
                    this.m_MainAddress = Convert.ToString(sqlDataReader["MainAddress"]);
                    this.m_ContactAddress = Convert.ToString(sqlDataReader["ContactAddress"]);
                    this.m_CellPhone = Convert.ToString(sqlDataReader["CellPhone"]);
                    this.m_HomePhone = Convert.ToString(sqlDataReader["HomePhone"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Skype = Convert.ToString(sqlDataReader["Skype"]);
                    this.m_Yahoo = Convert.ToString(sqlDataReader["Yahoo"]);
                    this.m_Facebook = Convert.ToString(sqlDataReader["Facebook"]);
                    this.m_Nationality = Convert.ToString(sqlDataReader["Nationality"]);
                    this.m_Ethnic = Convert.ToString(sqlDataReader["Ethnic"]);
                    this.m_Religion = Convert.ToString(sqlDataReader["Religion"]);
                    this.m_Education = Convert.ToString(sqlDataReader["Education"]);
                    this.m_Language = Convert.ToString(sqlDataReader["Language"]);
                    this.m_Informatic = Convert.ToString(sqlDataReader["Informatic"]);
                    this.m_Professional = Convert.ToString(sqlDataReader["Professional"]);
                    this.m_Position = Convert.ToString(sqlDataReader["Position"]);
                    this.m_GroupRateCode = Convert.ToString(sqlDataReader["GroupRateCode"]);
                    this.m_School = Convert.ToString(sqlDataReader["School"]);
                    this.m_IDCard = Convert.ToString(sqlDataReader["IDCard"]);
                    this.m_IDCardDate = Convert.ToDateTime(sqlDataReader["IDCardDate"]);
                    this.m_IDCardPlace = Convert.ToString(sqlDataReader["IDCardPlace"]);
                    this.m_IsTest = Convert.ToBoolean(sqlDataReader["IsTest"]);
                    this.m_TestTime = Convert.ToString(sqlDataReader["TestTime"]);
                    this.m_TestFromDate = Convert.ToDateTime(sqlDataReader["TestFromDate"]);
                    this.m_TestToDate = Convert.ToDateTime(sqlDataReader["TestToDate"]);
                    this.m_TestSalary = Convert.ToDecimal(sqlDataReader["TestSalary"]);
                    this.m_BeginDate = Convert.ToDateTime(sqlDataReader["BeginDate"]);
                    this.m_IsOffWork = Convert.ToBoolean(sqlDataReader["IsOffWork"]);
                    this.m_EndDate = Convert.ToDateTime(sqlDataReader["EndDate"]);
                    this.m_Health = Convert.ToString(sqlDataReader["Health"]);
                    this.m_Height = Convert.ToDouble(sqlDataReader["Height"]);
                    this.m_Weight = Convert.ToDouble(sqlDataReader["Weight"]);
                    this.m_PayForm = Convert.ToInt32(sqlDataReader["PayForm"]);
                    this.m_PayMoney = Convert.ToDecimal(sqlDataReader["PayMoney"]);
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_RankSalary = Convert.ToString(sqlDataReader["RankSalary"]);
                    this.m_StepSalary = Convert.ToInt32(sqlDataReader["StepSalary"]);
                    this.m_CoefficientSalary = Convert.ToDouble(sqlDataReader["CoefficientSalary"]);
                    this.m_DateSalary = Convert.ToDateTime(sqlDataReader["DateSalary"]);
                    this.m_BasicSalary = Convert.ToDecimal(sqlDataReader["BasicSalary"]);
                    this.m_SalaryPeriod1 = Convert.ToDecimal(sqlDataReader["SalaryPeriod1"]);
                    this.m_InsuranceSalary = Convert.ToDecimal(sqlDataReader["InsuranceSalary"]);
                    this.m_IsFixedSalary = (sqlDataReader["IsFixedSalary"] == DBNull.Value ? false : Convert.ToBoolean(sqlDataReader["IsFixedSalary"]));
                    this.m_Allowance1 = Convert.ToDecimal(sqlDataReader["Allowance1"]);
                    this.m_Allowance2 = Convert.ToDecimal(sqlDataReader["Allowance2"]);
                    this.m_Allowance3 = Convert.ToDecimal(sqlDataReader["Allowance3"]);
                    this.m_Allowance4 = Convert.ToDecimal(sqlDataReader["Allowance4"]);
                    this.m_IsSocialInsurance = Convert.ToBoolean(sqlDataReader["IsSocialInsurance"]);
                    this.m_IsHealthInsurance = Convert.ToBoolean(sqlDataReader["IsHealthInsurance"]);
                    this.m_IsUnemploymentInsurance = Convert.ToBoolean(sqlDataReader["IsUnemploymentInsurance"]);
                    this.m_IsUnionMoney = Convert.ToBoolean(sqlDataReader["IsUnionMoney"]);
                    this.m_IncomeTaxCode = Convert.ToString(sqlDataReader["IncomeTaxCode"]);
                    this.m_IsMandateTax = (sqlDataReader["IsMandateTax"] == DBNull.Value ? false : Convert.ToBoolean(sqlDataReader["IsMandateTax"]));
                    this.m_IsYourSelfTax = Convert.ToBoolean(sqlDataReader["IsYourSelfTax"]);
                    this.m_IsSecondIncomeTax = Convert.ToBoolean(sqlDataReader["IsSecondIncomeTax"]);
                    this.m_PercentSecondIncomeTax = Convert.ToDouble(sqlDataReader["PercentSecondIncomeTax"]);
                    this.m_ResidenceType = Convert.ToInt32(sqlDataReader["ResidenceType"]);
                    this.m_BankCode = Convert.ToString(sqlDataReader["BankCode"]);
                    this.m_BankDate = Convert.ToDateTime(sqlDataReader["BankDate"]);
                    this.m_BankName = Convert.ToString(sqlDataReader["BankName"]);
                    this.m_BankBranch = (sqlDataReader["BankBranch"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankBranch"]));
                    this.m_BankCity = (sqlDataReader["BankCity"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankCity"]));
                    this.m_BankAddress = Convert.ToString(sqlDataReader["BankAddress"]);
                    this.m_LaborCode = Convert.ToString(sqlDataReader["LaborCode"]);
                    this.m_LaborDate = Convert.ToDateTime(sqlDataReader["LaborDate"]);
                    this.m_LaborPlace = Convert.ToString(sqlDataReader["LaborPlace"]);
                    this.m_IsUnion = Convert.ToBoolean(sqlDataReader["IsUnion"]);
                    this.m_UnionCode = Convert.ToString(sqlDataReader["UnionCode"]);
                    this.m_UnionDate = Convert.ToDateTime(sqlDataReader["UnionDate"]);
                    this.m_UnionPlace = Convert.ToString(sqlDataReader["UnionPlace"]);
                    this.m_IsParty = Convert.ToBoolean(sqlDataReader["IsParty"]);
                    this.m_PartyCode = Convert.ToString(sqlDataReader["PartyCode"]);
                    this.m_PartyDate = Convert.ToDateTime(sqlDataReader["PartyDate"]);
                    this.m_PartyPlace = Convert.ToString(sqlDataReader["PartyPlace"]);
                    this.m_InsuranceCode = Convert.ToString(sqlDataReader["InsuranceCode"]);
                    this.m_InsuranceDate = Convert.ToDateTime(sqlDataReader["InsuranceDate"]);
                    this.m_InsurancePlace = Convert.ToString(sqlDataReader["InsurancePlace"]);
                    this.m_HealthInsuranceCode = Convert.ToString(sqlDataReader["HealthInsuranceCode"]);
                    this.m_HealthInsuranceFromDate = Convert.ToDateTime(sqlDataReader["HealthInsuranceFromDate"]);
                    this.m_HealthInsuranceToDate = Convert.ToDateTime(sqlDataReader["HealthInsuranceToDate"]);
                    this.m_ContractCode = Convert.ToString(sqlDataReader["ContractCode"]);
                    this.m_ContractType = Convert.ToString(sqlDataReader["ContractType"]);
                    this.m_ContractSignDate = Convert.ToDateTime(sqlDataReader["ContractSignDate"]);
                    this.m_ContractFromDate = Convert.ToDateTime(sqlDataReader["ContractFromDate"]);
                    this.m_ContractToDate = Convert.ToDateTime(sqlDataReader["ContractToDate"]);
                    this.m_Province = Convert.ToString(sqlDataReader["Province"]);
                    this.m_Hospital = Convert.ToString(sqlDataReader["Hospital"]);
                    this.m_MilitaryCode = Convert.ToString(sqlDataReader["MilitaryCode"]);
                    this.m_MilitaryFromDate = Convert.ToDateTime(sqlDataReader["MilitaryFromDate"]);
                    this.m_MilitaryToDate = Convert.ToDateTime(sqlDataReader["MilitaryToDate"]);
                    this.m_MilitaryPosition = Convert.ToString(sqlDataReader["MilitaryPosition"]);
                    this.m_PassportCode = Convert.ToString(sqlDataReader["PassportCode"]);
                    this.m_PassportFromDate = Convert.ToDateTime(sqlDataReader["PassportFromDate"]);
                    this.m_PassportToDate = Convert.ToDateTime(sqlDataReader["PassportToDate"]);
                    this.m_ReasonLeave = Convert.ToString(sqlDataReader["ReasonLeave"]);
                    this.m_Status = Convert.ToInt32(sqlDataReader["Status"]);
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

        public string Get(SqlConnection myConnection, string CandidateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@CandidateCode" };
            object[] candidateCode = new object[] { CandidateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myConnection, "HRM_EMPLOYEE_Get", strArrays, candidateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_BranchName = Convert.ToString(sqlDataReader["BranchName"]);
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_GroupName = Convert.ToString(sqlDataReader["GroupName"]);
                    this.m_CandidateCode = Convert.ToString(sqlDataReader["CandidateCode"]);
                    this.m_EnrollNumber = Convert.ToString(sqlDataReader["EnrollNumber"]);
                    this.m_FirstName = Convert.ToString(sqlDataReader["FirstName"]);
                    this.m_LastName = Convert.ToString(sqlDataReader["LastName"]);
                    this.m_Alias = Convert.ToString(sqlDataReader["Alias"]);
                    this.m_Sex = Convert.ToBoolean(sqlDataReader["Sex"]);
                    this.m_Marriage = Convert.ToString(sqlDataReader["Marriage"]);
                    this.m_BirthdayDay = Convert.ToInt32(sqlDataReader["BirthdayDay"]);
                    this.m_BirthdayMonth = Convert.ToInt32(sqlDataReader["BirthdayMonth"]);
                    this.m_BirthdayYear = Convert.ToInt32(sqlDataReader["BirthdayYear"]);
                    this.m_BirthPlace = Convert.ToString(sqlDataReader["BirthPlace"]);
                    this.m_MainAddress = Convert.ToString(sqlDataReader["MainAddress"]);
                    this.m_ContactAddress = Convert.ToString(sqlDataReader["ContactAddress"]);
                    this.m_CellPhone = Convert.ToString(sqlDataReader["CellPhone"]);
                    this.m_HomePhone = Convert.ToString(sqlDataReader["HomePhone"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Skype = Convert.ToString(sqlDataReader["Skype"]);
                    this.m_Yahoo = Convert.ToString(sqlDataReader["Yahoo"]);
                    this.m_Facebook = Convert.ToString(sqlDataReader["Facebook"]);
                    this.m_Nationality = Convert.ToString(sqlDataReader["Nationality"]);
                    this.m_Ethnic = Convert.ToString(sqlDataReader["Ethnic"]);
                    this.m_Religion = Convert.ToString(sqlDataReader["Religion"]);
                    this.m_Education = Convert.ToString(sqlDataReader["Education"]);
                    this.m_Language = Convert.ToString(sqlDataReader["Language"]);
                    this.m_Informatic = Convert.ToString(sqlDataReader["Informatic"]);
                    this.m_Professional = Convert.ToString(sqlDataReader["Professional"]);
                    this.m_Position = Convert.ToString(sqlDataReader["Position"]);
                    this.m_GroupRateCode = Convert.ToString(sqlDataReader["GroupRateCode"]);
                    this.m_School = Convert.ToString(sqlDataReader["School"]);
                    this.m_IDCard = Convert.ToString(sqlDataReader["IDCard"]);
                    this.m_IDCardDate = Convert.ToDateTime(sqlDataReader["IDCardDate"]);
                    this.m_IDCardPlace = Convert.ToString(sqlDataReader["IDCardPlace"]);
                    this.m_IsTest = Convert.ToBoolean(sqlDataReader["IsTest"]);
                    this.m_TestTime = Convert.ToString(sqlDataReader["TestTime"]);
                    this.m_TestFromDate = Convert.ToDateTime(sqlDataReader["TestFromDate"]);
                    this.m_TestToDate = Convert.ToDateTime(sqlDataReader["TestToDate"]);
                    this.m_TestSalary = Convert.ToDecimal(sqlDataReader["TestSalary"]);
                    this.m_BeginDate = Convert.ToDateTime(sqlDataReader["BeginDate"]);
                    this.m_IsOffWork = Convert.ToBoolean(sqlDataReader["IsOffWork"]);
                    this.m_EndDate = Convert.ToDateTime(sqlDataReader["EndDate"]);
                    this.m_Health = Convert.ToString(sqlDataReader["Health"]);
                    this.m_Height = Convert.ToDouble(sqlDataReader["Height"]);
                    this.m_Weight = Convert.ToDouble(sqlDataReader["Weight"]);
                    this.m_PayForm = Convert.ToInt32(sqlDataReader["PayForm"]);
                    this.m_PayMoney = Convert.ToDecimal(sqlDataReader["PayMoney"]);
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_RankSalary = Convert.ToString(sqlDataReader["RankSalary"]);
                    this.m_StepSalary = Convert.ToInt32(sqlDataReader["StepSalary"]);
                    this.m_CoefficientSalary = Convert.ToDouble(sqlDataReader["CoefficientSalary"]);
                    this.m_DateSalary = Convert.ToDateTime(sqlDataReader["DateSalary"]);
                    this.m_BasicSalary = Convert.ToDecimal(sqlDataReader["BasicSalary"]);
                    this.m_SalaryPeriod1 = Convert.ToDecimal(sqlDataReader["SalaryPeriod1"]);
                    this.m_InsuranceSalary = Convert.ToDecimal(sqlDataReader["InsuranceSalary"]);
                    this.m_IsFixedSalary = (sqlDataReader["IsFixedSalary"] == DBNull.Value ? false : Convert.ToBoolean(sqlDataReader["IsFixedSalary"]));
                    this.m_Allowance1 = Convert.ToDecimal(sqlDataReader["Allowance1"]);
                    this.m_Allowance2 = Convert.ToDecimal(sqlDataReader["Allowance2"]);
                    this.m_Allowance3 = Convert.ToDecimal(sqlDataReader["Allowance3"]);
                    this.m_Allowance4 = Convert.ToDecimal(sqlDataReader["Allowance4"]);
                    this.m_IsSocialInsurance = Convert.ToBoolean(sqlDataReader["IsSocialInsurance"]);
                    this.m_IsHealthInsurance = Convert.ToBoolean(sqlDataReader["IsHealthInsurance"]);
                    this.m_IsUnemploymentInsurance = Convert.ToBoolean(sqlDataReader["IsUnemploymentInsurance"]);
                    this.m_IsUnionMoney = Convert.ToBoolean(sqlDataReader["IsUnionMoney"]);
                    this.m_IncomeTaxCode = Convert.ToString(sqlDataReader["IncomeTaxCode"]);
                    this.m_IsMandateTax = (sqlDataReader["IsMandateTax"] == DBNull.Value ? false : Convert.ToBoolean(sqlDataReader["IsMandateTax"]));
                    this.m_IsYourSelfTax = Convert.ToBoolean(sqlDataReader["IsYourSelfTax"]);
                    this.m_IsSecondIncomeTax = Convert.ToBoolean(sqlDataReader["IsSecondIncomeTax"]);
                    this.m_PercentSecondIncomeTax = Convert.ToDouble(sqlDataReader["PercentSecondIncomeTax"]);
                    this.m_ResidenceType = Convert.ToInt32(sqlDataReader["ResidenceType"]);
                    this.m_BankCode = Convert.ToString(sqlDataReader["BankCode"]);
                    this.m_BankDate = Convert.ToDateTime(sqlDataReader["BankDate"]);
                    this.m_BankName = Convert.ToString(sqlDataReader["BankName"]);
                    this.m_BankBranch = (sqlDataReader["BankBranch"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankBranch"]));
                    this.m_BankCity = (sqlDataReader["BankCity"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankCity"]));
                    this.m_BankAddress = Convert.ToString(sqlDataReader["BankAddress"]);
                    this.m_LaborCode = Convert.ToString(sqlDataReader["LaborCode"]);
                    this.m_LaborDate = Convert.ToDateTime(sqlDataReader["LaborDate"]);
                    this.m_LaborPlace = Convert.ToString(sqlDataReader["LaborPlace"]);
                    this.m_IsUnion = Convert.ToBoolean(sqlDataReader["IsUnion"]);
                    this.m_UnionCode = Convert.ToString(sqlDataReader["UnionCode"]);
                    this.m_UnionDate = Convert.ToDateTime(sqlDataReader["UnionDate"]);
                    this.m_UnionPlace = Convert.ToString(sqlDataReader["UnionPlace"]);
                    this.m_IsParty = Convert.ToBoolean(sqlDataReader["IsParty"]);
                    this.m_PartyCode = Convert.ToString(sqlDataReader["PartyCode"]);
                    this.m_PartyDate = Convert.ToDateTime(sqlDataReader["PartyDate"]);
                    this.m_PartyPlace = Convert.ToString(sqlDataReader["PartyPlace"]);
                    this.m_InsuranceCode = Convert.ToString(sqlDataReader["InsuranceCode"]);
                    this.m_InsuranceDate = Convert.ToDateTime(sqlDataReader["InsuranceDate"]);
                    this.m_InsurancePlace = Convert.ToString(sqlDataReader["InsurancePlace"]);
                    this.m_HealthInsuranceCode = Convert.ToString(sqlDataReader["HealthInsuranceCode"]);
                    this.m_HealthInsuranceFromDate = Convert.ToDateTime(sqlDataReader["HealthInsuranceFromDate"]);
                    this.m_HealthInsuranceToDate = Convert.ToDateTime(sqlDataReader["HealthInsuranceToDate"]);
                    this.m_ContractCode = Convert.ToString(sqlDataReader["ContractCode"]);
                    this.m_ContractType = Convert.ToString(sqlDataReader["ContractType"]);
                    this.m_ContractSignDate = Convert.ToDateTime(sqlDataReader["ContractSignDate"]);
                    this.m_ContractFromDate = Convert.ToDateTime(sqlDataReader["ContractFromDate"]);
                    this.m_ContractToDate = Convert.ToDateTime(sqlDataReader["ContractToDate"]);
                    this.m_Province = Convert.ToString(sqlDataReader["Province"]);
                    this.m_Hospital = Convert.ToString(sqlDataReader["Hospital"]);
                    this.m_MilitaryCode = Convert.ToString(sqlDataReader["MilitaryCode"]);
                    this.m_MilitaryFromDate = Convert.ToDateTime(sqlDataReader["MilitaryFromDate"]);
                    this.m_MilitaryToDate = Convert.ToDateTime(sqlDataReader["MilitaryToDate"]);
                    this.m_MilitaryPosition = Convert.ToString(sqlDataReader["MilitaryPosition"]);
                    this.m_PassportCode = Convert.ToString(sqlDataReader["PassportCode"]);
                    this.m_PassportFromDate = Convert.ToDateTime(sqlDataReader["PassportFromDate"]);
                    this.m_PassportToDate = Convert.ToDateTime(sqlDataReader["PassportToDate"]);
                    this.m_ReasonLeave = Convert.ToString(sqlDataReader["ReasonLeave"]);
                    this.m_Status = Convert.ToInt32(sqlDataReader["Status"]);
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

        public string Get(SqlTransaction myTransaction, string CandidateCode)
        {
            string str = "";
            string[] strArrays = new string[] { "@CandidateCode" };
            object[] candidateCode = new object[] { CandidateCode };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader(myTransaction, "HRM_EMPLOYEE_Get", strArrays, candidateCode);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_SubsidiaryCode = (sqlDataReader["SubsidiaryCode"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryCode"]));
                    this.m_SubsidiaryName = (sqlDataReader["SubsidiaryName"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["SubsidiaryName"]));
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_BranchName = Convert.ToString(sqlDataReader["BranchName"]);
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_GroupName = Convert.ToString(sqlDataReader["GroupName"]);
                    this.m_CandidateCode = Convert.ToString(sqlDataReader["CandidateCode"]);
                    this.m_EnrollNumber = Convert.ToString(sqlDataReader["EnrollNumber"]);
                    this.m_FirstName = Convert.ToString(sqlDataReader["FirstName"]);
                    this.m_LastName = Convert.ToString(sqlDataReader["LastName"]);
                    this.m_Alias = Convert.ToString(sqlDataReader["Alias"]);
                    this.m_Sex = Convert.ToBoolean(sqlDataReader["Sex"]);
                    this.m_Marriage = Convert.ToString(sqlDataReader["Marriage"]);
                    this.m_BirthdayDay = Convert.ToInt32(sqlDataReader["BirthdayDay"]);
                    this.m_BirthdayMonth = Convert.ToInt32(sqlDataReader["BirthdayMonth"]);
                    this.m_BirthdayYear = Convert.ToInt32(sqlDataReader["BirthdayYear"]);
                    this.m_BirthPlace = Convert.ToString(sqlDataReader["BirthPlace"]);
                    this.m_MainAddress = Convert.ToString(sqlDataReader["MainAddress"]);
                    this.m_ContactAddress = Convert.ToString(sqlDataReader["ContactAddress"]);
                    this.m_CellPhone = Convert.ToString(sqlDataReader["CellPhone"]);
                    this.m_HomePhone = Convert.ToString(sqlDataReader["HomePhone"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    this.m_Skype = Convert.ToString(sqlDataReader["Skype"]);
                    this.m_Yahoo = Convert.ToString(sqlDataReader["Yahoo"]);
                    this.m_Facebook = Convert.ToString(sqlDataReader["Facebook"]);
                    this.m_Nationality = Convert.ToString(sqlDataReader["Nationality"]);
                    this.m_Ethnic = Convert.ToString(sqlDataReader["Ethnic"]);
                    this.m_Religion = Convert.ToString(sqlDataReader["Religion"]);
                    this.m_Education = Convert.ToString(sqlDataReader["Education"]);
                    this.m_Language = Convert.ToString(sqlDataReader["Language"]);
                    this.m_Informatic = Convert.ToString(sqlDataReader["Informatic"]);
                    this.m_Professional = Convert.ToString(sqlDataReader["Professional"]);
                    this.m_Position = Convert.ToString(sqlDataReader["Position"]);
                    this.m_GroupRateCode = Convert.ToString(sqlDataReader["GroupRateCode"]);
                    this.m_School = Convert.ToString(sqlDataReader["School"]);
                    this.m_IDCard = Convert.ToString(sqlDataReader["IDCard"]);
                    this.m_IDCardDate = Convert.ToDateTime(sqlDataReader["IDCardDate"]);
                    this.m_IDCardPlace = Convert.ToString(sqlDataReader["IDCardPlace"]);
                    this.m_IsTest = Convert.ToBoolean(sqlDataReader["IsTest"]);
                    this.m_TestTime = Convert.ToString(sqlDataReader["TestTime"]);
                    this.m_TestFromDate = Convert.ToDateTime(sqlDataReader["TestFromDate"]);
                    this.m_TestToDate = Convert.ToDateTime(sqlDataReader["TestToDate"]);
                    this.m_TestSalary = Convert.ToDecimal(sqlDataReader["TestSalary"]);
                    this.m_BeginDate = Convert.ToDateTime(sqlDataReader["BeginDate"]);
                    this.m_IsOffWork = Convert.ToBoolean(sqlDataReader["IsOffWork"]);
                    this.m_EndDate = Convert.ToDateTime(sqlDataReader["EndDate"]);
                    this.m_Health = Convert.ToString(sqlDataReader["Health"]);
                    this.m_Height = Convert.ToDouble(sqlDataReader["Height"]);
                    this.m_Weight = Convert.ToDouble(sqlDataReader["Weight"]);
                    this.m_PayForm = Convert.ToInt32(sqlDataReader["PayForm"]);
                    this.m_PayMoney = Convert.ToDecimal(sqlDataReader["PayMoney"]);
                    this.m_MinimumSalary = Convert.ToDecimal(sqlDataReader["MinimumSalary"]);
                    this.m_RankSalary = Convert.ToString(sqlDataReader["RankSalary"]);
                    this.m_StepSalary = Convert.ToInt32(sqlDataReader["StepSalary"]);
                    this.m_CoefficientSalary = Convert.ToDouble(sqlDataReader["CoefficientSalary"]);
                    this.m_DateSalary = Convert.ToDateTime(sqlDataReader["DateSalary"]);
                    this.m_BasicSalary = Convert.ToDecimal(sqlDataReader["BasicSalary"]);
                    this.m_SalaryPeriod1 = Convert.ToDecimal(sqlDataReader["SalaryPeriod1"]);
                    this.m_InsuranceSalary = Convert.ToDecimal(sqlDataReader["InsuranceSalary"]);
                    this.m_IsFixedSalary = (sqlDataReader["IsFixedSalary"] == DBNull.Value ? false : Convert.ToBoolean(sqlDataReader["IsFixedSalary"]));
                    this.m_Allowance1 = Convert.ToDecimal(sqlDataReader["Allowance1"]);
                    this.m_Allowance2 = Convert.ToDecimal(sqlDataReader["Allowance2"]);
                    this.m_Allowance3 = Convert.ToDecimal(sqlDataReader["Allowance3"]);
                    this.m_Allowance4 = Convert.ToDecimal(sqlDataReader["Allowance4"]);
                    this.m_IsSocialInsurance = Convert.ToBoolean(sqlDataReader["IsSocialInsurance"]);
                    this.m_IsHealthInsurance = Convert.ToBoolean(sqlDataReader["IsHealthInsurance"]);
                    this.m_IsUnemploymentInsurance = Convert.ToBoolean(sqlDataReader["IsUnemploymentInsurance"]);
                    this.m_IsUnionMoney = Convert.ToBoolean(sqlDataReader["IsUnionMoney"]);
                    this.m_IncomeTaxCode = Convert.ToString(sqlDataReader["IncomeTaxCode"]);
                    this.m_IsMandateTax = (sqlDataReader["IsMandateTax"] == DBNull.Value ? false : Convert.ToBoolean(sqlDataReader["IsMandateTax"]));
                    this.m_IsYourSelfTax = Convert.ToBoolean(sqlDataReader["IsYourSelfTax"]);
                    this.m_IsSecondIncomeTax = Convert.ToBoolean(sqlDataReader["IsSecondIncomeTax"]);
                    this.m_PercentSecondIncomeTax = Convert.ToDouble(sqlDataReader["PercentSecondIncomeTax"]);
                    this.m_ResidenceType = Convert.ToInt32(sqlDataReader["ResidenceType"]);
                    this.m_BankCode = Convert.ToString(sqlDataReader["BankCode"]);
                    this.m_BankDate = Convert.ToDateTime(sqlDataReader["BankDate"]);
                    this.m_BankName = Convert.ToString(sqlDataReader["BankName"]);
                    this.m_BankBranch = (sqlDataReader["BankBranch"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankBranch"]));
                    this.m_BankCity = (sqlDataReader["BankCity"] == DBNull.Value ? "" : Convert.ToString(sqlDataReader["BankCity"]));
                    this.m_BankAddress = Convert.ToString(sqlDataReader["BankAddress"]);
                    this.m_LaborCode = Convert.ToString(sqlDataReader["LaborCode"]);
                    this.m_LaborDate = Convert.ToDateTime(sqlDataReader["LaborDate"]);
                    this.m_LaborPlace = Convert.ToString(sqlDataReader["LaborPlace"]);
                    this.m_IsUnion = Convert.ToBoolean(sqlDataReader["IsUnion"]);
                    this.m_UnionCode = Convert.ToString(sqlDataReader["UnionCode"]);
                    this.m_UnionDate = Convert.ToDateTime(sqlDataReader["UnionDate"]);
                    this.m_UnionPlace = Convert.ToString(sqlDataReader["UnionPlace"]);
                    this.m_IsParty = Convert.ToBoolean(sqlDataReader["IsParty"]);
                    this.m_PartyCode = Convert.ToString(sqlDataReader["PartyCode"]);
                    this.m_PartyDate = Convert.ToDateTime(sqlDataReader["PartyDate"]);
                    this.m_PartyPlace = Convert.ToString(sqlDataReader["PartyPlace"]);
                    this.m_InsuranceCode = Convert.ToString(sqlDataReader["InsuranceCode"]);
                    this.m_InsuranceDate = Convert.ToDateTime(sqlDataReader["InsuranceDate"]);
                    this.m_InsurancePlace = Convert.ToString(sqlDataReader["InsurancePlace"]);
                    this.m_HealthInsuranceCode = Convert.ToString(sqlDataReader["HealthInsuranceCode"]);
                    this.m_HealthInsuranceFromDate = Convert.ToDateTime(sqlDataReader["HealthInsuranceFromDate"]);
                    this.m_HealthInsuranceToDate = Convert.ToDateTime(sqlDataReader["HealthInsuranceToDate"]);
                    this.m_ContractCode = Convert.ToString(sqlDataReader["ContractCode"]);
                    this.m_ContractType = Convert.ToString(sqlDataReader["ContractType"]);
                    this.m_ContractSignDate = Convert.ToDateTime(sqlDataReader["ContractSignDate"]);
                    this.m_ContractFromDate = Convert.ToDateTime(sqlDataReader["ContractFromDate"]);
                    this.m_ContractToDate = Convert.ToDateTime(sqlDataReader["ContractToDate"]);
                    this.m_Province = Convert.ToString(sqlDataReader["Province"]);
                    this.m_Hospital = Convert.ToString(sqlDataReader["Hospital"]);
                    this.m_MilitaryCode = Convert.ToString(sqlDataReader["MilitaryCode"]);
                    this.m_MilitaryFromDate = Convert.ToDateTime(sqlDataReader["MilitaryFromDate"]);
                    this.m_MilitaryToDate = Convert.ToDateTime(sqlDataReader["MilitaryToDate"]);
                    this.m_MilitaryPosition = Convert.ToString(sqlDataReader["MilitaryPosition"]);
                    this.m_PassportCode = Convert.ToString(sqlDataReader["PassportCode"]);
                    this.m_PassportFromDate = Convert.ToDateTime(sqlDataReader["PassportFromDate"]);
                    this.m_PassportToDate = Convert.ToDateTime(sqlDataReader["PassportToDate"]);
                    this.m_ReasonLeave = Convert.ToString(sqlDataReader["ReasonLeave"]);
                    this.m_Status = Convert.ToInt32(sqlDataReader["Status"]);
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

        public DataTable GetAge(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetAge", strArrays, level);
        }

        public DataTable GetAllList(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetAllList", strArrays, level);
        }

        public DataTable GetAllSex()
        {
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetAllSex");
        }

        public string GetByEnroll(string EnrollNumber)
        {
            string str = "";
            string[] strArrays = new string[] { "@EnrollNumber" };
            object[] enrollNumber = new object[] { EnrollNumber };
            SqlHelper sqlHelper = new SqlHelper();
            SqlDataReader sqlDataReader = sqlHelper.ExecuteReader("HRM_EMPLOYEE_GetByEnroll", strArrays, enrollNumber);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    this.m_EmployeeCode = Convert.ToString(sqlDataReader["EmployeeCode"]);
                    this.m_BranchCode = Convert.ToString(sqlDataReader["BranchCode"]);
                    this.m_BranchName = Convert.ToString(sqlDataReader["BranchName"]);
                    this.m_DepartmentCode = Convert.ToString(sqlDataReader["DepartmentCode"]);
                    this.m_DepartmentName = Convert.ToString(sqlDataReader["DepartmentName"]);
                    this.m_GroupCode = Convert.ToString(sqlDataReader["GroupCode"]);
                    this.m_GroupName = Convert.ToString(sqlDataReader["GroupName"]);
                    this.m_CandidateCode = Convert.ToString(sqlDataReader["CandidateCode"]);
                    this.m_EnrollNumber = Convert.ToString(sqlDataReader["EnrollNumber"]);
                    this.m_FirstName = Convert.ToString(sqlDataReader["FirstName"]);
                    this.m_LastName = Convert.ToString(sqlDataReader["LastName"]);
                    this.m_Alias = Convert.ToString(sqlDataReader["Alias"]);
                    this.m_Sex = Convert.ToBoolean(sqlDataReader["Sex"]);
                    this.m_Marriage = Convert.ToString(sqlDataReader["Marriage"]);
                    this.m_BirthdayDay = Convert.ToInt32(sqlDataReader["BirthdayDay"]);
                    this.m_BirthdayMonth = Convert.ToInt32(sqlDataReader["BirthdayMonth"]);
                    this.m_BirthdayYear = Convert.ToInt32(sqlDataReader["BirthdayYear"]);
                    this.m_BirthPlace = Convert.ToString(sqlDataReader["BirthPlace"]);
                    this.m_MainAddress = Convert.ToString(sqlDataReader["MainAddress"]);
                    this.m_ContactAddress = Convert.ToString(sqlDataReader["ContactAddress"]);
                    this.m_CellPhone = Convert.ToString(sqlDataReader["CellPhone"]);
                    this.m_HomePhone = Convert.ToString(sqlDataReader["HomePhone"]);
                    this.m_Email = Convert.ToString(sqlDataReader["Email"]);
                    str = "OK";
                }
                sqlDataReader.Close();
                sqlHelper.Close();
                sqlDataReader = null;
            }
            return str;
        }

        public DataTable GetCompactList(int Level, string Code, int Status, DateTime DayFirstMonth, DateTime DayEndMonth)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@Status", "@DayFirstMonth", "@DayEndMonth" };
            string[] strArrays1 = strArrays;
            object[] level = new object[] { Level, Code, Status, DayFirstMonth, DayEndMonth };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetCompactList", strArrays1, level);
        }

        public DataTable GetEducation(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetEducation", strArrays, level);
        }

        public DataTable GetEthnic(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetEthnic", strArrays, level);
        }

        public DataTable GetIncreaseDecreaseList(int Level, string Code, int Status, int Month, int Year)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@Status", "@Month", "@Year" };
            string[] strArrays1 = strArrays;
            object[] level = new object[] { Level, Code, Status, Month, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetIncreaseDecreaseList", strArrays1, level);
        }

        public DataTable GetInformatic(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetInformatic", strArrays, level);
        }

        public DataTable GetLanguage(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetLanguage", strArrays, level);
        }

        public DataTable GetList(string EmployeeCode)
        {
            string[] strArrays = new string[] { "@EmployeeCode" };
            object[] employeeCode = new object[] { EmployeeCode };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_Get", strArrays, employeeCode);
        }

        public DataTable GetList(int Level, string Code, int Status, DateTime DayFirstMonth, DateTime DayEndMonth)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@Status", "@DayFirstMonth", "@DayEndMonth" };
            string[] strArrays1 = strArrays;
            object[] level = new object[] { Level, Code, Status, DayFirstMonth, DayEndMonth };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetList", strArrays1, level);
        }

        public DataTable GetListBirthday(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetListBirthday", strArrays, level);
        }

        public DataTable GetListBirthdayByMonth(int Month)
        {
            string[] strArrays = new string[] { "@Month" };
            object[] month = new object[] { Month };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetListBirthdayByMonth", strArrays, month);
        }

        public DataTable GetListByYear(int Level, string Code, int Year)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@Year" };
            object[] level = new object[] { Level, Code, Year };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetListByYear", strArrays, level);
        }

        public DataTable GetListContractJustExpiration(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetListContractJustExpiration", strArrays, level);
        }

        public DataTable GetListCurrentNow(int Level, string Code, int Status)
        {
            DateTime now = DateTime.Now;
            DateTime dateTime = DateTime.Now;
            string[] strArrays = new string[] { "@Level", "@Code", "@Status", "@DayFirstMonth", "@DayEndMonth" };
            string[] strArrays1 = strArrays;
            object[] level = new object[] { Level, Code, Status, now, dateTime };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetList", strArrays1, level);
        }

        public DataTable GetListEvent()
        {
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetListEvent");
        }

        public DataTable GetListStatistical()
        {
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetStatistical");
        }

        public DataTable GetListTestJustExpiration(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetListTestJustExpiration", strArrays, level);
        }

        public DataTable GetMarriage(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetMarriage", strArrays, level);
        }

        public DataTable GetNationality(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetNationality", strArrays, level);
        }

        public DataTable GetPosition(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetPosition", strArrays, level);
        }

        public DataTable GetProfessional(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetProfessional", strArrays, level);
        }

        public DataTable GetRate(int Level, string Code, int FromYear, int ToYear)
        {
            string[] strArrays = new string[] { "@Level", "@Code", "@FromYear", "@ToYear" };
            object[] level = new object[] { Level, Code, FromYear, ToYear };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetRate", strArrays, level);
        }

        public DataTable GetReligion(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetReligion", strArrays, level);
        }

        public DataTable GetSex(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetSex", strArrays, level);
        }

        public DataTable GetStatus(int Level, string Code)
        {
            string[] strArrays = new string[] { "@Level", "@Code" };
            object[] level = new object[] { Level, Code };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_GetStatus", strArrays, level);
        }

        public string Insert()
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@CandidateCode", "@EnrollNumber", "@FirstName", "@LastName", "@Alias", "@Sex", "@Marriage", "@BirthdayDay", "@BirthdayMonth", "@BirthdayYear", "@BirthPlace", "@MainAddress", "@ContactAddress", "@CellPhone", "@HomePhone", "@Email", "@Skype", "@Yahoo", "@Facebook", "@Nationality", "@Ethnic", "@Religion", "@Education", "@Language", "@Informatic", "@Professional", "@Position", "@GroupRateCode", "@School", "@IDCard", "@IDCardDate", "@IDCardPlace", "@IsTest", "@TestTime", "@TestFromDate", "@TestToDate", "@TestSalary", "@BeginDate", "@IsOffWork", "@EndDate", "@Health", "@Height", "@Weight", "@PayForm", "@PayMoney", "@MinimumSalary", "@RankSalary", "@StepSalary", "@CoefficientSalary", "@DateSalary", "@BasicSalary", "@SalaryPeriod1", "@InsuranceSalary", "@IsFixedSalary", "@Allowance1", "@Allowance2", "@Allowance3", "@Allowance4", "@IsSocialInsurance", "@IsHealthInsurance", "@IsUnemploymentInsurance", "@IsUnionMoney", "@IncomeTaxCode", "@IsMandateTax", "@IsYourSelfTax", "@IsSecondIncomeTax", "@PercentSecondIncomeTax", "@ResidenceType", "@BankCode", "@BankDate", "@BankName", "@BankBranch", "@BankCity", "@BankAddress", "@LaborCode", "@LaborDate", "@LaborPlace", "@IsUnion", "@UnionCode", "@UnionDate", "@UnionPlace", "@IsParty", "@PartyCode", "@PartyDate", "@PartyPlace", "@InsuranceCode", "@InsuranceDate", "@InsurancePlace", "@HealthInsuranceCode", "@HealthInsuranceFromDate", "@HealthInsuranceToDate", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate", "@Province", "@Hospital", "@MilitaryCode", "@MilitaryFromDate", "@MilitaryToDate", "@MilitaryPosition", "@PassportCode", "@PassportFromDate", "@PassportToDate", "@ReasonLeave", "@Status", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentCode, this.m_GroupCode, this.m_CandidateCode, this.m_EnrollNumber, this.m_FirstName, this.m_LastName, this.m_Alias, this.m_Sex, this.m_Marriage, this.m_BirthdayDay, this.m_BirthdayMonth, this.m_BirthdayYear, this.m_BirthPlace, this.m_MainAddress, this.m_ContactAddress, this.m_CellPhone, this.m_HomePhone, this.m_Email, this.m_Skype, this.m_Yahoo, this.m_Facebook, this.m_Nationality, this.m_Ethnic, this.m_Religion, this.m_Education, this.m_Language, this.m_Informatic, this.m_Professional, this.m_Position, this.m_GroupRateCode, this.m_School, this.m_IDCard, this.m_IDCardDate, this.m_IDCardPlace, this.m_IsTest, this.m_TestTime, this.m_TestFromDate, this.m_TestToDate, this.m_TestSalary, this.m_BeginDate, this.m_IsOffWork, this.m_EndDate, this.m_Health, this.m_Height, this.m_Weight, this.m_PayForm, this.m_PayMoney, this.m_MinimumSalary, this.m_RankSalary, this.m_StepSalary, this.m_CoefficientSalary, this.m_DateSalary, this.m_BasicSalary, this.m_SalaryPeriod1, this.m_InsuranceSalary, this.m_IsFixedSalary, this.m_Allowance1, this.m_Allowance2, this.m_Allowance3, this.m_Allowance4, this.m_IsSocialInsurance, this.m_IsHealthInsurance, this.m_IsUnemploymentInsurance, this.m_IsUnionMoney, this.m_IncomeTaxCode, this.m_IsMandateTax, this.m_IsYourSelfTax, this.m_IsSecondIncomeTax, this.m_PercentSecondIncomeTax, this.m_ResidenceType, this.m_BankCode, this.m_BankDate, this.m_BankName, this.m_BankBranch, this.m_BankCity, this.m_BankAddress, this.m_LaborCode, this.m_LaborDate, this.m_LaborPlace, this.m_IsUnion, this.m_UnionCode, this.m_UnionDate, this.m_UnionPlace, this.m_IsParty, this.m_PartyCode, this.m_PartyDate, this.m_PartyPlace, this.m_InsuranceCode, this.m_InsuranceDate, this.m_InsurancePlace, this.m_HealthInsuranceCode, this.m_HealthInsuranceFromDate, this.m_HealthInsuranceToDate, this.m_ContractCode, this.m_ContractType, this.m_ContractSignDate, this.m_ContractFromDate, this.m_ContractToDate, this.m_Province, this.m_Hospital, this.m_MilitaryCode, this.m_MilitaryFromDate, this.m_MilitaryToDate, this.m_MilitaryPosition, this.m_PassportCode, this.m_PassportFromDate, this.m_PassportToDate, this.m_ReasonLeave, this.m_Status, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_Insert", strArrays1, mEmployeeCode);
        }

        public string Insert(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@CandidateCode", "@EnrollNumber", "@FirstName", "@LastName", "@Alias", "@Sex", "@Marriage", "@BirthdayDay", "@BirthdayMonth", "@BirthdayYear", "@BirthPlace", "@MainAddress", "@ContactAddress", "@CellPhone", "@HomePhone", "@Email", "@Skype", "@Yahoo", "@Facebook", "@Nationality", "@Ethnic", "@Religion", "@Education", "@Language", "@Informatic", "@Professional", "@Position", "@GroupRateCode", "@School", "@IDCard", "@IDCardDate", "@IDCardPlace", "@IsTest", "@TestTime", "@TestFromDate", "@TestToDate", "@TestSalary", "@BeginDate", "@IsOffWork", "@EndDate", "@Health", "@Height", "@Weight", "@PayForm", "@PayMoney", "@MinimumSalary", "@RankSalary", "@StepSalary", "@CoefficientSalary", "@DateSalary", "@BasicSalary", "@SalaryPeriod1", "@InsuranceSalary", "@IsFixedSalary", "@Allowance1", "@Allowance2", "@Allowance3", "@Allowance4", "@IsSocialInsurance", "@IsHealthInsurance", "@IsUnemploymentInsurance", "@IsUnionMoney", "@IncomeTaxCode", "@IsMandateTax", "@IsYourSelfTax", "@IsSecondIncomeTax", "@PercentSecondIncomeTax", "@ResidenceType", "@BankCode", "@BankDate", "@BankName", "@BankBranch", "@BankCity", "@BankAddress", "@LaborCode", "@LaborDate", "@LaborPlace", "@IsUnion", "@UnionCode", "@UnionDate", "@UnionPlace", "@IsParty", "@PartyCode", "@PartyDate", "@PartyPlace", "@InsuranceCode", "@InsuranceDate", "@InsurancePlace", "@HealthInsuranceCode", "@HealthInsuranceFromDate", "@HealthInsuranceToDate", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate", "@Province", "@Hospital", "@MilitaryCode", "@MilitaryFromDate", "@MilitaryToDate", "@MilitaryPosition", "@PassportCode", "@PassportFromDate", "@PassportToDate", "@ReasonLeave", "@Status", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentCode, this.m_GroupCode, this.m_CandidateCode, this.m_EnrollNumber, this.m_FirstName, this.m_LastName, this.m_Alias, this.m_Sex, this.m_Marriage, this.m_BirthdayDay, this.m_BirthdayMonth, this.m_BirthdayYear, this.m_BirthPlace, this.m_MainAddress, this.m_ContactAddress, this.m_CellPhone, this.m_HomePhone, this.m_Email, this.m_Skype, this.m_Yahoo, this.m_Facebook, this.m_Nationality, this.m_Ethnic, this.m_Religion, this.m_Education, this.m_Language, this.m_Informatic, this.m_Professional, this.m_Position, this.m_GroupRateCode, this.m_School, this.m_IDCard, this.m_IDCardDate, this.m_IDCardPlace, this.m_IsTest, this.m_TestTime, this.m_TestFromDate, this.m_TestToDate, this.m_TestSalary, this.m_BeginDate, this.m_IsOffWork, this.m_EndDate, this.m_Health, this.m_Height, this.m_Weight, this.m_PayForm, this.m_PayMoney, this.m_MinimumSalary, this.m_RankSalary, this.m_StepSalary, this.m_CoefficientSalary, this.m_DateSalary, this.m_BasicSalary, this.m_SalaryPeriod1, this.m_InsuranceSalary, this.m_IsFixedSalary, this.m_Allowance1, this.m_Allowance2, this.m_Allowance3, this.m_Allowance4, this.m_IsSocialInsurance, this.m_IsHealthInsurance, this.m_IsUnemploymentInsurance, this.m_IsUnionMoney, this.m_IncomeTaxCode, this.m_IsMandateTax, this.m_IsYourSelfTax, this.m_IsSecondIncomeTax, this.m_PercentSecondIncomeTax, this.m_ResidenceType, this.m_BankCode, this.m_BankDate, this.m_BankName, this.m_BankBranch, this.m_BankCity, this.m_BankAddress, this.m_LaborCode, this.m_LaborDate, this.m_LaborPlace, this.m_IsUnion, this.m_UnionCode, this.m_UnionDate, this.m_UnionPlace, this.m_IsParty, this.m_PartyCode, this.m_PartyDate, this.m_PartyPlace, this.m_InsuranceCode, this.m_InsuranceDate, this.m_InsurancePlace, this.m_HealthInsuranceCode, this.m_HealthInsuranceFromDate, this.m_HealthInsuranceToDate, this.m_ContractCode, this.m_ContractType, this.m_ContractSignDate, this.m_ContractFromDate, this.m_ContractToDate, this.m_Province, this.m_Hospital, this.m_MilitaryCode, this.m_MilitaryFromDate, this.m_MilitaryToDate, this.m_MilitaryPosition, this.m_PassportCode, this.m_PassportFromDate, this.m_PassportToDate, this.m_ReasonLeave, this.m_Status, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_EMPLOYEE_Insert", strArrays1, mEmployeeCode);
        }

        public string Insert(string EmployeeCode, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string CandidateCode, string EnrollNumber, string FirstName, string LastName, string Alias, bool Sex, string Marriage, int BirthdayDay, int BirthdayMonth, int BirthdayYear, string BirthPlace, string MainAddress, string ContactAddress, string CellPhone, string HomePhone, string Email, string Skype, string Yahoo, string Facebook, string Nationality, string Ethnic, string Religion, string Education, string Language, string Informatic, string Professional, string Position, string GroupRateCode, string School, string IDCard, DateTime IDCardDate, string IDCardPlace, bool IsTest, string TestTime, DateTime TestFromDate, DateTime TestToDate, decimal TestSalary, DateTime BeginDate, bool IsOffWork, DateTime EndDate, string Health, double Height, double Weight, decimal MinimumSalary, string RankSalary, int StepSalary, double CoefficientSalary, DateTime DateSalary, decimal BasicSalary, decimal SalaryPeriod1, decimal InsuranceSalary, bool IsFixedSalary, decimal Allowance1, decimal Allowance2, decimal Allowance3, decimal Allowance4, bool IsSocialInsurance, bool IsHealthInsurance, bool IsUnemploymentInsurance, bool IsUnionMoney, string IncomeTaxCode, bool IsMandateTax, bool IsYourSelfTax, bool IsSecondIncomeTax, double PercentSecondIncomeTax, int ResidenceType, string BankCode, DateTime BankDate, string BankName, string BankBranch, string BankCity, string BankAddress, string LaborCode, DateTime LaborDate, string LaborPlace, bool IsUnion, string UnionCode, DateTime UnionDate, string UnionPlace, bool IsParty, string PartyCode, DateTime PartyDate, string PartyPlace, string InsuranceCode, DateTime InsuranceDate, string InsurancePlace, string HealthInsuranceCode, DateTime HealthInsuranceFromDate, DateTime HealthInsuranceToDate, string ContractCode, string ContractType, DateTime ContractSignDate, DateTime ContractFromDate, DateTime ContractToDate, string Province, string Hospital, string MilitaryCode, DateTime MilitaryFromDate, DateTime MilitaryToDate, string MilitaryPosition, string PassportCode, DateTime PassportFromDate, DateTime PassportToDate, string ReasonLeave, int Status, string Description)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@CandidateCode", "@EnrollNumber", "@FirstName", "@LastName", "@Alias", "@Sex", "@Marriage", "@BirthdayDay", "@BirthdayMonth", "@BirthdayYear", "@BirthPlace", "@MainAddress", "@ContactAddress", "@CellPhone", "@HomePhone", "@Email", "@Skype", "@Yahoo", "@Facebook", "@Nationality", "@Ethnic", "@Religion", "@Education", "@Language", "@Informatic", "@Professional", "@Position", "@GroupRateCode", "@School", "@IDCard", "@IDCardDate", "@IDCardPlace", "@IsTest", "@TestTime", "@TestFromDate", "@TestToDate", "@TestSalary", "@BeginDate", "@IsOffWork", "@EndDate", "@Health", "@Height", "@Weight", "@PayForm", "@PayMoney", "@MinimumSalary", "@RankSalary", "@StepSalary", "@CoefficientSalary", "@DateSalary", "@BasicSalary", "@SalaryPeriod1", "@InsuranceSalary", "@IsFixedSalary", "@Allowance1", "@Allowance2", "@Allowance3", "@Allowance4", "@IsSocialInsurance", "@IsHealthInsurance", "@IsUnemploymentInsurance", "@IsUnionMoney", "@IncomeTaxCode", "@IsMandateTax", "@IsYourSelfTax", "@IsSecondIncomeTax", "@PercentSecondIncomeTax", "@ResidenceType", "@BankCode", "@BankDate", "@BankName", "@BankBranch", "@BankCity", "@BankAddress", "@LaborCode", "@LaborDate", "@LaborPlace", "@IsUnion", "@UnionCode", "@UnionDate", "@UnionPlace", "@IsParty", "@PartyCode", "@PartyDate", "@PartyPlace", "@InsuranceCode", "@InsuranceDate", "@InsurancePlace", "@HealthInsuranceCode", "@HealthInsuranceFromDate", "@HealthInsuranceToDate", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate", "@Province", "@Hospital", "@MilitaryCode", "@MilitaryFromDate", "@MilitaryToDate", "@MilitaryPosition", "@PassportCode", "@PassportFromDate", "@PassportToDate", "@ReasonLeave", "@Status", "@Description" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, CandidateCode, EnrollNumber, FirstName, LastName, Alias, Sex, Marriage, BirthdayDay, BirthdayMonth, BirthdayYear, BirthPlace, MainAddress, ContactAddress, CellPhone, HomePhone, Email, Skype, Yahoo, Facebook, Nationality, Ethnic, Religion, Education, Language, Informatic, Professional, Position, GroupRateCode, School, IDCard, IDCardDate, IDCardPlace, IsTest, TestTime, TestFromDate, TestToDate, TestSalary, BeginDate, IsOffWork, EndDate, Health, Height, Weight, this.PayForm, this.PayMoney, MinimumSalary, RankSalary, StepSalary, CoefficientSalary, DateSalary, BasicSalary, SalaryPeriod1, InsuranceSalary, IsFixedSalary, Allowance1, Allowance2, Allowance3, Allowance4, IsSocialInsurance, IsHealthInsurance, IsUnemploymentInsurance, IsUnionMoney, IncomeTaxCode, IsMandateTax, IsYourSelfTax, IsSecondIncomeTax, PercentSecondIncomeTax, ResidenceType, BankCode, BankDate, BankName, BankBranch, BankCity, BankAddress, LaborCode, LaborDate, LaborPlace, IsUnion, UnionCode, UnionDate, UnionPlace, IsParty, PartyCode, PartyDate, PartyPlace, InsuranceCode, InsuranceDate, InsurancePlace, MilitaryCode, MilitaryFromDate, HealthInsuranceCode, HealthInsuranceFromDate, HealthInsuranceToDate, ContractCode, ContractType, ContractSignDate, ContractFromDate, ContractToDate, Province, Hospital, MilitaryToDate, MilitaryPosition, PassportCode, PassportFromDate, PassportToDate, ReasonLeave, Status, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_Insert", strArrays1, employeeCode);
        }

        public string Insert(SqlConnection myConnection, string EmployeeCode, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string CandidateCode, string EnrollNumber, string FirstName, string LastName, string Alias, bool Sex, string Marriage, int BirthdayDay, int BirthdayMonth, int BirthdayYear, string BirthPlace, string MainAddress, string ContactAddress, string CellPhone, string HomePhone, string Email, string Skype, string Yahoo, string Facebook, string Nationality, string Ethnic, string Religion, string Education, string Language, string Informatic, string Professional, string Position, string GroupRateCode, string School, string IDCard, DateTime IDCardDate, string IDCardPlace, bool IsTest, string TestTime, DateTime TestFromDate, DateTime TestToDate, decimal TestSalary, DateTime BeginDate, bool IsOffWork, DateTime EndDate, string Health, double Height, double Weight, decimal MinimumSalary, string RankSalary, int StepSalary, double CoefficientSalary, DateTime DateSalary, decimal BasicSalary, decimal SalaryPeriod1, decimal InsuranceSalary, bool IsFixedSalary, decimal Allowance1, decimal Allowance2, decimal Allowance3, decimal Allowance4, bool IsSocialInsurance, bool IsHealthInsurance, bool IsUnemploymentInsurance, bool IsUnionMoney, string IncomeTaxCode, bool IsMandateTax, bool IsYourSelfTax, bool IsSecondIncomeTax, double PercentSecondIncomeTax, int ResidenceType, string BankCode, DateTime BankDate, string BankName, string BankBranch, string BankCity, string BankAddress, string LaborCode, DateTime LaborDate, string LaborPlace, bool IsUnion, string UnionCode, DateTime UnionDate, string UnionPlace, bool IsParty, string PartyCode, DateTime PartyDate, string PartyPlace, string InsuranceCode, DateTime InsuranceDate, string InsurancePlace, string HealthInsuranceCode, DateTime HealthInsuranceFromDate, DateTime HealthInsuranceToDate, string ContractCode, string ContractType, DateTime ContractSignDate, DateTime ContractFromDate, DateTime ContractToDate, string Province, string Hospital, string MilitaryCode, DateTime MilitaryFromDate, DateTime MilitaryToDate, string MilitaryPosition, string PassportCode, DateTime PassportFromDate, DateTime PassportToDate, string ReasonLeave, int Status, string Description)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@CandidateCode", "@EnrollNumber", "@FirstName", "@LastName", "@Alias", "@Sex", "@Marriage", "@BirthdayDay", "@BirthdayMonth", "@BirthdayYear", "@BirthPlace", "@MainAddress", "@ContactAddress", "@CellPhone", "@HomePhone", "@Email", "@Skype", "@Yahoo", "@Facebook", "@Nationality", "@Ethnic", "@Religion", "@Education", "@Language", "@Informatic", "@Professional", "@Position", "@GroupRateCode", "@School", "@IDCard", "@IDCardDate", "@IDCardPlace", "@IsTest", "@TestTime", "@TestFromDate", "@TestToDate", "@TestSalary", "@BeginDate", "@IsOffWork", "@EndDate", "@Health", "@Height", "@Weight", "@PayForm", "@PayMoney", "@MinimumSalary", "@RankSalary", "@StepSalary", "@CoefficientSalary", "@DateSalary", "@BasicSalary", "@SalaryPeriod1", "@InsuranceSalary", "@IsFixedSalary", "@Allowance1", "@Allowance2", "@Allowance3", "@Allowance4", "@IsSocialInsurance", "@IsHealthInsurance", "@IsUnemploymentInsurance", "@IsUnionMoney", "@IncomeTaxCode", "@IsMandateTax", "@IsYourSelfTax", "@IsSecondIncomeTax", "@PercentSecondIncomeTax", "@ResidenceType", "@BankCode", "@BankDate", "@BankName", "@BankBranch", "@BankCity", "@BankAddress", "@LaborCode", "@LaborDate", "@LaborPlace", "@IsUnion", "@UnionCode", "@UnionDate", "@UnionPlace", "@IsParty", "@PartyCode", "@PartyDate", "@PartyPlace", "@InsuranceCode", "@InsuranceDate", "@InsurancePlace", "@HealthInsuranceCode", "@HealthInsuranceFromDate", "@HealthInsuranceToDate", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate", "@Province", "@Hospital", "@MilitaryCode", "@MilitaryFromDate", "@MilitaryToDate", "@MilitaryPosition", "@PassportCode", "@PassportFromDate", "@PassportToDate", "@ReasonLeave", "@Status", "@Description" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, CandidateCode, EnrollNumber, FirstName, LastName, Alias, Sex, Marriage, BirthdayDay, BirthdayMonth, BirthdayYear, BirthPlace, MainAddress, ContactAddress, CellPhone, HomePhone, Email, Skype, Yahoo, Facebook, Nationality, Ethnic, Religion, Education, Language, Informatic, Professional, Position, GroupRateCode, School, IDCard, IDCardDate, IDCardPlace, IsTest, TestTime, TestFromDate, TestToDate, TestSalary, BeginDate, IsOffWork, EndDate, Health, Height, Weight, this.PayForm, this.PayMoney, MinimumSalary, RankSalary, StepSalary, CoefficientSalary, DateSalary, BasicSalary, SalaryPeriod1, InsuranceSalary, IsFixedSalary, Allowance1, Allowance2, Allowance3, Allowance4, IsSocialInsurance, IsHealthInsurance, IsUnemploymentInsurance, IsUnionMoney, IncomeTaxCode, IsMandateTax, IsYourSelfTax, IsSecondIncomeTax, PercentSecondIncomeTax, ResidenceType, BankCode, BankDate, BankName, BankBranch, BankCity, BankAddress, LaborCode, LaborDate, LaborPlace, IsUnion, UnionCode, UnionDate, UnionPlace, IsParty, PartyCode, PartyDate, PartyPlace, InsuranceCode, InsuranceDate, InsurancePlace, MilitaryCode, MilitaryFromDate, HealthInsuranceCode, HealthInsuranceFromDate, HealthInsuranceToDate, ContractCode, ContractType, ContractSignDate, ContractFromDate, ContractToDate, Province, Hospital, MilitaryToDate, MilitaryPosition, PassportCode, PassportFromDate, PassportToDate, ReasonLeave, Status, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_EMPLOYEE_Insert", strArrays1, employeeCode);
        }

        public string Insert(SqlTransaction myTransaction, string EmployeeCode, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string CandidateCode, string EnrollNumber, string FirstName, string LastName, string Alias, bool Sex, string Marriage, int BirthdayDay, int BirthdayMonth, int BirthdayYear, string BirthPlace, string MainAddress, string ContactAddress, string CellPhone, string HomePhone, string Email, string Skype, string Yahoo, string Facebook, string Nationality, string Ethnic, string Religion, string Education, string Language, string Informatic, string Professional, string Position, string GroupRateCode, string School, string IDCard, DateTime IDCardDate, string IDCardPlace, bool IsTest, string TestTime, DateTime TestFromDate, DateTime TestToDate, decimal TestSalary, DateTime BeginDate, bool IsOffWork, DateTime EndDate, string Health, double Height, double Weight, decimal MinimumSalary, string RankSalary, int StepSalary, double CoefficientSalary, DateTime DateSalary, decimal BasicSalary, decimal SalaryPeriod1, decimal InsuranceSalary, bool IsFixedSalary, decimal Allowance1, decimal Allowance2, decimal Allowance3, decimal Allowance4, bool IsSocialInsurance, bool IsHealthInsurance, bool IsUnemploymentInsurance, bool IsUnionMoney, string IncomeTaxCode, bool IsMandateTax, bool IsYourSelfTax, bool IsSecondIncomeTax, double PercentSecondIncomeTax, int ResidenceType, string BankCode, DateTime BankDate, string BankName, string BankBranch, string BankCity, string BankAddress, string LaborCode, DateTime LaborDate, string LaborPlace, bool IsUnion, string UnionCode, DateTime UnionDate, string UnionPlace, bool IsParty, string PartyCode, DateTime PartyDate, string PartyPlace, string InsuranceCode, DateTime InsuranceDate, string InsurancePlace, string HealthInsuranceCode, DateTime HealthInsuranceFromDate, DateTime HealthInsuranceToDate, string ContractCode, string ContractType, DateTime ContractSignDate, DateTime ContractFromDate, DateTime ContractToDate, string Province, string Hospital, string MilitaryCode, DateTime MilitaryFromDate, DateTime MilitaryToDate, string MilitaryPosition, string PassportCode, DateTime PassportFromDate, DateTime PassportToDate, string ReasonLeave, int Status, string Description)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@CandidateCode", "@EnrollNumber", "@FirstName", "@LastName", "@Alias", "@Sex", "@Marriage", "@BirthdayDay", "@BirthdayMonth", "@BirthdayYear", "@BirthPlace", "@MainAddress", "@ContactAddress", "@CellPhone", "@HomePhone", "@Email", "@Skype", "@Yahoo", "@Facebook", "@Nationality", "@Ethnic", "@Religion", "@Education", "@Language", "@Informatic", "@Professional", "@Position", "@GroupRateCode", "@School", "@IDCard", "@IDCardDate", "@IDCardPlace", "@IsTest", "@TestTime", "@TestFromDate", "@TestToDate", "@TestSalary", "@BeginDate", "@IsOffWork", "@EndDate", "@Health", "@Height", "@Weight", "@PayForm", "@PayMoney", "@MinimumSalary", "@RankSalary", "@StepSalary", "@CoefficientSalary", "@DateSalary", "@BasicSalary", "@SalaryPeriod1", "@InsuranceSalary", "@IsFixedSalary", "@Allowance1", "@Allowance2", "@Allowance3", "@Allowance4", "@IsSocialInsurance", "@IsHealthInsurance", "@IsUnemploymentInsurance", "@IsUnionMoney", "@IncomeTaxCode", "@IsMandateTax", "@IsYourSelfTax", "@IsSecondIncomeTax", "@PercentSecondIncomeTax", "@ResidenceType", "@BankCode", "@BankDate", "@BankName", "@BankBranch", "@BankCity", "@BankAddress", "@LaborCode", "@LaborDate", "@LaborPlace", "@IsUnion", "@UnionCode", "@UnionDate", "@UnionPlace", "@IsParty", "@PartyCode", "@PartyDate", "@PartyPlace", "@InsuranceCode", "@InsuranceDate", "@InsurancePlace", "@HealthInsuranceCode", "@HealthInsuranceFromDate", "@HealthInsuranceToDate", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate", "@Province", "@Hospital", "@MilitaryCode", "@MilitaryFromDate", "@MilitaryToDate", "@MilitaryPosition", "@PassportCode", "@PassportFromDate", "@PassportToDate", "@ReasonLeave", "@Status", "@Description" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, CandidateCode, EnrollNumber, FirstName, LastName, Alias, Sex, Marriage, BirthdayDay, BirthdayMonth, BirthdayYear, BirthPlace, MainAddress, ContactAddress, CellPhone, HomePhone, Email, Skype, Yahoo, Facebook, Nationality, Ethnic, Religion, Education, Language, Informatic, Professional, Position, GroupRateCode, School, IDCard, IDCardDate, IDCardPlace, IsTest, TestTime, TestFromDate, TestToDate, TestSalary, BeginDate, IsOffWork, EndDate, Health, Height, Weight, this.PayForm, this.PayMoney, MinimumSalary, RankSalary, StepSalary, CoefficientSalary, DateSalary, BasicSalary, SalaryPeriod1, InsuranceSalary, IsFixedSalary, Allowance1, Allowance2, Allowance3, Allowance4, IsSocialInsurance, IsHealthInsurance, IsUnemploymentInsurance, IsUnionMoney, IncomeTaxCode, IsMandateTax, IsYourSelfTax, IsSecondIncomeTax, PercentSecondIncomeTax, ResidenceType, BankCode, BankDate, BankName, BankBranch, BankCity, BankAddress, LaborCode, LaborDate, LaborPlace, IsUnion, UnionCode, UnionDate, UnionPlace, IsParty, PartyCode, PartyDate, PartyPlace, InsuranceCode, InsuranceDate, InsurancePlace, MilitaryCode, MilitaryFromDate, HealthInsuranceCode, HealthInsuranceFromDate, HealthInsuranceToDate, ContractCode, ContractType, ContractSignDate, ContractFromDate, ContractToDate, Province, Hospital, MilitaryToDate, MilitaryPosition, PassportCode, PassportFromDate, PassportToDate, ReasonLeave, Status, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_EMPLOYEE_Insert", strArrays1, employeeCode);
        }

        public string NewID()
        {
            clsDocumentNumberOption _clsDocumentNumberOption = new clsDocumentNumberOption("EmployeeCode", "NV", "");
            return _clsDocumentNumberOption.GenCode("HRM_EMPLOYEE", "EmployeeCode");
        }

        public DataTable Search(string Key, int Level, string Code, DateTime DayFirstMonth, DateTime DayEndMonth)
        {
            string[] strArrays = new string[] { "@Key", "@Level", "@Code", "@DayFirstMonth", "@DayEndMonth" };
            string[] strArrays1 = strArrays;
            object[] key = new object[] { Key, Level, Code, DayFirstMonth, DayEndMonth };
            return (new SqlHelper()).ExecuteDataTable("HRM_EMPLOYEE_Search", strArrays1, key);
        }

        public void SetData(string EmployeeCode, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string CandidateCode, string EnrollNumber, string FirstName, string LastName, string Alias, bool Sex, string Marriage, int BirthdayDay, int BirthdayMonth, int BirthdayYear, string BirthPlace, string MainAddress, string ContactAddress, string CellPhone, string HomePhone, string Email, string Skype, string Yahoo, string Facebook, string Nationality, string Ethnic, string Religion, string Education, string Language, string Informatic, string Professional, string Position, string GroupRateCode, string School, string IDCard, DateTime IDCardDate, string IDCardPlace, bool IsTest, string TestTime, DateTime TestFromDate, DateTime TestToDate, decimal TestSalary, DateTime BeginDate, bool IsOffWork, DateTime EndDate, string Health, double Height, double Weight, int PayForm, decimal PayMoney, decimal MinimumSalary, string RankSalary, int StepSalary, double CoefficientSalary, DateTime DateSalary, decimal BasicSalary, decimal SalaryPeriod1, decimal InsuranceSalary, bool IsFixedSalary, decimal Allowance1, decimal Allowance2, decimal Allowance3, decimal Allowance4, bool IsSocialInsurance, bool IsHealthInsurance, bool IsUnemploymentIsurance, bool IsUnionMoney, string IncomeTaxCode, bool IsMandateTax, bool IsYourSelfTax, bool IsSecondIncomeTax, double PercentSecondIncomeTax, int ResidenceType, string BankCode, DateTime BankDate, string BankName, string BankBranch, string BankCity, string BankAddress, string LaborCode, DateTime LaborDate, string LaborPlace, bool IsUnion, string UnionCode, DateTime UnionDate, string UnionPlace, bool IsParty, string PartyCode, DateTime PartyDate, string PartyPlace, string InsuranceCode, DateTime InsuranceDate, string InsurancePlace, string HealthInsuranceCode, DateTime HealthInsuranceFromDate, DateTime HealthInsuranceToDate, string ContractCode, string ContractType, DateTime ContractSignDate, DateTime ContractFromDate, DateTime ContractToDate, string Province, string Hospital, string MilitaryCode, DateTime MilitaryFromDate, DateTime MilitaryToDate, string MilitaryPosition, string PassportCode, DateTime PassportFromDate, DateTime PassportToDate, string ReasonLeave, int Status, string Description)
        {
            this.m_EmployeeCode = EmployeeCode;
            this.m_SubsidiaryCode = SubsidiaryCode;
            this.m_BranchCode = BranchCode;
            this.m_DepartmentCode = DepartmentCode;
            this.m_GroupCode = GroupCode;
            this.m_CandidateCode = CandidateCode;
            this.m_EnrollNumber = EnrollNumber;
            this.m_FirstName = FirstName;
            this.m_LastName = LastName;
            this.m_Alias = Alias;
            this.m_Sex = Sex;
            this.m_Marriage = Marriage;
            this.m_BirthdayDay = BirthdayDay;
            this.m_BirthdayMonth = BirthdayMonth;
            this.m_BirthdayYear = BirthdayYear;
            this.m_BirthPlace = BirthPlace;
            this.m_MainAddress = MainAddress;
            this.m_ContactAddress = ContactAddress;
            this.m_CellPhone = CellPhone;
            this.m_HomePhone = HomePhone;
            this.m_Email = Email;
            this.m_Skype = Skype;
            this.m_Yahoo = Yahoo;
            this.m_Facebook = Facebook;
            this.m_Nationality = Nationality;
            this.m_Ethnic = Ethnic;
            this.m_Religion = Religion;
            this.m_Education = Education;
            this.m_Language = Language;
            this.m_Informatic = Informatic;
            this.m_Professional = Professional;
            this.m_Position = Position;
            this.m_GroupRateCode = GroupRateCode;
            this.m_School = School;
            this.m_IDCard = IDCard;
            this.m_IDCardDate = IDCardDate;
            this.m_IDCardPlace = IDCardPlace;
            this.m_IsTest = IsTest;
            this.m_TestTime = TestTime;
            this.m_TestFromDate = TestFromDate;
            this.m_TestToDate = TestToDate;
            this.m_TestSalary = TestSalary;
            this.m_BeginDate = BeginDate;
            this.m_IsOffWork = IsOffWork;
            this.m_EndDate = EndDate;
            this.m_Health = Health;
            this.m_Height = Height;
            this.m_Weight = Weight;
            this.m_PayForm = PayForm;
            this.m_PayMoney = PayMoney;
            this.m_MinimumSalary = MinimumSalary;
            this.m_RankSalary = RankSalary;
            this.m_StepSalary = StepSalary;
            this.m_CoefficientSalary = CoefficientSalary;
            this.m_DateSalary = DateSalary;
            this.m_BasicSalary = BasicSalary;
            this.m_SalaryPeriod1 = SalaryPeriod1;
            this.m_InsuranceSalary = InsuranceSalary;
            this.m_IsFixedSalary = IsFixedSalary;
            this.m_Allowance1 = Allowance1;
            this.m_Allowance2 = Allowance2;
            this.m_Allowance3 = Allowance3;
            this.m_Allowance4 = Allowance4;
            this.m_IsSocialInsurance = IsSocialInsurance;
            this.m_IsHealthInsurance = IsHealthInsurance;
            this.m_IsUnemploymentInsurance = IsUnemploymentIsurance;
            this.m_IsUnionMoney = IsUnionMoney;
            this.m_IncomeTaxCode = IncomeTaxCode;
            this.m_IsMandateTax = IsMandateTax;
            this.m_IsYourSelfTax = IsYourSelfTax;
            this.m_IsSecondIncomeTax = IsSecondIncomeTax;
            this.m_PercentSecondIncomeTax = PercentSecondIncomeTax;
            this.m_ResidenceType = ResidenceType;
            this.m_BankCode = BankCode;
            this.m_BankDate = BankDate;
            this.m_BankName = BankName;
            this.m_BankBranch = BankBranch;
            this.m_BankCity = BankCity;
            this.m_BankAddress = BankAddress;
            this.m_LaborCode = LaborCode;
            this.m_LaborDate = LaborDate;
            this.m_LaborPlace = LaborPlace;
            this.m_IsUnion = IsUnion;
            this.m_UnionCode = UnionCode;
            this.m_UnionDate = UnionDate;
            this.m_UnionPlace = UnionPlace;
            this.m_IsParty = IsParty;
            this.m_PartyCode = PartyCode;
            this.m_PartyDate = PartyDate;
            this.m_PartyPlace = PartyPlace;
            this.m_InsuranceCode = InsuranceCode;
            this.m_InsuranceDate = InsuranceDate;
            this.m_InsurancePlace = InsurancePlace;
            this.m_HealthInsuranceCode = HealthInsuranceCode;
            this.m_HealthInsuranceFromDate = HealthInsuranceFromDate;
            this.m_HealthInsuranceToDate = HealthInsuranceToDate;
            this.m_ContractCode = ContractCode;
            this.m_ContractType = ContractType;
            this.m_ContractSignDate = ContractSignDate;
            this.m_ContractFromDate = ContractFromDate;
            this.m_ContractToDate = ContractToDate;
            this.m_Province = Province;
            this.m_Hospital = Hospital;
            this.m_MilitaryCode = MilitaryCode;
            this.m_MilitaryFromDate = MilitaryFromDate;
            this.m_MilitaryToDate = MilitaryToDate;
            this.m_MilitaryPosition = MilitaryPosition;
            this.m_PassportCode = PassportCode;
            this.m_PassportFromDate = PassportFromDate;
            this.m_PassportToDate = PassportToDate;
            this.m_ReasonLeave = ReasonLeave;
            this.m_Status = Status;
            this.m_Description = Description;
        }

        public string Update()
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@CandidateCode", "@EnrollNumber", "@FirstName", "@LastName", "@Alias", "@Sex", "@Marriage", "@BirthdayDay", "@BirthdayMonth", "@BirthdayYear", "@BirthPlace", "@MainAddress", "@ContactAddress", "@CellPhone", "@HomePhone", "@Email", "@Skype", "@Yahoo", "@Facebook", "@Nationality", "@Ethnic", "@Religion", "@Education", "@Language", "@Informatic", "@Professional", "@Position", "@GroupRateCode", "@School", "@IDCard", "@IDCardDate", "@IDCardPlace", "@IsTest", "@TestTime", "@TestFromDate", "@TestToDate", "@TestSalary", "@BeginDate", "@IsOffWork", "@EndDate", "@Health", "@Height", "@Weight", "@PayForm", "@PayMoney", "@MinimumSalary", "@RankSalary", "@StepSalary", "@CoefficientSalary", "@DateSalary", "@BasicSalary", "@SalaryPeriod1", "@InsuranceSalary", "@IsFixedSalary", "@Allowance1", "@Allowance2", "@Allowance3", "@Allowance4", "@IsSocialInsurance", "@IsHealthInsurance", "@IsUnemploymentInsurance", "@IsUnionMoney", "@IncomeTaxCode", "@IsMandateTax", "@IsYourSelfTax", "@IsSecondIncomeTax", "@PercentSecondIncomeTax", "@ResidenceType", "@BankCode", "@BankDate", "@BankName", "@BankBranch", "@BankCity", "@BankAddress", "@LaborCode", "@LaborDate", "@LaborPlace", "@IsUnion", "@UnionCode", "@UnionDate", "@UnionPlace", "@IsParty", "@PartyCode", "@PartyDate", "@PartyPlace", "@InsuranceCode", "@InsuranceDate", "@InsurancePlace", "@HealthInsuranceCode", "@HealthInsuranceFromDate", "@HealthInsuranceToDate", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate", "@Province", "@Hospital", "@MilitaryCode", "@MilitaryFromDate", "@MilitaryToDate", "@MilitaryPosition", "@PassportCode", "@PassportFromDate", "@PassportToDate", "@ReasonLeave", "@Status", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentCode, this.m_GroupCode, this.m_CandidateCode, this.m_EnrollNumber, this.m_FirstName, this.m_LastName, this.m_Alias, this.m_Sex, this.m_Marriage, this.m_BirthdayDay, this.m_BirthdayMonth, this.m_BirthdayYear, this.m_BirthPlace, this.m_MainAddress, this.m_ContactAddress, this.m_CellPhone, this.m_HomePhone, this.m_Email, this.m_Skype, this.m_Yahoo, this.m_Facebook, this.m_Nationality, this.m_Ethnic, this.m_Religion, this.m_Education, this.m_Language, this.m_Informatic, this.m_Professional, this.m_Position, this.m_GroupRateCode, this.m_School, this.m_IDCard, this.m_IDCardDate, this.m_IDCardPlace, this.m_IsTest, this.m_TestTime, this.m_TestFromDate, this.m_TestToDate, this.m_TestSalary, this.m_BeginDate, this.m_IsOffWork, this.m_EndDate, this.m_Health, this.m_Height, this.m_Weight, this.m_PayForm, this.m_PayMoney, this.m_MinimumSalary, this.m_RankSalary, this.m_StepSalary, this.m_CoefficientSalary, this.m_DateSalary, this.m_BasicSalary, this.m_SalaryPeriod1, this.m_InsuranceSalary, this.m_IsFixedSalary, this.m_Allowance1, this.m_Allowance2, this.m_Allowance3, this.m_Allowance4, this.m_IsSocialInsurance, this.m_IsHealthInsurance, this.m_IsUnemploymentInsurance, this.m_IsUnionMoney, this.m_IncomeTaxCode, this.m_IsMandateTax, this.m_IsYourSelfTax, this.m_IsSecondIncomeTax, this.m_PercentSecondIncomeTax, this.m_ResidenceType, this.m_BankCode, this.m_BankDate, this.m_BankName, this.m_BankBranch, this.m_BankCity, this.m_BankAddress, this.m_LaborCode, this.m_LaborDate, this.m_LaborPlace, this.m_IsUnion, this.m_UnionCode, this.m_UnionDate, this.m_UnionPlace, this.m_IsParty, this.m_PartyCode, this.m_PartyDate, this.m_PartyPlace, this.m_InsuranceCode, this.m_InsuranceDate, this.m_InsurancePlace, this.m_HealthInsuranceCode, this.m_HealthInsuranceFromDate, this.m_HealthInsuranceToDate, this.m_ContractCode, this.m_ContractType, this.m_ContractSignDate, this.m_ContractFromDate, this.m_ContractToDate, this.m_Province, this.m_Hospital, this.m_MilitaryCode, this.m_MilitaryFromDate, this.m_MilitaryToDate, this.m_MilitaryPosition, this.m_PassportCode, this.m_PassportFromDate, this.m_PassportToDate, this.m_ReasonLeave, this.m_Status, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_Update", strArrays1, mEmployeeCode);
        }

        public string Update(SqlTransaction myTransaction)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@CandidateCode", "@EnrollNumber", "@FirstName", "@LastName", "@Alias", "@Sex", "@Marriage", "@BirthdayDay", "@BirthdayMonth", "@BirthdayYear", "@BirthPlace", "@MainAddress", "@ContactAddress", "@CellPhone", "@HomePhone", "@Email", "@Skype", "@Yahoo", "@Facebook", "@Nationality", "@Ethnic", "@Religion", "@Education", "@Language", "@Informatic", "@Professional", "@Position", "@GroupRateCode", "@School", "@IDCard", "@IDCardDate", "@IDCardPlace", "@IsTest", "@TestTime", "@TestFromDate", "@TestToDate", "@TestSalary", "@BeginDate", "@IsOffWork", "@EndDate", "@Health", "@Height", "@Weight", "@PayForm", "@PayMoney", "@MinimumSalary", "@RankSalary", "@StepSalary", "@CoefficientSalary", "@DateSalary", "@BasicSalary", "@SalaryPeriod1", "@InsuranceSalary", "@IsFixedSalary", "@Allowance1", "@Allowance2", "@Allowance3", "@Allowance4", "@IsSocialInsurance", "@IsHealthInsurance", "@IsUnemploymentInsurance", "@IsUnionMoney", "@IncomeTaxCode", "@IsMandateTax", "@IsYourSelfTax", "@IsSecondIncomeTax", "@PercentSecondIncomeTax", "@ResidenceType", "@BankCode", "@BankDate", "@BankName", "@BankBranch", "@BankCity", "@BankAddress", "@LaborCode", "@LaborDate", "@LaborPlace", "@IsUnion", "@UnionCode", "@UnionDate", "@UnionPlace", "@IsParty", "@PartyCode", "@PartyDate", "@PartyPlace", "@InsuranceCode", "@InsuranceDate", "@InsurancePlace", "@HealthInsuranceCode", "@HealthInsuranceFromDate", "@HealthInsuranceToDate", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate", "@Province", "@Hospital", "@MilitaryCode", "@MilitaryFromDate", "@MilitaryToDate", "@MilitaryPosition", "@PassportCode", "@PassportFromDate", "@PassportToDate", "@ReasonLeave", "@Status", "@Description" };
            string[] strArrays1 = strArrays;
            object[] mEmployeeCode = new object[] { this.m_EmployeeCode, this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentCode, this.m_GroupCode, this.m_CandidateCode, this.m_EnrollNumber, this.m_FirstName, this.m_LastName, this.m_Alias, this.m_Sex, this.m_Marriage, this.m_BirthdayDay, this.m_BirthdayMonth, this.m_BirthdayYear, this.m_BirthPlace, this.m_MainAddress, this.m_ContactAddress, this.m_CellPhone, this.m_HomePhone, this.m_Email, this.m_Skype, this.m_Yahoo, this.m_Facebook, this.m_Nationality, this.m_Ethnic, this.m_Religion, this.m_Education, this.m_Language, this.m_Informatic, this.m_Professional, this.m_Position, this.m_GroupRateCode, this.m_School, this.m_IDCard, this.m_IDCardDate, this.m_IDCardPlace, this.m_IsTest, this.m_TestTime, this.m_TestFromDate, this.m_TestToDate, this.m_TestSalary, this.m_BeginDate, this.m_IsOffWork, this.m_EndDate, this.m_Health, this.m_Height, this.m_Weight, this.m_PayForm, this.m_PayMoney, this.m_MinimumSalary, this.m_RankSalary, this.m_StepSalary, this.m_CoefficientSalary, this.m_DateSalary, this.m_BasicSalary, this.m_SalaryPeriod1, this.m_InsuranceSalary, this.m_IsFixedSalary, this.m_Allowance1, this.m_Allowance2, this.m_Allowance3, this.m_Allowance4, this.m_IsSocialInsurance, this.m_IsHealthInsurance, this.m_IsUnemploymentInsurance, this.m_IsUnionMoney, this.m_IncomeTaxCode, this.m_IsMandateTax, this.m_IsYourSelfTax, this.m_IsSecondIncomeTax, this.m_PercentSecondIncomeTax, this.m_ResidenceType, this.m_BankCode, this.m_BankDate, this.m_BankName, this.m_BankBranch, this.m_BankCity, this.m_BankAddress, this.m_LaborCode, this.m_LaborDate, this.m_LaborPlace, this.m_IsUnion, this.m_UnionCode, this.m_UnionDate, this.m_UnionPlace, this.m_IsParty, this.m_PartyCode, this.m_PartyDate, this.m_PartyPlace, this.m_InsuranceCode, this.m_InsuranceDate, this.m_InsurancePlace, this.m_HealthInsuranceCode, this.m_HealthInsuranceFromDate, this.m_HealthInsuranceToDate, this.m_ContractCode, this.m_ContractType, this.m_ContractSignDate, this.m_ContractFromDate, this.m_ContractToDate, this.m_Province, this.m_Hospital, this.m_MilitaryCode, this.m_MilitaryFromDate, this.m_MilitaryToDate, this.m_MilitaryPosition, this.m_PassportCode, this.m_PassportFromDate, this.m_PassportToDate, this.m_ReasonLeave, this.m_Status, this.m_Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_EMPLOYEE_Update", strArrays1, mEmployeeCode);
        }

        public string Update(string EmployeeCode, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string CandidateCode, string EnrollNumber, string FirstName, string LastName, string Alias, bool Sex, string Marriage, int BirthdayDay, int BirthdayMonth, int BirthdayYear, string BirthPlace, string MainAddress, string ContactAddress, string CellPhone, string HomePhone, string Email, string Skype, string Yahoo, string Facebook, string Nationality, string Ethnic, string Religion, string Education, string Language, string Informatic, string Professional, string Position, string GroupRateCode, string School, string IDCard, DateTime IDCardDate, string IDCardPlace, bool IsTest, string TestTime, DateTime TestFromDate, DateTime TestToDate, decimal TestSalary, DateTime BeginDate, bool IsOffWork, DateTime EndDate, string Health, double Height, double Weight, decimal MinimumSalary, string RankSalary, int StepSalary, double CoefficientSalary, DateTime DateSalary, decimal BasicSalary, decimal SalaryPeriod1, decimal InsuranceSalary, bool IsFixedSalary, decimal Allowance1, decimal Allowance2, decimal Allowance3, decimal Allowance4, bool IsSocialInsurance, bool IsHealthInsurance, bool IsUnemploymentInsurance, bool IsUnionMoney, string IncomeTaxCode, bool IsMandateTax, bool IsYourSelfTax, bool IsSecondIncomeTax, double PercentSecondIncomeTax, int ResidenceType, string BankCode, DateTime BankDate, string BankName, string BankBranch, string BankCity, string BankAddress, string LaborCode, DateTime LaborDate, string LaborPlace, bool IsUnion, string UnionCode, DateTime UnionDate, string UnionPlace, bool IsParty, string PartyCode, DateTime PartyDate, string PartyPlace, string InsuranceCode, DateTime InsuranceDate, string InsurancePlace, string HealthInsuranceCode, DateTime HealthInsuranceFromDate, DateTime HealthInsuranceToDate, string ContractCode, string ContractType, DateTime ContractSignDate, DateTime ContractFromDate, DateTime ContractToDate, string Province, string Hospital, string MilitaryCode, DateTime MilitaryFromDate, DateTime MilitaryToDate, string MilitaryPosition, string PassportCode, DateTime PassportFromDate, DateTime PassportToDate, string ReasonLeave, int Status, string Description)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@CandidateCode", "@EnrollNumber", "@FirstName", "@LastName", "@Alias", "@Sex", "@Marriage", "@BirthdayDay", "@BirthdayMonth", "@BirthdayYear", "@BirthPlace", "@MainAddress", "@ContactAddress", "@CellPhone", "@HomePhone", "@Email", "@Skype", "@Yahoo", "@Facebook", "@Nationality", "@Ethnic", "@Religion", "@Education", "@Language", "@Informatic", "@Professional", "@Position", "@GroupRateCode", "@School", "@IDCard", "@IDCardDate", "@IDCardPlace", "@IsTest", "@TestTime", "@TestFromDate", "@TestToDate", "@TestSalary", "@BeginDate", "@IsOffWork", "@EndDate", "@Health", "@Height", "@Weight", "@PayForm", "@PayMoney", "@MinimumSalary", "@RankSalary", "@StepSalary", "@CoefficientSalary", "@DateSalary", "@BasicSalary", "@SalaryPeriod1", "@InsuranceSalary", "@IsFixedSalary", "@Allowance1", "@Allowance2", "@Allowance3", "@Allowance4", "@IsSocialInsurance", "@IsHealthInsurance", "@IsUnemploymentInsurance", "@IsUnionMoney", "@IncomeTaxCode", "@IsMandateTax", "@IsYourSelfTax", "@IsSecondIncomeTax", "@PercentSecondIncomeTax", "@ResidenceType", "@BankCode", "@BankDate", "@BankName", "@BankBranch", "@BankCity", "@BankAddress", "@LaborCode", "@LaborDate", "@LaborPlace", "@IsUnion", "@UnionCode", "@UnionDate", "@UnionPlace", "@IsParty", "@PartyCode", "@PartyDate", "@PartyPlace", "@InsuranceCode", "@InsuranceDate", "@InsurancePlace", "@HealthInsuranceCode", "@HealthInsuranceFromDate", "@HealthInsuranceToDate", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate", "@Province", "@Hospital", "@MilitaryCode", "@MilitaryFromDate", "@MilitaryToDate", "@MilitaryPosition", "@PassportCode", "@PassportFromDate", "@PassportToDate", "@ReasonLeave", "@Status", "@Description" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, CandidateCode, EnrollNumber, FirstName, LastName, Alias, Sex, Marriage, BirthdayDay, BirthdayMonth, BirthdayYear, BirthPlace, MainAddress, ContactAddress, CellPhone, HomePhone, Email, Skype, Yahoo, Facebook, Nationality, Ethnic, Religion, Education, Language, Informatic, Professional, Position, GroupRateCode, School, IDCard, IDCardDate, IDCardPlace, IsTest, TestTime, TestFromDate, TestToDate, TestSalary, BeginDate, IsOffWork, EndDate, Health, Height, Weight, this.PayForm, this.PayMoney, MinimumSalary, RankSalary, StepSalary, CoefficientSalary, DateSalary, BasicSalary, SalaryPeriod1, InsuranceSalary, IsFixedSalary, Allowance1, Allowance2, Allowance3, Allowance4, IsSocialInsurance, IsHealthInsurance, IsUnemploymentInsurance, IsUnionMoney, IncomeTaxCode, IsMandateTax, IsYourSelfTax, IsSecondIncomeTax, PercentSecondIncomeTax, ResidenceType, BankCode, BankDate, BankName, BankBranch, BankCity, BankAddress, LaborCode, LaborDate, LaborPlace, IsUnion, UnionCode, UnionDate, UnionPlace, IsParty, PartyCode, PartyDate, PartyPlace, InsuranceCode, InsuranceDate, InsurancePlace, MilitaryCode, MilitaryFromDate, HealthInsuranceCode, HealthInsuranceFromDate, HealthInsuranceToDate, ContractCode, ContractType, ContractSignDate, ContractFromDate, ContractToDate, Province, Hospital, MilitaryToDate, MilitaryPosition, PassportCode, PassportFromDate, PassportToDate, ReasonLeave, Status, Description };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_Update", strArrays1, employeeCode);
        }

        public string Update(SqlConnection myConnection, string EmployeeCode, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string CandidateCode, string EnrollNumber, string FirstName, string LastName, string Alias, bool Sex, string Marriage, int BirthdayDay, int BirthdayMonth, int BirthdayYear, string BirthPlace, string MainAddress, string ContactAddress, string CellPhone, string HomePhone, string Email, string Skype, string Yahoo, string Facebook, string Nationality, string Ethnic, string Religion, string Education, string Language, string Informatic, string Professional, string Position, string GroupRateCode, string School, string IDCard, DateTime IDCardDate, string IDCardPlace, bool IsTest, string TestTime, DateTime TestFromDate, DateTime TestToDate, decimal TestSalary, DateTime BeginDate, bool IsOffWork, DateTime EndDate, string Health, double Height, double Weight, decimal MinimumSalary, string RankSalary, int StepSalary, double CoefficientSalary, DateTime DateSalary, decimal BasicSalary, decimal InsuranceSalary, bool IsFixedSalary, decimal Allowance1, decimal Allowance2, decimal Allowance3, decimal Allowance4, bool IsSocialInsurance, bool IsHealthInsurance, bool IsUnemploymentInsurance, bool IsUnionMoney, string IncomeTaxCode, bool IsMandateTax, bool IsYourSelfTax, bool IsSecondIncomeTax, double PercentSecondIncomeTax, int ResidenceType, string BankCode, DateTime BankDate, string BankName, string BankBranch, string BankCity, string BankAddress, string LaborCode, DateTime LaborDate, string LaborPlace, bool IsUnion, string UnionCode, DateTime UnionDate, string UnionPlace, bool IsParty, string PartyCode, DateTime PartyDate, string PartyPlace, string InsuranceCode, DateTime InsuranceDate, string InsurancePlace, string HealthInsuranceCode, DateTime HealthInsuranceFromDate, DateTime HealthInsuranceToDate, string ContractCode, string ContractType, DateTime ContractSignDate, DateTime ContractFromDate, DateTime ContractToDate, string Province, string Hospital, string MilitaryCode, DateTime MilitaryFromDate, DateTime MilitaryToDate, string MilitaryPosition, string PassportCode, DateTime PassportFromDate, DateTime PassportToDate, string ReasonLeave, int Status, string Description)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@CandidateCode", "@EnrollNumber", "@FirstName", "@LastName", "@Alias", "@Sex", "@Marriage", "@BirthdayDay", "@BirthdayMonth", "@BirthdayYear", "@BirthPlace", "@MainAddress", "@ContactAddress", "@CellPhone", "@HomePhone", "@Email", "@Skype", "@Yahoo", "@Facebook", "@Nationality", "@Ethnic", "@Religion", "@Education", "@Language", "@Informatic", "@Professional", "@Position", "@GroupRateCode", "@School", "@IDCard", "@IDCardDate", "@IDCardPlace", "@IsTest", "@TestTime", "@TestFromDate", "@TestToDate", "@TestSalary", "@BeginDate", "@IsOffWork", "@EndDate", "@Health", "@Height", "@Weight", "@PayForm", "@PayMoney", "@MinimumSalary", "@RankSalary", "@StepSalary", "@CoefficientSalary", "@DateSalary", "@BasicSalary", "@SalaryPeriod1", "@InsuranceSalary", "@IsFixedSalary", "@Allowance1", "@Allowance2", "@Allowance3", "@Allowance4", "@IsSocialInsurance", "@IsHealthInsurance", "@IsUnemploymentInsurance", "@IsUnionMoney", "@IncomeTaxCode", "@IsMandateTax", "@IsYourSelfTax", "@IsSecondIncomeTax", "@PercentSecondIncomeTax", "@ResidenceType", "@BankCode", "@BankDate", "@BankName", "@BankBranch", "@BankCity", "@BankAddress", "@LaborCode", "@LaborDate", "@LaborPlace", "@IsUnion", "@UnionCode", "@UnionDate", "@UnionPlace", "@IsParty", "@PartyCode", "@PartyDate", "@PartyPlace", "@InsuranceCode", "@InsuranceDate", "@InsurancePlace", "@HealthInsuranceCode", "@HealthInsuranceFromDate", "@HealthInsuranceToDate", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate", "@Province", "@Hospital", "@MilitaryCode", "@MilitaryFromDate", "@MilitaryToDate", "@MilitaryPosition", "@PassportCode", "@PassportFromDate", "@PassportToDate", "@ReasonLeave", "@Status", "@Description" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, CandidateCode, EnrollNumber, FirstName, LastName, Alias, Sex, Marriage, BirthdayDay, BirthdayMonth, BirthdayYear, BirthPlace, MainAddress, ContactAddress, CellPhone, HomePhone, Email, Skype, Yahoo, Facebook, Nationality, Ethnic, Religion, Education, Language, Informatic, Professional, Position, GroupRateCode, School, IDCard, IDCardDate, IDCardPlace, IsTest, TestTime, TestFromDate, TestToDate, TestSalary, BeginDate, IsOffWork, EndDate, Health, Height, Weight, this.PayForm, this.PayMoney, MinimumSalary, RankSalary, StepSalary, CoefficientSalary, DateSalary, BasicSalary, this.SalaryPeriod1, InsuranceSalary, IsFixedSalary, Allowance1, Allowance2, Allowance3, Allowance4, IsSocialInsurance, IsHealthInsurance, IsUnemploymentInsurance, IsUnionMoney, IncomeTaxCode, IsMandateTax, IsYourSelfTax, IsSecondIncomeTax, PercentSecondIncomeTax, ResidenceType, BankCode, BankDate, BankName, BankBranch, BankCity, BankAddress, LaborCode, LaborDate, LaborPlace, IsUnion, UnionCode, UnionDate, UnionPlace, IsParty, PartyCode, PartyDate, PartyPlace, InsuranceCode, InsuranceDate, InsurancePlace, MilitaryCode, MilitaryFromDate, HealthInsuranceCode, HealthInsuranceFromDate, HealthInsuranceToDate, ContractCode, ContractType, ContractSignDate, ContractFromDate, ContractToDate, Province, Hospital, MilitaryToDate, MilitaryPosition, PassportCode, PassportFromDate, PassportToDate, ReasonLeave, Status, Description };
            return (new SqlHelper()).ExecuteNonQuery(myConnection, "HRM_EMPLOYEE_Update", strArrays1, employeeCode);
        }

        public string Update(SqlTransaction myTransaction, string EmployeeCode, string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string CandidateCode, string EnrollNumber, string FirstName, string LastName, string Alias, bool Sex, string Marriage, int BirthdayDay, int BirthdayMonth, int BirthdayYear, string BirthPlace, string MainAddress, string ContactAddress, string CellPhone, string HomePhone, string Email, string Skype, string Yahoo, string Facebook, string Nationality, string Ethnic, string Religion, string Education, string Language, string Informatic, string Professional, string Position, string GroupRateCode, string School, string IDCard, DateTime IDCardDate, string IDCardPlace, bool IsTest, string TestTime, DateTime TestFromDate, DateTime TestToDate, decimal TestSalary, DateTime BeginDate, bool IsOffWork, DateTime EndDate, string Health, double Height, double Weight, decimal MinimumSalary, string RankSalary, int StepSalary, double CoefficientSalary, DateTime DateSalary, decimal BasicSalary, decimal SalaryPeriod1, decimal InsuranceSalary, bool IsFixedSalary, decimal Allowance1, decimal Allowance2, decimal Allowance3, decimal Allowance4, bool IsSocialInsurance, bool IsHealthInsurance, bool IsUnemploymentInsurance, bool IsUnionMoney, string IncomeTaxCode, bool IsMandateTax, bool IsYourSelfTax, bool IsSecondIncomeTax, double PercentSecondIncomeTax, int ResidenceType, string BankCode, DateTime BankDate, string BankName, string BankBranch, string BankCity, string BankAddress, string LaborCode, DateTime LaborDate, string LaborPlace, bool IsUnion, string UnionCode, DateTime UnionDate, string UnionPlace, bool IsParty, string PartyCode, DateTime PartyDate, string PartyPlace, string InsuranceCode, DateTime InsuranceDate, string InsurancePlace, string HealthInsuranceCode, DateTime HealthInsuranceFromDate, DateTime HealthInsuranceToDate, string ContractCode, string ContractType, DateTime ContractSignDate, DateTime ContractFromDate, DateTime ContractToDate, string Province, string Hospital, string MilitaryCode, DateTime MilitaryFromDate, DateTime MilitaryToDate, string MilitaryPosition, string PassportCode, DateTime PassportFromDate, DateTime PassportToDate, string ReasonLeave, int Status, string Description)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@SubsidiaryCode", "@BranchCode", "@DepartmentCode", "@GroupCode", "@CandidateCode", "@EnrollNumber", "@FirstName", "@LastName", "@Alias", "@Sex", "@Marriage", "@BirthdayDay", "@BirthdayMonth", "@BirthdayYear", "@BirthPlace", "@MainAddress", "@ContactAddress", "@CellPhone", "@HomePhone", "@Email", "@Skype", "@Yahoo", "@Facebook", "@Nationality", "@Ethnic", "@Religion", "@Education", "@Language", "@Informatic", "@Professional", "@Position", "@GroupRateCode", "@School", "@IDCard", "@IDCardDate", "@IDCardPlace", "@IsTest", "@TestTime", "@TestFromDate", "@TestToDate", "@TestSalary", "@BeginDate", "@IsOffWork", "@EndDate", "@Health", "@Height", "@Weight", "@PayForm", "@PayMoney", "@MinimumSalary", "@RankSalary", "@StepSalary", "@CoefficientSalary", "@DateSalary", "@BasicSalary", "@SalaryPeriod1", "@InsuranceSalary", "@IsFixedSalary", "@Allowance1", "@Allowance2", "@Allowance3", "@Allowance4", "@IsSocialInsurance", "@IsHealthInsurance", "@IsUnemploymentInsurance", "@IsUnionMoney", "@IncomeTaxCode", "@IsMandateTax", "@IsYourSelfTax", "@IsSecondIncomeTax", "@PercentSecondIncomeTax", "@ResidenceType", "@BankCode", "@BankDate", "@BankName", "@BankBranch", "@BankCity", "@BankAddress", "@LaborCode", "@LaborDate", "@LaborPlace", "@IsUnion", "@UnionCode", "@UnionDate", "@UnionPlace", "@IsParty", "@PartyCode", "@PartyDate", "@PartyPlace", "@InsuranceCode", "@InsuranceDate", "@InsurancePlace", "@HealthInsuranceCode", "@HealthInsuranceFromDate", "@HealthInsuranceToDate", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate", "@Province", "@Hospital", "@MilitaryCode", "@MilitaryFromDate", "@MilitaryToDate", "@MilitaryPosition", "@PassportCode", "@PassportFromDate", "@PassportToDate", "@ReasonLeave", "@Status", "@Description" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, SubsidiaryCode, BranchCode, DepartmentCode, GroupCode, CandidateCode, EnrollNumber, FirstName, LastName, Alias, Sex, Marriage, BirthdayDay, BirthdayMonth, BirthdayYear, BirthPlace, MainAddress, ContactAddress, CellPhone, HomePhone, Email, Skype, Yahoo, Facebook, Nationality, Ethnic, Religion, Education, Language, Informatic, Professional, Position, GroupRateCode, School, IDCard, IDCardDate, IDCardPlace, IsTest, TestTime, TestFromDate, TestToDate, TestSalary, BeginDate, IsOffWork, EndDate, Health, Height, Weight, this.PayForm, this.PayMoney, MinimumSalary, RankSalary, StepSalary, CoefficientSalary, DateSalary, BasicSalary, SalaryPeriod1, InsuranceSalary, IsFixedSalary, Allowance1, Allowance2, Allowance3, Allowance4, IsSocialInsurance, IsHealthInsurance, IsUnemploymentInsurance, IsUnionMoney, IncomeTaxCode, IsMandateTax, IsYourSelfTax, IsSecondIncomeTax, PercentSecondIncomeTax, ResidenceType, BankCode, BankDate, BankName, BankBranch, BankCity, BankAddress, LaborCode, LaborDate, LaborPlace, IsUnion, UnionCode, UnionDate, UnionPlace, IsParty, PartyCode, PartyDate, PartyPlace, InsuranceCode, InsuranceDate, InsurancePlace, MilitaryCode, MilitaryFromDate, HealthInsuranceCode, HealthInsuranceFromDate, HealthInsuranceToDate, ContractCode, ContractType, ContractSignDate, ContractFromDate, ContractToDate, Province, Hospital, MilitaryToDate, MilitaryPosition, PassportCode, PassportFromDate, PassportToDate, ReasonLeave, Status, Description };
            return (new SqlHelper()).ExecuteNonQuery(myTransaction, "HRM_EMPLOYEE_Update", strArrays1, employeeCode);
        }

        public string Update(string EmployeeCode, Image photo)
        {
            byte[] buffer;
            SqlHelper sqlHelper = new SqlHelper()
            {
                CommandType = CommandType.Text
            };
            sqlHelper.Error += new SqlHelper.ErrorEventHander(this.DispError);
            if (photo == null)
            {
                buffer = new byte[2];
            }
            else
            {
                photo.Save(string.Concat(Path.GetTempPath(), "\\temp_image_perfect_software.JPG"));
              //  MyImage.CompressJpeg(string.Concat(Path.GetTempPath(), "\\temp_image_perfect_software.JPG"), 20);
                photo = Image.FromFile(string.Concat(Path.GetTempPath(), "\\temp_image_perfect_software.JPG"));
                MemoryStream memoryStream = new MemoryStream();
                photo.Save(memoryStream, photo.RawFormat);
                buffer = memoryStream.GetBuffer();
                memoryStream.Close();
            }
            string[] strArrays = new string[] { "@EmployeeCode", "@Photo" };
            object[] employeeCode = new object[] { EmployeeCode, buffer };
            return sqlHelper.ExecuteNonQuery("Update HRM_EMPLOYEE set Photo=@Photo WHERE EmployeeCode=@EmployeeCode", strArrays, employeeCode);
        }

        public string UpdateContract(string EmployeeCode, string ContractCode, string ContractType, DateTime ContractSignDate, DateTime ContractFromDate, DateTime ContractToDate)
        {
            string[] strArrays = new string[] { "@EmployeeCode", "@ContractCode", "@ContractType", "@ContractSignDate", "@ContractFromDate", "@ContractToDate" };
            string[] strArrays1 = strArrays;
            object[] employeeCode = new object[] { EmployeeCode, ContractCode, ContractType, ContractSignDate, ContractFromDate, ContractToDate };
            return (new SqlHelper()).ExecuteNonQuery("HRM_EMPLOYEE_UpdateContract", strArrays1, employeeCode);
        }
    }
}
