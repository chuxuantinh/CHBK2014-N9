using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.HumanResource.Report;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucContract : xucBase
    {

        private string m_EmployeeCode = "";

        private int m_Level = MyLogin.Level;

        private string m_Code = MyLogin.Code;

        private string m_Filter = "0";

        public xucContract()
        {
            this.InitializeComponent();
            base.RestoreLayout(this.gbList, this);
          
            this.LoadOrganization();
            this.Init();
            this.barManager1.SetPopupContextMenu(this.gcList, this.popupMenu1);
            this.splitContainerControl1.SplitterPosition = xucContract.LoadStyle();
        }

        private void Add()
        {
            xfmContractAdd _xfmContractAdd = new xfmContractAdd(Actions.Add);
            _xfmContractAdd.Added += new xfmContractAdd.AddedEventHander(this.frm_Added);
            _xfmContractAdd.ShowDialog();
        }
     

        private void dcList_Click(object sender, EventArgs e)
        {

        }

        private void bbiAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Add();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Change();
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseClosedHander();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            string str;
            object rowCellValue;
            HRM_EMPLOYEE hRMEMPLOYEE;
            if (MyRule.IsDelete("bbiContract"))
            {
                bool flag = false;
                int[] selectedRows = this.gbList.GetSelectedRows();
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    base.SetWaitDialogCaption("Đang xóa...");
                    HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        rowCellValue = this.gbList.GetRowCellValue(selectedRows[i - 1], "ContractCode");
                        this.m_EmployeeCode = this.gbList.GetRowCellValue(selectedRows[i - 1], "EmployeeCode").ToString();
                        if (rowCellValue != null)
                        {
                        //    SYS_LOG.Insert("Hợp Đồng Lao Động", "Xoá", rowCellValue.ToString());
                            str = hRMCONTRACT.Delete(rowCellValue.ToString());
                            if (str == "OK")
                            {
                                this.gbList.DeleteRow(selectedRows[i - 1]);
                                hRMEMPLOYEE = new HRM_EMPLOYEE();
                                hRMEMPLOYEE.Get(this.m_EmployeeCode);
                                if (hRMEMPLOYEE.ContractCode == rowCellValue.ToString())
                                {
                                    hRMEMPLOYEE.ContractCode = "";
                                    hRMEMPLOYEE.ContractType = "";
                                    hRMEMPLOYEE.Update();
                                }
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
                        if (hRMCONTRACT.GetList(this.m_Level, this.m_Code).Rows.Count != 0)
                        {
                            rowCellValue = this.gbList.GetFocusedRowCellValue("ContractCode");
                            this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue("EmployeeCode").ToString();
                            if (rowCellValue != null)
                            {
                                //                                SYS_LOG.Insert("Hợp Đồng Lao Động", "Xoá", rowCellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = hRMCONTRACT.Delete(rowCellValue.ToString());
                                if (str == "OK")
                                {
                                    this.gbList.DeleteRow(this.gbList.FocusedRowHandle);
                                    hRMEMPLOYEE = new HRM_EMPLOYEE();
                                    hRMEMPLOYEE.Get(this.m_EmployeeCode);
                                    if (hRMEMPLOYEE.ContractCode == rowCellValue.ToString())
                                    {
                                        hRMEMPLOYEE.ContractCode = "";
                                        hRMEMPLOYEE.ContractType = "";
                                        hRMEMPLOYEE.Update();
                                    }
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
        }

        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            this._exportView = this.gbList;
          //  SYS_LOG.Insert("Hợp Đồng Lao Động", "Xuất");
            base.Export();
        }

        private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                xfmOptionPrintContract _xfmOptionPrintContract = new xfmOptionPrintContract(this.m_Level, this.m_Code, this.gbList.GetFocusedRowCellValue(this.colContractCode).ToString(), this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString());
                _xfmOptionPrintContract.ShowDialog();
            }
            catch
            {
                (new xfmOptionPrintContract(this.m_Level, this.m_Code)).ShowDialog();
            }
        }

        private void bbiReload_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Init();
        }



        private void Change()
        {
            HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
            object focusedRowCellValue = this.gbList.GetFocusedRowCellValue("ContractCode");
            if (focusedRowCellValue != null)
            {
                base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                if (!(hRMCONTRACT.Get(focusedRowCellValue.ToString()) != "OK"))
                {
                    this.DoHide();
                    xfmContractAdd _xfmContractAdd = new xfmContractAdd(Actions.Update, hRMCONTRACT);
                    _xfmContractAdd.Updated += new xfmContractAdd.UpdatedEventHander(this.frm_Updated);
                    _xfmContractAdd.Added += new xfmContractAdd.AddedEventHander(this.frm_Added);
                    _xfmContractAdd.ShowDialog();
                }
                else
                {
                    this.DoHide();
                    XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private new void Delete()
        {
        }

        public void DisableMenu(bool disable)
        {
            this.bbiEdit.Enabled = !disable;
            this.bbiDelete.Enabled = !disable;
        }


        private void frm_Added(object sender, HRM_CONTRACT Item)
        {
            this.Init();
        }

        private void frm_Updated(object sender, HRM_CONTRACT Item)
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
                base.DoShowMenu(this.gbList.CalcHitInfo(new Point(e.X, e.Y)), this.gbList, this);
            }
            this.SetMenu(null);
        }

        private void Init()
        {
            this.repFilter.EditValueChanging += new ChangingEventHandler(this.repFilter_EditValueChanging);
            this.repFilter.EditValueChanged += new EventHandler(this.repFilter_EditValueChanged);
            this.LoadGrid(this.m_Level, this.m_Code);
        }

        private void LoadGrid(int Level, string Code)
        {
            HRM_CONTRACT hRMCONTRACT = new HRM_CONTRACT();
            if (!(Level == 0 || Level == 1 || Level == 2 || Level == 3 ? false : Level != 4))
            {
                this.gcList.DataSource = hRMCONTRACT.GetList(Level, Code);
            }
            else if (Level == 5)
            {
                this.gcList.DataSource = hRMCONTRACT.GetListByEmployee(Code);
            }
        }

        private void LoadOrganization()
        {
            this.xucListContractEmployee1.LoadData(1);
            this.xucListContractEmployee1.EmployeeSelected += new xucListContractEmployee.EmployeeSelectedHandler((object s, string e) =>
            {
                int num = 5;
                int num1 = num;
                this.m_Level = num;
                string str = e;
                string str1 = str;
                this.m_Code = str;
                this.LoadGrid(num1, str1);
            });
            this.xucListContractEmployee1.DepartmentSelected += new xucListContractEmployee.DepartmentSelectedHandler((object s, Organization o) =>
            {
                int num;
                string str;
                HRM_GROUP hRMGROUP = new HRM_GROUP();
                HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                if (o.Level == 0)
                {
                    int num1 = 0;
                    num = num1;
                    this.m_Level = num1;
                    string str1 = "";
                    str = str1;
                    this.m_Code = str1;
                    this.LoadGrid(num, str);
                }
                else if (o.Level == 1)
                {
                    int num2 = 1;
                    num = num2;
                    this.m_Level = num2;
                    string subsidiaryCode = o.SubsidiaryCode;
                    str = subsidiaryCode;
                    this.m_Code = subsidiaryCode;
                    this.LoadGrid(num, str);
                }
                else if (o.Level == 2)
                {
                    int num3 = 2;
                    num = num3;
                    this.m_Level = num3;
                    string branchCode = o.BranchCode;
                    str = branchCode;
                    this.m_Code = branchCode;
                    this.LoadGrid(num, str);
                }
                else if (o.Level == 3)
                {
                    int num4 = 3;
                    num = num4;
                    this.m_Level = num4;
                    string departmentCode = o.DepartmentCode;
                    str = departmentCode;
                    this.m_Code = departmentCode;
                    this.LoadGrid(num, str);
                }
                else if (o.Level == 4)
                {
                    int num5 = 4;
                    num = num5;
                    this.m_Level = num5;
                    string groupCode = o.GroupCode;
                    str = groupCode;
                    this.m_Code = groupCode;
                    this.LoadGrid(num, str);
                }
            });
        }

        private static int LoadStyle()
        {
            int num;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucContract.xml"));
                num = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
            }
            catch
            {
                num = 270;
            }
            return num;
        }

        private void RaiseClosedHander()
        {
            if (this.Closed != null)
            {
                this.Closed(this);
            }
        }

        private void repFilter_EditValueChanged(object sender, EventArgs e)
        {
            HRM_CONTRACT hRMCONTRACT;
            if (this.m_Filter == "0")
            {
                hRMCONTRACT = new HRM_CONTRACT();
                this.gcList.DataSource = hRMCONTRACT.GetList(this.m_Level, this.m_Code);
            }
            else if (this.m_Filter == "1")
            {
                hRMCONTRACT = new HRM_CONTRACT();
                this.gcList.DataSource = hRMCONTRACT.GetCurrentList(this.m_Level, this.m_Code);
            }
            else if (!(this.m_Filter == "2"))
            {
                hRMCONTRACT = new HRM_CONTRACT();
                this.gcList.DataSource = hRMCONTRACT.GetListExpiration(this.m_Level, this.m_Code);
            }
            else
            {
                hRMCONTRACT = new HRM_CONTRACT();
                this.gcList.DataSource = hRMCONTRACT.GetListJustExpiration(this.m_Level, this.m_Code);
            }
        }

        private void repFilter_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.m_Filter = e.NewValue.ToString();
        }

        private static void SaveStyle(int Position)
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable.Columns.Add("SplitterPosition", typeof(string));
                object[] str = new object[] { Position.ToString() };
                dataTable.Rows.Add(new object[0]);
                dataTable.Rows[0][0] = str[0];
                dataSet.Tables.Add(dataTable);
            }
            finally
            {
                if (dataTable != null)
                {
                    ((IDisposable)dataTable).Dispose();
                }
            }
            try
            {
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucContract.xml"));
            }
            catch
            {
            }
        }

        private void SetMenu(CHBK2014_N9.Common.Class. RowClickEventArgs e)
        {
            object rowCellValue = this.gbList.GetRowCellValue(this.gbList.FocusedRowHandle, "ContractCode");
            this.DisableMenu(false);
            if (rowCellValue == null)
            {
                this.DisableMenu(true);
            }
        }

        private void splitContainerControl1_SplitterPositionChanged(object sender, EventArgs e)
        {
            xucContract.SaveStyle(this.splitContainerControl1.SplitterPosition);
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
                this.Init();
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

        private void UpdateRow(HRM_CONTRACT item)
        {
            GridView gridView = this.gbList;
            int focusedRowHandle = this.gbList.FocusedRowHandle;
            gridView.SetRowCellValue(focusedRowHandle, "ContractCode", item.ContractCode);
            gridView.SetRowCellValue(focusedRowHandle, "ContractType", item.ContractType);
            if (item.ContractType != 1)
            {
                gridView.SetRowCellValue(focusedRowHandle, "ContractTime", item.ContractTime);
            }
            gridView.SetRowCellValue(focusedRowHandle, "SignDate", item.SignDate);
            gridView.SetRowCellValue(focusedRowHandle, "FromDate", item.FromDate);
            if (item.ContractType != 1)
            {
                gridView.SetRowCellValue(focusedRowHandle, "ToDate", item.ToDate);
            }
            gridView.SetRowCellValue(focusedRowHandle, "Signer", item.Signer);
            gridView.SetRowCellValue(focusedRowHandle, "SignerPosition", item.SignerPosition);
            gridView.SetRowCellValue(focusedRowHandle, "Subject", item.Subject);
            gridView.SetRowCellValue(focusedRowHandle, "Description", item.Description);
            gridView.UpdateCurrentRow();
        }

        public event xucContract.ClosedHander Closed;

        public delegate void ClosedHander(object sender);

        private void gbList_Click(object sender, EventArgs e)
        {

        }

        private void gbList_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }

        private void gcList_Click(object sender, EventArgs e)
        {

        }
    }
}
