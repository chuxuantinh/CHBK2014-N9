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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using CHBK2014_N9.Common.Class;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace CHBK2014_N9.Common
{
    public partial class XucBaseBasicE : xucBase
    {

        protected DateTime m_FromDate;

        protected DateTime m_ToDate;

        protected int m_Month = 0;

        protected int m_Year = 0;

        protected bool m_IsLock = false;

        protected bool m_IsFinish = false;

        protected bool m_IsFirstLoad = true;

        public XucBaseBasicE()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.View();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Import();
        }


        private void _exportView_Click(object sender, EventArgs e)
        {
        }

        private void _exportView_DataSourceChanged(object sender, EventArgs e)
        {
            this.CustomizeToolBar(0);
        }

        private void _exportView_DoubleClick(object sender, EventArgs e)
        {
            if (this._exportView.RowCount != 0)
            {
                if (this.bbiEdit.Enabled)
                {
                    this.Change();
                }
            }

        }

        private void _exportView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (this._exportView.RowCount != 0)
                {
                    if (this.bbiEdit.Enabled)
                    {
                        this.Change();
                    }
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.Reload();
            }
            else if (e.KeyCode == Keys.Control | e.KeyCode == Keys.N)
            {
                if (this.bbiAdd.Enabled)
                {
                    this.Add();
                }
            }
            else if (e.KeyCode == Keys.Alt | e.KeyCode == Keys.T)
            {
                if (this.bbiAdd.Enabled)
                {
                    this.Add();
                }
            }
            else if (e.KeyCode == Keys.Control | e.KeyCode == Keys.E)

            {
                base.Export();
            }
            else if (e.KeyCode == Keys.Control | e.KeyCode == Keys.P)
            {
                this.Print();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (this._exportView.RowCount != 0)
                {
                    if (this.bbiDelete.Enabled)
                    {
                        this.Delete();
                    }
                }
            }
            else if (e.KeyCode == Keys.Alt | e.KeyCode == Keys.X)
            {
                if (this._exportView.RowCount != 0)
                {
                    if (this.bbiDelete.Enabled)
                    {
                        this.Delete();
                    }
                }
            }
        }

        private void _exportView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.DoShowMenu(this._exportView.CalcHitInfo(new Point(e.X, e.Y)), this._exportView, this);
            }
        }

        private void _exportView_RowCountChanged(object sender, EventArgs e)
        {
            this.CustomizeToolBar(0);
        }

        protected virtual void ActionPlusWithData()
        {
        }


        protected virtual void Add()
        {
        }

        protected virtual void AfterInitializeComponent()
        {
        }

        private void bbeDateTimeSelect_EditValueChanged(object sender, EventArgs e)
        {
            this.SetDateTime(this.bbeDateTimeSelect.EditValue.ToString());
        }

        private void bbeTableListSelect_EditValueChanged(object sender, EventArgs e)
        {
            this.bbeTableListSelect_EditValueChanged();
        }

        protected virtual void bbeTableListSelect_EditValueChanged()
        {
        }

        private void bbiActionPlusWithData_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ActionPlusWithData();
        }

        private void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Add();
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiCopy_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Copy();
        }

        private void bbiCreate_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Create();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Delete();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Change();
        }

        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Export();
        }

        private void bbiFinish_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Finish();
            this.CustomizeToolBar(0);
        }

        private void bbiNameListOption_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.bbiNameListOption_ItemClick();
        }

        protected virtual void bbiNameListOption_ItemClick()
        {
        }

        private void bbiOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Open();
            this.CustomizeToolBar(0);
        }

        private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Print();
        }

        private void bbiQuickAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.QuickAdd();
        }

        private void bbiReCreate_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.ReCreate();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Reload();
        }

        private void bbiSendMail_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.SendMail();
        }

        protected virtual void Change()
        {
        }

        protected virtual void Close()
        {
            base.ParentForm.Close();
        }

        protected virtual void Copy()
        {
            if (this._exportView != null)
            {
                Clipboard.SetText(this._exportView.GetFocusedValue().ToString());
            }
        }

        protected virtual void Create()
        {
        }

        protected void CustomizeToolBar(int TypeToolBar)
        {
            if (TypeToolBar == -1)
            {
                this.bbiAdd.Enabled = false;
                this.bbiQuickAdd.Enabled = false;
                this.bbiReCreate.Enabled = false;
                this.bbiSendMail.Enabled = false;
                this.bbiEdit.Enabled = false;
                this.bbiDelete.Enabled = false;
                this.bbiImport.Enabled = false;
                this.bbiExport.Enabled = false;
                this.bbiPrint.Enabled = false;
                this.bbiLock.Enabled = false;
                this.bbiOpen.Enabled = false;
                this.bbiFinish.Enabled = false;
                this.bbiActionPlusWithData.Enabled = false;
            }
            else if (this._exportControl.DataSource == null)
            {
                this.CustomizeToolBar(-1);
            }
            else if (!(!this.m_IsLock ? true : this.m_IsFinish))
            {
                this.bbiAdd.Enabled = false;
                this.bbiQuickAdd.Enabled = false;
                this.bbiReCreate.Enabled = false;
                this.bbiSendMail.Enabled = true;
                this.bbiEdit.Enabled = false;
                this.bbiDelete.Enabled = false;
                this.bbiImport.Enabled = false;
                this.bbiExport.Enabled = true;
                this.bbiPrint.Enabled = true;
               this.bbiLock.Enabled = false;
                this.bbiOpen.Enabled = true;
                this.bbiFinish.Enabled = true;
                this.bbiActionPlusWithData.Enabled = false;
            }
            else if (!(!this.m_IsLock ? true : !this.m_IsFinish))
            {
                this.bbiAdd.Enabled = false;
                this.bbiQuickAdd.Enabled = false;
                this.bbiReCreate.Enabled = false;
                this.bbiSendMail.Enabled = true;
                this.bbiEdit.Enabled = false;
                this.bbiDelete.Enabled = false;
                this.bbiImport.Enabled = false;
                this.bbiExport.Enabled = true;
                this.bbiPrint.Enabled = true;
               this.bbiLock.Enabled = false;
                this.bbiOpen.Enabled = false;
                this.bbiFinish.Enabled = false;
                this.bbiActionPlusWithData.Enabled = false;
            }
            else if (this._exportView.RowCount != 0)
            {
                this.bbiAdd.Enabled = true;
                this.bbiQuickAdd.Enabled = true;
                this.bbiReCreate.Enabled = true;
                this.bbiSendMail.Enabled = true;
                this.bbiEdit.Enabled = true;
                this.bbiDelete.Enabled = true;
                this.bbiImport.Enabled = true;
                this.bbiExport.Enabled = true;
                this.bbiPrint.Enabled = true;
               this.bbiLock.Enabled = true;
                this.bbiOpen.Enabled = true;
                this.bbiFinish.Enabled = true;
                this.bbiActionPlusWithData.Enabled = true;
            }
            else
            {
                this.bbiAdd.Enabled = true;
                this.bbiQuickAdd.Enabled = true;
                this.bbiReCreate.Enabled = true;
                this.bbiSendMail.Enabled = false;
                this.bbiEdit.Enabled = false;
                this.bbiDelete.Enabled = false;
                this.bbiImport.Enabled = true;
                this.bbiExport.Enabled = false;
                this.bbiPrint.Enabled = true;
              this.bbiLock.Enabled = true;
                this.bbiOpen.Enabled = true;
                this.bbiFinish.Enabled = true;
                this.bbiActionPlusWithData.Enabled = true;
            }
        }

        protected virtual new void Delete()
        {
        }

        protected virtual void Finish()
        {
        }

        protected virtual void Help()
        {
        }

        protected virtual void Import()
        {
        }

        protected virtual void Lock()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.CustomizeToolBar(-1);
            this.repMonth.EditValueChanging += new ChangingEventHandler(this.repMonth_EditValueChanging);
           this.repMonth.EditValueChanged += new EventHandler(this.repMonth_EditValueChanged);
            this.repYear.EditValueChanging += new ChangingEventHandler(this.repYear_EditValueChanging);
            this.repYear.EditValueChanged += new EventHandler(this.repYear_EditValueChanged);
            this.repFromDate.EditValueChanging += new ChangingEventHandler(this.repFromDate_EditValueChanging);
            this.repFromDate.EditValueChanged += new EventHandler(this.repFromDate_EditValueChanged);
            this.repToDate.EditValueChanging += new ChangingEventHandler(this.repToDate_EditValueChanging);
            this.repToDate.EditValueChanged += new EventHandler(this.repToDate_EditValueChanged);
            clsAllOption _clsAllOption = new clsAllOption();
            this.m_Month = _clsAllOption.MonthDefault.Month;
            this.m_Year = _clsAllOption.MonthDefault.Year;
            this.bbeMonth.EditValue = _clsAllOption.MonthDefault;
            this.bbeYear.EditValue = _clsAllOption.MonthDefault;
            if (this._exportView != null)
            {
                base.RestoreLayout(this._exportView, this);
                this._exportView.Click += new EventHandler(this._exportView_Click);
                this._exportView.DoubleClick += new EventHandler(this._exportView_DoubleClick);
                this._exportView.KeyDown += new KeyEventHandler(this._exportView_KeyDown);
                this._exportView.MouseDown += new MouseEventHandler(this._exportView_MouseDown);
                this._exportView.DataSourceChanged += new EventHandler(this._exportView_DataSourceChanged);
                this._exportView.RowCountChanged += new EventHandler(this._exportView_RowCountChanged);
                this._exportView.CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(this.XucBaseBasicE_CustomDrawRowIndicator);
            }
            if (this._exportControl != null)
            {
                this.bm.SetPopupContextMenu(this._exportControl, this.pm);
            }
            this.Reload();
        }

        protected virtual void Open()
        {
        }

        protected virtual void Print()
        {
        }

        protected virtual void QuickAdd()
        {
        }

        protected virtual void ReCreate()
        {
        }

        protected virtual void Reload()
        {
        }


        private void repFromDate_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void repFromDate_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.m_FromDate = DateTime.Parse(e.NewValue.ToString());
        }

        private void repMonth_EditValueChanged(object sender, EventArgs e)
        {
            this.repYear_EditValueChanged();
        }

        protected virtual void repMonth_EditValueChanged()
        {
        }

        private void repMonth_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DateTime dateTime = DateTime.Parse(e.NewValue.ToString());
            this.m_Month = dateTime.Month;
           this.repYear_EditValueChanging();
        }

        protected virtual void repMonth_EditValueChanging()
        {
        }

        private void repTableListSelect_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                this.repTableListSelect_ButtonClick();
            }
        }


        protected virtual void repTableListSelect_ButtonClick()
        {
        }

        private void repTableListSelect_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.repTableListSelect_EditValueChanging(e);
        }

        protected virtual void repTableListSelect_EditValueChanging(ChangingEventArgs e)
        {
        }

        private void repToDate_EditValueChanged(object sender, EventArgs e)
        {
        }



       
        private void repToDate_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.m_ToDate = DateTime.Parse(e.NewValue.ToString());
        }

        private void repYear_EditValueChanged(object sender, EventArgs e)
        {
            this.repYear_EditValueChanged();
        }

        protected virtual void repYear_EditValueChanged()
        {
        }

        private void repYear_EditValueChanging(object sender, ChangingEventArgs e)
        {
            DateTime dateTime = DateTime.Parse(e.NewValue.ToString());
            this.m_Year = dateTime.Year;
            this.repYear_EditValueChanging();
        }

        protected virtual void repYear_EditValueChanging()
        {
        }

        protected virtual void SendMail()
        {
        }

        private void SetDateTime(string text)
        {
            DateTime now;
            if ((this.bbeFromDate.EditValue == null ? true : this.bbeToDate.EditValue == null))
            {
                int year = DateTime.Now.Year;
                now = DateTime.Now;
                this.m_FromDate = new DateTime(year, now.Month, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else
            {
                this.m_FromDate = DateTime.Parse(this.bbeFromDate.EditValue.ToString());
                this.m_ToDate = DateTime.Parse(this.bbeToDate.EditValue.ToString());
            }
            if (text == "Hôm nay")
            {
                this.m_FromDate = DateTime.Now;
                this.m_ToDate = DateTime.Now;
            }
            else if (text == "Tuần này")
            {
                this.m_FromDate = DateAndTime.DateAdd(DateInterval.Day, (double)(-DateAndTime.Weekday(DateTime.Now, FirstDayOfWeek.Monday)), DateTime.Now);
                this.m_ToDate = DateAndTime.DateAdd(DateInterval.Day, (double)DateAndTime.Weekday(DateTime.Now, FirstDayOfWeek.Monday), DateTime.Now);
            }
            else if (text == "Tháng này")
            {
                int num = DateTime.Now.Year;
                now = DateTime.Now;
                this.m_FromDate = new DateTime(num, now.Month, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Quý này")
            {
                if (DateTime.Now.Month >= 1 & DateTime.Now.Month <= 3)
                {
                    now = DateTime.Now;
                    this.m_FromDate = new DateTime(now.Year, 1, 1);
                    now = this.m_FromDate.AddMonths(4);
                    this.m_ToDate = now.AddDays(-1);
                }
                else if (DateTime.Now.Month >= 4 & DateTime.Now.Month <= 6)
                {
                    now = DateTime.Now;
                    this.m_FromDate = new DateTime(now.Year, 4, 1);
                    now = this.m_FromDate.AddMonths(4);
                    this.m_ToDate = now.AddDays(-1);
                }
                else if (!(DateTime.Now.Month >= 7 & DateTime.Now.Month <= 9))
                {
                    now = DateTime.Now;
                    this.m_FromDate = new DateTime(now.Year, 10, 1);
                    now = this.m_FromDate.AddMonths(4);
                    this.m_ToDate = now.AddDays(-1);
                }
                else
                {
                    now = DateTime.Now;
                    this.m_FromDate = new DateTime(now.Year, 9, 1);
                    now = this.m_FromDate.AddMonths(4);
                    this.m_ToDate = now.AddDays(-1);
                }
            }
            else if (text == "Năm nay")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 1, 1);
                now = this.m_FromDate.AddMonths(12);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 1")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 1, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 2")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 2, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 3")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 3, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 4")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 4, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 5")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 5, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 6")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 6, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 7")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 7, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 8")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 8, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 9")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 9, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 10")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 10, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 11")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 11, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Tháng 12")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 12, 1);
                now = this.m_FromDate.AddMonths(1);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Quý 1")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 1, 1);
                now = this.m_FromDate.AddMonths(3);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Quý 2")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 4, 1);
                now = this.m_FromDate.AddMonths(3);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Quý 3")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 7, 1);
                now = this.m_FromDate.AddMonths(3);
                this.m_ToDate = now.AddDays(-1);
            }
            else if (text == "Quý 4")
            {
                now = DateTime.Now;
                this.m_FromDate = new DateTime(now.Year, 10, 1);
                now = this.m_FromDate.AddMonths(3);
                this.m_ToDate = now.AddDays(-1);
            }
            this.bbeFromDate.EditValue = this.m_FromDate;
            this.bbeToDate.EditValue = this.m_ToDate;
        }

        protected virtual void View()
        {
        }

        private void XucBaseBasicE_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void bbeMonth_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbeTableListSelect_EditValueChanged_1(object sender, EventArgs e)
        {
            this.bbeTableListSelect_EditValueChanged();
        }

        private void repTableListSelect_EditValueChanging_1(object sender, ChangingEventArgs e)
        {
            this.repTableListSelect_EditValueChanging(e);
        }

        private void repTableListSelect_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bbiLock_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Lock();
            this.CustomizeToolBar(0);
        }
    }
}
