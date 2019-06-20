using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using CHBK2014_N9.Common.Base;
using CHBK2014_N9.Common.Class;
//using CHBK2014_N9.Common.Report;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace CHBK2014_N9.Common
{
    public partial class xucBaseBasic : xucBase
    {


        protected bool _search;

        private string _Title = "";

        private BaseView exportView;

        protected CHBK2014_N9.Common.Class.RowClickEventArgs m_RowClickEventArgs = new CHBK2014_N9.Common.Class.RowClickEventArgs();

        protected Actions m_Status = Actions.Add;

     protected XucToolBar ucToolBar = new XucToolBar();

       

        public bool IsSearch
        {
            get
            {
                return this._search;
            }
            set
            {
                this._search = value;
            }
        }

        public new string Title
        {
            set
            {
                this._Title = value;
            }
        }

        public xucBaseBasic()
        {
            this.InitializeComponent();
            this._search = false;
           this.DisableMenu(true);
        }

        protected virtual void Add()
        {
        }

        protected virtual void AddRow(object Item)
        {
        }


        protected virtual void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Add();
        }

        protected virtual void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseCloseClickEventHander();
        }

        protected virtual void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.gbList.RowCount != 0)
            {
                this.Delete();
               this.SetMenu(m_RowClickEventArgs);
            }
        }

        protected virtual void bbiDeleteAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.gbList.RowCount != 0)
            {
                this.gbList.SelectAll();
                this.Delete();
             SetMenu(this.m_RowClickEventArgs);
            }
        }

        protected virtual void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.gbList.RowCount != 0)
            {
                this.Change();
            }
        }

        protected virtual void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Export(this.gbList);
        }

        protected virtual void bbiPermision_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        protected virtual void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Print();
        }

        protected virtual void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ReLoad();
        }

        public virtual void Change()
        {
        }

        public virtual void Construct()
        {
        }

        public virtual new void Delete()
        {
        }

        public void DisableMenu(bool disable)
        {
            this.xucToolBar.bbiEdit.Enabled = !disable;
            this.xucToolBar.bbiDelete.Enabled = !disable;
            this.xucToolBar.bbiDeleteAll.Enabled = !disable;
            // this.ucToolBar.bbiPermision.Enabled = !disable;
            this.xucToolBar.bbiCopy.Enabled = !disable;
            this.xucToolBar.bbiPrint.Enabled = !disable;
            this.xucToolBar.bbiExport.Enabled = !disable;
        }

        public void DisableMenuNoData(bool disable)
        {
            this.DisableMenu(disable);
            this.xucToolBar.bbiPrint.Enabled = !disable;
            this.xucToolBar.bbiExport.Enabled = !disable;
            this.xucToolBar.bbiCopy.Enabled = !disable;
            this.xucToolBar.bbiEdit.Enabled = !disable;
            this.xucToolBar.bbiDelete.Enabled = !disable;
            this.xucToolBar.bbiDeleteAll.Enabled = !disable;
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

        protected virtual new bool ExportPermision()
        {
            return true;
        }

        protected virtual void SetMenu(CHBK2014_N9.Common.Class.RowClickEventArgs e)
        {
        }

        protected virtual void gbList_Click(object sender, EventArgs e)
        {
            if (!(sender is AdvBandedGridView))
            {
                XtraMessageBox.Show("Object is not AdvBandedGridView");
            }
            else
            {
                AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
                CHBK2014_N9.Common.Class.RowClickEventArgs rowClickEventArg = new CHBK2014_N9.Common.Class.RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
                this.m_RowClickEventArgs = rowClickEventArg;
                this.RaiseRowClickEventHander(rowClickEventArg);
              this.ItemSelectd(rowClickEventArg);
            }
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

        protected virtual void gbList_DoubleClick(object sender, EventArgs e)
        {
            if (!(sender is AdvBandedGridView))
            {
                XtraMessageBox.Show("Object is not AdvBandedGridView");
            }
            else
            {
                AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
                CHBK2014_N9.Common.Class.RowClickEventArgs rowClickEventArg = new CHBK2014_N9.Common.Class.RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
                this.m_RowClickEventArgs = rowClickEventArg;
                if (this._search)
                {
                    this.SetSearch(rowClickEventArg);
                }
                else
                {
                    if (this.gbList.RowCount == 0)
                    {
                        return;
                    }
                    this.RaiseRowDoubleClickEventHander(rowClickEventArg);
                    this.Change();
                }
            }
        }

        protected virtual void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(sender is AdvBandedGridView))
            {
                XtraMessageBox.Show("Object is not AdvBandedGridView");
            }
            else
            {
                AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
                CHBK2014_N9.Common.Class.RowClickEventArgs rowClickEventArg = new CHBK2014_N9.Common.Class.RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
                this.RaiseRowClickEventHander(rowClickEventArg);
               this.RaiseListKeyDownEventHander(e, rowClickEventArg);
                this.ucList_ListKeyDown(sender, e);
                this.m_RowClickEventArgs = rowClickEventArg;
                if (e.KeyCode == Keys.Delete)
                {
                    if (this.gbList.RowCount == 0)
                    {
                        return;
                    }
                    this.Delete();
                  this.SetMenu(this.m_RowClickEventArgs);
                }
            }
        }

        protected virtual void gbList_Layout(object sender, EventArgs e)
        {
            this.SaveLayout();
        }

        protected virtual void gbList_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.DoShowMenu(this.gbList.CalcHitInfo(new Point(e.X, e.Y)));
            }
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
           CHBK2014_N9.Common.Class. RowClickEventArgs rowClickEventArg = new CHBK2014_N9.Common.Class.RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
           this.SetMenu(rowClickEventArg);
            this.RaiseRowClickEventHander(rowClickEventArg);
        }

       

        public object GetCellValue(CHBK2014_N9.Common.Class.RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            GridColumn gridColumn = new GridColumn();
            gridColumn = (e.ColumnIndex == -1 ? advBandedGridView.Columns[e.FieldName] : advBandedGridView.Columns[e.ColumnIndex]);
            return advBandedGridView.GetRowCellValue(e.RowIndex, gridColumn);
        }

        public object GetCellValue(int RowIndex, int ColumIndex)
        {
             return this.GetCellValue(new CHBK2014_N9.Common.Class.RowClickEventArgs(RowIndex, ColumIndex));
        }

        public object GetCellValue(int RowIndex, string FieldName)
        {
            return this.GetCellValue(new CHBK2014_N9.Common.Class.RowClickEventArgs(RowIndex, FieldName));
        }

        public virtual void Import()
        {
        }
       
        private void Init()
        {

            this.xucToolBar.AddClick += new ButtonClickEventHander(this.ucToolBar_AddClick);
            xucToolBar.EditClick += new ButtonClickEventHander(this.ucToolBar_EditClick);
            xucToolBar.DeleteClick += new ButtonClickEventHander(this.ucToolBar_DeleteClick);
            this.xucToolBar.SearchClick += new ButtonClickEventHander(this.ucToolBar_SearchClick);
            this.xucToolBar.PrintClick += new ButtonClickEventHander(this.ucToolBar_PrintClick);
            this.xucToolBar.RefreshClick += new ButtonClickEventHander(this.ucToolBar_RefreshClick);
            this.xucToolBar.OptionClick += new ButtonClickEventHander(this.ucToolBar_OptionClick);
            this.xucToolBar.ExportClick += new ButtonClickEventHander(this.ucToolBar_Export);
            this.xucToolBar.HelpClick += new ButtonClickEventHander(this.ucToolBar_HelpClick);
            this.xucToolBar.CloseClick += new ButtonClickEventHander(this.ucToolBar_CloseClick);
            this.xucToolBar.ImportClick += new ButtonClickEventHander(this.ucToolBar_ImportClick);
            this.xucToolBar.PermisionClick += new ButtonClickEventHander(this.ucToolBar_PermisionClick);
            this.xucToolBar.ConstructClick += new ButtonClickEventHander(this.ucToolBar_ConstructClick);
            this.xucToolBar.CopyClick += new ButtonClickEventHander(this.ucToolBar_CopyClick);
            this.xucToolBar.MirrorClick += new ButtonClickEventHander(this.ucToolBar_MirrorClick);
            this.xucToolBar.ClearClick += new ButtonClickEventHander(this.ucToolBar_ClearClick);
            this.ReLoad();
            this.m_Status = Actions.None;
            xucToolBar.bm.SetPopupContextMenu(this.gcList, this.xucToolBar.pm);


        }


        protected virtual void ItemSelectd(CHBK2014_N9.Common.Class.RowClickEventArgs ex)
        {
        }

        protected virtual void List_Init(AdvBandedGridView dt)
        {
        }

        public virtual void Mirror()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
          this.Init();
            base.OnLoad(e);
        }

        public virtual void Permision()
        {
        }

        protected virtual void Print()
        {
            //(new xfmReport("Danh Mục")).ShowPrintPreview(this.gcList);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            bool flag;
            Keys key = keyData;
            if (key <= Keys.F5)
            {
                if (key == Keys.Escape)
                {
                    this.RaiseCloseClickEventHander();
                    flag = true;
                }
                else if (key == Keys.F1)
                {
                    this.ucToolBar_HelpClick(this.xucToolBar);
                    flag = true;
                }
                else
                {
                    if (key != Keys.F5)
                    {
                        flag = false;
                        return flag;
                    }
                    this.ReLoad();
                    flag = true;
                }
            }
            else if (key <= (Keys.MButton | Keys.ShiftKey | Keys.Capital | Keys.CapsLock | Keys.D | Keys.P | Keys.T | Keys.Control))
            {
                switch (key)
                {
                    case Keys.LButton | Keys.MButton | Keys.XButton1 | Keys.A | Keys.D | Keys.E | Keys.Control:
                        {
                            this.ucToolBar_Export(this.xucToolBar);
                            flag = true;
                            break;
                        }
                    case Keys.RButton | Keys.MButton | Keys.XButton2 | Keys.B | Keys.D | Keys.F | Keys.Control:
                        {
                            this.ucToolBar_SearchClick(this.xucToolBar);
                            flag = true;
                            break;
                        }
                    default:
                        {
                            switch (key)
                            {
                                case Keys.RButton | Keys.MButton | Keys.XButton2 | Keys.Back | Keys.LineFeed | Keys.Clear | Keys.B | Keys.D | Keys.F | Keys.H | Keys.J | Keys.L | Keys.N | Keys.Control:
                                    {
                                        this.ucToolBar_AddClick(this.xucToolBar);
                                        flag = true;
                                        break;
                                    }
                                case Keys.LButton | Keys.RButton | Keys.Cancel | Keys.MButton | Keys.XButton1 | Keys.XButton2 | Keys.Back | Keys.Tab | Keys.LineFeed | Keys.Clear | Keys.Return | Keys.Enter | Keys.A | Keys.B | Keys.C | Keys.D | Keys.E | Keys.F | Keys.G | Keys.H | Keys.I | Keys.J | Keys.K | Keys.L | Keys.M | Keys.N | Keys.O | Keys.Control:
                                    {
                                        this.ucToolBar_OptionClick(this.xucToolBar);
                                        flag = true;
                                        break;
                                    }
                                case Keys.ShiftKey | Keys.P | Keys.Control:
                                    {
                                        this.ucToolBar_PrintClick(this.xucToolBar);
                                        flag = true;
                                        break;
                                    }
                                case Keys.LButton | Keys.ShiftKey | Keys.ControlKey | Keys.A | Keys.P | Keys.Q | Keys.Control:
                                case Keys.RButton | Keys.ShiftKey | Keys.Menu | Keys.B | Keys.P | Keys.R | Keys.Control:
                                case Keys.LButton | Keys.RButton | Keys.Cancel | Keys.ShiftKey | Keys.ControlKey | Keys.Menu | Keys.Pause | Keys.A | Keys.B | Keys.C | Keys.P | Keys.Q | Keys.R | Keys.S | Keys.Control:
                                    {
                                        flag = false;
                                        return flag;
                                    }
                                case Keys.MButton | Keys.ShiftKey | Keys.Capital | Keys.CapsLock | Keys.D | Keys.P | Keys.T | Keys.Control:
                                    {
                                        this.ucToolBar_AddClick(this.xucToolBar);
                                        flag = true;
                                        break;
                                    }
                                default:
                                    {
                                        flag = false;
                                        return flag;
                                    }
                            }
                            break;
                        }
                }
            }
            else if (key == (Keys.MButton | Keys.D | Keys.Alt))
            {
                MessageBox.Show("You are stupid");
                flag = true;
            }
            else
            {
                if (key != (Keys.Back | Keys.ShiftKey | Keys.FinalMode | Keys.H | Keys.P | Keys.X | Keys.Alt))
                {
                    flag = false;
                    return flag;
                }
                this.RaiseCloseClickEventHander();
                flag = true;
            }
            return flag;
        }

        private void RaiseCloseClickEventHander()
        {
            if (this.CloseClick != null)
            {
                this.CloseClick(this);
            }
        }

        private void RaiseListKeyDownEventHander(KeyEventArgs key, CHBK2014_N9.Common.Class.RowClickEventArgs e)
        {
            if (this.ListKeyDown != null)
            {
                this.ListKeyDown(this, key, e);
            }
        }

        private void RaiseRowClickEventHander(CHBK2014_N9.Common.Class.RowClickEventArgs e)
        {
            if (this.RowClick != null)
            {
                this.RowClick(this, e);
            }
        }

        private void RaiseRowDoubleClickEventHander( CHBK2014_N9.Common.Class.RowClickEventArgs e)
        {
            if (this.RowDoubleClick != null)
            {
                this.RowDoubleClick(this, e);
            }
        }

        public virtual void ReadLayout(string name)
        {
            FileInfo fileInfo = new FileInfo(string.Concat(Application.StartupPath, "\\Layout\\", name, ".xml"));
            if (fileInfo.Exists)
            {
                try
                {
                    this.gbList.RestoreLayoutFromXml(fileInfo.FullName);
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

        public virtual void ReadLayout()
        {
            this.ReadLayout(base.Name);
        }

        public virtual void ReLoad()
        {
        }

        public virtual void SaveLayout(string name)
        {
            if (!Directory.Exists(string.Concat(Application.StartupPath, "\\Layout")))
            {
                Directory.CreateDirectory(string.Concat(Application.StartupPath, "\\Layout"));
            }
            try
            {
                this.gbList.SaveLayoutToXml(string.Concat(Application.StartupPath, "\\Layout\\", name, ".xml"));
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                XtraMessageBox.Show(string.Concat("Lỗi:\n\t", exception.Message), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public virtual void SaveLayout()
        {
            this.SaveLayout(base.Name);
        }

        protected virtual void Search()
        {
            XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
        }

       

        public virtual void SetSearch(CHBK2014_N9.Common.Class.RowClickEventArgs e)
        {
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

        private void ucToolBar_AddClick(object sender)
        {
            this.Add();
        }

        private void ucToolBar_ClearClick(object sender)
        {
            if (this.gbList.RowCount != 0)
            {
                this.gbList.SelectAll();
                this.Delete();
               this.SetMenu(this.m_RowClickEventArgs);
            }
        }

        private void ucToolBar_CloseClick(object sender)
        {
            this.RaiseCloseClickEventHander();
            if (base.ParentForm != null)
            {
                base.ParentForm.Close();
            }
        }

        private void ucToolBar_ConstructClick(object sender)
        {
            this.Construct();
        }

        private void ucToolBar_CopyClick(object sender)
        {
            this.gbList.CopyToClipboard();
        }

        private void ucToolBar_DeleteClick(object sender)
        {
            if (this.gbList.RowCount != 0)
            {
                this.Delete();
               this.SetMenu(this.m_RowClickEventArgs);
            }
        }

        private void ucToolBar_EditClick(object sender)
        {
            if (this.gbList.RowCount != 0)
            {
                this.Change();
            }
        }

        private void ucToolBar_Export(object sender)
        {
            this.exportView = this.gbList;
            this.Export(this.gbList);
        }

        private void ucToolBar_HelpClick(object sender)
        {
            Process.Start("hyperlink here");
        }

        private void ucToolBar_ImportClick(object sender)
        {
            this.Import();
        }

        private void ucToolBar_MirrorClick(object sender)
        {
            this.Mirror();
        }

        private void ucToolBar_OptionClick(object sender)
        {
            XtraMessageBox.Show("Tính năng này không được hỗ trợ!");
        }

        private void ucToolBar_PermisionClick(object sender)
        {
            this.Permision();
        }

        private void ucToolBar_PrintClick(object sender)
        {
            this.Print();
        }

        private void ucToolBar_RefreshClick(object sender)
        {
            this.ReLoad();
        }

        private void ucToolBar_SearchClick(object sender)
        {
            this.Search();
        }

        protected virtual void UpdateRow(object Item, CHBK2014_N9.Common.Class.RowClickEventArgs e)
        {
        }

        public event ButtonClickEventHander CloseClick;

        public event ListKeyDownEventHander ListKeyDown;

        public event RowClickEventHander RowClick;

        public event RowClickEventHander RowDoubleClick;

        private void xucBaseBasic_Load(object sender, EventArgs e)
        {
         
          
        }

        private void gbList_RowCellClick(object sender, RowCellClickEventArgs e)
        {
           CHBK2014_N9.Common.Class.RowClickEventArgs rowClickEventArg = new CHBK2014_N9.Common.Class.RowClickEventArgs(e.RowHandle, e.Column.ColumnHandle);
            this.m_RowClickEventArgs = rowClickEventArg;
            this.RaiseRowClickEventHander(rowClickEventArg);
            this.ItemSelectd(rowClickEventArg);
            this.SetMenu(rowClickEventArg);
            this.SetSearch(rowClickEventArg);
        }

        private void gbList_DoubleClick_1(object sender, EventArgs e)
        {
            if (!(sender is AdvBandedGridView))
            {
                XtraMessageBox.Show("Object is not AdvBandedGridView");
            }
            else
            {
                AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
                CHBK2014_N9.Common.Class.RowClickEventArgs rowClickEventArg = new CHBK2014_N9.Common.Class.RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
                this.m_RowClickEventArgs = rowClickEventArg;
                if (this._search)
                {
                    this.SetSearch(rowClickEventArg);
                }
                else
                {
                    if (this.gbList.RowCount == 0)
                    {
                        return;
                    }
                    this.RaiseRowDoubleClickEventHander(rowClickEventArg);
                    this.Change();
                }
            }
        }
    }
}
