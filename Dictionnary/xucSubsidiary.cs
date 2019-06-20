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
//using CHBK2014_N9.Common.Report;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucSubsidiary : xucBaseBasic
    {
        public xucSubsidiary()
        {
            InitializeComponent();
        }

        protected override void Add()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiSubsidiary") != "OK"))
            {
                if (MyRule.AllowAdd)
                {
                    xfmSubsidiaryAdd _xfmSubsidiaryAdd = new xfmSubsidiaryAdd(Actions.Add);
                    _xfmSubsidiaryAdd.Added += new xfmSubsidiaryAdd.AddedEventHander(this.frm_Added);
                    _xfmSubsidiaryAdd.ShowDialog();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        private void AddRow(HRM_SUBSIDIARY Item)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.AddNewRow();
            focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.SetRowCellValue(focusedRowHandle, "SubsidiaryCode", Item.SubsidiaryCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "SubsidiaryName", Item.SubsidiaryName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Address", Item.Address);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Phone", Item.Phone);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Fax", Item.Fax);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "WebSite", Item.WebSite);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Email", Item.Email);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Tax", Item.Tax);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "BankAccount", Item.BankAccount);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "OpenedAt", Item.OpenedAt);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "BankAbbreviationName", Item.BankAbbreviationName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "BankBranch", Item.BankBranch);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "PersonName", Item.PersonName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Quantity", Item.Quantity);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Description", Item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

        public override void Change()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiSubsidiary") != "OK"))
            {
                if (MyRule.AllowAccess)
                {
                    HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
                    object cellValue = base.GetCellValue(this.m_RowClickEventArgs.RowIndex, "SubsidiaryCode");
                    if (cellValue != null)
                    {
                        base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                        if (!(hRMSUBSIDIARY.Get(cellValue.ToString()) != "OK"))
                        {
                            this.DoHide();
                            xfmSubsidiaryAdd _xfmSubsidiaryAdd = new xfmSubsidiaryAdd(Actions.Update, hRMSUBSIDIARY);
                            _xfmSubsidiaryAdd.Updated += new xfmSubsidiaryAdd.UpdatedEventHander(this.frm_Updated);
                            _xfmSubsidiaryAdd.Added += new xfmSubsidiaryAdd.AddedEventHander(this.frm_Added);
                            _xfmSubsidiaryAdd.ShowDialog();
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
            if (!(MyRule.Get(MyLogin.RoleId, "bbiSubsidiary") != "OK"))
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
                    HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        cellValue = base.GetCellValue(selectedRows[i - 1], "SubsidiaryCode");
                        if (cellValue != null)
                        {
                          //  SYS_LOG.Insert("Danh Sách Công Ty Con", "Xoá", cellValue.ToString());
                            str = hRMSUBSIDIARY.Delete(cellValue.ToString());
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
                            cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "SubsidiaryCode");
                            if (cellValue != null)
                            {
                              //  SYS_LOG.Insert("Danh Sách Công Ty Con", "Xoá", cellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = hRMSUBSIDIARY.Delete(cellValue.ToString());
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
            if (MyRule.IsExport("bbiSubsidiary"))
            {
             //   SYS_LOG.Insert("Danh Sách Công Ty Con", "Xuất");
                flag = base.ExportPermision();
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        private void frm_Added(object sender, HRM_SUBSIDIARY e)
        {
            this.AddRow(e);
        }

        private void frm_Updated(object sender, HRM_SUBSIDIARY Item)
        {
            this.UpdateRow(Item, this.m_RowClickEventArgs);
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
            RowClickEventArgs rowClickEventArg = new RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
            object cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "SubsidiaryCode");
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
                        case "SubsidiaryCode":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "Mã công ty con";
                                dt.Columns[i].Width = 80;
                                break;
                            }
                        case "SubsidiaryName":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "Tên công ty con";
                                dt.Columns[i].Width = 200;
                                break;
                            }
                        case "Address":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption =  "Địa chỉ";
                                dt.Columns[i].Width = 200;
                                break;
                            }
                        case "Phone":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "Số điện thoại";
                                dt.Columns[i].Width = 140;
                                break;
                            }
                        case "Fax":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "Fax";
                                dt.Columns[i].Width = 140;
                                break;
                            }
                        case "WebSite":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "WebSite";
                                dt.Columns[i].Width = 140;
                                break;
                            }
                        case "Email":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                               
                                    dt.Columns[i].Caption = "Email";
                              
                                dt.Columns[i].Width = 140;
                                break;
                            }
                        case "Tax":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "Mã số thuế";
                                dt.Columns[i].Width = 140;
                                break;
                            }
                        case "BankAccount":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "Tài khoản ngân hàng";
                                dt.Columns[i].Width = 140;
                                break;
                            }
                        case "OpenedAt":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "Tên ngân hàng";
                                dt.Columns[i].Width = 140;
                                break;
                            }
                        case "BankAbbreviationName":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "Tên ngân hàng viết tắt";
                                dt.Columns[i].Width = 140;
                                break;
                            }
                        case "BankBranch":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "Chi nhánh ngân hàng";
                                dt.Columns[i].Width = 140;
                                break;
                            }
                        case "PersonName":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption = "Người đại diện";
                                dt.Columns[i].Width = 140;
                                break;
                            }
                        case "Quantity":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].Caption =  "Số lượng nhân viên";
                                dt.Columns[i].Width = 60;
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
           // Label1:
            }
            return;
        Label0:
            dt.Columns[i].Visible = false;
          //  goto Label1;
        }

        protected override void Print()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiSubsidiary") != "OK"))
            {
                if (MyRule.AllowPrint)
                {
                 //   SYS_LOG.Insert("Danh Sách Công Ty Con", "In");
                  //  (new xfmReport("Danh Sách Công Ty Con")).ShowPrintPreview(this.gcList);
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
            HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
            this.gcList.DataSource = hRMSUBSIDIARY.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.List_Init(this.gbList);
            base.SetWaitDialogCaption("Nạp quyền sử dụng...");
            MyRule.Get(MyLogin.RoleId, "bbiSubsidiary");
            if (!MyRule.AllowPrint)
            {
                this.ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiSubsidiary");
            if (!MyRule.AllowExport)
            {
                this.ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiSubsidiary");
            if (!MyRule.AllowAdd)
            {
                this.ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiSubsidiary");
            if (!MyRule.AllowDelete)
            {
                this.ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiSubsidiary");
            if (!MyRule.AllowEdit)
            {
                this.ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            }
            base.SetWaitDialogCaption("Đã xong...");
            this.gbList.OptionsView.ColumnAutoWidth = false;
            this.DoHide();
        }

        private void UpdateRow(HRM_SUBSIDIARY item, RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int rowIndex = e.RowIndex;
            advBandedGridView.SetRowCellValue(rowIndex, "SubsidiaryCode", item.SubsidiaryCode);
            advBandedGridView.SetRowCellValue(rowIndex, "SubsidiaryName", item.SubsidiaryName);
            advBandedGridView.SetRowCellValue(rowIndex, "Address", item.Address);
            advBandedGridView.SetRowCellValue(rowIndex, "Phone", item.Phone);
            advBandedGridView.SetRowCellValue(rowIndex, "Fax", item.Fax);
            advBandedGridView.SetRowCellValue(rowIndex, "WebSite", item.WebSite);
            advBandedGridView.SetRowCellValue(rowIndex, "Email", item.Email);
            advBandedGridView.SetRowCellValue(rowIndex, "Tax", item.Tax);
            advBandedGridView.SetRowCellValue(rowIndex, "BankAccount", item.BankAccount);
            advBandedGridView.SetRowCellValue(rowIndex, "OpenedAt", item.OpenedAt);
            advBandedGridView.SetRowCellValue(rowIndex, "BankAbbreviationName", item.BankAbbreviationName);
            advBandedGridView.SetRowCellValue(rowIndex, "BankBranch", item.BankBranch);
            advBandedGridView.SetRowCellValue(rowIndex, "PersonName", item.PersonName);
            advBandedGridView.SetRowCellValue(rowIndex, "Quantity", item.Quantity);
            advBandedGridView.SetRowCellValue(rowIndex, "Description", item.Description);
            advBandedGridView.UpdateCurrentRow();
        }
    }
}
