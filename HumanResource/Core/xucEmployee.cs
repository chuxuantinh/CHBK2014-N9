using DevExpress.Data;
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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
//using CHBK2014_N9.Common.Report;
using CHBK2014_N9.Dictionnary;
using CHBK2014_N9.ERP;
//using CHBK2014_N9.HumanResource.Core.Process;
//using CHBK2014_N9.HumanResource.Report;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using CHBK2014_N9.Data.Helper;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucEmployee : xucBase
    {

        private GridViewColumnButtonMenu menu;

        private int m_IndexKey = 1;

        private int m_Level = MyLogin.Level;

        private string m_Code = MyLogin.Code;

        private string m_EmployeeCode = "";
      


        StyleFormatCondition styleFormatCondition = new StyleFormatCondition();
        StyleFormatCondition styleFormatCondition1 = new StyleFormatCondition();
        StyleFormatCondition red = new StyleFormatCondition();
        StyleFormatCondition styleFormatCondition2 = new StyleFormatCondition();
        StyleFormatCondition styleFormatCondition3 = new StyleFormatCondition();
        StyleFormatCondition green = new StyleFormatCondition();
        StyleFormatCondition styleFormatCondition4 = new StyleFormatCondition();
        StyleFormatCondition red1 = new StyleFormatCondition();
        StyleFormatCondition whiteSmoke = new StyleFormatCondition();




        //   private xucOrganization xucOrganization1;



        public xucEmployee()
        {
            this.InitializeComponent();
           this.InitMultiLanguages();
          base.RestoreLayout(this.gbList, this);
            this.barManager1.SetPopupContextMenu(this.gcList, this.popupMenu1);
            this.ReLoad();
            this.splitContainerControl1.SplitterPosition = xucEmployee.LoadStyle();
        }



      
        private void xucEmployee_Load(object sender, EventArgs e)
        {

            ReLoad();


        }


        private void Add()
        {
            if (MyRule.IsAdd("bbiEmployee"))
            {
                xfmEmployeeAdd _xfmEmployeeAdd = new xfmEmployeeAdd(Actions.Add);
                _xfmEmployeeAdd.Added += new xfmEmployeeAdd.AddedEventHander(this.frm_Added);
                _xfmEmployeeAdd.ShowDialog();
            }
        }

        private void AddRow(HRM_EMPLOYEE item)
        {
            GridView gridView = this.gbList;
           

            int focusedRowHandle = gridView.FocusedRowHandle;
            gridView.AddNewRow();
            focusedRowHandle = gridView.FocusedRowHandle;
            gridView.SetRowCellValue(focusedRowHandle, "SubsidiaryCode", item.SubsidiaryCode);
            gridView.SetRowCellValue(focusedRowHandle, "BranchCode", item.BranchCode);
            gridView.SetRowCellValue(focusedRowHandle, "DepartmentCode", item.DepartmentCode);
            gridView.SetRowCellValue(focusedRowHandle, "GroupCode", item.GroupCode);
            gridView.SetRowCellValue(focusedRowHandle, "EmployeeCode", item.EmployeeCode);
            gridView.SetRowCellValue(focusedRowHandle, "FirstName", item.FirstName);
            gridView.SetRowCellValue(focusedRowHandle, "LastName", item.LastName);
            gridView.SetRowCellValue(focusedRowHandle, "BirthdayDay", item.BirthdayDay);
            gridView.SetRowCellValue(focusedRowHandle, "BirthdayMonth", item.BirthdayMonth);
            gridView.SetRowCellValue(focusedRowHandle, "BirthdayYear", item.BirthdayYear);
            gridView.SetRowCellValue(focusedRowHandle, "BirthPlace", item.BirthPlace);
            gridView.SetRowCellValue(focusedRowHandle, "Sex", item.Sex);
            gridView.SetRowCellValue(focusedRowHandle, "CellPhone", item.CellPhone);
            gridView.SetRowCellValue(focusedRowHandle, "HomePhone", item.HomePhone);
            gridView.SetRowCellValue(focusedRowHandle, "MainAddress", item.MainAddress);
            gridView.SetRowCellValue(focusedRowHandle, "ContactAddress", item.ContactAddress);
            gridView.SetRowCellValue(focusedRowHandle, "Position", item.Position);
            gridView.SetRowCellValue(focusedRowHandle, "IDCard", item.IDCard);
            gridView.SetRowCellValue(focusedRowHandle, "IDCardPlace", item.IDCardPlace);
            gridView.SetRowCellValue(focusedRowHandle, "IDCardDate", item.IDCardDate);
            gridView.SetRowCellValue(focusedRowHandle, "Status", item.Status);
            gridView.SetRowCellValue(focusedRowHandle, "TestFromDate", item.TestFromDate);
            gridView.SetRowCellValue(focusedRowHandle, "TestToDate", item.TestToDate);
            gridView.SetRowCellValue(focusedRowHandle, "BeginDate", item.BeginDate);
            gridView.SetRowCellValue(focusedRowHandle, "EndDate", item.EndDate);
            gridView.SetRowCellValue(focusedRowHandle, "Photo", item.Photo);
            gridView.SetRowCellValue(focusedRowHandle, "Email", item.Email);
            gridView.SetRowCellValue(focusedRowHandle, "Nationality", item.Nationality);
            gridView.SetRowCellValue(focusedRowHandle, "Ethnic", item.Ethnic);
            gridView.SetRowCellValue(focusedRowHandle, "Religion", item.Religion);
            gridView.SetRowCellValue(focusedRowHandle, "Education", item.Education);
            gridView.SetRowCellValue(focusedRowHandle, "Language", item.Language);
            gridView.SetRowCellValue(focusedRowHandle, "Informatic", item.Informatic);
            gridView.SetRowCellValue(focusedRowHandle, "Professional", item.Professional);
            gridView.SetRowCellValue(focusedRowHandle, "Marriage", item.Marriage);
            gridView.SetRowCellValue(focusedRowHandle, "InsuranceCode", item.InsuranceCode);
            gridView.SetRowCellValue(focusedRowHandle, "InsuranceDate", item.InsuranceDate);
            gridView.SetRowCellValue(focusedRowHandle, "BasicSalary", item.BasicSalary);
            gridView.SetRowCellValue(focusedRowHandle, "InsuranceSalary", item.InsuranceSalary);
            gridView.SetRowCellValue(focusedRowHandle, "DateSalary", item.DateSalary);
            gridView.SetRowCellValue(focusedRowHandle, "Health", item.Health);
            gridView.SetRowCellValue(focusedRowHandle, "Weight", item.Weight);
            gridView.SetRowCellValue(focusedRowHandle, "Height", item.Height);
            gridView.SetRowCellValue(focusedRowHandle, "ContractCode", item.ContractCode);
            gridView.SetRowCellValue(focusedRowHandle, "ContractType", item.ContractType);
            gridView.SetRowCellValue(focusedRowHandle, "ContractSignDate", item.ContractSignDate);
            gridView.SetRowCellValue(focusedRowHandle, "ContractFromDate", item.ContractFromDate);
            gridView.SetRowCellValue(focusedRowHandle, "ContractToDate", item.ContractToDate);
            gridView.SetRowCellValue(focusedRowHandle, "EnrollNumber", item.EnrollNumber);
            gridView.SetRowCellValue(focusedRowHandle, "Description", item.Description);
            gridView.UpdateCurrentRow();
        }


        private DataTable DataTableSelectedRows()
        {
            int[] selectedRows = this.gbList.GetSelectedRows();
            DataTable dataTable = (new HRM_EMPLOYEE()).CreateNullDataTable();
            for (int i = (int)selectedRows.Length; i > 0; i--)
            {
                try
                {
                    string str = this.gbList.GetRowCellValue(selectedRows[i - 1], "EmployeeCode").ToString();
                    string str1 = this.gbList.GetRowCellValue(selectedRows[i - 1], "FirstName").ToString();
                    string str2 = this.gbList.GetRowCellValue(selectedRows[i - 1], "LastName").ToString();
                    bool flag = bool.Parse(this.gbList.GetRowCellValue(selectedRows[i - 1], "Sex").ToString());
                    int num = int.Parse(this.gbList.GetRowCellValue(selectedRows[i - 1], "Status").ToString());
                    DataRowCollection rows = dataTable.Rows;
                    object[] objArray = new object[] { str, str1, str2, flag, num };
                    rows.Add(objArray);
                }
                catch
                {
                }
            }
            return dataTable;
        }

        public void DisableMenu(bool disable)
        {
            this.bbiEdit.Enabled = !disable;
            this.bbiDelete.Enabled = !disable;
        }

        private void frm_Added(object sender, HRM_EMPLOYEE Item)
        {
            this.ReLoad();
        }

        private void frm_Updated(object sender, HRM_EMPLOYEE Item)
        {
            this.UpdateRow(Item);
        }

        private void UpdateRow(HRM_EMPLOYEE item)
        {
            BandedGridView bandedGridView = this.gbList;
            int focusedRowHandle = this.gbList.FocusedRowHandle;
            bandedGridView.SetRowCellValue(focusedRowHandle, "SubsidiaryCode", item.SubsidiaryCode);
            bandedGridView.SetRowCellValue(focusedRowHandle, "BranchCode", item.BranchCode);
            bandedGridView.SetRowCellValue(focusedRowHandle, "DepartmentCode", item.DepartmentCode);
            bandedGridView.SetRowCellValue(focusedRowHandle, "GroupCode", item.GroupCode);
            bandedGridView.SetRowCellValue(focusedRowHandle, "EmployeeCode", item.EmployeeCode);
            bandedGridView.SetRowCellValue(focusedRowHandle, "FirstName", item.FirstName);
            bandedGridView.SetRowCellValue(focusedRowHandle, "LastName", item.LastName);
            bandedGridView.SetRowCellValue(focusedRowHandle, "BirthdayDay", item.BirthdayDay);
            bandedGridView.SetRowCellValue(focusedRowHandle, "BirthdayMonth", item.BirthdayMonth);
            bandedGridView.SetRowCellValue(focusedRowHandle, "BirthdayYear", item.BirthdayYear);
            bandedGridView.SetRowCellValue(focusedRowHandle, "BirthPlace", item.BirthPlace);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Sex", item.Sex);
            bandedGridView.SetRowCellValue(focusedRowHandle, "CellPhone", item.CellPhone);
            bandedGridView.SetRowCellValue(focusedRowHandle, "HomePhone", item.HomePhone);
            bandedGridView.SetRowCellValue(focusedRowHandle, "MainAddress", item.MainAddress);
            bandedGridView.SetRowCellValue(focusedRowHandle, "ContactAddress", item.ContactAddress);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Position", item.Position);
            bandedGridView.SetRowCellValue(focusedRowHandle, "IDCard", item.IDCard);
            bandedGridView.SetRowCellValue(focusedRowHandle, "IDCardPlace", item.IDCardPlace);
            bandedGridView.SetRowCellValue(focusedRowHandle, "IDCardDate", item.IDCardDate);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Status", item.Status);
            bandedGridView.SetRowCellValue(focusedRowHandle, "TestFromDate", item.TestFromDate);
            bandedGridView.SetRowCellValue(focusedRowHandle, "TestToDate", item.TestToDate);
            bandedGridView.SetRowCellValue(focusedRowHandle, "BeginDate", item.BeginDate);
            bandedGridView.SetRowCellValue(focusedRowHandle, "EndDate", item.EndDate);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Photo", item.Photo);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Email", item.Email);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Nationality", item.Nationality);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Ethnic", item.Ethnic);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Religion", item.Religion);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Education", item.Education);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Language", item.Language);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Informatic", item.Informatic);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Professional", item.Professional);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Marriage", item.Marriage);
            bandedGridView.SetRowCellValue(focusedRowHandle, "InsuranceCode", item.InsuranceCode);
            bandedGridView.SetRowCellValue(focusedRowHandle, "InsuranceDate", item.InsuranceDate);
            bandedGridView.SetRowCellValue(focusedRowHandle, "BasicSalary", item.BasicSalary);
            bandedGridView.SetRowCellValue(focusedRowHandle, "InsuranceSalary", item.InsuranceSalary);
            bandedGridView.SetRowCellValue(focusedRowHandle, "DateSalary", item.DateSalary);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Health", item.Health);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Weight", item.Weight);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Height", item.Height);
            bandedGridView.SetRowCellValue(focusedRowHandle, "ContractCode", item.ContractCode);
            bandedGridView.SetRowCellValue(focusedRowHandle, "ContractType", item.ContractType);
            bandedGridView.SetRowCellValue(focusedRowHandle, "ContractSignDate", item.ContractSignDate);
            bandedGridView.SetRowCellValue(focusedRowHandle, "ContractFromDate", item.ContractFromDate);
            bandedGridView.SetRowCellValue(focusedRowHandle, "ContractToDate", item.ContractToDate);
            bandedGridView.SetRowCellValue(focusedRowHandle, "EnrollNumber", item.EnrollNumber);
            bandedGridView.SetRowCellValue(focusedRowHandle, "Description", item.Description);
            bandedGridView.UpdateCurrentRow();
        }

        private void LoadGrid(int Level, string Code, int Status)
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            this.gcList.DataSource = hRMEMPLOYEE.GetListCurrentNow(Level, Code, Status); // 3 da nghi viec
        }

        private static int LoadStyle()
        {
            int num;
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucEmployee.xml"));
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
        private void LoadTree()
        {
            splitContainerControl1.Panel1.Controls.Add(this.xucOrganization1);
            xucOrganization1 = new xucOrganization();
            this.xucOrganization1.LoadData();
            this.xucOrganization1.Selected += new xucOrganization.SelectedEventHander((object s, Organization o) =>
            {
                int num;
                string str;
                if (o.Level == 0)
                {
                    int num1 = 0;
                    num = num1;
                    this.m_Level = num1;
                    string str1 = "";
                    str = str1;
                    this.m_Code = str1;
                    this.LoadGrid(num, str, this.m_IndexKey);
                }
                else if (o.Level == 1)
                {
                    int num2 = 1;
                    num = num2;
                    this.m_Level = num2;
                    string subsidiaryCode = o.SubsidiaryCode;
                    str = subsidiaryCode;
                    this.m_Code = subsidiaryCode;
                    this.LoadGrid(num, str, this.m_IndexKey);
                }
                else if (o.Level == 2)
                {
                    int num3 = 2;
                    num = num3;
                    this.m_Level = num3;
                    string branchCode = o.BranchCode;
                    str = branchCode;
                    this.m_Code = branchCode;
                    this.LoadGrid(num, str, this.m_IndexKey);
                }
                else if (o.Level == 3)
                {
                    int num4 = 3;
                    num = num4;
                    this.m_Level = num4;
                    string departmentCode = o.DepartmentCode;
                    str = departmentCode;
                    this.m_Code = departmentCode;
                    this.LoadGrid(num, str, this.m_IndexKey);
                }
                else if (o.Level == 4)
                {
                    int num5 = 4;
                    num = num5;
                    this.m_Level = num5;
                    string groupCode = o.GroupCode;
                    str = groupCode;
                    this.m_Code = groupCode;
                    this.LoadGrid(num, str, this.m_IndexKey);
                }
            });
            this.xucOrganization1.Updated += new xucOrganization.UpdatedEventHander((object o) => this.xucOrganization1.LoadData());
        }

      


        private void ReLoad()
        {
            base.SetWaitDialogCaption("Đang nạp dữ liệu...");
            this.m_IndexKey = 1;
            this.bbiFilter.EditValue = 2;
            this.bbiFilter.EditValueChanged += new EventHandler(this.bbiFilter_EditValueChanged);
            this.LoadTree();
            this.LoadGrid(m_Level, m_Code ,m_IndexKey); // mindexxkeyaho
            this.DoHide();
        }

        public event xucEmployee.ClosedHander Closed;

        public delegate void ClosedHander(object sender);

        private void gcList_Click(object sender, EventArgs e)
        {

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
                dataSet.WriteXml(string.Concat(Application.StartupPath, "\\LayoutControl\\xucEmployee.xml"));
            }
            catch
            {
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


        private void SetMenu(CHBK2014_N9.Common.Class.RowClickEventArgs e)
        {
            object rowCellValue = this.gbList.GetRowCellValue(this.gbList.FocusedRowHandle, "EmployeeCode");
            this.DisableMenu(false);
            if (rowCellValue == null)
            {
                this.DisableMenu(true);
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

        private void gbList_DoubleClick(object sender, EventArgs e)
        {
            if (this.gbList.RowCount != 0)
            {
                this.Change();
            }
        }

        private void gbList_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
            }
            catch
            {
            }
        }

        private void bbiFilter_EditValueChanged(object sender, EventArgs e)
        {
            this.m_IndexKey = int.Parse(this.bbiFilter.EditValue.ToString()) - 1;
            if (this.m_IndexKey == 0)
            {
                this.gbList.Appearance.Row.ForeColor = Color.Green;
            }
            else if (this.m_IndexKey == 2)
            {
                this.gbList.Appearance.Row.ForeColor = Color.Blue;
            }
            else if (this.m_IndexKey != 3)
            {
                this.gbList.Appearance.Row.ForeColor = Color.Black;
            }
            else
            {
                this.gbList.Appearance.Row.ForeColor = Color.Red;
            }
            this.xucOrganization1.LoadData(this.m_IndexKey + 1);
        }


        private void InitMultiLanguages()
        {
           // this.bbiAddSubsidiary.Caption = MultiLanguages.GetString("tbl_Employee", "AddSubsidiary", this.bbiAddSubsidiary.Caption);
          //  this.bbiAddBranch.Caption = MultiLanguages.GetString("tbl_Employee", "AddBranch", this.bbiAddBranch.Caption);
          //  this.bbiAddDepartment.Caption = MultiLanguages.GetString("tbl_Employee", "AddDepartment", this.bbiAddDepartment.Caption);
            this.bbiAddGroup.Caption =  this.bbiAddGroup.Caption;
            this.bbiAddEmployee.Caption = this.bbiAddEmployee.Caption;
            this.bbiEdit.Caption = this.bbiEdit.Caption;
            this.bbiDelete.Caption =  this.bbiDelete.Caption;
            //this.bbiPrint.Caption = MultiLanguages.GetString("tbl_Employee", "Print", this.bbiPrint.Caption);
            //this.bbiRefresh.Caption = MultiLanguages.GetString("tbl_Employee", "Refresh", this.bbiRefresh.Caption);
            //this.bbiImport.Caption = MultiLanguages.GetString("tbl_Employee", "Import", this.bbiImport.Caption);
            //this.bbiExport.Caption = MultiLanguages.GetString("tbl_Employee", "Export", this.bbiExport.Caption);
            //this.bbiClose.Caption = MultiLanguages.GetString("tbl_Employee", "Close", this.bbiClose.Caption);
            //this.colSubsidiaryName.Caption = MultiLanguages.GetString("tbl_Employee", "SubsidiaryName", this.colSubsidiaryName.Caption);
            //this.colBranchName.Caption = MultiLanguages.GetString("tbl_Employee", "BranchName", this.colBranchName.Caption);
            this.colDepartmentName.Caption =  this.colDepartmentName.Caption;
            this.colGroupName.Caption = this.colGroupName.Caption;
            this.colImage.Caption =  this.colImage.Caption;
            this.colEmployeeCode.Caption =  this.colEmployeeCode.Caption;
            this.colFirstName.Caption = this.colFirstName.Caption;
            this.colLastName.Caption = this.colLastName.Caption;
            this.colSex.Caption =  this.colSex.Caption;
            this.colBirthday.Caption = this.colBirthday.Caption;
            this.colBirthPlace.Caption =this.colBirthPlace.Caption;
            this.colCellPhone.Caption = this.colCellPhone.Caption;
            this.colMainAddress.Caption = this.colMainAddress.Caption;
            this.colPosition.Caption =  this.colPosition.Caption;
            this.colIDCard.Caption = this.colIDCard.Caption;
            this.colIDCardDate.Caption =  this.colIDCardDate.Caption;
            this.colIDCardPlace.Caption = this.colIDCardPlace.Caption;
            this.colStatus.Caption = this.colStatus.Caption;
            this.colTestFromDate.Caption =this.colTestFromDate.Caption;
            this.colTestToDate.Caption = this.colTestToDate.Caption;
            this.colEndDate.Caption =  this.colEndDate.Caption;
            this.colNationality.Caption = this.colNationality.Caption;
            this.colProfessional.Caption =this.colProfessional.Caption;
            this.colReligion.Caption =  this.colReligion.Caption;
            this.colMarriage.Caption =  this.colMarriage.Caption;
            this.colLanguage.Caption =  this.colLanguage.Caption;
            this.colInformatic.Caption = this.colInformatic.Caption;
            this.colEthnic.Caption =  this.colEthnic.Caption;
            this.colEducation.Caption = this.colEducation.Caption;
        }


        private void xfmBranchAdd_Added(object sender, HRM_BRANCH Item)
        {
            this.ReLoad();
        }

        private void xfmDepartmentAdd_Added(object sender, HRM_DEPARTMENT Item)
        {
            this.ReLoad();
        }

        private void xfmGroupAdd_Added(object sender, HRM_GROUP Item)
        {
            this.ReLoad();
        }

        private void Change()
        {
            if (MyRule.IsAccess("bbiEmployee"))
            {
                HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
                object focusedRowCellValue = this.gbList.GetFocusedRowCellValue("EmployeeCode");
                if (focusedRowCellValue != null)
                {
                    base.SetWaitDialogCaption("Đang kiểm tra dữ liệu....");
                    if (!(hRMEMPLOYEE.Get(focusedRowCellValue.ToString()) != "OK"))
                    {
                        this.DoHide();
                        xfmEmployeeAdd _xfmEmployeeAdd = new xfmEmployeeAdd(Actions.Update, hRMEMPLOYEE);
                        _xfmEmployeeAdd.Updated += new xfmEmployeeAdd.UpdatedEventHander(this.frm_Updated);
                        _xfmEmployeeAdd.Added += new xfmEmployeeAdd.AddedEventHander(this.frm_Added);
                        _xfmEmployeeAdd.ShowDialog();
                    }
                    else
                    {
                        this.DoHide();
                        XtraMessageBox.Show("Dữ liệu không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void splitContainerControl1_SplitterPositionChanged(object sender, EventArgs e)
        {
            xucEmployee.SaveStyle(this.splitContainerControl1.SplitterPosition);
        }

        private void gbList_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            DateTime dateTime;
          CHBK2014_N9.Common.Class.RowClickEventArgs rowClickEventArg = new CHBK2014_N9.Common.Class.RowClickEventArgs(e.RowHandle, e.Column.ColumnHandle);
            this.SetMenu(rowClickEventArg);
            try
            {
                this.toolTip1.HideHint();
                int num = Convert.ToInt32(this.gbList.GetFocusedRowCellValue(this.colStatus).ToString());
                if (num == 0)
                {
                    ToolTipController toolTipController = this.toolTip1;
                    string[] newLine = new string[] { "Đang thử việc!", Environment.NewLine, "Từ ngày: ", null, null, null, null };
                    dateTime = Convert.ToDateTime(this.gbList.GetFocusedRowCellValue(this.colTestFromDate).ToString());
                    newLine[3] = dateTime.ToShortDateString();
                    newLine[4] = Environment.NewLine;
                    newLine[5] = "Đến ngày: ";
                    dateTime = Convert.ToDateTime(this.gbList.GetFocusedRowCellValue(this.colTestToDate).ToString());
                    newLine[6] = dateTime.ToShortDateString();
                    toolTipController.ShowHint(string.Concat(newLine));
                }
                if (num == 3)
                {
                    ToolTipController toolTipController1 = this.toolTip1;
                    string str = Environment.NewLine;
                    dateTime = Convert.ToDateTime(this.gbList.GetFocusedRowCellValue(this.colEndDate).ToString());
                    toolTipController1.ShowHint(string.Concat("Đã nghỉ việc!", str, "Từ ngày: ", dateTime.ToShortDateString()));
                }
            }
            catch
            {
            }
        }

        private void gbList_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                base.DoShowMenu(this.gbList.CalcHitInfo(new Point(e.X, e.Y)), this.gbList, this);
            }
            this.SetMenu(null);
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

        private void gbList_FocusedRowChanged_1(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.m_EmployeeCode = this.gbList.GetFocusedRowCellValue(this.colEmployeeCode).ToString();
            }
            catch
            {
            }
        }

        
        private void gbList_CustomDrawRowIndicator_1(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void bbiAddEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Add();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Change();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            string str;
            object rowCellValue;
            if (MyRule.IsDelete("bbiEmployee"))
            {
                bool flag = false;
                int[] selectedRows = this.gbList.GetSelectedRows();
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    base.CreateWaitDialog();
                    HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
                    for (int i = (int)selectedRows.Length; i > 0; i--)
                    {
                        flag = true;
                        rowCellValue = this.gbList.GetRowCellValue(selectedRows[i - 1], "EmployeeCode");
                        if (rowCellValue != null)
                        {
                          //  SYS_LOG.Insert("Danh Sách Nhân Viên", "Xoá", rowCellValue.ToString());
                            base.SetWaitDialogCaption(string.Concat("Đang xóa...", rowCellValue.ToString()));
                            str = hRMEMPLOYEE.Delete(rowCellValue.ToString());
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
                        if (hRMEMPLOYEE.GetListCurrentNow(this.m_Level, this.m_Code, -1).Rows.Count != 0)
                        {
                            rowCellValue = this.gbList.GetFocusedRowCellValue("EmployeeCode");
                            if (rowCellValue != null)
                            {
                               // SYS_LOG.Insert("Danh Sách Nhân Viên", "Xoá", rowCellValue.ToString());
                                base.SetWaitDialogCaption("Đang xóa...");
                                str = hRMEMPLOYEE.Delete(rowCellValue.ToString());
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
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.RaiseClosedHander();
        }

        private void gbList_KeyDown_1(object sender, KeyEventArgs e)
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




      
    }
}
