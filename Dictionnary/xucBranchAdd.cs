using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class xucBranchAdd :xucBaseAdd
    {
        public xucBranchAdd()
        {
            InitializeComponent();

        
            this.InitData();
            this.calMinimumSalary.EditValue = 0;
            this.txtQuantity.Text = "0";
            this.txtFactQuantity.Text = "0";
        }

        protected override void Add()
        {
            base.Add();
            HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
            this.txtID.Text = hRMBRANCH.NewID();
            this.txtNAME.Focus();
        }

        public new void Clear()
        {
            this.txtID.Text = "";
            this.txtNAME.Text = "";
            this.txtAddress.Text = "";
            this.txtPhone.Text = "";
            this.calMinimumSalary.EditValue = 0;
            this.txtFax.Text = "";
            this.txtQuantity.Text = "0";
            this.txtFactQuantity.Text = "0";
            this.txtDescription.Text = "";
        }


        protected override void Init()
        {


        }

        private HRM_BRANCH InitClass()
        {
            HRM_BRANCH hRMBRANCH = new HRM_BRANCH()
            {
                BranchCode = this.txtID.Text,
                SubsidiaryCode = (this.glkSubsidiary.EditValue == null ? "" : this.glkSubsidiary.EditValue.ToString()),
                BranchName = this.txtNAME.Text,
                Address = this.txtAddress.Text,
                Phone = this.txtPhone.Text,
                Fax = this.txtFax.Text,
                MinimumSalary = decimal.Parse(this.calMinimumSalary.EditValue.ToString()),
                PersonName = this.txtPersonName.Text,
                Quantity = int.Parse(this.txtQuantity.Text),
                Description = this.txtDescription.Text
            };
            return hRMBRANCH;
        }

        private void InitData()
        {
            (new HRM_SUBSIDIARY()).AddGridLookupEdit(this.glkSubsidiary);
        }



        private void RaiseSuccessEventHander(HRM_BRANCH item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(HRM_BRANCH item)
        {
            this.txtID.Text = item.BranchCode;
         //   SYS_LOG.Insert("Danh Sách Chi Nhánh", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.glkSubsidiary.EditValue = item.SubsidiaryCode;
            this.txtNAME.Text = item.BranchName;
            this.txtAddress.Text = item.Address;
            this.txtPhone.Text = item.Phone;
            this.txtFax.Text = item.Fax;
            this.calMinimumSalary.EditValue = item.MinimumSalary;
            this.txtPersonName.Text = item.PersonName;
            this.txtQuantity.Text = item.Quantity.ToString();
            this.txtFactQuantity.Text = item.FactQuantity.ToString();
            this.txtDescription.Text = item.Description;
        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.ErrorText != string.Empty)
            {
                this.Err.SetError(textEdit, string.Empty);
            }
            HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
            HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
            HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
            HRM_GROUP hRMGROUP = new HRM_GROUP();
            if (this.m_Status == Actions.Add)
            {
                if ((hRMBRANCH.Exist(textEdit.Text) || hRMSUBSIDIARY.Exist(textEdit.Text) || hRMDEPARTMENT.Exist(textEdit.Text) ? true : hRMGROUP.Exist(textEdit.Text)))
                {
                    this.Err.SetError(textEdit, "Mã đã tồn tại.");
                    textEdit.Focus();
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (e.KeyCode == Keys.Return | e.KeyCode == Keys.Tab)
            {
                HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
                HRM_BRANCH hRMBRANCH = new HRM_BRANCH();
                HRM_DEPARTMENT hRMDEPARTMENT = new HRM_DEPARTMENT();
                HRM_GROUP hRMGROUP = new HRM_GROUP();
                if (this.m_Status == Actions.Add)
                {
                    if ((hRMBRANCH.Exist(textEdit.Text) || hRMSUBSIDIARY.Exist(textEdit.Text) || hRMDEPARTMENT.Exist(textEdit.Text) ? true : hRMGROUP.Exist(textEdit.Text)))
                    {
                        this.Err.SetError(textEdit, "Mã đã tồn tại.");
                        textEdit.Focus();
                    }
                }
            }
        }


        protected override string uc_Change()
        {
            return string.Empty;
        }

        protected override string uc_Delete()
        {
            HRM_BRANCH hRMBRANCH = new HRM_BRANCH()
            {
                BranchCode = this.txtID.Text
            };
            string str = hRMBRANCH.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(hRMBRANCH);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiBranch") != "OK")
            {
                str = "";
            }
            else if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                str = "";
            }
            else if (MyLogin.Level <= 1)
            {
               // SYS_LOG.Insert("Danh Sách Chi Nhánh", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                HRM_BRANCH hRMBRANCH = this.InitClass();
                string str1 = hRMBRANCH.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMBRANCH);
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
                XtraMessageBox.Show("Cấp độ quản lý của bạn không được phép thêm chi nhánh!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                str = "";
            }
            return str;
        }

        protected override string uc_Update()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiBranch") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
             //   SYS_LOG.Insert("Danh Sách Chi Nhánh", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                HRM_BRANCH hRMBRANCH = this.InitClass();
                string str1 = hRMBRANCH.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMBRANCH);
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

        public event xucBranchAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, HRM_BRANCH item);
    }
}
