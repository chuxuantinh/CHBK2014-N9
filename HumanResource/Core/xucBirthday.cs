using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.Common;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucBirthday : xucBase
    {
        public xucBirthday()
        {
            InitializeComponent();
            Init();
        }


        private void Init()
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            this.gcList.DataSource = hRMEMPLOYEE.GetListBirthday(MyLogin.Level, MyLogin.Code);
        }

    }
}
