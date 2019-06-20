using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucOrganizationBase :XucBaseBasicE
    {

        protected int m_Level = MyLogin.Level;

        protected string m_Code = MyLogin.Code;

        private AutoHideContainer hideContainerLeft;

   //     private ControlContainer dockPanel1_Container;
        public xucOrganizationBase()
        {
            InitializeComponent();

            if (!base.DesignMode)
            {
                this.Init();
            }
        }


        protected virtual void Init()
        {
            this.xucOrganization1.LoadData();
            this.xucOrganization1.Selected += new xucOrganization.SelectedEventHander((object s, Organization o) => {
                this.m_Level = o.Level;
                this.m_Code = o.Code;
                this.LoadGrid();
            });
            this.xucOrganization1.Updated += new xucOrganization.UpdatedEventHander((object o) => this.xucOrganization1.LoadData());
        }



        protected virtual void LoadGrid()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public void RaiseClosedHander()
        {
            if (this.Closed != null)
            {
                this.Closed(this);
            }
        }

        public event xucOrganizationBase.ClosedHander Closed;

        public delegate void ClosedHander(object sender);
    }
}
