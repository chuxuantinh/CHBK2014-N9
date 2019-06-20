using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucSalaryPlusByEmployee : UserControl
    {

        private Guid m_SalaryTableListID = Guid.Empty;

        private Guid m_SalaryPlusID = Guid.Empty;

        private string m_SalaryPlusName = "";

        private decimal m_Money = new decimal(0);

        private decimal m_PayMoney = new decimal(0);

        private decimal m_DebtMoney = new decimal(0);

        private string m_EmployeeCode = "";

        public xucSalaryPlusByEmployee()
        {
            InitializeComponent();
        }


        public xucSalaryPlusByEmployee(Guid SalaryTableListID, string EmployeeCode)
        {
            this.InitializeComponent();
            
            Guid salaryTableListID = SalaryTableListID;
            Guid guid = salaryTableListID;
            this.m_SalaryTableListID = salaryTableListID;
            string employeeCode = EmployeeCode;
            string str = employeeCode;
            this.m_EmployeeCode = employeeCode;
            this.Init(guid, str);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.gbList.DeleteSelectedRows();
        }



        public void ClearData()
        {
            this.gcList.DataSource = null;
        }

        private void gbList_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {

            if (e.Column != this.colDebtMoney)
            {
                if (e.Column == this.colMoney)
                {
                    this.m_Money = decimal.Parse(e.Value.ToString());
                    try
                    {
                        this.m_PayMoney = decimal.Parse(this.gbList.GetFocusedRowCellValue(this.colPayMoney).ToString());
                    }
                    catch
                    {
                        this.m_PayMoney = new decimal(0);
                    }
                }
                else if (e.Column == this.colPayMoney)
                {
                    this.m_PayMoney = decimal.Parse(e.Value.ToString());
                    try
                    {
                        this.m_Money = decimal.Parse(this.gbList.GetFocusedRowCellValue(this.colMoney).ToString());
                    }
                    catch
                    {
                        this.m_Money = new decimal(0);
                    }
                }
                if (!(this.m_Money >= this.m_PayMoney))
                {
                    this.gbList.SetFocusedRowCellValue(this.colPayMoney, 0);
                    this.gbList.SetFocusedRowCellValue(this.colDebtMoney, this.m_Money);
                }
                else
                {
                    this.gbList.SetFocusedRowCellValue(this.colDebtMoney, this.m_Money - this.m_PayMoney);
                }
                if (e.Column == this.colIncomeCode)
                {
                    HRM_SALARY_INCOME hRMSALARYINCOME = new HRM_SALARY_INCOME();
                }
            }
        }

        private void gbList_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {

        }

        private void gbList_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            this.gbList.SetRowCellValue(e.RowHandle, this.colMoney, 0);
            this.gbList.SetRowCellValue(e.RowHandle, this.colPayMoney, 0);
            this.gbList.SetRowCellValue(e.RowHandle, this.colDebtMoney, 0);
            this.gbList.SetRowCellValue(e.RowHandle, this.colDate, DateTime.Now);
        }

        private void gcList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.gbList.DeleteSelectedRows();
            }
            if (e.KeyCode == Keys.F5)
            {
                this.Init(this.m_SalaryTableListID, this.m_EmployeeCode);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
        }

        public void Init(Guid SalaryTableListID, string EmployeeCode)
        {
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.InitData();
            this.barManager1.SetPopupContextMenu(this.gcList, this.ppMenu);
            this.repMoney.EditValueChanging += new ChangingEventHandler(this.repMoney_EditValueChanging);
            this.repMoney.EditValueChanged += new EventHandler(this.repMoney_EditValueChanged);
            HRM_SALARY_PLUS hRMSALARYPLU = new HRM_SALARY_PLUS();
            this.gcList.DataSource = hRMSALARYPLU.GetListByEmployeeByType(this.m_SalaryTableListID, this.m_EmployeeCode, 0);
        }

        private void InitData()
        {
            (new HRM_SALARY_INCOME()).AddRepositoryGridLookupEdit(this.m_SalaryTableListID, this.repSalaryIncome);
        }



        private void RaiseSavedHander()
        {
            if (this.Saved != null)
            {
                this.Saved(this);
            }
        }


        public void Save()
        {
            HRM_SALARY_PLUS hRMSALARYPLU = new HRM_SALARY_PLUS();
            hRMSALARYPLU.DeleteAll(this.m_SalaryTableListID, this.m_EmployeeCode);
            try
            {
                foreach (DataRow row in (this.gcList.DataSource as DataTable).Rows)
                {
                    try
                    {
                        if (row != null)
                        {
                            string str = "";
                            try
                            {
                                str = (row["IncomeCode"] != null ? row["IncomeCode"].ToString() : "");
                            }
                            catch
                            {
                            }
                            hRMSALARYPLU.Insert(this.m_SalaryTableListID, this.m_EmployeeCode, Guid.NewGuid(), str, row["SalaryPlusName"].ToString(), 0, (row["Money"] == null ? new decimal(0) : decimal.Parse(row["Money"].ToString())), (row["PayMoney"] == null ? new decimal(0) : decimal.Parse(row["PayMoney"].ToString())), (row["DebtMoney"] == null ? new decimal(0) : decimal.Parse(row["DebtMoney"].ToString())), new decimal(0), (row["Date"] == null ? DateTime.Now : DateTime.Parse(row["Date"].ToString())), row["Description"].ToString());
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
                this.UpdateEmployeeSalary();
                this.RaiseSavedHander();
            }
            catch
            {
            }
        }

        private void UpdateEmployeeSalary()
        {
            HRM_TIMEKEEPER_TABLELIST hRMTIMEKEEPERTABLELIST = new HRM_TIMEKEEPER_TABLELIST();
            HRM_SALARY_TABLELIST hRMSALARYTABLELIST = new HRM_SALARY_TABLELIST();
            hRMSALARYTABLELIST.GetByID(this.m_SalaryTableListID);
            hRMTIMEKEEPERTABLELIST.Get(hRMSALARYTABLELIST.Month, hRMSALARYTABLELIST.Year);
            Guid timeKeeperTableListID = hRMTIMEKEEPERTABLELIST.TimeKeeperTableListID;
            HRM_SALARY.EmployeeUpdate(timeKeeperTableListID.ToString(), this.m_SalaryTableListID.ToString(), hRMSALARYTABLELIST.Month, hRMSALARYTABLELIST.Year, this.m_EmployeeCode);
        }

        public event xucSalaryPlusByEmployee.SavedHandler Saved;

        public delegate void SavedHandler(object sender);

        private void repSalaryIncome_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                //xfmSalaryIncome _xfmSalaryIncome = new xfmSalaryIncome(this.m_SalaryTableListID);
                //_xfmSalaryIncome.Added += new xfmSalaryIncome.AddedEventHander((object s, HRM_SALARY_INCOME i) => (new HRM_SALARY_INCOME()).AddRepositoryGridLookupEdit(this.m_SalaryTableListID, this.repSalaryIncome));
                //_xfmSalaryIncome.Updated += new xfmSalaryIncome.UpdatedEventHander((object s, HRM_SALARY_INCOME i) => (new HRM_SALARY_INCOME()).AddRepositoryGridLookupEdit(this.m_SalaryTableListID, this.repSalaryIncome));
                //_xfmSalaryIncome.Deleted += new DeletedEventHander((object s, RowClickEventArgs i) => (new HRM_SALARY_INCOME()).AddRepositoryGridLookupEdit(this.m_SalaryTableListID, this.repSalaryIncome));
                //_xfmSalaryIncome.ShowDialog();
            }
        }

        private void repMoney_EditValueChanging(object sender, ChangingEventArgs e)
        {

        }

        private void repMoney_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
