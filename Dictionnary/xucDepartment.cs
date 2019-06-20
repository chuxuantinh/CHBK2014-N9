using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
//using CHBK2014_N9.Common.Report;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace CHBK2014_N9.Dictionnary
{
    public partial class xucDepartment : XucBaseBasicB
    {
        public xucDepartment()
        {
            InitializeComponent();

            if (base.ParentForm != null)
            {
                this.dm.Form = base.ParentForm;
            }
            this.Init();
            this.ucToolBar.bm.SetPopupContextMenu(this.gcList, this.ucToolBar.pm);
            this.ucToolBar.bbiHistory.Visibility = BarItemVisibility.Always;
            this.ucToolBar.bbiUtils.Visibility = BarItemVisibility.Always;
            this.ucToolBar.bbiGroup.Visibility = BarItemVisibility.Always;
            this.ucToolBar.bbiMerge.Visibility = BarItemVisibility.Always;
            this.ucToolBar.bbiChangeId.Visibility = BarItemVisibility.Always;
            this.ucToolBar.bbiEditUnitConvret.Visibility = BarItemVisibility.Always;
        }

        protected override void Add()
        {
            xfmDepartmentAdd _xfmDepartmentAdd = new xfmDepartmentAdd(Actions.Add);
            _xfmDepartmentAdd.Added += new xfmDepartmentAdd.AddedEventHander(this.frm_Added);
            _xfmDepartmentAdd.ShowDialog();
        }

        public override void Change()
        {
            if (MyRule.IsAccess("bbiDepartment"))
            {
                HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                object focusedRowCellValue = this.gbList.GetFocusedRowCellValue("DepartmentCode");
               
                if (focusedRowCellValue != null)
                {
                    base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                    if (!(hRMDEPARTMENT.Get(focusedRowCellValue.ToString()) != "OK"))
                    {
                        this.DoHide();
                        xfmDepartmentAdd _xfmDepartmentAdd = new xfmDepartmentAdd(Actions.Update, hRMDEPARTMENT);
                        _xfmDepartmentAdd.Updated += new xfmDepartmentAdd.UpdatedEventHander(this.frm_Updated);
                        _xfmDepartmentAdd.Added += new xfmDepartmentAdd.AddedEventHander(this.frm_Added);
                        _xfmDepartmentAdd.ShowDialog();
                    }
                    else
                    {
                        this.DoHide();
                        XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        public override void Delete()
        {
            string str;
            object rowCellValue;
            if (MyRule.IsDelete("bbiDepartment"))
            {
                bool flag = false;
                int[] selectedRows = this.gbList.GetSelectedRows();
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    base.SetWaitDialogCaption("Đang xóa...");
                    HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        rowCellValue = this.gbList.GetRowCellValue(selectedRows[i - 1], "DepartmentCode");
                        if (rowCellValue != null)
                        {
                         //   SYS_LOG.Insert("Danh Sách Phòng Ban", "Xoá", rowCellValue.ToString());
                            str = hRMDEPARTMENT.Delete(rowCellValue.ToString());
                            if (str == "OK")
                            {
                                this.gbList.DeleteRow(selectedRows[i - 1]);
                            }
                            else if (str != "OK")
                            {
                                MessageBox.Show(string.Concat("Thông tin không được xóa\r\n", str), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                    }
                    this.DoHide();
                    if (!flag)
                    {
                        if (hRMDEPARTMENT.GetList().Rows.Count != 0)
                        {
                            rowCellValue = this.gbList.GetFocusedRowCellValue("DepartmentCode");
                            if (rowCellValue != null)
                            {
                               // SYS_LOG.Insert("Danh Sách Phòng Ban", "Xoá", rowCellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = hRMDEPARTMENT.Delete(rowCellValue.ToString());
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
        }

        protected void DoShowMenu(GridHitInfo hi)
        {
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                GridViewMenu gridViewColumnButtonMenu = new GridViewColumnButtonMenu(this.gbList);
                gridViewColumnButtonMenu.Init(hi);
                gridViewColumnButtonMenu.Show(hi.HitPoint);
            }
        }

        protected override bool ExportPermision()
        {
            bool flag;
            this._exportView = this.gbList;
            if (MyRule.IsExport("bbiDepartment"))
            {
              //  SYS_LOG.Insert("Danh Sách Phòng Ban", "Xuất");
                flag = base.ExportPermision();
            }
            else
            {
                flag = false;
            }
            return flag;
        }

        private void frm_Added(object sender, HRM_DEPARTMENT Item)
        {
            this.ReLoad();
        }

        private void frm_Updated(object sender, HRM_DEPARTMENT Item)
        {
            this.ReLoad();
        }

        private void gbList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle == -2147483648)
            {
                e.Handled = true;
                e.Painter.DrawObject(e.Info);
                Rectangle bounds = e.Bounds;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(63, 165, 165, 0)), bounds);
                bounds.Height = bounds.Height - 1;
                bounds.Width = bounds.Width - 1;
                e.Graphics.DrawRectangle(Pens.Blue, bounds);
            }
            int rowHandle = e.RowHandle;
            if (rowHandle >= 0)
            {
                rowHandle++;
                e.Info.DisplayText = rowHandle.ToString();
            }
        }

        private void gbList_DoubleClick(object sender, EventArgs e)
        {
            if (this.gbList.RowCount != 0)
            {
                this.Change();
            }
        }

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            this.ucList_ListKeyDown(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                if (this.gbList.RowCount != 0)
                {
                    this.Delete();
                    this.SetMenu(null);
                }
            }
        }

        private void gbList_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms. MouseButtons.Left)
            {
                this.DoShowMenu(this.gbList.CalcHitInfo(new Point(e.X, e.Y)));
            }
            this.SetMenu(null);
        }

        private void gbList_RowCellClick(object sender, RowCellClickEventArgs e)
        {
           CHBK2014_N9.Common.Class. RowClickEventArgs rowClickEventArg = new CHBK2014_N9.Common.Class. RowClickEventArgs(e.RowHandle, e.Column.ColumnHandle);
            this.ItemSelectd(rowClickEventArg);
            this.SetMenu(rowClickEventArg);
            this.SetSearch(rowClickEventArg);
        }

        private void Init()
        {
            MyRule.Check("bbiDepartment");
            this.ucToolBar.bbiPrint.Visibility = MyRule.Printed;
            this.ucToolBar.bbiExport.Visibility = MyRule.Exported;
            this.ucToolBar.bbiAdd.Visibility = MyRule.Added;
            this.ucToolBar.bbiDelete.Visibility = MyRule.Deleted;
            this.ucToolBar.bbiEdit.Visibility = MyRule.Edited;
            base.RibbonBar.Add.Visibility = MyRule.Added;
            base.RibbonBar.Change.Visibility = MyRule.Edited;
            base.RibbonBar.Delete.Visibility = MyRule.Deleted;
            base.RibbonBar.Print.Visibility = MyRule.Printed;
            base.RibbonBar.Export.Visibility = MyRule.Exported;
            base.RibbonBar.Import.Visibility = MyRule.Imported;
            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
            this.gcList.DataSource = hRMDEPARTMENT.GetList();
        }


        protected override void Print()
        {
            if (MyRule.IsPrint("bbiDepartment"))
            {
               // SYS_LOG.Insert("Danh Sách Phòng Ban", "In");
             //   (new xfmReport("Danh Sách Phòng Ban")).ShowPrintPreview(this.gcList);
                base.Print();
            }
        }

        private void RaiseItemSelectedEventHander(HRM_DEPARTMENT item)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(this, item);
            }
        }

        public override void ReLoad()
        {
            base.SetWaitDialogCaption("Đang nạp dữ liệu...");
            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
            this.gcList.DataSource = hRMDEPARTMENT.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.gbList.ClearColumnsFilter();
            base.SetWaitDialogCaption("Đã xong...");
            this.DoHide();
        }

        protected override void SetMenu(CHBK2014_N9.Common.Class. RowClickEventArgs e)
        {
            object rowCellValue = this.gbList.GetRowCellValue(this.gbList.FocusedRowHandle, "DepartmentCode");
            base.DisableMenu(false);
            if (rowCellValue != null)
            {
                base.SetMenu(e);
            }
            else
            {
                base.DisableMenu(true);
            }
        }

        public override void SetSearch ( CHBK2014_N9.Common.Class. RowClickEventArgs e)
        {
            if (this._search)
            {
                HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                object rowCellValue = this.gbList.GetRowCellValue(this.MRowClickEventArgs.RowIndex, "DepartmentCode");
                if (rowCellValue != null)
                {
                    base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                    if (!(hRMDEPARTMENT.Get(rowCellValue.ToString()) != "OK"))
                    {
                        this.DoHide();
                        this.RaiseItemSelectedEventHander(hRMDEPARTMENT);
                    }
                    else
                    {
                        this.DoHide();
                        XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void ucList_ListKeyDown(object sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.F2)
            {
                if (this.gbList.RowCount != 0)
                {
                    this.Change();
                }
            }
            else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.E)
            {
                if (this.gbList.RowCount != 0)
                {
                    this.Change();
                }
            }
            else if (key.KeyCode == Keys.Return)
            {
                if (this.gbList.RowCount != 0)
                {
                    this.Change();
                }
            }
            else if (key.KeyCode == Keys.F5)
            {
                this.ReLoad();
            }
            else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.N)
            {
                this.Add();
            }
            else if (key.KeyCode == Keys.Control | key.KeyCode == Keys.T)
            {
                this.Add();
            }
        }

        public event xucDepartment.ItemSelectedEventHander ItemSelected;

        public delegate void ItemSelectedEventHander(object sender, HRM_DEPARTMENT item);
    }
}
