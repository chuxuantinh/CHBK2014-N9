using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
//using CHBK2014_N9.HumanResource.Core.Process;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xfmSalaryTableListImport : xfmBaseWizard
    {
        private Guid m_SalaryTableListID = Guid.Empty;
        public xfmSalaryTableListImport()
        {
            InitializeComponent();
        }


      

        public xfmSalaryTableListImport(int SelectedIndex)
        {
            this.InitializeComponent();
            this.rgOption.SelectedIndex = SelectedIndex;
        }

        public xfmSalaryTableListImport(int SelectedIndex, Guid SalaryTableListID)
        {
            this.InitializeComponent();
            this.rgOption.SelectedIndex = SelectedIndex;
            this.m_SalaryTableListID = SalaryTableListID;
        }


        protected override void Next()
        {
            //base.Next();
            //switch (this.rgOption.SelectedIndex)
            //{
            //    case 0:
            //        {
            //            xfmSalaryPayImport _xfmSalaryPayImport = new xfmSalaryPayImport(this.m_SalaryTableListID)
            //            {
            //                Size = base.Size
            //            };
            //            _xfmSalaryPayImport.Success += new xfmBaseImport.SuccessEventHander((object s) => this.RaiseSuccessEventHander());
            //            _xfmSalaryPayImport.ShowDialog();
            //            break;
            //        }
            //    case 1:
            //        {
            //            xfmSalaryDebitImport _xfmSalaryDebitImport = new xfmSalaryDebitImport(this.m_SalaryTableListID)
            //            {
            //                Size = base.Size
            //            };
            //            _xfmSalaryDebitImport.Success += new xfmBaseImport.SuccessEventHander((object s) => this.RaiseSuccessEventHander());
            //            _xfmSalaryDebitImport.ShowDialog();
            //            break;
            //        }
            //    case 2:
            //        {
            //            xfmSalaryAllowanceImport _xfmSalaryAllowanceImport = new xfmSalaryAllowanceImport(this.m_SalaryTableListID)
            //            {
            //                Size = base.Size
            //            };
            //            _xfmSalaryAllowanceImport.Success += new xfmBaseImport.SuccessEventHander((object s) => this.RaiseSuccessEventHander());
            //            _xfmSalaryAllowanceImport.ShowDialog();
            //            break;
            //        }
            //    case 3:
            //        {
            //            xfmAdvanceImport _xfmAdvanceImport = new xfmAdvanceImport(this.m_SalaryTableListID)
            //            {
            //                Size = base.Size
            //            };
            //            _xfmAdvanceImport.Success += new xfmBaseImport.SuccessEventHander((object s) => this.RaiseSuccessEventHander());
            //            _xfmAdvanceImport.ShowDialog();
            //            break;
            //        }
            //    case 4:
            //        {
            //            xfmAssignmentImport _xfmAssignmentImport = new xfmAssignmentImport(this.m_SalaryTableListID)
            //            {
            //                Size = base.Size
            //            };
            //            _xfmAssignmentImport.Success += new xfmBaseImport.SuccessEventHander((object s) => this.RaiseSuccessEventHander());
            //            _xfmAssignmentImport.ShowDialog();
            //            break;
            //        }
            //    case 5:
            //    case 6:
            //        {
            //            xfmSalaryPlusImport _xfmSalaryPlusImport = new xfmSalaryPlusImport(this.m_SalaryTableListID)
            //            {
            //                Size = base.Size
            //            };
            //            _xfmSalaryPlusImport.Success += new xfmBaseImport.SuccessEventHander((object s) => this.RaiseSuccessEventHander());
            //            _xfmSalaryPlusImport.ShowDialog();
            //            break;
            //        }
            //    case 7:
            //        {
            //            xfmSalaryMinusImport _xfmSalaryMinusImport = new xfmSalaryMinusImport(this.m_SalaryTableListID)
            //            {
            //                Size = base.Size
            //            };
            //            _xfmSalaryMinusImport.Success += new xfmBaseImport.SuccessEventHander((object s) => this.RaiseSuccessEventHander());
            //            _xfmSalaryMinusImport.ShowDialog();
            //            break;
            //        }
            //}
        }

        private void RaiseSuccessEventHander()
        {
            if (this.Success != null)
            {
                this.Success(this);
            }
        }

        public event xfmSalaryTableListImport.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender);

    }
}
