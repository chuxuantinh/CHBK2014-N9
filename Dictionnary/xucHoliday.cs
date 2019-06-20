using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
//using CHBK2014_N9.Common.Report;
using CHBK2014_N9.ERP;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
namespace CHBK2014_N9.Dictionnary
{
    public partial class xucHoliday : xucBase
    {

        private int m_Year = 0;
        private RepositoryItemTimeEdit repMonth;
        private clsAllOption clsAllOption = new clsAllOption();

        public xucHoliday()
        {
            this.InitializeComponent();
            this.Init();
            this.ReLoad();
        }

        private void Add()
        {
            if (MyRule.IsAdd("bbiHoliday"))
            {
                xfmHolidayAdd _xfmHolidayAdd = new xfmHolidayAdd(Actions.Add);
                _xfmHolidayAdd.Added += new xfmHolidayAdd.AddedEventHander(this.frm_Added);
                _xfmHolidayAdd.ShowDialog();
            }
        }

        private void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Add();
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            (base.Parent as XtraForm).Close();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            string str;
            object rowCellValue;
            if (MyRule.IsDelete("bbiHoliday"))
            {
                bool flag = false;
                int[] selectedRows = this.gbList.GetSelectedRows();
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    base.SetWaitDialogCaption("Đang xóa...");
                    DIC_HOLIDAY dICHOLIDAY = new DIC_HOLIDAY();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        rowCellValue = this.gbList.GetRowCellValue(selectedRows[i - 1], "HolidayID");
                        if (rowCellValue != null)
                        {
                          //  SYS_LOG.Insert("Danh Sách Ngày Nghỉ, Ngày Lể", "Xoá", rowCellValue.ToString());
                            str = dICHOLIDAY.Delete(new Guid(rowCellValue.ToString()));
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
                        rowCellValue = this.gbList.GetFocusedRowCellValue("HolidayID");
                        if (rowCellValue != null)
                        {
                         //   SYS_LOG.Insert("Danh Sách Ngày Nghỉ, Ngày Lể", "Xoá", rowCellValue.ToString());
                            base.SetWaitDialogCaption("Đang xóa...");
                            str = dICHOLIDAY.Delete(new Guid(rowCellValue.ToString()));
                            if (str == "OK")
                            {
                                this.gbList.DeleteRow(this.gbList.FocusedRowHandle);
                            }
                            else if (str != "OK")
                            {
                                MessageBox.Show(string.Concat("Thông tin không được xóa", str), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            this.DoHide();
                        }
                    }
                }
            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Change();
        }

        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            this._exportView = this.gbList;
           // SYS_LOG.Insert("Danh Sách Ngày Nghỉ, Ngày Lể", "Xuất");
            base.Export();
        }

        private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MyRule.IsPrint("bbiHoliday"))
            {
              //  SYS_LOG.Insert("Danh Sách Ngày Nghỉ, Ngày Lể", "In");
              // (new xfmReport("Danh Mục")).ShowPrintPreview(this.gcList);
            }
        }

        private void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ReLoad();
        }

        private void Change()
        {
            if (MyRule.IsEdit("bbiHoliday"))
            {
                DIC_HOLIDAY dICHOLIDAY = new DIC_HOLIDAY();
                object focusedRowCellValue = this.gbList.GetFocusedRowCellValue("HolidayID");
                if (focusedRowCellValue != null)
                {
                    base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                    if (!(dICHOLIDAY.Get(focusedRowCellValue.ToString()) != "OK"))
                    {
                        this.DoHide();
                        xfmHolidayAdd _xfmHolidayAdd = new xfmHolidayAdd(Actions.Update, dICHOLIDAY);
                        _xfmHolidayAdd.Updated += new xfmHolidayAdd.UpdatedEventHander(this.frm_Updated);
                        _xfmHolidayAdd.Added += new xfmHolidayAdd.AddedEventHander(this.frm_Added);
                        _xfmHolidayAdd.ShowDialog();
                    }
                    else
                    {
                        this.DoHide();
                        XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        public void DisableMenu(bool disable)
        {
            this.bbiEdit.Enabled = !disable;
            this.bbiDelete.Enabled = !disable;
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

        private void frm_Added(object sender, DIC_HOLIDAY Item)
        {
            this.LoadGrid();
        }

        private void frm_Updated(object sender, DIC_HOLIDAY Item)
        {
            this.UpdateRow(Item);
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

        private void gbList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            this.SetMenu(null);
        }

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void gbList_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void gbList_RowCellClick(object sender, RowCellClickEventArgs e)
        {
        }

        private void Init()
        {
            this.bbeYear.EditValue = this.clsAllOption.MonthDefault;
            this.m_Year = this.clsAllOption.MonthDefault.Year;
            this.repYear.EditValueChanged += new EventHandler(this.repYear_EditValueChanged);
            this.repYear.EditValueChanging += new ChangingEventHandler(this.repYear_EditValueChanging);
        }

        private void LoadGrid()
        {
            DIC_HOLIDAY dICHOLIDAY = new DIC_HOLIDAY();
            this.gcList.DataSource = dICHOLIDAY.GetByYear(this.m_Year);
        }

        private void ReLoad()
        {
            base.SetWaitDialogCaption("Đang nạp dữ liệu...");
            this.LoadGrid();
        }

        private void repYear_EditValueChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void repYear_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(e.NewValue.ToString());
            int year = dateTime.Year;
            this.m_Year = Convert.ToInt32(year.ToString());
        }

        private void SetMenu(CHBK2014_N9.Common.Class.RowClickEventArgs e)
        {
            object rowCellValue = this.gbList.GetRowCellValue(this.gbList.FocusedRowHandle, "HolidayID");
            this.DisableMenu(false);
            if (rowCellValue == null)
            {
                this.DisableMenu(true);
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

        private void UpdateRow(DIC_HOLIDAY item)
        {
            GridView gridView = this.gbList;
            int focusedRowHandle = this.gbList.FocusedRowHandle;
            gridView.SetRowCellValue(focusedRowHandle, "HolidayID", item.HolidayID);
            gridView.SetRowCellValue(focusedRowHandle, "HolidayName", item.HolidayName);
            gridView.SetRowCellValue(focusedRowHandle, "FromDate", item.FromDate);
            gridView.SetRowCellValue(focusedRowHandle, "ToDate", item.ToDate);
            gridView.SetRowCellValue(focusedRowHandle, "Description", item.Description);
            gridView.UpdateCurrentRow();
        }
    }
}
