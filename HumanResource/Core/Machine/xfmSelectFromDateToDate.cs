using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core.Machine
{
    public partial class xfmSelectFromDateToDate : xfmBaseWizard
    {
        public xfmSelectFromDateToDate()
        {
            this.InitializeComponent();
            this.dtFromDate.DateTime = DateTime.Now;
            this.dtToDate.DateTime = DateTime.Now;
        }

        public xfmSelectFromDateToDate(DateTime FromDate, DateTime ToDate)
        {
            this.InitializeComponent();
            this.dtFromDate.DateTime = FromDate;
            this.dtToDate.DateTime = ToDate;
        }

        protected override void Cancel()
        {
            base.Cancel();
            this.RaiseDeselectedEventHander();
        }

        protected override void Next()
        {
            base.Next();
            this.RaiseSelectedEventHander(this.dtFromDate.DateTime, this.dtToDate.DateTime);
        }

        private void RaiseDeselectedEventHander()
        {
            if (this.Deselected != null)
            {
                this.Deselected(this);
            }
        }

        private void RaiseSelectedEventHander(DateTime FromDate, DateTime ToDate)
        {
            if (this.Selected != null)
            {
                this.Selected(this, FromDate, ToDate);
            }
        }

        private void xfmSelectFromDateToDate_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.RaiseDeselectedEventHander();
        }

        public event xfmSelectFromDateToDate.DeselectedEventHander Deselected;

        public event xfmSelectFromDateToDate.SelectedEventHander Selected;

        public delegate void DeselectedEventHander(object sender);

        public delegate void SelectedEventHander(object sender, DateTime FromDate, DateTime ToDate);
    }
}
