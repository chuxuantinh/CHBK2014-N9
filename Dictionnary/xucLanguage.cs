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
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucLanguage : xucBaseBasic
    {

        //  private XucToolBar uct1 = new XucToolBar();
       
        public xucLanguage()
        {
            InitializeComponent();
            ucToolBar.SetInterface();
        }

        //private void InitializeComponent()
        //{
        //    this.components = new Container();
        //    base.AutoScaleMode = AutoScaleMode.Font;
        //}


        protected override void Add()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiLanguage") != "OK"))
            {
                if (MyRule.AllowAdd)
                {
                    xfmLanguageAdd _xfmLanguageAdd = new xfmLanguageAdd(Actions.Add);
                    _xfmLanguageAdd.Added += new xfmLanguageAdd.AddedEventHander(this.frm_Added);
                    _xfmLanguageAdd.ShowDialog();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        private void AddRow(DIC_LANGUAGE Item)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.AddNewRow();
            focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Active", Item.Active);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "LanguageCode", Item.LanguageCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "LanguageName", Item.LanguageName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Description", Item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

        public override void Change()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiLanguage") != "OK"))
            {
                if (MyRule.AllowAccess)
                {
                    DIC_LANGUAGE dICLANGUAGE = new DIC_LANGUAGE();
                    object cellValue = base.GetCellValue(m_RowClickEventArgs.RowIndex, "LanguageCode");
                    if (cellValue != null)
                    {
                        base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                        if (!(dICLANGUAGE.Get(cellValue.ToString()) != "OK"))
                        {
                            this.DoHide();
                            xfmLanguageAdd _xfmLanguageAdd = new xfmLanguageAdd(Actions.Update, dICLANGUAGE);
                            _xfmLanguageAdd.Updated += new xfmLanguageAdd.UpdatedEventHander(this.frm_Updated);
                            _xfmLanguageAdd.Added += new xfmLanguageAdd.AddedEventHander(this.frm_Added);
                            _xfmLanguageAdd.ShowDialog();
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
            if (!(MyRule.Get(MyLogin.RoleId, "bbiLanguage") != "OK"))
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
                    DIC_LANGUAGE dICLANGUAGE = new DIC_LANGUAGE();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        cellValue = base.GetCellValue(selectedRows[i - 1], "LanguageCode");
                        if (cellValue != null)
                        {
                            //SYS_LOG.Insert("Danh Mục Ngoại Ngữ", "Xoá", cellValue.ToString());
                            str = dICLANGUAGE.Delete(cellValue.ToString());
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
                          cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "LanguageCode");
                            if (cellValue != null)
                            {
                                //SYS_LOG.Insert("Danh Mục Ngoại Ngữ", "Xoá", cellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = dICLANGUAGE.Delete(cellValue.ToString());
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

        internal void Save()
        {
            throw new NotImplementedException();
        }

        protected override bool ExportPermision()
        {
            bool flag;
            if (MyRule.Get(MyLogin.RoleId, "bbiLanguage") != "OK")
            {
                flag = false;
            }
            else if (MyRule.AllowExport)
            {
             //   SYS_LOG.Insert("Danh Mục Ngoại Ngữ", "Xuất");
                flag = base.ExportPermision();
            }
            else
            {
                MyRule.Notify();
                flag = false;
            }
            return flag;
        }


        private void frm_Added(object sender, DIC_LANGUAGE e)
        {
            this.AddRow(e);
        }

        private void frm_Updated(object sender, DIC_LANGUAGE Item)
        {
            this.UpdateRow(Item, this.m_RowClickEventArgs);
        }


        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
            RowClickEventArgs rowClickEventArg = new RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
            object cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "LanguageCode");
            DisableMenu(false);
            if (cellValue == null)
            {
                base.DisableMenu(true);
            }
            base.gbList_MouseDown(sender, e);
        }
      

        protected override void List_Init(AdvBandedGridView dt)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string fieldName = dt.Columns[i].FieldName;
                if (fieldName != null)
                {
                    if (fieldName == "LanguageCode")
                    {
                        dt.Columns[i].OptionsColumn.ReadOnly = true;
                        dt.Columns[i].OptionsColumn.AllowEdit = false;
                        dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                        dt.Columns[i].OptionsColumn.FixedWidth = true;
                       
                            dt.Columns[i].Caption = "Mã";
                       
                        dt.Columns[i].Width = 60;
                        goto Label0;
                    }
                    else if (fieldName == "LanguageName")
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
                       
                            dt.Columns[i].Caption = "Ghi chú";
                      
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
            if (!(MyRule.Get(MyLogin.RoleId, "bbiLanguage") != "OK"))
            {
                if (MyRule.AllowPrint)
                {
              //      SYS_LOG.Insert("Danh Mục Ngoại Ngữ", "In");
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
            DIC_LANGUAGE dICLANGUAGE = new DIC_LANGUAGE();
            this.gcList.DataSource = dICLANGUAGE.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.List_Init(this.gbList);
            base.SetWaitDialogCaption("Nạp quyền sử dụng ...");
            MyRule.Get(MyLogin.RoleId, "bbiLanguage");
            if (!MyRule.AllowPrint)
            {
                this.ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiLanguage");
            if (!MyRule.AllowExport)
            {
                this.ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiLanguage");
            if (!MyRule.AllowAdd)
            {
                this.ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiLanguage");
            if (!MyRule.AllowDelete)
            {
                this.ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiLanguage");
            if (!MyRule.AllowEdit)
            {
                this.ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            }
            base.SetWaitDialogCaption("Đã xong...");
            this.DoHide();
           
           
        }

        protected override void gbList_Click(object sender, EventArgs e)
        {
        
        }

        private void UpdateRow(DIC_LANGUAGE item, RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int rowIndex = e.RowIndex;
            advBandedGridView.SetRowCellValue(rowIndex, "Active", item.Active);
            advBandedGridView.SetRowCellValue(rowIndex, "LanguageCode", item.LanguageCode);
            advBandedGridView.SetRowCellValue(rowIndex, "LanguageName", item.LanguageName);
            advBandedGridView.SetRowCellValue(rowIndex, "Description", item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

        private void xucLanguage_Load(object sender, EventArgs e)
        {
            DisableMenu(false);
        }

        private void xucCustomerType_Load(object sender, EventArgs e)
        {
        }

        protected override void gbList_DoubleClick(object sender, EventArgs e)
        {
           
        }
       
    }
}
