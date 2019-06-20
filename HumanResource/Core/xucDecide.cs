﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using CHBK2014_N9.Common;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucDecide : xucBase
    {

      
        public xucDecide()
        {
            InitializeComponent();
            Init();
        }


        private void Init()
        {
            base.SetWaitDialogCaption("Đang khởi tạo dữ liệu...");
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            this.gridControl1.DataSource = hRMEMPLOYEE.GetListCurrentNow(0, "", -1);
        }

       
    }
}
