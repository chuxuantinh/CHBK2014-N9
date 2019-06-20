﻿using DevExpress.Utils;
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
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucGroupRate : xucBaseBasic
    {
        public xucGroupRate()
        {
            InitializeComponent();
            this.ucToolBar.SetInterface();
        }

     
        protected override void Add()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiJob") != "OK"))
            {
                if (MyRule.AllowAdd)
                {
                    xfmGroupRateAdd _xfmGroupRateAdd = new xfmGroupRateAdd(Actions.Add);
                    _xfmGroupRateAdd.Added += new xfmGroupRateAdd.AddedEventHander(this.frm_Added);
                    _xfmGroupRateAdd.ShowDialog();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        private void AddRow(DIC_GROUP_RATE Item)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.AddNewRow();
            focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Active", Item.Active);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "GroupRateCode", Item.GroupRateCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "GroupRateName", Item.GroupRateName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Description", Item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

        public override void Change()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiJob") != "OK"))
            {
                if (MyRule.AllowAccess)
                {
                    DIC_GROUP_RATE dICGROUPRATE = new DIC_GROUP_RATE();
                    object cellValue = base.GetCellValue(this.m_RowClickEventArgs.RowIndex, "GroupRateCode");
                    if (cellValue != null)
                    {
                        base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                        if (!(dICGROUPRATE.Get(cellValue.ToString()) != "OK"))
                        {
                            this.DoHide();
                            xfmGroupRateAdd _xfmGroupRateAdd = new xfmGroupRateAdd(Actions.Update, dICGROUPRATE);
                            _xfmGroupRateAdd.Updated += new xfmGroupRateAdd.UpdatedEventHander(this.frm_Updated);
                            _xfmGroupRateAdd.Added += new xfmGroupRateAdd.AddedEventHander(this.frm_Added);
                            _xfmGroupRateAdd.ShowDialog();
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
            if (!(MyRule.Get(MyLogin.RoleId, "bbiJob") != "OK"))
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
                    DIC_GROUP_RATE dICGROUPRATE = new DIC_GROUP_RATE();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        cellValue = base.GetCellValue(selectedRows[i - 1], "GroupRateCode");
                        if (cellValue != null)
                        {
                          //  SYS_LOG.Insert("Nhóm Tiêu Chí", "Xoá", cellValue.ToString());
                            str = dICGROUPRATE.Delete(cellValue.ToString());
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
                            cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "GroupRateCode");
                            if (cellValue != null)
                            {
                             //   SYS_LOG.Insert("Nhóm Tiêu Chí", "Xoá", cellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = dICGROUPRATE.Delete(cellValue.ToString());
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
            if (MyRule.Get(MyLogin.RoleId, "bbiJob") != "OK")
            {
                flag = false;
            }
            else if (MyRule.AllowExport)
            {
              //  SYS_LOG.Insert("Nhóm Tiêu Chí", "Xuất");
                flag = base.ExportPermision();
            }
            else
            {
                MyRule.Notify();
                flag = false;
            }
            return flag;
        }

        private void frm_Added(object sender, DIC_GROUP_RATE e)
        {
            this.AddRow(e);
        }

        private void frm_Updated(object sender, DIC_GROUP_RATE Item)
        {
            this.UpdateRow(Item, this.m_RowClickEventArgs);
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
            RowClickEventArgs rowClickEventArg = new RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
            object cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "GroupRateCode");
            base.DisableMenu(false);
            if (cellValue == null)
            {
                base.DisableMenu(true);
            }
        }


        protected override void List_Init(AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string fieldName = dt.Columns[i].FieldName;
                if (fieldName != null)
                {
                    if (fieldName == "GroupRateCode")
                    {
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;

                        dt.Columns[i].Caption = "Mã";
                    
                        dt.Columns[i].Width = 60;
                        goto Label0;
                    }
                    else if (fieldName == "GroupRateName")
                    {
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;

                        dt.Columns[i].Caption = "Tên";
                       
                        dt.Columns[i].Width = 180;
                        goto Label0;
                    }
                    else
                    {
                        if (fieldName != "Description")
                        {
                            goto Label2;
                        }
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                        
                            dt.Columns[i].Caption ="Ghi chú";
                       
                        dt.Columns[i].Width = 150;
                        goto Label0;
                    }
                }
            Label2:
                dt.Columns[i].Visible = false;
            Label0:;
            }
        }

        protected override void Print()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiJob") != "OK"))
            {
                if (MyRule.AllowPrint)
                {
                  //  SYS_LOG.Insert("Nhóm Tiêu Chí", "In");
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
            DIC_GROUP_RATE dICGROUPRATE = new DIC_GROUP_RATE();
            this.gcList.DataSource = dICGROUPRATE.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.List_Init(this.gbList);
            base.SetWaitDialogCaption("Nạp quyền sử dụng...");
            MyRule.Get(MyLogin.RoleId, "bbiJob");
            if (!MyRule.AllowPrint)
            {
                this.ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiJob");
            if (!MyRule.AllowExport)
            {
                this.ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiJob");
            if (!MyRule.AllowAdd)
            {
                this.ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiJob");
            if (!MyRule.AllowDelete)
            {
                this.ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiJob");
            if (!MyRule.AllowEdit)
            {
                this.ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            }
            base.SetWaitDialogCaption("Đã xong...");
            this.DoHide();
        }

        private void UpdateRow(DIC_GROUP_RATE item, RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int rowIndex = e.RowIndex;
            advBandedGridView.SetRowCellValue(rowIndex, "Active", item.Active);
            advBandedGridView.SetRowCellValue(rowIndex, "GroupRateCode", item.GroupRateCode);
            advBandedGridView.SetRowCellValue(rowIndex, "GroupRateName", item.GroupRateName);
            advBandedGridView.SetRowCellValue(rowIndex, "Description", item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

        private void xucCustomerType_Load(object sender, EventArgs e)
        {
        }
    }
}