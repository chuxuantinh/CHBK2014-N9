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
    public partial class xucBranch :xucBaseBasic
    {

        private XucToolBar xucToolBar1 = new XucToolBar();
        public xucBranch()
        {

            InitializeComponent();
          xucToolBar1.SetInterface();
        }


        protected override void Add()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiBranch") != "OK"))
            {
                if (MyRule.AllowAdd)
                {
                    xfmBranchAdd _xfmBranchAdd = new xfmBranchAdd(Actions.Add);
                    _xfmBranchAdd.Added += new xfmBranchAdd.AddedEventHander(this.frm_Added);
                    _xfmBranchAdd.ShowDialog();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        private void AddRow(HRM_BRANCH Item)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.AddNewRow();
            focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.SetRowCellValue(focusedRowHandle, "BranchCode", Item.BranchCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "BranchName", Item.BranchName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Address", Item.Address);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Phone", Item.Phone);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Fax", Item.Fax);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "PersonName", Item.PersonName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Quantity", Item.Quantity);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Description", Item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

        public override void Change()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiBranch") != "OK"))
            {
                if (MyRule.AllowAccess)
                {
                    HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                    object cellValue = base.GetCellValue(this.m_RowClickEventArgs.RowIndex, "BranchCode");
                    if (cellValue != null)
                    {
                        base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                        if (!(hRMBRANCH.Get(cellValue.ToString()) != "OK"))
                        {
                            this.DoHide();
                            xfmBranchAdd _xfmBranchAdd = new xfmBranchAdd(Actions.Update, hRMBRANCH);
                            _xfmBranchAdd.Updated += new xfmBranchAdd.UpdatedEventHander(this.frm_Updated);
                            _xfmBranchAdd.Added += new xfmBranchAdd.AddedEventHander(this.frm_Added);
                            _xfmBranchAdd.ShowDialog();
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
            if (!(MyRule.Get(MyLogin.RoleId, "bbiBranch") != "OK"))
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
                    HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        cellValue = base.GetCellValue(selectedRows[i - 1], "BranchCode");
                        if (cellValue != null)
                        {
                            //SYS_LOG.Insert("Danh Sách Chi Nhánh", "Xoá", cellValue.ToString());
                            str = hRMBRANCH.Delete(cellValue.ToString());
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
                            cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "BranchCode");
                            if (cellValue != null)
                            {
                                //  SYS_LOG.Insert("Danh Sách Chi Nhánh", "Xoá", cellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = hRMBRANCH.Delete(cellValue.ToString());
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
                    //  MyRule.Notify();
                }
            }
        }


        protected override bool ExportPermision()
        {
            bool flag;
            if (MyRule.IsExport("bbiBranch"))
            {
                //SYS_LOG.Insert("Danh Sách Chi Nhánh", "Xuất");
                flag = base.ExportPermision();
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        private void frm_Added(object sender, HRM_BRANCH e)
        {
            this.AddRow(e);
        }

        private void frm_Updated(object sender, HRM_BRANCH Item)
        {
            this.UpdateRow(Item, this.m_RowClickEventArgs);
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
            RowClickEventArgs rowClickEventArg = new RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
            object cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "BranchCode");
            base.DisableMenu(false);
            if (cellValue == null)
            {
                base.DisableMenu(true);
            }
        }

        //private void InitializeComponent()
        //{
        //    this.components = new Container();
        //    base.AutoScaleMode = AutoScaleMode.Font;
        //}

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
                        case "BranchCode":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                             
                                    dt.Columns[i].Caption = "Mã chi nhánh";
                               
                                dt.Columns[i].Width = 80;
                                break;
                            }
                        case "BranchName":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;

                                dt.Columns[i].Caption = "Tên chi nhánh";
                              
                                dt.Columns[i].Width = 200;
                                break;
                            }
                        case "Address":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;

                                dt.Columns[i].Caption = "Địa chỉ";
                               
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

                                dt.Columns[i].Caption = "Số lượng nhân viên";
                               
                                dt.Columns[i].Width = 60;
                                break;
                            }
                        case "Description":
                            {
                                dt.Columns[i].OptionsColumn.ReadOnly = true;
                                dt.Columns[i].OptionsColumn.AllowEdit = false;
                                dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                                dt.Columns[i].OptionsColumn.FixedWidth = true;
                              
                                    dt.Columns[i].Caption =  "Ghi chú";
                              
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
                continue;
            }
            return;
        Label0:
            dt.Columns[i].Visible = false;
            //  goto Label1;
           
        }

       // protected override void Print()
        //{
        //    if (!(MyRule.Get(MyLogin.RoleId, "bbiBranch") != "OK"))
        //    {
        //        if (MyRule.AllowPrint)
        //        {
        //            SYS_LOG.Insert("Danh Sách Chi Nhánh", "In");
        //            (new xfmReport("Danh Sách Chi Nhánh")).ShowPrintPreview(this.gcList);
        //            base.Print();
        //        }
        //        else
        //        {
        //            MyRule.Notify();
        //        }
        //    }
        //}

        public override void ReLoad()
        {
            base.SetWaitDialogCaption("Đang nạp dữ liệu...");
            HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
            this.gcList.DataSource = hRMBRANCH.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.List_Init(this.gbList);

            base.SetWaitDialogCaption("Nạp quyền sử dụng...");
            MyRule.Get(MyLogin.RoleId, "bbiBranch");
            if (!MyRule.AllowPrint)
            {
                this.ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiBranch");
            if (!MyRule.AllowExport)
            {
                this.ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiBranch");
            if (!MyRule.AllowAdd)
            {
                this.ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiBranch");
            if (!MyRule.AllowDelete)
            {
                this.ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiBranch");
            if (!MyRule.AllowEdit)
            {
                this.ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            }
            base.SetWaitDialogCaption("Đã xong...");
            this.DoHide();
        }

        private void UpdateRow(HRM_BRANCH item, RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int rowIndex = e.RowIndex;
            advBandedGridView.SetRowCellValue(rowIndex, "BranchCode", item.BranchCode);
            advBandedGridView.SetRowCellValue(rowIndex, "BranchName", item.BranchName);
            advBandedGridView.SetRowCellValue(rowIndex, "Address", item.Address);
            advBandedGridView.SetRowCellValue(rowIndex, "Phone", item.Phone);
            advBandedGridView.SetRowCellValue(rowIndex, "Fax", item.Fax);
            advBandedGridView.SetRowCellValue(rowIndex, "PersonName", item.PersonName);
            advBandedGridView.SetRowCellValue(rowIndex, "Quantity", item.Quantity);
            advBandedGridView.SetRowCellValue(rowIndex, "Description", item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

        private void xucBranch_Load(object sender, EventArgs e)
        {
            ReLoad();
        

        }
    }
}
