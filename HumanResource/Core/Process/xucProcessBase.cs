using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace CHBK2014_N9.HumanResource.Core.Process
{
    public partial class xucProcessBase : XucBaseBasicE
    {

        protected Guid m_SalaryTableListID = Guid.Empty;

        protected int m_Level = MyLogin.Level;

        protected string m_Code = MyLogin.Code;
        public xucProcessBase()
        {
            InitializeComponent();
        }


        private void Init()
        {
        }


        protected virtual void LoadGrid()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.bbiCreate.Visibility = BarItemVisibility.Never;
            this.bbiReCreate.Visibility = BarItemVisibility.Never;
            this.bbeTableListSelect.Visibility = BarItemVisibility.Never;
            this.bbiSendMail.Visibility = BarItemVisibility.Never;
            this.bbiNameListOption.Visibility = BarItemVisibility.Never;
            this.bbiQuickAdd.Visibility = BarItemVisibility.Never;
            this.bbiLock.Visibility = BarItemVisibility.Never;
            this.bbiOpen.Visibility = BarItemVisibility.Never;
            this.bbiFinish.Visibility = BarItemVisibility.Never;
            this.bbeMonth.Visibility = BarItemVisibility.Never;
            this.bbeYear.Visibility = BarItemVisibility.Never;
            this.bbeName.Visibility = BarItemVisibility.Never;
            this.bbeDateTimeSelect.EditValue = "Tùy chọn";
            if (!base.DesignMode)
            {
                this.LoadGrid();
            }
        }

        public void RaiseClosedHander()
        {
            if (this.Closed != null)
            {
                this.Closed(this);
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
                this.LoadGrid();
            }
        }

        protected override void View()
        {
            base.View();
            if (!base.DesignMode)
            {
                this.LoadGrid();
            }
        }

        public event xucProcessBase.ClosedHander Closed;

        public event xucProcessBase.SalaryPayChangedHander SalaryPayChanged;

        public delegate void ClosedHander(object sender);

        public delegate void SalaryPayChangedHander(object sender);
    }
}
