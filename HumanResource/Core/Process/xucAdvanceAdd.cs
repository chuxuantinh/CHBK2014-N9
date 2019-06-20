using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using CHBK2014_N9.Common;
using CHBK2014_N9.ERP;
using CHBK2014_N9.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace CHBK2014_N9.HumanResource.Core.Process
{
    public partial class xucAdvanceAdd : xucBaseAddH
    {

        private Guid m_AdvanceID = Guid.Empty;

        private string m_EmployeeCode = "";
        public xucAdvanceAdd()
        {
            InitializeComponent();
            this.InitData();
            this.InitComponent();
        }

        protected override void Add()
        {
            base.Add();
            HRM_PROCESS_ADVANCE hRMPROCESSADVANCE = new HRM_PROCESS_ADVANCE();
        }

        public new void Clear()
        {
            this.txtReason.Text = "";
        }

        private void glkEmployeeCode_EditValueChanged(object sender, EventArgs e)
        {
            this.m_EmployeeCode = this.glkEmployeeCode.EditValue.ToString();
            this.LoadEmployeeInformation();
        }



        protected override void Init()
        {
        }

        private void InitComponent()
        {
            this.calMoney.Text = "0";
            this.dtDate.DateTime = DateTime.Now;
        }

        private void InitData()
        {
            (new HRM_EMPLOYEE()).AddGridLookupEdit(this.glkEmployeeCode);
        }


        private void LoadEmployeeInformation()
        {
            HRM_EMPLOYEE hRMEMPLOYEE = new HRM_EMPLOYEE();
            hRMEMPLOYEE.Get(this.m_EmployeeCode);
            GroupControl groupControl = this.grInformation;
            string[] employeeCode = new string[] { "Thông Tin Tạm Ứng - ", hRMEMPLOYEE.EmployeeCode, " (", hRMEMPLOYEE.FirstName, " ", hRMEMPLOYEE.LastName, ")" };
            groupControl.Text = string.Concat(employeeCode);
            this.txtEmployeeName.Text = string.Concat(hRMEMPLOYEE.FirstName, " ", hRMEMPLOYEE.LastName);
        }

        private void RaiseSuccessEventHander(HRM_PROCESS_ADVANCE item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetCode(string EmployeeCode)
        {
            this.m_EmployeeCode = EmployeeCode;
            if (this.m_EmployeeCode != "")
            {
                this.glkEmployeeCode.EditValue = this.m_EmployeeCode;
                this.LoadEmployeeInformation();
            }
        }

        public void SetData(HRM_PROCESS_ADVANCE item)
        {
            this.m_AdvanceID = item.AdvanceID;
          //  SYS_LOG.Insert("Quá Trình Tạm Ứng", "Xem", this.m_AdvanceID.ToString());
            this.m_EmployeeCode = item.EmployeeCode;
            this.glkEmployeeCode.EditValue = this.m_EmployeeCode;
            this.glkEmployeeCode.Enabled = false;
            this.txtReason.Text = item.Reason;
            this.dtDate.DateTime = item.Date;
            this.calMoney.Text = item.Money.ToString();
            this.cboPerson.Text = item.Person;
            this.LoadEmployeeInformation();
        }

        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            HRM_PROCESS_ADVANCE hRMPROCESSADVANCE = new HRM_PROCESS_ADVANCE()
            {
                AdvanceID = this.m_AdvanceID
            };
            string str = hRMPROCESSADVANCE.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(hRMPROCESSADVANCE);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiProcessAdvance") != "OK")
            {
                str = "";
            }
            else if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                str = "";
            }
            else if (!(this.m_EmployeeCode == ""))
            {
              //  SYS_LOG.Insert("Quá Trình Tạm Ứng", "Thêm", this.m_AdvanceID.ToString());
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                HRM_PROCESS_ADVANCE hRMPROCESSADVANCE = new HRM_PROCESS_ADVANCE()
                {
                    AdvanceID = Guid.NewGuid(),
                    EmployeeCode = this.m_EmployeeCode,
                    Reason = this.txtReason.Text,
                    Date = this.dtDate.DateTime,
                    Money = decimal.Parse(this.calMoney.Text.ToString()),
                    Person = this.cboPerson.Text
                };
                string str1 = hRMPROCESSADVANCE.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMPROCESSADVANCE);
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
                XtraMessageBox.Show("Vui lòng chọn nhân viên để lưu dữ liệu!", "Thông Báo", MessageBoxButtons.OK);
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiProcessAdvance") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
              //  SYS_LOG.Insert("Quá Trình Tạm Ứng", "Cập Nhật", this.m_AdvanceID.ToString());
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                HRM_PROCESS_ADVANCE hRMPROCESSADVANCE = new HRM_PROCESS_ADVANCE()
                {
                    AdvanceID = this.m_AdvanceID,
                    EmployeeCode = this.m_EmployeeCode,
                    Reason = this.txtReason.Text,
                    Date = this.dtDate.DateTime,
                    Money = decimal.Parse(this.calMoney.Text.ToString()),
                    Person = this.cboPerson.Text
                };
                string str1 = hRMPROCESSADVANCE.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMPROCESSADVANCE);
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

        public event xucAdvanceAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, HRM_PROCESS_ADVANCE item);

    }

}

