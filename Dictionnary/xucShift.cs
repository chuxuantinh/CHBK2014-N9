using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class xucShift : xucBaseBasic
    {
        public xucShift()
        {
            InitializeComponent();
            this.ucToolBar.SetInterface();
        }

        protected override void Add()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiShift") != "OK"))
            {
                if (MyRule.AllowAdd)
                {
                    xfmShiftAdd _xfmShiftAdd = new xfmShiftAdd(Actions.Add);
                    _xfmShiftAdd.Added += new xfmShiftAdd.AddedEventHander(this.frm_Added);
                    _xfmShiftAdd.ShowDialog();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        private void AddRow(DIC_SHIFT Item)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.AddNewRow();
            focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.SetRowCellValue(focusedRowHandle, "BeginTime", Item.BeginTime);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "EndTime", Item.EndTime);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "ShiftCode", Item.ShiftCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "ShiftName", Item.ShiftName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Description", Item.Description);
            advBandedGridView.UpdateCurrentRow();
            this.RaiseAddedEventHander(Item);
        }

        public override void Change()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiShift") != "OK"))
            {
                if (MyRule.AllowAccess)
                {
                    DIC_SHIFT dICSHIFT = new DIC_SHIFT();
                    object cellValue = base.GetCellValue(this.m_RowClickEventArgs.RowIndex, "ShiftCode");
                    if (cellValue != null)
                    {
                        base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                        if (!(dICSHIFT.Get(cellValue.ToString()) != "OK"))
                        {
                            this.DoHide();
                            xfmShiftAdd _xfmShiftAdd = new xfmShiftAdd(Actions.Update, dICSHIFT);
                            _xfmShiftAdd.Updated += new xfmShiftAdd.UpdatedEventHander(this.frm_Updated);
                            _xfmShiftAdd.Added += new xfmShiftAdd.AddedEventHander(this.frm_Added);
                            _xfmShiftAdd.ShowDialog();
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
            if (!(MyRule.Get(MyLogin.RoleId, "bbiShift") != "OK"))
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
                    DIC_SHIFT dICSHIFT = new DIC_SHIFT();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        cellValue = base.GetCellValue(selectedRows[i - 1], "ShiftCode");
                        if (cellValue != null)
                        {
                           // SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Xoá", cellValue.ToString());
                            str = dICSHIFT.Delete(cellValue.ToString());
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
                            cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "ShiftCode");
                            if (cellValue == null)
                            {
                                return;
                            }
                           // SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Xoá", cellValue.ToString());
                            base.SetWaitDialogCaption("Đang xóa...");
                            str = dICSHIFT.Delete(cellValue.ToString());
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
            if (MyRule.Get(MyLogin.RoleId, "bbiShift") != "OK")
            {
                flag = false;
            }
            else if (MyRule.AllowExport)
            {
               // SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Xuất");
                flag = base.ExportPermision();
            }
            else
            {
                MyRule.Notify();
                flag = false;
            }
            return flag;
        }

        private void frm_Added(object sender, DIC_SHIFT e)
        {
            this.AddRow(e);
        }

        private void frm_Updated(object sender, DIC_SHIFT Item)
        {
            this.UpdateRow(Item, this.m_RowClickEventArgs);
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
            RowClickEventArgs rowClickEventArg = new RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
            object cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "ShiftCode");
            base.DisableMenu(false);
            if (cellValue == null)
            {
                base.DisableMenu(true);
            }
        }

       

        protected override void List_Init(AdvBandedGridView dt)
        {
            int i;
            RepositoryItemTimeEdit repositoryItemTimeEdit = new RepositoryItemTimeEdit()
            {
                EditMask = "HH:mm tt"
            };
            StyleFormatCondition styleFormatCondition = new StyleFormatCondition();
            styleFormatCondition.Appearance.BackColor = Color.Ivory;
            styleFormatCondition.Appearance.Options.UseBackColor = true;
            styleFormatCondition.ApplyToRow = true;
            styleFormatCondition.Condition = FormatConditionEnum.Expression;
            styleFormatCondition.Expression = "[IsNightDay] == 1";
            this.gbList.FormatConditions.AddRange(new StyleFormatCondition[] { styleFormatCondition });
            for (i = 0; i < dt.Columns.Count; i++)
            {
                string fieldName = dt.Columns[i].FieldName;
                if (fieldName != null)
                {
                    switch (fieldName)
                    {
                        case "ShiftCode":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                              
                                    dt.Columns[i].Caption = "Mã";
                               
                                dt.Columns[i].Width = 80;
                                break;
                            }
                        case "ShiftName":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                               
                                    dt.Columns[i].Caption = "Tên";
                               
                                dt.Columns[i].Width = 180;
                                break;
                            }
                        case "BeginTime":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].ColumnEdit = repositoryItemTimeEdit;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                              
                                    dt.Columns[i].Caption = "Giờ Vào";
                               
                                dt.Columns[i].Width = 180;
                                break;
                            }
                        case "EndTime":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].ColumnEdit = repositoryItemTimeEdit;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                               
                                    dt.Columns[i].Caption = "Giờ Ra";
                               
                                dt.Columns[i].Width = 180;
                                break;
                            }
                        case "IsNightDay":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Visible = false;
                               
                                    dt.Columns[i].Caption = "Được Phép Chỉnh Sửa";
                              
                                dt.Columns[i].Width = 150;
                                break;
                            }
                        case "Description":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                              
                                    dt.Columns[i].Caption = "Ghi chú";
                               
                                dt.Columns[i].Width = 150;
                                break;
                            }
                        default:
                            {
                                goto Label0;
                            }
                    }
                }
                else
                {
                    goto Label0;
                }
        //    Label1:
            }
            return;
        Label0:
            dt.Columns[i].Visible = false;
          //  goto Label1;
        }

        protected override void Print()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiShift") != "OK"))
            {
                if (MyRule.AllowPrint)
                {
                  //  SYS_LOG.Insert("Danh Mục Ca Làm Việc", "In");
                    base.Print();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        public void RaiseAddedEventHander(DIC_SHIFT Item)
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

        public void RaiseUpdatedEventHander(DIC_SHIFT Item)
        {
            if (this.Updated != null)
            {
                this.Updated(this, Item);
            }
        }

        public override void ReLoad()
        {
            base.SetWaitDialogCaption("Đang nạp dữ liệu...");
            DIC_SHIFT dICSHIFT = new DIC_SHIFT();
            this.gcList.DataSource = dICSHIFT.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.List_Init(this.gbList);
            base.SetWaitDialogCaption("Nạp quyền sử dụng...");
            MyRule.Get(MyLogin.RoleId, "bbiShift");
            if (!MyRule.AllowPrint)
            {
                this.ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiShift");
            if (!MyRule.AllowExport)
            {
                this.ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiShift");
            if (!MyRule.AllowAdd)
            {
                this.ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiShift");
            if (!MyRule.AllowDelete)
            {
                this.ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiShift");
            if (!MyRule.AllowEdit)
            {
                this.ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            }
            base.SetWaitDialogCaption("Đã xong...");
            this.DoHide();
        }

        private void UpdateRow(DIC_SHIFT item, RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int rowIndex = e.RowIndex;
            advBandedGridView.SetRowCellValue(rowIndex, "BeginTime", item.BeginTime);
            advBandedGridView.SetRowCellValue(rowIndex, "EndTime", item.EndTime);
            advBandedGridView.SetRowCellValue(rowIndex, "ShiftCode", item.ShiftCode);
            advBandedGridView.SetRowCellValue(rowIndex, "ShiftName", item.ShiftName);
            advBandedGridView.SetRowCellValue(rowIndex, "Description", item.Description);
            advBandedGridView.UpdateCurrentRow();
            this.RaiseUpdatedEventHander(item);
        }

        private void xucCustomerType_Load(object sender, EventArgs e)
        {
        }

        public event xucShift.AddedEventHander Added;

        public event DeletedEventHander Deleted;

        public event xucShift.UpdatedEventHander Updated;

        public delegate void AddedEventHander(object sender, DIC_SHIFT Item);

        public delegate void DeletedEventHandler(object sender, RowClickEventArgs e);

        public delegate void UpdatedEventHander(object sender, DIC_SHIFT Item);
    }
}
