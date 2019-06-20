using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using CHBK2014_N9.Common;
using CHBK2014_N9.Common.Class;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


namespace CHBK2014_N9.Dictionnary
{
    public partial class xucAllowanceAdd : xucBaseAdd
    {
        public xucAllowanceAdd()
        {
            InitializeComponent();
        }

      
        protected override void Add()
        {
            base.Add();
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
            this.txtID.Text = dICALLOWANCE.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtDescription.Text = "";
        }


        private void RaiseSuccessEventHander(DIC_ALLOWANCE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(DIC_ALLOWANCE item)
        {
            this.txtID.Text = item.AllowanceCode;
           // SYS_LOG.Insert("Danh Mục Phụ Cấp", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.AllowanceName;
            this.calMaximumSalary.EditValue = item.MaximumMoney;
            this.cheIsByWorkDay.Checked = item.IsByWorkDay;
            this.calIncomeTaxValue.EditValue = item.IncomeTaxValue;
            this.cheIsShowInSalaryTableList.Checked = item.IsShowInSalaryTableList;
            this.txtDescription.Text = item.Description;
        }

     
      

        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE()
            {
                AllowanceCode = this.txtID.Text
            };
            string str = dICALLOWANCE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(dICALLOWANCE);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiAllowance") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowAdd)
            {
               // SYS_LOG.Insert("Danh Mục Phụ Cấp", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE(this.txtID.Text, this.txtNAME.Text, Convert.ToDecimal(this.calMaximumSalary.EditValue), this.cheIsByWorkDay.Checked, Convert.ToDouble(this.calIncomeTaxValue.EditValue), this.cheIsShowInSalaryTableList.Checked, this.txtDescription.Text);
                string str1 = dICALLOWANCE.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICALLOWANCE);
                }
                Cursor.Current = Cursors.Default;
                this.DoHide();
                if (str1 != "OK")
                {
                    XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                str = str1;
            }
            else
            {
                MyRule.Notify();
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiAllowance") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
             //   SYS_LOG.Insert("Danh Mục Phụ Cấp", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
                dICALLOWANCE.Get(this.txtID.Text);
                DIC_ALLOWANCE dICALLOWANCE1 = new DIC_ALLOWANCE(this.txtID.Text, this.txtNAME.Text, Convert.ToDecimal(this.calMaximumSalary.EditValue), this.cheIsByWorkDay.Checked, Convert.ToDouble(this.calIncomeTaxValue.EditValue), this.cheIsShowInSalaryTableList.Checked, this.txtDescription.Text);
                string str1 = dICALLOWANCE1.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(dICALLOWANCE1);
                    if ((dICALLOWANCE.IsByWorkDay != dICALLOWANCE1.IsByWorkDay ? true : dICALLOWANCE.IncomeTaxValue != dICALLOWANCE1.IncomeTaxValue))
                    {
                        if (XtraMessageBox.Show("Bạn có muốn thay đổi thông tin phụ cấp của tất cả nhân viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            this.DoHide();
                            str = "";
                            return str;
                        }
                        dICALLOWANCE1.UpdateEmployeeAllowance(dICALLOWANCE1.AllowanceCode, this.cheIsByWorkDay.Checked, Convert.ToDouble(this.calIncomeTaxValue.EditValue));
                    }
                }
                if (str1 != "OK")
                {
                    XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.DoHide();
                str = str1;
            }
            else
            {
                MyRule.Notify();
                str = "";
            }
            return str;
        }

        public event xucAllowanceAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, DIC_ALLOWANCE item);

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            if (this.m_Status == Actions.Add)
            {
                if ((new DIC_ALLOWANCE()).Exist(textEdit.Text))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }

        private void txtID_KeyDown_1(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                DIC_ALLOWANCE dICALLOWANCE = new DIC_ALLOWANCE();
                if (this.m_Status == Actions.Add)
                {
                    if (dICALLOWANCE.Exist(textEdit.Text))
                    {
                        this.Err.SetError(textEdit, "Mã đã tồn tại.");
                        textEdit.Focus();
                    }
                }
            }
        }
    }
}
