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
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using CHBK2014_N9.ERP;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucSalaryDebitByEmployee : UserControl
    {

        private Guid m_SalaryTableListID = Guid.Empty;

        private Guid m_SalaryPayID = Guid.Empty;

        private string m_SalaryRewardName = "";

        private decimal m_Money = new decimal(0);

        private string m_EmployeeCode = "";

        public xucSalaryDebitByEmployee()
        {
            InitializeComponent();
        }


        public xucSalaryDebitByEmployee(Guid SalaryTableListID, string EmployeeCode)
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

        public void ClearData()
        {
            this.gcList.DataSource = null;
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

        private void gbList_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            this.gbList.SetRowCellValue(e.RowHandle, this.colDate, DateTime.Now);
            this.gbList.SetRowCellValue(e.RowHandle, this.colMoney, 0);
        }

        private void gbList_KeyDown(object sender, KeyEventArgs e)
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
            this.m_Money = new decimal(0);
            this.barManager1.SetPopupContextMenu(this.gcList, this.ppMenu);
            this.repMoney.EditValueChanging += new ChangingEventHandler(this.repMoney_EditValueChanging);
            HRM_SALARY_DEBIT hRMSALARYDEBIT = new HRM_SALARY_DEBIT();
            Guid salaryTableListID = SalaryTableListID;
            Guid guid = salaryTableListID;
            this.m_SalaryTableListID = salaryTableListID;
            string employeeCode = EmployeeCode;
            string str = employeeCode;
            this.m_EmployeeCode = employeeCode;
            this.gcList.DataSource = hRMSALARYDEBIT.GetList(guid, str);
        }

        private void RaiseSavedHander()
        {
            if (this.Saved != null)
            {
                this.Saved(this);
            }
        }

        private void repMoney_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void repMoney_EditValueChanging(object sender, ChangingEventArgs e)
        {
            try
            {
                this.m_Money = decimal.Parse(e.NewValue.ToString());
            }
            catch
            {
            }
        }


        public void Save()
        {
            HRM_SALARY_DEBIT hRMSALARYDEBIT = new HRM_SALARY_DEBIT();
            hRMSALARYDEBIT.Delete(this.m_SalaryTableListID, this.m_EmployeeCode);
            try
            {
                foreach (DataRow row in (this.gcList.DataSource as DataTable).Rows)
                {
                    try
                    {
                        if (row != null)
                        {
                            hRMSALARYDEBIT.Insert(this.m_SalaryTableListID, this.m_EmployeeCode, Guid.NewGuid(), row["Reason"].ToString(), DateTime.Parse(row["Date"].ToString()), decimal.Parse(row["Money"].ToString()), row["Person"].ToString(), row["Description"].ToString());
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
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

        public event xucSalaryDebitByEmployee.SavedHandler Saved;

        public delegate void SavedHandler(object sender);
    }
}
