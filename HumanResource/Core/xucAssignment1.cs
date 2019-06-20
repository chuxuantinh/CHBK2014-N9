using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers.Docking;
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
using CHBK2014_N9.Utils;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucAssignment1 : UserControl
    {

        private string m_EmployeeCode;

        private int m_Month;

        private int m_Year;
        public xucAssignment1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.gbList.DeleteSelectedRows();
        }

        public xucAssignment1(string EmployeeCode, int Month, int Year)
        {
            this.InitializeComponent();
           
            string employeeCode = EmployeeCode;
            string str = employeeCode;
            this.m_EmployeeCode = employeeCode;
            int month = Month;
            int num = month;
            this.m_Month = month;
            int num1 = num;
            int year = Year;
            num = year;
            this.m_Year = year;
            this.Init(str, num1, num);
        }


        public void ClearData()
        {
            this.gcList.DataSource = null;
        }

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.gbList.DeleteSelectedRows();
            }
            if (e.KeyCode == Keys.F5)
            {
                this.Init(this.m_EmployeeCode, this.m_Month, this.m_Year);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
        }


        public void Init(string EmployeeCode, int Month, int Year)
        {
            this.barManager1.SetPopupContextMenu(this.gcList, this.ppMenu);
            HRM_PROCESS_ASSIGNMENT hRMPROCESSASSIGNMENT = new HRM_PROCESS_ASSIGNMENT();
            string employeeCode = EmployeeCode;
            string str = employeeCode;
            this.m_EmployeeCode = employeeCode;
            int month = Month;
            int num = month;
            this.m_Month = month;
            int num1 = num;
            int year = Year;
            num = year;
            this.m_Year = year;
            this.gcList.DataSource = hRMPROCESSASSIGNMENT.GetListByMonth(str, num1, num);
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
            HRM_PROCESS_ASSIGNMENT hRMPROCESSASSIGNMENT = new HRM_PROCESS_ASSIGNMENT();
            hRMPROCESSASSIGNMENT.DeleteByMonth(this.m_EmployeeCode, this.m_Month, this.m_Year);
            try
            {
                foreach (DataRow row in (this.gcList.DataSource as DataTable).Rows)
                {
                    decimal num = new decimal(0);
                    decimal num1 = new decimal(0);
                    decimal num2 = new decimal(0);
                    try
                    {
                        num = decimal.Parse(row["Money"].ToString());
                    }
                    catch
                    {
                        num = new decimal(0);
                    }
                    try
                    {
                        num1 = decimal.Parse(row["PayMoney"].ToString());
                    }
                    catch
                    {
                        num1 = new decimal(0);
                    }
                    num2 = num - num1;
                    Guid guid = Guid.NewGuid();
                    hRMPROCESSASSIGNMENT.Insert(guid, this.m_EmployeeCode, row["AssignmentName"].ToString(), row["Reason"].ToString(), row["Where"].ToString(), DateTime.Parse(row["FromDate"].ToString()), DateTime.Parse(row["ToDate"].ToString()), num, num1, num2, DateTime.Parse(row["Date"].ToString()), "", "", "");
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
            hRMTIMEKEEPERTABLELIST.Get(this.m_Month, this.m_Year);
            hRMSALARYTABLELIST.Get(this.m_Month, this.m_Year);
            string str = hRMTIMEKEEPERTABLELIST.TimeKeeperTableListID.ToString();
            Guid salaryTableListID = hRMSALARYTABLELIST.SalaryTableListID;
            HRM_SALARY.EmployeeUpdate(str, salaryTableListID.ToString(), this.m_Month, this.m_Year, this.m_EmployeeCode);
        }

        public event xucAssignment1.SavedHandler Saved;

        public delegate void SavedHandler(object sender);
    }
}
