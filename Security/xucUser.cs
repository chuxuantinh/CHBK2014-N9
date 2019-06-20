using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Core;
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CHBK2014_N9.Security
{
    public partial class xucUser : xucBaseBasic
    {
        public xucUser()
        {
            InitializeComponent();
            this.ucToolBar.SetInterface();
        }


        protected override void Add()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiUsers") != "OK"))
            {
                if (MyRule.AllowAdd)
                {
                    //xfmUserAdd _xfmUserAdd = new xfmUserAdd(Actions.Add);
                    //_xfmUserAdd.Added += new xfmUserAdd.AddedEventHander(this.frm_Added);
                    //_xfmUserAdd.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void AddRow(SYS_USER Item)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.AddNewRow();
            focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Active", Item.Active);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "UserID", Item.UserID);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "UserName", Item.UserName);
            SYS_GROUP sYSGROUP = new SYS_GROUP();
            sYSGROUP.Get(Item.Group_ID);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Role_Name", sYSGROUP.Group_Name);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "EmployeeCode", Item.EmployeeCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Description", Item.Description);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Active", Item.Active);
            advBandedGridView.UpdateCurrentRow();
        }

        public override void Change()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiUsers") != "OK"))
            {
                if (MyRule.AllowAccess)
                {
                    SYS_USER sYSUSER = new SYS_USER();
                    object cellValue = base.GetCellValue(this.m_RowClickEventArgs.RowIndex, "UserID");
                    if (cellValue != null)
                    {
                        base.CreateWaitDialog();
                        base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                        if (!(sYSUSER.Get(cellValue.ToString()) != "OK"))
                        {
                            this.DoHide();
                            //xfmUserAdd _xfmUserAdd = new xfmUserAdd(Actions.Update, sYSUSER, false);
                            //_xfmUserAdd.Updated += new xfmUserAdd.UpdatedEventHander(this.frm_Updated);
                            //_xfmUserAdd.ShowDialog();
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
                    XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public override void Delete()
        {
            object cellValue;
            if (!(MyRule.Get(MyLogin.RoleId, "bbiUsers") != "OK"))
            {
                if (!MyRule.AllowDelete)
                {
                    XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (XtraMessageBox.Show(MsgResc.Delete, "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    base.CreateWaitDialog();
                    base.SetWaitDialogCaption("Đang xóa...");
                    string str = "";
                    bool flag = false;
                    AdvBandedGridView advBandedGridView = this.gbList;
                    int[] selectedRows = advBandedGridView.GetSelectedRows();
                    SYS_USER sYSUSER = new SYS_USER();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        cellValue = base.GetCellValue(selectedRows[i - 1], "UserID");
                        if (cellValue != null)
                        {
                         //   SYS_LOG.Insert("Quản Lý Người Dùng", "Xoá", cellValue.ToString());
                            if (cellValue.ToString() == MyLogin.UserId)
                            {
                                XtraMessageBox.Show("Không được xóa người dùng đang sử dụng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else if (!(cellValue.ToString() == "admin"))
                            {
                                str = sYSUSER.Delete(cellValue.ToString());
                                if (str == "OK")
                                {
                                    advBandedGridView.DeleteRow(selectedRows[i - 1]);
                                }
                                else if (str != "OK")
                                {
                                    XtraMessageBox.Show(string.Concat("Lỗi:\n\t", str), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("Không được xóa người dùng hệ thống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    this.DoHide();
                    if (!flag)
                    {
                        if (!(MyRule.Get(MyLogin.RoleId, "bbiUsers") != "OK"))
                        {
                            if (!MyRule.AllowDelete)
                            {
                                XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else if (advBandedGridView.DataSource != null)
                            {
                                CHBK2014_N9.Common.Class.RowClickEventArgs rowClickEventArg = new Common.Class.RowClickEventArgs ((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
                                this.m_RowClickEventArgs = rowClickEventArg;
                                cellValue = null;
                                cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "UserID");
                                if (cellValue != null)
                                {
                                 //   SYS_LOG.Insert("Quản Lý Người Dùng", "Xoá", cellValue.ToString());
                                    if (cellValue.ToString() == MyLogin.UserId)
                                    {
                                        XtraMessageBox.Show("Không được xóa người dùng đang sử dụng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else if (!(cellValue.ToString() == "admin"))
                                    {
                                        base.CreateWaitDialog();
                                        base.SetWaitDialogCaption("Đang xóa...");
                                        str = sYSUSER.Delete(cellValue.ToString());
                                        if (str == "OK")
                                        {
                                            advBandedGridView.DeleteRow(rowClickEventArg.RowIndex);
                                        }
                                        else if (str != "OK")
                                        {
                                            XtraMessageBox.Show(string.Concat("Lỗi:\n\t", str), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                        this.DoHide();
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("TKhông được xóa người dùng hệ thống.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }



        protected override bool ExportPermision()
        {
            bool flag;
            if (MyRule.Get(MyLogin.RoleId, "bbiUsers") == "OK")
            {
                if (!MyRule.AllowExport)
                {
                    XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    flag = false;
                    return flag;
                }
            }
            flag = true;
            return flag;
        }

        private void frm_Added(object sender, SYS_USER e)
        {
            this.AddRow(e);
        }

        private void frm_Updated(object sender, SYS_USER Item)
        {
            this.UpdateRow(Item, this.m_RowClickEventArgs);
        }


        protected override void List_Init(AdvBandedGridView dt)
        {
            int i;
            dt.OptionsBehavior.AutoExpandAllGroups = true;
            dt.Appearance.GroupRow.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
            for (i = 0; i < dt.Columns.Count; i++)
            {
                string fieldName = dt.Columns[i].FieldName;
                if (fieldName != null)
                {
                    switch (fieldName)
                    {
                        case "UserID":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.AllowSort = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = false;
                                
                                    dt.Columns[i].Caption = "Mã";
                              
                                dt.Columns[i].Width = 90;
                                dt.Columns[i].Visible = false;
                                break;
                            }
                        case "UserName":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.AllowSort = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                             
                                    dt.Columns[i].Caption = "Tên đăng nhập";
                              
                                dt.Columns[i].Width = 180;
                                break;
                            }
                        case "Role_Name":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.AllowSort = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                              
                                    dt.Columns[i].Caption = "Vai trò";
                               
                                dt.Columns[i].Width = 180;
                                dt.Columns[i].GroupIndex = 0;
                                break;
                            }
                        case "EmployeeCode":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.AllowSort = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                               
                                    dt.Columns[i].Caption = "Mã nhân viên";
                               
                                dt.Columns[i].Width = 120;
                                break;
                            }
                        case "Description":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.AllowSort = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                                dt.Columns[i].DisplayFormat.FormatType = FormatType.Custom;
                                dt.Columns[i].DisplayFormat.FormatString = ClsOption.Number.FormatString;
                              
                                    dt.Columns[i].Caption = "Diễn giải";
                                
                                dt.Columns[i].Width = 180;
                                break;
                            }
                        case "Active":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.AllowSort = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                               
                                    dt.Columns[i].Caption = "Kích hoạt";
                              
                                dt.Columns[i].Width = 80;
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
              //  continue;
            }
            return;
            Label0:
            dt.Columns[i].Visible = false;
        //    goto Label1;



           // xem lai cho nay
       
        }

        protected override void Print()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiUsers") != "OK"))
            {
                if (MyRule.AllowPrint)
                {
                    base.Print();
                }
                else
                {
                    XtraMessageBox.Show(MsgResc.Permision, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public override void ReLoad()
        {
            base.CreateWaitDialog();
            base.SetWaitDialogCaption("Đang nạp dữ liệu...");
            SYS_USER sYSUSER = new SYS_USER();
            this.gcList.DataSource = sYSUSER.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.List_Init(this.gbList);
            base.SetWaitDialogCaption("Nạp quyền sử dụng...");
            MyRule.Get(MyLogin.RoleId, "bbiUsers");
            if (!MyRule.AllowPrint)
            {
                this.ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiUsers");
            if (!MyRule.AllowExport)
            {
                this.ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiUsers");
            if (!MyRule.AllowAdd)
            {
                this.ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiUsers");
            if (!MyRule.AllowDelete)
            {
                this.ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiUsers");
            if (!MyRule.AllowEdit)
            {
                this.ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            }
            base.SetWaitDialogCaption("Đã xong...");
            this.DoHide();
        }

        public void UpdateRow(SYS_USER Item,   CHBK2014_N9.Common.Class. RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int rowIndex = e.RowIndex;
            advBandedGridView.SetRowCellValue(rowIndex, "Active", Item.Active);
            advBandedGridView.SetRowCellValue(rowIndex, "UserID", Item.UserID);
            advBandedGridView.SetRowCellValue(rowIndex, "UserName", Item.UserName);
            SYS_GROUP sYSGROUP = new SYS_GROUP();
            sYSGROUP.Get(Item.Group_ID);
            advBandedGridView.SetRowCellValue(rowIndex, "Role_Name", sYSGROUP.Group_Name);
            advBandedGridView.SetRowCellValue(rowIndex, "EmployeeCode", Item.EmployeeCode);
            advBandedGridView.SetRowCellValue(rowIndex, "Description", Item.Description);
            advBandedGridView.SetRowCellValue(rowIndex, "Active", Item.Active);
            advBandedGridView.UpdateCurrentRow();
        }



        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
           CHBK2014_N9.Common.Class.  RowClickEventArgs rowClickEventArg = new Common.Class.RowClickEventArgs ((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
            object cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "UserID");
            base.DisableMenu(false);
            if (cellValue == null)
            {
                base.DisableMenu(true);
            }
        }

        private void xucCustomerType_Load(object sender, EventArgs e)
        {
        }

    }


}
