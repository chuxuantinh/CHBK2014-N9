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
using CHBK2014_N9.Dictionnary;
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
    public partial class xucSalaryAllowanceByEmployee : UserControl
    {

        private Guid m_SalaryTableListID = Guid.Empty;

        private string m_AllowanceCode = "";

        private decimal m_Money = new decimal(0);

        private double m_IncomeTaxValue = 0;

        private string m_EmployeeCode = "";

        public xucSalaryAllowanceByEmployee(Guid SalaryTableListID, string EmployeeCode)
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

        public xucSalaryAllowanceByEmployee()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.gbList.DeleteSelectedRows();
        }


        private void cbo_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                xfmAllowanceAdd _xfmAllowanceAdd = new xfmAllowanceAdd(Actions.Add);
                _xfmAllowanceAdd.Added += new xfmAllowanceAdd.AddedEventHander(this.xfmAllowance_Added);
                _xfmAllowanceAdd.ShowDialog();
            }
        }

        public void ClearData()
        {
            this.gcList.DataSource = null;
        }

        private void CreateRowData()
        {
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            dICALLOWANCE.Get(this.m_AllowanceCode);
            this.gbList.SetFocusedRowCellValue(this.colEmployeeCode, this.m_EmployeeCode);
            this.gbList.SetFocusedRowCellValue(this.colAllowanceCode, dICALLOWANCE.AllowanceCode);
            this.gbList.SetFocusedRowCellValue(this.colAllowanceName, dICALLOWANCE.AllowanceCode);
            this.gbList.SetFocusedRowCellValue(this.colMoney, dICALLOWANCE.MaximumMoney);
            this.gbList.SetFocusedRowCellValue(this.colIncomeTaxValue, dICALLOWANCE.IncomeTaxValue);
        }


       // bool flag3;

        private bool Exist(DataTable l_eAllowance, string AllowanceCode)
        {
            bool flag = false;
            foreach (DataRow row in l_eAllowance.Rows)
            {
                try
                {
                    if (AllowanceCode == row["AllowanceCode"].ToString())
                    {
                        flag = true;
                    }
                }
                catch
                {
                    flag = false;
                    continue;
                }
            }
             // int num = 0;
           //   flag = (bool) num;
            return flag;


            //bool flag1 = false;
            //IEnumerator ienumerator = l_eAllowance.Rows.GetEnumerator();
            //try
            //{

            //    while (flag3)
            //    {
            //        DataRow dataRow = (DataRow)ienumerator.Current;
            //        try
            //        {
            //            flag3 = AllowanceCode != dataRow["AllowanceCode"].ToString();
            //            if (!flag3)
            //                flag1 = true;
            //        }
            //        catch
            //        {
            //            flag1 = false;
            //           //goto label_0;
            //        }
            //        flag3 = ienumerator.MoveNext();
            //    }
            //}
            //finally
            //{
            //    IDisposable idisposable = ienumerator as IDisposable;
            //    flag3 = idisposable == null;
            //    if (!flag3)
            //        idisposable.Dispose();
            //}
            //flag1 = false;
            //return flag1;
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

        private void gbList_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (!this.Exist(this.gcList.DataSource as DataTable, this.m_AllowanceCode))
            {
                this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
            else
            {
                e.ErrorText = "Trùng phụ cấp - Nhấn ESC để phục hồi trạng thái bình thường!";
                e.Valid = false;
            }
        }


        public void Init(Guid SalaryTableListID, string EmployeeCode)
        {
            this.barManager1.SetPopupContextMenu(this.gcList, this.ppMenu);
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            dICALLOWANCE.AddRepositoryGridLookupEdit(this.repAllowanceCode);
            dICALLOWANCE.AddRepositoryGridLookupEdit1(this.repAllowanceName);
            this.repAllowanceCode.EditValueChanged += new EventHandler(this.repAllowanceCode_EditValueChanged);
            this.repAllowanceCode.EditValueChanging += new ChangingEventHandler(this.repAllowanceCode_EditValueChanging);
            this.repAllowanceName.EditValueChanged += new EventHandler(this.repAllowanceName_EditValueChanged);
            this.repAllowanceName.EditValueChanging += new ChangingEventHandler(this.repAllowanceName_EditValueChanging);
            this.repMoney.EditValueChanging += new ChangingEventHandler(this.repMoney_EditValueChanging);
            this.repMoney.EditValueChanged += new EventHandler(this.repMoney_EditValueChanged);
            HRM_SALARY_ALLOWANCE hRMSALARYALLOWANCE = new HRM_SALARY_ALLOWANCE();
            Guid salaryTableListID = SalaryTableListID;
            Guid guid = salaryTableListID;
            this.m_SalaryTableListID = salaryTableListID;
            string employeeCode = EmployeeCode;
            string str = employeeCode;
            this.m_EmployeeCode = employeeCode;
            this.gcList.DataSource = hRMSALARYALLOWANCE.GetListByEmployee(guid, str);
        }


        private void RaiseSavedHander()
        {
            if (this.Saved != null)
            {
                this.Saved(this);
            }
        }

        private void repAllowanceCode_EditValueChanged(object sender, EventArgs e)
        {
            if (!this.Exist(this.gcList.DataSource as DataTable, this.m_AllowanceCode))
            {
                this.CreateRowData();
                this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
            else
            {
                this.gbList.SetColumnError(this.colAllowanceCode, "Error");
                this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        private void repAllowanceCode_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.m_AllowanceCode = e.NewValue.ToString();
        }

        private void repAllowanceName_EditValueChanged(object sender, EventArgs e)
        {
            if (!this.Exist(this.gcList.DataSource as DataTable, this.m_AllowanceCode))
            {
                this.CreateRowData();
                this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
            else
            {
                this.gbList.SetColumnError(this.colAllowanceName, "Error");
                this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
        }

        private void repAllowanceName_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.m_AllowanceCode = e.NewValue.ToString();
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
            HRM_SALARY_ALLOWANCE hRMSALARYALLOWANCE = new HRM_SALARY_ALLOWANCE();
            hRMSALARYALLOWANCE.DeleteAll(this.m_SalaryTableListID, this.m_EmployeeCode);
            try
            {
                if ((this.gcList.DataSource as DataTable).Rows.Count > 0)
                {
                    foreach (DataRow row in (this.gcList.DataSource as DataTable).Rows)
                    {
                        try
                        {
                            if (row != null)
                            {
                                hRMSALARYALLOWANCE.Insert(this.m_SalaryTableListID, this.m_EmployeeCode, row["AllowanceCode"].ToString(), decimal.Parse(row["Money"].ToString()), double.Parse(row["IncomeTaxValue"].ToString()));
                            }
                        }
                        catch
                        {
                            continue;
                        }
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

        private void xfmAllowance_Added(object sender, DIC_ALLOWANCE Item)
        {
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            dICALLOWANCE.AddRepositoryGridLookupEdit(this.repAllowanceCode);
            dICALLOWANCE.AddRepositoryGridLookupEdit1(this.repAllowanceName);
        }

        public event xucSalaryAllowanceByEmployee.SavedHandler Saved;

        public delegate void SavedHandler(object sender);

        private void repAllowanceName_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

        }
    }
}
