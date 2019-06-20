using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucOrganizationEdit : xucBase
    {

        private string m_SubsidiaryCode = "";

        private string m_BranchCode = "";

        private string m_DepartmentCode = "";

        private string m_GroupCode = "";

        private string m_EmployeeCode;

        private int m_Level;

        private string m_Code;

    //    private xucOrganization xucOrganization1;

        public Organization Organization;
        public xucOrganizationEdit()
        {
            InitializeComponent();
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


        public void LoadAllData()
        {
            this.m_Level = 0;
            this.m_Code = "";
            this.m_SubsidiaryCode = "";
            this.m_BranchCode = "";
            this.m_DepartmentCode = "";
            this.m_GroupCode = "";
            if (this.xucOrganization1 == null)
            {
                this.xucOrganization1 = new xucOrganization()
                {
                    Dock = DockStyle.Fill
                };
                this.ppContainer.Controls.Add(this.xucOrganization1);
                if (this.ppContainer.Width < this.ppContainerEdit.Width)
                {
                    this.ppContainer.Width = this.ppContainerEdit.Width;
                }
                this.Refresh();
                this.xucOrganization1.LoadAllData();

                this.xucOrganization1.Selected += new xucOrganization.SelectedEventHander(this.xucOrganization_Selected);
                this.ShowDisplay();
            }
        }

        public void LoadData()
        {
            this.m_Level = MyLogin.Level;
            this.m_Code = MyLogin.Code;
            if (this.xucOrganization1 == null)
            {
                this.xucOrganization1 = new xucOrganization()
                {
                    Dock = DockStyle.Fill
                };
                this.ppContainer.Controls.Add(this.xucOrganization1);
                if (this.ppContainer.Width < this.ppContainerEdit.Width)
                {
                    this.ppContainer.Width = this.ppContainerEdit.Width;
                }
                this.Refresh();
                this.xucOrganization1.LoadData();
                this.xucOrganization1.Selected += new xucOrganization.SelectedEventHander(this.xucOrganization1_Selected);
                this.ShowDisplay();
            }
        }

        private void RaiseDepartmentSelectedHandler(Organization Item)
        {
            if (this.DepartmentSelected != null)
            {
                this.DepartmentSelected(this, Item);
            }
        }

        public void SelectOrganization(int mLevel, string mCode)
        {
            this.m_Level = mLevel;
            this.m_Code = mCode;
            this.xucOrganization1.SelectNodeByLevelCode(this.m_Level, this.m_Code);
        }

        public void SelectOrganization(string mSubsidiaryCode, string mBranchCode, string mDepartmentCode, string mGroupCode)
        {
            if (mSubsidiaryCode != "")
            {
                if (mBranchCode != "")
                {
                    if (!(mDepartmentCode != ""))
                    {
                        this.m_Level = 2;
                        this.m_Code = mBranchCode;
                    }
                    else if (!(mGroupCode != ""))
                    {
                        this.m_Level = 3;
                        this.m_Code = mDepartmentCode;
                    }
                    else
                    {
                        this.m_Level = 4;
                        this.m_Code = mGroupCode;
                    }
                }
                else if (!(mDepartmentCode != ""))
                {
                    this.m_Level = 1;
                    this.m_Code = mSubsidiaryCode;
                }
                else if (!(mGroupCode != ""))
                {
                    this.m_Level = 3;
                    this.m_Code = mDepartmentCode;
                }
                else
                {
                    this.m_Level = 4;
                    this.m_Code = mGroupCode;
                }
            }
            else if (mBranchCode != "")
            {
                if (!(mDepartmentCode != ""))
                {
                    this.m_Level = 2;
                    this.m_Code = mBranchCode;
                }
                else if (!(mGroupCode != ""))
                {
                    this.m_Level = 3;
                    this.m_Code = mDepartmentCode;
                }
                else
                {
                    this.m_Level = 4;
                    this.m_Code = mGroupCode;
                }
            }
            else if (!(mDepartmentCode != ""))
            {
                this.m_Level = 0;
                this.m_Code = "";
            }
            else if (!(mGroupCode != ""))
            {
                this.m_Level = 3;
                this.m_Code = mDepartmentCode;
            }
            else
            {
                this.m_Level = 4;
                this.m_Code = mGroupCode;
            }
            this.SelectOrganization(this.m_Level, this.m_Code);
        }

        private void ShowDisplay()
        {
            this.ppContainerEdit.Text = HRM_ORGANIZATION.GetOrganizationOnFull(this.m_Level, this.m_Code);
            if (this.m_SubsidiaryCode == null)
            {
                this.m_SubsidiaryCode = "";
            }
            if (this.m_BranchCode == null)
            {
                this.m_BranchCode = "";
            }
            if (this.m_DepartmentCode == null)
            {
                this.m_DepartmentCode = "";
            }
            if (this.m_GroupCode == null)
            {
                this.m_GroupCode = "";
            }
            this.Organization = new Organization(this.m_SubsidiaryCode, this.m_BranchCode, this.m_DepartmentCode, this.m_GroupCode, this.m_EmployeeCode, this.m_Level, this.m_Code);
        }

        private void xucOrganization_Selected(object sender, Organization Item)
        {
            this.m_SubsidiaryCode = Item.SubsidiaryCode;
            this.m_BranchCode = Item.BranchCode;
            this.m_DepartmentCode = Item.DepartmentCode;
            this.m_GroupCode = Item.GroupCode;
            this.m_EmployeeCode = Item.EmployeeCode;
            this.m_Level = Item.Level;
            this.m_Code = Item.Code;
            this.ShowDisplay();
            this.ppContainerEdit.ClosePopup();
            this.RaiseDepartmentSelectedHandler(Item);
        }





        public event xucOrganizationEdit.DepartmentSelectedHandler DepartmentSelected;

        public delegate void DepartmentSelectedHandler(object sender, Organization Item);



        private void ppContainerEdit_Popup(object sender, EventArgs e)
        {

        }

        private void xucOrganizationEdit_Load(object sender, EventArgs e)
        {
            this.ppContainerEdit.Properties.Appearance.Font = this.Font;
          //  ShowDisplay();
        }

        private void xucOrganizationEdit_Load_1(object sender, EventArgs e)
        {
            this.ppContainerEdit.Properties.Appearance.Font = this.Font;
           ShowDisplay();
        }

        private void ppContainerEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void xucOrganization1_Selected(object sender, Organization Item)
        {
            this.m_SubsidiaryCode = Item.SubsidiaryCode;
            this.m_BranchCode = Item.BranchCode;
            this.m_DepartmentCode = Item.DepartmentCode;
            this.m_GroupCode = Item.GroupCode;
            this.m_EmployeeCode = Item.EmployeeCode;
            this.m_Level = Item.Level;
            this.m_Code = Item.Code;
            this.ShowDisplay();
            this.ppContainerEdit.ClosePopup();
            this.RaiseDepartmentSelectedHandler(Item);
        }
    }

}
