using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.Common.Report;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Report;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace CHBK2014_N9.HumanResource.Core.Process
{
    public partial class xucListAdvance : xucProcessBase
    {
        public xucListAdvance()
        {
            InitializeComponent();
            this._exportView = this.gbList;
            this._exportControl = this.gcList;
        }

        protected override void Add()
        {
            base.Add();
            if (MyRule.IsAdd("bbiProcessAdvance"))
            {
                xfmAdvanceAdd _xfmAdvanceAdd = new xfmAdvanceAdd(Actions.Add, "");
                _xfmAdvanceAdd.Added += new xfmAdvanceAdd.AddedEventHander(this.frm_Added);
                _xfmAdvanceAdd.ShowDialog();
            }
        }

        private void AddRow(HRM_PROCESS_ADVANCE item)
        {
            GridView gridView = this.gbList;
            int focusedRowHandle = gridView.FocusedRowHandle;
            gridView.AddNewRow();
            focusedRowHandle = gridView.FocusedRowHandle;
            gridView.SetRowCellValue(focusedRowHandle, "AdvanceID", item.AdvanceID);
            gridView.SetRowCellValue(focusedRowHandle, "EmployeeCode", item.EmployeeCode);
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.Get(item.EmployeeCode);
            gridView.SetRowCellValue(focusedRowHandle, "DepartmentName", hRMEMPLOYEE.DepartmentName);
            gridView.SetRowCellValue(focusedRowHandle, "GroupName", hRMEMPLOYEE.GroupName);
            gridView.SetRowCellValue(focusedRowHandle, "FirstName", hRMEMPLOYEE.FirstName);
            gridView.SetRowCellValue(focusedRowHandle, "LastName", hRMEMPLOYEE.LastName);
            gridView.SetRowCellValue(focusedRowHandle, "Reason", item.Reason);
            gridView.SetRowCellValue(focusedRowHandle, "Date", item.Date);
            gridView.SetRowCellValue(focusedRowHandle, "Money", item.Money);
            gridView.SetRowCellValue(focusedRowHandle, "Person", item.Person);
            gridView.UpdateCurrentRow();
        }

        protected override void Change()
        {
            base.Change();
            if (MyRule.IsAccess("bbiProcessAdvance"))
            {
                HRM_PROCESS_ADVANCE hRMPROCESSADVANCE = new HRM_PROCESS_ADVANCE();
                object focusedRowCellValue = this.gbList.GetFocusedRowCellValue("AdvanceID");
                if (focusedRowCellValue != null)
                {
                    base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                    if (!(hRMPROCESSADVANCE.Get(new Guid(focusedRowCellValue.ToString())) != "OK"))
                    {
                        this.DoHide();
                        xfmAdvanceAdd _xfmAdvanceAdd = new xfmAdvanceAdd(Actions.Update, hRMPROCESSADVANCE);
                        _xfmAdvanceAdd.Updated += new xfmAdvanceAdd.UpdatedEventHander(this.frm_Updated);
                        _xfmAdvanceAdd.Added += new xfmAdvanceAdd.AddedEventHander(this.frm_Added);
                        _xfmAdvanceAdd.ShowDialog();
                    }
                    else
                    {
                        this.DoHide();
                        XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        protected override void Delete()
        {
            string str;
            object rowCellValue;
            if (MyRule.IsDelete("bbiProcessAdvance"))
            {
                bool flag = false;
                int[] selectedRows = this.gbList.GetSelectedRows();
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    base.SetWaitDialogCaption("Đang xóa...");
                    HRM_PROCESS_ADVANCE hRMPROCESSADVANCE = new HRM_PROCESS_ADVANCE();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        rowCellValue = this.gbList.GetRowCellValue(selectedRows[i - 1], "AdvanceID");
                        if (rowCellValue != null)
                        {
                          //  SYS_LOG.Insert("Tạm Ứng", "Xoá", rowCellValue.ToString());
                            str = hRMPROCESSADVANCE.Delete(new Guid(rowCellValue.ToString()));
                            if (str == "OK")
                            {
                                this.gbList.DeleteRow(selectedRows[i - 1]);
                            }
                            else if (str != "OK")
                            {
                                MessageBox.Show(string.Concat("Thông tin không được xóa", str), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                    }
                    this.DoHide();
                    if (!flag)
                    {
                        rowCellValue = this.gbList.GetFocusedRowCellValue("AdvanceID");
                        if (rowCellValue != null)
                        {
                         //   SYS_LOG.Insert("Tạm Ứng", "Xoá", rowCellValue.ToString());
                            base.SetWaitDialogCaption("Đang xóa...");
                            str = hRMPROCESSADVANCE.Delete(new Guid(rowCellValue.ToString()));
                            if (str == "OK")
                            {
                                this.gbList.DeleteRow(this.gbList.FocusedRowHandle);
                            }
                            else if (str != "OK")
                            {
                                MessageBox.Show(string.Concat("Thông tin không được xóa\r\n", str), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            this.DoHide();
                        }
                    }
                }
            }
        }

      

        private void frm_Added(object sender, HRM_PROCESS_ADVANCE Item)
        {
            this.AddRow(Item);
        }

        private void frm_Updated(object sender, HRM_PROCESS_ADVANCE Item)
        {
            this.UpdateRow(Item);
        }

        protected override void Import()
        {
            xfmAdvanceImport _xfmAdvanceImport = new xfmAdvanceImport();
            _xfmAdvanceImport.Success += new xfmBaseImport.SuccessEventHander((object s) => this.Reload());
            _xfmAdvanceImport.ShowDialog();
        }


        protected override void LoadGrid()
        {
            base.LoadGrid();
            HRM_PROCESS_ADVANCE hRMPROCESSADVANCE = new HRM_PROCESS_ADVANCE();
            this.gcList.DataSource = hRMPROCESSADVANCE.GetAllListByDays(this.m_FromDate, this.m_ToDate);
        }

        protected override void Print()
        {
          //  SYS_LOG.Insert("Tạm Ứng", "In");
            //xfmReport _xfmReport = new xfmReport();
            //_xfmReport.SetTitle("Sổ Theo Dõi Tạm Ứng");
            //_xfmReport.ShowPrintPreview(new rptListAdvance(this.m_FromDate, this.m_ToDate));
        }

        private void UpdateRow(HRM_PROCESS_ADVANCE item)
        {
            GridView gridView = this.gbList;
            int focusedRowHandle = this.gbList.FocusedRowHandle;
            gridView.SetRowCellValue(focusedRowHandle, "AdvanceID", item.AdvanceID);
            gridView.SetRowCellValue(focusedRowHandle, "EmployeeCode", item.EmployeeCode);
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.Get(item.EmployeeCode);
            gridView.SetRowCellValue(focusedRowHandle, "DepartmentName", hRMEMPLOYEE.DepartmentName);
            gridView.SetRowCellValue(focusedRowHandle, "GroupName", hRMEMPLOYEE.GroupName);
            gridView.SetRowCellValue(focusedRowHandle, "FirstName", hRMEMPLOYEE.FirstName);
            gridView.SetRowCellValue(focusedRowHandle, "LastName", hRMEMPLOYEE.LastName);
            gridView.SetRowCellValue(focusedRowHandle, "Reason", item.Reason);
            gridView.SetRowCellValue(focusedRowHandle, "Date", item.Date);
            gridView.SetRowCellValue(focusedRowHandle, "Money", item.Money);
            gridView.SetRowCellValue(focusedRowHandle, "Person", item.Person);
            gridView.UpdateCurrentRow();
        }
    }
}
