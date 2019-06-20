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
using Perfect.Utils;
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
    public partial class xucSalaryMinusByEmployee : UserControl
    {
        private Guid m_SalaryTableListID = Guid.Empty;

        private Guid m_SalaryMinusID = Guid.Empty;

        private string m_SalaryMinusName = "";

        private decimal m_Money = new decimal(0);

        private string m_EmployeeCode = "";
        public xucSalaryMinusByEmployee()
        {
            InitializeComponent();
        }

        public xucSalaryMinusByEmployee(Guid SalaryTableListID, string EmployeeCode)
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

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {
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
            this.barManager1.SetPopupContextMenu(this.gcList, this.ppMenu);
            this.m_SalaryTableListID = SalaryTableListID;
            this.m_EmployeeCode = EmployeeCode;
            this.InitData();
            this.repMoney.EditValueChanging += new ChangingEventHandler(this.repMoney_EditValueChanging);
            this.repMoney.EditValueChanged += new EventHandler(this.repMoney_EditValueChanged);
            HRM_SALARY_MINUS hRMSALARYMINU = new HRM_SALARY_MINUS();
            this.gcList.DataSource = hRMSALARYMINU.GetListByEmployee(this.m_SalaryTableListID, this.m_EmployeeCode);
        }

        private void InitData()
        {
            (new HRM_SALARY_DEDUCTION()).AddRepositoryGridLookupEdit(this.m_SalaryTableListID, this.repSalaryDeduction);
        }
        private void RaiseSavedHander()
        {
            if (this.Saved != null)
            {
                this.Saved(this);
            }
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

        private void repSalaryDeduction_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind == ButtonPredefines.Glyph)
            //{
            //    xfmSalaryDeduction _xfmSalaryDeduction = new xfmSalaryDeduction(this.m_SalaryTableListID);
            //    _xfmSalaryDeduction.Added += new xfmSalaryDeduction.AddedEventHander((object s, HRM_SALARY_DEDUCTION i) => (new HRM_SALARY_DEDUCTION()).AddRepositoryGridLookupEdit(this.m_SalaryTableListID, this.repSalaryDeduction));
            //    _xfmSalaryDeduction.Updated += new xfmSalaryDeduction.UpdatedEventHander((object s, HRM_SALARY_DEDUCTION i) => (new HRM_SALARY_DEDUCTION()).AddRepositoryGridLookupEdit(this.m_SalaryTableListID, this.repSalaryDeduction));
            //    _xfmSalaryDeduction.Deleted += new DeletedEventHander((object s, RowClickEventArgs i) => (new HRM_SALARY_DEDUCTION()).AddRepositoryGridLookupEdit(this.m_SalaryTableListID, this.repSalaryDeduction));
            //    _xfmSalaryDeduction.ShowDialog();
            //}
        }

        public void Save()
        {
            HRM_SALARY_MINUS hRMSALARYMINU = new HRM_SALARY_MINUS();
            hRMSALARYMINU.DeleteAll(this.m_SalaryTableListID, this.m_EmployeeCode);
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
                                str = (row["DeductionCode"] != null ? row["DeductionCode"].ToString() : "");
                            }
                            catch
                            {
                            }
                            hRMSALARYMINU.Insert(this.m_SalaryTableListID, this.m_EmployeeCode, Guid.NewGuid(), str, row["SalaryMinusName"].ToString(), decimal.Parse(row["Money"].ToString()), row["Description"].ToString());
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

        public event xucSalaryMinusByEmployee.SavedHandler Saved;

        public delegate void SavedHandler(object sender);

        private void repMoney_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
