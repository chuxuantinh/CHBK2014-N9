using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraBars;
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
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucSalaryAllowance : xucSalaryBase
    {
        public xucSalaryAllowance()
        {
            InitializeComponent();
            this._exportView = this.gbList;
            this._exportControl = this.gcList;
        }


        protected override void Add()
        {
            //xfmSalaryAllowanceAdd _xfmSalaryAllowanceAdd = new xfmSalaryAllowanceAdd(Actions.Add, this.m_SalaryTableListID);
            //_xfmSalaryAllowanceAdd.Added += new xfmSalaryAllowanceAdd.AddedEventHander(this.frm_Added);
            //_xfmSalaryAllowanceAdd.ShowDialog();
        }

        private void AddRow(HRM_SALARY_ALLOWANCE item)
        {
            GridView gridView = this.gbList;
            int focusedRowHandle = gridView.FocusedRowHandle;
            gridView.AddNewRow();
            focusedRowHandle = gridView.FocusedRowHandle;
            gridView.SetRowCellValue(focusedRowHandle, "EmployeeCode", item.EmployeeCode);
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.Get(item.EmployeeCode);
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            dICALLOWANCE.Get(item.AllowanceCode);
            gridView.SetRowCellValue(focusedRowHandle, "FirstName", hRMEMPLOYEE.FirstName);
            gridView.SetRowCellValue(focusedRowHandle, "LastName", hRMEMPLOYEE.LastName);
            gridView.SetRowCellValue(focusedRowHandle, "AllowanceCode", item.AllowanceCode);
            gridView.SetRowCellValue(focusedRowHandle, "AllowanceName", dICALLOWANCE.AllowanceName);
            gridView.SetRowCellValue(focusedRowHandle, "Money", item.Money);
            gridView.SetRowCellValue(focusedRowHandle, "IncomeTaxValue", item.IncomeTaxValue);
            gridView.UpdateCurrentRow();
        }

        protected override void Change()
        {
            if (MyRule.IsAccess("bbiSalary"))
            {
                HRM_SALARY_ALLOWANCE hRMSALARYALLOWANCE = new HRM_SALARY_ALLOWANCE();
                object focusedRowCellValue = this.gbList.GetFocusedRowCellValue("EmployeeCode");
                object obj = this.gbList.GetFocusedRowCellValue("AllowanceCode");
                if ((focusedRowCellValue == null ? false : obj != null))
                {
                    base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                    if (!(hRMSALARYALLOWANCE.Get(this.m_SalaryTableListID, focusedRowCellValue.ToString(), obj.ToString()) != "OK"))
                    {
                        this.DoHide();
                        //xfmSalaryAllowanceAdd _xfmSalaryAllowanceAdd = new xfmSalaryAllowanceAdd(Actions.Update, hRMSALARYALLOWANCE);
                        //_xfmSalaryAllowanceAdd.Updated += new xfmSalaryAllowanceAdd.UpdatedEventHander(this.frm_Updated);
                        //_xfmSalaryAllowanceAdd.Added += new xfmSalaryAllowanceAdd.AddedEventHander(this.frm_Added);
                        //_xfmSalaryAllowanceAdd.ShowDialog();
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
            object focusedRowCellValue;
            if (MyRule.IsDelete("bbiSalary"))
            {
                bool flag = false;
                int[] selectedRows = this.gbList.GetSelectedRows();
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    base.SetWaitDialogCaption("Đang xóa...");
                    HRM_SALARY_ALLOWANCE hRMSALARYALLOWANCE = new HRM_SALARY_ALLOWANCE();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        rowCellValue = this.gbList.GetRowCellValue(selectedRows[i - 1], "EmployeeCode");
                        focusedRowCellValue = this.gbList.GetRowCellValue(selectedRows[i - 1], "AllowanceCode");
                        if ((rowCellValue == null ? false : focusedRowCellValue != null))
                        {
                            SYS_LOG.Insert("Phụ Cấp Lương", "Xoá", focusedRowCellValue.ToString());
                            str = hRMSALARYALLOWANCE.Delete(this.m_SalaryTableListID, rowCellValue.ToString(), focusedRowCellValue.ToString());
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
                        if (hRMSALARYALLOWANCE.GetList(this.m_Level, this.m_Code, this.m_SalaryTableListID).Rows.Count != 0)
                        {
                            rowCellValue = this.gbList.GetFocusedRowCellValue("EmployeeCode");
                            focusedRowCellValue = this.gbList.GetFocusedRowCellValue("AllowanceCode");
                            if ((rowCellValue == null ? false : focusedRowCellValue != null))
                            {
                                SYS_LOG.Insert("Phụ Cấp Lương", "Xoá", focusedRowCellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = hRMSALARYALLOWANCE.Delete(this.m_SalaryTableListID, rowCellValue.ToString(), focusedRowCellValue.ToString());
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
            else
            {
                MyRule.Notify();
            }
        }



        private void frm_Added(object sender, HRM_SALARY_ALLOWANCE Item)
        {
            this.AddRow(Item);
        }

        private void frm_Updated(object sender, HRM_SALARY_ALLOWANCE Item)
        {
            this.UpdateRow(Item);
        }

        protected override void Import()
        {
            //base.Import();
            //xfmSalaryAllowanceImport _xfmSalaryAllowanceImport = new xfmSalaryAllowanceImport(this.m_SalaryTableListID);
            //_xfmSalaryAllowanceImport.Success += new xfmBaseImport.SuccessEventHander((object s) => this.Reload());
            //_xfmSalaryAllowanceImport.ShowDialog();
        }


        protected override void LoadGrid()
        {
            base.LoadGrid();
            this.bbeName.EditValue = string.Concat("Tháng ", this.m_Month.ToString(), " - ", this.m_Year.ToString());
            this.lbSalaryName.Text = string.Concat("Bảng Phụ Cấp Lương Tháng ", this.m_Month.ToString(), " - ", this.m_Year.ToString());
            HRM_SALARY_ALLOWANCE hRMSALARYALLOWANCE = new HRM_SALARY_ALLOWANCE();
            this.gcList.DataSource = hRMSALARYALLOWANCE.GetList(this.m_Level, this.m_Code, this.m_SalaryTableListID);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.bbiQuickAdd.Visibility = BarItemVisibility.Never;
        }

        protected override void Print()
        {
            base.Print();
            if (MyRule.IsPrint("bbiSalary"))
            {
                //xfmReport _xfmReport = new xfmReport();
                //rptSalaryAllowance _rptSalaryAllowance = new rptSalaryAllowance(this.m_Level, this.m_Code, this.m_Month, this.m_Year);
                //_xfmReport.SetTitle(string.Concat("Bảng Lương Phụ Cấp Tháng ", this.m_Month.ToString(), "/", this.m_Year.ToString()));
                //_xfmReport.ShowPrintPreview(_rptSalaryAllowance);
            }
            else
            {
                MyRule.Notify();
            }
        }

        protected override void QuickAdd()
        {
        }

        private void UpdateRow(HRM_SALARY_ALLOWANCE item)
        {
            GridView gridView = this.gbList;
            int focusedRowHandle = this.gbList.FocusedRowHandle;
            gridView.SetRowCellValue(focusedRowHandle, "EmployeeCode", item.EmployeeCode);
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.Get(item.EmployeeCode);
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            dICALLOWANCE.Get(item.AllowanceCode);
            gridView.SetRowCellValue(focusedRowHandle, "FirstName", hRMEMPLOYEE.FirstName);
            gridView.SetRowCellValue(focusedRowHandle, "LastName", hRMEMPLOYEE.LastName);
            gridView.SetRowCellValue(focusedRowHandle, "AllowanceCode", item.AllowanceCode);
            gridView.SetRowCellValue(focusedRowHandle, "AllowanceName", dICALLOWANCE.AllowanceName);
            gridView.SetRowCellValue(focusedRowHandle, "Money", item.Money);
            gridView.SetRowCellValue(focusedRowHandle, "IncomeTaxValue", item.IncomeTaxValue);
            gridView.UpdateCurrentRow();
        }




    }
}
