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
using System.Windows.Forms;

namespace CHBK2014_N9.Dictionnary
{
    public partial class xucHospital : xucBaseBasic
    {
        public xucHospital()
        {
            
            this.ucToolBar.SetInterface();
        }

        protected override void Add()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiHospital") != "OK"))
            {
                if (MyRule.AllowAdd)
                {
                    //xfmHospitalAdd _xfmHospitalAdd = new xfmHospitalAdd(Actions.Add);
                    //_xfmHospitalAdd.Added += new xfmHospitalAdd.AddedEventHander(this.frm_Added);
                    //_xfmHospitalAdd.ShowDialog();
                }
                else
                {
                    MyRule.Notify();
                }
            }
        }

        private void AddRow(DIC_HOSPITAL Item)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.AddNewRow();
            focusedRowHandle = advBandedGridView.FocusedRowHandle;
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Active", Item.Active);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "HospitalCode", Item.HospitalCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "ProvinceCode", Item.ProvinceCode);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "HospitalName", Item.HospitalName);
            advBandedGridView.SetRowCellValue(focusedRowHandle, "Description", Item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

        public override void Change()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiHospital") != "OK"))
            {
                if (MyRule.AllowAccess)
                {
                    DIC_HOSPITAL dICHOSPITAL = new DIC_HOSPITAL();
                    object cellValue = base.GetCellValue(this.m_RowClickEventArgs.RowIndex, "HospitalCode");
                    if (cellValue != null)
                    {
                        base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                        if (!(dICHOSPITAL.Get(cellValue.ToString()) != "OK"))
                        {
                            this.DoHide();
                            //xfmHospitalAdd _xfmHospitalAdd = new xfmHospitalAdd(Actions.Update, dICHOSPITAL);
                            //_xfmHospitalAdd.Updated += new xfmHospitalAdd.UpdatedEventHander(this.frm_Updated);
                            //_xfmHospitalAdd.Added += new xfmHospitalAdd.AddedEventHander(this.frm_Added);
                            //_xfmHospitalAdd.ShowDialog();
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
            if (!(MyRule.Get(MyLogin.RoleId, "bbiHospital") != "OK"))
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
                    DIC_HOSPITAL dICHOSPITAL = new DIC_HOSPITAL();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        cellValue = base.GetCellValue(selectedRows[i - 1], "HospitalCode");
                        if (cellValue != null)
                        {
                            SYS_LOG.Insert("Danh Mục Bằng Cấp", "Xoá", cellValue.ToString());
                            str = dICHOSPITAL.Delete(cellValue.ToString());
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
                            cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "HospitalCode");
                            if (cellValue != null)
                            {
                                SYS_LOG.Insert("Danh Mục Bằng Cấp", "Xoá", cellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = dICHOSPITAL.Delete(cellValue.ToString());
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
            if (MyRule.Get(MyLogin.RoleId, "bbiHospital") != "OK")
            {
                flag = false;
            }
            else if (MyRule.AllowExport)
            {
                SYS_LOG.Insert("Danh Mục Bằng Cấp", "Xuất");
                flag = base.ExportPermision();
            }
            else
            {
                MyRule.Notify();
                flag = false;
            }
            return flag;
        }

        private void frm_Added(object sender, DIC_HOSPITAL e)
        {
            this.AddRow(e);
        }

        private void frm_Updated(object sender, DIC_HOSPITAL Item)
        {
            this.UpdateRow(Item, this.m_RowClickEventArgs);
        }

        protected override void gbList_MouseDown(object sender, MouseEventArgs e)
        {
            AdvBandedGridView advBandedGridView = (AdvBandedGridView)sender;
            RowClickEventArgs rowClickEventArg = new RowClickEventArgs((advBandedGridView == null ? -1 : advBandedGridView.FocusedRowHandle), (advBandedGridView.FocusedColumn == null ? -1 : advBandedGridView.FocusedColumn.ColumnHandle), (advBandedGridView.FocusedColumn == null ? "" : advBandedGridView.FocusedColumn.FieldName));
            this.m_RowClickEventArgs = rowClickEventArg;
            object cellValue = base.GetCellValue(rowClickEventArg.RowIndex, "HospitalCode");
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
                if (fieldName == null)
                {
                    goto Label0;
                }
                else if (fieldName == "HospitalCode")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                   
                        dt.Columns[i].Caption = "Mã bệnh viện";
                   
                    dt.Columns[i].Width = 60;
                }
                else if (fieldName == "ProvinceCode")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                   
                        dt.Columns[i].Caption = "Mã tỉnh";
                    
                    dt.Columns[i].Width = 60;
                }
                else if (fieldName == "HospitalName")
                {
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                  
                        dt.Columns[i].Caption = "Tên";
                   
                    dt.Columns[i].Width = 180;
                }
                else
                {
                    if (fieldName != "Description")
                    {
                        goto Label0;
                    }
                    dt.Columns[i].OptionsColumn.ReadOnly = true;
                    dt.Columns[i].OptionsColumn.AllowEdit = false;
                    dt.Columns[i].OptionsColumn.AllowGroup = DefaultBoolean.False;
                    dt.Columns[i].OptionsColumn.FixedWidth = true;
                  
                        dt.Columns[i].Caption = "Ghi chú";
                   
                    dt.Columns[i].Width = 150;
                }
           // Label2:;
            }
            return;
        Label0:
            dt.Columns[i].Visible = false;
          //  goto Label2;
        }

        protected override void Print()
        {
            if (!(MyRule.Get(MyLogin.RoleId, "bbiHospital") != "OK"))
            {
                if (MyRule.AllowPrint)
                {
                    SYS_LOG.Insert("Danh Mục Bằng Cấp", "In");
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
            DIC_HOSPITAL dICHOSPITAL = new DIC_HOSPITAL();
            this.gcList.DataSource = dICHOSPITAL.GetList();
            base.SetWaitDialogCaption("Đang nạp cấu hình...");
            this.List_Init(this.gbList);
            base.SetWaitDialogCaption("Nạp quyền sử dụng...");
            MyRule.Get(MyLogin.RoleId, "bbiHospital");
            if (!MyRule.AllowPrint)
            {
                this.ucToolBar.bbiPrint.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiHospital");
            if (!MyRule.AllowExport)
            {
                this.ucToolBar.bbiExport.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiHospital");
            if (!MyRule.AllowAdd)
            {
                this.ucToolBar.bbiAdd.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiHospital");
            if (!MyRule.AllowDelete)
            {
                this.ucToolBar.bbiDelete.Visibility = BarItemVisibility.Never;
            }
            MyRule.Get(MyLogin.RoleId, "bbiHospital");
            if (!MyRule.AllowEdit)
            {
                this.ucToolBar.bbiEdit.Visibility = BarItemVisibility.Never;
            }
            base.SetWaitDialogCaption("Đã xong...");
            this.DoHide();
        }

        private void UpdateRow(DIC_HOSPITAL item, RowClickEventArgs e)
        {
            AdvBandedGridView advBandedGridView = this.gbList;
            int rowIndex = e.RowIndex;
            advBandedGridView.SetRowCellValue(rowIndex, "Active", item.Active);
            advBandedGridView.SetRowCellValue(rowIndex, "HospitalCode", item.HospitalCode);
            advBandedGridView.SetRowCellValue(rowIndex, "ProvinceCode", item.ProvinceCode);
            advBandedGridView.SetRowCellValue(rowIndex, "HospitalName", item.HospitalName);
            advBandedGridView.SetRowCellValue(rowIndex, "Description", item.Description);
            advBandedGridView.UpdateCurrentRow();
        }

        private void xucCustomerType_Load(object sender, EventArgs e)
        {
        }

    }
}
