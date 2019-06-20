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
using CHBK2014_N9.Common;
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
using System.Windows.Forms;


namespace CHBK2014_N9.HumanResource.Core
{
    public partial class xucAllowance : xucBase
    {

        private string m_AllowanceCode = "";

        private decimal m_Money = new decimal(0);

        private bool m_IsByWorkDay = false;

        private string m_EmployeeCode = "";

        private DataTable m_DataTableEmployee;
        public xucAllowance()
        {
            InitializeComponent();
        }


        public xucAllowance(string EmployeeCode)
        {
            this.InitializeComponent();
         
            this.m_EmployeeCode = EmployeeCode;
        }

        public xucAllowance(DataTable DataTableEmployee)
        {
            this.InitializeComponent();
            this.m_DataTableEmployee = DataTableEmployee;
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.gbList.DeleteSelectedRows();
        }

        public void bbiExport()
        {
            this._exportView = this.gbList;
            SYS_LOG.Insert("Danh Sách Phụ Cấp", "Xuất");
            base.Export();
        }

        private void cbo_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Glyph)
            {
                //xfmAllowanceAdd _xfmAllowanceAdd = new xfmAllowanceAdd(Actions.Add);
                //_xfmAllowanceAdd.Added += new xfmAllowanceAdd.AddedEventHander(this.xfmAllowance_Added);
              //  _xfmAllowanceAdd.ShowDialog();
            }
        }

        private void CreateRowData()
        {
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            dICALLOWANCE.Get(this.m_AllowanceCode);
            this.gbList.SetFocusedRowCellValue(this.colEmployeeCode, this.m_EmployeeCode);
            this.gbList.SetFocusedRowCellValue(this.colAllowanceCode, dICALLOWANCE.AllowanceCode);
            this.gbList.SetFocusedRowCellValue(this.colAllowanceName, dICALLOWANCE.AllowanceCode);
            this.gbList.SetFocusedRowCellValue(this.colMoney, dICALLOWANCE.MaximumMoney);
            this.gbList.SetFocusedRowCellValue(this.colIsByWorkDay, dICALLOWANCE.IsByWorkDay);
            this.gbList.SetFocusedRowCellValue(this.colIncomeTaxValue, dICALLOWANCE.IncomeTaxValue);
        }

      
        //private bool Exist(DataTable l_eAllowance, string AllowanceCode)
        //{
        //    bool flag = false;
        //    foreach (DataRow row in l_eAllowance.Rows)
        //    {
        //        try
        //        {
        //            if (AllowanceCode == row["AllowanceCode"].ToString())
        //            {
        //                flag = true;
        //            }
        //        }
        //        catch
        //        {
        //            flag = false;
        //            continue;
        //        }
        //    }
        //    int num = 0;
        //    //flag = num;
        //    //return (bool)num;
        //}

        private void gbList_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            this.gbList.SetRowCellValue(e.RowHandle, this.colIsByWorkDay, false);
            this.gbList.SetRowCellValue(e.RowHandle, this.colIncomeTaxValue, 0);
        }

        private void gbList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.gbList.DeleteSelectedRows();
            }
            if (e.KeyCode == Keys.F5)
            {
                this.Init();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }
        }

        private void gbList_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        //private void gbList_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        //{
        //    if (!this.Exist(this.gcList.DataSource as DataTable, this.m_AllowanceCode))
        //    {
        //        this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        //    }
        //    else
        //    {
        //        e.ErrorText = "Trùng phụ cấp - Nhấn ESC để phục hồi trạng thái bình thường!";
        //        e.Valid = false;
        //    }
        //}

        public void Init()
        {
            this.barManager1.SetPopupContextMenu(this.gcList, this.ppMenu);
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            //dICALLOWANCE.AddRepositoryGridLookupEdit(this.repAllowanceCode);
            //dICALLOWANCE.AddRepositoryGridLookupEdit1(this.repAllowanceName);
            //this.repAllowanceCode.EditValueChanged += new EventHandler(this.repAllowanceCode_EditValueChanged);
            //this.repAllowanceCode.EditValueChanging += new ChangingEventHandler(this.repAllowanceCode_EditValueChanging);
            //this.repAllowanceName.EditValueChanged += new EventHandler(this.repAllowanceName_EditValueChanged);
            //this.repAllowanceName.EditValueChanging += new ChangingEventHandler(this.repAllowanceName_EditValueChanging);
            //this.repMoney.EditValueChanging += new ChangingEventHandler(this.repMoney_EditValueChanging);
            //this.repMoney.EditValueChanged += new EventHandler(this.repMoney_EditValueChanged);
            //HRM_EMPLOYEE_ALLOWANCE hRMEMPLOYEEALLOWANCE = new HRM_EMPLOYEE_ALLOWANCE();
            //this.gcList.DataSource = hRMEMPLOYEEALLOWANCE.GetList(this.m_EmployeeCode);
        }



        //private void repAllowanceCode_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (!this.Exist(this.gcList.DataSource as DataTable, this.m_AllowanceCode))
        //    {
        //        this.CreateRowData();
        //        this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        //    }
        //    else
        //    {
        //        this.gbList.SetColumnError(this.colAllowanceCode, "Error");
        //        this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
        //    }
        //}

        private void repAllowanceCode_EditValueChanging(object sender, ChangingEventArgs e)
        {
            this.m_AllowanceCode = e.NewValue.ToString();
        }

        //private void repAllowanceName_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (!this.Exist(this.gcList.DataSource as DataTable, this.m_AllowanceCode))
        //    {
        //        this.CreateRowData();
        //        this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        //    }
        //    else
        //    {
        //        this.gbList.SetColumnError(this.colAllowanceName, "Error");
        //        this.gbList.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
        //    }
        //}

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
            if (this.m_DataTableEmployee != null)
            {
                foreach (DataRow row in this.m_DataTableEmployee.Rows)
                {
                    string[] str = new string[] { "Đang cập nhật...", row["FirstName"].ToString(), " ", row["LastName"].ToString(), " (", row["EmployeeCode"].ToString(), ")" };
                    Options.SetWaitDialogCaption(string.Concat(str));
                    this.Save(row["Employeecode"].ToString());
                }
                Options.HideDialog();
            }
            else
            {
                this.Save(this.m_EmployeeCode);
            }
        }

        public void Save(string EmployeeCode)
        {
            HRM_EMPLOYEE_ALLOWANCE hRMEMPLOYEEALLOWANCE = new HRM_EMPLOYEE_ALLOWANCE();
            hRMEMPLOYEEALLOWANCE.Delete(EmployeeCode);
            foreach (DataRow row in (this.gcList.DataSource as DataTable).Rows)
            {
                try
                {
                    hRMEMPLOYEEALLOWANCE.Insert(EmployeeCode, row["AllowanceCode"].ToString(), decimal.Parse(row["Money"].ToString()), bool.Parse(row["IsByWorkDay"].ToString()), double.Parse(row["IncomeTaxValue"].ToString()));
                }
                catch
                {
                    continue;
                }
            }
        }

        private void xfmAllowance_Added(object sender, DIC_ALLOWANCE Item)
        {
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            //dICALLOWANCE.AddRepositoryGridLookupEdit(this.repAllowanceCode);
            //dICALLOWANCE.AddRepositoryGridLookupEdit1(this.repAllowanceName);
        }

    }
}
