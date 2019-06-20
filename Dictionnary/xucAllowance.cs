using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucAllowance : xucBaseBasic
    {
        public xucAllowance()
        {
            InitializeComponent();
          
            this.ucToolBar.SetInterface();

        }

        protected override void Add()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiAllowance") != "OK"))
            {
                if (MyRule.AllowAdd)
                {
                    xfmAllowanceAdd _xfmAllowanceAdd = new xfmAllowanceAdd(Actions.Add);
                    _xfmAllowanceAdd.Added += new xfmAllowanceAdd.AddedEventHander(this.frm_Added);
                    _xfmAllowanceAdd.ShowDialog();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        private void AddRow(DIC_ALLOWANCE Item)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.AddNewRow();
            focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.SetRowCellValue(focusedRowHandle, "MaximumMoney", Item.MaximumMoney);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "AllowanceCode", Item.AllowanceCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "AllowanceName", Item.AllowanceName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "MaximumMoney", Item.MaximumMoney);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "IncomeTaxValue", Item.IncomeTaxValue);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Description", Item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

        public override void Change()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiAllowance") != "OK"))
            {
                if (MyRule.AllowAccess)
                {
                    DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
                    object cellValue = base.GetCellValue(this.m_RowClickEventArgs.RowIndex, "AllowanceCode");
                    if (cellValue != null)
                    {
                        base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                        if (!(dICALLOWANCE.Get(cellValue.ToString()) != "OK"))
                        {
                            this.DoHide();
                            xfmAllowanceAdd _xfmAllowanceAdd = new xfmAllowanceAdd(Actions.Update, dICALLOWANCE);
                            _xfmAllowanceAdd.Updated += new xfmAllowanceAdd.UpdatedEventHander(this.frm_Updated);
                            _xfmAllowanceAdd.Added += new xfmAllowanceAdd.AddedEventHander(this.frm_Added);
                            _xfmAllowanceAdd.ShowDialog();
                        }
                        else
                        {
                            this.DoHide();
                            XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        public override void Delete()
        {
            object cellValue;
            if (!(MyRule.Get(MyLogin.RoleId, "bbiAllowance") != "OK"))
            {
                if (MyRule.AllowDelete)
                {
                    if (ClsOption.System2.IsQuestion)
                    {
                        if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    base.SetWaitDialogCaption("Đang xóa...");
                    string str = "";
                    bool flag = false;
                    AdvBandedGridView advBandedGridView = this.gbList;
                    int[] selectedRows = advBandedGridView.GetSelectedRows();
                    DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        cellValue = base.GetCellValue(selectedRows[i - 1], "AllowanceCode");
                        if (cellValue != null)
                        {
                            SYS_LOG.Insert("Danh Mục Phụ Cấp", "Xoá", cellValue.ToString());
                            str = dICALLOWANCE.Delete(cellValue.ToString());
                            if (str == "OK")
                            {
                                advBandedGridView.DeleteRow(selectedRows[i - 1]);
                            }
                            else if (str != "OK")
                            {
                                MessageBox.Show(string.Concat("Thông tin không được xóa\n", str), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                    }
                    this.DoHide();
                    if (!flag)
                    {
                        if (advBandedGridView.DataSource != null)
                        {
                            RowClickEventArgs rowClickEventArg = new RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
                            this.m_RowClickEventArgs = rowClickEventArg;
                            cellValue = null;
                            cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "AllowanceCode");
                            if (cellValue != null)
                            {
                                SYS_LOG.Insert("Danh Mục Phụ Cấp", "Xoá", cellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = dICALLOWANCE.Delete(cellValue.ToString());
                                if (str == "OK")
                                {
                                    advBandedGridView.DeleteRow(rowClickEventArg.RowIndex);
                                }
                                else if (str != "OK")
                                {
                                    MessageBox.Show(string.Concat("Thông tin không được xóa\n", str), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                this.DoHide();
                            }
                        }
                    }
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }


        protected override bool ExportPermision()
        {
            bool flag;
            if (MyRule.Get(MyLogin.RoleId, "bbiAllowance") != "OK")
            {
                flag = false;
            }
            else if (MyRule.AllowExport)
            {
                SYS_LOG.Insert("Danh Mục Phụ Cấp", "Xuất");
                flag = base.ExportPermision();
            }
            else
            {
                MyRule.Notify();
                flag = false;
            }
            return flag;
        }

        private void frm_Added(object sender, DIC_ALLOWANCE e)
        {
            this.AddRow(e);
        }

        private void frm_Updated(object sender, DIC_ALLOWANCE Item)
        {
            this.UpdateRow(Item, this.m_RowClickEventArgs);
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
            RowClickEventArgs rowClickEventArg = new RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
            object cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "AllowanceCode");
            base.DisableMenu(false);
            if (cellValue == null)
            {
                base.DisableMenu(true);
            }
        }


        protected override void List_Init(AdvBandedGridView dt)
        {
            int i;
            RepositoryItemCalcEdit repositoryItemCalcEdit = new RepositoryItemCalcEdit();
            repositoryItemCalcEdit.DisplayFormat.FormatString = "{0:##,##0}";
            repositoryItemCalcEdit.EditFormat.FormatString = "{0:##,##0}";
            repositoryItemCalcEdit.Mask.UseMaskAsDisplayFormat = true;
            for (i = 0; i < dt.Columns.Count; i++)
            {
                string fieldName = dt.Columns[i].FieldName;
                if (fieldName == null)
                {
                    goto Label0;
                }
                else if (fieldName == "AllowanceCode")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                  
                        dt.Columns[i].Caption = "Mã";
                   
                    dt.Columns[i].Width = 60;
                }
                else if (fieldName == "AllowanceName")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                     dt.Columns[i].Caption = "Tên";
                    
                    dt.Columns[i].Width = 180;
                }
                else if (fieldName == "MaximumMoney")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].ColumnEdit = repositoryItemCalcEdit;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                   
                        dt.Columns[i].Caption = "Số tiền chi trả (lớn nhất)";
                    
                    dt.Columns[i].Width = 120;
                }
                else if (fieldName == "IncomeTaxValue")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].ColumnEdit = repositoryItemCalcEdit;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                  
                        dt.Columns[i].Caption =  "Giảm trừ thuế %";
                   
                    dt.Columns[i].Width = 120;
                }
                else
                {
                    if (fieldName != "Description")
                    {
                        goto Label0;
                    }
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                   
                        dt.Columns[i].Caption = "Ghi chú";
                  
                    dt.Columns[i].Width = 150;
                }
          //  Label2:
            }
            return;
        Label0:
            dt.Columns[i].Visible = false;
         //   goto Label2;
        }

        protected override void Print()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiAllowance") != "OK"))
            {
                if (MyRule.AllowPrint)
                {
                    SYS_LOG.Insert("Danh Mục Phụ Cấp", "In");
                    base.Print();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        public override void ReLoad()
        {
            base.SetWaitDialogCaption("Đang nạp dữ liệu...");
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            this.gcList.DataSource = dICALLOWANCE.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.List_Init(this.gbList);
            base.SetWaitDialogCaption("Nạp quyền sử dụng...");
            MyRule.Get(MyLogin.RoleId, "bbiAllowance");
            if (!MyRule.AllowPrint)
            {
                this.ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiAllowance");
            if (!MyRule.AllowExport)
            {
                this.ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiAllowance");
            if (!MyRule.AllowAdd)
            {
                this.ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiAllowance");
            if (!MyRule.AllowDelete)
            {
                this.ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiAllowance");
            if (!MyRule.AllowEdit)
            {
                this.ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            }
            base.SetWaitDialogCaption("Đã xong...");
            this.DoHide();
        }

        private void UpdateRow(DIC_ALLOWANCE item, RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int rowIndex = e.RowIndex;
            advBandedGridView.SetRowCellValue(rowIndex, "MaximumMoney", item.MaximumMoney);
            advBandedGridView.SetRowCellValue(rowIndex, "AllowanceCode", item.AllowanceCode);
            advBandedGridView.SetRowCellValue(rowIndex, "AllowanceName", item.AllowanceName);
            advBandedGridView.SetRowCellValue(rowIndex, "MaximumMoney", item.MaximumMoney);
            advBandedGridView.SetRowCellValue(rowIndex, "IncomeTaxValue", item.IncomeTaxValue);
            advBandedGridView.SetRowCellValue(rowIndex, "Description", item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

    }
}
