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
    public partial class xucSubsidiaryAdd : xucBaseAdd
    {
        public xucSubsidiaryAdd()
        {
            InitializeComponent();
         
            this.calMinimumSalary.EditValue = 0;
            this.txtQuantity.Text = "0";
            this.txtFactQuantity.Text = "0";
        }


     

        protected override void Add()
        {
            base.Add();
            HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY();
            this.txtID.Text = hRMSUBSIDIARY.NewID();
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

        public HRM_SUBSIDIARY InitClass()
        {
            HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY()
            {
                SubsidiaryCode = this.txtID.Text,
                SubsidiaryName = this.txtNAME.Text,
                Address = this.txtAddress.Text,
                Phone = this.txtPhone.Text,
                Fax = this.txtFax.Text,
                WebSite = this.txtWebSite.Text,
                Email = this.txtEmail.Text,
                Tax = this.txtTax.Text,
                BankAccount = this.txtBankAccount.Text,
                OpenedAt = this.txtOpenedAt.Text,
                BankAbbreviationName = this.txtBankAbbreviationName.Text,
                BankBranch = this.txtBankBranch.Text,
                MinimumSalary = decimal.Parse(this.calMinimumSalary.EditValue.ToString()),
                PersonName = this.txtPersonName.Text,
                Quantity = int.Parse(this.txtQuantity.EditValue.ToString()),
                FactQuantity = int.Parse(this.txtFactQuantity.EditValue.ToString()),
                Description = this.txtDescription.Text
            };
            return hRMSUBSIDIARY;
        }


        private void InitMultiLanguages()
        {
            this.lblId.Text = this.lblId.Text;
            this.lblName.Text =  this.lblName.Text;
        }

        private void RaiseSuccessEventHander(HRM_SUBSIDIARY item)
        {
            if (this.Success != null)
            {
                this.Success(this, item);
            }
        }

        public void SetData(HRM_SUBSIDIARY item)
        {
            this.txtID.Text = item.SubsidiaryCode;
          //  SYS_LOG.Insert("Danh Sách Công Ty Con", "Xem", this.txtID.Text);
            if (this.m_Status == Actions.Update)
            {
                this.txtID.Properties.ReadOnly = true;
            }
            this.txtNAME.Text = item.SubsidiaryName;
            this.txtAddress.Text = item.Address;
            this.txtPhone.Text = item.Phone;
            this.txtFax.Text = item.Fax;
            this.txtWebSite.Text = item.WebSite;
            this.txtEmail.Text = item.Email;
            this.txtTax.Text = item.Tax;
            this.txtBankAccount.Text = item.BankAccount;
            this.txtOpenedAt.Text = item.OpenedAt;
            this.txtBankAbbreviationName.Text = item.BankAbbreviationName;
            this.txtBankBranch.Text = item.BankBranch;
           // this.imgPhoto.Image = item.Photo;
            this.calMinimumSalary.EditValue = item.MinimumSalary;
            this.txtPersonName.Text = item.PersonName;
            this.txtQuantity.Text = item.Quantity.ToString();
            this.txtFactQuantity.Text = item.FactQuantity.ToString();
            this.txtDescription.Text = item.Description;
        }

     
        protected override void txtID_KeyDown(object sender, KeyEventArgs e)
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
            HRM_SUBSIDIARY hRMSUBSIDIARY = new HRM_SUBSIDIARY()
            {
                SubsidiaryCode = this.txtID.Text
            };
            string str = hRMSUBSIDIARY.Delete();
            if (str == "OK")
            {
                this.RaiseSuccessEventHander(hRMSUBSIDIARY);
            }
            return str;
        }

        protected override string uc_Save()
        {
            string str;
            if (MyRule.Get(MyLogin.RoleId, "bbiSubsidiary") != "OK")
            {
                str = "";
            }
            else if (!MyRule.AllowAdd)
            {
                MyRule.Notify();
                str = "";
            }
            else if (MyLogin.Level <= 0)
            {
             //   SYS_LOG.Insert("Danh Sách Công Ty Con", "Thêm", this.txtID.Text);
                base.SetWaitDialogCaption("Đang lưu dữ liệu...");
                Cursor.Current = Cursors.WaitCursor;
                HRM_SUBSIDIARY hRMSUBSIDIARY = this.InitClass();
                string str1 = hRMSUBSIDIARY.Insert();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMSUBSIDIARY);
                }
                Cursor.Current = Cursors.Default;
                this.DoHide();
                if (str1 != "OK")
                {
                    XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            //    str1 = hRMSUBSIDIARY.Update(this.txtID.Text, this.imgPhoto.Image);
                if (str1 != "OK")
                {
                    this.DoHide();
                }
                this.DoHide();
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
            if (MyRule.Get(MyLogin.RoleId, "bbiSubsidiary") != "OK")
            {
                str = "";
            }
            else if (MyRule.AllowEdit)
            {
              //  SYS_LOG.Insert("Danh Sách Công Ty Con", "Cập Nhật", this.txtID.Text);
                base.SetWaitDialogCaption("Đang cập nhật dữ liệu...");
                HRM_SUBSIDIARY hRMSUBSIDIARY = this.InitClass();
                string str1 = hRMSUBSIDIARY.Update();
                if (str1 == "OK")
                {
                    this.RaiseSuccessEventHander(hRMSUBSIDIARY);
                }
                if (str1 != "OK")
                {
                    XtraMessageBox.Show(str1, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               // str1 = hRMSUBSIDIARY.Update(this.txtID.Text, this.imgPhoto.Image);
                if (str1 != "OK")
                {
                    this.DoHide();
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

        public event xucSubsidiaryAdd.SuccessEventHander Success;

        public delegate void SuccessEventHander(object sender, HRM_SUBSIDIARY item);

        private void txtID_EditValueChanged_1(object sender, EventArgs e)
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
    }
}
