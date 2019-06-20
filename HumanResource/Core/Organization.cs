using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;

namespace CHBK2014_N9.HumanResource.Core
{
   public class Organization
    {


        private string m_SubsidiaryCode = "";

        private string m_BranchCode = "";

        private string m_DepartmentCode = "";

        private string m_GroupCode = "";

        private string m_EmployeeCode = "";

        private int m_Level;

        private string m_Code;

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
                HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                hRMBRANCH.Get(this.m_BranchCode);
                this.m_SubsidiaryCode = hRMBRANCH.SubsidiaryCode;
            }
        }

        [Category("Column")]
        [DisplayName("Code")]
        public string Code
        {
            get
            {
                return this.m_Code;
            }
            set
            {
                this.m_Code = value;
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
                HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                hRMDEPARTMENT.Get(this.m_DepartmentCode);
                this.m_BranchCode = hRMDEPARTMENT.BranchCode;
                this.m_SubsidiaryCode = hRMDEPARTMENT.SubsidiaryCode;
            }
        }

        [Category("Column")]
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
                HRM_GROUP hRMGROUP = new HRM_GROUP();
                hRMGROUP.Get(this.m_GroupCode);
                this.m_DepartmentCode = hRMGROUP.DepartmentCode;
                HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                hRMDEPARTMENT.Get(this.m_DepartmentCode);
                this.m_BranchCode = hRMDEPARTMENT.BranchCode;
                this.m_SubsidiaryCode = hRMDEPARTMENT.SubsidiaryCode;
            }
        }

        [Category("Column")]
        [DisplayName("Level")]
        public int Level
        {
            get
            {
                return this.m_Level;
            }
            set
            {
                this.m_Level = value;
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

        public Organization()
        {
            this.m_SubsidiaryCode = "";
            this.m_BranchCode = "";
            this.m_DepartmentCode = "";
            this.m_GroupCode = "";
            this.m_EmployeeCode = "";
            this.m_Level = 0;
            this.m_Code = "";
        }

        public Organization(string SubsidiaryCode, string BranchCode, string DepartmentCode, string GroupCode, string EmployeeCode, int Level, string Code)
        {
            this.m_SubsidiaryCode = SubsidiaryCode;
            this.m_BranchCode = BranchCode;
            this.m_DepartmentCode = DepartmentCode;
            this.m_GroupCode = GroupCode;
            this.m_EmployeeCode = EmployeeCode;
            this.m_Level = Level;
            this.m_Code = Code;
        }
    }
}
