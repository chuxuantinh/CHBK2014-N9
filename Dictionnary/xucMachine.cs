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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucMachine : xucBaseBasic
    {
        public xucMachine()
        {
            InitializeComponent();
            this.ucToolBar.SetInterface();
        }


        protected override void Add()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiMachine") != "OK"))
            {
                if (MyRule.AllowAdd)
                {
                    xfmMachineAdd _xfmMachineAdd = new xfmMachineAdd(Actions.Add);
                    _xfmMachineAdd.Added += new xfmMachineAdd.AddedEventHander(this.frm_Added);
                    _xfmMachineAdd.ShowDialog();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        private void AddRow(DIC_MACHINE Item)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.AddNewRow();
            focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.SetRowCellValue(focusedRowHandle, "MachineCode", Item.MachineCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "MachineName", Item.MachineName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "PortType", Item.PortType);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "PortID", Item.PortID);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "IP", Item.IP);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Com", Item.Com);
            advBandedGridView.UpdateCurrentRow();
            this.RaiseAddedEventHander(Item);
        }

        public override void Change()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiMachine") != "OK"))
            {
                if (MyRule.AllowAccess)
                {
                    DIC_MACHINE dICMACHINE = new DIC_MACHINE();
                    object cellValue = base.GetCellValue(this.m_RowClickEventArgs.RowIndex, "MachineCode");
                    if (cellValue != null)
                    {
                        base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                        if (!(dICMACHINE.Get(cellValue.ToString()) != "OK"))
                        {
                            this.DoHide();
                            xfmMachineAdd _xfmMachineAdd = new xfmMachineAdd(Actions.Update, dICMACHINE);
                            _xfmMachineAdd.Updated += new xfmMachineAdd.UpdatedEventHander(this.frm_Updated);
                            _xfmMachineAdd.Added += new xfmMachineAdd.AddedEventHander(this.frm_Added);
                            _xfmMachineAdd.ShowDialog();
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
            if (!(MyRule.Get(MyLogin.RoleId, "bbiMachine") != "OK"))
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
                    DIC_MACHINE dICMACHINE = new DIC_MACHINE();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        cellValue = base.GetCellValue(selectedRows[i - 1], "MachineCode");
                        if (cellValue != null)
                        {
                         //   SYS_LOG.Insert("Danh Sách Thiết Bị", "Xoá", cellValue.ToString());
                            dICMACHINE.Get(cellValue.ToString());
                            str = dICMACHINE.Delete(cellValue.ToString());
                            if (str == "OK")
                            {
                                advBandedGridView.DeleteRow(selectedRows[i - 1]);
                                this.RaiseDeletedEventHander(dICMACHINE);
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
                            cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "MachineCode");
                            if (cellValue != null)
                            {
                              //  SYS_LOG.Insert("Danh Mục Ca Làm Việc", "Xoá", cellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                dICMACHINE.Get(cellValue.ToString());
                                str = dICMACHINE.Delete(cellValue.ToString());
                                if (str == "OK")
                                {
                                    advBandedGridView.DeleteRow(rowClickEventArg.RowIndex);
                                    this.RaiseDeletedEventHander(dICMACHINE);
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
            if (MyRule.Get(MyLogin.RoleId, "bbiMachine") != "OK")
            {
                flag = false;
            }
            else if (MyRule.AllowExport)
            {
               // SYS_LOG.Insert("Danh Sách Thiết Bị", "Xuất");
                flag = base.ExportPermision();
            }
            else
            {
                MyRule.Notify();
                flag = false;
            }
            return flag;
        }

        private void frm_Added(object sender, DIC_MACHINE e)
        {
            this.AddRow(e);
        }

        private void frm_Updated(object sender, DIC_MACHINE Item)
        {
            this.UpdateRow(Item, this.m_RowClickEventArgs);
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
            RowClickEventArgs rowClickEventArg = new RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
            object cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "MachineCode");
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
                if (fieldName != null)
                {
                    switch (fieldName)
                    {
                        case "MachineCode":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                               
                                    dt.Columns[i].Caption = "Mã";
                                
                                dt.Columns[i].Width = 60;
                                break;
                            }
                        case "MachineName":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                               
                                    dt.Columns[i].Caption = "Tên";
                              
                                dt.Columns[i].Width = 180;
                                break;
                            }
                        case "PortType":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                  dt.Columns[i].Caption = "Loại cổng";
                               
                                dt.Columns[i].Width = 180;
                                break;
                            }
                        case "PortID":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                               
                                    dt.Columns[i].Caption = "Cổng số";
                               
                                dt.Columns[i].Width = 180;
                                break;
                            }
                        case "IP":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                              
                                    dt.Columns[i].Caption = "IP";
                             
                                dt.Columns[i].Width = 150;
                                break;
                            }
                        case "Com":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                               
                                    dt.Columns[i].Caption = "Com";
                              
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
          //  Label1:;
            }
            return;
        Label0:
            dt.Columns[i].Visible = false;
         //   goto Label1;
        }

        protected override void Print()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiMachine") != "OK"))
            {
                if (MyRule.AllowPrint)
                {
                   // SYS_LOG.Insert("Danh Sách Thiết Bị", "In");
                    base.Print();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        public void RaiseAddedEventHander(DIC_MACHINE Item)
        {
            if (this.Added != null)
            {
                this.Added(this, Item);
            }
        }

        public void RaiseDeletedEventHander(DIC_MACHINE Item)
        {
            if (this.Deleted != null)
            {
                this.Deleted(this, Item, this.m_RowClickEventArgs);
            }
        }

        public void RaiseUpdatedEventHander(DIC_MACHINE Item)
        {
            if (this.Updated != null)
            {
                this.Updated(this, Item);
            }
        }

        public override void ReLoad()
        {
            base.SetWaitDialogCaption("Đang nạp dữ liệu...");
            DIC_MACHINE dICMACHINE = new DIC_MACHINE();
            this.gcList.DataSource = dICMACHINE.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.List_Init(this.gbList);
            base.SetWaitDialogCaption("Nạp quyền sử dụng...");
            MyRule.Get(MyLogin.RoleId, "bbiMachine");
            if (!MyRule.AllowPrint)
            {
                this.ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiMachine");
            if (!MyRule.AllowExport)
            {
                this.ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiMachine");
            if (!MyRule.AllowAdd)
            {
                this.ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiMachine");
            if (!MyRule.AllowDelete)
            {
                this.ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiMachine");
            if (!MyRule.AllowEdit)
            {
                this.ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            }
            base.SetWaitDialogCaption("Đã xong...");
            this.DoHide();
        }

        private void UpdateRow(DIC_MACHINE item, RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int rowIndex = e.RowIndex;
            advBandedGridView.SetRowCellValue(rowIndex, "MachineCode", item.MachineCode);
            advBandedGridView.SetRowCellValue(rowIndex, "MachineName", item.MachineName);
            advBandedGridView.SetRowCellValue(rowIndex, "PortType", item.PortType);
            advBandedGridView.SetRowCellValue(rowIndex, "PortID", item.PortID);
            advBandedGridView.SetRowCellValue(rowIndex, "IP", item.IP);
            advBandedGridView.SetRowCellValue(rowIndex, "Com", item.Com);
            advBandedGridView.UpdateCurrentRow();
            this.RaiseUpdatedEventHander(item);
        }

        private void xucCustomerType_Load(object sender, EventArgs e)
        {
        }

        public event xucMachine.AddedEventHander Added;

        public event xucMachine.DeletedEventHandler Deleted;

        public event xucMachine.UpdatedEventHander Updated;

        public delegate void AddedEventHander(object sender, DIC_MACHINE Item);

        public delegate void DeletedEventHandler(object sender, DIC_MACHINE Item, RowClickEventArgs e);

        public delegate void UpdatedEventHander(object sender, DIC_MACHINE Item);
    }
}
