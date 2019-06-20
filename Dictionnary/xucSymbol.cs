using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucSymbol : xucBaseBasic
    {
        public xucSymbol()
        {
            this.InitializeComponent();
            this.ucToolBar.SetInterface();
        }

        protected override void Add()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiSymbol") != "OK"))
            {
                if (MyRule.AllowAdd)
                {
                    xfmSymbolAdd _xfmSymbolAdd = new xfmSymbolAdd(Actions.Add);
                    _xfmSymbolAdd.Added += new xfmSymbolAdd.AddedEventHander(this.frm_Added);
                    _xfmSymbolAdd.ShowDialog();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        private void AddRow(DIC_SYMBOL Item)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.AddNewRow();
            focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.SetRowCellValue(focusedRowHandle, "IsEdit", Item.IsEdit);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "SymbolCode", Item.SymbolCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "SymbolName", Item.SymbolName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "PercentSalary", Item.PercentSalary);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Description", Item.Description);
            advBandedGridView.UpdateCurrentRow();
            this.RaiseAddedEventHander(Item);
        }

        public override void Change()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiSymbol") != "OK"))
            {
                if (MyRule.AllowAccess)
                {
                    DIC_SYMBOL dICSYMBOL = new DIC_SYMBOL();
                    object cellValue = base.GetCellValue(this.m_RowClickEventArgs.RowIndex, "SymbolCode");
                    if (cellValue != null)
                    {
                        base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                        if (!(dICSYMBOL.Get(cellValue.ToString()) != "OK"))
                        {
                            this.DoHide();
                            xfmSymbolAdd _xfmSymbolAdd = new xfmSymbolAdd(Actions.Update, dICSYMBOL);
                            _xfmSymbolAdd.Updated += new xfmSymbolAdd.UpdatedEventHander(this.frm_Updated);
                            _xfmSymbolAdd.Added += new xfmSymbolAdd.AddedEventHander(this.frm_Added);
                            _xfmSymbolAdd.ShowDialog();
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
            if (!(MyRule.Get(MyLogin.RoleId, "bbiSymbol") != "OK"))
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
                    DIC_SYMBOL dICSYMBOL = new DIC_SYMBOL();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        cellValue = base.GetCellValue(selectedRows[i - 1], "SymbolCode");
                        if (cellValue != null)
                        {
                            dICSYMBOL.Get(cellValue.ToString());
                            if (dICSYMBOL.IsEdit)
                            {
                                flag = true;
                             //   SYS_LOG.Insert("Danh Mục Ký Hiệu Chấm Công", "Xoá", cellValue.ToString());
                                str = dICSYMBOL.Delete(cellValue.ToString());
                                if (str == "OK")
                                {
                                    advBandedGridView.DeleteRow(selectedRows[i - 1]);
                                }
                                else if (str != "OK")
                                {
                                    MessageBox.Show(string.Concat("Thông tin không được xóa\n", str), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Dòng này không thể xóa");
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
                            cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "SymbolCode");
                            if (cellValue != null)
                            {
                                dICSYMBOL.Get(cellValue.ToString());
                                if (!dICSYMBOL.IsEdit)
                                {
                                    MessageBox.Show("Dòng này không thể xóa");
                                    return;
                                }
                             //   SYS_LOG.Insert("Danh Mục Ký Hiệu Chấm Công", "Xoá", cellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = dICSYMBOL.Delete(cellValue.ToString());
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
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    this.RaiseDeletedEventHander();
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
            if (MyRule.Get(MyLogin.RoleId, "bbiSymbol") != "OK")
            {
                flag = false;
            }
            else if (MyRule.AllowExport)
            {
              //  SYS_LOG.Insert("Danh Mục Ký Hiệu Chấm Công", "Xuất");
                flag = base.ExportPermision();
            }
            else
            {
                MyRule.Notify();
                flag = false;
            }
            return flag;
        }

        private void frm_Added(object sender, DIC_SYMBOL e)
        {
            this.AddRow(e);
        }

        private void frm_Updated(object sender, DIC_SYMBOL Item)
        {
            this.UpdateRow(Item, this.m_RowClickEventArgs);
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
            RowClickEventArgs rowClickEventArg = new RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
            object cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "SymbolCode");
            base.DisableMenu(false);
            if (cellValue == null)
            {
                base.DisableMenu(true);
            }
        }

       

        protected override void List_Init(AdvBandedGridView dt)
        {
            int i;
            for (i = 0; i < dt.Columns.Count; i++)
            {
                string fieldName = dt.Columns[i].FieldName;
                if (fieldName == null)
                {
                    goto Label0;
                }
                else if (fieldName == "SymbolCode")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                   
                        dt.Columns[i].Caption = "Mã";
                   
                    dt.Columns[i].Width = 60;
                }
                else if (fieldName == "SymbolName")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                    
                        dt.Columns[i].Caption = "Tên";
                   
                    dt.Columns[i].Width = 180;
                }
                else if (fieldName == "PercentSalary")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                   
                        dt.Columns[i].Caption = "Tiền trừ (% x Lương cơ bản)";
                    
                    dt.Columns[i].Width = 180;
                }
                else if (fieldName == "IsEdit")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                   
                        dt.Columns[i].Caption = "Mặc định";
                    
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
          //  goto Label2;
        }

        private void PreviewData()
        {
            StyleFormatCondition styleFormatCondition = new StyleFormatCondition(FormatConditionEnum.Equal, this.gbList.Columns["IsEdit"], null, true);
            styleFormatCondition.Appearance.BackColor = Color.White;
            this.gbList.FormatConditions.Add(styleFormatCondition);
            styleFormatCondition = new StyleFormatCondition(FormatConditionEnum.Equal, this.gbList.Columns["IsEdit"], null, false);
            styleFormatCondition.Appearance.BackColor = Color.WhiteSmoke;
            this.gbList.FormatConditions.Add(styleFormatCondition);
        }

        protected override void Print()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiSymbol") != "OK"))
            {
                if (MyRule.AllowPrint)
                {
                   // SYS_LOG.Insert("Danh Mục Ký Hiệu Chấm Công", "In");
                    base.Print();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        public void RaiseAddedEventHander(DIC_SYMBOL Item)
        {
            if (this.Added != null)
            {
                this.Added(this, Item);
            }
        }

        public void RaiseDeletedEventHander()
        {
            if (this.Deleted != null)
            {
                this.Deleted(this, this.m_RowClickEventArgs);
            }
        }

        public void RaiseUpdatedEventHander(DIC_SYMBOL Item)
        {
            if (this.Updated != null)
            {
                this.Updated(this, Item);
            }
        }

        public override void ReLoad()
        {
            base.SetWaitDialogCaption("Đang nạp dữ liệu...");
            this.PreviewData();
            DIC_SYMBOL dICSYMBOL = new DIC_SYMBOL();
            this.gcList.DataSource = dICSYMBOL.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.List_Init(this.gbList);
            base.SetWaitDialogCaption("Nạp quyền sử dụng...");
            MyRule.Get(MyLogin.RoleId, "bbiSymbol");
            if (!MyRule.AllowPrint)
            {
                this.ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiSymbol");
            if (!MyRule.AllowExport)
            {
                this.ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiSymbol");
            if (!MyRule.AllowAdd)
            {
                this.ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiSymbol");
            if (!MyRule.AllowDelete)
            {
                this.ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiSymbol");
            if (!MyRule.AllowEdit)
            {
                this.ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            }
            base.SetWaitDialogCaption("Đã xong...");
            this.DoHide();
        }

        private void UpdateRow(DIC_SYMBOL item, RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int rowIndex = e.RowIndex;
            advBandedGridView.SetRowCellValue(rowIndex, "IsEdit", item.IsEdit);
            advBandedGridView.SetRowCellValue(rowIndex, "SymbolCode", item.SymbolCode);
            advBandedGridView.SetRowCellValue(rowIndex, "SymbolName", item.SymbolName);
            advBandedGridView.SetRowCellValue(rowIndex, "PercentSalary", item.PercentSalary);
            advBandedGridView.SetRowCellValue(rowIndex, "Description", item.Description);
            advBandedGridView.UpdateCurrentRow();
            this.RaiseUpdatedEventHander(item);
        }

        private void xucCustomerType_Load(object sender, EventArgs e)
        {
        }

        public event xucSymbol.AddedEventHander Added;

        public event DeletedEventHander Deleted;

        public event xucSymbol.UpdatedEventHander Updated;

        public delegate void AddedEventHander(object sender, DIC_SYMBOL Item);

        public delegate void DeletedEventHandler(object sender, RowClickEventArgs e);

        public delegate void UpdatedEventHander(object sender, DIC_SYMBOL Item);
    }
}
