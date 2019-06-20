using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucSalaryBase : xucOrganizationBase
    {

        protected Guid m_SalaryTableListID = Guid.Empty;
        public xucSalaryBase()
        {
            InitializeComponent();

            HRM_ORGANIZATION.SetToTwoLabel(0, "", this.lbMainName, this.lbSubName);
        }


        protected override void bbiNameListOption_ItemClick()
        {
            base.bbiNameListOption_ItemClick();
            xfmSalaryTableListOption _xfmSalaryTableListOption = new xfmSalaryTableListOption();
            _xfmSalaryTableListOption.Created += new xfmSalaryTableListOption.CreateSuccess((object s) => this.Reload());
            _xfmSalaryTableListOption.Deleted += new xfmSalaryTableListOption.DeleteSuccess((object s) => this.Reload());
            _xfmSalaryTableListOption.ShowDialog();
        }

        private void CheckSalaryTableList()
        {
            HRM_SALARY_TABLELIST hRMSALARYTABLELIST = new HRM_SALARY_TABLELIST();
            if (hRMSALARYTABLELIST.Exist(this.m_Month, this.m_Year))
            {
                hRMSALARYTABLELIST.Get(this.m_Month, this.m_Year);
                this.m_SalaryTableListID = hRMSALARYTABLELIST.SalaryTableListID;
                this.m_IsLock = hRMSALARYTABLELIST.IsLock;
                this.m_IsFinish = hRMSALARYTABLELIST.IsFinish;
                this.Customize();
                this.LoadGrid();
            }
            else
            {
                if (this._exportControl != null)
                {
                    this._exportControl.DataSource = null;
                }
                this.m_IsLock = false;
                this.m_IsFinish = false;
                this.m_SalaryTableListID = Guid.Empty;
                this.Customize();
                LabelControl labelControl = this.lbSalaryName;
                string[] str = new string[] { "Dữ liệu tính lương tháng ", this.m_Month.ToString(), " - ", this.m_Year.ToString(), " này không tồn tại!" };
                labelControl.Text = string.Concat(str);
                this.lbMessage.Text = "Dữ liệu tính lương tháng này không tồn tại trong cơ sở dữ liệu của chương trình!";
                if (!this.m_IsFirstLoad)
                {
                    this.m_IsFirstLoad = true;
                }
                else
                {
                    xfmSalaryTableListAdd _xfmSalaryTableListAdd = new xfmSalaryTableListAdd(this.m_Month, this.m_Year);
                    _xfmSalaryTableListAdd.Created += new xfmSalaryTableListAdd.CreateSuccess((object s) => this.Reload());
                    _xfmSalaryTableListAdd.ShowDialog();
                }
            }
        }

        protected virtual void Customize()
        {
            if (!this.m_IsLock)
            {
                this.ptLock.Visible = false;
                this.lbMessage.Text = "Đã mở sổ - Được phép chỉnh sửa bảng tính lương tháng này";
            }
            else
            {
                this.ptLock.Visible = true;
                this.lbMessage.Text = "Đã khoá sổ - Không được phép chỉnh sửa";
            }
            if (this.m_IsFinish)
            {
                this.ptFinish.Visible = true;
                this.lbMessage.Text = "Đã hoàn thành bảng tính lương của tháng này - Không được phép chỉnh sửa";
            }
            else if (!this.m_IsLock)
            {
                this.ptLock.Visible = false;
                this.ptFinish.Visible = false;
                this.lbMessage.Text = "Đã mở sổ - Được phép chỉnh sửa bảng tính lương tháng này";
            }
        }

        protected override void Finish()
        {
            base.Finish();
            if (ClsOption.System2.IsQuestion)
            {
                if (XtraMessageBox.Show(string.Concat("Bạn có chắc là muốn thực hiện tác vụ này không?", Environment.NewLine, " Tác vụ này được hiểu là bạn đã hoàn thành bảng tính lương của tháng này!"), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            if (!((new HRM_SALARY_TABLELIST()).Finish(this.m_SalaryTableListID).ToString() == "OK"))
            {
                MessageBox.Show("Hoàn thành bảng lương thất bại!");
            }
            else
            {
                this.m_IsLock = true;
                this.m_IsFinish = true;
                this.Customize();
            }
        }

        protected override void Init()
        {
            base.Init();
        }
        protected override void LoadGrid()
        {
            base.LoadGrid();
            HRM_ORGANIZATION.SetToTwoLabel(this.m_Level, this.m_Code, this.lbMainName, this.lbSubName);
        }

        protected override void Lock()
        {
            base.Lock();
            if (!((new HRM_SALARY_TABLELIST()).Lock(this.m_SalaryTableListID).ToString() == "OK"))
            {
                MessageBox.Show("Khóa sổ bảng lương thất bại!");
            }
            else
            {
                this.m_IsLock = true;
                this.m_IsFinish = false;
                this.Customize();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.bbiView.Visibility = BarItemVisibility.Never;
            this.bbiCreate.Visibility = BarItemVisibility.Never;
            this.bbiReCreate.Visibility = BarItemVisibility.Never;
            this.bbeTableListSelect.Visibility = BarItemVisibility.Never;
            this.bbiSendMail.Visibility = BarItemVisibility.Never;
            this.bbeDateTimeSelect.Visibility = BarItemVisibility.Never;
            this.bbeFromDate.Visibility = BarItemVisibility.Never;
            this.bbeToDate.Visibility = BarItemVisibility.Never;
            this.bbeTableListSelect.Caption = "Chọn bảng lương:";
        }

        protected override void Open()
        {
            base.Open();
            if (!((new HRM_SALARY_TABLELIST()).Open(this.m_SalaryTableListID).ToString() == "OK"))
            {
                MessageBox.Show("Mở sổ bảng lương thất bại!");
            }
            else
            {
                this.m_IsLock = false;
                this.m_IsFinish = false;
                this.Customize();
            }
        }


     

        public void RaiseSalaryPayChangedHander()
        {
            if (this.SalaryPayChanged != null)
            {
                this.SalaryPayChanged(this);
            }
        }

        protected override void Reload()
        {
            base.Reload();
            if (!base.DesignMode)
            {
                this.CheckSalaryTableList();
            }
        }

        protected override void repMonth_EditValueChanged()
        {
            base.repMonth_EditValueChanged();
            this.CheckSalaryTableList();
        }

        protected override void repTableListSelect_ButtonClick()
        {
            base.repTableListSelect_ButtonClick();
            (new xfmSalaryTableListOption()).ShowDialog();
        }

        protected override void repYear_EditValueChanged()
        {
            base.repYear_EditValueChanged();
            this.CheckSalaryTableList();
        }

        private void xucExpandCollapseButton1_ExpandCollapsed(object sender, bool IsExpand)
        {
            if (!IsExpand)
            {
                this._exportView.OptionsView.ShowGroupPanel = false;
            }
            else
            {
                this._exportView.OptionsView.ShowGroupPanel = true;
            }
        }


        public event xucSalaryBase.SalaryPayChangedHander SalaryPayChanged;

        public delegate void SalaryPayChangedHander(object sender);
    }
}
