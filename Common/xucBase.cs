using DevExpress.Utils;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using CHBK2014_N9.Common.Class;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

//using DevExpress.Xpf.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraTreeList;

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace CHBK2014_N9.Common
{
    public class xucBase : XtraUserControl
    {
        private WaitDialogForm dlg = null;

        protected ProgressForm progressForm = null;

        protected Actions m_Status = Actions.Add;

        private IContainer components;

        protected AlertControl alc;

        protected CloseOrNew m_CloseOrNew = CloseOrNew.None;

        protected MenuButton m_Menu;

        private bool m_isSave = false;

        protected bool start = true;

        private string _title = "";

        protected string _parentControlName = "";

        protected GridView _exportView;

        protected GridControl _exportControl;

        [Category("Config")]
        [DisplayName("Close")]
        public CloseOrNew IsClose
        {
            get
            {
                return this.m_CloseOrNew;
            }
            set
            {
                this.m_CloseOrNew = value;
            }
        }

        [Category("Config")]
        [Description("Là thuộc tính thể trạng thái của dữ liệu hiện tại có được lưu hay chưa.")]
        [DisplayName("Save")]
        public bool NotSave
        {
            get
            {
                return this.m_isSave;
            }
            set
            {
                this.m_isSave = value;
            }
        }

        [Category("Config")]
        [DisplayName("Bar")]
        [PropertyTab(typeof(MenuButton))]
        public MenuButton RibbonBar
        {
            get
            {
                return this.m_Menu;
            }
            set
            {
                this.m_Menu = value;
            }
        }

        [Category("Config")]
        [Description("Là thuộc tính thể trạng thái của dữ liệu.")]
        [DisplayName("Status")]
        public Actions Status
        {
            get
            {
                return this.m_Status;
            }
            set
            {
                this.m_Status = value;
            }
        }

        [Category("Config")]
        [Description("Là thuộc tính tiêu đề khi in ra.")]
        [DisplayName("Title")]
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }

        public xucBase()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.alc = new AlertControl()
            {
                AllowHtmlText = true
            };
            this.m_Status = Actions.None;
            this.m_CloseOrNew = CloseOrNew.None;
            this.m_Menu = new MenuButton();
        }

        public virtual void Clear()
        {
        }

        public void CreateWaitDialog()
        {
            this.dlg = new WaitDialogForm("Đang nạp dữ liệu...", "Vui lòng đợi trong giây lát...");
        }

        public virtual void Delete()
        {
        }

        private void dlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dlg.Dispose();
            this.dlg = null;
        }

        protected virtual void DoHide()
        {
            base.OnLoad(EventArgs.Empty);
            if (this.dlg != null)
            {
                this.dlg.FormClosing += new FormClosingEventHandler(this.dlg_FormClosing);
                this.dlg.Close();
            }
        }

        protected virtual void DoShow()
        {
        }

        public void DoShowMenu(GridHitInfo hi, GridView view)
        {
            if (hi.HitTest == GridHitTest.ColumnButton)
            {
                GridViewMenu gridViewColumnButtonMenu = new GridViewColumnButtonMenu(view);
                gridViewColumnButtonMenu.Init(hi);
                gridViewColumnButtonMenu.Show(hi.HitPoint);
            }
        }

        public void DoShowMenu(GridHitInfo hi, GridView view, Control control)
        {
            GridViewColumnButtonMenu gridViewColumnButtonMenu;
            if (hi.HitTest != GridHitTest.ColumnButton)
            {
                try
                {
                    if ((hi as BandedGridHitInfo).HitTest == BandedGridHitTest.BandButton)
                    {
                        gridViewColumnButtonMenu = new GridViewColumnButtonMenu(view)
                        {
                            ParentControl = control,
                            ParentControlName = this._parentControlName
                        };
                        gridViewColumnButtonMenu.Init(hi);
                        gridViewColumnButtonMenu.Show(hi.HitPoint);
                    }
                }
                catch
                {
                }
            }
            else
            {
                gridViewColumnButtonMenu = new GridViewColumnButtonMenu(view)
                {
                    ParentControl = control,
                    ParentControlName = this._parentControlName
                };
                gridViewColumnButtonMenu.Init(hi);
                gridViewColumnButtonMenu.Show(hi.HitPoint);
            }
        }

        protected virtual void EndExport()
        {
            if (this.progressForm != null)
            {
                this.progressForm.Dispose();
            }
            this.progressForm = null;
        }

        public virtual void Export(GridView view, string title)
        {
            this.Title = title;
            this.Export(view);
        }

        public virtual void Export(GridView view)
        {
            this._exportView = view;
            this.Export();
        }

        public void Export()
        {
            if (this.ExportPermision())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Filter = "Microsoft Excel 97-2003(*.xls)|*.xls|Microsoft Excel 2007(*.xlsx)|*.xlsx|PDF(*.pdf)|*.pdf|Rich Text Format(*.rtf)|*.rtf|Webpage (*.htm)|*.htm",
                    FilterIndex = 0
                };
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != null)
                {
                    try
                    {
                        if (saveFileDialog.FilterIndex == 1)
                        {
                            this.ExportToEx(saveFileDialog.FileName, "xls");
                        }
                        else if (saveFileDialog.FilterIndex == 2)
                        {
                            this.ExportToEx(saveFileDialog.FileName, "xlsx");
                        }
                        else if (saveFileDialog.FilterIndex == 3)
                        {
                            this.ExportToEx(saveFileDialog.FileName, "pdf");
                        }
                        else if (saveFileDialog.FilterIndex == 4)
                        {
                            this.ExportToEx(saveFileDialog.FileName, "rtf");
                        }
                        else if (saveFileDialog.FilterIndex == 5)
                        {
                            this.ExportToEx(saveFileDialog.FileName, "htm");
                        }
                        if (File.Exists(saveFileDialog.FileName))
                        {
                            if (XtraMessageBox.Show("Bạn muốn mở tài liệu này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                            {
                                Process.Start(saveFileDialog.FileName);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        this.EndExport();
                    }
                }
            }
        }

        public void Export(TreeList treeList)
        {
            if (this.ExportPermision())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Filter = "Microsoft Excel 97-2003(*.xls)|*.xls|Microsoft Excel 2007(*.xlsx)|*.xlsx|PDF(*.pdf)|*.pdf|Rich Text Format(*.rtf)|*.rtf|Webpage (*.htm)|*.htm",
                    FilterIndex = 0
                };
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != null)
                {
                    try
                    {
                        if (saveFileDialog.FilterIndex == 1)
                        {
                            treeList.ExportToXls(saveFileDialog.FileName);
                        }
                        else if (saveFileDialog.FilterIndex == 2)
                        {
                            treeList.ExportToXlsx(saveFileDialog.FileName);
                        }
                        else if (saveFileDialog.FilterIndex == 3)
                        {
                            treeList.ExportToPdf(saveFileDialog.FileName);
                        }
                        else if (saveFileDialog.FilterIndex == 4)
                        {
                            treeList.ExportToRtf(saveFileDialog.FileName);
                        }
                        else if (saveFileDialog.FilterIndex == 5)
                        {
                            treeList.ExportToHtml(saveFileDialog.FileName);
                        }
                        if (File.Exists(saveFileDialog.FileName))
                        {
                            if (XtraMessageBox.Show("Bạn muốn mở tài liệu này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                            {
                                Process.Start(saveFileDialog.FileName);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        this.EndExport();
                    }
                }
            }
        }

        protected virtual void Export_ProgressEx(object sender, ChangeEventArgs e)
        {
            if (e.EventName == "ProgressPositionChanged")
            {
                int num = (int)e.ValueOf("ProgressPosition");
                this.progressForm.SetProgressValue(num);
            }
        }

        protected virtual bool ExportPermision()
        {
            return true;
        }

        private void ExportToEx(string filename, string ext)
        {
            this.StartExport();
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (this._exportView != null)
            {
               PrintingSystem currentPS =  new PrintingSystem();
                xucBase _xucBase = this;
               currentPS.AfterChange += new ChangeEventHandler(_xucBase.Export_ProgressEx);
                if (ext == "rtf")
                {
                    this._exportView.ExportToRtf(filename);
                }
                if (ext == "pdf")
                {
                    this._exportView.ExportToPdf(filename);
                }
                if (ext == "mht")
                {
                    this._exportView.ExportToMht(filename);
                }
                if (ext == "htm")
                {
                    this._exportView.ExportToHtml(filename, new HtmlExportOptions("utf-8"));
                }
                if (ext == "txt")
                {
                    this._exportView.ExportToText(filename, new TextExportOptions(" ", Encoding.Unicode));
                }
                if (ext == "xls")
                {
                    this._exportView.ExportToXls(filename, new XlsExportOptions(TextExportMode.Value, true));
                }
                if (ext == "xlsOld")
                {
                    this._exportView.ExportToExcelOld(filename);
                }
                if (ext == "xlsx")
                {
                    this._exportView.ExportToXlsx(filename, new XlsxExportOptions(TextExportMode.Value, true));
                }
                xucBase _xucBase1 = this;
               currentPS.AfterChange -= new ChangeEventHandler(_xucBase1.Export_ProgressEx);
                Cursor.Current = current;
                this.EndExport();
            }
            else
            {
                this.EndExport();
                XtraMessageBox.Show("Đối tượng kết xuất chưa xác định");
            }
        }

        public void FormatColumns(RepositoryItemGridLookUpEdit item, string column, int pos, int width, string caption)
        {
            this.FormatColumns(item, column, pos, width, caption, true);
        }

        public void FormatColumns(RepositoryItemGridLookUpEdit item, string column, int pos, int width, string caption, bool visible)
        {
            this.FormatColumns(item, column, pos, width, caption, null, visible);
        }

        public void FormatColumns(RepositoryItemGridLookUpEdit item, string column, int pos, int width, string caption, RepositoryItem repositoryItem)
        {
            this.FormatColumns(item, column, pos, width, caption, repositoryItem, true);
        }

        public void FormatColumns(RepositoryItemGridLookUpEdit item, string column, int pos, int width, string caption, RepositoryItem repositoryItem, bool visible)
        {
            GridColumn gridColumn = item.View.Columns.AddField(column);
            gridColumn.VisibleIndex = pos;
            gridColumn.Caption = caption;
            gridColumn.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            gridColumn.Visible = visible;
            gridColumn.ColumnEdit = repositoryItem;
            gridColumn.Width = width;
        }

        public string GenerateCode(string studentName)
        {
            string str = "";
            string[] strArrays = studentName.Split(new char[] { ' ' });
            for (int i = 0; i < (int)strArrays.Length; i++)
            {
                string str1 = strArrays[i];
                if (str1.Length > 0)
                {
                    str = string.Concat(str, str1.Substring(0, 1));
                }
            }
            return str;
        }

        public object GetCellValue(CHBK2014_N9.Common.Class.RowClickEventArgs e, AdvBandedGridView view)
        {
            GridColumn gridColumn = new GridColumn();
            gridColumn = (e.ColumnIndex == -1 ? view.Columns[e.FieldName] : view.Columns[e.ColumnIndex]);
            return view.GetRowCellValue(e.RowIndex, gridColumn);
        }

        public object GetCellValue(CHBK2014_N9.Common.Class.RowClickEventArgs e, GridView view)
        {
            GridColumn gridColumn = new GridColumn();
            gridColumn = (e.ColumnIndex == -1 ? view.Columns[e.FieldName] : view.Columns[e.ColumnIndex]);
            return view.GetRowCellValue(e.RowIndex, gridColumn);
        }

        public object GetCellValue(int Rowindex, GridColumn ColIndex, GridView view)
        {
            object cellValue = this.GetCellValue(new CHBK2014_N9.Common.Class.RowClickEventArgs(Rowindex, ColIndex.ColumnHandle, ColIndex.FieldName), view);
            return cellValue;
        }

        public object GetCellValue(int Rowindex, int ColIndex, GridView view)
        {
            return this.GetCellValue(new Class.RowClickEventArgs(Rowindex, ColIndex), view);
        }

        public object GetCellValue(int Rowindex, string FieldName, GridView view)
        {
            return this.GetCellValue(new Class.RowClickEventArgs(Rowindex, FieldName), view);
        }

        public object GetCellValue(int RowIndex, int ColumIndex, AdvBandedGridView view)
        {
            return this.GetCellValue(new Class.RowClickEventArgs(RowIndex, ColumIndex), view);
        }

        public object GetCellValue(int RowIndex, string FieldName, AdvBandedGridView view)
        {
            return this.GetCellValue(new Class.RowClickEventArgs(RowIndex, FieldName), view);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.alc = new AlertControl(this.components);
            base.SuspendLayout();
            this.alc.AllowHtmlText = true;
            base.Name = "xucBase";
            base.ResumeLayout(false);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.dlg != null)
            {
                this.dlg.Close();
            }
        }

        protected virtual void OnSwitchStyle()
        {
        }

        protected void RaiseRibbonChanged(RibbonChangedEventArgs e)
        {
            RibbonChangedEventHander ribbonChangedEventHander = this.RibbonChanged;
            if (ribbonChangedEventHander != null)
            {
                ribbonChangedEventHander(this, e);
            }
        }

        protected void RaiseSaveChanged(SaveChangedEventArgs e)
        {
            SaveChangedEventHander saveChangedEventHander = this.SaveChanged;
            if (saveChangedEventHander != null)
            {
                saveChangedEventHander(this, e);
            }
        }

        protected void RaiseSaveChanging(SaveChangingEventArgs e)
        {
            SaveChangingEventHander saveChangingEventHander = this.SaveChanging;
            if (saveChangingEventHander != null)
            {
                saveChangingEventHander(this, e);
            }
        }

        protected void RaiseSaveComplete(SaveCompleteEventArgs e)
        {
            SaveCompleteEventHander saveCompleteEventHander = this.SaveComplete;
            if (saveCompleteEventHander != null)
            {
                saveCompleteEventHander(this, e);
            }
        }

        public void RaiseSuccessEventHander(object Item)
        {
            if (this.Success != null)
            {
                this.Success(this, Item);
            }
        }

        public void RestoreLayout(GridView view, Control control)
        {
            GridViewColumnButtonMenu gridViewColumnButtonMenu = new GridViewColumnButtonMenu(view)
            {
                ParentControl = control,
                ParentControlName = this._parentControlName
            };
            gridViewColumnButtonMenu.RestoreLayout();
        }

        public void SetWaitDialogCaption(string fCaption)
        {
            if (this.dlg == null)
            {
                this.CreateWaitDialog();
                if (this.dlg != null)
                {
                    this.dlg.Caption = fCaption;
                }
            }
            else
            {
                this.dlg.Caption = fCaption;
            }
        }

        public void SetWaitDialogCaption(string fCaption, string fTitle)
        {
            if (this.dlg == null)
            {
                this.dlg = new WaitDialogForm(fCaption, fTitle);
            }
            else
            {
                this.DoHide();
                this.dlg = new WaitDialogForm(fCaption, fTitle);
            }
        }

        protected virtual void StartExport()
        {
            this.progressForm = new ProgressForm(this);
            this.progressForm.Show();
            this.progressForm.Refresh();
        }

        public event RibbonChangedEventHander RibbonChanged;

        public event SaveChangedEventHander SaveChanged;

        public event SaveChangingEventHander SaveChanging;

        public event SaveCompleteEventHander SaveComplete;

        public event xucBase.SuccessEventHander Success;

        public enum ColumnKeyPress
        {
            None,
            Quantity,
            UnitPrice,
            Amount,
            Discount,
            Vat,
            Unit
        }

        public delegate void SuccessEventHander(object sender, object Item);

        public enum TypeAdd
        {
            None,
            Single,
            Replace,
            Add,
            Duplicate
        }
    }
}
