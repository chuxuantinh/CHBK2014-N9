using DevExpress.XtraEditors;
using CHBK2014_N9.Net.Info;
using System;

namespace CHBK2014_N9.ERP
{
  public  class HRM_ORGANIZATION
    {

        private string m_SubsidiaryCode;

        private string m_BranchCode;

        private string m_DepartmentCode;

        private string m_GroupCode;

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

        public HRM_ORGANIZATION()
        {
            this.m_SubsidiaryCode = "";
            this.m_BranchCode = "";
            this.m_DepartmentCode = "";
            this.m_GroupCode = "";
        }

        public static string GetOrganization(int mLevel, string mCode, bool IsShowCompany)
        {
            HRM_DEPARTMENT hRMDEPARTMENT;
            string[] subsidiaryName;
            string str = "/";
            (new SYS_USER()).GetUserName(MyLogin.Account);
            string subsidiaryName1 = "";
            if (mLevel == 0)
            {
                if (IsShowCompany)
                {
                    subsidiaryName1 = "Tất cả";
                }
            }
            else if (mLevel == 1)
            {
                HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
                hRMSUBSIDIARY.Get(mCode);
                subsidiaryName1 = hRMSUBSIDIARY.SubsidiaryName;
            }
            else if (mLevel == 2)
            {
                HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                hRMBRANCH.Get(mCode);
                subsidiaryName1 = (!(hRMBRANCH.SubsidiaryName == "") ? string.Concat(hRMBRANCH.SubsidiaryName, str, hRMBRANCH.BranchName) : hRMBRANCH.BranchName);
            }
            else if (mLevel == 3)
            {
                hRMDEPARTMENT = new HRM_DEPARTMENT();
                hRMDEPARTMENT.Get(mCode);
                if (hRMDEPARTMENT.SubsidiaryName == "")
                {
                    subsidiaryName1 = (!(hRMDEPARTMENT.BranchName == "") ? string.Concat(hRMDEPARTMENT.BranchName, str, hRMDEPARTMENT.DepartmentName) : hRMDEPARTMENT.DepartmentName);
                }
                else if (!(hRMDEPARTMENT.BranchName == ""))
                {
                    subsidiaryName = new string[] { hRMDEPARTMENT.SubsidiaryName, str, hRMDEPARTMENT.BranchName, str, hRMDEPARTMENT.DepartmentName };
                    subsidiaryName1 = string.Concat(subsidiaryName);
                }
                else
                {
                    subsidiaryName1 = string.Concat(hRMDEPARTMENT.SubsidiaryName, str, hRMDEPARTMENT.DepartmentName);
                }
            }
            else if (mLevel == 4)
            {
                HRM_GROUP hRMGROUP = new HRM_GROUP();
                hRMGROUP.Get(mCode);
                hRMDEPARTMENT = new HRM_DEPARTMENT();
                hRMDEPARTMENT.Get(hRMGROUP.DepartmentCode);
                if (hRMDEPARTMENT.SubsidiaryName == "")
                {
                    if (!(hRMDEPARTMENT.BranchName == ""))
                    {
                        subsidiaryName = new string[] { hRMDEPARTMENT.BranchName, str, hRMDEPARTMENT.DepartmentName, str, hRMGROUP.GroupName };
                        subsidiaryName1 = string.Concat(subsidiaryName);
                    }
                    else
                    {
                        subsidiaryName1 = string.Concat(hRMDEPARTMENT.DepartmentName, str, hRMGROUP.GroupName);
                    }
                }
                else if (!(hRMDEPARTMENT.BranchName == ""))
                {
                    subsidiaryName = new string[] { hRMDEPARTMENT.SubsidiaryName, str, hRMDEPARTMENT.BranchName, str, hRMDEPARTMENT.DepartmentName, str, hRMGROUP.GroupName };
                    subsidiaryName1 = string.Concat(subsidiaryName);
                }
                else
                {
                    subsidiaryName = new string[] { hRMDEPARTMENT.SubsidiaryName, str, hRMDEPARTMENT.DepartmentName, str, hRMGROUP.GroupName };
                    subsidiaryName1 = string.Concat(subsidiaryName);
                }
            }
            return subsidiaryName1;
        }

        public static string GetOrganizationByMyLogin()
        {
            return HRM_ORGANIZATION.GetOrganization(MyLogin.Level, MyLogin.Code, true);
        }

        public static string GetOrganizationOnFull(int mLevel, string mCode)
        {
            return HRM_ORGANIZATION.GetOrganization(mLevel, mCode, true);
        }

        public static string GetOrganizationOnFull(string mSubsidiaryCode, string mBranchCode, string mDepartmentCode, string mGroupCode)
        {
            int num = 0;
            string str = "";
            if (mBranchCode != "")
            {
                if (!(mDepartmentCode != ""))
                {
                    num = 2;
                    str = mBranchCode;
                }
                else if (!(mGroupCode != ""))
                {
                    num = 3;
                    str = mDepartmentCode;
                }
                else
                {
                    num = 4;
                    str = mGroupCode;
                }
            }
            else if (!(mDepartmentCode != ""))
            {
                num = 1;
                str = mSubsidiaryCode;
            }
            else if (!(mGroupCode != ""))
            {
                num = 3;
                str = mDepartmentCode;
            }
            else
            {
                num = 4;
                str = mGroupCode;
            }
            return HRM_ORGANIZATION.GetOrganization(num, str, true);
        }

        public static string GetOrganizationOnReport(int mLevel, string mCode)
        {
            return HRM_ORGANIZATION.GetOrganization(mLevel, mCode, false);
        }

        public void SetOrganization(string OrganizationName)
        {
            string str;
            string str1;
            string str2;
            char[] chrArray = new char[] { '\\', '/' };
            string[] strArrays = OrganizationName.Split(chrArray);
            HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
            HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
            HRM_GROUP hRMGROUP = new HRM_GROUP();
            if ((int)strArrays.Length != 0)
            {
                if ((int)strArrays.Length == 1)
                {
                    str = strArrays[0];
                    if (hRMSUBSIDIARY.GetName(str) == "OK")
                    {
                        this.m_SubsidiaryCode = hRMSUBSIDIARY.SubsidiaryCode;
                    }
                    else if (hRMBRANCH.GetName(str) == "OK")
                    {
                        this.m_BranchCode = hRMBRANCH.BranchCode;
                        this.m_SubsidiaryCode = hRMBRANCH.SubsidiaryCode;
                    }
                    else if (hRMDEPARTMENT.GetName(str) == "OK")
                    {
                        this.m_DepartmentCode = hRMDEPARTMENT.DepartmentCode;
                        this.m_BranchCode = hRMDEPARTMENT.BranchCode;
                        this.m_SubsidiaryCode = hRMDEPARTMENT.SubsidiaryCode;
                    }
                    else if (hRMGROUP.GetName(str) == "OK")
                    {
                        this.m_GroupCode = hRMGROUP.GroupCode;
                        this.m_DepartmentCode = hRMGROUP.DepartmentCode;
                        this.m_BranchCode = hRMGROUP.BranchCode;
                        this.m_SubsidiaryCode = hRMGROUP.SubsidiaryCode;
                    }
                }
                else if ((int)strArrays.Length == 2)
                {
                    str = strArrays[0];
                    str1 = strArrays[1];
                    if (hRMSUBSIDIARY.GetName(str) == "OK")
                    {
                        this.m_SubsidiaryCode = hRMSUBSIDIARY.SubsidiaryCode;
                        if (hRMBRANCH.GetName(this.m_SubsidiaryCode, str1) == "OK")
                        {
                            this.m_BranchCode = hRMBRANCH.BranchCode;
                        }
                        else if (hRMDEPARTMENT.GetName(this.m_BranchCode, str1) == "OK")
                        {
                            this.m_DepartmentCode = hRMDEPARTMENT.DepartmentCode;
                        }
                    }
                    else if (hRMBRANCH.GetName(str) == "OK")
                    {
                        this.m_BranchCode = hRMBRANCH.BranchCode;
                        this.m_SubsidiaryCode = hRMBRANCH.SubsidiaryCode;
                        if (hRMDEPARTMENT.GetName(this.m_BranchCode, str1) == "OK")
                        {
                            this.m_DepartmentCode = hRMDEPARTMENT.DepartmentCode;
                        }
                    }
                    else if (hRMDEPARTMENT.GetName(str) == "OK")
                    {
                        this.m_DepartmentCode = hRMDEPARTMENT.DepartmentCode;
                        this.m_BranchCode = hRMDEPARTMENT.BranchCode;
                        this.m_SubsidiaryCode = hRMDEPARTMENT.SubsidiaryCode;
                        if (hRMGROUP.GetName(this.m_DepartmentCode, str1) == "OK")
                        {
                            this.m_GroupCode = hRMGROUP.GroupCode;
                        }
                    }
                }
                else if ((int)strArrays.Length == 3)
                {
                    str = strArrays[0];
                    str1 = strArrays[1];
                    str2 = strArrays[2];
                    if (hRMSUBSIDIARY.GetName(str) == "OK")
                    {
                        this.m_SubsidiaryCode = hRMSUBSIDIARY.SubsidiaryCode;
                        if (hRMBRANCH.GetName(this.m_SubsidiaryCode, str1) == "OK")
                        {
                            this.m_BranchCode = hRMBRANCH.BranchCode;
                            if (hRMDEPARTMENT.GetName(this.m_BranchCode, str2) == "OK")
                            {
                                this.m_DepartmentCode = hRMDEPARTMENT.DepartmentCode;
                            }
                        }
                        else if (hRMDEPARTMENT.GetName(this.m_BranchCode, str1) == "OK")
                        {
                            this.m_DepartmentCode = hRMDEPARTMENT.DepartmentCode;
                            if (hRMGROUP.GetName(this.m_DepartmentCode, str2) == "OK")
                            {
                                this.m_GroupCode = hRMGROUP.GroupCode;
                            }
                        }
                    }
                    else if (hRMBRANCH.GetName(str) == "OK")
                    {
                        this.m_BranchCode = hRMBRANCH.BranchCode;
                        this.m_SubsidiaryCode = hRMBRANCH.SubsidiaryCode;
                        if (hRMDEPARTMENT.GetName(this.m_BranchCode, str1) == "OK")
                        {
                            this.m_DepartmentCode = hRMDEPARTMENT.DepartmentCode;
                            if (hRMGROUP.GetName(this.m_DepartmentCode, str2) == "OK")
                            {
                                this.m_GroupCode = hRMGROUP.GroupCode;
                            }
                        }
                    }
                }
                else if ((int)strArrays.Length == 4)
                {
                    str = strArrays[0];
                    str1 = strArrays[1];
                    str2 = strArrays[2];
                    string str3 = strArrays[3];
                    if (hRMSUBSIDIARY.GetName(str) == "OK")
                    {
                        this.m_SubsidiaryCode = hRMSUBSIDIARY.SubsidiaryCode;
                        if (hRMBRANCH.GetName(this.m_SubsidiaryCode, str1) == "OK")
                        {
                            this.m_BranchCode = hRMBRANCH.BranchCode;
                            if (hRMDEPARTMENT.GetName(this.m_BranchCode, str2) == "OK")
                            {
                                this.m_DepartmentCode = hRMDEPARTMENT.DepartmentCode;
                                if (hRMGROUP.GetName(this.m_DepartmentCode, str3) == "OK")
                                {
                                    this.m_GroupCode = hRMGROUP.GroupCode;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void SetToTwoLabel(int mLevel, string mCode, LabelControl MainName, LabelControl SubName)
        {
            HRM_DEPARTMENT hRMDEPARTMENT;
            string str = "/";
            if (mLevel == 0)
            {
                MainName.Text = "Công ty ABC";
                SubName.Text = "";
            }
            else if (mLevel == 1)
            {
                HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
                hRMSUBSIDIARY.Get(mCode);
                MainName.Text = hRMSUBSIDIARY.SubsidiaryName;
                SubName.Text = "";
            }
            else if (mLevel == 2)
            {
                HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                hRMBRANCH.Get(mCode);
                if (!(hRMBRANCH.SubsidiaryName == ""))
                {
                    MainName.Text = string.Concat(hRMBRANCH.SubsidiaryName, str, hRMBRANCH.BranchName);
                }
                else
                {
                    MainName.Text = hRMBRANCH.BranchName;
                }
                SubName.Text = "";
            }
            else if (mLevel == 3)
            {
                hRMDEPARTMENT = new HRM_DEPARTMENT();
                hRMDEPARTMENT.Get(mCode);
                if (hRMDEPARTMENT.SubsidiaryName == "")
                {
                    if (!(hRMDEPARTMENT.BranchName == ""))
                    {
                        MainName.Text = string.Concat(hRMDEPARTMENT.BranchName, str, hRMDEPARTMENT.DepartmentName);
                        SubName.Text = "";
                    }
                    else
                    {
                        MainName.Text = hRMDEPARTMENT.DepartmentName;
                        SubName.Text = "";
                    }
                }
                else if (!(hRMDEPARTMENT.BranchName == ""))
                {
                    MainName.Text = string.Concat(hRMDEPARTMENT.SubsidiaryName, str, hRMDEPARTMENT.BranchName);
                    SubName.Text = hRMDEPARTMENT.DepartmentName;
                }
                else
                {
                    MainName.Text = string.Concat(hRMDEPARTMENT.SubsidiaryName, str, hRMDEPARTMENT.DepartmentName);
                    SubName.Text = "";
                }
            }
            else if (mLevel == 4)
            {
                HRM_GROUP hRMGROUP = new HRM_GROUP();
                hRMGROUP.Get(mCode);
                hRMDEPARTMENT = new HRM_DEPARTMENT();
                hRMDEPARTMENT.Get(hRMGROUP.DepartmentCode);
                if (hRMDEPARTMENT.SubsidiaryName == "")
                {
                    if (!(hRMDEPARTMENT.BranchName == ""))
                    {
                        MainName.Text = string.Concat(hRMDEPARTMENT.BranchName, str, hRMDEPARTMENT.DepartmentName);
                        SubName.Text = hRMGROUP.GroupName;
                    }
                    else
                    {
                        MainName.Text = string.Concat(hRMDEPARTMENT.DepartmentName, str, hRMGROUP.GroupName);
                        SubName.Text = "";
                    }
                }
                else if (!(hRMDEPARTMENT.BranchName == ""))
                {
                    MainName.Text = string.Concat(hRMDEPARTMENT.SubsidiaryName, str, hRMDEPARTMENT.BranchName);
                    SubName.Text = string.Concat(hRMDEPARTMENT.DepartmentName, str, hRMGROUP.GroupName);
                }
                else
                {
                    MainName.Text = string.Concat(hRMDEPARTMENT.SubsidiaryName, str, hRMDEPARTMENT.DepartmentName);
                    SubName.Text = hRMGROUP.GroupName;
                }
            }
        }
    }
}
